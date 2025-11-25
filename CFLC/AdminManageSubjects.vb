Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class AdminManageSubjects
    Public Property IsEmbedded As Boolean = False
    Private currentSubjectID As Integer = 0

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

        ' Load subjects data
        LoadToDGV("SELECT * FROM subject", dgvSubjectList)

        ' Set DateCreated to current date and make it readonly
        dtpManSubDateCreated.Value = DateTime.Now
        dtpManSubDateCreated.Enabled = False

        ' Set CreatedBy to current user (you might want to get this from your authentication system)
        txtbxManSubCreatedBy.Text = "Admin" ' Replace with actual username

        ' Ensure Add button is enabled by default
        btnSubjectAdd.Enabled = True

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
        ' Populate Category dropdown
        cmbSubjectCategory.Items.Clear()
        cmbSubjectCategory.Items.Add("Core")
        cmbSubjectCategory.Items.Add("Major")
        cmbSubjectCategory.Items.Add("Elective")
        cmbSubjectCategory.Items.Add("Specialization")
    End Sub

    Private Sub InitializeStatusComboBox()
        ' Populate Status dropdown - CHANGED TO COMBOBOX
        ComboBoxSubjectStatus.Items.Clear() ' CHANGED FROM txtbxManSubStatus
        ComboBoxSubjectStatus.Items.Add("Active")
        ComboBoxSubjectStatus.Items.Add("Inactive")
        ComboBoxSubjectStatus.Items.Add("Under Review")
    End Sub

    Private Sub InitializeRoomTypeComboBox()
        ' Populate Room Type dropdown
        cbxManSubRoomType.Items.Clear()
        cbxManSubRoomType.Items.Add("Regular Classroom")
        cbxManSubRoomType.Items.Add("Laboratory")
        cbxManSubRoomType.Items.Add("Computer Lab")
        cbxManSubRoomType.Items.Add("Science Lab")
        cbxManSubRoomType.Items.Add("Workshop")
        cbxManSubRoomType.Items.Add("Audio-Visual Room")
    End Sub

    Private Sub btnSubjectAdd_Click(sender As Object, e As EventArgs) Handles btnSubjectAdd.Click
        ' If a row is currently selected, prevent adding and show error
        If currentSubjectID <> 0 Then
            MessageBox.Show("Please clear the selection before adding a new subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

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
                            "GradeLevel, Quarter, RoomType, LearningMaterials, Schedule, " &
                            "Status, CurriculumYear, DateCreated, CreatedBy" &
                            ") VALUES (" &
                            "@SubjectCode, @SubjectName, @Category, @Description, @SkillFocus, " &
                            "@GradeLevel, @Quarter, @RoomType, @LearningMaterials, @Schedule, " &
                            "@Status, @CurriculumYear, @DateCreated, @CreatedBy)"

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

                cmd.Parameters.AddWithValue("@Description", ConvertToProperCase(SafeString(txtbxManSubDescription.Text)))
                cmd.Parameters.AddWithValue("@SkillFocus", ConvertToProperCase(SafeString(txtbxManSubSkillFocus.Text)))

                ' Grade Level and Quarter
                cmd.Parameters.AddWithValue("@GradeLevel", nudManSubGradeLevel.Value)
                cmd.Parameters.AddWithValue("@Quarter", nudManSubQuarter.Value)

                ' Room Type
                Dim roomType As String = ""
                If cbxManSubRoomType.SelectedItem IsNot Nothing Then
                    roomType = cbxManSubRoomType.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@RoomType", roomType)

                ' Learning Materials and Schedule
                cmd.Parameters.AddWithValue("@LearningMaterials", ConvertToProperCase(SafeString(txtbxManSubLearningMaterials.Text)))
                cmd.Parameters.AddWithValue("@Schedule", SafeString(txtbxManSubSchedule.Text))

                ' Status - CHANGED TO COMBOBOX
                Dim status As String = ""
                If ComboBoxSubjectStatus.SelectedItem IsNot Nothing Then ' CHANGED FROM txtbxManSubStatus
                    status = ComboBoxSubjectStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Status", status)

                ' Curriculum Information
                cmd.Parameters.AddWithValue("@CurriculumYear", SafeString(txtbxManSubCurriculumYear.Text))
                cmd.Parameters.AddWithValue("@DateCreated", dtpManSubDateCreated.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@CreatedBy", SafeString(txtbxManSubCreatedBy.Text))

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
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

            Dim sql As String = "UPDATE subject SET " &
                "SubjectCode = @SubjectCode, " &
                "SubjectName = @SubjectName, " &
                "Category = @Category, " &
                "Description = @Description, " &
                "SkillFocus = @SkillFocus, " &
                "GradeLevel = @GradeLevel, " &
                "Quarter = @Quarter, " &
                "RoomType = @RoomType, " &
                "LearningMaterials = @LearningMaterials, " &
                "Schedule = @Schedule, " &
                "Status = @Status, " &
                "CurriculumYear = @CurriculumYear " &
                "WHERE SubjectID = @SubjectID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                ' Subject Information
                cmd.Parameters.AddWithValue("@SubjectCode", txtbxManSubSubjectCode.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("@SubjectName", ConvertToProperCase(SafeString(txtbxManSubSubjectName.Text)))

                Dim category As String = ""
                If cmbSubjectCategory.SelectedItem IsNot Nothing Then
                    category = cmbSubjectCategory.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Category", category)

                cmd.Parameters.AddWithValue("@Description", ConvertToProperCase(SafeString(txtbxManSubDescription.Text)))
                cmd.Parameters.AddWithValue("@SkillFocus", ConvertToProperCase(SafeString(txtbxManSubSkillFocus.Text)))

                ' Grade Level and Quarter
                cmd.Parameters.AddWithValue("@GradeLevel", nudManSubGradeLevel.Value)
                cmd.Parameters.AddWithValue("@Quarter", nudManSubQuarter.Value)

                ' Room Type
                Dim roomType As String = ""
                If cbxManSubRoomType.SelectedItem IsNot Nothing Then
                    roomType = cbxManSubRoomType.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@RoomType", roomType)

                ' Learning Materials and Schedule
                cmd.Parameters.AddWithValue("@LearningMaterials", ConvertToProperCase(SafeString(txtbxManSubLearningMaterials.Text)))
                cmd.Parameters.AddWithValue("@Schedule", SafeString(txtbxManSubSchedule.Text))

                ' Status - CHANGED TO COMBOBOX
                Dim status As String = ""
                If ComboBoxSubjectStatus.SelectedItem IsNot Nothing Then ' CHANGED FROM txtbxManSubStatus
                    status = ComboBoxSubjectStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Status", status)

                ' Curriculum Information
                cmd.Parameters.AddWithValue("@CurriculumYear", SafeString(txtbxManSubCurriculumYear.Text))

                cmd.Parameters.AddWithValue("@SubjectID", currentSubjectID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
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
                        If Convert.ToInt32(reader("Quarter")) <> nudManSubQuarter.Value Then Return True
                        If GetSafeStringFromDB(reader("RoomType")) <> cbxManSubRoomType.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("LearningMaterials")) <> txtbxManSubLearningMaterials.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Schedule")) <> txtbxManSubSchedule.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Status")) <> ComboBoxSubjectStatus.Text.Trim() Then Return True ' CHANGED
                        If GetSafeStringFromDB(reader("CurriculumYear")) <> txtbxManSubCurriculumYear.Text.Trim() Then Return True
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

        If String.IsNullOrWhiteSpace(txtbxManSubSubjectName.Text) Then
            errors.Add("• Subject Name is required")
        End If

        If cmbSubjectCategory.SelectedIndex = -1 Then
            errors.Add("• Category is required")
        End If

        ' 2. Grade Level and Quarter Validation
        If nudManSubGradeLevel.Value < 1 Or nudManSubGradeLevel.Value > 12 Then
            errors.Add("• Grade Level must be between 1 and 12")
        End If

        If nudManSubQuarter.Value < 1 Or nudManSubQuarter.Value > 4 Then
            errors.Add("• Quarter must be between 1 and 4")
        End If

        ' 3. Room Type Validation
        If cbxManSubRoomType.SelectedIndex = -1 Then
            errors.Add("• Room Type is required")
        End If

        ' 4. Status Validation - CHANGED TO COMBOBOX
        If ComboBoxSubjectStatus.SelectedIndex = -1 Then ' CHANGED FROM txtbxManSubStatus
            errors.Add("• Status is required")
        End If

        ' 5. Curriculum Year Validation
        If String.IsNullOrWhiteSpace(txtbxManSubCurriculumYear.Text) Then
            errors.Add("• Curriculum Year is required")
        Else
            Dim curriculumYear As String = txtbxManSubCurriculumYear.Text.Trim()
            If curriculumYear.Length <> 9 OrElse Not curriculumYear.Contains("-") Then
                errors.Add("• Curriculum Year must be in format: YYYY-YYYY (e.g., 2023-2024)")
            ElseIf Not Integer.TryParse(curriculumYear.Substring(0, 4), Nothing) OrElse
                   Not Integer.TryParse(curriculumYear.Substring(5, 4), Nothing) Then
                errors.Add("• Curriculum Year must contain valid years")
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

        ' Grade Level and Quarter
        nudManSubGradeLevel.Value = 1
        nudManSubQuarter.Value = 1

        ' Room Type and Learning Materials
        cbxManSubRoomType.SelectedIndex = -1
        txtbxManSubLearningMaterials.Clear()
        txtbxManSubSchedule.Clear()

        ' Status and Curriculum - CHANGED TO COMBOBOX
        ComboBoxSubjectStatus.SelectedIndex = -1 ' CHANGED FROM txtbxManSubStatus
        txtbxManSubCurriculumYear.Clear()

        ' Date and Created By (reset to defaults)
        dtpManSubDateCreated.Value = DateTime.Now
        txtbxManSubCreatedBy.Text = "Admin" ' Reset to default or keep current user

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

            If Not IsDBNull(row.Cells("Quarter").Value) Then
                nudManSubQuarter.Value = Convert.ToDecimal(row.Cells("Quarter").Value)
            End If

            cbxManSubRoomType.Text = GetSafeString(row.Cells("RoomType"))
            txtbxManSubLearningMaterials.Text = GetSafeString(row.Cells("LearningMaterials"))
            txtbxManSubSchedule.Text = GetSafeString(row.Cells("Schedule"))
            ComboBoxSubjectStatus.Text = GetSafeString(row.Cells("Status")) ' CHANGED
            txtbxManSubCurriculumYear.Text = GetSafeString(row.Cells("CurriculumYear"))

            If Not IsDBNull(row.Cells("DateCreated").Value) Then
                dtpManSubDateCreated.Value = CDate(row.Cells("DateCreated").Value)
            End If

            txtbxManSubCreatedBy.Text = GetSafeString(row.Cells("CreatedBy"))

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

    Private Sub txtbxManSubDescription_Leave(sender As Object, e As EventArgs) Handles txtbxManSubDescription.Leave
        If Not String.IsNullOrWhiteSpace(txtbxManSubDescription.Text) Then
            txtbxManSubDescription.Text = ConvertToProperCase(txtbxManSubDescription.Text.Trim())
        End If
    End Sub

    Private Sub txtbxManSubSkillFocus_Leave(sender As Object, e As EventArgs) Handles txtbxManSubSkillFocus.Leave
        If Not String.IsNullOrWhiteSpace(txtbxManSubSkillFocus.Text) Then
            txtbxManSubSkillFocus.Text = ConvertToProperCase(txtbxManSubSkillFocus.Text.Trim())
        End If
    End Sub

    Private Sub txtbxManSubLearningMaterials_Leave(sender As Object, e As EventArgs) Handles txtbxManSubLearningMaterials.Leave
        If Not String.IsNullOrWhiteSpace(txtbxManSubLearningMaterials.Text) Then
            txtbxManSubLearningMaterials.Text = ConvertToProperCase(txtbxManSubLearningMaterials.Text.Trim())
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

                dgvSubjectList.DataSource = dt
                dgvSubjectList.Refresh()

                If dgvSubjectList.ColumnCount > 0 Then
                    dgvSubjectList.Columns(0).Visible = False ' Hide SubjectID column
                End If

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

            dgv.DataSource = dt
            dgv.Refresh()

            ' Hide the ID column if it exists
            If dgv.Columns.Count > 0 AndAlso dgv.Columns(0).Name.ToLower().Contains("id") Then
                dgv.Columns(0).Visible = False
            End If

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
        ' Handle label click if needed
    End Sub
End Class