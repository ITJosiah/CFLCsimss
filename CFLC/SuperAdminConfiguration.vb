Imports System.IO

Public Class SuperAdminConfiguration
    Public Property IsEmbedded As Boolean = False

    Private configPath As String

    Private Sub SuperAdminConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(7, 77, 39)
        End If

        Me.Text = "System Configuration"

        ' Get config file path
        configPath = Path.Combine(Application.StartupPath, "config.txt")

        ' Load configuration
        LoadConfiguration()

        ' Style controls
        StyleControls()

        ' Center controls after form is shown and fully laid out
        AddHandler Me.Shown, AddressOf SuperAdminConfiguration_Shown
        AddHandler Me.ResizeEnd, AddressOf SuperAdminConfiguration_ResizeEnd
    End Sub

    Private Sub SuperAdminConfiguration_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Use BeginInvoke to ensure form is fully laid out
        Me.BeginInvoke(New Action(AddressOf CenterControls))
    End Sub

    Private Sub SuperAdminConfiguration_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        CenterControls()
    End Sub

    Private Sub CenterControls()
        If pnlMainContent Is Nothing Then Return

        ' Wait for form to be fully loaded
        Application.DoEvents()
        
        ' Always use the panel's client size - this accounts for sidebar when embedded
        ' When embedded, the form is docked in pnlSuperAdminMainContent which excludes the sidebar
        ' When not embedded, pnlMainContent fills the form, so it's the same
        Dim panelWidth As Integer = pnlMainContent.ClientSize.Width
        Dim panelHeight As Integer = pnlMainContent.ClientSize.Height

        ' Center title
        If lblTitle IsNot Nothing Then
            lblTitle.Location = New Point(Math.Max(10, (panelWidth - lblTitle.Width) \ 2), 50)
        End If

        ' Configuration fields group (centered as a unit) - responsive to panel width
        Dim maxFieldGroupWidth As Integer = 500
        Dim minFieldGroupWidth As Integer = 400
        Dim fieldGroupWidth As Integer = Math.Max(minFieldGroupWidth, Math.Min(maxFieldGroupWidth, panelWidth - 100))
        Dim fieldGroupLeft As Integer = Math.Max(50, (panelWidth - fieldGroupWidth) \ 2)
        Dim startTop As Integer = 150
        Dim fieldSpacing As Integer = 50

        ' Server field
        If lblServer IsNot Nothing AndAlso txtbxServer IsNot Nothing Then
            lblServer.Location = New Point(fieldGroupLeft, startTop)
            txtbxServer.Location = New Point(fieldGroupLeft + 100, startTop - 2)
        End If

        ' UID field
        If lblUID IsNot Nothing AndAlso txtbxUID IsNot Nothing Then
            lblUID.Location = New Point(fieldGroupLeft, startTop + fieldSpacing)
            txtbxUID.Location = New Point(fieldGroupLeft + 100, startTop + fieldSpacing - 2)
        End If

        ' Password field
        If lblPassword IsNot Nothing AndAlso txtbxPassword IsNot Nothing Then
            lblPassword.Location = New Point(fieldGroupLeft, startTop + fieldSpacing * 2)
            txtbxPassword.Location = New Point(fieldGroupLeft + 100, startTop + fieldSpacing * 2 - 2)
        End If

        ' Database field
        If lblDatabase IsNot Nothing AndAlso txtbxDatabase IsNot Nothing Then
            lblDatabase.Location = New Point(fieldGroupLeft, startTop + fieldSpacing * 3)
            txtbxDatabase.Location = New Point(fieldGroupLeft + 100, startTop + fieldSpacing * 3 - 2)
        End If

        ' Center save button
        If btnSave IsNot Nothing Then
            btnSave.Location = New Point(Math.Max(10, (panelWidth - btnSave.Width) \ 2), startTop + fieldSpacing * 4 + 20)
        End If
    End Sub

    Private Sub SuperAdminConfiguration_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterControls()
    End Sub

    Private Sub StyleControls()
        ' Style textboxes
        Dim textboxes() As TextBox = {txtbxServer, txtbxUID, txtbxPassword, txtbxDatabase}
        For Each txtbx As TextBox In textboxes
            If txtbx IsNot Nothing Then
                txtbx.BackColor = Color.White
                txtbx.ForeColor = Color.Black
                txtbx.BorderStyle = BorderStyle.FixedSingle
            End If
        Next

        ' Style save button
        If btnSave IsNot Nothing Then
            btnSave.BackColor = Color.FromArgb(108, 117, 125)
            btnSave.ForeColor = Color.White
            btnSave.FlatStyle = FlatStyle.Flat
            btnSave.FlatAppearance.BorderSize = 0
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 100, 110)
            btnSave.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub LoadConfiguration()
        Try
            ' Check if config file exists
            If Not File.Exists(configPath) Then
                MessageBox.Show("config.txt not found. A new configuration file will be created when you save.", 
                                "Configuration File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Set default values
                txtbxServer.Text = "localhost"
                txtbxUID.Text = "root"
                txtbxPassword.Text = ""
                txtbxDatabase.Text = "cflc_database"
                Return
            End If

            ' Read config file
            Dim configText As String = File.ReadAllText(configPath).Trim()

            If String.IsNullOrWhiteSpace(configText) Then
                MessageBox.Show("config.txt is empty. Please enter configuration values.", 
                                "Empty Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Parse config file (format: server=...\nuid=...\npassword=...\ndatabase=...)
            Dim lines() As String = configText.Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)

            For Each line As String In lines
                If line.Contains("=") Then
                    Dim parts() As String = line.Split(New Char() {"="c}, 2)
                    If parts.Length = 2 Then
                        Dim key As String = parts(0).Trim().ToLower()
                        Dim value As String = parts(1).Trim()

                        Select Case key
                            Case "server"
                                txtbxServer.Text = value
                            Case "uid"
                                txtbxUID.Text = value
                            Case "password"
                                txtbxPassword.Text = value
                            Case "database"
                                txtbxDatabase.Text = value
                        End Select
                    End If
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading configuration: " & ex.Message, 
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate inputs
        If String.IsNullOrWhiteSpace(txtbxServer.Text) Then
            MessageBox.Show("Server cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxServer.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtbxUID.Text) Then
            MessageBox.Show("UID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxUID.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtbxDatabase.Text) Then
            MessageBox.Show("Database cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxDatabase.Focus()
            Return
        End If

        Try
            ' Create config content
            Dim configContent As String = "server=" & txtbxServer.Text.Trim() & vbCrLf &
                                         "uid=" & txtbxUID.Text.Trim() & vbCrLf &
                                         "password=" & txtbxPassword.Text.Trim() & vbCrLf &
                                         "database=" & txtbxDatabase.Text.Trim()

            ' Write to config file
            File.WriteAllText(configPath, configContent)

            ' Log the configuration change
            Try
                Dim configInfo As String = "Server: " & txtbxServer.Text.Trim() & ", Database: " & txtbxDatabase.Text.Trim()
                modDBx.Logs("Updated system configuration - " & configInfo, "btnSave_Click")
            Catch
                ' Silently fail if logging doesn't work
            End Try

            MessageBox.Show("Configuration saved successfully!" & vbCrLf & vbCrLf &
                          "Note: You may need to restart the application for changes to take effect.",
                          "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saving configuration: " & ex.Message, 
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
