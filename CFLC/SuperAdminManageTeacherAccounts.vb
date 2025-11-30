Imports System.Text
Imports MySql.Data.MySqlClient

Public Class SuperAdminManageTeacherAccounts
    Public Property IsEmbedded As Boolean = False
    Private currentUserID As String = String.Empty
    Private originalData As New Dictionary(Of String, Object)()

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
        SetupTeacherDataGridView()
        SetDefaultValues()
        StyleControls()
        LoadTeacherData()
        LoadTeacherInfoData()

        ' Ensure Add button is enabled by default
        btnManTeacherAdd.Enabled = True

        ' Ensure the grid doesn't auto-select the first row on load
        dgvLoginTeacher.ClearSelection()
        dgvTeacher.ClearSelection()
        Try
            If dgvLoginTeacher.Rows.Count > 0 AndAlso dgvLoginTeacher.Columns.Count > 0 Then
                dgvLoginTeacher.CurrentCell = Nothing
            End If
            If dgvTeacher.Rows.Count > 0 AndAlso dgvTeacher.Columns.Count > 0 Then
                dgvTeacher.CurrentCell = Nothing
            End If
        Catch
            ' ignore potential layout timing exceptions
        End Try
        currentUserID = String.Empty
    End Sub

    Private Sub InitializeControls()
        ' Set default values for user type
        If txtbxTeacherUserType IsNot Nothing Then
            txtbxTeacherUserType.Text = "teacher"
            txtbxTeacherUserType.Enabled = False
        End If

        ' Initialize search textbox with placeholder
        If txtbxManTeaSearch IsNot Nothing Then
            txtbxManTeaSearch.Text = "Search by Teacher ID..."
            txtbxManTeaSearch.ForeColor = Color.Gray
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

    Private Sub SetupTeacherDataGridView()
        If dgvTeacher Is Nothing Then Return

        ' Clear existing columns first
        dgvTeacher.Columns.Clear()

        ' Configure DataGridView appearance
        dgvTeacher.AutoGenerateColumns = False
        dgvTeacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTeacher.ReadOnly = True
        dgvTeacher.AllowUserToAddRows = False
        dgvTeacher.RowHeadersVisible = False
        dgvTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Create and add columns with DataPropertyName for Teacher Information
        Dim colTeacherID As New DataGridViewTextBoxColumn()
        colTeacherID.Name = "TeacherID"
        colTeacherID.HeaderText = "Teacher ID"
        colTeacherID.DataPropertyName = "TeacherID"
        dgvTeacher.Columns.Add(colTeacherID)

        Dim colFirstName As New DataGridViewTextBoxColumn()
        colFirstName.Name = "FirstName"
        colFirstName.HeaderText = "First Name"
        colFirstName.DataPropertyName = "FirstName"
        dgvTeacher.Columns.Add(colFirstName)

        Dim colMiddleName As New DataGridViewTextBoxColumn()
        colMiddleName.Name = "MiddleName"
        colMiddleName.HeaderText = "Middle Name"
        colMiddleName.DataPropertyName = "MiddleName"
        dgvTeacher.Columns.Add(colMiddleName)

        Dim colLastName As New DataGridViewTextBoxColumn()
        colLastName.Name = "LastName"
        colLastName.HeaderText = "Last Name"
        colLastName.DataPropertyName = "LastName"
        dgvTeacher.Columns.Add(colLastName)
    End Sub

    Private Sub StyleControls()
        ' Style input controls
        Dim textBoxes() As TextBox = {txtbxTeacherUserID, txtbxTeacherPassword,
                                       txtbxTeacherUserType, txtbxTeaAccountTeacherID, txtbxManTeaSearch}

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

        ' Style Update button
        If btnManTeaUpdate IsNot Nothing Then
            btnManTeaUpdate.BackColor = Color.FromArgb(40, 167, 69)
            btnManTeaUpdate.ForeColor = Color.White
            btnManTeaUpdate.FlatStyle = FlatStyle.Flat
            btnManTeaUpdate.FlatAppearance.BorderSize = 0
            btnManTeaUpdate.Font = New Font("Arial", 10, FontStyle.Bold)
        End If

        ' Style Delete button
        If btnManTeaDelete IsNot Nothing Then
            btnManTeaDelete.BackColor = Color.FromArgb(220, 53, 69)
            btnManTeaDelete.ForeColor = Color.White
            btnManTeaDelete.FlatStyle = FlatStyle.Flat
            btnManTeaDelete.FlatAppearance.BorderSize = 0
            btnManTeaDelete.Font = New Font("Arial", 10, FontStyle.Bold)
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

    Private Sub LoadTeacherInfoData()
        If dgvTeacher Is Nothing Then Return

        Try
            modDBx.openConn(modDBx.db_name)

            ' Query teacher information from teacher table
            Dim query As String = "SELECT TeacherID, FirstName, MiddleName, LastName FROM teacher ORDER BY TeacherID"
            Using command As New MySqlCommand(query, modDBx.conn)
                Using adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvTeacher.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading teacher information: " & ex.Message, "Database Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' ==================== SEARCH FUNCTIONALITY ====================
    Private Sub SearchTeachers(ByVal searchTerm As String)
        ' If the search box is empty, load all teachers (default view)
        If String.IsNullOrWhiteSpace(searchTerm) OrElse searchTerm = "Search by Teacher ID..." Then
            LoadTeacherData()
            LoadTeacherInfoData()
            Return
        End If

        Try
            ' Open Connection
            modDBx.openConn(modDBx.db_name)

            ' Search login accounts by TeacherID
            Dim sqlLogin As String = "SELECT user_id, password, user_type, TeacherID FROM login 
                                     WHERE user_type = 'teacher' 
                                     AND TeacherID LIKE @searchTerm
                                     ORDER BY user_id"

            Using cmdLogin As New MySqlCommand(sqlLogin, modDBx.conn)
                ' Use searchTerm + '%' to match from the beginning
                cmdLogin.Parameters.AddWithValue("@searchTerm", searchTerm.Trim() & "%")

                Dim dtLogin As New System.Data.DataTable
                Using adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(cmdLogin)
                    adapter.Fill(dtLogin)
                End Using

                dgvLoginTeacher.DataSource = dtLogin
                dgvLoginTeacher.Refresh()
            End Using

            ' Search teacher information by TeacherID
            Dim sqlTeacher As String = "SELECT TeacherID, FirstName, MiddleName, LastName FROM teacher 
                                       WHERE TeacherID LIKE @searchTerm
                                       ORDER BY TeacherID"

            Using cmdTeacher As New MySqlCommand(sqlTeacher, modDBx.conn)
                ' Use searchTerm + '%' to match from the beginning
                cmdTeacher.Parameters.AddWithValue("@searchTerm", searchTerm.Trim() & "%")

                Dim dtTeacher As New System.Data.DataTable
                Using adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(cmdTeacher)
                    adapter.Fill(dtTeacher)
                End Using

                dgvTeacher.DataSource = dtTeacher
                dgvTeacher.Refresh()
            End Using

            ' Optional: Show message when no results found
            ' If dtLogin.Rows.Count = 0 AndAlso dtTeacher.Rows.Count = 0 Then
            '     MessageBox.Show("No teacher found matching '" & searchTerm & "'.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' End If

        Catch ex As Exception
            MessageBox.Show("Error searching teacher accounts: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = System.Data.ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' Real-time search as user types
    Private Sub txtbxManTeaSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbxManTeaSearch.TextChanged
        SearchTeachers(txtbxManTeaSearch.Text)
    End Sub

    Private Sub txtbxManTeaSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxManTeaSearch.KeyPress
        ' Allow Enter key to trigger search (optional, since we have real-time search)
        If e.KeyChar = ChrW(Keys.Enter) Then
            SearchTeachers(txtbxManTeaSearch.Text)
            e.Handled = True
        End If
    End Sub

    ' Placeholder text for search box
    Private Sub txtbxManTeaSearch_Enter(sender As Object, e As EventArgs) Handles txtbxManTeaSearch.Enter
        If txtbxManTeaSearch.Text = "Search by Teacher ID..." Then
            txtbxManTeaSearch.Text = ""
            txtbxManTeaSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtbxManTeaSearch_Leave(sender As Object, e As EventArgs) Handles txtbxManTeaSearch.Leave
        If String.IsNullOrWhiteSpace(txtbxManTeaSearch.Text) Then
            txtbxManTeaSearch.Text = "Search by Teacher ID..."
            txtbxManTeaSearch.ForeColor = Color.Gray
        End If
    End Sub
    ' ==================== END SEARCH FUNCTIONALITY ====================

    Private Sub btnManTeacherAdd_Click(sender As Object, e As EventArgs) Handles btnManTeacherAdd.Click
        ' If a row is currently selected, prevent adding and show error
        If Not String.IsNullOrEmpty(currentUserID) Then
            MessageBox.Show("Please clear the selection before adding a new teacher account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If ValidateInputs() Then
            AddTeacherAccount()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim errors As New List(Of String)

        ' Validate User ID format (00-0000)
        If Not IsValidUserID(txtbxTeacherUserID.Text) Then
            errors.Add("• User ID must be in the format 00-0000")
        End If

        ' Validate Password - CHANGED TO 8 CHARACTERS
        If String.IsNullOrWhiteSpace(txtbxTeacherPassword.Text) Then
            errors.Add("• Password is required")
        ElseIf txtbxTeacherPassword.Text.Length < 8 Then
            errors.Add("• Password must be at least 8 characters long")
        End If

        ' Validate Teacher ID
        If String.IsNullOrWhiteSpace(txtbxTeaAccountTeacherID.Text) Then
            errors.Add("• Teacher ID is required")
        ElseIf Not TeacherIDExists(txtbxTeaAccountTeacherID.Text) Then
            errors.Add("• The specified Teacher ID does not exist in the system")
        ElseIf TeacherHasAccount(txtbxTeaAccountTeacherID.Text) Then
            errors.Add("• This Teacher ID already has an account")
        End If

        ' Check if User ID already exists
        If UserIDExists(txtbxTeacherUserID.Text) Then
            errors.Add("• This User ID already exists")
        End If

        ' Display validation errors if any
        If errors.Count > 0 Then
            Dim errorMessage As New StringBuilder()
            errorMessage.AppendLine("Please fix the following errors before proceeding:")
            errorMessage.AppendLine()

            For Each [error] As String In errors
                errorMessage.AppendLine([error])
            Next

            MessageBox.Show(errorMessage.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                    LoadTeacherInfoData()
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

        ' Reset current selection
        currentUserID = String.Empty
        originalData.Clear()

        ' Re-enable Add button so user can create a new record
        btnManTeacherAdd.Enabled = True

        ' Set focus back to first field
        If txtbxTeacherUserID IsNot Nothing Then
            txtbxTeacherUserID.Focus()
        End If
    End Sub

    ' ==================== DGV CLICK HANDLER ====================
    Private Sub dgvLoginTeacher_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoginTeacher.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvLoginTeacher.Rows(e.RowIndex)

        ' Safely read the user_id in the clicked row
        Dim clickedUserID As String = String.Empty
        If row.Cells.Count > 0 AndAlso row.Cells("user_id").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("user_id").Value) Then
            clickedUserID = row.Cells("user_id").Value.ToString()
        End If

        ' If the user clicked the already-selected row, clear selection and inputs
        If Not String.IsNullOrEmpty(clickedUserID) AndAlso clickedUserID = currentUserID Then
            dgvLoginTeacher.ClearSelection()
            currentUserID = String.Empty
            originalData.Clear()
            ClearInputs()
            Return
        End If

        ' Otherwise populate fields for the newly selected row
        If Not String.IsNullOrEmpty(clickedUserID) Then
            currentUserID = clickedUserID

            ' Store original data for change detection
            originalData.Clear()
            originalData("user_id") = GetSafeString(row.Cells("user_id"))
            originalData("password") = GetSafeString(row.Cells("password"))
            originalData("TeacherID") = GetSafeString(row.Cells("TeacherID"))

            ' Populate form fields
            txtbxTeacherUserID.Text = originalData("user_id")
            txtbxTeacherUserID.ForeColor = Color.Black
            txtbxTeacherPassword.Text = "" ' Don't show encrypted password
            txtbxTeacherUserType.Text = "teacher"
            txtbxTeaAccountTeacherID.Text = originalData("TeacherID")

            ' Keep Add button enabled
            btnManTeacherAdd.Enabled = True
        End If
    End Sub

    ' Helper function for safe string retrieval from DataGridView
    Private Function GetSafeString(cell As DataGridViewCell) As String
        Return If(cell.Value Is Nothing OrElse IsDBNull(cell.Value), "", cell.Value.ToString())
    End Function
    ' ==================== END DGV CLICK HANDLER ====================

    ' ==================== UPDATE WITH CHANGE DETECTION ====================
    Private Sub btnManTeaUpdate_Click(sender As Object, e As EventArgs) Handles btnManTeaUpdate.Click
        UpdateTeacherAccount()
    End Sub

    Private Sub UpdateTeacherAccount()
        ' Check if a teacher account is selected
        If String.IsNullOrEmpty(currentUserID) Then
            MessageBox.Show("No teacher account selected for update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Validate required fields FIRST
        If Not ValidateInputsForUpdate() Then
            Return ' Stop execution if validation fails
        End If

        ' Check if any data has actually changed
        If Not HasTeacherAccountDataChanged() Then
            MessageBox.Show("No changes were made to the teacher account data.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            ' Get the original user_id from the selected row
            Dim originalUserID As String = currentUserID

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
                ' Update with new password - CHANGED TO 8 CHARACTERS VALIDATION
                If txtbxTeacherPassword.Text.Length < 8 Then
                    MessageBox.Show("Password must be at least 8 characters long", "Password Too Short", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

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

    Private Function ValidateInputsForUpdate() As Boolean
        Dim errors As New List(Of String)

        ' Validate User ID format (00-0000)
        If Not IsValidUserID(txtbxTeacherUserID.Text) Then
            errors.Add("• User ID must be in the format 00-0000")
        End If

        ' Validate Password (optional for update - only validate if not empty) - CHANGED TO 8 CHARACTERS
        If Not String.IsNullOrWhiteSpace(txtbxTeacherPassword.Text) Then
            If txtbxTeacherPassword.Text.Length < 8 Then
                errors.Add("• Password must be at least 8 characters long")
            End If
        End If

        ' Validate Teacher ID
        If String.IsNullOrWhiteSpace(txtbxTeaAccountTeacherID.Text) Then
            errors.Add("• Teacher ID is required")
        ElseIf Not TeacherIDExists(txtbxTeaAccountTeacherID.Text) Then
            errors.Add("• The specified Teacher ID does not exist in the system")
        End If

        ' Get the original teacher_id from stored data
        Dim originalTeacherID As String = If(originalData.ContainsKey("TeacherID"), originalData("TeacherID").ToString(), "")

        ' Check if Teacher ID already has an account (only if it's different from the original)
        If txtbxTeaAccountTeacherID.Text <> originalTeacherID AndAlso TeacherHasAccount(txtbxTeaAccountTeacherID.Text) Then
            errors.Add("• This Teacher ID already has an account")
        End If

        ' Check if User ID already exists (only if it's different from the original)
        If txtbxTeacherUserID.Text <> currentUserID AndAlso UserIDExists(txtbxTeacherUserID.Text) Then
            errors.Add("• This User ID already exists")
        End If

        ' Display validation errors if any
        If errors.Count > 0 Then
            Dim errorMessage As New StringBuilder()
            errorMessage.AppendLine("Please fix the following errors before proceeding:")
            errorMessage.AppendLine()

            For Each [error] As String In errors
                errorMessage.AppendLine([error])
            Next

            MessageBox.Show(errorMessage.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    ' Add this function to check if any data has changed
    Private Function HasTeacherAccountDataChanged() As Boolean
        ' Compare current form values with original data
        If originalData.Count = 0 Then Return False

        If txtbxTeacherUserID.Text <> originalData("user_id").ToString() Then Return True
        If txtbxTeaAccountTeacherID.Text <> originalData("TeacherID").ToString() Then Return True

        ' Only check password if it's not empty (user wants to change it)
        If Not String.IsNullOrWhiteSpace(txtbxTeacherPassword.Text) Then
            ' Note: We can't compare encrypted passwords directly, so if user entered any password, consider it changed
            Return True
        End If

        Return False ' No changes detected
    End Function
    ' ==================== END UPDATE WITH CHANGE DETECTION ====================

    Private Sub btnManTeaDelete_Click(sender As Object, e As EventArgs) Handles btnManTeaDelete.Click
        ' Check if a teacher account is selected
        If String.IsNullOrEmpty(currentUserID) Then
            MessageBox.Show("Please select a teacher account to delete.", "Delete Teacher Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Confirm deletion
        If MessageBox.Show("Are you sure you want to delete this teacher account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Try
            modDBx.openConn(modDBx.db_name)

            Dim query As String = "DELETE FROM login WHERE user_id = @user_id AND user_type = 'teacher'"
            Using command As New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@user_id", currentUserID)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Teacher account deleted successfully!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInputs()
                    LoadTeacherData()
                    LoadTeacherInfoData()
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

    ' ==================== KEYBOARD SHORTCUTS AND OTHER METHODS ====================
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

    ' Ensure selection is cleared after any data binding operation
    Private Sub dgvLoginTeacher_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvLoginTeacher.DataBindingComplete
        dgvLoginTeacher.ClearSelection()
        Try
            If dgvLoginTeacher.Rows.Count > 0 AndAlso dgvLoginTeacher.Columns.Count > 0 Then
                dgvLoginTeacher.CurrentCell = Nothing
            End If
        Catch
            ' ignore - layout timing may prevent clearing CurrentCell
        End Try
    End Sub

    ' Final fallback after form is shown
    Private Sub SuperAdminManageTeacherAccounts_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dgvLoginTeacher.ClearSelection()
        Try
            If dgvLoginTeacher.Rows.Count > 0 AndAlso dgvLoginTeacher.Columns.Count > 0 Then
                dgvLoginTeacher.CurrentCell = Nothing
            End If
        Catch
        End Try

        ' Move focus to first input so the grid doesn't appear focused
        If txtbxTeacherUserID IsNot Nothing Then
            txtbxTeacherUserID.Focus()
        End If
    End Sub

    ' Allow typing "f" into the search TextBox while preventing the parent/dashboard full-screen handler.
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Check only the key code (ignore modifiers in comparison)
        If (keyData And Keys.KeyCode) = Keys.F AndAlso txtbxManTeaSearch IsNot Nothing AndAlso txtbxManTeaSearch.Focused Then
            ' Insert the character into the textbox manually (preserve selection/replacement).
            Dim tb = txtbxManTeaSearch
            Dim s As String = tb.Text
            Dim selStart As Integer = tb.SelectionStart
            Dim selLen As Integer = tb.SelectionLength

            ' Determine case: Shift toggles, CapsLock toggles
            Dim shiftPressed As Boolean = (keyData And Keys.Shift) = Keys.Shift
            Dim capsOn As Boolean = Control.IsKeyLocked(Keys.CapsLock)
            Dim useUpper As Boolean = shiftPressed Xor capsOn
            Dim ch As Char = If(useUpper, "F"c, "f"c)

            ' Remove placeholder text if it's there
            If s = "Search by User ID or Teacher ID..." Then
                s = ""
                selStart = 0
                selLen = 0
            End If

            Dim before As String = If(selStart > 0, s.Substring(0, selStart), String.Empty)
            Dim afterIndex As Integer = Math.Min(selStart + selLen, s.Length)
            Dim after As String = If(afterIndex < s.Length, s.Substring(afterIndex), String.Empty)

            tb.Text = before & ch & after
            tb.SelectionStart = selStart + 1
            tb.SelectionLength = 0
            tb.ForeColor = Color.Black

            ' Consume the key so parent doesn't trigger full-screen
            Return True
        End If

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

    ' ==================== SIDEBAR AND NAVIGATION METHODS ====================
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

    Private Sub AdminDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Not IsEmbedded Then
            CenterLogo()
            PositionSidebarButtons()
        End If
    End Sub
End Class