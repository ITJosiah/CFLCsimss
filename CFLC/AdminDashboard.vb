Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(7, 77, 39) ' Dark green background
        Me.Text = "Dashboard-Admin"

        ' Position sidebar buttons first
        PositionSidebarButtons()

        ' Center the logo
        CenterLogo()

        ' Style the sidebar buttons
        StyleSidebarButtons()
    End Sub

    Private Sub CenterLogo()
        ' Center the logo in the main content area
        ' Adjust the left position to account for sidebar (sidebar is typically 200-250px wide)
        Dim sidebarWidth As Integer = 250
        Dim mainAreaLeft As Integer = sidebarWidth
        Dim mainAreaWidth As Integer = Me.ClientSize.Width - sidebarWidth

        PictureBox1.Left = mainAreaLeft + (mainAreaWidth - PictureBox1.Width) \ 2
        PictureBox1.Top = (Me.ClientSize.Height - PictureBox1.Height) \ 2 - 50
    End Sub

    Private Sub StyleSidebarButtons()
        ' Style all sidebar buttons
        Dim buttons() As Button = {btnManageStudents, btnManageTeachers, btnManageSections,
                                   btnManageEnrollments, btnManageSubjects, btnGenerateReports}

        For Each btn As Button In buttons
            btn.BackColor = Color.LightGray
            btn.ForeColor = Color.Black
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = Color.Gainsboro ' Slight hover effect
            btn.Font = New Font(btn.Font.FontFamily, 15, FontStyle.Bold)
            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.Padding = New Padding(15, 0, 0, 0) ' More left padding for text
        Next

        ' Style logout button differently (red)
        btnLogout.BackColor = Color.Red
        btnLogout.ForeColor = Color.White
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseOverBackColor = Color.DarkRed ' Darker red on hover
        btnLogout.Font = New Font(btnLogout.Font.FontFamily, 12, FontStyle.Bold)
        btnLogout.TextAlign = ContentAlignment.MiddleCenter ' Center text for logout
    End Sub

    Private Sub AdminDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterLogo()
        PositionSidebarButtons()
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

    ' Button click handlers
    Private Sub btnManageStudents_Click(sender As Object, e As EventArgs) Handles btnManageStudents.Click
        ' TODO: Open Manage Students form
        MessageBox.Show("Manage Students - Hello Po!!!")
    End Sub

    Private Sub btnManageTeachers_Click(sender As Object, e As EventArgs) Handles btnManageTeachers.Click
        ' TODO: Open Manage Teachers form
        MessageBox.Show("Manage Teachers - Coming Soon")
    End Sub

    Private Sub btnManageSections_Click(sender As Object, e As EventArgs) Handles btnManageSections.Click
        ' TODO: Open Manage Sections form
        MessageBox.Show("Manage Sections - Coming Soon")
    End Sub

    Private Sub btnManageEnrollments_Click(sender As Object, e As EventArgs) Handles btnManageEnrollments.Click
        ' TODO: Open Manage Enrollments form
        MessageBox.Show("Manage Enrollments - Coming Soon")
    End Sub

    Private Sub btnManageSubjects_Click(sender As Object, e As EventArgs) Handles btnManageSubjects.Click
        ' TODO: Open Manage Subjects form
        MessageBox.Show("Manage Subjects - Coming Soon")
    End Sub

    Private Sub btnGenerateReports_Click(sender As Object, e As EventArgs) Handles btnGenerateReports.Click
        ' TODO: Open Generate Reports form
        MessageBox.Show("Generate Reports - Coming Soon")
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Go back to Form1 (main menu)
        For Each form As Form In Application.OpenForms
            If form.Name = "Form1" Then
                form.Show()
                form.WindowState = FormWindowState.Maximized
                Exit For
            End If
        Next
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class

