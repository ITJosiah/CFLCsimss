Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class TeacherViewStudents
    Private Sub TeacherViewStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BackColor = Color.FromArgb(7, 77, 39) ' Dark green background
        Me.Text = "Dashboard-Teacher"
        StyleSidebarButtons()
        PositionSidebarButtons()

        LoadToDGV("SELECT * FROM student", dgvStudents)

        txtbxStudentFirstName.ReadOnly = True
        txtbxStudentFirstName.Enabled = False

        txtStudentMiddleName.ReadOnly = True
        txtStudentMiddleName.Enabled = False

        txtbxStudentSurname.ReadOnly = True
        txtbxStudentSurname.Enabled = False

        txtbxStudentExtension.ReadOnly = True
        txtbxStudentExtension.Enabled = False

        txtbbxStudentIPGroup.ReadOnly = True
        txtbbxStudentIPGroup.Enabled = False

        RadioButtonStudentIPNO.Enabled = False
        RadioButtonStudentIPYES.Enabled = False
        RadioButtonStudent4PNO.Enabled = False
        RadioButtonStudent4PYES.Enabled = False

        txtbx4ps.ReadOnly = True
        txtbx4ps.Enabled = False

        dtpStudentBirthdate.Enabled = False

        cmbStudenttGender.Enabled = False

        txtbxStudentPOB.ReadOnly = True
        txtbxStudentPOB.Enabled = False

        txtbxStudentReligion.ReadOnly = True
        txtbxStudentReligion.Enabled = False

        txtbxStudentAge.ReadOnly = True
        txtbxStudentAge.Enabled = False

        txtbxStudentLRN.ReadOnly = True
        txtbxStudentLRN.Enabled = False

        txtbxStudentMotherTongue.ReadOnly = True
        txtbxStudentMotherTongue.Enabled = False

        txtbxGuardianName.ReadOnly = True
        txtbxGuardianName.Enabled = False

        txtbxGuardianContactNo.ReadOnly = True
        txtbxGuardianContactNo.Enabled = False

        txtbxStudentHouseNo.ReadOnly = True
        txtbxStudentHouseNo.Enabled = False

        txtbxstudentStreet.ReadOnly = True
        txtbxstudentStreet.Enabled = False

        txtbxStudentBarangay.ReadOnly = True
        txtbxStudentBarangay.Enabled = False

        txtbxStudentCity.ReadOnly = True
        txtbxStudentCity.Enabled = False

        txtbxStudentProvince.ReadOnly = True
        txtbxStudentProvince.Enabled = False

        txtbxCountry.ReadOnly = True
        txtbxCountry.Enabled = False

        txtbxZipCode.ReadOnly = True
        txtbxZipCode.Enabled = False

    End Sub

    Private Sub PositionSidebarButtons()
        ' Position sidebar buttons vertically with better spacing
        Dim sidebarWidth As Integer = 250
        Dim sidebarPadding As Integer = 10
        Dim buttonHeight As Integer = 70
        Dim buttonSpacing As Integer = 50
        Dim startTop As Integer = 60

        btnTeacherViewStudents.Top = startTop
        btnTeacherViewStudents.Left = sidebarPadding
        btnTeacherViewStudents.Width = sidebarWidth - (sidebarPadding * 2)
        btnTeacherViewStudents.Height = buttonHeight

        btnViewAssignedSubjects.Top = btnTeacherViewStudents.Bottom + buttonSpacing
        btnViewAssignedSubjects.Left = sidebarPadding
        btnViewAssignedSubjects.Width = sidebarWidth - (sidebarPadding * 2)
        btnViewAssignedSubjects.Height = buttonHeight

        btnTeacherGenerateReports.Top = btnTeacherViewStudents.Bottom + buttonSpacing
        btnTeacherGenerateReports.Left = sidebarPadding
        btnTeacherGenerateReports.Width = sidebarWidth - (sidebarPadding * 2)
        btnTeacherGenerateReports.Height = buttonHeight

        Dim logoutBottomPadding As Integer = 30
        btnLogout.Top = Me.ClientSize.Height - buttonHeight - logoutBottomPadding
        btnLogout.Left = sidebarPadding
        btnLogout.Width = sidebarWidth - (sidebarPadding * 2)
        btnLogout.Height = buttonHeight

    End Sub

    Private Sub StyleSidebarButtons()
        Dim buttons() As Button = {
            btnTeacherViewStudents,
            btnViewAssignedSubjects,
            btnTeacherGenerateReports
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

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            ExitFullScreen()
            Return True
        End If

        If keyData = Keys.F Then
            MakeItFullScreen()
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)


    End Function

    Private Sub ExitFullScreen()
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = False
    End Sub

    Private Sub MakeItFullScreen()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BringToFront()
    End Sub

    Private Sub txtbxStudentFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtbxStudentFirstName.TextChanged
        txtbxStudentFirstName.ReadOnly = True
        txtbxStudentFirstName.Enabled = False
        txtbxStudentFirstName.TabStop = False
    End Sub

    Private Sub txtbxStudentPOB_TextChanged(sender As Object, e As EventArgs) Handles txtbxStudentPOB.TextChanged

    End Sub

    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvStudents.Rows(e.RowIndex)

        ' Safely read the StudentID in the clicked row
        Dim clickedID As Integer = 0
        If row.Cells.Count > 0 AndAlso row.Cells(0).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(0).Value) Then
            Integer.TryParse(row.Cells(0).Value.ToString(), clickedID)
        End If

        txtbxStudentLRN.Text = GetSafeString(row.Cells("LRN"))
            txtbxStudentFirstName.Text = GetSafeString(row.Cells("FirstName"))
            txtStudentMiddleName.Text = GetSafeString(row.Cells("MiddleName"))
            txtbxStudentSurname.Text = GetSafeString(row.Cells("LastName"))
            txtbxStudentExtension.Text = GetSafeString(row.Cells("ExtensionName"))
            cmbStudenttGender.Text = GetSafeString(row.Cells("Gender"))

            If Not IsDBNull(row.Cells("Birthdate").Value) Then
                dtpStudentBirthdate.Value = CDate(row.Cells("Birthdate").Value)
            End If

            txtbxStudentPOB.Text = GetSafeString(row.Cells("BirthPlace"))
            txtbxStudentMotherTongue.Text = GetSafeString(row.Cells("MotherTongue"))
            txtbxStudentReligion.Text = GetSafeString(row.Cells("Religion"))

            ' Indigineous fields
            Dim indigineous As String = GetSafeString(row.Cells("Indigineous"))
            If indigineous = "Yes" Then
                RadioButtonStudentIPYES.Checked = True
            Else
                RadioButtonStudentIPNO.Checked = True
            End If
            txtbbxStudentIPGroup.Text = GetSafeString(row.Cells("IndigineousSpecific"))

            ' 4Ps fields
            Dim is4Ps As String = GetSafeString(row.Cells("4Ps"))
            If is4Ps = "Yes" Then
                RadioButtonStudent4PYES.Checked = True
            Else
                RadioButtonStudent4PNO.Checked = True
            End If
            txtbx4ps.Text = GetSafeString(row.Cells("4PsID"))

            txtbxGuardianName.Text = GetSafeString(row.Cells("GuardianName"))
            txtbxGuardianContactNo.Text = GetSafeString(row.Cells("GuardianContact"))

            ' Age field
            If Not IsDBNull(row.Cells("Age").Value) Then
                txtbxStudentAge.Text = row.Cells("Age").Value.ToString()
            End If
            ' Address fields
            txtbxStudentHouseNo.Text = GetSafeString(row.Cells("HouseNumber"))
            txtbxstudentStreet.Text = GetSafeString(row.Cells("Street"))
            txtbxStudentBarangay.Text = GetSafeString(row.Cells("Barangay"))
            txtbxStudentCity.Text = GetSafeString(row.Cells("Municipality"))
            txtbxStudentProvince.Text = GetSafeString(row.Cells("Province"))
            txtbxCountry.Text = GetSafeString(row.Cells("Country"))
            txtbxZipCode.Text = GetSafeString(row.Cells("ZIPCode"))

        ' Keep Add button enabled so it's clickable; btnAdd will block adding while updating via currentStudentID check
    End Sub

    ' Helper function for safe string retrieval from DataGridView
    Private Function GetSafeString(cell As DataGridViewCell) As String
        Return If(cell.Value Is Nothing OrElse IsDBNull(cell.Value), "", cell.Value.ToString())
    End Function
End Class