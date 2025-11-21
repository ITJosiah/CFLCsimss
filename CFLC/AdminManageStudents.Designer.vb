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
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(40, 49, 40, 49)
        Me.pnlSidebar.Size = New System.Drawing.Size(400, 779)
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
        Me.flowButtons.Size = New System.Drawing.Size(320, 619)
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
        Me.btnLogout.Size = New System.Drawing.Size(320, 62)
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
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(30, 30, 30, 30)
        Me.pnlContent.Size = New System.Drawing.Size(1000, 633)
        Me.pnlContent.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(1211, 720)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(115, 43)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Location = New System.Drawing.Point(1061, 720)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(115, 43)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(912, 720)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(115, 43)
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
        Me.dgvStudents.Location = New System.Drawing.Point(44, 514)
        Me.dgvStudents.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.Size = New System.Drawing.Size(1245, 185)
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
        Me.grpAddress.Location = New System.Drawing.Point(44, 283)
        Me.grpAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpAddress.Size = New System.Drawing.Size(1245, 215)
        Me.grpAddress.TabIndex = 4
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address"
        '
        'txtbxZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(650, 44)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(180, 20)
        Me.txtZipCode.TabIndex = 13
        '
        'lblStudentZIP
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(647, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 13)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Zip Code"
        '
        'txtbxStudentBarangay
        '
        Me.txtCity.Location = New System.Drawing.Point(360, 91)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(230, 20)
        Me.txtCity.TabIndex = 11
        '
        'lblStudentBarangay
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(358, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Province"
        '
        'txtbxCountry
        '
        Me.txtStreet.Location = New System.Drawing.Point(40, 132)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(230, 20)
        Me.txtStreet.TabIndex = 9
        '
        'lblStudentCountry
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(37, 116)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Barangay"
        '
        'txtbxStudentCity
        '
        Me.txtCountry.Location = New System.Drawing.Point(360, 132)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(230, 20)
        Me.txtCountry.TabIndex = 7
        '
        'lblStudentCity
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(362, 116)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Country"
        '
        'txtbcStudentStreet
        '
        Me.txtProvince.Location = New System.Drawing.Point(360, 44)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(230, 20)
        Me.txtProvince.TabIndex = 5
        '
        'lblStudentStreet
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(358, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "City / Municipality"
        '
        'txtbxStudentHouseNo
        '
        Me.txtSubdivision.Location = New System.Drawing.Point(40, 91)
        Me.txtSubdivision.Name = "txtSubdivision"
        Me.txtSubdivision.Size = New System.Drawing.Size(230, 20)
        Me.txtSubdivision.TabIndex = 3
        '
        'lblStudentHouseNumber
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(37, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Street"
        '
        'txtHouseNo
        '
        Me.txtHouseNo.Location = New System.Drawing.Point(40, 44)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.Size = New System.Drawing.Size(230, 20)
        Me.txtHouseNo.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "House Number"
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
        Me.grpStudentInfo.Controls.Add(Me.txtStudentId)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentID)
        Me.grpStudentInfo.Location = New System.Drawing.Point(33, 80)
        Me.grpStudentInfo.Name = "grpStudentInfo"
        Me.grpStudentInfo.Size = New System.Drawing.Size(934, 175)
        Me.grpStudentInfo.TabIndex = 3
        Me.grpStudentInfo.TabStop = False
        Me.grpStudentInfo.Text = "Student List"
        '
        'dtpStudentBirthdate
        '
        Me.dtpBirthdate.Location = New System.Drawing.Point(700, 128)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(200, 20)
        Me.dtpBirthdate.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(697, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Birthdate"
        '
        'lblStudentGender
        '
        Me.txtGender.Location = New System.Drawing.Point(700, 84)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(120, 20)
        Me.txtGender.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(697, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Gender"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(700, 38)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(120, 20)
        Me.txtAge.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(697, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Age"
        '
        'txtParentName
        '
        Me.txtParentName.Location = New System.Drawing.Point(480, 128)
        Me.txtParentName.Name = "txtParentName"
        Me.txtParentName.Size = New System.Drawing.Size(190, 20)
        Me.txtParentName.TabIndex = 16
        '
        'lblStudentAge
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(477, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Parent Name"
        '
        'txtbxStudentParentName
        '
        Me.txtReligion.Location = New System.Drawing.Point(480, 84)
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.Size = New System.Drawing.Size(190, 20)
        Me.txtReligion.TabIndex = 14
        '
        'lblStudentParentName
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(477, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Religion"
        '
        'txtbxStudentReligion
        '
        Me.txtSectionId.Location = New System.Drawing.Point(480, 38)
        Me.txtSectionId.Name = "txtSectionId"
        Me.txtSectionId.Size = New System.Drawing.Size(190, 20)
        Me.txtSectionId.TabIndex = 12
        '
        'lblStudentReligion
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(477, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Section ID"
        '
        'txtbxStudentEnrollmentID
        '
        Me.txtGradeLevel.Location = New System.Drawing.Point(260, 128)
        Me.txtGradeLevel.Name = "txtGradeLevel"
        Me.txtGradeLevel.Size = New System.Drawing.Size(190, 20)
        Me.txtGradeLevel.TabIndex = 10
        '
        'lblStudentSectionID
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Grade Level"
        '
        'txtbxStudentSectionID
        '
        Me.txtStudentNo.Location = New System.Drawing.Point(260, 84)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.Size = New System.Drawing.Size(190, 20)
        Me.txtStudentNo.TabIndex = 8
        '
        'lblStudentGradeLevel
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Student No."
        '
        'txtbxStudentSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(40, 128)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(190, 20)
        Me.txtSurname.TabIndex = 6
        '
        'lblStudentSurname
        '
        Me.lblStudentSurname.AutoSize = True
        Me.lblStudentSurname.Location = New System.Drawing.Point(37, 110)
        Me.lblStudentSurname.Name = "lblStudentSurname"
        Me.lblStudentSurname.Size = New System.Drawing.Size(49, 13)
        Me.lblStudentSurname.TabIndex = 5
        Me.lblStudentSurname.Text = "Surname"
        '
        'txtStudentMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(260, 38)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(190, 20)
        Me.txtMiddleName.TabIndex = 4
        '
        'lblStudentMiddleName
        '
        Me.lblStudentMiddleName.AutoSize = True
        Me.lblStudentMiddleName.Location = New System.Drawing.Point(257, 22)
        Me.lblStudentMiddleName.Name = "lblStudentMiddleName"
        Me.lblStudentMiddleName.Size = New System.Drawing.Size(69, 13)
        Me.lblStudentMiddleName.TabIndex = 3
        Me.lblStudentMiddleName.Text = "Middle Name"
        '
        'txtbxStudentFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(40, 84)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(190, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'lblStudentFirstName
        '
        Me.lblStudentFirstName.AutoSize = True
        Me.lblStudentFirstName.Location = New System.Drawing.Point(37, 68)
        Me.lblStudentFirstName.Name = "lblStudentFirstName"
        Me.lblStudentFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblStudentFirstName.TabIndex = 1
        Me.lblStudentFirstName.Text = "First Name"
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(40, 38)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(190, 20)
        Me.txtStudentId.TabIndex = 0
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(37, 22)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(58, 13)
        Me.lblStudentID.TabIndex = 23
        Me.lblStudentID.Text = "Student ID"
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
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(900, 28)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(67, 26)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(629, 32)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(199, 20)
        Me.txtSearch.TabIndex = 0
        '
        'picWatermark
        '
        Me.picWatermark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(273, 97)
        Me.picWatermark.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(693, 574)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1733, 779)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
