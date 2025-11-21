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
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.lblTeacherList = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtbxTeacherZipCode = New System.Windows.Forms.TextBox()
        Me.lblTeacherZIP = New System.Windows.Forms.Label()
        Me.txtbxTeacherProvince = New System.Windows.Forms.TextBox()
        Me.lblTeacherProvince = New System.Windows.Forms.Label()
        Me.txtbxTeacherBarangay = New System.Windows.Forms.TextBox()
        Me.lblTeacherBarangay = New System.Windows.Forms.Label()
        Me.txtbxTeacherCountry = New System.Windows.Forms.TextBox()
        Me.lblTeacherCountry = New System.Windows.Forms.Label()
        Me.txtbxTeacherCity = New System.Windows.Forms.TextBox()
        Me.lblTeacherCity = New System.Windows.Forms.Label()
        Me.txtbcTeacherStreet = New System.Windows.Forms.TextBox()
        Me.lblTeacherStreet = New System.Windows.Forms.Label()
        Me.txtbxTeacherHouseNo = New System.Windows.Forms.TextBox()
        Me.lbTeacherHouseNumber = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBoxTeacherGender = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxTeacherassignedSection = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.HireDate = New System.Windows.Forms.Label()
        Me.TextBoxTeacherSpecialization = New System.Windows.Forms.TextBox()
        Me.Specialization = New System.Windows.Forms.Label()
        Me.TextBoxTeacherEducationalAttainment = New System.Windows.Forms.TextBox()
        Me.EducationalAttainment = New System.Windows.Forms.Label()
        Me.TextBoxTeacherContactNo = New System.Windows.Forms.TextBox()
        Me.ContactNo = New System.Windows.Forms.Label()
        Me.TextBoxTeacherEmail = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.Label()
        Me.TextBoxTeacherEmployeeNo = New System.Windows.Forms.TextBox()
        Me.EmployeeNo = New System.Windows.Forms.Label()
        Me.TextBoxTeacherSurname = New System.Windows.Forms.TextBox()
        Me.Surname = New System.Windows.Forms.Label()
        Me.TextBoxTeacherMiddleName = New System.Windows.Forms.TextBox()
        Me.MiddleName = New System.Windows.Forms.Label()
        Me.TextBoxTeacherFirstName = New System.Windows.Forms.TextBox()
        Me.TeacherFirstName = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxTeacherStatus = New System.Windows.Forms.ComboBox()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.pnlContent.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.lblTeacherList)
        Me.pnlContent.Controls.Add(Me.btnDelete)
        Me.pnlContent.Controls.Add(Me.DataGridView1)
        Me.pnlContent.Controls.Add(Me.btnUpdate)
        Me.pnlContent.Controls.Add(Me.btnAdd)
        Me.pnlContent.Controls.Add(Me.Panel1)
        Me.pnlContent.Controls.Add(Me.btnSearch)
        Me.pnlContent.Controls.Add(Me.picWatermark)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1733, 779)
        Me.pnlContent.TabIndex = 23
        '
        'lblTeacherList
        '
        Me.lblTeacherList.AutoSize = True
        Me.lblTeacherList.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTeacherList.ForeColor = System.Drawing.Color.White
        Me.lblTeacherList.Location = New System.Drawing.Point(58, 28)
        Me.lblTeacherList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacherList.Name = "lblTeacherList"
        Me.lblTeacherList.Size = New System.Drawing.Size(142, 32)
        Me.lblTeacherList.TabIndex = 24
        Me.lblTeacherList.Text = "Teacher List"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(1576, 723)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(115, 43)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(64, 492)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1627, 196)
        Me.DataGridView1.TabIndex = 24
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Location = New System.Drawing.Point(1426, 723)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(115, 43)
        Me.btnUpdate.TabIndex = 26
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(1277, 723)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(115, 43)
        Me.btnAdd.TabIndex = 25
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.ComboBoxTeacherStatus)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.txtbxTeacherZipCode)
        Me.Panel1.Controls.Add(Me.lblTeacherZIP)
        Me.Panel1.Controls.Add(Me.txtbxTeacherProvince)
        Me.Panel1.Controls.Add(Me.lblTeacherProvince)
        Me.Panel1.Controls.Add(Me.txtbxTeacherBarangay)
        Me.Panel1.Controls.Add(Me.lblTeacherBarangay)
        Me.Panel1.Controls.Add(Me.txtbxTeacherCountry)
        Me.Panel1.Controls.Add(Me.lblTeacherCountry)
        Me.Panel1.Controls.Add(Me.txtbxTeacherCity)
        Me.Panel1.Controls.Add(Me.lblTeacherCity)
        Me.Panel1.Controls.Add(Me.txtbcTeacherStreet)
        Me.Panel1.Controls.Add(Me.lblTeacherStreet)
        Me.Panel1.Controls.Add(Me.txtbxTeacherHouseNo)
        Me.Panel1.Controls.Add(Me.lbTeacherHouseNumber)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.ComboBoxTeacherGender)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TextBoxTeacherassignedSection)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.HireDate)
        Me.Panel1.Controls.Add(Me.TextBoxTeacherSpecialization)
        Me.Panel1.Controls.Add(Me.Specialization)
        Me.Panel1.Controls.Add(Me.TextBoxTeacherEducationalAttainment)
        Me.Panel1.Controls.Add(Me.EducationalAttainment)
        Me.Panel1.Controls.Add(Me.TextBoxTeacherContactNo)
        Me.Panel1.Controls.Add(Me.ContactNo)
        Me.Panel1.Controls.Add(Me.TextBoxTeacherEmail)
        Me.Panel1.Controls.Add(Me.Email)
        Me.Panel1.Controls.Add(Me.TextBoxTeacherEmployeeNo)
        Me.Panel1.Controls.Add(Me.EmployeeNo)
        Me.Panel1.Controls.Add(Me.TextBoxTeacherSurname)
        Me.Panel1.Controls.Add(Me.Surname)
        Me.Panel1.Controls.Add(Me.TextBoxTeacherMiddleName)
        Me.Panel1.Controls.Add(Me.MiddleName)
        Me.Panel1.Controls.Add(Me.TextBoxTeacherFirstName)
        Me.Panel1.Controls.Add(Me.TeacherFirstName)
        Me.Panel1.Location = New System.Drawing.Point(64, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(1627, 355)
        Me.Panel1.TabIndex = 23
        '
        'txtbxTeacherZipCode
        '
        Me.txtbxTeacherZipCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherZipCode.Location = New System.Drawing.Point(878, 207)
        Me.txtbxTeacherZipCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxTeacherZipCode.Name = "txtbxTeacherZipCode"
        Me.txtbxTeacherZipCode.Size = New System.Drawing.Size(239, 26)
        Me.txtbxTeacherZipCode.TabIndex = 41
        '
        'lblTeacherZIP
        '
        Me.lblTeacherZIP.AutoSize = True
        Me.lblTeacherZIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherZIP.Location = New System.Drawing.Point(874, 182)
        Me.lblTeacherZIP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacherZIP.Name = "lblTeacherZIP"
        Me.lblTeacherZIP.Size = New System.Drawing.Size(75, 20)
        Me.lblTeacherZIP.TabIndex = 40
        Me.lblTeacherZIP.Text = "Zip Code"
        '
        'txtbxTeacherProvince
        '
        Me.txtbxTeacherProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherProvince.Location = New System.Drawing.Point(490, 265)
        Me.txtbxTeacherProvince.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxTeacherProvince.Name = "txtbxTeacherProvince"
        Me.txtbxTeacherProvince.Size = New System.Drawing.Size(305, 26)
        Me.txtbxTeacherProvince.TabIndex = 39
        '
        'lblTeacherProvince
        '
        Me.lblTeacherProvince.AutoSize = True
        Me.lblTeacherProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherProvince.Location = New System.Drawing.Point(486, 240)
        Me.lblTeacherProvince.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacherProvince.Name = "lblTeacherProvince"
        Me.lblTeacherProvince.Size = New System.Drawing.Size(74, 20)
        Me.lblTeacherProvince.TabIndex = 38
        Me.lblTeacherProvince.Text = "Province"
        '
        'txtbxTeacherBarangay
        '
        Me.txtbxTeacherBarangay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherBarangay.Location = New System.Drawing.Point(84, 316)
        Me.txtbxTeacherBarangay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxTeacherBarangay.Name = "txtbxTeacherBarangay"
        Me.txtbxTeacherBarangay.Size = New System.Drawing.Size(305, 26)
        Me.txtbxTeacherBarangay.TabIndex = 37
        '
        'lblTeacherBarangay
        '
        Me.lblTeacherBarangay.AutoSize = True
        Me.lblTeacherBarangay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherBarangay.Location = New System.Drawing.Point(80, 292)
        Me.lblTeacherBarangay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacherBarangay.Name = "lblTeacherBarangay"
        Me.lblTeacherBarangay.Size = New System.Drawing.Size(80, 20)
        Me.lblTeacherBarangay.TabIndex = 36
        Me.lblTeacherBarangay.Text = "Barangay"
        '
        'txtbxTeacherCountry
        '
        Me.txtbxTeacherCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherCountry.Location = New System.Drawing.Point(490, 316)
        Me.txtbxTeacherCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxTeacherCountry.Name = "txtbxTeacherCountry"
        Me.txtbxTeacherCountry.Size = New System.Drawing.Size(305, 26)
        Me.txtbxTeacherCountry.TabIndex = 35
        '
        'lblTeacherCountry
        '
        Me.lblTeacherCountry.AutoSize = True
        Me.lblTeacherCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherCountry.Location = New System.Drawing.Point(487, 292)
        Me.lblTeacherCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacherCountry.Name = "lblTeacherCountry"
        Me.lblTeacherCountry.Size = New System.Drawing.Size(67, 20)
        Me.lblTeacherCountry.TabIndex = 34
        Me.lblTeacherCountry.Text = "Country"
        '
        'txtbxTeacherCity
        '
        Me.txtbxTeacherCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherCity.Location = New System.Drawing.Point(491, 207)
        Me.txtbxTeacherCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxTeacherCity.Name = "txtbxTeacherCity"
        Me.txtbxTeacherCity.Size = New System.Drawing.Size(305, 26)
        Me.txtbxTeacherCity.TabIndex = 33
        '
        'lblTeacherCity
        '
        Me.lblTeacherCity.AutoSize = True
        Me.lblTeacherCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherCity.Location = New System.Drawing.Point(487, 183)
        Me.lblTeacherCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacherCity.Name = "lblTeacherCity"
        Me.lblTeacherCity.Size = New System.Drawing.Size(141, 20)
        Me.lblTeacherCity.TabIndex = 32
        Me.lblTeacherCity.Text = "City / Municipality"
        '
        'txtbcTeacherStreet
        '
        Me.txtbcTeacherStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbcTeacherStreet.Location = New System.Drawing.Point(84, 261)
        Me.txtbcTeacherStreet.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbcTeacherStreet.Name = "txtbcTeacherStreet"
        Me.txtbcTeacherStreet.Size = New System.Drawing.Size(305, 26)
        Me.txtbcTeacherStreet.TabIndex = 31
        '
        'lblTeacherStreet
        '
        Me.lblTeacherStreet.AutoSize = True
        Me.lblTeacherStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherStreet.Location = New System.Drawing.Point(80, 240)
        Me.lblTeacherStreet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacherStreet.Name = "lblTeacherStreet"
        Me.lblTeacherStreet.Size = New System.Drawing.Size(54, 20)
        Me.lblTeacherStreet.TabIndex = 30
        Me.lblTeacherStreet.Text = "Street"
        '
        'txtbxTeacherHouseNo
        '
        Me.txtbxTeacherHouseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherHouseNo.Location = New System.Drawing.Point(84, 208)
        Me.txtbxTeacherHouseNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxTeacherHouseNo.Name = "txtbxTeacherHouseNo"
        Me.txtbxTeacherHouseNo.Size = New System.Drawing.Size(305, 26)
        Me.txtbxTeacherHouseNo.TabIndex = 29
        '
        'lbTeacherHouseNumber
        '
        Me.lbTeacherHouseNumber.AutoSize = True
        Me.lbTeacherHouseNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTeacherHouseNumber.Location = New System.Drawing.Point(80, 183)
        Me.lbTeacherHouseNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTeacherHouseNumber.Name = "lbTeacherHouseNumber"
        Me.lbTeacherHouseNumber.Size = New System.Drawing.Size(122, 20)
        Me.lbTeacherHouseNumber.TabIndex = 28
        Me.lbTeacherHouseNumber.Text = "House Number"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 164)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 20)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Address"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(-1, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Teacher List"
        '
        'ComboBoxTeacherGender
        '
        Me.ComboBoxTeacherGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTeacherGender.FormattingEnabled = True
        Me.ComboBoxTeacherGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxTeacherGender.Location = New System.Drawing.Point(1155, 46)
        Me.ComboBoxTeacherGender.Name = "ComboBoxTeacherGender"
        Me.ComboBoxTeacherGender.Size = New System.Drawing.Size(110, 28)
        Me.ComboBoxTeacherGender.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1104, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 20)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Gender"
        '
        'TextBoxTeacherassignedSection
        '
        Me.TextBoxTeacherassignedSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherassignedSection.Location = New System.Drawing.Point(1155, 139)
        Me.TextBoxTeacherassignedSection.Name = "TextBoxTeacherassignedSection"
        Me.TextBoxTeacherassignedSection.Size = New System.Drawing.Size(213, 26)
        Me.TextBoxTeacherassignedSection.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1040, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Assigned Section"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1104, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Status"
        '
        'HireDate
        '
        Me.HireDate.AutoSize = True
        Me.HireDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HireDate.Location = New System.Drawing.Point(755, 117)
        Me.HireDate.Name = "HireDate"
        Me.HireDate.Size = New System.Drawing.Size(82, 20)
        Me.HireDate.TabIndex = 16
        Me.HireDate.Text = "Hire Date"
        '
        'TextBoxTeacherSpecialization
        '
        Me.TextBoxTeacherSpecialization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherSpecialization.Location = New System.Drawing.Point(828, 92)
        Me.TextBoxTeacherSpecialization.Name = "TextBoxTeacherSpecialization"
        Me.TextBoxTeacherSpecialization.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxTeacherSpecialization.TabIndex = 15
        '
        'Specialization
        '
        Me.Specialization.AutoSize = True
        Me.Specialization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specialization.Location = New System.Drawing.Point(724, 69)
        Me.Specialization.Name = "Specialization"
        Me.Specialization.Size = New System.Drawing.Size(113, 20)
        Me.Specialization.TabIndex = 14
        Me.Specialization.Text = "Specialization"
        '
        'TextBoxTeacherEducationalAttainment
        '
        Me.TextBoxTeacherEducationalAttainment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherEducationalAttainment.Location = New System.Drawing.Point(828, 46)
        Me.TextBoxTeacherEducationalAttainment.Name = "TextBoxTeacherEducationalAttainment"
        Me.TextBoxTeacherEducationalAttainment.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxTeacherEducationalAttainment.TabIndex = 13
        '
        'EducationalAttainment
        '
        Me.EducationalAttainment.AutoSize = True
        Me.EducationalAttainment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EducationalAttainment.Location = New System.Drawing.Point(656, 23)
        Me.EducationalAttainment.Name = "EducationalAttainment"
        Me.EducationalAttainment.Size = New System.Drawing.Size(181, 20)
        Me.EducationalAttainment.TabIndex = 12
        Me.EducationalAttainment.Text = "Educational Attainment"
        '
        'TextBoxTeacherContactNo
        '
        Me.TextBoxTeacherContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherContactNo.Location = New System.Drawing.Point(435, 139)
        Me.TextBoxTeacherContactNo.Name = "TextBoxTeacherContactNo"
        Me.TextBoxTeacherContactNo.Size = New System.Drawing.Size(233, 26)
        Me.TextBoxTeacherContactNo.TabIndex = 11
        '
        'ContactNo
        '
        Me.ContactNo.AutoSize = True
        Me.ContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNo.Location = New System.Drawing.Point(355, 117)
        Me.ContactNo.Name = "ContactNo"
        Me.ContactNo.Size = New System.Drawing.Size(97, 20)
        Me.ContactNo.TabIndex = 10
        Me.ContactNo.Text = "Contact No."
        '
        'TextBoxTeacherEmail
        '
        Me.TextBoxTeacherEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherEmail.Location = New System.Drawing.Point(435, 92)
        Me.TextBoxTeacherEmail.Name = "TextBoxTeacherEmail"
        Me.TextBoxTeacherEmail.Size = New System.Drawing.Size(233, 26)
        Me.TextBoxTeacherEmail.TabIndex = 9
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(401, 69)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(51, 20)
        Me.Email.TabIndex = 8
        Me.Email.Text = "Email"
        '
        'TextBoxTeacherEmployeeNo
        '
        Me.TextBoxTeacherEmployeeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherEmployeeNo.Location = New System.Drawing.Point(435, 46)
        Me.TextBoxTeacherEmployeeNo.Name = "TextBoxTeacherEmployeeNo"
        Me.TextBoxTeacherEmployeeNo.Size = New System.Drawing.Size(233, 26)
        Me.TextBoxTeacherEmployeeNo.TabIndex = 7
        '
        'EmployeeNo
        '
        Me.EmployeeNo.AutoSize = True
        Me.EmployeeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNo.Location = New System.Drawing.Point(340, 26)
        Me.EmployeeNo.Name = "EmployeeNo"
        Me.EmployeeNo.Size = New System.Drawing.Size(112, 20)
        Me.EmployeeNo.TabIndex = 6
        Me.EmployeeNo.Text = "Employee No."
        '
        'TextBoxTeacherSurname
        '
        Me.TextBoxTeacherSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherSurname.Location = New System.Drawing.Point(82, 139)
        Me.TextBoxTeacherSurname.Name = "TextBoxTeacherSurname"
        Me.TextBoxTeacherSurname.Size = New System.Drawing.Size(241, 26)
        Me.TextBoxTeacherSurname.TabIndex = 5
        '
        'Surname
        '
        Me.Surname.AutoSize = True
        Me.Surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Surname.Location = New System.Drawing.Point(55, 117)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(76, 20)
        Me.Surname.TabIndex = 4
        Me.Surname.Text = "Surname"
        '
        'TextBoxTeacherMiddleName
        '
        Me.TextBoxTeacherMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherMiddleName.Location = New System.Drawing.Point(84, 91)
        Me.TextBoxTeacherMiddleName.Name = "TextBoxTeacherMiddleName"
        Me.TextBoxTeacherMiddleName.Size = New System.Drawing.Size(239, 26)
        Me.TextBoxTeacherMiddleName.TabIndex = 3
        '
        'MiddleName
        '
        Me.MiddleName.AutoSize = True
        Me.MiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleName.Location = New System.Drawing.Point(24, 69)
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Size = New System.Drawing.Size(107, 20)
        Me.MiddleName.TabIndex = 2
        Me.MiddleName.Text = "Middle Name"
        '
        'TextBoxTeacherFirstName
        '
        Me.TextBoxTeacherFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherFirstName.Location = New System.Drawing.Point(84, 46)
        Me.TextBoxTeacherFirstName.Name = "TextBoxTeacherFirstName"
        Me.TextBoxTeacherFirstName.Size = New System.Drawing.Size(239, 26)
        Me.TextBoxTeacherFirstName.TabIndex = 1
        '
        'TeacherFirstName
        '
        Me.TeacherFirstName.AutoSize = True
        Me.TeacherFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherFirstName.Location = New System.Drawing.Point(38, 26)
        Me.TeacherFirstName.Name = "TeacherFirstName"
        Me.TeacherFirstName.Size = New System.Drawing.Size(92, 20)
        Me.TeacherFirstName.TabIndex = 0
        Me.TeacherFirstName.Text = "FIrst Name"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(1126, 723)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(117, 43)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(828, 142)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 42
        '
        'ComboBoxTeacherStatus
        '
        Me.ComboBoxTeacherStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTeacherStatus.FormattingEnabled = True
        Me.ComboBoxTeacherStatus.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxTeacherStatus.Location = New System.Drawing.Point(1155, 86)
        Me.ComboBoxTeacherStatus.Name = "ComboBoxTeacherStatus"
        Me.ComboBoxTeacherStatus.Size = New System.Drawing.Size(110, 28)
        Me.ComboBoxTeacherStatus.TabIndex = 43
        '
        'picWatermark
        '
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(340, 139)
        Me.picWatermark.Margin = New System.Windows.Forms.Padding(4)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(648, 596)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 22
        Me.picWatermark.TabStop = False
        '
        'AdminManageTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1733, 779)
        Me.Controls.Add(Me.pnlContent)
        Me.Name = "AdminManageTeacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher"
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents pnlContent As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblTeacherList As Label
    Friend WithEvents TeacherFirstName As Label
    Friend WithEvents HireDate As Label
    Friend WithEvents TextBoxTeacherSpecialization As TextBox
    Friend WithEvents Specialization As Label
    Friend WithEvents TextBoxTeacherEducationalAttainment As TextBox
    Friend WithEvents EducationalAttainment As Label
    Friend WithEvents TextBoxTeacherContactNo As TextBox
    Friend WithEvents ContactNo As Label
    Friend WithEvents TextBoxTeacherEmail As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents TextBoxTeacherEmployeeNo As TextBox
    Friend WithEvents EmployeeNo As Label
    Friend WithEvents TextBoxTeacherSurname As TextBox
    Friend WithEvents Surname As Label
    Friend WithEvents TextBoxTeacherMiddleName As TextBox
    Friend WithEvents MiddleName As Label
    Friend WithEvents TextBoxTeacherFirstName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxTeacherassignedSection As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBoxTeacherGender As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbxTeacherZipCode As TextBox
    Friend WithEvents lblTeacherZIP As Label
    Friend WithEvents txtbxTeacherProvince As TextBox
    Friend WithEvents lblTeacherProvince As Label
    Friend WithEvents txtbxTeacherBarangay As TextBox
    Friend WithEvents lblTeacherBarangay As Label
    Friend WithEvents txtbxTeacherCountry As TextBox
    Friend WithEvents lblTeacherCountry As Label
    Friend WithEvents txtbxTeacherCity As TextBox
    Friend WithEvents lblTeacherCity As Label
    Friend WithEvents txtbcTeacherStreet As TextBox
    Friend WithEvents lblTeacherStreet As Label
    Friend WithEvents txtbxTeacherHouseNo As TextBox
    Friend WithEvents lbTeacherHouseNumber As Label
    Friend WithEvents ComboBoxTeacherStatus As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
