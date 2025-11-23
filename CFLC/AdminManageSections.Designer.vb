<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminManageSections
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
        Me.pnlManSecContent = New System.Windows.Forms.Panel()
        Me.btnSectionDelete = New System.Windows.Forms.Button()
        Me.btnSectionUpdate = New System.Windows.Forms.Button()
        Me.btnSectionAdd = New System.Windows.Forms.Button()
        Me.dgvSections = New System.Windows.Forms.DataGridView()
        Me.SecSectionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecSubjectCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecSubjectName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecSkillFocus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecGradeLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecRoomType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecLearningMaterials = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecTeacherID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecSchedule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecQuarter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecCreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecDateCreated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpSectionInfo = New System.Windows.Forms.GroupBox()
        Me.txtbxManSecRemarks = New System.Windows.Forms.TextBox()
        Me.lblManSecRemarks = New System.Windows.Forms.Label()
        Me.cmbManSecLearningMode = New System.Windows.Forms.ComboBox()
        Me.cmbManSecClassType = New System.Windows.Forms.ComboBox()
        Me.lblManSecLearningMode = New System.Windows.Forms.Label()
        Me.lblManSecClassType = New System.Windows.Forms.Label()
        Me.dtpManSecDateCreated = New System.Windows.Forms.DateTimePicker()
        Me.txtbxManSecRoomNo = New System.Windows.Forms.TextBox()
        Me.dtpManSecEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblManSecDateCreated = New System.Windows.Forms.Label()
        Me.lblManSecRoomNo = New System.Windows.Forms.Label()
        Me.txtbxManSecCreatedBy = New System.Windows.Forms.TextBox()
        Me.lblManSecCreatedBy = New System.Windows.Forms.Label()
        Me.dtpManSecStartDate = New System.Windows.Forms.DateTimePicker()
        Me.nudManSecGradeLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblManSecStatus = New System.Windows.Forms.Label()
        Me.nudManSecNoOfStudents = New System.Windows.Forms.NumericUpDown()
        Me.cmbStudenttGender = New System.Windows.Forms.ComboBox()
        Me.txtbxManSecStatus = New System.Windows.Forms.TextBox()
        Me.dtpManSecSchoolYear = New System.Windows.Forms.DateTimePicker()
        Me.lblManSecSchoolYear = New System.Windows.Forms.Label()
        Me.txtbxSchedule = New System.Windows.Forms.TextBox()
        Me.lblManSecSchedule = New System.Windows.Forms.Label()
        Me.lblManSecCapacity = New System.Windows.Forms.Label()
        Me.lblManSecNoOfStudents = New System.Windows.Forms.Label()
        Me.lblManSecStartDate = New System.Windows.Forms.Label()
        Me.lblManSecEndDate = New System.Windows.Forms.Label()
        Me.lblManSecGradeLevel = New System.Windows.Forms.Label()
        Me.txtbxManSecTeacherID = New System.Windows.Forms.TextBox()
        Me.lblManSecTeacherID = New System.Windows.Forms.Label()
        Me.txtbxManSecSectionName = New System.Windows.Forms.TextBox()
        Me.lblManSecSectionName = New System.Windows.Forms.Label()
        Me.txtbxManSecSectionID = New System.Windows.Forms.TextBox()
        Me.lblManSecSectionID = New System.Windows.Forms.Label()
        Me.lblSectionsList = New System.Windows.Forms.Label()
        Me.btnSectionSearch = New System.Windows.Forms.Button()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.TextBoxStudentSearch = New System.Windows.Forms.TextBox()
        Me.pnlSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
        Me.pnlManSecContent.SuspendLayout()
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSectionInfo.SuspendLayout()
        CType(Me.nudManSecGradeLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudManSecNoOfStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.flowButtons)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(40, 49, 40, 49)
        Me.pnlSidebar.Size = New System.Drawing.Size(400, 775)
        Me.pnlSidebar.TabIndex = 12
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
        Me.flowButtons.Size = New System.Drawing.Size(320, 615)
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
        Me.btnLogout.Location = New System.Drawing.Point(40, 664)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(320, 62)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlManSecContent
        '
        Me.pnlManSecContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlManSecContent.Controls.Add(Me.TextBoxStudentSearch)
        Me.pnlManSecContent.Controls.Add(Me.btnSectionDelete)
        Me.pnlManSecContent.Controls.Add(Me.btnSectionUpdate)
        Me.pnlManSecContent.Controls.Add(Me.btnSectionAdd)
        Me.pnlManSecContent.Controls.Add(Me.dgvSections)
        Me.pnlManSecContent.Controls.Add(Me.grpSectionInfo)
        Me.pnlManSecContent.Controls.Add(Me.lblSectionsList)
        Me.pnlManSecContent.Controls.Add(Me.btnSectionSearch)
        Me.pnlManSecContent.Controls.Add(Me.picWatermark)
        Me.pnlManSecContent.Location = New System.Drawing.Point(400, 1)
        Me.pnlManSecContent.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlManSecContent.Name = "pnlManSecContent"
        Me.pnlManSecContent.Padding = New System.Windows.Forms.Padding(40, 37, 40, 37)
        Me.pnlManSecContent.Size = New System.Drawing.Size(1333, 779)
        Me.pnlManSecContent.TabIndex = 13
        '
        'btnSectionDelete
        '
        Me.btnSectionDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSectionDelete.Location = New System.Drawing.Point(1211, 720)
        Me.btnSectionDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSectionDelete.Name = "btnSectionDelete"
        Me.btnSectionDelete.Size = New System.Drawing.Size(115, 43)
        Me.btnSectionDelete.TabIndex = 9
        Me.btnSectionDelete.Text = "Delete"
        Me.btnSectionDelete.UseVisualStyleBackColor = True
        '
        'btnSectionUpdate
        '
        Me.btnSectionUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSectionUpdate.Location = New System.Drawing.Point(1061, 720)
        Me.btnSectionUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSectionUpdate.Name = "btnSectionUpdate"
        Me.btnSectionUpdate.Size = New System.Drawing.Size(115, 43)
        Me.btnSectionUpdate.TabIndex = 8
        Me.btnSectionUpdate.Text = "Update"
        Me.btnSectionUpdate.UseVisualStyleBackColor = True
        '
        'btnSectionAdd
        '
        Me.btnSectionAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSectionAdd.Location = New System.Drawing.Point(912, 720)
        Me.btnSectionAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSectionAdd.Name = "btnSectionAdd"
        Me.btnSectionAdd.Size = New System.Drawing.Size(115, 43)
        Me.btnSectionAdd.TabIndex = 7
        Me.btnSectionAdd.Text = "Add"
        Me.btnSectionAdd.UseVisualStyleBackColor = True
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
        Me.dgvSections.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SecSectionID, Me.SecSubjectCode, Me.SecSubjectName, Me.SecDescription, Me.SecSkillFocus, Me.SecGradeLevel, Me.SecRoomType, Me.SecCategory, Me.SecLearningMaterials, Me.SecTeacherID, Me.SecSchedule, Me.SecQuarter, Me.SecStatus, Me.SecCreatedBy, Me.SecDateCreated})
        Me.dgvSections.Location = New System.Drawing.Point(44, 554)
        Me.dgvSections.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvSections.Name = "dgvSections"
        Me.dgvSections.ReadOnly = True
        Me.dgvSections.RowHeadersVisible = False
        Me.dgvSections.RowHeadersWidth = 51
        Me.dgvSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSections.Size = New System.Drawing.Size(1245, 145)
        Me.dgvSections.TabIndex = 6
        '
        'SecSectionID
        '
        Me.SecSectionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecSectionID.HeaderText = "Section ID"
        Me.SecSectionID.MinimumWidth = 6
        Me.SecSectionID.Name = "SecSectionID"
        Me.SecSectionID.ReadOnly = True
        Me.SecSectionID.Width = 90
        '
        'SecSubjectCode
        '
        Me.SecSubjectCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecSubjectCode.HeaderText = "Subject Code"
        Me.SecSubjectCode.MinimumWidth = 6
        Me.SecSubjectCode.Name = "SecSubjectCode"
        Me.SecSubjectCode.ReadOnly = True
        Me.SecSubjectCode.Width = 108
        '
        'SecSubjectName
        '
        Me.SecSubjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecSubjectName.HeaderText = "Subject Name"
        Me.SecSubjectName.MinimumWidth = 6
        Me.SecSubjectName.Name = "SecSubjectName"
        Me.SecSubjectName.ReadOnly = True
        Me.SecSubjectName.Width = 111
        '
        'SecDescription
        '
        Me.SecDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecDescription.HeaderText = "Description"
        Me.SecDescription.MinimumWidth = 6
        Me.SecDescription.Name = "SecDescription"
        Me.SecDescription.ReadOnly = True
        Me.SecDescription.Width = 104
        '
        'SecSkillFocus
        '
        Me.SecSkillFocus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecSkillFocus.HeaderText = "Skill Focus"
        Me.SecSkillFocus.MinimumWidth = 6
        Me.SecSkillFocus.Name = "SecSkillFocus"
        Me.SecSkillFocus.ReadOnly = True
        Me.SecSkillFocus.Width = 93
        '
        'SecGradeLevel
        '
        Me.SecGradeLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecGradeLevel.HeaderText = "Grade Level"
        Me.SecGradeLevel.MinimumWidth = 6
        Me.SecGradeLevel.Name = "SecGradeLevel"
        Me.SecGradeLevel.ReadOnly = True
        Me.SecGradeLevel.Width = 101
        '
        'SecRoomType
        '
        Me.SecRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecRoomType.HeaderText = "Room Type"
        Me.SecRoomType.MinimumWidth = 6
        Me.SecRoomType.Name = "SecRoomType"
        Me.SecRoomType.ReadOnly = True
        '
        'SecCategory
        '
        Me.SecCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecCategory.HeaderText = "Category"
        Me.SecCategory.MinimumWidth = 6
        Me.SecCategory.Name = "SecCategory"
        Me.SecCategory.ReadOnly = True
        Me.SecCategory.Width = 91
        '
        'SecLearningMaterials
        '
        Me.SecLearningMaterials.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecLearningMaterials.HeaderText = "Learning Materials"
        Me.SecLearningMaterials.MinimumWidth = 6
        Me.SecLearningMaterials.Name = "SecLearningMaterials"
        Me.SecLearningMaterials.ReadOnly = True
        Me.SecLearningMaterials.Width = 134
        '
        'SecTeacherID
        '
        Me.SecTeacherID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecTeacherID.HeaderText = "Teacher ID"
        Me.SecTeacherID.MinimumWidth = 6
        Me.SecTeacherID.Name = "SecTeacherID"
        Me.SecTeacherID.ReadOnly = True
        Me.SecTeacherID.Width = 95
        '
        'SecSchedule
        '
        Me.SecSchedule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecSchedule.HeaderText = "Schedule"
        Me.SecSchedule.MinimumWidth = 6
        Me.SecSchedule.Name = "SecSchedule"
        Me.SecSchedule.ReadOnly = True
        Me.SecSchedule.Width = 93
        '
        'SecQuarter
        '
        Me.SecQuarter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecQuarter.HeaderText = "Quarter"
        Me.SecQuarter.MinimumWidth = 6
        Me.SecQuarter.Name = "SecQuarter"
        Me.SecQuarter.ReadOnly = True
        Me.SecQuarter.Width = 80
        '
        'SecStatus
        '
        Me.SecStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecStatus.HeaderText = "Status"
        Me.SecStatus.MinimumWidth = 6
        Me.SecStatus.Name = "SecStatus"
        Me.SecStatus.ReadOnly = True
        Me.SecStatus.Width = 73
        '
        'SecCreatedBy
        '
        Me.SecCreatedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecCreatedBy.HeaderText = "Created By"
        Me.SecCreatedBy.MinimumWidth = 6
        Me.SecCreatedBy.Name = "SecCreatedBy"
        Me.SecCreatedBy.ReadOnly = True
        Me.SecCreatedBy.Width = 95
        '
        'SecDateCreated
        '
        Me.SecDateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SecDateCreated.HeaderText = "Date Created"
        Me.SecDateCreated.MinimumWidth = 6
        Me.SecDateCreated.Name = "SecDateCreated"
        Me.SecDateCreated.ReadOnly = True
        Me.SecDateCreated.Width = 107
        '
        'grpSectionInfo
        '
        Me.grpSectionInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSectionInfo.BackColor = System.Drawing.Color.Gainsboro
        Me.grpSectionInfo.Controls.Add(Me.txtbxManSecRemarks)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecRemarks)
        Me.grpSectionInfo.Controls.Add(Me.cmbManSecLearningMode)
        Me.grpSectionInfo.Controls.Add(Me.cmbManSecClassType)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecLearningMode)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecClassType)
        Me.grpSectionInfo.Controls.Add(Me.dtpManSecDateCreated)
        Me.grpSectionInfo.Controls.Add(Me.txtbxManSecRoomNo)
        Me.grpSectionInfo.Controls.Add(Me.dtpManSecEndDate)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecDateCreated)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecRoomNo)
        Me.grpSectionInfo.Controls.Add(Me.txtbxManSecCreatedBy)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecCreatedBy)
        Me.grpSectionInfo.Controls.Add(Me.dtpManSecStartDate)
        Me.grpSectionInfo.Controls.Add(Me.nudManSecGradeLevel)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecStatus)
        Me.grpSectionInfo.Controls.Add(Me.nudManSecNoOfStudents)
        Me.grpSectionInfo.Controls.Add(Me.cmbStudenttGender)
        Me.grpSectionInfo.Controls.Add(Me.txtbxManSecStatus)
        Me.grpSectionInfo.Controls.Add(Me.dtpManSecSchoolYear)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecSchoolYear)
        Me.grpSectionInfo.Controls.Add(Me.txtbxSchedule)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecSchedule)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecCapacity)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecNoOfStudents)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecStartDate)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecEndDate)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecGradeLevel)
        Me.grpSectionInfo.Controls.Add(Me.txtbxManSecTeacherID)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecTeacherID)
        Me.grpSectionInfo.Controls.Add(Me.txtbxManSecSectionName)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecSectionName)
        Me.grpSectionInfo.Controls.Add(Me.txtbxManSecSectionID)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecSectionID)
        Me.grpSectionInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSectionInfo.Location = New System.Drawing.Point(44, 97)
        Me.grpSectionInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSectionInfo.Name = "grpSectionInfo"
        Me.grpSectionInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSectionInfo.Size = New System.Drawing.Size(1245, 438)
        Me.grpSectionInfo.TabIndex = 3
        Me.grpSectionInfo.TabStop = False
        Me.grpSectionInfo.Text = "Section Information"
        '
        'txtbxManSecRemarks
        '
        Me.txtbxManSecRemarks.Location = New System.Drawing.Point(73, 341)
        Me.txtbxManSecRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxManSecRemarks.MaxLength = 20
        Me.txtbxManSecRemarks.Multiline = True
        Me.txtbxManSecRemarks.Name = "txtbxManSecRemarks"
        Me.txtbxManSecRemarks.Size = New System.Drawing.Size(361, 73)
        Me.txtbxManSecRemarks.TabIndex = 36
        '
        'lblManSecRemarks
        '
        Me.lblManSecRemarks.AutoSize = True
        Me.lblManSecRemarks.Location = New System.Drawing.Point(69, 314)
        Me.lblManSecRemarks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecRemarks.Name = "lblManSecRemarks"
        Me.lblManSecRemarks.Size = New System.Drawing.Size(76, 20)
        Me.lblManSecRemarks.TabIndex = 35
        Me.lblManSecRemarks.Text = "Remarks"
        '
        'cmbManSecLearningMode
        '
        Me.cmbManSecLearningMode.FormattingEnabled = True
        Me.cmbManSecLearningMode.Location = New System.Drawing.Point(389, 242)
        Me.cmbManSecLearningMode.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbManSecLearningMode.Name = "cmbManSecLearningMode"
        Me.cmbManSecLearningMode.Size = New System.Drawing.Size(204, 28)
        Me.cmbManSecLearningMode.TabIndex = 34
        '
        'cmbManSecClassType
        '
        Me.cmbManSecClassType.FormattingEnabled = True
        Me.cmbManSecClassType.Location = New System.Drawing.Point(73, 242)
        Me.cmbManSecClassType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbManSecClassType.Name = "cmbManSecClassType"
        Me.cmbManSecClassType.Size = New System.Drawing.Size(204, 28)
        Me.cmbManSecClassType.TabIndex = 33
        '
        'lblManSecLearningMode
        '
        Me.lblManSecLearningMode.AutoSize = True
        Me.lblManSecLearningMode.Location = New System.Drawing.Point(385, 218)
        Me.lblManSecLearningMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecLearningMode.Name = "lblManSecLearningMode"
        Me.lblManSecLearningMode.Size = New System.Drawing.Size(120, 20)
        Me.lblManSecLearningMode.TabIndex = 32
        Me.lblManSecLearningMode.Text = "Learning Mode"
        '
        'lblManSecClassType
        '
        Me.lblManSecClassType.AutoSize = True
        Me.lblManSecClassType.Location = New System.Drawing.Point(69, 218)
        Me.lblManSecClassType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecClassType.Name = "lblManSecClassType"
        Me.lblManSecClassType.Size = New System.Drawing.Size(93, 20)
        Me.lblManSecClassType.TabIndex = 30
        Me.lblManSecClassType.Text = "Class Type"
        '
        'dtpManSecDateCreated
        '
        Me.dtpManSecDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpManSecDateCreated.Location = New System.Drawing.Point(996, 386)
        Me.dtpManSecDateCreated.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpManSecDateCreated.Name = "dtpManSecDateCreated"
        Me.dtpManSecDateCreated.Size = New System.Drawing.Size(135, 26)
        Me.dtpManSecDateCreated.TabIndex = 7
        '
        'txtbxManSecRoomNo
        '
        Me.txtbxManSecRoomNo.Location = New System.Drawing.Point(632, 164)
        Me.txtbxManSecRoomNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxManSecRoomNo.Name = "txtbxManSecRoomNo"
        Me.txtbxManSecRoomNo.Size = New System.Drawing.Size(176, 26)
        Me.txtbxManSecRoomNo.TabIndex = 13
        '
        'dtpManSecEndDate
        '
        Me.dtpManSecEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpManSecEndDate.Location = New System.Drawing.Point(899, 106)
        Me.dtpManSecEndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpManSecEndDate.Name = "dtpManSecEndDate"
        Me.dtpManSecEndDate.Size = New System.Drawing.Size(135, 26)
        Me.dtpManSecEndDate.TabIndex = 29
        '
        'lblManSecDateCreated
        '
        Me.lblManSecDateCreated.AutoSize = True
        Me.lblManSecDateCreated.Location = New System.Drawing.Point(992, 362)
        Me.lblManSecDateCreated.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecDateCreated.Name = "lblManSecDateCreated"
        Me.lblManSecDateCreated.Size = New System.Drawing.Size(109, 20)
        Me.lblManSecDateCreated.TabIndex = 4
        Me.lblManSecDateCreated.Text = "Date Created"
        '
        'lblManSecRoomNo
        '
        Me.lblManSecRoomNo.AutoSize = True
        Me.lblManSecRoomNo.Location = New System.Drawing.Point(628, 140)
        Me.lblManSecRoomNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecRoomNo.Name = "lblManSecRoomNo"
        Me.lblManSecRoomNo.Size = New System.Drawing.Size(83, 20)
        Me.lblManSecRoomNo.TabIndex = 12
        Me.lblManSecRoomNo.Text = "Room No."
        '
        'txtbxManSecCreatedBy
        '
        Me.txtbxManSecCreatedBy.Location = New System.Drawing.Point(716, 389)
        Me.txtbxManSecCreatedBy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxManSecCreatedBy.MaxLength = 50
        Me.txtbxManSecCreatedBy.Name = "txtbxManSecCreatedBy"
        Me.txtbxManSecCreatedBy.Size = New System.Drawing.Size(239, 26)
        Me.txtbxManSecCreatedBy.TabIndex = 1
        '
        'lblManSecCreatedBy
        '
        Me.lblManSecCreatedBy.AutoSize = True
        Me.lblManSecCreatedBy.Location = New System.Drawing.Point(712, 362)
        Me.lblManSecCreatedBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecCreatedBy.Name = "lblManSecCreatedBy"
        Me.lblManSecCreatedBy.Size = New System.Drawing.Size(93, 20)
        Me.lblManSecCreatedBy.TabIndex = 0
        Me.lblManSecCreatedBy.Text = "Created By"
        '
        'dtpManSecStartDate
        '
        Me.dtpManSecStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpManSecStartDate.Location = New System.Drawing.Point(899, 48)
        Me.dtpManSecStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpManSecStartDate.Name = "dtpManSecStartDate"
        Me.dtpManSecStartDate.Size = New System.Drawing.Size(135, 26)
        Me.dtpManSecStartDate.TabIndex = 28
        '
        'nudManSecGradeLevel
        '
        Me.nudManSecGradeLevel.Location = New System.Drawing.Point(112, 165)
        Me.nudManSecGradeLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.nudManSecGradeLevel.Name = "nudManSecGradeLevel"
        Me.nudManSecGradeLevel.Size = New System.Drawing.Size(47, 26)
        Me.nudManSecGradeLevel.TabIndex = 27
        '
        'lblManSecStatus
        '
        Me.lblManSecStatus.AutoSize = True
        Me.lblManSecStatus.Location = New System.Drawing.Point(628, 84)
        Me.lblManSecStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecStatus.Name = "lblManSecStatus"
        Me.lblManSecStatus.Size = New System.Drawing.Size(57, 20)
        Me.lblManSecStatus.TabIndex = 26
        Me.lblManSecStatus.Text = "Status"
        '
        'nudManSecNoOfStudents
        '
        Me.nudManSecNoOfStudents.Location = New System.Drawing.Point(389, 103)
        Me.nudManSecNoOfStudents.Margin = New System.Windows.Forms.Padding(4)
        Me.nudManSecNoOfStudents.Name = "nudManSecNoOfStudents"
        Me.nudManSecNoOfStudents.Size = New System.Drawing.Size(47, 26)
        Me.nudManSecNoOfStudents.TabIndex = 24
        '
        'cmbStudenttGender
        '
        Me.cmbStudenttGender.FormattingEnabled = True
        Me.cmbStudenttGender.Location = New System.Drawing.Point(389, 46)
        Me.cmbStudenttGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStudenttGender.Name = "cmbStudenttGender"
        Me.cmbStudenttGender.Size = New System.Drawing.Size(136, 28)
        Me.cmbStudenttGender.TabIndex = 23
        '
        'txtbxManSecStatus
        '
        Me.txtbxManSecStatus.Location = New System.Drawing.Point(632, 108)
        Me.txtbxManSecStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxManSecStatus.Name = "txtbxManSecStatus"
        Me.txtbxManSecStatus.Size = New System.Drawing.Size(176, 26)
        Me.txtbxManSecStatus.TabIndex = 12
        '
        'dtpManSecSchoolYear
        '
        Me.dtpManSecSchoolYear.Location = New System.Drawing.Point(872, 165)
        Me.dtpManSecSchoolYear.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpManSecSchoolYear.Name = "dtpManSecSchoolYear"
        Me.dtpManSecSchoolYear.Size = New System.Drawing.Size(308, 26)
        Me.dtpManSecSchoolYear.TabIndex = 22
        '
        'lblManSecSchoolYear
        '
        Me.lblManSecSchoolYear.AutoSize = True
        Me.lblManSecSchoolYear.Location = New System.Drawing.Point(895, 140)
        Me.lblManSecSchoolYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecSchoolYear.Name = "lblManSecSchoolYear"
        Me.lblManSecSchoolYear.Size = New System.Drawing.Size(99, 20)
        Me.lblManSecSchoolYear.TabIndex = 21
        Me.lblManSecSchoolYear.Text = "School Year"
        '
        'txtbxSchedule
        '
        Me.txtbxSchedule.Location = New System.Drawing.Point(632, 48)
        Me.txtbxSchedule.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxSchedule.MaxLength = 20
        Me.txtbxSchedule.Name = "txtbxSchedule"
        Me.txtbxSchedule.Size = New System.Drawing.Size(176, 26)
        Me.txtbxSchedule.TabIndex = 10
        '
        'lblManSecSchedule
        '
        Me.lblManSecSchedule.AutoSize = True
        Me.lblManSecSchedule.Location = New System.Drawing.Point(628, 28)
        Me.lblManSecSchedule.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecSchedule.Name = "lblManSecSchedule"
        Me.lblManSecSchedule.Size = New System.Drawing.Size(78, 20)
        Me.lblManSecSchedule.TabIndex = 11
        Me.lblManSecSchedule.Text = "Schedule"
        '
        'lblManSecCapacity
        '
        Me.lblManSecCapacity.AutoSize = True
        Me.lblManSecCapacity.Location = New System.Drawing.Point(385, 23)
        Me.lblManSecCapacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecCapacity.Name = "lblManSecCapacity"
        Me.lblManSecCapacity.Size = New System.Drawing.Size(74, 20)
        Me.lblManSecCapacity.TabIndex = 19
        Me.lblManSecCapacity.Text = "Capacity"
        '
        'lblManSecNoOfStudents
        '
        Me.lblManSecNoOfStudents.AutoSize = True
        Me.lblManSecNoOfStudents.Location = New System.Drawing.Point(385, 84)
        Me.lblManSecNoOfStudents.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecNoOfStudents.Name = "lblManSecNoOfStudents"
        Me.lblManSecNoOfStudents.Size = New System.Drawing.Size(124, 20)
        Me.lblManSecNoOfStudents.TabIndex = 17
        Me.lblManSecNoOfStudents.Text = "No. of Students"
        '
        'lblManSecStartDate
        '
        Me.lblManSecStartDate.AutoSize = True
        Me.lblManSecStartDate.Location = New System.Drawing.Point(895, 23)
        Me.lblManSecStartDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecStartDate.Name = "lblManSecStartDate"
        Me.lblManSecStartDate.Size = New System.Drawing.Size(86, 20)
        Me.lblManSecStartDate.TabIndex = 15
        Me.lblManSecStartDate.Text = "Start Date"
        '
        'lblManSecEndDate
        '
        Me.lblManSecEndDate.AutoSize = True
        Me.lblManSecEndDate.Location = New System.Drawing.Point(895, 80)
        Me.lblManSecEndDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecEndDate.Name = "lblManSecEndDate"
        Me.lblManSecEndDate.Size = New System.Drawing.Size(79, 20)
        Me.lblManSecEndDate.TabIndex = 13
        Me.lblManSecEndDate.Text = "End Date"
        '
        'lblManSecGradeLevel
        '
        Me.lblManSecGradeLevel.AutoSize = True
        Me.lblManSecGradeLevel.Location = New System.Drawing.Point(69, 140)
        Me.lblManSecGradeLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecGradeLevel.Name = "lblManSecGradeLevel"
        Me.lblManSecGradeLevel.Size = New System.Drawing.Size(100, 20)
        Me.lblManSecGradeLevel.TabIndex = 9
        Me.lblManSecGradeLevel.Text = "Grade Level"
        '
        'txtbxManSecTeacherID
        '
        Me.txtbxManSecTeacherID.Location = New System.Drawing.Point(389, 165)
        Me.txtbxManSecTeacherID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxManSecTeacherID.MaxLength = 20
        Me.txtbxManSecTeacherID.Name = "txtbxManSecTeacherID"
        Me.txtbxManSecTeacherID.Size = New System.Drawing.Size(153, 26)
        Me.txtbxManSecTeacherID.TabIndex = 6
        '
        'lblManSecTeacherID
        '
        Me.lblManSecTeacherID.AutoSize = True
        Me.lblManSecTeacherID.Location = New System.Drawing.Point(385, 140)
        Me.lblManSecTeacherID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecTeacherID.Name = "lblManSecTeacherID"
        Me.lblManSecTeacherID.Size = New System.Drawing.Size(92, 20)
        Me.lblManSecTeacherID.TabIndex = 5
        Me.lblManSecTeacherID.Text = "Teacher ID"
        '
        'txtbxManSecSectionName
        '
        Me.txtbxManSecSectionName.Location = New System.Drawing.Point(73, 103)
        Me.txtbxManSecSectionName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxManSecSectionName.MaxLength = 20
        Me.txtbxManSecSectionName.Name = "txtbxManSecSectionName"
        Me.txtbxManSecSectionName.Size = New System.Drawing.Size(252, 26)
        Me.txtbxManSecSectionName.TabIndex = 4
        '
        'lblManSecSectionName
        '
        Me.lblManSecSectionName.AutoSize = True
        Me.lblManSecSectionName.Location = New System.Drawing.Point(69, 79)
        Me.lblManSecSectionName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecSectionName.Name = "lblManSecSectionName"
        Me.lblManSecSectionName.Size = New System.Drawing.Size(114, 20)
        Me.lblManSecSectionName.TabIndex = 3
        Me.lblManSecSectionName.Text = "Section Name"
        '
        'txtbxManSecSectionID
        '
        Me.txtbxManSecSectionID.Location = New System.Drawing.Point(73, 46)
        Me.txtbxManSecSectionID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxManSecSectionID.MaxLength = 20
        Me.txtbxManSecSectionID.Name = "txtbxManSecSectionID"
        Me.txtbxManSecSectionID.Size = New System.Drawing.Size(252, 26)
        Me.txtbxManSecSectionID.TabIndex = 2
        '
        'lblManSecSectionID
        '
        Me.lblManSecSectionID.AutoSize = True
        Me.lblManSecSectionID.Location = New System.Drawing.Point(69, 23)
        Me.lblManSecSectionID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManSecSectionID.Name = "lblManSecSectionID"
        Me.lblManSecSectionID.Size = New System.Drawing.Size(87, 20)
        Me.lblManSecSectionID.TabIndex = 1
        Me.lblManSecSectionID.Text = "Section ID"
        '
        'lblSectionsList
        '
        Me.lblSectionsList.AutoSize = True
        Me.lblSectionsList.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSectionsList.ForeColor = System.Drawing.Color.White
        Me.lblSectionsList.Location = New System.Drawing.Point(37, 36)
        Me.lblSectionsList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSectionsList.Name = "lblSectionsList"
        Me.lblSectionsList.Size = New System.Drawing.Size(148, 32)
        Me.lblSectionsList.TabIndex = 2
        Me.lblSectionsList.Text = "Sections List"
        '
        'btnSectionSearch
        '
        Me.btnSectionSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSectionSearch.Location = New System.Drawing.Point(759, 720)
        Me.btnSectionSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSectionSearch.Name = "btnSectionSearch"
        Me.btnSectionSearch.Size = New System.Drawing.Size(120, 43)
        Me.btnSectionSearch.TabIndex = 1
        Me.btnSectionSearch.Text = "Search"
        Me.btnSectionSearch.UseVisualStyleBackColor = True
        '
        'picWatermark
        '
        Me.picWatermark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(317, 97)
        Me.picWatermark.Margin = New System.Windows.Forms.Padding(4)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(693, 574)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 5
        Me.picWatermark.TabStop = False
        '
        'TextBoxStudentSearch
        '
        Me.TextBoxStudentSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxStudentSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentSearch.Location = New System.Drawing.Point(483, 726)
        Me.TextBoxStudentSearch.MaxLength = 50
        Me.TextBoxStudentSearch.Name = "TextBoxStudentSearch"
        Me.TextBoxStudentSearch.Size = New System.Drawing.Size(246, 36)
        Me.TextBoxStudentSearch.TabIndex = 11
        '
        'AdminManageSections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1732, 775)
        Me.Controls.Add(Me.pnlManSecContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminManageSections"
        Me.Text = "AdminManageSections"
        Me.pnlSidebar.ResumeLayout(False)
        Me.flowButtons.ResumeLayout(False)
        Me.pnlManSecContent.ResumeLayout(False)
        Me.pnlManSecContent.PerformLayout()
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSectionInfo.ResumeLayout(False)
        Me.grpSectionInfo.PerformLayout()
        CType(Me.nudManSecGradeLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudManSecNoOfStudents, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pnlManSecContent As Panel
    Friend WithEvents btnSectionDelete As Button
    Friend WithEvents btnSectionUpdate As Button
    Friend WithEvents btnSectionAdd As Button
    Friend WithEvents dgvSections As DataGridView
    Friend WithEvents txtbxManSecRoomNo As TextBox
    Friend WithEvents lblManSecRoomNo As Label
    Friend WithEvents lblManSecDateCreated As Label
    Friend WithEvents txtbxManSecCreatedBy As TextBox
    Friend WithEvents lblManSecCreatedBy As Label
    Friend WithEvents grpSectionInfo As GroupBox
    Friend WithEvents nudManSecGradeLevel As NumericUpDown
    Friend WithEvents lblManSecStatus As Label
    Friend WithEvents nudManSecNoOfStudents As NumericUpDown
    Friend WithEvents cmbStudenttGender As ComboBox
    Friend WithEvents dtpManSecSchoolYear As DateTimePicker
    Friend WithEvents lblManSecSchoolYear As Label
    Friend WithEvents lblManSecCapacity As Label
    Friend WithEvents lblManSecNoOfStudents As Label
    Friend WithEvents lblManSecStartDate As Label
    Friend WithEvents lblManSecEndDate As Label
    Friend WithEvents txtbxManSecStatus As TextBox
    Friend WithEvents lblManSecSchedule As Label
    Friend WithEvents txtbxSchedule As TextBox
    Friend WithEvents lblManSecGradeLevel As Label
    Friend WithEvents txtbxManSecTeacherID As TextBox
    Friend WithEvents lblManSecTeacherID As Label
    Friend WithEvents txtbxManSecSectionName As TextBox
    Friend WithEvents lblManSecSectionName As Label
    Friend WithEvents txtbxManSecSectionID As TextBox
    Friend WithEvents lblManSecSectionID As Label
    Friend WithEvents lblSectionsList As Label
    Friend WithEvents btnSectionSearch As Button
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents dtpManSecEndDate As DateTimePicker
    Friend WithEvents dtpManSecStartDate As DateTimePicker
    Friend WithEvents lblManSecLearningMode As Label
    Friend WithEvents lblManSecClassType As Label
    Friend WithEvents dtpManSecDateCreated As DateTimePicker
    Friend WithEvents cmbManSecLearningMode As ComboBox
    Friend WithEvents cmbManSecClassType As ComboBox
    Friend WithEvents lblManSecRemarks As Label
    Friend WithEvents txtbxManSecRemarks As TextBox
    Friend WithEvents SecSectionID As DataGridViewTextBoxColumn
    Friend WithEvents SecSubjectCode As DataGridViewTextBoxColumn
    Friend WithEvents SecSubjectName As DataGridViewTextBoxColumn
    Friend WithEvents SecDescription As DataGridViewTextBoxColumn
    Friend WithEvents SecSkillFocus As DataGridViewTextBoxColumn
    Friend WithEvents SecGradeLevel As DataGridViewTextBoxColumn
    Friend WithEvents SecRoomType As DataGridViewTextBoxColumn
    Friend WithEvents SecCategory As DataGridViewTextBoxColumn
    Friend WithEvents SecLearningMaterials As DataGridViewTextBoxColumn
    Friend WithEvents SecTeacherID As DataGridViewTextBoxColumn
    Friend WithEvents SecSchedule As DataGridViewTextBoxColumn
    Friend WithEvents SecQuarter As DataGridViewTextBoxColumn
    Friend WithEvents SecStatus As DataGridViewTextBoxColumn
    Friend WithEvents SecCreatedBy As DataGridViewTextBoxColumn
    Friend WithEvents SecDateCreated As DataGridViewTextBoxColumn
    Friend WithEvents TextBoxStudentSearch As TextBox
End Class
