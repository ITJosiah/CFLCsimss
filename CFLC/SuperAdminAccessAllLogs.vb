Imports System.Data
Imports MySql.Data.MySqlClient

Public Class SuperAdminAccessAllLogs
    Public Property IsEmbedded As Boolean = False

    Private Sub SuperAdminAccessAllLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(7, 77, 39)
        End If

        Me.Text = "Access All Logs"

        ' Initialize search textbox placeholder
        If txtbxSearchLogs IsNot Nothing Then
            txtbxSearchLogs.Text = "Search by User ID or Event..."
            txtbxSearchLogs.ForeColor = Color.Gray
        End If

        ' Create logs table if it doesn't exist
        CreateLogsTableIfNotExists()

        ' Setup DataGridView
        SetupDataGridView()

        ' Style controls
        StyleControls()

        ' Load all logs
        LoadAllLogs()

        ' Center controls after form is shown and fully laid out
        AddHandler Me.Shown, AddressOf SuperAdminAccessAllLogs_Shown
        AddHandler Me.ResizeEnd, AddressOf SuperAdminAccessAllLogs_ResizeEnd
        AddHandler Me.VisibleChanged, AddressOf SuperAdminAccessAllLogs_VisibleChanged
    End Sub

    Private Sub SuperAdminAccessAllLogs_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Use BeginInvoke to ensure form is fully laid out
        ' Multiple invocations ensure it happens after layout is complete
        Me.BeginInvoke(New Action(AddressOf CenterControls))
        Me.BeginInvoke(New Action(AddressOf CenterControls))
    End Sub

    Private Sub SuperAdminAccessAllLogs_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            ' Center when form becomes visible (important for embedded forms)
            ' Use multiple BeginInvoke to ensure it happens after layout
            Me.BeginInvoke(New Action(AddressOf CenterControls))
            Me.BeginInvoke(New Action(AddressOf CenterControls))
        End If
    End Sub

    Private Sub SuperAdminAccessAllLogs_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        CenterControls()
    End Sub

    Private Sub CenterControls()
        If pnlMainContent Is Nothing Then Return

        ' Wait for form to be fully loaded
        Application.DoEvents()
        
        ' Always use pnlMainContent width - it automatically excludes the sidebar (400px)
        ' pnlMainContent is docked to fill, so it's the available area after sidebar
        Dim panelWidth As Integer = pnlMainContent.ClientSize.Width
        Dim panelHeight As Integer = pnlMainContent.ClientSize.Height
        
        ' Ensure we have valid dimensions
        If panelWidth <= 0 Then
            ' Fallback: if panel width is invalid, calculate from form width minus sidebar
            Dim sidebarWidth As Integer = If(pnlSidebar IsNot Nothing, pnlSidebar.Width, 300)
            panelWidth = Math.Max(100, Me.ClientSize.Width - sidebarWidth)
        End If
        If panelHeight <= 0 Then panelHeight = Me.ClientSize.Height

        ' Center title
        If lblTitle IsNot Nothing Then
            lblTitle.Location = New Point(Math.Max(10, (panelWidth - lblTitle.Width) \ 2), 30)
        End If

        ' Center search label
        If lblSearchLogs IsNot Nothing Then
            lblSearchLogs.Location = New Point(Math.Max(10, (panelWidth - lblSearchLogs.Width) \ 2), 90)
        End If

        ' Center search textbox
        If txtbxSearchLogs IsNot Nothing Then
            txtbxSearchLogs.Location = New Point(Math.Max(10, (panelWidth - txtbxSearchLogs.Width) \ 2), 120)
        End If

        ' Center and size DataGridView - responsive to panel width
        If dgvLogs IsNot Nothing Then
            Dim maxDgvWidth As Integer = 1000
            Dim minDgvWidth As Integer = 600
            Dim dgvWidth As Integer = Math.Max(minDgvWidth, Math.Min(maxDgvWidth, panelWidth - 50))
            Dim dgvHeight As Integer = Math.Min(500, panelHeight - 200)
            dgvLogs.Size = New Size(dgvWidth, dgvHeight)
            dgvLogs.Location = New Point(Math.Max(25, (panelWidth - dgvWidth) \ 2), 170)
        End If
    End Sub

    Private Sub SuperAdminAccessAllLogs_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterControls()
    End Sub

    Private Sub CreateLogsTableIfNotExists()
        Try
            modDBx.openConn(modDBx.db_name)

            ' Check if table exists
            Dim checkTableQuery As String = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = DATABASE() AND table_name = 'logs'"
            Using checkCmd As New MySqlCommand(checkTableQuery, modDBx.conn)
                Dim tableExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If tableExists = 0 Then
                    ' Create the logs table
                    Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS `logs` (" &
                                                     "`id` INT AUTO_INCREMENT PRIMARY KEY, " &
                                                     "`dt` DATETIME NOT NULL, " &
                                                     "`user_accounts_id` VARCHAR(50), " &
                                                     "`event` VARCHAR(255), " &
                                                     "`transactions` TEXT, " &
                                                     "INDEX `idx_dt` (`dt`), " &
                                                     "INDEX `idx_user_accounts_id` (`user_accounts_id`)" &
                                                     ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4"

                    Using createCmd As New MySqlCommand(createTableQuery, modDBx.conn)
                        createCmd.ExecuteNonQuery()
                        MessageBox.Show("Logs table created successfully. Logging is now enabled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking/creating logs table: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub SetupDataGridView()
        If dgvLogs Is Nothing Then Return

        dgvLogs.AutoGenerateColumns = True
        dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLogs.ReadOnly = True
        dgvLogs.AllowUserToAddRows = False
        dgvLogs.RowHeadersVisible = False
        dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub StyleControls()
        ' Style search textbox
        If txtbxSearchLogs IsNot Nothing Then
            txtbxSearchLogs.BackColor = Color.White
            txtbxSearchLogs.ForeColor = Color.Black
            txtbxSearchLogs.BorderStyle = BorderStyle.FixedSingle
        End If

        ' Style DataGridView
        If dgvLogs IsNot Nothing Then
            dgvLogs.BackgroundColor = Color.White
            dgvLogs.BorderStyle = BorderStyle.None
            dgvLogs.Font = New Font("Arial", 9, FontStyle.Regular)
            dgvLogs.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
            dgvLogs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(108, 117, 125)
            dgvLogs.DefaultCellStyle.SelectionForeColor = Color.White
            dgvLogs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(108, 117, 125)
            dgvLogs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            dgvLogs.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Regular)
            dgvLogs.EnableHeadersVisualStyles = False
        End If
    End Sub

    Private Sub LoadAllLogs()
        If dgvLogs Is Nothing Then Return

        Try
            modDBx.openConn(modDBx.db_name)

            ' Query to get all logs with user information
            Dim query As String = "SELECT l.dt AS 'Date/Time', " &
                                  "l.user_accounts_id AS 'User ID', " &
                                  "l.event AS 'Event', " &
                                  "l.transactions AS 'Transaction' " &
                                  "FROM logs l " &
                                  "ORDER BY l.dt DESC"

            Using command As New MySqlCommand(query, modDBx.conn)
                Using adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvLogs.DataSource = table
                    
                    ' Show message if no logs exist
                    If table.Rows.Count = 0 Then
                        ' Don't show message box, just display empty grid
                        ' The table was just created, so it's expected to be empty
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            ' Check if it's a "table doesn't exist" error
            If ex.Number = 1146 Then
                ' Table doesn't exist, try to create it
                CreateLogsTableIfNotExists()
                ' Try loading again
                LoadAllLogs()
            Else
                MessageBox.Show("Error loading logs: " & ex.Message, "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading logs: " & ex.Message, "Database Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub SearchLogs(ByVal searchTerm As String)
        If String.IsNullOrWhiteSpace(searchTerm) OrElse searchTerm = "Search by User ID or Event..." Then
            LoadAllLogs()
            Return
        End If

        Try
            modDBx.openConn(modDBx.db_name)

            Dim sql As String = "SELECT l.dt AS 'Date/Time', " &
                                "l.user_accounts_id AS 'User ID', " &
                                "l.event AS 'Event', " &
                                "l.transactions AS 'Transaction' " &
                                "FROM logs l " &
                                "WHERE l.user_accounts_id LIKE @searchTerm OR l.event LIKE @searchTerm OR l.transactions LIKE @searchTerm " &
                                "ORDER BY l.dt DESC"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@searchTerm", "%" & searchTerm.Trim() & "%")

                Dim dt As New DataTable
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                dgvLogs.DataSource = dt
                dgvLogs.Refresh()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching logs: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' Real-time search as user types
    Private Sub txtbxSearchLogs_TextChanged(sender As Object, e As EventArgs) Handles txtbxSearchLogs.TextChanged
        SearchLogs(txtbxSearchLogs.Text)
    End Sub

    ' Placeholder text for search box
    Private Sub txtbxSearchLogs_Enter(sender As Object, e As EventArgs) Handles txtbxSearchLogs.Enter
        If txtbxSearchLogs.Text = "Search by User ID or Event..." Then
            txtbxSearchLogs.Text = ""
            txtbxSearchLogs.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtbxSearchLogs_Leave(sender As Object, e As EventArgs) Handles txtbxSearchLogs.Leave
        If String.IsNullOrWhiteSpace(txtbxSearchLogs.Text) Then
            txtbxSearchLogs.Text = "Search by User ID or Event..."
            txtbxSearchLogs.ForeColor = Color.Gray
        End If
    End Sub

    ' Ensure selection is cleared after data binding
    Private Sub dgvLogs_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvLogs.DataBindingComplete
        dgvLogs.ClearSelection()
        Try
            If dgvLogs.Rows.Count > 0 AndAlso dgvLogs.Columns.Count > 0 Then
                dgvLogs.CurrentCell = Nothing
            End If
        Catch
            ' ignore potential layout timing exceptions
        End Try
    End Sub
End Class
