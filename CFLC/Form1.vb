Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BringToFront()


        modDBx.UpdateConnectionString()

        If modDBx.isConnectedToLocalServer() Then
            MsgBox("Connected!")
        Else
            MsgBox("Failed to connect!")
        End If


        Me.WindowState = FormWindowState.Maximized
        CenterUI()
        ' Do not set FormBorderStyle = None to keep buttons visible
        ' Optional: Me.TopMost = True  ' Uncomment if you want it on top of other windows

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
        Me.WindowState = FormWindowState.Normal
        Me.TopMost = False
    End Sub
    Private Sub MakeItFullScreen()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BringToFront()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterUI()
    End Sub


    Private Sub CenterUI()
        Dim verticalOffsetLogo As Integer = 40
        PictureBox1.Left = (Me.ClientSize.Width - PictureBox1.Width) \ 2
        PictureBox1.Top = (Me.ClientSize.Height - PictureBox1.Height) \ 3 - verticalOffsetLogo

        lblTitle.Left = (Me.ClientSize.Width - lblTitle.Width) \ 2
        lblTitle.Top = PictureBox1.Bottom + 10 'space between logo and text

        ' Center the buttons horizontally and stack them vertically
        Dim buttonSpacing As Integer = 20 ' Space between buttons
        Dim firstButtonTop As Integer = lblTitle.Bottom + 40 ' Space below text

        ' Center each button horizontally
        btnAdministrator.Left = (Me.ClientSize.Width - btnAdministrator.Width) \ 2
        btnAdministrator.Top = firstButtonTop

        btnTeacher.Left = (Me.ClientSize.Width - btnTeacher.Width) \ 2
        btnTeacher.Top = btnAdministrator.Bottom + buttonSpacing

        btnSuperAdmin.Left = (Me.ClientSize.Width - btnSuperAdmin.Width) \ 2
        btnSuperAdmin.Top = btnTeacher.Bottom + buttonSpacing
    End Sub

    Private Sub btnAdministrator_Click(sender As Object, e As EventArgs) Handles btnAdministrator.Click, btnTeacher.Click, btnSuperAdmin.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Hide() ' Hide Form1, or use Me.Close() if you want to close it
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class

