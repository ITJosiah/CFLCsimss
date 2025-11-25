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
        Me.TextBoxSubjectSearch = New System.Windows.Forms.TextBox()
        Me.btnSubjectDelete = New System.Windows.Forms.Button()
        Me.btnSubjectUpdate = New System.Windows.Forms.Button()
        Me.btnSubjectAdd = New System.Windows.Forms.Button()
        Me.dgvSubjectList = New System.Windows.Forms.DataGridView()
        Me.grpSubjectInformation = New System.Windows.Forms.GroupBox()
        Me.txtbxManSubCurriculumYear = New System.Windows.Forms.TextBox()
        Me.cbxManSubRoomType = New System.Windows.Forms.ComboBox()
        Me.txtbxManSubSubjectName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxManSubDescription = New System.Windows.Forms.TextBox()
        Me.lblManSubDescription = New System.Windows.Forms.Label()
        Me.txtbxManSubLearningMaterials = New System.Windows.Forms.TextBox()
        Me.lblManSubLearningMaterials = New System.Windows.Forms.Label()
        Me.dtpManSubDateCreated = New System.Windows.Forms.DateTimePicker()
        Me.lblManSecDateCreated = New System.Windows.Forms.Label()
        Me.txtbxManSubSkillFocus = New System.Windows.Forms.TextBox()
        Me.txtbxManSubCreatedBy = New System.Windows.Forms.TextBox()
        Me.lblManSubSkillFocus = New System.Windows.Forms.Label()
        Me.lblManSubCreatedBy = New System.Windows.Forms.Label()
        Me.nudManSubGradeLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblManSubStatus = New System.Windows.Forms.Label()
        Me.nudManSubQuarter = New System.Windows.Forms.NumericUpDown()
        Me.cmbSubjectCategory = New System.Windows.Forms.ComboBox()
        Me.txtbxManSubSchedule = New System.Windows.Forms.TextBox()
        Me.lblManSubSchedule = New System.Windows.Forms.Label()
        Me.lblManSubCategory = New System.Windows.Forms.Label()
        Me.lblManSubQuarter = New System.Windows.Forms.Label()
        Me.lblManSubCurriculumYear = New System.Windows.Forms.Label()
        Me.lblManSubRoomType = New System.Windows.Forms.Label()
        Me.lblManSubGradeLevel = New System.Windows.Forms.Label()
        Me.txtbxManSubSubjectCode = New System.Windows.Forms.TextBox()
        Me.lblManSubSubjectCode = New System.Windows.Forms.Label()
        Me.lblSubjectList = New System.Windows.Forms.Label()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.ComboBoxSubjectStatus = New System.Windows.Forms.ComboBox()
        Me.pnlSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
        Me.pnlManSubContent.SuspendLayout()
        CType(Me.dgvSubjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSubjectInformation.SuspendLayout()
        CType(Me.nudManSubGradeLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudManSubQuarter, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlManSubContent.Controls.Add(Me.TextBoxSubjectSearch)
        Me.pnlManSubContent.Controls.Add(Me.btnSubjectDelete)
        Me.pnlManSubContent.Controls.Add(Me.btnSubjectUpdate)
        Me.pnlManSubContent.Controls.Add(Me.btnSubjectAdd)
        Me.pnlManSubContent.Controls.Add(Me.dgvSubjectList)
        Me.pnlManSubContent.Controls.Add(Me.grpSubjectInformation)
        Me.pnlManSubContent.Controls.Add(Me.lblSubjectList)
        Me.pnlManSubContent.Controls.Add(Me.picWatermark)
        Me.pnlManSubContent.Location = New System.Drawing.Point(400, 0)
        Me.pnlManSubContent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlManSubContent.Name = "pnlManSubContent"
        Me.pnlManSubContent.Padding = New System.Windows.Forms.Padding(40, 37, 40, 37)
        Me.pnlManSubContent.Size = New System.Drawing.Size(1333, 779)
        Me.pnlManSubContent.TabIndex = 14
        '
        'TextBoxSubjectSearch
        '
        Me.TextBoxSubjectSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSubjectSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSubjectSearch.Location = New System.Drawing.Point(629, 729)
        Me.TextBoxSubjectSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxSubjectSearch.MaxLength = 50
        Me.TextBoxSubjectSearch.Name = "TextBoxSubjectSearch"
        Me.TextBoxSubjectSearch.Size = New System.Drawing.Size(247, 36)
        Me.TextBoxSubjectSearch.TabIndex = 11
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
        'dgvSubjectList
        '
        Me.dgvSubjectList.AllowUserToAddRows = False
        Me.dgvSubjectList.AllowUserToDeleteRows = False
        Me.dgvSubjectList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSubjectList.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSubjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubjectList.Location = New System.Drawing.Point(44, 478)
        Me.dgvSubjectList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvSubjectList.Name = "dgvSubjectList"
        Me.dgvSubjectList.ReadOnly = True
        Me.dgvSubjectList.RowHeadersVisible = False
        Me.dgvSubjectList.RowHeadersWidth = 51
        Me.dgvSubjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubjectList.Size = New System.Drawing.Size(1245, 222)
        Me.dgvSubjectList.TabIndex = 6
        '
        'grpSubjectInformation
        '
        Me.grpSubjectInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSubjectInformation.BackColor = System.Drawing.Color.Gainsboro
        Me.grpSubjectInformation.Controls.Add(Me.ComboBoxSubjectStatus)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubCurriculumYear)
        Me.grpSubjectInformation.Controls.Add(Me.cbxManSubRoomType)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubSubjectName)
        Me.grpSubjectInformation.Controls.Add(Me.Label1)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubDescription)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubDescription)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubLearningMaterials)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubLearningMaterials)
        Me.grpSubjectInformation.Controls.Add(Me.dtpManSubDateCreated)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSecDateCreated)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubSkillFocus)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubCreatedBy)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubSkillFocus)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubCreatedBy)
        Me.grpSubjectInformation.Controls.Add(Me.nudManSubGradeLevel)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubStatus)
        Me.grpSubjectInformation.Controls.Add(Me.nudManSubQuarter)
        Me.grpSubjectInformation.Controls.Add(Me.cmbSubjectCategory)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubSchedule)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubSchedule)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubCategory)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubQuarter)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubCurriculumYear)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubRoomType)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubGradeLevel)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubSubjectCode)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubSubjectCode)
        Me.grpSubjectInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSubjectInformation.Location = New System.Drawing.Point(44, 97)
        Me.grpSubjectInformation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSubjectInformation.Name = "grpSubjectInformation"
        Me.grpSubjectInformation.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSubjectInformation.Size = New System.Drawing.Size(1245, 354)
        Me.grpSubjectInformation.TabIndex = 3
        Me.grpSubjectInformation.TabStop = False
        Me.grpSubjectInformation.Text = "Subject Information"
        '
        'txtbxManSubCurriculumYear
        '
        Me.txtbxManSubCurriculumYear.Location = New System.Drawing.Point(655, 164)
        Me.txtbxManSubCurriculumYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubCurriculumYear.Name = "txtbxManSubCurriculumYear"
        Me.txtbxManSubCurriculumYear.Size = New System.Drawing.Size(180, 26)
        Me.txtbxManSubCurriculumYear.TabIndex = 39
        '
        'cbxManSubRoomType
        '
        Me.cbxManSubRoomType.FormattingEnabled = True
        Me.cbxManSubRoomType.Location = New System.Drawing.Point(372, 162)
        Me.cbxManSubRoomType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxManSubRoomType.Name = "cbxManSubRoomType"
        Me.cbxManSubRoomType.Size = New System.Drawing.Size(239, 28)
        Me.cbxManSubRoomType.TabIndex = 37
        '
        'txtbxManSubSubjectName
        '
        Me.txtbxManSubSubjectName.Location = New System.Drawing.Point(73, 106)
        Me.txtbxManSubSubjectName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubSubjectName.Name = "txtbxManSubSubjectName"
        Me.txtbxManSubSubjectName.Size = New System.Drawing.Size(252, 26)
        Me.txtbxManSubSubjectName.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Subject Name"
        '
        'txtbxManSubDescription
        '
        Me.txtbxManSubDescription.Location = New System.Drawing.Point(73, 230)
        Me.txtbxManSubDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubDescription.Multiline = True
        Me.txtbxManSubDescription.Name = "txtbxManSubDescription"
        Me.txtbxManSubDescription.Size = New System.Drawing.Size(255, 93)
        Me.txtbxManSubDescription.TabIndex = 34
        '
        'lblManSubDescription
        '
        Me.lblManSubDescription.AutoSize = True
        Me.lblManSubDescription.Location = New System.Drawing.Point(69, 203)
        Me.lblManSubDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubDescription.Name = "lblManSubDescription"
        Me.lblManSubDescription.Size = New System.Drawing.Size(95, 20)
        Me.lblManSubDescription.TabIndex = 33
        Me.lblManSubDescription.Text = "Description"
        '
        'txtbxManSubLearningMaterials
        '
        Me.txtbxManSubLearningMaterials.Location = New System.Drawing.Point(372, 230)
        Me.txtbxManSubLearningMaterials.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubLearningMaterials.Multiline = True
        Me.txtbxManSubLearningMaterials.Name = "txtbxManSubLearningMaterials"
        Me.txtbxManSubLearningMaterials.Size = New System.Drawing.Size(239, 93)
        Me.txtbxManSubLearningMaterials.TabIndex = 32
        '
        'lblManSubLearningMaterials
        '
        Me.lblManSubLearningMaterials.AutoSize = True
        Me.lblManSubLearningMaterials.Location = New System.Drawing.Point(368, 203)
        Me.lblManSubLearningMaterials.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubLearningMaterials.Name = "lblManSubLearningMaterials"
        Me.lblManSubLearningMaterials.Size = New System.Drawing.Size(148, 20)
        Me.lblManSubLearningMaterials.TabIndex = 31
        Me.lblManSubLearningMaterials.Text = "Learning Materials"
        '
        'dtpManSubDateCreated
        '
        Me.dtpManSubDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpManSubDateCreated.Location = New System.Drawing.Point(655, 230)
        Me.dtpManSubDateCreated.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpManSubDateCreated.Name = "dtpManSubDateCreated"
        Me.dtpManSubDateCreated.Size = New System.Drawing.Size(136, 26)
        Me.dtpManSubDateCreated.TabIndex = 7
        '
        'lblManSecDateCreated
        '
        Me.lblManSecDateCreated.AutoSize = True
        Me.lblManSecDateCreated.Location = New System.Drawing.Point(651, 206)
        Me.lblManSecDateCreated.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecDateCreated.Name = "lblManSecDateCreated"
        Me.lblManSecDateCreated.Size = New System.Drawing.Size(109, 20)
        Me.lblManSecDateCreated.TabIndex = 4
        Me.lblManSecDateCreated.Text = "Date Created"
        '
        'txtbxManSubSkillFocus
        '
        Me.txtbxManSubSkillFocus.Location = New System.Drawing.Point(372, 46)
        Me.txtbxManSubSkillFocus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubSkillFocus.Name = "txtbxManSubSkillFocus"
        Me.txtbxManSubSkillFocus.Size = New System.Drawing.Size(239, 26)
        Me.txtbxManSubSkillFocus.TabIndex = 13
        '
        'txtbxManSubCreatedBy
        '
        Me.txtbxManSubCreatedBy.Location = New System.Drawing.Point(655, 295)
        Me.txtbxManSubCreatedBy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubCreatedBy.Name = "txtbxManSubCreatedBy"
        Me.txtbxManSubCreatedBy.Size = New System.Drawing.Size(213, 26)
        Me.txtbxManSubCreatedBy.TabIndex = 1
        '
        'lblManSubSkillFocus
        '
        Me.lblManSubSkillFocus.AutoSize = True
        Me.lblManSubSkillFocus.Location = New System.Drawing.Point(368, 21)
        Me.lblManSubSkillFocus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubSkillFocus.Name = "lblManSubSkillFocus"
        Me.lblManSubSkillFocus.Size = New System.Drawing.Size(91, 20)
        Me.lblManSubSkillFocus.TabIndex = 12
        Me.lblManSubSkillFocus.Text = "Skill Focus"
        '
        'lblManSubCreatedBy
        '
        Me.lblManSubCreatedBy.AutoSize = True
        Me.lblManSubCreatedBy.Location = New System.Drawing.Point(651, 270)
        Me.lblManSubCreatedBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubCreatedBy.Name = "lblManSubCreatedBy"
        Me.lblManSubCreatedBy.Size = New System.Drawing.Size(93, 20)
        Me.lblManSubCreatedBy.TabIndex = 0
        Me.lblManSubCreatedBy.Text = "Created By"
        '
        'nudManSubGradeLevel
        '
        Me.nudManSubGradeLevel.Location = New System.Drawing.Point(400, 103)
        Me.nudManSubGradeLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudManSubGradeLevel.Name = "nudManSubGradeLevel"
        Me.nudManSubGradeLevel.Size = New System.Drawing.Size(47, 26)
        Me.nudManSubGradeLevel.TabIndex = 27
        '
        'lblManSubStatus
        '
        Me.lblManSubStatus.AutoSize = True
        Me.lblManSubStatus.Location = New System.Drawing.Point(655, 79)
        Me.lblManSubStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubStatus.Name = "lblManSubStatus"
        Me.lblManSubStatus.Size = New System.Drawing.Size(57, 20)
        Me.lblManSubStatus.TabIndex = 26
        Me.lblManSubStatus.Text = "Status"
        '
        'nudManSubQuarter
        '
        Me.nudManSubQuarter.Location = New System.Drawing.Point(511, 103)
        Me.nudManSubQuarter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudManSubQuarter.Name = "nudManSubQuarter"
        Me.nudManSubQuarter.Size = New System.Drawing.Size(47, 26)
        Me.nudManSubQuarter.TabIndex = 24
        '
        'cmbSubjectCategory
        '
        Me.cmbSubjectCategory.FormattingEnabled = True
        Me.cmbSubjectCategory.Location = New System.Drawing.Point(73, 162)
        Me.cmbSubjectCategory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbSubjectCategory.Name = "cmbSubjectCategory"
        Me.cmbSubjectCategory.Size = New System.Drawing.Size(255, 28)
        Me.cmbSubjectCategory.TabIndex = 23
        '
        'txtbxManSubSchedule
        '
        Me.txtbxManSubSchedule.Location = New System.Drawing.Point(655, 46)
        Me.txtbxManSubSchedule.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubSchedule.Name = "txtbxManSubSchedule"
        Me.txtbxManSubSchedule.Size = New System.Drawing.Size(176, 26)
        Me.txtbxManSubSchedule.TabIndex = 10
        '
        'lblManSubSchedule
        '
        Me.lblManSubSchedule.AutoSize = True
        Me.lblManSubSchedule.Location = New System.Drawing.Point(651, 26)
        Me.lblManSubSchedule.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubSchedule.Name = "lblManSubSchedule"
        Me.lblManSubSchedule.Size = New System.Drawing.Size(78, 20)
        Me.lblManSubSchedule.TabIndex = 11
        Me.lblManSubSchedule.Text = "Schedule"
        '
        'lblManSubCategory
        '
        Me.lblManSubCategory.AutoSize = True
        Me.lblManSubCategory.Location = New System.Drawing.Point(69, 140)
        Me.lblManSubCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubCategory.Name = "lblManSubCategory"
        Me.lblManSubCategory.Size = New System.Drawing.Size(76, 20)
        Me.lblManSubCategory.TabIndex = 19
        Me.lblManSubCategory.Text = "Category"
        '
        'lblManSubQuarter
        '
        Me.lblManSubQuarter.AutoSize = True
        Me.lblManSubQuarter.Location = New System.Drawing.Point(503, 82)
        Me.lblManSubQuarter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubQuarter.Name = "lblManSubQuarter"
        Me.lblManSubQuarter.Size = New System.Drawing.Size(66, 20)
        Me.lblManSubQuarter.TabIndex = 17
        Me.lblManSubQuarter.Text = "Quarter"
        '
        'lblManSubCurriculumYear
        '
        Me.lblManSubCurriculumYear.AutoSize = True
        Me.lblManSubCurriculumYear.Location = New System.Drawing.Point(651, 140)
        Me.lblManSubCurriculumYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubCurriculumYear.Name = "lblManSubCurriculumYear"
        Me.lblManSubCurriculumYear.Size = New System.Drawing.Size(130, 20)
        Me.lblManSubCurriculumYear.TabIndex = 15
        Me.lblManSubCurriculumYear.Text = "Curriculum Year"
        '
        'lblManSubRoomType
        '
        Me.lblManSubRoomType.AutoSize = True
        Me.lblManSubRoomType.Location = New System.Drawing.Point(368, 142)
        Me.lblManSubRoomType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubRoomType.Name = "lblManSubRoomType"
        Me.lblManSubRoomType.Size = New System.Drawing.Size(94, 20)
        Me.lblManSubRoomType.TabIndex = 13
        Me.lblManSubRoomType.Text = "Room Type"
        '
        'lblManSubGradeLevel
        '
        Me.lblManSubGradeLevel.AutoSize = True
        Me.lblManSubGradeLevel.Location = New System.Drawing.Point(367, 82)
        Me.lblManSubGradeLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubGradeLevel.Name = "lblManSubGradeLevel"
        Me.lblManSubGradeLevel.Size = New System.Drawing.Size(100, 20)
        Me.lblManSubGradeLevel.TabIndex = 9
        Me.lblManSubGradeLevel.Text = "Grade Level"
        '
        'txtbxManSubSubjectCode
        '
        Me.txtbxManSubSubjectCode.Location = New System.Drawing.Point(73, 46)
        Me.txtbxManSubSubjectCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxManSubSubjectCode.Name = "txtbxManSubSubjectCode"
        Me.txtbxManSubSubjectCode.Size = New System.Drawing.Size(252, 26)
        Me.txtbxManSubSubjectCode.TabIndex = 4
        '
        'lblManSubSubjectCode
        '
        Me.lblManSubSubjectCode.AutoSize = True
        Me.lblManSubSubjectCode.Location = New System.Drawing.Point(69, 22)
        Me.lblManSubSubjectCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSubSubjectCode.Name = "lblManSubSubjectCode"
        Me.lblManSubSubjectCode.Size = New System.Drawing.Size(109, 20)
        Me.lblManSubSubjectCode.TabIndex = 3
        Me.lblManSubSubjectCode.Text = "Subject Code"
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
        'ComboBoxSubjectStatus
        '
        Me.ComboBoxSubjectStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSubjectStatus.FormattingEnabled = True
        Me.ComboBoxSubjectStatus.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxSubjectStatus.Location = New System.Drawing.Point(655, 101)
        Me.ComboBoxSubjectStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxSubjectStatus.Name = "ComboBoxSubjectStatus"
        Me.ComboBoxSubjectStatus.Size = New System.Drawing.Size(111, 28)
        Me.ComboBoxSubjectStatus.TabIndex = 44
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
        CType(Me.dgvSubjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSubjectInformation.ResumeLayout(False)
        Me.grpSubjectInformation.PerformLayout()
        CType(Me.nudManSubGradeLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudManSubQuarter, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvSubjectList As DataGridView
    Friend WithEvents grpSubjectInformation As GroupBox
    Friend WithEvents txtbxManSubSkillFocus As TextBox
    Friend WithEvents lblManSubSkillFocus As Label
    Friend WithEvents nudManSubGradeLevel As NumericUpDown
    Friend WithEvents lblManSubStatus As Label
    Friend WithEvents nudManSubQuarter As NumericUpDown
    Friend WithEvents cmbSubjectCategory As ComboBox
    Friend WithEvents txtbxManSubSchedule As TextBox
    Friend WithEvents lblManSubSchedule As Label
    Friend WithEvents lblManSubCategory As Label
    Friend WithEvents lblManSubQuarter As Label
    Friend WithEvents lblManSubCurriculumYear As Label
    Friend WithEvents lblManSubRoomType As Label
    Friend WithEvents lblManSubGradeLevel As Label
    Friend WithEvents txtbxManSubSubjectCode As TextBox
    Friend WithEvents lblManSubSubjectCode As Label
    Friend WithEvents lblSubjectList As Label
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents txtbxManSubDescription As TextBox
    Friend WithEvents lblManSubDescription As Label
    Friend WithEvents txtbxManSubLearningMaterials As TextBox
    Friend WithEvents lblManSubLearningMaterials As Label
    Friend WithEvents dtpManSubDateCreated As DateTimePicker
    Friend WithEvents lblManSecDateCreated As Label
    Friend WithEvents txtbxManSubCreatedBy As TextBox
    Friend WithEvents lblManSubCreatedBy As Label
    Friend WithEvents TextBoxSubjectSearch As TextBox
    Friend WithEvents txtbxManSubSubjectName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxManSubRoomType As ComboBox
    Friend WithEvents txtbxManSubCurriculumYear As TextBox
    Friend WithEvents ComboBoxSubjectStatus As ComboBox
End Class
