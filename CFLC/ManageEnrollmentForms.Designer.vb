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
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.nudEnrollmentGradeLevel = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtbxEnrollStudentID = New System.Windows.Forms.Label()
        Me.txtbxEnrollSectionID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxEnrollCreatedBy = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateCreated = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxEnrollmentContactNo = New System.Windows.Forms.TextBox()
        Me.LabelEnrollmentContactNo = New System.Windows.Forms.Label()
        Me.ComboBoxEnrollmentMode = New System.Windows.Forms.ComboBox()
        Me.LabelEnrollmentMode = New System.Windows.Forms.Label()
        Me.TextBoxEnrollmentModeOfPayment = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentModeOfPayment = New System.Windows.Forms.Label()
        Me.ComboBoxEnrollmentPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.TextBoxEnrollmentRefNum = New System.Windows.Forms.TextBox()
        Me.ComboBoxEnrollmentStatus = New System.Windows.Forms.ComboBox()
        Me.TextBoxEnrollmentRequirementStatus = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentStatus = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.EnrollmentRequirementStatus = New System.Windows.Forms.Label()
        Me.TextEnrollmentRefNum = New System.Windows.Forms.Label()
        Me.TextBoxEnrollmentGuardianName = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentGuardianName = New System.Windows.Forms.Label()
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
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1286, 595)
        Me.pnlContent.TabIndex = 24
        '
        'TextBoxEnrollSearch
        '
        Me.TextBoxEnrollSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxEnrollSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollSearch.Location = New System.Drawing.Point(744, 555)
        Me.TextBoxEnrollSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxEnrollSearch.MaxLength = 50
        Me.TextBoxEnrollSearch.Name = "TextBoxEnrollSearch"
        Me.TextBoxEnrollSearch.Size = New System.Drawing.Size(186, 30)
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
        Me.dgvEnrollment.Location = New System.Drawing.Point(37, 360)
        Me.dgvEnrollment.Name = "dgvEnrollment"
        Me.dgvEnrollment.ReadOnly = True
        Me.dgvEnrollment.RowHeadersVisible = False
        Me.dgvEnrollment.RowHeadersWidth = 51
        Me.dgvEnrollment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnrollment.Size = New System.Drawing.Size(1218, 157)
        Me.dgvEnrollment.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.nudEnrollmentGradeLevel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.txtbxEnrollStudentID)
        Me.Panel1.Controls.Add(Me.txtbxEnrollSectionID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtbxEnrollCreatedBy)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpDateCreated)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentContactNo)
        Me.Panel1.Controls.Add(Me.LabelEnrollmentContactNo)
        Me.Panel1.Controls.Add(Me.ComboBoxEnrollmentMode)
        Me.Panel1.Controls.Add(Me.LabelEnrollmentMode)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentModeOfPayment)
        Me.Panel1.Controls.Add(Me.TextEnrollmentModeOfPayment)
        Me.Panel1.Controls.Add(Me.ComboBoxEnrollmentPaymentStatus)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentRefNum)
        Me.Panel1.Controls.Add(Me.ComboBoxEnrollmentStatus)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentRequirementStatus)
        Me.Panel1.Controls.Add(Me.TextEnrollmentStatus)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.EnrollmentRequirementStatus)
        Me.Panel1.Controls.Add(Me.TextEnrollmentRefNum)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentGuardianName)
        Me.Panel1.Controls.Add(Me.TextEnrollmentGuardianName)
        Me.Panel1.Controls.Add(Me.TextEnrollmentPaymentStatus)
        Me.Panel1.Controls.Add(Me.TextEnrollmentDate)
        Me.Panel1.Controls.Add(Me.TextEnrollmentSchoolYear)
        Me.Panel1.Controls.Add(Me.TextEnrollmentGradeLvl)
        Me.Panel1.Location = New System.Drawing.Point(38, 54)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(1220, 288)
        Me.Panel1.TabIndex = 28
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(72, 98)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(105, 23)
        Me.DateTimePicker2.TabIndex = 64
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(72, 46)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 23)
        Me.DateTimePicker1.TabIndex = 63
        '
        'nudEnrollmentGradeLevel
        '
        Me.nudEnrollmentGradeLevel.Location = New System.Drawing.Point(204, 99)
        Me.nudEnrollmentGradeLevel.Name = "nudEnrollmentGradeLevel"
        Me.nudEnrollmentGradeLevel.Size = New System.Drawing.Size(40, 20)
        Me.nudEnrollmentGradeLevel.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "End Date"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(69, 208)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.MaxLength = 20
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 23)
        Me.TextBox2.TabIndex = 59
        '
        'txtbxEnrollStudentID
        '
        Me.txtbxEnrollStudentID.AutoSize = True
        Me.txtbxEnrollStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEnrollStudentID.Location = New System.Drawing.Point(67, 188)
        Me.txtbxEnrollStudentID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtbxEnrollStudentID.Name = "txtbxEnrollStudentID"
        Me.txtbxEnrollStudentID.Size = New System.Drawing.Size(74, 17)
        Me.txtbxEnrollStudentID.TabIndex = 58
        Me.txtbxEnrollStudentID.Text = "Student ID"
        '
        'txtbxEnrollSectionID
        '
        Me.txtbxEnrollSectionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEnrollSectionID.Location = New System.Drawing.Point(69, 153)
        Me.txtbxEnrollSectionID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbxEnrollSectionID.MaxLength = 20
        Me.txtbxEnrollSectionID.Name = "txtbxEnrollSectionID"
        Me.txtbxEnrollSectionID.Size = New System.Drawing.Size(176, 23)
        Me.txtbxEnrollSectionID.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Section ID"
        '
        'txtbxEnrollCreatedBy
        '
        Me.txtbxEnrollCreatedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEnrollCreatedBy.Location = New System.Drawing.Point(753, 100)
        Me.txtbxEnrollCreatedBy.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbxEnrollCreatedBy.MaxLength = 20
        Me.txtbxEnrollCreatedBy.Name = "txtbxEnrollCreatedBy"
        Me.txtbxEnrollCreatedBy.Size = New System.Drawing.Size(176, 23)
        Me.txtbxEnrollCreatedBy.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(751, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Created By"
        '
        'dtpDateCreated
        '
        Me.dtpDateCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateCreated.Location = New System.Drawing.Point(754, 46)
        Me.dtpDateCreated.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDateCreated.Name = "dtpDateCreated"
        Me.dtpDateCreated.Size = New System.Drawing.Size(105, 23)
        Me.dtpDateCreated.TabIndex = 53
        '
        'TextBoxEnrollmentContactNo
        '
        Me.TextBoxEnrollmentContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentContactNo.Location = New System.Drawing.Point(503, 100)
        Me.TextBoxEnrollmentContactNo.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxEnrollmentContactNo.MaxLength = 15
        Me.TextBoxEnrollmentContactNo.Name = "TextBoxEnrollmentContactNo"
        Me.TextBoxEnrollmentContactNo.Size = New System.Drawing.Size(189, 23)
        Me.TextBoxEnrollmentContactNo.TabIndex = 52
        '
        'LabelEnrollmentContactNo
        '
        Me.LabelEnrollmentContactNo.AutoSize = True
        Me.LabelEnrollmentContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEnrollmentContactNo.Location = New System.Drawing.Point(500, 80)
        Me.LabelEnrollmentContactNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelEnrollmentContactNo.Name = "LabelEnrollmentContactNo"
        Me.LabelEnrollmentContactNo.Size = New System.Drawing.Size(82, 17)
        Me.LabelEnrollmentContactNo.TabIndex = 51
        Me.LabelEnrollmentContactNo.Text = "Contact No."
        '
        'ComboBoxEnrollmentMode
        '
        Me.ComboBoxEnrollmentMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEnrollmentMode.FormattingEnabled = True
        Me.ComboBoxEnrollmentMode.Items.AddRange(New Object() {"Walk-in", "Online", "Scheduled Appointment"})
        Me.ComboBoxEnrollmentMode.Location = New System.Drawing.Point(307, 100)
        Me.ComboBoxEnrollmentMode.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxEnrollmentMode.Name = "ComboBoxEnrollmentMode"
        Me.ComboBoxEnrollmentMode.Size = New System.Drawing.Size(84, 24)
        Me.ComboBoxEnrollmentMode.TabIndex = 50
        '
        'LabelEnrollmentMode
        '
        Me.LabelEnrollmentMode.AutoSize = True
        Me.LabelEnrollmentMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEnrollmentMode.Location = New System.Drawing.Point(304, 80)
        Me.LabelEnrollmentMode.Name = "LabelEnrollmentMode"
        Me.LabelEnrollmentMode.Size = New System.Drawing.Size(114, 17)
        Me.LabelEnrollmentMode.TabIndex = 49
        Me.LabelEnrollmentMode.Text = "Enrollment Mode"
        '
        'TextBoxEnrollmentModeOfPayment
        '
        Me.TextBoxEnrollmentModeOfPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentModeOfPayment.Location = New System.Drawing.Point(305, 153)
        Me.TextBoxEnrollmentModeOfPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxEnrollmentModeOfPayment.MaxLength = 20
        Me.TextBoxEnrollmentModeOfPayment.Name = "TextBoxEnrollmentModeOfPayment"
        Me.TextBoxEnrollmentModeOfPayment.Size = New System.Drawing.Size(132, 23)
        Me.TextBoxEnrollmentModeOfPayment.TabIndex = 48
        '
        'TextEnrollmentModeOfPayment
        '
        Me.TextEnrollmentModeOfPayment.AutoSize = True
        Me.TextEnrollmentModeOfPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentModeOfPayment.Location = New System.Drawing.Point(304, 134)
        Me.TextEnrollmentModeOfPayment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TextEnrollmentModeOfPayment.Name = "TextEnrollmentModeOfPayment"
        Me.TextEnrollmentModeOfPayment.Size = New System.Drawing.Size(121, 17)
        Me.TextEnrollmentModeOfPayment.TabIndex = 47
        Me.TextEnrollmentModeOfPayment.Text = "Mode Of Payment"
        '
        'ComboBoxEnrollmentPaymentStatus
        '
        Me.ComboBoxEnrollmentPaymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEnrollmentPaymentStatus.FormattingEnabled = True
        Me.ComboBoxEnrollmentPaymentStatus.Items.AddRange(New Object() {"Paid", "Unpaid"})
        Me.ComboBoxEnrollmentPaymentStatus.Location = New System.Drawing.Point(307, 208)
        Me.ComboBoxEnrollmentPaymentStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxEnrollmentPaymentStatus.Name = "ComboBoxEnrollmentPaymentStatus"
        Me.ComboBoxEnrollmentPaymentStatus.Size = New System.Drawing.Size(90, 24)
        Me.ComboBoxEnrollmentPaymentStatus.TabIndex = 46
        '
        'TextBoxEnrollmentRefNum
        '
        Me.TextBoxEnrollmentRefNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentRefNum.Location = New System.Drawing.Point(503, 209)
        Me.TextBoxEnrollmentRefNum.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxEnrollmentRefNum.Name = "TextBoxEnrollmentRefNum"
        Me.TextBoxEnrollmentRefNum.Size = New System.Drawing.Size(156, 23)
        Me.TextBoxEnrollmentRefNum.TabIndex = 44
        '
        'ComboBoxEnrollmentStatus
        '
        Me.ComboBoxEnrollmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEnrollmentStatus.FormattingEnabled = True
        Me.ComboBoxEnrollmentStatus.Items.AddRange(New Object() {"Enrolled", "Un-enrolled"})
        Me.ComboBoxEnrollmentStatus.Location = New System.Drawing.Point(307, 45)
        Me.ComboBoxEnrollmentStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxEnrollmentStatus.Name = "ComboBoxEnrollmentStatus"
        Me.ComboBoxEnrollmentStatus.Size = New System.Drawing.Size(84, 24)
        Me.ComboBoxEnrollmentStatus.TabIndex = 43
        '
        'TextBoxEnrollmentRequirementStatus
        '
        Me.TextBoxEnrollmentRequirementStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentRequirementStatus.Location = New System.Drawing.Point(503, 152)
        Me.TextBoxEnrollmentRequirementStatus.MaxLength = 20
        Me.TextBoxEnrollmentRequirementStatus.Name = "TextBoxEnrollmentRequirementStatus"
        Me.TextBoxEnrollmentRequirementStatus.Size = New System.Drawing.Size(156, 23)
        Me.TextBoxEnrollmentRequirementStatus.TabIndex = 39
        '
        'TextEnrollmentStatus
        '
        Me.TextEnrollmentStatus.AutoSize = True
        Me.TextEnrollmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentStatus.Location = New System.Drawing.Point(304, 27)
        Me.TextEnrollmentStatus.Name = "TextEnrollmentStatus"
        Me.TextEnrollmentStatus.Size = New System.Drawing.Size(119, 17)
        Me.TextEnrollmentStatus.TabIndex = 38
        Me.TextEnrollmentStatus.Text = "Enrollment Status"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(-1, 2)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 17)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Enrollment List"
        '
        'EnrollmentRequirementStatus
        '
        Me.EnrollmentRequirementStatus.AutoSize = True
        Me.EnrollmentRequirementStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollmentRequirementStatus.Location = New System.Drawing.Point(500, 134)
        Me.EnrollmentRequirementStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EnrollmentRequirementStatus.Name = "EnrollmentRequirementStatus"
        Me.EnrollmentRequirementStatus.Size = New System.Drawing.Size(133, 17)
        Me.EnrollmentRequirementStatus.TabIndex = 20
        Me.EnrollmentRequirementStatus.Text = "Requirement Status"
        '
        'TextEnrollmentRefNum
        '
        Me.TextEnrollmentRefNum.AutoSize = True
        Me.TextEnrollmentRefNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentRefNum.Location = New System.Drawing.Point(500, 188)
        Me.TextEnrollmentRefNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TextEnrollmentRefNum.Name = "TextEnrollmentRefNum"
        Me.TextEnrollmentRefNum.Size = New System.Drawing.Size(128, 17)
        Me.TextEnrollmentRefNum.TabIndex = 16
        Me.TextEnrollmentRefNum.Text = "Reference Number"
        '
        'TextBoxEnrollmentGuardianName
        '
        Me.TextBoxEnrollmentGuardianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentGuardianName.Location = New System.Drawing.Point(502, 46)
        Me.TextBoxEnrollmentGuardianName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxEnrollmentGuardianName.MaxLength = 100
        Me.TextBoxEnrollmentGuardianName.Name = "TextBoxEnrollmentGuardianName"
        Me.TextBoxEnrollmentGuardianName.Size = New System.Drawing.Size(189, 23)
        Me.TextBoxEnrollmentGuardianName.TabIndex = 15
        '
        'TextEnrollmentGuardianName
        '
        Me.TextEnrollmentGuardianName.AutoSize = True
        Me.TextEnrollmentGuardianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentGuardianName.Location = New System.Drawing.Point(499, 27)
        Me.TextEnrollmentGuardianName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TextEnrollmentGuardianName.Name = "TextEnrollmentGuardianName"
        Me.TextEnrollmentGuardianName.Size = New System.Drawing.Size(108, 17)
        Me.TextEnrollmentGuardianName.TabIndex = 14
        Me.TextEnrollmentGuardianName.Text = "Guardian Name"
        '
        'TextEnrollmentPaymentStatus
        '
        Me.TextEnrollmentPaymentStatus.AutoSize = True
        Me.TextEnrollmentPaymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentPaymentStatus.Location = New System.Drawing.Point(304, 188)
        Me.TextEnrollmentPaymentStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TextEnrollmentPaymentStatus.Name = "TextEnrollmentPaymentStatus"
        Me.TextEnrollmentPaymentStatus.Size = New System.Drawing.Size(107, 17)
        Me.TextEnrollmentPaymentStatus.TabIndex = 12
        Me.TextEnrollmentPaymentStatus.Text = "Payment Status"
        '
        'TextEnrollmentDate
        '
        Me.TextEnrollmentDate.AutoSize = True
        Me.TextEnrollmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentDate.Location = New System.Drawing.Point(751, 27)
        Me.TextEnrollmentDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TextEnrollmentDate.Name = "TextEnrollmentDate"
        Me.TextEnrollmentDate.Size = New System.Drawing.Size(92, 17)
        Me.TextEnrollmentDate.TabIndex = 10
        Me.TextEnrollmentDate.Text = "Date Created"
        '
        'TextEnrollmentSchoolYear
        '
        Me.TextEnrollmentSchoolYear.AutoSize = True
        Me.TextEnrollmentSchoolYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentSchoolYear.Location = New System.Drawing.Point(69, 27)
        Me.TextEnrollmentSchoolYear.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TextEnrollmentSchoolYear.Name = "TextEnrollmentSchoolYear"
        Me.TextEnrollmentSchoolYear.Size = New System.Drawing.Size(72, 17)
        Me.TextEnrollmentSchoolYear.TabIndex = 6
        Me.TextEnrollmentSchoolYear.Text = "Start Date"
        '
        'TextEnrollmentGradeLvl
        '
        Me.TextEnrollmentGradeLvl.AutoSize = True
        Me.TextEnrollmentGradeLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentGradeLvl.Location = New System.Drawing.Point(201, 80)
        Me.TextEnrollmentGradeLvl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TextEnrollmentGradeLvl.Name = "TextEnrollmentGradeLvl"
        Me.TextEnrollmentGradeLvl.Size = New System.Drawing.Size(86, 17)
        Me.TextEnrollmentGradeLvl.TabIndex = 4
        Me.TextEnrollmentGradeLvl.Text = "Grade Level"
        '
        'lblTeacherList
        '
        Me.lblTeacherList.AutoSize = True
        Me.lblTeacherList.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTeacherList.ForeColor = System.Drawing.Color.White
        Me.lblTeacherList.Location = New System.Drawing.Point(32, 13)
        Me.lblTeacherList.Name = "lblTeacherList"
        Me.lblTeacherList.Size = New System.Drawing.Size(140, 25)
        Me.lblTeacherList.TabIndex = 24
        Me.lblTeacherList.Text = "Enrollment List"
        '
        'btnEnrollDelete
        '
        Me.btnEnrollDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnrollDelete.Location = New System.Drawing.Point(1168, 549)
        Me.btnEnrollDelete.Name = "btnEnrollDelete"
        Me.btnEnrollDelete.Size = New System.Drawing.Size(86, 35)
        Me.btnEnrollDelete.TabIndex = 27
        Me.btnEnrollDelete.Text = "Delete"
        Me.btnEnrollDelete.UseVisualStyleBackColor = True
        '
        'btnEnrollUpdate
        '
        Me.btnEnrollUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnrollUpdate.Location = New System.Drawing.Point(1056, 549)
        Me.btnEnrollUpdate.Name = "btnEnrollUpdate"
        Me.btnEnrollUpdate.Size = New System.Drawing.Size(86, 35)
        Me.btnEnrollUpdate.TabIndex = 26
        Me.btnEnrollUpdate.Text = "Update"
        Me.btnEnrollUpdate.UseVisualStyleBackColor = True
        '
        'btnEnrollAdd
        '
        Me.btnEnrollAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnrollAdd.Location = New System.Drawing.Point(944, 549)
        Me.btnEnrollAdd.Name = "btnEnrollAdd"
        Me.btnEnrollAdd.Size = New System.Drawing.Size(86, 35)
        Me.btnEnrollAdd.TabIndex = 25
        Me.btnEnrollAdd.Text = "Add"
        Me.btnEnrollAdd.UseVisualStyleBackColor = True
        '
        'picWatermark
        '
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(365, 113)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(486, 484)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 22
        Me.picWatermark.TabStop = False
        '
        'ManageEnrollmentForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 595)
        Me.Controls.Add(Me.pnlContent)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents TextBoxEnrollmentRequirementStatus As TextBox
    Friend WithEvents TextEnrollmentStatus As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents EnrollmentRequirementStatus As Label
    Friend WithEvents TextEnrollmentRefNum As Label
    Friend WithEvents TextBoxEnrollmentGuardianName As TextBox
    Friend WithEvents TextEnrollmentGuardianName As Label
    Friend WithEvents TextEnrollmentPaymentStatus As Label
    Friend WithEvents TextEnrollmentDate As Label
    Friend WithEvents TextEnrollmentSchoolYear As Label
    Friend WithEvents TextEnrollmentGradeLvl As Label
    Friend WithEvents dgvEnrollment As DataGridView
    Friend WithEvents TextBoxEnrollmentRefNum As TextBox
    Friend WithEvents ComboBoxEnrollmentPaymentStatus As ComboBox
    Friend WithEvents TextBoxEnrollmentModeOfPayment As TextBox
    Friend WithEvents TextEnrollmentModeOfPayment As Label
    Friend WithEvents LabelEnrollmentMode As Label
    Friend WithEvents TextBoxEnrollmentContactNo As TextBox
    Friend WithEvents LabelEnrollmentContactNo As Label
    Friend WithEvents ComboBoxEnrollmentMode As ComboBox
    Friend WithEvents dtpDateCreated As DateTimePicker
    Friend WithEvents TextBoxEnrollSearch As TextBox
    Friend WithEvents txtbxEnrollCreatedBy As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtbxEnrollStudentID As Label
    Friend WithEvents txtbxEnrollSectionID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents nudEnrollmentGradeLevel As NumericUpDown
End Class
