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


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' If TextBox exists and has focus and key is F, insert the char and consume the key.
        If (keyData And Keys.KeyCode) = Keys.F AndAlso
           txtbxAdminPassword IsNot Nothing AndAlso txtbxAdminPassword.Focused Then

            Dim tb = txtbxAdminPassword
            Dim s As String = tb.Text
            Dim selStart As Integer = tb.SelectionStart
            Dim selLen As Integer = tb.SelectionLength

            Dim shiftPressed As Boolean = (Control.ModifierKeys And Keys.Shift) = Keys.Shift
            Dim capsOn As Boolean = Control.IsKeyLocked(Keys.CapsLock)
            Dim useUpper As Boolean = shiftPressed Xor capsOn
            Dim ch As Char = If(useUpper, "F"c, "f"c)

            Dim before As String = If(selStart > 0, s.Substring(0, selStart), String.Empty)
            Dim afterIndex As Integer = Math.Min(selStart + selLen, s.Length)
            Dim after As String = If(afterIndex < s.Length, s.Substring(afterIndex), String.Empty)

            tb.Text = before & ch & after
            tb.SelectionStart = selStart + 1
            tb.SelectionLength = 0

            Return True

        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class