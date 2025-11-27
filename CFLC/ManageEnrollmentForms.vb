Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ManageEnrollmentForms

    Public Property IsEmbedded As Boolean = False
    Private currentEnrollmentID As Integer = 0

    Private Sub ManageEnrollmentForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToDGV("SELECT * FROM enrollment", dgvEnrollment)
    End Sub

    Private Sub btnEnrollUpdate_Click(sender As Object, e As EventArgs) Handles btnEnrollUpdate.Click
        UpdateEnrollment()
    End Sub

    Private Sub UpdateEnrollment()
        If currentEnrollmentID = 0 Then
            MessageBox.Show("No enrollment selected for update.", "Update Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Status logic based on dates
        Dim calculatedStatus As String = CalculateEnrollmentStatus(dtpEnrollmentStartDate.Value,
                                                               dtpEnrollmentEndDate.Value)

        Dim selectedStatus As String = If(ComboBoxEnrollmentStatus.SelectedItem IsNot Nothing,
                                      ComboBoxEnrollmentStatus.SelectedItem.ToString(), "")

        If selectedStatus <> calculatedStatus Then
            Dim result = MessageBox.Show(
            "Selected status does not match the date range." & vbCrLf &
            "Calculated status: " & calculatedStatus & vbCrLf & vbCrLf &
            "Yes = Keep manual status" & vbCrLf &
            "No = Use calculated status",
            "Status Mismatch",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.No Then
                ComboBoxEnrollmentStatus.SelectedItem = calculatedStatus
            End If
        End If

        ' Validate inputs
        If Not ValidateEnrollmentInputs() Then
            Return
        End If

        ' Check duplicate Reference Number (excluding current record)
        If EnrollmentRefNumExists(TextBoxEnrollmentRefNum.Text.Trim(), currentEnrollmentID) Then
            MessageBox.Show("Reference Number already exists. Please use a unique value.",
                        "Duplicate Reference Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if changes were made
        If Not HasEnrollmentDataChanged() Then
            MessageBox.Show("No changes detected.", "No Changes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Perform Update
        Try
            modDBx.openConn(modDBx.db_name)

            Dim sql As String =
            "UPDATE enrollment SET " &
            "StudentID = @StudentID, " &
            "SectionID = @SectionID, " &
            "GradeLevel = @GradeLevel, " &
            "StartDate = @StartDate, " &
            "EndDate = @EndDate, " &
            "EnrollmentMode = @EnrollmentMode, " &
            "EnrollmentStatus = @EnrollmentStatus, " &
            "ModeOfPayment = @PaymentMode, " &
            "PaymentStatus = @" & "PaymentStatus" & ", " &
            "RequirementStatus = @RequirementStatus, " &
            "ReferenceNumber = @ReferenceNumber, " &
            "Remarks = @Remarks, " &
            "CreatedDate = @CreatedDate, " &
            "CreatedBy = @CreatedBy " &
            "WHERE EnrollmentID = @EnrollmentID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@StudentID", txtbxEnrollmentStudentID.Text.Trim())
                cmd.Parameters.AddWithValue("@SectionID", txtbxEnrollSectionID.Text.Trim())
                cmd.Parameters.AddWithValue("@GradeLevel", nudEnrollmentGradeLevel.Value)
                cmd.Parameters.AddWithValue("@StartDate", dtpEnrollmentStartDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@EndDate", dtpEnrollmentEndDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@EnrollmentMode", SafeString(ComboBoxEnrollmentMode.Text))
                cmd.Parameters.AddWithValue("@EnrollmentStatus", SafeString(ComboBoxEnrollmentStatus.Text))
                cmd.Parameters.AddWithValue("@PaymentMode", SafeString(TextBoxEnrollmentModeOfPayment.Text))
                cmd.Parameters.AddWithValue("@PaymentStatus", SafeString(ComboBoxEnrollmentPaymentStatus.Text))
                cmd.Parameters.AddWithValue("@RequirementStatus", SafeString(cmbEnrollmentRequirementStatus.Text))
                cmd.Parameters.AddWithValue("@ReferenceNumber", SafeString(TextBoxEnrollmentRefNum.Text))
                cmd.Parameters.AddWithValue("@Remarks", ConvertToProperCase(SafeString(txtbxEnrollmentRemarks.Text)))
                cmd.Parameters.AddWithValue("@CreatedDate", dtpDateCreated.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@CreatedBy", SafeString(txtbxEnrollCreatedBy.Text))
                cmd.Parameters.AddWithValue("@EnrollmentID", currentEnrollmentID)

                Dim rows As Integer = cmd.ExecuteNonQuery()

                If rows > 0 Then
                    MessageBox.Show("Enrollment updated successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ClearEnrollmentFields()
                    LoadToDGV("SELECT * FROM enrollment", dgvEnrollment)
                    currentEnrollmentID = 0
                Else
                    MessageBox.Show("No enrollment was updated.", "Update Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating enrollment: " & ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Function SafeString(value As Object) As String
        If value Is Nothing OrElse IsDBNull(value) Then Return ""
        Return value.ToString().Trim()
    End Function

    Private Function ConvertToProperCase(input As String) As String
        If String.IsNullOrWhiteSpace(input) Then Return ""
        Return Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower())
    End Function

    Private Function CalculateEnrollmentStatus(startDate As Date, endDate As Date) As String
        Dim today As Date = Date.Today

        If today < startDate Then
            Return "Upcoming"
        ElseIf today >= startDate AndAlso today <= endDate Then
            Return "Ongoing"
        Else
            Return "Completed"
        End If
    End Function

    Private Function ValidateEnrollmentInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtbxEnrollmentStudentID.Text) Then
            MessageBox.Show("Student ID is required.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtbxEnrollSectionID.Text) Then
            MessageBox.Show("Section ID is required.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If ComboBoxEnrollmentStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please select Enrollment Status.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function EnrollmentRefNumExists(refNum As String, excludeID As Integer) As Boolean
        Try
            modDBx.openConn(modDBx.db_name)
            Dim sql As String = "SELECT COUNT(*) FROM enrollment 
                             WHERE ReferenceNumber = @RefNum AND EnrollmentID <> @ID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@RefNum", refNum)
                cmd.Parameters.AddWithValue("@ID", excludeID)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using

        Catch
            Return False
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    Private Function HasEnrollmentDataChanged() As Boolean
        Try
            modDBx.openConn(modDBx.db_name)

            Dim sql As String = "SELECT * FROM enrollment WHERE EnrollmentID = @ID"

            Using cmd As New MySqlCommand(sql, modDBx.conn)
                cmd.Parameters.AddWithValue("@ID", currentEnrollmentID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Compare each field safely
                        If GetSafeStringFromDB(reader("StudentID")) <> SafeString(txtbxEnrollmentStudentID.Text) Then Return True
                        If GetSafeStringFromDB(reader("SectionID")) <> SafeString(txtbxEnrollSectionID.Text) Then Return True

                        ' Grade Level comparison
                        Dim dbGradeLevel As Integer = 0
                        If Not IsDBNull(reader("GradeLevel")) Then
                            dbGradeLevel = Convert.ToInt32(reader("GradeLevel"))
                        End If
                        If dbGradeLevel <> nudEnrollmentGradeLevel.Value Then Return True

                        ' Date comparisons with NULL handling
                        If Not CompareDatesSafely(reader("StartDate"), dtpEnrollmentStartDate.Value) Then Return True
                        If Not CompareDatesSafely(reader("EndDate"), dtpEnrollmentEndDate.Value) Then Return True
                        If Not CompareDatesSafely(reader("CreatedDate"), dtpDateCreated.Value) Then Return True

                        ' String comparisons
                        If GetSafeStringFromDB(reader("EnrollmentMode")) <> SafeString(ComboBoxEnrollmentMode.Text) Then Return True
                        If GetSafeStringFromDB(reader("EnrollmentStatus")) <> SafeString(ComboBoxEnrollmentStatus.Text) Then Return True
                        If GetSafeStringFromDB(reader("ModeOfPayment")) <> SafeString(TextBoxEnrollmentModeOfPayment.Text) Then Return True
                        If GetSafeStringFromDB(reader("PaymentStatus")) <> SafeString(ComboBoxEnrollmentPaymentStatus.Text) Then Return True
                        If GetSafeStringFromDB(reader("RequirementStatus")) <> SafeString(cmbEnrollmentRequirementStatus.Text) Then Return True
                        If GetSafeStringFromDB(reader("ReferenceNumber")) <> SafeString(TextBoxEnrollmentRefNum.Text) Then Return True
                        If GetSafeStringFromDB(reader("Remarks")) <> SafeString(txtbxEnrollmentRemarks.Text) Then Return True
                        If GetSafeStringFromDB(reader("CreatedBy")) <> SafeString(txtbxEnrollCreatedBy.Text) Then Return True

                        Return False ' No changes
                    End If
                End Using
            End Using

            Return False

        Catch ex As Exception
            MessageBox.Show("Error checking changes: " & ex.Message)
            Return True
        Finally
            If modDBx.conn IsNot Nothing AndAlso modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Function

    ' NEW: Safe method to get strings from database
    Private Function GetSafeStringFromDB(value As Object) As String
        If value Is Nothing OrElse IsDBNull(value) Then
            Return ""
        End If
        Return value.ToString().Trim()
    End Function

    ' NEW: Safe method to compare dates (handles NULL values)
    Private Function CompareDatesSafely(dbValue As Object, controlValue As Date) As Boolean
        If dbValue Is Nothing OrElse IsDBNull(dbValue) Then
            ' If database has NULL and control has default date, consider them equal
            Return controlValue = Date.Today
        Else
            Try
                Dim dbDate As Date = Convert.ToDateTime(dbValue)
                Return dbDate.ToString("yyyy-MM-dd") = controlValue.ToString("yyyy-MM-dd")
            Catch
                Return False
            End Try
        End If
    End Function

    Private Sub ClearEnrollmentFields()
        txtbxEnrollmentStudentID.Clear()
        txtbxEnrollSectionID.Clear()
        nudEnrollmentGradeLevel.Value = 1
        ComboBoxEnrollmentStatus.SelectedIndex = -1
        ComboBoxEnrollmentMode.SelectedIndex = -1
        TextBoxEnrollmentModeOfPayment.Clear()
        ComboBoxEnrollmentPaymentStatus.SelectedIndex = -1
        cmbEnrollmentRequirementStatus.SelectedIndex = -1
        TextBoxEnrollmentRefNum.Clear()
        txtbxEnrollmentRemarks.Clear()
        txtbxEnrollCreatedBy.Clear()

        dtpEnrollmentStartDate.Value = Date.Today
        dtpEnrollmentEndDate.Value = Date.Today
        dtpDateCreated.Value = Date.Today
    End Sub

    Private Function GetSafeString(cell As DataGridViewCell) As String
        If cell Is Nothing OrElse cell.Value Is Nothing OrElse IsDBNull(cell.Value) Then
            Return ""
        End If
        Return cell.Value.ToString()
    End Function

    Private Sub dgvEnrollment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnrollment.CellClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvEnrollment.Rows(e.RowIndex)

        ' Read EnrollmentID safely
        Dim clickedID As Integer = 0
        If row.Cells.Count > 0 AndAlso row.Cells(0).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(0).Value) Then
            Integer.TryParse(row.Cells(0).Value.ToString(), clickedID)
        End If

        ' Clicked the same row → clear
        If clickedID <> 0 AndAlso clickedID = currentEnrollmentID Then
            dgvEnrollment.ClearSelection()
            currentEnrollmentID = 0
            ClearEnrollmentFields()
            Return
        End If

        ' Populate fields if valid row
        If clickedID <> 0 Then
            currentEnrollmentID = clickedID

            txtbxEnrollmentStudentID.Text = GetSafeString(row.Cells("StudentID"))
            txtbxEnrollSectionID.Text = GetSafeString(row.Cells("SectionID"))

            ' Grade Level
            If Not IsDBNull(row.Cells("GradeLevel").Value) AndAlso row.Cells("GradeLevel").Value IsNot Nothing Then
                nudEnrollmentGradeLevel.Value = Convert.ToDecimal(row.Cells("GradeLevel").Value)
            Else
                nudEnrollmentGradeLevel.Value = 1
            End If

            ' Dates with NULL handling
            If Not IsDBNull(row.Cells("StartDate").Value) AndAlso row.Cells("StartDate").Value IsNot Nothing Then
                dtpEnrollmentStartDate.Value = CDate(row.Cells("StartDate").Value)
            Else
                dtpEnrollmentStartDate.Value = Date.Today
            End If

            If Not IsDBNull(row.Cells("EndDate").Value) AndAlso row.Cells("EndDate").Value IsNot Nothing Then
                dtpEnrollmentEndDate.Value = CDate(row.Cells("EndDate").Value)
            Else
                dtpEnrollmentEndDate.Value = Date.Today
            End If

            If Not IsDBNull(row.Cells("CreatedDate").Value) AndAlso row.Cells("CreatedDate").Value IsNot Nothing Then
                dtpDateCreated.Value = CDate(row.Cells("CreatedDate").Value)
            Else
                dtpDateCreated.Value = Date.Today
            End If

            ComboBoxEnrollmentStatus.Text = GetSafeString(row.Cells("EnrollmentStatus"))
            ComboBoxEnrollmentMode.Text = GetSafeString(row.Cells("EnrollmentMode"))
            TextBoxEnrollmentModeOfPayment.Text = GetSafeString(row.Cells("ModeOfPayment"))
            ComboBoxEnrollmentPaymentStatus.Text = GetSafeString(row.Cells("PaymentStatus"))
            cmbEnrollmentRequirementStatus.Text = GetSafeString(row.Cells("RequirementStatus"))
            TextBoxEnrollmentRefNum.Text = GetSafeString(row.Cells("ReferenceNumber"))
            txtbxEnrollmentRemarks.Text = GetSafeString(row.Cells("Remarks"))
            txtbxEnrollCreatedBy.Text = GetSafeString(row.Cells("CreatedBy"))

            ' Enable manual status editing
            ComboBoxEnrollmentStatus.Enabled = True
        End If
    End Sub
End Class