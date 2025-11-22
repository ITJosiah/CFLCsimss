<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminManageSubjects
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
        Me.btnManageEnrollments = New System.Windows.Forms.Button()
        Me.btnManageSubjects = New System.Windows.Forms.Button()
        Me.btnGenerateReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlManSubContent = New System.Windows.Forms.Panel()
        Me.btnSubjectDelete = New System.Windows.Forms.Button()
        Me.btnSubjectUpdate = New System.Windows.Forms.Button()
        Me.btnSubjectAdd = New System.Windows.Forms.Button()
        Me.dgvSections = New System.Windows.Forms.DataGridView()
        Me.grpSubjectInformation = New System.Windows.Forms.GroupBox()
        Me.txtbxManSubDescription = New System.Windows.Forms.TextBox()
        Me.lblManSubDescription = New System.Windows.Forms.Label()
        Me.txtbxManSubLearningMaterials = New System.Windows.Forms.TextBox()
        Me.lblManSubLearningMaterials = New System.Windows.Forms.Label()
        Me.dtpManSubDateCreated = New System.Windows.Forms.DateTimePicker()
        Me.txtbxManSubSubjectName = New System.Windows.Forms.TextBox()
        Me.txtbxManSubType = New System.Windows.Forms.TextBox()
        Me.lblManSecDateCreated = New System.Windows.Forms.Label()
        Me.txtbxManSubSkillFocus = New System.Windows.Forms.TextBox()
        Me.txtbxManSubCreatedBy = New System.Windows.Forms.TextBox()
        Me.lblManSubSkillFocus = New System.Windows.Forms.Label()
        Me.lblManSubCreatedBy = New System.Windows.Forms.Label()
        Me.dtpManSubCurriculumYear = New System.Windows.Forms.DateTimePicker()
        Me.nudManSubGradeLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblManSubStatus = New System.Windows.Forms.Label()
        Me.nudManSubQuarters = New System.Windows.Forms.NumericUpDown()
        Me.cmbStudenttGender = New System.Windows.Forms.ComboBox()
        Me.txtbxManSubStatus = New System.Windows.Forms.TextBox()
        Me.lblManSubSubjectName = New System.Windows.Forms.Label()
        Me.txtbxManSubSchedule = New System.Windows.Forms.TextBox()
        Me.lblManSubSchedule = New System.Windows.Forms.Label()
        Me.lblManSubCategory = New System.Windows.Forms.Label()
        Me.lblManSubQuarter = New System.Windows.Forms.Label()
        Me.lblManSubCurriculumYear = New System.Windows.Forms.Label()
        Me.lblManSubRoomType = New System.Windows.Forms.Label()
        Me.lblManSubGradeLevel = New System.Windows.Forms.Label()
        Me.txtbxManSubTeacherID = New System.Windows.Forms.TextBox()
        Me.lblManSubTeacherID = New System.Windows.Forms.Label()
        Me.txtbxManSubSubjectCode = New System.Windows.Forms.TextBox()
        Me.lblManSubSubjectCode = New System.Windows.Forms.Label()
        Me.txtbxManSubSubjectID = New System.Windows.Forms.TextBox()
        Me.lblManSubSubjectD = New System.Windows.Forms.Label()
        Me.lblSubjectList = New System.Windows.Forms.Label()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.btnSubjectSearch = New System.Windows.Forms.Button()
        Me.SubSubjectID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubSubjectCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubSubjectName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubSkillFocus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubGradeLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubRoomType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubLearningMaterials = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTeacherID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubSchedule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubQuarter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubDateCreated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
        Me.pnlManSubContent.SuspendLayout()
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSubjectInformation.SuspendLayout()
        CType(Me.nudManSubGradeLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudManSubQuarters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.flowButtons)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(40, 49, 40, 49)
        Me.pnlSidebar.Size = New System.Drawing.Size(1733, 779)
        Me.pnlSidebar.TabIndex = 13
        '
        'flowButtons
        '
        Me.flowButtons.BackColor = System.Drawing.Color.Transparent
        Me.flowButtons.Controls.Add(Me.btnManageStudents)
        Me.flowButtons.Controls.Add(Me.btnManageTeachers)
        Me.flowButtons.Controls.Add(Me.btnManageSections)
        Me.flowButtons.Controls.Add(Me.btnManageEnrollments)
        Me.flowButtons.Controls.Add(Me.btnManageSubjects)
        Me.flowButtons.Controls.Add(Me.btnGenerateReports)
        Me.flowButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowButtons.Location = New System.Drawing.Point(40, 49)
        Me.flowButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.flowButtons.Name = "flowButtons"
        Me.flowButtons.Size = New System.Drawing.Size(1653, 619)
        Me.flowButtons.TabIndex = 0
        Me.flowButtons.WrapContents = False
        '
        'btnManageStudents
        '
        Me.btnManageStudents.Location = New System.Drawing.Point(0, 0)
        Me.btnManageStudents.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnManageStudents.Name = "btnManageStudents"
        Me.btnManageStudents.Size = New System.Drawing.Size(320, 55)
        Me.btnManageStudents.TabIndex = 4
        Me.btnManageStudents.Text = "Manage Students"
        Me.btnManageStudents.UseVisualStyleBackColor = True
        '
        'btnManageTeachers
        '
        Me.btnManageTeachers.Location = New System.Drawing.Point(0, 77)
        Me.btnManageTeachers.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnManageTeachers.Name = "btnManageTeachers"
        Me.btnManageTeachers.Size = New System.Drawing.Size(320, 55)
        Me.btnManageTeachers.TabIndex = 5
        Me.btnManageTeachers.Text = "Manage Teachers"
        Me.btnManageTeachers.UseVisualStyleBackColor = True
        '
        'btnManageSections
        '
        Me.btnManageSections.Location = New System.Drawing.Point(0, 154)
        Me.btnManageSections.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnManageSections.Name = "btnManageSections"
        Me.btnManageSections.Size = New System.Drawing.Size(320, 55)
        Me.btnManageSections.TabIndex = 6
        Me.btnManageSections.Text = "Manage Sections"
        Me.btnManageSections.UseVisualStyleBackColor = True
        '
        'btnManageEnrollments
        '
        Me.btnManageEnrollments.Location = New System.Drawing.Point(0, 231)
        Me.btnManageEnrollments.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnManageEnrollments.Name = "btnManageEnrollments"
        Me.btnManageEnrollments.Size = New System.Drawing.Size(320, 55)
        Me.btnManageEnrollments.TabIndex = 7
        Me.btnManageEnrollments.Text = "Manage Enrollments"
        Me.btnManageEnrollments.UseVisualStyleBackColor = True
        '
        'btnManageSubjects
        '
        Me.btnManageSubjects.Location = New System.Drawing.Point(0, 308)
        Me.btnManageSubjects.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnManageSubjects.Name = "btnManageSubjects"
        Me.btnManageSubjects.Size = New System.Drawing.Size(320, 55)
        Me.btnManageSubjects.TabIndex = 8
        Me.btnManageSubjects.Text = "Manage Subjects"
        Me.btnManageSubjects.UseVisualStyleBackColor = True
        '
        'btnGenerateReports
        '
        Me.btnGenerateReports.Location = New System.Drawing.Point(0, 385)
        Me.btnGenerateReports.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnGenerateReports.Name = "btnGenerateReports"
        Me.btnGenerateReports.Size = New System.Drawing.Size(320, 55)
        Me.btnGenerateReports.TabIndex = 9
        Me.btnGenerateReports.Text = "Generate Reports"
        Me.btnGenerateReports.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(40, 668)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(1653, 62)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlManSubContent
        '
        Me.pnlManSubContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlManSubContent.Controls.Add(Me.btnSubjectDelete)
        Me.pnlManSubContent.Controls.Add(Me.btnSubjectUpdate)
        Me.pnlManSubContent.Controls.Add(Me.btnSubjectAdd)
        Me.pnlManSubContent.Controls.Add(Me.dgvSections)
        Me.pnlManSubContent.Controls.Add(Me.grpSubjectInformation)
        Me.pnlManSubContent.Controls.Add(Me.lblSubjectList)
        Me.pnlManSubContent.Controls.Add(Me.picWatermark)
        Me.pnlManSubContent.Controls.Add(Me.btnSubjectSearch)
        Me.pnlManSubContent.Location = New System.Drawing.Point(400, 0)
        Me.pnlManSubContent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlManSubContent.Name = "pnlManSubContent"
        Me.pnlManSubContent.Padding = New System.Windows.Forms.Padding(40, 37, 40, 37)
        Me.pnlManSubContent.Size = New System.Drawing.Size(1333, 779)
        Me.pnlManSubContent.TabIndex = 14
        '
        'btnSubjectDelete
        '
        Me.btnSubjectDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubjectDelete.Location = New System.Drawing.Point(1211, 720)
        Me.btnSubjectDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubjectDelete.Name = "btnSubjectDelete"
        Me.btnSubjectDelete.Size = New System.Drawing.Size(115, 43)
        Me.btnSubjectDelete.TabIndex = 9
        Me.btnSubjectDelete.Text = "Delete"
        Me.btnSubjectDelete.UseVisualStyleBackColor = True
        '
        'btnSubjectUpdate
        '
        Me.btnSubjectUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubjectUpdate.Location = New System.Drawing.Point(1061, 720)
        Me.btnSubjectUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubjectUpdate.Name = "btnSubjectUpdate"
        Me.btnSubjectUpdate.Size = New System.Drawing.Size(115, 43)
        Me.btnSubjectUpdate.TabIndex = 8
        Me.btnSubjectUpdate.Text = "Update"
        Me.btnSubjectUpdate.UseVisualStyleBackColor = True
        '
        'btnSubjectAdd
        '
        Me.btnSubjectAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubjectAdd.Location = New System.Drawing.Point(912, 720)
        Me.btnSubjectAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubjectAdd.Name = "btnSubjectAdd"
        Me.btnSubjectAdd.Size = New System.Drawing.Size(115, 43)
        Me.btnSubjectAdd.TabIndex = 7
        Me.btnSubjectAdd.Text = "Add"
        Me.btnSubjectAdd.UseVisualStyleBackColor = True
        '
        'dgvSections
        '
        Me.dgvSections.AllowUserToAddRows = False
        Me.dgvSections.AllowUserToDeleteRows = False
        Me.dgvSections.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSections.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSections.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubSubjectID, Me.SubSubjectCode, Me.SubSubjectName, Me.SubDescription, Me.SubSkillFocus, Me.SubGradeLevel, Me.SubRoomType, Me.SubCategory, Me.SubLearningMaterials, Me.SubTeacherID, Me.SubSchedule, Me.SubQuarter, Me.SubStatus, Me.SubCreatedBy, Me.SubDateCreated})
        Me.dgvSections.Location = New System.Drawing.Point(44, 514)
        Me.dgvSections.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvSections.Name = "dgvSections"
        Me.dgvSections.ReadOnly = True
        Me.dgvSections.RowHeadersVisible = False
        Me.dgvSections.RowHeadersWidth = 51
        Me.dgvSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSections.Size = New System.Drawing.Size(1245, 185)
        Me.dgvSections.TabIndex = 6
        '
        'grpSubjectInformation
        '
        Me.grpSubjectInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSubjectInformation.BackColor = System.Drawing.Color.Gainsboro
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubDescription)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubDescription)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubLearningMaterials)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubLearningMaterials)
        Me.grpSubjectInformation.Controls.Add(Me.dtpManSubDateCreated)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubSubjectName)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubType)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSecDateCreated)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubSkillFocus)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubCreatedBy)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubSkillFocus)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubCreatedBy)
        Me.grpSubjectInformation.Controls.Add(Me.dtpManSubCurriculumYear)
        Me.grpSubjectInformation.Controls.Add(Me.nudManSubGradeLevel)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubStatus)
        Me.grpSubjectInformation.Controls.Add(Me.nudManSubQuarters)
        Me.grpSubjectInformation.Controls.Add(Me.cmbStudenttGender)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubStatus)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubSubjectName)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubSchedule)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubSchedule)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubCategory)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubQuarter)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubCurriculumYear)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubRoomType)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubGradeLevel)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubTeacherID)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubTeacherID)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubSubjectCode)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubSubjectCode)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubSubjectID)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubSubjectD)
        Me.grpSubjectInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSubjectInformation.Location = New System.Drawing.Point(44, 97)
        Me.grpSubjectInformation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSubjectInformation.Name = "grpSubjectInformation"
        Me.grpSubjectInformation.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSubjectInformation.Size = New System.Drawing.Size(1245, 384)
        Me.grpSubjectInformation.TabIndex = 3
        Me.grpSubjectInformation.TabStop = False
        Me.grpSubjectInformation.Text = "Subject Information"
        '
        'txtbxManSubDescription
        '
        Me.txtbxManSubDescription.Location = New System.Drawing.Point(389, 246)
        Me.txtbxManSubDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubDescription.Name = "txtbxManSubDescription"
        Me.txtbxManSubDescription.Size = New System.Drawing.Size(239, 26)
        Me.txtbxManSubDescription.TabIndex = 34
        '
        'lblManSubDescription
        '
        Me.lblManSubDescription.AutoSize = True
        Me.lblManSubDescription.Location = New System.Drawing.Point(385, 219)
        Me.lblManSubDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubDescription.Name = "lblManSubDescription"
        Me.lblManSubDescription.Size = New System.Drawing.Size(95, 20)
        Me.lblManSubDescription.TabIndex = 33
        Me.lblManSubDescription.Text = "Description"
        '
        'txtbxManSubLearningMaterials
        '
        Me.txtbxManSubLearningMaterials.Location = New System.Drawing.Point(73, 246)
        Me.txtbxManSubLearningMaterials.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubLearningMaterials.Name = "txtbxManSubLearningMaterials"
        Me.txtbxManSubLearningMaterials.Size = New System.Drawing.Size(239, 26)
        Me.txtbxManSubLearningMaterials.TabIndex = 32
        '
        'lblManSubLearningMaterials
        '
        Me.lblManSubLearningMaterials.AutoSize = True
        Me.lblManSubLearningMaterials.Location = New System.Drawing.Point(69, 219)
        Me.lblManSubLearningMaterials.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubLearningMaterials.Name = "lblManSubLearningMaterials"
        Me.lblManSubLearningMaterials.Size = New System.Drawing.Size(148, 20)
        Me.lblManSubLearningMaterials.TabIndex = 31
        Me.lblManSubLearningMaterials.Text = "Learning Materials"
        '
        'dtpManSubDateCreated
        '
        Me.dtpManSubDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpManSubDateCreated.Location = New System.Drawing.Point(995, 340)
        Me.dtpManSubDateCreated.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpManSubDateCreated.Name = "dtpManSubDateCreated"
        Me.dtpManSubDateCreated.Size = New System.Drawing.Size(136, 26)
        Me.dtpManSubDateCreated.TabIndex = 7
        '
        'txtbxManSubSubjectName
        '
        Me.txtbxManSubSubjectName.Location = New System.Drawing.Point(872, 165)
        Me.txtbxManSubSubjectName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubSubjectName.Name = "txtbxManSubSubjectName"
        Me.txtbxManSubSubjectName.Size = New System.Drawing.Size(176, 26)
        Me.txtbxManSubSubjectName.TabIndex = 30
        '
        'txtbxManSubType
        '
        Me.txtbxManSubType.Location = New System.Drawing.Point(872, 108)
        Me.txtbxManSubType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubType.Name = "txtbxManSubType"
        Me.txtbxManSubType.Size = New System.Drawing.Size(176, 26)
        Me.txtbxManSubType.TabIndex = 29
        '
        'lblManSecDateCreated
        '
        Me.lblManSecDateCreated.AutoSize = True
        Me.lblManSecDateCreated.Location = New System.Drawing.Point(991, 315)
        Me.lblManSecDateCreated.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecDateCreated.Name = "lblManSecDateCreated"
        Me.lblManSecDateCreated.Size = New System.Drawing.Size(109, 20)
        Me.lblManSecDateCreated.TabIndex = 4
        Me.lblManSecDateCreated.Text = "Date Created"
        '
        'txtbxManSubSkillFocus
        '
        Me.txtbxManSubSkillFocus.Location = New System.Drawing.Point(632, 164)
        Me.txtbxManSubSkillFocus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubSkillFocus.Name = "txtbxManSubSkillFocus"
        Me.txtbxManSubSkillFocus.Size = New System.Drawing.Size(176, 26)
        Me.txtbxManSubSkillFocus.TabIndex = 13
        '
        'txtbxManSubCreatedBy
        '
        Me.txtbxManSubCreatedBy.Location = New System.Drawing.Point(715, 342)
        Me.txtbxManSubCreatedBy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubCreatedBy.Name = "txtbxManSubCreatedBy"
        Me.txtbxManSubCreatedBy.Size = New System.Drawing.Size(239, 26)
        Me.txtbxManSubCreatedBy.TabIndex = 1
        '
        'lblManSubSkillFocus
        '
        Me.lblManSubSkillFocus.AutoSize = True
        Me.lblManSubSkillFocus.Location = New System.Drawing.Point(628, 140)
        Me.lblManSubSkillFocus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubSkillFocus.Name = "lblManSubSkillFocus"
        Me.lblManSubSkillFocus.Size = New System.Drawing.Size(91, 20)
        Me.lblManSubSkillFocus.TabIndex = 12
        Me.lblManSubSkillFocus.Text = "Skill Focus"
        '
        'lblManSubCreatedBy
        '
        Me.lblManSubCreatedBy.AutoSize = True
        Me.lblManSubCreatedBy.Location = New System.Drawing.Point(711, 315)
        Me.lblManSubCreatedBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubCreatedBy.Name = "lblManSubCreatedBy"
        Me.lblManSubCreatedBy.Size = New System.Drawing.Size(93, 20)
        Me.lblManSubCreatedBy.TabIndex = 0
        Me.lblManSubCreatedBy.Text = "Created By"
        '
        'dtpManSubCurriculumYear
        '
        Me.dtpManSubCurriculumYear.Location = New System.Drawing.Point(872, 48)
        Me.dtpManSubCurriculumYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpManSubCurriculumYear.Name = "dtpManSubCurriculumYear"
        Me.dtpManSubCurriculumYear.Size = New System.Drawing.Size(308, 26)
        Me.dtpManSubCurriculumYear.TabIndex = 28
        '
        'nudManSubGradeLevel
        '
        Me.nudManSubGradeLevel.Location = New System.Drawing.Point(112, 165)
        Me.nudManSubGradeLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudManSubGradeLevel.Name = "nudManSubGradeLevel"
        Me.nudManSubGradeLevel.Size = New System.Drawing.Size(47, 26)
        Me.nudManSubGradeLevel.TabIndex = 27
        '
        'lblManSubStatus
        '
        Me.lblManSubStatus.AutoSize = True
        Me.lblManSubStatus.Location = New System.Drawing.Point(628, 84)
        Me.lblManSubStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubStatus.Name = "lblManSubStatus"
        Me.lblManSubStatus.Size = New System.Drawing.Size(57, 20)
        Me.lblManSubStatus.TabIndex = 26
        Me.lblManSubStatus.Text = "Status"
        '
        'nudManSubQuarters
        '
        Me.nudManSubQuarters.Location = New System.Drawing.Point(389, 103)
        Me.nudManSubQuarters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudManSubQuarters.Name = "nudManSubQuarters"
        Me.nudManSubQuarters.Size = New System.Drawing.Size(47, 26)
        Me.nudManSubQuarters.TabIndex = 24
        '
        'cmbStudenttGender
        '
        Me.cmbStudenttGender.FormattingEnabled = True
        Me.cmbStudenttGender.Location = New System.Drawing.Point(389, 46)
        Me.cmbStudenttGender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbStudenttGender.Name = "cmbStudenttGender"
        Me.cmbStudenttGender.Size = New System.Drawing.Size(136, 28)
        Me.cmbStudenttGender.TabIndex = 23
        '
        'txtbxManSubStatus
        '
        Me.txtbxManSubStatus.Location = New System.Drawing.Point(632, 108)
        Me.txtbxManSubStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubStatus.Name = "txtbxManSubStatus"
        Me.txtbxManSubStatus.Size = New System.Drawing.Size(176, 26)
        Me.txtbxManSubStatus.TabIndex = 12
        '
        'lblManSubSubjectName
        '
        Me.lblManSubSubjectName.AutoSize = True
        Me.lblManSubSubjectName.Location = New System.Drawing.Point(895, 140)
        Me.lblManSubSubjectName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubSubjectName.Name = "lblManSubSubjectName"
        Me.lblManSubSubjectName.Size = New System.Drawing.Size(114, 20)
        Me.lblManSubSubjectName.TabIndex = 21
        Me.lblManSubSubjectName.Text = "Subject Name"
        '
        'txtbxManSubSchedule
        '
        Me.txtbxManSubSchedule.Location = New System.Drawing.Point(632, 48)
        Me.txtbxManSubSchedule.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubSchedule.Name = "txtbxManSubSchedule"
        Me.txtbxManSubSchedule.Size = New System.Drawing.Size(176, 26)
        Me.txtbxManSubSchedule.TabIndex = 10
        '
        'lblManSubSchedule
        '
        Me.lblManSubSchedule.AutoSize = True
        Me.lblManSubSchedule.Location = New System.Drawing.Point(628, 28)
        Me.lblManSubSchedule.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubSchedule.Name = "lblManSubSchedule"
        Me.lblManSubSchedule.Size = New System.Drawing.Size(78, 20)
        Me.lblManSubSchedule.TabIndex = 11
        Me.lblManSubSchedule.Text = "Schedule"
        '
        'lblManSubCategory
        '
        Me.lblManSubCategory.AutoSize = True
        Me.lblManSubCategory.Location = New System.Drawing.Point(385, 23)
        Me.lblManSubCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubCategory.Name = "lblManSubCategory"
        Me.lblManSubCategory.Size = New System.Drawing.Size(76, 20)
        Me.lblManSubCategory.TabIndex = 19
        Me.lblManSubCategory.Text = "Category"
        '
        'lblManSubQuarter
        '
        Me.lblManSubQuarter.AutoSize = True
        Me.lblManSubQuarter.Location = New System.Drawing.Point(385, 84)
        Me.lblManSubQuarter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubQuarter.Name = "lblManSubQuarter"
        Me.lblManSubQuarter.Size = New System.Drawing.Size(66, 20)
        Me.lblManSubQuarter.TabIndex = 17
        Me.lblManSubQuarter.Text = "Quarter"
        '
        'lblManSubCurriculumYear
        '
        Me.lblManSubCurriculumYear.AutoSize = True
        Me.lblManSubCurriculumYear.Location = New System.Drawing.Point(895, 23)
        Me.lblManSubCurriculumYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubCurriculumYear.Name = "lblManSubCurriculumYear"
        Me.lblManSubCurriculumYear.Size = New System.Drawing.Size(130, 20)
        Me.lblManSubCurriculumYear.TabIndex = 15
        Me.lblManSubCurriculumYear.Text = "Curriculum Year"
        '
        'lblManSubRoomType
        '
        Me.lblManSubRoomType.AutoSize = True
        Me.lblManSubRoomType.Location = New System.Drawing.Point(895, 80)
        Me.lblManSubRoomType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubRoomType.Name = "lblManSubRoomType"
        Me.lblManSubRoomType.Size = New System.Drawing.Size(94, 20)
        Me.lblManSubRoomType.TabIndex = 13
        Me.lblManSubRoomType.Text = "Room Type"
        '
        'lblManSubGradeLevel
        '
        Me.lblManSubGradeLevel.AutoSize = True
        Me.lblManSubGradeLevel.Location = New System.Drawing.Point(69, 140)
        Me.lblManSubGradeLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubGradeLevel.Name = "lblManSubGradeLevel"
        Me.lblManSubGradeLevel.Size = New System.Drawing.Size(100, 20)
        Me.lblManSubGradeLevel.TabIndex = 9
        Me.lblManSubGradeLevel.Text = "Grade Level"
        '
        'txtbxManSubTeacherID
        '
        Me.txtbxManSubTeacherID.Location = New System.Drawing.Point(389, 165)
        Me.txtbxManSubTeacherID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubTeacherID.Name = "txtbxManSubTeacherID"
        Me.txtbxManSubTeacherID.Size = New System.Drawing.Size(153, 26)
        Me.txtbxManSubTeacherID.TabIndex = 6
        '
        'lblManSubTeacherID
        '
        Me.lblManSubTeacherID.AutoSize = True
        Me.lblManSubTeacherID.Location = New System.Drawing.Point(385, 140)
        Me.lblManSubTeacherID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubTeacherID.Name = "lblManSubTeacherID"
        Me.lblManSubTeacherID.Size = New System.Drawing.Size(92, 20)
        Me.lblManSubTeacherID.TabIndex = 5
        Me.lblManSubTeacherID.Text = "Teacher ID"
        '
        'txtbxManSubSubjectCode
        '
        Me.txtbxManSubSubjectCode.Location = New System.Drawing.Point(73, 103)
        Me.txtbxManSubSubjectCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubSubjectCode.Name = "txtbxManSubSubjectCode"
        Me.txtbxManSubSubjectCode.Size = New System.Drawing.Size(252, 26)
        Me.txtbxManSubSubjectCode.TabIndex = 4
        '
        'lblManSubSubjectCode
        '
        Me.lblManSubSubjectCode.AutoSize = True
        Me.lblManSubSubjectCode.Location = New System.Drawing.Point(69, 79)
        Me.lblManSubSubjectCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubSubjectCode.Name = "lblManSubSubjectCode"
        Me.lblManSubSubjectCode.Size = New System.Drawing.Size(109, 20)
        Me.lblManSubSubjectCode.TabIndex = 3
        Me.lblManSubSubjectCode.Text = "Subject Code"
        '
        'txtbxManSubSubjectID
        '
        Me.txtbxManSubSubjectID.Location = New System.Drawing.Point(73, 46)
        Me.txtbxManSubSubjectID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubSubjectID.Name = "txtbxManSubSubjectID"
        Me.txtbxManSubSubjectID.Size = New System.Drawing.Size(252, 26)
        Me.txtbxManSubSubjectID.TabIndex = 2
        '
        'lblManSubSubjectD
        '
        Me.lblManSubSubjectD.AutoSize = True
        Me.lblManSubSubjectD.Location = New System.Drawing.Point(69, 23)
        Me.lblManSubSubjectD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubSubjectD.Name = "lblManSubSubjectD"
        Me.lblManSubSubjectD.Size = New System.Drawing.Size(87, 20)
        Me.lblManSubSubjectD.TabIndex = 1
        Me.lblManSubSubjectD.Text = "Subject ID"
        '
        'lblSubjectList
        '
        Me.lblSubjectList.AutoSize = True
        Me.lblSubjectList.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubjectList.ForeColor = System.Drawing.Color.White
        Me.lblSubjectList.Location = New System.Drawing.Point(37, 36)
        Me.lblSubjectList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubjectList.Name = "lblSubjectList"
        Me.lblSubjectList.Size = New System.Drawing.Size(138, 32)
        Me.lblSubjectList.TabIndex = 2
        Me.lblSubjectList.Text = "Subject List"
        '
        'picWatermark
        '
        Me.picWatermark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(379, 210)
        Me.picWatermark.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(557, 458)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 5
        Me.picWatermark.TabStop = False
        '
        'btnSubjectSearch
        '
        Me.btnSubjectSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubjectSearch.Location = New System.Drawing.Point(759, 720)
        Me.btnSubjectSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubjectSearch.Name = "btnSubjectSearch"
        Me.btnSubjectSearch.Size = New System.Drawing.Size(120, 43)
        Me.btnSubjectSearch.TabIndex = 1
        Me.btnSubjectSearch.Text = "Search"
        Me.btnSubjectSearch.UseVisualStyleBackColor = True
        '
        'SubSubjectID
        '
        Me.SubSubjectID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubSubjectID.HeaderText = "Subject ID"
        Me.SubSubjectID.MinimumWidth = 6
        Me.SubSubjectID.Name = "SubSubjectID"
        Me.SubSubjectID.ReadOnly = True
        Me.SubSubjectID.Width = 97
        '
        'SubSubjectCode
        '
        Me.SubSubjectCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubSubjectCode.HeaderText = "Subject Code"
        Me.SubSubjectCode.MinimumWidth = 6
        Me.SubSubjectCode.Name = "SubSubjectCode"
        Me.SubSubjectCode.ReadOnly = True
        Me.SubSubjectCode.Width = 117
        '
        'SubSubjectName
        '
        Me.SubSubjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubSubjectName.HeaderText = "Subject Name"
        Me.SubSubjectName.MinimumWidth = 6
        Me.SubSubjectName.Name = "SubSubjectName"
        Me.SubSubjectName.ReadOnly = True
        Me.SubSubjectName.Width = 121
        '
        'SubDescription
        '
        Me.SubDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubDescription.HeaderText = "Description"
        Me.SubDescription.MinimumWidth = 6
        Me.SubDescription.Name = "SubDescription"
        Me.SubDescription.ReadOnly = True
        Me.SubDescription.Width = 104
        '
        'SubSkillFocus
        '
        Me.SubSkillFocus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubSkillFocus.HeaderText = "Skill Focus"
        Me.SubSkillFocus.MinimumWidth = 6
        Me.SubSkillFocus.Name = "SubSkillFocus"
        Me.SubSkillFocus.ReadOnly = True
        Me.SubSkillFocus.Width = 101
        '
        'SubGradeLevel
        '
        Me.SubGradeLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubGradeLevel.HeaderText = "Grade Level"
        Me.SubGradeLevel.MinimumWidth = 6
        Me.SubGradeLevel.Name = "SubGradeLevel"
        Me.SubGradeLevel.ReadOnly = True
        Me.SubGradeLevel.Width = 110
        '
        'SubRoomType
        '
        Me.SubRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubRoomType.HeaderText = "Room Type"
        Me.SubRoomType.MinimumWidth = 6
        Me.SubRoomType.Name = "SubRoomType"
        Me.SubRoomType.ReadOnly = True
        Me.SubRoomType.Width = 108
        '
        'SubCategory
        '
        Me.SubCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubCategory.HeaderText = "Category"
        Me.SubCategory.MinimumWidth = 6
        Me.SubCategory.Name = "SubCategory"
        Me.SubCategory.ReadOnly = True
        Me.SubCategory.Width = 91
        '
        'SubLearningMaterials
        '
        Me.SubLearningMaterials.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubLearningMaterials.HeaderText = "Learning Materials"
        Me.SubLearningMaterials.MinimumWidth = 6
        Me.SubLearningMaterials.Name = "SubLearningMaterials"
        Me.SubLearningMaterials.ReadOnly = True
        Me.SubLearningMaterials.Width = 134
        '
        'SubTeacherID
        '
        Me.SubTeacherID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubTeacherID.HeaderText = "Teacher ID"
        Me.SubTeacherID.MinimumWidth = 6
        Me.SubTeacherID.Name = "SubTeacherID"
        Me.SubTeacherID.ReadOnly = True
        Me.SubTeacherID.Width = 95
        '
        'SubSchedule
        '
        Me.SubSchedule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubSchedule.HeaderText = "Schedule"
        Me.SubSchedule.MinimumWidth = 6
        Me.SubSchedule.Name = "SubSchedule"
        Me.SubSchedule.ReadOnly = True
        Me.SubSchedule.Width = 93
        '
        'SubQuarter
        '
        Me.SubQuarter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubQuarter.HeaderText = "Quarter"
        Me.SubQuarter.MinimumWidth = 6
        Me.SubQuarter.Name = "SubQuarter"
        Me.SubQuarter.ReadOnly = True
        Me.SubQuarter.Width = 80
        '
        'SubStatus
        '
        Me.SubStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubStatus.HeaderText = "Status"
        Me.SubStatus.MinimumWidth = 6
        Me.SubStatus.Name = "SubStatus"
        Me.SubStatus.ReadOnly = True
        Me.SubStatus.Width = 73
        '
        'SubCreatedBy
        '
        Me.SubCreatedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubCreatedBy.HeaderText = "Created By"
        Me.SubCreatedBy.MinimumWidth = 6
        Me.SubCreatedBy.Name = "SubCreatedBy"
        Me.SubCreatedBy.ReadOnly = True
        Me.SubCreatedBy.Width = 95
        '
        'SubDateCreated
        '
        Me.SubDateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubDateCreated.HeaderText = "Date Created"
        Me.SubDateCreated.MinimumWidth = 6
        Me.SubDateCreated.Name = "SubDateCreated"
        Me.SubDateCreated.ReadOnly = True
        Me.SubDateCreated.Width = 107
        '
        'AdminManageSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 779)
        Me.Controls.Add(Me.pnlManSubContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminManageSubjects"
        Me.Text = "AdminManageSubjects"
        Me.pnlSidebar.ResumeLayout(False)
        Me.flowButtons.ResumeLayout(False)
        Me.pnlManSubContent.ResumeLayout(False)
        Me.pnlManSubContent.PerformLayout()
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSubjectInformation.ResumeLayout(False)
        Me.grpSubjectInformation.PerformLayout()
        CType(Me.nudManSubGradeLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudManSubQuarters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents flowButtons As FlowLayoutPanel
    Friend WithEvents btnManageStudents As Button
    Friend WithEvents btnManageTeachers As Button
    Friend WithEvents btnManageSections As Button
    Friend WithEvents btnManageEnrollments As Button
    Friend WithEvents btnManageSubjects As Button
    Friend WithEvents btnGenerateReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlManSubContent As Panel
    Friend WithEvents btnSubjectDelete As Button
    Friend WithEvents btnSubjectUpdate As Button
    Friend WithEvents btnSubjectAdd As Button
    Friend WithEvents dgvSections As DataGridView
    Friend WithEvents grpSubjectInformation As GroupBox
    Friend WithEvents txtbxManSubSkillFocus As TextBox
    Friend WithEvents lblManSubSkillFocus As Label
    Friend WithEvents dtpManSubCurriculumYear As DateTimePicker
    Friend WithEvents nudManSubGradeLevel As NumericUpDown
    Friend WithEvents lblManSubStatus As Label
    Friend WithEvents nudManSubQuarters As NumericUpDown
    Friend WithEvents cmbStudenttGender As ComboBox
    Friend WithEvents txtbxManSubStatus As TextBox
    Friend WithEvents lblManSubSubjectName As Label
    Friend WithEvents txtbxManSubSchedule As TextBox
    Friend WithEvents lblManSubSchedule As Label
    Friend WithEvents lblManSubCategory As Label
    Friend WithEvents lblManSubQuarter As Label
    Friend WithEvents lblManSubCurriculumYear As Label
    Friend WithEvents lblManSubRoomType As Label
    Friend WithEvents lblManSubGradeLevel As Label
    Friend WithEvents txtbxManSubTeacherID As TextBox
    Friend WithEvents lblManSubTeacherID As Label
    Friend WithEvents txtbxManSubSubjectCode As TextBox
    Friend WithEvents lblManSubSubjectCode As Label
    Friend WithEvents txtbxManSubSubjectID As TextBox
    Friend WithEvents lblManSubSubjectD As Label
    Friend WithEvents lblSubjectList As Label
    Friend WithEvents btnSubjectSearch As Button
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents txtbxManSubSubjectName As TextBox
    Friend WithEvents txtbxManSubType As TextBox
    Friend WithEvents txtbxManSubDescription As TextBox
    Friend WithEvents lblManSubDescription As Label
    Friend WithEvents txtbxManSubLearningMaterials As TextBox
    Friend WithEvents lblManSubLearningMaterials As Label
    Friend WithEvents dtpManSubDateCreated As DateTimePicker
    Friend WithEvents lblManSecDateCreated As Label
    Friend WithEvents txtbxManSubCreatedBy As TextBox
    Friend WithEvents lblManSubCreatedBy As Label
    Friend WithEvents SubSubjectID As DataGridViewTextBoxColumn
    Friend WithEvents SubSubjectCode As DataGridViewTextBoxColumn
    Friend WithEvents SubSubjectName As DataGridViewTextBoxColumn
    Friend WithEvents SubDescription As DataGridViewTextBoxColumn
    Friend WithEvents SubSkillFocus As DataGridViewTextBoxColumn
    Friend WithEvents SubGradeLevel As DataGridViewTextBoxColumn
    Friend WithEvents SubRoomType As DataGridViewTextBoxColumn
    Friend WithEvents SubCategory As DataGridViewTextBoxColumn
    Friend WithEvents SubLearningMaterials As DataGridViewTextBoxColumn
    Friend WithEvents SubTeacherID As DataGridViewTextBoxColumn
    Friend WithEvents SubSchedule As DataGridViewTextBoxColumn
    Friend WithEvents SubQuarter As DataGridViewTextBoxColumn
    Friend WithEvents SubStatus As DataGridViewTextBoxColumn
    Friend WithEvents SubCreatedBy As DataGridViewTextBoxColumn
    Friend WithEvents SubDateCreated As DataGridViewTextBoxColumn
End Class
