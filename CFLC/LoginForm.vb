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

        ' Initialize Show Password CheckBox
        InitializeShowPasswordCheckBox()

        ' Center the controls
        CenterControls()

        ' Style the login button
        btnLogin.BackColor = Color.FromArgb(31, 168, 67)
        btnLogin.ForeColor = Color.White
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 140, 55)
        btnLogin.Cursor = Cursors.Hand

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

    Private Sub CenterControls()
        txtUserID.Size = New Size(200, 35)
        txtPassword.Size = New Size(200, 35)

        ' Center the logo
        Dim verticalOffsetLogo As Integer = 40
        PictureBox1.Left = (Me.ClientSize.Width - PictureBox1.Width) \ 2
        PictureBox1.Top = (Me.ClientSize.Height - PictureBox1.Height) \ 3 - verticalOffsetLogo

        ' Center the title
        lblTitle1.Left = (Me.ClientSize.Width - lblTitle1.Width) \ 2
        lblTitle1.Top = PictureBox1.Bottom + 10

        ' -------- USER ID --------
        lblUserID.Left = (Me.ClientSize.Width - txtUserID.Width) \ 2
        txtUserID.Left = lblUserID.Left

        ' -------- PASSWORD --------
        lblPassword.Left = txtUserID.Left
        txtPassword.Left = txtUserID.Left

        ' CheckBox aligned right below password
        CheckBoxPass.Left = txtPassword.Left + txtPassword.Width - CheckBoxPass.Width
        CheckBoxPass.Top = txtPassword.Bottom + 5

        ' -------- LOGIN BUTTON --------
        btnLogin.Left = (Me.ClientSize.Width - btnLogin.Width) \ 2
        btnLogin.Top = txtPassword.Bottom + 30
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

        ' Attempt login
        Dim userLevel As String = ValidateLogin(txtUserID.Text.Trim(), txtPassword.Text)

        If userLevel IsNot Nothing Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Navigate to appropriate dashboard based on user level
            Select Case userLevel.ToLower()
                Case "admin", "superadmin"
                    Dim adminDashboard As New AdminDashboard()
                    adminDashboard.Show()
                Case "teacher"
                    ' Create and show teacher dashboard
                    ' Dim teacherDashboard As New TeacherDashboard()
                    ' teacherDashboard.Show()
                    MessageBox.Show("Teacher dashboard would open here", "Teacher Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case Else
                    MessageBox.Show($"Welcome {userLevel}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select

            Me.Close()
        Else
            MessageBox.Show("Invalid User ID or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateLogin(userID As String, password As String) As String
        Try
            modDBx.openConn(modDBx.db_name)

            ' Query to get the encrypted password and user type from database
            Dim query As String = "SELECT Password, user_type FROM login WHERE user_id = @user_id"

            Using cmd As New MySqlCommand(query, modDBx.conn)
                cmd.Parameters.AddWithValue("@user_id", userID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Get the encrypted password and user type from database
                        Dim encryptedPasswordFromDB As String = reader("Password").ToString()
                        Dim userType As String = reader("user_type").ToString()

                        ' Decrypt the password from database and compare with user input
                        Dim decryptedPassword As String = modDBx.Decrypt(encryptedPasswordFromDB)

                        ' Compare the decrypted password with user input
                        If decryptedPassword = password Then
                            Return userType ' Return user type if login successful
                        Else
                            Return Nothing ' Password doesn't match
                        End If
                    Else
                        Return Nothing ' User not found
                    End If
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
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
End Class