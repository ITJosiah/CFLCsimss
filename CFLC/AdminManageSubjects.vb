Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class AdminManageSubjects
    Public Property IsEmbedded As Boolean = False
    Private currentSubjectID As Integer = 0

    ' Define the current school year (you might want to make this configurable)
    Private currentSchoolYearStart As Date = New Date(2025, 8, 1) ' August 2025
    Private currentSchoolYearEnd As Date = New Date(2026, 5, 31) ' May 2026

    ' Event to notify when subject count changes
    Public Event SubjectCountChanged(count As Integer)

    ' Public method to get current subject count
    Public Function GetSubjectCount() As Integer
        If dgvSubjectList IsNot Nothing AndAlso dgvSubjectList.DataSource IsNot Nothing Then
            Dim dt As DataTable = TryCast(dgvSubjectList.DataSource, DataTable)
            If dt IsNot Nothing Then
                Return dt.Rows.Count
            End If
            Return dgvSubjectList.Rows.Count
        End If
        Return 0
    End Function

    Private Sub AdminManageSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            StyleSidebarButtons()
            PositionSidebarButtons()
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Else
            pnlSidebar.Visible = False
            pnlManSubContent.Dock = DockStyle.Fill
        End If


        ' Initialize Category ComboBox
        InitializeCategoryComboBox()

        ' Initialize Status ComboBox (CHANGED FROM TEXTBOX)
        InitializeStatusComboBox()

        ' Initialize Room Type ComboBox
        InitializeRoomTypeComboBox()

        ' Set default dates
        dtpManSubStartDate.Value = DateTime.Now
        dtpManSubEndDate.Value = DateTime.Now.AddMonths(6) ' Default 6-month duration

        ' Load subjects data
        LoadToDGV("SELECT * FROM subject", dgvSubjectList)

        ' Set DateCreated to current date and make it readonly
        dtpManSubDateCreated.Value = DateTime.Now
        dtpManSubDateCreated.Enabled = False

        ' Set CreatedBy to current user (you might want to get this from your authentication system)
        txtbxManSubCreatedBy.Clear()

        ' Ensure Add button is enabled by default
        btnSubjectAdd.Enabled = True

        ' nud readable only
        Dim txt = DirectCast(nudManSubGradeLevel.Controls(1), TextBox)
        txt.Enabled = False

        ' Ensure the grid doesn't auto-select the first row on load
        dgvSubjectList.ClearSelection()
        Try
            If dgvSubjectList.Rows.Count > 0 AndAlso dgvSubjectList.Columns.Count > 0 Then
                dgvSubjectList.CurrentCell = Nothing
            End If
        Catch
            ' ignore potential layout timing exceptions
        End Try
        currentSubjectID = 0
    End Sub

    Private Sub InitializeCategoryComboBox()
        ' Populate Category dropdown and make it a DropDownList (no typing allowed)
        cmbSubjectCategory.Items.Clear()
        cmbSubjectCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSubjectCategory.Items.Add("Core")
        cmbSubjectCategory.Items.Add("Special")

    End Sub

    Private Sub InitializeStatusComboBox()
        ' Populate Status dropdown - CHANGED TO COMBOBOX
        ComboBoxSubjectStatus.Items.Clear() ' CHANGED FROM txtbxManSubStatus
        ComboBoxSubjectStatus.Items.Add("Active")
        ComboBoxSubjectStatus.Items.Add("Inactive")
        ComboBoxSubjectStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxSubjectStatus.Enabled = False ' Make it read-only since it's auto-determined
    End Sub

    Private Sub InitializeRoomTypeComboBox()
        ' Populate Room Type dropdown and make it a DropDownList (no typing allowed)
        cbxManSubRoomType.Items.Clear()
        cbxManSubRoomType.DropDownStyle = ComboBoxStyle.DropDownList
        cbxManSubRoomType.Items.Add("Regular Classroom")
        cbxManSubRoomType.Items.Add("Science Lab")
        cbxManSubRoomType.Items.Add("Covered Court/Workshop")
    End Sub

    ' ===== DATE-BASED STATUS CALCULATION METHODS =====

    Private Function CalculateStatusBasedOnDates(startDate As Date, endDate As Date) As String
        Dim today As Date = DateTime.Today

        ' If subject dates fall within current school year, it's active
        If startDate <= currentSchoolYearEnd AndAlso endDate >= currentSchoolYearStart Then
            ' Check if currently within the subject's date range
            If today >= startDate AndAlso today <= endDate Then
                Return "Active"
            Else
                Return "Inactive"
            End If
        Else
            ' Subject dates don't overlap with current school year
            Return "Inactive"
        End If
    End Function

    Private Sub AutoSetStatusBasedOnDates()
        Dim calculatedStatus As String = CalculateStatusBasedOnDates(dtpManSubStartDate.Value, dtpManSubEndDate.Value)
        ComboBoxSubjectStatus.SelectedItem = calculatedStatus
    End Sub

    ' ===== DATE EVENT HANDLERS =====

    Private Sub dtpManSubStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpManSubStartDate.ValueChanged
        ' Auto-update status when dates change (only for new subjects)
        If currentSubjectID = 0 Then
            AutoSetStatusBasedOnDates()
        End If
    End Sub

    Private Sub dtpManSubEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpManSubEndDate.ValueChanged
        ' Auto-update status when dates change (only for new subjects)
        If currentSubjectID = 0 Then
            AutoSetStatusBasedOnDates()
        End If
    End Sub

    ' ===== MAIN SUBJECT OPERATIONS =====

    Private Sub btnSubjectAdd_Click(sender As Object, e As EventArgs) Handles btnSubjectAdd.Click
        ' If a row is currently selected, prevent adding and show error
        If currentSubjectID <> 0 Then
            MessageBox.Show("Please clear the selection before adding a new subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Automatically set status based on dates BEFORE validation
        AutoSetStatusBasedOnDates()

        ' Validate required fields FIRST
        If Not ValidateSubjectInputs() Then
            Return ' Stop execution if validation fails
        End If

        ' Check if SubjectCode already exists
        If SubjectCodeExists(txtbxManSubSubjectCode.Text.Trim()) Then
            MessageBox.Show("Subject Code already exists. Please use a unique Subject Code.", "Duplicate Subject Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Add subject to database
        Try
            Dim query As String = "INSERT INTO subject (" &
                "SubjectCode, SubjectName, Category, Description, SkillFocus, " &
                "GradeLevel, RoomType, LearningMaterials, Schedule, " &
                "Status, DateCreated, CreatedBy, TeacherID, StartDate, EndDate" &
                ") VALUES (" &
                "@SubjectCode, @SubjectName, @Category, @Description, @SkillFocus, " &
                "@GradeLevel, @RoomType, @LearningMaterials, @Schedule, " &
                "@Status, @DateCreated, @CreatedBy, @TeacherID, @StartDate, @EndDate)"

            modDBx.openConn(modDBx.db_name)

            Using cmd As New MySqlCommand(query, modDBx.conn)
                ' Subject Information
                cmd.Parameters.AddWithValue("@SubjectCode", txtbxManSubSubjectCode.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("@SubjectName", ConvertToProperCase(SafeString(txtbxManSubSubjectName.Text)))

                Dim category As String = ""
                If cmbSubjectCategory.SelectedItem IsNot Nothing Then
                    category = cmbSubjectCategory.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Category", category)

                cmd.Parameters.AddWithValue("@Description", SafeString(txtbxManSubDescription.Text))
                cmd.Parameters.AddWithValue("@SkillFocus", SafeString(txtbxManSubSkillFocus.Text))

                ' Grade Level
                cmd.Parameters.AddWithValue("@GradeLevel", nudManSubGradeLevel.Value)

                ' Room Type
                Dim roomType As String = ""
                If cbxManSubRoomType.SelectedItem IsNot Nothing Then
                    roomType = cbxManSubRoomType.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@RoomType", roomType)

                ' Learning Materials and Schedule
                cmd.Parameters.AddWithValue("@LearningMaterials", SafeString(txtbxManSubLearningMaterials.Text))
                cmd.Parameters.AddWithValue("@Schedule", SafeString(txtbxManSubSchedule.Text))

                ' Status - Auto-determined based on dates
                Dim status As String = ""
                If ComboBoxSubjectStatus.SelectedItem IsNot Nothing Then
                    status = ComboBoxSubjectStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Status", status)

                ' Date Information
                cmd.Parameters.AddWithValue("@DateCreated", dtpManSubDateCreated.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@CreatedBy", SafeString(txtbxManSubCreatedBy.Text))
                cmd.Parameters.AddWithValue("@StartDate", dtpManSubStartDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@EndDate", dtpManSubEndDate.Value.ToString("yyyy-MM-dd"))

                cmd.Parameters.AddWithValue("@TeacherID", If(String.IsNullOrWhiteSpace(txtbxManSubTeacherID.Text), DBNull.Value, CInt(txtbxManSubTeacherID.Text)))

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    ' Log the addition
                    Try
                        Dim subjectInfo As String = "Subject Code: " & txtbxManSubSubjectCode.Text.Trim() & ", Subject Name: " & ConvertToProperCase(SafeString(txtbxManSubSubjectName.Text))
                        modDBx.Logs("Added subject - " & subjectInfo, "btnSubjectAdd_Click")
                    Catch
                        ' Silently fail if logging doesn't work
                    End Try

                    MessageBox.Show("Subject added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInputFields()
                    LoadToDGV("SELECT * FROM subject", dgvSubjectList)
                Else
                    MessageBox.Show("Failed to add subject. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSubjectDelete_Click(sender As Object, e As EventArgs) Handles btnSubjectDelete.Click
        ' Check if a subject is selected
        If currentSubjectID = 0 Then
            MessageBox.Show("Please select a subject to delete.", "Delete Subject", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Confirm deletion
        If MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Try
            ' Open database connection
            modDBx.openConn(modDBx.db_name)

            ' Prepare the DELETE SQL statement
            Dim sql As String = "DELETE FROM subject WHERE SubjectID = @SubjectID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@SubjectID", currentSubjectID)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    ' Log the deletion
                    Try
                        Dim subjectInfo As String = "Subject ID: " & currentSubjectID.ToString()
                        modDBx.Logs("Deleted subject - " & subjectInfo, "btnSubjectDelete_Click")
                    Catch
                        ' Silently fail if logging doesn't work
                    End Try

                    MessageBox.Show("Subject deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Refresh the DataGridView
                    LoadToDGV("SELECT * FROM subject", dgvSubjectList)
                    ' Reset current selection and clear input fields
                    currentSubjectID = 0
                    ClearInputFields()
                Else
                    MessageBox.Show("No subject was deleted. Please check your selection.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error deleting subject: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection safely
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSubjectUpdate_Click(sender As Object, e As EventArgs) Handles btnSubjectUpdate.Click
        UpdateSubject()
    End Sub

    Private Sub UpdateSubject()
        ' Check if a subject is selected
        If currentSubjectID = 0 Then
            MessageBox.Show("No subject selected for update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' For existing subjects, allow manual status override but show warning if dates don't match
        Dim calculatedStatus As String = CalculateStatusBasedOnDates(dtpManSubStartDate.Value, dtpManSubEndDate.Value)
        Dim selectedStatus As String = If(ComboBoxSubjectStatus.SelectedItem IsNot Nothing, ComboBoxSubjectStatus.SelectedItem.ToString(), "")

        If selectedStatus <> calculatedStatus Then
            Dim result As DialogResult = MessageBox.Show(
                "The selected status doesn't match the date range." & vbCrLf &
                "Calculated status based on dates: " & calculatedStatus & vbCrLf & vbCrLf &
                "Do you want to keep the manually selected status?" & vbCrLf &
                "Yes = Keep manual status" & vbCrLf &
                "No = Use calculated status based on dates",
                "Status Mismatch",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

            If result = DialogResult.No Then
                ComboBoxSubjectStatus.SelectedItem = calculatedStatus
            End If
        End If

        ' Validate required fields FIRST using the same validation as Add
        If Not ValidateSubjectInputs() Then
            Return ' Stop execution if validation fails
        End If

        ' Check if SubjectCode already exists (excluding current subject)
        If SubjectCodeExists(txtbxManSubSubjectCode.Text.Trim(), currentSubjectID) Then
            MessageBox.Show("Subject Code already exists. Please use a unique Subject Code.", "Duplicate Subject Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if any data has actually changed
        If Not HasSubjectDataChanged() Then
            MessageBox.Show("No changes were made to the subject data.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            modDBx.openConn(modDBx.db_name)

            Dim Sql As String = "UPDATE subject SET " &
                "SubjectCode = @SubjectCode, " &
                "SubjectName = @SubjectName, " &
                "Category = @Category, " &
                "Description = @Description, " &
                "SkillFocus = @SkillFocus, " &
                "GradeLevel = @GradeLevel, " &
                "RoomType = @RoomType, " &
                "LearningMaterials = @LearningMaterials, " &
                "Schedule = @Schedule, " &
                "Status = @Status, " &
                "TeacherID = @TeacherID, " &
                "StartDate = @StartDate, " &
                "EndDate = @EndDate " &
                "WHERE SubjectID = @SubjectID"

            Using cmd As New MySqlCommand(Sql, modDBx.conn)
                ' Subject Informations
                cmd.Parameters.AddWithValue("@SubjectCode", txtbxManSubSubjectCode.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("@SubjectName", ConvertToProperCase(SafeString(txtbxManSubSubjectName.Text)))

                Dim category As String = ""
                If cmbSubjectCategory.SelectedItem IsNot Nothing Then
                    category = cmbSubjectCategory.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Category", category)

                cmd.Parameters.AddWithValue("@Description", SafeString(txtbxManSubDescription.Text))
                cmd.Parameters.AddWithValue("@SkillFocus", SafeString(txtbxManSubSkillFocus.Text))

                ' Grade Level
                cmd.Parameters.AddWithValue("@GradeLevel", nudManSubGradeLevel.Value)

                ' Room Type
                Dim roomType As String = ""
                If cbxManSubRoomType.SelectedItem IsNot Nothing Then
                    roomType = cbxManSubRoomType.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@RoomType", roomType)

                ' Learning Materials and Schedule
                cmd.Parameters.AddWithValue("@LearningMaterials", SafeString(txtbxManSubLearningMaterials.Text))
                cmd.Parameters.AddWithValue("@Schedule", SafeString(txtbxManSubSchedule.Text))

                ' Status
                Dim status As String = ""
                If ComboBoxSubjectStatus.SelectedItem IsNot Nothing Then
                    status = ComboBoxSubjectStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Status", status)

                ' Date Information
                cmd.Parameters.AddWithValue("@StartDate", dtpManSubStartDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@EndDate", dtpManSubEndDate.Value.ToString("yyyy-MM-dd"))

                cmd.Parameters.AddWithValue("@SubjectID", currentSubjectID)
                cmd.Parameters.AddWithValue("@TeacherID", If(String.IsNullOrWhiteSpace(txtbxManSubTeacherID.Text), DBNull.Value, CInt(txtbxManSubTeacherID.Text)))

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    ' Log the update
                    Try
                        Dim subjectInfo As String = "Subject ID: " & currentSubjectID.ToString() & ", Subject Code: " & txtbxManSubSubjectCode.Text.Trim()
                        modDBx.Logs("Updated subject - " & subjectInfo, "btnSubjectUpdate_Click")
                    Catch
                        ' Silently fail if logging doesn't work
                    End Try

                    MessageBox.Show("Subject updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Clear inputs and re-enable Add after successful update
                    ClearInputFields()
                    LoadToDGV("SELECT * FROM subject", dgvSubjectList)
                    currentSubjectID = 0
                Else
                    MessageBox.Show("No subject was updated. Please check the data.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error updating subject: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Function SubjectCodeExists(subjectCode As String, Optional excludeSubjectID As Integer = 0) As Boolean
        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT COUNT(*) FROM subject WHERE SubjectCode = @SubjectCode"

            If excludeSubjectID > 0 Then
                sql &= " AND SubjectID != @SubjectID"
            End If

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@SubjectCode", subjectCode)
                If excludeSubjectID > 0 Then
                    cmd.Parameters.AddWithValue("@SubjectID", excludeSubjectID)
                End If

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error checking subject code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True ' Return true to be safe and prevent potential duplicates
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    Private Function HasSubjectDataChanged() As Boolean
        ' Get the current subject data from database to compare
        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT * FROM subject WHERE SubjectID = @SubjectID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@SubjectID", currentSubjectID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Compare each field with current form values
                        If GetSafeStringFromDB(reader("SubjectCode")) <> txtbxManSubSubjectCode.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("SubjectName")) <> txtbxManSubSubjectName.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Category")) <> cmbSubjectCategory.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Description")) <> txtbxManSubDescription.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("SkillFocus")) <> txtbxManSubSkillFocus.Text.Trim() Then Return True
                        If Convert.ToInt32(reader("GradeLevel")) <> nudManSubGradeLevel.Value Then Return True
                        If GetSafeStringFromDB(reader("RoomType")) <> cbxManSubRoomType.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("LearningMaterials")) <> txtbxManSubLearningMaterials.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Schedule")) <> txtbxManSubSchedule.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Status")) <> ComboBoxSubjectStatus.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("TeacherID")) <> txtbxManSubTeacherID.Text.Trim() Then Return True

                        ' Check StartDate
                        If Not IsDBNull(reader("StartDate")) Then
                            Dim dbDate As DateTime = Convert.ToDateTime(reader("StartDate"))
                            If dbDate.Date <> dtpManSubStartDate.Value.Date Then Return True
                        Else
                            ' If DB is null but picker has a value, treat as change
                            If dtpManSubStartDate.Value <> Date.MinValue Then Return True
                        End If

                        ' Check EndDate
                        If Not IsDBNull(reader("EndDate")) Then
                            Dim dbDate As DateTime = Convert.ToDateTime(reader("EndDate"))
                            If dbDate.Date <> dtpManSubEndDate.Value.Date Then Return True
                        Else
                            If dtpManSubEndDate.Value <> Date.MinValue Then Return True
                        End If

                    End If
                End Using
            End Using

            Return False ' No changes detected

        Catch ex As Exception
            ' If we can't check for changes, assume there are changes to be safe
            Return True
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    Private Function ValidateSubjectInputs() As Boolean
        Dim errors As New List(Of String)

        ' 1. Basic Subject Information Validation
        If String.IsNullOrWhiteSpace(txtbxManSubSubjectCode.Text) Then
            errors.Add("• Subject Code is required")
        ElseIf txtbxManSubSubjectCode.Text.Trim().Length < 3 Then
            errors.Add("• Subject Code must be at least 3 characters long")
        End If

        ' 2. Subject Name Validation
        If String.IsNullOrWhiteSpace(txtbxManSubSubjectName.Text) Then
            errors.Add("• Subject Name is required")
        End If

        ' 3. Category Validation
        If cmbSubjectCategory.SelectedIndex = -1 Then
            errors.Add("• Category is required")
        End If

        ' 4. Skill Focus Validation
        If String.IsNullOrWhiteSpace(txtbxManSubSkillFocus.Text) Then
            errors.Add("• Skill Focus is required")
        End If

        ' 5 Grade Level Validation
        If nudManSubGradeLevel.Value < 1 Or nudManSubGradeLevel.Value > 6 Then
            errors.Add("• Grade Level must be between 1 and 6")
        End If

        ' 6. Status Validation
        If ComboBoxSubjectStatus.SelectedIndex = -1 Then
            errors.Add("• Status is required")
        End If

        ' 7. Room Type Validation
        If cbxManSubRoomType.SelectedIndex = -1 Then
            errors.Add("• Room Type is required")
        End If

        ' 8. Learning Materials Validation
        If String.IsNullOrWhiteSpace(txtbxManSubLearningMaterials.Text) Then
            errors.Add("• Learning Materials is required")
        End If

        ' 9. Schedule Validation
        If String.IsNullOrWhiteSpace(txtbxManSubSchedule.Text) Then
            errors.Add("• Schedule is required")
        End If

        ' 10. Date Validation
        If dtpManSubEndDate.Value < dtpManSubStartDate.Value Then
            errors.Add("• End Date cannot be earlier than Start Date")
        End If

        ' 11. Date Range Validation
        If dtpManSubStartDate.Value > currentSchoolYearEnd Or dtpManSubEndDate.Value < currentSchoolYearStart Then
            errors.Add("• Subject dates must overlap with the current school year")
        End If

        ' 12. Date Created Validation
        If dtpManSubDateCreated.Value > DateTime.Now Then
            errors.Add("• Date Created cannot be in the future")
        End If

        ' 13. Created By Validation
        If String.IsNullOrWhiteSpace(txtbxManSubCreatedBy.Text) Then
            errors.Add("• Created By is required")
        End If

        ' 14. Teacher ID Validation
        If String.IsNullOrWhiteSpace(txtbxManSubTeacherID.Text) Then
            errors.Add("• Teacher ID is required")
        End If


        ' 15. Teacher ID validation (optional but if provided, should be valid)
        If Not String.IsNullOrWhiteSpace(txtbxManSubTeacherID.Text) Then
            If Not Integer.TryParse(txtbxManSubTeacherID.Text, Nothing) Then
                errors.Add("• Teacher ID must be a valid number")
            ElseIf Not TeacherIDExists(txtbxManSubTeacherID.Text.Trim()) Then
                errors.Add("• Teacher ID does not exist in the system")
            End If
        End If

        ' 6. Check if there are any validation errors
        If errors.Count > 0 Then
            Dim errorMessage As New StringBuilder()
            errorMessage.AppendLine("Please fix the following errors before proceeding:")
            errorMessage.AppendLine()

            For Each [error] As String In errors
                errorMessage.AppendLine([error])
            Next

            MessageBox.Show(errorMessage.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    ' Keep the TeacherIDExists function for validation purposes
    Private Function TeacherIDExists(teacherID As String) As Boolean
        If String.IsNullOrWhiteSpace(teacherID) Then
            Return False
        End If

        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT COUNT(*) FROM teacher WHERE TeacherID = @TeacherID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@TeacherID", CInt(teacherID))
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error checking teacher ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    Private Function ConvertToProperCase(text As String) As String
        If String.IsNullOrWhiteSpace(text) Then
            Return text
        End If

        ' Convert to proper case (first letter uppercase, rest lowercase)
        Dim culture As New System.Globalization.CultureInfo("en-US")
        Dim textInfo As System.Globalization.TextInfo = culture.TextInfo

        Return textInfo.ToTitleCase(text.ToLower())
    End Function

    ' Helper function to safely handle string values
    Private Function SafeString(value As String) As String
        Return If(String.IsNullOrWhiteSpace(value), "", value.Trim().Replace("'", "''"))
    End Function

    ' Helper function for safe string retrieval from database
    Private Function GetSafeStringFromDB(dbValue As Object) As String
        Return If(dbValue Is Nothing OrElse IsDBNull(dbValue), "", dbValue.ToString())
    End Function

    Private Sub ClearInputFields()
        ' Clear all input fields after successful add or when un-selecting a row

        ' Subject Information
        txtbxManSubSubjectCode.Clear()
        txtbxManSubSubjectName.Clear()
        cmbSubjectCategory.SelectedIndex = -1
        txtbxManSubDescription.Clear()
        txtbxManSubSkillFocus.Clear()

        ' Grade Level
        nudManSubGradeLevel.Value = 0

        ' Room Type and Learning Materials
        cbxManSubRoomType.SelectedIndex = -1
        txtbxManSubLearningMaterials.Clear()
        txtbxManSubSchedule.Clear()

        ' Status - Auto-calculate based on default dates
        ComboBoxSubjectStatus.SelectedIndex = -1

        ' Reset dates to defaults
        dtpManSubStartDate.Value = DateTime.Now
        dtpManSubEndDate.Value = DateTime.Now.AddMonths(6)
        AutoSetStatusBasedOnDates() ' Calculate status for default dates

        ' Date and Created By (reset to defaults)
        dtpManSubDateCreated.Value = DateTime.Now
        txtbxManSubCreatedBy.Text = "" ' Reset to default or keep current user

        txtbxManSubTeacherID.Clear()

        ' Reset current subject selection
        currentSubjectID = 0

        ' Re-enable Add button so user can create a new record
        btnSubjectAdd.Enabled = True

        ' Set focus back to first field
        txtbxManSubSubjectCode.Focus()
    End Sub

    Private Sub dgvSubjectList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjectList.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvSubjectList.Rows(e.RowIndex)

        ' Safely read the SubjectID in the clicked row
        Dim clickedID As Integer = 0
        If row.Cells.Count > 0 AndAlso row.Cells(0).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(0).Value) Then
            Integer.TryParse(row.Cells(0).Value.ToString(), clickedID)
        End If

        ' If the user clicked the already-selected row, clear selection and inputs
        If clickedID <> 0 AndAlso clickedID = currentSubjectID Then
            dgvSubjectList.ClearSelection()
            currentSubjectID = 0
            ClearInputFields()
            Return
        End If

        ' Otherwise populate fields for the newly selected row
        If clickedID <> 0 Then
            currentSubjectID = clickedID

            txtbxManSubSubjectCode.Text = GetSafeString(row.Cells("SubjectCode"))
            txtbxManSubSubjectName.Text = GetSafeString(row.Cells("SubjectName"))
            cmbSubjectCategory.Text = GetSafeString(row.Cells("Category"))
            txtbxManSubDescription.Text = GetSafeString(row.Cells("Description"))
            txtbxManSubSkillFocus.Text = GetSafeString(row.Cells("SkillFocus"))

            If Not IsDBNull(row.Cells("GradeLevel").Value) Then
                nudManSubGradeLevel.Value = Convert.ToDecimal(row.Cells("GradeLevel").Value)
            End If

            cbxManSubRoomType.Text = GetSafeString(row.Cells("RoomType"))
            txtbxManSubLearningMaterials.Text = GetSafeString(row.Cells("LearningMaterials"))
            txtbxManSubSchedule.Text = GetSafeString(row.Cells("Schedule"))
            ComboBoxSubjectStatus.Text = GetSafeString(row.Cells("Status"))

            ' Load Date Information
            If Not IsDBNull(row.Cells("DateCreated").Value) Then
                dtpManSubDateCreated.Value = CDate(row.Cells("DateCreated").Value)
            End If

            ' Load StartDate and EndDate
            If Not IsDBNull(row.Cells("StartDate").Value) Then
                dtpManSubStartDate.Value = CDate(row.Cells("StartDate").Value)
            Else
                dtpManSubStartDate.Value = DateTime.Now
            End If

            If Not IsDBNull(row.Cells("EndDate").Value) Then
                dtpManSubEndDate.Value = CDate(row.Cells("EndDate").Value)
            Else
                dtpManSubEndDate.Value = DateTime.Now.AddMonths(6)
            End If

            txtbxManSubTeacherID.Text = GetSafeString(row.Cells("TeacherID"))
            txtbxManSubCreatedBy.Text = GetSafeString(row.Cells("CreatedBy"))

            ' For existing records, we show the stored status but enable manual override
            ComboBoxSubjectStatus.Enabled = True

            ' Keep Add button enabled
            btnSubjectAdd.Enabled = True
        End If
    End Sub

    ' Helper function for safe string retrieval from DataGridView
    Private Function GetSafeString(cell As DataGridViewCell) As String
        Return If(cell.Value Is Nothing OrElse IsDBNull(cell.Value), "", cell.Value.ToString())
    End Function

    ' Apply Proper Case when leaving text fields
    Private Sub txtbxManSubSubjectName_Leave(sender As Object, e As EventArgs) Handles txtbxManSubSubjectName.Leave
        If Not String.IsNullOrWhiteSpace(txtbxManSubSubjectName.Text) Then
            txtbxManSubSubjectName.Text = ConvertToProperCase(txtbxManSubSubjectName.Text.Trim())
        End If
    End Sub

    ' Ensure selection is cleared after any data binding operation
    Private Sub dgvSubjectList_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSubjectList.DataBindingComplete
        dgvSubjectList.ClearSelection()
        Try
            If dgvSubjectList.Rows.Count > 0 AndAlso dgvSubjectList.Columns.Count > 0 Then
                dgvSubjectList.CurrentCell = Nothing
            End If
        Catch
            ' ignore - layout timing may prevent clearing CurrentCell
        End Try

        ' Notify that subject count has changed
        RaiseEvent SubjectCountChanged(GetSubjectCount())
    End Sub

    ' Final fallback after form is shown
    Private Sub AdminManageSubjects_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dgvSubjectList.ClearSelection()
        Try
            If dgvSubjectList.Rows.Count > 0 AndAlso dgvSubjectList.Columns.Count > 0 Then
                dgvSubjectList.CurrentCell = Nothing
            End If
        Catch
        End Try

        ' Move focus to first input so the grid doesn't appear focused
        txtbxManSubSubjectCode.Focus()
    End Sub


    ' Allow typing "f" into the search TextBox while preventing the parent/dashboard full-screen handler.
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Dim keyOnly As Keys = keyData And Keys.KeyCode

        ' Find the deepest focused control inside the form
        Dim focused As Control = GetDeepestFocusedControl()

        ' If focused control is a TextBoxBase (TextBox or RichTextBox, etc.) and editable, handle F insertion
        If keyOnly = Keys.F AndAlso focused IsNot Nothing AndAlso TypeOf focused Is TextBoxBase Then
            Dim tbBase = DirectCast(focused, TextBoxBase)
            If tbBase.Enabled AndAlso Not tbBase.ReadOnly Then
                ' Determine character case using Shift and CapsLock
                Dim shiftPressed As Boolean = (Control.ModifierKeys And Keys.Shift) = Keys.Shift
                Dim capsOn As Boolean = Control.IsKeyLocked(Keys.CapsLock)
                Dim useUpper As Boolean = shiftPressed Xor capsOn
                Dim ch As Char = If(useUpper, "F"c, "f"c)

                ' Insert character respecting selection/replacement
                Dim s As String = tbBase.Text
                Dim selStart As Integer = tbBase.SelectionStart
                Dim selLen As Integer = tbBase.SelectionLength

                Dim before As String = If(selStart > 0, s.Substring(0, selStart), String.Empty)
                Dim afterIndex As Integer = Math.Min(selStart + selLen, s.Length)
                Dim after As String = If(afterIndex < s.Length, s.Substring(afterIndex), String.Empty)

                tbBase.Text = before & ch & after
                tbBase.SelectionStart = selStart + 1
                tbBase.SelectionLength = 0

                Return True ' consumed
            End If
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ' Walk ActiveControl chain to the deepest focused control
    Private Function GetDeepestFocusedControl() As Control
        Dim c As Control = Me.ActiveControl
        While c IsNot Nothing
            Dim container = TryCast(c, ContainerControl)
            If container IsNot Nothing AndAlso container.ActiveControl IsNot Nothing Then
                c = container.ActiveControl
            Else
                Exit While
            End If
        End While
        Return c
    End Function

    Private Sub SearchSubjectsByName(ByVal subjectName As String)
        ' If the search box is empty, load all subjects (default view)
        If String.IsNullOrWhiteSpace(subjectName) Then
            LoadToDGV("SELECT * FROM subject", dgvSubjectList)
            Return
        End If

        Try
            ' Open Connection
            modDBx.openConn(modDBx.db_name)

            ' Use prefix match so search is from the first letter to the last (incremental per-letter filter)
            Dim sql As String = "SELECT * FROM subject WHERE SubjectName LIKE @searchName OR SubjectCode LIKE @searchCode ORDER BY SubjectName"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                ' Use subjectName + '%' to match only names that start with the typed letters
                cmd.Parameters.AddWithValue("@searchName", subjectName.Trim() & "%")
                cmd.Parameters.AddWithValue("@searchCode", subjectName.Trim() & "%")

                Dim dt As New System.Data.DataTable
                Using adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                ' Ensure grid will generate columns for the DataTable if not already configured
                dgvSubjectList.AutoGenerateColumns = True
                dgvSubjectList.DataSource = dt
                dgvSubjectList.Refresh()

                ' Make sure any "id" column (SubjectID) is visible and placed as the first column
                For Each col As DataGridViewColumn In dgvSubjectList.Columns
                    Dim checkName As String = If(col.DataPropertyName, "").ToLower()
                    Dim checkHeader As String = If(col.HeaderText, "").ToLower()
                    If checkName.Contains("subjectid") OrElse checkName.Contains("id") OrElse checkHeader.Contains("subjectid") OrElse checkHeader.Contains("id") Then
                        col.Visible = True
                        col.HeaderText = "SubjectID"
                        col.DisplayIndex = 0
                        Exit For
                    End If
                Next

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("No subject found matching '" & subjectName & "'.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching subject: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = System.Data.ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub TextBoxSubjectSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSubjectSearch.TextChanged
        SearchSubjectsByName(TextBoxSubjectSearch.Text)
    End Sub

    ' Database helper method (assuming you have similar in your project)
    Private Sub LoadToDGV(sql As String, dgv As DataGridView)
        Try
            modDBx.openConn(modDBx.db_name)
            Dim dt As New System.Data.DataTable
            Using adapter As New MySqlDataAdapter(sql, modDBx.conn)
                adapter.Fill(dt)
            End Using

            ' Let the grid auto-generate columns from the DataTable (unless you intentionally use designer columns)
            dgv.AutoGenerateColumns = True
            dgv.DataSource = dt
            dgv.Refresh()

            ' Ensure any ID-like column (SubjectID) is visible and shown as first column
            For Each col As DataGridViewColumn In dgv.Columns
                Dim checkName As String = If(col.DataPropertyName, "").ToLower()
                Dim checkHeader As String = If(col.HeaderText, "").ToLower()
                If checkName.Contains("subjectid") OrElse checkName.Contains("id") OrElse checkHeader.Contains("subjectid") OrElse checkHeader.Contains("id") Then
                    col.Visible = True
                    col.HeaderText = "SubjectID"
                    col.DisplayIndex = 0
                    Exit For
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' Rest of your existing methods for sidebar...
    Private Sub PositionSidebarButtons()
        ' Position sidebar buttons vertically with better spacing
        Dim sidebarWidth As Integer = 250
        Dim sidebarPadding As Integer = 10 ' Padding on left and right sides
        Dim buttonHeight As Integer = 70 ' Slightly taller for better appearance
        Dim buttonSpacing As Integer = 50 ' More space between buttons for better visual separation
        Dim startTop As Integer = 60 ' More space from top
        Dim buttonWidth As Integer = 70
        ' Position each button with padding
        btnManageStudents.Top = startTop
        btnManageStudents.Left = sidebarPadding
        btnManageStudents.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageStudents.Height = buttonHeight

        btnManageTeachers.Top = btnManageStudents.Bottom + buttonSpacing
        btnManageTeachers.Left = sidebarPadding
        btnManageTeachers.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageTeachers.Height = buttonHeight

        btnManageSections.Top = btnManageTeachers.Bottom + buttonSpacing
        btnManageSections.Left = sidebarPadding
        btnManageSections.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageSections.Height = buttonHeight

        btnManageEnrollments.Top = btnManageSections.Bottom + buttonSpacing
        btnManageEnrollments.Left = sidebarPadding
        btnManageEnrollments.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageEnrollments.Height = buttonHeight

        btnManageSubjects.Top = btnManageEnrollments.Bottom + buttonSpacing
        btnManageSubjects.Left = sidebarPadding
        btnManageSubjects.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageSubjects.Height = buttonHeight

        btnGenerateReports.Top = btnManageSubjects.Bottom + buttonSpacing
        btnGenerateReports.Left = sidebarPadding
        btnGenerateReports.Width = sidebarWidth - (sidebarPadding * 2)
        btnGenerateReports.Height = buttonHeight

        ' Position logout button at the bottom with more spacing
        Dim logoutBottomPadding As Integer = 30 ' More space from bottom
        btnLogout.Top = Me.ClientSize.Height - buttonHeight - logoutBottomPadding
        btnLogout.Left = sidebarPadding
        btnLogout.Width = sidebarWidth - (sidebarPadding * 2)
        btnLogout.Height = buttonHeight
    End Sub

    Private Sub StyleSidebarButtons()
        Dim buttons() As Button = {
        btnManageStudents,
        btnManageTeachers,
        btnManageSections,
        btnManageEnrollments,
        btnManageSubjects,
        btnGenerateReports
    }

        For Each btn As Button In buttons
            btn.BackColor = Color.LightGray
            btn.ForeColor = Color.Black
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = Color.Gainsboro
            btn.Font = New Font(btn.Font.FontFamily, 15, FontStyle.Bold)
            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.Padding = New Padding(15, 0, 0, 0)
        Next

        btnLogout.BackColor = Color.Red
        btnLogout.ForeColor = Color.White
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btnLogout.Font = New Font(btnLogout.Font.FontFamily, 12, FontStyle.Bold)
        btnLogout.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub lblManSubCategory_Click(sender As Object, e As EventArgs) Handles lblManSubCategory.Click
        ' Handle label click if neededd
    End Sub

    Private Sub pnlManSubContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlManSubContent.Paint

    End Sub
End Class