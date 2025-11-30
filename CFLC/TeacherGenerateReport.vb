Imports System.Data
Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class TeacherGenerateReport
    Public Property IsEmbedded As Boolean = False
    Public Property TeacherID As String = ""

    Private conn As MySqlConnection
    Private db_name As String = "cflc_database"
    Private isInitializing As Boolean = False

    ' Open database connection
    Private Function openConn() As Boolean
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            Dim configPath As String = Path.Combine(Application.StartupPath, "config.txt")
            Dim strConnection As String = ""

            If Not File.Exists(configPath) Then
                MessageBox.Show("config.txt not found in application folder!" & vbCrLf & "Expected path: " & configPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim configText As String = File.ReadAllText(configPath).Trim()

            If String.IsNullOrWhiteSpace(configText) Then
                MessageBox.Show("Connection string in config.txt is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If configText.Contains(vbCrLf) OrElse configText.Contains(vbLf) Then
                Dim arr_text() As String = configText.Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)
                If arr_text.Length >= 4 Then
                    Try
                        Dim server As String = arr_text(0).Split("="c)(1).Trim()
                        Dim uid As String = arr_text(1).Split("="c)(1).Trim()
                        Dim password As String = arr_text(2).Split("="c)(1).Trim()
                        Dim database As String = If(arr_text.Length > 3, arr_text(3).Split("="c)(1).Trim(), db_name)

                        strConnection = String.Format("server={0};uid={1};password={2};database={3};allowuservariables=True;Connection Timeout=30;",
                                                      server, uid, password, database)
                    Catch ex As Exception
                        MessageBox.Show("Error parsing config.txt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End Try
                Else
                    MessageBox.Show("Invalid format in config.txt. Expected format: server=...\nuid=...\npassword=...\ndatabase=...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Else
                strConnection = configText
            End If

            conn = New MySqlConnection(strConnection)
            conn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub TeacherGenerateReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(7, 77, 39)
        End If

        PictureBox1.Visible = True
        isInitializing = True

        InitializeGenderComboBox()
        InitializeSubjectLoadYearComboBox()

        dgvSectionStudents.Visible = True
        dgvSubjectLoad.Visible = True
        isInitializing = False

        StyleControls()
    End Sub

    Private Sub TeacherGenerateReport_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CenterGroupBoxes()
    End Sub

    Private Sub CenterGroupBoxes()
        If pnlMainContent Is Nothing Then Return

        Dim panelWidth As Integer = pnlMainContent.ClientSize.Width
        Dim panelHeight As Integer = pnlMainContent.ClientSize.Height

        Dim groupBoxWidth As Integer = 1200
        Dim groupBoxHeight As Integer = 200
        Dim spacing As Integer = 20

        ' Calculate horizontal center
        Dim centerX As Integer = (panelWidth - groupBoxWidth) \ 2

        ' Calculate total height of 2 GroupBoxes with spacing
        Dim totalHeight As Integer = (groupBoxHeight * 2) + spacing

        ' Calculate vertical center
        Dim startY As Integer = (panelHeight - totalHeight) \ 2

        ' Position each GroupBox
        If grpSectionStudents IsNot Nothing Then
            grpSectionStudents.Location = New Point(centerX, startY)
        End If

        If grpSubjectLoad IsNot Nothing Then
            grpSubjectLoad.Location = New Point(centerX, startY + groupBoxHeight + spacing)
        End If
    End Sub

    Private Sub TeacherGenerateReport_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterGroupBoxes()
    End Sub

    Private Sub StyleControls()
        Dim buttons() As Button = {btnTeacherGenerateStudents, btnTeacherGenerateSubjectLoad}

        For Each btn As Button In buttons
            If btn IsNot Nothing Then
                btn.FlatAppearance.BorderSize = 0
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 98, 104)
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 80, 87)
                btn.Cursor = Cursors.Hand
            End If
        Next

        Dim comboBoxes() As ComboBox = {cmbGender, cmbSubjectLoadYear}

        For Each cmb As ComboBox In comboBoxes
            If cmb IsNot Nothing Then
                cmb.FlatStyle = FlatStyle.Flat
                cmb.BackColor = Color.White
                cmb.ForeColor = Color.Black
            End If
        Next

        Dim dataGrids() As DataGridView = {dgvSectionStudents, dgvSubjectLoad}

        For Each dgv As DataGridView In dataGrids
            If dgv IsNot Nothing Then
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 249, 249)
                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(108, 117, 125)
                dgv.DefaultCellStyle.SelectionForeColor = Color.White
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(108, 117, 125)
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                dgv.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                dgv.EnableHeadersVisualStyles = False
            End If
        Next
    End Sub

    Private Sub HideLogoWhenDataShown()
        If PictureBox1 IsNot Nothing Then
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub InitializeGenderComboBox()
        cmbGender.Items.Clear()
        cmbGender.Items.Add("All")
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
    End Sub

    Private Sub InitializeSubjectLoadYearComboBox()
        PopulateYearComboBox(cmbSubjectLoadYear)
    End Sub

    Private Sub PopulateYearComboBox(cmb As ComboBox)
        If cmb Is Nothing Then Return

        cmb.Items.Clear()
        cmb.Items.Add("All Years")

        Try
            If Not openConn() Then Return

            Dim query As String = "SELECT DISTINCT YEAR(StartDate) AS Year FROM enrollment WHERE StartDate IS NOT NULL ORDER BY Year DESC"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        If Not IsDBNull(reader("Year")) Then
                            cmb.Items.Add(reader("Year").ToString())
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading years: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Load students in teacher's section filtered by gender
    Private Sub LoadSectionStudents()
        If String.IsNullOrEmpty(TeacherID) Then
            MessageBox.Show("Teacher ID is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If Not openConn() Then Return

            Dim selectedGender As String = Nothing
            If cmbGender.SelectedItem IsNot Nothing Then
                selectedGender = cmbGender.SelectedItem.ToString()
            End If

            Dim dt As New DataTable()
            Dim sql As String = "SELECT DISTINCT s.StudentID, s.FirstName, s.MiddleName, s.LastName, s.Gender " &
                                "FROM student s " &
                                "INNER JOIN enrollment e ON s.StudentID = e.StudentID " &
                                "INNER JOIN section sec ON e.SectionID = sec.SectionID " &
                                "WHERE sec.TeacherID = @TeacherID " &
                                "AND (e.EnrollmentStatus = 'Enrolled' OR e.EnrollmentStatus IS NULL)"

            If selectedGender IsNot Nothing AndAlso selectedGender <> "All" Then
                sql &= " AND s.Gender = @Gender"
            End If

            sql &= " ORDER BY s.LastName, s.FirstName"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@TeacherID", TeacherID)
                If selectedGender IsNot Nothing AndAlso selectedGender <> "All" Then
                    cmd.Parameters.AddWithValue("@Gender", selectedGender)
                End If

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvSectionStudents.DataSource = dt
            dgvSectionStudents.Refresh()
            HideLogoWhenDataShown()
            dgvSectionStudents.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Load teacher's subject load for the year
    Private Sub LoadSubjectLoad()
        If String.IsNullOrEmpty(TeacherID) Then
            MessageBox.Show("Teacher ID is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If Not openConn() Then Return

            Dim selectedYear As String = Nothing
            If cmbSubjectLoadYear.SelectedItem IsNot Nothing Then
                selectedYear = cmbSubjectLoadYear.SelectedItem.ToString()
            End If

            Dim dt As New DataTable()
            Dim sql As String = "SELECT s.SubjectID, s.SubjectCode, s.SubjectName, s.Category, s.GradeLevel, s.Schedule " &
                                "FROM subject s " &
                                "WHERE s.TeacherID = @TeacherID"

            If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                sql &= " AND YEAR(s.DateCreated) = @Year"
            End If

            sql &= " ORDER BY s.SubjectName"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@TeacherID", TeacherID)
                If selectedYear IsNot Nothing AndAlso selectedYear <> "All Years" Then
                    cmd.Parameters.AddWithValue("@Year", Integer.Parse(selectedYear))
                End If

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvSubjectLoad.DataSource = dt
            dgvSubjectLoad.Refresh()
            HideLogoWhenDataShown()
            dgvSubjectLoad.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error loading subject load: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Event handlers
    Private Sub cmbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedIndexChanged
        If Not isInitializing Then
            LoadSectionStudents()
        End If
    End Sub

    Private Sub cmbSubjectLoadYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubjectLoadYear.SelectedIndexChanged
        If Not isInitializing Then
            LoadSubjectLoad()
        End If
    End Sub

    ' Print Students Report
    Private Sub btnTeacherGenerateStudents_Click(sender As Object, e As EventArgs) Handles btnTeacherGenerateStudents.Click
        If dgvSectionStudents.DataSource Is Nothing OrElse DirectCast(dgvSectionStudents.DataSource, DataTable).Rows.Count = 0 Then
            MessageBox.Show("No student data to generate report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim selectedGender As String = If(cmbGender.SelectedItem IsNot Nothing, cmbGender.SelectedItem.ToString(), "All")
            Dim fileName As String = "TeacherSectionStudents_" & selectedGender & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"
            Dim savePath As String = Path.Combine(desktopPath, fileName)

            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
            PdfWriter.GetInstance(doc, New FileStream(savePath, FileMode.Create))
            doc.Open()

            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
            Dim titleText As String = "Section Students Report"
            If selectedGender <> "All" Then
                titleText &= " - " & selectedGender
            End If
            Dim title As New Paragraph(titleText, titleFont) With {.Alignment = Element.ALIGN_CENTER}
            doc.Add(title)

            Dim dt As DataTable = DirectCast(dgvSectionStudents.DataSource, DataTable)
            Dim table As New PdfPTable(5)
            table.WidthPercentage = 100
            table.SetWidths(New Single() {1, 3, 3, 3, 1.5F})

            ' Headers
            table.AddCell(New PdfPCell(New Phrase("Student ID", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("First Name", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Middle Name", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Last Name", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Gender", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})

            For Each row As DataRow In dt.Rows
                table.AddCell(GetSafeString(row("StudentID")))
                table.AddCell(GetSafeString(row("FirstName")))
                table.AddCell(GetSafeString(row("MiddleName")))
                table.AddCell(GetSafeString(row("LastName")))
                table.AddCell(GetSafeString(row("Gender")))
            Next

            doc.Add(table)
            doc.Close()

            MessageBox.Show("Report generated successfully!" & vbCrLf & "Saved to: " & savePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Print Subject Load Report
    Private Sub btnTeacherGenerateSubjectLoad_Click(sender As Object, e As EventArgs) Handles btnTeacherGenerateSubjectLoad.Click
        If dgvSubjectLoad.DataSource Is Nothing OrElse DirectCast(dgvSubjectLoad.DataSource, DataTable).Rows.Count = 0 Then
            MessageBox.Show("No subject data to generate report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim selectedYear As String = If(cmbSubjectLoadYear.SelectedItem IsNot Nothing, cmbSubjectLoadYear.SelectedItem.ToString(), "AllYears")
            Dim fileName As String = "TeacherSubjectLoad_" & selectedYear & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"
            Dim savePath As String = Path.Combine(desktopPath, fileName)

            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
            PdfWriter.GetInstance(doc, New FileStream(savePath, FileMode.Create))
            doc.Open()

            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
            Dim titleText As String = "Teacher Subject Load Report"
            If selectedYear <> "AllYears" Then
                titleText &= " (" & selectedYear & ")"
            End If
            Dim title As New Paragraph(titleText, titleFont) With {.Alignment = Element.ALIGN_CENTER}
            doc.Add(title)

            Dim dt As DataTable = DirectCast(dgvSubjectLoad.DataSource, DataTable)
            Dim table As New PdfPTable(6)
            table.WidthPercentage = 100
            table.SetWidths(New Single() {1, 2, 4, 2, 1, 2})

            ' Headers
            table.AddCell(New PdfPCell(New Phrase("Subject ID", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Subject Code", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Subject Name", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Category", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Grade", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})
            table.AddCell(New PdfPCell(New Phrase("Schedule", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD))) With {.BackgroundColor = New BaseColor(108, 117, 125), .HorizontalAlignment = Element.ALIGN_CENTER})

            For Each row As DataRow In dt.Rows
                table.AddCell(GetSafeString(row("SubjectID")))
                table.AddCell(GetSafeString(row("SubjectCode")))
                table.AddCell(GetSafeString(row("SubjectName")))
                table.AddCell(GetSafeString(row("Category")))
                table.AddCell(GetSafeString(row("GradeLevel")))
                table.AddCell(GetSafeString(row("Schedule")))
            Next

            doc.Add(table)
            doc.Close()

            MessageBox.Show("Report generated successfully!" & vbCrLf & "Saved to: " & savePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetSafeString(value As Object) As String
        If value Is Nothing OrElse IsDBNull(value) Then
            Return ""
        End If
        Return value.ToString()
    End Function
End Class
