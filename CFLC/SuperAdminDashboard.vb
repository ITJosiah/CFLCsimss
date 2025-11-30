Imports MySql.Data.MySqlClient
Imports System.Collections.Generic

Public Class SuperAdminDashboard

    Private currentContent As Form
    Public Property IsEmbedded As Boolean = False
    
    ' Form references for event subscriptions
    Private manageStudentsForm As AdminManageStudents = Nothing
    Private manageTeachersForm As AdminManageTeacher = Nothing
    Private manageSubjectsForm As AdminManageSubjects = Nothing
    Private manageSectionsForm As AdminManageSections = Nothing
    Private manageEnrollmentsForm As ManageEnrollmentForms = Nothing
    Private manageAdminAccountsForm As SuperAdminManageAdminAccounts = Nothing
    Private manageTeacherAccountsForm As SuperAdminManageTeacherAccounts = Nothing
    Private Sub SuperAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        End If
        Me.Text = "Dashboard-SuperAdmin"


        PositionSidebarButtons()

        ShowHomeContent()

        StyleSidebarButtons()
        
        ' Initialize dashboard data
        RefreshDashboardData()

    End Sub

    Private Sub CenterLogo()
        If Not pnlSuperAdminMainContent.Controls.Contains(PictureBox1) Then
            Return
        End If

        Dim areaWidth As Integer = pnlSuperAdminMainContent.ClientSize.Width
        Dim areaHeight As Integer = pnlSuperAdminMainContent.ClientSize.Height

        PictureBox1.Left = (areaWidth - PictureBox1.Width) \ 2
        PictureBox1.Top = (areaHeight - PictureBox1.Height) \ 2
    End Sub

    Private Sub StyleSidebarButtons()
        ' Style all sidebar buttons
        Dim buttons() As Button = {btnSuperAdminManageAdmin, btnSuperAdminManageTea, btnSuperAdminManageSysCon, btnSuperAdminAccessLogs,
                                   btnSuperAdminGenerateReports}

        For Each btn As Button In buttons
            btn.BackColor = Color.LightGray
            btn.ForeColor = Color.Black
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = Color.Gainsboro ' Slight hover effect
            btn.Font = New Font(btn.Font.FontFamily, 15, FontStyle.Bold)
            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.Padding = New Padding(15, 0, 0, 0) ' More left padding for text
        Next

        ' Style logout button differently (red)
        btnLogout.BackColor = Color.Red
        btnLogout.ForeColor = Color.White
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseOverBackColor = Color.DarkRed ' Darker red on hover
        btnLogout.Font = New Font(btnLogout.Font.FontFamily, 12, FontStyle.Bold)
        btnLogout.TextAlign = ContentAlignment.MiddleCenter ' Center text for logout
    End Sub



    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
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
    Private Sub AdminDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterLogo()
        PositionSidebarButtons()
    End Sub

    Private Sub PositionSidebarButtons()
        ' Position sidebar buttons vertically with better spacing
        Dim sidebarWidth As Integer = 250
        Dim sidebarPadding As Integer = 10 ' Padding on left and right sides
        Dim buttonHeight As Integer = 70 ' Slightly taller for better appearance
        Dim buttonSpacing As Integer = 50 ' More space between buttons for better visual separation
        Dim startTop As Integer = 60 ' More space from top
        Dim buttonWidth As Integer = 70
        ' Position each button with padding
        btnSuperAdminManageAdmin.Top = startTop
        btnSuperAdminManageAdmin.Left = sidebarPadding
        btnSuperAdminManageAdmin.Width = sidebarWidth - (sidebarPadding * 2)
        btnSuperAdminManageAdmin.Height = buttonHeight

        btnSuperAdminManageTea.Top = btnSuperAdminManageAdmin.Bottom + buttonSpacing
        btnSuperAdminManageTea.Left = sidebarPadding
        btnSuperAdminManageTea.Width = sidebarWidth - (sidebarPadding * 2)
        btnSuperAdminManageTea.Height = buttonHeight

        btnSuperAdminManageSysCon.Top = btnSuperAdminManageTea.Bottom + buttonSpacing
        btnSuperAdminManageSysCon.Left = sidebarPadding
        btnSuperAdminManageSysCon.Width = sidebarWidth - (sidebarPadding * 2)
        btnSuperAdminManageSysCon.Height = buttonHeight

        btnSuperAdminAccessLogs.Top = btnSuperAdminManageSysCon.Bottom + buttonSpacing
        btnSuperAdminAccessLogs.Left = sidebarPadding
        btnSuperAdminAccessLogs.Width = sidebarWidth - (sidebarPadding * 2)
        btnSuperAdminAccessLogs.Height = buttonHeight

        btnSuperAdminGenerateReports.Top = btnSuperAdminAccessLogs.Bottom + buttonSpacing
        btnSuperAdminGenerateReports.Left = sidebarPadding
        btnSuperAdminGenerateReports.Width = sidebarWidth - (sidebarPadding * 2)
        btnSuperAdminGenerateReports.Height = buttonHeight

        ' Position logout button at the bottom with more spacing
        Dim logoutBottomPadding As Integer = 30 ' More space from bottom
        btnLogout.Top = Me.ClientSize.Height - buttonHeight - logoutBottomPadding
        btnLogout.Left = sidebarPadding
        btnLogout.Width = sidebarWidth - (sidebarPadding * 2)
        btnLogout.Height = buttonHeight
    End Sub

    Private Sub LoadContentForm(child As Form)
        ' Unsubscribe from previous form events
        UnsubscribeFromFormEvents()
        
        If currentContent IsNot Nothing Then
            currentContent.Close()
            currentContent.Dispose()
            currentContent = Nothing
        End If

        ' Remove only the main content controls — do not remove the sidebar panel
        ClearMainContentExceptSidebar()

        currentContent = child
        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        child.Dock = DockStyle.Fill
        pnlSuperAdminMainContent.Controls.Add(child)
        child.Show()
        
        ' Subscribe to form events based on type
        SubscribeToFormEvents(child)
    End Sub
    
    Private Sub UnsubscribeFromFormEvents()
        If manageStudentsForm IsNot Nothing Then
            RemoveHandler manageStudentsForm.StudentCountChanged, AddressOf OnStudentCountChanged
        End If
        If manageTeachersForm IsNot Nothing Then
            RemoveHandler manageTeachersForm.TeacherCountChanged, AddressOf OnTeacherCountChanged
        End If
        If manageSubjectsForm IsNot Nothing Then
            RemoveHandler manageSubjectsForm.SubjectCountChanged, AddressOf OnSubjectCountChanged
        End If
        If manageSectionsForm IsNot Nothing Then
            RemoveHandler manageSectionsForm.SectionCountChanged, AddressOf OnSectionCountChanged
        End If
        If manageEnrollmentsForm IsNot Nothing Then
            RemoveHandler manageEnrollmentsForm.EnrollmentCountChanged, AddressOf OnEnrollmentCountChanged
        End If
        If manageAdminAccountsForm IsNot Nothing Then
            RemoveHandler manageAdminAccountsForm.AdminAccountCountChanged, AddressOf OnAdminAccountCountChanged
        End If
        If manageTeacherAccountsForm IsNot Nothing Then
            RemoveHandler manageTeacherAccountsForm.TeacherAccountCountChanged, AddressOf OnTeacherAccountCountChanged
        End If
    End Sub
    
    Private Sub SubscribeToFormEvents(child As Form)
        If TypeOf child Is AdminManageStudents Then
            manageStudentsForm = DirectCast(child, AdminManageStudents)
            AddHandler manageStudentsForm.StudentCountChanged, AddressOf OnStudentCountChanged
            UpdateStudentCountFromForm()
        ElseIf TypeOf child Is AdminManageTeacher Then
            manageTeachersForm = DirectCast(child, AdminManageTeacher)
            AddHandler manageTeachersForm.TeacherCountChanged, AddressOf OnTeacherCountChanged
            UpdateTeacherCountFromForm()
        ElseIf TypeOf child Is AdminManageSubjects Then
            manageSubjectsForm = DirectCast(child, AdminManageSubjects)
            AddHandler manageSubjectsForm.SubjectCountChanged, AddressOf OnSubjectCountChanged
            UpdateSubjectCountFromForm()
        ElseIf TypeOf child Is AdminManageSections Then
            manageSectionsForm = DirectCast(child, AdminManageSections)
            AddHandler manageSectionsForm.SectionCountChanged, AddressOf OnSectionCountChanged
            UpdateSectionCountFromForm()
        ElseIf TypeOf child Is ManageEnrollmentForms Then
            manageEnrollmentsForm = DirectCast(child, ManageEnrollmentForms)
            AddHandler manageEnrollmentsForm.EnrollmentCountChanged, AddressOf OnEnrollmentCountChanged
            UpdateEnrollmentCountFromForm()
        ElseIf TypeOf child Is SuperAdminManageAdminAccounts Then
            manageAdminAccountsForm = DirectCast(child, SuperAdminManageAdminAccounts)
            AddHandler manageAdminAccountsForm.AdminAccountCountChanged, AddressOf OnAdminAccountCountChanged
            UpdateAdminAccountCountFromForm()
        ElseIf TypeOf child Is SuperAdminManageTeacherAccounts Then
            manageTeacherAccountsForm = DirectCast(child, SuperAdminManageTeacherAccounts)
            AddHandler manageTeacherAccountsForm.TeacherAccountCountChanged, AddressOf OnTeacherAccountCountChanged
            UpdateTeacherAccountCountFromForm()
        End If
    End Sub



    ' Utility: remove everything from pnlTeacherMainContent except the left sidebar
    Private Sub ClearMainContentExceptSidebar()
        For i As Integer = pnlSuperAdminMainContent.Controls.Count - 1 To 0 Step -1
            Dim c As Control = pnlSuperAdminMainContent.Controls(i)
            If c Is pnlTeacherSidebar Then
                Continue For
            End If
            pnlSuperAdminMainContent.Controls.RemoveAt(i)
        Next
    End Sub

    Private Sub LoadFormInPanel(childForm As Form)
        pnlSuperAdminMainContent.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlSuperAdminMainContent.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub ShowHomeContent()
        ' Clear form references
        manageStudentsForm = Nothing
        manageTeachersForm = Nothing
        manageSubjectsForm = Nothing
        manageSectionsForm = Nothing
        manageEnrollmentsForm = Nothing
        manageAdminAccountsForm = Nothing
        manageTeacherAccountsForm = Nothing
        
        ' Clear main content
        pnlSuperAdminMainContent.Controls.Clear()
        
        ' Re-add all dashboard panels
        pnlSuperAdminMainContent.Controls.Add(pnlSuperAdminStudentListDashboard)
        pnlSuperAdminMainContent.Controls.Add(pnlSuperAdminTeacherListDashboard)
        pnlSuperAdminMainContent.Controls.Add(pnlSuperAdminSubjectListDashboard)
        pnlSuperAdminMainContent.Controls.Add(pnlSuperAdminSectionList)
        pnlSuperAdminMainContent.Controls.Add(pnlSuperAdminEnrollmentList)
        pnlSuperAdminMainContent.Controls.Add(pnlSuperAdminAccountsList)
        pnlSuperAdminMainContent.Controls.Add(pnlSuperAdminTeacherAccountsList)
        
        ' Ensure panels are visible and in front
        pnlSuperAdminStudentListDashboard.Visible = True
        pnlSuperAdminStudentListDashboard.BringToFront()
        pnlSuperAdminTeacherListDashboard.Visible = True
        pnlSuperAdminTeacherListDashboard.BringToFront()
        pnlSuperAdminSubjectListDashboard.Visible = True
        pnlSuperAdminSubjectListDashboard.BringToFront()
        pnlSuperAdminSectionList.Visible = True
        pnlSuperAdminSectionList.BringToFront()
        pnlSuperAdminEnrollmentList.Visible = True
        pnlSuperAdminEnrollmentList.BringToFront()
        pnlSuperAdminAccountsList.Visible = True
        pnlSuperAdminAccountsList.BringToFront()
        pnlSuperAdminTeacherAccountsList.Visible = True
        pnlSuperAdminTeacherAccountsList.BringToFront()
        
        ' Put logo behind panels
        pnlSuperAdminMainContent.Controls.Add(PictureBox1)
        PictureBox1.SendToBack()
        CenterLogo()
        
        ' Refresh dashboard data
        RefreshDashboardData()
    End Sub

    Private Sub btnSuperAdminManageAdmin_Click(sender As Object, e As EventArgs) Handles btnSuperAdminManageAdmin.Click
        Dim viewSuperAdminManageAdmin As New SuperAdminManageAdminAccounts() With {
            .IsEmbedded = True
        }
        LoadContentForm(viewSuperAdminManageAdmin)
    End Sub

    Private Sub btnSuperAdminManageTea_Click(sender As Object, e As EventArgs) Handles btnSuperAdminManageTea.Click
        Dim viewSuperAdminManageTeacher As New SuperAdminManageTeacherAccounts() With {
         .IsEmbedded = True
        }
        LoadContentForm(viewSuperAdminManageTeacher)
    End Sub

    Private Sub btnBackToDashboard_Click(sender As Object, e As EventArgs) Handles btnBackToDashboard.Click
        ShowHomeContent()
    End Sub

    Private Sub btnSuperAdminAccessLogs_Click(sender As Object, e As EventArgs) Handles btnSuperAdminAccessLogs.Click
        ' Open Access All Logs form
        Dim accessLogsForm As New SuperAdminAccessAllLogs() With {
            .IsEmbedded = True
        }
        LoadContentForm(accessLogsForm)
    End Sub

    Private Sub btnSuperAdminManageSysCon_Click(sender As Object, e As EventArgs) Handles btnSuperAdminManageSysCon.Click
        ' Open System Configuration form
        Dim configForm As New SuperAdminConfiguration() With {
            .IsEmbedded = True
        }
        LoadContentForm(configForm)
    End Sub

    Private Sub btnSuperAdminGenerateReports_Click(sender As Object, e As EventArgs) Handles btnSuperAdminGenerateReports.Click
        ' Open Generate Reports form
        Dim reportsForm As New SuperAdminGenerateReports() With {
            .IsEmbedded = True
        }
        LoadContentForm(reportsForm)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Go back to Form1 (main menu)
        For Each form As Form In Application.OpenForms
            If form.Name = "Form1" Then
                form.Show()
                form.WindowState = FormWindowState.Maximized
                Exit For
            End If
        Next
        Me.Close()
    End Sub
    
    ' Event handlers
    Private Sub OnStudentCountChanged(count As Integer)
        lblSuperAdminStudentListDashboard.Text = count.ToString()
        Label3.Text = count.ToString()
    End Sub
    
    Private Sub OnTeacherCountChanged(count As Integer)
        lblSuperAdminTeacherListDashboard.Text = count.ToString()
        Label5.Text = count.ToString()
    End Sub
    
    Private Sub OnSubjectCountChanged(count As Integer)
        lblSuperAdminSubjectListDashboard.Text = count.ToString()
        Label2.Text = count.ToString()
    End Sub
    
    Private Sub OnSectionCountChanged(count As Integer)
        lblSuperAdminSectionList.Text = count.ToString()
        Label8.Text = count.ToString()
    End Sub
    
    Private Sub OnEnrollmentCountChanged(count As Integer)
        lblSuperAdminEnrollmentList.Text = count.ToString()
        Label13.Text = count.ToString()
    End Sub
    
    Private Sub OnAdminAccountCountChanged(count As Integer)
        lblSuperAdminAccountsList.Text = count.ToString()
        Label11.Text = count.ToString()
    End Sub
    
    Private Sub OnTeacherAccountCountChanged(count As Integer)
        lblSuperAdminTeacherAccountsList.Text = count.ToString()
        Label17.Text = count.ToString()
    End Sub
    
    ' Update methods from forms
    Private Sub UpdateStudentCountFromForm()
        If manageStudentsForm IsNot Nothing Then
            Dim count As Integer = manageStudentsForm.GetStudentCount()
            OnStudentCountChanged(count)
        End If
    End Sub
    
    Private Sub UpdateTeacherCountFromForm()
        If manageTeachersForm IsNot Nothing Then
            Dim count As Integer = manageTeachersForm.GetTeacherCount()
            OnTeacherCountChanged(count)
        End If
    End Sub
    
    Private Sub UpdateSubjectCountFromForm()
        If manageSubjectsForm IsNot Nothing Then
            Dim count As Integer = manageSubjectsForm.GetSubjectCount()
            OnSubjectCountChanged(count)
        End If
    End Sub
    
    Private Sub UpdateSectionCountFromForm()
        If manageSectionsForm IsNot Nothing Then
            Dim count As Integer = manageSectionsForm.GetSectionCount()
            OnSectionCountChanged(count)
        End If
    End Sub
    
    Private Sub UpdateEnrollmentCountFromForm()
        If manageEnrollmentsForm IsNot Nothing Then
            Dim count As Integer = manageEnrollmentsForm.GetEnrollmentCount()
            OnEnrollmentCountChanged(count)
        End If
    End Sub
    
    Private Sub UpdateAdminAccountCountFromForm()
        If manageAdminAccountsForm IsNot Nothing Then
            Dim count As Integer = manageAdminAccountsForm.GetAdminAccountCount()
            OnAdminAccountCountChanged(count)
        End If
    End Sub
    
    Private Sub UpdateTeacherAccountCountFromForm()
        If manageTeacherAccountsForm IsNot Nothing Then
            Dim count As Integer = manageTeacherAccountsForm.GetTeacherAccountCount()
            OnTeacherAccountCountChanged(count)
        End If
    End Sub
    
    ' Refresh dashboard data from database (fallback when forms are not loaded)
    Private Sub RefreshDashboardData()
        UpdateStudentCountFromDatabase()
        UpdateTeacherCountFromDatabase()
        UpdateSubjectCountFromDatabase()
        UpdateSectionCountFromDatabase()
        UpdateEnrollmentCountFromDatabase()
        UpdateAdminAccountCountFromDatabase()
        UpdateTeacherAccountCountFromDatabase()
    End Sub
    
    ' Database update methods (fallback)
    Private Sub UpdateStudentCountFromDatabase()
        Try
            modDBx.openConn("cflc_db")
            Dim query As String = "SELECT COUNT(*) FROM student"
            Using cmd As New MySqlCommand(query, modDBx.conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lblSuperAdminStudentListDashboard.Text = count.ToString()
                Label3.Text = count.ToString()
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating student count: " & ex.Message)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub
    
    Private Sub UpdateTeacherCountFromDatabase()
        Try
            modDBx.openConn("cflc_db")
            Dim query As String = "SELECT COUNT(*) FROM teacher"
            Using cmd As New MySqlCommand(query, modDBx.conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lblSuperAdminTeacherListDashboard.Text = count.ToString()
                Label5.Text = count.ToString()
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating teacher count: " & ex.Message)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub
    
    Private Sub UpdateSubjectCountFromDatabase()
        Try
            modDBx.openConn("cflc_db")
            Dim query As String = "SELECT COUNT(*) FROM subject"
            Using cmd As New MySqlCommand(query, modDBx.conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lblSuperAdminSubjectListDashboard.Text = count.ToString()
                Label2.Text = count.ToString()
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating subject count: " & ex.Message)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub
    
    Private Sub UpdateSectionCountFromDatabase()
        Try
            modDBx.openConn("cflc_db")
            Dim query As String = "SELECT COUNT(*) FROM section"
            Using cmd As New MySqlCommand(query, modDBx.conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lblSuperAdminSectionList.Text = count.ToString()
                Label8.Text = count.ToString()
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating section count: " & ex.Message)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub
    
    Private Sub UpdateEnrollmentCountFromDatabase()
        Try
            modDBx.openConn("cflc_db")
            Dim query As String = "SELECT COUNT(*) FROM enrollment"
            Using cmd As New MySqlCommand(query, modDBx.conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lblSuperAdminEnrollmentList.Text = count.ToString()
                Label13.Text = count.ToString()
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating enrollment count: " & ex.Message)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub
    
    Private Sub UpdateAdminAccountCountFromDatabase()
        Try
            modDBx.openConn("cflc_db")
            Dim query As String = "SELECT COUNT(*) FROM login WHERE user_type IN ('admin', 'superadmin')"
            Using cmd As New MySqlCommand(query, modDBx.conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lblSuperAdminAccountsList.Text = count.ToString()
                Label11.Text = count.ToString()
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating admin account count: " & ex.Message)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub
    
    Private Sub UpdateTeacherAccountCountFromDatabase()
        Try
            modDBx.openConn("cflc_db")
            Dim query As String = "SELECT COUNT(*) FROM login WHERE user_type = 'teacher'"
            Using cmd As New MySqlCommand(query, modDBx.conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lblSuperAdminTeacherAccountsList.Text = count.ToString()
                Label17.Text = count.ToString()
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating teacher account count: " & ex.Message)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub
End Class