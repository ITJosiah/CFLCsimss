<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminManageStudents
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
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.TextBoxStudentSearch = New System.Windows.Forms.TextBox()
        Me.btnStudentDelete = New System.Windows.Forms.Button()
        Me.btnStudentUpdate = New System.Windows.Forms.Button()
        Me.btnStudentAdd = New System.Windows.Forms.Button()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.grpStudentInfo = New System.Windows.Forms.GroupBox()
        Me.txtbxGuardianContactNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxStudentIPNo = New System.Windows.Forms.CheckBox()
        Me.cbxStudentIPYes = New System.Windows.Forms.CheckBox()
        Me.txtbbxStudentIPGroup = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbxStudentMotherTongue = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbxStudentLRN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxStudentPOB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxStudentExtension = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudStudentGradeLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblStudentEnrollmentID = New System.Windows.Forms.Label()
        Me.nudStudentAge = New System.Windows.Forms.NumericUpDown()
        Me.cmbStudenttGender = New System.Windows.Forms.ComboBox()
        Me.dtpStudentBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblStudentGender = New System.Windows.Forms.Label()
        Me.lblStudentAge = New System.Windows.Forms.Label()
        Me.txtbxGuardianName = New System.Windows.Forms.TextBox()
        Me.lblStudentGuardianName = New System.Windows.Forms.Label()
        Me.txtbxStudentReligion = New System.Windows.Forms.TextBox()
        Me.lblStudentReligion = New System.Windows.Forms.Label()
        Me.txtbxStudentEnrollmentID = New System.Windows.Forms.TextBox()
        Me.lblStudentGradeLevel = New System.Windows.Forms.Label()
        Me.txtbxStudentSurname = New System.Windows.Forms.TextBox()
        Me.lblStudentSurname = New System.Windows.Forms.Label()
        Me.txtStudentMiddleName = New System.Windows.Forms.TextBox()
        Me.lblStudentMiddleName = New System.Windows.Forms.Label()
        Me.txtbxStudentFirstName = New System.Windows.Forms.TextBox()
        Me.lblStudentFirstName = New System.Windows.Forms.Label()
        Me.lblStudentList = New System.Windows.Forms.Label()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbx4psNo = New System.Windows.Forms.CheckBox()
        Me.cbx4psYes = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbx4ps = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbxStudentBarangay = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbxstudentStreet = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbxStudentHouseNo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbxCountry = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtbxStudentProvince = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtbxStudentCity = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtbxZipCode = New System.Windows.Forms.TextBox()
        Me.pnlSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStudentInfo.SuspendLayout()
        CType(Me.nudStudentGradeLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStudentAge, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlSidebar.Size = New System.Drawing.Size(300, 800)
        Me.pnlSidebar.TabIndex = 11
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
        Me.flowButtons.Size = New System.Drawing.Size(240, 670)
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
        Me.btnLogout.Location = New System.Drawing.Point(30, 710)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(240, 50)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.TextBoxStudentSearch)
        Me.pnlContent.Controls.Add(Me.btnStudentDelete)
        Me.pnlContent.Controls.Add(Me.btnStudentUpdate)
        Me.pnlContent.Controls.Add(Me.btnStudentAdd)
        Me.pnlContent.Controls.Add(Me.dgvStudents)
        Me.pnlContent.Controls.Add(Me.grpStudentInfo)
        Me.pnlContent.Controls.Add(Me.lblStudentList)
        Me.pnlContent.Controls.Add(Me.picWatermark)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(300, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlContent.Size = New System.Drawing.Size(1157, 800)
        Me.pnlContent.TabIndex = 1
        '
        'TextBoxStudentSearch
        '
        Me.TextBoxStudentSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxStudentSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxStudentSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentSearch.Location = New System.Drawing.Point(638, 754)
        Me.TextBoxStudentSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxStudentSearch.MaxLength = 50
        Me.TextBoxStudentSearch.Name = "TextBoxStudentSearch"
        Me.TextBoxStudentSearch.Size = New System.Drawing.Size(186, 30)
        Me.TextBoxStudentSearch.TabIndex = 10
        '
        'btnStudentDelete
        '
        Me.btnStudentDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStudentDelete.Location = New System.Drawing.Point(1065, 752)
        Me.btnStudentDelete.Name = "btnStudentDelete"
        Me.btnStudentDelete.Size = New System.Drawing.Size(86, 35)
        Me.btnStudentDelete.TabIndex = 9
        Me.btnStudentDelete.Text = "Delete"
        Me.btnStudentDelete.UseVisualStyleBackColor = True
        '
        'btnStudentUpdate
        '
        Me.btnStudentUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStudentUpdate.Location = New System.Drawing.Point(953, 752)
        Me.btnStudentUpdate.Name = "btnStudentUpdate"
        Me.btnStudentUpdate.Size = New System.Drawing.Size(86, 35)
        Me.btnStudentUpdate.TabIndex = 8
        Me.btnStudentUpdate.Text = "Update"
        Me.btnStudentUpdate.UseVisualStyleBackColor = True
        '
        'btnStudentAdd
        '
        Me.btnStudentAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStudentAdd.Location = New System.Drawing.Point(841, 752)
        Me.btnStudentAdd.Name = "btnStudentAdd"
        Me.btnStudentAdd.Size = New System.Drawing.Size(86, 35)
        Me.btnStudentAdd.TabIndex = 7
        Me.btnStudentAdd.Text = "Add"
        Me.btnStudentAdd.UseVisualStyleBackColor = True
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(33, 620)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersVisible = False
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(1091, 126)
        Me.dgvStudents.TabIndex = 6
        '
        'grpStudentInfo
        '
        Me.grpStudentInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStudentInfo.BackColor = System.Drawing.Color.Gainsboro
        Me.grpStudentInfo.Controls.Add(Me.txtbxZipCode)
        Me.grpStudentInfo.Controls.Add(Me.Label18)
        Me.grpStudentInfo.Controls.Add(Me.txtbxCountry)
        Me.grpStudentInfo.Controls.Add(Me.Label15)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentProvince)
        Me.grpStudentInfo.Controls.Add(Me.Label16)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentCity)
        Me.grpStudentInfo.Controls.Add(Me.Label17)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentBarangay)
        Me.grpStudentInfo.Controls.Add(Me.Label12)
        Me.grpStudentInfo.Controls.Add(Me.txtbxstudentStreet)
        Me.grpStudentInfo.Controls.Add(Me.Label13)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentHouseNo)
        Me.grpStudentInfo.Controls.Add(Me.Label14)
        Me.grpStudentInfo.Controls.Add(Me.Label10)
        Me.grpStudentInfo.Controls.Add(Me.txtbx4ps)
        Me.grpStudentInfo.Controls.Add(Me.Label8)
        Me.grpStudentInfo.Controls.Add(Me.cbx4psNo)
        Me.grpStudentInfo.Controls.Add(Me.cbx4psYes)
        Me.grpStudentInfo.Controls.Add(Me.Label9)
        Me.grpStudentInfo.Controls.Add(Me.txtbxGuardianContactNo)
        Me.grpStudentInfo.Controls.Add(Me.Label7)
        Me.grpStudentInfo.Controls.Add(Me.Label6)
        Me.grpStudentInfo.Controls.Add(Me.cbxStudentIPNo)
        Me.grpStudentInfo.Controls.Add(Me.cbxStudentIPYes)
        Me.grpStudentInfo.Controls.Add(Me.txtbbxStudentIPGroup)
        Me.grpStudentInfo.Controls.Add(Me.Label5)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentMotherTongue)
        Me.grpStudentInfo.Controls.Add(Me.Label4)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentLRN)
        Me.grpStudentInfo.Controls.Add(Me.Label3)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentPOB)
        Me.grpStudentInfo.Controls.Add(Me.Label2)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentExtension)
        Me.grpStudentInfo.Controls.Add(Me.Label1)
        Me.grpStudentInfo.Controls.Add(Me.nudStudentGradeLevel)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentEnrollmentID)
        Me.grpStudentInfo.Controls.Add(Me.nudStudentAge)
        Me.grpStudentInfo.Controls.Add(Me.cmbStudenttGender)
        Me.grpStudentInfo.Controls.Add(Me.dtpStudentBirthdate)
        Me.grpStudentInfo.Controls.Add(Me.Label11)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentGender)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentAge)
        Me.grpStudentInfo.Controls.Add(Me.txtbxGuardianName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentGuardianName)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentReligion)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentReligion)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentEnrollmentID)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentGradeLevel)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentSurname)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentSurname)
        Me.grpStudentInfo.Controls.Add(Me.txtStudentMiddleName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentMiddleName)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentFirstName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentFirstName)
        Me.grpStudentInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStudentInfo.Location = New System.Drawing.Point(33, 79)
        Me.grpStudentInfo.Name = "grpStudentInfo"
        Me.grpStudentInfo.Size = New System.Drawing.Size(1091, 514)
        Me.grpStudentInfo.TabIndex = 3
        Me.grpStudentInfo.TabStop = False
        Me.grpStudentInfo.Text = "Student List"
        '
        'txtbxGuardianContactNo
        '
        Me.txtbxGuardianContactNo.Location = New System.Drawing.Point(731, 232)
        Me.txtbxGuardianContactNo.MaxLength = 50
        Me.txtbxGuardianContactNo.Name = "txtbxGuardianContactNo"
        Me.txtbxGuardianContactNo.Size = New System.Drawing.Size(143, 23)
        Me.txtbxGuardianContactNo.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(728, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 17)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Guardian Contact Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 17)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "If Yes, please specify:"
        '
        'cbxStudentIPNo
        '
        Me.cbxStudentIPNo.AutoSize = True
        Me.cbxStudentIPNo.Location = New System.Drawing.Point(112, 237)
        Me.cbxStudentIPNo.Name = "cbxStudentIPNo"
        Me.cbxStudentIPNo.Size = New System.Drawing.Size(45, 21)
        Me.cbxStudentIPNo.TabIndex = 39
        Me.cbxStudentIPNo.Text = "No"
        Me.cbxStudentIPNo.UseVisualStyleBackColor = True
        '
        'cbxStudentIPYes
        '
        Me.cbxStudentIPYes.AutoSize = True
        Me.cbxStudentIPYes.Location = New System.Drawing.Point(55, 237)
        Me.cbxStudentIPYes.Name = "cbxStudentIPYes"
        Me.cbxStudentIPYes.Size = New System.Drawing.Size(51, 21)
        Me.cbxStudentIPYes.TabIndex = 38
        Me.cbxStudentIPYes.Text = "Yes"
        Me.cbxStudentIPYes.UseVisualStyleBackColor = True
        '
        'txtbbxStudentIPGroup
        '
        Me.txtbbxStudentIPGroup.Location = New System.Drawing.Point(314, 235)
        Me.txtbbxStudentIPGroup.MaxLength = 50
        Me.txtbbxStudentIPGroup.Name = "txtbbxStudentIPGroup"
        Me.txtbbxStudentIPGroup.Size = New System.Drawing.Size(198, 23)
        Me.txtbbxStudentIPGroup.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(345, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Belonging to any Indigineous People (IP) Community?"
        '
        'txtbxStudentMotherTongue
        '
        Me.txtbxStudentMotherTongue.Location = New System.Drawing.Point(555, 129)
        Me.txtbxStudentMotherTongue.MaxLength = 50
        Me.txtbxStudentMotherTongue.Name = "txtbxStudentMotherTongue"
        Me.txtbxStudentMotherTongue.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentMotherTongue.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(552, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Mother Tongue"
        '
        'txtbxStudentLRN
        '
        Me.txtbxStudentLRN.Location = New System.Drawing.Point(555, 35)
        Me.txtbxStudentLRN.MaxLength = 50
        Me.txtbxStudentLRN.Name = "txtbxStudentLRN"
        Me.txtbxStudentLRN.Size = New System.Drawing.Size(222, 23)
        Me.txtbxStudentLRN.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(552, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Learner Reference No. (LRN) If applicable:"
        '
        'txtbxStudentPOB
        '
        Me.txtbxStudentPOB.Location = New System.Drawing.Point(309, 129)
        Me.txtbxStudentPOB.MaxLength = 20
        Me.txtbxStudentPOB.Name = "txtbxStudentPOB"
        Me.txtbxStudentPOB.Size = New System.Drawing.Size(181, 23)
        Me.txtbxStudentPOB.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Place of Birth (City/Municipality)"
        '
        'txtbxStudentExtension
        '
        Me.txtbxStudentExtension.Location = New System.Drawing.Point(55, 175)
        Me.txtbxStudentExtension.MaxLength = 50
        Me.txtbxStudentExtension.Name = "txtbxStudentExtension"
        Me.txtbxStudentExtension.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentExtension.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Extension (Jr. III,  etc.)"
        '
        'nudStudentGradeLevel
        '
        Me.nudStudentGradeLevel.Location = New System.Drawing.Point(438, 33)
        Me.nudStudentGradeLevel.Name = "nudStudentGradeLevel"
        Me.nudStudentGradeLevel.Size = New System.Drawing.Size(35, 23)
        Me.nudStudentGradeLevel.TabIndex = 27
        '
        'lblStudentEnrollmentID
        '
        Me.lblStudentEnrollmentID.AutoSize = True
        Me.lblStudentEnrollmentID.Location = New System.Drawing.Point(552, 64)
        Me.lblStudentEnrollmentID.Name = "lblStudentEnrollmentID"
        Me.lblStudentEnrollmentID.Size = New System.Drawing.Size(92, 17)
        Me.lblStudentEnrollmentID.TabIndex = 26
        Me.lblStudentEnrollmentID.Text = "Enrollment ID"
        '
        'nudStudentAge
        '
        Me.nudStudentAge.Location = New System.Drawing.Point(308, 84)
        Me.nudStudentAge.Name = "nudStudentAge"
        Me.nudStudentAge.Size = New System.Drawing.Size(35, 23)
        Me.nudStudentAge.TabIndex = 24
        '
        'cmbStudenttGender
        '
        Me.cmbStudenttGender.FormattingEnabled = True
        Me.cmbStudenttGender.Location = New System.Drawing.Point(386, 82)
        Me.cmbStudenttGender.Name = "cmbStudenttGender"
        Me.cmbStudenttGender.Size = New System.Drawing.Size(91, 24)
        Me.cmbStudenttGender.TabIndex = 23
        '
        'dtpStudentBirthdate
        '
        Me.dtpStudentBirthdate.Checked = False
        Me.dtpStudentBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStudentBirthdate.Location = New System.Drawing.Point(308, 33)
        Me.dtpStudentBirthdate.Name = "dtpStudentBirthdate"
        Me.dtpStudentBirthdate.Size = New System.Drawing.Size(85, 23)
        Me.dtpStudentBirthdate.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(305, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Birthdate"
        '
        'lblStudentGender
        '
        Me.lblStudentGender.AutoSize = True
        Me.lblStudentGender.Location = New System.Drawing.Point(383, 64)
        Me.lblStudentGender.Name = "lblStudentGender"
        Me.lblStudentGender.Size = New System.Drawing.Size(31, 17)
        Me.lblStudentGender.TabIndex = 19
        Me.lblStudentGender.Text = "Sex"
        '
        'lblStudentAge
        '
        Me.lblStudentAge.AutoSize = True
        Me.lblStudentAge.Location = New System.Drawing.Point(305, 64)
        Me.lblStudentAge.Name = "lblStudentAge"
        Me.lblStudentAge.Size = New System.Drawing.Size(33, 17)
        Me.lblStudentAge.TabIndex = 17
        Me.lblStudentAge.Text = "Age"
        '
        'txtbxGuardianName
        '
        Me.txtbxGuardianName.Location = New System.Drawing.Point(549, 232)
        Me.txtbxGuardianName.MaxLength = 50
        Me.txtbxGuardianName.Name = "txtbxGuardianName"
        Me.txtbxGuardianName.Size = New System.Drawing.Size(156, 23)
        Me.txtbxGuardianName.TabIndex = 16
        '
        'lblStudentGuardianName
        '
        Me.lblStudentGuardianName.AutoEllipsis = True
        Me.lblStudentGuardianName.AutoSize = True
        Me.lblStudentGuardianName.Location = New System.Drawing.Point(546, 214)
        Me.lblStudentGuardianName.Name = "lblStudentGuardianName"
        Me.lblStudentGuardianName.Size = New System.Drawing.Size(108, 17)
        Me.lblStudentGuardianName.TabIndex = 15
        Me.lblStudentGuardianName.Text = "Guardian Name"
        '
        'txtbxStudentReligion
        '
        Me.txtbxStudentReligion.Location = New System.Drawing.Point(308, 174)
        Me.txtbxStudentReligion.MaxLength = 20
        Me.txtbxStudentReligion.Name = "txtbxStudentReligion"
        Me.txtbxStudentReligion.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentReligion.TabIndex = 14
        '
        'lblStudentReligion
        '
        Me.lblStudentReligion.AutoSize = True
        Me.lblStudentReligion.Location = New System.Drawing.Point(305, 155)
        Me.lblStudentReligion.Name = "lblStudentReligion"
        Me.lblStudentReligion.Size = New System.Drawing.Size(59, 17)
        Me.lblStudentReligion.TabIndex = 13
        Me.lblStudentReligion.Text = "Religion"
        '
        'txtbxStudentEnrollmentID
        '
        Me.txtbxStudentEnrollmentID.Location = New System.Drawing.Point(555, 83)
        Me.txtbxStudentEnrollmentID.Name = "txtbxStudentEnrollmentID"
        Me.txtbxStudentEnrollmentID.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentEnrollmentID.TabIndex = 12
        '
        'lblStudentGradeLevel
        '
        Me.lblStudentGradeLevel.AutoSize = True
        Me.lblStudentGradeLevel.Location = New System.Drawing.Point(417, 13)
        Me.lblStudentGradeLevel.Name = "lblStudentGradeLevel"
        Me.lblStudentGradeLevel.Size = New System.Drawing.Size(86, 17)
        Me.lblStudentGradeLevel.TabIndex = 9
        Me.lblStudentGradeLevel.Text = "Grade Level"
        '
        'txtbxStudentSurname
        '
        Me.txtbxStudentSurname.Location = New System.Drawing.Point(55, 130)
        Me.txtbxStudentSurname.MaxLength = 50
        Me.txtbxStudentSurname.Name = "txtbxStudentSurname"
        Me.txtbxStudentSurname.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentSurname.TabIndex = 6
        '
        'lblStudentSurname
        '
        Me.lblStudentSurname.AutoSize = True
        Me.lblStudentSurname.Location = New System.Drawing.Point(52, 110)
        Me.lblStudentSurname.Name = "lblStudentSurname"
        Me.lblStudentSurname.Size = New System.Drawing.Size(65, 17)
        Me.lblStudentSurname.TabIndex = 5
        Me.lblStudentSurname.Text = "Surname"
        '
        'txtStudentMiddleName
        '
        Me.txtStudentMiddleName.Location = New System.Drawing.Point(55, 84)
        Me.txtStudentMiddleName.MaxLength = 50
        Me.txtStudentMiddleName.Name = "txtStudentMiddleName"
        Me.txtStudentMiddleName.Size = New System.Drawing.Size(190, 23)
        Me.txtStudentMiddleName.TabIndex = 4
        '
        'lblStudentMiddleName
        '
        Me.lblStudentMiddleName.AutoSize = True
        Me.lblStudentMiddleName.Location = New System.Drawing.Point(52, 64)
        Me.lblStudentMiddleName.Name = "lblStudentMiddleName"
        Me.lblStudentMiddleName.Size = New System.Drawing.Size(90, 17)
        Me.lblStudentMiddleName.TabIndex = 3
        Me.lblStudentMiddleName.Text = "Middle Name"
        '
        'txtbxStudentFirstName
        '
        Me.txtbxStudentFirstName.Location = New System.Drawing.Point(55, 37)
        Me.txtbxStudentFirstName.MaxLength = 50
        Me.txtbxStudentFirstName.Name = "txtbxStudentFirstName"
        Me.txtbxStudentFirstName.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentFirstName.TabIndex = 2
        '
        'lblStudentFirstName
        '
        Me.lblStudentFirstName.AutoSize = True
        Me.lblStudentFirstName.Location = New System.Drawing.Point(52, 19)
        Me.lblStudentFirstName.Name = "lblStudentFirstName"
        Me.lblStudentFirstName.Size = New System.Drawing.Size(76, 17)
        Me.lblStudentFirstName.TabIndex = 1
        Me.lblStudentFirstName.Text = "First Name"
        '
        'lblStudentList
        '
        Me.lblStudentList.AutoSize = True
        Me.lblStudentList.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblStudentList.ForeColor = System.Drawing.Color.White
        Me.lblStudentList.Location = New System.Drawing.Point(28, 29)
        Me.lblStudentList.Name = "lblStudentList"
        Me.lblStudentList.Size = New System.Drawing.Size(112, 25)
        Me.lblStudentList.TabIndex = 2
        Me.lblStudentList.Text = "Student List"
        '
        'picWatermark
        '
        Me.picWatermark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(316, 163)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(520, 466)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 5
        Me.picWatermark.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(163, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(328, 17)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "If Yes, please write the 4P's Household ID Number:"
        '
        'cbx4psNo
        '
        Me.cbx4psNo.AutoSize = True
        Me.cbx4psNo.Location = New System.Drawing.Point(112, 290)
        Me.cbx4psNo.Name = "cbx4psNo"
        Me.cbx4psNo.Size = New System.Drawing.Size(45, 21)
        Me.cbx4psNo.TabIndex = 45
        Me.cbx4psNo.Text = "No"
        Me.cbx4psNo.UseVisualStyleBackColor = True
        '
        'cbx4psYes
        '
        Me.cbx4psYes.AutoSize = True
        Me.cbx4psYes.Location = New System.Drawing.Point(55, 290)
        Me.cbx4psYes.Name = "cbx4psYes"
        Me.cbx4psYes.Size = New System.Drawing.Size(51, 21)
        Me.cbx4psYes.TabIndex = 44
        Me.cbx4psYes.Text = "Yes"
        Me.cbx4psYes.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(225, 17)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Is your family a benificiary of 4P's?"
        '
        'txtbx4ps
        '
        Me.txtbx4ps.Location = New System.Drawing.Point(497, 288)
        Me.txtbx4ps.MaxLength = 50
        Me.txtbx4ps.Name = "txtbx4ps"
        Me.txtbx4ps.Size = New System.Drawing.Size(228, 23)
        Me.txtbx4ps.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 17)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Address"
        '
        'txtbxStudentBarangay
        '
        Me.txtbxStudentBarangay.Location = New System.Drawing.Point(55, 456)
        Me.txtbxStudentBarangay.MaxLength = 50
        Me.txtbxStudentBarangay.Name = "txtbxStudentBarangay"
        Me.txtbxStudentBarangay.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentBarangay.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(52, 436)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 17)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Barangay"
        '
        'txtbxstudentStreet
        '
        Me.txtbxstudentStreet.Location = New System.Drawing.Point(55, 410)
        Me.txtbxstudentStreet.MaxLength = 50
        Me.txtbxstudentStreet.Name = "txtbxstudentStreet"
        Me.txtbxstudentStreet.Size = New System.Drawing.Size(190, 23)
        Me.txtbxstudentStreet.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(52, 390)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 17)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Street Name"
        '
        'txtbxStudentHouseNo
        '
        Me.txtbxStudentHouseNo.Location = New System.Drawing.Point(55, 363)
        Me.txtbxStudentHouseNo.MaxLength = 50
        Me.txtbxStudentHouseNo.Name = "txtbxStudentHouseNo"
        Me.txtbxStudentHouseNo.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentHouseNo.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(52, 343)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 17)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "House Number"
        '
        'txtbxCountry
        '
        Me.txtbxCountry.Location = New System.Drawing.Point(322, 456)
        Me.txtbxCountry.MaxLength = 50
        Me.txtbxCountry.Name = "txtbxCountry"
        Me.txtbxCountry.Size = New System.Drawing.Size(190, 23)
        Me.txtbxCountry.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(319, 436)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 17)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Country"
        '
        'txtbxStudentProvince
        '
        Me.txtbxStudentProvince.Location = New System.Drawing.Point(322, 410)
        Me.txtbxStudentProvince.MaxLength = 50
        Me.txtbxStudentProvince.Name = "txtbxStudentProvince"
        Me.txtbxStudentProvince.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentProvince.TabIndex = 58
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(319, 390)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 17)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Province"
        '
        'txtbxStudentCity
        '
        Me.txtbxStudentCity.Location = New System.Drawing.Point(322, 361)
        Me.txtbxStudentCity.MaxLength = 50
        Me.txtbxStudentCity.Name = "txtbxStudentCity"
        Me.txtbxStudentCity.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentCity.TabIndex = 56
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(319, 343)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 17)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "City/Municipality"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(556, 343)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 17)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "ZIP Code"
        '
        'txtbxZipCode
        '
        Me.txtbxZipCode.Location = New System.Drawing.Point(555, 363)
        Me.txtbxZipCode.MaxLength = 50
        Me.txtbxZipCode.Name = "txtbxZipCode"
        Me.txtbxZipCode.Size = New System.Drawing.Size(190, 23)
        Me.txtbxZipCode.TabIndex = 62
        '
        'AdminManageStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1457, 800)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AdminManageStudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminManageStudents"
        Me.pnlSidebar.ResumeLayout(False)
        Me.flowButtons.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStudentInfo.ResumeLayout(False)
        Me.grpStudentInfo.PerformLayout()
        CType(Me.nudStudentGradeLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStudentAge, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pnlContent As Panel
    Friend WithEvents btnStudentDelete As Button
    Friend WithEvents btnStudentUpdate As Button
    Friend WithEvents btnStudentAdd As Button
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents grpStudentInfo As GroupBox
    Friend WithEvents dtpStudentBirthdate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents lblStudentGender As Label
    Friend WithEvents lblStudentAge As Label
    Friend WithEvents txtbxGuardianName As TextBox
    Friend WithEvents lblStudentGuardianName As Label
    Friend WithEvents txtbxStudentReligion As TextBox
    Friend WithEvents lblStudentReligion As Label
    Friend WithEvents txtbxStudentEnrollmentID As TextBox
    Friend WithEvents lblStudentGradeLevel As Label
    Friend WithEvents txtbxStudentSurname As TextBox
    Friend WithEvents lblStudentSurname As Label
    Friend WithEvents txtStudentMiddleName As TextBox
    Friend WithEvents lblStudentMiddleName As Label
    Friend WithEvents txtbxStudentFirstName As TextBox
    Friend WithEvents lblStudentFirstName As Label
    Friend WithEvents lblStudentList As Label
    Friend WithEvents cmbStudenttGender As ComboBox
    Friend WithEvents lblStudentEnrollmentID As Label
    Friend WithEvents nudStudentAge As NumericUpDown
    Friend WithEvents nudStudentGradeLevel As NumericUpDown
    Friend WithEvents TextBoxStudentSearch As TextBox
    Friend WithEvents txtbxStudentExtension As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxStudentPOB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxStudentLRN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxStudentMotherTongue As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxStudentIPYes As CheckBox
    Friend WithEvents txtbbxStudentIPGroup As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxStudentIPNo As CheckBox
    Friend WithEvents txtbxGuardianContactNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbx4psNo As CheckBox
    Friend WithEvents cbx4psYes As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbx4ps As TextBox
    Friend WithEvents txtbxZipCode As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtbxCountry As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtbxStudentProvince As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtbxStudentCity As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtbxStudentBarangay As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbxstudentStreet As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtbxStudentHouseNo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
End Class
