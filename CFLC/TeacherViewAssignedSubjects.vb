Public Class TeacherViewAssignedSubjects

    Public Property IsEmbedded As Boolean = False
    Private isInitializing As Boolean = False
    Private lastSelectedIndex As Integer = -1

    Private Sub TeacherViewSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isInitializing = True

        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BackColor = Color.FromArgb(7, 77, 39) ' Dark green background ni nio
        Me.Text = "Dashboard-Teacher"

        LoadToDGV("SELECT * FROM subject", dgvSubjectList)

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

        isInitializing = False
    End Sub

    ' Allow typing "f" into the search TextBox while preventing the parent/dashboard full-screen handler.
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Check only the key code (ignore modifiers in comparison)
        If (keyData And Keys.KeyCode) = Keys.F AndAlso TextBoxSubjectSearch IsNot Nothing AndAlso TextBoxSubjectSearch.Focused Then
            ' Insert the character into the textbox manually (preserve selection/replacement).
            Dim tb = TextBoxSubjectSearch
            Dim s As String = tb.Text
            Dim selStart As Integer = tb.SelectionStart
            Dim selLen As Integer = tb.SelectionLength

            ' Determine case: Shift toggles, CapsLock toggles
            Dim shiftPressed As Boolean = (keyData And Keys.Shift) = Keys.Shift
            Dim capsOn As Boolean = Control.IsKeyLocked(Keys.CapsLock)
            Dim useUpper As Boolean = shiftPressed Xor capsOn
            Dim ch As Char = If(useUpper, "F"c, "f"c)

            Dim before As String = If(selStart > 0, s.Substring(0, selStart), String.Empty)
            Dim afterIndex As Integer = Math.Min(selStart + selLen, s.Length)
            Dim after As String = If(afterIndex < s.Length, s.Substring(afterIndex), String.Empty)

            tb.Text = before & ch & after
            tb.SelectionStart = selStart + 1
            tb.SelectionLength = 0

            ' Consume the key so parent doesn't trigger full-screen
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ' Populate the subject detail controls when a row in dgvSubjectList is clicked
    Private Sub dgvSubjectList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjectList.CellClick
        If isInitializing Then
            Return
        End If

        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvSubjectList.Rows(e.RowIndex)

        ' Toggle behavior using lastSelectedIndex:
        ' - If the same row is clicked again (index equals lastSelectedIndex) unselect and clear details.
        ' - Otherwise select the new row, populate details and update lastSelectedIndex.
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

        ' Safely read a possible SubjectID in the clicked row (if present)
        Dim clickedID As Integer = 0
        If row.Cells.Count > 0 AndAlso row.Cells(0).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(0).Value) Then
            Integer.TryParse(row.Cells(0).Value.ToString(), clickedID)
        End If

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
    End Sub

    ' Helper function for safe string retrieval from DataGridView
    Private Function GetSafeString(cell As DataGridViewCell) As String
        Return If(cell Is Nothing OrElse cell.Value Is Nothing OrElse IsDBNull(cell.Value), "", cell.Value.ToString())
    End Function

    ' Clear the detail controls (used after loading or clearing search results)
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

    ' Perform a search using the TextBox input. Safe-escape single quotes for SQL string composition.
    Private Sub PerformSearch(query As String)
        Dim trimmed As String = query?.Trim()
        If String.IsNullOrEmpty(trimmed) Then
            LoadToDGV("SELECT * FROM subject", dgvSubjectList)
        Else
            Dim safe As String = trimmed.Replace("'", "''")
            Dim sql As String = "SELECT * FROM subject WHERE SubjectCode LIKE '%" & safe & "%' OR SubjectName LIKE '%" & safe & "%' OR Category LIKE '%" & safe & "%'"
            LoadToDGV(sql, dgvSubjectList)
        End If

        ' After reloading results, clear selection and clear details so nothing appears selected automatically
        dgvSubjectList.ClearSelection()
        ClearSubjectDetails()
    End Sub

    ' Search when user types and presses Enter
    Private Sub TextBoxSubjectSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSubjectSearch.KeyDown
        PerformSearch(TextBoxSubjectSearch.Text)
    End Sub

    ' Live-search as user types (optional). If you prefer only Enter-triggered search, remove this handler body.
    Private Sub TextBoxSubjectSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSubjectSearch.TextChanged
        If String.IsNullOrWhiteSpace(TextBoxSubjectSearch.Text) Then
            PerformSearch(String.Empty)
        End If
    End Sub

    ' If you add a Search button in the Designer, wire its Click to this sub (no Handles so designer can attach it)
    Public Sub btnSubjectSearch_Click(sender As Object, e As EventArgs)
        PerformSearch(TextBoxSubjectSearch.Text)
    End Sub

End Class