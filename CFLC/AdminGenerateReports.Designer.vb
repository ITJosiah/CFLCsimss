<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminGenerateReports
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
        Me.dgvSubjects = New System.Windows.Forms.DataGridView()
        Me.lblSubjectView = New System.Windows.Forms.Label()
        Me.cmbSubjectView = New System.Windows.Forms.ComboBox()
        Me.btnAdminGenerateSubjects = New System.Windows.Forms.Button()
        Me.dgvSections = New System.Windows.Forms.DataGridView()
        Me.lblEnrollmentYear = New System.Windows.Forms.Label()
        Me.cmbEnrollmentYear = New System.Windows.Forms.ComboBox()
        Me.lblStudentEnrollmentYear = New System.Windows.Forms.Label()
        Me.cmbStudentEnrollmentYear = New System.Windows.Forms.ComboBox()
        Me.lblEnrollmentSummaryYear = New System.Windows.Forms.Label()
        Me.cmbEnrollmentSummaryYear = New System.Windows.Forms.ComboBox()
        Me.lblSubjectEnrollmentYear = New System.Windows.Forms.Label()
        Me.cmbSubjectEnrollmentYear = New System.Windows.Forms.ComboBox()
        Me.lblSectionView = New System.Windows.Forms.Label()
        Me.cmbSectionView = New System.Windows.Forms.ComboBox()
        Me.btnAdminGenerateSections = New System.Windows.Forms.Button()
        Me.dgvEnrollment = New System.Windows.Forms.DataGridView()
        Me.lblEnrollmentView = New System.Windows.Forms.Label()
        Me.cmbEnrollmentView = New System.Windows.Forms.ComboBox()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.lblGradeLevel = New System.Windows.Forms.Label()
        Me.cmbGradeLevel = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAdminGenerateStudents = New System.Windows.Forms.Button()
        Me.btnAdminGenerateEnrollmentSummary = New System.Windows.Forms.Button()
        Me.grpStudents = New System.Windows.Forms.GroupBox()
        Me.grpEnrollment = New System.Windows.Forms.GroupBox()
        Me.grpSections = New System.Windows.Forms.GroupBox()
        Me.grpSubjects = New System.Windows.Forms.GroupBox()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlMainContent.SuspendLayout()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEnrollment, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlSidebar.Size = New System.Drawing.Size(0, 960)
        Me.pnlSidebar.TabIndex = 12
        '
        'pnlMainContent
        '
        Me.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlMainContent.Controls.Add(Me.grpSubjects)
        Me.pnlMainContent.Controls.Add(Me.grpSections)
        Me.pnlMainContent.Controls.Add(Me.grpEnrollment)
        Me.pnlMainContent.Controls.Add(Me.grpStudents)
        Me.pnlMainContent.Controls.Add(Me.PictureBox1)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(1443, 960)
        Me.pnlMainContent.TabIndex = 13
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
        'grpStudents
        '
        Me.grpStudents.BackColor = System.Drawing.Color.White
        Me.grpStudents.Controls.Add(Me.btnAdminGenerateStudents)
        Me.grpStudents.Controls.Add(Me.lblGradeLevel)
        Me.grpStudents.Controls.Add(Me.cmbGradeLevel)
        Me.grpStudents.Controls.Add(Me.lblStudentEnrollmentYear)
        Me.grpStudents.Controls.Add(Me.cmbStudentEnrollmentYear)
        Me.grpStudents.Controls.Add(Me.dgvStudents)
        Me.grpStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStudents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpStudents.Location = New System.Drawing.Point(50, 20)
        Me.grpStudents.Name = "grpStudents"
        Me.grpStudents.Padding = New System.Windows.Forms.Padding(15, 10, 15, 15)
        Me.grpStudents.Size = New System.Drawing.Size(1200, 200)
        Me.grpStudents.TabIndex = 28
        Me.grpStudents.TabStop = False
        Me.grpStudents.Text = "Student Reports"
        '
        'btnAdminGenerateStudents
        '
        Me.btnAdminGenerateStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAdminGenerateStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminGenerateStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminGenerateStudents.ForeColor = System.Drawing.Color.White
        Me.btnAdminGenerateStudents.Location = New System.Drawing.Point(18, 30)
        Me.btnAdminGenerateStudents.Name = "btnAdminGenerateStudents"
        Me.btnAdminGenerateStudents.Size = New System.Drawing.Size(150, 40)
        Me.btnAdminGenerateStudents.TabIndex = 4
        Me.btnAdminGenerateStudents.Text = "Print Students"
        Me.btnAdminGenerateStudents.UseVisualStyleBackColor = False
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
        Me.grpEnrollment.BackColor = System.Drawing.Color.White
        Me.grpEnrollment.Controls.Add(Me.btnAdminGenerateEnrollmentSummary)
        Me.grpEnrollment.Controls.Add(Me.lblEnrollmentView)
        Me.grpEnrollment.Controls.Add(Me.cmbEnrollmentView)
        Me.grpEnrollment.Controls.Add(Me.lblEnrollmentSummaryYear)
        Me.grpEnrollment.Controls.Add(Me.cmbEnrollmentSummaryYear)
        Me.grpEnrollment.Controls.Add(Me.dgvEnrollment)
        Me.grpEnrollment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEnrollment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpEnrollment.Location = New System.Drawing.Point(50, 240)
        Me.grpEnrollment.Name = "grpEnrollment"
        Me.grpEnrollment.Padding = New System.Windows.Forms.Padding(15, 10, 15, 15)
        Me.grpEnrollment.Size = New System.Drawing.Size(1200, 200)
        Me.grpEnrollment.TabIndex = 29
        Me.grpEnrollment.TabStop = False
        Me.grpEnrollment.Text = "Enrollment Summary Reports"
        '
        'btnAdminGenerateEnrollmentSummary
        '
        Me.btnAdminGenerateEnrollmentSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAdminGenerateEnrollmentSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminGenerateEnrollmentSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminGenerateEnrollmentSummary.ForeColor = System.Drawing.Color.White
        Me.btnAdminGenerateEnrollmentSummary.Location = New System.Drawing.Point(18, 30)
        Me.btnAdminGenerateEnrollmentSummary.Name = "btnAdminGenerateEnrollmentSummary"
        Me.btnAdminGenerateEnrollmentSummary.Size = New System.Drawing.Size(150, 40)
        Me.btnAdminGenerateEnrollmentSummary.TabIndex = 8
        Me.btnAdminGenerateEnrollmentSummary.Text = "Print Enrollments"
        Me.btnAdminGenerateEnrollmentSummary.UseVisualStyleBackColor = False
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
        Me.grpSections.BackColor = System.Drawing.Color.White
        Me.grpSections.Controls.Add(Me.btnAdminGenerateSections)
        Me.grpSections.Controls.Add(Me.lblSectionView)
        Me.grpSections.Controls.Add(Me.cmbSectionView)
        Me.grpSections.Controls.Add(Me.lblEnrollmentYear)
        Me.grpSections.Controls.Add(Me.cmbEnrollmentYear)
        Me.grpSections.Controls.Add(Me.dgvSections)
        Me.grpSections.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSections.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpSections.Location = New System.Drawing.Point(50, 460)
        Me.grpSections.Name = "grpSections"
        Me.grpSections.Padding = New System.Windows.Forms.Padding(15, 10, 15, 15)
        Me.grpSections.Size = New System.Drawing.Size(1200, 200)
        Me.grpSections.TabIndex = 30
        Me.grpSections.TabStop = False
        Me.grpSections.Text = "Section Reports"
        '
        'btnAdminGenerateSections
        '
        Me.btnAdminGenerateSections.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAdminGenerateSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminGenerateSections.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminGenerateSections.ForeColor = System.Drawing.Color.White
        Me.btnAdminGenerateSections.Location = New System.Drawing.Point(18, 30)
        Me.btnAdminGenerateSections.Name = "btnAdminGenerateSections"
        Me.btnAdminGenerateSections.Size = New System.Drawing.Size(150, 40)
        Me.btnAdminGenerateSections.TabIndex = 12
        Me.btnAdminGenerateSections.Text = "Print Section"
        Me.btnAdminGenerateSections.UseVisualStyleBackColor = False
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
        Me.grpSubjects.BackColor = System.Drawing.Color.White
        Me.grpSubjects.Controls.Add(Me.btnAdminGenerateSubjects)
        Me.grpSubjects.Controls.Add(Me.lblSubjectView)
        Me.grpSubjects.Controls.Add(Me.cmbSubjectView)
        Me.grpSubjects.Controls.Add(Me.lblSubjectEnrollmentYear)
        Me.grpSubjects.Controls.Add(Me.cmbSubjectEnrollmentYear)
        Me.grpSubjects.Controls.Add(Me.dgvSubjects)
        Me.grpSubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSubjects.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpSubjects.Location = New System.Drawing.Point(50, 680)
        Me.grpSubjects.Name = "grpSubjects"
        Me.grpSubjects.Padding = New System.Windows.Forms.Padding(15, 10, 15, 15)
        Me.grpSubjects.Size = New System.Drawing.Size(1200, 200)
        Me.grpSubjects.TabIndex = 31
        Me.grpSubjects.TabStop = False
        Me.grpSubjects.Text = "Subject Reports"
        '
        'btnAdminGenerateSubjects
        '
        Me.btnAdminGenerateSubjects.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAdminGenerateSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminGenerateSubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminGenerateSubjects.ForeColor = System.Drawing.Color.White
        Me.btnAdminGenerateSubjects.Location = New System.Drawing.Point(18, 30)
        Me.btnAdminGenerateSubjects.Name = "btnAdminGenerateSubjects"
        Me.btnAdminGenerateSubjects.Size = New System.Drawing.Size(150, 40)
        Me.btnAdminGenerateSubjects.TabIndex = 18
        Me.btnAdminGenerateSubjects.Text = "Print Subjects"
        Me.btnAdminGenerateSubjects.UseVisualStyleBackColor = False
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
        'AdminGenerateReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 960)
        Me.Controls.Add(Me.pnlMainContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Name = "AdminGenerateReports"
        Me.Text = "AdminGenerateReports"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlMainContent.ResumeLayout(False)
        Me.pnlMainContent.PerformLayout()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEnrollment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAdminGenerateStudents As Button
    Friend WithEvents btnAdminGenerateEnrollmentSummary As Button
    Friend WithEvents btnAdminGenerateSections As Button
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
    Friend WithEvents btnAdminGenerateSubjects As Button
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
End Class
