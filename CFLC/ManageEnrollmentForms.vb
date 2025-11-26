Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ManageEnrollmentForms

    Public Property IsEmbedded As Boolean = False
    Private currentEnrollmentID As Integer = 0
    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ManageEnrollmentForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadToDGV("SELECT * FROM enrollment", dgvEnrollment)

    End Sub

    Private Sub btnEnrollDelete_Click(sender As Object, e As EventArgs) Handles btnEnrollDelete.Click
        ' Check if a enrollment is selected
        If currentEnrollmentID = 0 Then
            MessageBox.Show("Please select a enrollment to delete.", "Delete Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Confirm deletion
        If MessageBox.Show("Are you sure you want to delete this Enrollment?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Try
            ' Open database connection
            modDBx.openConn(modDBx.db_name)

            ' Prepare the DELETE SQL statement
            Dim sql As String = "DELETE FROM enrollment WHERE EnrollmentID = @EnrollmentID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@EnrollmentID", currentEnrollmentID)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Enrollment deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Refresh the DataGridView
                    LoadToDGV("SELECT * FROM enrollment", dgvEnrollment)
                    ' Reset current selection and clear input fields
                    currentEnrollmentID = 0
                    ClearInputFields()
                Else
                    MessageBox.Show("No enrollment was deleted. Please check your selection.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error deleting enrollment: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection safely
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub ClearInputFields()
        TextBoxEnrollmentSchoolYear.Text = ""
        TextBoxEnrollmentGradeLvl.Text = ""
        DateTimePickerEnrollmentDate.Value = DateTime.Now
        ComboBoxEnrollmentPaymentStatus.SelectedIndex = -1
        TextBoxEnrollmentModeOfPayment.Text = ""
        ComboBoxEnrollmentStatus.SelectedIndex = -1
        ComboBoxEnrollmentMode.SelectedIndex = -1
        TextBoxEnrollmentProcessedBy.Text = ""
        TextBoxEnrollmentGuardianName.Text = ""
        TextBoxEnrollmentContactNo.Text = ""
        TextBoxEnrollmentRequirementStatus.Text = ""
        TextBoxEnrollmentRefNum.Text = ""
    End Sub

End Class