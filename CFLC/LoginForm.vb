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

<<<<<<< HEAD
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
=======
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
>>>>>>> f2ba93c7172801b8894d6aef3a966eb326c85c8b
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

        txtUserID.Size = New Size(200, 35)
        txtPassword.Size = New Size(200, 35)
        cmbBoxUserLvl.Size = New Size(200, 35)

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
        btnLogin.Top = cmbBoxUserLvl.Bottom + 30

        ' -------- USER LEVEL (CLEAN + CORRECTED) --------

        Dim sectionSpacing As Integer = 20   ' distance between controls sections
        Dim rowSpacing As Integer = 10       ' space between label and textbox

        ' Position User Level label under Password with matching spacing
        lblUserLvl.Top = txtPassword.Bottom + sectionSpacing

        ' Make combobox half width
        cmbBoxUserLvl.Width = txtPassword.Width \ 2

        ' Combobox under UserLevel label
        cmbBoxUserLvl.Top = lblUserLvl.Bottom + rowSpacing

        ' Align combobox to the RIGHT under password
        cmbBoxUserLvl.Left = txtPassword.Left + txtPassword.Width - cmbBoxUserLvl.Width

        ' Label directly to the LEFT of combobox (same row)
        lblUserLvl.Top = cmbBoxUserLvl.Top + (cmbBoxUserLvl.Height - lblUserLvl.Height) \ 2
        lblUserLvl.Left = cmbBoxUserLvl.Left - lblUserLvl.Width - 10

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
        If ValidateLogin(txtUserID.Text.Trim(), txtPassword.Text, cmbBoxUserLvl.SelectedItem.ToString()) Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Navigate to appropriate dashboard based on user level
            Select Case cmbBoxUserLvl.SelectedItem.ToString().ToLower()
                Case "admin", "superadmin"
                    Dim adminDashboard As New AdminDashboard()
                    adminDashboard.Show()
                Case "teacher"
                    ' Create and show teacher dashboard
                    ' Dim teacherDashboard As New TeacherDashboard()
                    ' teacherDashboard.Show()
                    MessageBox.Show("Teacher dashboard would open here", "Teacher Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select

            Me.Close()
        Else
            MessageBox.Show("Invalid User ID, Password, or User Level", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateLogin(userID As String, password As String, userLevel As String) As Boolean
        Try
            modDBx.openConn(modDBx.db_name)

            ' Query to get the encrypted password from database
            Dim query As String = "SELECT Password FROM login WHERE user_id = @user_id AND user_type = @user_type"

            Using cmd As New MySqlCommand(query, modDBx.conn)
                cmd.Parameters.AddWithValue("@user_id", userID)
                cmd.Parameters.AddWithValue("@user_type", userLevel)

                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    ' Get the encrypted password from database
                    Dim encryptedPasswordFromDB As String = result.ToString()

                    ' Decrypt the password from database and compare with user input
                    Dim decryptedPassword As String = modDBx.Decrypt(encryptedPasswordFromDB)

                    ' Compare the decrypted password with user input
                    Return decryptedPassword = password
                Else
                    Return False ' User not found
                End If
            End Using

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