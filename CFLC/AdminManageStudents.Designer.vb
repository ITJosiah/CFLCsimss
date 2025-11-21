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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.grpAddress = New System.Windows.Forms.GroupBox()
        Me.txtbxZipCode = New System.Windows.Forms.TextBox()
        Me.lblStudentZIP = New System.Windows.Forms.Label()
        Me.txtbxStudentBarangay = New System.Windows.Forms.TextBox()
        Me.lblStudentBarangay = New System.Windows.Forms.Label()
        Me.txtbxCountry = New System.Windows.Forms.TextBox()
        Me.lblStudentCountry = New System.Windows.Forms.Label()
        Me.txtbxStudentCity = New System.Windows.Forms.TextBox()
        Me.lblStudentCity = New System.Windows.Forms.Label()
        Me.txtbcStudentStreet = New System.Windows.Forms.TextBox()
        Me.lblStudentStreet = New System.Windows.Forms.Label()
        Me.txtbxStudentHouseNo = New System.Windows.Forms.TextBox()
        Me.lblStudentHouseNumber = New System.Windows.Forms.Label()
        Me.grpStudentInfo = New System.Windows.Forms.GroupBox()
        Me.dtpStudentBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblStudentGender = New System.Windows.Forms.Label()
        Me.lblStudentAge = New System.Windows.Forms.Label()
        Me.txtbxStudentParentName = New System.Windows.Forms.TextBox()
        Me.lblStudentParentName = New System.Windows.Forms.Label()
        Me.txtbxStudentReligion = New System.Windows.Forms.TextBox()
        Me.lblStudentReligion = New System.Windows.Forms.Label()
        Me.txtbxStudentEnrollmentID = New System.Windows.Forms.TextBox()
        Me.lblStudentSectionID = New System.Windows.Forms.Label()
        Me.txtbxStudentSectionID = New System.Windows.Forms.TextBox()
        Me.lblStudentGradeLevel = New System.Windows.Forms.Label()
        Me.txtbxStudentSurname = New System.Windows.Forms.TextBox()
        Me.lblStudentSurname = New System.Windows.Forms.Label()
        Me.txtStudentMiddleName = New System.Windows.Forms.TextBox()
        Me.lblStudentMiddleName = New System.Windows.Forms.Label()
        Me.txtbxStudentFirstName = New System.Windows.Forms.TextBox()
        Me.lblStudentFirstName = New System.Windows.Forms.Label()
        Me.lblStudentList = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.cmbStudenttGender = New System.Windows.Forms.ComboBox()
        Me.nudStudentAge = New System.Windows.Forms.NumericUpDown()
        Me.lblStudentEnrollmentID = New System.Windows.Forms.Label()
        Me.nudStudentGradeLevel = New System.Windows.Forms.NumericUpDown()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblStudentProvince = New System.Windows.Forms.Label()
        Me.txtbxStudentProvince = New System.Windows.Forms.TextBox()
        Me.pnlSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAddress.SuspendLayout()
        Me.grpStudentInfo.SuspendLayout()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStudentAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStudentGradeLevel, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.btnDelete)
        Me.pnlContent.Controls.Add(Me.btnUpdate)
        Me.pnlContent.Controls.Add(Me.btnAdd)
        Me.pnlContent.Controls.Add(Me.dgvStudents)
        Me.pnlContent.Controls.Add(Me.grpAddress)
        Me.pnlContent.Controls.Add(Me.grpStudentInfo)
        Me.pnlContent.Controls.Add(Me.lblStudentList)
        Me.pnlContent.Controls.Add(Me.btnSearch)
        Me.pnlContent.Controls.Add(Me.picWatermark)
        Me.pnlContent.Location = New System.Drawing.Point(300, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlContent.Size = New System.Drawing.Size(1000, 633)
        Me.pnlContent.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(908, 585)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 35)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Location = New System.Drawing.Point(796, 585)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(86, 35)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(684, 585)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 35)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvStudents
        '
        Me.dgvStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(33, 418)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.Size = New System.Drawing.Size(934, 150)
        Me.dgvStudents.TabIndex = 6
        '
        'grpAddress
        '
        Me.grpAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAddress.BackColor = System.Drawing.Color.Gainsboro
        Me.grpAddress.Controls.Add(Me.txtbxZipCode)
        Me.grpAddress.Controls.Add(Me.lblStudentZIP)
        Me.grpAddress.Controls.Add(Me.txtbxStudentProvince)
        Me.grpAddress.Controls.Add(Me.lblStudentProvince)
        Me.grpAddress.Controls.Add(Me.txtbxStudentBarangay)
        Me.grpAddress.Controls.Add(Me.lblStudentBarangay)
        Me.grpAddress.Controls.Add(Me.txtbxCountry)
        Me.grpAddress.Controls.Add(Me.lblStudentCountry)
        Me.grpAddress.Controls.Add(Me.txtbxStudentCity)
        Me.grpAddress.Controls.Add(Me.lblStudentCity)
        Me.grpAddress.Controls.Add(Me.txtbcStudentStreet)
        Me.grpAddress.Controls.Add(Me.lblStudentStreet)
        Me.grpAddress.Controls.Add(Me.txtbxStudentHouseNo)
        Me.grpAddress.Controls.Add(Me.lblStudentHouseNumber)
        Me.grpAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAddress.ForeColor = System.Drawing.Color.Black
        Me.grpAddress.Location = New System.Drawing.Point(33, 230)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(934, 175)
        Me.grpAddress.TabIndex = 4
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address"
        '
        'txtbxZipCode
        '
        Me.txtbxZipCode.Location = New System.Drawing.Point(650, 47)
        Me.txtbxZipCode.Name = "txtbxZipCode"
        Me.txtbxZipCode.Size = New System.Drawing.Size(180, 23)
        Me.txtbxZipCode.TabIndex = 13
        '
        'lblStudentZIP
        '
        Me.lblStudentZIP.AutoSize = True
        Me.lblStudentZIP.Location = New System.Drawing.Point(647, 27)
        Me.lblStudentZIP.Name = "lblStudentZIP"
        Me.lblStudentZIP.Size = New System.Drawing.Size(65, 17)
        Me.lblStudentZIP.TabIndex = 12
        Me.lblStudentZIP.Text = "Zip Code"
        '
        'txtbxStudentBarangay
        '
        Me.txtbxStudentBarangay.Location = New System.Drawing.Point(55, 136)
        Me.txtbxStudentBarangay.Name = "txtbxStudentBarangay"
        Me.txtbxStudentBarangay.Size = New System.Drawing.Size(230, 23)
        Me.txtbxStudentBarangay.TabIndex = 9
        '
        'lblStudentBarangay
        '
        Me.lblStudentBarangay.AutoSize = True
        Me.lblStudentBarangay.Location = New System.Drawing.Point(52, 116)
        Me.lblStudentBarangay.Name = "lblStudentBarangay"
        Me.lblStudentBarangay.Size = New System.Drawing.Size(69, 17)
        Me.lblStudentBarangay.TabIndex = 8
        Me.lblStudentBarangay.Text = "Barangay"
        '
        'txtbxCountry
        '
        Me.txtbxCountry.Location = New System.Drawing.Point(359, 136)
        Me.txtbxCountry.Name = "txtbxCountry"
        Me.txtbxCountry.Size = New System.Drawing.Size(230, 23)
        Me.txtbxCountry.TabIndex = 7
        '
        'lblStudentCountry
        '
        Me.lblStudentCountry.AutoSize = True
        Me.lblStudentCountry.Location = New System.Drawing.Point(357, 116)
        Me.lblStudentCountry.Name = "lblStudentCountry"
        Me.lblStudentCountry.Size = New System.Drawing.Size(57, 17)
        Me.lblStudentCountry.TabIndex = 6
        Me.lblStudentCountry.Text = "Country"
        '
        'txtbxStudentCity
        '
        Me.txtbxStudentCity.Location = New System.Drawing.Point(360, 47)
        Me.txtbxStudentCity.Name = "txtbxStudentCity"
        Me.txtbxStudentCity.Size = New System.Drawing.Size(230, 23)
        Me.txtbxStudentCity.TabIndex = 5
        '
        'lblStudentCity
        '
        Me.lblStudentCity.AutoSize = True
        Me.lblStudentCity.Location = New System.Drawing.Point(357, 28)
        Me.lblStudentCity.Name = "lblStudentCity"
        Me.lblStudentCity.Size = New System.Drawing.Size(116, 17)
        Me.lblStudentCity.TabIndex = 4
        Me.lblStudentCity.Text = "City / Municipality"
        '
        'txtbcStudentStreet
        '
        Me.txtbcStudentStreet.Location = New System.Drawing.Point(55, 91)
        Me.txtbcStudentStreet.Name = "txtbcStudentStreet"
        Me.txtbcStudentStreet.Size = New System.Drawing.Size(230, 23)
        Me.txtbcStudentStreet.TabIndex = 3
        '
        'lblStudentStreet
        '
        Me.lblStudentStreet.AutoSize = True
        Me.lblStudentStreet.Location = New System.Drawing.Point(52, 74)
        Me.lblStudentStreet.Name = "lblStudentStreet"
        Me.lblStudentStreet.Size = New System.Drawing.Size(46, 17)
        Me.lblStudentStreet.TabIndex = 2
        Me.lblStudentStreet.Text = "Street"
        '
        'txtbxStudentHouseNo
        '
        Me.txtbxStudentHouseNo.Location = New System.Drawing.Point(55, 48)
        Me.txtbxStudentHouseNo.Name = "txtbxStudentHouseNo"
        Me.txtbxStudentHouseNo.Size = New System.Drawing.Size(230, 23)
        Me.txtbxStudentHouseNo.TabIndex = 1
        '
        'lblStudentHouseNumber
        '
        Me.lblStudentHouseNumber.AutoSize = True
        Me.lblStudentHouseNumber.Location = New System.Drawing.Point(52, 28)
        Me.lblStudentHouseNumber.Name = "lblStudentHouseNumber"
        Me.lblStudentHouseNumber.Size = New System.Drawing.Size(103, 17)
        Me.lblStudentHouseNumber.TabIndex = 0
        Me.lblStudentHouseNumber.Text = "House Number"
        '
        'grpStudentInfo
        '
        Me.grpStudentInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStudentInfo.BackColor = System.Drawing.Color.Gainsboro
        Me.grpStudentInfo.Controls.Add(Me.DateTimePicker1)
        Me.grpStudentInfo.Controls.Add(Me.nudStudentGradeLevel)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentEnrollmentID)
        Me.grpStudentInfo.Controls.Add(Me.nudStudentAge)
        Me.grpStudentInfo.Controls.Add(Me.cmbStudenttGender)
        Me.grpStudentInfo.Controls.Add(Me.dtpStudentBirthdate)
        Me.grpStudentInfo.Controls.Add(Me.Label11)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentGender)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentAge)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentParentName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentParentName)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentReligion)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentReligion)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentEnrollmentID)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentSectionID)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentSectionID)
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
        Me.grpStudentInfo.Size = New System.Drawing.Size(934, 167)
        Me.grpStudentInfo.TabIndex = 3
        Me.grpStudentInfo.TabStop = False
        Me.grpStudentInfo.Text = "Student List"
        '
        'dtpStudentBirthdate
        '
        Me.dtpStudentBirthdate.Location = New System.Drawing.Point(274, 129)
        Me.dtpStudentBirthdate.Name = "dtpStudentBirthdate"
        Me.dtpStudentBirthdate.Size = New System.Drawing.Size(218, 23)
        Me.dtpStudentBirthdate.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(289, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Birthdate"
        '
        'lblStudentGender
        '
        Me.lblStudentGender.AutoSize = True
        Me.lblStudentGender.Location = New System.Drawing.Point(289, 19)
        Me.lblStudentGender.Name = "lblStudentGender"
        Me.lblStudentGender.Size = New System.Drawing.Size(56, 17)
        Me.lblStudentGender.TabIndex = 19
        Me.lblStudentGender.Text = "Gender"
        '
        'lblStudentAge
        '
        Me.lblStudentAge.AutoSize = True
        Me.lblStudentAge.Location = New System.Drawing.Point(289, 68)
        Me.lblStudentAge.Name = "lblStudentAge"
        Me.lblStudentAge.Size = New System.Drawing.Size(33, 17)
        Me.lblStudentAge.TabIndex = 17
        Me.lblStudentAge.Text = "Age"
        '
        'txtbxStudentParentName
        '
        Me.txtbxStudentParentName.Location = New System.Drawing.Point(480, 37)
        Me.txtbxStudentParentName.Name = "txtbxStudentParentName"
        Me.txtbxStudentParentName.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentParentName.TabIndex = 16
        '
        'lblStudentParentName
        '
        Me.lblStudentParentName.AutoSize = True
        Me.lblStudentParentName.Location = New System.Drawing.Point(477, 24)
        Me.lblStudentParentName.Name = "lblStudentParentName"
        Me.lblStudentParentName.Size = New System.Drawing.Size(91, 17)
        Me.lblStudentParentName.TabIndex = 15
        Me.lblStudentParentName.Text = "Parent Name"
        '
        'txtbxStudentReligion
        '
        Me.txtbxStudentReligion.Location = New System.Drawing.Point(480, 84)
        Me.txtbxStudentReligion.Name = "txtbxStudentReligion"
        Me.txtbxStudentReligion.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentReligion.TabIndex = 14
        '
        'lblStudentReligion
        '
        Me.lblStudentReligion.AutoSize = True
        Me.lblStudentReligion.Location = New System.Drawing.Point(477, 68)
        Me.lblStudentReligion.Name = "lblStudentReligion"
        Me.lblStudentReligion.Size = New System.Drawing.Size(59, 17)
        Me.lblStudentReligion.TabIndex = 13
        Me.lblStudentReligion.Text = "Religion"
        '
        'txtbxStudentEnrollmentID
        '
        Me.txtbxStudentEnrollmentID.Location = New System.Drawing.Point(698, 87)
        Me.txtbxStudentEnrollmentID.Name = "txtbxStudentEnrollmentID"
        Me.txtbxStudentEnrollmentID.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentEnrollmentID.TabIndex = 12
        '
        'lblStudentSectionID
        '
        Me.lblStudentSectionID.AutoSize = True
        Me.lblStudentSectionID.Location = New System.Drawing.Point(698, 22)
        Me.lblStudentSectionID.Name = "lblStudentSectionID"
        Me.lblStudentSectionID.Size = New System.Drawing.Size(72, 17)
        Me.lblStudentSectionID.TabIndex = 11
        Me.lblStudentSectionID.Text = "Section ID"
        '
        'txtbxStudentSectionID
        '
        Me.txtbxStudentSectionID.Location = New System.Drawing.Point(700, 40)
        Me.txtbxStudentSectionID.Name = "txtbxStudentSectionID"
        Me.txtbxStudentSectionID.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentSectionID.TabIndex = 10
        '
        'lblStudentGradeLevel
        '
        Me.lblStudentGradeLevel.AutoSize = True
        Me.lblStudentGradeLevel.Location = New System.Drawing.Point(509, 109)
        Me.lblStudentGradeLevel.Name = "lblStudentGradeLevel"
        Me.lblStudentGradeLevel.Size = New System.Drawing.Size(86, 17)
        Me.lblStudentGradeLevel.TabIndex = 9
        Me.lblStudentGradeLevel.Text = "Grade Level"
        '
        'txtbxStudentSurname
        '
        Me.txtbxStudentSurname.Location = New System.Drawing.Point(55, 130)
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
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(569, 585)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 35)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'picWatermark
        '
        Me.picWatermark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(205, 79)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(520, 466)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 5
        Me.picWatermark.TabStop = False
        '
        'cmbStudenttGender
        '
        Me.cmbStudenttGender.FormattingEnabled = True
        Me.cmbStudenttGender.Location = New System.Drawing.Point(292, 37)
        Me.cmbStudenttGender.Name = "cmbStudenttGender"
        Me.cmbStudenttGender.Size = New System.Drawing.Size(103, 24)
        Me.cmbStudenttGender.TabIndex = 23
        '
        'nudStudentAge
        '
        Me.nudStudentAge.Location = New System.Drawing.Point(292, 84)
        Me.nudStudentAge.Name = "nudStudentAge"
        Me.nudStudentAge.Size = New System.Drawing.Size(35, 23)
        Me.nudStudentAge.TabIndex = 24
        '
        'lblStudentEnrollmentID
        '
        Me.lblStudentEnrollmentID.AutoSize = True
        Me.lblStudentEnrollmentID.Location = New System.Drawing.Point(698, 68)
        Me.lblStudentEnrollmentID.Name = "lblStudentEnrollmentID"
        Me.lblStudentEnrollmentID.Size = New System.Drawing.Size(92, 17)
        Me.lblStudentEnrollmentID.TabIndex = 26
        Me.lblStudentEnrollmentID.Text = "Enrollment ID"
        '
        'nudStudentGradeLevel
        '
        Me.nudStudentGradeLevel.Location = New System.Drawing.Point(512, 129)
        Me.nudStudentGradeLevel.Name = "nudStudentGradeLevel"
        Me.nudStudentGradeLevel.Size = New System.Drawing.Size(35, 23)
        Me.nudStudentGradeLevel.TabIndex = 27
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(394, 131)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(8, 23)
        Me.DateTimePicker1.TabIndex = 28
        '
        'lblStudentProvince
        '
        Me.lblStudentProvince.AutoSize = True
        Me.lblStudentProvince.Location = New System.Drawing.Point(356, 74)
        Me.lblStudentProvince.Name = "lblStudentProvince"
        Me.lblStudentProvince.Size = New System.Drawing.Size(63, 17)
        Me.lblStudentProvince.TabIndex = 10
        Me.lblStudentProvince.Text = "Province"
        '
        'txtbxStudentProvince
        '
        Me.txtbxStudentProvince.Location = New System.Drawing.Point(359, 94)
        Me.txtbxStudentProvince.Name = "txtbxStudentProvince"
        Me.txtbxStudentProvince.Size = New System.Drawing.Size(230, 23)
        Me.txtbxStudentProvince.TabIndex = 11
        '
        'AdminManageStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 633)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AdminManageStudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin - Manage Students"
        Me.pnlSidebar.ResumeLayout(False)
        Me.flowButtons.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAddress.ResumeLayout(False)
        Me.grpAddress.PerformLayout()
        Me.grpStudentInfo.ResumeLayout(False)
        Me.grpStudentInfo.PerformLayout()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStudentAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStudentGradeLevel, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents grpStudentInfo As GroupBox
    Friend WithEvents dtpStudentBirthdate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents lblStudentGender As Label
    Friend WithEvents lblStudentAge As Label
    Friend WithEvents txtbxStudentParentName As TextBox
    Friend WithEvents lblStudentParentName As Label
    Friend WithEvents txtbxStudentReligion As TextBox
    Friend WithEvents lblStudentReligion As Label
    Friend WithEvents txtbxStudentEnrollmentID As TextBox
    Friend WithEvents lblStudentSectionID As Label
    Friend WithEvents txtbxStudentSectionID As TextBox
    Friend WithEvents lblStudentGradeLevel As Label
    Friend WithEvents txtbxStudentSurname As TextBox
    Friend WithEvents lblStudentSurname As Label
    Friend WithEvents txtStudentMiddleName As TextBox
    Friend WithEvents lblStudentMiddleName As Label
    Friend WithEvents txtbxStudentFirstName As TextBox
    Friend WithEvents lblStudentFirstName As Label
    Friend WithEvents lblStudentList As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents grpAddress As GroupBox
    Friend WithEvents txtbxZipCode As TextBox
    Friend WithEvents lblStudentZIP As Label
    Friend WithEvents txtbxStudentBarangay As TextBox
    Friend WithEvents lblStudentBarangay As Label
    Friend WithEvents txtbxCountry As TextBox
    Friend WithEvents lblStudentCountry As Label
    Friend WithEvents txtbxStudentCity As TextBox
    Friend WithEvents lblStudentCity As Label
    Friend WithEvents txtbcStudentStreet As TextBox
    Friend WithEvents lblStudentStreet As Label
    Friend WithEvents txtbxStudentHouseNo As TextBox
    Friend WithEvents lblStudentHouseNumber As Label
    Friend WithEvents cmbStudenttGender As ComboBox
    Friend WithEvents lblStudentEnrollmentID As Label
    Friend WithEvents nudStudentAge As NumericUpDown
    Friend WithEvents nudStudentGradeLevel As NumericUpDown
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtbxStudentProvince As TextBox
    Friend WithEvents lblStudentProvince As Label
End Class
