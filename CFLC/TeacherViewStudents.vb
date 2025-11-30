Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Collections.Generic

Public Class TeacherViewStudents
    Public Property IsEmbedded As Boolean = False
    Public Property TeacherID As String = "" ' The logged-in teacher's ID
    Private isInitializing As Boolean = False
    Private lastSelectedIndex As Integer = -1
    
    ' Events for dashboard updates
    Public Event StudentCountChanged(count As Integer)
    Public Event FourPSDataChanged(with4PS As Integer, without4PS As Integer)
    Public Event IndigenousDataChanged(indigenous As Integer, notIndigenous As Integer)
    Public Event GenderDataChanged(maleCount As Integer, femaleCount As Integer)

    Private Sub TeacherViewStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isInitializing = True

        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        End If
        Me.Text = "My Students - Teacher"

        ' Load students from teacher's section
        If Not String.IsNullOrEmpty(TeacherID) Then
            LoadStudentsInTeacherSection()
        Else
            MessageBox.Show("TeacherID is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Set all detail controls to read-only
        SetControlsReadOnly()

        ' Ensure no row is selected on initial load and details are cleared
        dgvStudents.ClearSelection()
        ClearStudentDetails()

        isInitializing = False
    End Sub

    Private Sub LoadStudentsInTeacherSection()
        Try
            modDBx.openConn("cflc_db")
            ' Query to get students enrolled in the teacher's section
            Dim query As String = "SELECT st.* 
                                  FROM student st 
                                  INNER JOIN enrollment se ON st.StudentID = se.StudentID 
                                  INNER JOIN section s ON se.SectionID = s.SectionID 
                                  WHERE s.TeacherID = @teacher_id"

            Using cmd As New MySqlCommand(query, modDBx.conn)
                cmd.Parameters.AddWithValue("@teacher_id", TeacherID)

                ' Load into DataGridView
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvStudents.DataSource = dt
                
                ' Raise events after data is loaded
                RaiseDataChangedEvents()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub SetControlsReadOnly()
        ' Set all student detail controls to read-only
        txtbxStudentFirstName.ReadOnly = True
        txtbxStudentFirstName.Enabled = False

        txtStudentMiddleName.ReadOnly = True
        txtStudentMiddleName.Enabled = False

        txtbxStudentSurname.ReadOnly = True
        txtbxStudentSurname.Enabled = False

        txtbxStudentExtension.ReadOnly = True
        txtbxStudentExtension.Enabled = False

        txtbbxStudentIPGroup.ReadOnly = True
        txtbbxStudentIPGroup.Enabled = False

        txtbx4ps.ReadOnly = True
        txtbx4ps.Enabled = False

        dtpStudentBirthdate.Enabled = False

        cmbStudenttGender.Enabled = False

        txtbxStudentPOB.ReadOnly = True
        txtbxStudentPOB.Enabled = False

        txtbxStudentReligion.ReadOnly = True
        txtbxStudentReligion.Enabled = False

        txtbxStudentAge.ReadOnly = True
        txtbxStudentAge.Enabled = False

        txtbxStudentLRN.ReadOnly = True
        txtbxStudentLRN.Enabled = False

        txtbxStudentMotherTongue.ReadOnly = True
        txtbxStudentMotherTongue.Enabled = False

        txtbxGuardianName.ReadOnly = True
        txtbxGuardianName.Enabled = False

        txtbxGuardianContactNo.ReadOnly = True
        txtbxGuardianContactNo.Enabled = False

        txtbxStudentHouseNo.ReadOnly = True
        txtbxStudentHouseNo.Enabled = False

        txtbxstudentStreet.ReadOnly = True
        txtbxstudentStreet.Enabled = False

        txtbxStudentBarangay.ReadOnly = True
        txtbxStudentBarangay.Enabled = False

        txtbxStudentCity.ReadOnly = True
        txtbxStudentCity.Enabled = False

        txtbxStudentProvince.ReadOnly = True
        txtbxStudentProvince.Enabled = False

        txtbxCountry.ReadOnly = True
        txtbxCountry.Enabled = False

        txtbxZipCode.ReadOnly = True
        txtbxZipCode.Enabled = False
    End Sub

    ' Generalized ProcessCmdKey:
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Preserve existing global shortcuts when not editing text
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

    ' Populate the student detail controls when a row in dgvStudents is clicked
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If isInitializing Then
            Return
        End If

        If e.RowIndex < 0 Then
            Return
        End If

        ' Toggle behavior: clicking the same row again will unselect and clear details
        If e.RowIndex = lastSelectedIndex Then
            dgvStudents.ClearSelection()
            ClearStudentDetails()
            lastSelectedIndex = -1
            Return
        End If

        Dim row As DataGridViewRow = dgvStudents.Rows(e.RowIndex)

        ' Select only this row
        dgvStudents.ClearSelection()
        row.Selected = True
        lastSelectedIndex = e.RowIndex

        ' Populate student details
        txtbxStudentLRN.Text = GetSafeString(row.Cells("LRN"))
        txtbxStudentFirstName.Text = GetSafeString(row.Cells("FirstName"))
        txtStudentMiddleName.Text = GetSafeString(row.Cells("MiddleName"))
        txtbxStudentSurname.Text = GetSafeString(row.Cells("LastName"))
        txtbxStudentExtension.Text = GetSafeString(row.Cells("ExtensionName"))
        cmbStudenttGender.Text = GetSafeString(row.Cells("Gender"))

        If Not IsDBNull(row.Cells("Birthdate").Value) Then
            dtpStudentBirthdate.Value = CDate(row.Cells("Birthdate").Value)
        End If

        txtbxStudentPOB.Text = GetSafeString(row.Cells("BirthPlace"))
        txtbxStudentMotherTongue.Text = GetSafeString(row.Cells("MotherTongue"))
        txtbxStudentReligion.Text = GetSafeString(row.Cells("Religion"))

        ' Indigineous fields
        txtbbxStudentIPGroup.Text = GetSafeString(row.Cells("IndigineousSpecific"))

        ' 4Ps fields
        txtbx4ps.Text = GetSafeString(row.Cells("4PsID"))

        txtbxGuardianName.Text = GetSafeString(row.Cells("GuardianName"))
        txtbxGuardianContactNo.Text = GetSafeString(row.Cells("GuardianContact"))

        ' Age field
        If Not IsDBNull(row.Cells("Age").Value) Then
            txtbxStudentAge.Text = row.Cells("Age").Value.ToString()
        End If

        ' Address fields
        txtbxStudentHouseNo.Text = GetSafeString(row.Cells("HouseNumber"))
        txtbxstudentStreet.Text = GetSafeString(row.Cells("Street"))
        txtbxStudentBarangay.Text = GetSafeString(row.Cells("Barangay"))
        txtbxStudentCity.Text = GetSafeString(row.Cells("Municipality"))
        txtbxStudentProvince.Text = GetSafeString(row.Cells("Province"))
        txtbxCountry.Text = GetSafeString(row.Cells("Country"))
        txtbxZipCode.Text = GetSafeString(row.Cells("ZIPCode"))
    End Sub

    ' Helper function for safe string retrieval from DataGridView
    Private Function GetSafeString(cell As DataGridViewCell) As String
        Return If(cell.Value Is Nothing OrElse IsDBNull(cell.Value), "", cell.Value.ToString())
    End Function

    ' Clear the student detail controls
    Private Sub ClearStudentDetails()
        txtbxStudentLRN.Text = String.Empty
        txtbxStudentFirstName.Text = String.Empty
        txtStudentMiddleName.Text = String.Empty
        txtbxStudentSurname.Text = String.Empty
        txtbxStudentExtension.Text = String.Empty
        cmbStudenttGender.Text = String.Empty
        dtpStudentBirthdate.Value = DateTime.Today
        txtbxStudentPOB.Text = String.Empty
        txtbxStudentMotherTongue.Text = String.Empty
        txtbxStudentReligion.Text = String.Empty
        txtbbxStudentIPGroup.Text = String.Empty
        txtbx4ps.Text = String.Empty
        txtbxGuardianName.Text = String.Empty
        txtbxGuardianContactNo.Text = String.Empty
        txtbxStudentAge.Text = String.Empty
        txtbxStudentHouseNo.Text = String.Empty
        txtbxstudentStreet.Text = String.Empty
        txtbxStudentBarangay.Text = String.Empty
        txtbxStudentCity.Text = String.Empty
        txtbxStudentProvince.Text = String.Empty
        txtbxCountry.Text = String.Empty
        txtbxZipCode.Text = String.Empty
        lastSelectedIndex = -1
    End Sub

    ' Perform a search within the teacher's section students
    Private Sub PerformSearch(query As String)
        Try
            modDBx.openConn("cflc_db")
            Dim trimmed As String = query?.Trim()

            If String.IsNullOrEmpty(trimmed) Then
                ' Show all students in teacher's section
                LoadStudentsInTeacherSection()
            Else
                Dim safe As String = trimmed.Replace("'", "''")
                Dim sql As String = "SELECT st.* 
                                    FROM student st 
                                    INNER JOIN enrollment se ON st.StudentID = se.StudentID 
                                    INNER JOIN section s ON se.SectionID = s.SectionID 
                                    WHERE s.TeacherID = @teacher_id 
                                    AND (st.LRN LIKE '%" & safe & "%' 
                                         OR st.FirstName LIKE '%" & safe & "%' 
                                         OR st.LastName LIKE '%" & safe & "%' 
                                         OR st.MiddleName LIKE '%" & safe & "%')"

                Using cmd As New MySqlCommand(sql, modDBx.conn)
                    cmd.Parameters.AddWithValue("@teacher_id", TeacherID)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvStudents.DataSource = dt
                    
                    ' Raise events after data is loaded
                    RaiseDataChangedEvents()
                End Using
            End If

            ' After reloading results, clear selection and details
            dgvStudents.ClearSelection()
            ClearStudentDetails()

        Catch ex As Exception
            MessageBox.Show("Error searching students: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' Search when user types and presses Enter
    Private Sub TextBoxStudentSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxStudentSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            PerformSearch(TextBoxStudentSearch.Text)
        End If
    End Sub

    ' Live-search: start searching on the first character typed
    Private Sub TextBoxStudentSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxStudentSearch.TextChanged
        PerformSearch(TextBoxStudentSearch.Text)
    End Sub

    ' If you add a Search button in the Designer, wire its Click to this sub
    Public Sub btnStudentSearch_Click(sender As Object, e As EventArgs)
        PerformSearch(TextBoxStudentSearch.Text)
    End Sub

    ' Keep your existing event handlers
    Private Sub txtbxStudentFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtbxStudentFirstName.TextChanged
        ' Add any specific logic here if needed
    End Sub

    Private Sub txtbxStudentPOB_TextChanged(sender As Object, e As EventArgs) Handles txtbxStudentPOB.TextChanged
        ' Add any specific logic here if needed
    End Sub
    
    ' Public methods to get data for dashboard
    Public Function GetStudentCount() As Integer
        If dgvStudents.DataSource IsNot Nothing AndAlso TypeOf dgvStudents.DataSource Is DataTable Then
            Return DirectCast(dgvStudents.DataSource, DataTable).Rows.Count
        End If
        Return 0
    End Function
    
    Public Function GetFourPSCounts() As Dictionary(Of String, Integer)
        Dim counts As New Dictionary(Of String, Integer)
        counts("With 4PS") = 0
        counts("No 4PS") = 0
        
        If dgvStudents.DataSource IsNot Nothing AndAlso TypeOf dgvStudents.DataSource Is DataTable Then
            Dim dt As DataTable = DirectCast(dgvStudents.DataSource, DataTable)
            For Each row As DataRow In dt.Rows
                Dim fourPSValue As Object = row("4PsID")
                If fourPSValue IsNot Nothing AndAlso Not IsDBNull(fourPSValue) AndAlso Not String.IsNullOrWhiteSpace(fourPSValue.ToString()) Then
                    counts("With 4PS") += 1
                Else
                    counts("No 4PS") += 1
                End If
            Next
        End If
        
        Return counts
    End Function
    
    Public Function GetIndigenousCounts() As Dictionary(Of String, Integer)
        Dim counts As New Dictionary(Of String, Integer)
        counts("Indigenous") = 0
        counts("Not Indigenous") = 0
        
        If dgvStudents.DataSource IsNot Nothing AndAlso TypeOf dgvStudents.DataSource Is DataTable Then
            Dim dt As DataTable = DirectCast(dgvStudents.DataSource, DataTable)
            For Each row As DataRow In dt.Rows
                Dim indigenousValue As Object = row("IndigineousSpecific")
                If indigenousValue IsNot Nothing AndAlso Not IsDBNull(indigenousValue) AndAlso Not String.IsNullOrWhiteSpace(indigenousValue.ToString()) Then
                    counts("Indigenous") += 1
                Else
                    counts("Not Indigenous") += 1
                End If
            Next
        End If
        
        Return counts
    End Function
    
    Public Function GetGenderCounts() As Dictionary(Of String, Integer)
        Dim counts As New Dictionary(Of String, Integer)
        counts("Male") = 0
        counts("Female") = 0
        
        If dgvStudents.DataSource IsNot Nothing AndAlso TypeOf dgvStudents.DataSource Is DataTable Then
            Dim dt As DataTable = DirectCast(dgvStudents.DataSource, DataTable)
            For Each row As DataRow In dt.Rows
                Dim genderValue As Object = row("Gender")
                If genderValue IsNot Nothing AndAlso Not IsDBNull(genderValue) Then
                    Dim gender As String = genderValue.ToString().Trim()
                    If String.Equals(gender, "Male", StringComparison.OrdinalIgnoreCase) Then
                        counts("Male") += 1
                    ElseIf String.Equals(gender, "Female", StringComparison.OrdinalIgnoreCase) Then
                        counts("Female") += 1
                    End If
                End If
            Next
        End If
        
        Return counts
    End Function
    
    ' Raise all data changed events
    Private Sub RaiseDataChangedEvents()
        Try
            Dim studentCount As Integer = GetStudentCount()
            RaiseEvent StudentCountChanged(studentCount)
            
            Dim fourPSCounts As Dictionary(Of String, Integer) = GetFourPSCounts()
            RaiseEvent FourPSDataChanged(fourPSCounts("With 4PS"), fourPSCounts("No 4PS"))
            
            Dim indigenousCounts As Dictionary(Of String, Integer) = GetIndigenousCounts()
            RaiseEvent IndigenousDataChanged(indigenousCounts("Indigenous"), indigenousCounts("Not Indigenous"))
            
            Dim genderCounts As Dictionary(Of String, Integer) = GetGenderCounts()
            RaiseEvent GenderDataChanged(genderCounts("Male"), genderCounts("Female"))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error raising data changed events: " & ex.Message)
        End Try
    End Sub
    
    ' Handle DataBindingComplete to raise events when data changes
    Private Sub dgvStudents_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvStudents.DataBindingComplete
        If Not isInitializing Then
            RaiseDataChangedEvents()
        End If
    End Sub
End Class