Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class TeacherViewStudents

    Public Property IsEmbedded As Boolean = False
    Private isInitializing As Boolean = False
    Private lastSelectedIndex As Integer = -1

    Private Sub TeacherViewStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isInitializing = True

        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        End If
        Me.Text = "Dashboard-Teacher"

        LoadToDGV("SELECT * FROM student", dgvStudents)

        ' Ensure no row is selected on initial load and details are cleared
        dgvStudents.ClearSelection()
        ClearStudentDetails()

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

        isInitializing = False
    End Sub

    ' Allow typing "f" into the student search TextBox while preventing the parent/dashboard full-screen handler.
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' If the search TextBox exists and has focus and key is F, insert the char and consume the key.
        If (keyData And Keys.KeyCode) = Keys.F AndAlso
           TextBoxStudentSearch IsNot Nothing AndAlso TextBoxStudentSearch.Focused Then

            Dim tb = TextBoxStudentSearch
            Dim s As String = tb.Text
            Dim selStart As Integer = tb.SelectionStart
            Dim selLen As Integer = tb.SelectionLength

            Dim shiftPressed As Boolean = (Control.ModifierKeys And Keys.Shift) = Keys.Shift
            Dim capsOn As Boolean = Control.IsKeyLocked(Keys.CapsLock)
            Dim useUpper As Boolean = shiftPressed Xor capsOn
            Dim ch As Char = If(useUpper, "F"c, "f"c)

            Dim before As String = If(selStart > 0, s.Substring(0, selStart), String.Empty)
            Dim afterIndex As Integer = Math.Min(selStart + selLen, s.Length)
            Dim after As String = If(afterIndex < s.Length, s.Substring(afterIndex), String.Empty)

            tb.Text = before & ch & after
            tb.SelectionStart = selStart + 1
            tb.SelectionLength = 0

            Return True
        End If

        ' Existing global shortcuts preserved when search box not focused
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

    Private Sub txtbxStudentFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtbxStudentFirstName.TextChanged
        txtbxStudentFirstName.ReadOnly = True
        txtbxStudentFirstName.Enabled = False
        txtbxStudentFirstName.TabStop = False
    End Sub

    Private Sub txtbxStudentPOB_TextChanged(sender As Object, e As EventArgs) Handles txtbxStudentPOB.TextChanged

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

        ' Safely read the StudentID in the clicked row
        Dim clickedID As Integer = 0
        If row.Cells.Count > 0 AndAlso row.Cells(0).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(0).Value) Then
            Integer.TryParse(row.Cells(0).Value.ToString(), clickedID)
        End If

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

    ' Perform a search using the TextBox input. Safe-escape single quotes for SQL string composition.
    Private Sub PerformSearch(query As String)
        Dim trimmed As String = query?.Trim()
        If String.IsNullOrEmpty(trimmed) Then
            LoadToDGV("SELECT * FROM student", dgvStudents)
        Else
            Dim safe As String = trimmed.Replace("'", "''")
            Dim sql As String = "SELECT * FROM student WHERE LRN LIKE '%" & safe & "%' OR FirstName LIKE '%" & safe & "%' OR LastName LIKE '%" & safe & "%' OR MiddleName LIKE '%" & safe & "%'"
            LoadToDGV(sql, dgvStudents)
        End If

        ' After reloading results, clear selection and details
        dgvStudents.ClearSelection()
        ClearStudentDetails()
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

    ' If you add a Search button in the Designer, wire its Click to this sub (no Handles so designer can attach it)
    Public Sub btnStudentSearch_Click(sender As Object, e As EventArgs)
        PerformSearch(TextBoxStudentSearch.Text)
    End Sub
End Class