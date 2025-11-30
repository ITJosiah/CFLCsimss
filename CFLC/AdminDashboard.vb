Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Collections.Generic

Public Class AdminDashboard
    Private currentContent As Form
    Private manageStudentsForm As AdminManageStudents = Nothing
    Private manageSubjectsForm As AdminManageSubjects = Nothing
    Private manageTeachersForm As AdminManageTeacher = Nothing
    Private manageEnrollmentForms As ManageEnrollmentForms = Nothing
    Private selectedYearFilter As String = Nothing ' Stores the selected year filter (e.g., "2024-2025")
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
        UpdateMunicipalityChartFromDatabase()
        UpdateEnrollmentPerYearChartFromDatabase()

        ' Configure ComboBox to be dropdown list only (no typing)
        ComboBoxEnrollmentPerYearDashboard.DropDownStyle = ComboBoxStyle.DropDownList

        ' Populate year filter ComboBox
        PopulateYearComboBox()

        ' Add event handler for ComboBox selection change
        AddHandler ComboBoxEnrollmentPerYearDashboard.SelectedIndexChanged, AddressOf ComboBoxEnrollmentPerYearDashboard_SelectedIndexChanged
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

    Friend Sub LoadContentForm(child As Form)
        If currentContent IsNot Nothing Then
            ' Unsubscribe from events if it's AdminManageStudents
            ' Note: Student count subscription removed - now using enrollment count instead
            ' If TypeOf currentContent Is AdminManageStudents Then
            '     Dim oldForm As AdminManageStudents = TryCast(currentContent, AdminManageStudents)
            '     If oldForm IsNot Nothing Then
            '         RemoveHandler oldForm.StudentCountChanged, AddressOf OnStudentCountChanged
            '     End If
            ' End If

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

            ' Unsubscribe from events if it's ManageEnrollmentForms
            If TypeOf currentContent Is ManageEnrollmentForms Then
                Dim oldForm As ManageEnrollmentForms = TryCast(currentContent, ManageEnrollmentForms)
                If oldForm IsNot Nothing Then
                    RemoveHandler oldForm.GenderDataChanged, AddressOf OnGenderDataChanged
                    RemoveHandler oldForm.EnrollmentCountChanged, AddressOf OnStudentCountChanged
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
        
        ' Hide charts if ManageEnrollmentForms is loaded (to prevent overlap with data grid)
        If TypeOf child Is ManageEnrollmentForms Then
            If PieChartStudentGenderList IsNot Nothing Then
                PieChartStudentGenderList.Visible = False
                PieChartStudentGenderList.SendToBack()
            End If
            If PieChartMunicipalityList IsNot Nothing Then
                PieChartMunicipalityList.Visible = False
                PieChartMunicipalityList.SendToBack()
            End If
        End If
    End Sub

    Private Sub ShowHomeContent()
        If currentContent IsNot Nothing Then
            ' Unsubscribe from events if it's AdminManageStudents
            ' Note: Student count subscription removed - now using enrollment count instead
            ' If TypeOf currentContent Is AdminManageStudents Then
            '     Dim oldForm As AdminManageStudents = TryCast(currentContent, AdminManageStudents)
            '     If oldForm IsNot Nothing Then
            '         RemoveHandler oldForm.StudentCountChanged, AddressOf OnStudentCountChanged
            '     End If
            ' End If

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

            ' Unsubscribe from events if it's ManageEnrollmentForms
            If TypeOf currentContent Is ManageEnrollmentForms Then
                Dim oldForm As ManageEnrollmentForms = TryCast(currentContent, ManageEnrollmentForms)
                If oldForm IsNot Nothing Then
                    RemoveHandler oldForm.GenderDataChanged, AddressOf OnGenderDataChanged
                    RemoveHandler oldForm.EnrollmentCountChanged, AddressOf OnStudentCountChanged
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
        manageEnrollmentForms = Nothing

        pnlMainContent.Controls.Clear()
        ' Add all dashboard panels and charts
        ' Order matters for z-ordering (last added appears on top)
        pnlMainContent.Controls.Add(pnlStudentListDashboard)
        pnlMainContent.Controls.Add(pnlSubjectListDashboard)
        pnlMainContent.Controls.Add(pnlTeacherListDashboard)
        pnlMainContent.Controls.Add(PanelForTotalEnrollmentChartDashboard)
        pnlMainContent.Controls.Add(PieChartStudentGenderList)
        pnlMainContent.Controls.Add(PieChartMunicipalityList)
        pnlMainContent.Controls.Add(ComboBoxEnrollmentPerYearDashboard)
        pnlMainContent.Controls.Add(PictureBox1)

        ' Ensure ChartTotalEnrollmentPerYear is inside PanelForTotalEnrollmentChartDashboard
        If PanelForTotalEnrollmentChartDashboard IsNot Nothing AndAlso ChartTotalEnrollmentPerYear IsNot Nothing Then
            If Not PanelForTotalEnrollmentChartDashboard.Controls.Contains(ChartTotalEnrollmentPerYear) Then
                ' Remove from pnlMainContent if it's there
                If pnlMainContent.Controls.Contains(ChartTotalEnrollmentPerYear) Then
                    pnlMainContent.Controls.Remove(ChartTotalEnrollmentPerYear)
                End If
                ' Add to Panel
                PanelForTotalEnrollmentChartDashboard.Controls.Add(ChartTotalEnrollmentPerYear)
                ChartTotalEnrollmentPerYear.Dock = DockStyle.Fill
            End If
        End If

        ' Ensure PieChartMunicipalityList is visible and properly positioned
        ' (It will be added to a container in UpdateMunicipalityChart if needed)
        If PieChartMunicipalityList IsNot Nothing Then
            PieChartMunicipalityList.Visible = True
        End If

        ' Ensure charts are visible and properly ordered
        ' Bring charts to front, but keep PictureBox1 behind charts (logo should not cover charts)
        If ChartTotalEnrollmentPerYear IsNot Nothing Then
            ChartTotalEnrollmentPerYear.Visible = True
            ChartTotalEnrollmentPerYear.BringToFront()
        End If
        If PieChartStudentGenderList IsNot Nothing Then
            PieChartStudentGenderList.Visible = True
            PieChartStudentGenderList.BringToFront()
        End If
        If PieChartMunicipalityList IsNot Nothing Then
            PieChartMunicipalityList.Visible = True
            PieChartMunicipalityList.BringToFront()
        End If
        If PanelForTotalEnrollmentChartDashboard IsNot Nothing Then
            PanelForTotalEnrollmentChartDashboard.BringToFront()
        End If
        ' PictureBox1 (logo) stays in background, only centered if no content overlaps

        CenterLogo()

        ' Update counts from database when showing home (in case form is closed)
        UpdateStudentCountFromDatabase()
        UpdateSubjectCountFromDatabase()
        UpdateTeacherCountFromDatabase()
        UpdateGenderChartFromDatabase()
        UpdateMunicipalityChartFromDatabase()
        UpdateEnrollmentPerYearChartFromDatabase()

        ' Refresh year ComboBox
        PopulateYearComboBox()
    End Sub

    ' Method to update student count from database (fallback when form is not loaded)
    ' Note: This now shows enrollment count instead of student count
    Private Sub UpdateStudentCountFromDatabase()
        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT COUNT(*) FROM enrollment"

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

    ' Method to update gender chart from database with filter support
    Private Sub UpdateGenderChartFromDatabase()
        Try
            Dim maleCount As Integer = 0
            Dim femaleCount As Integer = 0

            If manageEnrollmentForms IsNot Nothing Then
                Dim genderCounts = manageEnrollmentForms.GetGenderCounts(selectedYearFilter)
                maleCount = genderCounts("Male")
                femaleCount = genderCounts("Female")
            Else
                ' Fallback: query database directly
                modDBx.openConn(modDBx.db_name)
                Dim sql As String = "SELECT s.Gender, COUNT(DISTINCT e.EnrollmentID) as Count " &
                                    "FROM enrollment e " &
                                    "INNER JOIN student s ON e.StudentID = s.StudentID "

                If Not String.IsNullOrEmpty(selectedYearFilter) Then
                    Dim years() As String = selectedYearFilter.Split("-"c)
                    If years.Length = 2 Then
                        Dim startYear As Integer = Convert.ToInt32(years(0))
                        Dim endYear As Integer = Convert.ToInt32(years(1))
                        sql &= "WHERE YEAR(e.StartDate) = " & startYear & " AND YEAR(e.EndDate) = " & endYear & " "
                    End If
                End If

                sql &= "GROUP BY s.Gender"

                Using cmd As New MySqlCommand(sql, modDBx.conn)
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

                If modDBx.conn.State = ConnectionState.Open Then
                    modDBx.conn.Close()
                End If
            End If

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

        ' Note: Student count subscription removed - now using enrollment count instead
        ' AddHandler manageStudentsForm.StudentCountChanged, AddressOf OnStudentCountChanged

        LoadContentForm(manageStudentsForm)
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
    ' Note: This now gets enrollment count from ManageEnrollmentForms instead
    Private Sub UpdateStudentCountFromForm()
        If manageEnrollmentForms IsNot Nothing Then
            Dim count As Integer = manageEnrollmentForms.GetEnrollmentCount(selectedYearFilter)
            OnStudentCountChanged(count)
        End If
    End Sub

    ' Method to update gender chart from the form
    Private Sub UpdateGenderChartFromForm()
        If manageEnrollmentForms IsNot Nothing Then
            Dim genderCounts = manageEnrollmentForms.GetGenderCounts(selectedYearFilter)
            UpdateGenderChart(genderCounts("Male"), genderCounts("Female"))
        End If
    End Sub

    ' Method to update the gender pie chart
    Private Sub UpdateGenderChart(maleCount As Integer, femaleCount As Integer)
        Try
            ' Use the direct reference to the chart control (it's a form member variable)
            Dim chartControl As Chart = PieChartStudentGenderList

            ' If chart exists, update it (don't check if it's in controls - it might be added later)
            If chartControl IsNot Nothing Then
                ' Ensure chart is added to pnlMainContent if not already there
                If Not pnlMainContent.Controls.Contains(chartControl) Then
                    pnlMainContent.Controls.Add(chartControl)
                End If
                chartControl.Series.Clear()
                chartControl.ChartAreas.Clear()

                ' Add chart area
                Dim chartArea As New ChartArea("GenderChartArea")
                chartControl.ChartAreas.Add(chartArea)

                ' Add legend first (before series)
                chartControl.Legends.Clear()
                Dim legend As New Legend("GenderLegend")
                legend.Docking = Docking.Bottom
                legend.ForeColor = Color.White
                legend.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                legend.BackColor = Color.Transparent
                chartControl.Legends.Add(legend)

                ' Add series for pie chart
                Dim series As New Series("GenderSeries")
                series.ChartType = SeriesChartType.Pie
                series.IsValueShownAsLabel = True
                series.LabelFormat = "#,##0"
                series.Legend = "GenderLegend"  ' Link series to legend

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

                ' Hide chart if enrollment form is active (to prevent overlap)
                If currentContent IsNot Nothing AndAlso TypeOf currentContent Is ManageEnrollmentForms Then
                    chartControl.Visible = False
                    chartControl.SendToBack()
                Else
                    ' Ensure chart is visible
                    chartControl.Visible = True
                    chartControl.BringToFront()
                End If

                ' Change label font + color here
                series.IsValueShownAsLabel = True
                series.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                series.LabelForeColor = Color.White

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
        ' Dispose previous instance if exists
        If manageEnrollmentForms IsNot Nothing Then
            RemoveHandler manageEnrollmentForms.GenderDataChanged, AddressOf OnGenderDataChanged
            RemoveHandler manageEnrollmentForms.EnrollmentCountChanged, AddressOf OnStudentCountChanged
            RemoveHandler manageEnrollmentForms.MunicipalityDataChanged, AddressOf OnMunicipalityDataChanged
            RemoveHandler manageEnrollmentForms.EnrollmentPerYearDataChanged, AddressOf OnEnrollmentPerYearDataChanged
            RemoveHandler manageEnrollmentForms.AvailableYearsChanged, AddressOf OnAvailableYearsChanged
            manageEnrollmentForms = Nothing
        End If

        manageEnrollmentForms = New ManageEnrollmentForms() With {
            .IsEmbedded = True
        }

        ' Subscribe to all enrollment data changed events
        AddHandler manageEnrollmentForms.GenderDataChanged, AddressOf OnGenderDataChanged
        AddHandler manageEnrollmentForms.EnrollmentCountChanged, AddressOf OnStudentCountChanged
        AddHandler manageEnrollmentForms.MunicipalityDataChanged, AddressOf OnMunicipalityDataChanged
        AddHandler manageEnrollmentForms.EnrollmentPerYearDataChanged, AddressOf OnEnrollmentPerYearDataChanged
        AddHandler manageEnrollmentForms.AvailableYearsChanged, AddressOf OnAvailableYearsChanged

        LoadContentForm(manageEnrollmentForms)

        ' Update gender chart immediately
        UpdateGenderChartFromForm()
        ' Update enrollment count immediately
        UpdateStudentCountFromForm()
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
        ' Open Generate Reports form
        Dim reportsForm As New AdminGenerateReports() With {
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub pnlMainContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlMainContent.Paint

    End Sub

    Private Sub btnBackToDashboard_Click(sender As Object, e As EventArgs) Handles btnBackToDashboard.Click
        ShowHomeContent()
    End Sub

    ' ===== YEAR FILTERING METHODS =====

    ' Populate the year filter ComboBox
    Private Sub PopulateYearComboBox()
        Try
            ComboBoxEnrollmentPerYearDashboard.Items.Clear()
            ComboBoxEnrollmentPerYearDashboard.Items.Add("All Years")

            If manageEnrollmentForms IsNot Nothing Then
                Dim years = manageEnrollmentForms.GetAvailableYears()
                For Each year As String In years
                    ComboBoxEnrollmentPerYearDashboard.Items.Add(year)
                Next
            Else
                ' Fallback: query database directly
                modDBx.openConn(modDBx.db_name)
                Dim sql As String = "SELECT DISTINCT CONCAT(YEAR(e.StartDate), '-', YEAR(e.EndDate)) as YearRange " &
                                    "FROM enrollment e " &
                                    "ORDER BY YEAR(e.StartDate) DESC"

                Using cmd As New MySqlCommand(sql, modDBx.conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim yearRange As String = reader("YearRange").ToString()
                            If Not String.IsNullOrEmpty(yearRange) Then
                                ComboBoxEnrollmentPerYearDashboard.Items.Add(yearRange)
                            End If
                        End While
                    End Using
                End Using

                If modDBx.conn.State = ConnectionState.Open Then
                    modDBx.conn.Close()
                End If
            End If

            ' Select "All Years" by default
            ComboBoxEnrollmentPerYearDashboard.SelectedIndex = 0
            selectedYearFilter = Nothing
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error populating year ComboBox: " & ex.Message)
        End Try
    End Sub

    ' ComboBox selection changed handler
    Private Sub ComboBoxEnrollmentPerYearDashboard_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ComboBoxEnrollmentPerYearDashboard.SelectedItem IsNot Nothing Then
            Dim selectedItem As String = ComboBoxEnrollmentPerYearDashboard.SelectedItem.ToString()
            If selectedItem = "All Years" Then
                selectedYearFilter = Nothing
            Else
                selectedYearFilter = selectedItem
            End If

            ' Refresh all charts and labels with the new filter
            RefreshAllChartsWithFilter()
        End If
    End Sub

    ' Refresh all charts and labels with current filter
    Private Sub RefreshAllChartsWithFilter()
        UpdateStudentCountFromDatabase()
        UpdateGenderChartFromDatabase()
        UpdateMunicipalityChartFromDatabase()
        UpdateEnrollmentPerYearChartFromDatabase()
    End Sub

    ' ===== EVENT HANDLERS FOR NEW EVENTS =====

    Private Sub OnMunicipalityDataChanged(municipalityCounts As Dictionary(Of String, Integer))
        UpdateMunicipalityChart(municipalityCounts)
    End Sub

    Private Sub OnEnrollmentPerYearDataChanged(enrollmentData As Dictionary(Of String, Integer))
        UpdateEnrollmentPerYearChart(enrollmentData)
    End Sub

    Private Sub OnAvailableYearsChanged(years As List(Of String))
        ' Update ComboBox when years change
        PopulateYearComboBox()
    End Sub

    ' ===== CHART UPDATE METHODS WITH FILTERING =====

    ' Update municipality chart from database
    Private Sub UpdateMunicipalityChartFromDatabase()
        Try
            Dim municipalityCounts As Dictionary(Of String, Integer)

            If manageEnrollmentForms IsNot Nothing Then
                municipalityCounts = manageEnrollmentForms.GetMunicipalityCounts(selectedYearFilter)
            Else
                ' Fallback: query database directly
                municipalityCounts = GetMunicipalityCountsFromDatabase(selectedYearFilter)
            End If

            UpdateMunicipalityChart(municipalityCounts)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating municipality chart from database: " & ex.Message)
        End Try
    End Sub

    ' Update enrollment per year chart from database
    Private Sub UpdateEnrollmentPerYearChartFromDatabase()
        Try
            Dim enrollmentData As Dictionary(Of String, Integer)

            If manageEnrollmentForms IsNot Nothing Then
                enrollmentData = manageEnrollmentForms.GetEnrollmentPerYearData(selectedYearFilter)
            Else
                ' Fallback: query database directly
                enrollmentData = GetEnrollmentPerYearDataFromDatabase(selectedYearFilter)
            End If

            UpdateEnrollmentPerYearChart(enrollmentData)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating enrollment per year chart from database: " & ex.Message)
        End Try
    End Sub

    ' Helper methods for database fallback queries
    ' Count distinct students per municipality (not enrollments)
    Private Function GetMunicipalityCountsFromDatabase(yearFilter As String) As Dictionary(Of String, Integer)
        Dim municipalityCounts As New Dictionary(Of String, Integer)()

        Try
            modDBx.openConn(modDBx.db_name)
            ' Count distinct students per municipality, connected to enrollment
            Dim sql As String = "SELECT s.Municipality, COUNT(DISTINCT s.StudentID) as Count " &
                                "FROM enrollment e " &
                                "INNER JOIN student s ON e.StudentID = s.StudentID "

            If Not String.IsNullOrEmpty(yearFilter) Then
                Dim years() As String = yearFilter.Split("-"c)
                If years.Length = 2 Then
                    Dim startYear As Integer = Convert.ToInt32(years(0))
                    Dim endYear As Integer = Convert.ToInt32(years(1))
                    sql &= "WHERE YEAR(e.StartDate) = " & startYear & " AND YEAR(e.EndDate) = " & endYear & " "
                End If
            End If

            sql &= "GROUP BY s.Municipality ORDER BY Count DESC"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim municipality As String = ""
                        If Not IsDBNull(reader("Municipality")) Then
                            municipality = reader("Municipality").ToString().Trim()
                        End If
                        If Not String.IsNullOrEmpty(municipality) Then
                            Dim count As Integer = Convert.ToInt32(reader("Count"))
                            municipalityCounts(municipality) = count
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error getting municipality counts from database: " & ex.Message)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try

        Return municipalityCounts
    End Function

    Private Function GetEnrollmentPerYearDataFromDatabase(yearFilter As String) As Dictionary(Of String, Integer)
        Dim enrollmentData As New Dictionary(Of String, Integer)()

        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = ""

            If Not String.IsNullOrEmpty(yearFilter) Then
                ' Return monthly data for the filtered year
                Dim years() As String = yearFilter.Split("-"c)
                If years.Length = 2 Then
                    Dim startYear As Integer = Convert.ToInt32(years(0))
                    sql = "SELECT MONTH(e.StartDate) as MonthNum, " &
                          "CASE MONTH(e.StartDate) " &
                          "WHEN 1 THEN 'January' WHEN 2 THEN 'February' WHEN 3 THEN 'March' " &
                          "WHEN 4 THEN 'April' WHEN 5 THEN 'May' WHEN 6 THEN 'June' " &
                          "WHEN 7 THEN 'July' WHEN 8 THEN 'August' WHEN 9 THEN 'September' " &
                          "WHEN 10 THEN 'October' WHEN 11 THEN 'November' WHEN 12 THEN 'December' " &
                          "END as MonthName, " &
                          "COUNT(DISTINCT e.EnrollmentID) as Count " &
                          "FROM enrollment e " &
                          "WHERE YEAR(e.StartDate) = " & startYear & " " &
                          "GROUP BY MONTH(e.StartDate) " &
                          "ORDER BY MonthNum"
                End If
            Else
                ' Return yearly data (all years)
                sql = "SELECT CONCAT(YEAR(e.StartDate), '-', YEAR(e.EndDate)) as YearRange, " &
                      "COUNT(DISTINCT e.EnrollmentID) as Count " &
                      "FROM enrollment e " &
                      "GROUP BY YEAR(e.StartDate), YEAR(e.EndDate) " &
                      "ORDER BY YEAR(e.StartDate)"
            End If

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim key As String = ""
                        If Not String.IsNullOrEmpty(yearFilter) Then
                            key = reader("MonthName").ToString()
                        Else
                            key = reader("YearRange").ToString()
                        End If
                        Dim count As Integer = Convert.ToInt32(reader("Count"))
                        enrollmentData(key) = count
                    End While
                End Using
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error getting enrollment per year data from database: " & ex.Message)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try

        Return enrollmentData
    End Function

    ' ===== CHART RENDERING METHODS =====

    ' Update municipality pie chart
    Private Sub UpdateMunicipalityChart(municipalityCounts As Dictionary(Of String, Integer))
        Try
            Dim chartControl As Chart = PieChartMunicipalityList

            If chartControl IsNot Nothing Then
                ' Ensure chart is in pnlMainContent
                If Not pnlMainContent.Controls.Contains(chartControl) Then
                    pnlMainContent.Controls.Add(chartControl)
                End If

                chartControl.Series.Clear()
                chartControl.ChartAreas.Clear()

                Dim chartArea As New ChartArea("MunicipalityChartArea")
                chartControl.ChartAreas.Add(chartArea)

                Dim series As New Series("MunicipalitySeries")
                series.ChartType = SeriesChartType.Pie
                series.IsValueShownAsLabel = True
                series.LabelFormat = "#,##0"

                ' Configure label style to line up based on corresponding pie slices (radial alignment)
                ' "Outside" positions labels outside the pie, aligned with their slices
                series("PieLabelStyle") = "Outside"
                series("PieLineColor") = "Black"
                ' Disable SmartLabelStyle to allow manual radial alignment
                series.SmartLabelStyle.Enabled = False
                ' Set label font and color - transparent background, black text
                series.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                series.LabelForeColor = Color.Black
                series.LabelBackColor = Color.Transparent

                ' Add data points for each municipality
                Dim colorIndex As Integer = 0
                Dim colors() As Color = {Color.Green, Color.LightGreen, Color.DarkGreen, Color.ForestGreen,
                                        Color.SeaGreen, Color.MediumSeaGreen, Color.LimeGreen, Color.YellowGreen}

                For Each kvp As KeyValuePair(Of String, Integer) In municipalityCounts
                    If kvp.Value > 0 Then
                        Dim point As New DataPoint(0, kvp.Value)
                        point.Color = colors(colorIndex Mod colors.Length)
                        point.LegendText = kvp.Key
                        point.Label = kvp.Key & ": #VALY"
                        point.LabelForeColor = Color.Black
                        point.LabelBackColor = Color.Transparent
                        ' Don't set LabelAngle - let it align automatically with the pie slice (radial)
                        series.Points.Add(point)
                        colorIndex += 1
                    End If
                Next

                ' Configure chart area for better label positioning
                chartArea.Area3DStyle.Enable3D = False

                ' If no data, add placeholder
                If municipalityCounts.Count = 0 Then
                    Dim emptyPoint As New DataPoint(0, 1)
                    emptyPoint.Color = Color.Gray
                    emptyPoint.LegendText = "No Data"
                    emptyPoint.IsEmpty = True
                    series.Points.Add(emptyPoint)
                End If

                chartControl.Series.Add(series)

                ' Make chart background lighter for better label visibility
                chartControl.BackColor = Color.FromArgb(40, 130, 61) ' Lighter green background
                chartArea.BackColor = Color.Transparent

                ' Force label colors to be applied after series is added - transparent background, black text
                For Each point As DataPoint In series.Points
                    point.LabelForeColor = Color.Black
                    point.LabelBackColor = Color.Transparent
                Next

                ' Hide chart if enrollment form is active (to prevent overlap)
                If currentContent IsNot Nothing AndAlso TypeOf currentContent Is ManageEnrollmentForms Then
                    chartControl.Visible = False
                    chartControl.SendToBack()
                Else
                    chartControl.Visible = True
                    chartControl.BringToFront()
                End If
                ' Adjust inner plot position to make pie chart bigger and fit better
                chartArea.InnerPlotPosition.Auto = False
                chartArea.InnerPlotPosition.X = 25
                chartArea.InnerPlotPosition.Y = 20
                chartArea.InnerPlotPosition.Width = 50
                chartArea.InnerPlotPosition.Height = 65

            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating municipality chart: " & ex.Message)
        End Try
    End Sub

    ' Update enrollment per year chart (bar/line chart)
    Private Sub UpdateEnrollmentPerYearChart(enrollmentData As Dictionary(Of String, Integer))
        Try
            Dim chartControl As Chart = ChartTotalEnrollmentPerYear

            If chartControl IsNot Nothing Then
                ' Clear previous series and chart areas
                chartControl.Series.Clear()
                chartControl.ChartAreas.Clear()

                ' Create chart area
                Dim chartArea As New ChartArea("EnrollmentChartArea")
                chartControl.ChartAreas.Add(chartArea)

                ' Make chart and chart area backgrounds transparent
                chartControl.BackColor = Color.Transparent
                chartArea.BackColor = Color.Transparent

                ' Keep axis lines visible
                chartArea.AxisX.LineColor = Color.Black
                chartArea.AxisY.LineColor = Color.Black

                ' Optionally, adjust grid lines (light gray or transparent)
                chartArea.AxisX.MajorGrid.LineColor = Color.Black
                chartArea.AxisY.MajorGrid.LineColor = Color.Black

                ' Create series
                Dim series As New Series("EnrollmentSeries")
                series.ChartType = SeriesChartType.Column
                series.IsValueShownAsLabel = True          ' Show label inside bar
                series.LabelForeColor = Color.Black        ' Label color for visibility
                series.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                series.LabelFormat = "#,##0"
                series("LabelStyle") = "Bottom"            ' Center labels inside bars
                series.SmartLabelStyle.Enabled = False     ' Disable smart labels

                ' Define bar colors
                Dim barColors() As Color = {Color.Green, Color.LightGreen, Color.DarkGreen, Color.ForestGreen,
                                           Color.SeaGreen, Color.MediumSeaGreen, Color.LimeGreen, Color.YellowGreen,
                                           Color.OliveDrab, Color.DarkSeaGreen, Color.MediumAquamarine, Color.SpringGreen}

                ' Add data points
                Dim colorIndex As Integer = 0
                For Each kvp As KeyValuePair(Of String, Integer) In enrollmentData
                    Dim point As New DataPoint()
                    point.SetValueXY(kvp.Key, kvp.Value)
                    point.Color = barColors(colorIndex Mod barColors.Length)
                    series.Points.Add(point)
                    colorIndex += 1
                Next

                ' Add series to chart
                chartControl.Series.Add(series)

                ' Configure axes
                chartArea.AxisX.Title = If(selectedYearFilter IsNot Nothing, "Month", "School Year")
                chartArea.AxisY.Title = "Number of Enrollments"
                chartArea.AxisX.Interval = 1
                chartArea.AxisX.LabelStyle.Angle = 100

                ' Hide chart if enrollment form is active (to prevent overlap)
                If currentContent IsNot Nothing AndAlso TypeOf currentContent Is ManageEnrollmentForms Then
                    chartControl.Visible = False
                    chartControl.SendToBack()
                Else
                    chartControl.Visible = True
                    chartControl.BringToFront()
                End If

                ' Ensure chart is inside the correct panel
                If PanelForTotalEnrollmentChartDashboard IsNot Nothing Then
                    If Not PanelForTotalEnrollmentChartDashboard.Controls.Contains(chartControl) Then
                        If pnlMainContent.Controls.Contains(chartControl) Then
                            pnlMainContent.Controls.Remove(chartControl)
                        End If
                        PanelForTotalEnrollmentChartDashboard.Controls.Add(chartControl)
                        chartControl.Dock = DockStyle.Fill
                    End If
                    PanelForTotalEnrollmentChartDashboard.BringToFront()
                End If
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating enrollment per year chart: " & ex.Message)
        End Try
    End Sub

    Private Sub PieChartMunicipalityList_Click(sender As Object, e As EventArgs) Handles PieChartMunicipalityList.Click

    End Sub
End Class

