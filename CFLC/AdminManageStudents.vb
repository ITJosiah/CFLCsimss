Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class AdminManageStudents

    Private currentStudentID As Integer = 0

    Public Property IsEmbedded As Boolean = False

    Private Sub AdminManageStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            StyleSidebarButtons()
            PositionSidebarButtons()
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Else
            pnlSidebar.Visible = False
            pnlContent.Dock = DockStyle.Fill
        End If

        ' Initialize Gender ComboBox
        InitializeGenderComboBox()

        ' Initialize radio buttons
        InitializeRadioButtons()

        ' Load students data
        LoadToDGV("SELECT * FROM student", dgvStudents)

        txtbxStudentAge.ReadOnly = True
    End Sub

    Private Sub InitializeRadioButtons()
        ' Set default values for radio buttons
        RadioButtonStudentIPNO.Checked = True
        RadioButtonStudent4PNO.Checked = True

        ' Disable Indigineous group textbox by default
        txtbbxStudentIPGroup.Enabled = False
        txtbx4ps.Enabled = False
    End Sub

    Private Sub InitializeGenderComboBox()
        ' Populate Gender dropdown
        cmbStudenttGender.Items.Clear()
        cmbStudenttGender.Items.Add("Male")
        cmbStudenttGender.Items.Add("Female")
    End Sub

    ' Handle Indigineous radio button changes
    Private Sub RadioButtonStudentIPYES_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonStudentIPYES.CheckedChanged
        txtbbxStudentIPGroup.Enabled = RadioButtonStudentIPYES.Checked
        If Not RadioButtonStudentIPYES.Checked Then
            txtbbxStudentIPGroup.Clear()
        End If
    End Sub

    Private Sub RadioButtonStudentIPNO_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonStudentIPNO.CheckedChanged
        txtbbxStudentIPGroup.Enabled = Not RadioButtonStudentIPNO.Checked
        If RadioButtonStudentIPNO.Checked Then
            txtbbxStudentIPGroup.Clear()
        End If
    End Sub

    ' Handle 4Ps radio button changes
    Private Sub RadioButtonStudent4PYES_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonStudent4PYES.CheckedChanged
        txtbx4ps.Enabled = RadioButtonStudent4PYES.Checked
        If Not RadioButtonStudent4PYES.Checked Then
            txtbx4ps.Clear()
        End If
    End Sub

    Private Sub RadioButtonStudent4PNO_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonStudent4PNO.CheckedChanged
        txtbx4ps.Enabled = Not RadioButtonStudent4PNO.Checked
        If RadioButtonStudent4PNO.Checked Then
            txtbx4ps.Clear()
        End If
    End Sub

    Private Sub PositionSidebarButtons()
        ' Position sidebar buttons vertically with better spacing
        Dim sidebarWidth As Integer = 250
        Dim sidebarPadding As Integer = 10
        Dim buttonHeight As Integer = 70
        Dim buttonSpacing As Integer = 50
        Dim startTop As Integer = 60

        btnManageStudents.Top = startTop
        btnManageStudents.Left = sidebarPadding
        btnManageStudents.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageStudents.Height = buttonHeight

        btnManageTeachers.Top = btnManageStudents.Bottom + buttonSpacing
        btnManageTeachers.Left = sidebarPadding
        btnManageTeachers.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageTeachers.Height = buttonHeight

        btnManageSections.Top = btnManageTeachers.Bottom + buttonSpacing
        btnManageSections.Left = sidebarPadding
        btnManageSections.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageSections.Height = buttonHeight

        btnManageEnrollments.Top = btnManageSections.Bottom + buttonSpacing
        btnManageEnrollments.Left = sidebarPadding
        btnManageEnrollments.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageEnrollments.Height = buttonHeight

        btnManageSubjects.Top = btnManageEnrollments.Bottom + buttonSpacing
        btnManageSubjects.Left = sidebarPadding
        btnManageSubjects.Width = sidebarWidth - (sidebarPadding * 2)
        btnManageSubjects.Height = buttonHeight

        btnGenerateReports.Top = btnManageSubjects.Bottom + buttonSpacing
        btnGenerateReports.Left = sidebarPadding
        btnGenerateReports.Width = sidebarWidth - (sidebarPadding * 2)
        btnGenerateReports.Height = buttonHeight

        Dim logoutBottomPadding As Integer = 30
        btnLogout.Top = Me.ClientSize.Height - buttonHeight - logoutBottomPadding
        btnLogout.Left = sidebarPadding
        btnLogout.Width = sidebarWidth - (sidebarPadding * 2)
        btnLogout.Height = buttonHeight
    End Sub

    Private Sub StyleSidebarButtons()
        Dim buttons() As Button = {
            btnManageStudents,
            btnManageTeachers,
            btnManageSections,
            btnManageEnrollments,
            btnManageSubjects,
            btnGenerateReports
        }

        For Each btn As Button In buttons
            btn.BackColor = Color.LightGray
            btn.ForeColor = Color.Black
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = Color.Gainsboro
            btn.Font = New Font(btn.Font.FontFamily, 15, FontStyle.Bold)
            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.Padding = New Padding(15, 0, 0, 0)
        Next

        btnLogout.BackColor = Color.Red
        btnLogout.ForeColor = Color.White
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btnLogout.Font = New Font(btnLogout.Font.FontFamily, 12, FontStyle.Bold)
        btnLogout.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnStudentAdd.Click
        ' Validate required fields FIRST
        If Not ValidateInputs() Then
            Return ' Stop execution if validation fails
        End If

        ' Add student to database using modDB
        Try
            Dim query As String = "INSERT INTO student (" &
                            "LRN, MiddleName, FirstName, LastName, ExtensionName, " &
                            "Gender, BirthDate, Age, BirthPlace, MotherTongue, " &
                            "Indigineous, IndigineousSpecific, 4Ps, 4PsID, " &
                            "Religion, GuardianName, GuardianContact, " &
                            "GradeLevel, SectionID, EnrollmentID, " &
                            "HouseNumber, Street, Barangay, Municipality, Province, Country, ZipCode" &
                            ") VALUES (" &
                            "@LRN, @MiddleName, @FirstName, @LastName, @ExtensionName, " &
                            "@Gender, @BirthDate, @Age, @BirthPlace, @MotherTongue, " &
                            "@Indigineous, @IndigineousSpecific, @4Ps, @4PsID, " &
                            "@Religion, @GuardianName, @GuardianContact, " &
                            "@GradeLevel, @SectionID, @EnrollmentID, " &
                            "@HouseNumber, @Street, @Barangay, @Municipality, @Province, @Country, @ZipCode)"

            modDBx.openConn(modDBx.db_name)

            Using cmd As New MySqlCommand(query, modDBx.conn)
                ' LRN (optional) - No conversion needed (numeric)
                cmd.Parameters.AddWithValue("@LRN", SafeString(txtbxStudentLRN.Text))

                ' Personal Information - Convert to Proper Case
                cmd.Parameters.AddWithValue("@MiddleName", ConvertToProperCase(SafeString(txtStudentMiddleName.Text)))
                cmd.Parameters.AddWithValue("@FirstName", ConvertToProperCase(SafeString(txtbxStudentFirstName.Text)))
                cmd.Parameters.AddWithValue("@LastName", ConvertToProperCase(SafeString(txtbxStudentSurname.Text)))
                cmd.Parameters.AddWithValue("@ExtensionName", ConvertToProperCase(SafeString(txtbxStudentExtension.Text)))

                Dim gender As String = ""
                If cmbStudenttGender.SelectedItem IsNot Nothing Then
                    gender = cmbStudenttGender.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@Gender", gender)
                cmd.Parameters.AddWithValue("@BirthDate", dtpStudentBirthdate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@Age", txtbxStudentAge.Text)

                ' Convert these fields to Proper Case
                cmd.Parameters.AddWithValue("@BirthPlace", ConvertToProperCase(SafeString(txtbxStudentPOB.Text)))
                cmd.Parameters.AddWithValue("@MotherTongue", ConvertToProperCase(SafeString(txtbxStudentMotherTongue.Text)))

                ' Indigineous Information
                cmd.Parameters.AddWithValue("@Indigineous", If(RadioButtonStudentIPYES.Checked, "Yes", "No"))
                cmd.Parameters.AddWithValue("@IndigineousSpecific", ConvertToProperCase(SafeString(txtbbxStudentIPGroup.Text)))

                ' 4Ps Information
                cmd.Parameters.AddWithValue("@4Ps", If(RadioButtonStudent4PYES.Checked, "Yes", "No"))
                cmd.Parameters.AddWithValue("@4PsID", SafeString(txtbx4ps.Text)) ' No conversion (typically numeric)

                ' Guardian and Religion - Convert to Proper Case
                cmd.Parameters.AddWithValue("@Religion", ConvertToProperCase(SafeString(txtbxStudentReligion.Text)))
                cmd.Parameters.AddWithValue("@GuardianName", ConvertToProperCase(SafeString(txtbxGuardianName.Text)))
                cmd.Parameters.AddWithValue("@GuardianContact", SafeString(txtbxGuardianContactNo.Text)) ' No conversion (numeric)

                ' Academic Information
                cmd.Parameters.AddWithValue("@GradeLevel", nudStudentGradeLevel.Value)

                ' Address Information - Convert to Proper Case
                cmd.Parameters.AddWithValue("@HouseNumber", SafeString(txtbxStudentHouseNo.Text)) ' No conversion (numeric)
                cmd.Parameters.AddWithValue("@Street", ConvertToProperCase(SafeString(txtbxstudentStreet.Text)))
                cmd.Parameters.AddWithValue("@Barangay", ConvertToProperCase(SafeString(txtbxStudentBarangay.Text)))
                cmd.Parameters.AddWithValue("@Municipality", ConvertToProperCase(SafeString(txtbxStudentCity.Text)))
                cmd.Parameters.AddWithValue("@Province", ConvertToProperCase(SafeString(txtbxStudentProvince.Text)))
                cmd.Parameters.AddWithValue("@Country", ConvertToProperCase(SafeString(txtbxCountry.Text)))
                cmd.Parameters.AddWithValue("@ZipCode", SafeString(txtbxZipCode.Text)) ' No conversion (numeric)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInputFields()
                    LoadToDGV("SELECT * FROM student", dgvStudents)
                Else
                    MessageBox.Show("Failed to add student. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Function ConvertToProperCase(text As String) As String
        If String.IsNullOrWhiteSpace(text) Then
            Return text
        End If

        ' Convert to proper case (first letter uppercase, rest lowercase)
        Dim culture As New System.Globalization.CultureInfo("en-US")
        Dim textInfo As System.Globalization.TextInfo = culture.TextInfo

        Return textInfo.ToTitleCase(text.ToLower())
    End Function

    Private Sub txtbxStudentFirstName_Leave(sender As Object, e As EventArgs) Handles txtbxStudentFirstName.Leave
        If Not String.IsNullOrWhiteSpace(txtbxStudentFirstName.Text) Then
            txtbxStudentFirstName.Text = ConvertToProperCase(txtbxStudentFirstName.Text.Trim())
        End If
    End Sub

    Private Sub txtStudentMiddleName_Leave(sender As Object, e As EventArgs) Handles txtStudentMiddleName.Leave
        If Not String.IsNullOrWhiteSpace(txtStudentMiddleName.Text) Then
            txtStudentMiddleName.Text = ConvertToProperCase(txtStudentMiddleName.Text.Trim())
        End If
    End Sub

    Private Sub txtbxStudentSurname_Leave(sender As Object, e As EventArgs) Handles txtbxStudentSurname.Leave
        If Not String.IsNullOrWhiteSpace(txtbxStudentSurname.Text) Then
            txtbxStudentSurname.Text = ConvertToProperCase(txtbxStudentSurname.Text.Trim())
        End If
    End Sub

    Private Sub txtbxStudentExtension_Leave(sender As Object, e As EventArgs) Handles txtbxStudentExtension.Leave
        If Not String.IsNullOrWhiteSpace(txtbxStudentExtension.Text) Then
            txtbxStudentExtension.Text = ConvertToProperCase(txtbxStudentExtension.Text.Trim())
        End If
    End Sub

    Private Sub txtbxStudentPOB_Leave(sender As Object, e As EventArgs) Handles txtbxStudentPOB.Leave
        If Not String.IsNullOrWhiteSpace(txtbxStudentPOB.Text) Then
            txtbxStudentPOB.Text = ConvertToProperCase(txtbxStudentPOB.Text.Trim())
        End If
    End Sub

    Private Sub txtbxStudentMotherTongue_Leave(sender As Object, e As EventArgs) Handles txtbxStudentMotherTongue.Leave
        If Not String.IsNullOrWhiteSpace(txtbxStudentMotherTongue.Text) Then
            txtbxStudentMotherTongue.Text = ConvertToProperCase(txtbxStudentMotherTongue.Text.Trim())
        End If
    End Sub

    Private Sub txtbbxStudentIPGroup_Leave(sender As Object, e As EventArgs) Handles txtbbxStudentIPGroup.Leave
        If Not String.IsNullOrWhiteSpace(txtbbxStudentIPGroup.Text) Then
            txtbbxStudentIPGroup.Text = ConvertToProperCase(txtbbxStudentIPGroup.Text.Trim())
        End If
    End Sub

    Private Sub txtbxStudentReligion_Leave(sender As Object, e As EventArgs) Handles txtbxStudentReligion.Leave
        If Not String.IsNullOrWhiteSpace(txtbxStudentReligion.Text) Then
            txtbxStudentReligion.Text = ConvertToProperCase(txtbxStudentReligion.Text.Trim())
        End If
    End Sub

    Private Sub txtbxstudentStreet_Leave(sender As Object, e As EventArgs) Handles txtbxstudentStreet.Leave
        If Not String.IsNullOrWhiteSpace(txtbxstudentStreet.Text) Then
            txtbxstudentStreet.Text = ConvertToProperCase(txtbxstudentStreet.Text.Trim())
        End If
    End Sub

    Private Sub txtbxStudentBarangay_Leave(sender As Object, e As EventArgs) Handles txtbxStudentBarangay.Leave
        If Not String.IsNullOrWhiteSpace(txtbxStudentBarangay.Text) Then
            txtbxStudentBarangay.Text = ConvertToProperCase(txtbxStudentBarangay.Text.Trim())
        End If
    End Sub

    Private Sub txtbxStudentCity_Leave(sender As Object, e As EventArgs) Handles txtbxStudentCity.Leave
        If Not String.IsNullOrWhiteSpace(txtbxStudentCity.Text) Then
            txtbxStudentCity.Text = ConvertToProperCase(txtbxStudentCity.Text.Trim())
        End If
    End Sub

    Private Sub txtbxStudentProvince_Leave(sender As Object, e As EventArgs) Handles txtbxStudentProvince.Leave
        If Not String.IsNullOrWhiteSpace(txtbxStudentProvince.Text) Then
            txtbxStudentProvince.Text = ConvertToProperCase(txtbxStudentProvince.Text.Trim())
        End If
    End Sub

    Private Sub txtbxCountry_Leave(sender As Object, e As EventArgs) Handles txtbxCountry.Leave
        If Not String.IsNullOrWhiteSpace(txtbxCountry.Text) Then
            txtbxCountry.Text = ConvertToProperCase(txtbxCountry.Text.Trim())
        End If
    End Sub

    Private Sub txtbxGuardianName_Leave(sender As Object, e As EventArgs) Handles txtbxGuardianName.Leave
        If Not String.IsNullOrWhiteSpace(txtbxGuardianName.Text) Then
            txtbxGuardianName.Text = ConvertToProperCase(txtbxGuardianName.Text.Trim())
        End If
    End Sub

    ' Helper function to safely handle string values
    Private Function SafeString(value As String) As String
        Return If(String.IsNullOrWhiteSpace(value), "", value.Trim().Replace("'", "''"))
    End Function

    Private Function ValidateInputs() As Boolean
        ' Check if required fields are filled in sequence

        ' 1. First Name (Required)
        If String.IsNullOrWhiteSpace(txtbxStudentFirstName.Text) Then
            MessageBox.Show("Please enter First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentFirstName.Focus()
            Return False
        End If

        ' 2. Last Name (Required)
        If String.IsNullOrWhiteSpace(txtbxStudentSurname.Text) Then
            MessageBox.Show("Please enter Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentSurname.Focus()
            Return False
        End If

        ' 3. Birth Date (Required - validated by control)
        ' 4. Age (Required)
        If String.IsNullOrWhiteSpace(txtbxStudentAge.Text) Then
            MessageBox.Show("Please enter a valid Age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentAge.Focus()
            Return False
        End If

        ' 5. Gender (Required)
        If cmbStudenttGender.SelectedIndex = -1 Then
            MessageBox.Show("Please select Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStudenttGender.Focus()
            Return False
        End If

        ' 6. Grade Level (Required)
        If nudStudentGradeLevel.Value <= 0 Then
            MessageBox.Show("Please enter a valid Grade Level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            nudStudentGradeLevel.Focus()
            Return False
        End If

        ' 7. Birth Place (Required)
        If String.IsNullOrWhiteSpace(txtbxStudentPOB.Text) Then
            MessageBox.Show("Please enter Birth Place.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentPOB.Focus()
            Return False
        End If

        ' 8. Religion (Required)
        If String.IsNullOrWhiteSpace(txtbxStudentReligion.Text) Then
            MessageBox.Show("Please enter Religion.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentReligion.Focus()
            Return False
        End If

        ' 9. Mother Tongue (Required)
        If String.IsNullOrWhiteSpace(txtbxStudentMotherTongue.Text) Then
            MessageBox.Show("Please enter Mother Tongue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentMotherTongue.Focus()
            Return False
        End If

        ' 10. Guardian Name (Required)
        If String.IsNullOrWhiteSpace(txtbxGuardianName.Text) Then
            MessageBox.Show("Please enter Guardian Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxGuardianName.Focus()
            Return False
        End If

        ' 11. Guardian Contact (Required with specific format)
        If String.IsNullOrWhiteSpace(txtbxGuardianContactNo.Text) Then
            MessageBox.Show("Please enter Guardian Contact Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxGuardianContactNo.Focus()
            Return False
        End If

        ' Validate Guardian Contact format (09XXXXXXXXX - 11 digits)
        Dim guardianContact As String = txtbxGuardianContactNo.Text.Trim()
        If guardianContact.Length <> 11 Then
            MessageBox.Show("Guardian Contact must be exactly 11 digits (09XXXXXXXXX).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxGuardianContactNo.Focus()
            Return False
        End If

        If Not guardianContact.StartsWith("09") Then
            MessageBox.Show("Guardian Contact must start with '09'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxGuardianContactNo.Focus()
            Return False
        End If

        Dim contactNum As Long
        If Not Long.TryParse(guardianContact, contactNum) Then
            MessageBox.Show("Guardian Contact must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxGuardianContactNo.Focus()
            Return False
        End If

        ' 12. Validate Indigineous group if Indigineous is YES
        If RadioButtonStudentIPYES.Checked AndAlso String.IsNullOrWhiteSpace(txtbbxStudentIPGroup.Text) Then
            MessageBox.Show("Please specify Indigineous Group.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbbxStudentIPGroup.Focus()
            Return False
        End If

        ' 13. Validate 4Ps ID if 4Ps is YES
        If RadioButtonStudent4PYES.Checked AndAlso String.IsNullOrWhiteSpace(txtbx4ps.Text) Then
            MessageBox.Show("Please enter 4Ps ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbx4ps.Focus()
            Return False
        End If

        ' 14. Address validation

        ' House Number (Required and numeric)
        If String.IsNullOrWhiteSpace(txtbxStudentHouseNo.Text) Then
            MessageBox.Show("Please enter House Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentHouseNo.Focus()
            Return False
        End If

        Dim houseNum As Integer
        If Not Integer.TryParse(txtbxStudentHouseNo.Text.Trim(), houseNum) Then
            MessageBox.Show("House Number must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentHouseNo.Focus()
            Return False
        End If

        ' Street (Required)
        If String.IsNullOrWhiteSpace(txtbxstudentStreet.Text) Then
            MessageBox.Show("Please enter Street.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxstudentStreet.Focus()
            Return False
        End If

        ' Barangay (Required)
        If String.IsNullOrWhiteSpace(txtbxStudentBarangay.Text) Then
            MessageBox.Show("Please enter Barangay.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentBarangay.Focus()
            Return False
        End If

        ' Municipality/City (Required)
        If String.IsNullOrWhiteSpace(txtbxStudentCity.Text) Then
            MessageBox.Show("Please enter Municipality/City.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentCity.Focus()
            Return False
        End If

        ' Province (Required)
        If String.IsNullOrWhiteSpace(txtbxStudentProvince.Text) Then
            MessageBox.Show("Please enter Province.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentProvince.Focus()
            Return False
        End If

        ' Country (Required)
        If String.IsNullOrWhiteSpace(txtbxCountry.Text) Then
            MessageBox.Show("Please enter Country.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxCountry.Focus()
            Return False
        End If

        ' Zip Code (Required)
        If String.IsNullOrWhiteSpace(txtbxZipCode.Text) Then
            MessageBox.Show("Please enter Zip Code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxZipCode.Focus()
            Return False
        End If

        ' Validate Zip Code is numeric and has appropriate length
        Dim zipCode As String = txtbxZipCode.Text.Trim()
        If zipCode.Length <> 4 Then
            MessageBox.Show("Zip Code must be exactly 4 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxZipCode.Focus()
            Return False
        End If

        Dim zipCodeNum As Integer
        If Not Integer.TryParse(zipCode, zipCodeNum) Then
            MessageBox.Show("Zip Code must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxZipCode.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub ClearInputFields()
        ' Clear all input fields after successful add

        ' LRN (optional)
        txtbxStudentLRN.Clear()

        ' Personal Information
        txtStudentMiddleName.Clear()
        txtbxStudentFirstName.Clear()
        txtbxStudentSurname.Clear()
        txtbxStudentExtension.Clear()
        cmbStudenttGender.SelectedIndex = -1
        dtpStudentBirthdate.Value = DateTime.Now
        txtbxStudentAge.Clear()

        ' Clear additional personal info
        txtbxStudentPOB.Clear()
        txtbxStudentMotherTongue.Clear()
        txtbxStudentReligion.Clear()

        ' Guardian Information
        txtbxGuardianName.Clear()
        txtbxGuardianContactNo.Clear()

        ' Reset Indigineous radio buttons
        RadioButtonStudentIPNO.Checked = True
        txtbbxStudentIPGroup.Clear()

        ' Reset 4Ps radio buttons
        RadioButtonStudent4PNO.Checked = True
        txtbx4ps.Clear()

        ' Clear address fields
        txtbxStudentHouseNo.Clear()
        txtbxstudentStreet.Clear()
        txtbxStudentBarangay.Clear()
        txtbxStudentCity.Clear()
        txtbxStudentProvince.Clear()
        txtbxCountry.Clear()
        txtbxZipCode.Clear()

        ' Set focus back to first field
        txtbxStudentFirstName.Focus()
    End Sub

    ' Helper method to safely reset numeric up/down controls
    Private Sub ResetNumericControl(nudControl As NumericUpDown)
        If nudControl.Minimum <= 0 AndAlso nudControl.Maximum >= 0 Then
            nudControl.Value = 0
        Else
            nudControl.Value = nudControl.Minimum
        End If
    End Sub

    ' Auto-calculate age when birthdate changes
    Private Sub dtpStudentBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStudentBirthdate.ValueChanged
        Dim birthDate As Date = dtpStudentBirthdate.Value
        Dim today As Date = Date.Today

        Dim age As Integer = today.Year - birthDate.Year

        ' Adjust if birthday hasn't happened yet this year
        If birthDate > today.AddYears(-age) Then
            age -= 1
        End If

        txtbxStudentAge.Text = age.ToString()
    End Sub

    Private Function CalculateAge(birthDate As Date) As Integer
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year

        If birthDate > today.AddYears(-age) Then
            age -= 1
        End If

        Return age
    End Function

    ' Update the dgvStudents_CellClick method to populate all fields including new ones
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvStudents.Rows(e.RowIndex)

            currentStudentID = CInt(row.Cells(0).Value)

            ' Populate all fields including new ones
            txtbxStudentLRN.Text = GetSafeString(row.Cells("LRN"))
            txtbxStudentFirstName.Text = GetSafeString(row.Cells("FirstName"))
            txtStudentMiddleName.Text = GetSafeString(row.Cells("MiddleName"))
            txtbxStudentSurname.Text = GetSafeString(row.Cells("LastName"))
            txtbxStudentExtension.Text = GetSafeString(row.Cells("ExtensionName"))
            cmbStudenttGender.Text = GetSafeString(row.Cells("Gender"))

            If Not IsDBNull(row.Cells("Birthdate").Value) Then
                dtpStudentBirthdate.Value = CDate(row.Cells("Birthdate").Value)
            End If

            txtbxStudentPOB.Text = GetSafeString(row.Cells("BirthPlace"))
            txtbxStudentMotherTongue.Text = GetSafeString(row.Cells("MotherTongue"))
            txtbxStudentReligion.Text = GetSafeString(row.Cells("Religion"))

            ' Indigineous fields
            Dim indigineous As String = GetSafeString(row.Cells("Indigineous"))
            If indigineous = "Yes" Then
                RadioButtonStudentIPYES.Checked = True
            Else
                RadioButtonStudentIPNO.Checked = True
            End If
            txtbbxStudentIPGroup.Text = GetSafeString(row.Cells("IndigineousSpecific"))

            ' 4Ps fields
            Dim is4Ps As String = GetSafeString(row.Cells("4Ps"))
            If is4Ps = "Yes" Then
                RadioButtonStudent4PYES.Checked = True
            Else
                RadioButtonStudent4PNO.Checked = True
            End If
            txtbx4ps.Text = GetSafeString(row.Cells("4PsID"))

            txtbxGuardianName.Text = GetSafeString(row.Cells("GuardianName"))
            txtbxGuardianContactNo.Text = GetSafeString(row.Cells("GuardianContact"))

            ' Age field
            If Not IsDBNull(row.Cells("Age").Value) Then
                txtbxStudentAge.Text = row.Cells("Age").Value.ToString()
            End If

            ' Grade Level
            If Not IsDBNull(row.Cells("GradeLevel").Value) Then
                nudStudentGradeLevel.Value = CInt(row.Cells("GradeLevel").Value)
            End If

            ' Address fields
            txtbxStudentHouseNo.Text = GetSafeString(row.Cells("HouseNumber"))
            txtbxstudentStreet.Text = GetSafeString(row.Cells("Street"))
            txtbxStudentBarangay.Text = GetSafeString(row.Cells("Barangay"))
            txtbxStudentCity.Text = GetSafeString(row.Cells("Municipality"))
            txtbxStudentProvince.Text = GetSafeString(row.Cells("Province"))
            txtbxCountry.Text = GetSafeString(row.Cells("Country"))
            txtbxZipCode.Text = GetSafeString(row.Cells("ZIPCode"))
        End If
    End Sub

    ' Helper function for safe string retrieval from DataGridView
    Private Function GetSafeString(cell As DataGridViewCell) As String
        Return If(cell.Value Is Nothing OrElse IsDBNull(cell.Value), "", cell.Value.ToString())
    End Function

    Private Sub UpdateStudent()
        If currentStudentID = 0 Then
            MsgBox("No student selected for update.", MsgBoxStyle.Exclamation, "Update Error")
            Return
        End If

        Try
            modDBx.openConn(modDBx.db_name)

            Dim sql As String = "UPDATE student SET " &
                        "LRN = @LRN, " &
                        "FirstName = @FirstName, " &
                        "MiddleName = @MiddleName, " &
                        "LastName = @LastName, " &
                        "ExtensionName = @ExtensionName, " &
                        "Gender = @Gender, " &
                        "Birthdate = @Birthdate, " &
                        "Age = @Age, " &
                        "BirthPlace = @BirthPlace, " &
                        "MotherTongue = @MotherTongue, " &
                        "Indigineous = @Indigineous, " &
                        "IndigineousSpecific = @IndigineousSpecific, " &
                        "4Ps = @4Ps, " &
                        "4PsID = @4PsID, " &
                        "Religion = @Religion, " &
                        "GuardianName = @GuardianName, " &
                        "GuardianContact = @GuardianContact, " &
                        "GradeLevel = @GradeLevel, " &
                        "HouseNumber = @HouseNumber, " &
                        "Street = @Street, " &
                        "Barangay = @Barangay, " &
                        "Municipality = @Municipality, " &
                        "Province = @Province, " &
                        "Country = @Country, " &
                        "ZIPCode = @ZIPCode " &
                        "WHERE StudentID = @StudentID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                ' Add all parameters - Convert appropriate fields to Proper Case
                cmd.Parameters.AddWithValue("@LRN", txtbxStudentLRN.Text.Trim())
                cmd.Parameters.AddWithValue("@FirstName", ConvertToProperCase(txtbxStudentFirstName.Text.Trim()))
                cmd.Parameters.AddWithValue("@MiddleName", ConvertToProperCase(txtStudentMiddleName.Text.Trim()))
                cmd.Parameters.AddWithValue("@LastName", ConvertToProperCase(txtbxStudentSurname.Text.Trim()))
                cmd.Parameters.AddWithValue("@ExtensionName", ConvertToProperCase(txtbxStudentExtension.Text.Trim()))
                cmd.Parameters.AddWithValue("@Gender", cmbStudenttGender.Text.Trim())
                cmd.Parameters.AddWithValue("@Birthdate", dtpStudentBirthdate.Value)
                cmd.Parameters.AddWithValue("@Age", txtbxStudentAge.Text.Trim())
                cmd.Parameters.AddWithValue("@BirthPlace", ConvertToProperCase(txtbxStudentPOB.Text.Trim()))
                cmd.Parameters.AddWithValue("@MotherTongue", ConvertToProperCase(txtbxStudentMotherTongue.Text.Trim()))
                cmd.Parameters.AddWithValue("@Indigineous", If(RadioButtonStudentIPYES.Checked, "Yes", "No"))
                cmd.Parameters.AddWithValue("@IndigineousSpecific", ConvertToProperCase(txtbbxStudentIPGroup.Text.Trim()))
                cmd.Parameters.AddWithValue("@4Ps", If(RadioButtonStudent4PYES.Checked, "Yes", "No"))
                cmd.Parameters.AddWithValue("@4PsID", txtbx4ps.Text.Trim())
                cmd.Parameters.AddWithValue("@Religion", ConvertToProperCase(txtbxStudentReligion.Text.Trim()))
                cmd.Parameters.AddWithValue("@GuardianName", ConvertToProperCase(txtbxGuardianName.Text.Trim()))
                cmd.Parameters.AddWithValue("@GuardianContact", txtbxGuardianContactNo.Text.Trim())
                cmd.Parameters.AddWithValue("@GradeLevel", nudStudentGradeLevel.Value)
                cmd.Parameters.AddWithValue("@HouseNumber", txtbxStudentHouseNo.Text.Trim())
                cmd.Parameters.AddWithValue("@Street", ConvertToProperCase(txtbxstudentStreet.Text.Trim()))
                cmd.Parameters.AddWithValue("@Barangay", ConvertToProperCase(txtbxStudentBarangay.Text.Trim()))
                cmd.Parameters.AddWithValue("@Municipality", ConvertToProperCase(txtbxStudentCity.Text.Trim()))
                cmd.Parameters.AddWithValue("@Province", ConvertToProperCase(txtbxStudentProvince.Text.Trim()))
                cmd.Parameters.AddWithValue("@Country", ConvertToProperCase(txtbxCountry.Text.Trim()))
                cmd.Parameters.AddWithValue("@ZIPCode", txtbxZipCode.Text.Trim())
                cmd.Parameters.AddWithValue("@StudentID", currentStudentID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Student updated successfully.", MsgBoxStyle.Information, "Update Success")
                    LoadToDGV("SELECT * FROM student", dgvStudents)
                    currentStudentID = 0
                Else
                    MsgBox("No student was updated. Please check the data.", MsgBoxStyle.Exclamation, "Update Failed")
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error updating student: " & ex.Message, MsgBoxStyle.Critical, "Update Error")
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub SearchStudentsBySurname(ByVal surname As String)
        ' If the search box is empty, load all students (default view)
        If String.IsNullOrWhiteSpace(surname) Then
            LoadToDGV("SELECT * FROM student", dgvStudents)
            Return
        End If

        Try
            ' Open Connection
            modDBx.openConn(modDBx.db_name)

            ' Use prefix match so search is from the first letter to the last (incremental per-letter filter)
            Dim sql As String = "SELECT * FROM student WHERE LastName LIKE @searchSurname ORDER BY LastName"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                ' Use surname + '%' to match only names that start with the typed letters
                cmd.Parameters.AddWithValue("@searchSurname", surname.Trim() & "%")

                Dim dt As New System.Data.DataTable
                Using adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                dgvStudents.DataSource = dt
                dgvStudents.Refresh()

                If dgvStudents.ColumnCount > 0 Then
                    dgvStudents.Columns(0).Visible = False
                End If

                If dt.Rows.Count = 0 Then
                    MsgBox("No student found matching the surname '" & surname & "'.", MsgBoxStyle.Information, "Search Result")
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error searching students: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = System.Data.ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub TextBoxStudentSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxStudentSearch.TextChanged
        SearchStudentsBySurname(TextBoxStudentSearch.Text)
    End Sub

    Private Sub btnStudentUpdate_Click(sender As Object, e As EventArgs) Handles btnStudentUpdate.Click
        UpdateStudent()
    End Sub

    Private Sub btnStudentDelete_Click(sender As Object, e As EventArgs) Handles btnStudentDelete.Click
        ' Check if a student is selected
        If currentStudentID = 0 Then
            MsgBox("Please select a student to delete.", MsgBoxStyle.Exclamation, "Delete Student")
            Return
        End If

        ' Confirm deletion
        If MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Try
            ' Open database connection
            modDBx.openConn(modDBx.db_name)

            ' Prepare the DELETE SQL statement
            Dim sql As String = "DELETE FROM student WHERE StudentID = @StudentID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@StudentID", currentStudentID)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Student deleted successfully.", MsgBoxStyle.Information, "Delete Success")
                    ' Refresh the DataGridView
                    LoadToDGV("SELECT * FROM student", dgvStudents)
                    ' Reset current selection and clear input fields
                    currentStudentID = 0
                    ClearInputFields()
                Else
                    MsgBox("No student was deleted. Please check your selection.", MsgBoxStyle.Exclamation, "Delete Failed")
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error deleting student: " & ex.Message, MsgBoxStyle.Critical, "Delete Error")
        Finally
            ' Close connection safely
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' Rest of your existing event handlers...

    Private Sub txtbxStudentAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxStudentAge.KeyPress
        e.Handled = True ' Block typing
    End Sub

    Private Sub txtbxStudentAge_TextChanged(sender As Object, e As EventArgs) Handles txtbxStudentAge.TextChanged
        ' Prevent manual edits from breaking the value
        If Not txtbxStudentAge.ReadOnly Then
            txtbxStudentAge.ReadOnly = True
        End If
    End Sub

    ' Keep all your existing event handlers that weren't modified
    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint
        ' Handle paint event if needed
    End Sub

    Private Sub lblStudentAge_Click(sender As Object, e As EventArgs) Handles lblStudentAge.Click
        ' Handle label click if needed
    End Sub

    Private Sub lblStudentGender_Click(sender As Object, e As EventArgs) Handles lblStudentGender.Click
        ' Handle label click if needed
    End Sub

    Private Sub picWatermark_Click(sender As Object, e As EventArgs) Handles picWatermark.Click
        ' Handle picture click if needed
    End Sub

    Private Sub grpStudentInfo_Enter(sender As Object, e As EventArgs) Handles grpStudentInfo.Enter
        ' Handle group box enter if needed
    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint
        ' Handle paint event if needed
    End Sub

    Private Sub lblStudentMiddleName_Click(sender As Object, e As EventArgs) Handles lblStudentMiddleName.Click
        ' Handle label click if needed
    End Sub

    Private Sub cmbStudenttGenderSelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudenttGender.SelectedIndexChanged
        ' Handle combo box selection change if needed
    End Sub

    Private Sub txtbxStudentSurnameTextChanged(sender As Object, e As EventArgs) Handles txtbxStudentSurname.TextChanged
        ' Handle text change if needed
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        ' Handle label click if needed
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        ' Handle label click if needed
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtbxStudentProvince.TextChanged
        ' Handle text change if needed
    End Sub

End Class
