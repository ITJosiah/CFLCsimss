Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class TeacherViewAssignedSubjects
    Public Property IsEmbedded As Boolean = False
    Private isInitializing As Boolean = False
    Private lastSelectedIndex As Integer = -1
    Public Property TeacherID As String = "" ' Store the logged-in teacher's ID

    ' Default constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Optional constructor to accept teacher ID
    Public Sub New(loggedInTeacherID As String)
        InitializeComponent()
        Me.TeacherID = loggedInTeacherID
    End Sub

    Private Sub TeacherViewSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isInitializing = True

        ' Debug: Check if TeacherID is set
        MessageBox.Show($"TeacherID in load: {TeacherID}", "Debug Info")

        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BackColor = Color.FromArgb(7, 77, 39)
        Me.Text = "Dashboard-Teacher"

        ' Set controls as read-only
        SetControlsReadOnly()

        ' Load teacher's assigned subjects
        If Not String.IsNullOrEmpty(TeacherID) Then
            LoadTeacherSubjects()
        Else
            MessageBox.Show("Teacher ID not found. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        isInitializing = False
    End Sub

    Private Sub SetControlsReadOnly()
        txtbxManSubSubjectCode.ReadOnly = True
        txtbxManSubSubjectCode.Enabled = False
        txtbxManSubSubjectName.ReadOnly = True
        txtbxManSubSubjectName.Enabled = False
        cmbSubjectCategory.Enabled = False
        txtbxManSubDescription.ReadOnly = True
        txtbxManSubDescription.Enabled = False
        txtbxManSubSkillFocus.ReadOnly = True
        txtbxManSubSkillFocus.Enabled = False
        nudManSubGradeLevel.Enabled = False
        ComboBoxSubjectStatus.Enabled = False
        cbxManSubRoomType.Enabled = False
        txtbxManSubLearningMaterials.ReadOnly = True
        txtbxManSubLearningMaterials.Enabled = False
        txtbxManSubSchedule.ReadOnly = True
        txtbxManSubSchedule.Enabled = False
        dtpManSubStartDate.Enabled = False
        dtpManSubEndDate.Enabled = False
        dtpManSubDateCreated.Enabled = False
        txtbxManSubCreatedBy.ReadOnly = True
        txtbxManSubCreatedBy.Enabled = False
        txtbxManSubTeacherID.ReadOnly = True
        txtbxManSubTeacherID.Enabled = False
    End Sub

    Private Sub LoadTeacherSubjects()
        Try
            modDBx.openConn("cflc_db")

            ' First, test if we can get any data
            Dim testQuery As String = "SELECT COUNT(*) as SubjectCount FROM subject WHERE TeacherID = @TeacherID"
            Using testCmd As New MySqlCommand(testQuery, modDBx.conn)
                testCmd.Parameters.AddWithValue("@TeacherID", TeacherID)
                Dim subjectCount As Integer = Convert.ToInt32(testCmd.ExecuteScalar())

                MessageBox.Show($"Found {subjectCount} subjects for TeacherID: {TeacherID}", "Database Info")

                If subjectCount = 0 Then
                    MessageBox.Show($"No subjects found for TeacherID: {TeacherID}", "Information")
                    Return
                End If
            End Using

            ' Now load the actual data
            Dim query As String = "SELECT * FROM subject WHERE TeacherID = @TeacherID"
            Using cmd As New MySqlCommand(query, modDBx.conn)
                cmd.Parameters.AddWithValue("@TeacherID", TeacherID)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                dgvSubjectList.DataSource = dt

                MessageBox.Show($"DataGridView loaded with {dt.Rows.Count} rows", "Data Load Info")
            End Using

            ' Clear any previous selection
            dgvSubjectList.ClearSelection()
            ClearSubjectDetails()

        Catch ex As Exception
            MessageBox.Show("Error loading assigned subjects: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' Modified PerformSearch to only search within teacher's subjects
    Private Sub PerformSearch(query As String)
        Dim trimmed As String = query?.Trim()

        Try
            modDBx.openConn("cflc_db")

            If String.IsNullOrEmpty(trimmed) Then
                ' Show all subjects for this teacher when search is empty
                Dim baseQuery As String = "SELECT * FROM subject WHERE TeacherID = @TeacherID"
                Using cmd As New MySqlCommand(baseQuery, modDBx.conn)
                    cmd.Parameters.AddWithValue("@TeacherID", TeacherID)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvSubjectList.DataSource = dt
                End Using
            Else
                ' Search only within this teacher's subjects
                Dim safe As String = trimmed.Replace("'", "''")
                Dim sql As String = "SELECT * FROM subject WHERE TeacherID = @TeacherID AND " &
                                   "(SubjectCode LIKE '%" & safe & "%' OR SubjectName LIKE '%" & safe & "%' OR Category LIKE '%" & safe & "%')"
                Using cmd As New MySqlCommand(sql, modDBx.conn)
                    cmd.Parameters.AddWithValue("@TeacherID", TeacherID)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvSubjectList.DataSource = dt
                End Using
            End If

            ' After reloading results, clear selection and clear details
            dgvSubjectList.ClearSelection()
            ClearSubjectDetails()
            lastSelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error searching subjects: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Dim keyOnly As Keys = keyData And Keys.KeyCode

        ' Find the deepest focused control inside the form
        Dim focused As Control = GetDeepestFocusedControl()

        ' If focused control is a TextBoxBase (TextBox or RichTextBox, etc.) and editable, handle F insertion
        If keyOnly = Keys.F AndAlso focused IsNot Nothing AndAlso TypeOf focused Is TextBoxBase Then
            Dim tbBase = DirectCast(focused, TextBoxBase)
            If tbBase.Enabled AndAlso Not tbBase.ReadOnly Then
                ' Determine character case using Shift and CapsLock
                Dim shiftPressed As Boolean = (Control.ModifierKeys And Keys.Shift) = Keys.Shift
                Dim capsOn As Boolean = Control.IsKeyLocked(Keys.CapsLock)
                Dim useUpper As Boolean = shiftPressed Xor capsOn
                Dim ch As Char = If(useUpper, "F"c, "f"c)

                ' Insert character respecting selection/replacement
                Dim s As String = tbBase.Text
                Dim selStart As Integer = tbBase.SelectionStart
                Dim selLen As Integer = tbBase.SelectionLength

                Dim before As String = If(selStart > 0, s.Substring(0, selStart), String.Empty)
                Dim afterIndex As Integer = Math.Min(selStart + selLen, s.Length)
                Dim after As String = If(afterIndex < s.Length, s.Substring(afterIndex), String.Empty)

                tbBase.Text = before & ch & after
                tbBase.SelectionStart = selStart + 1
                tbBase.SelectionLength = 0

                Return True ' consumed
            End If
        End If

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

    ' Walk ActiveControl chain to the deepest focused control
    Private Function GetDeepestFocusedControl() As Control
        Dim c As Control = Me.ActiveControl
        While c IsNot Nothing
            Dim container = TryCast(c, ContainerControl)
            If container IsNot Nothing AndAlso container.ActiveControl IsNot Nothing Then
                c = container.ActiveControl
            Else
                Exit While
            End If
        End While
        Return c
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

    Private Sub dgvSubjectList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjectList.CellClick
        If isInitializing Then
            Return
        End If

        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvSubjectList.Rows(e.RowIndex)

        ' Toggle behavior: clicking the same row again will unselect and clear details
        If e.RowIndex = lastSelectedIndex Then
            dgvSubjectList.ClearSelection()
            ClearSubjectDetails()
            lastSelectedIndex = -1
            Return
        End If

        ' Select only this row
        dgvSubjectList.ClearSelection()
        row.Selected = True
        lastSelectedIndex = e.RowIndex

        ' Safely read the data from the clicked row
        PopulateSubjectDetails(row)
    End Sub

    Private Sub PopulateSubjectDetails(row As DataGridViewRow)
        Try
            txtbxManSubSubjectCode.Text = GetSafeString(row.Cells("SubjectCode"))
            txtbxManSubSubjectName.Text = GetSafeString(row.Cells("SubjectName"))
            cmbSubjectCategory.Text = GetSafeString(row.Cells("Category"))
            txtbxManSubDescription.Text = GetSafeString(row.Cells("Description"))
            txtbxManSubSkillFocus.Text = GetSafeString(row.Cells("SkillFocus"))

            If Not IsDBNull(row.Cells("GradeLevel").Value) Then
                Dim n As Integer = 0
                If Integer.TryParse(row.Cells("GradeLevel").Value.ToString(), n) Then
                    nudManSubGradeLevel.Value = Math.Max(nudManSubGradeLevel.Minimum, Math.Min(nudManSubGradeLevel.Maximum, n))
                End If
            End If

            ComboBoxSubjectStatus.Text = GetSafeString(row.Cells("Status"))
            cbxManSubRoomType.Text = GetSafeString(row.Cells("RoomType"))
            txtbxManSubLearningMaterials.Text = GetSafeString(row.Cells("LearningMaterials"))
            txtbxManSubSchedule.Text = GetSafeString(row.Cells("Schedule"))

            If Not IsDBNull(row.Cells("StartDate").Value) Then
                dtpManSubStartDate.Value = CDate(row.Cells("StartDate").Value)
            End If

            If Not IsDBNull(row.Cells("EndDate").Value) Then
                dtpManSubEndDate.Value = CDate(row.Cells("EndDate").Value)
            End If

            If Not IsDBNull(row.Cells("DateCreated").Value) Then
                dtpManSubDateCreated.Value = CDate(row.Cells("DateCreated").Value)
            End If

            txtbxManSubCreatedBy.Text = GetSafeString(row.Cells("CreatedBy"))
            txtbxManSubTeacherID.Text = GetSafeString(row.Cells("TeacherID"))

        Catch ex As Exception
            MessageBox.Show("Error loading subject details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetSafeString(cell As DataGridViewCell) As String
        Return If(cell Is Nothing OrElse cell.Value Is Nothing OrElse IsDBNull(cell.Value), "", cell.Value.ToString())
    End Function

    Private Sub ClearSubjectDetails()
        txtbxManSubSubjectCode.Text = String.Empty
        txtbxManSubSubjectName.Text = String.Empty
        cmbSubjectCategory.Text = String.Empty
        txtbxManSubDescription.Text = String.Empty
        txtbxManSubSkillFocus.Text = String.Empty
        nudManSubGradeLevel.Value = nudManSubGradeLevel.Minimum
        ComboBoxSubjectStatus.Text = String.Empty
        cbxManSubRoomType.Text = String.Empty
        txtbxManSubLearningMaterials.Text = String.Empty
        txtbxManSubSchedule.Text = String.Empty
        dtpManSubStartDate.Value = DateTime.Today
        dtpManSubEndDate.Value = DateTime.Today
        dtpManSubDateCreated.Value = DateTime.Today
        txtbxManSubCreatedBy.Text = String.Empty
        txtbxManSubTeacherID.Text = String.Empty
    End Sub

    Private Sub TextBoxSubjectSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSubjectSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            PerformSearch(TextBoxSubjectSearch.Text)
        End If
    End Sub

    Private Sub TextBoxSubjectSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSubjectSearch.TextChanged
        If String.IsNullOrWhiteSpace(TextBoxSubjectSearch.Text) Then
            PerformSearch(String.Empty)
        End If
    End Sub

    Public Sub btnSubjectSearch_Click(sender As Object, e As EventArgs)
        PerformSearch(TextBoxSubjectSearch.Text)
    End Sub

    ' Refresh button method (if you have a refresh button)

    ' Add these missing event handlers for your controls
    Private Sub txtbxManSubSubjectCode_TextChanged(sender As Object, e As EventArgs) Handles txtbxManSubSubjectCode.TextChanged
        ' Add any specific logic here if needed
    End Sub

    Private Sub txtbxManSubSubjectName_TextChanged(sender As Object, e As EventArgs) Handles txtbxManSubSubjectName.TextChanged
        ' Add any specific logic here if needed
    End Sub

    Private Sub cmbSubjectCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubjectCategory.SelectedIndexChanged
        ' Add any specific logic here if needed
    End Sub
End Class