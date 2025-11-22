Imports MySql.Data.MySqlClient

Public Class AdminManageStudents

    Public Property IsEmbedded As Boolean = False

    Private Sub AdminManageStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Update connection string in modDB
        modDBx.db_server = "127.0.0.1"
        modDBx.db_uid = "root"
        modDBx.db_pwd = ""
        modDBx.db_name = "cflc_db"
        modDBx.strConnection = "server=" & modDBx.db_server & ";port=3306;uid=" & modDBx.db_uid & ";password=" & modDBx.db_pwd & ";database=" & modDBx.db_name & ";allowuservariables=True;"

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
    End Sub

    Private Sub InitializeGenderComboBox()
        ' Populate Gender dropdown
        cmbStudenttGender.Items.Clear()
        cmbStudenttGender.Items.Add("Male")
        cmbStudenttGender.Items.Add("Female")
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validate required fields FIRST
        If Not ValidateInputs() Then
            Return ' Stop execution if validation fails
        End If

        ' Add student to database using modDB
        Try
            ' Build the INSERT query (StudentID auto-increments, StudentNo left blank for now)
            ' Use NULL for empty SectionID and EnrollmentID to avoid foreign key constraints
            Dim sectionIDValue As String = If(String.IsNullOrWhiteSpace(txtbxStudentSectionID.Text), "NULL", "'" & txtbxStudentSectionID.Text.Trim().Replace("'", "''") & "'")
            Dim enrollmentIDValue As String = If(String.IsNullOrWhiteSpace(txtbxStudentEnrollmentID.Text), "NULL", "'" & txtbxStudentEnrollmentID.Text.Trim().Replace("'", "''") & "'")

            Dim query As String = "INSERT INTO student (MiddleName, FirstName, LastName, Gender, BirthDate, Age, GuardianName, Religion, GradeLevel, SectionID, EnrollmentID, HouseNumber, Street, Barangay, Municipality, Province, ZipCode) " &
                                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', {8}, {9}, {10}, '{11}', '{12}', '{13}', '{14}', '{15}', '{16}')"

            ' Format the query with values
            query = String.Format(query,
                txtStudentMiddleName.Text.Trim().Replace("'", "''"),
                txtbxStudentFirstName.Text.Trim().Replace("'", "''"),
                txtbxStudentSurname.Text.Trim().Replace("'", "''"),
                cmbStudenttGender.SelectedItem.ToString(),
                dtpStudentBirthdate.Value.ToString("yyyy-MM-dd"),
                nudStudentAge.Value,
                txtbxStudentParentName.Text.Trim().Replace("'", "''"),
                txtbxStudentReligion.Text.Trim().Replace("'", "''"),
                nudStudentGradeLevel.Value,
                sectionIDValue,
                enrollmentIDValue,
                txtbxStudentHouseNo.Text.Trim().Replace("'", "''"),
                txtbxStudentStreet.Text.Trim().Replace("'", "''"),
                txtbxStudentBarangay.Text.Trim().Replace("'", "''"),
                txtbxStudentCity.Text.Trim().Replace("'", "''"),
                txtbxStudentProvince.Text.Trim().Replace("'", "''"),
                txtbxZipCode.Text.Trim().Replace("'", "''")
            )

            ' Open connection and execute query
            modDBx.openConn(modDBx.db_name)

            Using cmd As New MySqlCommand(query, modDBx.conn)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Log the transaction if user is logged in
                    If modDBx.CurrentLoggedUser.id > 0 Then
                        modDBx.Logs("Added student: " & txtbxStudentFirstName.Text & " " & txtbxStudentSurname.Text, "btnAdd_Click")
                    End If

                    ' Clear all fields after successful insert
                    ClearInputFields()
                Else
                    MessageBox.Show("Failed to add student. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            ' Close connection
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure connection is closed
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Check if required fields are filled
        If String.IsNullOrWhiteSpace(txtbxStudentFirstName.Text) Then
            MessageBox.Show("Please enter First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentFirstName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtbxStudentSurname.Text) Then
            MessageBox.Show("Please enter Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentSurname.Focus()
            Return False
        End If

        If cmbStudenttGender.SelectedIndex = -1 Then
            MessageBox.Show("Please select Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStudenttGender.Focus()
            Return False
        End If

        If nudStudentAge.Value <= 0 Then
            MessageBox.Show("Please enter a valid Age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            nudStudentAge.Focus()
            Return False
        End If

        If nudStudentGradeLevel.Value <= 0 Then
            MessageBox.Show("Please enter a valid Grade Level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            nudStudentGradeLevel.Focus()
            Return False
        End If

        ' Validate address fields
        If String.IsNullOrWhiteSpace(txtbxStudentHouseNo.Text) Then
            MessageBox.Show("Please enter House Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentHouseNo.Focus()
            Return False
        End If

        ' Validate House Number is numeric
        Dim houseNum As Integer
        If Not Integer.TryParse(txtbxStudentHouseNo.Text.Trim(), houseNum) Then
            MessageBox.Show("House Number must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentHouseNo.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtbxStudentStreet.Text) Then
            MessageBox.Show("Please enter Street.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentStreet.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtbxStudentBarangay.Text) Then
            MessageBox.Show("Please enter Barangay.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentBarangay.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtbxStudentCity.Text) Then
            MessageBox.Show("Please enter Municipality/City.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentCity.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtbxStudentProvince.Text) Then
            MessageBox.Show("Please enter Province.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxStudentProvince.Focus()
            Return False
        End If

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

        ' Validate SectionID exists in section table (if not empty)
        If Not String.IsNullOrWhiteSpace(txtbxStudentSectionID.Text) Then
            If Not ValidateSectionID(txtbxStudentSectionID.Text.Trim()) Then
                MessageBox.Show("The Section ID does not exist. Please enter a valid Section ID or leave it blank.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtbxStudentSectionID.Focus()
                Return False
            End If
        End If

        ' Validate EnrollmentID exists in enrollment table (if not empty)
        If Not String.IsNullOrWhiteSpace(txtbxStudentEnrollmentID.Text) Then
            If Not ValidateEnrollmentID(txtbxStudentEnrollmentID.Text.Trim()) Then
                MessageBox.Show("The Enrollment ID does not exist. Please enter a valid Enrollment ID or leave it blank.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtbxStudentEnrollmentID.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Function ValidateSectionID(sectionID As String) As Boolean
        Try
            Dim query As String = String.Format("SELECT COUNT(*) FROM section WHERE SectionID = '{0}'", sectionID.Replace("'", "''"))
            modDBx.openConn(modDBx.db_name)

            Using cmd As New MySqlCommand(query, modDBx.conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If modDBx.conn.State = ConnectionState.Open Then
                    modDBx.conn.Close()
                End If
                Return count > 0
            End Using
        Catch ex As Exception
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
            Return False
        End Try
    End Function

    Private Function ValidateEnrollmentID(enrollmentID As String) As Boolean
        Try
            Dim query As String = String.Format("SELECT COUNT(*) FROM enrollment WHERE EnrollmentID = '{0}'", enrollmentID.Replace("'", "''"))
            modDBx.openConn(modDBx.db_name)

            Using cmd As New MySqlCommand(query, modDBx.conn)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If modDBx.conn.State = ConnectionState.Open Then
                    modDBx.conn.Close()
                End If
                Return count > 0
            End Using
        Catch ex As Exception
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
            Return False
        End Try
    End Function

    Private Sub ClearInputFields()
        ' Clear all input fields after successful add
        txtStudentMiddleName.Clear()
        txtbxStudentFirstName.Clear()
        txtbxStudentSurname.Clear()
        cmbStudenttGender.SelectedIndex = -1
        dtpStudentBirthdate.Value = DateTime.Now
        nudStudentAge.Value = 0
        txtbxStudentParentName.Clear()
        txtbxStudentReligion.Clear()
        nudStudentGradeLevel.Value = 0
        txtbxStudentSectionID.Clear()
        txtbxStudentEnrollmentID.Clear()

        ' Clear address fields
        txtbxStudentHouseNo.Clear()
        txtbxStudentStreet.Clear()
        txtbxStudentBarangay.Clear()
        txtbxStudentCity.Clear()
        txtbxStudentProvince.Clear()
        txtbxZipCode.Clear()

        ' Set focus back to first field
        txtbxStudentFirstName.Focus()
    End Sub

    ' Auto-calculate age when birthdate changes
    Private Sub dtpStudentBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStudentBirthdate.ValueChanged
        Dim birthDate As Date = dtpStudentBirthdate.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year

        ' Adjust if birthday hasn't occurred this year
        If birthDate.Date > today.AddYears(-age) Then
            age -= 1
        End If

        nudStudentAge.Value = age
    End Sub

    Private Sub txtStudentId_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint

    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblStudentAge_Click(sender As Object, e As EventArgs) Handles lblStudentAge.Click

    End Sub

    Private Sub lblStudentGender_Click(sender As Object, e As EventArgs) Handles lblStudentGender.Click

    End Sub

    Private Sub picWatermark_Click(sender As Object, e As EventArgs) Handles picWatermark.Click

    End Sub

    Private Sub grpStudentInfo_Enter(sender As Object, e As EventArgs) Handles grpStudentInfo.Enter

    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint

    End Sub

    Private Sub grpAddress_Enter(sender As Object, e As EventArgs) Handles grpAddress.Enter

    End Sub

    Private Sub lblStudentBarangay_Click(sender As Object, e As EventArgs) Handles lblStudentBarangay.Click

    End Sub

    Private Sub lblStudentProvince_Click(sender As Object, e As EventArgs) Handles lblStudentProvince.Click

    End Sub

    Private Sub lblStudentMiddleName_Click(sender As Object, e As EventArgs) Handles lblStudentMiddleName.Click

    End Sub

    Private Sub cmbStudenttGenderSelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudenttGender.SelectedIndexChanged

    End Sub

    Private Sub nudStudentAgeValueChanged(sender As Object, e As EventArgs) Handles nudStudentAge.ValueChanged

    End Sub

    Private Sub txtbxStudentSurnameTextChanged(sender As Object, e As EventArgs) Handles txtbxStudentSurname.TextChanged

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs)

    End Sub
End Class