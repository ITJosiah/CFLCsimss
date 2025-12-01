Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Collections.Generic

Public Class TeacherDashboard
    Private currentContent As Form
    Private teacherViewStudentsForm As TeacherViewStudents = Nothing
    Public Property IsEmbedded As Boolean = False
    Public Property TeacherID As String = ""

    Private Sub TeacherDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties
        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        End If

        ' DEBUG: Verify TeacherID is received
        If String.IsNullOrEmpty(TeacherID) Then
            MessageBox.Show("ERROR: TeacherID is empty in Dashboard!", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show($"TeacherDashboard loaded with TeacherID: {TeacherID}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        StyleSidebarButtons()
        PositionSidebarButtons()
        ShowHomeContent()
        
        ' Initialize dashboard data
        RefreshDashboardData()
        
        ' Style all dashboard panel labels to white
        StyleDashboardLabels()
    End Sub

    Private Sub CenterLogo()
            If Not pnlTeacherMainContent.Controls.Contains(PictureBox1) Then
                Return
            End If

        Dim areaWidth As Integer = pnlTeacherMainContent.ClientSize.Width
        Dim areaHeight As Integer = pnlTeacherMainContent.ClientSize.Height

        PictureBox1.Left = (areaWidth - PictureBox1.Width) \ 2
        PictureBox1.Top = (areaHeight - PictureBox1.Height) \ 2
    End Sub

    Private Sub PositionSidebarButtons()
        ' Position sidebar buttons vertically with better spacing
        Dim sidebarWidth As Integer = 250
        Dim sidebarPadding As Integer = 10
        Dim buttonHeight As Integer = 70
        Dim buttonSpacing As Integer = 50
        Dim startTop As Integer = 60

        btnTeacherViewSection.Top = startTop
        btnTeacherViewSection.Left = sidebarPadding
        btnTeacherViewSection.Width = sidebarWidth - (sidebarPadding * 2)
        btnTeacherViewSection.Height = buttonHeight

        btnTeacherViewStudents.Top = btnTeacherViewSection.Bottom + buttonSpacing
        btnTeacherViewStudents.Left = sidebarPadding
        btnTeacherViewStudents.Width = sidebarWidth - (sidebarPadding * 2)
        btnTeacherViewStudents.Height = buttonHeight

        btnViewAssignedSubjects.Top = btnTeacherViewStudents.Bottom + buttonSpacing
        btnViewAssignedSubjects.Left = sidebarPadding
        btnViewAssignedSubjects.Width = sidebarWidth - (sidebarPadding * 2)
        btnViewAssignedSubjects.Height = buttonHeight

        btnTeacherGenerateReports.Top = btnTeacherViewStudents.Bottom + buttonSpacing
        btnTeacherGenerateReports.Left = sidebarPadding
        btnTeacherGenerateReports.Width = sidebarWidth - (sidebarPadding * 2)
        btnTeacherGenerateReports.Height = buttonHeight

        Dim logoutBottomPadding As Integer = 30
        btnLogout.Top = Me.ClientSize.Height - buttonHeight - logoutBottomPadding
        btnLogout.Left = sidebarPadding
        btnLogout.Width = sidebarWidth - (sidebarPadding * 2)
        btnLogout.Height = buttonHeight

    End Sub

    Private Sub AdminDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterLogo()
        PositionSidebarButtons()
    End Sub

    Private Sub StyleSidebarButtons()
        Dim buttons() As Button = {
                btnTeacherViewSection,
                btnTeacherViewStudents,
                btnViewAssignedSubjects,
                btnTeacherGenerateReports
            }

        For Each btn As Button In buttons
            btn.BackColor = Color.LightGray
            btn.ForeColor = Color.Black
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = Color.Gainsboro
            btn.Font = New Font(btn.Font.FontFamily, 15, FontStyle.Bold)
            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.Padding = New Padding(15, 0, 0, 0)
        Next

        ' Style home button (green)
        btnBackToDashboard.BackColor = Color.FromArgb(40, 167, 69) ' Green
        btnBackToDashboard.ForeColor = Color.White
        btnBackToDashboard.FlatStyle = FlatStyle.Flat
        btnBackToDashboard.FlatAppearance.BorderSize = 0
        btnBackToDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 136, 56) ' Darker green on hover
        btnBackToDashboard.Font = New Font(btnBackToDashboard.Font.FontFamily, 15, FontStyle.Bold)
        btnBackToDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnBackToDashboard.Padding = New Padding(15, 0, 0, 0)

        btnLogout.BackColor = Color.Red
        btnLogout.ForeColor = Color.White
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btnLogout.Font = New Font(btnLogout.Font.FontFamily, 12, FontStyle.Bold)
        btnLogout.TextAlign = ContentAlignment.MiddleCenter
    End Sub
    
    Private Sub StyleDashboardLabels()
        ' Style all labels on count panels to white
        ' Teacher Student List Dashboard
        If Label1 IsNot Nothing Then Label1.ForeColor = Color.White
        If Label3 IsNot Nothing Then Label3.ForeColor = Color.White
        If Label4 IsNot Nothing Then Label4.ForeColor = Color.White
        If lblTeacherStudentListDashboard IsNot Nothing Then lblTeacherStudentListDashboard.ForeColor = Color.White
    End Sub

    Private Sub LoadContentForm(child As Form)
        ' Unsubscribe from previous TeacherViewStudents events
        If teacherViewStudentsForm IsNot Nothing Then
            RemoveHandler teacherViewStudentsForm.StudentCountChanged, AddressOf OnStudentCountChanged
            RemoveHandler teacherViewStudentsForm.FourPSDataChanged, AddressOf OnFourPSDataChanged
            RemoveHandler teacherViewStudentsForm.IndigenousDataChanged, AddressOf OnIndigenousDataChanged
            RemoveHandler teacherViewStudentsForm.GenderDataChanged, AddressOf OnGenderDataChanged
        End If
        
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
        pnlTeacherMainContent.Controls.Add(child)
        child.Show()
        
        ' Subscribe to TeacherViewStudents events if it's that form
        If TypeOf child Is TeacherViewStudents Then
            teacherViewStudentsForm = DirectCast(child, TeacherViewStudents)
            AddHandler teacherViewStudentsForm.StudentCountChanged, AddressOf OnStudentCountChanged
            AddHandler teacherViewStudentsForm.FourPSDataChanged, AddressOf OnFourPSDataChanged
            AddHandler teacherViewStudentsForm.IndigenousDataChanged, AddressOf OnIndigenousDataChanged
            AddHandler teacherViewStudentsForm.GenderDataChanged, AddressOf OnGenderDataChanged
            
            ' Update dashboard immediately
            UpdateStudentCountFromForm()
            UpdateFourPSChartFromForm()
            UpdateIndigenousChartFromForm()
            UpdateGenderChartFromForm()
        End If
    End Sub

    Private Sub ShowHomeContent()
        If currentContent IsNot Nothing Then
            currentContent.Close()
            currentContent.Dispose()
            currentContent = Nothing
        End If

        ' Clear form reference
        teacherViewStudentsForm = Nothing

        ' Remove only the main content controls — keep the sidebar intact
        ClearMainContentExceptSidebar()

        ' Re-add dashboard controls (charts and panel)
        If Not pnlTeacherMainContent.Controls.Contains(pnlTeacherStudentListDashboard) Then
            pnlTeacherMainContent.Controls.Add(pnlTeacherStudentListDashboard)
        End If
        If Not pnlTeacherMainContent.Controls.Contains(PieChartTeacherStudent4psList) Then
            pnlTeacherMainContent.Controls.Add(PieChartTeacherStudent4psList)
        End If
        If Not pnlTeacherMainContent.Controls.Contains(PieChartTeacherStudentIndigenous) Then
            pnlTeacherMainContent.Controls.Add(PieChartTeacherStudentIndigenous)
        End If
        If Not pnlTeacherMainContent.Controls.Contains(PieChartTeacherStudentGenderList) Then
            pnlTeacherMainContent.Controls.Add(PieChartTeacherStudentGenderList)
        End If
        
        ' Ensure charts and panel are visible and in front
        pnlTeacherStudentListDashboard.Visible = True
        pnlTeacherStudentListDashboard.BringToFront()
        PieChartTeacherStudent4psList.Visible = True
        PieChartTeacherStudent4psList.BringToFront()
        PieChartTeacherStudentIndigenous.Visible = True
        PieChartTeacherStudentIndigenous.BringToFront()
        PieChartTeacherStudentGenderList.Visible = True
        PieChartTeacherStudentGenderList.BringToFront()
        
        ' Put logo behind charts
        If Not pnlTeacherMainContent.Controls.Contains(PictureBox1) Then
            pnlTeacherMainContent.Controls.Add(PictureBox1)
        End If
        PictureBox1.SendToBack()
        CenterLogo()
        
        ' Refresh dashboard data from database
        RefreshDashboardData()
        
        ' Style all dashboard panel labels to white
        StyleDashboardLabels()
    End Sub

    ' Utility: remove everything from pnlTeacherMainContent except the left sidebar
    Private Sub ClearMainContentExceptSidebar()
        For i As Integer = pnlTeacherMainContent.Controls.Count - 1 To 0 Step -1
            Dim c As Control = pnlTeacherMainContent.Controls(i)
            If c Is pnlTeacherSidebar Then
                Continue For
            End If
            pnlTeacherMainContent.Controls.RemoveAt(i)
        Next
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

    Private Sub btnTeacherViewSection_Click(sender As Object, e As EventArgs) Handles btnTeacherViewSection.Click
        If String.IsNullOrEmpty(TeacherID) Then
            MessageBox.Show("Cannot open section view - TeacherID is missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim viewTeacherSectionsForms As New TeacherViewSection() With {
            .IsEmbedded = True,
            .TeacherID = Me.TeacherID
        }
        LoadContentForm(viewTeacherSectionsForms)
    End Sub
    Private Sub btnViewStudents_Click(sender As Object, e As EventArgs) Handles btnTeacherViewStudents.Click
        Dim viewStudentsForm As New TeacherViewStudents() With {
            .IsEmbedded = True
        }
        viewStudentsForm.TeacherID = Me.TeacherID ' Set the TeacherID before showing
        LoadContentForm(viewStudentsForm)

    End Sub

    Private Sub btnViewAssignedSubjects_Click(sender As Object, e As EventArgs) Handles btnViewAssignedSubjects.Click
        Dim viewTeacherAssignSubjectsForm As New TeacherViewAssignedSubjects(Me.TeacherID) With {
        .IsEmbedded = True
        }

        LoadContentForm(viewTeacherAssignSubjectsForm)
    End Sub

    Private Sub btnTeacherGenerateReports_Click(sender As Object, e As EventArgs) Handles btnTeacherGenerateReports.Click
        ' Open Generate Reports form for teacher
        Dim reportsForm As New TeacherGenerateReport() With {
            .IsEmbedded = True,
            .TeacherID = Me.TeacherID
        }
        LoadContentForm(reportsForm)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
            ' Go back to LoginForm
            For Each form As Form In Application.OpenForms
                If form.Name = "LoginForm" Then
                    form.Show()
                    form.WindowState = FormWindowState.Maximized
                    Exit For
                End If
            Next
            Me.Close()
        End Sub

    Private Sub btnBackToDashboard_Click(sender As Object, e As EventArgs) Handles btnBackToDashboard.Click
        ShowHomeContent()
    End Sub
    
    ' Event handlers for TeacherViewStudents events
    Private Sub OnStudentCountChanged(count As Integer)
        lblTeacherStudentListDashboard.Text = count.ToString()
        Label3.Text = count.ToString()
    End Sub
    
    Private Sub OnFourPSDataChanged(with4PS As Integer, without4PS As Integer)
        UpdateFourPSChart(with4PS, without4PS)
    End Sub
    
    Private Sub OnIndigenousDataChanged(indigenous As Integer, notIndigenous As Integer)
        UpdateIndigenousChart(indigenous, notIndigenous)
    End Sub
    
    Private Sub OnGenderDataChanged(maleCount As Integer, femaleCount As Integer)
        UpdateGenderChart(maleCount, femaleCount)
    End Sub
    
    ' Update methods from form
    Private Sub UpdateStudentCountFromForm()
        If teacherViewStudentsForm IsNot Nothing Then
            Dim count As Integer = teacherViewStudentsForm.GetStudentCount()
            OnStudentCountChanged(count)
        End If
    End Sub
    
    Private Sub UpdateFourPSChartFromForm()
        If teacherViewStudentsForm IsNot Nothing Then
            Dim counts As Dictionary(Of String, Integer) = teacherViewStudentsForm.GetFourPSCounts()
            UpdateFourPSChart(counts("With 4PS"), counts("No 4PS"))
        End If
    End Sub
    
    Private Sub UpdateIndigenousChartFromForm()
        If teacherViewStudentsForm IsNot Nothing Then
            Dim counts As Dictionary(Of String, Integer) = teacherViewStudentsForm.GetIndigenousCounts()
            UpdateIndigenousChart(counts("Indigenous"), counts("Not Indigenous"))
        End If
    End Sub
    
    Private Sub UpdateGenderChartFromForm()
        If teacherViewStudentsForm IsNot Nothing Then
            Dim counts As Dictionary(Of String, Integer) = teacherViewStudentsForm.GetGenderCounts()
            UpdateGenderChart(counts("Male"), counts("Female"))
        End If
    End Sub
    
    ' Refresh dashboard data from database (fallback when form is not loaded)
    Private Sub RefreshDashboardData()
        UpdateStudentCountFromDatabase()
        UpdateFourPSChartFromDatabase()
        UpdateIndigenousChartFromDatabase()
        UpdateGenderChartFromDatabase()
    End Sub
    
    ' Database update methods (fallback)
    Private Sub UpdateStudentCountFromDatabase()
        Try
            modDBx.openConn("cflc_db")
            Dim query As String = "SELECT COUNT(DISTINCT st.StudentID) 
                                  FROM student st 
                                  INNER JOIN enrollment se ON st.StudentID = se.StudentID 
                                  INNER JOIN section s ON se.SectionID = s.SectionID 
                                  WHERE s.TeacherID = @teacher_id"
            
            Using cmd As New MySqlCommand(query, modDBx.conn)
                cmd.Parameters.AddWithValue("@teacher_id", TeacherID)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lblTeacherStudentListDashboard.Text = count.ToString()
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
    
    Private Sub UpdateFourPSChartFromDatabase()
        Try
            modDBx.openConn("cflc_db")
            Dim query As String = "SELECT 
                                    SUM(CASE WHEN st.`4PsID` IS NOT NULL AND st.`4PsID` != '' THEN 1 ELSE 0 END) AS With4PS,
                                    SUM(CASE WHEN st.`4PsID` IS NULL OR st.`4PsID` = '' THEN 1 ELSE 0 END) AS No4PS
                                  FROM student st 
                                  INNER JOIN enrollment se ON st.StudentID = se.StudentID 
                                  INNER JOIN section s ON se.SectionID = s.SectionID 
                                  WHERE s.TeacherID = @teacher_id"
            
            Using cmd As New MySqlCommand(query, modDBx.conn)
                cmd.Parameters.AddWithValue("@teacher_id", TeacherID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim with4PS As Integer = If(IsDBNull(reader("With4PS")), 0, Convert.ToInt32(reader("With4PS")))
                        Dim no4PS As Integer = If(IsDBNull(reader("No4PS")), 0, Convert.ToInt32(reader("No4PS")))
                        UpdateFourPSChart(with4PS, no4PS)
                    End If
                End Using
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating 4PS chart: " & ex.Message)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub
    
    Private Sub UpdateIndigenousChartFromDatabase()
        Try
            modDBx.openConn("cflc_db")
            Dim query As String = "SELECT 
                                    SUM(CASE WHEN st.IndigineousSpecific IS NOT NULL AND st.IndigineousSpecific != '' THEN 1 ELSE 0 END) AS Indigenous,
                                    SUM(CASE WHEN st.IndigineousSpecific IS NULL OR st.IndigineousSpecific = '' THEN 1 ELSE 0 END) AS NotIndigenous
                                  FROM student st 
                                  INNER JOIN enrollment se ON st.StudentID = se.StudentID 
                                  INNER JOIN section s ON se.SectionID = s.SectionID 
                                  WHERE s.TeacherID = @teacher_id"
            
            Using cmd As New MySqlCommand(query, modDBx.conn)
                cmd.Parameters.AddWithValue("@teacher_id", TeacherID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim indigenous As Integer = If(IsDBNull(reader("Indigenous")), 0, Convert.ToInt32(reader("Indigenous")))
                        Dim notIndigenous As Integer = If(IsDBNull(reader("NotIndigenous")), 0, Convert.ToInt32(reader("NotIndigenous")))
                        UpdateIndigenousChart(indigenous, notIndigenous)
                    End If
                End Using
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating Indigenous chart: " & ex.Message)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub
    
    Private Sub UpdateGenderChartFromDatabase()
        Try
            modDBx.openConn("cflc_db")
            Dim query As String = "SELECT 
                                    SUM(CASE WHEN st.Gender = 'Male' THEN 1 ELSE 0 END) AS Male,
                                    SUM(CASE WHEN st.Gender = 'Female' THEN 1 ELSE 0 END) AS Female
                                  FROM student st 
                                  INNER JOIN enrollment se ON st.StudentID = se.StudentID 
                                  INNER JOIN section s ON se.SectionID = s.SectionID 
                                  WHERE s.TeacherID = @teacher_id"
            
            Using cmd As New MySqlCommand(query, modDBx.conn)
                cmd.Parameters.AddWithValue("@teacher_id", TeacherID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim maleCount As Integer = If(IsDBNull(reader("Male")), 0, Convert.ToInt32(reader("Male")))
                        Dim femaleCount As Integer = If(IsDBNull(reader("Female")), 0, Convert.ToInt32(reader("Female")))
                        UpdateGenderChart(maleCount, femaleCount)
                    End If
                End Using
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating Gender chart: " & ex.Message)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub
    
    ' Chart update methods
    Private Sub UpdateFourPSChart(with4PS As Integer, without4PS As Integer)
        Try
            Dim chartControl As Chart = PieChartTeacherStudent4psList
            If chartControl IsNot Nothing Then
                chartControl.Series.Clear()
                chartControl.ChartAreas.Clear()
                
                Dim chartArea As New ChartArea("FourPSChartArea")
                chartControl.ChartAreas.Add(chartArea)
                
                Dim series As New Series("FourPSSeries")
                series.ChartType = SeriesChartType.Pie
                series.IsValueShownAsLabel = True
                series.LabelFormat = "#,##0"
                series.LabelForeColor = Color.White
                series.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                
                ' Add legend
                chartControl.Legends.Clear()
                Dim legend As New Legend("FourPSLegend")
                legend.Docking = Docking.Bottom
                legend.ForeColor = Color.White
                legend.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                legend.BackColor = Color.Transparent
                chartControl.Legends.Add(legend)
                series.Legend = "FourPSLegend"
                
                ' Add data points
                If with4PS > 0 Then
                    Dim point1 As New DataPoint(0, with4PS)
                    point1.LegendText = "With 4PS"
                    point1.Color = Color.Green
                    point1.Label = "With 4PS: #VALY"
                    point1.LabelForeColor = Color.White
                    series.Points.Add(point1)
                End If
                
                If without4PS > 0 Then
                    Dim point2 As New DataPoint(0, without4PS)
                    point2.LegendText = "No 4PS"
                    point2.Color = Color.LightGreen
                    point2.Label = "No 4PS: #VALY"
                    point2.LabelForeColor = Color.White
                    series.Points.Add(point2)
                End If
                
                chartControl.Series.Add(series)
                chartControl.BackColor = Color.Transparent
                chartArea.BackColor = Color.Transparent
                chartControl.Visible = True
                chartControl.BringToFront()
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating 4PS chart: " & ex.Message)
        End Try
    End Sub
    
    Private Sub UpdateIndigenousChart(indigenous As Integer, notIndigenous As Integer)
        Try
            Dim chartControl As Chart = PieChartTeacherStudentIndigenous
            If chartControl IsNot Nothing Then
                chartControl.Series.Clear()
                chartControl.ChartAreas.Clear()
                
                Dim chartArea As New ChartArea("IndigenousChartArea")
                chartControl.ChartAreas.Add(chartArea)
                
                Dim series As New Series("IndigenousSeries")
                series.ChartType = SeriesChartType.Pie
                series.IsValueShownAsLabel = True
                series.LabelFormat = "#,##0"
                series.LabelForeColor = Color.White
                series.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                
                ' Add legend
                chartControl.Legends.Clear()
                Dim legend As New Legend("IndigenousLegend")
                legend.Docking = Docking.Bottom
                legend.ForeColor = Color.White
                legend.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                legend.BackColor = Color.Transparent
                chartControl.Legends.Add(legend)
                series.Legend = "IndigenousLegend"
                
                ' Add data points
                If indigenous > 0 Then
                    Dim point1 As New DataPoint(0, indigenous)
                    point1.LegendText = "Indigenous"
                    point1.Color = Color.Green
                    point1.Label = "Indigenous: #VALY"
                    point1.LabelForeColor = Color.White
                    series.Points.Add(point1)
                End If
                
                If notIndigenous > 0 Then
                    Dim point2 As New DataPoint(0, notIndigenous)
                    point2.LegendText = "Not Indigenous"
                    point2.Color = Color.LightGreen
                    point2.Label = "Not Indigenous: #VALY"
                    point2.LabelForeColor = Color.White
                    series.Points.Add(point2)
                End If
                
                chartControl.Series.Add(series)
                chartControl.BackColor = Color.Transparent
                chartArea.BackColor = Color.Transparent
                chartControl.Visible = True
                chartControl.BringToFront()
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating Indigenous chart: " & ex.Message)
        End Try
    End Sub
    
    Private Sub UpdateGenderChart(maleCount As Integer, femaleCount As Integer)
        Try
            Dim chartControl As Chart = PieChartTeacherStudentGenderList
            If chartControl IsNot Nothing Then
                chartControl.Series.Clear()
                chartControl.ChartAreas.Clear()
                
                Dim chartArea As New ChartArea("GenderChartArea")
                chartControl.ChartAreas.Add(chartArea)
                
                Dim series As New Series("GenderSeries")
                series.ChartType = SeriesChartType.Pie
                series.IsValueShownAsLabel = True
                series.LabelFormat = "#,##0"
                series.LabelForeColor = Color.White
                series.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                
                ' Add legend
                chartControl.Legends.Clear()
                Dim legend As New Legend("GenderLegend")
                legend.Docking = Docking.Bottom
                legend.ForeColor = Color.White
                legend.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                legend.BackColor = Color.Transparent
                chartControl.Legends.Add(legend)
                series.Legend = "GenderLegend"
                
                ' Add data points with Green for Male and LightGreen for Female
                If maleCount > 0 Then
                    Dim point1 As New DataPoint(0, maleCount)
                    point1.LegendText = "Male"
                    point1.Color = Color.Green
                    point1.Label = "Male: #VALY"
                    point1.LabelForeColor = Color.White
                    series.Points.Add(point1)
                End If
                
                If femaleCount > 0 Then
                    Dim point2 As New DataPoint(0, femaleCount)
                    point2.LegendText = "Female"
                    point2.Color = Color.LightGreen
                    point2.Label = "Female: #VALY"
                    point2.LabelForeColor = Color.White
                    series.Points.Add(point2)
                End If
                
                chartControl.Series.Add(series)
                chartControl.BackColor = Color.Transparent
                chartArea.BackColor = Color.Transparent
                chartControl.Visible = True
                chartControl.BringToFront()
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating Gender chart: " & ex.Message)
        End Try
    End Sub
End Class