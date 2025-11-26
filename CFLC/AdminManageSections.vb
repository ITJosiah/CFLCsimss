Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class AdminManageSections
    Public Property IsEmbedded As Boolean = False
    Private currentSectionID As Integer = 0

    Private Sub AdminManageSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            StyleSidebarButtons()
            PositionSidebarButtons()
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Else
            pnlSidebar.Visible = False
            pnlManSecContent.Dock = DockStyle.Fill
        End If

        ' Initialize ComboBoxes
        InitializeLearningModeComboBox()
        InitializeClassTypeComboBox()
        InitializeStatusComboBox()

        ' Load sections data
        LoadToDGV("SELECT * FROM section", dgvSections)

        ' Set DateCreated to current date and make it readonly
        dtpManSecDateCreated.Value = DateTime.Now
        dtpManSecDateCreated.Enabled = False

        ' Set CreatedBy to current user
        txtbxManSecCreatedBy.Text = "Admin" ' Replace with actual username

        ' Ensure Add button is enabled by default
        btnSectionAdd.Enabled = True

        ' Ensure the grid doesn't auto-select the first row on load
        dgvSections.ClearSelection()
        Try
            If dgvSections.Rows.Count > 0 AndAlso dgvSections.Columns.Count > 0 Then
                dgvSections.CurrentCell = Nothing
            End If
        Catch
            ' ignore potential layout timing exceptions
        End Try
        currentSectionID = 0
    End Sub

    Private Sub InitializeLearningModeComboBox()
        ' Populate Learning Mode dropdown
        cmbManSecLearningMode.Items.Clear()
        cmbManSecLearningMode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbManSecLearningMode.Items.Add("Face-to-Face")
        cmbManSecLearningMode.Items.Add("Online")
        cmbManSecLearningMode.Items.Add("Hybrid")
        cmbManSecLearningMode.Items.Add("Blended")
    End Sub

    Private Sub InitializeClassTypeComboBox()
        ' Populate Class Type dropdown
        cmbManSecClassType.Items.Clear()
        cmbManSecClassType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbManSecClassType.Items.Add("Regular")
        cmbManSecClassType.Items.Add("Honors")
        cmbManSecClassType.Items.Add("Advanced")
        cmbManSecClassType.Items.Add("Special Education")
        cmbManSecClassType.Items.Add("Accelerated")
    End Sub

    Private Sub InitializeStatusComboBox()
        ' Populate Status dropdown
        cbxManSecStatus.Items.Clear()
        cbxManSecStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbxManSecStatus.Items.Add("Active")
        cbxManSecStatus.Items.Add("Inactive")
        cbxManSecStatus.Items.Add("Planning")
        cbxManSecStatus.Items.Add("Completed")
        cbxManSecStatus.Items.Add("Cancelled")
    End Sub

    Private Sub btnSectionAdd_Click(sender As Object, e As EventArgs) Handles btnSectionAdd.Click
        ' If a row is currently selected, prevent adding and show error
        If currentSectionID <> 0 Then
            MessageBox.Show("Please clear the selection before adding a new section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate required fields FIRST
        If Not ValidateSectionInputs() Then
            Return ' Stop execution if validation fails
        End If

        ' Check if SectionName already exists
        If SectionNameExists(txtbxManSecSectionName.Text.Trim()) Then
            MessageBox.Show("Section Name already exists. Please use a unique Section Name.", "Duplicate Section Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Add section to database
        Try
            Dim query As String = "INSERT INTO section (" &
                            "SectionName, GradeLevel, TeacherID, RoomNo, LearningMode, " &
                            "ClassType, SchoolYear, StartDate, EndDate, Remarks, " &
                            "Schedule, Status, CreatedBy, DateCreated" &
                            ") VALUES (" &
                            "@SectionName, @GradeLevel, @TeacherID, @RoomNo, @LearningMode, " &
                            "@ClassType, @SchoolYear, @StartDate, @EndDate, @Remarks, " &
                            "@Schedule, @Status, @CreatedBy, @DateCreated)"

            modDBx.openConn(modDBx.db_name)

            Using cmd As New MySqlCommand(query, modDBx.conn)
                ' Section Information
                cmd.Parameters.AddWithValue("@SectionName", ConvertToProperCase(SafeString(txtbxManSecSectionName.Text)))
                cmd.Parameters.AddWithValue("@GradeLevel", nudManSecGradeLevel.Value)

                ' Teacher ID (optional field)
                Dim teacherID As String = SafeString(txtbxManSecTeacherID.Text)
                If String.IsNullOrWhiteSpace(teacherID) Then
                    cmd.Parameters.AddWithValue("@TeacherID", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@TeacherID", teacherID)
                End If

                cmd.Parameters.AddWithValue("@RoomNo", SafeString(txtbxManSecRoomNo.Text))
                cmd.Parameters.AddWithValue("@LBuildingName", SafeString(txtbxManSecBuildingName.Text))

                ' Learning Mode
                Dim learningMode As String = ""
                If cmbManSecLearningMode.SelectedItem IsNot Nothing Then
                    learningMode = cmbManSecLearningMode.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@LearningMode", learningMode)

                ' Class Type
                Dim classType As String = ""
                If cmbManSecClassType.SelectedItem IsNot Nothing Then
                    classType = cmbManSecClassType.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@ClassType", classType)

                ' School Year, Start Date, End Date

                cmd.Parameters.AddWithValue("@StartDate", dtpManSecStartDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@EndDate", dtpManSecEndDate.Value.ToString("yyyy-MM-dd"))

                ' Remarks and Schedule
                cmd.Parameters.AddWithValue("@Remarks", ConvertToProperCase(SafeString(txtbxManSecRemarks.Text)))
                cmd.Parameters.AddWithValue("@Schedule", SafeString(txtbxManSchedule.Text))

                ' Status
                Dim status As String = ""
                If cbxManSecStatus.SelectedItem IsNot Nothing Then
                    status = cbxManSecStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Status", status)

                ' Created By and Date Created
                cmd.Parameters.AddWithValue("@CreatedBy", SafeString(txtbxManSecCreatedBy.Text))
                cmd.Parameters.AddWithValue("@DateCreated", dtpManSecDateCreated.Value.ToString("yyyy-MM-dd"))

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Section added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInputFields()
                    LoadToDGV("SELECT * FROM section", dgvSections)
                Else
                    MessageBox.Show("Failed to add section. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnSectionDelete_Click(sender As Object, e As EventArgs) Handles btnSectionDelete.Click
        ' Check if a section is selected
        If currentSectionID = 0 Then
            MessageBox.Show("Please select a section to delete.", "Delete Section", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Confirm deletion
        If MessageBox.Show("Are you sure you want to delete this section?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Try
            ' Open database connection
            modDBx.openConn(modDBx.db_name)

            ' Prepare the DELETE SQL statement
            Dim sql As String = "DELETE FROM section WHERE SectionID = @SectionID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@SectionID", currentSectionID)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Section deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Refresh the DataGridView
                    LoadToDGV("SELECT * FROM section", dgvSections)
                    ' Reset current selection and clear input fields
                    currentSectionID = 0
                    ClearInputFields()
                Else
                    MessageBox.Show("No section was deleted. Please check your selection.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error deleting section: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection safely
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSectionUpdate_Click(sender As Object, e As EventArgs) Handles btnSectionUpdate.Click
        UpdateSection()
    End Sub

    Private Sub UpdateSection()
        ' Check if a section is selected
        If currentSectionID = 0 Then
            MessageBox.Show("No section selected for update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Validate required fields FIRST using the same validation as Add
        If Not ValidateSectionInputs() Then
            Return ' Stop execution if validation fails
        End If

        ' Check if SectionName already exists (excluding current section)
        If SectionNameExists(txtbxManSecSectionName.Text.Trim(), currentSectionID) Then
            MessageBox.Show("Section Name already exists. Please use a unique Section Name.", "Duplicate Section Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if any data has actually changed
        If Not HasSectionDataChanged() Then
            MessageBox.Show("No changes were made to the section data.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            modDBx.openConn(modDBx.db_name)

            Dim sql As String = "UPDATE section SET " &
                "SectionName = @SectionName, " &
                "GradeLevel = @GradeLevel, " &
                "TeacherID = @TeacherID, " &
                "RoomNo = @RoomNo, " &
                "LearningMode = @LearningMode, " &
                "ClassType = @ClassType, " &
                "BuildingName = @BuildingName, " &
                "StartDate = @StartDate, " &
                "EndDate = @EndDate, " &
                "Remarks = @Remarks, " &
                "Schedule = @Schedule, " &
                "Status = @Status " &
                "WHERE SectionID = @SectionID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                ' Section Information
                cmd.Parameters.AddWithValue("@SectionName", ConvertToProperCase(SafeString(txtbxManSecSectionName.Text)))
                cmd.Parameters.AddWithValue("@GradeLevel", nudManSecGradeLevel.Value)

                ' Teacher ID (optional field)
                Dim teacherID As String = SafeString(txtbxManSecTeacherID.Text)
                If String.IsNullOrWhiteSpace(teacherID) Then
                    cmd.Parameters.AddWithValue("@TeacherID", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@TeacherID", teacherID)
                End If

                cmd.Parameters.AddWithValue("@RoomNo", SafeString(txtbxManSecRoomNo.Text))
                cmd.Parameters.AddWithValue("@BuildingName", (txtbxManSecBuildingName.Text))

                ' Learning Mode
                Dim learningMode As String = ""
                If cmbManSecLearningMode.SelectedItem IsNot Nothing Then
                    learningMode = cmbManSecLearningMode.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@LearningMode", learningMode)

                ' Class Type
                Dim classType As String = ""
                If cmbManSecClassType.SelectedItem IsNot Nothing Then
                    classType = cmbManSecClassType.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@ClassType", classType)

                ' School Year, Start Date, End Date
                cmd.Parameters.AddWithValue("@StartDate", dtpManSecStartDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@EndDate", dtpManSecEndDate.Value.ToString("yyyy-MM-dd"))

                ' Remarks and Schedule
                cmd.Parameters.AddWithValue("@Remarks", ConvertToProperCase(SafeString(txtbxManSecRemarks.Text)))
                cmd.Parameters.AddWithValue("@Schedule", SafeString(txtbxManSchedule.Text))

                ' Status
                Dim status As String = ""
                If cbxManSecStatus.SelectedItem IsNot Nothing Then
                    status = cbxManSecStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Status", status)

                cmd.Parameters.AddWithValue("@SectionID", currentSectionID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Section updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Clear inputs and re-enable Add after successful update
                    ClearInputFields()
                    LoadToDGV("SELECT * FROM section", dgvSections)
                    currentSectionID = 0
                Else
                    MessageBox.Show("No section was updated. Please check the data.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error updating section: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Function SectionNameExists(sectionName As String, Optional excludeSectionID As Integer = 0) As Boolean
        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT COUNT(*) FROM section WHERE SectionName = @SectionName"

            If excludeSectionID > 0 Then
                sql &= " AND SectionID != @SectionID"
            End If

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@SectionName", sectionName)
                If excludeSectionID > 0 Then
                    cmd.Parameters.AddWithValue("@SectionID", excludeSectionID)
                End If

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error checking section name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True ' Return true to be safe and prevent potential duplicates
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    Private Function HasSectionDataChanged() As Boolean
        ' Get the current section data from database to compare
        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT * FROM section WHERE SectionID = @SectionID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@SectionID", currentSectionID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Compare each field with current form values
                        If GetSafeStringFromDB(reader("SectionName")) <> txtbxManSecSectionName.Text.Trim() Then Return True
                        If Convert.ToInt32(reader("GradeLevel")) <> nudManSecGradeLevel.Value Then Return True
                        If GetSafeStringFromDB(reader("TeacherID")) <> txtbxManSecTeacherID.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("RoomNo")) <> txtbxManSecRoomNo.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("BuildingName")) <> txtbxManSecBuildingName.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("LearningMode")) <> cmbManSecLearningMode.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("ClassType")) <> cmbManSecClassType.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Status")) <> cbxManSecStatus.Text.Trim() Then Return True

                        If Convert.ToDateTime(reader("StartDate")).ToString("yyyy-MM-dd") <> dtpManSecStartDate.Value.ToString("yyyy-MM-dd") Then Return True
                        If Convert.ToDateTime(reader("EndDate")).ToString("yyyy-MM-dd") <> dtpManSecEndDate.Value.ToString("yyyy-MM-dd") Then Return True
                        If GetSafeStringFromDB(reader("Remarks")) <> txtbxManSecRemarks.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Schedule")) <> txtbxManSchedule.Text.Trim() Then Return True
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

    Private Function ValidateSectionInputs() As Boolean
        Dim errors As New List(Of String)

        ' 1. Basic Section Information Validation
        If String.IsNullOrWhiteSpace(txtbxManSecSectionName.Text) Then
            errors.Add("• Section Name is required")
        ElseIf txtbxManSecSectionName.Text.Trim().Length < 2 Then
            errors.Add("• Section Name must be at least 2 characters long")
        End If

        ' 2. Grade Level Validation
        If nudManSecGradeLevel.Value < 1 Or nudManSecGradeLevel.Value > 12 Then
            errors.Add("• Grade Level must be between 1 and 12")
        End If

        ' 3. Learning Mode Validation
        If cmbManSecLearningMode.SelectedIndex = -1 Then
            errors.Add("• Learning Mode is required")
        End If

        ' 4. Class Type Validation
        If cmbManSecClassType.SelectedIndex = -1 Then
            errors.Add("• Class Type is required")
        End If

        ' 5. School Year Validation

        ' 6. Status Validation
        If cbxManSecStatus.SelectedIndex = -1 Then
            errors.Add("• Status is required")
        End If

        ' 7. Date Validation
        If dtpManSecEndDate.Value <= dtpManSecStartDate.Value Then
            errors.Add("• End Date must be after Start Date")
        End If

        ' 8. Check if there are any validation errors
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

        ' Section Information
        txtbxManSecSectionName.Clear()
        nudManSecGradeLevel.Value = 1
        txtbxManSecTeacherID.Clear()
        txtbxManSecRoomNo.Clear()
        txtbxManSecBuildingName.Clear()
        cmbManSecLearningMode.SelectedIndex = -1
        cmbManSecClassType.SelectedIndex = -1
        cbxManSecStatus.SelectedIndex = -1

        ' School Year and Dates

        dtpManSecStartDate.Value = DateTime.Now
        dtpManSecEndDate.Value = DateTime.Now.AddMonths(6) ' Default 6-month duration

        ' Remarks and Schedule
        txtbxManSecRemarks.Clear()
        txtbxManSchedule.Clear()

        ' Date and Created By (reset to defaults)
        dtpManSecDateCreated.Value = DateTime.Now
        txtbxManSecCreatedBy.Text = "" ' Reset to default or keep current user

        ' Reset current section selection
        currentSectionID = 0

        ' Re-enable Add button so user can create a new record
        btnSectionAdd.Enabled = True

        ' Set focus back to first field
        txtbxManSecSectionName.Focus()
    End Sub

    Private Sub dgvSections_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSections.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvSections.Rows(e.RowIndex)

        ' Safely read the SectionID in the clicked row
        Dim clickedID As Integer = 0
        If row.Cells.Count > 0 AndAlso row.Cells(0).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(0).Value) Then
            Integer.TryParse(row.Cells(0).Value.ToString(), clickedID)
        End If

        ' If the user clicked the already-selected row, clear selection and inputs
        If clickedID <> 0 AndAlso clickedID = currentSectionID Then
            dgvSections.ClearSelection()
            currentSectionID = 0
            ClearInputFields()
            Return
        End If

        ' Otherwise populate fields for the newly selected row
        If clickedID <> 0 Then
            currentSectionID = clickedID

            txtbxManSecSectionName.Text = GetSafeString(row.Cells("SectionName"))

            If Not IsDBNull(row.Cells("GradeLevel").Value) Then
                nudManSecGradeLevel.Value = Convert.ToDecimal(row.Cells("GradeLevel").Value)
            End If

            txtbxManSecTeacherID.Text = GetSafeString(row.Cells("TeacherID"))
            txtbxManSecRoomNo.Text = GetSafeString(row.Cells("RoomNo"))
            txtbxManSecBuildingName.Text = GetSafeString(row.Cells("BuildingName"))
            cmbManSecLearningMode.Text = GetSafeString(row.Cells("LearningMode"))
            cmbManSecClassType.Text = GetSafeString(row.Cells("ClassType"))
            cbxManSecStatus.Text = GetSafeString(row.Cells("Status"))


            If Not IsDBNull(row.Cells("StartDate").Value) Then
                dtpManSecStartDate.Value = CDate(row.Cells("StartDate").Value)
            End If

            If Not IsDBNull(row.Cells("EndDate").Value) Then
                dtpManSecEndDate.Value = CDate(row.Cells("EndDate").Value)
            End If

            txtbxManSecRemarks.Text = GetSafeString(row.Cells("Remarks"))
            txtbxManSchedule.Text = GetSafeString(row.Cells("Schedule"))

            If Not IsDBNull(row.Cells("DateCreated").Value) Then
                dtpManSecDateCreated.Value = CDate(row.Cells("DateCreated").Value)
            End If

            txtbxManSecCreatedBy.Text = GetSafeString(row.Cells("CreatedBy"))

            ' Keep Add button enabled
            btnSectionAdd.Enabled = True
        End If
    End Sub

    ' Helper function for safe string retrieval from DataGridView
    Private Function GetSafeString(cell As DataGridViewCell) As String
        Return If(cell.Value Is Nothing OrElse IsDBNull(cell.Value), "", cell.Value.ToString())
    End Function

    ' Apply Proper Case when leaving text fields
    Private Sub txtbxManSecSectionName_Leave(sender As Object, e As EventArgs) Handles txtbxManSecSectionName.Leave
        If Not String.IsNullOrWhiteSpace(txtbxManSecSectionName.Text) Then
            txtbxManSecSectionName.Text = ConvertToProperCase(txtbxManSecSectionName.Text.Trim())
        End If
    End Sub

    Private Sub txtbxManSecRemarks_Leave(sender As Object, e As EventArgs) Handles txtbxManSecRemarks.Leave
        If Not String.IsNullOrWhiteSpace(txtbxManSecRemarks.Text) Then
            txtbxManSecRemarks.Text = ConvertToProperCase(txtbxManSecRemarks.Text.Trim())
        End If
    End Sub

    ' Ensure selection is cleared after any data binding operation
    Private Sub dgvSections_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSections.DataBindingComplete
        dgvSections.ClearSelection()
        Try
            If dgvSections.Rows.Count > 0 AndAlso dgvSections.Columns.Count > 0 Then
                dgvSections.CurrentCell = Nothing
            End If
        Catch
            ' ignore - layout timing may prevent clearing CurrentCell
        End Try
    End Sub

    ' Final fallback after form is shown
    Private Sub AdminManageSections_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dgvSections.ClearSelection()
        Try
            If dgvSections.Rows.Count > 0 AndAlso dgvSections.Columns.Count > 0 Then
                dgvSections.CurrentCell = Nothing
            End If
        Catch
        End Try

        ' Move focus to first input so the grid doesn't appear focused
        txtbxManSecSectionName.Focus()
    End Sub

    Private Sub SearchSectionsByName(ByVal sectionName As String)
        ' If the search box is empty, load all sections (default view)
        If String.IsNullOrWhiteSpace(sectionName) Then
            LoadToDGV("SELECT * FROM section", dgvSections)
            Return
        End If

        Try
            ' Open Connection
            modDBx.openConn(modDBx.db_name)

            ' Use prefix match so search is from the first letter to the last (incremental per-letter filter)
            Dim sql As String = "SELECT * FROM section WHERE SectionName LIKE @searchName OR RoomNo LIKE @searchRoom ORDER BY SectionName"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                ' Use sectionName + '%' to match only names that start with the typed letters
                cmd.Parameters.AddWithValue("@searchName", sectionName.Trim() & "%")
                cmd.Parameters.AddWithValue("@searchRoom", sectionName.Trim() & "%")

                Dim dt As New System.Data.DataTable
                Using adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                ' Ensure grid will generate columns for the DataTable if not already configured
                dgvSections.AutoGenerateColumns = True
                dgvSections.DataSource = dt
                dgvSections.Refresh()

                ' Make sure any "id" column (SectionID) is visible and placed as the first column
                For Each col As DataGridViewColumn In dgvSections.Columns
                    Dim checkName As String = If(col.DataPropertyName, "").ToLower()
                    Dim checkHeader As String = If(col.HeaderText, "").ToLower()
                    If checkName.Contains("sectionid") OrElse checkName.Contains("id") OrElse checkHeader.Contains("sectionid") OrElse checkHeader.Contains("id") Then
                        col.Visible = True
                        col.HeaderText = "SectionID"
                        col.DisplayIndex = 0
                        Exit For
                    End If
                Next

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("No section found matching '" & sectionName & "'.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching section: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = System.Data.ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub TextBoxStudentSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxStudentSearch.TextChanged
        SearchSectionsByName(TextBoxStudentSearch.Text)
    End Sub

    ' Database helper method
    Private Sub LoadToDGV(sql As String, dgv As DataGridView)
        Try
            modDBx.openConn(modDBx.db_name)
            Dim dt As New System.Data.DataTable
            Using adapter As New MySqlDataAdapter(sql, modDBx.conn)
                adapter.Fill(dt)
            End Using

            ' Let the grid auto-generate columns from the DataTable
            dgv.AutoGenerateColumns = True
            dgv.DataSource = dt
            dgv.Refresh()

            ' Ensure any ID-like column (SectionID) is visible and shown as first column
            For Each col As DataGridViewColumn In dgv.Columns
                Dim checkName As String = If(col.DataPropertyName, "").ToLower()
                Dim checkHeader As String = If(col.HeaderText, "").ToLower()
                If checkName.Contains("sectionid") OrElse checkName.Contains("id") OrElse checkHeader.Contains("sectionid") OrElse checkHeader.Contains("id") Then
                    col.Visible = True
                    col.HeaderText = "SectionID"
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

    Private Sub txtbxManSecRoomNo_TextChanged(sender As Object, e As EventArgs) Handles txtbxManSecRoomNo.TextChanged
        ' Room number text changed handler
    End Sub

    Private Sub lblSectionsList_Click(sender As Object, e As EventArgs) Handles lblSectionsList.Click
        ' Label click handler
    End Sub

    Private Sub txtbxManSecSectionID_TextChanged(sender As Object, e As EventArgs)
        ' Section ID text changed handler
    End Sub

    Private Sub txtbxManSecSectionID_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Allow only digits and control characters (like backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub lblManSecStartDate_Click(sender As Object, e As EventArgs) Handles lblManSecStartDate.Click
        ' Label click handler
    End Sub

    Private Sub lblManSecSchedule_Click(sender As Object, e As EventArgs) Handles lblManSecSchedule.Click
        ' Label click handler
    End Sub


End Class