Imports System.Data.SqlClient
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
        ComboBoxTeacherStatus.Items.Add("Inactive")
        ComboBoxTeacherStatus.Items.Add("On Leave")
        ComboBoxTeacherStatus.Items.Add("Resigned")
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
                            "HouseNumber, Barangay, Municipality, Province, Country, ZipCode" &
                            ") VALUES (" &
                            "@SectionID, @FirstName, @MiddleName, @LastName, @ExtensionName, " &
                            "@Sex, @BirthDate, @Age, @ContactNumber, @Email, " &
                            "@EducationalAttainment, @HireDate, @Specialization, @Status, " &
                            "@HouseNumber, @Barangay, @Municipality, @Province, @Country, @ZipCode)"

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
        ' 1. First Name (Required)
        If String.IsNullOrWhiteSpace(TextBoxTeacherFirstName.Text) Then
            MessageBox.Show("Please enter First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxTeacherFirstName.Focus()
            Return False
        End If

        ' 2. Last Name (Required)
        If String.IsNullOrWhiteSpace(TextBoxTeacherSurname.Text) Then
            MessageBox.Show("Please enter Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxTeacherSurname.Focus()
            Return False
        End If

        ' 3. Gender (Required)
        If ComboBoxTeacherGender.SelectedIndex = -1 Then
            MessageBox.Show("Please select Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBoxTeacherGender.Focus()
            Return False
        End If

        ' 4. Birth Date (Required - validated by control)
        ' 5. Age (Required)
        If String.IsNullOrWhiteSpace(txtbxTeacherAge.Text) Then
            MessageBox.Show("Please enter a valid Age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherAge.Focus()
            Return False
        End If

        ' 6. Contact Number (Required with specific format)
        If String.IsNullOrWhiteSpace(TextBoxTeacherContactNo.Text) Then
            MessageBox.Show("Please enter Contact Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxTeacherContactNo.Focus()
            Return False
        End If

        ' Validate Contact Number format (09XXXXXXXXX - 11 digits)
        Dim contactNumber As String = TextBoxTeacherContactNo.Text.Trim()
        If contactNumber.Length <> 11 Then
            MessageBox.Show("Contact Number must be exactly 11 digits (09XXXXXXXXX).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxTeacherContactNo.Focus()
            Return False
        End If

        If Not contactNumber.StartsWith("09") Then
            MessageBox.Show("Contact Number must start with '09'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxTeacherContactNo.Focus()
            Return False
        End If

        Dim contactNum As Long
        If Not Long.TryParse(contactNumber, contactNum) Then
            MessageBox.Show("Contact Number must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxTeacherContactNo.Focus()
            Return False
        End If

        ' 7. Email (Required and valid format)
        If String.IsNullOrWhiteSpace(TextBoxTeacherEmail.Text) Then
            MessageBox.Show("Please enter Email Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxTeacherEmail.Focus()
            Return False
        End If

        ' Basic email validation
        Dim email As String = TextBoxTeacherEmail.Text.Trim()
        If Not email.Contains("@") OrElse Not email.Contains(".") Then
            MessageBox.Show("Please enter a valid Email Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxTeacherEmail.Focus()
            Return False
        End If

        ' 8. Educational Attainment (Required)
        If String.IsNullOrWhiteSpace(TextBoxTeacherEducationalAttainment.Text) Then
            MessageBox.Show("Please enter Educational Attainment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxTeacherEducationalAttainment.Focus()
            Return False
        End If

        ' 9. Hire Date (Required - validated by control)

        ' 10. Specialization (Required)
        If String.IsNullOrWhiteSpace(TextBoxTeacherSpecialization.Text) Then
            MessageBox.Show("Please enter Specialization.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxTeacherSpecialization.Focus()
            Return False
        End If

        ' 11. Status (Required)
        If ComboBoxTeacherStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBoxTeacherStatus.Focus()
            Return False
        End If

        ' 12. Address validation

        ' House Number (Required and numeric)
        If String.IsNullOrWhiteSpace(txtbxTeacherHouseNo.Text) Then
            MessageBox.Show("Please enter House Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherHouseNo.Focus()
            Return False
        End If

        Dim houseNum As Integer
        If Not Integer.TryParse(txtbxTeacherHouseNo.Text.Trim(), houseNum) Then
            MessageBox.Show("House Number must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherHouseNo.Focus()
            Return False
        End If

        ' Barangay (Required)
        If String.IsNullOrWhiteSpace(txtbxTeacherBarangay.Text) Then
            MessageBox.Show("Please enter Barangay.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherBarangay.Focus()
            Return False
        End If

        ' Municipality/City (Required)
        If String.IsNullOrWhiteSpace(txtbxTeacherCity.Text) Then
            MessageBox.Show("Please enter Municipality/City.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherCity.Focus()
            Return False
        End If

        ' Province (Required)
        If String.IsNullOrWhiteSpace(txtbxTeacherProvince.Text) Then
            MessageBox.Show("Please enter Province.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherProvince.Focus()
            Return False
        End If

        ' Country (Required)
        If String.IsNullOrWhiteSpace(txtbxTeacherCountry.Text) Then
            MessageBox.Show("Please enter Country.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherCountry.Focus()
            Return False
        End If

        ' Zip Code (Required)
        If String.IsNullOrWhiteSpace(txtbxTeacherZipCode.Text) Then
            MessageBox.Show("Please enter Zip Code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherZipCode.Focus()
            Return False
        End If

        ' Validate Zip Code is numeric and has appropriate length
        Dim zipCode As String = txtbxTeacherZipCode.Text.Trim()
        If zipCode.Length <> 4 Then
            MessageBox.Show("Zip Code must be exactly 4 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherZipCode.Focus()
            Return False
        End If

        Dim zipCodeNum As Integer
        If Not Integer.TryParse(zipCode, zipCodeNum) Then
            MessageBox.Show("Zip Code must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxTeacherZipCode.Focus()
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

    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeacher.CellClick
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

End Class