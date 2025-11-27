Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ManageEnrollmentForms
    Public Property IsEmbedded As Boolean = False
    Private currentEnrollmentID As Integer = 0

    ' Define the current school year
    Private currentSchoolYearStart As Date = New Date(2025, 8, 1) ' August 2025
    Private currentSchoolYearEnd As Date = New Date(2026, 5, 31) ' May 2026

    Private Sub ManageEnrollmentForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            ' StyleSidebarButtons() ' Uncomment if you have sidebar buttons
            ' PositionSidebarButtons() ' Uncomment if you have sidebar buttons
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Else
            ' pnlSidebar.Visible = False ' Uncomment if you have sidebar panel
            ' pnlContent.Dock = DockStyle.Fill ' Uncomment if you have content panel
        End If

        ' Initialize ComboBoxes
        InitializeEnrollmentModeComboBox()
        InitializeEnrollmentStatusComboBox()
        InitializePaymentStatusComboBox()
        InitializeRequirementStatusComboBox()
        InitializeModeOfPaymentComboBox()

        ' Load enrollment data
        LoadToDGV("SELECT * FROM enrollment", dgvEnrollment)

        ' Set CreatedDate to current date and make it readonly
        dtpDateCreated.Value = DateTime.Now
        dtpDateCreated.Enabled = False

        ' Set CreatedBy to current user
        txtbxEnrollCreatedBy.Text = "" ' Set to current user

        ' Ensure Add button is enabled by default
        btnEnrollAdd.Enabled = True

        ' Ensure the grid doesn't auto-select the first row on load
        dgvEnrollment.ClearSelection()
        Try
            If dgvEnrollment.Rows.Count > 0 AndAlso dgvEnrollment.Columns.Count > 0 Then
                dgvEnrollment.CurrentCell = Nothing
            End If
        Catch
            ' ignore potential layout timing exceptions
        End Try
        currentEnrollmentID = 0

        ' Initialize mode of payment based on payment status
        UpdateModeOfPaymentAvailability()
    End Sub

    ' ===== COMBOBOX INITIALIZATION METHODS =====
    Private Sub InitializeEnrollmentModeComboBox()
        ComboBoxEnrollmentMode.Items.Clear()
        ComboBoxEnrollmentMode.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxEnrollmentMode.Items.Add("Online")
        ComboBoxEnrollmentMode.Items.Add("Walk-In")
    End Sub

    Private Sub InitializeEnrollmentStatusComboBox()
        ComboBoxEnrollmentStatus.Items.Clear()
        ComboBoxEnrollmentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxEnrollmentStatus.Items.Add("Enrolled")
        ComboBoxEnrollmentStatus.Items.Add("Not Enrolled")
    End Sub

    Private Sub InitializePaymentStatusComboBox()
        ComboBoxEnrollmentPaymentStatus.Items.Clear()
        ComboBoxEnrollmentPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxEnrollmentPaymentStatus.Items.Add("Paid")
        ComboBoxEnrollmentPaymentStatus.Items.Add("Unpaid")
    End Sub

    Private Sub InitializeRequirementStatusComboBox()
        cmbEnrollmentRequirementStatus.Items.Clear()
        cmbEnrollmentRequirementStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEnrollmentRequirementStatus.Items.Add("Complete")
        cmbEnrollmentRequirementStatus.Items.Add("Incomplete")
    End Sub

    Private Sub InitializeModeOfPaymentComboBox()
        ComboBoxEnrollmentModeofPayment.Items.Clear()
        ComboBoxEnrollmentModeofPayment.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxEnrollmentModeofPayment.Items.Add("Cash")
        ComboBoxEnrollmentModeofPayment.Items.Add("Online")
    End Sub

    ' ===== ID VALIDATION METHODS =====
    Private Function StudentIDExists(studentID As String) As Boolean
        If String.IsNullOrWhiteSpace(studentID) Then
            Return False
        End If

        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT COUNT(*) FROM student WHERE StudentID = @StudentID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@StudentID", CInt(studentID))
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error checking student ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    Private Function SectionIDExists(sectionID As String) As Boolean
        If String.IsNullOrWhiteSpace(sectionID) Then
            Return False
        End If

        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT COUNT(*) FROM section WHERE SectionID = @SectionID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@SectionID", CInt(sectionID))
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error checking section ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    ' ===== DATE-BASED STATUS CALCULATION METHODS =====
    Private Function CalculateEnrollmentStatus(startDate As Date, endDate As Date) As String
        Dim today As Date = DateTime.Today

        ' If current date is before or equal to end date, status is "Enrolled"
        ' If current date is after end date, status is "Not Enrolled"
        If today <= endDate Then
            Return "Enrolled"
        Else
            Return "Not Enrolled"
        End If
    End Function

    Private Sub AutoSetStatusBasedOnDates()
        Dim calculatedStatus As String = CalculateEnrollmentStatus(dtpEnrollmentStartDate.Value, dtpEnrollmentEndDate.Value)
        ComboBoxEnrollmentStatus.SelectedItem = calculatedStatus
    End Sub

    ' ===== PAYMENT STATUS AND MODE OF PAYMENT HANDLING =====
    Private Sub UpdateModeOfPaymentAvailability()
        If ComboBoxEnrollmentPaymentStatus.SelectedItem IsNot Nothing AndAlso ComboBoxEnrollmentPaymentStatus.SelectedItem.ToString() = "Paid" Then
            ComboBoxEnrollmentModeofPayment.Enabled = True
        Else
            ComboBoxEnrollmentModeofPayment.Enabled = False
            ComboBoxEnrollmentModeofPayment.SelectedIndex = -1
        End If
    End Sub

    Private Sub ComboBoxEnrollmentPaymentStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEnrollmentPaymentStatus.SelectedIndexChanged
        UpdateModeOfPaymentAvailability()
    End Sub

    ' ===== ID VALIDATION EVENT HANDLERS =====
    Private Sub txtbxEnrollmentStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtbxEnrollmentStudentID.TextChanged
        ' Validate Student ID as user types (for new enrollments only)
        If currentEnrollmentID = 0 AndAlso Not String.IsNullOrWhiteSpace(txtbxEnrollmentStudentID.Text) Then
            If Not Integer.TryParse(txtbxEnrollmentStudentID.Text, Nothing) Then
                txtbxEnrollmentStudentID.BackColor = Color.LightPink
            Else
                txtbxEnrollmentStudentID.BackColor = SystemColors.Window
            End If
        End If
    End Sub

    Private Sub txtbxEnrollmentStudentID_Leave(sender As Object, e As EventArgs) Handles txtbxEnrollmentStudentID.Leave
        ' Validate Student ID when user leaves the field
        If Not String.IsNullOrWhiteSpace(txtbxEnrollmentStudentID.Text) Then
            If Not Integer.TryParse(txtbxEnrollmentStudentID.Text, Nothing) Then
                MessageBox.Show("Student ID must be a valid number.", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtbxEnrollmentStudentID.BackColor = Color.LightPink
                txtbxEnrollmentStudentID.Focus()
            ElseIf Not StudentIDExists(txtbxEnrollmentStudentID.Text.Trim()) Then
                MessageBox.Show("Student ID does not exist in the system. Please enter a valid Student ID.", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtbxEnrollmentStudentID.BackColor = Color.LightPink
                txtbxEnrollmentStudentID.Focus()
            Else
                txtbxEnrollmentStudentID.BackColor = SystemColors.Window
            End If
        Else
            txtbxEnrollmentStudentID.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtbxEnrollSectionID_TextChanged(sender As Object, e As EventArgs) Handles txtbxEnrollSectionID.TextChanged
        ' Validate Section ID as user types (for new enrollments only)
        If currentEnrollmentID = 0 AndAlso Not String.IsNullOrWhiteSpace(txtbxEnrollSectionID.Text) Then
            If Not Integer.TryParse(txtbxEnrollSectionID.Text, Nothing) Then
                txtbxEnrollSectionID.BackColor = Color.LightPink
            Else
                txtbxEnrollSectionID.BackColor = SystemColors.Window
            End If
        End If
    End Sub

    Private Sub txtbxEnrollSectionID_Leave(sender As Object, e As EventArgs) Handles txtbxEnrollSectionID.Leave
        ' Validate Section ID when user leaves the field
        If Not String.IsNullOrWhiteSpace(txtbxEnrollSectionID.Text) Then
            If Not Integer.TryParse(txtbxEnrollSectionID.Text, Nothing) Then
                MessageBox.Show("Section ID must be a valid number.", "Invalid Section ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtbxEnrollSectionID.BackColor = Color.LightPink
                txtbxEnrollSectionID.Focus()
            ElseIf Not SectionIDExists(txtbxEnrollSectionID.Text.Trim()) Then
                MessageBox.Show("Section ID does not exist in the system. Please enter a valid Section ID.", "Invalid Section ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtbxEnrollSectionID.BackColor = Color.LightPink
                txtbxEnrollSectionID.Focus()
            Else
                txtbxEnrollSectionID.BackColor = SystemColors.Window
            End If
        Else
            txtbxEnrollSectionID.BackColor = SystemColors.Window
        End If
    End Sub

    ' ===== DATE EVENT HANDLERS =====
    Private Sub dtpEnrollmentStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEnrollmentStartDate.ValueChanged
        ' Auto-update status when dates change (only for new enrollments)
        If currentEnrollmentID = 0 Then
            AutoSetStatusBasedOnDates()
        End If
    End Sub

    Private Sub dtpEnrollmentEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEnrollmentEndDate.ValueChanged
        ' Auto-update status when dates change (only for new enrollments)
        If currentEnrollmentID = 0 Then
            AutoSetStatusBasedOnDates()
        End If
    End Sub

    ' ===== MAIN ENROLLMENT OPERATIONS =====
    Private Sub btnEnrollAdd_Click(sender As Object, e As EventArgs) Handles btnEnrollAdd.Click
        ' If a row is currently selected, prevent adding and show error
        If currentEnrollmentID <> 0 Then
            MessageBox.Show("Please clear the selection before adding a new enrollment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Automatically set status based on dates BEFORE validation
        AutoSetStatusBasedOnDates()

        ' Validate required fields FIRST
        If Not ValidateEnrollmentInputs() Then
            Return ' Stop execution if validation fails
        End If

        ' Check if ReferenceNumber already exists
        If EnrollmentRefNumExists(TextBoxEnrollmentRefNum.Text.Trim()) Then
            MessageBox.Show("Reference Number already exists. Please use a unique Reference Number.", "Duplicate Reference Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Add enrollment to database
        Try
            Dim query As String = "INSERT INTO enrollment (" &
                            "StudentID, SectionID, GradeLevel, StartDate, EndDate, " &
                            "EnrollmentMode, EnrollmentStatus, ModeOfPayment, PaymentStatus, " &
                            "RequirementStatus, ReferenceNumber, Remarks, CreatedDate, CreatedBy" &
                            ") VALUES (" &
                            "@StudentID, @SectionID, @GradeLevel, @StartDate, @EndDate, " &
                            "@EnrollmentMode, @EnrollmentStatus, @ModeOfPayment, @PaymentStatus, " &
                            "@RequirementStatus, @ReferenceNumber, @Remarks, @CreatedDate, @CreatedBy)"

            modDBx.openConn(modDBx.db_name)

            Using cmd As New MySqlCommand(query, modDBx.conn)
                ' Student and Section Information
                cmd.Parameters.AddWithValue("@StudentID", CInt(txtbxEnrollmentStudentID.Text.Trim()))
                cmd.Parameters.AddWithValue("@SectionID", CInt(txtbxEnrollSectionID.Text.Trim()))
                cmd.Parameters.AddWithValue("@GradeLevel", nudEnrollmentGradeLevel.Value)

                ' Dates
                cmd.Parameters.AddWithValue("@StartDate", dtpEnrollmentStartDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@EndDate", dtpEnrollmentEndDate.Value.ToString("yyyy-MM-dd"))

                ' Enrollment Details
                Dim enrollmentMode As String = ""
                If ComboBoxEnrollmentMode.SelectedItem IsNot Nothing Then
                    enrollmentMode = ComboBoxEnrollmentMode.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@EnrollmentMode", enrollmentMode)

                Dim enrollmentStatus As String = ""
                If ComboBoxEnrollmentStatus.SelectedItem IsNot Nothing Then
                    enrollmentStatus = ComboBoxEnrollmentStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@EnrollmentStatus", enrollmentStatus)

                Dim paymentStatus As String = ""
                If ComboBoxEnrollmentPaymentStatus.SelectedItem IsNot Nothing Then
                    paymentStatus = ComboBoxEnrollmentPaymentStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus)

                ' Mode of Payment - only if payment status is Paid
                Dim modeOfPayment As String = ""
                If ComboBoxEnrollmentPaymentStatus.SelectedItem IsNot Nothing AndAlso ComboBoxEnrollmentPaymentStatus.SelectedItem.ToString() = "Paid" Then
                    If ComboBoxEnrollmentModeofPayment.SelectedItem IsNot Nothing Then
                        modeOfPayment = ComboBoxEnrollmentModeofPayment.SelectedItem.ToString()
                    End If
                End If
                cmd.Parameters.AddWithValue("@ModeOfPayment", modeOfPayment)

                Dim requirementStatus As String = ""
                If cmbEnrollmentRequirementStatus.SelectedItem IsNot Nothing Then
                    requirementStatus = cmbEnrollmentRequirementStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@RequirementStatus", requirementStatus)

                ' Reference and Remarks
                cmd.Parameters.AddWithValue("@ReferenceNumber", SafeString(TextBoxEnrollmentRefNum.Text))
                cmd.Parameters.AddWithValue("@Remarks", ConvertToProperCase(SafeString(txtbxEnrollmentRemarks.Text)))

                ' Created By and Date Created
                cmd.Parameters.AddWithValue("@CreatedDate", dtpDateCreated.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@CreatedBy", SafeString(txtbxEnrollCreatedBy.Text))

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Enrollment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearEnrollmentFields()
                    LoadToDGV("SELECT * FROM enrollment", dgvEnrollment)
                Else
                    MessageBox.Show("Failed to add enrollment. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnEnrollDelete_Click(sender As Object, e As EventArgs) Handles btnEnrollDelete.Click
        ' Check if an enrollment is selected
        If currentEnrollmentID = 0 Then
            MessageBox.Show("Please select an enrollment to delete.", "Delete Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Confirm deletion
        If MessageBox.Show("Are you sure you want to delete this enrollment?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
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
                    ClearEnrollmentFields()
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

    Private Sub btnEnrollUpdate_Click(sender As Object, e As EventArgs) Handles btnEnrollUpdate.Click
        UpdateEnrollment()
    End Sub

    Private Sub UpdateEnrollment()
        ' Check if an enrollment is selected
        If currentEnrollmentID = 0 Then
            MessageBox.Show("No enrollment selected for update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' For existing enrollments, allow manual status override but show warning if dates don't match
        Dim calculatedStatus As String = CalculateEnrollmentStatus(dtpEnrollmentStartDate.Value, dtpEnrollmentEndDate.Value)
        Dim selectedStatus As String = If(ComboBoxEnrollmentStatus.SelectedItem IsNot Nothing, ComboBoxEnrollmentStatus.SelectedItem.ToString(), "")

        If selectedStatus <> calculatedStatus Then
            Dim result As DialogResult = MessageBox.Show(
                "The selected status doesn't match the date range." & vbCrLf &
                "Calculated status based on dates: " & calculatedStatus & vbCrLf & vbCrLf &
                "Do you want to keep the manually selected status?" & vbCrLf &
                "Yes = Keep manual status" & vbCrLf &
                "No = Use calculated status based on dates",
                "Status Mismatch",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

            If result = DialogResult.No Then
                ComboBoxEnrollmentStatus.SelectedItem = calculatedStatus
            End If
        End If

        ' Validate required fields FIRST using the same validation as Add
        If Not ValidateEnrollmentInputs() Then
            Return ' Stop execution if validation fails
        End If

        ' Check if ReferenceNumber already exists (excluding current enrollment)
        If EnrollmentRefNumExists(TextBoxEnrollmentRefNum.Text.Trim(), currentEnrollmentID) Then
            MessageBox.Show("Reference Number already exists. Please use a unique Reference Number.", "Duplicate Reference Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if any data has actually changed
        If Not HasEnrollmentDataChanged() Then
            MessageBox.Show("No changes were made to the enrollment data.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            modDBx.openConn(modDBx.db_name)

            Dim sql As String = "UPDATE enrollment SET " &
                "StudentID = @StudentID, " &
                "SectionID = @SectionID, " &
                "GradeLevel = @GradeLevel, " &
                "StartDate = @StartDate, " &
                "EndDate = @EndDate, " &
                "EnrollmentMode = @EnrollmentMode, " &
                "EnrollmentStatus = @EnrollmentStatus, " &
                "ModeOfPayment = @ModeOfPayment, " &
                "PaymentStatus = @PaymentStatus, " &
                "RequirementStatus = @RequirementStatus, " &
                "ReferenceNumber = @ReferenceNumber, " &
                "Remarks = @Remarks, " &
                "CreatedDate = @CreatedDate, " &
                "CreatedBy = @CreatedBy " &
                "WHERE EnrollmentID = @EnrollmentID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                ' Student and Section Information
                cmd.Parameters.AddWithValue("@StudentID", CInt(txtbxEnrollmentStudentID.Text.Trim()))
                cmd.Parameters.AddWithValue("@SectionID", CInt(txtbxEnrollSectionID.Text.Trim()))
                cmd.Parameters.AddWithValue("@GradeLevel", nudEnrollmentGradeLevel.Value)

                ' Dates
                cmd.Parameters.AddWithValue("@StartDate", dtpEnrollmentStartDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@EndDate", dtpEnrollmentEndDate.Value.ToString("yyyy-MM-dd"))

                ' Enrollment Details
                Dim enrollmentMode As String = ""
                If ComboBoxEnrollmentMode.SelectedItem IsNot Nothing Then
                    enrollmentMode = ComboBoxEnrollmentMode.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@EnrollmentMode", enrollmentMode)

                Dim enrollmentStatus As String = ""
                If ComboBoxEnrollmentStatus.SelectedItem IsNot Nothing Then
                    enrollmentStatus = ComboBoxEnrollmentStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@EnrollmentStatus", enrollmentStatus)

                Dim paymentStatus As String = ""
                If ComboBoxEnrollmentPaymentStatus.SelectedItem IsNot Nothing Then
                    paymentStatus = ComboBoxEnrollmentPaymentStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus)

                ' Mode of Payment - only if payment status is Paid
                Dim modeOfPayment As String = ""
                If ComboBoxEnrollmentPaymentStatus.SelectedItem IsNot Nothing AndAlso ComboBoxEnrollmentPaymentStatus.SelectedItem.ToString() = "Paid" Then
                    If ComboBoxEnrollmentModeofPayment.SelectedItem IsNot Nothing Then
                        modeOfPayment = ComboBoxEnrollmentModeofPayment.SelectedItem.ToString()
                    End If
                End If
                cmd.Parameters.AddWithValue("@ModeOfPayment", modeOfPayment)

                Dim requirementStatus As String = ""
                If cmbEnrollmentRequirementStatus.SelectedItem IsNot Nothing Then
                    requirementStatus = cmbEnrollmentRequirementStatus.SelectedItem.ToString()
                End If
                cmd.Parameters.AddWithValue("@RequirementStatus", requirementStatus)

                ' Reference and Remarks
                cmd.Parameters.AddWithValue("@ReferenceNumber", SafeString(TextBoxEnrollmentRefNum.Text))
                cmd.Parameters.AddWithValue("@Remarks", ConvertToProperCase(SafeString(txtbxEnrollmentRemarks.Text)))

                ' Created By and Date Created
                cmd.Parameters.AddWithValue("@CreatedDate", dtpDateCreated.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@CreatedBy", SafeString(txtbxEnrollCreatedBy.Text))

                cmd.Parameters.AddWithValue("@EnrollmentID", currentEnrollmentID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Enrollment updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Clear inputs and re-enable Add after successful update
                    ClearEnrollmentFields()
                    LoadToDGV("SELECT * FROM enrollment", dgvEnrollment)
                    currentEnrollmentID = 0
                Else
                    MessageBox.Show("No enrollment was updated. Please check the data.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error updating enrollment: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Function EnrollmentRefNumExists(refNum As String, Optional excludeEnrollmentID As Integer = 0) As Boolean
        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT COUNT(*) FROM enrollment WHERE ReferenceNumber = @ReferenceNumber"

            If excludeEnrollmentID > 0 Then
                sql &= " AND EnrollmentID != @EnrollmentID"
            End If

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@ReferenceNumber", refNum)
                If excludeEnrollmentID > 0 Then
                    cmd.Parameters.AddWithValue("@EnrollmentID", excludeEnrollmentID)
                End If

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error checking reference number: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True ' Return true to be safe and prevent potential duplicates
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    Private Function HasEnrollmentDataChanged() As Boolean
        ' Get the current enrollment data from database to compare
        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT * FROM enrollment WHERE EnrollmentID = @EnrollmentID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@EnrollmentID", currentEnrollmentID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Compare each field with current form values
                        If GetSafeStringFromDB(reader("StudentID")) <> txtbxEnrollmentStudentID.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("SectionID")) <> txtbxEnrollSectionID.Text.Trim() Then Return True
                        If Convert.ToInt32(reader("GradeLevel")) <> nudEnrollmentGradeLevel.Value Then Return True
                        If GetSafeStringFromDB(reader("EnrollmentMode")) <> ComboBoxEnrollmentMode.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("EnrollmentStatus")) <> ComboBoxEnrollmentStatus.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("ModeOfPayment")) <> ComboBoxEnrollmentModeofPayment.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("PaymentStatus")) <> ComboBoxEnrollmentPaymentStatus.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("RequirementStatus")) <> cmbEnrollmentRequirementStatus.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("ReferenceNumber")) <> TextBoxEnrollmentRefNum.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("Remarks")) <> txtbxEnrollmentRemarks.Text.Trim() Then Return True
                        If GetSafeStringFromDB(reader("CreatedBy")) <> txtbxEnrollCreatedBy.Text.Trim() Then Return True

                        If Convert.ToDateTime(reader("StartDate")).ToString("yyyy-MM-dd") <> dtpEnrollmentStartDate.Value.ToString("yyyy-MM-dd") Then Return True
                        If Convert.ToDateTime(reader("EndDate")).ToString("yyyy-MM-dd") <> dtpEnrollmentEndDate.Value.ToString("yyyy-MM-dd") Then Return True
                        If Convert.ToDateTime(reader("CreatedDate")).ToString("yyyy-MM-dd") <> dtpDateCreated.Value.ToString("yyyy-MM-dd") Then Return True
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

    Private Function ValidateEnrollmentInputs() As Boolean
        Dim errors As New List(Of String)

        ' 1. Student ID Validation
        If String.IsNullOrWhiteSpace(txtbxEnrollmentStudentID.Text) Then
            errors.Add("• Student ID is required")
        ElseIf Not Integer.TryParse(txtbxEnrollmentStudentID.Text, Nothing) Then
            errors.Add("• Student ID must be a valid number")
        ElseIf Not StudentIDExists(txtbxEnrollmentStudentID.Text.Trim()) Then
            errors.Add("• Student ID does not exist in the system")
        End If

        ' 2. Section ID Validation
        If String.IsNullOrWhiteSpace(txtbxEnrollSectionID.Text) Then
            errors.Add("• Section ID is required")
        ElseIf Not Integer.TryParse(txtbxEnrollSectionID.Text, Nothing) Then
            errors.Add("• Section ID must be a valid number")
        ElseIf Not SectionIDExists(txtbxEnrollSectionID.Text.Trim()) Then
            errors.Add("• Section ID does not exist in the system")
        End If

        ' 3. Grade Level Validation
        If nudEnrollmentGradeLevel.Value < 1 Or nudEnrollmentGradeLevel.Value > 12 Then
            errors.Add("• Grade Level must be between 1 and 12")
        End If

        ' 4. Enrollment Mode Validation
        If ComboBoxEnrollmentMode.SelectedIndex = -1 Then
            errors.Add("• Enrollment Mode is required")
        End If

        ' 5. Enrollment Status Validation
        If ComboBoxEnrollmentStatus.SelectedIndex = -1 Then
            errors.Add("• Enrollment Status is required")
        End If

        ' 6. Payment Status Validation
        If ComboBoxEnrollmentPaymentStatus.SelectedIndex = -1 Then
            errors.Add("• Payment Status is required")
        End If

        ' 7. Requirement Status Validation
        If cmbEnrollmentRequirementStatus.SelectedIndex = -1 Then
            errors.Add("• Requirement Status is required")
        End If

        ' 8. Reference Number Validation
        If String.IsNullOrWhiteSpace(TextBoxEnrollmentRefNum.Text) Then
            errors.Add("• Reference Number is required")
        End If

        ' 9. Mode of Payment Validation - Only required if Payment Status is "Paid"
        If ComboBoxEnrollmentPaymentStatus.SelectedItem IsNot Nothing AndAlso ComboBoxEnrollmentPaymentStatus.SelectedItem.ToString() = "Paid" Then
            If ComboBoxEnrollmentModeofPayment.SelectedIndex = -1 Then
                errors.Add("• Mode of Payment is required when Payment Status is 'Paid'")
            End If
        End If

        ' 10. Date Validation
        If dtpEnrollmentEndDate.Value <= dtpEnrollmentStartDate.Value Then
            errors.Add("• End Date must be after Start Date")
        End If

        ' 11. Created By Validation
        If String.IsNullOrWhiteSpace(txtbxEnrollCreatedBy.Text) Then
            errors.Add("• Created By is required")
        End If

        ' Check if there are any validation errors
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

    ' Helper function for safe string retrieval from database
    Private Function GetSafeStringFromDB(dbValue As Object) As String
        Return If(dbValue Is Nothing OrElse IsDBNull(dbValue), "", dbValue.ToString())
    End Function

    Private Sub ClearEnrollmentFields()
        ' Clear all input fields after successful add or when un-selecting a row

        ' Student and Section Information
        txtbxEnrollmentStudentID.Clear()
        txtbxEnrollSectionID.Clear()
        nudEnrollmentGradeLevel.Value = 1

        ' Enrollment Details
        ComboBoxEnrollmentMode.SelectedIndex = -1
        ComboBoxEnrollmentStatus.SelectedIndex = -1
        ComboBoxEnrollmentPaymentStatus.SelectedIndex = -1
        cmbEnrollmentRequirementStatus.SelectedIndex = -1
        ComboBoxEnrollmentModeofPayment.SelectedIndex = -1
        TextBoxEnrollmentRefNum.Clear()

        ' Dates
        dtpEnrollmentStartDate.Value = DateTime.Now
        dtpEnrollmentEndDate.Value = DateTime.Now.AddMonths(6) ' Default 6-month duration
        AutoSetStatusBasedOnDates() ' Calculate status for default dates

        ' Remarks
        txtbxEnrollmentRemarks.Clear()

        ' Date and Created By (reset to defaults)
        dtpDateCreated.Value = DateTime.Now
        txtbxEnrollCreatedBy.Text = ""

        ' Reset ID background colors
        txtbxEnrollmentStudentID.BackColor = SystemColors.Window
        txtbxEnrollSectionID.BackColor = SystemColors.Window

        ' Reset current enrollment selection
        currentEnrollmentID = 0

        ' Re-enable Add button so user can create a new record
        btnEnrollAdd.Enabled = True

        ' Update mode of payment availability
        UpdateModeOfPaymentAvailability()

        ' Set focus back to first field
        txtbxEnrollmentStudentID.Focus()
    End Sub

    Private Sub dgvEnrollment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnrollment.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim row As DataGridViewRow = dgvEnrollment.Rows(e.RowIndex)

        ' Safely read the EnrollmentID in the clicked row
        Dim clickedID As Integer = 0
        If row.Cells.Count > 0 AndAlso row.Cells(0).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(0).Value) Then
            Integer.TryParse(row.Cells(0).Value.ToString(), clickedID)
        End If

        ' If the user clicked the already-selected row, clear selection and inputs
        If clickedID <> 0 AndAlso clickedID = currentEnrollmentID Then
            dgvEnrollment.ClearSelection()
            currentEnrollmentID = 0
            ClearEnrollmentFields()
            Return
        End If

        ' Otherwise populate fields for the newly selected row
        If clickedID <> 0 Then
            currentEnrollmentID = clickedID

            txtbxEnrollmentStudentID.Text = GetSafeString(row.Cells("StudentID"))
            txtbxEnrollSectionID.Text = GetSafeString(row.Cells("SectionID"))

            If Not IsDBNull(row.Cells("GradeLevel").Value) Then
                nudEnrollmentGradeLevel.Value = Convert.ToDecimal(row.Cells("GradeLevel").Value)
            End If

            ComboBoxEnrollmentMode.Text = GetSafeString(row.Cells("EnrollmentMode"))
            ComboBoxEnrollmentStatus.Text = GetSafeString(row.Cells("EnrollmentStatus"))
            ComboBoxEnrollmentModeofPayment.Text = GetSafeString(row.Cells("ModeOfPayment"))
            ComboBoxEnrollmentPaymentStatus.Text = GetSafeString(row.Cells("PaymentStatus"))
            cmbEnrollmentRequirementStatus.Text = GetSafeString(row.Cells("RequirementStatus"))
            TextBoxEnrollmentRefNum.Text = GetSafeString(row.Cells("ReferenceNumber"))
            txtbxEnrollmentRemarks.Text = GetSafeString(row.Cells("Remarks"))
            txtbxEnrollCreatedBy.Text = GetSafeString(row.Cells("CreatedBy"))

            If Not IsDBNull(row.Cells("StartDate").Value) Then
                dtpEnrollmentStartDate.Value = CDate(row.Cells("StartDate").Value)
            End If

            If Not IsDBNull(row.Cells("EndDate").Value) Then
                dtpEnrollmentEndDate.Value = CDate(row.Cells("EndDate").Value)
            End If

            If Not IsDBNull(row.Cells("CreatedDate").Value) Then
                dtpDateCreated.Value = CDate(row.Cells("CreatedDate").Value)
            End If

            ' For existing records, enable manual status override
            ComboBoxEnrollmentStatus.Enabled = True

            ' Validate IDs if present
            If Not String.IsNullOrWhiteSpace(txtbxEnrollmentStudentID.Text) Then
                If StudentIDExists(txtbxEnrollmentStudentID.Text.Trim()) Then
                    txtbxEnrollmentStudentID.BackColor = SystemColors.Window
                Else
                    txtbxEnrollmentStudentID.BackColor = Color.LightPink
                End If
            Else
                txtbxEnrollmentStudentID.BackColor = SystemColors.Window
            End If

            If Not String.IsNullOrWhiteSpace(txtbxEnrollSectionID.Text) Then
                If SectionIDExists(txtbxEnrollSectionID.Text.Trim()) Then
                    txtbxEnrollSectionID.BackColor = SystemColors.Window
                Else
                    txtbxEnrollSectionID.BackColor = Color.LightPink
                End If
            Else
                txtbxEnrollSectionID.BackColor = SystemColors.Window
            End If

            ' Update mode of payment availability
            UpdateModeOfPaymentAvailability()

            ' Keep Add button enabled
            btnEnrollAdd.Enabled = True
        End If
    End Sub

    ' Helper function for safe string retrieval from DataGridView
    Private Function GetSafeString(cell As DataGridViewCell) As String
        Return If(cell.Value Is Nothing OrElse IsDBNull(cell.Value), "", cell.Value.ToString())
    End Function

    ' Apply Proper Case when leaving text fields
    Private Sub txtbxEnrollmentRemarks_Leave(sender As Object, e As EventArgs) Handles txtbxEnrollmentRemarks.Leave
        If Not String.IsNullOrWhiteSpace(txtbxEnrollmentRemarks.Text) Then
            txtbxEnrollmentRemarks.Text = ConvertToProperCase(txtbxEnrollmentRemarks.Text.Trim())
        End If
    End Sub

    ' Ensure selection is cleared after any data binding operation
    Private Sub dgvEnrollment_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvEnrollment.DataBindingComplete
        dgvEnrollment.ClearSelection()
        Try
            If dgvEnrollment.Rows.Count > 0 AndAlso dgvEnrollment.Columns.Count > 0 Then
                dgvEnrollment.CurrentCell = Nothing
            End If
        Catch
            ' ignore - layout timing may prevent clearing CurrentCell
        End Try
    End Sub

    ' Final fallback after form is shown
    Private Sub ManageEnrollmentForms_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dgvEnrollment.ClearSelection()
        Try
            If dgvEnrollment.Rows.Count > 0 AndAlso dgvEnrollment.Columns.Count > 0 Then
                dgvEnrollment.CurrentCell = Nothing
            End If
        Catch
        End Try

        ' Move focus to first input so the grid doesn't appear focused
        txtbxEnrollmentStudentID.Focus()
    End Sub

    ' ===== SEARCH FUNCTIONALITY =====
    Private Sub SearchEnrollments(ByVal searchText As String)
        ' If the search box is empty, load all enrollments (default view)
        If String.IsNullOrWhiteSpace(searchText) Then
            LoadToDGV("SELECT * FROM enrollment", dgvEnrollment)
            Return
        End If

        Try
            ' Open Connection
            modDBx.openConn(modDBx.db_name)

            ' Search by ReferenceNumber, StudentID, or SectionID
            Dim sql As String = "SELECT * FROM enrollment WHERE ReferenceNumber LIKE @searchText OR StudentID LIKE @searchText OR SectionID LIKE @searchText ORDER BY EnrollmentID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                ' Use searchText + '%' to match from the beginning
                cmd.Parameters.AddWithValue("@searchText", searchText.Trim() & "%")

                Dim dt As New System.Data.DataTable
                Using adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                ' Ensure grid will generate columns for the DataTable if not already configured
                dgvEnrollment.AutoGenerateColumns = True
                dgvEnrollment.DataSource = dt
                dgvEnrollment.Refresh()

                ' Make sure any "id" column (EnrollmentID) is visible and placed as the first column
                For Each col As DataGridViewColumn In dgvEnrollment.Columns
                    Dim checkName As String = If(col.DataPropertyName, "").ToLower()
                    Dim checkHeader As String = If(col.HeaderText, "").ToLower()
                    If checkName.Contains("enrollmentid") OrElse checkName.Contains("id") OrElse checkHeader.Contains("enrollmentid") OrElse checkHeader.Contains("id") Then
                        col.Visible = True
                        col.HeaderText = "EnrollmentID"
                        col.DisplayIndex = 0
                        Exit For
                    End If
                Next

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("No enrollment found matching '" & searchText & "'.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching enrollment: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = System.Data.ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub TextBoxEnrollmentSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEnrollSearch.TextChanged
        SearchEnrollments(TextBoxEnrollSearch.Text)
    End Sub

    ' Database helper method
    Private Sub LoadToDGV(sql As String, dgv As DataGridView)
        Try
            modDBx.openConn(modDBx.db_name)
            Dim dt As New System.Data.DataTable
            Using adapter As New MySqlDataAdapter(sql, modDBx.conn)
                adapter.Fill(dt)
            End Using

            ' Let the grid auto-generate columns from the DataTable
            dgv.AutoGenerateColumns = True
            dgv.DataSource = dt
            dgv.Refresh()

            ' Ensure any ID-like column (EnrollmentID) is visible and shown as first column
            For Each col As DataGridViewColumn In dgv.Columns
                Dim checkName As String = If(col.DataPropertyName, "").ToLower()
                Dim checkHeader As String = If(col.HeaderText, "").ToLower()
                If checkName.Contains("enrollmentid") OrElse checkName.Contains("id") OrElse checkHeader.Contains("enrollmentid") OrElse checkHeader.Contains("id") Then
                    col.Visible = True
                    col.HeaderText = "EnrollmentID"
                    col.DisplayIndex = 0
                    Exit For
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint

    End Sub
End Class