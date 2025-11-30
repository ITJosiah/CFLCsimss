Imports System.Text
Imports MySql.Data.MySqlClient

Public Class SuperAdminManageAdminAccounts
    Public Property IsEmbedded As Boolean = False
    Private currentUserID As String = String.Empty
    Private originalData As New Dictionary(Of String, Object)()
    
    ' Event to notify when admin account count changes
    Public Event AdminAccountCountChanged(count As Integer)
    
    ' Public method to get current admin account count
    Public Function GetAdminAccountCount() As Integer
        If dgvLoginAdmin IsNot Nothing AndAlso dgvLoginAdmin.DataSource IsNot Nothing Then
            Dim dt As DataTable = TryCast(dgvLoginAdmin.DataSource, DataTable)
            If dt IsNot Nothing Then
                Return dt.Rows.Count
            End If
            Return dgvLoginAdmin.Rows.Count
        End If
        Return 0
    End Function

    Private Sub SuperAdminManageAdminAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Me.Text = "Manage Admin Accounts"

        ' Initialize form components
        InitializeControls()
        SetupDataGridView()
        SetDefaultValues()
        StyleControls()
        LoadAdminData()

        ' Ensure Add button is enabled by default
        btnManAdAdd.Enabled = True

        ' Ensure the grid doesn't auto-select the first row on load
        dgvLoginAdmin.ClearSelection()
        Try
            If dgvLoginAdmin.Rows.Count > 0 AndAlso dgvLoginAdmin.Columns.Count > 0 Then
                dgvLoginAdmin.CurrentCell = Nothing
            End If
        Catch
            ' ignore potential layout timing exceptions
        End Try
        currentUserID = String.Empty
    End Sub

    Private Sub InitializeControls()
        ' Set default values for user type in combobox
        If ComboBoxAdminUserType IsNot Nothing Then
            ComboBoxAdminUserType.Items.Add("admin")
            ComboBoxAdminUserType.Items.Add("superadmin")
            ComboBoxAdminUserType.SelectedIndex = 0 ' Default to "admin"
        End If

        ' Initialize search textbox with placeholder
        If txtbxManAdminSearch IsNot Nothing Then
            txtbxManAdminSearch.Text = "Search by User ID..."
            txtbxManAdminSearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub SetDefaultValues()
        ' No default format for admin user_id (unlike teacher's 00-0000)
        If txtbxAdminUserID IsNot Nothing Then
            txtbxAdminUserID.Text = ""
        End If
    End Sub

    Private Sub SetupDataGridView()
        If dgvLoginAdmin Is Nothing Then Return

        ' Clear existing columns first
        dgvLoginAdmin.Columns.Clear()

        ' Configure DataGridView appearance
        dgvLoginAdmin.AutoGenerateColumns = False
        dgvLoginAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLoginAdmin.ReadOnly = True
        dgvLoginAdmin.AllowUserToAddRows = False
        dgvLoginAdmin.RowHeadersVisible = False
        dgvLoginAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Create and add columns with DataPropertyName
        Dim colUserID As New DataGridViewTextBoxColumn()
        colUserID.Name = "user_id"
        colUserID.HeaderText = "User ID"
        colUserID.DataPropertyName = "user_id"
        dgvLoginAdmin.Columns.Add(colUserID)

        Dim colPassword As New DataGridViewTextBoxColumn()
        colPassword.Name = "password"
        colPassword.HeaderText = "Password"
        colPassword.DataPropertyName = "password"
        dgvLoginAdmin.Columns.Add(colPassword)

        Dim colUserType As New DataGridViewTextBoxColumn()
        colUserType.Name = "user_type"
        colUserType.HeaderText = "User Type"
        colUserType.DataPropertyName = "user_type"
        dgvLoginAdmin.Columns.Add(colUserType)
    End Sub

    Private Sub StyleControls()
        ' Style input controls
        Dim textBoxes() As TextBox = {txtbxAdminUserID, txtbxAdminPassword, txtbxManAdminSearch}

        For Each txt As TextBox In textBoxes
            If txt IsNot Nothing Then
                txt.BackColor = Color.White
                txt.ForeColor = Color.Black
                txt.Font = New Font("Arial", 10, FontStyle.Regular)
                txt.BorderStyle = BorderStyle.FixedSingle
            End If
        Next

        ' Style ComboBox
        If ComboBoxAdminUserType IsNot Nothing Then
            ComboBoxAdminUserType.BackColor = Color.White
            ComboBoxAdminUserType.ForeColor = Color.Black
            ComboBoxAdminUserType.Font = New Font("Arial", 10, FontStyle.Regular)
            ComboBoxAdminUserType.FlatStyle = FlatStyle.Flat
        End If

        ' Style Add button
        If btnManAdAdd IsNot Nothing Then
            btnManAdAdd.BackColor = Color.FromArgb(0, 123, 255)
            btnManAdAdd.ForeColor = Color.White
            btnManAdAdd.FlatStyle = FlatStyle.Flat
            btnManAdAdd.FlatAppearance.BorderSize = 0
            btnManAdAdd.Font = New Font("Arial", 10, FontStyle.Bold)
        End If

        ' Style Update button
        If btnManAdUpdate IsNot Nothing Then
            btnManAdUpdate.BackColor = Color.FromArgb(40, 167, 69)
            btnManAdUpdate.ForeColor = Color.White
            btnManAdUpdate.FlatStyle = FlatStyle.Flat
            btnManAdUpdate.FlatAppearance.BorderSize = 0
            btnManAdUpdate.Font = New Font("Arial", 10, FontStyle.Bold)
        End If

        ' Style Delete button
        If btnManAdDelete IsNot Nothing Then
            btnManAdDelete.BackColor = Color.FromArgb(220, 53, 69)
            btnManAdDelete.ForeColor = Color.White
            btnManAdDelete.FlatStyle = FlatStyle.Flat
            btnManAdDelete.FlatAppearance.BorderSize = 0
            btnManAdDelete.Font = New Font("Arial", 10, FontStyle.Bold)
        End If

        ' Style DataGridView
        If dgvLoginAdmin IsNot Nothing Then
            dgvLoginAdmin.BackgroundColor = Color.White
            dgvLoginAdmin.BorderStyle = BorderStyle.None
            dgvLoginAdmin.Font = New Font("Arial", 9, FontStyle.Regular)
            dgvLoginAdmin.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
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

    Private Sub LoadAdminData()
        If dgvLoginAdmin Is Nothing Then Return

        Try
            modDBx.openConn(modDBx.db_name)

            Dim query As String = "SELECT user_id, password, user_type FROM login WHERE user_type IN ('admin', 'superadmin')"
            Using command As New MySqlCommand(query, modDBx.conn)
                Using adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvLoginAdmin.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading admin data: " & ex.Message, "Database Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' ==================== SEARCH FUNCTIONALITY ====================
    Private Sub SearchAdmins(ByVal searchTerm As String)
        ' If the search box is empty, load all admins (default view)
        If String.IsNullOrWhiteSpace(searchTerm) OrElse searchTerm = "Search by User ID..." Then
            LoadAdminData()
            Return
        End If

        Try
            ' Open Connection
            modDBx.openConn(modDBx.db_name)

            ' Search by user_id
            Dim sql As String = "SELECT user_id, password, user_type FROM login 
                               WHERE user_type IN ('admin', 'superadmin') 
                               AND user_id LIKE @searchTerm
                               ORDER BY user_id"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                ' Use searchTerm + '%' to match from the beginning
                cmd.Parameters.AddWithValue("@searchTerm", searchTerm.Trim() & "%")

                Dim dt As New System.Data.DataTable
                Using adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                dgvLoginAdmin.DataSource = dt
                dgvLoginAdmin.Refresh()

                If dt.Rows.Count = 0 Then
                    ' Optional: Show message when no results found
                    ' MessageBox.Show("No admin account found matching '" & searchTerm & "'.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching admin accounts: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = System.Data.ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' Real-time search as user types
    Private Sub txtbxManAdminSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbxManAdminSearch.TextChanged
        SearchAdmins(txtbxManAdminSearch.Text)
    End Sub

    Private Sub txtbxManAdminSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxManAdminSearch.KeyPress
        ' Allow Enter key to trigger search (optional, since we have real-time search)
        If e.KeyChar = ChrW(Keys.Enter) Then
            SearchAdmins(txtbxManAdminSearch.Text)
            e.Handled = True
        End If
    End Sub

    ' Placeholder text for search box
    Private Sub txtbxManAdminSearch_Enter(sender As Object, e As EventArgs) Handles txtbxManAdminSearch.Enter
        If txtbxManAdminSearch.Text = "Search by User ID..." Then
            txtbxManAdminSearch.Text = ""
            txtbxManAdminSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtbxManAdminSearch_Leave(sender As Object, e As EventArgs) Handles txtbxManAdminSearch.Leave
        If String.IsNullOrWhiteSpace(txtbxManAdminSearch.Text) Then
            txtbxManAdminSearch.Text = "Search by User ID..."
            txtbxManAdminSearch.ForeColor = Color.Gray
        End If
    End Sub
    ' ==================== END SEARCH FUNCTIONALITY ====================

    Private Sub btnManAdAdd_Click(sender As Object, e As EventArgs) Handles btnManAdAdd.Click
        ' If a row is currently selected, prevent adding and show error
        If Not String.IsNullOrEmpty(currentUserID) Then
            MessageBox.Show("Please clear the selection before adding a new admin account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If ValidateInputs() Then
            AddAdminAccount()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim errors As New List(Of String)

        ' Validate User ID (no specific format for admin)
        If String.IsNullOrWhiteSpace(txtbxAdminUserID.Text) Then
            errors.Add("• User ID is required")
        End If

        ' Validate Password - 8 CHARACTERS
        If String.IsNullOrWhiteSpace(txtbxAdminPassword.Text) Then
            errors.Add("• Password is required")
        ElseIf txtbxAdminPassword.Text.Length < 8 Then
            errors.Add("• Password must be at least 8 characters long")
        End If

        ' Validate User Type
        If ComboBoxAdminUserType.SelectedItem Is Nothing Then
            errors.Add("• User Type is required")
        End If

        ' Check if User ID already exists
        If UserIDExists(txtbxAdminUserID.Text) Then
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

    Private Sub AddAdminAccount()
        Try
            modDBx.openConn(modDBx.db_name)

            ' Encrypt the password before storing
            Dim encryptedPassword As String = modDBx.Encrypt(txtbxAdminPassword.Text.Trim())

            Dim query As String = "INSERT INTO login (user_id, password, user_type) " &
                                "VALUES (@user_id, @password, @user_type)"

            Using command As New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@user_id", txtbxAdminUserID.Text.Trim())
                command.Parameters.AddWithValue("@password", encryptedPassword)
                command.Parameters.AddWithValue("@user_type", ComboBoxAdminUserType.SelectedItem.ToString())

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    ' Log the addition
                    Try
                        Dim accountInfo As String = "User ID: " & txtbxAdminUserID.Text.Trim() & ", User Type: " & ComboBoxAdminUserType.SelectedItem.ToString()
                        modDBx.Logs("Added admin account - " & accountInfo, "btnManAdAdd_Click")
                    Catch
                        ' Silently fail if logging doesn't work
                    End Try

                    MessageBox.Show("Admin account created successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInputs()
                    LoadAdminData()
                Else
                    MessageBox.Show("Failed to create admin account", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error creating admin account: " & ex.Message,
                          "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub ClearInputs()
        If txtbxAdminUserID IsNot Nothing Then
            txtbxAdminUserID.Text = ""
        End If

        If txtbxAdminPassword IsNot Nothing Then
            txtbxAdminPassword.Clear()
        End If

        If ComboBoxAdminUserType IsNot Nothing Then
            ComboBoxAdminUserType.SelectedIndex = 0 ' Reset to "admin"
        End If

        ' Reset current selection
        currentUserID = String.Empty
        originalData.Clear()

        ' Re-enable Add button so user can create a new record
        btnManAdAdd.Enabled = True

        ' Set focus back to first field
        If txtbxAdminUserID IsNot Nothing Then
            txtbxAdminUserID.Focus()
        End If
    End Sub

    ' ==================== DGV CLICK HANDLER ====================
    Private Sub dgvLoginAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoginAdmin.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvLoginAdmin.Rows(e.RowIndex)

        ' Safely read the user_id in the clicked row
        Dim clickedUserID As String = String.Empty
        If row.Cells.Count > 0 AndAlso row.Cells("user_id").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("user_id").Value) Then
            clickedUserID = row.Cells("user_id").Value.ToString()
        End If

        ' If the user clicked the already-selected row, clear selection and inputs
        If Not String.IsNullOrEmpty(clickedUserID) AndAlso clickedUserID = currentUserID Then
            dgvLoginAdmin.ClearSelection()
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
            originalData("user_type") = GetSafeString(row.Cells("user_type"))

            ' Populate form fields
            txtbxAdminUserID.Text = originalData("user_id")
            txtbxAdminPassword.Text = "" ' Don't show encrypted password

            ' Set user type in combobox
            If ComboBoxAdminUserType IsNot Nothing Then
                Dim userType As String = originalData("user_type").ToString()
                If ComboBoxAdminUserType.Items.Contains(userType) Then
                    ComboBoxAdminUserType.SelectedItem = userType
                Else
                    ComboBoxAdminUserType.SelectedIndex = 0 ' Default to "admin" if not found
                End If
            End If

            ' Keep Add button enabled
            btnManAdAdd.Enabled = True
        End If
    End Sub

    ' Helper function for safe string retrieval from DataGridView
    Private Function GetSafeString(cell As DataGridViewCell) As String
        Return If(cell.Value Is Nothing OrElse IsDBNull(cell.Value), "", cell.Value.ToString())
    End Function
    ' ==================== END DGV CLICK HANDLER ====================

    ' ==================== UPDATE WITH CHANGE DETECTION ====================
    Private Sub btnManAdUpdate_Click(sender As Object, e As EventArgs) Handles btnManAdUpdate.Click
        UpdateAdminAccount()
    End Sub

    Private Sub UpdateAdminAccount()
        ' Check if an admin account is selected
        If String.IsNullOrEmpty(currentUserID) Then
            MessageBox.Show("No admin account selected for update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Validate required fields FIRST
        If Not ValidateInputsForUpdate() Then
            Return ' Stop execution if validation fails
        End If

        ' Check if any data has actually changed
        If Not HasAdminAccountDataChanged() Then
            MessageBox.Show("No changes were made to the admin account data.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            ' Get the original user_id from the selected row
            Dim originalUserID As String = currentUserID

            modDBx.openConn(modDBx.db_name)

            Dim query As String
            Dim command As MySqlCommand

            ' Check if password is being updated
            If String.IsNullOrWhiteSpace(txtbxAdminPassword.Text) Then
                ' Update without changing password
                query = "UPDATE login SET user_id = @new_user_id, user_type = @user_type " &
                   "WHERE user_id = @original_user_id AND user_type IN ('admin', 'superadmin')"
                command = New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@new_user_id", txtbxAdminUserID.Text.Trim())
                command.Parameters.AddWithValue("@user_type", ComboBoxAdminUserType.SelectedItem.ToString())
                command.Parameters.AddWithValue("@original_user_id", originalUserID)
            Else
                ' Update with new password - 8 CHARACTERS VALIDATION
                If txtbxAdminPassword.Text.Length < 8 Then
                    MessageBox.Show("Password must be at least 8 characters long", "Password Too Short", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim encryptedPassword As String = modDBx.Encrypt(txtbxAdminPassword.Text.Trim())
                query = "UPDATE login SET user_id = @new_user_id, password = @password, user_type = @user_type " &
                   "WHERE user_id = @original_user_id AND user_type IN ('admin', 'superadmin')"
                command = New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@new_user_id", txtbxAdminUserID.Text.Trim())
                command.Parameters.AddWithValue("@password", encryptedPassword)
                command.Parameters.AddWithValue("@user_type", ComboBoxAdminUserType.SelectedItem.ToString())
                command.Parameters.AddWithValue("@original_user_id", originalUserID)
            End If

            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                ' Log the update
                Try
                    Dim accountInfo As String = "User ID: " & txtbxAdminUserID.Text.Trim() & " (Original: " & originalUserID & "), User Type: " & ComboBoxAdminUserType.SelectedItem.ToString()
                    modDBx.Logs("Updated admin account - " & accountInfo, "btnManAdUpdate_Click")
                Catch
                    ' Silently fail if logging doesn't work
                End Try

                MessageBox.Show("Admin account updated successfully!", "Success",
                          MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearInputs()
                LoadAdminData()
            Else
                MessageBox.Show("Failed to update admin account", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            command.Dispose()

        Catch ex As Exception
            MessageBox.Show("Error updating admin account: " & ex.Message,
                      "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Function ValidateInputsForUpdate() As Boolean
        Dim errors As New List(Of String)

        ' Validate User ID
        If String.IsNullOrWhiteSpace(txtbxAdminUserID.Text) Then
            errors.Add("• User ID is required")
        End If

        ' Validate Password (optional for update - only validate if not empty) - 8 CHARACTERS
        If Not String.IsNullOrWhiteSpace(txtbxAdminPassword.Text) Then
            If txtbxAdminPassword.Text.Length < 8 Then
                errors.Add("• Password must be at least 8 characters long")
            End If
        End If

        ' Validate User Type
        If ComboBoxAdminUserType.SelectedItem Is Nothing Then
            errors.Add("• User Type is required")
        End If

        ' Check if User ID already exists (only if it's different from the original)
        If txtbxAdminUserID.Text <> currentUserID AndAlso UserIDExists(txtbxAdminUserID.Text) Then
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
    Private Function HasAdminAccountDataChanged() As Boolean
        ' Compare current form values with original data
        If originalData.Count = 0 Then Return False

        If txtbxAdminUserID.Text <> originalData("user_id").ToString() Then Return True
        If ComboBoxAdminUserType.SelectedItem.ToString() <> originalData("user_type").ToString() Then Return True

        ' Only check password if it's not empty (user wants to change it)
        If Not String.IsNullOrWhiteSpace(txtbxAdminPassword.Text) Then
            ' Note: We can't compare encrypted passwords directly, so if user entered any password, consider it changed
            Return True
        End If

        Return False ' No changes detected
    End Function
    ' ==================== END UPDATE WITH CHANGE DETECTION ====================

    Private Sub btnManAdDelete_Click(sender As Object, e As EventArgs) Handles btnManAdDelete.Click
        ' Check if an admin account is selected
        If String.IsNullOrEmpty(currentUserID) Then
            MessageBox.Show("Please select an admin account to delete.", "Delete Admin Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Confirm deletion
        If MessageBox.Show("Are you sure you want to delete this admin account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Try
            modDBx.openConn(modDBx.db_name)

            Dim query As String = "DELETE FROM login WHERE user_id = @user_id AND user_type IN ('admin', 'superadmin')"
            Using command As New MySqlCommand(query, modDBx.conn)
                command.Parameters.AddWithValue("@user_id", currentUserID)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    ' Log the deletion
                    Try
                        Dim accountInfo As String = "User ID: " & currentUserID
                        modDBx.Logs("Deleted admin account - " & accountInfo, "btnManAdDelete_Click")
                    Catch
                        ' Silently fail if logging doesn't work
                    End Try

                    MessageBox.Show("Admin account deleted successfully!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInputs()
                    LoadAdminData()
                Else
                    MessageBox.Show("Failed to delete admin account", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting admin account: " & ex.Message,
                      "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' ==================== KEYBOARD SHORTCUTS AND OTHER METHODS ====================
    Private Sub EnsureSelectionCleared()
        dgvLoginAdmin.ClearSelection()
        Try
            If dgvLoginAdmin.Rows.Count > 0 AndAlso dgvLoginAdmin.Columns.Count > 0 Then
                dgvLoginAdmin.CurrentCell = Nothing
            End If
        Catch
            ' ignore - layout timing may prevent clearing CurrentCell
        End Try
    End Sub

    ' Ensure selection is cleared after any data binding operation
    Private Sub dgvLoginAdmin_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvLoginAdmin.DataBindingComplete
        EnsureSelectionCleared()
        
        ' Raise event for dashboard update
        Dim count As Integer = GetAdminAccountCount()
        RaiseEvent AdminAccountCountChanged(count)
    End Sub

    ' Final fallback after form is shown
    Private Sub SuperAdminManageAdminAccounts_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        EnsureSelectionCleared()

        ' Move focus to first input so the grid doesn't appear focused
        If txtbxAdminUserID IsNot Nothing Then
            txtbxAdminUserID.Focus()
        End If
    End Sub

    ' Allow typing "f" into the search TextBox while preventing the parent/dashboard full-screen handler.
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Check only the key code (ignore modifiers in comparison)
        If (keyData And Keys.KeyCode) = Keys.F AndAlso txtbxManAdminSearch IsNot Nothing AndAlso txtbxManAdminSearch.Focused Then
            ' Insert the character into the textbox manually (preserve selection/replacement).
            Dim tb = txtbxManAdminSearch
            Dim s As String = tb.Text
            Dim selStart As Integer = tb.SelectionStart
            Dim selLen As Integer = tb.SelectionLength

            ' Determine case: Shift toggles, CapsLock toggles
            Dim shiftPressed As Boolean = (keyData And Keys.Shift) = Keys.Shift
            Dim capsOn As Boolean = Control.IsKeyLocked(Keys.CapsLock)
            Dim useUpper As Boolean = shiftPressed Xor capsOn
            Dim ch As Char = If(useUpper, "F"c, "f"c)

            ' Remove placeholder text if it's there
            If s = "Search by User ID..." Then
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
            If btnManAdAdd IsNot Nothing Then
                btnManAdAdd.PerformClick()
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
        ' Don't load the same form recursively - instead show message or do nothing
        MessageBox.Show("You are already viewing the Admin Accounts management screen.",
                       "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSuperAdminManageTea_Click(sender As Object, e As EventArgs) Handles btnSuperAdminManageTea.Click
        LoadFormInPanel(New SuperAdminManageTeacherAccounts())
    End Sub

    Private Sub AdminDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Not IsEmbedded Then
            CenterLogo()
            PositionSidebarButtons()
        End If
    End Sub
End Class