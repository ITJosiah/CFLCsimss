Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties sadasdada

        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BringToFront()
        Me.BackColor = Color.FromArgb(7, 77, 39)

        txtUserID.Size = New Size(200, 35)
        txtPassword.Size = New Size(200, 35)

        ' Center the controls
        CenterControls()

        ' Style the login button
        btnLogin.BackColor = Me.BackColor
        btnLogin.ForeColor = Color.White
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderSize = 0

        ' Style the back button (if you added one)
        ' Uncomment these lines if you added btnBack:
        ' btnBack.BackColor = Me.BackColor
        ' btnBack.ForeColor = Color.White
        ' btnBack.FlatStyle = FlatStyle.Flat
        ' btnBack.FlatAppearance.BorderSize = 0
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Dim keyOnly As Keys = keyData And Keys.KeyCode

        ' Find the deepest focused control inside the form
        Dim focused As Control = GetDeepestFocusedControl()

        ' If focused control is a TextBoxBase (TextBox or RichTextBox, etc.) and editable, handle F insertion
        If keyOnly = Keys.F AndAlso focused IsNot Nothing AndAlso TypeOf focused Is TextBoxBase Then
            Dim tbBase = DirectCast(focused, TextBoxBase)
            If tbBase.Enabled AndAlso Not tbBase.ReadOnly Then
                ' Determine character case using Shift and CapsLock
                Dim shiftPressed As Boolean = (Control.ModifierKeys And Keys.Shift) = Keys.Shift
                Dim capsOn As Boolean = Control.IsKeyLocked(Keys.CapsLock)
                Dim useUpper As Boolean = shiftPressed Xor capsOn
                Dim ch As Char = If(useUpper, "F"c, "f"c)

                ' Insert character respecting selection/replacement
                Dim s As String = tbBase.Text
                Dim selStart As Integer = tbBase.SelectionStart
                Dim selLen As Integer = tbBase.SelectionLength

                Dim before As String = If(selStart > 0, s.Substring(0, selStart), String.Empty)
                Dim afterIndex As Integer = Math.Min(selStart + selLen, s.Length)
                Dim after As String = If(afterIndex < s.Length, s.Substring(afterIndex), String.Empty)

                tbBase.Text = before & ch & after
                tbBase.SelectionStart = selStart + 1
                tbBase.SelectionLength = 0

                Return True ' consumed
            End If
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)

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

    ' Walk ActiveControl chain to the deepest focused control
    Private Function GetDeepestFocusedControl() As Control
        Dim c As Control = Me.ActiveControl
        While c IsNot Nothing
            Dim container = TryCast(c, ContainerControl)
            If container IsNot Nothing AndAlso container.ActiveControl IsNot Nothing Then
                c = container.ActiveControl
            Else
                Exit While
            End If
        End While
        Return c
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
    Private Sub CenterControls()

        txtUserID.Size = New Size(200, 35)
        txtPassword.Size = New Size(200, 35)

        ' Center the logo
        Dim verticalOffsetLogo As Integer = 40
        PictureBox1.Left = (Me.ClientSize.Width - PictureBox1.Width) \ 2
        PictureBox1.Top = (Me.ClientSize.Height - PictureBox1.Height) \ 3 - verticalOffsetLogo

        ' Center the title label
        lblTitle1.Left = (Me.ClientSize.Width - lblTitle1.Width) \ 2
        lblTitle1.Top = PictureBox1.Bottom + 10 ' Space between logo and text

        ' Center User ID label and textbox
        lblUserID.Left = (Me.ClientSize.Width - lblUserID.Width) \ 2
        txtUserID.Left = (Me.ClientSize.Width - txtUserID.Width) \ 2

        ' Center Password label and textbox
        lblPassword.Left = (Me.ClientSize.Width - lblPassword.Width) \ 2
        txtPassword.Left = (Me.ClientSize.Width - txtPassword.Width) \ 2

        ' Center Login button
        btnLogin.Left = (Me.ClientSize.Width - btnLogin.Width) \ 2

        ' Position login controls below the title label
        Dim startTop As Integer = lblTitle1.Bottom + 40 ' Space below title

        lblUserID.Top = startTop
        txtUserID.Top = lblUserID.Bottom + 10

        lblPassword.Top = txtUserID.Bottom + 20
        txtPassword.Top = lblPassword.Bottom + 10

        btnLogin.Top = txtPassword.Bottom + 30
    End Sub

    Private Sub LoginForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterControls()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Add your login validation logic here
        Dim userID As String = txtUserID.Text
        Dim password As String = txtPassword.Text

        ' Example validation (replace with your actual validation)
        If userID = "" AndAlso password = "" Then
            ' Navigate to Admin Dashboard
            Dim adminDashboard As New AdminDashboard()
            adminDashboard.Show()
            Me.Close()
        ElseIf userID = "teacher" AndAlso password = "" Then
            Dim teacherDashboard As New TeacherDashboard()
            teacherDashboard.Show()
            Me.Close()
        ElseIf userID = "superadmin" AndAlso password = "" Then
            Dim superAdminDashboard As New SuperAdminDashboard()
            superAdminDashboard.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid User ID or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Go back to Form1
        ' Find Form1 in the open forms and show it
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

    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged

    End Sub
End Class