Public Class ManageEnrollmentForms

    Public Property IsEmbedded As Boolean = False
    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ManageEnrollmentForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadToDGV("SELECT * FROM enrollment", dgvEnrollment)

    End Sub


End Class