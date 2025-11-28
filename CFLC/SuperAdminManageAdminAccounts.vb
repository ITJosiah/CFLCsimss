Public Class SuperAdminManageAdminAccounts

    Public Property IsEmbedded As Boolean = False
    Private Sub SuperAdminManageAdminAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        End If
        Me.Text = "Dashboard-SuperAdminManageAdminAccounts"


        PositionSidebarButtons()

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
        Dim buttons() As Button = {btnSuperAdminManageAdmin, btnSuperAdminManageTea, btnSuperAdminManageSysCon,
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

        ' Style logout button differentlyy (red)
        btnLogout.BackColor = Color.Red
        btnLogout.ForeColor = Color.White
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseOverBackColor = Color.DarkRed ' Darker red on hover
        btnLogout.Font = New Font(btnLogout.Font.FontFamily, 12, FontStyle.Bold)
        btnLogout.TextAlign = ContentAlignment.MiddleCenter ' Center text for logout
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

        btnSuperAdminGenerateReports.Top = btnSuperAdminManageSysCon.Bottom + buttonSpacing
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


End Class