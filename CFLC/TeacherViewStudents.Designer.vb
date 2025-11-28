<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherViewStudents
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
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.TextBoxStudentSearch = New System.Windows.Forms.TextBox()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.grpStudentInfo = New System.Windows.Forms.GroupBox()
        Me.txtbxStudentAge = New System.Windows.Forms.TextBox()
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
        Me.cmbStudenttGender = New System.Windows.Forms.ComboBox()
        Me.dtpStudentBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblStudentGender = New System.Windows.Forms.Label()
        Me.lblStudentAge = New System.Windows.Forms.Label()
        Me.txtbxGuardianName = New System.Windows.Forms.TextBox()
        Me.lblStudentGuardianName = New System.Windows.Forms.Label()
        Me.txtbxStudentReligion = New System.Windows.Forms.TextBox()
        Me.lblStudentReligion = New System.Windows.Forms.Label()
        Me.txtbxStudentSurname = New System.Windows.Forms.TextBox()
        Me.lblStudentSurname = New System.Windows.Forms.Label()
        Me.txtStudentMiddleName = New System.Windows.Forms.TextBox()
        Me.lblStudentMiddleName = New System.Windows.Forms.Label()
        Me.txtbxStudentFirstName = New System.Windows.Forms.TextBox()
        Me.lblStudentFirstName = New System.Windows.Forms.Label()
        Me.lblStudentList = New System.Windows.Forms.Label()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.btnTeacherViewSection = New System.Windows.Forms.Button()
        Me.pnlTeacherSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStudentInfo.SuspendLayout()
        Me.GroupBox4P.SuspendLayout()
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
        Me.pnlTeacherSidebar.TabIndex = 13
        '
        'flowButtons
        '
        Me.flowButtons.BackColor = System.Drawing.Color.Transparent
        Me.flowButtons.Controls.Add(Me.btnTeacherViewSection)
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
        Me.btnTeacherViewStudents.Location = New System.Drawing.Point(0, 63)
        Me.btnTeacherViewStudents.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnTeacherViewStudents.Name = "btnTeacherViewStudents"
        Me.btnTeacherViewStudents.Size = New System.Drawing.Size(240, 45)
        Me.btnTeacherViewStudents.TabIndex = 4
        Me.btnTeacherViewStudents.Text = "View Students"
        Me.btnTeacherViewStudents.UseVisualStyleBackColor = True
        '
        'btnViewAssignedSubjects
        '
        Me.btnViewAssignedSubjects.Location = New System.Drawing.Point(0, 126)
        Me.btnViewAssignedSubjects.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnViewAssignedSubjects.Name = "btnViewAssignedSubjects"
        Me.btnViewAssignedSubjects.Size = New System.Drawing.Size(240, 45)
        Me.btnViewAssignedSubjects.TabIndex = 5
        Me.btnViewAssignedSubjects.Text = "View Assigned Subjects"
        Me.btnViewAssignedSubjects.UseVisualStyleBackColor = True
        '
        'btnTeacherGenerateReports
        '
        Me.btnTeacherGenerateReports.Location = New System.Drawing.Point(0, 189)
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
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.TextBoxStudentSearch)
        Me.pnlContent.Controls.Add(Me.dgvStudents)
        Me.pnlContent.Controls.Add(Me.grpStudentInfo)
        Me.pnlContent.Controls.Add(Me.lblStudentList)
        Me.pnlContent.Controls.Add(Me.picWatermark)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(300, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlContent.Size = New System.Drawing.Size(1143, 800)
        Me.pnlContent.TabIndex = 14
        '
        'TextBoxStudentSearch
        '
        Me.TextBoxStudentSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxStudentSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxStudentSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentSearch.Location = New System.Drawing.Point(924, 759)
        Me.TextBoxStudentSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxStudentSearch.MaxLength = 50
        Me.TextBoxStudentSearch.Name = "TextBoxStudentSearch"
        Me.TextBoxStudentSearch.Size = New System.Drawing.Size(186, 30)
        Me.TextBoxStudentSearch.TabIndex = 10
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
        Me.dgvStudents.Size = New System.Drawing.Size(1077, 126)
        Me.dgvStudents.TabIndex = 6
        '
        'grpStudentInfo
        '
        Me.grpStudentInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStudentInfo.BackColor = System.Drawing.Color.Gainsboro
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentAge)
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
        Me.grpStudentInfo.Controls.Add(Me.cmbStudenttGender)
        Me.grpStudentInfo.Controls.Add(Me.dtpStudentBirthdate)
        Me.grpStudentInfo.Controls.Add(Me.Label11)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentGender)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentAge)
        Me.grpStudentInfo.Controls.Add(Me.txtbxGuardianName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentGuardianName)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentReligion)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentReligion)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentSurname)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentSurname)
        Me.grpStudentInfo.Controls.Add(Me.txtStudentMiddleName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentMiddleName)
        Me.grpStudentInfo.Controls.Add(Me.txtbxStudentFirstName)
        Me.grpStudentInfo.Controls.Add(Me.lblStudentFirstName)
        Me.grpStudentInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStudentInfo.Location = New System.Drawing.Point(33, 79)
        Me.grpStudentInfo.Name = "grpStudentInfo"
        Me.grpStudentInfo.Size = New System.Drawing.Size(1077, 514)
        Me.grpStudentInfo.TabIndex = 3
        Me.grpStudentInfo.TabStop = False
        Me.grpStudentInfo.Text = "Student List"
        '
        'txtbxStudentAge
        '
        Me.txtbxStudentAge.Location = New System.Drawing.Point(442, 33)
        Me.txtbxStudentAge.Name = "txtbxStudentAge"
        Me.txtbxStudentAge.ReadOnly = True
        Me.txtbxStudentAge.Size = New System.Drawing.Size(47, 23)
        Me.txtbxStudentAge.TabIndex = 65
        '
        'RadioButtonStudentIPNO
        '
        Me.RadioButtonStudentIPNO.AutoSize = True
        Me.RadioButtonStudentIPNO.Location = New System.Drawing.Point(116, 238)
        Me.RadioButtonStudentIPNO.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonStudentIPNO.Name = "RadioButtonStudentIPNO"
        Me.RadioButtonStudentIPNO.Size = New System.Drawing.Size(44, 21)
        Me.RadioButtonStudentIPNO.TabIndex = 64
        Me.RadioButtonStudentIPNO.TabStop = True
        Me.RadioButtonStudentIPNO.Text = "No"
        Me.RadioButtonStudentIPNO.UseVisualStyleBackColor = True
        '
        'RadioButtonStudentIPYES
        '
        Me.RadioButtonStudentIPYES.AutoSize = True
        Me.RadioButtonStudentIPYES.Location = New System.Drawing.Point(63, 239)
        Me.RadioButtonStudentIPYES.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonStudentIPYES.Name = "RadioButtonStudentIPYES"
        Me.RadioButtonStudentIPYES.Size = New System.Drawing.Size(50, 21)
        Me.RadioButtonStudentIPYES.TabIndex = 63
        Me.RadioButtonStudentIPYES.TabStop = True
        Me.RadioButtonStudentIPYES.Text = "Yes"
        Me.RadioButtonStudentIPYES.UseVisualStyleBackColor = True
        '
        'txtbxZipCode
        '
        Me.txtbxZipCode.Location = New System.Drawing.Point(555, 363)
        Me.txtbxZipCode.MaxLength = 50
        Me.txtbxZipCode.Name = "txtbxZipCode"
        Me.txtbxZipCode.Size = New System.Drawing.Size(190, 23)
        Me.txtbxZipCode.TabIndex = 62
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
        'GroupBox4P
        '
        Me.GroupBox4P.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox4P.Controls.Add(Me.RadioButtonStudent4PYES)
        Me.GroupBox4P.Controls.Add(Me.RadioButtonStudent4PNO)
        Me.GroupBox4P.Location = New System.Drawing.Point(58, 284)
        Me.GroupBox4P.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4P.Name = "GroupBox4P"
        Me.GroupBox4P.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4P.Size = New System.Drawing.Size(100, 36)
        Me.GroupBox4P.TabIndex = 11
        Me.GroupBox4P.TabStop = False
        '
        'RadioButtonStudent4PYES
        '
        Me.RadioButtonStudent4PYES.AutoSize = True
        Me.RadioButtonStudent4PYES.Location = New System.Drawing.Point(5, 7)
        Me.RadioButtonStudent4PYES.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonStudent4PYES.Name = "RadioButtonStudent4PYES"
        Me.RadioButtonStudent4PYES.Size = New System.Drawing.Size(50, 21)
        Me.RadioButtonStudent4PYES.TabIndex = 65
        Me.RadioButtonStudent4PYES.TabStop = True
        Me.RadioButtonStudent4PYES.Text = "Yes"
        Me.RadioButtonStudent4PYES.UseVisualStyleBackColor = True
        '
        'RadioButtonStudent4PNO
        '
        Me.RadioButtonStudent4PNO.AutoSize = True
        Me.RadioButtonStudent4PNO.Location = New System.Drawing.Point(58, 7)
        Me.RadioButtonStudent4PNO.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonStudent4PNO.Name = "RadioButtonStudent4PNO"
        Me.RadioButtonStudent4PNO.Size = New System.Drawing.Size(44, 21)
        Me.RadioButtonStudent4PNO.TabIndex = 66
        Me.RadioButtonStudent4PNO.TabStop = True
        Me.RadioButtonStudent4PNO.Text = "No"
        Me.RadioButtonStudent4PNO.UseVisualStyleBackColor = True
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 17)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Address"
        '
        'txtbx4ps
        '
        Me.txtbx4ps.Location = New System.Drawing.Point(497, 289)
        Me.txtbx4ps.MaxLength = 50
        Me.txtbx4ps.Name = "txtbx4ps"
        Me.txtbx4ps.Size = New System.Drawing.Size(228, 23)
        Me.txtbx4ps.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(163, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(328, 17)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "If Yes, please write the 4P's Household ID Number:"
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
        'txtbxGuardianContactNo
        '
        Me.txtbxGuardianContactNo.Location = New System.Drawing.Point(555, 175)
        Me.txtbxGuardianContactNo.MaxLength = 50
        Me.txtbxGuardianContactNo.Name = "txtbxGuardianContactNo"
        Me.txtbxGuardianContactNo.Size = New System.Drawing.Size(143, 23)
        Me.txtbxGuardianContactNo.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(552, 156)
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
        'txtbbxStudentIPGroup
        '
        Me.txtbbxStudentIPGroup.Location = New System.Drawing.Point(312, 236)
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
        Me.txtbxStudentMotherTongue.Location = New System.Drawing.Point(555, 82)
        Me.txtbxStudentMotherTongue.MaxLength = 50
        Me.txtbxStudentMotherTongue.Name = "txtbxStudentMotherTongue"
        Me.txtbxStudentMotherTongue.Size = New System.Drawing.Size(190, 23)
        Me.txtbxStudentMotherTongue.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(552, 63)
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
        Me.txtbxStudentExtension.ReadOnly = True
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
        'cmbStudenttGender
        '
        Me.cmbStudenttGender.FormattingEnabled = True
        Me.cmbStudenttGender.Location = New System.Drawing.Point(309, 82)
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
        Me.lblStudentGender.Location = New System.Drawing.Point(306, 64)
        Me.lblStudentGender.Name = "lblStudentGender"
        Me.lblStudentGender.Size = New System.Drawing.Size(31, 17)
        Me.lblStudentGender.TabIndex = 19
        Me.lblStudentGender.Text = "Sex"
        '
        'lblStudentAge
        '
        Me.lblStudentAge.AutoSize = True
        Me.lblStudentAge.Location = New System.Drawing.Point(439, 13)
        Me.lblStudentAge.Name = "lblStudentAge"
        Me.lblStudentAge.Size = New System.Drawing.Size(33, 17)
        Me.lblStudentAge.TabIndex = 17
        Me.lblStudentAge.Text = "Age"
        '
        'txtbxGuardianName
        '
        Me.txtbxGuardianName.Location = New System.Drawing.Point(555, 129)
        Me.txtbxGuardianName.MaxLength = 50
        Me.txtbxGuardianName.Name = "txtbxGuardianName"
        Me.txtbxGuardianName.Size = New System.Drawing.Size(156, 23)
        Me.txtbxGuardianName.TabIndex = 16
        '
        'lblStudentGuardianName
        '
        Me.lblStudentGuardianName.AutoEllipsis = True
        Me.lblStudentGuardianName.AutoSize = True
        Me.lblStudentGuardianName.Location = New System.Drawing.Point(552, 110)
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
        'txtbxStudentSurname
        '
        Me.txtbxStudentSurname.Location = New System.Drawing.Point(55, 130)
        Me.txtbxStudentSurname.MaxLength = 50
        Me.txtbxStudentSurname.Name = "txtbxStudentSurname"
        Me.txtbxStudentSurname.ReadOnly = True
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
        Me.txtStudentMiddleName.ReadOnly = True
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
        Me.txtbxStudentFirstName.ReadOnly = True
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
        Me.picWatermark.Location = New System.Drawing.Point(309, 163)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(520, 466)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 5
        Me.picWatermark.TabStop = False
        '
        'btnTeacherViewSection
        '
        Me.btnTeacherViewSection.Location = New System.Drawing.Point(0, 0)
        Me.btnTeacherViewSection.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnTeacherViewSection.Name = "btnTeacherViewSection"
        Me.btnTeacherViewSection.Size = New System.Drawing.Size(240, 45)
        Me.btnTeacherViewSection.TabIndex = 10
        Me.btnTeacherViewSection.Text = "View Section"
        Me.btnTeacherViewSection.UseVisualStyleBackColor = True
        '
        'TeacherViewStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 800)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlTeacherSidebar)
        Me.Name = "TeacherViewStudents"
        Me.Text = "TeacherViewStudents"
        Me.pnlTeacherSidebar.ResumeLayout(False)
        Me.flowButtons.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStudentInfo.ResumeLayout(False)
        Me.grpStudentInfo.PerformLayout()
        Me.GroupBox4P.ResumeLayout(False)
        Me.GroupBox4P.PerformLayout()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTeacherSidebar As Panel
    Friend WithEvents flowButtons As FlowLayoutPanel
    Friend WithEvents btnTeacherViewStudents As Button
    Friend WithEvents btnViewAssignedSubjects As Button
    Friend WithEvents btnTeacherGenerateReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents TextBoxStudentSearch As TextBox
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents grpStudentInfo As GroupBox
    Friend WithEvents txtbxStudentAge As TextBox
    Friend WithEvents RadioButtonStudentIPNO As RadioButton
    Friend WithEvents RadioButtonStudentIPYES As RadioButton
    Friend WithEvents txtbxZipCode As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox4P As GroupBox
    Friend WithEvents RadioButtonStudent4PYES As RadioButton
    Friend WithEvents RadioButtonStudent4PNO As RadioButton
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
    Friend WithEvents txtbx4ps As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbxGuardianContactNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbbxStudentIPGroup As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbxStudentMotherTongue As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbxStudentLRN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxStudentPOB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxStudentExtension As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbStudenttGender As ComboBox
    Friend WithEvents dtpStudentBirthdate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents lblStudentGender As Label
    Friend WithEvents lblStudentAge As Label
    Friend WithEvents txtbxGuardianName As TextBox
    Friend WithEvents lblStudentGuardianName As Label
    Friend WithEvents txtbxStudentReligion As TextBox
    Friend WithEvents lblStudentReligion As Label
    Friend WithEvents txtbxStudentSurname As TextBox
    Friend WithEvents lblStudentSurname As Label
    Friend WithEvents txtStudentMiddleName As TextBox
    Friend WithEvents lblStudentMiddleName As Label
    Friend WithEvents txtbxStudentFirstName As TextBox
    Friend WithEvents lblStudentFirstName As Label
    Friend WithEvents lblStudentList As Label
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents btnTeacherViewSection As Button
End Class
