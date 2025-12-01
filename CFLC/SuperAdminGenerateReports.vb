Imports System.Data
Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class SuperAdminGenerateReports

    Public Property IsEmbedded As Boolean = False

    Private conn As MySqlConnection
    Private db_name As String = "cflc_database" ' Database name
    Private isInitializing As Boolean = False
    Private currentTeacherID As String = "" ' Store the searched TeacherID

    ' Open database connection
    Private Function openConn() As Boolean
        Try
            ' Close existing connection if open
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            Dim configPath As String = Path.Combine(Application.StartupPath, "config.txt")
            Dim strConnection As String = ""

            ' Check if config.txt exists
            If Not File.Exists(configPath) Then
                MessageBox.Show("config.txt not found in application folder!" & vbCrLf & "Expected path: " & configPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            ' Read and parse config.txt (supports both line-by-line format and single connection string)
            Dim configText As String = File.ReadAllText(configPath).Trim()

            If String.IsNullOrWhiteSpace(configText) Then
                MessageBox.Show("Connection string in config.txt is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            ' Try to parse as line-by-line format (server=, uid=, password=, database=)
            If configText.Contains(vbCrLf) OrElse configText.Contains(vbLf) Then
                Dim arr_text() As String = configText.Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)
                If arr_text.Length >= 4 Then
                    Try
                        Dim server As String = arr_text(0).Split("="c)(1).Trim()
                        Dim uid As String = arr_text(1).Split("="c)(1).Trim()
                        Dim password As String = arr_text(2).Split("="c)(1).Trim()
                        Dim database As String = If(arr_text.Length > 3, arr_text(3).Split("="c)(1).Trim(), db_name)

                        strConnection = String.Format("server={0};uid={1};password={2};database={3};allowuservariables=True;Connection Timeout=30;",
                                                      server, uid, password, database)
                    Catch ex As Exception
                        MessageBox.Show("Error parsing config.txt line format: " & ex.Message & vbCrLf & vbCrLf &
                                       "Expected format:" & vbCrLf & "server=localhost" & vbCrLf & "uid=root" & vbCrLf & "password=yourpassword" & vbCrLf & "database=cflc_database",
                                       "Config Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End Try
                Else
                    MessageBox.Show("config.txt does not have enough lines. Expected 4 lines (server, uid, password, database)", "Config Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Else
                ' Treat as single connection string
                strConnection = configText

                ' Append database name if not already present (case-insensitive check)
                If Not strConnection.ToLower().Contains("database=") Then
                    If strConnection.EndsWith(";") Then
                        strConnection &= "database=" & db_name
                    Else
                        strConnection &= ";database=" & db_name
                    End If
                End If

                ' Add connection timeout if not present
                If Not strConnection.ToLower().Contains("connection timeout") Then
                    strConnection &= ";Connection Timeout=30;"
                End If
            End If

            ' Create and open connection with timeout
            conn = New MySqlConnection(strConnection)

            ' Set connection timeout (30 seconds)
            Try
                conn.Open()
            Catch ex As MySqlException
                Dim errorDetails As String = "MySQL Connection Error: " & ex.Message
                If ex.Number <> 0 Then
                    errorDetails &= vbCrLf & "Error Number: " & ex.Number
                End If
                errorDetails &= vbCrLf & vbCrLf & "Connection String (masked): " & MaskConnectionString(strConnection)
                errorDetails &= vbCrLf & vbCrLf & "Troubleshooting:" & vbCrLf &
                              "1. Verify MySQL server is running" & vbCrLf &
                              "2. Check server address in config.txt" & vbCrLf &
                              "3. Verify username and password are correct" & vbCrLf &
                              "4. Check firewall settings"
                MessageBox.Show(errorDetails, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try

            ' Verify connection is actually open
            If conn.State <> ConnectionState.Open Then
                MessageBox.Show("Connection opened but state is not Open. State: " & conn.State.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Return True

        Catch ex As MySqlException
            Dim errorMsg As String = "MySQL Connection Error: " & ex.Message
            If ex.Number <> 0 Then
                errorMsg &= vbCrLf & "Error Number: " & ex.Number
            End If
            MessageBox.Show(errorMsg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Catch ex As Exception
            MessageBox.Show("Connection Error: " & ex.Message & vbCrLf & "Type: " & ex.GetType().Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Helper function to mask sensitive information in connection string for display
    Private Function MaskConnectionString(connStr As String) As String
        Try
            Dim masked As String = connStr
            ' Mask password
            Dim pwdIndex As Integer = masked.ToLower().IndexOf("password=")
            If pwdIndex >= 0 Then
                Dim startPos As Integer = pwdIndex + 9
                Dim endPos As Integer = masked.IndexOf(";", startPos)
                If endPos < 0 Then endPos = masked.Length
                Dim pwdLength As Integer = endPos - startPos
                masked = masked.Substring(0, startPos) & New String("*"c, Math.Min(pwdLength, 10)) & masked.Substring(endPos)
            End If
            Return masked
        Catch
            Return "Unable to display connection string"
        End Try
    End Function

    ' Form Load event
    Private Sub SuperAdminGenerateReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show PictureBox (logo) when form loads
        PictureBox1.Visible = True
        ' Initialize without selecting (to prevent auto-loading students)
        isInitializing = True
        InitializeGradeComboBox()
        InitializeEnrollmentComboBox()
        InitializeSectionComboBox()
        InitializeEnrollmentYearComboBox()
        InitializeSubjectComboBox()
        ' Initialize year combo boxes for all sections
        InitializeStudentEnrollmentYearComboBox()
        InitializeEnrollmentSummaryYearComboBox()
        InitializeSubjectEnrollmentYearComboBox()
        ' Initialize Teacher Reports combo boxes
        InitializeTeacherGenderComboBox()
        InitializeTeacherSubjectLoadYearComboBox()
        ' Show all DGV by default
        dgvStudents.Visible = True
        dgvEnrollment.Visible = True
        dgvSections.Visible = True
        dgvSubjects.Visible = True
        dgvTeacherSectionStudents.Visible = True
        dgvTeacherSubjectLoad.Visible = True
        ' Hide Teacher Reports GroupBoxes initially (until TeacherID is searched)
        grpTeacherSectionStudents.Visible = False
        grpTeacherSubjectLoad.Visible = False
        isInitializing = False

        ' Style controls for better appearance
        StyleControls()

        ' Center the GroupBoxes after form is fully laid out
        AddHandler Me.Shown, AddressOf SuperAdminGenerateReports_Shown
        AddHandler Me.ResizeEnd, AddressOf SuperAdminGenerateReports_ResizeEnd
        AddHandler Me.VisibleChanged, AddressOf SuperAdminGenerateReports_VisibleChanged
    End Sub

    Private Sub SuperAdminGenerateReports_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Throttle resize events - only center after resize ends
        ' This prevents excessive calculations during resizing
    End Sub

    Private Sub SuperAdminGenerateReports_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Use BeginInvoke to ensure form is fully laid out
        ' Multiple invocations ensure it happens after layout is complete
        Me.BeginInvoke(New Action(AddressOf CenterGroupBoxes))
        Me.BeginInvoke(New Action(AddressOf CenterGroupBoxes))
    End Sub

    Private Sub SuperAdminGenerateReports_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            ' Center when form becomes visible (important for embedded forms)
            ' Use multiple BeginInvoke to ensure it happens after layout
            Me.BeginInvoke(New Action(AddressOf CenterGroupBoxes))
            Me.BeginInvoke(New Action(AddressOf CenterGroupBoxes))
        End If
    End Sub

    Private Sub SuperAdminGenerateReports_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        CenterGroupBoxes()
    End Sub

    Private Sub CenterGroupBoxes()
        If pnlMainContent Is Nothing Then Return

        ' Get the correct width based on whether form is embedded
        ' When embedded: form is docked in pnlSuperAdminMainContent (excludes 400px sidebar)
        ' When not embedded: form fills screen, pnlMainContent fills form
        Dim panelWidth As Integer
        Dim panelHeight As Integer
        
        If IsEmbedded Then
            ' When embedded, the form itself is the available area (already excludes sidebar)
            panelWidth = Me.ClientSize.Width
            panelHeight = Me.ClientSize.Height
        Else
            ' When not embedded, use panel size
            panelWidth = pnlMainContent.ClientSize.Width
            panelHeight = pnlMainContent.ClientSize.Height
        End If
        
        ' Ensure we have valid dimensions
        If panelWidth <= 0 Then panelWidth = Me.ClientSize.Width
        If panelHeight <= 0 Then panelHeight = Me.ClientSize.Height

        ' GroupBox dimensions - responsive to panel width with max width
        Dim maxGroupBoxWidth As Integer = 1200
        Dim minGroupBoxWidth As Integer = 800
        Dim groupBoxWidth As Integer = Math.Max(minGroupBoxWidth, Math.Min(maxGroupBoxWidth, panelWidth - 100))
        Dim groupBoxHeight As Integer = 150 ' Reduced from 200 to 150
        Dim spacing As Integer = 10 ' Reduced from 20 to 10

        ' Calculate horizontal center
        Dim centerX As Integer = Math.Max(50, (panelWidth - groupBoxWidth) \ 2)

        ' Calculate Teacher Reports height (expanded if teacher sections are visible)
        Dim teacherReportsHeight As Integer = groupBoxHeight
        If grpTeacherSectionStudents IsNot Nothing AndAlso grpTeacherSectionStudents.Visible Then
            ' Both sections are visible, need more height
            Dim sectionStudentsHeight As Integer = 150
            Dim sectionSpacing As Integer = 10
            Dim subjectLoadY As Integer = 70 + sectionStudentsHeight + sectionSpacing
            teacherReportsHeight = subjectLoadY + 150 + 20 ' 20 for bottom padding
        End If

        ' Calculate total height - we have 4 Admin GroupBoxes + 1 Teacher Reports container
        Dim totalHeight As Integer = (groupBoxHeight * 4) + (spacing * 3) + teacherReportsHeight + spacing

        ' If total height exceeds panel height, reduce spacing and height further
        If totalHeight > panelHeight - 40 Then
            ' Calculate optimal height and spacing to fit
            Dim availableHeight As Integer = panelHeight - 40
            ' Reserve space for Teacher Reports
            Dim adminSectionsHeight As Integer = availableHeight - teacherReportsHeight - spacing
            groupBoxHeight = Math.Max(120, (adminSectionsHeight - (spacing * 3)) \ 4)
            totalHeight = (groupBoxHeight * 4) + (spacing * 3) + teacherReportsHeight + spacing
        End If

        ' Calculate vertical start position (top-aligned with small margin)
        Dim startY As Integer = 20

        ' Position each GroupBox
        If grpStudents IsNot Nothing Then
            grpStudents.Size = New Size(groupBoxWidth, groupBoxHeight)
            grpStudents.Location = New Point(centerX, startY)
        End If

        If grpEnrollment IsNot Nothing Then
            grpEnrollment.Size = New Size(groupBoxWidth, groupBoxHeight)
            grpEnrollment.Location = New Point(centerX, startY + groupBoxHeight + spacing)
        End If

        If grpSections IsNot Nothing Then
            grpSections.Size = New Size(groupBoxWidth, groupBoxHeight)
            grpSections.Location = New Point(centerX, startY + (groupBoxHeight + spacing) * 2)
        End If

        If grpSubjects IsNot Nothing Then
            grpSubjects.Size = New Size(groupBoxWidth, groupBoxHeight)
            grpSubjects.Location = New Point(centerX, startY + (groupBoxHeight + spacing) * 3)
        End If

        If grpTeacherReports IsNot Nothing Then
            grpTeacherReports.Size = New Size(groupBoxWidth, teacherReportsHeight)
            grpTeacherReports.Location = New Point(centerX, startY + (groupBoxHeight + spacing) * 4)
        End If
    End Sub

    Private Sub StyleControls()
        ' Style all print buttons with hover effects
        Dim buttons() As Button = {btnSuperAdminGenerateStudents, btnSuperAdminGenerateEnrollmentSummary,
                                   btnSuperAdminGenerateSections, btnSuperAdminGenerateSubjects,
                                   btnSuperAdminGenerateTeacherStudents, btnSuperAdminGenerateTeacherSubjectLoad,
                                   btnSearchTeacher}

        For Each btn As Button In buttons
            If btn IsNot Nothing Then
                btn.FlatAppearance.BorderSize = 0
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 98, 104)
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87)
                btn.Cursor = Cursors.Hand
            End If
        Next

        ' Style combo boxes
        Dim comboBoxes() As ComboBox = {cmbGradeLevel, cmbStudentEnrollmentYear, cmbEnrollmentView,
                                        cmbEnrollmentSummaryYear, cmbSectionView, cmbEnrollmentYear,
                                        cmbSubjectView, cmbSubjectEnrollmentYear,
                                        cmbTeacherGender, cmbTeacherSubjectLoadYear}

        For Each cmb As ComboBox In comboBoxes
            If cmb IsNot Nothing Then
                cmb.FlatStyle = FlatStyle.Flat
                cmb.BackColor = Color.White
                cmb.ForeColor = Color.Black
            End If
        Next

        ' Style DataGridViews - more subtle colors
        Dim dataGrids() As DataGridView = {dgvStudents, dgvEnrollment, dgvSections, dgvSubjects,
                                           dgvTeacherSectionStudents, dgvTeacherSubjectLoad}

        For Each dgv As DataGridView In dataGrids
            If dgv IsNot Nothing Then
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 249, 249)
                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(108, 117, 125)
                dgv.DefaultCellStyle.SelectionForeColor = Color.White
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(108, 117, 125)
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                dgv.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                dgv.EnableHeadersVisualStyles = False
            End If
        Next
    End Sub

    Private Sub HideLogoWhenDataShown()
        ' Hide logo when any data is displayed
        If PictureBox1 IsNot Nothing Then
            PictureBox1.Visible = False
        End If
    End Sub

    ' Initialize Grade Level ComboBox
    Private Sub InitializeGradeComboBox()
        cmbGradeLevel.Items.Clear()
        cmbGradeLevel.Items.Add("All Students")
        For i As Integer = 1 To 6
            cmbGradeLevel.Items.Add("GRADE " & i)
        Next
    End Sub

    ' Initialize Enrollment View ComboBox
    Private Sub InitializeEnrollmentComboBox()
        cmbEnrollmentView.Items.Clear()
        cmbEnrollmentView.Items.Add("All Enrollments")
        For i As Integer = 1 To 6
            cmbEnrollmentView.Items.Add("GRADE " & i)
        Next
    End Sub

    ' Initialize Section View ComboBox
    Private Sub InitializeSectionComboBox()
        cmbSectionView.Items.Clear()
        cmbSectionView.Items.Add("All Sections")
        For i As Integer = 1 To 6
            cmbSectionView.Items.Add("GRADE " & i)
        Next
    End Sub

    ' Initialize Enrollment Year ComboBox (for Sections)
    Private Sub InitializeEnrollmentYearComboBox()
        PopulateYearComboBox(cmbEnrollmentYear)
    End Sub

    ' Initialize Student Enrollment Year ComboBox
    Private Sub InitializeStudentEnrollmentYearComboBox()
        PopulateYearComboBox(cmbStudentEnrollmentYear)
    End Sub

    ' Initialize Enrollment Summary Year ComboBox
    Private Sub InitializeEnrollmentSummaryYearComboBox()
        PopulateYearComboBox(cmbEnrollmentSummaryYear)
    End Sub

    ' Initialize Subject Enrollment Year ComboBox
    Private Sub InitializeSubjectEnrollmentYearComboBox()
        PopulateYearComboBox(cmbSubjectEnrollmentYear)
    End Sub

    ' Helper method to populate year combo box
    Private Sub PopulateYearComboBox(comboBox As ComboBox)
        Try
            comboBox.Items.Clear()
            comboBox.Items.Add("All Years")

            ' Open connection
            If Not openConn() Then
                Return
            End If

            ' Query distinct enrollment years from StartDate
            Dim sql As String = "SELECT DISTINCT YEAR(e.StartDate) AS EnrollmentYear " &
                                "FROM enrollment e " &
                                "WHERE e.StartDate IS NOT NULL " &
                                "ORDER BY EnrollmentYear DESC"

            Using cmd As New MySqlCommand(sql, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim year As Integer = reader.GetInt32("EnrollmentYear")
                        comboBox.Items.Add(year.ToString())
                    End While
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading enrollment years: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Initialize Subject View ComboBox
    Private Sub InitializeSubjectComboBox()
        cmbSubjectView.Items.Clear()
        cmbSubjectView.Items.Add("All Subjects")
        For i As Integer = 1 To 6
            cmbSubjectView.Items.Add("GRADE " & i)
        Next
    End Sub

    ' Initialize Teacher Gender ComboBox
    Private Sub InitializeTeacherGenderComboBox()
        cmbTeacherGender.Items.Clear()
        cmbTeacherGender.Items.Add("All")
        cmbTeacherGender.Items.Add("Male")
        cmbTeacherGender.Items.Add("Female")
    End Sub

    ' Initialize Teacher Subject Load Year ComboBox
    Private Sub InitializeTeacherSubjectLoadYearComboBox()
        PopulateYearComboBox(cmbTeacherSubjectLoadYear)
    End Sub

    ' ========== EVENT HANDLERS FOR ADMIN REPORTS ==========
    ' Enrollment ComboBox selection change event
    Private Sub cmbEnrollmentView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEnrollmentView.SelectedIndexChanged
        If Not isInitializing AndAlso cmbEnrollmentView.SelectedItem IsNot Nothing Then
            LoadEnrollmentSummary()
            dgvEnrollment.Visible = True
        End If
    End Sub

    ' ComboBox selection change event
    Private Sub cmbGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGradeLevel.SelectedIndexChanged
        If Not isInitializing AndAlso cmbGradeLevel.SelectedItem IsNot Nothing Then
            LoadStudentsByGrade()
            dgvStudents.Visible = True
        End If
    End Sub

    ' Section ComboBox selection change event
    Private Sub cmbSectionView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSectionView.SelectedIndexChanged
        If Not isInitializing AndAlso cmbSectionView.SelectedItem IsNot Nothing Then
            LoadSectionsByGrade()
            dgvSections.Visible = True
        End If
    End Sub

    ' Enrollment Year ComboBox selection change event (for Sections)
    Private Sub cmbEnrollmentYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEnrollmentYear.SelectedIndexChanged
        If Not isInitializing AndAlso cmbEnrollmentYear.SelectedItem IsNot Nothing Then
            LoadSectionsByGrade()
            dgvSections.Visible = True
        End If
    End Sub

    ' Student Enrollment Year ComboBox selection change event
    Private Sub cmbStudentEnrollmentYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudentEnrollmentYear.SelectedIndexChanged
        If Not isInitializing AndAlso cmbStudentEnrollmentYear.SelectedItem IsNot Nothing Then
            LoadStudentsByGrade()
            dgvStudents.Visible = True
        End If
    End Sub

    ' Enrollment Summary Year ComboBox selection change event
    Private Sub cmbEnrollmentSummaryYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEnrollmentSummaryYear.SelectedIndexChanged
        If Not isInitializing AndAlso cmbEnrollmentSummaryYear.SelectedItem IsNot Nothing Then
            LoadEnrollmentSummary()
            dgvEnrollment.Visible = True
        End If
    End Sub

    ' Subject Enrollment Year ComboBox selection change event
    Private Sub cmbSubjectEnrollmentYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubjectEnrollmentYear.SelectedIndexChanged
        If Not isInitializing AndAlso cmbSubjectEnrollmentYear.SelectedItem IsNot Nothing Then
            LoadSubjectsByGrade()
            dgvSubjects.Visible = True
        End If
    End Sub

    ' Subject ComboBox selection change event
    Private Sub cmbSubjectView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubjectView.SelectedIndexChanged
        If Not isInitializing AndAlso cmbSubjectView.SelectedItem IsNot Nothing Then
            LoadSubjectsByGrade()
            dgvSubjects.Visible = True
        End If
    End Sub

    ' ========== LOAD METHODS FOR ADMIN REPORTS ==========
    ' Load enrollment summary into DataGridView
    Private Sub LoadEnrollmentSummary()
        Try
            If cmbEnrollmentView.SelectedItem Is Nothing Then
                Return
            End If

            Dim selectedOption As String = cmbEnrollmentView.SelectedItem.ToString()
            Dim selectedYear As String = Nothing
            If cmbEnrollmentSummaryYear.SelectedItem IsNot Nothing Then
                selectedYear = cmbEnrollmentSummaryYear.SelectedItem.ToString()
            End If

            If Not openConn() Then
                MessageBox.Show("Cannot connect to database. Please check your config.txt file and database settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim dt As New DataTable()
            Dim yearFilter As String = ""
            If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                yearFilter = "AND YEAR(e.StartDate) = @EnrollmentYear "
            End If

            If selectedOption = "All Enrollments" Then
                Dim sql As String = "SELECT CONCAT('GRADE ', e.GradeLevel) AS GradeLevel, COUNT(DISTINCT e.StudentID) AS StudentCount " &
                                    "FROM enrollment e " &
                                    "WHERE (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL) " &
                                    If(selectedYear IsNot Nothing AndAlso selectedYear <> "All Years", yearFilter, "") &
                                    "GROUP BY e.GradeLevel " &
                                    "ORDER BY e.GradeLevel"

                Using cmd As New MySqlCommand(sql, conn)
                    If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                        cmd.Parameters.AddWithValue("@EnrollmentYear", Integer.Parse(selectedYear))
                    End If
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using

                Dim totalRow As DataRow = dt.NewRow()
                Dim totalCount As Integer = 0
                For Each row As DataRow In dt.Rows
                    totalCount += Convert.ToInt32(row("StudentCount"))
                Next
                totalRow("GradeLevel") = "TOTAL"
                totalRow("StudentCount") = totalCount
                dt.Rows.Add(totalRow)
            Else
                Dim gradeNumber As Integer = Integer.Parse(selectedOption.Replace("GRADE ", ""))
                Dim sql As String = "SELECT CONCAT('GRADE ', e.GradeLevel) AS GradeLevel, COUNT(DISTINCT e.StudentID) AS StudentCount " &
                                    "FROM enrollment e " &
                                    "WHERE (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL) " &
                                    "AND e.GradeLevel = @GradeLevel " &
                                    If(selectedYear IsNot Nothing AndAlso selectedYear <> "All Years", yearFilter, "") &
                                    "GROUP BY e.GradeLevel " &
                                    "ORDER BY e.GradeLevel"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@GradeLevel", gradeNumber)
                    If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                        cmd.Parameters.AddWithValue("@EnrollmentYear", Integer.Parse(selectedYear))
                    End If
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End If

            dt.Columns("GradeLevel").ColumnName = "Grade Level"
            dt.Columns("StudentCount").ColumnName = "Number of Students"

            dgvEnrollment.DataSource = dt
            dgvEnrollment.Refresh()
            HideLogoWhenDataShown()
            dgvEnrollment.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error loading enrollment summary: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Load students filtered by grade level into DataGridView
    Private Sub LoadStudentsByGrade()
        Try
            If cmbGradeLevel.SelectedItem Is Nothing Then
                Return
            End If

            Dim selectedOption As String = cmbGradeLevel.SelectedItem.ToString()
            Dim selectedYear As String = Nothing
            If cmbStudentEnrollmentYear.SelectedItem IsNot Nothing Then
                selectedYear = cmbStudentEnrollmentYear.SelectedItem.ToString()
            End If

            If Not openConn() Then
                MessageBox.Show("Cannot connect to database. Please check your config.txt file and database settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim dt As New DataTable()
            Dim yearFilter As String = ""
            If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                yearFilter = "AND YEAR(e.StartDate) = @EnrollmentYear "
            End If

            If selectedOption = "All Students" Then
                Dim sql As String = "SELECT DISTINCT s.StudentID, s.FirstName, s.LastName, s.Gender " &
                                    "FROM student s " &
                                    "INNER JOIN enrollment e ON s.StudentID = e.StudentID " &
                                    "WHERE (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL) " &
                                    If(selectedYear IsNot Nothing AndAlso selectedYear <> "All Years", yearFilter, "") &
                                    "ORDER BY s.LastName, s.FirstName"

                Using cmd As New MySqlCommand(sql, conn)
                    If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                        cmd.Parameters.AddWithValue("@EnrollmentYear", Integer.Parse(selectedYear))
                    End If
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            Else
                Dim gradeNumber As Integer = Integer.Parse(selectedOption.Replace("GRADE ", ""))
                Dim sql As String = "SELECT DISTINCT s.StudentID, s.FirstName, s.LastName, s.Gender " &
                                    "FROM student s " &
                                    "INNER JOIN enrollment e ON s.StudentID = e.StudentID " &
                                    "WHERE e.GradeLevel = @GradeLevel " &
                                    "AND (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL) " &
                                    If(selectedYear IsNot Nothing AndAlso selectedYear <> "All Years", yearFilter, "") &
                                    "ORDER BY s.LastName, s.FirstName"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@GradeLevel", gradeNumber)
                    If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                        cmd.Parameters.AddWithValue("@EnrollmentYear", Integer.Parse(selectedYear))
                    End If
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End If

            dgvStudents.DataSource = dt
            dgvStudents.Refresh()
            HideLogoWhenDataShown()
            dgvStudents.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Load sections filtered by grade level into DataGridView
    Private Sub LoadSectionsByGrade()
        Try
            If cmbSectionView.SelectedItem Is Nothing Then
                Return
            End If

            Dim selectedOption As String = cmbSectionView.SelectedItem.ToString()
            Dim selectedYear As String = Nothing
            If cmbEnrollmentYear.SelectedItem IsNot Nothing Then
                selectedYear = cmbEnrollmentYear.SelectedItem.ToString()
            End If

            If Not openConn() Then
                MessageBox.Show("Cannot connect to database. Please check your config.txt file and database settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim dt As New DataTable()
            Dim yearFilter As String = ""
            If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                yearFilter = "AND YEAR(e.StartDate) = @EnrollmentYear "
            End If

            If selectedOption = "All Sections" Then
                Dim sql As String = "SELECT s.SectionID, s.SectionName, s.GradeLevel, " &
                                    "COUNT(DISTINCT e.StudentID) AS StudentCount " &
                                    "FROM section s " &
                                    "LEFT JOIN enrollment e ON s.SectionID = e.SectionID " &
                                    "AND (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL) " &
                                    If(selectedYear IsNot Nothing AndAlso selectedYear <> "All Years", yearFilter, "") &
                                    "GROUP BY s.SectionID, s.SectionName, s.GradeLevel " &
                                    "ORDER BY s.GradeLevel, s.SectionName"

                Using cmd As New MySqlCommand(sql, conn)
                    If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                        cmd.Parameters.AddWithValue("@EnrollmentYear", Integer.Parse(selectedYear))
                    End If
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            Else
                Dim gradeNumber As Integer = Integer.Parse(selectedOption.Replace("GRADE ", ""))
                Dim sql As String = "SELECT s.SectionID, s.SectionName, s.GradeLevel, " &
                                    "COUNT(DISTINCT e.StudentID) AS StudentCount " &
                                    "FROM section s " &
                                    "LEFT JOIN enrollment e ON s.SectionID = e.SectionID " &
                                    "AND (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL) " &
                                    "WHERE s.GradeLevel = @GradeLevel " &
                                    If(selectedYear IsNot Nothing AndAlso selectedYear <> "All Years", yearFilter, "") &
                                    "GROUP BY s.SectionID, s.SectionName, s.GradeLevel " &
                                    "ORDER BY s.SectionName"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@GradeLevel", gradeNumber)
                    If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                        cmd.Parameters.AddWithValue("@EnrollmentYear", Integer.Parse(selectedYear))
                    End If
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End If

            dt.Columns("SectionID").ColumnName = "Section ID"
            dt.Columns("SectionName").ColumnName = "Section Name"
            dt.Columns("GradeLevel").ColumnName = "Grade Level"
            dt.Columns("StudentCount").ColumnName = "Number of Students"

            dgvSections.DataSource = dt
            dgvSections.Refresh()
            HideLogoWhenDataShown()
            dgvSections.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error loading sections: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Load subjects filtered by grade level into DataGridView
    Private Sub LoadSubjectsByGrade()
        Try
            If cmbSubjectView.SelectedItem Is Nothing Then
                Return
            End If

            Dim selectedOption As String = cmbSubjectView.SelectedItem.ToString()

            If Not openConn() Then
                MessageBox.Show("Cannot connect to database. Please check your config.txt file and database settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim dt As New DataTable()

            If selectedOption = "All Subjects" Then
                Dim sql As String = "SELECT SubjectID, SubjectCode, SubjectName, Category, GradeLevel, Status " &
                                    "FROM subject " &
                                    "ORDER BY GradeLevel, SubjectName"

                Using cmd As New MySqlCommand(sql, conn)
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            Else
                Dim gradeNumber As Integer = Integer.Parse(selectedOption.Replace("GRADE ", ""))
                Dim sql As String = "SELECT SubjectID, SubjectCode, SubjectName, Category, GradeLevel, Status " &
                                    "FROM subject " &
                                    "WHERE GradeLevel = @GradeLevel " &
                                    "ORDER BY SubjectName"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@GradeLevel", gradeNumber)
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End If

            If dt.Columns.Contains("SubjectID") Then dt.Columns("SubjectID").ColumnName = "Subject ID"
            If dt.Columns.Contains("SubjectCode") Then dt.Columns("SubjectCode").ColumnName = "Subject Code"
            If dt.Columns.Contains("SubjectName") Then dt.Columns("SubjectName").ColumnName = "Subject Name"
            If dt.Columns.Contains("GradeLevel") Then dt.Columns("GradeLevel").ColumnName = "Grade Level"

            dgvSubjects.DataSource = dt
            dgvSubjects.Refresh()
            HideLogoWhenDataShown()
            dgvSubjects.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error loading subjects: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' ========== BUTTON CLICK HANDLERS FOR ADMIN REPORTS ==========
    ' Button click to generate Student PDF
    Private Sub btnSuperAdminGenerateStudents_Click(sender As Object, e As EventArgs) Handles btnSuperAdminGenerateStudents.Click
        If cmbGradeLevel.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a grade level or 'All Students' from the dropdown.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        LoadStudentsByGrade()
        dgvStudents.Visible = True
        GenerateStudentReport()
    End Sub

    ' Button click to generate Enrollment Summary PDF
    Private Sub btnSuperAdminGenerateEnrollmentSummary_Click(sender As Object, e As EventArgs) Handles btnSuperAdminGenerateEnrollmentSummary.Click
        If cmbEnrollmentView.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a grade level or 'All Enrollments' from the dropdown.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        LoadEnrollmentSummary()
        dgvEnrollment.Visible = True
        GenerateEnrollmentSummaryReport()
    End Sub

    ' Button click to generate Section PDF
    Private Sub btnSuperAdminGenerateSections_Click(sender As Object, e As EventArgs) Handles btnSuperAdminGenerateSections.Click
        If cmbSectionView.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a grade level or 'All Sections' from the dropdown.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        LoadSectionsByGrade()
        dgvSections.Visible = True
        GenerateSectionReport()
    End Sub

    ' Button click to generate Subject PDF
    Private Sub btnSuperAdminGenerateSubjects_Click(sender As Object, e As EventArgs) Handles btnSuperAdminGenerateSubjects.Click
        If cmbSubjectView.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a grade level or 'All Subjects' from the dropdown.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        LoadSubjectsByGrade()
        dgvSubjects.Visible = True
        GenerateSubjectReport()
    End Sub

    ' ========== PDF GENERATION METHODS FOR ADMIN REPORTS ==========
    ' Generate student report
    Private Sub GenerateStudentReport()
        Try
            If cmbGradeLevel.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a grade level or 'All Students'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim selectedOption As String = cmbGradeLevel.SelectedItem.ToString()
            Dim selectedGrade As String = selectedOption
            Dim selectedYear As String = Nothing
            If cmbStudentEnrollmentYear.SelectedItem IsNot Nothing Then
                selectedYear = cmbStudentEnrollmentYear.SelectedItem.ToString()
            End If

            Dim dt As DataTable = DirectCast(dgvStudents.DataSource, DataTable)

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                If Not openConn() Then
                    MessageBox.Show("Cannot connect to database. Please check your config.txt file and database settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim yearFilter As String = ""
                If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                    yearFilter = "AND YEAR(e.StartDate) = @EnrollmentYear "
                End If

                If selectedOption = "All Students" Then
                    Dim sql As String = "SELECT DISTINCT s.StudentID, s.FirstName, s.LastName, s.Gender " &
                                        "FROM student s " &
                                        "INNER JOIN enrollment e ON s.StudentID = e.StudentID " &
                                        "WHERE (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL) " &
                                        If(selectedYear IsNot Nothing AndAlso selectedYear <> "All Years", yearFilter, "") &
                                        "ORDER BY s.LastName, s.FirstName"

                    dt = New DataTable()
                    Using cmd As New MySqlCommand(sql, conn)
                        If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                            cmd.Parameters.AddWithValue("@EnrollmentYear", Integer.Parse(selectedYear))
                        End If
                        Using da As New MySqlDataAdapter(cmd)
                            da.Fill(dt)
                        End Using
                    End Using
                Else
                    Dim gradeNumber As Integer = Integer.Parse(selectedOption.Replace("GRADE ", ""))
                    Dim sql As String = "SELECT DISTINCT s.StudentID, s.FirstName, s.LastName, s.Gender " &
                                        "FROM student s " &
                                        "INNER JOIN enrollment e ON s.StudentID = e.StudentID " &
                                        "WHERE e.GradeLevel = @GradeLevel " &
                                        "AND (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL) " &
                                        If(selectedYear IsNot Nothing AndAlso selectedYear <> "All Years", yearFilter, "") &
                                        "ORDER BY s.LastName, s.FirstName"

                    dt = New DataTable()
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@GradeLevel", gradeNumber)
                        If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                            cmd.Parameters.AddWithValue("@EnrollmentYear", Integer.Parse(selectedYear))
                        End If
                        Using da As New MySqlDataAdapter(cmd)
                            da.Fill(dt)
                        End Using
                    End Using
                End If
            End If

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                MessageBox.Show("No student data found for " & selectedGrade & ".", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim fileName As String = "StudentReport_" & selectedOption.Replace(" ", "_") & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"
            Dim savePath As String = Path.Combine(desktopPath, fileName)
            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
            PdfWriter.GetInstance(doc, New FileStream(savePath, FileMode.Create))
            doc.Open()

            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
            Dim titleText As String = If(selectedOption = "All Students", "Student Master List Report - All Students", "Student Master List Report - " & selectedGrade)
            If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                titleText &= " (" & selectedYear & ")"
            End If
            Dim title As New Paragraph(titleText, titleFont) With {.Alignment = Element.ALIGN_CENTER}
            doc.Add(title)
            doc.Add(New Paragraph("Generated on: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))
            doc.Add(New Paragraph(" "))

            Dim table As New PdfPTable(dt.Columns.Count) With {.WidthPercentage = 100}
            table.SetWidths(New Single() {15, 30, 30, 25})

            For Each col As DataColumn In dt.Columns
                Dim cell As New PdfPCell(New Phrase(col.ColumnName, New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))) With {
                    .BackgroundColor = BaseColor.LIGHT_GRAY,
                    .HorizontalAlignment = Element.ALIGN_CENTER
                }
                table.AddCell(cell)
            Next

            For Each row As DataRow In dt.Rows
                For Each col As DataColumn In dt.Columns
                    Dim cell As New PdfPCell(New Phrase(row(col).ToString(), New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10))) With {
                        .HorizontalAlignment = Element.ALIGN_CENTER
                    }
                    table.AddCell(cell)
                Next
            Next

            doc.Add(table)
            doc.Close()

            Dim reportTitle As String = If(selectedOption = "All Students", "All Students", selectedGrade)
            MessageBox.Show(reportTitle & " report generated successfully!" & vbCrLf & "Total students: " & dt.Rows.Count & vbCrLf & savePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Generate Enrollment Summary Report
    Private Sub GenerateEnrollmentSummaryReport()
        Try
            If cmbEnrollmentView.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a grade level or 'All Enrollments'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim selectedOption As String = cmbEnrollmentView.SelectedItem.ToString()
            Dim selectedYear As String = Nothing
            If cmbEnrollmentSummaryYear.SelectedItem IsNot Nothing Then
                selectedYear = cmbEnrollmentSummaryYear.SelectedItem.ToString()
            End If

            Dim dt As DataTable = DirectCast(dgvEnrollment.DataSource, DataTable)

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                If Not openConn() Then
                    MessageBox.Show("Cannot connect to database. Please check your config.txt file and database settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim yearFilter As String = ""
                If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                    yearFilter = "AND YEAR(e.StartDate) = @EnrollmentYear "
                End If

                If selectedOption = "All Enrollments" Then
                    Dim sql As String = "SELECT e.GradeLevel, COUNT(DISTINCT e.StudentID) AS StudentCount " &
                                        "FROM enrollment e " &
                                        "WHERE (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL) " &
                                        If(selectedYear IsNot Nothing AndAlso selectedYear <> "All Years", yearFilter, "") &
                                        "GROUP BY e.GradeLevel " &
                                        "ORDER BY e.GradeLevel"

                    dt = New DataTable()
                    Using cmd As New MySqlCommand(sql, conn)
                        If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                            cmd.Parameters.AddWithValue("@EnrollmentYear", Integer.Parse(selectedYear))
                        End If
                        Using da As New MySqlDataAdapter(cmd)
                            da.Fill(dt)
                        End Using
                    End Using
                Else
                    Dim gradeNumber As Integer = Integer.Parse(selectedOption.Replace("GRADE ", ""))
                    Dim sql As String = "SELECT e.GradeLevel, COUNT(DISTINCT e.StudentID) AS StudentCount " &
                                        "FROM enrollment e " &
                                        "WHERE (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL) " &
                                        "AND e.GradeLevel = @GradeLevel " &
                                        If(selectedYear IsNot Nothing AndAlso selectedYear <> "All Years", yearFilter, "") &
                                        "GROUP BY e.GradeLevel " &
                                        "ORDER BY e.GradeLevel"

                    dt = New DataTable()
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@GradeLevel", gradeNumber)
                        If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                            cmd.Parameters.AddWithValue("@EnrollmentYear", Integer.Parse(selectedYear))
                        End If
                        Using da As New MySqlDataAdapter(cmd)
                            da.Fill(dt)
                        End Using
                    End Using
                End If
            End If

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                Dim errorMsg As String = If(selectedOption = "All Enrollments", "No enrollment data found.", "No enrollment data found for " & selectedOption & ".")
                MessageBox.Show(errorMsg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim pdfDt As New DataTable()
            pdfDt.Columns.Add("GradeLevel", GetType(String))
            pdfDt.Columns.Add("StudentCount", GetType(Integer))

            Dim totalStudents As Integer = 0
            For Each row As DataRow In dt.Rows
                If row("Grade Level").ToString().ToUpper() = "TOTAL" Then
                    totalStudents = Convert.ToInt32(row("Number of Students"))
                    Continue For
                End If

                Dim newRow As DataRow = pdfDt.NewRow()
                newRow("GradeLevel") = row("Grade Level").ToString()
                newRow("StudentCount") = Convert.ToInt32(row("Number of Students"))
                totalStudents += Convert.ToInt32(row("Number of Students"))
                pdfDt.Rows.Add(newRow)
            Next

            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim fileName As String = "EnrollmentSummaryReport_" & selectedOption.Replace(" ", "_") & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"
            Dim savePath As String = Path.Combine(desktopPath, fileName)
            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
            PdfWriter.GetInstance(doc, New FileStream(savePath, FileMode.Create))
            doc.Open()

            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
            Dim titleText As String = If(selectedOption = "All Enrollments", "Enrollment Summary Report - All Enrollments", "Enrollment Summary Report - " & selectedOption)
            If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                titleText &= " (" & selectedYear & ")"
            End If
            Dim title As New Paragraph(titleText, titleFont) With {.Alignment = Element.ALIGN_CENTER}
            doc.Add(title)
            Dim descriptionText As String = If(selectedOption = "All Enrollments", "Summarizes the number of students enrolled per grade level", "Summarizes the number of students enrolled for " & selectedOption)
            If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                descriptionText &= " for enrollment year " & selectedYear
            End If
            doc.Add(New Paragraph(descriptionText))
            doc.Add(New Paragraph("Generated on: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))
            doc.Add(New Paragraph(" "))

            Dim table As New PdfPTable(2) With {.WidthPercentage = 100}
            table.SetWidths(New Single() {50, 50})

            Dim headerFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)
            Dim gradeHeader As New PdfPCell(New Phrase("Grade Level", headerFont)) With {
                .BackgroundColor = BaseColor.LIGHT_GRAY,
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .Padding = 10
            }
            table.AddCell(gradeHeader)

            Dim countHeader As New PdfPCell(New Phrase("Number of Students", headerFont)) With {
                .BackgroundColor = BaseColor.LIGHT_GRAY,
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .Padding = 10
            }
            table.AddCell(countHeader)

            Dim dataFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10)

            For Each row As DataRow In pdfDt.Rows
                Dim gradeLevel As String = row("GradeLevel").ToString()
                Dim studentCount As Integer = Convert.ToInt32(row("StudentCount"))

                Dim gradeCell As New PdfPCell(New Phrase(gradeLevel, dataFont)) With {
                    .HorizontalAlignment = Element.ALIGN_CENTER,
                    .Padding = 8
                }
                table.AddCell(gradeCell)

                Dim countCell As New PdfPCell(New Phrase(studentCount.ToString(), dataFont)) With {
                    .HorizontalAlignment = Element.ALIGN_CENTER,
                    .Padding = 8
                }
                table.AddCell(countCell)
            Next

            Dim totalGradeCell As New PdfPCell(New Phrase("TOTAL", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {
                .BackgroundColor = BaseColor.LIGHT_GRAY,
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .Padding = 8
            }
            table.AddCell(totalGradeCell)

            Dim totalCountCell As New PdfPCell(New Phrase(totalStudents.ToString(), New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {
                .BackgroundColor = BaseColor.LIGHT_GRAY,
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .Padding = 8
            }
            table.AddCell(totalCountCell)

            doc.Add(table)
            doc.Close()

            Dim reportTitle As String = If(selectedOption = "All Enrollments", "All Enrollments", selectedOption)
            MessageBox.Show(reportTitle & " Enrollment Summary Report generated successfully!" & vbCrLf & "Total students enrolled: " & totalStudents & vbCrLf & savePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating enrollment summary report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Generate Section Report
    Private Sub GenerateSectionReport()
        Try
            If cmbSectionView.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a grade level or 'All Sections'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim selectedOption As String = cmbSectionView.SelectedItem.ToString()
            Dim selectedYear As String = Nothing
            If cmbEnrollmentYear.SelectedItem IsNot Nothing Then
                selectedYear = cmbEnrollmentYear.SelectedItem.ToString()
            End If

            Dim dt As DataTable = DirectCast(dgvSections.DataSource, DataTable)

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                If Not openConn() Then
                    MessageBox.Show("Cannot connect to database. Please check your config.txt file and database settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim yearFilter As String = ""
                If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                    yearFilter = "AND YEAR(e.StartDate) = @EnrollmentYear "
                End If

                If selectedOption = "All Sections" Then
                    Dim sql As String = "SELECT s.SectionID, s.SectionName, s.GradeLevel, " &
                                    "COUNT(DISTINCT e.StudentID) AS StudentCount " &
                                    "FROM section s " &
                                    "LEFT JOIN enrollment e ON s.SectionID = e.SectionID " &
                                    "AND (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL) " &
                                    If(selectedYear IsNot Nothing AndAlso selectedYear <> "All Years", yearFilter, "") &
                                    "GROUP BY s.SectionID, s.SectionName, s.GradeLevel " &
                                    "ORDER BY s.GradeLevel, s.SectionName"

                    dt = New DataTable()
                    Using cmd As New MySqlCommand(sql, conn)
                        If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                            cmd.Parameters.AddWithValue("@EnrollmentYear", Integer.Parse(selectedYear))
                        End If
                        Using da As New MySqlDataAdapter(cmd)
                            da.Fill(dt)
                        End Using
                    End Using
                Else
                    Dim gradeNumber As Integer = Integer.Parse(selectedOption.Replace("GRADE ", ""))
                    Dim sql As String = "SELECT s.SectionID, s.SectionName, s.GradeLevel, " &
                                    "COUNT(DISTINCT e.StudentID) AS StudentCount " &
                                    "FROM section s " &
                                    "LEFT JOIN enrollment e ON s.SectionID = e.SectionID " &
                                    "AND (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL) " &
                                    "WHERE s.GradeLevel = @GradeLevel " &
                                    If(selectedYear IsNot Nothing AndAlso selectedYear <> "All Years", yearFilter, "") &
                                    "GROUP BY s.SectionID, s.SectionName, s.GradeLevel " &
                                    "ORDER BY s.SectionName"

                    dt = New DataTable()
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@GradeLevel", gradeNumber)
                        If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                            cmd.Parameters.AddWithValue("@EnrollmentYear", Integer.Parse(selectedYear))
                        End If
                        Using da As New MySqlDataAdapter(cmd)
                            da.Fill(dt)
                        End Using
                    End Using
                End If
            End If

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                Dim errorMsg As String = If(selectedOption = "All Sections", "No section data found.", "No section data found for " & selectedOption & ".")
                MessageBox.Show(errorMsg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim fileName As String = "SectionReport_" & selectedOption.Replace(" ", "_") & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"
            Dim savePath As String = Path.Combine(desktopPath, fileName)
            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
            PdfWriter.GetInstance(doc, New FileStream(savePath, FileMode.Create))
            doc.Open()

            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
            Dim titleText As String = If(selectedOption = "All Sections", "Section Report - All Sections", "Section Report - " & selectedOption)
            If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                titleText &= " (" & selectedYear & ")"
            End If
            Dim title As New Paragraph(titleText, titleFont) With {.Alignment = Element.ALIGN_CENTER}
            doc.Add(title)
            Dim descriptionText As String = "Presents the total number of students per section"
            If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                descriptionText &= " for enrollment year " & selectedYear
            End If
            doc.Add(New Paragraph(descriptionText))
            doc.Add(New Paragraph("Generated on: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))
            doc.Add(New Paragraph(" "))

            Dim table As New PdfPTable(4) With {.WidthPercentage = 100}
            table.SetWidths(New Single() {15, 40, 20, 25})

            Dim headerFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)
            Dim headers() As String = {"Section ID", "Section Name", "Grade Level", "Number of Students"}

            For Each header As String In headers
                Dim headerCell As New PdfPCell(New Phrase(header, headerFont)) With {
                    .BackgroundColor = BaseColor.LIGHT_GRAY,
                    .HorizontalAlignment = Element.ALIGN_CENTER,
                    .Padding = 10
                }
                table.AddCell(headerCell)
            Next

            Dim dataFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10)
            Dim totalStudents As Integer = 0

            For Each row As DataRow In dt.Rows
                Dim sectionID As String = row("Section ID").ToString()
                Dim sectionName As String = row("Section Name").ToString()
                Dim gradeLevel As String = "GRADE " & row("Grade Level").ToString()
                Dim studentCount As Integer = Convert.ToInt32(row("Number of Students"))
                totalStudents += studentCount

                Dim cells() As String = {sectionID, sectionName, gradeLevel, studentCount.ToString()}
                For Each cellText As String In cells
                    Dim cell As New PdfPCell(New Phrase(cellText, dataFont)) With {
                        .HorizontalAlignment = Element.ALIGN_CENTER,
                        .Padding = 8
                    }
                    table.AddCell(cell)
                Next
            Next

            Dim totalCells() As String = {"TOTAL", "", "", totalStudents.ToString()}
            For Each cellText As String In totalCells
                Dim cell As New PdfPCell(New Phrase(cellText, New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {
                    .BackgroundColor = BaseColor.LIGHT_GRAY,
                    .HorizontalAlignment = Element.ALIGN_CENTER,
                    .Padding = 8
                }
                table.AddCell(cell)
            Next

            doc.Add(table)
            doc.Close()

            Dim reportTitle As String = If(selectedOption = "All Sections", "All Sections", selectedOption)
            MessageBox.Show(reportTitle & " Section Report generated successfully!" & vbCrLf & "Total students: " & totalStudents & vbCrLf & savePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating section report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Generate Subject Report
    Private Sub GenerateSubjectReport()
        Try
            If cmbSubjectView.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a grade level or 'All Subjects'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim selectedOption As String = cmbSubjectView.SelectedItem.ToString()
            Dim dt As DataTable = DirectCast(dgvSubjects.DataSource, DataTable)

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                If Not openConn() Then
                    MessageBox.Show("Cannot connect to database. Please check your config.txt file and database settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                If selectedOption = "All Subjects" Then
                    Dim sql As String = "SELECT SubjectID, SubjectCode, SubjectName, Category, GradeLevel, Status " &
                                        "FROM subject " &
                                        "ORDER BY GradeLevel, SubjectName"

                    dt = New DataTable()
                    Using cmd As New MySqlCommand(sql, conn)
                        Using da As New MySqlDataAdapter(cmd)
                            da.Fill(dt)
                        End Using
                    End Using
                Else
                    Dim gradeNumber As Integer = Integer.Parse(selectedOption.Replace("GRADE ", ""))
                    Dim sql As String = "SELECT SubjectID, SubjectCode, SubjectName, Category, GradeLevel, Status " &
                                        "FROM subject " &
                                        "WHERE GradeLevel = @GradeLevel " &
                                        "ORDER BY SubjectName"

                    dt = New DataTable()
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@GradeLevel", gradeNumber)
                        Using da As New MySqlDataAdapter(cmd)
                            da.Fill(dt)
                        End Using
                    End Using
                End If
            End If

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                Dim errorMsg As String = If(selectedOption = "All Subjects", "No subject data found.", "No subject data found for " & selectedOption & ".")
                MessageBox.Show(errorMsg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If dt.Columns.Contains("SubjectID") Then dt.Columns("SubjectID").ColumnName = "Subject ID"
            If dt.Columns.Contains("SubjectCode") Then dt.Columns("SubjectCode").ColumnName = "Subject Code"
            If dt.Columns.Contains("SubjectName") Then dt.Columns("SubjectName").ColumnName = "Subject Name"
            If dt.Columns.Contains("GradeLevel") Then dt.Columns("GradeLevel").ColumnName = "Grade Level"

            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim fileName As String = "SubjectReport_" & selectedOption.Replace(" ", "_") & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"
            Dim savePath As String = Path.Combine(desktopPath, fileName)
            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
            PdfWriter.GetInstance(doc, New FileStream(savePath, FileMode.Create))
            doc.Open()

            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
            Dim titleText As String = If(selectedOption = "All Subjects", "Subject Report - All Subjects", "Subject Report - " & selectedOption)
            Dim title As New Paragraph(titleText, titleFont) With {.Alignment = Element.ALIGN_CENTER}
            doc.Add(title)
            Dim descriptionText As String = "Presents the list of subjects"
            doc.Add(New Paragraph(descriptionText))
            doc.Add(New Paragraph("Generated on: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))
            doc.Add(New Paragraph(" "))

            Dim table As New PdfPTable(6) With {.WidthPercentage = 100}
            table.SetWidths(New Single() {10, 15, 30, 15, 15, 15})

            Dim headerFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)
            Dim headers() As String = {"Subject ID", "Subject Code", "Subject Name", "Category", "Grade Level", "Status"}

            For Each header As String In headers
                Dim headerCell As New PdfPCell(New Phrase(header, headerFont)) With {
                    .BackgroundColor = BaseColor.LIGHT_GRAY,
                    .HorizontalAlignment = Element.ALIGN_CENTER,
                    .Padding = 10
                }
                table.AddCell(headerCell)
            Next

            Dim dataFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10)
            Dim totalSubjects As Integer = 0

            For Each row As DataRow In dt.Rows
                Dim subjectID As String = row("Subject ID").ToString()
                Dim subjectCode As String = row("Subject Code").ToString()
                Dim subjectName As String = row("Subject Name").ToString()
                Dim category As String = If(IsDBNull(row("Category")), "", row("Category").ToString())
                Dim gradeLevel As String = "GRADE " & row("Grade Level").ToString()
                Dim status As String = If(IsDBNull(row("Status")), "", row("Status").ToString())
                totalSubjects += 1

                Dim cells() As String = {subjectID, subjectCode, subjectName, category, gradeLevel, status}
                For Each cellText As String In cells
                    Dim cell As New PdfPCell(New Phrase(cellText, dataFont)) With {
                        .HorizontalAlignment = Element.ALIGN_CENTER,
                        .Padding = 8
                    }
                    table.AddCell(cell)
                Next
            Next

            Dim totalCells() As String = {"TOTAL", "", "", "", "", totalSubjects.ToString()}
            For Each cellText As String In totalCells
                Dim cell As New PdfPCell(New Phrase(cellText, New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {
                    .BackgroundColor = BaseColor.LIGHT_GRAY,
                    .HorizontalAlignment = Element.ALIGN_CENTER,
                    .Padding = 8
                }
                table.AddCell(cell)
            Next

            doc.Add(table)
            doc.Close()

            Dim reportTitle As String = If(selectedOption = "All Subjects", "All Subjects", selectedOption)
            MessageBox.Show(reportTitle & " Subject Report generated successfully!" & vbCrLf & "Total subjects: " & totalSubjects & vbCrLf & savePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating subject report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' ========== TEACHER REPORTS FUNCTIONALITY ==========
    ' Search Teacher by TeacherID
    Private Sub btnSearchTeacher_Click(sender As Object, e As EventArgs) Handles btnSearchTeacher.Click
        Dim teacherID As String = txtbxTeacherID.Text.Trim()

        If String.IsNullOrWhiteSpace(teacherID) Then
            MessageBox.Show("Please enter a Teacher ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If Not openConn() Then
                MessageBox.Show("Cannot connect to database. Please check your config.txt file and database settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if TeacherID exists in teacher table
            Dim checkQuery As String = "SELECT COUNT(*) FROM teacher WHERE TeacherID = @TeacherID"
            Using checkCmd As New MySqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@TeacherID", teacherID)
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count = 0 Then
                    MessageBox.Show("Teacher ID not found in the database.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    grpTeacherSectionStudents.Visible = False
                    grpTeacherSubjectLoad.Visible = False
                    currentTeacherID = ""
                    Return
                End If
            End Using

            ' TeacherID found, store it and show the Teacher Reports GroupBoxes
            currentTeacherID = teacherID
            grpTeacherSectionStudents.Visible = True
            grpTeacherSubjectLoad.Visible = True

            ' Adjust Teacher Reports GroupBox size to fit both nested sections
            ' Section Students at Y=70, Subject Load should be below it
            Dim sectionStudentsHeight As Integer = 150
            Dim spacing As Integer = 10
            Dim subjectLoadY As Integer = 70 + sectionStudentsHeight + spacing
            grpTeacherSubjectLoad.Location = New Point(18, subjectLoadY)
            
            ' Expand grpTeacherReports to fit both sections
            Dim totalTeacherHeight As Integer = subjectLoadY + 150 + 20 ' 20 for bottom padding
            grpTeacherReports.Size = New Size(1200, totalTeacherHeight)

            ' Load the teacher reports data
            LoadTeacherSectionStudents()
            LoadTeacherSubjectLoad()

            ' Re-center all GroupBoxes to account for expanded Teacher Reports
            CenterGroupBoxes()

            MessageBox.Show("Teacher ID found! Teacher reports are now available.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error searching for teacher: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Load students in teacher's section filtered by gender
    Private Sub LoadTeacherSectionStudents()
        If String.IsNullOrEmpty(currentTeacherID) Then
            Return
        End If

        Try
            If Not openConn() Then Return

            Dim selectedGender As String = Nothing
            If cmbTeacherGender.SelectedItem IsNot Nothing Then
                selectedGender = cmbTeacherGender.SelectedItem.ToString()
            End If

            Dim dt As New DataTable()
            Dim sql As String = "SELECT DISTINCT s.StudentID, s.FirstName, s.MiddleName, s.LastName, s.Gender " &
                                "FROM student s " &
                                "INNER JOIN enrollment e ON s.StudentID = e.StudentID " &
                                "INNER JOIN section sec ON e.SectionID = sec.SectionID " &
                                "WHERE sec.TeacherID = @TeacherID " &
                                "AND (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL)"

            If selectedGender IsNot Nothing AndAlso selectedGender <> "All" Then
                sql &= " AND s.Gender = @Gender"
            End If

            sql &= " ORDER BY s.LastName, s.FirstName"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@TeacherID", currentTeacherID)
                If selectedGender IsNot Nothing AndAlso selectedGender <> "All" Then
                    cmd.Parameters.AddWithValue("@Gender", selectedGender)
                End If

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvTeacherSectionStudents.DataSource = dt
            dgvTeacherSectionStudents.Refresh()
            HideLogoWhenDataShown()
            dgvTeacherSectionStudents.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Load teacher's subject load for the year
    Private Sub LoadTeacherSubjectLoad()
        If String.IsNullOrEmpty(currentTeacherID) Then
            Return
        End If

        Try
            If Not openConn() Then Return

            Dim selectedYear As String = Nothing
            If cmbTeacherSubjectLoadYear.SelectedItem IsNot Nothing Then
                selectedYear = cmbTeacherSubjectLoadYear.SelectedItem.ToString()
            End If

            Dim dt As New DataTable()
            Dim sql As String = "SELECT s.SubjectID, s.SubjectCode, s.SubjectName, s.Category, s.GradeLevel, s.Schedule " &
                                "FROM subject s " &
                                "WHERE s.TeacherID = @TeacherID"

            If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                sql &= " AND YEAR(s.DateCreated) = @Year"
            End If

            sql &= " ORDER BY s.SubjectName"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@TeacherID", currentTeacherID)
                If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                    cmd.Parameters.AddWithValue("@Year", Integer.Parse(selectedYear))
                End If

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvTeacherSubjectLoad.DataSource = dt
            dgvTeacherSubjectLoad.Refresh()
            HideLogoWhenDataShown()
            dgvTeacherSubjectLoad.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error loading subject load: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Event handlers for Teacher Reports
    Private Sub cmbTeacherGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeacherGender.SelectedIndexChanged
        If Not isInitializing AndAlso Not String.IsNullOrEmpty(currentTeacherID) Then
            LoadTeacherSectionStudents()
        End If
    End Sub

    Private Sub cmbTeacherSubjectLoadYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeacherSubjectLoadYear.SelectedIndexChanged
        If Not isInitializing AndAlso Not String.IsNullOrEmpty(currentTeacherID) Then
            LoadTeacherSubjectLoad()
        End If
    End Sub

    ' Button click handlers for Teacher Reports
    Private Sub btnSuperAdminGenerateTeacherStudents_Click(sender As Object, e As EventArgs) Handles btnSuperAdminGenerateTeacherStudents.Click
        If String.IsNullOrEmpty(currentTeacherID) Then
            MessageBox.Show("Please search for a teacher first.", "Teacher Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If dgvTeacherSectionStudents.DataSource Is Nothing OrElse DirectCast(dgvTeacherSectionStudents.DataSource, DataTable).Rows.Count = 0 Then
            MessageBox.Show("No student data to generate report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        GenerateTeacherSectionStudentsReport()
    End Sub

    Private Sub btnSuperAdminGenerateTeacherSubjectLoad_Click(sender As Object, e As EventArgs) Handles btnSuperAdminGenerateTeacherSubjectLoad.Click
        If String.IsNullOrEmpty(currentTeacherID) Then
            MessageBox.Show("Please search for a teacher first.", "Teacher Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If dgvTeacherSubjectLoad.DataSource Is Nothing OrElse DirectCast(dgvTeacherSubjectLoad.DataSource, DataTable).Rows.Count = 0 Then
            MessageBox.Show("No subject data to generate report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        GenerateTeacherSubjectLoadReport()
    End Sub

    ' PDF Generation for Teacher Reports
    Private Sub GenerateTeacherSectionStudentsReport()
        Try
            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim selectedGender As String = If(cmbTeacherGender.SelectedItem IsNot Nothing, cmbTeacherGender.SelectedItem.ToString(), "All")
            Dim fileName As String = "TeacherSectionStudents_TeacherID" & currentTeacherID & "_" & selectedGender & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"
            Dim savePath As String = Path.Combine(desktopPath, fileName)

            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
            PdfWriter.GetInstance(doc, New FileStream(savePath, FileMode.Create))
            doc.Open()

            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
            Dim titleText As String = "Section Students Report - Teacher ID: " & currentTeacherID
            If selectedGender <> "All" Then
                titleText &= " (" & selectedGender & ")"
            End If
            Dim title As New Paragraph(titleText, titleFont) With {.Alignment = Element.ALIGN_CENTER}
            doc.Add(title)
            doc.Add(New Paragraph("Generated on: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))
            doc.Add(New Paragraph(" "))

            Dim dt As DataTable = DirectCast(dgvTeacherSectionStudents.DataSource, DataTable)
            Dim table As New PdfPTable(5)
            table.WidthPercentage = 100
            table.SetWidths(New Single() {1, 3, 3, 3, 1.5F})

            ' Headers
            table.AddCell(New PdfPCell(New Phrase("Student ID", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("First Name", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Middle Name", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Last Name", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Gender", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})

            For Each row As DataRow In dt.Rows
                table.AddCell(GetSafeString(row("StudentID")))
                table.AddCell(GetSafeString(row("FirstName")))
                table.AddCell(GetSafeString(row("MiddleName")))
                table.AddCell(GetSafeString(row("LastName")))
                table.AddCell(GetSafeString(row("Gender")))
            Next

            doc.Add(table)
            doc.Close()

            MessageBox.Show("Report generated successfully!" & vbCrLf & "Saved to: " & savePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenerateTeacherSubjectLoadReport()
        Try
            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim selectedYear As String = If(cmbTeacherSubjectLoadYear.SelectedItem IsNot Nothing, cmbTeacherSubjectLoadYear.SelectedItem.ToString(), "AllYears")
            Dim fileName As String = "TeacherSubjectLoad_TeacherID" & currentTeacherID & "_" & selectedYear & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"
            Dim savePath As String = Path.Combine(desktopPath, fileName)

            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
            PdfWriter.GetInstance(doc, New FileStream(savePath, FileMode.Create))
            doc.Open()

            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
            Dim titleText As String = "Teacher Subject Load Report - Teacher ID: " & currentTeacherID
            If selectedYear <> "AllYears" Then
                titleText &= " (" & selectedYear & ")"
            End If
            Dim title As New Paragraph(titleText, titleFont) With {.Alignment = Element.ALIGN_CENTER}
            doc.Add(title)
            doc.Add(New Paragraph("Generated on: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))
            doc.Add(New Paragraph(" "))

            Dim dt As DataTable = DirectCast(dgvTeacherSubjectLoad.DataSource, DataTable)
            Dim table As New PdfPTable(6)
            table.WidthPercentage = 100
            table.SetWidths(New Single() {1, 2, 4, 2, 1, 2})

            ' Headers
            table.AddCell(New PdfPCell(New Phrase("Subject ID", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Subject Code", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Subject Name", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Category", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Grade", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Schedule", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})

            For Each row As DataRow In dt.Rows
                table.AddCell(GetSafeString(row("SubjectID")))
                table.AddCell(GetSafeString(row("SubjectCode")))
                table.AddCell(GetSafeString(row("SubjectName")))
                table.AddCell(GetSafeString(row("Category")))
                table.AddCell(GetSafeString(row("GradeLevel")))
                table.AddCell(GetSafeString(row("Schedule")))
            Next

            doc.Add(table)
            doc.Close()

            MessageBox.Show("Report generated successfully!" & vbCrLf & "Saved to: " & savePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetSafeString(value As Object) As String
        If value Is Nothing OrElse IsDBNull(value) Then
            Return ""
        End If
        Return value.ToString()
    End Function

End Class