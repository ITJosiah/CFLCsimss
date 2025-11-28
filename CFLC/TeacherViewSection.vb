Public Class TeacherViewSection
    Public Property IsEmbedded As Boolean = False
    Private Sub TeacherViewSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BackColor = Color.FromArgb(7, 77, 39) ' Dark green background ni nio
        Me.Text = "Dashboard-Teacher"


        txtbxManSecSectionName.ReadOnly = True
        txtbxManSecSectionName.Enabled = False

        nudManSecGradeLevel.ReadOnly = True
        nudManSecGradeLevel.Enabled = False

        txtbxManSecTeacherID.ReadOnly = True
        txtbxManSecTeacherID.Enabled = False

        txtbxManSecRoomNo.ReadOnly = True
        txtbxManSecRoomNo.Enabled = False

        txtbxManSecBuildingName.ReadOnly = True
        txtbxManSecBuildingName.Enabled = False


        cmbManSecClassType.Enabled = False

        cmbManSecLearningMode.Enabled = False

        txtbxManSchedule.ReadOnly = True
        txtbxManSchedule.Enabled = False

    End Sub


    Private Sub txtbxManSecTeacherID_TextChanged(sender As Object, e As EventArgs) Handles txtbxManSecTeacherID.TextChanged

    End Sub

    Private Sub lblManSecTeacherID_Click(sender As Object, e As EventArgs) Handles lblManSecTeacherID.Click

    End Sub

    Private Sub picWatermark_Click(sender As Object, e As EventArgs) Handles picWatermark.Click

    End Sub
End Class