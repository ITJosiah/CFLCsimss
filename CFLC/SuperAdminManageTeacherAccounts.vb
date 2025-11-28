Imports MySql.Data.MySqlClient

Public Class SuperAdminManageTeacherAccounts
    Private Sub SuperAdminManageTeacherAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeForm()
        SetupDataGridView()
        LoadTeacherData()
        SetDefaultValues()
    End Sub

    Private Sub InitializeForm()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BackColor = Color.FromArgb(7, 77, 39)
        Me.Text = "Manage Teacher Accounts"

        ' Initialize controls if not done in designer
        InitializeControls()
        StyleControls()
    End Sub

    Private Sub InitializeControls()
        ' Set default values
        txtbxTeacherUserType.Text = "teacher" ' Lowercase to match your login form
        txtbxTeacherUserType.Enabled = False ' Make it read-only since it's always "teacher"
    End Sub

    Private Sub SetDefaultValues()
        ' Generate initial user_id format display
        txtbxTeacherUserID.Text = "00-0000"
        txtbxTeacherUserID.ForeColor = Color.Gray ' Indicate it's a format hint
    End Sub

    Private Sub SetupDataGridView()
        ' Configure DataGridView appearance and columns
        dgvLoginTeacher.AutoGenerateColumns = False
        dgvLoginTeacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLoginTeacher.ReadOnly = True
        dgvLoginTeacher.AllowUserToAddRows = False

        ' Add columns if not already added in designer
        If dgvLoginTeacher.Columns.Count = 0 Then
            dgvLoginTeacher.Columns.Add("user_id", "User ID")
            dgvLoginTeacher.Columns.Add("password", "Password")
            dgvLoginTeacher.Columns.Add("user_type", "User Type")
            dgvLoginTeacher.Columns.Add("TeacherID", "Teacher ID")
        End If
    End Sub

    Private Sub StyleControls()
        ' Style input controls
        Dim textBoxes() As TextBox = {txtbxTeacherUserID, txtbxTeacherPassword, txtbxTeacherUserType, txtbxTeaAccountTeacherID}

        For Each txt As TextBox In textBoxes
            txt.BackColor = Color.White
            txt.ForeColor = Color.Black
            txt.Font = New Font("Arial", 10, FontStyle.Regular)
            txt.BorderStyle = BorderStyle.FixedSingle
        Next

        ' Style buttons
        btnManTeacherAdd.BackColor = Color.FromArgb(0, 123, 255)
        btnManTeacherAdd.ForeColor = Color.White
        btnManTeacherAdd.FlatStyle = FlatStyle.Flat
        btnManTeacherAdd.FlatAppearance.BorderSize = 0
        btnManTeacherAdd.Font = New Font("Arial", 10, FontStyle.Bold)

        ' Style DataGridView
        dgvLoginTeacher.BackgroundColor = Color.White
        dgvLoginTeacher.BorderStyle = BorderStyle.None
        dgvLoginTeacher.Font = New Font("Arial", 9, FontStyle.Regular)
        dgvLoginTeacher.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub LoadTeacherData()
        Try
            modDBx.openConn(modDBx.db_name)

            Dim query As String = "SELECT user_id, password, user_type, TeacherID FROM login WHERE user_type = 'teacher'"
            Using command As New MySqlCommand(query, modDBx.conn)
                Using adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvLoginTeacher.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading teacher data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnManTeacherAdd_Click(sender As Object, e As EventArgs) Handles btnManTeacherAdd.Click
        If ValidateInputs() Then
            AddTeacherAccount()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Validate User ID format (00-0000)
        If Not IsValidUserID(txtbxTeacherUserID.Text) Then
            MessageBox.Show("Please enter a valid User ID in the format 00-0000", "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherUserID.Focus()
            Return False
        End If

        ' Validate Password
        If String.IsNullOrWhiteSpace(txtbxTeacherPassword.Text) Then
            MessageBox.Show("Please enter a password", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherPassword.Focus()
            Return False
        End If

        If txtbxTeacherPassword.Text.Length < 4 Then
            MessageBox.Show("Password must be at least 4 characters long", "Password Too Short", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherPassword.Focus()
            Return False
        End If

        ' Validate Teacher ID
        If String.IsNullOrWhiteSpace(txtbxTeaAccountTeacherID.Text) Then
            MessageBox.Show("Please enter a Teacher ID", "Teacher ID Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeaAccountTeacherID.Focus()
            Return False
        End If

        ' Check if Teacher ID exists in the system (you might need to adjust this based on your actual teacher table)
        If Not TeacherIDExists(txtbxTeaAccountTeacherID.Text) Then
            MessageBox.Show("The specified Teacher ID does not exist in the system", "Invalid Teacher ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeaAccountTeacherID.Focus()
            Return False
        End If

        ' Check if User ID already exists
        If UserIDExists(txtbxTeacherUserID.Text) Then
            MessageBox.Show("This User ID already exists. Please choose a different one.", "Duplicate User ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherUserID.Focus()
            Return False
        End If

        ' Check if Teacher ID already has an account
        If TeacherHasAccount(txtbxTeaAccountTeacherID.Text) Then
            MessageBox.Show("This Teacher ID already has an account. Cannot create duplicate accounts.", "Account Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeaAccountTeacherID.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function IsValidUserID(userID As String) As Boolean
        ' Validate format: 00-0000 (2 digits, hyphen, 4 digits)
        Dim pattern As String = "^\d{2}-\d{4}$"
        Return System.Text.RegularExpressions.Regex.IsMatch(userID, pattern)
    End Function

    Private Function TeacherIDExists(teacherID As String) As Boolean
        Try
            modDBx.openConn(modDBx.db_name)

            ' NOTE: You need to adjust this query based on your actual teacher table name and structure
            ' If you have a separate teachers table, use: "SELECT COUNT(*) FROM teachers WHERE TeacherID = @TeacherID"
            ' If you don't have a separate table, you might need to remove this validation or adjust it
            Dim query As String = "SELECT COUNT(*) FROM login WHERE TeacherID = @TeacherID"
            Using command As New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@TeacherID", teacherID)
                Return Convert.ToInt32(command.ExecuteScalar()) > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking Teacher ID: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    Private Function UserIDExists(userID As String) As Boolean
        Try
            modDBx.openConn(modDBx.db_name)

            Dim query As String = "SELECT COUNT(*) FROM login WHERE user_id = @user_id"
            Using command As New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@user_id", userID)
                Return Convert.ToInt32(command.ExecuteScalar()) > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking User ID: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    Private Function TeacherHasAccount(teacherID As String) As Boolean
        Try
            modDBx.openConn(modDBx.db_name)

            Dim query As String = "SELECT COUNT(*) FROM login WHERE TeacherID = @TeacherID AND user_type = 'teacher'"
            Using command As New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@TeacherID", teacherID)
                Return Convert.ToInt32(command.ExecuteScalar()) > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking teacher account: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    Private Sub AddTeacherAccount()
        Try
            modDBx.openConn(modDBx.db_name)

            ' Encrypt the password before storing
            Dim encryptedPassword As String = modDBx.Encrypt(txtbxTeacherPassword.Text.Trim())

            Dim query As String = "INSERT INTO login (user_id, password, user_type, TeacherID) VALUES (@user_id, @password, @user_type, @TeacherID)"

            Using command As New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@user_id", txtbxTeacherUserID.Text.Trim())
                command.Parameters.AddWithValue("@password", encryptedPassword)
                command.Parameters.AddWithValue("@user_type", "teacher") ' Always "teacher" (lowercase)
                command.Parameters.AddWithValue("@TeacherID", txtbxTeaAccountTeacherID.Text.Trim())

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Teacher account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInputs()
                    LoadTeacherData() ' Refresh the DataGridView
                Else
                    MessageBox.Show("Failed to create teacher account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error creating teacher account: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub ClearInputs()
        txtbxTeacherUserID.Text = "00-0000"
        txtbxTeacherUserID.ForeColor = Color.Gray
        txtbxTeacherPassword.Clear()
        txtbxTeacherUserType.Text = "teacher" ' Lowercase to match login
        txtbxTeaAccountTeacherID.Clear()
        txtbxTeacherUserID.Focus()
    End Sub

    ' Event handlers for better user experience
    Private Sub txtbxTeacherUserID_Enter(sender As Object, e As EventArgs) Handles txtbxTeacherUserID.Enter
        If txtbxTeacherUserID.Text = "00-0000" Then
            txtbxTeacherUserID.Text = ""
            txtbxTeacherUserID.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtbxTeacherUserID_Leave(sender As Object, e As EventArgs) Handles txtbxTeacherUserID.Leave
        If String.IsNullOrWhiteSpace(txtbxTeacherUserID.Text) Then
            txtbxTeacherUserID.Text = "00-0000"
            txtbxTeacherUserID.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtbxTeacherUserID_TextChanged(sender As Object, e As EventArgs) Handles txtbxTeacherUserID.TextChanged
        ' Real-time format validation
        If txtbxTeacherUserID.Text <> "00-0000" AndAlso txtbxTeacherUserID.ForeColor <> Color.Gray Then
            If IsValidUserID(txtbxTeacherUserID.Text) Then
                txtbxTeacherUserID.ForeColor = Color.Green
            Else
                txtbxTeacherUserID.ForeColor = Color.Red
            End If
        End If
    End Sub

    ' Keyboard shortcuts
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.A) Then
            btnManTeacherAdd.PerformClick()
            Return True
        End If

        If keyData = Keys.Escape Then
            ClearInputs()
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ' Make sure to add these methods for the base class requirements
    Private Sub CenterLogo()
        ' Implementation if needed
    End Sub

    Private Sub PositionSidebarButtons()
        ' Implementation if needed
    End Sub

    Private Sub StyleSidebarButtons()
        ' Implementation if needed
    End Sub
End Class