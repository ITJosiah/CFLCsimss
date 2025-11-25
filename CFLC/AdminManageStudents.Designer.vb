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
        Me.RadioButtonStudentIPNO = New System.Windows.Forms.RadioButton()
        Me.RadioButtonStudentIPYES = New System.Windows.Forms.RadioButton()
        Me.txtbxZipCode = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox4P = New System.Windows.Forms.GroupBox()
        Me.RadioButtonStudent4PYES = New System.Windows.Forms.RadioButton()
        Me.RadioButtonStudent4PNO = New System.Windows.Forms.RadioButton()
        Me.txtbxCountry = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtbxStudentProvince = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtbxStudentCity = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtbxStudentBarangay = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbxstudentStreet = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbxStudentHouseNo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbx4ps = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbxGuardianContactNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.lblStudentGradeLevel = New System.Windows.Forms.Label()
        Me.txtbxStudentSurname = New System.Windows.Forms.TextBox()
        Me.lblStudentSurname = New System.Windows.Forms.Label()
        Me.txtStudentMiddleName = New System.Windows.Forms.TextBox()
        Me.lblStudentMiddleName = New System.Windows.Forms.Label()
        Me.txtbxStudentFirstName = New System.Windows.Forms.TextBox()
        Me.lblStudentFirstName = New System.Windows.Forms.Label()
        Me.lblStudentList = New System.Windows.Forms.Label()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.pnlSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStudentInfo.SuspendLayout()
        Me.GroupBox4P.SuspendLayout()
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
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(40, 49, 40, 49)
        Me.pnlSidebar.Size = New System.Drawing.Size(400, 985)
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
        Me.flowButtons.Location = New System.Drawing.Point(40, 49)
        Me.flowButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.flowButtons.Name = "flowButtons"
        Me.flowButtons.Size = New System.Drawing.Size(320, 825)
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
        Me.btnLogout.Location = New System.Drawing.Point(40, 874)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(320, 62)
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
        Me.pnlContent.Location = New System.Drawing.Point(400, 0)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(40, 37, 40, 37)
        Me.pnlContent.Size = New System.Drawing.Size(1524, 985)
        Me.pnlContent.TabIndex = 1
        '
        'TextBoxStudentSearch
        '
        Me.TextBoxStudentSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxStudentSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxStudentSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentSearch.Location = New System.Drawing.Point(832, 928)
        Me.TextBoxStudentSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxStudentSearch.MaxLength = 50
        Me.TextBoxStudentSearch.Name = "TextBoxStudentSearch"
        Me.TextBoxStudentSearch.Size = New System.Drawing.Size(247, 36)
        Me.TextBoxStudentSearch.TabIndex = 10
        '
        'btnStudentDelete
        '
        Me.btnStudentDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStudentDelete.Location = New System.Drawing.Point(1401, 926)
        Me.btnStudentDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStudentDelete.Name = "btnStudentDelete"
        Me.btnStudentDelete.Size = New System.Drawing.Size(115, 43)
        Me.btnStudentDelete.TabIndex = 9
        Me.btnStudentDelete.Text = "Delete"
        Me.btnStudentDelete.UseVisualStyleBackColor = True
        '
        'btnStudentUpdate
        '
        Me.btnStudentUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStudentUpdate.Location = New System.Drawing.Point(1252, 926)
        Me.btnStudentUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStudentUpdate.Name = "btnStudentUpdate"
        Me.btnStudentUpdate.Size = New System.Drawing.Size(115, 43)
        Me.btnStudentUpdate.TabIndex = 8
        Me.btnStudentUpdate.Text = "Update"
        Me.btnStudentUpdate.UseVisualStyleBackColor = True
        '
        'btnStudentAdd
        '
        Me.btnStudentAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStudentAdd.Location = New System.Drawing.Point(1102, 926)
        Me.btnStudentAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStudentAdd.Name = "btnStudentAdd"
        Me.btnStudentAdd.Size = New System.Drawing.Size(115, 43)
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
        Me.dgvStudents.Location = New System.Drawing.Point(44, 763)
        Me.dgvStudents.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersVisible = False
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(1436, 155)
        Me.dgvStudents.TabIndex = 6
        '
        'grpStudentInfo
        '
        Me.grpStudentInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStudentInfo.BackColor = System.Drawing.Color.Gainsboro
        Me.grpStudentInfo.Controls.Add(Me.RadioButtonStudentIPNO)
        Me.grpStudentInfo.Controls.Add(Me.RadioButtonStudentIPYES)
        Me.grpStudentInfo.Controls.Add(Me.txtbxZipCode)
        Me.grpStudentInfo.Controls.Add(Me.Label18)
        Me.grpStudentInfo.Controls.Add(Me.GroupBox4P)
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
        Me.grpStudentInfo.Controls.Add(Me.Label9)
        Me.grpStudentInfo.Controls.Add(Me.txtbxGuardianContactNo)
        Me.grpStudentInfo.Controls.Add(Me.Label7)
        Me.grpStudentInfo.Controls.Add(Me.Label6)
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
        Me.grpStudentInfo.Controls.Add(Me.lblStudentGradeLevel)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentSurname)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentSurname)
        Me.grpStudentInfo.Controls.Add(Me.txtStudentMiddleName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentMiddleName)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentFirstName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentFirstName)
        Me.grpStudentInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStudentInfo.Location = New System.Drawing.Point(44, 97)
        Me.grpStudentInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.grpStudentInfo.Name = "grpStudentInfo"
        Me.grpStudentInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.grpStudentInfo.Size = New System.Drawing.Size(1436, 633)
        Me.grpStudentInfo.TabIndex = 3
        Me.grpStudentInfo.TabStop = False
        Me.grpStudentInfo.Text = "Student List"
        '
        'RadioButtonStudentIPNO
        '
        Me.RadioButtonStudentIPNO.AutoSize = True
        Me.RadioButtonStudentIPNO.Location = New System.Drawing.Point(154, 293)
        Me.RadioButtonStudentIPNO.Name = "RadioButtonStudentIPNO"
        Me.RadioButtonStudentIPNO.Size = New System.Drawing.Size(51, 24)
        Me.RadioButtonStudentIPNO.TabIndex = 64
        Me.RadioButtonStudentIPNO.TabStop = True
        Me.RadioButtonStudentIPNO.Text = "No"
        Me.RadioButtonStudentIPNO.UseVisualStyleBackColor = True
        '
        'RadioButtonStudentIPYES
        '
        Me.RadioButtonStudentIPYES.AutoSize = True
        Me.RadioButtonStudentIPYES.Location = New System.Drawing.Point(84, 294)
        Me.RadioButtonStudentIPYES.Name = "RadioButtonStudentIPYES"
        Me.RadioButtonStudentIPYES.Size = New System.Drawing.Size(58, 24)
        Me.RadioButtonStudentIPYES.TabIndex = 63
        Me.RadioButtonStudentIPYES.TabStop = True
        Me.RadioButtonStudentIPYES.Text = "Yes"
        Me.RadioButtonStudentIPYES.UseVisualStyleBackColor = True
        '
        'txtbxZipCode
        '
        Me.txtbxZipCode.Location = New System.Drawing.Point(740, 447)
        Me.txtbxZipCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxZipCode.MaxLength = 50
        Me.txtbxZipCode.Name = "txtbxZipCode"
        Me.txtbxZipCode.Size = New System.Drawing.Size(252, 26)
        Me.txtbxZipCode.TabIndex = 62
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(741, 422)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 20)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "ZIP Code"
        '
        'GroupBox4P
        '
        Me.GroupBox4P.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox4P.Controls.Add(Me.RadioButtonStudent4PYES)
        Me.GroupBox4P.Controls.Add(Me.RadioButtonStudent4PNO)
        Me.GroupBox4P.Location = New System.Drawing.Point(78, 350)
        Me.GroupBox4P.Name = "GroupBox4P"
        Me.GroupBox4P.Size = New System.Drawing.Size(134, 44)
        Me.GroupBox4P.TabIndex = 11
        Me.GroupBox4P.TabStop = False
        '
        'RadioButtonStudent4PYES
        '
        Me.RadioButtonStudent4PYES.AutoSize = True
        Me.RadioButtonStudent4PYES.Location = New System.Drawing.Point(7, 9)
        Me.RadioButtonStudent4PYES.Name = "RadioButtonStudent4PYES"
        Me.RadioButtonStudent4PYES.Size = New System.Drawing.Size(58, 24)
        Me.RadioButtonStudent4PYES.TabIndex = 65
        Me.RadioButtonStudent4PYES.TabStop = True
        Me.RadioButtonStudent4PYES.Text = "Yes"
        Me.RadioButtonStudent4PYES.UseVisualStyleBackColor = True
        '
        'RadioButtonStudent4PNO
        '
        Me.RadioButtonStudent4PNO.AutoSize = True
        Me.RadioButtonStudent4PNO.Location = New System.Drawing.Point(77, 9)
        Me.RadioButtonStudent4PNO.Name = "RadioButtonStudent4PNO"
        Me.RadioButtonStudent4PNO.Size = New System.Drawing.Size(51, 24)
        Me.RadioButtonStudent4PNO.TabIndex = 66
        Me.RadioButtonStudent4PNO.TabStop = True
        Me.RadioButtonStudent4PNO.Text = "No"
        Me.RadioButtonStudent4PNO.UseVisualStyleBackColor = True
        '
        'txtbxCountry
        '
        Me.txtbxCountry.Location = New System.Drawing.Point(429, 561)
        Me.txtbxCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxCountry.MaxLength = 50
        Me.txtbxCountry.Name = "txtbxCountry"
        Me.txtbxCountry.Size = New System.Drawing.Size(252, 26)
        Me.txtbxCountry.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(425, 537)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 20)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Country"
        '
        'txtbxStudentProvince
        '
        Me.txtbxStudentProvince.Location = New System.Drawing.Point(429, 505)
        Me.txtbxStudentProvince.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentProvince.MaxLength = 50
        Me.txtbxStudentProvince.Name = "txtbxStudentProvince"
        Me.txtbxStudentProvince.Size = New System.Drawing.Size(252, 26)
        Me.txtbxStudentProvince.TabIndex = 58
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(425, 480)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 20)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Province"
        '
        'txtbxStudentCity
        '
        Me.txtbxStudentCity.Location = New System.Drawing.Point(429, 444)
        Me.txtbxStudentCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentCity.MaxLength = 50
        Me.txtbxStudentCity.Name = "txtbxStudentCity"
        Me.txtbxStudentCity.Size = New System.Drawing.Size(252, 26)
        Me.txtbxStudentCity.TabIndex = 56
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(425, 422)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(131, 20)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "City/Municipality"
        '
        'txtbxStudentBarangay
        '
        Me.txtbxStudentBarangay.Location = New System.Drawing.Point(73, 561)
        Me.txtbxStudentBarangay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentBarangay.MaxLength = 50
        Me.txtbxStudentBarangay.Name = "txtbxStudentBarangay"
        Me.txtbxStudentBarangay.Size = New System.Drawing.Size(252, 26)
        Me.txtbxStudentBarangay.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(69, 537)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 20)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Barangay"
        '
        'txtbxstudentStreet
        '
        Me.txtbxstudentStreet.Location = New System.Drawing.Point(73, 505)
        Me.txtbxstudentStreet.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxstudentStreet.MaxLength = 50
        Me.txtbxstudentStreet.Name = "txtbxstudentStreet"
        Me.txtbxstudentStreet.Size = New System.Drawing.Size(252, 26)
        Me.txtbxstudentStreet.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(69, 480)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 20)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Street Name"
        '
        'txtbxStudentHouseNo
        '
        Me.txtbxStudentHouseNo.Location = New System.Drawing.Point(73, 447)
        Me.txtbxStudentHouseNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentHouseNo.MaxLength = 50
        Me.txtbxStudentHouseNo.Name = "txtbxStudentHouseNo"
        Me.txtbxStudentHouseNo.Size = New System.Drawing.Size(252, 26)
        Me.txtbxStudentHouseNo.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(69, 422)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 20)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "House Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 396)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Address"
        '
        'txtbx4ps
        '
        Me.txtbx4ps.Location = New System.Drawing.Point(626, 356)
        Me.txtbx4ps.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbx4ps.MaxLength = 50
        Me.txtbx4ps.Name = "txtbx4ps"
        Me.txtbx4ps.Size = New System.Drawing.Size(303, 26)
        Me.txtbx4ps.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(217, 360)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(392, 20)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "If Yes, please write the 4P's Household ID Number:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(69, 327)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(269, 20)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Is your family a benificiary of 4P's?"
        '
        'txtbxGuardianContactNo
        '
        Me.txtbxGuardianContactNo.Location = New System.Drawing.Point(740, 215)
        Me.txtbxGuardianContactNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxGuardianContactNo.MaxLength = 50
        Me.txtbxGuardianContactNo.Name = "txtbxGuardianContactNo"
        Me.txtbxGuardianContactNo.Size = New System.Drawing.Size(189, 26)
        Me.txtbxGuardianContactNo.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(736, 192)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 20)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Guardian Contact Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(217, 293)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "If Yes, please specify:"
        '
        'txtbbxStudentIPGroup
        '
        Me.txtbbxStudentIPGroup.Location = New System.Drawing.Point(416, 290)
        Me.txtbbxStudentIPGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbbxStudentIPGroup.MaxLength = 50
        Me.txtbbxStudentIPGroup.Name = "txtbbxStudentIPGroup"
        Me.txtbbxStudentIPGroup.Size = New System.Drawing.Size(263, 26)
        Me.txtbbxStudentIPGroup.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 262)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(408, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Belonging to any Indigineous People (IP) Community?"
        '
        'txtbxStudentMotherTongue
        '
        Me.txtbxStudentMotherTongue.Location = New System.Drawing.Point(740, 101)
        Me.txtbxStudentMotherTongue.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentMotherTongue.MaxLength = 50
        Me.txtbxStudentMotherTongue.Name = "txtbxStudentMotherTongue"
        Me.txtbxStudentMotherTongue.Size = New System.Drawing.Size(252, 26)
        Me.txtbxStudentMotherTongue.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(736, 77)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Mother Tongue"
        '
        'txtbxStudentLRN
        '
        Me.txtbxStudentLRN.Location = New System.Drawing.Point(740, 43)
        Me.txtbxStudentLRN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentLRN.MaxLength = 50
        Me.txtbxStudentLRN.Name = "txtbxStudentLRN"
        Me.txtbxStudentLRN.Size = New System.Drawing.Size(295, 26)
        Me.txtbxStudentLRN.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(736, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(329, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Learner Reference No. (LRN) If applicable:"
        '
        'txtbxStudentPOB
        '
        Me.txtbxStudentPOB.Location = New System.Drawing.Point(412, 159)
        Me.txtbxStudentPOB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentPOB.MaxLength = 20
        Me.txtbxStudentPOB.Name = "txtbxStudentPOB"
        Me.txtbxStudentPOB.Size = New System.Drawing.Size(240, 26)
        Me.txtbxStudentPOB.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 135)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Place of Birth (City/Municipality)"
        '
        'txtbxStudentExtension
        '
        Me.txtbxStudentExtension.Location = New System.Drawing.Point(73, 215)
        Me.txtbxStudentExtension.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentExtension.MaxLength = 50
        Me.txtbxStudentExtension.Name = "txtbxStudentExtension"
        Me.txtbxStudentExtension.Size = New System.Drawing.Size(252, 26)
        Me.txtbxStudentExtension.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 191)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Extension (Jr. III,  etc.)"
        '
        'nudStudentGradeLevel
        '
        Me.nudStudentGradeLevel.Location = New System.Drawing.Point(584, 41)
        Me.nudStudentGradeLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.nudStudentGradeLevel.Name = "nudStudentGradeLevel"
        Me.nudStudentGradeLevel.Size = New System.Drawing.Size(47, 26)
        Me.nudStudentGradeLevel.TabIndex = 27
        '
        'nudStudentAge
        '
        Me.nudStudentAge.Location = New System.Drawing.Point(411, 103)
        Me.nudStudentAge.Margin = New System.Windows.Forms.Padding(4)
        Me.nudStudentAge.Name = "nudStudentAge"
        Me.nudStudentAge.Size = New System.Drawing.Size(47, 26)
        Me.nudStudentAge.TabIndex = 24
        '
        'cmbStudenttGender
        '
        Me.cmbStudenttGender.FormattingEnabled = True
        Me.cmbStudenttGender.Location = New System.Drawing.Point(515, 101)
        Me.cmbStudenttGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStudenttGender.Name = "cmbStudenttGender"
        Me.cmbStudenttGender.Size = New System.Drawing.Size(120, 28)
        Me.cmbStudenttGender.TabIndex = 23
        '
        'dtpStudentBirthdate
        '
        Me.dtpStudentBirthdate.Checked = False
        Me.dtpStudentBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStudentBirthdate.Location = New System.Drawing.Point(411, 41)
        Me.dtpStudentBirthdate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStudentBirthdate.Name = "dtpStudentBirthdate"
        Me.dtpStudentBirthdate.Size = New System.Drawing.Size(112, 26)
        Me.dtpStudentBirthdate.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(407, 16)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Birthdate"
        '
        'lblStudentGender
        '
        Me.lblStudentGender.AutoSize = True
        Me.lblStudentGender.Location = New System.Drawing.Point(511, 79)
        Me.lblStudentGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentGender.Name = "lblStudentGender"
        Me.lblStudentGender.Size = New System.Drawing.Size(37, 20)
        Me.lblStudentGender.TabIndex = 19
        Me.lblStudentGender.Text = "Sex"
        '
        'lblStudentAge
        '
        Me.lblStudentAge.AutoSize = True
        Me.lblStudentAge.Location = New System.Drawing.Point(407, 79)
        Me.lblStudentAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentAge.Name = "lblStudentAge"
        Me.lblStudentAge.Size = New System.Drawing.Size(38, 20)
        Me.lblStudentAge.TabIndex = 17
        Me.lblStudentAge.Text = "Age"
        '
        'txtbxGuardianName
        '
        Me.txtbxGuardianName.Location = New System.Drawing.Point(740, 159)
        Me.txtbxGuardianName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxGuardianName.MaxLength = 50
        Me.txtbxGuardianName.Name = "txtbxGuardianName"
        Me.txtbxGuardianName.Size = New System.Drawing.Size(207, 26)
        Me.txtbxGuardianName.TabIndex = 16
        '
        'lblStudentGuardianName
        '
        Me.lblStudentGuardianName.AutoEllipsis = True
        Me.lblStudentGuardianName.AutoSize = True
        Me.lblStudentGuardianName.Location = New System.Drawing.Point(736, 136)
        Me.lblStudentGuardianName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentGuardianName.Name = "lblStudentGuardianName"
        Me.lblStudentGuardianName.Size = New System.Drawing.Size(126, 20)
        Me.lblStudentGuardianName.TabIndex = 15
        Me.lblStudentGuardianName.Text = "Guardian Name"
        '
        'txtbxStudentReligion
        '
        Me.txtbxStudentReligion.Location = New System.Drawing.Point(411, 214)
        Me.txtbxStudentReligion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentReligion.MaxLength = 20
        Me.txtbxStudentReligion.Name = "txtbxStudentReligion"
        Me.txtbxStudentReligion.Size = New System.Drawing.Size(252, 26)
        Me.txtbxStudentReligion.TabIndex = 14
        '
        'lblStudentReligion
        '
        Me.lblStudentReligion.AutoSize = True
        Me.lblStudentReligion.Location = New System.Drawing.Point(407, 191)
        Me.lblStudentReligion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentReligion.Name = "lblStudentReligion"
        Me.lblStudentReligion.Size = New System.Drawing.Size(69, 20)
        Me.lblStudentReligion.TabIndex = 13
        Me.lblStudentReligion.Text = "Religion"
        '
        'lblStudentGradeLevel
        '
        Me.lblStudentGradeLevel.AutoSize = True
        Me.lblStudentGradeLevel.Location = New System.Drawing.Point(556, 16)
        Me.lblStudentGradeLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentGradeLevel.Name = "lblStudentGradeLevel"
        Me.lblStudentGradeLevel.Size = New System.Drawing.Size(100, 20)
        Me.lblStudentGradeLevel.TabIndex = 9
        Me.lblStudentGradeLevel.Text = "Grade Level"
        '
        'txtbxStudentSurname
        '
        Me.txtbxStudentSurname.Location = New System.Drawing.Point(73, 160)
        Me.txtbxStudentSurname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentSurname.MaxLength = 50
        Me.txtbxStudentSurname.Name = "txtbxStudentSurname"
        Me.txtbxStudentSurname.Size = New System.Drawing.Size(252, 26)
        Me.txtbxStudentSurname.TabIndex = 6
        '
        'lblStudentSurname
        '
        Me.lblStudentSurname.AutoSize = True
        Me.lblStudentSurname.Location = New System.Drawing.Point(69, 135)
        Me.lblStudentSurname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentSurname.Name = "lblStudentSurname"
        Me.lblStudentSurname.Size = New System.Drawing.Size(76, 20)
        Me.lblStudentSurname.TabIndex = 5
        Me.lblStudentSurname.Text = "Surname"
        '
        'txtStudentMiddleName
        '
        Me.txtStudentMiddleName.Location = New System.Drawing.Point(73, 103)
        Me.txtStudentMiddleName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentMiddleName.MaxLength = 50
        Me.txtStudentMiddleName.Name = "txtStudentMiddleName"
        Me.txtStudentMiddleName.Size = New System.Drawing.Size(252, 26)
        Me.txtStudentMiddleName.TabIndex = 4
        '
        'lblStudentMiddleName
        '
        Me.lblStudentMiddleName.AutoSize = True
        Me.lblStudentMiddleName.Location = New System.Drawing.Point(69, 79)
        Me.lblStudentMiddleName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentMiddleName.Name = "lblStudentMiddleName"
        Me.lblStudentMiddleName.Size = New System.Drawing.Size(107, 20)
        Me.lblStudentMiddleName.TabIndex = 3
        Me.lblStudentMiddleName.Text = "Middle Name"
        '
        'txtbxStudentFirstName
        '
        Me.txtbxStudentFirstName.Location = New System.Drawing.Point(73, 46)
        Me.txtbxStudentFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentFirstName.MaxLength = 50
        Me.txtbxStudentFirstName.Name = "txtbxStudentFirstName"
        Me.txtbxStudentFirstName.Size = New System.Drawing.Size(252, 26)
        Me.txtbxStudentFirstName.TabIndex = 2
        '
        'lblStudentFirstName
        '
        Me.lblStudentFirstName.AutoSize = True
        Me.lblStudentFirstName.Location = New System.Drawing.Point(69, 23)
        Me.lblStudentFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentFirstName.Name = "lblStudentFirstName"
        Me.lblStudentFirstName.Size = New System.Drawing.Size(92, 20)
        Me.lblStudentFirstName.TabIndex = 1
        Me.lblStudentFirstName.Text = "First Name"
        '
        'lblStudentList
        '
        Me.lblStudentList.AutoSize = True
        Me.lblStudentList.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblStudentList.ForeColor = System.Drawing.Color.White
        Me.lblStudentList.Location = New System.Drawing.Point(37, 36)
        Me.lblStudentList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentList.Name = "lblStudentList"
        Me.lblStudentList.Size = New System.Drawing.Size(143, 32)
        Me.lblStudentList.TabIndex = 2
        Me.lblStudentList.Text = "Student List"
        '
        'picWatermark
        '
        Me.picWatermark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(412, 201)
        Me.picWatermark.Margin = New System.Windows.Forms.Padding(4)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(693, 574)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 5
        Me.picWatermark.TabStop = False
        '
        'AdminManageStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 985)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
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
        Me.GroupBox4P.ResumeLayout(False)
        Me.GroupBox4P.PerformLayout()
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
    Friend WithEvents lblStudentGradeLevel As Label
    Friend WithEvents txtbxStudentSurname As TextBox
    Friend WithEvents lblStudentSurname As Label
    Friend WithEvents txtStudentMiddleName As TextBox
    Friend WithEvents lblStudentMiddleName As Label
    Friend WithEvents txtbxStudentFirstName As TextBox
    Friend WithEvents lblStudentFirstName As Label
    Friend WithEvents lblStudentList As Label
    Friend WithEvents cmbStudenttGender As ComboBox
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
    Friend WithEvents txtbbxStudentIPGroup As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbxGuardianContactNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
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
    Friend WithEvents RadioButtonStudentIPYES As RadioButton
    Friend WithEvents RadioButtonStudent4PNO As RadioButton
    Friend WithEvents RadioButtonStudent4PYES As RadioButton
    Friend WithEvents RadioButtonStudentIPNO As RadioButton
    Friend WithEvents GroupBox4P As GroupBox
End Class
