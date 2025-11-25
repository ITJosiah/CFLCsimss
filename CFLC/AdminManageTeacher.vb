Public Class AdminManageTeacher


    Public Property IsEmbedded As Boolean = False

    Private currentTeacherID As Integer = 0
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeacher.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTeacher.Rows(e.RowIndex)

            ' Store the StudentID (assuming it's the first column, index 0)
            currentTeacherID = CInt(row.Cells(0).Value)

            TextBoxTeacherFirstName.Text = row.Cells("FirstName").Value.ToString()
            TextBoxTeacherMiddleName.Text = row.Cells("MiddleName").Value.ToString()
            TextBoxTeacherSurname.Text = row.Cells("LastName").Value.ToString()
            ComboBoxTeacherGender.Text = row.Cells("Gender").Value.ToString()

            ' Birthdate (DateTimePicker)
            If Not IsDBNull(row.Cells("Birthdate").Value) Then
                DateTImePickerTeacherBirthdate.Value = CDate(row.Cells("Birth Date").Value)
            End If

            If Not IsDBNull(row.Cells("HireDate").Value) Then
                ManageTeacherHireDate.Text = CDate(row.Cells("HireDate").Value)
            End If

            TextBoxTeacherContactNo.Text = row.Cells("ContactNumber").Value.ToString()
            TextBoxTeacherEmail.Text = row.Cells("Email").Value.ToString()
            txtbxTeacherHouseNo.Text = row.Cells("HouseNumber").Value.ToString()
            txtbxTeacherBarangay.Text = row.Cells("Barangay").Value.ToString()
            txtbxTeacherCity.Text = row.Cells("Municipality").Value.ToString()
            txtbxTeacherProvince.Text = row.Cells("Province").Value.ToString()
            txtbxTeacherCountry.Text = row.Cells("Country").Value.ToString()
            txtbxTeacherZipCode.Text = row.Cells("ZipCode").Value.ToString()
            TextBoxTeacherEducationalAttainment.Text = row.Cells("EducationalAttainment").Value.ToString()
            TextBoxTeacherSpecialization.Text = row.Cells("Specialization").Value.ToString()
            ComboBoxTeacherStatus.Text = row.Cells("Status").Value.ToString()

        End If
    End Sub
    Private Sub txtbxTeacherZipCode_TextChanged(sender As Object, e As EventArgs) Handles txtbxTeacherZipCode.TextChanged

    End Sub

    Private Sub txtbxTeacherZipCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxTeacherZipCode.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub AdminManageTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Initialize Gender ComboBox
        InitializeGenderComboBox()

        ' Load students data
        LoadToDGV("SELECT * FROM student", dgvTeacher)

    End Sub

    Private Sub InitializeGenderComboBox()
        ' Populate Gender dropdown
        ComboBoxTeacherGender.Items.Clear()
        ComboBoxTeacherGender.Items.Add("Male")
        ComboBoxTeacherGender.Items.Add("Female")
    End Sub


End Class


