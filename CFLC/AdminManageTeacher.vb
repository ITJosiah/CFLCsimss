Public Class AdminManageTeacher
    Public Property IsEmbedded As Boolean = False


    Private Sub txtbxTeacherZipCode_TextChanged(sender As Object, e As EventArgs) Handles txtbxTeacherZipCode.TextChanged

    End Sub

    Private Sub txtbxTeacherZipCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxTeacherZipCode.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


End Class


