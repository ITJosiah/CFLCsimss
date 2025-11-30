Public Class SuperAdminDashboard

    Private currentContent As Form
    Public Property IsEmbedded As Boolean = False
    Private Sub SuperAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        End If
        Me.Text = "Dashboard-SuperAdmin"


        PositionSidebarButtons()

        ShowHomeContent()

        StyleSidebarButtons()

    End Sub

    Private Sub CenterLogo()
        If Not pnlSuperAdminMainContent.Controls.Contains(PictureBox1) Then
            Return
        End If

        Dim areaWidth As Integer = pnlSuperAdminMainContent.ClientSize.Width
        Dim areaHeight As Integer = pnlSuperAdminMainContent.ClientSize.Height

        PictureBox1.Left = (areaWidth - PictureBox1.Width) \ 2
        PictureBox1.Top = (areaHeight - PictureBox1.Height) \ 2
    End Sub

    Private Sub StyleSidebarButtons()
        ' Style all sidebar buttons
        Dim buttons() As Button = {btnSuperAdminManageAdmin, btnSuperAdminManageTea, btnSuperAdminManageSysCon, btnSuperAdminAccessLogs,
                                   btnSuperAdminGenerateReports}

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
        btnSuperAdminManageAdmin.Top = startTop
        btnSuperAdminManageAdmin.Left = sidebarPadding
        btnSuperAdminManageAdmin.Width = sidebarWidth - (sidebarPadding * 2)
        btnSuperAdminManageAdmin.Height = buttonHeight

        btnSuperAdminManageTea.Top = btnSuperAdminManageAdmin.Bottom + buttonSpacing
        btnSuperAdminManageTea.Left = sidebarPadding
        btnSuperAdminManageTea.Width = sidebarWidth - (sidebarPadding * 2)
        btnSuperAdminManageTea.Height = buttonHeight

        btnSuperAdminManageSysCon.Top = btnSuperAdminManageTea.Bottom + buttonSpacing
        btnSuperAdminManageSysCon.Left = sidebarPadding
        btnSuperAdminManageSysCon.Width = sidebarWidth - (sidebarPadding * 2)
        btnSuperAdminManageSysCon.Height = buttonHeight

        btnSuperAdminAccessLogs.Top = btnSuperAdminManageSysCon.Bottom + buttonSpacing
        btnSuperAdminAccessLogs.Left = sidebarPadding
        btnSuperAdminAccessLogs.Width = sidebarWidth - (sidebarPadding * 2)
        btnSuperAdminAccessLogs.Height = buttonHeight

        btnSuperAdminGenerateReports.Top = btnSuperAdminAccessLogs.Bottom + buttonSpacing
        btnSuperAdminGenerateReports.Left = sidebarPadding
        btnSuperAdminGenerateReports.Width = sidebarWidth - (sidebarPadding * 2)
        btnSuperAdminGenerateReports.Height = buttonHeight

        ' Position logout button at the bottom with more spacing
        Dim logoutBottomPadding As Integer = 30 ' More space from bottom
        btnLogout.Top = Me.ClientSize.Height - buttonHeight - logoutBottomPadding
        btnLogout.Left = sidebarPadding
        btnLogout.Width = sidebarWidth - (sidebarPadding * 2)
        btnLogout.Height = buttonHeight
    End Sub

    Private Sub LoadContentForm(child As Form)
        If currentContent IsNot Nothing Then
            currentContent.Close()
            currentContent.Dispose()
            currentContent = Nothing
        End If

        ' Remove only the main content controls — do not remove the sidebar panel
        ClearMainContentExceptSidebar()

        currentContent = child
        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        child.Dock = DockStyle.Fill
        pnlSuperAdminMainContent.Controls.Add(child)
        child.Show()
    End Sub



    ' Utility: remove everything from pnlTeacherMainContent except the left sidebar
    Private Sub ClearMainContentExceptSidebar()
        For i As Integer = pnlSuperAdminMainContent.Controls.Count - 1 To 0 Step -1
            Dim c As Control = pnlSuperAdminMainContent.Controls(i)
            If c Is pnlTeacherSidebar Then
                Continue For
            End If
            pnlSuperAdminMainContent.Controls.RemoveAt(i)
        Next
    End Sub

    Private Sub LoadFormInPanel(childForm As Form)
        pnlSuperAdminMainContent.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlSuperAdminMainContent.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub ShowHomeContent()
        pnlSuperAdminMainContent.Controls.Clear()
        pnlSuperAdminMainContent.Controls.Add(PictureBox1)
        PictureBox1.BringToFront()
        CenterLogo()
    End Sub

    Private Sub btnSuperAdminManageAdmin_Click(sender As Object, e As EventArgs) Handles btnSuperAdminManageAdmin.Click
        Dim viewSuperAdminManageAdmin As New SuperAdminManageAdminAccounts() With {
            .IsEmbedded = True
        }
        LoadContentForm(viewSuperAdminManageAdmin)
    End Sub

    Private Sub btnSuperAdminManageTea_Click(sender As Object, e As EventArgs) Handles btnSuperAdminManageTea.Click
        Dim viewSuperAdminManageTeacher As New SuperAdminManageTeacherAccounts() With {
         .IsEmbedded = True
        }
        LoadContentForm(viewSuperAdminManageTeacher)
    End Sub

    Private Sub btnBackToDashboard_Click(sender As Object, e As EventArgs) Handles btnBackToDashboard.Click
        ShowHomeContent()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Go back to Form1 (main menu)
        For Each form As Form In Application.OpenForms
            If form.Name = "LoginForm" Then
                form.Show()
                form.WindowState = FormWindowState.Maximized
                Exit For
            End If
        Next
        Me.Close()
    End Sub
End Class