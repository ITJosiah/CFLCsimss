Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class AdminManageTeacher

    Public Property IsEmbedded As Boolean = False

    Private currentTeacherID As Integer = 0

    Private Sub dgvTeacher_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeacher.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTeacher.Rows(e.RowIndex)

            ' Store the Teacher (assuming it's the first column, index 0)
            currentTeacherID = CInt(row.Cells(0).Value)

            TextBoxTeacherFirstName.Text = row.Cells("FirstName").Value.ToString()
            TextBoxTeacherMiddleName.Text = row.Cells("MiddleName").Value.ToString()
            TextBoxTeacherSurname.Text = row.Cells("LastName").Value.ToString()
            TextBoxTeacherExtension.Text = row.Cells("ExtensionName").Value.ToString()
            txtbxTeacherAge.Text = row.Cells("Age").Value.ToString()

            'TextBpxTeacherExtensionName.Text = row.Cells("ExtensionName").Value.ToString()

            ComboBoxTeacherGender.Text = row.Cells("Sex").Value.ToString()

            ' Birthdate (DateTimePicker)
            If Not IsDBNull(row.Cells("Birthdate").Value) Then
                DateTImePickerTeacherBirthdate.Value = CDate(row.Cells("BirthDate").Value)
            End If

            If Not IsDBNull(row.Cells("HireDate").Value) Then
                ManageTeacherHireDate.Text = CDate(row.Cells("HireDate").Value)
            End If

            'Age'

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
            TextBoxTeacherStreet.Text = row.Cells("Street").Value.ToString()

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

        ' Load teacher data
        LoadToDGV("SELECT * FROM teacher", dgvTeacher)

        ' Ensure the grid doesn't auto-select the first row on load
        dgvTeacher.ClearSelection()
        Try
            If dgvTeacher.Rows.Count > 0 AndAlso dgvTeacher.Columns.Count > 0 Then
                dgvTeacher.CurrentCell = Nothing
            End If
        Catch
            ' ignore potential layout timing exceptions
        End Try
        currentTeacherID = 0

    End Sub

    Private Sub InitializeGenderComboBox()
        ' Populate Gender dropdown
        ComboBoxTeacherGender.Items.Clear()
        ComboBoxTeacherGender.Items.Add("Male")
        ComboBoxTeacherGender.Items.Add("Female")
    End Sub

    Private Sub btnTeaUpdate_Click(sender As Object, e As EventArgs) Handles btnTeaUpdate.Click
        UpdateTeacher()
    End Sub

    Private Sub UpdateTeacher()
        If currentTeacherID = 0 Then
            MessageBox.Show("Please select a teacher to update.", "No Teacher Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim query As String = "
            UPDATE teacher SET
                FirstName = @FirstName,
                MiddleName = @MiddleName,
                LastName = @LastName,
                ExtensionName = @ExtensionName,
                Age = @Age,
                Sex = @Sex,
                BirthDate = @BirthDate,
                HireDate = @HireDate,
                ContactNumber = @ContactNumber,
                Email = @Email,
                HouseNumber = @HouseNumber,
                Street = @Street,
                Barangay = @Barangay,
                Municipality = @Municipality,
                Province = @Province,
                Country = @Country,
                ZipCode = @ZipCode,
                EducationalAttainment = @EducationalAttainment,
                Specialization = @Specialization,
                Status = @Status
            WHERE TeacherID = @TeacherID
        "

            Dim con As New MySqlConnection("server=192.168.1.30;user=jeje;password=password;database=cflc_db;")
            Using cmd As New MySqlCommand(query, con)
                ' Add parameters
                cmd.Parameters.AddWithValue("@TeacherID", currentTeacherID)
                cmd.Parameters.AddWithValue("@FirstName", TextBoxTeacherFirstName.Text)
                cmd.Parameters.AddWithValue("@MiddleName", TextBoxTeacherMiddleName.Text)
                cmd.Parameters.AddWithValue("@LastName", TextBoxTeacherSurname.Text)
                cmd.Parameters.AddWithValue("@ExtensionName", TextBoxTeacherExtension.Text)
                cmd.Parameters.AddWithValue("@Sex", ComboBoxTeacherGender.Text)
                cmd.Parameters.AddWithValue("@BirthDate", DateTImePickerTeacherBirthdate.Value)
                cmd.Parameters.AddWithValue("@Age", txtbxTeacherAge.Text)
                cmd.Parameters.AddWithValue("@HireDate", ManageTeacherHireDate.Value)
                cmd.Parameters.AddWithValue("@ContactNumber", TextBoxTeacherContactNo.Text)
                cmd.Parameters.AddWithValue("@Email", TextBoxTeacherEmail.Text)
                cmd.Parameters.AddWithValue("@HouseNumber", txtbxTeacherHouseNo.Text)
                cmd.Parameters.AddWithValue("@Street", TextBoxTeacherStreet.Text)
                cmd.Parameters.AddWithValue("@Barangay", txtbxTeacherBarangay.Text)
                cmd.Parameters.AddWithValue("@Municipality", txtbxTeacherCity.Text)
                cmd.Parameters.AddWithValue("@Province", txtbxTeacherProvince.Text)
                cmd.Parameters.AddWithValue("@Country", txtbxTeacherCountry.Text)
                cmd.Parameters.AddWithValue("@ZipCode", txtbxTeacherZipCode.Text)
                cmd.Parameters.AddWithValue("@EducationalAttainment", TextBoxTeacherEducationalAttainment.Text)
                cmd.Parameters.AddWithValue("@Specialization", TextBoxTeacherSpecialization.Text)
                cmd.Parameters.AddWithValue("@Status", ComboBoxTeacherStatus.Text)

                con.Open()
                cmd.ExecuteNonQuery()

            End Using

            MessageBox.Show("Teacher information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh DataGridView
            LoadToDGV("SELECT * FROM teacher", dgvTeacher)

        Catch ex As Exception
            MessageBox.Show("Update failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint

    End Sub

    ' Ensure selection is cleared after any data binding operation
    Private Sub dgvTeacher_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvTeacher.DataBindingComplete
        dgvTeacher.ClearSelection()
        Try
            If dgvTeacher.Rows.Count > 0 AndAlso dgvTeacher.Columns.Count > 0 Then
                dgvTeacher.CurrentCell = Nothing
            End If
        Catch
            ' ignore - layout timing may prevent clearing CurrentCell
        End Try
    End Sub

    ' Final fallback after form is shown
    Private Sub AdminManageTeacher_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dgvTeacher.ClearSelection()
        Try
            If dgvTeacher.Rows.Count > 0 AndAlso dgvTeacher.Columns.Count > 0 Then
                dgvTeacher.CurrentCell = Nothing
            End If
        Catch
        End Try

        ' Move focus to first input so the grid doesn't appear focused
        TextBoxTeacherFirstName.Focus()
    End Sub


    Private Sub btnTeacherDelete_Click(sender As Object, e As EventArgs) Handles btnTeaDelete.Click
        ' Check if a teacher is selected
        If currentTeacherID = 0 Then
            MsgBox("Please select a teacher to delete.", MsgBoxStyle.Exclamation, "Delete Teacher")
            Return
        End If

        ' Confirm deletion
        If MessageBox.Show("Are you sure you want to delete this teacher?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Try
            ' Open database connection
            modDBx.openConn(modDBx.db_name)

            ' Prepare the DELETE SQL statement
            Dim sql As String = "DELETE FROM teacher WHERE TeacherID = @TeacherID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@TeacherID", currentTeacherID)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Teacher deleted successfully.", MsgBoxStyle.Information, "Delete Success")
                    ' Refresh the DataGridView
                    LoadToDGV("SELECT * FROM teacher", dgvTeacher)
                    ' Reset current selection and clear input fields
                    currentTeacherID = 0
                    ClearInputFIelds()

                Else
                    MsgBox("No teacher was deleted. Please check your selection.", MsgBoxStyle.Exclamation, "Delete Failed")
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error deleting teacher: " & ex.Message, MsgBoxStyle.Critical, "Delete Error")
        Finally
            ' Close connection safely
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub ClearInputFIelds()
        TextBoxTeacherFirstName.Clear()
        TextBoxTeacherMiddleName.Clear()
        TextBoxTeacherSurname.Clear()
        TextBoxTeacherExtension.Clear()
        txtbxTeacherAge.Clear()
        ComboBoxTeacherGender.SelectedIndex = -1
        DateTImePickerTeacherBirthdate.Value = DateTime.Now
        ManageTeacherHireDate.Value = DateTime.Now
        TextBoxTeacherContactNo.Clear()
        TextBoxTeacherEmail.Clear()
        txtbxTeacherHouseNo.Clear()
        txtbxTeacherBarangay.Clear()
        txtbxTeacherCity.Clear()
        txtbxTeacherProvince.Clear()
        txtbxTeacherCountry.Clear()
        txtbxTeacherZipCode.Clear()
        TextBoxTeacherEducationalAttainment.Clear()
        TextBoxTeacherSpecialization.Clear()
        ComboBoxTeacherStatus.SelectedIndex = -1

        ' Clear address fields
        txtbxTeacherHouseNo.Clear()
        TextBoxTeacherStreet.Clear()
        txtbxTeacherBarangay.Clear()
        txtbxTeacherCity.Clear()
        txtbxTeacherProvince.Clear()
        txtbxTeacherCountry.Clear()
        txtbxTeacherZipCode.Clear()
    End Sub

    Private Sub SearchTeachersBySurname(ByVal surname As String)
        ' If the search box is empty, load all teachers (default view)
        If String.IsNullOrWhiteSpace(surname) Then
            LoadToDGV("SELECT * FROM teacher", dgvTeacher)
            Return
        End If

        Try
            ' Open Connection
            modDBx.openConn(modDBx.db_name)

            ' Use prefix match so search is from the first letter to the last (incremental per-letter filter)
            Dim sql As String = "SELECT * FROM teacher WHERE LastName LIKE @searchSurname ORDER BY LastName"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                ' Use surname + '%' to match only names that start with the typed letters
                cmd.Parameters.AddWithValue("@searchSurname", surname.Trim() & "%")

                Dim dt As New System.Data.DataTable
                Using adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                dgvTeacher.DataSource = dt
                dgvTeacher.Refresh()

                If dgvTeacher.ColumnCount > 0 Then
                    dgvTeacher.Columns(0).Visible = False ' Hide TeacherID column
                End If

                If dt.Rows.Count = 0 Then
                    MsgBox("No teacher found matching the surname '" & surname & "'.", MsgBoxStyle.Information, "Search Result")
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error searching teachers: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = System.Data.ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub TextBoxTeacherSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTeacherSearch.TextChanged
        SearchTeachersBySurname(TextBoxTeacherSearch.Text)
    End Sub
End Class


