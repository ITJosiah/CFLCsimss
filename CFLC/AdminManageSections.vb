Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class AdminManageSections

    Public Property IsEmbedded As Boolean = False
    Private Sub AdminManageSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadToDGV("SELECT * FROM section", dgvSections)

        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            StyleSidebarButtons()
            PositionSidebarButtons()
            ' Replace the designer-generated AutoScaleMode line with:
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi

        Else
            pnlSidebar.Visible = False
            pnlManSecContent.Dock = DockStyle.Fill
        End If
    End Sub

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

    End Sub

    Private Sub lblSectionsList_Click(sender As Object, e As EventArgs) Handles lblSectionsList.Click

    End Sub

    Private Sub txtbxManSecSectionID_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtbxManSecSectionID_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Allow only digits and control characters (like backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub lblManSecStartDate_Click(sender As Object, e As EventArgs) Handles lblManSecStartDate.Click

    End Sub

    Private Sub lblManSecSchedule_Click(sender As Object, e As EventArgs) Handles lblManSecSchedule.Click

    End Sub

    Private Function HasSectionDataChanged() As Boolean
        ' TODO: Implement actual field comparison logic
        ' For now, always return True to allow updating
        Return True
    End Function

    Private Sub btnSectionUpdate_Click(sender As Object, e As EventArgs) Handles btnSectionUpdate.Click
        UpdateSection()
    End Sub

    Private Sub UpdateSection()

        ' Make sure a section is selected
        If currentSectionID = 0 Then
            MessageBox.Show("No section selected for update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Validate all required fields
        If Not ValidateSectionInputs() Then
            Return
        End If

        ' Check if Section Name already exists (excluding current record)
        If SectionNameExists(txtbxManSecSectionName.Text.Trim(), currentSectionID) Then
            MessageBox.Show("Section Name already exists. Please use a unique Section Name.", "Duplicate Section", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if data actually changed
        If Not HasSectionDataChanged() Then
            MessageBox.Show("No changes were made to the section data.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            modDBx.openConn(modDBx.db_name)

            Dim sql As String =
                "UPDATE section SET " &
                "SectionName = @SectionName, " &
                "GradeLevel = @GradeLevel, " &
                "TeacherID = @TeacherID, " &
                "Remarks = @Remarks, " &
                "RoomNo = @RoomNo, " &
                "LearningMode = @LearningMode, " &
                "ClassType = @ClassType, " &
                "Schedule = @Schedule, " &
                "SchoolYear = @SchoolYear, " &
                "StartDate = @StartDate, " &
                "EndDate = @EndDate, " &
                "Status = @Status, " &
                "DateCreated = @DateCreated, " &
                "CreatedBy = @CreatedBy " &
                "WHERE SectionID = @SectionID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)

                ' Basic Information
                cmd.Parameters.AddWithValue("@SectionName", ConvertToProperCase(SafeString(txtbxManSecSectionName.Text)))
                cmd.Parameters.AddWithValue("@GradeLevel", nudManSecGradeLevel.Value)
                cmd.Parameters.AddWithValue("@TeacherID", SafeString(txtbxManSecTeacherID.Text))
                cmd.Parameters.AddWithValue("@Remarks", ConvertToProperCase(SafeString(txtbxManSecRemarks.Text)))
                cmd.Parameters.AddWithValue("@RoomNo", SafeString(txtbxManSecRoomNo.Text))

                ' Combo Boxes
                Dim learningMode As String = If(cmbManSecLearningMode.SelectedItem Is Nothing, "", cmbManSecLearningMode.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@LearningMode", learningMode)

                Dim classType As String = If(cmbManSecClassType.SelectedItem Is Nothing, "", cmbManSecClassType.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@ClassType", classType)

                ' Schedule + Year
                cmd.Parameters.AddWithValue("@Schedule", SafeString(txtbxManSchedule.Text))
                cmd.Parameters.AddWithValue("@SchoolYear", SafeString(txtbxManSecSchoolYear.Text))

                ' Dates
                cmd.Parameters.AddWithValue("@StartDate", dtpManSecStartDate.Value)
                cmd.Parameters.AddWithValue("@EndDate", dtpManSecEndDate.Value)

                ' Status
                Dim status As String = If(cbxManSecStatus.SelectedItem Is Nothing, "", cbxManSecStatus.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Status", status)

                ' Metadata
                cmd.Parameters.AddWithValue("@DateCreated", dtpManSecDateCreated.Value)
                cmd.Parameters.AddWithValue("@CreatedBy", SafeString(txtbxManSecCreatedBy.Text))

                ' Identifier
                cmd.Parameters.AddWithValue("@SectionID", currentSectionID)

                ' Execute Update
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Section updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private currentSectionID As Integer = 0

    Private Sub dgvSections_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSections.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvSections.Rows(e.RowIndex)

        ' Safely read the SectionID from first column
        Dim clickedID As Integer = 0
        If row.Cells.Count > 0 AndAlso row.Cells(0).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(0).Value) Then
            Integer.TryParse(row.Cells(0).Value.ToString(), clickedID)
        End If

        ' If user clicked the same row again → clear
        If clickedID <> 0 AndAlso clickedID = currentSectionID Then
            dgvSections.ClearSelection()
            currentSectionID = 0
            ClearInputFields()
            Return
        End If

        ' Load selected row values
        If clickedID <> 0 Then
            currentSectionID = clickedID

            txtbxManSecSectionName.Text = GetSafeString(row.Cells("SectionName"))
            nudManSecGradeLevel.Value = If(IsDBNull(row.Cells("GradeLevel").Value), 0, Convert.ToDecimal(row.Cells("GradeLevel").Value))
            txtbxManSecTeacherID.Text = GetSafeString(row.Cells("TeacherID"))
            txtbxManSecRemarks.Text = GetSafeString(row.Cells("Remarks"))
            txtbxManSecRoomNo.Text = GetSafeString(row.Cells("RoomNo"))

            cmbManSecLearningMode.Text = GetSafeString(row.Cells("LearningMode"))
            cmbManSecClassType.Text = GetSafeString(row.Cells("ClassType"))

            txtbxManSchedule.Text = GetSafeString(row.Cells("Schedule"))
            txtbxManSecSchoolYear.Text = GetSafeString(row.Cells("SchoolYear"))

            ' Dates
            If Not IsDBNull(row.Cells("StartDate").Value) Then
                dtpManSecStartDate.Value = CDate(row.Cells("StartDate").Value)
            End If

            If Not IsDBNull(row.Cells("EndDate").Value) Then
                dtpManSecEndDate.Value = CDate(row.Cells("EndDate").Value)
            End If

            ' Status
            cbxManSecStatus.Text = GetSafeString(row.Cells("Status"))

            ' Metadata fields
            If Not IsDBNull(row.Cells("DateCreated").Value) Then
                dtpManSecDateCreated.Value = CDate(row.Cells("DateCreated").Value)
            End If

            txtbxManSecCreatedBy.Text = GetSafeString(row.Cells("CreatedBy"))

            ' Keep Add button enabled
            btnSectionAdd.Enabled = True
        End If
    End Sub
    Private Function GetSafeString(cell As DataGridViewCell) As String
        If cell Is Nothing OrElse cell.Value Is Nothing OrElse IsDBNull(cell.Value) Then
            Return ""
        End If
        Return cell.Value.ToString()
    End Function

    Private Function SafeString(text As String) As String
        If text Is Nothing Then Return ""
        Return text.Trim()
    End Function

    Private Function ConvertToProperCase(text As String) As String
        If String.IsNullOrEmpty(text) Then Return ""
        Return Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower())
    End Function

    Private Sub ClearInputFields()
        txtbxManSecSectionName.Clear()
        nudManSecGradeLevel.Value = 0
        txtbxManSecTeacherID.Clear()
        txtbxManSecRemarks.Clear()
        txtbxManSecRoomNo.Clear()
        cmbManSecLearningMode.SelectedIndex = -1
        cmbManSecClassType.SelectedIndex = -1
        txtbxManSchedule.Clear()
        txtbxManSecSchoolYear.Clear()
        dtpManSecStartDate.Value = Date.Today
        dtpManSecEndDate.Value = Date.Today
        cbxManSecStatus.SelectedIndex = -1
        dtpManSecDateCreated.Value = Date.Today
        txtbxManSecCreatedBy.Clear()
    End Sub

    Private Function ValidateSectionInputs() As Boolean

        If txtbxManSecSectionName.Text.Trim() = "" Then
            MessageBox.Show("Section Name is required.")
            Return False
        End If

        If nudManSecGradeLevel.Value <= 0 Then
            MessageBox.Show("Grade Level must be greater than 0.")
            Return False
        End If

        If txtbxManSecTeacherID.Text.Trim() = "" Then
            MessageBox.Show("Teacher ID is required.")
            Return False
        End If

        Return True
    End Function

    Private Function SectionNameExists(sectionName As String, excludeID As Integer) As Boolean
        Try
            ' Make sure the connection is open
            If modDBx.conn.State <> ConnectionState.Open Then
                modDBx.conn.Open()
            End If

            Dim sql As String = "SELECT COUNT(*) FROM section WHERE SectionName = @name AND SectionID <> @id"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@name", sectionName)
                cmd.Parameters.AddWithValue("@id", excludeID)

                Dim result As Object = cmd.ExecuteScalar()
                Dim count As Integer = 0

                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Integer.TryParse(result.ToString(), count)
                End If

                Return count > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error checking section name: " & ex.Message)
            Return False
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    Private Sub btnSectionDelete_Click(sender As Object, e As EventArgs) Handles btnSectionDelete.Click
        ' Check if a delete is selected
        If currentSectionID = 0 Then
            MessageBox.Show("Please select a section to delete.", "Delete section", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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


End Class