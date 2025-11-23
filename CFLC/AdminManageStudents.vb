Imports MySql.Data.MySqlClient

Public Class AdminManageStudents

    Public Property IsEmbedded As Boolean = False

    Private Sub AdminManageStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            StyleSidebarButtons()
            PositionSidebarButtons()
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Else
            pnlSidebar.Visible = False
            pnlContent.Dock = DockStyle.Fill
        End If

        ' Initialize Gender ComboBox
        InitializeGenderComboBox()

        ' Initialize numeric controls with safe default values
        InitializeNumericControls()
    End Sub

    Private Sub InitializeNumericControls()
        ' Set safe default values for numeric up/down controls
        If nudStudentAge.Minimum <= 0 AndAlso nudStudentAge.Maximum >= 0 Then
            nudStudentAge.Value = 0
        Else
            nudStudentAge.Value = nudStudentAge.Minimum
        End If

        If nudStudentGradeLevel.Minimum <= 0 AndAlso nudStudentGradeLevel.Maximum >= 0 Then
            nudStudentGradeLevel.Value = 0
        Else
            nudStudentGradeLevel.Value = nudStudentGradeLevel.Minimum
        End If
    End Sub

    Private Sub InitializeGenderComboBox()
        ' Populate Gender dropdownS
        cmbStudenttGender.Items.Clear()
        cmbStudenttGender.Items.Add("Male")
        cmbStudenttGender.Items.Add("Female")
    End Sub

    Private Sub PositionSidebarButtons()
        ' Position sidebar buttons vertically with better spacing
        Dim sidebarWidth As Integer = 250
        Dim sidebarPadding As Integer = 10
        Dim buttonHeight As Integer = 70
        Dim buttonSpacing As Integer = 50
        Dim startTop As Integer = 60

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

        Dim logoutBottomPadding As Integer = 30
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnStudentAdd.Click

    End Sub


    Private Sub ClearInputFields()
        ' Clear all input fields after successful add
        txtStudentMiddleName.Clear()
        txtbxStudentFirstName.Clear()
        txtbxStudentSurname.Clear()
        cmbStudenttGender.SelectedIndex = -1
        dtpStudentBirthdate.Value = DateTime.Now

        ' Reset numeric controls safely
        ResetNumericControl(nudStudentAge)
        ResetNumericControl(nudStudentGradeLevel)

        txtbxGuardianName.Clear()
        txtbxStudentReligion.Clear()
        txtbxStudentSectionID.Clear()
        txtbxStudentEnrollmentID.Clear()

        ' Clear address fields
        txtbxStudentHouseNo.Clear()
        txtbcStudentStreet.Clear()
        txtbxStudentBarangay.Clear()
        txtbxStudentCity.Clear()
        txtbxStudentProvince.Clear()
        txtbxCountry.Clear()
        txtbxZipCode.Clear()

        ' Set focus back to first field
        txtbxStudentFirstName.Focus()
    End Sub

    ' Helper method to safely reset numeric up/down controls
    Private Sub ResetNumericControl(nudControl As NumericUpDown)
        ' Set to minimum value, but ensure it's within valid range
        If nudControl.Minimum <= 0 AndAlso nudControl.Maximum >= 0 Then
            nudControl.Value = 0
        Else
            ' If 0 is not valid, set to the minimum value
            nudControl.Value = nudControl.Minimum
        End If
    End Sub

    ' Auto-calculate age when birthdate changes
    Private Sub dtpStudentBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStudentBirthdate.ValueChanged
        Dim birthDate As Date = dtpStudentBirthdate.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year

        ' Adjust if birthday hasn't occurred this year
        If birthDate.Date > today.AddYears(-age) Then
            age -= 1
        End If

        ' Ensure age is within valid range for the control
        If age < nudStudentAge.Minimum Then
            nudStudentAge.Value = nudStudentAge.Minimum
        ElseIf age > nudStudentAge.Maximum Then
            nudStudentAge.Value = nudStudentAge.Maximum
        Else
            nudStudentAge.Value = age
        End If
    End Sub

    Private Function CalculateAge(birthDate As Date) As Integer
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year

        If birthDate > today.AddYears(-age) Then
            age -= 1
        End If

        Return age
    End Function

    ' Event handlers for various controls
    Private Sub txtStudentId_TextChanged(sender As Object, e As EventArgs)
        ' Handle text change if needed
    End Sub

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint
        ' Handle paint event if needed
    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs)
        ' Handle text change if needed
    End Sub

    Private Sub lblStudentAge_Click(sender As Object, e As EventArgs) Handles lblStudentAge.Click
        ' Handle label click if needed
    End Sub

    Private Sub lblStudentGender_Click(sender As Object, e As EventArgs) Handles lblStudentGender.Click
        ' Handle label click if needed
    End Sub

    Private Sub picWatermark_Click(sender As Object, e As EventArgs) Handles picWatermark.Click
        ' Handle picture click if needed
    End Sub

    Private Sub grpStudentInfo_Enter(sender As Object, e As EventArgs) Handles grpStudentInfo.Enter
        ' Handle group box enter if needed
    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
        ' Handle paint event if needed
    End Sub

    Private Sub grpAddress_Enter(sender As Object, e As EventArgs) Handles grpAddress.Enter
        ' Handle group box enter if needed
    End Sub

    Private Sub lblStudentBarangay_Click(sender As Object, e As EventArgs) Handles lblStudentBarangay.Click
        ' Handle label click if needed
    End Sub

    Private Sub lblStudentProvince_Click(sender As Object, e As EventArgs) Handles lblStudentProvince.Click
        ' Handle label click if needed
    End Sub

    Private Sub lblStudentMiddleName_Click(sender As Object, e As EventArgs) Handles lblStudentMiddleName.Click
        ' Handle label click if needed
    End Sub

    Private Sub cmbStudenttGenderSelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudenttGender.SelectedIndexChanged
        ' Handle combo box selection change if needed
    End Sub

    Private Sub nudStudentAgeValueChanged(sender As Object, e As EventArgs) Handles nudStudentAge.ValueChanged
        ' Handle numeric up/down value change if needed
    End Sub

    Private Sub txtbxStudentSurnameTextChanged(sender As Object, e As EventArgs) Handles txtbxStudentSurname.TextChanged
        ' Handle text change if needed
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs)
        ' Handle label click if needed
    End Sub

    Private Sub txtbxZipCode_TextChanged(sender As Object, e As EventArgs) Handles txtbxZipCode.TextChanged
        ' Handle text change if needed
    End Sub

    Private Sub txtbxZipCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxZipCode.KeyPress
        ' Only allow digits and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtpStudentBirthdate_ValuesChanged(sender As Object, e As EventArgs) Handles dtpStudentBirthdate.ValueChanged
        ' This is already handled by dtpStudentBirthdate_ValueChanged
    End Sub

    Private Sub dgvStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellContentClick

    End Sub

    Private Sub FormStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToDGV("SELECT * FROM student", dgvStudents)
    End Sub
End Class
