<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherViewAssignedSubjects
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
        Me.pnlTeacherSidebar = New System.Windows.Forms.Panel()
        Me.flowButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnTeacherViewStudents = New System.Windows.Forms.Button()
        Me.btnViewAssignedSubjects = New System.Windows.Forms.Button()
        Me.btnTeacherGenerateReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlManSubContent = New System.Windows.Forms.Panel()
        Me.TextBoxSubjectSearch = New System.Windows.Forms.TextBox()
        Me.dgvSubjectList = New System.Windows.Forms.DataGridView()
        Me.grpSubjectInformation = New System.Windows.Forms.GroupBox()
        Me.dtpManSubEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Enddate = New System.Windows.Forms.Label()
        Me.dtpManSubStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxManSubTeacherID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxSubjectStatus = New System.Windows.Forms.ComboBox()
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
        Me.cmbSubjectCategory = New System.Windows.Forms.ComboBox()
        Me.txtbxManSubSchedule = New System.Windows.Forms.TextBox()
        Me.lblManSubSchedule = New System.Windows.Forms.Label()
        Me.lblManSubCategory = New System.Windows.Forms.Label()
        Me.lblManSubRoomType = New System.Windows.Forms.Label()
        Me.lblManSubGradeLevel = New System.Windows.Forms.Label()
        Me.txtbxManSubSubjectCode = New System.Windows.Forms.TextBox()
        Me.lblManSubSubjectCode = New System.Windows.Forms.Label()
        Me.lblSubjectList = New System.Windows.Forms.Label()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.pnlTeacherSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
        Me.pnlManSubContent.SuspendLayout()
        CType(Me.dgvSubjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSubjectInformation.SuspendLayout()
        CType(Me.nudManSubGradeLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTeacherSidebar
        '
        Me.pnlTeacherSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlTeacherSidebar.Controls.Add(Me.flowButtons)
        Me.pnlTeacherSidebar.Controls.Add(Me.btnLogout)
        Me.pnlTeacherSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTeacherSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTeacherSidebar.Name = "pnlTeacherSidebar"
        Me.pnlTeacherSidebar.Padding = New System.Windows.Forms.Padding(30, 40, 30, 40)
        Me.pnlTeacherSidebar.Size = New System.Drawing.Size(300, 800)
        Me.pnlTeacherSidebar.TabIndex = 14
        '
        'flowButtons
        '
        Me.flowButtons.BackColor = System.Drawing.Color.Transparent
        Me.flowButtons.Controls.Add(Me.btnTeacherViewStudents)
        Me.flowButtons.Controls.Add(Me.btnViewAssignedSubjects)
        Me.flowButtons.Controls.Add(Me.btnTeacherGenerateReports)
        Me.flowButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowButtons.Location = New System.Drawing.Point(30, 40)
        Me.flowButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.flowButtons.Name = "flowButtons"
        Me.flowButtons.Size = New System.Drawing.Size(240, 670)
        Me.flowButtons.TabIndex = 0
        Me.flowButtons.WrapContents = False
        '
        'btnTeacherViewStudents
        '
        Me.btnTeacherViewStudents.Location = New System.Drawing.Point(0, 0)
        Me.btnTeacherViewStudents.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnTeacherViewStudents.Name = "btnTeacherViewStudents"
        Me.btnTeacherViewStudents.Size = New System.Drawing.Size(240, 45)
        Me.btnTeacherViewStudents.TabIndex = 4
        Me.btnTeacherViewStudents.Text = "View Students"
        Me.btnTeacherViewStudents.UseVisualStyleBackColor = True
        '
        'btnViewAssignedSubjects
        '
        Me.btnViewAssignedSubjects.Location = New System.Drawing.Point(0, 63)
        Me.btnViewAssignedSubjects.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnViewAssignedSubjects.Name = "btnViewAssignedSubjects"
        Me.btnViewAssignedSubjects.Size = New System.Drawing.Size(240, 45)
        Me.btnViewAssignedSubjects.TabIndex = 5
        Me.btnViewAssignedSubjects.Text = "View Assigned Subjects"
        Me.btnViewAssignedSubjects.UseVisualStyleBackColor = True
        '
        'btnTeacherGenerateReports
        '
        Me.btnTeacherGenerateReports.Location = New System.Drawing.Point(0, 126)
        Me.btnTeacherGenerateReports.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnTeacherGenerateReports.Name = "btnTeacherGenerateReports"
        Me.btnTeacherGenerateReports.Size = New System.Drawing.Size(240, 45)
        Me.btnTeacherGenerateReports.TabIndex = 9
        Me.btnTeacherGenerateReports.Text = "Generate Reports"
        Me.btnTeacherGenerateReports.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(30, 710)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(240, 50)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlManSubContent
        '
        Me.pnlManSubContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlManSubContent.Controls.Add(Me.TextBoxSubjectSearch)
        Me.pnlManSubContent.Controls.Add(Me.dgvSubjectList)
        Me.pnlManSubContent.Controls.Add(Me.grpSubjectInformation)
        Me.pnlManSubContent.Controls.Add(Me.lblSubjectList)
        Me.pnlManSubContent.Controls.Add(Me.picWatermark)
        Me.pnlManSubContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlManSubContent.Location = New System.Drawing.Point(300, 0)
        Me.pnlManSubContent.Name = "pnlManSubContent"
        Me.pnlManSubContent.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlManSubContent.Size = New System.Drawing.Size(1143, 800)
        Me.pnlManSubContent.TabIndex = 15
        '
        'TextBoxSubjectSearch
        '
        Me.TextBoxSubjectSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSubjectSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSubjectSearch.Location = New System.Drawing.Point(924, 759)
        Me.TextBoxSubjectSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSubjectSearch.MaxLength = 50
        Me.TextBoxSubjectSearch.Name = "TextBoxSubjectSearch"
        Me.TextBoxSubjectSearch.Size = New System.Drawing.Size(186, 30)
        Me.TextBoxSubjectSearch.TabIndex = 11
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
        Me.dgvSubjectList.Location = New System.Drawing.Point(33, 388)
        Me.dgvSubjectList.Name = "dgvSubjectList"
        Me.dgvSubjectList.ReadOnly = True
        Me.dgvSubjectList.RowHeadersVisible = False
        Me.dgvSubjectList.RowHeadersWidth = 51
        Me.dgvSubjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubjectList.Size = New System.Drawing.Size(1077, 347)
        Me.dgvSubjectList.TabIndex = 6
        '
        'grpSubjectInformation
        '
        Me.grpSubjectInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSubjectInformation.BackColor = System.Drawing.Color.Gainsboro
        Me.grpSubjectInformation.Controls.Add(Me.dtpManSubEndDate)
        Me.grpSubjectInformation.Controls.Add(Me.Enddate)
        Me.grpSubjectInformation.Controls.Add(Me.dtpManSubStartDate)
        Me.grpSubjectInformation.Controls.Add(Me.Label3)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubTeacherID)
        Me.grpSubjectInformation.Controls.Add(Me.Label2)
        Me.grpSubjectInformation.Controls.Add(Me.ComboBoxSubjectStatus)
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
        Me.grpSubjectInformation.Controls.Add(Me.cmbSubjectCategory)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubSchedule)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubSchedule)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubCategory)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubRoomType)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubGradeLevel)
        Me.grpSubjectInformation.Controls.Add(Me.txtbxManSubSubjectCode)
        Me.grpSubjectInformation.Controls.Add(Me.lblManSubSubjectCode)
        Me.grpSubjectInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSubjectInformation.Location = New System.Drawing.Point(33, 79)
        Me.grpSubjectInformation.Name = "grpSubjectInformation"
        Me.grpSubjectInformation.Size = New System.Drawing.Size(1077, 288)
        Me.grpSubjectInformation.TabIndex = 3
        Me.grpSubjectInformation.TabStop = False
        Me.grpSubjectInformation.Text = "Subject Information"
        '
        'dtpManSubEndDate
        '
        Me.dtpManSubEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpManSubEndDate.Location = New System.Drawing.Point(491, 133)
        Me.dtpManSubEndDate.Name = "dtpManSubEndDate"
        Me.dtpManSubEndDate.Size = New System.Drawing.Size(103, 23)
        Me.dtpManSubEndDate.TabIndex = 50
        '
        'Enddate
        '
        Me.Enddate.AutoSize = True
        Me.Enddate.Location = New System.Drawing.Point(488, 113)
        Me.Enddate.Name = "Enddate"
        Me.Enddate.Size = New System.Drawing.Size(67, 17)
        Me.Enddate.TabIndex = 49
        Me.Enddate.Text = "End Date"
        '
        'dtpManSubStartDate
        '
        Me.dtpManSubStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpManSubStartDate.Location = New System.Drawing.Point(491, 87)
        Me.dtpManSubStartDate.Name = "dtpManSubStartDate"
        Me.dtpManSubStartDate.Size = New System.Drawing.Size(103, 23)
        Me.dtpManSubStartDate.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(488, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Start Date"
        '
        'txtbxManSubTeacherID
        '
        Me.txtbxManSubTeacherID.Location = New System.Drawing.Point(651, 37)
        Me.txtbxManSubTeacherID.Name = "txtbxManSubTeacherID"
        Me.txtbxManSubTeacherID.Size = New System.Drawing.Size(180, 23)
        Me.txtbxManSubTeacherID.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(648, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Teacher ID"
        '
        'ComboBoxSubjectStatus
        '
        Me.ComboBoxSubjectStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSubjectStatus.FormattingEnabled = True
        Me.ComboBoxSubjectStatus.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxSubjectStatus.Location = New System.Drawing.Point(367, 85)
        Me.ComboBoxSubjectStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxSubjectStatus.Name = "ComboBoxSubjectStatus"
        Me.ComboBoxSubjectStatus.Size = New System.Drawing.Size(84, 24)
        Me.ComboBoxSubjectStatus.TabIndex = 44
        '
        'cbxManSubRoomType
        '
        Me.cbxManSubRoomType.FormattingEnabled = True
        Me.cbxManSubRoomType.Location = New System.Drawing.Point(279, 132)
        Me.cbxManSubRoomType.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxManSubRoomType.Name = "cbxManSubRoomType"
        Me.cbxManSubRoomType.Size = New System.Drawing.Size(180, 24)
        Me.cbxManSubRoomType.TabIndex = 37
        '
        'txtbxManSubSubjectName
        '
        Me.txtbxManSubSubjectName.Location = New System.Drawing.Point(55, 86)
        Me.txtbxManSubSubjectName.Name = "txtbxManSubSubjectName"
        Me.txtbxManSubSubjectName.Size = New System.Drawing.Size(190, 23)
        Me.txtbxManSubSubjectName.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Subject Name"
        '
        'txtbxManSubDescription
        '
        Me.txtbxManSubDescription.Location = New System.Drawing.Point(55, 187)
        Me.txtbxManSubDescription.Multiline = True
        Me.txtbxManSubDescription.Name = "txtbxManSubDescription"
        Me.txtbxManSubDescription.Size = New System.Drawing.Size(192, 76)
        Me.txtbxManSubDescription.TabIndex = 34
        '
        'lblManSubDescription
        '
        Me.lblManSubDescription.AutoSize = True
        Me.lblManSubDescription.Location = New System.Drawing.Point(52, 165)
        Me.lblManSubDescription.Name = "lblManSubDescription"
        Me.lblManSubDescription.Size = New System.Drawing.Size(79, 17)
        Me.lblManSubDescription.TabIndex = 33
        Me.lblManSubDescription.Text = "Description"
        '
        'txtbxManSubLearningMaterials
        '
        Me.txtbxManSubLearningMaterials.Location = New System.Drawing.Point(279, 187)
        Me.txtbxManSubLearningMaterials.Multiline = True
        Me.txtbxManSubLearningMaterials.Name = "txtbxManSubLearningMaterials"
        Me.txtbxManSubLearningMaterials.Size = New System.Drawing.Size(180, 76)
        Me.txtbxManSubLearningMaterials.TabIndex = 32
        '
        'lblManSubLearningMaterials
        '
        Me.lblManSubLearningMaterials.AutoSize = True
        Me.lblManSubLearningMaterials.Location = New System.Drawing.Point(276, 165)
        Me.lblManSubLearningMaterials.Name = "lblManSubLearningMaterials"
        Me.lblManSubLearningMaterials.Size = New System.Drawing.Size(125, 17)
        Me.lblManSubLearningMaterials.TabIndex = 31
        Me.lblManSubLearningMaterials.Text = "Learning Materials"
        '
        'dtpManSubDateCreated
        '
        Me.dtpManSubDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpManSubDateCreated.Location = New System.Drawing.Point(491, 187)
        Me.dtpManSubDateCreated.Name = "dtpManSubDateCreated"
        Me.dtpManSubDateCreated.Size = New System.Drawing.Size(103, 23)
        Me.dtpManSubDateCreated.TabIndex = 7
        '
        'lblManSecDateCreated
        '
        Me.lblManSecDateCreated.AutoSize = True
        Me.lblManSecDateCreated.Location = New System.Drawing.Point(488, 167)
        Me.lblManSecDateCreated.Name = "lblManSecDateCreated"
        Me.lblManSecDateCreated.Size = New System.Drawing.Size(92, 17)
        Me.lblManSecDateCreated.TabIndex = 4
        Me.lblManSecDateCreated.Text = "Date Created"
        '
        'txtbxManSubSkillFocus
        '
        Me.txtbxManSubSkillFocus.Location = New System.Drawing.Point(279, 37)
        Me.txtbxManSubSkillFocus.Name = "txtbxManSubSkillFocus"
        Me.txtbxManSubSkillFocus.Size = New System.Drawing.Size(180, 23)
        Me.txtbxManSubSkillFocus.TabIndex = 13
        '
        'txtbxManSubCreatedBy
        '
        Me.txtbxManSubCreatedBy.Location = New System.Drawing.Point(491, 240)
        Me.txtbxManSubCreatedBy.Name = "txtbxManSubCreatedBy"
        Me.txtbxManSubCreatedBy.Size = New System.Drawing.Size(161, 23)
        Me.txtbxManSubCreatedBy.TabIndex = 1
        '
        'lblManSubSkillFocus
        '
        Me.lblManSubSkillFocus.AutoSize = True
        Me.lblManSubSkillFocus.Location = New System.Drawing.Point(276, 17)
        Me.lblManSubSkillFocus.Name = "lblManSubSkillFocus"
        Me.lblManSubSkillFocus.Size = New System.Drawing.Size(75, 17)
        Me.lblManSubSkillFocus.TabIndex = 12
        Me.lblManSubSkillFocus.Text = "Skill Focus"
        '
        'lblManSubCreatedBy
        '
        Me.lblManSubCreatedBy.AutoSize = True
        Me.lblManSubCreatedBy.Location = New System.Drawing.Point(488, 219)
        Me.lblManSubCreatedBy.Name = "lblManSubCreatedBy"
        Me.lblManSubCreatedBy.Size = New System.Drawing.Size(78, 17)
        Me.lblManSubCreatedBy.TabIndex = 0
        Me.lblManSubCreatedBy.Text = "Created By"
        '
        'nudManSubGradeLevel
        '
        Me.nudManSubGradeLevel.Location = New System.Drawing.Point(300, 84)
        Me.nudManSubGradeLevel.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudManSubGradeLevel.Name = "nudManSubGradeLevel"
        Me.nudManSubGradeLevel.Size = New System.Drawing.Size(35, 23)
        Me.nudManSubGradeLevel.TabIndex = 27
        '
        'lblManSubStatus
        '
        Me.lblManSubStatus.AutoSize = True
        Me.lblManSubStatus.Location = New System.Drawing.Point(381, 67)
        Me.lblManSubStatus.Name = "lblManSubStatus"
        Me.lblManSubStatus.Size = New System.Drawing.Size(48, 17)
        Me.lblManSubStatus.TabIndex = 26
        Me.lblManSubStatus.Text = "Status"
        '
        'cmbSubjectCategory
        '
        Me.cmbSubjectCategory.FormattingEnabled = True
        Me.cmbSubjectCategory.Location = New System.Drawing.Point(55, 132)
        Me.cmbSubjectCategory.Name = "cmbSubjectCategory"
        Me.cmbSubjectCategory.Size = New System.Drawing.Size(192, 24)
        Me.cmbSubjectCategory.TabIndex = 23
        '
        'txtbxManSubSchedule
        '
        Me.txtbxManSubSchedule.Location = New System.Drawing.Point(491, 37)
        Me.txtbxManSubSchedule.Name = "txtbxManSubSchedule"
        Me.txtbxManSubSchedule.Size = New System.Drawing.Size(133, 23)
        Me.txtbxManSubSchedule.TabIndex = 10
        '
        'lblManSubSchedule
        '
        Me.lblManSubSchedule.AutoSize = True
        Me.lblManSubSchedule.Location = New System.Drawing.Point(491, 17)
        Me.lblManSubSchedule.Name = "lblManSubSchedule"
        Me.lblManSubSchedule.Size = New System.Drawing.Size(67, 17)
        Me.lblManSubSchedule.TabIndex = 11
        Me.lblManSubSchedule.Text = "Schedule"
        '
        'lblManSubCategory
        '
        Me.lblManSubCategory.AutoSize = True
        Me.lblManSubCategory.Location = New System.Drawing.Point(52, 114)
        Me.lblManSubCategory.Name = "lblManSubCategory"
        Me.lblManSubCategory.Size = New System.Drawing.Size(65, 17)
        Me.lblManSubCategory.TabIndex = 19
        Me.lblManSubCategory.Text = "Category"
        '
        'lblManSubRoomType
        '
        Me.lblManSubRoomType.AutoSize = True
        Me.lblManSubRoomType.Location = New System.Drawing.Point(276, 115)
        Me.lblManSubRoomType.Name = "lblManSubRoomType"
        Me.lblManSubRoomType.Size = New System.Drawing.Size(81, 17)
        Me.lblManSubRoomType.TabIndex = 13
        Me.lblManSubRoomType.Text = "Room Type"
        '
        'lblManSubGradeLevel
        '
        Me.lblManSubGradeLevel.AutoSize = True
        Me.lblManSubGradeLevel.Location = New System.Drawing.Point(275, 67)
        Me.lblManSubGradeLevel.Name = "lblManSubGradeLevel"
        Me.lblManSubGradeLevel.Size = New System.Drawing.Size(86, 17)
        Me.lblManSubGradeLevel.TabIndex = 9
        Me.lblManSubGradeLevel.Text = "Grade Level"
        '
        'txtbxManSubSubjectCode
        '
        Me.txtbxManSubSubjectCode.Location = New System.Drawing.Point(55, 37)
        Me.txtbxManSubSubjectCode.Name = "txtbxManSubSubjectCode"
        Me.txtbxManSubSubjectCode.Size = New System.Drawing.Size(190, 23)
        Me.txtbxManSubSubjectCode.TabIndex = 4
        '
        'lblManSubSubjectCode
        '
        Me.lblManSubSubjectCode.AutoSize = True
        Me.lblManSubSubjectCode.Location = New System.Drawing.Point(52, 18)
        Me.lblManSubSubjectCode.Name = "lblManSubSubjectCode"
        Me.lblManSubSubjectCode.Size = New System.Drawing.Size(92, 17)
        Me.lblManSubSubjectCode.TabIndex = 3
        Me.lblManSubSubjectCode.Text = "Subject Code"
        '
        'lblSubjectList
        '
        Me.lblSubjectList.AutoSize = True
        Me.lblSubjectList.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubjectList.ForeColor = System.Drawing.Color.White
        Me.lblSubjectList.Location = New System.Drawing.Point(28, 29)
        Me.lblSubjectList.Name = "lblSubjectList"
        Me.lblSubjectList.Size = New System.Drawing.Size(109, 25)
        Me.lblSubjectList.TabIndex = 2
        Me.lblSubjectList.Text = "Subject List"
        '
        'picWatermark
        '
        Me.picWatermark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(355, 255)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(418, 372)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 5
        Me.picWatermark.TabStop = False
        '
        'TeacherViewAssignedSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 800)
        Me.Controls.Add(Me.pnlManSubContent)
        Me.Controls.Add(Me.pnlTeacherSidebar)
        Me.Name = "TeacherViewAssignedSubjects"
        Me.Text = "TeacherViewAssignedSubjects"
        Me.pnlTeacherSidebar.ResumeLayout(False)
        Me.flowButtons.ResumeLayout(False)
        Me.pnlManSubContent.ResumeLayout(False)
        Me.pnlManSubContent.PerformLayout()
        CType(Me.dgvSubjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSubjectInformation.ResumeLayout(False)
        Me.grpSubjectInformation.PerformLayout()
        CType(Me.nudManSubGradeLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTeacherSidebar As Panel
    Friend WithEvents flowButtons As FlowLayoutPanel
    Friend WithEvents btnTeacherViewStudents As Button
    Friend WithEvents btnViewAssignedSubjects As Button
    Friend WithEvents btnTeacherGenerateReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlManSubContent As Panel
    Friend WithEvents TextBoxSubjectSearch As TextBox
    Friend WithEvents dgvSubjectList As DataGridView
    Friend WithEvents grpSubjectInformation As GroupBox
    Friend WithEvents dtpManSubEndDate As DateTimePicker
    Friend WithEvents Enddate As Label
    Friend WithEvents dtpManSubStartDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxManSubTeacherID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxSubjectStatus As ComboBox
    Friend WithEvents cbxManSubRoomType As ComboBox
    Friend WithEvents txtbxManSubSubjectName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxManSubDescription As TextBox
    Friend WithEvents lblManSubDescription As Label
    Friend WithEvents txtbxManSubLearningMaterials As TextBox
    Friend WithEvents lblManSubLearningMaterials As Label
    Friend WithEvents dtpManSubDateCreated As DateTimePicker
    Friend WithEvents lblManSecDateCreated As Label
    Friend WithEvents txtbxManSubSkillFocus As TextBox
    Friend WithEvents txtbxManSubCreatedBy As TextBox
    Friend WithEvents lblManSubSkillFocus As Label
    Friend WithEvents lblManSubCreatedBy As Label
    Friend WithEvents nudManSubGradeLevel As NumericUpDown
    Friend WithEvents lblManSubStatus As Label
    Friend WithEvents cmbSubjectCategory As ComboBox
    Friend WithEvents txtbxManSubSchedule As TextBox
    Friend WithEvents lblManSubSchedule As Label
    Friend WithEvents lblManSubCategory As Label
    Friend WithEvents lblManSubRoomType As Label
    Friend WithEvents lblManSubGradeLevel As Label
    Friend WithEvents txtbxManSubSubjectCode As TextBox
    Friend WithEvents lblManSubSubjectCode As Label
    Friend WithEvents lblSubjectList As Label
    Friend WithEvents picWatermark As PictureBox
End Class
