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
        Me.btnStudentSearch = New System.Windows.Forms.Button()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.TextBoxStudentSearch = New System.Windows.Forms.TextBox()
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
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(40, 49, 40, 49)
        Me.pnlSidebar.Size = New System.Drawing.Size(400, 775)
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
        Me.flowButtons.Size = New System.Drawing.Size(320, 615)
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
        Me.btnLogout.Location = New System.Drawing.Point(40, 664)
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
        Me.pnlContent.Controls.Add(Me.TextBoxStudentSearch)
        Me.pnlContent.Controls.Add(Me.btnStudentDelete)
        Me.pnlContent.Controls.Add(Me.btnStudentUpdate)
        Me.pnlContent.Controls.Add(Me.btnStudentAdd)
        Me.pnlContent.Controls.Add(Me.dgvStudents)
        Me.pnlContent.Controls.Add(Me.grpAddress)
        Me.pnlContent.Controls.Add(Me.grpStudentInfo)
        Me.pnlContent.Controls.Add(Me.lblStudentList)
        Me.pnlContent.Controls.Add(Me.btnStudentSearch)
        Me.pnlContent.Controls.Add(Me.picWatermark)
        Me.pnlContent.Location = New System.Drawing.Point(400, 0)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(40, 37, 40, 37)
        Me.pnlContent.Size = New System.Drawing.Size(1333, 779)
        Me.pnlContent.TabIndex = 1
        '
        'btnStudentDelete
        '
        Me.btnStudentDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStudentDelete.Location = New System.Drawing.Point(1211, 720)
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
        Me.btnStudentUpdate.Location = New System.Drawing.Point(1061, 720)
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
        Me.btnStudentAdd.Location = New System.Drawing.Point(912, 720)
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
        Me.dgvStudents.Location = New System.Drawing.Point(44, 514)
        Me.dgvStudents.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersVisible = False
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        Me.grpAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Padding = New System.Windows.Forms.Padding(4)
        Me.grpAddress.Size = New System.Drawing.Size(1245, 215)
        Me.grpAddress.TabIndex = 4
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address"
        '
        'txtbxZipCode
        '
        Me.txtbxZipCode.Location = New System.Drawing.Point(867, 58)
        Me.txtbxZipCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxZipCode.Name = "txtbxZipCode"
        Me.txtbxZipCode.Size = New System.Drawing.Size(239, 26)
        Me.txtbxZipCode.TabIndex = 13
        '
        'lblStudentZIP
        '
        Me.lblStudentZIP.AutoSize = True
        Me.lblStudentZIP.Location = New System.Drawing.Point(863, 33)
        Me.lblStudentZIP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentZIP.Name = "lblStudentZIP"
        Me.lblStudentZIP.Size = New System.Drawing.Size(75, 20)
        Me.lblStudentZIP.TabIndex = 12
        Me.lblStudentZIP.Text = "Zip Code"
        '
        'txtbxStudentProvince
        '
        Me.txtbxStudentProvince.Location = New System.Drawing.Point(479, 116)
        Me.txtbxStudentProvince.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentProvince.MaxLength = 50
        Me.txtbxStudentProvince.Name = "txtbxStudentProvince"
        Me.txtbxStudentProvince.Size = New System.Drawing.Size(305, 26)
        Me.txtbxStudentProvince.TabIndex = 11
        '
        'lblStudentProvince
        '
        Me.lblStudentProvince.AutoSize = True
        Me.lblStudentProvince.Location = New System.Drawing.Point(475, 91)
        Me.lblStudentProvince.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentProvince.Name = "lblStudentProvince"
        Me.lblStudentProvince.Size = New System.Drawing.Size(74, 20)
        Me.lblStudentProvince.TabIndex = 10
        Me.lblStudentProvince.Text = "Province"
        '
        'txtbxStudentBarangay
        '
        Me.txtbxStudentBarangay.Location = New System.Drawing.Point(73, 167)
        Me.txtbxStudentBarangay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentBarangay.MaxLength = 50
        Me.txtbxStudentBarangay.Name = "txtbxStudentBarangay"
        Me.txtbxStudentBarangay.Size = New System.Drawing.Size(305, 26)
        Me.txtbxStudentBarangay.TabIndex = 9
        '
        'lblStudentBarangay
        '
        Me.lblStudentBarangay.AutoSize = True
        Me.lblStudentBarangay.Location = New System.Drawing.Point(69, 143)
        Me.lblStudentBarangay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentBarangay.Name = "lblStudentBarangay"
        Me.lblStudentBarangay.Size = New System.Drawing.Size(80, 20)
        Me.lblStudentBarangay.TabIndex = 8
        Me.lblStudentBarangay.Text = "Barangay"
        '
        'txtbxCountry
        '
        Me.txtbxCountry.Location = New System.Drawing.Point(479, 167)
        Me.txtbxCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxCountry.MaxLength = 50
        Me.txtbxCountry.Name = "txtbxCountry"
        Me.txtbxCountry.Size = New System.Drawing.Size(305, 26)
        Me.txtbxCountry.TabIndex = 7
        '
        'lblStudentCountry
        '
        Me.lblStudentCountry.AutoSize = True
        Me.lblStudentCountry.Location = New System.Drawing.Point(476, 143)
        Me.lblStudentCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentCountry.Name = "lblStudentCountry"
        Me.lblStudentCountry.Size = New System.Drawing.Size(67, 20)
        Me.lblStudentCountry.TabIndex = 6
        Me.lblStudentCountry.Text = "Country"
        '
        'txtbxStudentCity
        '
        Me.txtbxStudentCity.Location = New System.Drawing.Point(480, 58)
        Me.txtbxStudentCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentCity.MaxLength = 50
        Me.txtbxStudentCity.Name = "txtbxStudentCity"
        Me.txtbxStudentCity.Size = New System.Drawing.Size(305, 26)
        Me.txtbxStudentCity.TabIndex = 5
        '
        'lblStudentCity
        '
        Me.lblStudentCity.AutoSize = True
        Me.lblStudentCity.Location = New System.Drawing.Point(476, 34)
        Me.lblStudentCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentCity.Name = "lblStudentCity"
        Me.lblStudentCity.Size = New System.Drawing.Size(141, 20)
        Me.lblStudentCity.TabIndex = 4
        Me.lblStudentCity.Text = "City / Municipality"
        '
        'txtbcStudentStreet
        '
        Me.txtbcStudentStreet.Location = New System.Drawing.Point(73, 112)
        Me.txtbcStudentStreet.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbcStudentStreet.MaxLength = 20
        Me.txtbcStudentStreet.Name = "txtbcStudentStreet"
        Me.txtbcStudentStreet.Size = New System.Drawing.Size(305, 26)
        Me.txtbcStudentStreet.TabIndex = 3
        '
        'lblStudentStreet
        '
        Me.lblStudentStreet.AutoSize = True
        Me.lblStudentStreet.Location = New System.Drawing.Point(69, 91)
        Me.lblStudentStreet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentStreet.Name = "lblStudentStreet"
        Me.lblStudentStreet.Size = New System.Drawing.Size(54, 20)
        Me.lblStudentStreet.TabIndex = 2
        Me.lblStudentStreet.Text = "Street"
        '
        'txtbxStudentHouseNo
        '
        Me.txtbxStudentHouseNo.Location = New System.Drawing.Point(73, 59)
        Me.txtbxStudentHouseNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentHouseNo.MaxLength = 20
        Me.txtbxStudentHouseNo.Name = "txtbxStudentHouseNo"
        Me.txtbxStudentHouseNo.Size = New System.Drawing.Size(305, 26)
        Me.txtbxStudentHouseNo.TabIndex = 1
        '
        'lblStudentHouseNumber
        '
        Me.lblStudentHouseNumber.AutoSize = True
        Me.lblStudentHouseNumber.Location = New System.Drawing.Point(69, 34)
        Me.lblStudentHouseNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentHouseNumber.Name = "lblStudentHouseNumber"
        Me.lblStudentHouseNumber.Size = New System.Drawing.Size(122, 20)
        Me.lblStudentHouseNumber.TabIndex = 0
        Me.lblStudentHouseNumber.Text = "House Number"
        '
        'grpStudentInfo
        '
        Me.grpStudentInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStudentInfo.BackColor = System.Drawing.Color.Gainsboro
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
        Me.grpStudentInfo.Location = New System.Drawing.Point(44, 97)
        Me.grpStudentInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.grpStudentInfo.Name = "grpStudentInfo"
        Me.grpStudentInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.grpStudentInfo.Size = New System.Drawing.Size(1245, 206)
        Me.grpStudentInfo.TabIndex = 3
        Me.grpStudentInfo.TabStop = False
        Me.grpStudentInfo.Text = "Student List"
        '
        'nudStudentGradeLevel
        '
        Me.nudStudentGradeLevel.Location = New System.Drawing.Point(725, 154)
        Me.nudStudentGradeLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.nudStudentGradeLevel.Name = "nudStudentGradeLevel"
        Me.nudStudentGradeLevel.Size = New System.Drawing.Size(47, 26)
        Me.nudStudentGradeLevel.TabIndex = 27
        '
        'lblStudentEnrollmentID
        '
        Me.lblStudentEnrollmentID.AutoSize = True
        Me.lblStudentEnrollmentID.Location = New System.Drawing.Point(931, 84)
        Me.lblStudentEnrollmentID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentEnrollmentID.Name = "lblStudentEnrollmentID"
        Me.lblStudentEnrollmentID.Size = New System.Drawing.Size(111, 20)
        Me.lblStudentEnrollmentID.TabIndex = 26
        Me.lblStudentEnrollmentID.Text = "Enrollment ID"
        '
        'nudStudentAge
        '
        Me.nudStudentAge.Location = New System.Drawing.Point(725, 98)
        Me.nudStudentAge.Margin = New System.Windows.Forms.Padding(4)
        Me.nudStudentAge.Name = "nudStudentAge"
        Me.nudStudentAge.Size = New System.Drawing.Size(47, 26)
        Me.nudStudentAge.TabIndex = 24
        '
        'cmbStudenttGender
        '
        Me.cmbStudenttGender.FormattingEnabled = True
        Me.cmbStudenttGender.Location = New System.Drawing.Point(389, 46)
        Me.cmbStudenttGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStudenttGender.Name = "cmbStudenttGender"
        Me.cmbStudenttGender.Size = New System.Drawing.Size(136, 28)
        Me.cmbStudenttGender.TabIndex = 23
        '
        'dtpStudentBirthdate
        '
        Me.dtpStudentBirthdate.Checked = False
        Me.dtpStudentBirthdate.Location = New System.Drawing.Point(365, 103)
        Me.dtpStudentBirthdate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStudentBirthdate.Name = "dtpStudentBirthdate"
        Me.dtpStudentBirthdate.Size = New System.Drawing.Size(308, 26)
        Me.dtpStudentBirthdate.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(385, 79)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Birthdate"
        '
        'lblStudentGender
        '
        Me.lblStudentGender.AutoSize = True
        Me.lblStudentGender.Location = New System.Drawing.Point(385, 23)
        Me.lblStudentGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentGender.Name = "lblStudentGender"
        Me.lblStudentGender.Size = New System.Drawing.Size(64, 20)
        Me.lblStudentGender.TabIndex = 19
        Me.lblStudentGender.Text = "Gender"
        '
        'lblStudentAge
        '
        Me.lblStudentAge.AutoSize = True
        Me.lblStudentAge.Location = New System.Drawing.Point(721, 79)
        Me.lblStudentAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentAge.Name = "lblStudentAge"
        Me.lblStudentAge.Size = New System.Drawing.Size(38, 20)
        Me.lblStudentAge.TabIndex = 17
        Me.lblStudentAge.Text = "Age"
        '
        'txtbxGuardianName
        '
        Me.txtbxGuardianName.Location = New System.Drawing.Point(640, 46)
        Me.txtbxGuardianName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxGuardianName.MaxLength = 50
        Me.txtbxGuardianName.Name = "txtbxGuardianName"
        Me.txtbxGuardianName.Size = New System.Drawing.Size(252, 26)
        Me.txtbxGuardianName.TabIndex = 16
        '
        'lblStudentGuardianName
        '
        Me.lblStudentGuardianName.AutoEllipsis = True
        Me.lblStudentGuardianName.AutoSize = True
        Me.lblStudentGuardianName.Location = New System.Drawing.Point(636, 23)
        Me.lblStudentGuardianName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentGuardianName.Name = "lblStudentGuardianName"
        Me.lblStudentGuardianName.Size = New System.Drawing.Size(126, 20)
        Me.lblStudentGuardianName.TabIndex = 15
        Me.lblStudentGuardianName.Text = "Guardian Name"
        '
        'txtbxStudentReligion
        '
        Me.txtbxStudentReligion.Location = New System.Drawing.Point(389, 159)
        Me.txtbxStudentReligion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentReligion.MaxLength = 20
        Me.txtbxStudentReligion.Name = "txtbxStudentReligion"
        Me.txtbxStudentReligion.Size = New System.Drawing.Size(252, 26)
        Me.txtbxStudentReligion.TabIndex = 14
        '
        'lblStudentReligion
        '
        Me.lblStudentReligion.AutoSize = True
        Me.lblStudentReligion.Location = New System.Drawing.Point(385, 135)
        Me.lblStudentReligion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentReligion.Name = "lblStudentReligion"
        Me.lblStudentReligion.Size = New System.Drawing.Size(69, 20)
        Me.lblStudentReligion.TabIndex = 13
        Me.lblStudentReligion.Text = "Religion"
        '
        'txtbxStudentEnrollmentID
        '
        Me.txtbxStudentEnrollmentID.Location = New System.Drawing.Point(931, 107)
        Me.txtbxStudentEnrollmentID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentEnrollmentID.Name = "txtbxStudentEnrollmentID"
        Me.txtbxStudentEnrollmentID.Size = New System.Drawing.Size(252, 26)
        Me.txtbxStudentEnrollmentID.TabIndex = 12
        '
        'lblStudentSectionID
        '
        Me.lblStudentSectionID.AutoSize = True
        Me.lblStudentSectionID.Location = New System.Drawing.Point(931, 27)
        Me.lblStudentSectionID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentSectionID.Name = "lblStudentSectionID"
        Me.lblStudentSectionID.Size = New System.Drawing.Size(87, 20)
        Me.lblStudentSectionID.TabIndex = 11
        Me.lblStudentSectionID.Text = "Section ID"
        '
        'txtbxStudentSectionID
        '
        Me.txtbxStudentSectionID.Location = New System.Drawing.Point(933, 49)
        Me.txtbxStudentSectionID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxStudentSectionID.Name = "txtbxStudentSectionID"
        Me.txtbxStudentSectionID.Size = New System.Drawing.Size(252, 26)
        Me.txtbxStudentSectionID.TabIndex = 10
        '
        'lblStudentGradeLevel
        '
        Me.lblStudentGradeLevel.AutoSize = True
        Me.lblStudentGradeLevel.Location = New System.Drawing.Point(683, 130)
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
        'btnStudentSearch
        '
        Me.btnStudentSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStudentSearch.Location = New System.Drawing.Point(759, 720)
        Me.btnStudentSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStudentSearch.Name = "btnStudentSearch"
        Me.btnStudentSearch.Size = New System.Drawing.Size(120, 43)
        Me.btnStudentSearch.TabIndex = 1
        Me.btnStudentSearch.Text = "Search"
        Me.btnStudentSearch.UseVisualStyleBackColor = True
        '
        'picWatermark
        '
        Me.picWatermark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(317, 97)
        Me.picWatermark.Margin = New System.Windows.Forms.Padding(4)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(693, 574)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 5
        Me.picWatermark.TabStop = False
        '
        'TextBoxStudentSearch
        '
        Me.TextBoxStudentSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentSearch.Location = New System.Drawing.Point(478, 727)
        Me.TextBoxStudentSearch.MaxLength = 50
        Me.TextBoxStudentSearch.Name = "TextBoxStudentSearch"
        Me.TextBoxStudentSearch.Size = New System.Drawing.Size(246, 36)
        Me.TextBoxStudentSearch.TabIndex = 10
        '
        'AdminManageStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1732, 775)
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
    Friend WithEvents btnStudentSearch As Button
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
End Class
