<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuperAdminGenerateReports
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.grpTeacherReports = New System.Windows.Forms.GroupBox()
        Me.grpTeacherSubjectLoad = New System.Windows.Forms.GroupBox()
        Me.dgvTeacherSubjectLoad = New System.Windows.Forms.DataGridView()
        Me.lblTeacherSubjectLoadYear = New System.Windows.Forms.Label()
        Me.cmbTeacherSubjectLoadYear = New System.Windows.Forms.ComboBox()
        Me.btnSuperAdminGenerateTeacherSubjectLoad = New System.Windows.Forms.Button()
        Me.grpTeacherSectionStudents = New System.Windows.Forms.GroupBox()
        Me.dgvTeacherSectionStudents = New System.Windows.Forms.DataGridView()
        Me.lblTeacherGender = New System.Windows.Forms.Label()
        Me.cmbTeacherGender = New System.Windows.Forms.ComboBox()
        Me.btnSuperAdminGenerateTeacherStudents = New System.Windows.Forms.Button()
        Me.lblTeacherID = New System.Windows.Forms.Label()
        Me.txtbxTeacherID = New System.Windows.Forms.TextBox()
        Me.btnSearchTeacher = New System.Windows.Forms.Button()
        Me.grpSubjects = New System.Windows.Forms.GroupBox()
        Me.dgvSubjects = New System.Windows.Forms.DataGridView()
        Me.lblSubjectView = New System.Windows.Forms.Label()
        Me.cmbSubjectView = New System.Windows.Forms.ComboBox()
        Me.btnSuperAdminGenerateSubjects = New System.Windows.Forms.Button()
        Me.lblSubjectEnrollmentYear = New System.Windows.Forms.Label()
        Me.cmbSubjectEnrollmentYear = New System.Windows.Forms.ComboBox()
        Me.grpSections = New System.Windows.Forms.GroupBox()
        Me.dgvSections = New System.Windows.Forms.DataGridView()
        Me.lblEnrollmentYear = New System.Windows.Forms.Label()
        Me.cmbEnrollmentYear = New System.Windows.Forms.ComboBox()
        Me.lblSectionView = New System.Windows.Forms.Label()
        Me.cmbSectionView = New System.Windows.Forms.ComboBox()
        Me.btnSuperAdminGenerateSections = New System.Windows.Forms.Button()
        Me.grpEnrollment = New System.Windows.Forms.GroupBox()
        Me.dgvEnrollment = New System.Windows.Forms.DataGridView()
        Me.lblEnrollmentView = New System.Windows.Forms.Label()
        Me.cmbEnrollmentView = New System.Windows.Forms.ComboBox()
        Me.btnSuperAdminGenerateEnrollmentSummary = New System.Windows.Forms.Button()
        Me.lblEnrollmentSummaryYear = New System.Windows.Forms.Label()
        Me.cmbEnrollmentSummaryYear = New System.Windows.Forms.ComboBox()
        Me.grpStudents = New System.Windows.Forms.GroupBox()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.lblGradeLevel = New System.Windows.Forms.Label()
        Me.cmbGradeLevel = New System.Windows.Forms.ComboBox()
        Me.btnSuperAdminGenerateStudents = New System.Windows.Forms.Button()
        Me.lblStudentEnrollmentYear = New System.Windows.Forms.Label()
        Me.cmbStudentEnrollmentYear = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlMainContent.SuspendLayout()
        Me.grpTeacherReports.SuspendLayout()
        Me.grpTeacherSubjectLoad.SuspendLayout()
        CType(Me.dgvTeacherSubjectLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTeacherSectionStudents.SuspendLayout()
        CType(Me.dgvTeacherSectionStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSubjects.SuspendLayout()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSections.SuspendLayout()
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEnrollment.SuspendLayout()
        CType(Me.dgvEnrollment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStudents.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(300, 960)
        Me.pnlSidebar.TabIndex = 12
        '
        'pnlMainContent
        '
        Me.pnlMainContent.AutoScroll = True
        Me.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlMainContent.Controls.Add(Me.grpTeacherReports)
        Me.pnlMainContent.Controls.Add(Me.grpSubjects)
        Me.pnlMainContent.Controls.Add(Me.grpSections)
        Me.pnlMainContent.Controls.Add(Me.grpEnrollment)
        Me.pnlMainContent.Controls.Add(Me.grpStudents)
        Me.pnlMainContent.Controls.Add(Me.PictureBox1)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(300, 0)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(1143, 960)
        Me.pnlMainContent.TabIndex = 13
        '
        'grpStudents
        '
        Me.grpStudents.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpStudents.BackColor = System.Drawing.Color.White
        Me.grpStudents.Controls.Add(Me.btnSuperAdminGenerateStudents)
        Me.grpStudents.Controls.Add(Me.lblGradeLevel)
        Me.grpStudents.Controls.Add(Me.cmbGradeLevel)
        Me.grpStudents.Controls.Add(Me.lblStudentEnrollmentYear)
        Me.grpStudents.Controls.Add(Me.cmbStudentEnrollmentYear)
        Me.grpStudents.Controls.Add(Me.dgvStudents)
        Me.grpStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStudents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpStudents.Location = New System.Drawing.Point(50, 20)
        Me.grpStudents.Margin = New System.Windows.Forms.Padding(50, 20, 50, 20)
        Me.grpStudents.MinimumSize = New System.Drawing.Size(800, 150)
        Me.grpStudents.Name = "grpStudents"
        Me.grpStudents.Padding = New System.Windows.Forms.Padding(15, 10, 15, 15)
        Me.grpStudents.Size = New System.Drawing.Size(1200, 150)
        Me.grpStudents.TabIndex = 28
        Me.grpStudents.TabStop = False
        Me.grpStudents.Text = "Student Reports"
        '
        'btnSuperAdminGenerateStudents
        '
        Me.btnSuperAdminGenerateStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSuperAdminGenerateStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuperAdminGenerateStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuperAdminGenerateStudents.ForeColor = System.Drawing.Color.White
        Me.btnSuperAdminGenerateStudents.Location = New System.Drawing.Point(18, 30)
        Me.btnSuperAdminGenerateStudents.Name = "btnSuperAdminGenerateStudents"
        Me.btnSuperAdminGenerateStudents.Size = New System.Drawing.Size(150, 40)
        Me.btnSuperAdminGenerateStudents.TabIndex = 4
        Me.btnSuperAdminGenerateStudents.Text = "Print Students"
        Me.btnSuperAdminGenerateStudents.UseVisualStyleBackColor = False
        '
        'cmbGradeLevel
        '
        Me.cmbGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGradeLevel.FormattingEnabled = True
        Me.cmbGradeLevel.Location = New System.Drawing.Point(190, 40)
        Me.cmbGradeLevel.Name = "cmbGradeLevel"
        Me.cmbGradeLevel.Size = New System.Drawing.Size(200, 28)
        Me.cmbGradeLevel.TabIndex = 5
        '
        'lblGradeLevel
        '
        Me.lblGradeLevel.AutoSize = True
        Me.lblGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGradeLevel.Location = New System.Drawing.Point(190, 17)
        Me.lblGradeLevel.Name = "lblGradeLevel"
        Me.lblGradeLevel.Size = New System.Drawing.Size(100, 20)
        Me.lblGradeLevel.TabIndex = 6
        Me.lblGradeLevel.Text = "Grade Level:"
        '
        'cmbStudentEnrollmentYear
        '
        Me.cmbStudentEnrollmentYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudentEnrollmentYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStudentEnrollmentYear.FormattingEnabled = True
        Me.cmbStudentEnrollmentYear.Location = New System.Drawing.Point(410, 40)
        Me.cmbStudentEnrollmentYear.Name = "cmbStudentEnrollmentYear"
        Me.cmbStudentEnrollmentYear.Size = New System.Drawing.Size(200, 28)
        Me.cmbStudentEnrollmentYear.TabIndex = 22
        '
        'lblStudentEnrollmentYear
        '
        Me.lblStudentEnrollmentYear.AutoSize = True
        Me.lblStudentEnrollmentYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentEnrollmentYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStudentEnrollmentYear.Location = New System.Drawing.Point(410, 17)
        Me.lblStudentEnrollmentYear.Name = "lblStudentEnrollmentYear"
        Me.lblStudentEnrollmentYear.Size = New System.Drawing.Size(130, 20)
        Me.lblStudentEnrollmentYear.TabIndex = 23
        Me.lblStudentEnrollmentYear.Text = "Enrollment Year:"
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.White
        Me.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(18, 95)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.RowTemplate.Height = 24
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(1164, 90)
        Me.dgvStudents.TabIndex = 7
        '
        'grpEnrollment
        '
        Me.grpEnrollment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpEnrollment.BackColor = System.Drawing.Color.White
        Me.grpEnrollment.Controls.Add(Me.btnSuperAdminGenerateEnrollmentSummary)
        Me.grpEnrollment.Controls.Add(Me.lblEnrollmentView)
        Me.grpEnrollment.Controls.Add(Me.cmbEnrollmentView)
        Me.grpEnrollment.Controls.Add(Me.lblEnrollmentSummaryYear)
        Me.grpEnrollment.Controls.Add(Me.cmbEnrollmentSummaryYear)
        Me.grpEnrollment.Controls.Add(Me.dgvEnrollment)
        Me.grpEnrollment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEnrollment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpEnrollment.Location = New System.Drawing.Point(50, 240)
        Me.grpEnrollment.Margin = New System.Windows.Forms.Padding(50, 20, 50, 20)
        Me.grpEnrollment.MinimumSize = New System.Drawing.Size(800, 150)
        Me.grpEnrollment.Name = "grpEnrollment"
        Me.grpEnrollment.Padding = New System.Windows.Forms.Padding(15, 10, 15, 15)
        Me.grpEnrollment.Size = New System.Drawing.Size(1200, 150)
        Me.grpEnrollment.TabIndex = 29
        Me.grpEnrollment.TabStop = False
        Me.grpEnrollment.Text = "Enrollment Summary Reports"
        '
        'btnSuperAdminGenerateEnrollmentSummary
        '
        Me.btnSuperAdminGenerateEnrollmentSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSuperAdminGenerateEnrollmentSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuperAdminGenerateEnrollmentSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuperAdminGenerateEnrollmentSummary.ForeColor = System.Drawing.Color.White
        Me.btnSuperAdminGenerateEnrollmentSummary.Location = New System.Drawing.Point(18, 30)
        Me.btnSuperAdminGenerateEnrollmentSummary.Name = "btnSuperAdminGenerateEnrollmentSummary"
        Me.btnSuperAdminGenerateEnrollmentSummary.Size = New System.Drawing.Size(150, 40)
        Me.btnSuperAdminGenerateEnrollmentSummary.TabIndex = 8
        Me.btnSuperAdminGenerateEnrollmentSummary.Text = "Print Enrollments"
        Me.btnSuperAdminGenerateEnrollmentSummary.UseVisualStyleBackColor = False
        '
        'cmbEnrollmentView
        '
        Me.cmbEnrollmentView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEnrollmentView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEnrollmentView.FormattingEnabled = True
        Me.cmbEnrollmentView.Location = New System.Drawing.Point(190, 40)
        Me.cmbEnrollmentView.Name = "cmbEnrollmentView"
        Me.cmbEnrollmentView.Size = New System.Drawing.Size(200, 28)
        Me.cmbEnrollmentView.TabIndex = 9
        '
        'lblEnrollmentView
        '
        Me.lblEnrollmentView.AutoSize = True
        Me.lblEnrollmentView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrollmentView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEnrollmentView.Location = New System.Drawing.Point(190, 17)
        Me.lblEnrollmentView.Name = "lblEnrollmentView"
        Me.lblEnrollmentView.Size = New System.Drawing.Size(133, 20)
        Me.lblEnrollmentView.TabIndex = 10
        Me.lblEnrollmentView.Text = "Enrollment View:"
        '
        'cmbEnrollmentSummaryYear
        '
        Me.cmbEnrollmentSummaryYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEnrollmentSummaryYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEnrollmentSummaryYear.FormattingEnabled = True
        Me.cmbEnrollmentSummaryYear.Location = New System.Drawing.Point(410, 40)
        Me.cmbEnrollmentSummaryYear.Name = "cmbEnrollmentSummaryYear"
        Me.cmbEnrollmentSummaryYear.Size = New System.Drawing.Size(200, 28)
        Me.cmbEnrollmentSummaryYear.TabIndex = 24
        '
        'lblEnrollmentSummaryYear
        '
        Me.lblEnrollmentSummaryYear.AutoSize = True
        Me.lblEnrollmentSummaryYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrollmentSummaryYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEnrollmentSummaryYear.Location = New System.Drawing.Point(410, 17)
        Me.lblEnrollmentSummaryYear.Name = "lblEnrollmentSummaryYear"
        Me.lblEnrollmentSummaryYear.Size = New System.Drawing.Size(130, 20)
        Me.lblEnrollmentSummaryYear.TabIndex = 25
        Me.lblEnrollmentSummaryYear.Text = "Enrollment Year:"
        '
        'dgvEnrollment
        '
        Me.dgvEnrollment.AllowUserToAddRows = False
        Me.dgvEnrollment.AllowUserToDeleteRows = False
        Me.dgvEnrollment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEnrollment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEnrollment.BackgroundColor = System.Drawing.Color.White
        Me.dgvEnrollment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEnrollment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnrollment.Location = New System.Drawing.Point(18, 95)
        Me.dgvEnrollment.Name = "dgvEnrollment"
        Me.dgvEnrollment.ReadOnly = True
        Me.dgvEnrollment.RowHeadersWidth = 51
        Me.dgvEnrollment.RowTemplate.Height = 24
        Me.dgvEnrollment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnrollment.Size = New System.Drawing.Size(1164, 90)
        Me.dgvEnrollment.TabIndex = 11
        '
        'grpSections
        '
        Me.grpSections.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpSections.BackColor = System.Drawing.Color.White
        Me.grpSections.Controls.Add(Me.btnSuperAdminGenerateSections)
        Me.grpSections.Controls.Add(Me.lblSectionView)
        Me.grpSections.Controls.Add(Me.cmbSectionView)
        Me.grpSections.Controls.Add(Me.lblEnrollmentYear)
        Me.grpSections.Controls.Add(Me.cmbEnrollmentYear)
        Me.grpSections.Controls.Add(Me.dgvSections)
        Me.grpSections.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSections.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpSections.Location = New System.Drawing.Point(50, 460)
        Me.grpSections.Margin = New System.Windows.Forms.Padding(50, 20, 50, 20)
        Me.grpSections.MinimumSize = New System.Drawing.Size(800, 150)
        Me.grpSections.Name = "grpSections"
        Me.grpSections.Padding = New System.Windows.Forms.Padding(15, 10, 15, 15)
        Me.grpSections.Size = New System.Drawing.Size(1200, 150)
        Me.grpSections.TabIndex = 30
        Me.grpSections.TabStop = False
        Me.grpSections.Text = "Section Reports"
        '
        'btnSuperAdminGenerateSections
        '
        Me.btnSuperAdminGenerateSections.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSuperAdminGenerateSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuperAdminGenerateSections.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuperAdminGenerateSections.ForeColor = System.Drawing.Color.White
        Me.btnSuperAdminGenerateSections.Location = New System.Drawing.Point(18, 30)
        Me.btnSuperAdminGenerateSections.Name = "btnSuperAdminGenerateSections"
        Me.btnSuperAdminGenerateSections.Size = New System.Drawing.Size(150, 40)
        Me.btnSuperAdminGenerateSections.TabIndex = 12
        Me.btnSuperAdminGenerateSections.Text = "Print Section"
        Me.btnSuperAdminGenerateSections.UseVisualStyleBackColor = False
        '
        'cmbSectionView
        '
        Me.cmbSectionView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSectionView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSectionView.FormattingEnabled = True
        Me.cmbSectionView.Location = New System.Drawing.Point(190, 40)
        Me.cmbSectionView.Name = "cmbSectionView"
        Me.cmbSectionView.Size = New System.Drawing.Size(200, 28)
        Me.cmbSectionView.TabIndex = 13
        '
        'lblSectionView
        '
        Me.lblSectionView.AutoSize = True
        Me.lblSectionView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSectionView.Location = New System.Drawing.Point(190, 17)
        Me.lblSectionView.Name = "lblSectionView"
        Me.lblSectionView.Size = New System.Drawing.Size(100, 20)
        Me.lblSectionView.TabIndex = 14
        Me.lblSectionView.Text = "Section View:"
        '
        'dgvSections
        '
        Me.dgvSections.AllowUserToAddRows = False
        Me.dgvSections.AllowUserToDeleteRows = False
        Me.dgvSections.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSections.BackgroundColor = System.Drawing.Color.White
        Me.dgvSections.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSections.Location = New System.Drawing.Point(18, 95)
        Me.dgvSections.Name = "dgvSections"
        Me.dgvSections.ReadOnly = True
        Me.dgvSections.RowHeadersWidth = 51
        Me.dgvSections.RowTemplate.Height = 24
        Me.dgvSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSections.Size = New System.Drawing.Size(1164, 90)
        Me.dgvSections.TabIndex = 15
        '
        'cmbEnrollmentYear
        '
        Me.cmbEnrollmentYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEnrollmentYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEnrollmentYear.FormattingEnabled = True
        Me.cmbEnrollmentYear.Location = New System.Drawing.Point(410, 40)
        Me.cmbEnrollmentYear.Name = "cmbEnrollmentYear"
        Me.cmbEnrollmentYear.Size = New System.Drawing.Size(200, 28)
        Me.cmbEnrollmentYear.TabIndex = 16
        '
        'lblEnrollmentYear
        '
        Me.lblEnrollmentYear.AutoSize = True
        Me.lblEnrollmentYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrollmentYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEnrollmentYear.Location = New System.Drawing.Point(410, 17)
        Me.lblEnrollmentYear.Name = "lblEnrollmentYear"
        Me.lblEnrollmentYear.Size = New System.Drawing.Size(130, 20)
        Me.lblEnrollmentYear.TabIndex = 17
        Me.lblEnrollmentYear.Text = "Enrollment Year:"
        '
        'grpSubjects
        '
        Me.grpSubjects.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpSubjects.BackColor = System.Drawing.Color.White
        Me.grpSubjects.Controls.Add(Me.btnSuperAdminGenerateSubjects)
        Me.grpSubjects.Controls.Add(Me.lblSubjectView)
        Me.grpSubjects.Controls.Add(Me.cmbSubjectView)
        Me.grpSubjects.Controls.Add(Me.lblSubjectEnrollmentYear)
        Me.grpSubjects.Controls.Add(Me.cmbSubjectEnrollmentYear)
        Me.grpSubjects.Controls.Add(Me.dgvSubjects)
        Me.grpSubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSubjects.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpSubjects.Location = New System.Drawing.Point(50, 680)
        Me.grpSubjects.Margin = New System.Windows.Forms.Padding(50, 20, 50, 20)
        Me.grpSubjects.MinimumSize = New System.Drawing.Size(800, 150)
        Me.grpSubjects.Name = "grpSubjects"
        Me.grpSubjects.Padding = New System.Windows.Forms.Padding(15, 10, 15, 15)
        Me.grpSubjects.Size = New System.Drawing.Size(1200, 150)
        Me.grpSubjects.TabIndex = 31
        Me.grpSubjects.TabStop = False
        Me.grpSubjects.Text = "Subject Reports"
        '
        'btnSuperAdminGenerateSubjects
        '
        Me.btnSuperAdminGenerateSubjects.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSuperAdminGenerateSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuperAdminGenerateSubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuperAdminGenerateSubjects.ForeColor = System.Drawing.Color.White
        Me.btnSuperAdminGenerateSubjects.Location = New System.Drawing.Point(18, 30)
        Me.btnSuperAdminGenerateSubjects.Name = "btnSuperAdminGenerateSubjects"
        Me.btnSuperAdminGenerateSubjects.Size = New System.Drawing.Size(150, 40)
        Me.btnSuperAdminGenerateSubjects.TabIndex = 18
        Me.btnSuperAdminGenerateSubjects.Text = "Print Subjects"
        Me.btnSuperAdminGenerateSubjects.UseVisualStyleBackColor = False
        '
        'cmbSubjectView
        '
        Me.cmbSubjectView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubjectView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubjectView.FormattingEnabled = True
        Me.cmbSubjectView.Location = New System.Drawing.Point(190, 40)
        Me.cmbSubjectView.Name = "cmbSubjectView"
        Me.cmbSubjectView.Size = New System.Drawing.Size(200, 28)
        Me.cmbSubjectView.TabIndex = 19
        '
        'lblSubjectView
        '
        Me.lblSubjectView.AutoSize = True
        Me.lblSubjectView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSubjectView.Location = New System.Drawing.Point(190, 17)
        Me.lblSubjectView.Name = "lblSubjectView"
        Me.lblSubjectView.Size = New System.Drawing.Size(100, 20)
        Me.lblSubjectView.TabIndex = 20
        Me.lblSubjectView.Text = "Subject View:"
        '
        'cmbSubjectEnrollmentYear
        '
        Me.cmbSubjectEnrollmentYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubjectEnrollmentYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubjectEnrollmentYear.FormattingEnabled = True
        Me.cmbSubjectEnrollmentYear.Location = New System.Drawing.Point(410, 40)
        Me.cmbSubjectEnrollmentYear.Name = "cmbSubjectEnrollmentYear"
        Me.cmbSubjectEnrollmentYear.Size = New System.Drawing.Size(200, 28)
        Me.cmbSubjectEnrollmentYear.TabIndex = 26
        '
        'lblSubjectEnrollmentYear
        '
        Me.lblSubjectEnrollmentYear.AutoSize = True
        Me.lblSubjectEnrollmentYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectEnrollmentYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSubjectEnrollmentYear.Location = New System.Drawing.Point(410, 17)
        Me.lblSubjectEnrollmentYear.Name = "lblSubjectEnrollmentYear"
        Me.lblSubjectEnrollmentYear.Size = New System.Drawing.Size(130, 20)
        Me.lblSubjectEnrollmentYear.TabIndex = 27
        Me.lblSubjectEnrollmentYear.Text = "Enrollment Year:"
        '
        'dgvSubjects
        '
        Me.dgvSubjects.AllowUserToAddRows = False
        Me.dgvSubjects.AllowUserToDeleteRows = False
        Me.dgvSubjects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubjects.BackgroundColor = System.Drawing.Color.White
        Me.dgvSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubjects.Location = New System.Drawing.Point(18, 95)
        Me.dgvSubjects.Name = "dgvSubjects"
        Me.dgvSubjects.ReadOnly = True
        Me.dgvSubjects.RowHeadersWidth = 51
        Me.dgvSubjects.RowTemplate.Height = 24
        Me.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubjects.Size = New System.Drawing.Size(1164, 90)
        Me.dgvSubjects.TabIndex = 21
        '
        'grpTeacherReports
        '
        Me.grpTeacherReports.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpTeacherReports.BackColor = System.Drawing.Color.White
        Me.grpTeacherReports.Controls.Add(Me.grpTeacherSubjectLoad)
        Me.grpTeacherReports.Controls.Add(Me.grpTeacherSectionStudents)
        Me.grpTeacherReports.Controls.Add(Me.lblTeacherID)
        Me.grpTeacherReports.Controls.Add(Me.txtbxTeacherID)
        Me.grpTeacherReports.Controls.Add(Me.btnSearchTeacher)
        Me.grpTeacherReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTeacherReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpTeacherReports.Location = New System.Drawing.Point(50, 900)
        Me.grpTeacherReports.Margin = New System.Windows.Forms.Padding(50, 20, 50, 20)
        Me.grpTeacherReports.MinimumSize = New System.Drawing.Size(800, 150)
        Me.grpTeacherReports.Name = "grpTeacherReports"
        Me.grpTeacherReports.Padding = New System.Windows.Forms.Padding(15, 10, 15, 15)
        Me.grpTeacherReports.Size = New System.Drawing.Size(1200, 150)
        Me.grpTeacherReports.TabIndex = 32
        Me.grpTeacherReports.TabStop = False
        Me.grpTeacherReports.Text = "Teacher Reports"
        '
        'lblTeacherID
        '
        Me.lblTeacherID.AutoSize = True
        Me.lblTeacherID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTeacherID.Location = New System.Drawing.Point(18, 30)
        Me.lblTeacherID.Name = "lblTeacherID"
        Me.lblTeacherID.Size = New System.Drawing.Size(88, 20)
        Me.lblTeacherID.TabIndex = 0
        Me.lblTeacherID.Text = "Teacher ID:"
        '
        'txtbxTeacherID
        '
        Me.txtbxTeacherID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherID.Location = New System.Drawing.Point(112, 27)
        Me.txtbxTeacherID.Name = "txtbxTeacherID"
        Me.txtbxTeacherID.Size = New System.Drawing.Size(200, 26)
        Me.txtbxTeacherID.TabIndex = 1
        '
        'btnSearchTeacher
        '
        Me.btnSearchTeacher.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSearchTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchTeacher.ForeColor = System.Drawing.Color.White
        Me.btnSearchTeacher.Location = New System.Drawing.Point(330, 25)
        Me.btnSearchTeacher.Name = "btnSearchTeacher"
        Me.btnSearchTeacher.Size = New System.Drawing.Size(100, 30)
        Me.btnSearchTeacher.TabIndex = 2
        Me.btnSearchTeacher.Text = "Search"
        Me.btnSearchTeacher.UseVisualStyleBackColor = False
        '
        'grpTeacherSectionStudents
        '
        Me.grpTeacherSectionStudents.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpTeacherSectionStudents.BackColor = System.Drawing.Color.White
        Me.grpTeacherSectionStudents.Controls.Add(Me.btnSuperAdminGenerateTeacherStudents)
        Me.grpTeacherSectionStudents.Controls.Add(Me.lblTeacherGender)
        Me.grpTeacherSectionStudents.Controls.Add(Me.cmbTeacherGender)
        Me.grpTeacherSectionStudents.Controls.Add(Me.dgvTeacherSectionStudents)
        Me.grpTeacherSectionStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTeacherSectionStudents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpTeacherSectionStudents.Location = New System.Drawing.Point(18, 70)
        Me.grpTeacherSectionStudents.MinimumSize = New System.Drawing.Size(700, 150)
        Me.grpTeacherSectionStudents.Name = "grpTeacherSectionStudents"
        Me.grpTeacherSectionStudents.Padding = New System.Windows.Forms.Padding(15, 10, 15, 15)
        Me.grpTeacherSectionStudents.Size = New System.Drawing.Size(1164, 150)
        Me.grpTeacherSectionStudents.TabIndex = 3
        Me.grpTeacherSectionStudents.TabStop = False
        Me.grpTeacherSectionStudents.Text = "Section Students Report"
        Me.grpTeacherSectionStudents.Visible = False
        '
        'btnSuperAdminGenerateTeacherStudents
        '
        Me.btnSuperAdminGenerateTeacherStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSuperAdminGenerateTeacherStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuperAdminGenerateTeacherStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuperAdminGenerateTeacherStudents.ForeColor = System.Drawing.Color.White
        Me.btnSuperAdminGenerateTeacherStudents.Location = New System.Drawing.Point(18, 30)
        Me.btnSuperAdminGenerateTeacherStudents.Name = "btnSuperAdminGenerateTeacherStudents"
        Me.btnSuperAdminGenerateTeacherStudents.Size = New System.Drawing.Size(150, 40)
        Me.btnSuperAdminGenerateTeacherStudents.TabIndex = 4
        Me.btnSuperAdminGenerateTeacherStudents.Text = "Print Students"
        Me.btnSuperAdminGenerateTeacherStudents.UseVisualStyleBackColor = False
        '
        'lblTeacherGender
        '
        Me.lblTeacherGender.AutoSize = True
        Me.lblTeacherGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTeacherGender.Location = New System.Drawing.Point(190, 17)
        Me.lblTeacherGender.Name = "lblTeacherGender"
        Me.lblTeacherGender.Size = New System.Drawing.Size(65, 20)
        Me.lblTeacherGender.TabIndex = 6
        Me.lblTeacherGender.Text = "Gender:"
        '
        'cmbTeacherGender
        '
        Me.cmbTeacherGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTeacherGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTeacherGender.FormattingEnabled = True
        Me.cmbTeacherGender.Location = New System.Drawing.Point(190, 40)
        Me.cmbTeacherGender.Name = "cmbTeacherGender"
        Me.cmbTeacherGender.Size = New System.Drawing.Size(200, 28)
        Me.cmbTeacherGender.TabIndex = 5
        '
        'dgvTeacherSectionStudents
        '
        Me.dgvTeacherSectionStudents.AllowUserToAddRows = False
        Me.dgvTeacherSectionStudents.AllowUserToDeleteRows = False
        Me.dgvTeacherSectionStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTeacherSectionStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTeacherSectionStudents.BackgroundColor = System.Drawing.Color.White
        Me.dgvTeacherSectionStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTeacherSectionStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeacherSectionStudents.Location = New System.Drawing.Point(18, 95)
        Me.dgvTeacherSectionStudents.Name = "dgvTeacherSectionStudents"
        Me.dgvTeacherSectionStudents.ReadOnly = True
        Me.dgvTeacherSectionStudents.RowHeadersWidth = 51
        Me.dgvTeacherSectionStudents.RowTemplate.Height = 24
        Me.dgvTeacherSectionStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTeacherSectionStudents.Size = New System.Drawing.Size(1128, 90)
        Me.dgvTeacherSectionStudents.TabIndex = 7
        '
        'grpTeacherSubjectLoad
        '
        Me.grpTeacherSubjectLoad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpTeacherSubjectLoad.BackColor = System.Drawing.Color.White
        Me.grpTeacherSubjectLoad.Controls.Add(Me.btnSuperAdminGenerateTeacherSubjectLoad)
        Me.grpTeacherSubjectLoad.Controls.Add(Me.lblTeacherSubjectLoadYear)
        Me.grpTeacherSubjectLoad.Controls.Add(Me.cmbTeacherSubjectLoadYear)
        Me.grpTeacherSubjectLoad.Controls.Add(Me.dgvTeacherSubjectLoad)
        Me.grpTeacherSubjectLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTeacherSubjectLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpTeacherSubjectLoad.Location = New System.Drawing.Point(18, 230)
        Me.grpTeacherSubjectLoad.MinimumSize = New System.Drawing.Size(700, 150)
        Me.grpTeacherSubjectLoad.Name = "grpTeacherSubjectLoad"
        Me.grpTeacherSubjectLoad.Padding = New System.Windows.Forms.Padding(15, 10, 15, 15)
        Me.grpTeacherSubjectLoad.Size = New System.Drawing.Size(1164, 150)
        Me.grpTeacherSubjectLoad.TabIndex = 4
        Me.grpTeacherSubjectLoad.TabStop = False
        Me.grpTeacherSubjectLoad.Text = "Subject Load Report"
        Me.grpTeacherSubjectLoad.Visible = False
        '
        'btnSuperAdminGenerateTeacherSubjectLoad
        '
        Me.btnSuperAdminGenerateTeacherSubjectLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSuperAdminGenerateTeacherSubjectLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuperAdminGenerateTeacherSubjectLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuperAdminGenerateTeacherSubjectLoad.ForeColor = System.Drawing.Color.White
        Me.btnSuperAdminGenerateTeacherSubjectLoad.Location = New System.Drawing.Point(18, 30)
        Me.btnSuperAdminGenerateTeacherSubjectLoad.Name = "btnSuperAdminGenerateTeacherSubjectLoad"
        Me.btnSuperAdminGenerateTeacherSubjectLoad.Size = New System.Drawing.Size(150, 40)
        Me.btnSuperAdminGenerateTeacherSubjectLoad.TabIndex = 8
        Me.btnSuperAdminGenerateTeacherSubjectLoad.Text = "Print Subject Load"
        Me.btnSuperAdminGenerateTeacherSubjectLoad.UseVisualStyleBackColor = False
        '
        'lblTeacherSubjectLoadYear
        '
        Me.lblTeacherSubjectLoadYear.AutoSize = True
        Me.lblTeacherSubjectLoadYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherSubjectLoadYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTeacherSubjectLoadYear.Location = New System.Drawing.Point(190, 17)
        Me.lblTeacherSubjectLoadYear.Name = "lblTeacherSubjectLoadYear"
        Me.lblTeacherSubjectLoadYear.Size = New System.Drawing.Size(47, 20)
        Me.lblTeacherSubjectLoadYear.TabIndex = 10
        Me.lblTeacherSubjectLoadYear.Text = "Year:"
        '
        'cmbTeacherSubjectLoadYear
        '
        Me.cmbTeacherSubjectLoadYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTeacherSubjectLoadYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTeacherSubjectLoadYear.FormattingEnabled = True
        Me.cmbTeacherSubjectLoadYear.Location = New System.Drawing.Point(190, 40)
        Me.cmbTeacherSubjectLoadYear.Name = "cmbTeacherSubjectLoadYear"
        Me.cmbTeacherSubjectLoadYear.Size = New System.Drawing.Size(200, 28)
        Me.cmbTeacherSubjectLoadYear.TabIndex = 9
        '
        'dgvTeacherSubjectLoad
        '
        Me.dgvTeacherSubjectLoad.AllowUserToAddRows = False
        Me.dgvTeacherSubjectLoad.AllowUserToDeleteRows = False
        Me.dgvTeacherSubjectLoad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTeacherSubjectLoad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTeacherSubjectLoad.BackgroundColor = System.Drawing.Color.White
        Me.dgvTeacherSubjectLoad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTeacherSubjectLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeacherSubjectLoad.Location = New System.Drawing.Point(18, 95)
        Me.dgvTeacherSubjectLoad.Name = "dgvTeacherSubjectLoad"
        Me.dgvTeacherSubjectLoad.ReadOnly = True
        Me.dgvTeacherSubjectLoad.RowHeadersWidth = 51
        Me.dgvTeacherSubjectLoad.RowTemplate.Height = 24
        Me.dgvTeacherSubjectLoad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTeacherSubjectLoad.Size = New System.Drawing.Size(1128, 90)
        Me.dgvTeacherSubjectLoad.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.CFLC.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(534, 247)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 330)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'SuperAdminGenerateReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 960)
        Me.Controls.Add(Me.pnlMainContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "SuperAdminGenerateReports"
        Me.Text = "SuperAdminGenerateReports"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlMainContent.ResumeLayout(False)
        Me.grpTeacherReports.ResumeLayout(False)
        Me.grpTeacherReports.PerformLayout()
        Me.grpTeacherSubjectLoad.ResumeLayout(False)
        Me.grpTeacherSubjectLoad.PerformLayout()
        CType(Me.dgvTeacherSubjectLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTeacherSectionStudents.ResumeLayout(False)
        Me.grpTeacherSectionStudents.PerformLayout()
        CType(Me.dgvTeacherSectionStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSubjects.ResumeLayout(False)
        Me.grpSubjects.PerformLayout()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSections.ResumeLayout(False)
        Me.grpSections.PerformLayout()
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEnrollment.ResumeLayout(False)
        Me.grpEnrollment.PerformLayout()
        CType(Me.dgvEnrollment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStudents.ResumeLayout(False)
        Me.grpStudents.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSuperAdminGenerateStudents As Button
    Friend WithEvents btnSuperAdminGenerateEnrollmentSummary As Button
    Friend WithEvents btnSuperAdminGenerateSections As Button
    Friend WithEvents cmbGradeLevel As ComboBox
    Friend WithEvents lblGradeLevel As Label
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents cmbEnrollmentView As ComboBox
    Friend WithEvents lblEnrollmentView As Label
    Friend WithEvents dgvEnrollment As DataGridView
    Friend WithEvents cmbSectionView As ComboBox
    Friend WithEvents lblSectionView As Label
    Friend WithEvents dgvSections As DataGridView
    Friend WithEvents cmbEnrollmentYear As ComboBox
    Friend WithEvents lblEnrollmentYear As Label
    Friend WithEvents btnSuperAdminGenerateSubjects As Button
    Friend WithEvents cmbSubjectView As ComboBox
    Friend WithEvents lblSubjectView As Label
    Friend WithEvents dgvSubjects As DataGridView
    Friend WithEvents lblStudentEnrollmentYear As Label
    Friend WithEvents cmbStudentEnrollmentYear As ComboBox
    Friend WithEvents lblEnrollmentSummaryYear As Label
    Friend WithEvents cmbEnrollmentSummaryYear As ComboBox
    Friend WithEvents lblSubjectEnrollmentYear As Label
    Friend WithEvents cmbSubjectEnrollmentYear As ComboBox
    Friend WithEvents grpStudents As GroupBox
    Friend WithEvents grpEnrollment As GroupBox
    Friend WithEvents grpSections As GroupBox
    Friend WithEvents grpSubjects As GroupBox
    Friend WithEvents grpTeacherReports As GroupBox
    Friend WithEvents lblTeacherID As Label
    Friend WithEvents txtbxTeacherID As TextBox
    Friend WithEvents btnSearchTeacher As Button
    Friend WithEvents grpTeacherSectionStudents As GroupBox
    Friend WithEvents btnSuperAdminGenerateTeacherStudents As Button
    Friend WithEvents lblTeacherGender As Label
    Friend WithEvents cmbTeacherGender As ComboBox
    Friend WithEvents dgvTeacherSectionStudents As DataGridView
    Friend WithEvents grpTeacherSubjectLoad As GroupBox
    Friend WithEvents btnSuperAdminGenerateTeacherSubjectLoad As Button
    Friend WithEvents lblTeacherSubjectLoadYear As Label
    Friend WithEvents cmbTeacherSubjectLoadYear As ComboBox
    Friend WithEvents dgvTeacherSubjectLoad As DataGridView
End Class
