Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class AdminManageStudents

    Private currentStudentID As Integer = 0

    Public Property IsEmbedded As Boolean = False

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            ExitFullScreen()
            Return True
        End If

        If keyData = Keys.F Then
            MakeItFullScreen()
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)


    End Function

    Private Sub ExitFullScreen()
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = False
    End Sub

    Private Sub MakeItFullScreen()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BringToFront()
    End Sub

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

        ' Initialize numeric controls with safe default values
        InitializeNumericControls()

        ' Load students data
        LoadToDGV("SELECT * FROM student", dgvStudents)
    End Sub

    Private Sub InitializeNumericControls()
        ' Set safe default values for numeric up/down controls
        If nudStudentAge.Minimum <= 0 AndAlso nudStudentAge.Maximum >= 0 Then
            nudStudentAge.Value = 0
        Else
            nudStudentAge.Value = nudStudentAge.Minimum
        End If

        If nudStudentGradeLevel.Minimum <= 0 AndAlso nudStudentGradeLevel.Maximum >= 0 Then
            nudStudentGradeLevel.Value = 0
        Else
            nudStudentGradeLevel.Value = nudStudentGradeLevel.Minimum
        End If
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnStudentAdd.Click
        ' Validate required fields FIRST
        If Not ValidateInputs() Then
            Return ' Stop execution if validation fails
        End If

        ' Add student to database using modDB
        Try
            ' Build the INSERT query (StudentID auto-increments, StudentNo left blank for now)
            ' Use NULL for empty SectionID and EnrollmentID to avoid foreign key constraints
            Dim enrollmentIDValue As String = If(String.IsNullOrWhiteSpace(txtbxStudentEnrollmentID.Text), "NULL", "'" & txtbxStudentEnrollmentID.Text.Trim().Replace("'", "''") & "'")

            Dim query As String = "INSERT INTO student (MiddleName, FirstName, LastName, Gender, BirthDate, Age, GuardianName, Religion, GradeLevel, SectionID, EnrollmentID, HouseNumber, Street, Barangay, Municipality, Province, Country, ZipCode) " &
                                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', {8}, {9}, {10}, '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}')"

            ' Format the query with values
            query = String.Format(query,
                txtStudentMiddleName.Text.Trim().Replace("'", "''"),
                txtbxStudentFirstName.Text.Trim().Replace("'", "''"),
                txtbxStudentSurname.Text.Trim().Replace("'", "''"),
                cmbStudenttGender.SelectedItem.ToString(),
                dtpStudentBirthdate.Value.ToString("yyyy-MM-dd"),
                nudStudentAge.Value,
                txtbxGuardianName.Text.Trim().Replace("'", "''"),
                txtbxStudentReligion.Text.Trim().Replace("'", "''"),
                nudStudentGradeLevel.Value,
                enrollmentIDValue,
                txtbxStudentHouseNo.Text.Trim().Replace("'", "''"),
                txtbxstudentStreet.Text.Trim().Replace("'", "''"),
                txtbxStudentBarangay.Text.Trim().Replace("'", "''"),
                txtbxStudentCity.Text.Trim().Replace("'", "''"),
                txtbxStudentProvince.Text.Trim().Replace("'", "''"),
                txtbxCountry.Text.Trim().Replace("'", "''"),
                txtbxZipCode.Text.Trim().Replace("'", "''")
            )

            ' Open connection and execute query
            modDBx.openConn(modDBx.db_name)

            Using cmd As New MySqlCommand(query, modDBx.conn)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Note: Logging functionality removed due to missing method
                    ' You can add your own logging implementation here if needed

                    ' Clear all fields after successful insert
                    ClearInputFields()

                    ' Refresh the DataGridView
                    LoadToDGV("SELECT * FROM student", dgvStudents)
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

        If String.IsNullOrWhiteSpace(txtbxstudentStreet.Text) Then
            MessageBox.Show("Please enter Street.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxstudentStreet.Focus()
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

        If String.IsNullOrWhiteSpace(txtbxCountry.Text) Then
            MessageBox.Show("Please enter Country.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbxCountry.Focus()
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

        Return False
 

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

        ' Reset numeric controls safely
        ResetNumericControl(nudStudentAge)
        ResetNumericControl(nudStudentGradeLevel)

        txtbxGuardianName.Clear()
        txtbxStudentReligion.Clear()

        txtbxStudentEnrollmentID.Clear()

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
        ' Set to minimum value, but ensure it's within valid range
        If nudControl.Minimum <= 0 AndAlso nudControl.Maximum >= 0 Then
            nudControl.Value = 0
        Else
            ' If 0 is not valid, set to the minimum value
            nudControl.Value = nudControl.Minimum
        End If
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

        ' Ensure age is within valid range for the control
        If age < nudStudentAge.Minimum Then
            nudStudentAge.Value = nudStudentAge.Minimum
        ElseIf age > nudStudentAge.Maximum Then
            nudStudentAge.Value = nudStudentAge.Maximum
        Else
            nudStudentAge.Value = age
        End If
    End Sub

    Private Function CalculateAge(birthDate As Date) As Integer
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year

        If birthDate > today.AddYears(-age) Then
            age -= 1
        End If

        Return age
    End Function

    ' Event handlers for various controls
    Private Sub txtStudentId_TextChanged(sender As Object, e As EventArgs)
        ' Handle text change if needed
    End Sub

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint

    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs)
        ' Handle text change if needed
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

    Private Sub grpAddress_Enter(sender As Object, e As EventArgs)
        ' Handle group box enter if needed
    End Sub

    Private Sub lblStudentBarangay_Click(sender As Object, e As EventArgs)
        ' Handle label click if needed
    End Sub

    Private Sub lblStudentProvince_Click(sender As Object, e As EventArgs)
        ' Handle label click if needed
    End Sub

    Private Sub lblStudentMiddleName_Click(sender As Object, e As EventArgs) Handles lblStudentMiddleName.Click
        ' Handle label click if needed
    End Sub

    Private Sub cmbStudenttGenderSelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudenttGender.SelectedIndexChanged
        ' Handle combo box selection change if needed
    End Sub

    Private Sub nudStudentAgeValueChanged(sender As Object, e As EventArgs) Handles nudStudentAge.ValueChanged
        ' Handle numeric up/down value change if needed
    End Sub

    Private Sub txtbxStudentSurnameTextChanged(sender As Object, e As EventArgs) Handles txtbxStudentSurname.TextChanged
        ' Handle text change if needed
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs)
        ' Handle label click if needed
    End Sub

    Private Sub txtbxZipCode_TextChanged(sender As Object, e As EventArgs)
        ' Handle text change if needed
    End Sub

    Private Sub txtbxZipCode_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Only allow digits and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtpStudentBirthdate_ValuesChanged(sender As Object, e As EventArgs) Handles dtpStudentBirthdate.ValueChanged
        ' This is already handled by dtpStudentBirthdate_ValueChanged
    End Sub

    Private Sub dgvStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellContentClick
        ' Handle cell content click if needed
    End Sub

    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvStudents.Rows(e.RowIndex)

            ' Store the StudentID (assuming it's the first column, index 0)
            currentStudentID = CInt(row.Cells(0).Value)

            txtbxStudentFirstName.Text = row.Cells("FirstName").Value.ToString()
            txtStudentMiddleName.Text = row.Cells("MiddleName").Value.ToString()
            txtbxStudentSurname.Text = row.Cells("LastName").Value.ToString()
            cmbStudenttGender.Text = row.Cells("Gender").Value.ToString()

            ' Birthdate (DateTimePicker)
            If Not IsDBNull(row.Cells("Birthdate").Value) Then
                dtpStudentBirthdate.Value = CDate(row.Cells("Birthdate").Value)
            End If

            txtbxStudentReligion.Text = row.Cells("Religion").Value.ToString()
            txtbxGuardianName.Text = row.Cells("GuardianName").Value.ToString()

            ' Numeric Up Downs
            If Not IsDBNull(row.Cells("Age").Value) Then
                nudStudentAge.Value = CInt(row.Cells("Age").Value)
            End If

            If Not IsDBNull(row.Cells("GradeLevel").Value) Then
                nudStudentGradeLevel.Value = CInt(row.Cells("GradeLevel").Value)
            End If

            ' SectionID retrieval (still needed for the textbox)


            txtbxStudentEnrollmentID.Text = row.Cells("EnrollmentID").Value.ToString()
            txtbxStudentHouseNo.Text = row.Cells("HouseNumber").Value.ToString()
            txtbxstudentStreet.Text = row.Cells("Street").Value.ToString()
            txtbxStudentBarangay.Text = row.Cells("Barangay").Value.ToString()
            txtbxStudentCity.Text = row.Cells("Municipality").Value.ToString()
            txtbxStudentProvince.Text = row.Cells("Province").Value.ToString()
            txtbxCountry.Text = row.Cells("Country").Value.ToString()
            txtbxZipCode.Text = row.Cells("ZIPCode").Value.ToString()
        End If
    End Sub

    Private Sub UpdateStudent()
        If currentStudentID = 0 Then
            MsgBox("No student selected for update.", MsgBoxStyle.Exclamation, "Update Error")
            Return
        End If

        Try
            ' Open Connection
            modDBx.openConn(modDBx.db_name)

            ' Define the SQL Update Statement using parameters
            Dim sql As String = "UPDATE student SET " &
                            "FirstName = @FirstName, " &
                            "MiddleName = @MiddleName, " &
                            "LastName = @LastName, " &
                            "Gender = @Gender, " &
                            "Birthdate = @Birthdate, " &
                            "Religion = @Religion, " &
                            "GuardianName = @GuardianName, " &
                            "Age = @Age, " &
                            "GradeLevel = @GradeLevel, " &
                            "SectionID = @SectionID, " &
                            "EnrollmentID = @EnrollmentID, " &
                            "HouseNumber = @HouseNumber, " &
                            "Street = @Street, " &
                            "Barangay = @Barangay, " &
                            "Municipality = @Municipality, " &
                            "Province = @Province, " &
                            "Country = @Country, " &
                            "ZIPCode = @ZIPCode " &
                            "WHERE StudentID = @StudentID"

            ' Create and Configure Command
            Using cmd As New MySqlCommand(sql, modDBx.conn)
                ' Add Parameters
                cmd.Parameters.AddWithValue("@FirstName", txtbxStudentFirstName.Text.Trim())
                cmd.Parameters.AddWithValue("@MiddleName", txtStudentMiddleName.Text.Trim())
                cmd.Parameters.AddWithValue("@LastName", txtbxStudentSurname.Text.Trim())
                cmd.Parameters.AddWithValue("@Gender", cmbStudenttGender.Text.Trim())
                cmd.Parameters.AddWithValue("@Birthdate", dtpStudentBirthdate.Value)
                cmd.Parameters.AddWithValue("@Religion", txtbxStudentReligion.Text.Trim())
                cmd.Parameters.AddWithValue("@GuardianName", txtbxGuardianName.Text.Trim())
                cmd.Parameters.AddWithValue("@Age", nudStudentAge.Value)
                cmd.Parameters.AddWithValue("@GradeLevel", nudStudentGradeLevel.Value)

                cmd.Parameters.AddWithValue("@EnrollmentID", txtbxStudentEnrollmentID.Text.Trim())
                cmd.Parameters.AddWithValue("@HouseNumber", txtbxStudentHouseNo.Text.Trim())
                cmd.Parameters.AddWithValue("@Street", txtbxstudentStreet.Text.Trim())
                cmd.Parameters.AddWithValue("@Barangay", txtbxStudentBarangay.Text.Trim())
                cmd.Parameters.AddWithValue("@Municipality", txtbxStudentCity.Text.Trim())
                cmd.Parameters.AddWithValue("@Province", txtbxStudentProvince.Text.Trim())
                cmd.Parameters.AddWithValue("@Country", txtbxCountry.Text.Trim())
                cmd.Parameters.AddWithValue("@ZIPCode", txtbxZipCode.Text.Trim())
                cmd.Parameters.AddWithValue("@StudentID", currentStudentID)

                ' Execute the Update
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Student updated successfully.", MsgBoxStyle.Information, "Update Success")
                    ' Reload the DataGridView to reflect changes
                    LoadToDGV("SELECT * FROM student", dgvStudents)
                    ' Clear the current selection or reset fields if needed
                    currentStudentID = 0
                Else
                    MsgBox("No student was updated. Please check the data.", MsgBoxStyle.Exclamation, "Update Failed")
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error updating student: " & ex.Message, MsgBoxStyle.Critical, "Update Error")
        Finally
            ' Close Connection safely
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    ' Example: Call UpdateStudent from a button click (add a button named btnUpdateStudent)
    Private Sub SearchStudentsBySurname(ByVal surname As String)
        ' 1. If the search box is empty, load all students (default view)
        If String.IsNullOrWhiteSpace(surname) Then
            LoadToDGV("SELECT * FROM student", dgvStudents)
            Return
        End If

        Try
            ' 2. Open Connection
            modDBx.openConn(modDBx.db_name)

            ' 3. Define the SQL Search Statement using parameters
            ' We use LIKE and wildcards (%) for partial and case-insensitive matching.
            Dim sql As String = "SELECT * FROM student WHERE LastName LIKE @searchSurname ORDER BY LastName"

            ' 4. Create and Configure Command
            Using cmd As New MySqlCommand(sql, modDBx.conn)
                ' 5. Add Parameter with Wildcards
                ' The database column is 'LastName', which the user enters in the search box (Surname).
                cmd.Parameters.AddWithValue("@searchSurname", "%" & surname.Trim() & "%")

                ' 6. Execute and Load Data into a DataTable
                Dim dt As New System.Data.DataTable
                Using adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                ' 7. Update the DataGridView
                dgvStudents.DataSource = dt
                dgvStudents.Refresh()

                ' Hide the primary key column (StudentID is usually the first column)
                If dgvStudents.ColumnCount > 0 Then
                    dgvStudents.Columns(0).Visible = False
                End If

                ' Notification
                If dt.Rows.Count = 0 Then
                    MsgBox("No student found matching the surname '" & surname & "'.", MsgBoxStyle.Information, "Search Result")
                End If

            End Using

        Catch ex As Exception
            MsgBox("Error searching students: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            ' 8. Close Connection safely
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = System.Data.ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub
    Private Sub TextBoxStudentSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxStudentSearch.TextChanged
        SearchStudentsBySurname(TextBoxStudentSearch.Text)
    End Sub

    Private Sub btnStudentSearch_Click(sender As Object, e As EventArgs)
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

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtbxStudentProvince.TextChanged

    End Sub



    ' test123

End Class
