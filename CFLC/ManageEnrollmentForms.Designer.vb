<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageEnrollmentForms
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.TextBoxStudentSearch = New System.Windows.Forms.TextBox()
        Me.dgvEnrollment = New System.Windows.Forms.DataGridView()
        Me.EnrollmentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESchoolYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EGradeLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESectionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnrollmentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EPaymentStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EModeOfPayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnrollmentStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnrollmentMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EProcessedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EGuardianName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ERequirementStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EReferenceNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePickerEnrollmentDate = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxEnrollmentContactNo = New System.Windows.Forms.TextBox()
        Me.LabelEnrollmentContactNo = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelEnrollmentMode = New System.Windows.Forms.Label()
        Me.TextBoxEnrollmentModeOfPayment = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentModeOfPayment = New System.Windows.Forms.Label()
        Me.ComboBoxEnrollmentPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.TextBoxEnrollmentRefNum = New System.Windows.Forms.TextBox()
        Me.ComboBoxEnrollmentStatus = New System.Windows.Forms.ComboBox()
        Me.TextBoxEnrollmentRequirementStatus = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentStatus = New System.Windows.Forms.Label()
        Me.TextBoxEnrollmentProcessedBy = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentProcessedBy = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.EnrollmentRequirementStatus = New System.Windows.Forms.Label()
        Me.TextEnrollmentRefNum = New System.Windows.Forms.Label()
        Me.TextBoxGuardianName = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentGuardianName = New System.Windows.Forms.Label()
        Me.TextEnrollmentPaymentStatus = New System.Windows.Forms.Label()
        Me.TextEnrollmentDate = New System.Windows.Forms.Label()
        Me.TextBoxEnrollmentSchoolYear = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentSchoolYear = New System.Windows.Forms.Label()
        Me.TextBoxEnrollmentGradeLvl = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentGradeLvl = New System.Windows.Forms.Label()
        Me.lblTeacherList = New System.Windows.Forms.Label()
        Me.btnEnrollDelete = New System.Windows.Forms.Button()
        Me.btnEnrollUpdate = New System.Windows.Forms.Button()
        Me.btnEnrollAdd = New System.Windows.Forms.Button()
        Me.btnEnrollSearch = New System.Windows.Forms.Button()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvEnrollment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.TextBoxStudentSearch)
        Me.pnlContent.Controls.Add(Me.dgvEnrollment)
        Me.pnlContent.Controls.Add(Me.Panel1)
        Me.pnlContent.Controls.Add(Me.lblTeacherList)
        Me.pnlContent.Controls.Add(Me.btnEnrollDelete)
        Me.pnlContent.Controls.Add(Me.btnEnrollUpdate)
        Me.pnlContent.Controls.Add(Me.btnEnrollAdd)
        Me.pnlContent.Controls.Add(Me.btnEnrollSearch)
        Me.pnlContent.Controls.Add(Me.picWatermark)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1715, 732)
        Me.pnlContent.TabIndex = 24
        '
        'TextBoxStudentSearch
        '
        Me.TextBoxStudentSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxStudentSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentSearch.Location = New System.Drawing.Point(827, 683)
        Me.TextBoxStudentSearch.MaxLength = 50
        Me.TextBoxStudentSearch.Name = "TextBoxStudentSearch"
        Me.TextBoxStudentSearch.Size = New System.Drawing.Size(246, 36)
        Me.TextBoxStudentSearch.TabIndex = 30
        '
        'dgvEnrollment
        '
        Me.dgvEnrollment.AllowUserToAddRows = False
        Me.dgvEnrollment.AllowUserToDeleteRows = False
        Me.dgvEnrollment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEnrollment.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvEnrollment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnrollment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EnrollmentID, Me.EStudentID, Me.ESchoolYear, Me.EGradeLevel, Me.ESectionID, Me.EnrollmentDate, Me.EPaymentStatus, Me.EModeOfPayment, Me.EnrollmentStatus, Me.EnrollmentMode, Me.EProcessedBy, Me.EGuardianName, Me.EContactNumber, Me.ERequirementStatus, Me.EReferenceNumber})
        Me.dgvEnrollment.Location = New System.Drawing.Point(49, 443)
        Me.dgvEnrollment.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvEnrollment.Name = "dgvEnrollment"
        Me.dgvEnrollment.ReadOnly = True
        Me.dgvEnrollment.RowHeadersVisible = False
        Me.dgvEnrollment.RowHeadersWidth = 51
        Me.dgvEnrollment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnrollment.Size = New System.Drawing.Size(1624, 193)
        Me.dgvEnrollment.TabIndex = 29
        '
        'EnrollmentID
        '
        Me.EnrollmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EnrollmentID.HeaderText = "Enrollment ID"
        Me.EnrollmentID.MinimumWidth = 6
        Me.EnrollmentID.Name = "EnrollmentID"
        Me.EnrollmentID.ReadOnly = True
        Me.EnrollmentID.Width = 106
        '
        'EStudentID
        '
        Me.EStudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EStudentID.HeaderText = "Student ID"
        Me.EStudentID.MinimumWidth = 6
        Me.EStudentID.Name = "EStudentID"
        Me.EStudentID.ReadOnly = True
        Me.EStudentID.Width = 90
        '
        'ESchoolYear
        '
        Me.ESchoolYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ESchoolYear.HeaderText = "School Year"
        Me.ESchoolYear.MinimumWidth = 6
        Me.ESchoolYear.Name = "ESchoolYear"
        Me.ESchoolYear.ReadOnly = True
        Me.ESchoolYear.Width = 101
        '
        'EGradeLevel
        '
        Me.EGradeLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EGradeLevel.HeaderText = "Grade Level"
        Me.EGradeLevel.MinimumWidth = 6
        Me.EGradeLevel.Name = "EGradeLevel"
        Me.EGradeLevel.ReadOnly = True
        Me.EGradeLevel.Width = 101
        '
        'ESectionID
        '
        Me.ESectionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ESectionID.HeaderText = "SectionID"
        Me.ESectionID.MinimumWidth = 6
        Me.ESectionID.Name = "ESectionID"
        Me.ESectionID.ReadOnly = True
        Me.ESectionID.Width = 94
        '
        'EnrollmentDate
        '
        Me.EnrollmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EnrollmentDate.HeaderText = "Enrollment Date"
        Me.EnrollmentDate.MinimumWidth = 6
        Me.EnrollmentDate.Name = "EnrollmentDate"
        Me.EnrollmentDate.ReadOnly = True
        Me.EnrollmentDate.Width = 120
        '
        'EPaymentStatus
        '
        Me.EPaymentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EPaymentStatus.HeaderText = "Payment Status"
        Me.EPaymentStatus.MinimumWidth = 6
        Me.EPaymentStatus.Name = "EPaymentStatus"
        Me.EPaymentStatus.ReadOnly = True
        Me.EPaymentStatus.Width = 119
        '
        'EModeOfPayment
        '
        Me.EModeOfPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EModeOfPayment.HeaderText = "Mode Of Payment"
        Me.EModeOfPayment.MinimumWidth = 6
        Me.EModeOfPayment.Name = "EModeOfPayment"
        Me.EModeOfPayment.ReadOnly = True
        Me.EModeOfPayment.Width = 131
        '
        'EnrollmentStatus
        '
        Me.EnrollmentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EnrollmentStatus.HeaderText = "Enrollment Status"
        Me.EnrollmentStatus.MinimumWidth = 6
        Me.EnrollmentStatus.Name = "EnrollmentStatus"
        Me.EnrollmentStatus.ReadOnly = True
        Me.EnrollmentStatus.Width = 128
        '
        'EnrollmentMode
        '
        Me.EnrollmentMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EnrollmentMode.HeaderText = "Enrollment Mode"
        Me.EnrollmentMode.MinimumWidth = 6
        Me.EnrollmentMode.Name = "EnrollmentMode"
        Me.EnrollmentMode.ReadOnly = True
        Me.EnrollmentMode.Width = 126
        '
        'EProcessedBy
        '
        Me.EProcessedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EProcessedBy.HeaderText = "Processed By"
        Me.EProcessedBy.MinimumWidth = 6
        Me.EProcessedBy.Name = "EProcessedBy"
        Me.EProcessedBy.ReadOnly = True
        Me.EProcessedBy.Width = 111
        '
        'EGuardianName
        '
        Me.EGuardianName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EGuardianName.HeaderText = "Guardian Name"
        Me.EGuardianName.MinimumWidth = 6
        Me.EGuardianName.Name = "EGuardianName"
        Me.EGuardianName.ReadOnly = True
        Me.EGuardianName.Width = 120
        '
        'EContactNumber
        '
        Me.EContactNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EContactNumber.HeaderText = "Contact No"
        Me.EContactNumber.MinimumWidth = 6
        Me.EContactNumber.Name = "EContactNumber"
        Me.EContactNumber.ReadOnly = True
        Me.EContactNumber.Width = 94
        '
        'ERequirementStatus
        '
        Me.ERequirementStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ERequirementStatus.HeaderText = "Requirement Status"
        Me.ERequirementStatus.MinimumWidth = 6
        Me.ERequirementStatus.Name = "ERequirementStatus"
        Me.ERequirementStatus.ReadOnly = True
        Me.ERequirementStatus.Width = 140
        '
        'EReferenceNumber
        '
        Me.EReferenceNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EReferenceNumber.HeaderText = "Reference Number"
        Me.EReferenceNumber.MinimumWidth = 6
        Me.EReferenceNumber.Name = "EReferenceNumber"
        Me.EReferenceNumber.ReadOnly = True
        Me.EReferenceNumber.Width = 137
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.DateTimePickerEnrollmentDate)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentContactNo)
        Me.Panel1.Controls.Add(Me.LabelEnrollmentContactNo)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.LabelEnrollmentMode)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentModeOfPayment)
        Me.Panel1.Controls.Add(Me.TextEnrollmentModeOfPayment)
        Me.Panel1.Controls.Add(Me.ComboBoxEnrollmentPaymentStatus)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentRefNum)
        Me.Panel1.Controls.Add(Me.ComboBoxEnrollmentStatus)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentRequirementStatus)
        Me.Panel1.Controls.Add(Me.TextEnrollmentStatus)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentProcessedBy)
        Me.Panel1.Controls.Add(Me.TextEnrollmentProcessedBy)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.EnrollmentRequirementStatus)
        Me.Panel1.Controls.Add(Me.TextEnrollmentRefNum)
        Me.Panel1.Controls.Add(Me.TextBoxGuardianName)
        Me.Panel1.Controls.Add(Me.TextEnrollmentGuardianName)
        Me.Panel1.Controls.Add(Me.TextEnrollmentPaymentStatus)
        Me.Panel1.Controls.Add(Me.TextEnrollmentDate)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentSchoolYear)
        Me.Panel1.Controls.Add(Me.TextEnrollmentSchoolYear)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentGradeLvl)
        Me.Panel1.Controls.Add(Me.TextEnrollmentGradeLvl)
        Me.Panel1.Location = New System.Drawing.Point(51, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(1627, 355)
        Me.Panel1.TabIndex = 28
        '
        'DateTimePickerEnrollmentDate
        '
        Me.DateTimePickerEnrollmentDate.Location = New System.Drawing.Point(90, 177)
        Me.DateTimePickerEnrollmentDate.Name = "DateTimePickerEnrollmentDate"
        Me.DateTimePickerEnrollmentDate.Size = New System.Drawing.Size(233, 22)
        Me.DateTimePickerEnrollmentDate.TabIndex = 53
        '
        'TextBoxEnrollmentContactNo
        '
        Me.TextBoxEnrollmentContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentContactNo.Location = New System.Drawing.Point(746, 123)
        Me.TextBoxEnrollmentContactNo.MaxLength = 15
        Me.TextBoxEnrollmentContactNo.Name = "TextBoxEnrollmentContactNo"
        Me.TextBoxEnrollmentContactNo.Size = New System.Drawing.Size(251, 26)
        Me.TextBoxEnrollmentContactNo.TabIndex = 52
        '
        'LabelEnrollmentContactNo
        '
        Me.LabelEnrollmentContactNo.AutoSize = True
        Me.LabelEnrollmentContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEnrollmentContactNo.Location = New System.Drawing.Point(693, 98)
        Me.LabelEnrollmentContactNo.Name = "LabelEnrollmentContactNo"
        Me.LabelEnrollmentContactNo.Size = New System.Drawing.Size(97, 20)
        Me.LabelEnrollmentContactNo.TabIndex = 51
        Me.LabelEnrollmentContactNo.Text = "Contact No."
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Walk-in", "Online", "Scheduled Appointment"})
        Me.ComboBox1.Location = New System.Drawing.Point(407, 188)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(110, 28)
        Me.ComboBox1.TabIndex = 50
        '
        'LabelEnrollmentMode
        '
        Me.LabelEnrollmentMode.AutoSize = True
        Me.LabelEnrollmentMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEnrollmentMode.Location = New System.Drawing.Point(354, 165)
        Me.LabelEnrollmentMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelEnrollmentMode.Name = "LabelEnrollmentMode"
        Me.LabelEnrollmentMode.Size = New System.Drawing.Size(135, 20)
        Me.LabelEnrollmentMode.TabIndex = 49
        Me.LabelEnrollmentMode.Text = "Enrollment Mode"
        '
        'TextBoxEnrollmentModeOfPayment
        '
        Me.TextBoxEnrollmentModeOfPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentModeOfPayment.Location = New System.Drawing.Point(407, 61)
        Me.TextBoxEnrollmentModeOfPayment.MaxLength = 20
        Me.TextBoxEnrollmentModeOfPayment.Name = "TextBoxEnrollmentModeOfPayment"
        Me.TextBoxEnrollmentModeOfPayment.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxEnrollmentModeOfPayment.TabIndex = 48
        '
        'TextEnrollmentModeOfPayment
        '
        Me.TextEnrollmentModeOfPayment.AutoSize = True
        Me.TextEnrollmentModeOfPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentModeOfPayment.Location = New System.Drawing.Point(354, 36)
        Me.TextEnrollmentModeOfPayment.Name = "TextEnrollmentModeOfPayment"
        Me.TextEnrollmentModeOfPayment.Size = New System.Drawing.Size(143, 20)
        Me.TextEnrollmentModeOfPayment.TabIndex = 47
        Me.TextEnrollmentModeOfPayment.Text = "Mode Of Payment"
        '
        'ComboBoxEnrollmentPaymentStatus
        '
        Me.ComboBoxEnrollmentPaymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEnrollmentPaymentStatus.FormattingEnabled = True
        Me.ComboBoxEnrollmentPaymentStatus.Items.AddRange(New Object() {"Paid", "Unpaid"})
        Me.ComboBoxEnrollmentPaymentStatus.Location = New System.Drawing.Point(90, 237)
        Me.ComboBoxEnrollmentPaymentStatus.Name = "ComboBoxEnrollmentPaymentStatus"
        Me.ComboBoxEnrollmentPaymentStatus.Size = New System.Drawing.Size(118, 28)
        Me.ComboBoxEnrollmentPaymentStatus.TabIndex = 46
        '
        'TextBoxEnrollmentRefNum
        '
        Me.TextBoxEnrollmentRefNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentRefNum.Location = New System.Drawing.Point(747, 242)
        Me.TextBoxEnrollmentRefNum.Name = "TextBoxEnrollmentRefNum"
        Me.TextBoxEnrollmentRefNum.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxEnrollmentRefNum.TabIndex = 44
        '
        'ComboBoxEnrollmentStatus
        '
        Me.ComboBoxEnrollmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEnrollmentStatus.FormattingEnabled = True
        Me.ComboBoxEnrollmentStatus.Items.AddRange(New Object() {"Enrolled", "Un-enrolled"})
        Me.ComboBoxEnrollmentStatus.Location = New System.Drawing.Point(407, 121)
        Me.ComboBoxEnrollmentStatus.Name = "ComboBoxEnrollmentStatus"
        Me.ComboBoxEnrollmentStatus.Size = New System.Drawing.Size(110, 28)
        Me.ComboBoxEnrollmentStatus.TabIndex = 43
        '
        'TextBoxEnrollmentRequirementStatus
        '
        Me.TextBoxEnrollmentRequirementStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentRequirementStatus.Location = New System.Drawing.Point(747, 189)
        Me.TextBoxEnrollmentRequirementStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxEnrollmentRequirementStatus.MaxLength = 20
        Me.TextBoxEnrollmentRequirementStatus.Name = "TextBoxEnrollmentRequirementStatus"
        Me.TextBoxEnrollmentRequirementStatus.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxEnrollmentRequirementStatus.TabIndex = 39
        '
        'TextEnrollmentStatus
        '
        Me.TextEnrollmentStatus.AutoSize = True
        Me.TextEnrollmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentStatus.Location = New System.Drawing.Point(354, 98)
        Me.TextEnrollmentStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TextEnrollmentStatus.Name = "TextEnrollmentStatus"
        Me.TextEnrollmentStatus.Size = New System.Drawing.Size(142, 20)
        Me.TextEnrollmentStatus.TabIndex = 38
        Me.TextEnrollmentStatus.Text = "Enrollment Status"
        '
        'TextBoxEnrollmentProcessedBy
        '
        Me.TextBoxEnrollmentProcessedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentProcessedBy.Location = New System.Drawing.Point(407, 245)
        Me.TextBoxEnrollmentProcessedBy.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxEnrollmentProcessedBy.MaxLength = 50
        Me.TextBoxEnrollmentProcessedBy.Name = "TextBoxEnrollmentProcessedBy"
        Me.TextBoxEnrollmentProcessedBy.Size = New System.Drawing.Size(251, 26)
        Me.TextBoxEnrollmentProcessedBy.TabIndex = 33
        '
        'TextEnrollmentProcessedBy
        '
        Me.TextEnrollmentProcessedBy.AutoSize = True
        Me.TextEnrollmentProcessedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentProcessedBy.Location = New System.Drawing.Point(354, 219)
        Me.TextEnrollmentProcessedBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TextEnrollmentProcessedBy.Name = "TextEnrollmentProcessedBy"
        Me.TextEnrollmentProcessedBy.Size = New System.Drawing.Size(114, 20)
        Me.TextEnrollmentProcessedBy.TabIndex = 32
        Me.TextEnrollmentProcessedBy.Text = "Processed By"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(-1, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Enrollment List"
        '
        'EnrollmentRequirementStatus
        '
        Me.EnrollmentRequirementStatus.AutoSize = True
        Me.EnrollmentRequirementStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollmentRequirementStatus.Location = New System.Drawing.Point(693, 165)
        Me.EnrollmentRequirementStatus.Name = "EnrollmentRequirementStatus"
        Me.EnrollmentRequirementStatus.Size = New System.Drawing.Size(157, 20)
        Me.EnrollmentRequirementStatus.TabIndex = 20
        Me.EnrollmentRequirementStatus.Text = "Requirement Status"
        '
        'TextEnrollmentRefNum
        '
        Me.TextEnrollmentRefNum.AutoSize = True
        Me.TextEnrollmentRefNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentRefNum.Location = New System.Drawing.Point(693, 219)
        Me.TextEnrollmentRefNum.Name = "TextEnrollmentRefNum"
        Me.TextEnrollmentRefNum.Size = New System.Drawing.Size(150, 20)
        Me.TextEnrollmentRefNum.TabIndex = 16
        Me.TextEnrollmentRefNum.Text = "Reference Number"
        '
        'TextBoxGuardianName
        '
        Me.TextBoxGuardianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGuardianName.Location = New System.Drawing.Point(746, 61)
        Me.TextBoxGuardianName.MaxLength = 100
        Me.TextBoxGuardianName.Name = "TextBoxGuardianName"
        Me.TextBoxGuardianName.Size = New System.Drawing.Size(251, 26)
        Me.TextBoxGuardianName.TabIndex = 15
        '
        'TextEnrollmentGuardianName
        '
        Me.TextEnrollmentGuardianName.AutoSize = True
        Me.TextEnrollmentGuardianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentGuardianName.Location = New System.Drawing.Point(693, 36)
        Me.TextEnrollmentGuardianName.Name = "TextEnrollmentGuardianName"
        Me.TextEnrollmentGuardianName.Size = New System.Drawing.Size(126, 20)
        Me.TextEnrollmentGuardianName.TabIndex = 14
        Me.TextEnrollmentGuardianName.Text = "Guardian Name"
        '
        'TextEnrollmentPaymentStatus
        '
        Me.TextEnrollmentPaymentStatus.AutoSize = True
        Me.TextEnrollmentPaymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentPaymentStatus.Location = New System.Drawing.Point(24, 214)
        Me.TextEnrollmentPaymentStatus.Name = "TextEnrollmentPaymentStatus"
        Me.TextEnrollmentPaymentStatus.Size = New System.Drawing.Size(127, 20)
        Me.TextEnrollmentPaymentStatus.TabIndex = 12
        Me.TextEnrollmentPaymentStatus.Text = "Payment Status"
        '
        'TextEnrollmentDate
        '
        Me.TextEnrollmentDate.AutoSize = True
        Me.TextEnrollmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentDate.Location = New System.Drawing.Point(23, 154)
        Me.TextEnrollmentDate.Name = "TextEnrollmentDate"
        Me.TextEnrollmentDate.Size = New System.Drawing.Size(130, 20)
        Me.TextEnrollmentDate.TabIndex = 10
        Me.TextEnrollmentDate.Text = "Enrollment Date"
        '
        'TextBoxEnrollmentSchoolYear
        '
        Me.TextBoxEnrollmentSchoolYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentSchoolYear.Location = New System.Drawing.Point(90, 59)
        Me.TextBoxEnrollmentSchoolYear.MaxLength = 20
        Me.TextBoxEnrollmentSchoolYear.Name = "TextBoxEnrollmentSchoolYear"
        Me.TextBoxEnrollmentSchoolYear.Size = New System.Drawing.Size(233, 26)
        Me.TextBoxEnrollmentSchoolYear.TabIndex = 7
        '
        'TextEnrollmentSchoolYear
        '
        Me.TextEnrollmentSchoolYear.AutoSize = True
        Me.TextEnrollmentSchoolYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentSchoolYear.Location = New System.Drawing.Point(53, 36)
        Me.TextEnrollmentSchoolYear.Name = "TextEnrollmentSchoolYear"
        Me.TextEnrollmentSchoolYear.Size = New System.Drawing.Size(99, 20)
        Me.TextEnrollmentSchoolYear.TabIndex = 6
        Me.TextEnrollmentSchoolYear.Text = "School Year"
        '
        'TextBoxEnrollmentGradeLvl
        '
        Me.TextBoxEnrollmentGradeLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentGradeLvl.Location = New System.Drawing.Point(90, 122)
        Me.TextBoxEnrollmentGradeLvl.MaxLength = 20
        Me.TextBoxEnrollmentGradeLvl.Name = "TextBoxEnrollmentGradeLvl"
        Me.TextBoxEnrollmentGradeLvl.Size = New System.Drawing.Size(233, 26)
        Me.TextBoxEnrollmentGradeLvl.TabIndex = 5
        '
        'TextEnrollmentGradeLvl
        '
        Me.TextEnrollmentGradeLvl.AutoSize = True
        Me.TextEnrollmentGradeLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentGradeLvl.Location = New System.Drawing.Point(55, 97)
        Me.TextEnrollmentGradeLvl.Name = "TextEnrollmentGradeLvl"
        Me.TextEnrollmentGradeLvl.Size = New System.Drawing.Size(100, 20)
        Me.TextEnrollmentGradeLvl.TabIndex = 4
        Me.TextEnrollmentGradeLvl.Text = "Grade Level"
        '
        'lblTeacherList
        '
        Me.lblTeacherList.AutoSize = True
        Me.lblTeacherList.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTeacherList.ForeColor = System.Drawing.Color.White
        Me.lblTeacherList.Location = New System.Drawing.Point(43, 16)
        Me.lblTeacherList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacherList.Name = "lblTeacherList"
        Me.lblTeacherList.Size = New System.Drawing.Size(176, 32)
        Me.lblTeacherList.TabIndex = 24
        Me.lblTeacherList.Text = "Enrollment List"
        '
        'btnEnrollDelete
        '
        Me.btnEnrollDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnrollDelete.Location = New System.Drawing.Point(1558, 676)
        Me.btnEnrollDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnrollDelete.Name = "btnEnrollDelete"
        Me.btnEnrollDelete.Size = New System.Drawing.Size(115, 43)
        Me.btnEnrollDelete.TabIndex = 27
        Me.btnEnrollDelete.Text = "Delete"
        Me.btnEnrollDelete.UseVisualStyleBackColor = True
        '
        'btnEnrollUpdate
        '
        Me.btnEnrollUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnrollUpdate.Location = New System.Drawing.Point(1408, 676)
        Me.btnEnrollUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnrollUpdate.Name = "btnEnrollUpdate"
        Me.btnEnrollUpdate.Size = New System.Drawing.Size(115, 43)
        Me.btnEnrollUpdate.TabIndex = 26
        Me.btnEnrollUpdate.Text = "Update"
        Me.btnEnrollUpdate.UseVisualStyleBackColor = True
        '
        'btnEnrollAdd
        '
        Me.btnEnrollAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnrollAdd.Location = New System.Drawing.Point(1259, 676)
        Me.btnEnrollAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnrollAdd.Name = "btnEnrollAdd"
        Me.btnEnrollAdd.Size = New System.Drawing.Size(115, 43)
        Me.btnEnrollAdd.TabIndex = 25
        Me.btnEnrollAdd.Text = "Add"
        Me.btnEnrollAdd.UseVisualStyleBackColor = True
        '
        'btnEnrollSearch
        '
        Me.btnEnrollSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnrollSearch.Location = New System.Drawing.Point(1108, 676)
        Me.btnEnrollSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnrollSearch.Name = "btnEnrollSearch"
        Me.btnEnrollSearch.Size = New System.Drawing.Size(117, 43)
        Me.btnEnrollSearch.TabIndex = 24
        Me.btnEnrollSearch.Text = "Search"
        Me.btnEnrollSearch.UseVisualStyleBackColor = True
        '
        'picWatermark
        '
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(487, 139)
        Me.picWatermark.Margin = New System.Windows.Forms.Padding(4)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(648, 596)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 22
        Me.picWatermark.TabStop = False
        '
        'ManageEnrollmentForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1715, 732)
        Me.Controls.Add(Me.pnlContent)
        Me.Name = "ManageEnrollmentForms"
        Me.Text = "ManageEnrollmentForms"
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.dgvEnrollment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContent As Panel
    Friend WithEvents lblTeacherList As Label
    Friend WithEvents btnEnrollDelete As Button
    Friend WithEvents btnEnrollUpdate As Button
    Friend WithEvents btnEnrollAdd As Button
    Friend WithEvents btnEnrollSearch As Button
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxEnrollmentStatus As ComboBox
    Friend WithEvents TextBoxEnrollmentRequirementStatus As TextBox
    Friend WithEvents TextEnrollmentStatus As Label
    Friend WithEvents TextBoxEnrollmentProcessedBy As TextBox
    Friend WithEvents TextEnrollmentProcessedBy As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents EnrollmentRequirementStatus As Label
    Friend WithEvents TextEnrollmentRefNum As Label
    Friend WithEvents TextBoxGuardianName As TextBox
    Friend WithEvents TextEnrollmentGuardianName As Label
    Friend WithEvents TextEnrollmentPaymentStatus As Label
    Friend WithEvents TextEnrollmentDate As Label
    Friend WithEvents TextBoxEnrollmentSchoolYear As TextBox
    Friend WithEvents TextEnrollmentSchoolYear As Label
    Friend WithEvents TextBoxEnrollmentGradeLvl As TextBox
    Friend WithEvents TextEnrollmentGradeLvl As Label
    Friend WithEvents dgvEnrollment As DataGridView
    Friend WithEvents TextBoxEnrollmentRefNum As TextBox
    Friend WithEvents ComboBoxEnrollmentPaymentStatus As ComboBox
    Friend WithEvents TextBoxEnrollmentModeOfPayment As TextBox
    Friend WithEvents TextEnrollmentModeOfPayment As Label
    Friend WithEvents LabelEnrollmentMode As Label
    Friend WithEvents TextBoxEnrollmentContactNo As TextBox
    Friend WithEvents LabelEnrollmentContactNo As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePickerEnrollmentDate As DateTimePicker
    Friend WithEvents EnrollmentID As DataGridViewTextBoxColumn
    Friend WithEvents EStudentID As DataGridViewTextBoxColumn
    Friend WithEvents ESchoolYear As DataGridViewTextBoxColumn
    Friend WithEvents EGradeLevel As DataGridViewTextBoxColumn
    Friend WithEvents ESectionID As DataGridViewTextBoxColumn
    Friend WithEvents EnrollmentDate As DataGridViewTextBoxColumn
    Friend WithEvents EPaymentStatus As DataGridViewTextBoxColumn
    Friend WithEvents EModeOfPayment As DataGridViewTextBoxColumn
    Friend WithEvents EnrollmentStatus As DataGridViewTextBoxColumn
    Friend WithEvents EnrollmentMode As DataGridViewTextBoxColumn
    Friend WithEvents EProcessedBy As DataGridViewTextBoxColumn
    Friend WithEvents EGuardianName As DataGridViewTextBoxColumn
    Friend WithEvents EContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents ERequirementStatus As DataGridViewTextBoxColumn
    Friend WithEvents EReferenceNumber As DataGridViewTextBoxColumn
    Friend WithEvents TextBoxStudentSearch As TextBox
End Class
