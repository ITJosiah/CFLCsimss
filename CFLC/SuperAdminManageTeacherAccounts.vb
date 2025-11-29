Imports MySql.Data.MySqlClient

Public Class SuperAdminManageTeacherAccounts
    Public Property IsEmbedded As Boolean = False

    Private Sub SuperAdminManageTeacherAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEmbedded Then
            ' Only apply full-screen settings if not embedded in another form
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            Me.Bounds = Screen.PrimaryScreen.Bounds
            Me.TopMost = True
            Me.BackColor = Color.FromArgb(7, 77, 39)

            ' Setup sidebar if it exists
            If pnlSuperAdminMainContent IsNot Nothing AndAlso btnLogout IsNot Nothing Then
                StyleSidebarButtons()
                PositionSidebarButtons()
                CenterLogo()
            End If
        Else
            ' When embedded, just set background
            Me.BackColor = Color.FromArgb(7, 77, 39)
        End If

        Me.Text = "Manage Teacher Accounts"

        ' Initialize form components
        InitializeControls()
        SetupDataGridView()
        SetDefaultValues()
        StyleControls()
        LoadTeacherData()
    End Sub

    Private Sub InitializeControls()
        ' Set default values for user type
        If txtbxTeacherUserType IsNot Nothing Then
            txtbxTeacherUserType.Text = "teacher"
            txtbxTeacherUserType.Enabled = False
        End If
    End Sub

    Private Sub SetDefaultValues()
        ' Generate initial user_id format display
        If txtbxTeacherUserID IsNot Nothing Then
            txtbxTeacherUserID.Text = "00-0000"
            txtbxTeacherUserID.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub SetupDataGridView()
        If dgvLoginTeacher Is Nothing Then Return

        ' Clear existing columns first
        dgvLoginTeacher.Columns.Clear()

        ' Configure DataGridView appearance
        dgvLoginTeacher.AutoGenerateColumns = False
        dgvLoginTeacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLoginTeacher.ReadOnly = True
        dgvLoginTeacher.AllowUserToAddRows = False
        dgvLoginTeacher.RowHeadersVisible = False
        dgvLoginTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Create and add columns with DataPropertyName
        Dim colUserID As New DataGridViewTextBoxColumn()
        colUserID.Name = "user_id"
        colUserID.HeaderText = "User ID"
        colUserID.DataPropertyName = "user_id"
        dgvLoginTeacher.Columns.Add(colUserID)

        Dim colPassword As New DataGridViewTextBoxColumn()
        colPassword.Name = "password"
        colPassword.HeaderText = "Password"
        colPassword.DataPropertyName = "password"
        dgvLoginTeacher.Columns.Add(colPassword)

        Dim colUserType As New DataGridViewTextBoxColumn()
        colUserType.Name = "user_type"
        colUserType.HeaderText = "User Type"
        colUserType.DataPropertyName = "user_type"
        dgvLoginTeacher.Columns.Add(colUserType)

        Dim colTeacherID As New DataGridViewTextBoxColumn()
        colTeacherID.Name = "TeacherID"
        colTeacherID.HeaderText = "Teacher ID"
        colTeacherID.DataPropertyName = "TeacherID"
        dgvLoginTeacher.Columns.Add(colTeacherID)
    End Sub

    Private Sub StyleControls()
        ' Style input controls
        Dim textBoxes() As TextBox = {txtbxTeacherUserID, txtbxTeacherPassword,
                                       txtbxTeacherUserType, txtbxTeaAccountTeacherID}

        For Each txt As TextBox In textBoxes
            If txt IsNot Nothing Then
                txt.BackColor = Color.White
                txt.ForeColor = Color.Black
                txt.Font = New Font("Arial", 10, FontStyle.Regular)
                txt.BorderStyle = BorderStyle.FixedSingle
            End If
        Next

        ' Style Add button
        If btnManTeacherAdd IsNot Nothing Then
            btnManTeacherAdd.BackColor = Color.FromArgb(0, 123, 255)
            btnManTeacherAdd.ForeColor = Color.White
            btnManTeacherAdd.FlatStyle = FlatStyle.Flat
            btnManTeacherAdd.FlatAppearance.BorderSize = 0
            btnManTeacherAdd.Font = New Font("Arial", 10, FontStyle.Bold)
        End If

        ' Style DataGridView
        If dgvLoginTeacher IsNot Nothing Then
            dgvLoginTeacher.BackgroundColor = Color.White
            dgvLoginTeacher.BorderStyle = BorderStyle.None
            dgvLoginTeacher.Font = New Font("Arial", 9, FontStyle.Regular)
            dgvLoginTeacher.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        End If
    End Sub

    Private Sub StyleSidebarButtons()
        If btnSuperAdminManageAdmin Is Nothing Then Return

        ' Style all sidebar buttons
        Dim buttons() As Button = {btnSuperAdminManageAdmin, btnSuperAdminManageTea,
                                   btnSuperAdminManageSysCon, btnSuperAdminGenerateReports}

        For Each btn As Button In buttons
            If btn IsNot Nothing Then
                btn.BackColor = Color.LightGray
                btn.ForeColor = Color.Black
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
                btn.FlatAppearance.MouseOverBackColor = Color.Gainsboro
                btn.Font = New Font(btn.Font.FontFamily, 15, FontStyle.Bold)
                btn.TextAlign = ContentAlignment.MiddleLeft
                btn.Padding = New Padding(15, 0, 0, 0)
            End If
        Next

        ' Style logout button differently (red)
        If btnLogout IsNot Nothing Then
            btnLogout.BackColor = Color.Red
            btnLogout.ForeColor = Color.White
            btnLogout.FlatStyle = FlatStyle.Flat
            btnLogout.FlatAppearance.BorderSize = 0
            btnLogout.FlatAppearance.MouseOverBackColor = Color.DarkRed
            btnLogout.Font = New Font(btnLogout.Font.FontFamily, 12, FontStyle.Bold)
            btnLogout.TextAlign = ContentAlignment.MiddleCenter
        End If
    End Sub

    Private Sub LoadTeacherData()
        If dgvLoginTeacher Is Nothing Then Return

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
            MessageBox.Show("Error loading teacher data: " & ex.Message, "Database Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
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
            MessageBox.Show("Please enter a valid User ID in the format 00-0000",
                          "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherUserID.Focus()
            Return False
        End If

        ' Validate Password
        If String.IsNullOrWhiteSpace(txtbxTeacherPassword.Text) Then
            MessageBox.Show("Please enter a password", "Password Required",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherPassword.Focus()
            Return False
        End If

        If txtbxTeacherPassword.Text.Length < 4 Then
            MessageBox.Show("Password must be at least 4 characters long",
                          "Password Too Short", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherPassword.Focus()
            Return False
        End If

        ' Validate Teacher ID
        If String.IsNullOrWhiteSpace(txtbxTeaAccountTeacherID.Text) Then
            MessageBox.Show("Please enter a Teacher ID", "Teacher ID Required",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeaAccountTeacherID.Focus()
            Return False
        End If

        ' Check if Teacher ID exists in the system
        If Not TeacherIDExists(txtbxTeaAccountTeacherID.Text) Then
            MessageBox.Show("The specified Teacher ID does not exist in the system",
                          "Invalid Teacher ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeaAccountTeacherID.Focus()
            Return False
        End If

        ' Check if User ID already exists
        If UserIDExists(txtbxTeacherUserID.Text) Then
            MessageBox.Show("This User ID already exists. Please choose a different one.",
                          "Duplicate User ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherUserID.Focus()
            Return False
        End If

        ' Check if Teacher ID already has an account
        If TeacherHasAccount(txtbxTeaAccountTeacherID.Text) Then
            MessageBox.Show("This Teacher ID already has an account. Cannot create duplicate accounts.",
                          "Account Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

            ' Check if TeacherID exists in the teacher table
            Dim query As String = "SELECT COUNT(*) FROM teacher WHERE TeacherID = @TeacherID"
            Using command As New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@TeacherID", teacherID)
                Return Convert.ToInt32(command.ExecuteScalar()) > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking Teacher ID: " & ex.Message,
                          "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
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
            MessageBox.Show("Error checking User ID: " & ex.Message,
                          "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
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
            MessageBox.Show("Error checking teacher account: " & ex.Message,
                          "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    Private Sub AddTeacherAccount()
        Try
            modDBx.openConn(modDBx.db_name)

            ' Encrypt the password before storing
            Dim encryptedPassword As String = modDBx.Encrypt(txtbxTeacherPassword.Text.Trim())

            Dim query As String = "INSERT INTO login (user_id, password, user_type, TeacherID) " &
                                "VALUES (@user_id, @password, @user_type, @TeacherID)"

            Using command As New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@user_id", txtbxTeacherUserID.Text.Trim())
                command.Parameters.AddWithValue("@password", encryptedPassword)
                command.Parameters.AddWithValue("@user_type", "teacher")
                command.Parameters.AddWithValue("@TeacherID", txtbxTeaAccountTeacherID.Text.Trim())

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Teacher account created successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInputs()
                    LoadTeacherData()
                Else
                    MessageBox.Show("Failed to create teacher account", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error creating teacher account: " & ex.Message,
                          "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub ClearInputs()
        If txtbxTeacherUserID IsNot Nothing Then
            txtbxTeacherUserID.Text = "00-0000"
            txtbxTeacherUserID.ForeColor = Color.Gray
        End If

        If txtbxTeacherPassword IsNot Nothing Then
            txtbxTeacherPassword.Clear()
        End If

        If txtbxTeacherUserType IsNot Nothing Then
            txtbxTeacherUserType.Text = "teacher"
        End If

        If txtbxTeaAccountTeacherID IsNot Nothing Then
            txtbxTeaAccountTeacherID.Clear()
        End If

        If txtbxTeacherUserID IsNot Nothing Then
            txtbxTeacherUserID.Focus()
        End If
    End Sub

    Private Sub CenterLogo()
        If pnlSuperAdminMainContent Is Nothing OrElse PictureBox1 Is Nothing Then Return
        If Not pnlSuperAdminMainContent.Controls.Contains(PictureBox1) Then Return

        Dim areaWidth As Integer = pnlSuperAdminMainContent.ClientSize.Width
        Dim areaHeight As Integer = pnlSuperAdminMainContent.ClientSize.Height

        PictureBox1.Left = (areaWidth - PictureBox1.Width) \ 2
        PictureBox1.Top = (areaHeight - PictureBox1.Height) \ 2
    End Sub

    Private Sub PositionSidebarButtons()
        If btnLogout Is Nothing Then Return

        Dim sidebarWidth As Integer = 250
        Dim sidebarPadding As Integer = 10
        Dim buttonHeight As Integer = 70
        Dim buttonSpacing As Integer = 50
        Dim startTop As Integer = 60

        If btnSuperAdminManageAdmin IsNot Nothing Then
            btnSuperAdminManageAdmin.Top = startTop
            btnSuperAdminManageAdmin.Left = sidebarPadding
            btnSuperAdminManageAdmin.Width = sidebarWidth - (sidebarPadding * 2)
            btnSuperAdminManageAdmin.Height = buttonHeight
        End If

        If btnSuperAdminManageTea IsNot Nothing Then
            btnSuperAdminManageTea.Top = btnSuperAdminManageAdmin.Bottom + buttonSpacing
            btnSuperAdminManageTea.Left = sidebarPadding
            btnSuperAdminManageTea.Width = sidebarWidth - (sidebarPadding * 2)
            btnSuperAdminManageTea.Height = buttonHeight
        End If

        If btnSuperAdminManageSysCon IsNot Nothing Then
            btnSuperAdminManageSysCon.Top = btnSuperAdminManageTea.Bottom + buttonSpacing
            btnSuperAdminManageSysCon.Left = sidebarPadding
            btnSuperAdminManageSysCon.Width = sidebarWidth - (sidebarPadding * 2)
            btnSuperAdminManageSysCon.Height = buttonHeight
        End If

        If btnSuperAdminGenerateReports IsNot Nothing Then
            btnSuperAdminGenerateReports.Top = btnSuperAdminManageSysCon.Bottom + buttonSpacing
            btnSuperAdminGenerateReports.Left = sidebarPadding
            btnSuperAdminGenerateReports.Width = sidebarWidth - (sidebarPadding * 2)
            btnSuperAdminGenerateReports.Height = buttonHeight
        End If

        ' Position logout button at the bottom
        Dim logoutBottomPadding As Integer = 30
        btnLogout.Top = Me.ClientSize.Height - buttonHeight - logoutBottomPadding
        btnLogout.Left = sidebarPadding
        btnLogout.Width = sidebarWidth - (sidebarPadding * 2)
        btnLogout.Height = buttonHeight
    End Sub

    Private Sub LoadFormInPanel(childForm As Form)
        If pnlSuperAdminMainContent Is Nothing Then Return

        pnlSuperAdminMainContent.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        ' Set IsEmbedded property if it exists
        Dim embeddedProperty = childForm.GetType().GetProperty("IsEmbedded")
        If embeddedProperty IsNot Nothing Then
            embeddedProperty.SetValue(childForm, True)
        End If

        pnlSuperAdminMainContent.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub ShowHomeContent()
        If pnlSuperAdminMainContent Is Nothing OrElse PictureBox1 Is Nothing Then Return

        pnlSuperAdminMainContent.Controls.Clear()
        pnlSuperAdminMainContent.Controls.Add(PictureBox1)
        PictureBox1.BringToFront()
        CenterLogo()
    End Sub

    ' Event Handlers
    Private Sub btnSuperAdminManageAdmin_Click(sender As Object, e As EventArgs) Handles btnSuperAdminManageAdmin.Click
        LoadFormInPanel(New SuperAdminManageAdminAccounts())
    End Sub

    Private Sub btnSuperAdminManageTea_Click(sender As Object, e As EventArgs) Handles btnSuperAdminManageTea.Click
        ' Don't load the same form recursively - instead show message or do nothing
        MessageBox.Show("You are already viewing the Teacher Accounts management screen.",
                       "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

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
        If txtbxTeacherUserID.Text <> "00-0000" AndAlso txtbxTeacherUserID.ForeColor <> Color.Gray Then
            If IsValidUserID(txtbxTeacherUserID.Text) Then
                txtbxTeacherUserID.ForeColor = Color.Green
            Else
                txtbxTeacherUserID.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub AdminDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Not IsEmbedded Then
            CenterLogo()
            PositionSidebarButtons()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Ctrl+A to add account
        If keyData = (Keys.Control Or Keys.A) Then
            If btnManTeacherAdd IsNot Nothing Then
                btnManTeacherAdd.PerformClick()
            End If
            Return True
        End If

        ' Escape to clear inputs
        If keyData = Keys.Escape Then
            If IsEmbedded Then
                ClearInputs()
            Else
                ExitFullScreen()
            End If
            Return True
        End If

        ' F for fullscreen (only if not embedded)
        If keyData = Keys.F AndAlso Not IsEmbedded Then
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

    Private Sub btnManTeaDelete_Click(sender As Object, e As EventArgs) Handles btnManTeaDelete.Click
        If dgvLoginTeacher.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a teacher account to delete", "No Selection",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the user_id from the selected row
        Dim userID As String = dgvLoginTeacher.SelectedRows(0).Cells("user_id").Value.ToString()

        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to delete the teacher account with User ID: " & userID & "?" & vbCrLf & vbCrLf &
        "This action cannot be undone.",
        "Confirm Deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            DeleteTeacherAccount(userID)
        End If
    End Sub

    Private Sub DeleteTeacherAccount(userID As String)
        Try
            modDBx.openConn(modDBx.db_name)

            Dim query As String = "DELETE FROM login WHERE user_id = @user_id AND user_type = 'teacher'"
            Using command As New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@user_id", userID)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Teacher account deleted successfully!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInputs()
                    LoadTeacherData()
                Else
                    MessageBox.Show("Failed to delete teacher account", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting teacher account: " & ex.Message,
                      "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnManTeaUpdate_Click(sender As Object, e As EventArgs) Handles btnManTeaUpdate.Click
        If dgvLoginTeacher.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a teacher account to update", "No Selection",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ValidateInputsForUpdate() Then
            UpdateTeacherAccount()
        End If
    End Sub

    Private Function ValidateInputsForUpdate() As Boolean
        ' Validate User ID format (00-0000)
        If Not IsValidUserID(txtbxTeacherUserID.Text) Then
            MessageBox.Show("Please enter a valid User ID in the format 00-0000",
                      "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherUserID.Focus()
            Return False
        End If

        ' Validate Password (optional for update - only validate if not empty)
        If Not String.IsNullOrWhiteSpace(txtbxTeacherPassword.Text) Then
            If txtbxTeacherPassword.Text.Length < 4 Then
                MessageBox.Show("Password must be at least 4 characters long",
                          "Password Too Short", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtbxTeacherPassword.Focus()
                Return False
            End If
        End If

        ' Validate Teacher ID
        If String.IsNullOrWhiteSpace(txtbxTeaAccountTeacherID.Text) Then
            MessageBox.Show("Please enter a Teacher ID", "Teacher ID Required",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeaAccountTeacherID.Focus()
            Return False
        End If

        ' Check if Teacher ID exists in the system
        If Not TeacherIDExists(txtbxTeaAccountTeacherID.Text) Then
            MessageBox.Show("The specified Teacher ID does not exist in the system",
                      "Invalid Teacher ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeaAccountTeacherID.Focus()
            Return False
        End If

        ' Get the original user_id from the selected row
        Dim originalUserID As String = dgvLoginTeacher.SelectedRows(0).Cells("user_id").Value.ToString()

        ' Check if User ID already exists (only if it's different from the original)
        If txtbxTeacherUserID.Text <> originalUserID AndAlso UserIDExists(txtbxTeacherUserID.Text) Then
            MessageBox.Show("This User ID already exists. Please choose a different one.",
                      "Duplicate User ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherUserID.Focus()
            Return False
        End If

        ' Get the original teacher_id from the selected row
        Dim originalTeacherID As String = dgvLoginTeacher.SelectedRows(0).Cells("TeacherID").Value.ToString()

        ' Check if Teacher ID already has an account (only if it's different from the original)
        If txtbxTeaAccountTeacherID.Text <> originalTeacherID AndAlso TeacherHasAccount(txtbxTeaAccountTeacherID.Text) Then
            MessageBox.Show("This Teacher ID already has an account. Cannot assign duplicate accounts.",
                      "Account Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeaAccountTeacherID.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub UpdateTeacherAccount()
        Try
            ' Get the original user_id from the selected row
            Dim originalUserID As String = dgvLoginTeacher.SelectedRows(0).Cells("user_id").Value.ToString()

            modDBx.openConn(modDBx.db_name)

            Dim query As String
            Dim command As MySqlCommand

            ' Check if password is being updated
            If String.IsNullOrWhiteSpace(txtbxTeacherPassword.Text) Then
                ' Update without changing password
                query = "UPDATE login SET user_id = @new_user_id, TeacherID = @TeacherID " &
                   "WHERE user_id = @original_user_id AND user_type = 'teacher'"
                command = New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@new_user_id", txtbxTeacherUserID.Text.Trim())
                command.Parameters.AddWithValue("@TeacherID", txtbxTeaAccountTeacherID.Text.Trim())
                command.Parameters.AddWithValue("@original_user_id", originalUserID)
            Else
                ' Update with new password
                Dim encryptedPassword As String = modDBx.Encrypt(txtbxTeacherPassword.Text.Trim())
                query = "UPDATE login SET user_id = @new_user_id, password = @password, TeacherID = @TeacherID " &
                   "WHERE user_id = @original_user_id AND user_type = 'teacher'"
                command = New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@new_user_id", txtbxTeacherUserID.Text.Trim())
                command.Parameters.AddWithValue("@password", encryptedPassword)
                command.Parameters.AddWithValue("@TeacherID", txtbxTeaAccountTeacherID.Text.Trim())
                command.Parameters.AddWithValue("@original_user_id", originalUserID)
            End If

            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Teacher account updated successfully!", "Success",
                          MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearInputs()
                LoadTeacherData()
            Else
                MessageBox.Show("Failed to update teacher account", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            command.Dispose()

        Catch ex As Exception
            MessageBox.Show("Error updating teacher account: " & ex.Message,
                      "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub
End Class