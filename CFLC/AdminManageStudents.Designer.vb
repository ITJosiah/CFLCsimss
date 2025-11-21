<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminManageStudents
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
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.grpAddress = New System.Windows.Forms.GroupBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSubdivision = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtHouseNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grpStudentInfo = New System.Windows.Forms.GroupBox()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtParentName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtReligion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSectionId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGradeLevel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudentNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblStudentSurname = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.lblStudentMiddleName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblStudentFirstName = New System.Windows.Forms.Label()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblStudentList = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.pnlSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAddress.SuspendLayout()
        Me.grpStudentInfo.SuspendLayout()
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
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
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
        Me.pnlContent.Controls.Add(Me.txtSearch)
        Me.pnlContent.Controls.Add(Me.picWatermark)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(400, 0)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(40, 37, 40, 37)
        Me.pnlContent.Size = New System.Drawing.Size(1333, 779)
        Me.pnlContent.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(1211, 720)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(115, 43)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvStudents
        '
        Me.dgvStudents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(44, 514)
        Me.dgvStudents.Margin = New System.Windows.Forms.Padding(4)
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
        Me.grpAddress.Controls.Add(Me.txtZipCode)
        Me.grpAddress.Controls.Add(Me.Label18)
        Me.grpAddress.Controls.Add(Me.txtCity)
        Me.grpAddress.Controls.Add(Me.Label17)
        Me.grpAddress.Controls.Add(Me.txtStreet)
        Me.grpAddress.Controls.Add(Me.Label16)
        Me.grpAddress.Controls.Add(Me.txtCountry)
        Me.grpAddress.Controls.Add(Me.Label15)
        Me.grpAddress.Controls.Add(Me.txtProvince)
        Me.grpAddress.Controls.Add(Me.Label14)
        Me.grpAddress.Controls.Add(Me.txtSubdivision)
        Me.grpAddress.Controls.Add(Me.Label13)
        Me.grpAddress.Controls.Add(Me.txtHouseNo)
        Me.grpAddress.Controls.Add(Me.Label12)
        Me.grpAddress.ForeColor = System.Drawing.Color.Black
        Me.grpAddress.Location = New System.Drawing.Point(44, 283)
        Me.grpAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Padding = New System.Windows.Forms.Padding(4)
        Me.grpAddress.Size = New System.Drawing.Size(1245, 215)
        Me.grpAddress.TabIndex = 4
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(867, 54)
        Me.txtZipCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(239, 22)
        Me.txtZipCode.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(863, 34)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 16)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Zip Code"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(480, 112)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(305, 22)
        Me.txtCity.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(477, 92)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 16)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "City / Municipality"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(53, 162)
        Me.txtStreet.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(305, 22)
        Me.txtStreet.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(49, 143)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 16)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Street / Purok / Sitio"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(480, 162)
        Me.txtCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(305, 22)
        Me.txtCountry.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(483, 143)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 16)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Country"
        '
        'txtProvince
        '
        Me.txtProvince.Location = New System.Drawing.Point(480, 54)
        Me.txtProvince.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(305, 22)
        Me.txtProvince.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(477, 34)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Province"
        '
        'txtSubdivision
        '
        Me.txtSubdivision.Location = New System.Drawing.Point(53, 112)
        Me.txtSubdivision.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubdivision.Name = "txtSubdivision"
        Me.txtSubdivision.Size = New System.Drawing.Size(305, 22)
        Me.txtSubdivision.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(49, 92)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(198, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Subdivision / Village / Barangay"
        '
        'txtHouseNo
        '
        Me.txtHouseNo.Location = New System.Drawing.Point(53, 54)
        Me.txtHouseNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.Size = New System.Drawing.Size(305, 22)
        Me.txtHouseNo.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(49, 34)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "House No. / Lot No. / Block"
        '
        'grpStudentInfo
        '
        Me.grpStudentInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStudentInfo.BackColor = System.Drawing.Color.Gainsboro
        Me.grpStudentInfo.Controls.Add(Me.dtpBirthdate)
        Me.grpStudentInfo.Controls.Add(Me.Label11)
        Me.grpStudentInfo.Controls.Add(Me.txtGender)
        Me.grpStudentInfo.Controls.Add(Me.Label10)
        Me.grpStudentInfo.Controls.Add(Me.txtAge)
        Me.grpStudentInfo.Controls.Add(Me.Label9)
        Me.grpStudentInfo.Controls.Add(Me.txtParentName)
        Me.grpStudentInfo.Controls.Add(Me.Label8)
        Me.grpStudentInfo.Controls.Add(Me.txtReligion)
        Me.grpStudentInfo.Controls.Add(Me.Label7)
        Me.grpStudentInfo.Controls.Add(Me.txtSectionId)
        Me.grpStudentInfo.Controls.Add(Me.Label6)
        Me.grpStudentInfo.Controls.Add(Me.txtGradeLevel)
        Me.grpStudentInfo.Controls.Add(Me.Label5)
        Me.grpStudentInfo.Controls.Add(Me.txtStudentNo)
        Me.grpStudentInfo.Controls.Add(Me.Label4)
        Me.grpStudentInfo.Controls.Add(Me.txtSurname)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentSurname)
        Me.grpStudentInfo.Controls.Add(Me.txtMiddleName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentMiddleName)
        Me.grpStudentInfo.Controls.Add(Me.txtFirstName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentFirstName)
        Me.grpStudentInfo.Controls.Add(Me.txtStudentId)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentID)
        Me.grpStudentInfo.Location = New System.Drawing.Point(44, 98)
        Me.grpStudentInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.grpStudentInfo.Name = "grpStudentInfo"
        Me.grpStudentInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.grpStudentInfo.Size = New System.Drawing.Size(1245, 215)
        Me.grpStudentInfo.TabIndex = 3
        Me.grpStudentInfo.TabStop = False
        Me.grpStudentInfo.Text = "Student List"
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.Location = New System.Drawing.Point(933, 158)
        Me.dtpBirthdate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(265, 22)
        Me.dtpBirthdate.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(929, 135)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Birthdate"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(933, 103)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(159, 22)
        Me.txtGender.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(929, 84)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Gender"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(933, 47)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(159, 22)
        Me.txtAge.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(929, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Age"
        '
        'txtParentName
        '
        Me.txtParentName.Location = New System.Drawing.Point(640, 158)
        Me.txtParentName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtParentName.Name = "txtParentName"
        Me.txtParentName.Size = New System.Drawing.Size(252, 22)
        Me.txtParentName.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(636, 135)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Parent Name"
        '
        'txtReligion
        '
        Me.txtReligion.Location = New System.Drawing.Point(640, 103)
        Me.txtReligion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.Size = New System.Drawing.Size(252, 22)
        Me.txtReligion.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(636, 84)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Religion"
        '
        'txtSectionId
        '
        Me.txtSectionId.Location = New System.Drawing.Point(640, 47)
        Me.txtSectionId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSectionId.Name = "txtSectionId"
        Me.txtSectionId.Size = New System.Drawing.Size(252, 22)
        Me.txtSectionId.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(636, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Section ID"
        '
        'txtGradeLevel
        '
        Me.txtGradeLevel.Location = New System.Drawing.Point(347, 158)
        Me.txtGradeLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGradeLevel.Name = "txtGradeLevel"
        Me.txtGradeLevel.Size = New System.Drawing.Size(252, 22)
        Me.txtGradeLevel.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 135)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Grade Level"
        '
        'txtStudentNo
        '
        Me.txtStudentNo.Location = New System.Drawing.Point(347, 103)
        Me.txtStudentNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.Size = New System.Drawing.Size(252, 22)
        Me.txtStudentNo.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 84)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Student No."
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(53, 158)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(252, 22)
        Me.txtSurname.TabIndex = 6
        '
        'lblStudentSurname
        '
        Me.lblStudentSurname.AutoSize = True
        Me.lblStudentSurname.Location = New System.Drawing.Point(49, 135)
        Me.lblStudentSurname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentSurname.Name = "lblStudentSurname"
        Me.lblStudentSurname.Size = New System.Drawing.Size(61, 16)
        Me.lblStudentSurname.TabIndex = 5
        Me.lblStudentSurname.Text = "Surname"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(347, 47)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(252, 22)
        Me.txtMiddleName.TabIndex = 4
        '
        'lblStudentMiddleName
        '
        Me.lblStudentMiddleName.AutoSize = True
        Me.lblStudentMiddleName.Location = New System.Drawing.Point(343, 27)
        Me.lblStudentMiddleName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentMiddleName.Name = "lblStudentMiddleName"
        Me.lblStudentMiddleName.Size = New System.Drawing.Size(88, 16)
        Me.lblStudentMiddleName.TabIndex = 3
        Me.lblStudentMiddleName.Text = "Middle Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(53, 103)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(252, 22)
        Me.txtFirstName.TabIndex = 2
        '
        'lblStudentFirstName
        '
        Me.lblStudentFirstName.AutoSize = True
        Me.lblStudentFirstName.Location = New System.Drawing.Point(49, 84)
        Me.lblStudentFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentFirstName.Name = "lblStudentFirstName"
        Me.lblStudentFirstName.Size = New System.Drawing.Size(72, 16)
        Me.lblStudentFirstName.TabIndex = 1
        Me.lblStudentFirstName.Text = "First Name"
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(53, 47)
        Me.txtStudentId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(252, 22)
        Me.txtStudentId.TabIndex = 0
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(49, 27)
        Me.lblStudentID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(68, 16)
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
        Me.btnSearch.Location = New System.Drawing.Point(1200, 34)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(89, 32)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(839, 39)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(264, 22)
        Me.txtSearch.TabIndex = 0
        '
        'picWatermark
        '
        Me.picWatermark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(273, 97)
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
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1733, 779)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtParentName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtReligion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSectionId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGradeLevel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStudentNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblStudentSurname As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents lblStudentMiddleName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblStudentFirstName As Label
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblStudentList As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents grpAddress As GroupBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtProvince As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSubdivision As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtHouseNo As TextBox
    Friend WithEvents Label12 As Label
End Class
