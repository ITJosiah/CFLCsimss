<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminManageTeacher
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
        Me.grpTeacherInfo = New System.Windows.Forms.GroupBox()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAssignedSection = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHireDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSpecialization = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEducationalAttainment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmployeeNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtTeacherId = New System.Windows.Forms.TextBox()
        Me.lblTeacherID = New System.Windows.Forms.Label()
        Me.lblTeacherList = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvTeacher = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.flowButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnManageStudents = New System.Windows.Forms.Button()
        Me.btnManageTeachers = New System.Windows.Forms.Button()
        Me.btnManageSections = New System.Windows.Forms.Button()
        Me.btnManageEnrollments = New System.Windows.Forms.Button()
        Me.btnManageSubjects = New System.Windows.Forms.Button()
        Me.btnGenerateReports = New System.Windows.Forms.Button()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.grpAddress.SuspendLayout()
        Me.grpTeacherInfo.SuspendLayout()
        CType(Me.dgvTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flowButtons.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
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
        Me.grpAddress.Location = New System.Drawing.Point(332, 234)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(934, 175)
        Me.grpAddress.TabIndex = 4
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(650, 44)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(180, 20)
        Me.txtZipCode.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(647, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 13)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Zip Code"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(360, 91)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(230, 20)
        Me.txtCity.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(358, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "City / Municipality"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(40, 132)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(230, 20)
        Me.txtStreet.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(37, 116)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Street / Purok / Sitio"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(360, 132)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(230, 20)
        Me.txtCountry.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(362, 116)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Country"
        '
        'txtProvince
        '
        Me.txtProvince.Location = New System.Drawing.Point(360, 44)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(230, 20)
        Me.txtProvince.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(358, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Province"
        '
        'txtSubdivision
        '
        Me.txtSubdivision.Location = New System.Drawing.Point(40, 91)
        Me.txtSubdivision.Name = "txtSubdivision"
        Me.txtSubdivision.Size = New System.Drawing.Size(230, 20)
        Me.txtSubdivision.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(37, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(159, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Subdivision / Village / Barangay"
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
        Me.Label12.Size = New System.Drawing.Size(142, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "House No. / Lot No. / Block"
        '
        'grpTeacherInfo
        '
        Me.grpTeacherInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTeacherInfo.BackColor = System.Drawing.Color.Gainsboro
        Me.grpTeacherInfo.Controls.Add(Me.ComboBoxGender)
        Me.grpTeacherInfo.Controls.Add(Me.Label11)
        Me.grpTeacherInfo.Controls.Add(Me.txtAssignedSection)
        Me.grpTeacherInfo.Controls.Add(Me.Label10)
        Me.grpTeacherInfo.Controls.Add(Me.txtStatus)
        Me.grpTeacherInfo.Controls.Add(Me.Label9)
        Me.grpTeacherInfo.Controls.Add(Me.txtHireDate)
        Me.grpTeacherInfo.Controls.Add(Me.Label8)
        Me.grpTeacherInfo.Controls.Add(Me.txtSpecialization)
        Me.grpTeacherInfo.Controls.Add(Me.Label7)
        Me.grpTeacherInfo.Controls.Add(Me.txtEducationalAttainment)
        Me.grpTeacherInfo.Controls.Add(Me.Label6)
        Me.grpTeacherInfo.Controls.Add(Me.txtEmail)
        Me.grpTeacherInfo.Controls.Add(Me.Label5)
        Me.grpTeacherInfo.Controls.Add(Me.txtEmployeeNo)
        Me.grpTeacherInfo.Controls.Add(Me.Label4)
        Me.grpTeacherInfo.Controls.Add(Me.txtSurname)
        Me.grpTeacherInfo.Controls.Add(Me.Label3)
        Me.grpTeacherInfo.Controls.Add(Me.txtMiddleName)
        Me.grpTeacherInfo.Controls.Add(Me.Label2)
        Me.grpTeacherInfo.Controls.Add(Me.txtFirstName)
        Me.grpTeacherInfo.Controls.Add(Me.lblFirstName)
        Me.grpTeacherInfo.Controls.Add(Me.txtTeacherId)
        Me.grpTeacherInfo.Controls.Add(Me.lblTeacherID)
        Me.grpTeacherInfo.Location = New System.Drawing.Point(332, 84)
        Me.grpTeacherInfo.Name = "grpTeacherInfo"
        Me.grpTeacherInfo.Size = New System.Drawing.Size(934, 175)
        Me.grpTeacherInfo.TabIndex = 3
        Me.grpTeacherInfo.TabStop = False
        Me.grpTeacherInfo.Text = "Teacher List"
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxGender.Location = New System.Drawing.Point(700, 126)
        Me.ComboBoxGender.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(54, 21)
        Me.ComboBoxGender.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(697, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Gender"
        '
        'txtAssignedSection
        '
        Me.txtAssignedSection.Location = New System.Drawing.Point(700, 84)
        Me.txtAssignedSection.Name = "txtAssignedSection"
        Me.txtAssignedSection.Size = New System.Drawing.Size(120, 20)
        Me.txtAssignedSection.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(697, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Assigned Section"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(700, 38)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(120, 20)
        Me.txtStatus.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(697, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Status"
        '
        'txtHireDate
        '
        Me.txtHireDate.Location = New System.Drawing.Point(480, 128)
        Me.txtHireDate.Name = "txtHireDate"
        Me.txtHireDate.Size = New System.Drawing.Size(190, 20)
        Me.txtHireDate.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(477, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Hire Date"
        '
        'txtSpecialization
        '
        Me.txtSpecialization.Location = New System.Drawing.Point(480, 84)
        Me.txtSpecialization.Name = "txtSpecialization"
        Me.txtSpecialization.Size = New System.Drawing.Size(190, 20)
        Me.txtSpecialization.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(477, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Specialization"
        '
        'txtEducationalAttainment
        '
        Me.txtEducationalAttainment.Location = New System.Drawing.Point(480, 38)
        Me.txtEducationalAttainment.Name = "txtEducationalAttainment"
        Me.txtEducationalAttainment.Size = New System.Drawing.Size(190, 20)
        Me.txtEducationalAttainment.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(477, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Educational Attainment"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(260, 128)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(190, 20)
        Me.txtEmail.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Email"
        '
        'txtEmployeeNo
        '
        Me.txtEmployeeNo.Location = New System.Drawing.Point(260, 84)
        Me.txtEmployeeNo.Name = "txtEmployeeNo"
        Me.txtEmployeeNo.Size = New System.Drawing.Size(190, 20)
        Me.txtEmployeeNo.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Employee No."
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(40, 128)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(190, 20)
        Me.txtSurname.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Surname"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(260, 38)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(190, 20)
        Me.txtMiddleName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Middle Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(40, 84)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(190, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(37, 68)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'txtTeacherId
        '
        Me.txtTeacherId.Location = New System.Drawing.Point(40, 38)
        Me.txtTeacherId.Name = "txtTeacherId"
        Me.txtTeacherId.Size = New System.Drawing.Size(190, 20)
        Me.txtTeacherId.TabIndex = 0
        '
        'lblTeacherID
        '
        Me.lblTeacherID.AutoSize = True
        Me.lblTeacherID.Location = New System.Drawing.Point(37, 22)
        Me.lblTeacherID.Name = "lblTeacherID"
        Me.lblTeacherID.Size = New System.Drawing.Size(61, 13)
        Me.lblTeacherID.TabIndex = 23
        Me.lblTeacherID.Text = "Teacher ID"
        '
        'lblTeacherList
        '
        Me.lblTeacherList.AutoSize = True
        Me.lblTeacherList.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTeacherList.ForeColor = System.Drawing.Color.White
        Me.lblTeacherList.Location = New System.Drawing.Point(326, 19)
        Me.lblTeacherList.Name = "lblTeacherList"
        Me.lblTeacherList.Size = New System.Drawing.Size(111, 25)
        Me.lblTeacherList.TabIndex = 17
        Me.lblTeacherList.Text = "Teacher List"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(1198, 17)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(67, 26)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(927, 21)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(199, 20)
        Me.txtSearch.TabIndex = 15
        '
        'dgvTeacher
        '
        Me.dgvTeacher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTeacher.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeacher.Location = New System.Drawing.Point(332, 424)
        Me.dgvTeacher.Name = "dgvTeacher"
        Me.dgvTeacher.RowHeadersWidth = 51
        Me.dgvTeacher.Size = New System.Drawing.Size(934, 150)
        Me.dgvTeacher.TabIndex = 18
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(1178, 587)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 35)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Location = New System.Drawing.Point(1066, 587)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(86, 35)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(954, 587)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 35)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'picWatermark
        '
        Me.picWatermark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(540, 89)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(520, 466)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 22
        Me.picWatermark.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(30, 543)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(240, 50)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
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
        Me.pnlSidebar.TabIndex = 12
        '
        'AdminManageTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 633)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvTeacher)
        Me.Controls.Add(Me.lblTeacherList)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.grpAddress)
        Me.Controls.Add(Me.grpTeacherInfo)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.picWatermark)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AdminManageTeacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher"
        Me.grpAddress.ResumeLayout(False)
        Me.grpAddress.PerformLayout()
        Me.grpTeacherInfo.ResumeLayout(False)
        Me.grpTeacherInfo.PerformLayout()
        CType(Me.dgvTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flowButtons.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents grpTeacherInfo As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAssignedSection As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHireDate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSpecialization As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEducationalAttainment As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmployeeNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtTeacherId As TextBox
    Friend WithEvents lblTeacherID As Label
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents lblTeacherList As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvTeacher As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents flowButtons As FlowLayoutPanel
    Friend WithEvents btnManageStudents As Button
    Friend WithEvents btnManageTeachers As Button
    Friend WithEvents btnManageSections As Button
    Friend WithEvents btnManageEnrollments As Button
    Friend WithEvents btnManageSubjects As Button
    Friend WithEvents btnGenerateReports As Button
    Friend WithEvents pnlSidebar As Panel
End Class
