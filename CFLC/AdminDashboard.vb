Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class AdminDashboard
    Private currentContent As Form
    Private manageStudentsForm As AdminManageStudents = Nothing
    Private manageSubjectsForm As AdminManageSubjects = Nothing
    Private manageTeachersForm As AdminManageTeacher = Nothing
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BackColor = Color.FromArgb(7, 77, 39) ' Dark green background
        Me.Text = "Dashboard-Admin"


        PositionSidebarButtons()

        ShowHomeContent()

        StyleSidebarButtons()

        ' Load initial counts
        UpdateStudentCountFromDatabase()
        UpdateSubjectCountFromDatabase()
        UpdateTeacherCountFromDatabase()
        UpdateGenderChartFromDatabase()
    End Sub

    Private Sub CenterLogo()
        If Not pnlMainContent.Controls.Contains(PictureBox1) Then
            Return
        End If

        Dim areaWidth As Integer = pnlMainContent.ClientSize.Width
        Dim areaHeight As Integer = pnlMainContent.ClientSize.Height

        PictureBox1.Left = (areaWidth - PictureBox1.Width) \ 2
        PictureBox1.Top = (areaHeight - PictureBox1.Height) \ 2
    End Sub

    Private Sub StyleSidebarButtons()
        ' Style all sidebar buttons
        Dim buttons() As Button = {btnManageStudents, btnManageTeachers, btnManageSections,
                                   btnManageEnrollments, btnManageSubjects, btnGenerateReports}

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
        btnManageStudents.Top = startTop
        btnManageStudents.Left = sidebarPadding
        btnManageStudents.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageStudents.Height = buttonHeight

        btnManageTeachers.Top = btnManageStudents.Bottom + buttonSpacing
        btnManageTeachers.Left = sidebarPadding
        btnManageTeachers.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageTeachers.Height = buttonHeight

        btnManageSections.Top = btnManageTeachers.Bottom + buttonSpacing
        btnManageSections.Left = sidebarPadding
        btnManageSections.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageSections.Height = buttonHeight

        btnManageEnrollments.Top = btnManageSections.Bottom + buttonSpacing
        btnManageEnrollments.Left = sidebarPadding
        btnManageEnrollments.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageEnrollments.Height = buttonHeight

        btnManageSubjects.Top = btnManageEnrollments.Bottom + buttonSpacing
        btnManageSubjects.Left = sidebarPadding
        btnManageSubjects.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageSubjects.Height = buttonHeight

        btnGenerateReports.Top = btnManageSubjects.Bottom + buttonSpacing
        btnGenerateReports.Left = sidebarPadding
        btnGenerateReports.Width = sidebarWidth - (sidebarPadding * 2)
        btnGenerateReports.Height = buttonHeight

        ' Position logout button at the bottom with more spacing
        Dim logoutBottomPadding As Integer = 30 ' More space from bottom
        btnLogout.Top = Me.ClientSize.Height - buttonHeight - logoutBottomPadding
        btnLogout.Left = sidebarPadding
        btnLogout.Width = sidebarWidth - (sidebarPadding * 2)
        btnLogout.Height = buttonHeight
    End Sub

    Private Sub LoadContentForm(child As Form)
        If currentContent IsNot Nothing Then
            ' Unsubscribe from events if it's AdminManageStudents
            If TypeOf currentContent Is AdminManageStudents Then
                Dim oldForm As AdminManageStudents = TryCast(currentContent, AdminManageStudents)
                If oldForm IsNot Nothing Then
                    RemoveHandler oldForm.StudentCountChanged, AddressOf OnStudentCountChanged
                    RemoveHandler oldForm.GenderDataChanged, AddressOf OnGenderDataChanged
                End If
            End If

            ' Unsubscribe from events if it's AdminManageSubjects
            If TypeOf currentContent Is AdminManageSubjects Then
                Dim oldForm As AdminManageSubjects = TryCast(currentContent, AdminManageSubjects)
                If oldForm IsNot Nothing Then
                    RemoveHandler oldForm.SubjectCountChanged, AddressOf OnSubjectCountChanged
                End If
            End If

            ' Unsubscribe from events if it's AdminManageTeacher
            If TypeOf currentContent Is AdminManageTeacher Then
                Dim oldForm As AdminManageTeacher = TryCast(currentContent, AdminManageTeacher)
                If oldForm IsNot Nothing Then
                    RemoveHandler oldForm.TeacherCountChanged, AddressOf OnTeacherCountChanged
                End If
            End If

            currentContent.Close()
            currentContent.Dispose()
            currentContent = Nothing
        End If

        pnlMainContent.Controls.Clear()
        currentContent = child
        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        child.Dock = DockStyle.Fill
        pnlMainContent.Controls.Add(child)
        child.Show()
    End Sub

    Private Sub ShowHomeContent()
        If currentContent IsNot Nothing Then
            ' Unsubscribe from events if it's AdminManageStudents
            If TypeOf currentContent Is AdminManageStudents Then
                Dim oldForm As AdminManageStudents = TryCast(currentContent, AdminManageStudents)
                If oldForm IsNot Nothing Then
                    RemoveHandler oldForm.StudentCountChanged, AddressOf OnStudentCountChanged
                    RemoveHandler oldForm.GenderDataChanged, AddressOf OnGenderDataChanged
                End If
            End If

            ' Unsubscribe from events if it's AdminManageSubjects
            If TypeOf currentContent Is AdminManageSubjects Then
                Dim oldForm As AdminManageSubjects = TryCast(currentContent, AdminManageSubjects)
                If oldForm IsNot Nothing Then
                    RemoveHandler oldForm.SubjectCountChanged, AddressOf OnSubjectCountChanged
                End If
            End If

            ' Unsubscribe from events if it's AdminManageTeacher
            If TypeOf currentContent Is AdminManageTeacher Then
                Dim oldForm As AdminManageTeacher = TryCast(currentContent, AdminManageTeacher)
                If oldForm IsNot Nothing Then
                    RemoveHandler oldForm.TeacherCountChanged, AddressOf OnTeacherCountChanged
                End If
            End If

            currentContent.Close()
            currentContent.Dispose()
            currentContent = Nothing
        End If

        ' Clear the form references when showing home
        manageStudentsForm = Nothing
        manageSubjectsForm = Nothing
        manageTeachersForm = Nothing

        pnlMainContent.Controls.Clear()
        ' Add both the student list dashboard panel and the logo
        ' Order matters for z-ordering (last added appears on top)
        pnlMainContent.Controls.Add(pnlStudentListDashboard)
        pnlMainContent.Controls.Add(pnlSubjectListDashboard)
        pnlMainContent.Controls.Add(pnlTeacherListDashboard)
        pnlMainContent.Controls.Add(PieChartStudentGenderList)
        pnlMainContent.Controls.Add(PictureBox1)
        CenterLogo()

        ' Update counts from database when showing home (in case form is closed)
        UpdateStudentCountFromDatabase()
        UpdateSubjectCountFromDatabase()
        UpdateTeacherCountFromDatabase()
        UpdateGenderChartFromDatabase()
    End Sub

    ' Method to update student count from database (fallback when form is not loaded)
    Private Sub UpdateStudentCountFromDatabase()
        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT COUNT(*) FROM student"

            Using cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, modDBx.conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If lblStudentListDashboard IsNot Nothing Then
                    lblStudentListDashboard.Text = count.ToString()
                End If

                If Label3 IsNot Nothing Then
                    Label3.Text = count.ToString()
                End If
            End Using
        Catch ex As Exception
            ' If there's an error, keep current value or set to 0
            System.Diagnostics.Debug.WriteLine("Error updating student count from database: " & ex.Message)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' Method to update subject count from database (fallback when form is not loaded)
    Private Sub UpdateSubjectCountFromDatabase()
        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT COUNT(*) FROM subject"

            Using cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, modDBx.conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If lblSubjectListDashboard IsNot Nothing Then
                    lblSubjectListDashboard.Text = count.ToString()
                End If
            End Using
        Catch ex As Exception
            ' If there's an error, keep current value or set to 0
            System.Diagnostics.Debug.WriteLine("Error updating subject count from database: " & ex.Message)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' Method to update teacher count from database (fallback when form is not loaded)
    Private Sub UpdateTeacherCountFromDatabase()
        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT COUNT(*) FROM teacher"

            Using cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, modDBx.conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If lblTeacherListDashboard IsNot Nothing Then
                    lblTeacherListDashboard.Text = count.ToString()
                End If
            End Using
        Catch ex As Exception
            ' If there's an error, keep current value or set to 0
            System.Diagnostics.Debug.WriteLine("Error updating teacher count from database: " & ex.Message)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' Method to update gender chart from database (fallback when form is not loaded)
    Private Sub UpdateGenderChartFromDatabase()
        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT Gender, COUNT(*) as Count FROM student GROUP BY Gender"

            Dim maleCount As Integer = 0
            Dim femaleCount As Integer = 0

            Using cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, modDBx.conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim gender As String = ""
                        If Not IsDBNull(reader("Gender")) Then
                            gender = reader("Gender").ToString().Trim()
                        End If
                        Dim count As Integer = Convert.ToInt32(reader("Count"))

                        If gender.Equals("Male", StringComparison.OrdinalIgnoreCase) Then
                            maleCount = count
                        ElseIf gender.Equals("Female", StringComparison.OrdinalIgnoreCase) Then
                            femaleCount = count
                        End If
                    End While
                End Using
            End Using

            UpdateGenderChart(maleCount, femaleCount)
        Catch ex As Exception
            ' If there's an error, keep current chart or set to 0
            System.Diagnostics.Debug.WriteLine("Error updating gender chart from database: " & ex.Message)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' Button click handlers
    Private Sub btnManageStudents_Click(sender As Object, e As EventArgs) Handles btnManageStudents.Click
        ' Dispose previous instance if exists
        If manageStudentsForm IsNot Nothing Then
            RemoveHandler manageStudentsForm.StudentCountChanged, AddressOf OnStudentCountChanged
            manageStudentsForm = Nothing
        End If

        manageStudentsForm = New AdminManageStudents() With {
            .IsEmbedded = True
        }

        ' Subscribe to student count changed event
        AddHandler manageStudentsForm.StudentCountChanged, AddressOf OnStudentCountChanged
        ' Subscribe to gender data changed event
        AddHandler manageStudentsForm.GenderDataChanged, AddressOf OnGenderDataChanged

        LoadContentForm(manageStudentsForm)

        ' Update count immediately
        UpdateStudentCountFromForm()
        ' Update gender chart immediately
        UpdateGenderChartFromForm()
    End Sub

    ' Event handler for student count changes
    Private Sub OnStudentCountChanged(count As Integer)
        If lblStudentListDashboard IsNot Nothing Then
            lblStudentListDashboard.Text = count.ToString()
        End If
        ' Also update Label3 if it exists
        If Label3 IsNot Nothing Then
            Label3.Text = count.ToString()
        End If
    End Sub

    ' Event handler for gender data changes
    Private Sub OnGenderDataChanged(maleCount As Integer, femaleCount As Integer)
        UpdateGenderChart(maleCount, femaleCount)
    End Sub

    ' Method to update student count from the form
    Private Sub UpdateStudentCountFromForm()
        If manageStudentsForm IsNot Nothing Then
            Dim count As Integer = manageStudentsForm.GetStudentCount()
            OnStudentCountChanged(count)
        End If
    End Sub

    ' Method to update gender chart from the form
    Private Sub UpdateGenderChartFromForm()
        If manageStudentsForm IsNot Nothing Then
            Dim genderCounts = manageStudentsForm.GetGenderCounts()
            UpdateGenderChart(genderCounts("Male"), genderCounts("Female"))
        End If
    End Sub

    ' Method to update the gender pie chart
    Private Sub UpdateGenderChart(maleCount As Integer, femaleCount As Integer)
        Try
            ' Check if the chart control exists - search in multiple locations
            Dim chartControl As Chart = Nothing

            ' First, try to find by exact name in pnlMainContent
            For Each ctrl As Control In pnlMainContent.Controls
                If TypeOf ctrl Is Chart AndAlso ctrl.Name = "PieChartStudentGenderList" Then
                    chartControl = DirectCast(ctrl, Chart)
                    Exit For
                End If
            Next

            ' If not found, check in pnlStudentListDashboard
            If chartControl Is Nothing AndAlso pnlStudentListDashboard IsNot Nothing Then
                For Each ctrl As Control In pnlStudentListDashboard.Controls
                    If TypeOf ctrl Is Chart Then
                        If ctrl.Name = "PieChartStudentGenderList" OrElse
                           ctrl.Name.Contains("Chart") OrElse ctrl.Name.Contains("Pie") OrElse
                           ctrl.Name.Contains("Gender") Then
                            chartControl = DirectCast(ctrl, Chart)
                            Exit For
                        End If
                    End If
                Next
            End If

            ' If still not found, search all controls recursively
            If chartControl Is Nothing Then
                chartControl = FindChartControl(Me)
            End If

            ' If chart exists, update it
            If chartControl IsNot Nothing Then
                chartControl.Series.Clear()
                chartControl.ChartAreas.Clear()

                ' Add chart area
                Dim chartArea As New ChartArea("GenderChartArea")
                chartControl.ChartAreas.Add(chartArea)

                ' Add series for pie chart
                Dim series As New Series("GenderSeries")
                series.ChartType = SeriesChartType.Pie
                series.IsValueShownAsLabel = True
                series.LabelFormat = "#,##0"

                ' Add data points with colors
                If maleCount > 0 Then
                    Dim malePoint As New DataPoint(0, maleCount)
                    malePoint.Color = Color.Green
                    malePoint.LegendText = "Male"
                    malePoint.Label = "Male: #VALY"
                    series.Points.Add(malePoint)
                End If

                If femaleCount > 0 Then
                    Dim femalePoint As New DataPoint(1, femaleCount)
                    femalePoint.Color = Color.LightGreen
                    femalePoint.LegendText = "Female"
                    femalePoint.Label = "Female: #VALY"
                    series.Points.Add(femalePoint)
                End If

                ' If no data, add placeholder
                If maleCount = 0 AndAlso femaleCount = 0 Then
                    Dim emptyPoint As New DataPoint(0, 1)
                    emptyPoint.Color = Color.Gray
                    emptyPoint.LegendText = "No Data"
                    emptyPoint.IsEmpty = True
                    series.Points.Add(emptyPoint)
                End If

                chartControl.Series.Add(series)

                ' Configure chart appearance
                chartControl.BackColor = Color.Transparent
                chartArea.BackColor = Color.Transparent

                ' Add legend
                If chartControl.Legends.Count = 0 Then
                    Dim legend As New Legend("GenderLegend")
                    legend.Docking = Docking.Bottom
                    chartControl.Legends.Add(legend)
                End If
            Else
                ' Chart control doesn't exist - log for debugging
                System.Diagnostics.Debug.WriteLine("PieChartStudentGenderList not found. Please add a Chart control named 'PieChartStudentGenderList' to the form.")
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating gender chart: " & ex.Message)
        End Try
    End Sub

    ' Helper method to find chart control recursively
    Private Function FindChartControl(parent As Control) As Chart
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is Chart Then
                Dim chart As Chart = DirectCast(ctrl, Chart)
                If chart.Name = "PieChartStudentGenderList" OrElse
                   chart.Name.Contains("Gender") OrElse
                   chart.Name.Contains("Pie") Then
                    Return chart
                End If
            End If

            ' Recursively search child controls
            Dim foundChart As Chart = FindChartControl(ctrl)
            If foundChart IsNot Nothing Then
                Return foundChart
            End If
        Next
        Return Nothing
    End Function

    Private Sub btnManageTeachers_Click(sender As Object, e As EventArgs) Handles btnManageTeachers.Click
        ' Dispose previous instance if exists
        If manageTeachersForm IsNot Nothing Then
            RemoveHandler manageTeachersForm.TeacherCountChanged, AddressOf OnTeacherCountChanged
            manageTeachersForm = Nothing
        End If

        manageTeachersForm = New AdminManageTeacher() With {
            .IsEmbedded = True
        }

        ' Subscribe to teacher count changed event
        AddHandler manageTeachersForm.TeacherCountChanged, AddressOf OnTeacherCountChanged

        LoadContentForm(manageTeachersForm)

        ' Update count immediately
        UpdateTeacherCountFromForm()
    End Sub

    ' Event handler for teacher count changes
    Private Sub OnTeacherCountChanged(count As Integer)
        If lblTeacherListDashboard IsNot Nothing Then
            lblTeacherListDashboard.Text = count.ToString()
        End If
    End Sub

    ' Method to update teacher count from the form
    Private Sub UpdateTeacherCountFromForm()
        If manageTeachersForm IsNot Nothing Then
            Dim count As Integer = manageTeachersForm.GetTeacherCount()
            OnTeacherCountChanged(count)
        End If
    End Sub

    Private Sub btnManageSections_Click(sender As Object, e As EventArgs) Handles btnManageSections.Click
        Dim manageSectionsForm As New AdminManageSections() With {
            .IsEmbedded = True
        }
        LoadContentForm(manageSectionsForm)
    End Sub

    Private Sub btnManageEnrollments_Click(sender As Object, e As EventArgs) Handles btnManageEnrollments.Click
        Dim manageEnrollmentForms As New ManageEnrollmentForms() With {
            .IsEmbedded = True
        }
        LoadContentForm(manageEnrollmentForms)
    End Sub

    Private Sub btnManageSubjects_Click(sender As Object, e As EventArgs) Handles btnManageSubjects.Click
        ' Dispose previous instance if exists
        If manageSubjectsForm IsNot Nothing Then
            RemoveHandler manageSubjectsForm.SubjectCountChanged, AddressOf OnSubjectCountChanged
            manageSubjectsForm = Nothing
        End If

        manageSubjectsForm = New AdminManageSubjects() With {
            .IsEmbedded = True
        }

        ' Subscribe to subject count changed event
        AddHandler manageSubjectsForm.SubjectCountChanged, AddressOf OnSubjectCountChanged

        LoadContentForm(manageSubjectsForm)

        ' Update count immediately
        UpdateSubjectCountFromForm()
    End Sub
    
    ' Event handler for subject count changes
    Private Sub OnSubjectCountChanged(count As Integer)
        If lblSubjectListDashboard IsNot Nothing Then
            lblSubjectListDashboard.Text = count.ToString()
        End If
    End Sub
    
    ' Method to update subject count from the form
    Private Sub UpdateSubjectCountFromForm()
        If manageSubjectsForm IsNot Nothing Then
            Dim count As Integer = manageSubjectsForm.GetSubjectCount()
            OnSubjectCountChanged(count)
        End If
    End Sub

    Private Sub btnGenerateReports_Click(sender As Object, e As EventArgs) Handles btnGenerateReports.Click
        ' TODO: Open Generate Reports form
        MessageBox.Show("Generate Reports - Coming Soon")
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub pnlMainContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlMainContent.Paint

    End Sub

    Private Sub btnBackToDashboard_Click(sender As Object, e As EventArgs) Handles btnBackToDashboard.Click
        ShowHomeContent()
    End Sub


End Class

