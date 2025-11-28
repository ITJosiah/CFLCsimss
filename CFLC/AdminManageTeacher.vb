Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class AdminManageTeacher
    Public Property IsEmbedded As Boolean = False
    Private currentTeacherID As Integer = 0

    Private Sub AdminManageTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        End If

        ' Initialize Gender ComboBox
        InitializeGenderComboBox()

        ' Initialize Status ComboBox
        InitializeStatusComboBox()

        ' Load teachers data
        LoadToDGV("SELECT * FROM teacher", dgvTeacher)

        ' Set Age as readonly (auto-calculated)
        txtbxTeacherAge.ReadOnly = True

        ' Ensure Add button is enabled by default
        btnTeaAdd.Enabled = True

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

    Private Sub InitializeStatusComboBox()
        ' Populate Status dropdown
        ComboBoxTeacherStatus.Items.Clear()
        ComboBoxTeacherStatus.Items.Add("Active")
        ComboBoxTeacherStatus.Items.Add("On Leave")
        ComboBoxTeacherStatus.Items.Add("Resigned")
        ComboBoxTeacherStatus.Items.Add("Retired")

    End Sub

    Private Sub btnTeaAdd_Click(sender As Object, e As EventArgs) Handles btnTeaAdd.Click
        ' If a row is currently selected, prevent adding and show error
        If currentTeacherID <> 0 Then
            MessageBox.Show("Please clear the selection before adding a new teacher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate required fields FIRST
        If Not ValidateInputs() Then
            Return ' Stop execution if validation fails
        End If

        ' Add teacher to database
        Try
            ' Note: TeacherID should be auto-increment, so we don't include it in the INSERT
            ' SectionID is set to 0 initially (teacher not assigned to section yet)
            Dim query As String = "INSERT INTO teacher (" &
                            "SectionID, FirstName, MiddleName, LastName, ExtensionName, " &
                            "Sex, BirthDate, Age, ContactNumber, Email, " &
                            "EducationalAttainment, HireDate, Specialization, Status, " &
                            "HouseNumber, Street, Barangay, Municipality, Province, Country, ZipCode" &
                            ") VALUES (" &
                            "@SectionID, @FirstName, @MiddleName, @LastName, @ExtensionName, " &
                            "@Sex, @BirthDate, @Age, @ContactNumber, @Email, " &
                            "@EducationalAttainment, @HireDate, @Specialization, @Status, " &
                            "@HouseNumber, @Street, @Barangay, @Municipality, @Province, @Country, @ZipCode)"

            modDBx.openConn(modDBx.db_name)

            Using cmd As New MySqlCommand(query, modDBx.conn)
                ' SectionID - set to 0 (teacher not assigned yet)
                cmd.Parameters.AddWithValue("@SectionID", 0)

                ' Personal Information - Convert to Proper Case
                cmd.Parameters.AddWithValue("@FirstName", ConvertToProperCase(SafeString(TextBoxTeacherFirstName.Text)))
                cmd.Parameters.AddWithValue("@MiddleName", ConvertToProperCase(SafeString(TextBoxTeacherMiddleName.Text)))
                cmd.Parameters.AddWithValue("@LastName", ConvertToProperCase(SafeString(TextBoxTeacherSurname.Text)))
                cmd.Parameters.AddWithValue("@ExtensionName", ConvertToProperCase(SafeString(TextBoxTeacherExtension.Text)))

                Dim gender As String = ""
                If ComboBoxTeacherGender.SelectedItem IsNot Nothing Then
                    gender = ComboBoxTeacherGender.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Sex", gender)

                cmd.Parameters.AddWithValue("@BirthDate", DateTImePickerTeacherBirthdate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@Age", txtbxTeacherAge.Text)

                ' Contact Information
                cmd.Parameters.AddWithValue("@ContactNumber", SafeString(TextBoxTeacherContactNo.Text))
                cmd.Parameters.AddWithValue("@Email", SafeString(TextBoxTeacherEmail.Text))

                ' Professional Information - Convert to Proper Case
                cmd.Parameters.AddWithValue("@EducationalAttainment", ConvertToProperCase(SafeString(TextBoxTeacherEducationalAttainment.Text)))
                cmd.Parameters.AddWithValue("@HireDate", ManageTeacherHireDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@Specialization", ConvertToProperCase(SafeString(TextBoxTeacherSpecialization.Text)))

                Dim status As String = ""
                If ComboBoxTeacherStatus.SelectedItem IsNot Nothing Then
                    status = ComboBoxTeacherStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Status", status)

                ' Address Information - Convert to Proper Case
                cmd.Parameters.AddWithValue("@HouseNumber", SafeString(txtbxTeacherHouseNo.Text))
                cmd.Parameters.AddWithValue("@Street", ConvertToProperCase(SafeString(TextBoxTeacherStreet.Text)))
                cmd.Parameters.AddWithValue("@Barangay", ConvertToProperCase(SafeString(txtbxTeacherBarangay.Text)))
                cmd.Parameters.AddWithValue("@Municipality", ConvertToProperCase(SafeString(txtbxTeacherCity.Text)))
                cmd.Parameters.AddWithValue("@Province", ConvertToProperCase(SafeString(txtbxTeacherProvince.Text)))
                cmd.Parameters.AddWithValue("@Country", ConvertToProperCase(SafeString(txtbxTeacherCountry.Text)))
                cmd.Parameters.AddWithValue("@ZipCode", SafeString(txtbxTeacherZipCode.Text))

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Teacher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInputFields()
                    LoadToDGV("SELECT * FROM teacher", dgvTeacher)
                Else
                    MessageBox.Show("Failed to add teacher. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnTeaDelete_Click(sender As Object, e As EventArgs) Handles btnTeaDelete.Click
        ' Check if a teacher is selected
        If currentTeacherID = 0 Then
            MessageBox.Show("Please select a teacher to delete.", "Delete Teacher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                    MessageBox.Show("Teacher deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Refresh the DataGridView
                    LoadToDGV("SELECT * FROM teacher", dgvTeacher)
                    ' Reset current selection and clear input fields
                    currentTeacherID = 0
                    ClearInputFields()
                Else
                    MessageBox.Show("No teacher was deleted. Please check your selection.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error deleting teacher: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection safely
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnTeaUpdate_Click(sender As Object, e As EventArgs) Handles btnTeaUpdate.Click
        UpdateTeacher()
    End Sub

    Private Sub UpdateTeacher()
        ' Check if a teacher is selected
        If currentTeacherID = 0 Then
            MessageBox.Show("No teacher selected for update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Validate required fields FIRST using the same validation as Add
        If Not ValidateInputs() Then
            Return ' Stop execution if validation fails
        End If

        ' Check if any data has actually changed
        If Not HasTeacherDataChanged() Then
            MessageBox.Show("No changes were made to the teacher data.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            modDBx.openConn(modDBx.db_name)

            Dim sql As String = "UPDATE teacher SET " &
                "FirstName = @FirstName, " &
                "MiddleName = @MiddleName, " &
                "LastName = @LastName, " &
                "ExtensionName = @ExtensionName, " &
                "Sex = @Sex, " &
                "BirthDate = @BirthDate, " &
                "Age = @Age, " &
                "ContactNumber = @ContactNumber, " &
                "Email = @Email, " &
                "EducationalAttainment = @EducationalAttainment, " &
                "HireDate = @HireDate, " &
                "Specialization = @Specialization, " &
                "Status = @Status, " &
                "HouseNumber = @HouseNumber, " &
                "Street = @Street, " &
                "Barangay = @Barangay, " &
                "Municipality = @Municipality, " &
                "Province = @Province, " &
                "Country = @Country, " &
                "ZipCode = @ZipCode " &
                "WHERE TeacherID = @TeacherID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                ' Personal Information - Convert to Proper Case
                cmd.Parameters.AddWithValue("@FirstName", ConvertToProperCase(SafeString(TextBoxTeacherFirstName.Text)))
                cmd.Parameters.AddWithValue("@MiddleName", If(String.IsNullOrWhiteSpace(TextBoxTeacherMiddleName.Text), DBNull.Value, ConvertToProperCase(TextBoxTeacherMiddleName.Text.Trim())))
                cmd.Parameters.AddWithValue("@LastName", ConvertToProperCase(SafeString(TextBoxTeacherSurname.Text)))
                cmd.Parameters.AddWithValue("@ExtensionName", If(String.IsNullOrWhiteSpace(TextBoxTeacherExtension.Text), DBNull.Value, ConvertToProperCase(TextBoxTeacherExtension.Text.Trim())))

                Dim gender As String = ""
                If ComboBoxTeacherGender.SelectedItem IsNot Nothing Then
                    gender = ComboBoxTeacherGender.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Sex", gender)

                cmd.Parameters.AddWithValue("@BirthDate", DateTImePickerTeacherBirthdate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@Age", txtbxTeacherAge.Text)

                ' Contact Information
                cmd.Parameters.AddWithValue("@ContactNumber", SafeString(TextBoxTeacherContactNo.Text))
                cmd.Parameters.AddWithValue("@Email", SafeString(TextBoxTeacherEmail.Text))

                ' Professional Information - Convert to Proper Case
                cmd.Parameters.AddWithValue("@EducationalAttainment", ConvertToProperCase(SafeString(TextBoxTeacherEducationalAttainment.Text)))
                cmd.Parameters.AddWithValue("@HireDate", ManageTeacherHireDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@Specialization", ConvertToProperCase(SafeString(TextBoxTeacherSpecialization.Text)))

                Dim status As String = ""
                If ComboBoxTeacherStatus.SelectedItem IsNot Nothing Then
                    status = ComboBoxTeacherStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Status", status)

                ' Address Information - Convert to Proper Case
                cmd.Parameters.AddWithValue("@HouseNumber", SafeString(txtbxTeacherHouseNo.Text))
                cmd.Parameters.AddWithValue("@Street", ConvertToProperCase(SafeString(TextBoxTeacherStreet.Text)))
                cmd.Parameters.AddWithValue("@Barangay", ConvertToProperCase(SafeString(txtbxTeacherBarangay.Text)))
                cmd.Parameters.AddWithValue("@Municipality", ConvertToProperCase(SafeString(txtbxTeacherCity.Text)))
                cmd.Parameters.AddWithValue("@Province", ConvertToProperCase(SafeString(txtbxTeacherProvince.Text)))
                cmd.Parameters.AddWithValue("@Country", ConvertToProperCase(SafeString(txtbxTeacherCountry.Text)))
                cmd.Parameters.AddWithValue("@ZipCode", SafeString(txtbxTeacherZipCode.Text))

                cmd.Parameters.AddWithValue("@TeacherID", currentTeacherID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Teacher updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Clear inputs and re-enable Add after successful update
                    ClearInputFields()
                    LoadToDGV("SELECT * FROM teacher", dgvTeacher)
                    currentTeacherID = 0
                Else
                    MessageBox.Show("No teacher was updated. Please check the data.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error updating teacher: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' Add this function to check if any data has changed
    Private Function HasTeacherDataChanged() As Boolean
        ' Get the current teacher data from database to compare
        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT * FROM teacher WHERE TeacherID = @TeacherID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@TeacherID", currentTeacherID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Compare each field with current form values
                        If GetSafeStringFromDB(reader("FirstName")) <> TextBoxTeacherFirstName.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("MiddleName")) <> If(String.IsNullOrWhiteSpace(TextBoxTeacherMiddleName.Text), "", TextBoxTeacherMiddleName.Text.Trim()) Then Return True
                        If GetSafeStringFromDB(reader("LastName")) <> TextBoxTeacherSurname.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("ExtensionName")) <> If(String.IsNullOrWhiteSpace(TextBoxTeacherExtension.Text), "", TextBoxTeacherExtension.Text.Trim()) Then Return True
                        If GetSafeStringFromDB(reader("Sex")) <> ComboBoxTeacherGender.Text.Trim() Then Return True
                        If CDate(reader("BirthDate")).Date <> DateTImePickerTeacherBirthdate.Value.Date Then Return True
                        If GetSafeStringFromDB(reader("Age")) <> txtbxTeacherAge.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("ContactNumber")) <> TextBoxTeacherContactNo.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Email")) <> TextBoxTeacherEmail.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("EducationalAttainment")) <> TextBoxTeacherEducationalAttainment.Text.Trim() Then Return True
                        If CDate(reader("HireDate")).Date <> ManageTeacherHireDate.Value.Date Then Return True
                        If GetSafeStringFromDB(reader("Specialization")) <> TextBoxTeacherSpecialization.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Status")) <> ComboBoxTeacherStatus.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("HouseNumber")) <> txtbxTeacherHouseNo.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Street")) <> TextBoxTeacherStreet.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Barangay")) <> txtbxTeacherBarangay.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Municipality")) <> txtbxTeacherCity.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Province")) <> txtbxTeacherProvince.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Country")) <> txtbxTeacherCountry.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("ZipCode")) <> txtbxTeacherZipCode.Text.Trim() Then Return True
                    End If
                End Using
            End Using

            Return False ' No changes detected

        Catch ex As Exception
            ' If we can't check for changes, assume there are changes to be safe
            Return True
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    ' Helper function for safe string retrieval from database
    Private Function GetSafeStringFromDB(dbValue As Object) As String
        Return If(dbValue Is Nothing OrElse IsDBNull(dbValue), "", dbValue.ToString())
    End Function

    Private Function ValidateInputs() As Boolean
        Dim errors As New List(Of String)

        ' 1. Personal Information Validation
        If String.IsNullOrWhiteSpace(TextBoxTeacherFirstName.Text) Then
            errors.Add("• First Name is required")
        End If

        If String.IsNullOrWhiteSpace(TextBoxTeacherSurname.Text) Then
            errors.Add("• Last Name is required")
        End If

        If ComboBoxTeacherGender.SelectedIndex = -1 Then
            errors.Add("• Sex is required")
        End If

        If String.IsNullOrWhiteSpace(txtbxTeacherAge.Text) Then
            errors.Add("• Age is required")
        End If

        ' 2. Contact Information Validation
        Dim contactNumber As String = TextBoxTeacherContactNo.Text.Trim()
        If String.IsNullOrWhiteSpace(contactNumber) Then
            errors.Add("• Contact Number is required")
        Else
            If contactNumber.Length <> 11 Then
                errors.Add("• Contact Number must be exactly 11 digits (09XXXXXXXXX)")
            ElseIf Not contactNumber.StartsWith("09") Then
                errors.Add("• Contact Number must start with '09'")
            ElseIf Not Long.TryParse(contactNumber, Nothing) Then
                errors.Add("• Contact Number must contain only numbers")
            End If
        End If

        Dim email As String = TextBoxTeacherEmail.Text.Trim()
        If String.IsNullOrWhiteSpace(email) Then
            errors.Add("• Email Address is required")
        ElseIf Not email.Contains("@") OrElse Not email.Contains(".") Then
            errors.Add("• Please enter a valid Email Address")
        End If

        ' 3. Professional Information Validation
        If String.IsNullOrWhiteSpace(TextBoxTeacherEducationalAttainment.Text) Then
            errors.Add("• Educational Attainment is required")
        End If

        If String.IsNullOrWhiteSpace(TextBoxTeacherSpecialization.Text) Then
            errors.Add("• Specialization is required")
        End If

        If ComboBoxTeacherStatus.SelectedIndex = -1 Then
            errors.Add("• Status is required")
        End If

        ' 4. Address Information Validation
        Dim houseNumber As String = txtbxTeacherHouseNo.Text.Trim()
        If String.IsNullOrWhiteSpace(houseNumber) Then
            errors.Add("• House Number is required")
        ElseIf Not Integer.TryParse(houseNumber, Nothing) Then
            errors.Add("• House Number must contain only numbers")
        End If

        If String.IsNullOrWhiteSpace(TextBoxTeacherStreet.Text) Then
            errors.Add("• Street is required")
        End If

        If String.IsNullOrWhiteSpace(txtbxTeacherBarangay.Text) Then
            errors.Add("• Barangay is required")
        End If

        If String.IsNullOrWhiteSpace(txtbxTeacherCity.Text) Then
            errors.Add("• Municipality/City is required")
        End If

        If String.IsNullOrWhiteSpace(txtbxTeacherProvince.Text) Then
            errors.Add("• Province is required")
        End If

        If String.IsNullOrWhiteSpace(txtbxTeacherCountry.Text) Then
            errors.Add("• Country is required")
        End If

        Dim zipCode As String = txtbxTeacherZipCode.Text.Trim()
        If String.IsNullOrWhiteSpace(zipCode) Then
            errors.Add("• Zip Code is required")
        Else
            If zipCode.Length <> 4 Then
                errors.Add("• Zip Code must be exactly 4 digits")
            ElseIf Not Integer.TryParse(zipCode, Nothing) Then
                errors.Add("• Zip Code must contain only numbers")
            End If
        End If

        ' 5. Check if there are any validation errors
        If errors.Count > 0 Then
            Dim errorMessage As New StringBuilder()
            errorMessage.AppendLine("Please fix the following errors before proceeding:")
            errorMessage.AppendLine()

            For Each [error] As String In errors
                errorMessage.AppendLine([error])
            Next

            MessageBox.Show(errorMessage.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function ConvertToProperCase(text As String) As String
        If String.IsNullOrWhiteSpace(text) Then
            Return text
        End If

        ' Convert to proper case (first letter uppercase, rest lowercase)
        Dim culture As New System.Globalization.CultureInfo("en-US")
        Dim textInfo As System.Globalization.TextInfo = culture.TextInfo

        Return textInfo.ToTitleCase(text.ToLower())
    End Function

    ' Helper function to safely handle string values
    Private Function SafeString(value As String) As String
        Return If(String.IsNullOrWhiteSpace(value), "", value.Trim().Replace("'", "''"))
    End Function

    Private Sub ClearInputFields()
        ' Clear all input fields after successful add or when un-selecting a row

        ' Personal Information
        TextBoxTeacherFirstName.Clear()
        TextBoxTeacherMiddleName.Clear()
        TextBoxTeacherSurname.Clear()
        TextBoxTeacherExtension.Clear()
        ComboBoxTeacherGender.SelectedIndex = -1
        DateTImePickerTeacherBirthdate.Value = DateTime.Now
        txtbxTeacherAge.Clear()

        ' Contact Information
        TextBoxTeacherContactNo.Clear()
        TextBoxTeacherEmail.Clear()

        ' Professional Information
        TextBoxTeacherEducationalAttainment.Clear()
        ManageTeacherHireDate.Value = DateTime.Now
        TextBoxTeacherSpecialization.Clear()
        ComboBoxTeacherStatus.SelectedIndex = -1

        ' Address fields
        txtbxTeacherHouseNo.Clear()
        TextBoxTeacherStreet.Clear()
        txtbxTeacherBarangay.Clear()
        txtbxTeacherCity.Clear()
        txtbxTeacherProvince.Clear()
        txtbxTeacherCountry.Clear()
        txtbxTeacherZipCode.Clear()

        ' Reset current teacher selection
        currentTeacherID = 0

        ' Re-enable Add button so user can create a new record
        btnTeaAdd.Enabled = True

        ' Set focus back to first field
        TextBoxTeacherFirstName.Focus()
    End Sub

    ' Auto-calculate age when birthdate changes
    Private Sub DateTImePickerTeacherBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles DateTImePickerTeacherBirthdate.ValueChanged
        Dim birthDate As Date = DateTImePickerTeacherBirthdate.Value
        Dim today As Date = Date.Today

        Dim age As Integer = today.Year - birthDate.Year

        ' Adjust if birthday hasn't happened yet this year
        If birthDate > today.AddYears(-age) Then
            age -= 1
        End If

        txtbxTeacherAge.Text = age.ToString()
    End Sub

    ' Prevent manual editing of age textbox
    Private Sub txtbxTeacherAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxTeacherAge.KeyPress
        e.Handled = True ' Block typing
    End Sub

    Private Sub txtbxTeacherAge_TextChanged(sender As Object, e As EventArgs) Handles txtbxTeacherAge.TextChanged
        ' Prevent manual edits from breaking the value
        If Not txtbxTeacherAge.ReadOnly Then
            txtbxTeacherAge.ReadOnly = True
        End If
    End Sub

    ' Apply Proper Case when leaving text fields
    Private Sub TextBoxTeacherFirstName_Leave(sender As Object, e As EventArgs) Handles TextBoxTeacherFirstName.Leave
        If Not String.IsNullOrWhiteSpace(TextBoxTeacherFirstName.Text) Then
            TextBoxTeacherFirstName.Text = ConvertToProperCase(TextBoxTeacherFirstName.Text.Trim())
        End If
    End Sub

    Private Sub TextBoxTeacherMiddleName_Leave(sender As Object, e As EventArgs) Handles TextBoxTeacherMiddleName.Leave
        If Not String.IsNullOrWhiteSpace(TextBoxTeacherMiddleName.Text) Then
            TextBoxTeacherMiddleName.Text = ConvertToProperCase(TextBoxTeacherMiddleName.Text.Trim())
        End If
    End Sub

    Private Sub TextBoxTeacherSurname_Leave(sender As Object, e As EventArgs) Handles TextBoxTeacherSurname.Leave
        If Not String.IsNullOrWhiteSpace(TextBoxTeacherSurname.Text) Then
            TextBoxTeacherSurname.Text = ConvertToProperCase(TextBoxTeacherSurname.Text.Trim())
        End If
    End Sub

    Private Sub TextBoxTeacherExtension_Leave(sender As Object, e As EventArgs) Handles TextBoxTeacherExtension.Leave
        If Not String.IsNullOrWhiteSpace(TextBoxTeacherExtension.Text) Then
            TextBoxTeacherExtension.Text = ConvertToProperCase(TextBoxTeacherExtension.Text.Trim())
        End If
    End Sub

    Private Sub TextBoxTeacherEducationalAttainment_Leave(sender As Object, e As EventArgs) Handles TextBoxTeacherEducationalAttainment.Leave
        If Not String.IsNullOrWhiteSpace(TextBoxTeacherEducationalAttainment.Text) Then
            TextBoxTeacherEducationalAttainment.Text = ConvertToProperCase(TextBoxTeacherEducationalAttainment.Text.Trim())
        End If
    End Sub

    Private Sub TextBoxTeacherSpecialization_Leave(sender As Object, e As EventArgs) Handles TextBoxTeacherSpecialization.Leave
        If Not String.IsNullOrWhiteSpace(TextBoxTeacherSpecialization.Text) Then
            TextBoxTeacherSpecialization.Text = ConvertToProperCase(TextBoxTeacherSpecialization.Text.Trim())
        End If
    End Sub

    Private Sub TextBoxTeacherStreet_Leave(sender As Object, e As EventArgs) Handles TextBoxTeacherStreet.Leave
        If Not String.IsNullOrWhiteSpace(TextBoxTeacherStreet.Text) Then
            TextBoxTeacherStreet.Text = ConvertToProperCase(TextBoxTeacherStreet.Text.Trim())
        End If
    End Sub

    Private Sub txtbxTeacherBarangay_Leave(sender As Object, e As EventArgs) Handles txtbxTeacherBarangay.Leave
        If Not String.IsNullOrWhiteSpace(txtbxTeacherBarangay.Text) Then
            txtbxTeacherBarangay.Text = ConvertToProperCase(txtbxTeacherBarangay.Text.Trim())
        End If
    End Sub

    Private Sub txtbxTeacherCity_Leave(sender As Object, e As EventArgs) Handles txtbxTeacherCity.Leave
        If Not String.IsNullOrWhiteSpace(txtbxTeacherCity.Text) Then
            txtbxTeacherCity.Text = ConvertToProperCase(txtbxTeacherCity.Text.Trim())
        End If
    End Sub

    Private Sub txtbxTeacherProvince_Leave(sender As Object, e As EventArgs) Handles txtbxTeacherProvince.Leave
        If Not String.IsNullOrWhiteSpace(txtbxTeacherProvince.Text) Then
            txtbxTeacherProvince.Text = ConvertToProperCase(txtbxTeacherProvince.Text.Trim())
        End If
    End Sub

    Private Sub txtbxTeacherCountry_Leave(sender As Object, e As EventArgs) Handles txtbxTeacherCountry.Leave
        If Not String.IsNullOrWhiteSpace(txtbxTeacherCountry.Text) Then
            txtbxTeacherCountry.Text = ConvertToProperCase(txtbxTeacherCountry.Text.Trim())
        End If
    End Sub

    Private Sub dgvTeacher_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeacher.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvTeacher.Rows(e.RowIndex)

        ' Safely read the TeacherID in the clicked row
        Dim clickedID As Integer = 0
        If row.Cells.Count > 0 AndAlso row.Cells(0).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(0).Value) Then
            Integer.TryParse(row.Cells(0).Value.ToString(), clickedID)
        End If

        ' If the user clicked the already-selected row, clear selection and inputs
        If clickedID <> 0 AndAlso clickedID = currentTeacherID Then
            dgvTeacher.ClearSelection()
            currentTeacherID = 0
            ClearInputFields()
            Return
        End If

        ' Otherwise populate fields for the newly selected row
        If clickedID <> 0 Then
            currentTeacherID = clickedID

            TextBoxTeacherFirstName.Text = GetSafeString(row.Cells("FirstName"))
            TextBoxTeacherMiddleName.Text = GetSafeString(row.Cells("MiddleName"))
            TextBoxTeacherSurname.Text = GetSafeString(row.Cells("LastName"))
            TextBoxTeacherExtension.Text = GetSafeString(row.Cells("ExtensionName"))
            ComboBoxTeacherGender.Text = GetSafeString(row.Cells("Sex"))

            If Not IsDBNull(row.Cells("BirthDate").Value) Then
                DateTImePickerTeacherBirthdate.Value = CDate(row.Cells("BirthDate").Value)
            End If

            If Not IsDBNull(row.Cells("Age").Value) Then
                txtbxTeacherAge.Text = row.Cells("Age").Value.ToString()
            End If

            TextBoxTeacherContactNo.Text = GetSafeString(row.Cells("ContactNumber"))
            TextBoxTeacherEmail.Text = GetSafeString(row.Cells("Email"))
            TextBoxTeacherEducationalAttainment.Text = GetSafeString(row.Cells("EducationalAttainment"))

            If Not IsDBNull(row.Cells("HireDate").Value) Then
                ManageTeacherHireDate.Value = CDate(row.Cells("HireDate").Value)
            End If

            TextBoxTeacherSpecialization.Text = GetSafeString(row.Cells("Specialization"))
            ComboBoxTeacherStatus.Text = GetSafeString(row.Cells("Status"))

            ' Address fields
            txtbxTeacherHouseNo.Text = GetSafeString(row.Cells("HouseNumber"))
            TextBoxTeacherStreet.Text = GetSafeString(row.Cells("Street"))
            txtbxTeacherBarangay.Text = GetSafeString(row.Cells("Barangay"))
            txtbxTeacherCity.Text = GetSafeString(row.Cells("Municipality"))
            txtbxTeacherProvince.Text = GetSafeString(row.Cells("Province"))
            txtbxTeacherCountry.Text = GetSafeString(row.Cells("Country"))
            txtbxTeacherZipCode.Text = GetSafeString(row.Cells("ZipCode"))

            ' Keep Add button enabled
            btnTeaAdd.Enabled = True
        End If
    End Sub

    ' Helper function for safe string retrieval from DataGridView
    Private Function GetSafeString(cell As DataGridViewCell) As String
        Return If(cell.Value Is Nothing OrElse IsDBNull(cell.Value), "", cell.Value.ToString())
    End Function

    Private Sub txtbxTeacherZipCode_TextChanged(sender As Object, e As EventArgs) Handles txtbxTeacherZipCode.TextChanged
    End Sub

    Private Sub txtbxTeacherZipCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxTeacherZipCode.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint
        ' Painting code if needed
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

    ' Allow typing "f" into the search TextBox while preventing the parent/dashboard full-screen handler.
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Check only the key code (ignore modifiers in comparison)
        If (keyData And Keys.KeyCode) = Keys.F AndAlso TextBoxTeacherSearch IsNot Nothing AndAlso TextBoxTeacherSearch.Focused Then
            ' Insert the character into the textbox manually (preserve selection/replacement).
            Dim tb = TextBoxTeacherSearch
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

                ' Ensure StudentID (or any ID-like column) remains visible and is placed first.
                For Each col As DataGridViewColumn In dgvTeacher.Columns
                    Dim propName As String = If(col.DataPropertyName, "").ToLower()
                    Dim header As String = If(col.HeaderText, "").ToLower()
                    If propName.Contains("teacherid") OrElse propName = "teacherid" OrElse header.Contains("teacherid") OrElse header = "teacherid" Then
                        col.Visible = True
                        col.DisplayIndex = 0
                        Exit For
                    End If
                Next

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("No teacher found matching the surname '" & surname & "'.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching teachers: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


