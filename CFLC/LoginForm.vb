Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BringToFront()
        Me.BackColor = Color.FromArgb(7, 77, 39)

        txtUserID.Size = New Size(200, 35)
        txtPassword.Size = New Size(200, 35)

        ' Initialize User Level ComboBox
        InitializeUserLevelComboBox()

        ' Initialize Show Password CheckBox
        InitializeShowPasswordCheckBox()

        ' Center the controls
        CenterControls()

        ' Style the login button
        btnLogin.BackColor = Me.BackColor
        btnLogin.ForeColor = Color.White
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderSize = 0

        ' Style the back button
        btnBack.BackColor = Me.BackColor
        btnBack.ForeColor = Color.White
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub InitializeShowPasswordCheckBox()
        ' Initialize Show Password CheckBox
        CheckBoxPass.Text = "Show Password"
        CheckBoxPass.ForeColor = Color.Black
        CheckBoxPass.BackColor = Color.Transparent
        CheckBoxPass.FlatStyle = FlatStyle.Flat
        CheckBoxPass.AutoSize = True

        ' Set initial state - password hidden
        txtPassword.UseSystemPasswordChar = True
        CheckBoxPass.Checked = False
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Dim keyOnly As Keys = keyData And Keys.KeyCode

        ' Find the deepest focused control inside the form
        Dim focused As Control = GetDeepestFocusedControl()

        ' If focused control is a TextBoxBase and editable, handle F insertion
        If keyOnly = Keys.F AndAlso focused IsNot Nothing AndAlso TypeOf focused Is TextBoxBase Then
            Dim tbBase = DirectCast(focused, TextBoxBase)
            If tbBase.Enabled AndAlso Not tbBase.ReadOnly Then
                ' ... (your existing F key handling code)
                Return True ' consumed
            End If
        End If

        ' Handle Escape and F keys for fullscreen
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

    Private Sub InitializeUserLevelComboBox()
        ' Populate User Level dropdown
        cmbBoxUserLvl.Items.Clear()
        cmbBoxUserLvl.DropDownStyle = ComboBoxStyle.DropDownList
        cmbBoxUserLvl.Items.Add("Teacher")
        cmbBoxUserLvl.Items.Add("Admin")
        cmbBoxUserLvl.Items.Add("SuperAdmin")
    End Sub
    Private Sub CenterControls()
        ' Set consistent sizes
        txtUserID.Size = New Size(200, 35)
        txtPassword.Size = New Size(200, 35)
        cmbBoxUserLvl.Size = New Size(200, 35)

        ' Calculate center position once
        Dim centerX As Integer = (Me.ClientSize.Width - txtUserID.Width) \ 2

        ' Center the logo
        Dim verticalOffsetLogo As Integer = 40
        PictureBox1.Left = (Me.ClientSize.Width - PictureBox1.Width) \ 2
        PictureBox1.Top = (Me.ClientSize.Height - PictureBox1.Height) \ 3 - verticalOffsetLogo

        ' Center the title
        lblTitle1.Left = (Me.ClientSize.Width - lblTitle1.Width) \ 2
        lblTitle1.Top = PictureBox1.Bottom + 20

        ' -------- USER ID SECTION --------
        lblUserID.Top = lblTitle1.Bottom + 30
        lblUserID.Left = centerX
        txtUserID.Top = lblUserID.Bottom + 8
        txtUserID.Left = centerX

        ' -------- PASSWORD SECTION --------
        lblPassword.Top = txtUserID.Bottom + 20
        lblPassword.Left = centerX
        txtPassword.Top = lblPassword.Bottom + 8
        txtPassword.Left = centerX

        ' Show Password Checkbox (right aligned under password box)
        CheckBoxPass.Top = txtPassword.Bottom + 8
        CheckBoxPass.Left = txtPassword.Left + txtPassword.Width - CheckBoxPass.Width

        ' -------- USER LEVEL SECTION --------
        lblUserLvl.Top = CheckBoxPass.Bottom + 25
        lblUserLvl.Left = centerX
        cmbBoxUserLvl.Top = lblUserLvl.Bottom + 8
        cmbBoxUserLvl.Left = centerX

        ' -------- LOGIN BUTTON --------
        btnLogin.Top = cmbBoxUserLvl.Bottom + 30
        btnLogin.Left = (Me.ClientSize.Width - btnLogin.Width) \ 2

        ' Ensure all labels are fully visible
        EnsureLabelVisibility()
    End Sub

    Private Sub EnsureLabelVisibility()
        ' Make sure labels are wide enough to show full text
        lblUserID.AutoSize = True
        lblPassword.AutoSize = True
        lblUserLvl.AutoSize = True

        ' Optional: Set minimum width if needed
        If lblUserID.Width < 80 Then lblUserID.Width = 80
        If lblPassword.Width < 80 Then lblPassword.Width = 80
        If lblUserLvl.Width < 80 Then lblUserLvl.Width = 80
    End Sub


    Private Sub LoginForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterControls()
    End Sub

    ' Show/Hide Password when checkbox is clicked
    Private Sub CheckBoxPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass.CheckedChanged
        If CheckBoxPass.Checked Then
            ' Show password
            txtPassword.UseSystemPasswordChar = False
        Else
            ' Hide password
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    ' ... (Keep the existing ProcessCmdKey, ExitFullScreen, MakeItFullScreen, and Resize methods)

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validate inputs
        If String.IsNullOrWhiteSpace(txtUserID.Text) Then
            MessageBox.Show("Please enter User ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserID.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        If cmbBoxUserLvl.SelectedIndex = -1 Then
            MessageBox.Show("Please select User Level", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbBoxUserLvl.Focus()
            Return
        End If

        ' Attempt login
        Dim actualTeacherID As String = ValidateLogin(txtUserID.Text.Trim(), txtPassword.Text, cmbBoxUserLvl.SelectedItem.ToString())

        If ValidateLogin(txtUserID.Text.Trim(), txtPassword.Text, cmbBoxUserLvl.SelectedItem.ToString()) Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()

            Select Case cmbBoxUserLvl.SelectedItem.ToString().ToLower()
                Case "admin"
                    Dim adminDashboard As New AdminDashboard()
                    adminDashboard.Show()
                Case "superadmin"
                    Dim superAdminDashboard As New SuperAdminDashboard()
                    superAdminDashboard.Show()
                Case "teacher"
                    ' Only get TeacherID for teachers
                    Dim teacherID As String = GetTeacherID(txtUserID.Text.Trim())
                    Dim teacherDashboard As New TeacherDashboard()
                    teacherDashboard.TeacherID = teacherID
                    teacherDashboard.Show()
            End Select

            Me.Close()
        Else
            MessageBox.Show("Invalid User ID, Password, or User Level", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateLogin(userID As String, password As String, userLevel As String) As Boolean
        Try
            modDBx.openConn("cflc_db")

            Dim query As String = "SELECT password FROM login WHERE user_id = @user_id AND user_type = @user_type"

            Using cmd As New MySqlCommand(query, modDBx.conn)
                cmd.Parameters.AddWithValue("@user_id", userID)
                cmd.Parameters.AddWithValue("@user_type", userLevel)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim encryptedPasswordFromDB As String = reader("password").ToString()
                        Dim decryptedPassword As String = modDBx.Decrypt(encryptedPasswordFromDB)
                        Return decryptedPassword = password
                    End If
                End Using
            End Using

            Return False

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function


    Private Function GetTeacherID(userID As String) As String
        Try
            modDBx.openConn("clfc_db")
            Dim query As String = "SELECT TeacherID FROM login WHERE user_id = @user_id"

            Using cmd As New MySqlCommand(query, modDBx.conn)
                cmd.Parameters.AddWithValue("@user_id", userID)
                Dim result = cmd.ExecuteScalar()
                Return If(result IsNot Nothing, result.ToString(), "")
            End Using

        Catch ex As Exception
            Return ""
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Go back to Form1
        For Each form As Form In Application.OpenForms
            If form.Name = "Form1" Then
                form.Show()
                form.WindowState = FormWindowState.Maximized
                Exit For
            End If
        Next
        Me.Close()
    End Sub

    Private Sub MakeItFullScreen()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BringToFront()
    End Sub

    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged

    End Sub
End Class