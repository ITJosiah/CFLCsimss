<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminManageSections
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.TextBoxStudentSearch = New System.Windows.Forms.TextBox()
        Me.btnSectionDelete = New System.Windows.Forms.Button()
        Me.btnSectionUpdate = New System.Windows.Forms.Button()
        Me.btnSectionAdd = New System.Windows.Forms.Button()
        Me.dgvSections = New System.Windows.Forms.DataGridView()
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
        Me.dtpManSecSchoolYear = New System.Windows.Forms.DateTimePicker()
        Me.lblManSecSchoolYear = New System.Windows.Forms.Label()
        Me.txtbxSecSchedule = New System.Windows.Forms.TextBox()
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
        Me.cbxManSecStatus = New System.Windows.Forms.ComboBox()
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
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(30, 40, 30, 40)
        Me.pnlSidebar.Size = New System.Drawing.Size(300, 630)
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
        Me.flowButtons.Location = New System.Drawing.Point(30, 40)
        Me.flowButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.flowButtons.Name = "flowButtons"
        Me.flowButtons.Size = New System.Drawing.Size(240, 500)
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
        'btnManageEnrollments
        '
        Me.btnManageEnrollments.Location = New System.Drawing.Point(0, 189)
        Me.btnManageEnrollments.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnManageEnrollments.Name = "btnManageEnrollments"
        Me.btnManageEnrollments.Size = New System.Drawing.Size(240, 45)
        Me.btnManageEnrollments.TabIndex = 7
        Me.btnManageEnrollments.Text = "Manage Enrollments"
        Me.btnManageEnrollments.UseVisualStyleBackColor = True
        '
        'btnManageSubjects
        '
        Me.btnManageSubjects.Location = New System.Drawing.Point(0, 252)
        Me.btnManageSubjects.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnManageSubjects.Name = "btnManageSubjects"
        Me.btnManageSubjects.Size = New System.Drawing.Size(240, 45)
        Me.btnManageSubjects.TabIndex = 8
        Me.btnManageSubjects.Text = "Manage Subjects"
        Me.btnManageSubjects.UseVisualStyleBackColor = True
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
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(30, 540)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(240, 50)
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
        Me.pnlManSecContent.Location = New System.Drawing.Point(300, 1)
        Me.pnlManSecContent.Name = "pnlManSecContent"
        Me.pnlManSecContent.Padding = New System.Windows.Forms.Padding(30, 30, 30, 30)
        Me.pnlManSecContent.Size = New System.Drawing.Size(1000, 633)
        Me.pnlManSecContent.TabIndex = 13
        '
        'TextBoxStudentSearch
        '
        Me.TextBoxStudentSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxStudentSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentSearch.Location = New System.Drawing.Point(362, 590)
        Me.TextBoxStudentSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxStudentSearch.MaxLength = 50
        Me.TextBoxStudentSearch.Name = "TextBoxStudentSearch"
        Me.TextBoxStudentSearch.Size = New System.Drawing.Size(186, 30)
        Me.TextBoxStudentSearch.TabIndex = 11
        '
        'btnSectionDelete
        '
        Me.btnSectionDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSectionDelete.Location = New System.Drawing.Point(908, 585)
        Me.btnSectionDelete.Name = "btnSectionDelete"
        Me.btnSectionDelete.Size = New System.Drawing.Size(86, 35)
        Me.btnSectionDelete.TabIndex = 9
        Me.btnSectionDelete.Text = "Delete"
        Me.btnSectionDelete.UseVisualStyleBackColor = True
        '
        'btnSectionUpdate
        '
        Me.btnSectionUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSectionUpdate.Location = New System.Drawing.Point(796, 585)
        Me.btnSectionUpdate.Name = "btnSectionUpdate"
        Me.btnSectionUpdate.Size = New System.Drawing.Size(86, 35)
        Me.btnSectionUpdate.TabIndex = 8
        Me.btnSectionUpdate.Text = "Update"
        Me.btnSectionUpdate.UseVisualStyleBackColor = True
        '
        'btnSectionAdd
        '
        Me.btnSectionAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSectionAdd.Location = New System.Drawing.Point(684, 585)
        Me.btnSectionAdd.Name = "btnSectionAdd"
        Me.btnSectionAdd.Size = New System.Drawing.Size(86, 35)
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
        Me.dgvSections.Location = New System.Drawing.Point(33, 450)
        Me.dgvSections.Name = "dgvSections"
        Me.dgvSections.ReadOnly = True
        Me.dgvSections.RowHeadersVisible = False
        Me.dgvSections.RowHeadersWidth = 51
        Me.dgvSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSections.Size = New System.Drawing.Size(934, 118)
        Me.dgvSections.TabIndex = 6
        '
        'grpSectionInfo
        '
        Me.grpSectionInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSectionInfo.BackColor = System.Drawing.Color.Gainsboro
        Me.grpSectionInfo.Controls.Add(Me.cbxManSecStatus)
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
        Me.grpSectionInfo.Controls.Add(Me.dtpManSecSchoolYear)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecSchoolYear)
        Me.grpSectionInfo.Controls.Add(Me.txtbxSecSchedule)
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
        Me.grpSectionInfo.Location = New System.Drawing.Point(33, 79)
        Me.grpSectionInfo.Name = "grpSectionInfo"
        Me.grpSectionInfo.Size = New System.Drawing.Size(934, 356)
        Me.grpSectionInfo.TabIndex = 3
        Me.grpSectionInfo.TabStop = False
        Me.grpSectionInfo.Text = "Section Information"
        '
        'txtbxManSecRemarks
        '
        Me.txtbxManSecRemarks.Location = New System.Drawing.Point(55, 277)
        Me.txtbxManSecRemarks.MaxLength = 20
        Me.txtbxManSecRemarks.Multiline = True
        Me.txtbxManSecRemarks.Name = "txtbxManSecRemarks"
        Me.txtbxManSecRemarks.Size = New System.Drawing.Size(272, 60)
        Me.txtbxManSecRemarks.TabIndex = 36
        '
        'lblManSecRemarks
        '
        Me.lblManSecRemarks.AutoSize = True
        Me.lblManSecRemarks.Location = New System.Drawing.Point(52, 255)
        Me.lblManSecRemarks.Name = "lblManSecRemarks"
        Me.lblManSecRemarks.Size = New System.Drawing.Size(64, 17)
        Me.lblManSecRemarks.TabIndex = 35
        Me.lblManSecRemarks.Text = "Remarks"
        '
        'cmbManSecLearningMode
        '
        Me.cmbManSecLearningMode.FormattingEnabled = True
        Me.cmbManSecLearningMode.Location = New System.Drawing.Point(292, 197)
        Me.cmbManSecLearningMode.Name = "cmbManSecLearningMode"
        Me.cmbManSecLearningMode.Size = New System.Drawing.Size(154, 24)
        Me.cmbManSecLearningMode.TabIndex = 34
        '
        'cmbManSecClassType
        '
        Me.cmbManSecClassType.FormattingEnabled = True
        Me.cmbManSecClassType.Location = New System.Drawing.Point(55, 197)
        Me.cmbManSecClassType.Name = "cmbManSecClassType"
        Me.cmbManSecClassType.Size = New System.Drawing.Size(154, 24)
        Me.cmbManSecClassType.TabIndex = 33
        '
        'lblManSecLearningMode
        '
        Me.lblManSecLearningMode.AutoSize = True
        Me.lblManSecLearningMode.Location = New System.Drawing.Point(289, 177)
        Me.lblManSecLearningMode.Name = "lblManSecLearningMode"
        Me.lblManSecLearningMode.Size = New System.Drawing.Size(103, 17)
        Me.lblManSecLearningMode.TabIndex = 32
        Me.lblManSecLearningMode.Text = "Learning Mode"
        '
        'lblManSecClassType
        '
        Me.lblManSecClassType.AutoSize = True
        Me.lblManSecClassType.Location = New System.Drawing.Point(52, 177)
        Me.lblManSecClassType.Name = "lblManSecClassType"
        Me.lblManSecClassType.Size = New System.Drawing.Size(78, 17)
        Me.lblManSecClassType.TabIndex = 30
        Me.lblManSecClassType.Text = "Class Type"
        '
        'dtpManSecDateCreated
        '
        Me.dtpManSecDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpManSecDateCreated.Location = New System.Drawing.Point(747, 314)
        Me.dtpManSecDateCreated.Name = "dtpManSecDateCreated"
        Me.dtpManSecDateCreated.Size = New System.Drawing.Size(102, 23)
        Me.dtpManSecDateCreated.TabIndex = 7
        '
        'txtbxManSecRoomNo
        '
        Me.txtbxManSecRoomNo.Location = New System.Drawing.Point(474, 133)
        Me.txtbxManSecRoomNo.Name = "txtbxManSecRoomNo"
        Me.txtbxManSecRoomNo.Size = New System.Drawing.Size(133, 23)
        Me.txtbxManSecRoomNo.TabIndex = 13
        '
        'dtpManSecEndDate
        '
        Me.dtpManSecEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpManSecEndDate.Location = New System.Drawing.Point(674, 86)
        Me.dtpManSecEndDate.Name = "dtpManSecEndDate"
        Me.dtpManSecEndDate.Size = New System.Drawing.Size(102, 23)
        Me.dtpManSecEndDate.TabIndex = 29
        '
        'lblManSecDateCreated
        '
        Me.lblManSecDateCreated.AutoSize = True
        Me.lblManSecDateCreated.Location = New System.Drawing.Point(744, 294)
        Me.lblManSecDateCreated.Name = "lblManSecDateCreated"
        Me.lblManSecDateCreated.Size = New System.Drawing.Size(92, 17)
        Me.lblManSecDateCreated.TabIndex = 4
        Me.lblManSecDateCreated.Text = "Date Created"
        '
        'lblManSecRoomNo
        '
        Me.lblManSecRoomNo.AutoSize = True
        Me.lblManSecRoomNo.Location = New System.Drawing.Point(471, 114)
        Me.lblManSecRoomNo.Name = "lblManSecRoomNo"
        Me.lblManSecRoomNo.Size = New System.Drawing.Size(71, 17)
        Me.lblManSecRoomNo.TabIndex = 12
        Me.lblManSecRoomNo.Text = "Room No."
        '
        'txtbxManSecCreatedBy
        '
        Me.txtbxManSecCreatedBy.Location = New System.Drawing.Point(537, 316)
        Me.txtbxManSecCreatedBy.MaxLength = 50
        Me.txtbxManSecCreatedBy.Name = "txtbxManSecCreatedBy"
        Me.txtbxManSecCreatedBy.Size = New System.Drawing.Size(180, 23)
        Me.txtbxManSecCreatedBy.TabIndex = 1
        '
        'lblManSecCreatedBy
        '
        Me.lblManSecCreatedBy.AutoSize = True
        Me.lblManSecCreatedBy.Location = New System.Drawing.Point(534, 294)
        Me.lblManSecCreatedBy.Name = "lblManSecCreatedBy"
        Me.lblManSecCreatedBy.Size = New System.Drawing.Size(78, 17)
        Me.lblManSecCreatedBy.TabIndex = 0
        Me.lblManSecCreatedBy.Text = "Created By"
        '
        'dtpManSecStartDate
        '
        Me.dtpManSecStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpManSecStartDate.Location = New System.Drawing.Point(674, 39)
        Me.dtpManSecStartDate.Name = "dtpManSecStartDate"
        Me.dtpManSecStartDate.Size = New System.Drawing.Size(102, 23)
        Me.dtpManSecStartDate.TabIndex = 28
        '
        'nudManSecGradeLevel
        '
        Me.nudManSecGradeLevel.Location = New System.Drawing.Point(84, 134)
        Me.nudManSecGradeLevel.Name = "nudManSecGradeLevel"
        Me.nudManSecGradeLevel.Size = New System.Drawing.Size(35, 23)
        Me.nudManSecGradeLevel.TabIndex = 27
        '
        'lblManSecStatus
        '
        Me.lblManSecStatus.AutoSize = True
        Me.lblManSecStatus.Location = New System.Drawing.Point(471, 68)
        Me.lblManSecStatus.Name = "lblManSecStatus"
        Me.lblManSecStatus.Size = New System.Drawing.Size(48, 17)
        Me.lblManSecStatus.TabIndex = 26
        Me.lblManSecStatus.Text = "Status"
        '
        'nudManSecNoOfStudents
        '
        Me.nudManSecNoOfStudents.Location = New System.Drawing.Point(292, 84)
        Me.nudManSecNoOfStudents.Name = "nudManSecNoOfStudents"
        Me.nudManSecNoOfStudents.Size = New System.Drawing.Size(35, 23)
        Me.nudManSecNoOfStudents.TabIndex = 24
        '
        'cmbStudenttGender
        '
        Me.cmbStudenttGender.FormattingEnabled = True
        Me.cmbStudenttGender.Location = New System.Drawing.Point(292, 37)
        Me.cmbStudenttGender.Name = "cmbStudenttGender"
        Me.cmbStudenttGender.Size = New System.Drawing.Size(103, 24)
        Me.cmbStudenttGender.TabIndex = 23
        '
        'dtpManSecSchoolYear
        '
        Me.dtpManSecSchoolYear.Location = New System.Drawing.Point(654, 134)
        Me.dtpManSecSchoolYear.Name = "dtpManSecSchoolYear"
        Me.dtpManSecSchoolYear.Size = New System.Drawing.Size(232, 23)
        Me.dtpManSecSchoolYear.TabIndex = 22
        '
        'lblManSecSchoolYear
        '
        Me.lblManSecSchoolYear.AutoSize = True
        Me.lblManSecSchoolYear.Location = New System.Drawing.Point(671, 114)
        Me.lblManSecSchoolYear.Name = "lblManSecSchoolYear"
        Me.lblManSecSchoolYear.Size = New System.Drawing.Size(85, 17)
        Me.lblManSecSchoolYear.TabIndex = 21
        Me.lblManSecSchoolYear.Text = "School Year"
        '
        'txtbxSecSchedule
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
        Me.lblManSecSchedule.Location = New System.Drawing.Point(471, 23)
        Me.lblManSecSchedule.Name = "lblManSecSchedule"
        Me.lblManSecSchedule.Size = New System.Drawing.Size(67, 17)
        Me.lblManSecSchedule.TabIndex = 11
        Me.lblManSecSchedule.Text = "Schedule"
        '
        'lblManSecCapacity
        '
        Me.lblManSecCapacity.AutoSize = True
        Me.lblManSecCapacity.Location = New System.Drawing.Point(289, 19)
        Me.lblManSecCapacity.Name = "lblManSecCapacity"
        Me.lblManSecCapacity.Size = New System.Drawing.Size(62, 17)
        Me.lblManSecCapacity.TabIndex = 19
        Me.lblManSecCapacity.Text = "Capacity"
        '
        'lblManSecNoOfStudents
        '
        Me.lblManSecNoOfStudents.AutoSize = True
        Me.lblManSecNoOfStudents.Location = New System.Drawing.Point(289, 68)
        Me.lblManSecNoOfStudents.Name = "lblManSecNoOfStudents"
        Me.lblManSecNoOfStudents.Size = New System.Drawing.Size(106, 17)
        Me.lblManSecNoOfStudents.TabIndex = 17
        Me.lblManSecNoOfStudents.Text = "No. of Students"
        '
        'lblManSecStartDate
        '
        Me.lblManSecStartDate.AutoSize = True
        Me.lblManSecStartDate.Location = New System.Drawing.Point(671, 19)
        Me.lblManSecStartDate.Name = "lblManSecStartDate"
        Me.lblManSecStartDate.Size = New System.Drawing.Size(72, 17)
        Me.lblManSecStartDate.TabIndex = 15
        Me.lblManSecStartDate.Text = "Start Date"
        '
        'lblManSecEndDate
        '
        Me.lblManSecEndDate.AutoSize = True
        Me.lblManSecEndDate.Location = New System.Drawing.Point(671, 65)
        Me.lblManSecEndDate.Name = "lblManSecEndDate"
        Me.lblManSecEndDate.Size = New System.Drawing.Size(67, 17)
        Me.lblManSecEndDate.TabIndex = 13
        Me.lblManSecEndDate.Text = "End Date"
        '
        'lblManSecGradeLevel
        '
        Me.lblManSecGradeLevel.AutoSize = True
        Me.lblManSecGradeLevel.Location = New System.Drawing.Point(52, 114)
        Me.lblManSecGradeLevel.Name = "lblManSecGradeLevel"
        Me.lblManSecGradeLevel.Size = New System.Drawing.Size(86, 17)
        Me.lblManSecGradeLevel.TabIndex = 9
        Me.lblManSecGradeLevel.Text = "Grade Level"
        '
        'txtbxManSecTeacherID
        '
        Me.txtbxManSecTeacherID.Location = New System.Drawing.Point(292, 134)
        Me.txtbxManSecTeacherID.MaxLength = 20
        Me.txtbxManSecTeacherID.Name = "txtbxManSecTeacherID"
        Me.txtbxManSecTeacherID.Size = New System.Drawing.Size(116, 23)
        Me.txtbxManSecTeacherID.TabIndex = 6
        '
        'lblManSecTeacherID
        '
        Me.lblManSecTeacherID.AutoSize = True
        Me.lblManSecTeacherID.Location = New System.Drawing.Point(289, 114)
        Me.lblManSecTeacherID.Name = "lblManSecTeacherID"
        Me.lblManSecTeacherID.Size = New System.Drawing.Size(78, 17)
        Me.lblManSecTeacherID.TabIndex = 5
        Me.lblManSecTeacherID.Text = "Teacher ID"
        '
        'txtbxManSecSectionName
        '
        Me.txtbxManSecSectionName.Location = New System.Drawing.Point(55, 84)
        Me.txtbxManSecSectionName.MaxLength = 20
        Me.txtbxManSecSectionName.Name = "txtbxManSecSectionName"
        Me.txtbxManSecSectionName.Size = New System.Drawing.Size(190, 23)
        Me.txtbxManSecSectionName.TabIndex = 4
        '
        'lblManSecSectionName
        '
        Me.lblManSecSectionName.AutoSize = True
        Me.lblManSecSectionName.Location = New System.Drawing.Point(52, 64)
        Me.lblManSecSectionName.Name = "lblManSecSectionName"
        Me.lblManSecSectionName.Size = New System.Drawing.Size(96, 17)
        Me.lblManSecSectionName.TabIndex = 3
        Me.lblManSecSectionName.Text = "Section Name"
        '
        'txtbxManSecSectionID
        '
        Me.txtbxManSecSectionID.Location = New System.Drawing.Point(55, 37)
        Me.txtbxManSecSectionID.MaxLength = 20
        Me.txtbxManSecSectionID.Name = "txtbxManSecSectionID"
        Me.txtbxManSecSectionID.Size = New System.Drawing.Size(190, 23)
        Me.txtbxManSecSectionID.TabIndex = 2
        '
        'lblManSecSectionID
        '
        Me.lblManSecSectionID.AutoSize = True
        Me.lblManSecSectionID.Location = New System.Drawing.Point(52, 19)
        Me.lblManSecSectionID.Name = "lblManSecSectionID"
        Me.lblManSecSectionID.Size = New System.Drawing.Size(72, 17)
        Me.lblManSecSectionID.TabIndex = 1
        Me.lblManSecSectionID.Text = "Section ID"
        '
        'lblSectionsList
        '
        Me.lblSectionsList.AutoSize = True
        Me.lblSectionsList.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSectionsList.ForeColor = System.Drawing.Color.White
        Me.lblSectionsList.Location = New System.Drawing.Point(28, 29)
        Me.lblSectionsList.Name = "lblSectionsList"
        Me.lblSectionsList.Size = New System.Drawing.Size(117, 25)
        Me.lblSectionsList.TabIndex = 2
        Me.lblSectionsList.Text = "Sections List"
        '
        'btnSectionSearch
        '
        Me.btnSectionSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSectionSearch.Location = New System.Drawing.Point(569, 585)
        Me.btnSectionSearch.Name = "btnSectionSearch"
        Me.btnSectionSearch.Size = New System.Drawing.Size(90, 35)
        Me.btnSectionSearch.TabIndex = 1
        Me.btnSectionSearch.Text = "Search"
        Me.btnSectionSearch.UseVisualStyleBackColor = True
        '
        'picWatermark
        '
        Me.picWatermark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(238, 79)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(520, 466)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 5
        Me.picWatermark.TabStop = False
        '
        'cbxManSecStatus
        '
        Me.cbxManSecStatus.FormattingEnabled = True
        Me.cbxManSecStatus.Location = New System.Drawing.Point(474, 84)
        Me.cbxManSecStatus.Name = "cbxManSecStatus"
        Me.cbxManSecStatus.Size = New System.Drawing.Size(154, 24)
        Me.cbxManSecStatus.TabIndex = 37
        '
        'AdminManageSections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 630)
        Me.Controls.Add(Me.pnlManSecContent)
        Me.Controls.Add(Me.pnlSidebar)
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
    Friend WithEvents lblManSecSchedule As Label
    Friend WithEvents txtbxSecSchedule As TextBox
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
    Friend WithEvents TextBoxStudentSearch As TextBox
    Friend WithEvents cbxManSecStatus As ComboBox
End Class
