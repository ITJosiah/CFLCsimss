Public Class TeacherViewSection

    Private Sub TeacherViewSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BackColor = Color.FromArgb(7, 77, 39) ' Dark green background ni nio
        Me.Text = "Dashboard-Teacher"
        StyleSidebarButtons()
        PositionSidebarButtons()

        txtbxManSecSectionName.ReadOnly = True
        txtbxManSecSectionName.Enabled = False

        nudManSecGradeLevel.ReadOnly = True
        nudManSecGradeLevel.Enabled = False

        txtbxManSecTeacherID.ReadOnly = True
        txtbxManSecTeacherID.Enabled = False

        txtbxManSecRoomNo.ReadOnly = True
        txtbxManSecRoomNo.Enabled = False

        txtbxManSecBuildingName.ReadOnly = True
        txtbxManSecBuildingName.Enabled = False


        cmbManSecClassType.Enabled = False

        cmbManSecLearningMode.Enabled = False

        txtbxManSchedule.ReadOnly = True
        txtbxManSchedule.Enabled = False

    End Sub

    Private Sub PositionSidebarButtons()
        ' Position sidebar buttons vertically with better spacing
        Dim sidebarWidth As Integer = 250
        Dim sidebarPadding As Integer = 10
        Dim buttonHeight As Integer = 70
        Dim buttonSpacing As Integer = 50
        Dim startTop As Integer = 60

        btnTeacherViewSection.Top = startTop
        btnTeacherViewSection.Left = sidebarPadding
        btnTeacherViewSection.Width = sidebarWidth - (sidebarPadding * 2)
        btnTeacherViewSection.Height = buttonHeight

        btnTeacherViewStudents.Top = btnTeacherViewSection.Bottom + buttonSpacing
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
            btnTeacherViewSection,
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

    Private Sub txtbxManSecTeacherID_TextChanged(sender As Object, e As EventArgs) Handles txtbxManSecTeacherID.TextChanged

    End Sub

    Private Sub lblManSecTeacherID_Click(sender As Object, e As EventArgs) Handles lblManSecTeacherID.Click

    End Sub

    Private Sub picWatermark_Click(sender As Object, e As EventArgs) Handles picWatermark.Click

    End Sub
End Class