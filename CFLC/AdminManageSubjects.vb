Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class AdminManageSubjects

    Public Property IsEmbedded As Boolean = False

    Private Sub AdminManageSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbSubjectCategory.Items.Clear()
        cmbSubjectCategory.Items.Add("Core")
        cmbSubjectCategory.Items.Add("Elective")
        cmbSubjectCategory.Items.Add("Special")

        ' Make category and room type read-only (non-editable by user)
        cmbSubjectCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSubjectCategory.Enabled = True

        cbxManSubRoomType.DropDownStyle = ComboBoxStyle.DropDownList
        cbxManSubRoomType.Enabled = True

        ' Load subject data
        LoadToDGV("SELECT * FROM subject", dgvSubjectList)


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

        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            StyleSidebarButtons()
            PositionSidebarButtons()
            ' Replace the designer-generated AutoScaleMode line with:
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi

        Else
            pnlSidebar.Visible = False
            pnlManSubContent.Dock = DockStyle.Fill
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

    Private Sub pnlManSubContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlManSubContent.Paint

    End Sub

    Private Sub lblManSubCategory_Click(sender As Object, e As EventArgs) Handles lblManSubCategory.Click, lblManSubCategory.Click

    End Sub

    Private Sub btnSubUpdate_Click(sender As Object, e As EventArgs) Handles btnSubjectUpdate.Click
        UpdateSubject()
    End Sub

    Private currentSubjectID As Integer = 0 ' Make sure this is set when selecting a row

    Private Sub UpdateSubject()
        If currentSubjectID = 0 Then
            MessageBox.Show("Please select a subject to update.", "No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim query As String = "
        UPDATE subject SET
            SubjectName = @SubjectName,
            SubjectCode = @SubjectCode,
            Description = @Description,
            SkillFocus = @SkillFocus,
            GradeLevel = @GradeLevel,
            RoomType = @RoomType,
            Quarter = @Quarter,
            LearningMaterials = @LearningMaterials,
            Category = @Category,
            Schedule = @Schedule,
            Status = @Status,
            CurriculumYear = @CurriculumYear,
            DateCreated = @DateCreated
        WHERE SubjectID = @SubjectID
    "

            Using con As New MySqlConnection("server=192.168.1.30;user=jeje;password=password;database=cflc_db;")
                Using cmd As New MySqlCommand(query, con)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@SubjectID", currentSubjectID)
                    cmd.Parameters.AddWithValue("@SubjectName", txtbxManSubSubjectName.Text)
                    cmd.Parameters.AddWithValue("@SubjectCode", txtbxManSubSubjectCode.Text)
                    cmd.Parameters.AddWithValue("@Description", txtbxManSubDescription.Text)
                    cmd.Parameters.AddWithValue("@SkillFocus", txtbxManSubSkillFocus.Text)
                    cmd.Parameters.AddWithValue("@RoomType", cbxManSubRoomType.Text)
                    cmd.Parameters.AddWithValue("@GradeLevel", nudManSubGradeLevel.Value)
                    cmd.Parameters.AddWithValue("@Quarter", nudManSubQuarter.Value)
                    cmd.Parameters.AddWithValue("@LearningMaterials", txtbxManSubLearningMaterials.Text)
                    cmd.Parameters.AddWithValue("@Schedule", txtbxManSubSchedule.Text)
                    cmd.Parameters.AddWithValue("@Status", txtbxManSubStatus.Text)
                    cmd.Parameters.AddWithValue("@CurriculumYear", txtbxManSubCurriculumYear.Text)
                    cmd.Parameters.AddWithValue("@DateCreated", dtpManSubDateCreated.Value)
                    cmd.Parameters.AddWithValue("@Category", cmbSubjectCategory.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Subject updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh DataGridView (assuming you have a LoadToDGV function)
            LoadToDGV("SELECT * FROM subject", dgvSubjectList)

        Catch ex As Exception
            MessageBox.Show("Update failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgvSubjectList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjectList.CellClick
        ' Toggle selection: if user clicks the same row again, unselect and clear inputs.
        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvSubjectList.Rows(e.RowIndex)

        ' Safely read the SubjectID in the clicked row
        Dim clickedID As Integer = 0
        If row.Cells.Count > 0 AndAlso row.Cells(0).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(0).Value) Then
            Integer.TryParse(row.Cells(0).Value.ToString(), clickedID)
        End If

        ' If same row clicked again, clear selection and inputs
        If clickedID <> 0 AndAlso clickedID = currentSubjectID Then
            dgvSubjectList.ClearSelection()
            Try
                If dgvSubjectList.Rows.Count > 0 AndAlso dgvSubjectList.Columns.Count > 0 Then
                    dgvSubjectList.CurrentCell = Nothing
                End If
            Catch
                ' ignore timing/layout exceptions
            End Try

            ' Clear fields and reset selection state
            ClearInputFields()
            currentSubjectID = 0
            Return
        End If

        ' Otherwise populate fields for the newly selected row
        If clickedID <> 0 Then
            currentSubjectID = clickedID

            ' Safely assign text values
            txtbxManSubSubjectName.Text = If(row.Cells("SubjectName").Value IsNot DBNull.Value, row.Cells("SubjectName").Value.ToString(), "")
            txtbxManSubSubjectCode.Text = If(row.Cells("SubjectCode").Value IsNot DBNull.Value, row.Cells("SubjectCode").Value.ToString(), "")
            txtbxManSubDescription.Text = If(row.Cells("Description").Value IsNot DBNull.Value, row.Cells("Description").Value.ToString(), "")
            txtbxManSubLearningMaterials.Text = If(row.Cells("LearningMaterials").Value IsNot DBNull.Value, row.Cells("LearningMaterials").Value.ToString(), "")
            txtbxManSubSchedule.Text = If(row.Cells("Schedule").Value IsNot DBNull.Value, row.Cells("Schedule").Value.ToString(), "")
            txtbxManSubStatus.Text = If(row.Cells("Status").Value IsNot DBNull.Value, row.Cells("Status").Value.ToString(), "")
            txtbxManSubCurriculumYear.Text = If(row.Cells("CurriculumYear").Value IsNot DBNull.Value, row.Cells("CurriculumYear").Value.ToString(), "")
            txtbxManSubSkillFocus.Text = If(row.Cells("SkillFocus").Value IsNot DBNull.Value, row.Cells("SkillFocus").Value.ToString(), "")
            txtbxManSubCreatedBy.Text = If(row.Cells("CreatedBy").Value IsNot DBNull.Value, row.Cells("CreatedBy").Value.ToString(), "")

            ' Safely assign numeric up-down values
            nudManSubQuarter.Value = If(row.Cells("Quarter").Value IsNot DBNull.Value, Convert.ToDecimal(row.Cells("Quarter").Value), 1D)

            ' Safely assign GradeLevel
            nudManSubGradeLevel.Value = If(row.Cells("GradeLevel").Value IsNot DBNull.Value, Convert.ToDecimal(row.Cells("GradeLevel").Value), 1D)

            ' Safely assign RoomType (ComboBox)
            cbxManSubRoomType.Text = If(row.Cells("RoomType").Value IsNot DBNull.Value, row.Cells("RoomType").Value.ToString(), "")
            cmbSubjectCategory.Text = If(row.Cells("Category").Value IsNot DBNull.Value, row.Cells("Category").Value.ToString(), "")

            ' Safely assign DateCreated
            If row.Cells("DateCreated").Value IsNot DBNull.Value Then
                dtpManSubDateCreated.Value = CDate(row.Cells("DateCreated").Value)
            End If
        End If

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

    Private Sub ClearInputFields()
        ' Clear all input fields after successful add or when un-selecting a row

        ' Subject Information
        txtbxManSubSubjectName.Clear()
        txtbxManSubSubjectCode.Clear()
        txtbxManSubDescription.Clear()
        txtbxManSubSkillFocus.Clear()
        cbxManSubRoomType.SelectedIndex = -1
        cbxManSubRoomType.Text = "" ' ensure room type string is cleared
        cmbSubjectCategory.SelectedIndex = -1
        cmbSubjectCategory.Text = "" ' ensure category string is cleared
        nudManSubGradeLevel.Value = 1
        nudManSubQuarter.Value = 1
        txtbxManSubLearningMaterials.Clear()
        txtbxManSubSchedule.Clear()
        txtbxManSubStatus.Clear()
        txtbxManSubCurriculumYear.Clear()
        dtpManSubDateCreated.Value = DateTime.Now
        txtbxManSubCreatedBy.Clear()

        ' Reset current teacher selection
        currentSubjectID = 0

        ' Set focus back to first field
        txtbxManSubSubjectName.Focus()
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
            ' ignore
        End Try

        ' Move focus to first input so the grid doesn't look focused
        txtbxManSubSubjectName.Focus()
    End Sub

    Private Sub cmbSubjectCategory_TextChanged(sender As Object, e As EventArgs) Handles cmbSubjectCategory.TextChanged
        ' No-op handler: ComboBox is non-editable for the user (DropDownList + Disabled).
        ' Keep DropDownStyle enforced in case something changes it programmatically elsewhere.
        If cmbSubjectCategory.DropDownStyle <> ComboBoxStyle.DropDownList Then
            cmbSubjectCategory.DropDownStyle = ComboBoxStyle.DropDownList
        End If
    End Sub

End Class