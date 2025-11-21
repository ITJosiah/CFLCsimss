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
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nudStudentAge = New System.Windows.Forms.NumericUpDown()
        Me.txtStudentAge = New System.Windows.Forms.Label()
        Me.txtbxStudentProvince = New System.Windows.Forms.TextBox()
        Me.txtbxStudentCountry = New System.Windows.Forms.TextBox()
        Me.txtbxStudentZIP = New System.Windows.Forms.TextBox()
        Me.lblStudentBirthday = New System.Windows.Forms.Label()
        Me.dtStudentBirthday = New System.Windows.Forms.DateTimePicker()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.txtbxStudentStreet = New System.Windows.Forms.TextBox()
        Me.txtbxStudentHouse = New System.Windows.Forms.TextBox()
        Me.txtbxStudentCity = New System.Windows.Forms.TextBox()
        Me.txtbxStudentSectionID = New System.Windows.Forms.TextBox()
        Me.txtboxStudentEnrollmentID = New System.Windows.Forms.TextBox()
        Me.txtbxStudentParentName = New System.Windows.Forms.TextBox()
        Me.txtbxStudentReligion = New System.Windows.Forms.TextBox()
        Me.txtbxStudentGradeLevel = New System.Windows.Forms.TextBox()
        Me.txtbxStudentNumber = New System.Windows.Forms.TextBox()
        Me.txtbxStudentLastName = New System.Windows.Forms.TextBox()
        Me.txtbxStudentMiddleName = New System.Windows.Forms.TextBox()
        Me.txtbxStudentFirstName = New System.Windows.Forms.TextBox()
        Me.lblStudentZIP = New System.Windows.Forms.Label()
        Me.lblStudentCity = New System.Windows.Forms.Label()
        Me.lblStudentStreet = New System.Windows.Forms.Label()
        Me.lblStudentCountry = New System.Windows.Forms.Label()
        Me.lblStudentProvince = New System.Windows.Forms.Label()
        Me.lblStudentSubdi = New System.Windows.Forms.Label()
        Me.lblStudentNumber = New System.Windows.Forms.Label()
        Me.lblStudentHouse = New System.Windows.Forms.Label()
        Me.lblSectionID = New System.Windows.Forms.Label()
        Me.lblEnrollmentID = New System.Windows.Forms.Label()
        Me.lblParentName = New System.Windows.Forms.Label()
        Me.lblStudentReligion = New System.Windows.Forms.Label()
        Me.lblStudentGradeLevel = New System.Windows.Forms.Label()
        Me.lblStudentLastName = New System.Windows.Forms.Label()
        Me.lblStudentMiddleName = New System.Windows.Forms.Label()
        Me.lblStudentFirstName = New System.Windows.Forms.Label()
        Me.lblStudentInfo = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.nudStudentAge, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlSidebar.Size = New System.Drawing.Size(300, 633)
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
        Me.flowButtons.Size = New System.Drawing.Size(240, 503)
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
        Me.btnLogout.Location = New System.Drawing.Point(30, 543)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(240, 50)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'picWatermark
        '
        Me.picWatermark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(532, 77)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(520, 466)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 23
        Me.picWatermark.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.nudStudentAge)
        Me.Panel1.Controls.Add(Me.txtStudentAge)
        Me.Panel1.Controls.Add(Me.txtbxStudentProvince)
        Me.Panel1.Controls.Add(Me.txtbxStudentCountry)
        Me.Panel1.Controls.Add(Me.txtbxStudentZIP)
        Me.Panel1.Controls.Add(Me.lblStudentBirthday)
        Me.Panel1.Controls.Add(Me.dtStudentBirthday)
        Me.Panel1.Controls.Add(Me.TextBox12)
        Me.Panel1.Controls.Add(Me.txtbxStudentStreet)
        Me.Panel1.Controls.Add(Me.txtbxStudentHouse)
        Me.Panel1.Controls.Add(Me.txtbxStudentCity)
        Me.Panel1.Controls.Add(Me.txtbxStudentSectionID)
        Me.Panel1.Controls.Add(Me.txtboxStudentEnrollmentID)
        Me.Panel1.Controls.Add(Me.txtbxStudentParentName)
        Me.Panel1.Controls.Add(Me.txtbxStudentReligion)
        Me.Panel1.Controls.Add(Me.txtbxStudentGradeLevel)
        Me.Panel1.Controls.Add(Me.txtbxStudentNumber)
        Me.Panel1.Controls.Add(Me.txtbxStudentLastName)
        Me.Panel1.Controls.Add(Me.txtbxStudentMiddleName)
        Me.Panel1.Controls.Add(Me.txtbxStudentFirstName)
        Me.Panel1.Controls.Add(Me.lblStudentZIP)
        Me.Panel1.Controls.Add(Me.lblStudentCity)
        Me.Panel1.Controls.Add(Me.lblStudentStreet)
        Me.Panel1.Controls.Add(Me.lblStudentCountry)
        Me.Panel1.Controls.Add(Me.lblStudentProvince)
        Me.Panel1.Controls.Add(Me.lblStudentSubdi)
        Me.Panel1.Controls.Add(Me.lblStudentNumber)
        Me.Panel1.Controls.Add(Me.lblStudentHouse)
        Me.Panel1.Controls.Add(Me.lblSectionID)
        Me.Panel1.Controls.Add(Me.lblEnrollmentID)
        Me.Panel1.Controls.Add(Me.lblParentName)
        Me.Panel1.Controls.Add(Me.lblStudentReligion)
        Me.Panel1.Controls.Add(Me.lblStudentGradeLevel)
        Me.Panel1.Controls.Add(Me.lblStudentLastName)
        Me.Panel1.Controls.Add(Me.lblStudentMiddleName)
        Me.Panel1.Controls.Add(Me.lblStudentFirstName)
        Me.Panel1.Location = New System.Drawing.Point(324, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(944, 378)
        Me.Panel1.TabIndex = 24
        '
        'nudStudentAge
        '
        Me.nudStudentAge.Location = New System.Drawing.Point(637, 56)
        Me.nudStudentAge.Name = "nudStudentAge"
        Me.nudStudentAge.Size = New System.Drawing.Size(40, 20)
        Me.nudStudentAge.TabIndex = 35
        '
        'txtStudentAge
        '
        Me.txtStudentAge.AutoSize = True
        Me.txtStudentAge.Location = New System.Drawing.Point(634, 38)
        Me.txtStudentAge.Name = "txtStudentAge"
        Me.txtStudentAge.Size = New System.Drawing.Size(26, 13)
        Me.txtStudentAge.TabIndex = 34
        Me.txtStudentAge.Text = "Age"
        '
        'txtbxStudentProvince
        '
        Me.txtbxStudentProvince.Location = New System.Drawing.Point(57, 301)
        Me.txtbxStudentProvince.Name = "txtbxStudentProvince"
        Me.txtbxStudentProvince.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentProvince.TabIndex = 33
        '
        'txtbxStudentCountry
        '
        Me.txtbxStudentCountry.Location = New System.Drawing.Point(479, 287)
        Me.txtbxStudentCountry.Name = "txtbxStudentCountry"
        Me.txtbxStudentCountry.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentCountry.TabIndex = 32
        '
        'txtbxStudentZIP
        '
        Me.txtbxStudentZIP.Location = New System.Drawing.Point(690, 301)
        Me.txtbxStudentZIP.Name = "txtbxStudentZIP"
        Me.txtbxStudentZIP.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentZIP.TabIndex = 31
        '
        'lblStudentBirthday
        '
        Me.lblStudentBirthday.AutoSize = True
        Me.lblStudentBirthday.Location = New System.Drawing.Point(654, 146)
        Me.lblStudentBirthday.Name = "lblStudentBirthday"
        Me.lblStudentBirthday.Size = New System.Drawing.Size(45, 13)
        Me.lblStudentBirthday.TabIndex = 30
        Me.lblStudentBirthday.Text = "Birthday"
        '
        'dtStudentBirthday
        '
        Me.dtStudentBirthday.Location = New System.Drawing.Point(657, 162)
        Me.dtStudentBirthday.Name = "dtStudentBirthday"
        Me.dtStudentBirthday.Size = New System.Drawing.Size(182, 20)
        Me.dtStudentBirthday.TabIndex = 29
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(535, 231)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(149, 20)
        Me.TextBox12.TabIndex = 28
        '
        'txtbxStudentStreet
        '
        Me.txtbxStudentStreet.Location = New System.Drawing.Point(307, 231)
        Me.txtbxStudentStreet.Name = "txtbxStudentStreet"
        Me.txtbxStudentStreet.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentStreet.TabIndex = 27
        '
        'txtbxStudentHouse
        '
        Me.txtbxStudentHouse.Location = New System.Drawing.Point(57, 228)
        Me.txtbxStudentHouse.Name = "txtbxStudentHouse"
        Me.txtbxStudentHouse.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentHouse.TabIndex = 26
        '
        'txtbxStudentCity
        '
        Me.txtbxStudentCity.Location = New System.Drawing.Point(294, 288)
        Me.txtbxStudentCity.Name = "txtbxStudentCity"
        Me.txtbxStudentCity.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentCity.TabIndex = 25
        '
        'txtbxStudentSectionID
        '
        Me.txtbxStudentSectionID.Location = New System.Drawing.Point(426, 161)
        Me.txtbxStudentSectionID.Name = "txtbxStudentSectionID"
        Me.txtbxStudentSectionID.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentSectionID.TabIndex = 24
        '
        'txtboxStudentEnrollmentID
        '
        Me.txtboxStudentEnrollmentID.Location = New System.Drawing.Point(426, 130)
        Me.txtboxStudentEnrollmentID.Name = "txtboxStudentEnrollmentID"
        Me.txtboxStudentEnrollmentID.Size = New System.Drawing.Size(149, 20)
        Me.txtboxStudentEnrollmentID.TabIndex = 23
        '
        'txtbxStudentParentName
        '
        Me.txtbxStudentParentName.Location = New System.Drawing.Point(426, 98)
        Me.txtbxStudentParentName.Name = "txtbxStudentParentName"
        Me.txtbxStudentParentName.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentParentName.TabIndex = 22
        '
        'txtbxStudentReligion
        '
        Me.txtbxStudentReligion.Location = New System.Drawing.Point(426, 61)
        Me.txtbxStudentReligion.Name = "txtbxStudentReligion"
        Me.txtbxStudentReligion.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentReligion.TabIndex = 21
        '
        'txtbxStudentGradeLevel
        '
        Me.txtbxStudentGradeLevel.Location = New System.Drawing.Point(426, 35)
        Me.txtbxStudentGradeLevel.Name = "txtbxStudentGradeLevel"
        Me.txtbxStudentGradeLevel.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentGradeLevel.TabIndex = 20
        '
        'txtbxStudentNumber
        '
        Me.txtbxStudentNumber.Location = New System.Drawing.Point(185, 149)
        Me.txtbxStudentNumber.Name = "txtbxStudentNumber"
        Me.txtbxStudentNumber.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentNumber.TabIndex = 19
        '
        'txtbxStudentLastName
        '
        Me.txtbxStudentLastName.Location = New System.Drawing.Point(185, 111)
        Me.txtbxStudentLastName.Name = "txtbxStudentLastName"
        Me.txtbxStudentLastName.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentLastName.TabIndex = 18
        '
        'txtbxStudentMiddleName
        '
        Me.txtbxStudentMiddleName.Location = New System.Drawing.Point(185, 75)
        Me.txtbxStudentMiddleName.Name = "txtbxStudentMiddleName"
        Me.txtbxStudentMiddleName.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentMiddleName.TabIndex = 17
        '
        'txtbxStudentFirstName
        '
        Me.txtbxStudentFirstName.Location = New System.Drawing.Point(185, 38)
        Me.txtbxStudentFirstName.Name = "txtbxStudentFirstName"
        Me.txtbxStudentFirstName.Size = New System.Drawing.Size(149, 20)
        Me.txtbxStudentFirstName.TabIndex = 16
        '
        'lblStudentZIP
        '
        Me.lblStudentZIP.AutoSize = True
        Me.lblStudentZIP.Location = New System.Drawing.Point(687, 271)
        Me.lblStudentZIP.Name = "lblStudentZIP"
        Me.lblStudentZIP.Size = New System.Drawing.Size(52, 13)
        Me.lblStudentZIP.TabIndex = 15
        Me.lblStudentZIP.Text = "ZIP Code"
        '
        'lblStudentCity
        '
        Me.lblStudentCity.AutoSize = True
        Me.lblStudentCity.Location = New System.Drawing.Point(315, 271)
        Me.lblStudentCity.Name = "lblStudentCity"
        Me.lblStudentCity.Size = New System.Drawing.Size(24, 13)
        Me.lblStudentCity.TabIndex = 14
        Me.lblStudentCity.Text = "City"
        '
        'lblStudentStreet
        '
        Me.lblStudentStreet.AutoSize = True
        Me.lblStudentStreet.Location = New System.Drawing.Point(304, 212)
        Me.lblStudentStreet.Name = "lblStudentStreet"
        Me.lblStudentStreet.Size = New System.Drawing.Size(35, 13)
        Me.lblStudentStreet.TabIndex = 13
        Me.lblStudentStreet.Text = "Street"
        '
        'lblStudentCountry
        '
        Me.lblStudentCountry.AutoSize = True
        Me.lblStudentCountry.Location = New System.Drawing.Point(476, 271)
        Me.lblStudentCountry.Name = "lblStudentCountry"
        Me.lblStudentCountry.Size = New System.Drawing.Size(43, 13)
        Me.lblStudentCountry.TabIndex = 12
        Me.lblStudentCountry.Text = "Country"
        '
        'lblStudentProvince
        '
        Me.lblStudentProvince.AutoSize = True
        Me.lblStudentProvince.Location = New System.Drawing.Point(58, 271)
        Me.lblStudentProvince.Name = "lblStudentProvince"
        Me.lblStudentProvince.Size = New System.Drawing.Size(49, 13)
        Me.lblStudentProvince.TabIndex = 11
        Me.lblStudentProvince.Text = "Province"
        '
        'lblStudentSubdi
        '
        Me.lblStudentSubdi.AutoSize = True
        Me.lblStudentSubdi.Location = New System.Drawing.Point(525, 212)
        Me.lblStudentSubdi.Name = "lblStudentSubdi"
        Me.lblStudentSubdi.Size = New System.Drawing.Size(159, 13)
        Me.lblStudentSubdi.TabIndex = 10
        Me.lblStudentSubdi.Text = "Subdivision / Village / Barangay"
        '
        'lblStudentNumber
        '
        Me.lblStudentNumber.AutoSize = True
        Me.lblStudentNumber.Location = New System.Drawing.Point(170, 130)
        Me.lblStudentNumber.Name = "lblStudentNumber"
        Me.lblStudentNumber.Size = New System.Drawing.Size(64, 13)
        Me.lblStudentNumber.TabIndex = 9
        Me.lblStudentNumber.Text = "Student No."
        '
        'lblStudentHouse
        '
        Me.lblStudentHouse.AutoSize = True
        Me.lblStudentHouse.Location = New System.Drawing.Point(50, 212)
        Me.lblStudentHouse.Name = "lblStudentHouse"
        Me.lblStudentHouse.Size = New System.Drawing.Size(156, 13)
        Me.lblStudentHouse.TabIndex = 8
        Me.lblStudentHouse.Text = "House No./ Lot No./ Block No."
        '
        'lblSectionID
        '
        Me.lblSectionID.AutoSize = True
        Me.lblSectionID.Location = New System.Drawing.Point(414, 149)
        Me.lblSectionID.Name = "lblSectionID"
        Me.lblSectionID.Size = New System.Drawing.Size(57, 13)
        Me.lblSectionID.TabIndex = 7
        Me.lblSectionID.Text = "Section ID"
        '
        'lblEnrollmentID
        '
        Me.lblEnrollmentID.AutoSize = True
        Me.lblEnrollmentID.Location = New System.Drawing.Point(414, 114)
        Me.lblEnrollmentID.Name = "lblEnrollmentID"
        Me.lblEnrollmentID.Size = New System.Drawing.Size(70, 13)
        Me.lblEnrollmentID.TabIndex = 6
        Me.lblEnrollmentID.Text = "Enrollment ID"
        '
        'lblParentName
        '
        Me.lblParentName.AutoSize = True
        Me.lblParentName.Location = New System.Drawing.Point(414, 84)
        Me.lblParentName.Name = "lblParentName"
        Me.lblParentName.Size = New System.Drawing.Size(69, 13)
        Me.lblParentName.TabIndex = 5
        Me.lblParentName.Text = "Parent Name"
        '
        'lblStudentReligion
        '
        Me.lblStudentReligion.AutoSize = True
        Me.lblStudentReligion.Location = New System.Drawing.Point(414, 51)
        Me.lblStudentReligion.Name = "lblStudentReligion"
        Me.lblStudentReligion.Size = New System.Drawing.Size(45, 13)
        Me.lblStudentReligion.TabIndex = 4
        Me.lblStudentReligion.Text = "Religion"
        '
        'lblStudentGradeLevel
        '
        Me.lblStudentGradeLevel.AutoSize = True
        Me.lblStudentGradeLevel.Location = New System.Drawing.Point(414, 22)
        Me.lblStudentGradeLevel.Name = "lblStudentGradeLevel"
        Me.lblStudentGradeLevel.Size = New System.Drawing.Size(65, 13)
        Me.lblStudentGradeLevel.TabIndex = 3
        Me.lblStudentGradeLevel.Text = "Grade Level"
        '
        'lblStudentLastName
        '
        Me.lblStudentLastName.AutoSize = True
        Me.lblStudentLastName.Location = New System.Drawing.Point(170, 98)
        Me.lblStudentLastName.Name = "lblStudentLastName"
        Me.lblStudentLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblStudentLastName.TabIndex = 2
        Me.lblStudentLastName.Text = "Last Name"
        '
        'lblStudentMiddleName
        '
        Me.lblStudentMiddleName.AutoSize = True
        Me.lblStudentMiddleName.Location = New System.Drawing.Point(170, 58)
        Me.lblStudentMiddleName.Name = "lblStudentMiddleName"
        Me.lblStudentMiddleName.Size = New System.Drawing.Size(69, 13)
        Me.lblStudentMiddleName.TabIndex = 1
        Me.lblStudentMiddleName.Text = "Middle Name"
        '
        'lblStudentFirstName
        '
        Me.lblStudentFirstName.AutoSize = True
        Me.lblStudentFirstName.Location = New System.Drawing.Point(170, 22)
        Me.lblStudentFirstName.Name = "lblStudentFirstName"
        Me.lblStudentFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblStudentFirstName.TabIndex = 0
        Me.lblStudentFirstName.Text = "First Name"
        '
        'lblStudentInfo
        '
        Me.lblStudentInfo.AutoSize = True
        Me.lblStudentInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblStudentInfo.Location = New System.Drawing.Point(319, 22)
        Me.lblStudentInfo.Name = "lblStudentInfo"
        Me.lblStudentInfo.Size = New System.Drawing.Size(217, 25)
        Me.lblStudentInfo.TabIndex = 25
        Me.lblStudentInfo.Text = "Student Information"
        '
        'AdminManageStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 633)
        Me.Controls.Add(Me.lblStudentInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picWatermark)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AdminManageStudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin - Manage Students"
        Me.pnlSidebar.ResumeLayout(False)
        Me.flowButtons.ResumeLayout(False)
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudStudentAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStudentInfo As Label
    Friend WithEvents lblStudentNumber As Label
    Friend WithEvents lblStudentHouse As Label
    Friend WithEvents lblSectionID As Label
    Friend WithEvents lblEnrollmentID As Label
    Friend WithEvents lblParentName As Label
    Friend WithEvents lblStudentReligion As Label
    Friend WithEvents lblStudentGradeLevel As Label
    Friend WithEvents lblStudentLastName As Label
    Friend WithEvents lblStudentMiddleName As Label
    Friend WithEvents lblStudentFirstName As Label
    Friend WithEvents txtbxStudentFirstName As TextBox
    Friend WithEvents lblStudentZIP As Label
    Friend WithEvents lblStudentCity As Label
    Friend WithEvents lblStudentStreet As Label
    Friend WithEvents lblStudentCountry As Label
    Friend WithEvents lblStudentProvince As Label
    Friend WithEvents lblStudentSubdi As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents txtbxStudentStreet As TextBox
    Friend WithEvents txtbxStudentHouse As TextBox
    Friend WithEvents txtbxStudentCity As TextBox
    Friend WithEvents txtbxStudentSectionID As TextBox
    Friend WithEvents txtboxStudentEnrollmentID As TextBox
    Friend WithEvents txtbxStudentParentName As TextBox
    Friend WithEvents txtbxStudentReligion As TextBox
    Friend WithEvents txtbxStudentGradeLevel As TextBox
    Friend WithEvents txtbxStudentNumber As TextBox
    Friend WithEvents txtbxStudentLastName As TextBox
    Friend WithEvents txtbxStudentMiddleName As TextBox
    Friend WithEvents txtbxStudentProvince As TextBox
    Friend WithEvents txtbxStudentCountry As TextBox
    Friend WithEvents txtbxStudentZIP As TextBox
    Friend WithEvents lblStudentBirthday As Label
    Friend WithEvents dtStudentBirthday As DateTimePicker
    Friend WithEvents nudStudentAge As NumericUpDown
    Friend WithEvents txtStudentAge As Label
End Class
