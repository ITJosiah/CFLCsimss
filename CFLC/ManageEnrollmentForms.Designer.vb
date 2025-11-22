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
        Me.dgvEnrollment = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBoxEnrollmentTotalFees = New System.Windows.Forms.TextBox()
        Me.TextBoxEnrollmentRelationship = New System.Windows.Forms.TextBox()
        Me.ComboBoxEnrollmentStatus = New System.Windows.Forms.ComboBox()
        Me.TextBoxStatus = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentStatus = New System.Windows.Forms.Label()
        Me.TextBoxEnrollmentProcessedBy = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentProcessedBy = New System.Windows.Forms.Label()
        Me.TextBoxEnrollmentBalance = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentBalance = New System.Windows.Forms.Label()
        Me.TextBoxEnrollmentTextBoxEnrollmentAmountPaid = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentAmountPaid = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.EnrollmentTotalFees = New System.Windows.Forms.Label()
        Me.TextBoxEnrollmentAmountPaid = New System.Windows.Forms.TextBox()
        Me.EnrollmentAmountPaid = New System.Windows.Forms.Label()
        Me.EnrollmentStatus = New System.Windows.Forms.Label()
        Me.TextEnrollmentRelationship = New System.Windows.Forms.Label()
        Me.TextBoxGuardianName = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentGuardianName = New System.Windows.Forms.Label()
        Me.TextEnrollmentPaymentStatus = New System.Windows.Forms.Label()
        Me.TextBoxEnrollmentDate = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentDate = New System.Windows.Forms.Label()
        Me.TextBoxSectionID = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentSectionID = New System.Windows.Forms.Label()
        Me.TextBoxEnrollmentSchoolYear = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentSchoolYear = New System.Windows.Forms.Label()
        Me.TextBoxEnrollmentGradeLvl = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentGradeLvl = New System.Windows.Forms.Label()
        Me.TextBoxTeacherMiddleName = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentStudentID = New System.Windows.Forms.Label()
        Me.TextBoxStudentEnrollmentID = New System.Windows.Forms.TextBox()
        Me.TextEnrollmentID = New System.Windows.Forms.Label()
        Me.lblTeacherList = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
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
        Me.pnlContent.Controls.Add(Me.dgvEnrollment)
        Me.pnlContent.Controls.Add(Me.Panel1)
        Me.pnlContent.Controls.Add(Me.lblTeacherList)
        Me.pnlContent.Controls.Add(Me.btnDelete)
        Me.pnlContent.Controls.Add(Me.btnUpdate)
        Me.pnlContent.Controls.Add(Me.btnAdd)
        Me.pnlContent.Controls.Add(Me.btnSearch)
        Me.pnlContent.Controls.Add(Me.picWatermark)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1715, 732)
        Me.pnlContent.TabIndex = 24
        '
        'dgvEnrollment
        '
        Me.dgvEnrollment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEnrollment.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvEnrollment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnrollment.Location = New System.Drawing.Point(49, 451)
        Me.dgvEnrollment.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvEnrollment.Name = "dgvEnrollment"
        Me.dgvEnrollment.RowHeadersWidth = 51
        Me.dgvEnrollment.Size = New System.Drawing.Size(1624, 185)
        Me.dgvEnrollment.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentTotalFees)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentRelationship)
        Me.Panel1.Controls.Add(Me.ComboBoxEnrollmentStatus)
        Me.Panel1.Controls.Add(Me.TextBoxStatus)
        Me.Panel1.Controls.Add(Me.TextEnrollmentStatus)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentProcessedBy)
        Me.Panel1.Controls.Add(Me.TextEnrollmentProcessedBy)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentBalance)
        Me.Panel1.Controls.Add(Me.TextEnrollmentBalance)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentTextBoxEnrollmentAmountPaid)
        Me.Panel1.Controls.Add(Me.TextEnrollmentAmountPaid)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.EnrollmentTotalFees)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentAmountPaid)
        Me.Panel1.Controls.Add(Me.EnrollmentAmountPaid)
        Me.Panel1.Controls.Add(Me.EnrollmentStatus)
        Me.Panel1.Controls.Add(Me.TextEnrollmentRelationship)
        Me.Panel1.Controls.Add(Me.TextBoxGuardianName)
        Me.Panel1.Controls.Add(Me.TextEnrollmentGuardianName)
        Me.Panel1.Controls.Add(Me.TextEnrollmentPaymentStatus)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentDate)
        Me.Panel1.Controls.Add(Me.TextEnrollmentDate)
        Me.Panel1.Controls.Add(Me.TextBoxSectionID)
        Me.Panel1.Controls.Add(Me.TextEnrollmentSectionID)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentSchoolYear)
        Me.Panel1.Controls.Add(Me.TextEnrollmentSchoolYear)
        Me.Panel1.Controls.Add(Me.TextBoxEnrollmentGradeLvl)
        Me.Panel1.Controls.Add(Me.TextEnrollmentGradeLvl)
        Me.Panel1.Controls.Add(Me.TextBoxTeacherMiddleName)
        Me.Panel1.Controls.Add(Me.TextEnrollmentStudentID)
        Me.Panel1.Controls.Add(Me.TextBoxStudentEnrollmentID)
        Me.Panel1.Controls.Add(Me.TextEnrollmentID)
        Me.Panel1.Location = New System.Drawing.Point(51, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(1627, 355)
        Me.Panel1.TabIndex = 28
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Paid", "Unpaid"})
        Me.ComboBox1.Location = New System.Drawing.Point(972, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(118, 28)
        Me.ComboBox1.TabIndex = 46
        '
        'TextBoxEnrollmentTotalFees
        '
        Me.TextBoxEnrollmentTotalFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentTotalFees.Location = New System.Drawing.Point(1362, 45)
        Me.TextBoxEnrollmentTotalFees.Name = "TextBoxEnrollmentTotalFees"
        Me.TextBoxEnrollmentTotalFees.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxEnrollmentTotalFees.TabIndex = 45
        '
        'TextBoxEnrollmentRelationship
        '
        Me.TextBoxEnrollmentRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentRelationship.Location = New System.Drawing.Point(972, 136)
        Me.TextBoxEnrollmentRelationship.Name = "TextBoxEnrollmentRelationship"
        Me.TextBoxEnrollmentRelationship.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxEnrollmentRelationship.TabIndex = 44
        '
        'ComboBoxEnrollmentStatus
        '
        Me.ComboBoxEnrollmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEnrollmentStatus.FormattingEnabled = True
        Me.ComboBoxEnrollmentStatus.Items.AddRange(New Object() {"Enrolled", "Un-enrolled"})
        Me.ComboBoxEnrollmentStatus.Location = New System.Drawing.Point(491, 259)
        Me.ComboBoxEnrollmentStatus.Name = "ComboBoxEnrollmentStatus"
        Me.ComboBoxEnrollmentStatus.Size = New System.Drawing.Size(110, 28)
        Me.ComboBoxEnrollmentStatus.TabIndex = 43
        '
        'TextBoxStatus
        '
        Me.TextBoxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStatus.Location = New System.Drawing.Point(1362, 91)
        Me.TextBoxStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxStatus.Name = "TextBoxStatus"
        Me.TextBoxStatus.Size = New System.Drawing.Size(218, 26)
        Me.TextBoxStatus.TabIndex = 39
        '
        'TextEnrollmentStatus
        '
        Me.TextEnrollmentStatus.AutoSize = True
        Me.TextEnrollmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentStatus.Location = New System.Drawing.Point(422, 237)
        Me.TextEnrollmentStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TextEnrollmentStatus.Name = "TextEnrollmentStatus"
        Me.TextEnrollmentStatus.Size = New System.Drawing.Size(142, 20)
        Me.TextEnrollmentStatus.TabIndex = 38
        Me.TextEnrollmentStatus.Text = "Enrollment Status"
        '
        'TextBoxEnrollmentProcessedBy
        '
        Me.TextBoxEnrollmentProcessedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentProcessedBy.Location = New System.Drawing.Point(491, 207)
        Me.TextBoxEnrollmentProcessedBy.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxEnrollmentProcessedBy.Name = "TextBoxEnrollmentProcessedBy"
        Me.TextBoxEnrollmentProcessedBy.Size = New System.Drawing.Size(305, 26)
        Me.TextBoxEnrollmentProcessedBy.TabIndex = 33
        '
        'TextEnrollmentProcessedBy
        '
        Me.TextEnrollmentProcessedBy.AutoSize = True
        Me.TextEnrollmentProcessedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentProcessedBy.Location = New System.Drawing.Point(422, 184)
        Me.TextEnrollmentProcessedBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TextEnrollmentProcessedBy.Name = "TextEnrollmentProcessedBy"
        Me.TextEnrollmentProcessedBy.Size = New System.Drawing.Size(114, 20)
        Me.TextEnrollmentProcessedBy.TabIndex = 32
        Me.TextEnrollmentProcessedBy.Text = "Processed By"
        '
        'TextBoxEnrollmentBalance
        '
        Me.TextBoxEnrollmentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentBalance.Location = New System.Drawing.Point(84, 261)
        Me.TextBoxEnrollmentBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxEnrollmentBalance.Name = "TextBoxEnrollmentBalance"
        Me.TextBoxEnrollmentBalance.Size = New System.Drawing.Size(305, 26)
        Me.TextBoxEnrollmentBalance.TabIndex = 31
        '
        'TextEnrollmentBalance
        '
        Me.TextEnrollmentBalance.AutoSize = True
        Me.TextEnrollmentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentBalance.Location = New System.Drawing.Point(32, 237)
        Me.TextEnrollmentBalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TextEnrollmentBalance.Name = "TextEnrollmentBalance"
        Me.TextEnrollmentBalance.Size = New System.Drawing.Size(70, 20)
        Me.TextEnrollmentBalance.TabIndex = 30
        Me.TextEnrollmentBalance.Text = "Balance"
        '
        'TextBoxEnrollmentTextBoxEnrollmentAmountPaid
        '
        Me.TextBoxEnrollmentTextBoxEnrollmentAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentTextBoxEnrollmentAmountPaid.Location = New System.Drawing.Point(84, 208)
        Me.TextBoxEnrollmentTextBoxEnrollmentAmountPaid.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxEnrollmentTextBoxEnrollmentAmountPaid.Name = "TextBoxEnrollmentTextBoxEnrollmentAmountPaid"
        Me.TextBoxEnrollmentTextBoxEnrollmentAmountPaid.Size = New System.Drawing.Size(305, 26)
        Me.TextBoxEnrollmentTextBoxEnrollmentAmountPaid.TabIndex = 29
        '
        'TextEnrollmentAmountPaid
        '
        Me.TextEnrollmentAmountPaid.AutoSize = True
        Me.TextEnrollmentAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentAmountPaid.Location = New System.Drawing.Point(31, 184)
        Me.TextEnrollmentAmountPaid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TextEnrollmentAmountPaid.Name = "TextEnrollmentAmountPaid"
        Me.TextEnrollmentAmountPaid.Size = New System.Drawing.Size(104, 20)
        Me.TextEnrollmentAmountPaid.TabIndex = 28
        Me.TextEnrollmentAmountPaid.Text = "Amount Paid"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(-1, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Teacher List"
        '
        'EnrollmentTotalFees
        '
        Me.EnrollmentTotalFees.AutoSize = True
        Me.EnrollmentTotalFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollmentTotalFees.Location = New System.Drawing.Point(1280, 26)
        Me.EnrollmentTotalFees.Name = "EnrollmentTotalFees"
        Me.EnrollmentTotalFees.Size = New System.Drawing.Size(88, 20)
        Me.EnrollmentTotalFees.TabIndex = 24
        Me.EnrollmentTotalFees.Text = "Total Fees"
        '
        'TextBoxEnrollmentAmountPaid
        '
        Me.TextBoxEnrollmentAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentAmountPaid.Location = New System.Drawing.Point(1362, 137)
        Me.TextBoxEnrollmentAmountPaid.Name = "TextBoxEnrollmentAmountPaid"
        Me.TextBoxEnrollmentAmountPaid.Size = New System.Drawing.Size(213, 26)
        Me.TextBoxEnrollmentAmountPaid.TabIndex = 23
        '
        'EnrollmentAmountPaid
        '
        Me.EnrollmentAmountPaid.AutoSize = True
        Me.EnrollmentAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollmentAmountPaid.Location = New System.Drawing.Point(1264, 117)
        Me.EnrollmentAmountPaid.Name = "EnrollmentAmountPaid"
        Me.EnrollmentAmountPaid.Size = New System.Drawing.Size(104, 20)
        Me.EnrollmentAmountPaid.TabIndex = 22
        Me.EnrollmentAmountPaid.Text = "Amount Paid"
        '
        'EnrollmentStatus
        '
        Me.EnrollmentStatus.AutoSize = True
        Me.EnrollmentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollmentStatus.Location = New System.Drawing.Point(1311, 67)
        Me.EnrollmentStatus.Name = "EnrollmentStatus"
        Me.EnrollmentStatus.Size = New System.Drawing.Size(57, 20)
        Me.EnrollmentStatus.TabIndex = 20
        Me.EnrollmentStatus.Text = "Status"
        '
        'TextEnrollmentRelationship
        '
        Me.TextEnrollmentRelationship.AutoSize = True
        Me.TextEnrollmentRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentRelationship.Location = New System.Drawing.Point(877, 113)
        Me.TextEnrollmentRelationship.Name = "TextEnrollmentRelationship"
        Me.TextEnrollmentRelationship.Size = New System.Drawing.Size(101, 20)
        Me.TextEnrollmentRelationship.TabIndex = 16
        Me.TextEnrollmentRelationship.Text = "Relationship"
        '
        'TextBoxGuardianName
        '
        Me.TextBoxGuardianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGuardianName.Location = New System.Drawing.Point(972, 86)
        Me.TextBoxGuardianName.Name = "TextBoxGuardianName"
        Me.TextBoxGuardianName.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxGuardianName.TabIndex = 15
        '
        'TextEnrollmentGuardianName
        '
        Me.TextEnrollmentGuardianName.AutoSize = True
        Me.TextEnrollmentGuardianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentGuardianName.Location = New System.Drawing.Point(852, 63)
        Me.TextEnrollmentGuardianName.Name = "TextEnrollmentGuardianName"
        Me.TextEnrollmentGuardianName.Size = New System.Drawing.Size(126, 20)
        Me.TextEnrollmentGuardianName.TabIndex = 14
        Me.TextEnrollmentGuardianName.Text = "Guardian Name"
        '
        'TextEnrollmentPaymentStatus
        '
        Me.TextEnrollmentPaymentStatus.AutoSize = True
        Me.TextEnrollmentPaymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentPaymentStatus.Location = New System.Drawing.Point(851, 21)
        Me.TextEnrollmentPaymentStatus.Name = "TextEnrollmentPaymentStatus"
        Me.TextEnrollmentPaymentStatus.Size = New System.Drawing.Size(127, 20)
        Me.TextEnrollmentPaymentStatus.TabIndex = 12
        Me.TextEnrollmentPaymentStatus.Text = "Payment Status"
        '
        'TextBoxEnrollmentDate
        '
        Me.TextBoxEnrollmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentDate.Location = New System.Drawing.Point(491, 138)
        Me.TextBoxEnrollmentDate.Name = "TextBoxEnrollmentDate"
        Me.TextBoxEnrollmentDate.Size = New System.Drawing.Size(233, 26)
        Me.TextBoxEnrollmentDate.TabIndex = 11
        '
        'TextEnrollmentDate
        '
        Me.TextEnrollmentDate.AutoSize = True
        Me.TextEnrollmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentDate.Location = New System.Drawing.Point(368, 115)
        Me.TextEnrollmentDate.Name = "TextEnrollmentDate"
        Me.TextEnrollmentDate.Size = New System.Drawing.Size(130, 20)
        Me.TextEnrollmentDate.TabIndex = 10
        Me.TextEnrollmentDate.Text = "Enrollment Date"
        '
        'TextBoxSectionID
        '
        Me.TextBoxSectionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSectionID.Location = New System.Drawing.Point(491, 91)
        Me.TextBoxSectionID.Name = "TextBoxSectionID"
        Me.TextBoxSectionID.Size = New System.Drawing.Size(233, 26)
        Me.TextBoxSectionID.TabIndex = 9
        '
        'TextEnrollmentSectionID
        '
        Me.TextEnrollmentSectionID.AutoSize = True
        Me.TextEnrollmentSectionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentSectionID.Location = New System.Drawing.Point(408, 69)
        Me.TextEnrollmentSectionID.Name = "TextEnrollmentSectionID"
        Me.TextEnrollmentSectionID.Size = New System.Drawing.Size(87, 20)
        Me.TextEnrollmentSectionID.TabIndex = 8
        Me.TextEnrollmentSectionID.Text = "Section ID"
        '
        'TextBoxEnrollmentSchoolYear
        '
        Me.TextBoxEnrollmentSchoolYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentSchoolYear.Location = New System.Drawing.Point(491, 45)
        Me.TextBoxEnrollmentSchoolYear.Name = "TextBoxEnrollmentSchoolYear"
        Me.TextBoxEnrollmentSchoolYear.Size = New System.Drawing.Size(233, 26)
        Me.TextBoxEnrollmentSchoolYear.TabIndex = 7
        '
        'TextEnrollmentSchoolYear
        '
        Me.TextEnrollmentSchoolYear.AutoSize = True
        Me.TextEnrollmentSchoolYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentSchoolYear.Location = New System.Drawing.Point(396, 25)
        Me.TextEnrollmentSchoolYear.Name = "TextEnrollmentSchoolYear"
        Me.TextEnrollmentSchoolYear.Size = New System.Drawing.Size(99, 20)
        Me.TextEnrollmentSchoolYear.TabIndex = 6
        Me.TextEnrollmentSchoolYear.Text = "School Year"
        '
        'TextBoxEnrollmentGradeLvl
        '
        Me.TextBoxEnrollmentGradeLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEnrollmentGradeLvl.Location = New System.Drawing.Point(82, 139)
        Me.TextBoxEnrollmentGradeLvl.Name = "TextBoxEnrollmentGradeLvl"
        Me.TextBoxEnrollmentGradeLvl.Size = New System.Drawing.Size(241, 26)
        Me.TextBoxEnrollmentGradeLvl.TabIndex = 5
        '
        'TextEnrollmentGradeLvl
        '
        Me.TextEnrollmentGradeLvl.AutoSize = True
        Me.TextEnrollmentGradeLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentGradeLvl.Location = New System.Drawing.Point(24, 120)
        Me.TextEnrollmentGradeLvl.Name = "TextEnrollmentGradeLvl"
        Me.TextEnrollmentGradeLvl.Size = New System.Drawing.Size(77, 20)
        Me.TextEnrollmentGradeLvl.TabIndex = 4
        Me.TextEnrollmentGradeLvl.Text = "GradeLvl"
        '
        'TextBoxTeacherMiddleName
        '
        Me.TextBoxTeacherMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherMiddleName.Location = New System.Drawing.Point(84, 91)
        Me.TextBoxTeacherMiddleName.Name = "TextBoxTeacherMiddleName"
        Me.TextBoxTeacherMiddleName.Size = New System.Drawing.Size(239, 26)
        Me.TextBoxTeacherMiddleName.TabIndex = 3
        '
        'TextEnrollmentStudentID
        '
        Me.TextEnrollmentStudentID.AutoSize = True
        Me.TextEnrollmentStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentStudentID.Location = New System.Drawing.Point(24, 69)
        Me.TextEnrollmentStudentID.Name = "TextEnrollmentStudentID"
        Me.TextEnrollmentStudentID.Size = New System.Drawing.Size(88, 20)
        Me.TextEnrollmentStudentID.TabIndex = 2
        Me.TextEnrollmentStudentID.Text = "Student ID"
        '
        'TextBoxStudentEnrollmentID
        '
        Me.TextBoxStudentEnrollmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentEnrollmentID.Location = New System.Drawing.Point(84, 46)
        Me.TextBoxStudentEnrollmentID.Name = "TextBoxStudentEnrollmentID"
        Me.TextBoxStudentEnrollmentID.Size = New System.Drawing.Size(239, 26)
        Me.TextBoxStudentEnrollmentID.TabIndex = 1
        '
        'TextEnrollmentID
        '
        Me.TextEnrollmentID.AutoSize = True
        Me.TextEnrollmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEnrollmentID.Location = New System.Drawing.Point(24, 26)
        Me.TextEnrollmentID.Name = "TextEnrollmentID"
        Me.TextEnrollmentID.Size = New System.Drawing.Size(111, 20)
        Me.TextEnrollmentID.TabIndex = 0
        Me.TextEnrollmentID.Text = "Enrollment ID"
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
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(1558, 676)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(115, 43)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Location = New System.Drawing.Point(1408, 676)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(115, 43)
        Me.btnUpdate.TabIndex = 26
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(1259, 676)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(115, 43)
        Me.btnAdd.TabIndex = 25
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(1108, 676)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(117, 43)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'picWatermark
        '
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(340, 139)
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
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxEnrollmentStatus As ComboBox
    Friend WithEvents TextBoxStatus As TextBox
    Friend WithEvents TextEnrollmentStatus As Label
    Friend WithEvents TextBoxEnrollmentProcessedBy As TextBox
    Friend WithEvents TextEnrollmentProcessedBy As Label
    Friend WithEvents TextBoxEnrollmentBalance As TextBox
    Friend WithEvents TextEnrollmentBalance As Label
    Friend WithEvents TextBoxEnrollmentTextBoxEnrollmentAmountPaid As TextBox
    Friend WithEvents TextEnrollmentAmountPaid As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents EnrollmentTotalFees As Label
    Friend WithEvents TextBoxEnrollmentAmountPaid As TextBox
    Friend WithEvents EnrollmentAmountPaid As Label
    Friend WithEvents EnrollmentStatus As Label
    Friend WithEvents TextEnrollmentRelationship As Label
    Friend WithEvents TextBoxGuardianName As TextBox
    Friend WithEvents TextEnrollmentGuardianName As Label
    Friend WithEvents TextEnrollmentPaymentStatus As Label
    Friend WithEvents TextBoxEnrollmentDate As TextBox
    Friend WithEvents TextEnrollmentDate As Label
    Friend WithEvents TextBoxSectionID As TextBox
    Friend WithEvents TextEnrollmentSectionID As Label
    Friend WithEvents TextBoxEnrollmentSchoolYear As TextBox
    Friend WithEvents TextEnrollmentSchoolYear As Label
    Friend WithEvents TextBoxEnrollmentGradeLvl As TextBox
    Friend WithEvents TextEnrollmentGradeLvl As Label
    Friend WithEvents TextBoxTeacherMiddleName As TextBox
    Friend WithEvents TextEnrollmentStudentID As Label
    Friend WithEvents TextBoxStudentEnrollmentID As TextBox
    Friend WithEvents TextEnrollmentID As Label
    Friend WithEvents dgvEnrollment As DataGridView
    Friend WithEvents TextBoxEnrollmentRelationship As TextBox
    Friend WithEvents TextBoxEnrollmentTotalFees As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
