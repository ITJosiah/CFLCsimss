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
        Me.grpAddress = New System.Windows.Forms.GroupBox()
        Me.txtbxZipCode = New System.Windows.Forms.TextBox()
        Me.lblStudentZIP = New System.Windows.Forms.Label()
        Me.txtbxStudentProvince = New System.Windows.Forms.TextBox()
        Me.lblStudentProvince = New System.Windows.Forms.Label()
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
        Me.txtbxStudentExtension = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxStudentPOB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxStudentLRN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxStudentMotherTongue = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbbxStudentIPGroup = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxStudentIPYes = New System.Windows.Forms.CheckBox()
        Me.cbxStudentIPNo = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbxGuardianContactNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAddress.SuspendLayout()
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
        Me.pnlSidebar.Size = New System.Drawing.Size(300, 630)
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
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.TextBoxStudentSearch)
        Me.pnlContent.Controls.Add(Me.btnStudentDelete)
        Me.pnlContent.Controls.Add(Me.btnStudentUpdate)
        Me.pnlContent.Controls.Add(Me.btnStudentAdd)
        Me.pnlContent.Controls.Add(Me.dgvStudents)
        Me.pnlContent.Controls.Add(Me.grpAddress)
        Me.pnlContent.Controls.Add(Me.grpStudentInfo)
        Me.pnlContent.Controls.Add(Me.lblStudentList)
        Me.pnlContent.Controls.Add(Me.picWatermark)
        Me.pnlContent.Location = New System.Drawing.Point(300, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(30, 30, 30, 30)
        Me.pnlContent.Size = New System.Drawing.Size(1000, 633)
        Me.pnlContent.TabIndex = 1
        '
        'TextBoxStudentSearch
        '
        Me.TextBoxStudentSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxStudentSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentSearch.Location = New System.Drawing.Point(481, 587)
        Me.TextBoxStudentSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxStudentSearch.MaxLength = 50
        Me.TextBoxStudentSearch.Name = "TextBoxStudentSearch"
        Me.TextBoxStudentSearch.Size = New System.Drawing.Size(186, 30)
        Me.TextBoxStudentSearch.TabIndex = 10
        '
        'btnStudentDelete
        '
        Me.btnStudentDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStudentDelete.Location = New System.Drawing.Point(908, 585)
        Me.btnStudentDelete.Name = "btnStudentDelete"
        Me.btnStudentDelete.Size = New System.Drawing.Size(86, 35)
        Me.btnStudentDelete.TabIndex = 9
        Me.btnStudentDelete.Text = "Delete"
        Me.btnStudentDelete.UseVisualStyleBackColor = True
        '
        'btnStudentUpdate
        '
        Me.btnStudentUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStudentUpdate.Location = New System.Drawing.Point(796, 585)
        Me.btnStudentUpdate.Name = "btnStudentUpdate"
        Me.btnStudentUpdate.Size = New System.Drawing.Size(86, 35)
        Me.btnStudentUpdate.TabIndex = 8
        Me.btnStudentUpdate.Text = "Update"
        Me.btnStudentUpdate.UseVisualStyleBackColor = True
        '
        'btnStudentAdd
        '
        Me.btnStudentAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStudentAdd.Location = New System.Drawing.Point(684, 585)
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
        Me.dgvStudents.Location = New System.Drawing.Point(33, 562)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersVisible = False
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        Me.grpAddress.Location = New System.Drawing.Point(33, 355)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(934, 190)
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
        'txtbxStudentProvince
        '
        Me.txtbxStudentProvince.Location = New System.Drawing.Point(359, 94)
        Me.txtbxStudentProvince.MaxLength = 50
        Me.txtbxStudentProvince.Name = "txtbxStudentProvince"
        Me.txtbxStudentProvince.Size = New System.Drawing.Size(230, 23)
        Me.txtbxStudentProvince.TabIndex = 11
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
        'txtbxStudentBarangay
        '
        Me.txtbxStudentBarangay.Location = New System.Drawing.Point(55, 136)
        Me.txtbxStudentBarangay.MaxLength = 50
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
        Me.txtbxCountry.MaxLength = 50
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
        Me.txtbxStudentCity.MaxLength = 50
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
        Me.txtbcStudentStreet.MaxLength = 20
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
        Me.txtbxStudentHouseNo.MaxLength = 20
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
        Me.grpStudentInfo.Size = New System.Drawing.Size(934, 291)
        Me.grpStudentInfo.TabIndex = 3
        Me.grpStudentInfo.TabStop = False
        Me.grpStudentInfo.Text = "Student List"
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
        Me.picWatermark.Location = New System.Drawing.Point(238, 79)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(520, 466)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 5
        Me.picWatermark.TabStop = False
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 17)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "If Yes, please specify:"
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
        'AdminManageStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1299, 630)
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
        Me.grpAddress.ResumeLayout(False)
        Me.grpAddress.PerformLayout()
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
    Friend WithEvents txtbxStudentProvince As TextBox
    Friend WithEvents lblStudentProvince As Label
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
End Class
