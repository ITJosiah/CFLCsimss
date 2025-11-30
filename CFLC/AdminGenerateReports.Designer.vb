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
        Me.flowButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnManageStudents = New System.Windows.Forms.Button()
        Me.btnManageTeachers = New System.Windows.Forms.Button()
        Me.btnManageSections = New System.Windows.Forms.Button()
        Me.btnManageSubjects = New System.Windows.Forms.Button()
        Me.btnManageEnrollments = New System.Windows.Forms.Button()
        Me.btnGenerateReports = New System.Windows.Forms.Button()
        Me.btnBackToDashboard = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.dgvSubjects = New System.Windows.Forms.DataGridView()
        Me.lblSubjectView = New System.Windows.Forms.Label()
        Me.cmbSubjectView = New System.Windows.Forms.ComboBox()
        Me.btnAdminGenerateSubjects = New System.Windows.Forms.Button()
        Me.dgvSections = New System.Windows.Forms.DataGridView()
        Me.lblEnrollmentYear = New System.Windows.Forms.Label()
        Me.cmbEnrollmentYear = New System.Windows.Forms.ComboBox()
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
        Me.pnlSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
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
        Me.pnlSidebar.Controls.Add(Me.flowButtons)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(30, 40, 30, 40)
        Me.pnlSidebar.Size = New System.Drawing.Size(300, 960)
        Me.pnlSidebar.TabIndex = 12
        '
        'flowButtons
        '
        Me.flowButtons.BackColor = System.Drawing.Color.Transparent
        Me.flowButtons.Controls.Add(Me.btnManageStudents)
        Me.flowButtons.Controls.Add(Me.btnManageTeachers)
        Me.flowButtons.Controls.Add(Me.btnManageSections)
        Me.flowButtons.Controls.Add(Me.btnManageSubjects)
        Me.flowButtons.Controls.Add(Me.btnManageEnrollments)
        Me.flowButtons.Controls.Add(Me.btnGenerateReports)
        Me.flowButtons.Controls.Add(Me.btnBackToDashboard)
        Me.flowButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowButtons.Location = New System.Drawing.Point(30, 40)
        Me.flowButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.flowButtons.Name = "flowButtons"
        Me.flowButtons.Size = New System.Drawing.Size(240, 730)
        Me.flowButtons.TabIndex = 0
        Me.flowButtons.WrapContents = False
        '
        'btnManageStudents
        '
        Me.btnManageStudents.Location = New System.Drawing.Point(0, 0)
        Me.btnManageStudents.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnManageStudents.Name = "btnManageStudents"
        Me.btnManageStudents.Size = New System.Drawing.Size(240, 45)
        Me.btnManageStudents.TabIndex = 4
        Me.btnManageStudents.Text = "Manage Students"
        Me.btnManageStudents.UseVisualStyleBackColor = True
        '
        'btnManageTeachers
        '
        Me.btnManageTeachers.Location = New System.Drawing.Point(0, 63)
        Me.btnManageTeachers.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnManageTeachers.Name = "btnManageTeachers"
        Me.btnManageTeachers.Size = New System.Drawing.Size(240, 45)
        Me.btnManageTeachers.TabIndex = 5
        Me.btnManageTeachers.Text = "Manage Teachers"
        Me.btnManageTeachers.UseVisualStyleBackColor = True
        '
        'btnManageSections
        '
        Me.btnManageSections.Location = New System.Drawing.Point(0, 126)
        Me.btnManageSections.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnManageSections.Name = "btnManageSections"
        Me.btnManageSections.Size = New System.Drawing.Size(240, 45)
        Me.btnManageSections.TabIndex = 6
        Me.btnManageSections.Text = "Manage Sections"
        Me.btnManageSections.UseVisualStyleBackColor = True
        '
        'btnManageSubjects
        '
        Me.btnManageSubjects.Location = New System.Drawing.Point(0, 189)
        Me.btnManageSubjects.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnManageSubjects.Name = "btnManageSubjects"
        Me.btnManageSubjects.Size = New System.Drawing.Size(240, 45)
        Me.btnManageSubjects.TabIndex = 8
        Me.btnManageSubjects.Text = "Manage Subjects"
        Me.btnManageSubjects.UseVisualStyleBackColor = True
        '
        'btnManageEnrollments
        '
        Me.btnManageEnrollments.Location = New System.Drawing.Point(0, 252)
        Me.btnManageEnrollments.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnManageEnrollments.Name = "btnManageEnrollments"
        Me.btnManageEnrollments.Size = New System.Drawing.Size(240, 45)
        Me.btnManageEnrollments.TabIndex = 7
        Me.btnManageEnrollments.Text = "Manage Enrollments"
        Me.btnManageEnrollments.UseVisualStyleBackColor = True
        '
        'btnGenerateReports
        '
        Me.btnGenerateReports.Location = New System.Drawing.Point(0, 315)
        Me.btnGenerateReports.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnGenerateReports.Name = "btnGenerateReports"
        Me.btnGenerateReports.Size = New System.Drawing.Size(240, 45)
        Me.btnGenerateReports.TabIndex = 9
        Me.btnGenerateReports.Text = "Generate Reports"
        Me.btnGenerateReports.UseVisualStyleBackColor = True
        '
        'btnBackToDashboard
        '
        Me.btnBackToDashboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBackToDashboard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBackToDashboard.Location = New System.Drawing.Point(56, 378)
        Me.btnBackToDashboard.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnBackToDashboard.Name = "btnBackToDashboard"
        Me.btnBackToDashboard.Size = New System.Drawing.Size(127, 45)
        Me.btnBackToDashboard.TabIndex = 10
        Me.btnBackToDashboard.Text = "Back to Dashboard"
        Me.btnBackToDashboard.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(30, 770)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(240, 50)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlMainContent
        '
        Me.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlMainContent.Controls.Add(Me.dgvSubjects)
        Me.pnlMainContent.Controls.Add(Me.lblSubjectView)
        Me.pnlMainContent.Controls.Add(Me.cmbSubjectView)
        Me.pnlMainContent.Controls.Add(Me.btnAdminGenerateSubjects)
        Me.pnlMainContent.Controls.Add(Me.dgvSections)
        Me.pnlMainContent.Controls.Add(Me.lblEnrollmentYear)
        Me.pnlMainContent.Controls.Add(Me.cmbEnrollmentYear)
        Me.pnlMainContent.Controls.Add(Me.lblSectionView)
        Me.pnlMainContent.Controls.Add(Me.cmbSectionView)
        Me.pnlMainContent.Controls.Add(Me.btnAdminGenerateSections)
        Me.pnlMainContent.Controls.Add(Me.dgvEnrollment)
        Me.pnlMainContent.Controls.Add(Me.lblEnrollmentView)
        Me.pnlMainContent.Controls.Add(Me.cmbEnrollmentView)
        Me.pnlMainContent.Controls.Add(Me.btnAdminGenerateEnrollmentSummary)
        Me.pnlMainContent.Controls.Add(Me.dgvStudents)
        Me.pnlMainContent.Controls.Add(Me.lblGradeLevel)
        Me.pnlMainContent.Controls.Add(Me.cmbGradeLevel)
        Me.pnlMainContent.Controls.Add(Me.btnAdminGenerateStudents)
        Me.pnlMainContent.Controls.Add(Me.PictureBox1)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(300, 0)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(1143, 960)
        Me.pnlMainContent.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.CFLC.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(393, 247)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 330)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnAdminGenerateStudents
        '
        Me.btnAdminGenerateStudents.Location = New System.Drawing.Point(116, 30)
        Me.btnAdminGenerateStudents.Name = "btnAdminGenerateStudents"
        Me.btnAdminGenerateStudents.Size = New System.Drawing.Size(169, 40)
        Me.btnAdminGenerateStudents.TabIndex = 4
        Me.btnAdminGenerateStudents.Text = "Print Students"
        Me.btnAdminGenerateStudents.UseVisualStyleBackColor = True
        '
        'cmbGradeLevel
        '
        Me.cmbGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGradeLevel.FormattingEnabled = True
        Me.cmbGradeLevel.Location = New System.Drawing.Point(300, 37)
        Me.cmbGradeLevel.Name = "cmbGradeLevel"
        Me.cmbGradeLevel.Size = New System.Drawing.Size(200, 28)
        Me.cmbGradeLevel.TabIndex = 5
        '
        'lblGradeLevel
        '
        Me.lblGradeLevel.AutoSize = True
        Me.lblGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeLevel.ForeColor = System.Drawing.Color.White
        Me.lblGradeLevel.Location = New System.Drawing.Point(300, 14)
        Me.lblGradeLevel.Name = "lblGradeLevel"
        Me.lblGradeLevel.Size = New System.Drawing.Size(100, 20)
        Me.lblGradeLevel.TabIndex = 6
        Me.lblGradeLevel.Text = "Grade Level:"
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.White
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(116, 80)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.RowTemplate.Height = 24
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(900, 150)
        Me.dgvStudents.TabIndex = 7
        '
        'btnAdminGenerateEnrollmentSummary
        '
        Me.btnAdminGenerateEnrollmentSummary.Location = New System.Drawing.Point(116, 260)
        Me.btnAdminGenerateEnrollmentSummary.Name = "btnAdminGenerateEnrollmentSummary"
        Me.btnAdminGenerateEnrollmentSummary.Size = New System.Drawing.Size(169, 40)
        Me.btnAdminGenerateEnrollmentSummary.TabIndex = 8
        Me.btnAdminGenerateEnrollmentSummary.Text = "Print Enrollments"
        Me.btnAdminGenerateEnrollmentSummary.UseVisualStyleBackColor = True
        '
        'cmbEnrollmentView
        '
        Me.cmbEnrollmentView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEnrollmentView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEnrollmentView.FormattingEnabled = True
        Me.cmbEnrollmentView.Location = New System.Drawing.Point(300, 267)
        Me.cmbEnrollmentView.Name = "cmbEnrollmentView"
        Me.cmbEnrollmentView.Size = New System.Drawing.Size(200, 28)
        Me.cmbEnrollmentView.TabIndex = 9
        '
        'lblEnrollmentView
        '
        Me.lblEnrollmentView.AutoSize = True
        Me.lblEnrollmentView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrollmentView.ForeColor = System.Drawing.Color.White
        Me.lblEnrollmentView.Location = New System.Drawing.Point(300, 244)
        Me.lblEnrollmentView.Name = "lblEnrollmentView"
        Me.lblEnrollmentView.Size = New System.Drawing.Size(133, 20)
        Me.lblEnrollmentView.TabIndex = 10
        Me.lblEnrollmentView.Text = "Enrollment View:"
        '
        'dgvEnrollment
        '
        Me.dgvEnrollment.AllowUserToAddRows = False
        Me.dgvEnrollment.AllowUserToDeleteRows = False
        Me.dgvEnrollment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEnrollment.BackgroundColor = System.Drawing.Color.White
        Me.dgvEnrollment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnrollment.Location = New System.Drawing.Point(116, 310)
        Me.dgvEnrollment.Name = "dgvEnrollment"
        Me.dgvEnrollment.ReadOnly = True
        Me.dgvEnrollment.RowHeadersWidth = 51
        Me.dgvEnrollment.RowTemplate.Height = 24
        Me.dgvEnrollment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnrollment.Size = New System.Drawing.Size(900, 150)
        Me.dgvEnrollment.TabIndex = 11
        '
        'btnAdminGenerateSections
        '
        Me.btnAdminGenerateSections.Location = New System.Drawing.Point(116, 490)
        Me.btnAdminGenerateSections.Name = "btnAdminGenerateSections"
        Me.btnAdminGenerateSections.Size = New System.Drawing.Size(169, 40)
        Me.btnAdminGenerateSections.TabIndex = 12
        Me.btnAdminGenerateSections.Text = "Print Section"
        Me.btnAdminGenerateSections.UseVisualStyleBackColor = True
        '
        'cmbSectionView
        '
        Me.cmbSectionView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSectionView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSectionView.FormattingEnabled = True
        Me.cmbSectionView.Location = New System.Drawing.Point(300, 497)
        Me.cmbSectionView.Name = "cmbSectionView"
        Me.cmbSectionView.Size = New System.Drawing.Size(200, 28)
        Me.cmbSectionView.TabIndex = 13
        '
        'lblSectionView
        '
        Me.lblSectionView.AutoSize = True
        Me.lblSectionView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionView.ForeColor = System.Drawing.Color.White
        Me.lblSectionView.Location = New System.Drawing.Point(300, 474)
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
        Me.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSections.Location = New System.Drawing.Point(116, 540)
        Me.dgvSections.Name = "dgvSections"
        Me.dgvSections.ReadOnly = True
        Me.dgvSections.RowHeadersWidth = 51
        Me.dgvSections.RowTemplate.Height = 24
        Me.dgvSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSections.Size = New System.Drawing.Size(900, 150)
        Me.dgvSections.TabIndex = 15
        '
        'cmbEnrollmentYear
        '
        Me.cmbEnrollmentYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEnrollmentYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEnrollmentYear.FormattingEnabled = True
        Me.cmbEnrollmentYear.Location = New System.Drawing.Point(520, 497)
        Me.cmbEnrollmentYear.Name = "cmbEnrollmentYear"
        Me.cmbEnrollmentYear.Size = New System.Drawing.Size(200, 28)
        Me.cmbEnrollmentYear.TabIndex = 16
        '
        'lblEnrollmentYear
        '
        Me.lblEnrollmentYear.AutoSize = True
        Me.lblEnrollmentYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrollmentYear.ForeColor = System.Drawing.Color.White
        Me.lblEnrollmentYear.Location = New System.Drawing.Point(520, 474)
        Me.lblEnrollmentYear.Name = "lblEnrollmentYear"
        Me.lblEnrollmentYear.Size = New System.Drawing.Size(130, 20)
        Me.lblEnrollmentYear.TabIndex = 17
        Me.lblEnrollmentYear.Text = "Enrollment Year:"
        '
        'btnAdminGenerateSubjects
        '
        Me.btnAdminGenerateSubjects.Location = New System.Drawing.Point(116, 720)
        Me.btnAdminGenerateSubjects.Name = "btnAdminGenerateSubjects"
        Me.btnAdminGenerateSubjects.Size = New System.Drawing.Size(169, 40)
        Me.btnAdminGenerateSubjects.TabIndex = 18
        Me.btnAdminGenerateSubjects.Text = "Print Subjects"
        Me.btnAdminGenerateSubjects.UseVisualStyleBackColor = True
        '
        'cmbSubjectView
        '
        Me.cmbSubjectView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubjectView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubjectView.FormattingEnabled = True
        Me.cmbSubjectView.Location = New System.Drawing.Point(300, 727)
        Me.cmbSubjectView.Name = "cmbSubjectView"
        Me.cmbSubjectView.Size = New System.Drawing.Size(200, 28)
        Me.cmbSubjectView.TabIndex = 19
        '
        'lblSubjectView
        '
        Me.lblSubjectView.AutoSize = True
        Me.lblSubjectView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectView.ForeColor = System.Drawing.Color.White
        Me.lblSubjectView.Location = New System.Drawing.Point(300, 704)
        Me.lblSubjectView.Name = "lblSubjectView"
        Me.lblSubjectView.Size = New System.Drawing.Size(100, 20)
        Me.lblSubjectView.TabIndex = 20
        Me.lblSubjectView.Text = "Subject View:"
        '
        'dgvSubjects
        '
        Me.dgvSubjects.AllowUserToAddRows = False
        Me.dgvSubjects.AllowUserToDeleteRows = False
        Me.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubjects.BackgroundColor = System.Drawing.Color.White
        Me.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubjects.Location = New System.Drawing.Point(116, 770)
        Me.dgvSubjects.Name = "dgvSubjects"
        Me.dgvSubjects.ReadOnly = True
        Me.dgvSubjects.RowHeadersWidth = 51
        Me.dgvSubjects.RowTemplate.Height = 24
        Me.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubjects.Size = New System.Drawing.Size(900, 150)
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
        Me.flowButtons.ResumeLayout(False)
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
    Friend WithEvents flowButtons As FlowLayoutPanel
    Friend WithEvents btnManageStudents As Button
    Friend WithEvents btnManageTeachers As Button
    Friend WithEvents btnManageSections As Button
    Friend WithEvents btnManageSubjects As Button
    Friend WithEvents btnManageEnrollments As Button
    Friend WithEvents btnGenerateReports As Button
    Friend WithEvents btnBackToDashboard As Button
    Friend WithEvents btnLogout As Button
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
End Class
