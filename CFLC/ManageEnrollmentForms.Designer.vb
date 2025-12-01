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
        Me.TextBoxEnrollSearch = New System.Windows.Forms.TextBox()
        Me.dgvEnrollment = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxEnrollmentModeofPayment = New System.Windows.Forms.ComboBox()
        Me.cmbEnrollmentRequirementStatus = New System.Windows.Forms.ComboBox()
        Me.txtbxEnrollmentRemarks = New System.Windows.Forms.TextBox()
        Me.labelRemarks = New System.Windows.Forms.Label()
        Me.dtpEnrollmentEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnrollmentStartDate = New System.Windows.Forms.DateTimePicker()
        Me.nudEnrollmentGradeLevel = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxEnrollmentStudentID = New System.Windows.Forms.TextBox()
        Me.lblEnrollStudentID = New System.Windows.Forms.Label()
        Me.txtbxEnrollSectionID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxEnrollCreatedBy = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateCreated = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxEnrollmentMode = New System.Windows.Forms.ComboBox()
        Me.LabelEnrollmentMode = New System.Windows.Forms.Label()
        Me.TextEnrollmentModeOfPayment = New System.Windows.Forms.Label()
        Me.ComboBoxEnrollmentPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.TextBoxEnrollmentRefNum = New System.Windows.Forms.TextBox()
        Me.ComboBoxEnrollmentStatus = New System.Windows.Forms.ComboBox()
        Me.TextEnrollmentStatus = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.EnrollmentRequirementStatus = New System.Windows.Forms.Label()
        Me.TextEnrollmentRefNum = New System.Windows.Forms.Label()
        Me.TextEnrollmentPaymentStatus = New System.Windows.Forms.Label()
        Me.TextEnrollmentDate = New System.Windows.Forms.Label()
        Me.TextEnrollmentSchoolYear = New System.Windows.Forms.Label()
        Me.TextEnrollmentGradeLvl = New System.Windows.Forms.Label()
        Me.lblTeacherList = New System.Windows.Forms.Label()
        Me.btnEnrollDelete = New System.Windows.Forms.Button()
        Me.btnEnrollUpdate = New System.Windows.Forms.Button()
        Me.btnEnrollAdd = New System.Windows.Forms.Button()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvEnrollment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.nudEnrollmentGradeLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.TextBoxEnrollSearch)
        Me.pnlContent.Controls.Add(Me.dgvEnrollment)
        Me.pnlContent.Controls.Add(Me.Panel1)
        Me.pnlContent.Controls.Add(Me.lblTeacherList)
        Me.pnlContent.Controls.Add(Me.btnEnrollDelete)
        Me.pnlContent.Controls.Add(Me.btnEnrollUpdate)
        Me.pnlContent.Controls.Add(Me.btnEnrollAdd)
        Me.pnlContent.Controls.Add(Me.picWatermark)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1715, 732)
        Me.pnlContent.TabIndex = 24
        '
        'TextBoxEnrollSearch
        '
        Me.TextBoxEnrollSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEnrollSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollSearch.Location = New System.Drawing.Point(992, 683)
        Me.TextBoxEnrollSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxEnrollSearch.MaxLength = 50
        Me.TextBoxEnrollSearch.Name = "TextBoxEnrollSearch"
        Me.TextBoxEnrollSearch.Size = New System.Drawing.Size(247, 36)
        Me.TextBoxEnrollSearch.TabIndex = 30
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
        Me.dgvEnrollment.Location = New System.Drawing.Point(49, 443)
        Me.dgvEnrollment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvEnrollment.Name = "dgvEnrollment"
        Me.dgvEnrollment.ReadOnly = True
        Me.dgvEnrollment.RowHeadersVisible = False
        Me.dgvEnrollment.RowHeadersWidth = 51
        Me.dgvEnrollment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnrollment.Size = New System.Drawing.Size(1624, 193)
        Me.dgvEnrollment.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.ComboBoxEnrollmentModeofPayment)
        Me.Panel1.Controls.Add(Me.cmbEnrollmentRequirementStatus)
        Me.Panel1.Controls.Add(Me.txtbxEnrollmentRemarks)
        Me.Panel1.Controls.Add(Me.labelRemarks)
        Me.Panel1.Controls.Add(Me.dtpEnrollmentEndDate)
        Me.Panel1.Controls.Add(Me.dtpEnrollmentStartDate)
        Me.Panel1.Controls.Add(Me.nudEnrollmentGradeLevel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtbxEnrollmentStudentID)
        Me.Panel1.Controls.Add(Me.lblEnrollStudentID)
        Me.Panel1.Controls.Add(Me.txtbxEnrollSectionID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtbxEnrollCreatedBy)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpDateCreated)
        Me.Panel1.Controls.Add(Me.ComboBoxEnrollmentMode)
        Me.Panel1.Controls.Add(Me.LabelEnrollmentMode)
        Me.Panel1.Controls.Add(Me.TextEnrollmentModeOfPayment)
        Me.Panel1.Controls.Add(Me.ComboBoxEnrollmentPaymentStatus)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentRefNum)
        Me.Panel1.Controls.Add(Me.ComboBoxEnrollmentStatus)
        Me.Panel1.Controls.Add(Me.TextEnrollmentStatus)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.EnrollmentRequirementStatus)
        Me.Panel1.Controls.Add(Me.TextEnrollmentRefNum)
        Me.Panel1.Controls.Add(Me.TextEnrollmentPaymentStatus)
        Me.Panel1.Controls.Add(Me.TextEnrollmentDate)
        Me.Panel1.Controls.Add(Me.TextEnrollmentSchoolYear)
        Me.Panel1.Controls.Add(Me.TextEnrollmentGradeLvl)
        Me.Panel1.Location = New System.Drawing.Point(51, 66)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Size = New System.Drawing.Size(1627, 354)
        Me.Panel1.TabIndex = 28
        '
        'ComboBoxEnrollmentModeofPayment
        '
        Me.ComboBoxEnrollmentModeofPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEnrollmentModeofPayment.FormattingEnabled = True
        Me.ComboBoxEnrollmentModeofPayment.Items.AddRange(New Object() {"Walk-in", "Online", "Scheduled Appointment"})
        Me.ComboBoxEnrollmentModeofPayment.Location = New System.Drawing.Point(409, 255)
        Me.ComboBoxEnrollmentModeofPayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxEnrollmentModeofPayment.Name = "ComboBoxEnrollmentModeofPayment"
        Me.ComboBoxEnrollmentModeofPayment.Size = New System.Drawing.Size(137, 28)
        Me.ComboBoxEnrollmentModeofPayment.TabIndex = 68
        '
        'cmbEnrollmentRequirementStatus
        '
        Me.cmbEnrollmentRequirementStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEnrollmentRequirementStatus.FormattingEnabled = True
        Me.cmbEnrollmentRequirementStatus.Items.AddRange(New Object() {"Enrolled", "Un-enrolled"})
        Me.cmbEnrollmentRequirementStatus.Location = New System.Drawing.Point(673, 57)
        Me.cmbEnrollmentRequirementStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbEnrollmentRequirementStatus.Name = "cmbEnrollmentRequirementStatus"
        Me.cmbEnrollmentRequirementStatus.Size = New System.Drawing.Size(172, 28)
        Me.cmbEnrollmentRequirementStatus.TabIndex = 67
        '
        'txtbxEnrollmentRemarks
        '
        Me.txtbxEnrollmentRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEnrollmentRemarks.Location = New System.Drawing.Point(673, 191)
        Me.txtbxEnrollmentRemarks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbxEnrollmentRemarks.Multiline = True
        Me.txtbxEnrollmentRemarks.Name = "txtbxEnrollmentRemarks"
        Me.txtbxEnrollmentRemarks.Size = New System.Drawing.Size(207, 94)
        Me.txtbxEnrollmentRemarks.TabIndex = 66
        '
        'labelRemarks
        '
        Me.labelRemarks.AutoSize = True
        Me.labelRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRemarks.Location = New System.Drawing.Point(669, 165)
        Me.labelRemarks.Name = "labelRemarks"
        Me.labelRemarks.Size = New System.Drawing.Size(76, 20)
        Me.labelRemarks.TabIndex = 65
        Me.labelRemarks.Text = "Remarks"
        '
        'dtpEnrollmentEndDate
        '
        Me.dtpEnrollmentEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnrollmentEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnrollmentEndDate.Location = New System.Drawing.Point(96, 121)
        Me.dtpEnrollmentEndDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpEnrollmentEndDate.Name = "dtpEnrollmentEndDate"
        Me.dtpEnrollmentEndDate.Size = New System.Drawing.Size(139, 26)
        Me.dtpEnrollmentEndDate.TabIndex = 64
        '
        'dtpEnrollmentStartDate
        '
        Me.dtpEnrollmentStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnrollmentStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnrollmentStartDate.Location = New System.Drawing.Point(96, 57)
        Me.dtpEnrollmentStartDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpEnrollmentStartDate.Name = "dtpEnrollmentStartDate"
        Me.dtpEnrollmentStartDate.Size = New System.Drawing.Size(139, 26)
        Me.dtpEnrollmentStartDate.TabIndex = 63
        '
        'nudEnrollmentGradeLevel
        '
        Me.nudEnrollmentGradeLevel.Location = New System.Drawing.Point(256, 255)
        Me.nudEnrollmentGradeLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudEnrollmentGradeLevel.Name = "nudEnrollmentGradeLevel"
        Me.nudEnrollmentGradeLevel.Size = New System.Drawing.Size(53, 22)
        Me.nudEnrollmentGradeLevel.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "End Date"
        '
        'txtbxEnrollmentStudentID
        '
        Me.txtbxEnrollmentStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEnrollmentStudentID.Location = New System.Drawing.Point(92, 190)
        Me.txtbxEnrollmentStudentID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbxEnrollmentStudentID.MaxLength = 20
        Me.txtbxEnrollmentStudentID.Name = "txtbxEnrollmentStudentID"
        Me.txtbxEnrollmentStudentID.Size = New System.Drawing.Size(216, 26)
        Me.txtbxEnrollmentStudentID.TabIndex = 59
        '
        'lblEnrollStudentID
        '
        Me.lblEnrollStudentID.AutoSize = True
        Me.lblEnrollStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrollStudentID.Location = New System.Drawing.Point(89, 165)
        Me.lblEnrollStudentID.Name = "lblEnrollStudentID"
        Me.lblEnrollStudentID.Size = New System.Drawing.Size(88, 20)
        Me.lblEnrollStudentID.TabIndex = 58
        Me.lblEnrollStudentID.Text = "Student ID"
        '
        'txtbxEnrollSectionID
        '
        Me.txtbxEnrollSectionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEnrollSectionID.Location = New System.Drawing.Point(89, 256)
        Me.txtbxEnrollSectionID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbxEnrollSectionID.MaxLength = 20
        Me.txtbxEnrollSectionID.Name = "txtbxEnrollSectionID"
        Me.txtbxEnrollSectionID.Size = New System.Drawing.Size(117, 26)
        Me.txtbxEnrollSectionID.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Section ID"
        '
        'txtbxEnrollCreatedBy
        '
        Me.txtbxEnrollCreatedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEnrollCreatedBy.Location = New System.Drawing.Point(1004, 123)
        Me.txtbxEnrollCreatedBy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbxEnrollCreatedBy.MaxLength = 20
        Me.txtbxEnrollCreatedBy.Name = "txtbxEnrollCreatedBy"
        Me.txtbxEnrollCreatedBy.Size = New System.Drawing.Size(233, 26)
        Me.txtbxEnrollCreatedBy.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1001, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Created By"
        '
        'dtpDateCreated
        '
        Me.dtpDateCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateCreated.Location = New System.Drawing.Point(1005, 57)
        Me.dtpDateCreated.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpDateCreated.Name = "dtpDateCreated"
        Me.dtpDateCreated.Size = New System.Drawing.Size(139, 26)
        Me.dtpDateCreated.TabIndex = 53
        '
        'ComboBoxEnrollmentMode
        '
        Me.ComboBoxEnrollmentMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEnrollmentMode.FormattingEnabled = True
        Me.ComboBoxEnrollmentMode.Items.AddRange(New Object() {"Walk-in", "Online", "Scheduled Appointment"})
        Me.ComboBoxEnrollmentMode.Location = New System.Drawing.Point(409, 123)
        Me.ComboBoxEnrollmentMode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxEnrollmentMode.Name = "ComboBoxEnrollmentMode"
        Me.ComboBoxEnrollmentMode.Size = New System.Drawing.Size(111, 28)
        Me.ComboBoxEnrollmentMode.TabIndex = 50
        '
        'LabelEnrollmentMode
        '
        Me.LabelEnrollmentMode.AutoSize = True
        Me.LabelEnrollmentMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEnrollmentMode.Location = New System.Drawing.Point(405, 98)
        Me.LabelEnrollmentMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelEnrollmentMode.Name = "LabelEnrollmentMode"
        Me.LabelEnrollmentMode.Size = New System.Drawing.Size(135, 20)
        Me.LabelEnrollmentMode.TabIndex = 49
        Me.LabelEnrollmentMode.Text = "Enrollment Mode"
        '
        'TextEnrollmentModeOfPayment
        '
        Me.TextEnrollmentModeOfPayment.AutoSize = True
        Me.TextEnrollmentModeOfPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentModeOfPayment.Location = New System.Drawing.Point(405, 231)
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
        Me.ComboBoxEnrollmentPaymentStatus.Location = New System.Drawing.Point(409, 188)
        Me.ComboBoxEnrollmentPaymentStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxEnrollmentPaymentStatus.Name = "ComboBoxEnrollmentPaymentStatus"
        Me.ComboBoxEnrollmentPaymentStatus.Size = New System.Drawing.Size(119, 28)
        Me.ComboBoxEnrollmentPaymentStatus.TabIndex = 46
        '
        'TextBoxEnrollmentRefNum
        '
        Me.TextBoxEnrollmentRefNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentRefNum.Location = New System.Drawing.Point(673, 124)
        Me.TextBoxEnrollmentRefNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxEnrollmentRefNum.Name = "TextBoxEnrollmentRefNum"
        Me.TextBoxEnrollmentRefNum.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxEnrollmentRefNum.TabIndex = 44
        '
        'ComboBoxEnrollmentStatus
        '
        Me.ComboBoxEnrollmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEnrollmentStatus.FormattingEnabled = True
        Me.ComboBoxEnrollmentStatus.Items.AddRange(New Object() {"Enrolled", "Un-enrolled"})
        Me.ComboBoxEnrollmentStatus.Location = New System.Drawing.Point(409, 55)
        Me.ComboBoxEnrollmentStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxEnrollmentStatus.Name = "ComboBoxEnrollmentStatus"
        Me.ComboBoxEnrollmentStatus.Size = New System.Drawing.Size(111, 28)
        Me.ComboBoxEnrollmentStatus.TabIndex = 43
        '
        'TextEnrollmentStatus
        '
        Me.TextEnrollmentStatus.AutoSize = True
        Me.TextEnrollmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentStatus.Location = New System.Drawing.Point(405, 33)
        Me.TextEnrollmentStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TextEnrollmentStatus.Name = "TextEnrollmentStatus"
        Me.TextEnrollmentStatus.Size = New System.Drawing.Size(142, 20)
        Me.TextEnrollmentStatus.TabIndex = 38
        Me.TextEnrollmentStatus.Text = "Enrollment Status"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(-1, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Enrollment List"
        '
        'EnrollmentRequirementStatus
        '
        Me.EnrollmentRequirementStatus.AutoSize = True
        Me.EnrollmentRequirementStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollmentRequirementStatus.Location = New System.Drawing.Point(669, 33)
        Me.EnrollmentRequirementStatus.Name = "EnrollmentRequirementStatus"
        Me.EnrollmentRequirementStatus.Size = New System.Drawing.Size(157, 20)
        Me.EnrollmentRequirementStatus.TabIndex = 20
        Me.EnrollmentRequirementStatus.Text = "Requirement Status"
        '
        'TextEnrollmentRefNum
        '
        Me.TextEnrollmentRefNum.AutoSize = True
        Me.TextEnrollmentRefNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentRefNum.Location = New System.Drawing.Point(669, 98)
        Me.TextEnrollmentRefNum.Name = "TextEnrollmentRefNum"
        Me.TextEnrollmentRefNum.Size = New System.Drawing.Size(150, 20)
        Me.TextEnrollmentRefNum.TabIndex = 16
        Me.TextEnrollmentRefNum.Text = "Reference Number"
        '
        'TextEnrollmentPaymentStatus
        '
        Me.TextEnrollmentPaymentStatus.AutoSize = True
        Me.TextEnrollmentPaymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentPaymentStatus.Location = New System.Drawing.Point(405, 165)
        Me.TextEnrollmentPaymentStatus.Name = "TextEnrollmentPaymentStatus"
        Me.TextEnrollmentPaymentStatus.Size = New System.Drawing.Size(127, 20)
        Me.TextEnrollmentPaymentStatus.TabIndex = 12
        Me.TextEnrollmentPaymentStatus.Text = "Payment Status"
        '
        'TextEnrollmentDate
        '
        Me.TextEnrollmentDate.AutoSize = True
        Me.TextEnrollmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentDate.Location = New System.Drawing.Point(1001, 33)
        Me.TextEnrollmentDate.Name = "TextEnrollmentDate"
        Me.TextEnrollmentDate.Size = New System.Drawing.Size(109, 20)
        Me.TextEnrollmentDate.TabIndex = 10
        Me.TextEnrollmentDate.Text = "Date Created"
        '
        'TextEnrollmentSchoolYear
        '
        Me.TextEnrollmentSchoolYear.AutoSize = True
        Me.TextEnrollmentSchoolYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentSchoolYear.Location = New System.Drawing.Point(92, 33)
        Me.TextEnrollmentSchoolYear.Name = "TextEnrollmentSchoolYear"
        Me.TextEnrollmentSchoolYear.Size = New System.Drawing.Size(86, 20)
        Me.TextEnrollmentSchoolYear.TabIndex = 6
        Me.TextEnrollmentSchoolYear.Text = "Start Date"
        '
        'TextEnrollmentGradeLvl
        '
        Me.TextEnrollmentGradeLvl.AutoSize = True
        Me.TextEnrollmentGradeLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentGradeLvl.Location = New System.Drawing.Point(252, 231)
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
        Me.btnEnrollDelete.Location = New System.Drawing.Point(1557, 676)
        Me.btnEnrollDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnEnrollUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnEnrollAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEnrollAdd.Name = "btnEnrollAdd"
        Me.btnEnrollAdd.Size = New System.Drawing.Size(115, 43)
        Me.btnEnrollAdd.TabIndex = 25
        Me.btnEnrollAdd.Text = "Add"
        Me.btnEnrollAdd.UseVisualStyleBackColor = True
        '
        'picWatermark
        '
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(487, 139)
        Me.picWatermark.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "ManageEnrollmentForms"
        Me.Text = "ManageEnrollmentForms"
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.dgvEnrollment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudEnrollmentGradeLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContent As Panel
    Friend WithEvents lblTeacherList As Label
    Friend WithEvents btnEnrollDelete As Button
    Friend WithEvents btnEnrollUpdate As Button
    Friend WithEvents btnEnrollAdd As Button
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxEnrollmentStatus As ComboBox
    Friend WithEvents TextEnrollmentStatus As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents EnrollmentRequirementStatus As Label
    Friend WithEvents TextEnrollmentRefNum As Label
    Friend WithEvents TextEnrollmentPaymentStatus As Label
    Friend WithEvents TextEnrollmentDate As Label
    Friend WithEvents TextEnrollmentSchoolYear As Label
    Friend WithEvents TextEnrollmentGradeLvl As Label
    Friend WithEvents dgvEnrollment As DataGridView
    Friend WithEvents TextBoxEnrollmentRefNum As TextBox
    Friend WithEvents ComboBoxEnrollmentPaymentStatus As ComboBox
    Friend WithEvents TextEnrollmentModeOfPayment As Label
    Friend WithEvents LabelEnrollmentMode As Label
    Friend WithEvents ComboBoxEnrollmentMode As ComboBox
    Friend WithEvents dtpDateCreated As DateTimePicker
    Friend WithEvents TextBoxEnrollSearch As TextBox
    Friend WithEvents txtbxEnrollCreatedBy As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxEnrollmentStudentID As TextBox
    Friend WithEvents lblEnrollStudentID As Label
    Friend WithEvents txtbxEnrollSectionID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpEnrollmentEndDate As DateTimePicker
    Friend WithEvents dtpEnrollmentStartDate As DateTimePicker
    Friend WithEvents nudEnrollmentGradeLevel As NumericUpDown
    Friend WithEvents txtbxEnrollmentRemarks As TextBox
    Friend WithEvents labelRemarks As Label
    Friend WithEvents cmbEnrollmentRequirementStatus As ComboBox
    Friend WithEvents ComboBoxEnrollmentModeofPayment As ComboBox
End Class
