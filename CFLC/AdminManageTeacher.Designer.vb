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
        Me.TextBoxTeacherSearch = New System.Windows.Forms.TextBox()
        Me.lblTeacherList = New System.Windows.Forms.Label()
        Me.btnTeaDelete = New System.Windows.Forms.Button()
        Me.dgvTeacher = New System.Windows.Forms.DataGridView()
        Me.btnTeaUpdate = New System.Windows.Forms.Button()
        Me.btnTeaAdd = New System.Windows.Forms.Button()
        Me.TextBoxProvince = New System.Windows.Forms.Panel()
        Me.txtbxTeacherAge = New System.Windows.Forms.TextBox()
        Me.txtTeacherAge = New System.Windows.Forms.Label()
        Me.TextBoxTeacherExtension = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTImePickerTeacherBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxTeacherStatus = New System.Windows.Forms.ComboBox()
        Me.ManageTeacherHireDate = New System.Windows.Forms.DateTimePicker()
        Me.txtbxTeacherZipCode = New System.Windows.Forms.TextBox()
        Me.lblTeacherZIP = New System.Windows.Forms.Label()
        Me.txtbxTeacherProvince = New System.Windows.Forms.TextBox()
        Me.lblTeacherProvince = New System.Windows.Forms.Label()
        Me.TeacherEmail = New System.Windows.Forms.Label()
        Me.txtbxTeacherBarangay = New System.Windows.Forms.TextBox()
        Me.TextBoxTeacherEmail = New System.Windows.Forms.TextBox()
        Me.lblTeacherBarangay = New System.Windows.Forms.Label()
        Me.TeacherContactNo = New System.Windows.Forms.Label()
        Me.txtbxTeacherCountry = New System.Windows.Forms.TextBox()
        Me.TextBoxTeacherContactNo = New System.Windows.Forms.TextBox()
        Me.lblTeacherCountry = New System.Windows.Forms.Label()
        Me.txtbxTeacherCity = New System.Windows.Forms.TextBox()
        Me.lblTeacherCity = New System.Windows.Forms.Label()
        Me.txtbxTeacherHouseNo = New System.Windows.Forms.TextBox()
        Me.lbTeacherHouseNumber = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBoxTeacherGender = New System.Windows.Forms.ComboBox()
        Me.TeacherSex = New System.Windows.Forms.Label()
        Me.TeacherBirthDate = New System.Windows.Forms.Label()
        Me.TeacherStatus = New System.Windows.Forms.Label()
        Me.TeacherHireDate = New System.Windows.Forms.Label()
        Me.TextBoxTeacherSpecialization = New System.Windows.Forms.TextBox()
        Me.TeacherSpecialization = New System.Windows.Forms.Label()
        Me.TextBoxTeacherEducationalAttainment = New System.Windows.Forms.TextBox()
        Me.TeacherEducationalAttainment = New System.Windows.Forms.Label()
        Me.TextBoxTeacherSurname = New System.Windows.Forms.TextBox()
        Me.TeacherSurname = New System.Windows.Forms.Label()
        Me.TextBoxTeacherMiddleName = New System.Windows.Forms.TextBox()
        Me.TeacherMiddleName = New System.Windows.Forms.Label()
        Me.TextBoxTeacherFirstName = New System.Windows.Forms.TextBox()
        Me.TeacherFirstName = New System.Windows.Forms.Label()
        Me.btnTeaSearch = New System.Windows.Forms.Button()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TextBoxProvince.SuspendLayout()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.TextBoxTeacherSearch)
        Me.pnlContent.Controls.Add(Me.lblTeacherList)
        Me.pnlContent.Controls.Add(Me.btnTeaDelete)
        Me.pnlContent.Controls.Add(Me.dgvTeacher)
        Me.pnlContent.Controls.Add(Me.btnTeaUpdate)
        Me.pnlContent.Controls.Add(Me.btnTeaAdd)
        Me.pnlContent.Controls.Add(Me.TextBoxProvince)
        Me.pnlContent.Controls.Add(Me.btnTeaSearch)
        Me.pnlContent.Controls.Add(Me.picWatermark)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1300, 774)
        Me.pnlContent.TabIndex = 23
        '
        'TextBoxTeacherSearch
        '
        Me.TextBoxTeacherSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTeacherSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherSearch.Location = New System.Drawing.Point(747, 710)
        Me.TextBoxTeacherSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTeacherSearch.MaxLength = 50
        Me.TextBoxTeacherSearch.Name = "TextBoxTeacherSearch"
        Me.TextBoxTeacherSearch.Size = New System.Drawing.Size(186, 30)
        Me.TextBoxTeacherSearch.TabIndex = 28
        '
        'lblTeacherList
        '
        Me.lblTeacherList.AutoSize = True
        Me.lblTeacherList.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTeacherList.ForeColor = System.Drawing.Color.White
        Me.lblTeacherList.Location = New System.Drawing.Point(44, 23)
        Me.lblTeacherList.Name = "lblTeacherList"
        Me.lblTeacherList.Size = New System.Drawing.Size(111, 25)
        Me.lblTeacherList.TabIndex = 24
        Me.lblTeacherList.Text = "Teacher List"
        '
        'btnTeaDelete
        '
        Me.btnTeaDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTeaDelete.Location = New System.Drawing.Point(1182, 704)
        Me.btnTeaDelete.Name = "btnTeaDelete"
        Me.btnTeaDelete.Size = New System.Drawing.Size(86, 35)
        Me.btnTeaDelete.TabIndex = 27
        Me.btnTeaDelete.Text = "Delete"
        Me.btnTeaDelete.UseVisualStyleBackColor = True
        '
        'dgvTeacher
        '
        Me.dgvTeacher.AllowUserToAddRows = False
        Me.dgvTeacher.AllowUserToDeleteRows = False
        Me.dgvTeacher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTeacher.BackgroundColor = System.Drawing.Color.White
        Me.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeacher.Location = New System.Drawing.Point(48, 459)
        Me.dgvTeacher.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvTeacher.Name = "dgvTeacher"
        Me.dgvTeacher.ReadOnly = True
        Me.dgvTeacher.RowHeadersVisible = False
        Me.dgvTeacher.RowHeadersWidth = 51
        Me.dgvTeacher.RowTemplate.Height = 24
        Me.dgvTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTeacher.Size = New System.Drawing.Size(1220, 228)
        Me.dgvTeacher.TabIndex = 24
        '
        'btnTeaUpdate
        '
        Me.btnTeaUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTeaUpdate.Location = New System.Drawing.Point(1070, 704)
        Me.btnTeaUpdate.Name = "btnTeaUpdate"
        Me.btnTeaUpdate.Size = New System.Drawing.Size(86, 35)
        Me.btnTeaUpdate.TabIndex = 26
        Me.btnTeaUpdate.Text = "Update"
        Me.btnTeaUpdate.UseVisualStyleBackColor = True
        '
        'btnTeaAdd
        '
        Me.btnTeaAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTeaAdd.Location = New System.Drawing.Point(958, 704)
        Me.btnTeaAdd.Name = "btnTeaAdd"
        Me.btnTeaAdd.Size = New System.Drawing.Size(86, 35)
        Me.btnTeaAdd.TabIndex = 25
        Me.btnTeaAdd.Text = "Add"
        Me.btnTeaAdd.UseVisualStyleBackColor = True
        '
        'TextBoxProvince
        '
        Me.TextBoxProvince.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxProvince.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxProvince.Controls.Add(Me.txtbxTeacherAge)
        Me.TextBoxProvince.Controls.Add(Me.txtTeacherAge)
        Me.TextBoxProvince.Controls.Add(Me.TextBoxTeacherExtension)
        Me.TextBoxProvince.Controls.Add(Me.Label2)
        Me.TextBoxProvince.Controls.Add(Me.Label1)
        Me.TextBoxProvince.Controls.Add(Me.DateTImePickerTeacherBirthdate)
        Me.TextBoxProvince.Controls.Add(Me.ComboBoxTeacherStatus)
        Me.TextBoxProvince.Controls.Add(Me.ManageTeacherHireDate)
        Me.TextBoxProvince.Controls.Add(Me.txtbxTeacherZipCode)
        Me.TextBoxProvince.Controls.Add(Me.lblTeacherZIP)
        Me.TextBoxProvince.Controls.Add(Me.txtbxTeacherProvince)
        Me.TextBoxProvince.Controls.Add(Me.lblTeacherProvince)
        Me.TextBoxProvince.Controls.Add(Me.TeacherEmail)
        Me.TextBoxProvince.Controls.Add(Me.txtbxTeacherBarangay)
        Me.TextBoxProvince.Controls.Add(Me.TextBoxTeacherEmail)
        Me.TextBoxProvince.Controls.Add(Me.lblTeacherBarangay)
        Me.TextBoxProvince.Controls.Add(Me.TeacherContactNo)
        Me.TextBoxProvince.Controls.Add(Me.txtbxTeacherCountry)
        Me.TextBoxProvince.Controls.Add(Me.TextBoxTeacherContactNo)
        Me.TextBoxProvince.Controls.Add(Me.lblTeacherCountry)
        Me.TextBoxProvince.Controls.Add(Me.txtbxTeacherCity)
        Me.TextBoxProvince.Controls.Add(Me.lblTeacherCity)
        Me.TextBoxProvince.Controls.Add(Me.txtbxTeacherHouseNo)
        Me.TextBoxProvince.Controls.Add(Me.lbTeacherHouseNumber)
        Me.TextBoxProvince.Controls.Add(Me.Label15)
        Me.TextBoxProvince.Controls.Add(Me.Label14)
        Me.TextBoxProvince.Controls.Add(Me.ComboBoxTeacherGender)
        Me.TextBoxProvince.Controls.Add(Me.TeacherSex)
        Me.TextBoxProvince.Controls.Add(Me.TeacherBirthDate)
        Me.TextBoxProvince.Controls.Add(Me.TeacherStatus)
        Me.TextBoxProvince.Controls.Add(Me.TeacherHireDate)
        Me.TextBoxProvince.Controls.Add(Me.TextBoxTeacherSpecialization)
        Me.TextBoxProvince.Controls.Add(Me.TeacherSpecialization)
        Me.TextBoxProvince.Controls.Add(Me.TextBoxTeacherEducationalAttainment)
        Me.TextBoxProvince.Controls.Add(Me.TeacherEducationalAttainment)
        Me.TextBoxProvince.Controls.Add(Me.TextBoxTeacherSurname)
        Me.TextBoxProvince.Controls.Add(Me.TeacherSurname)
        Me.TextBoxProvince.Controls.Add(Me.TextBoxTeacherMiddleName)
        Me.TextBoxProvince.Controls.Add(Me.TeacherMiddleName)
        Me.TextBoxProvince.Controls.Add(Me.TextBoxTeacherFirstName)
        Me.TextBoxProvince.Controls.Add(Me.TeacherFirstName)
        Me.TextBoxProvince.Location = New System.Drawing.Point(48, 72)
        Me.TextBoxProvince.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxProvince.Name = "TextBoxProvince"
        Me.TextBoxProvince.Padding = New System.Windows.Forms.Padding(2)
        Me.TextBoxProvince.Size = New System.Drawing.Size(1220, 370)
        Me.TextBoxProvince.TabIndex = 23
        '
        'txtbxTeacherAge
        '
        Me.txtbxTeacherAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherAge.Location = New System.Drawing.Point(428, 42)
        Me.txtbxTeacherAge.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbxTeacherAge.MaxLength = 50
        Me.txtbxTeacherAge.Name = "txtbxTeacherAge"
        Me.txtbxTeacherAge.Size = New System.Drawing.Size(53, 23)
        Me.txtbxTeacherAge.TabIndex = 52
        '
        'txtTeacherAge
        '
        Me.txtTeacherAge.AutoSize = True
        Me.txtTeacherAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeacherAge.Location = New System.Drawing.Point(425, 23)
        Me.txtTeacherAge.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtTeacherAge.Name = "txtTeacherAge"
        Me.txtTeacherAge.Size = New System.Drawing.Size(33, 17)
        Me.txtTeacherAge.TabIndex = 51
        Me.txtTeacherAge.Text = "Age"
        '
        'TextBoxTeacherExtension
        '
        Me.TextBoxTeacherExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherExtension.Location = New System.Drawing.Point(63, 176)
        Me.TextBoxTeacherExtension.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTeacherExtension.MaxLength = 50
        Me.TextBoxTeacherExtension.Name = "TextBoxTeacherExtension"
        Me.TextBoxTeacherExtension.Size = New System.Drawing.Size(182, 23)
        Me.TextBoxTeacherExtension.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 17)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Extension (Jr, III, Etc)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(751, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 47
        '
        'DateTImePickerTeacherBirthdate
        '
        Me.DateTImePickerTeacherBirthdate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTImePickerTeacherBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTImePickerTeacherBirthdate.Location = New System.Drawing.Point(302, 84)
        Me.DateTImePickerTeacherBirthdate.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTImePickerTeacherBirthdate.Name = "DateTImePickerTeacherBirthdate"
        Me.DateTImePickerTeacherBirthdate.Size = New System.Drawing.Size(175, 23)
        Me.DateTImePickerTeacherBirthdate.TabIndex = 46
        '
        'ComboBoxTeacherStatus
        '
        Me.ComboBoxTeacherStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTeacherStatus.FormattingEnabled = True
        Me.ComboBoxTeacherStatus.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxTeacherStatus.Location = New System.Drawing.Point(754, 79)
        Me.ComboBoxTeacherStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxTeacherStatus.Name = "ComboBoxTeacherStatus"
        Me.ComboBoxTeacherStatus.Size = New System.Drawing.Size(84, 24)
        Me.ComboBoxTeacherStatus.TabIndex = 43
        '
        'ManageTeacherHireDate
        '
        Me.ManageTeacherHireDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageTeacherHireDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageTeacherHireDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ManageTeacherHireDate.Location = New System.Drawing.Point(529, 132)
        Me.ManageTeacherHireDate.Margin = New System.Windows.Forms.Padding(2)
        Me.ManageTeacherHireDate.Name = "ManageTeacherHireDate"
        Me.ManageTeacherHireDate.Size = New System.Drawing.Size(89, 23)
        Me.ManageTeacherHireDate.TabIndex = 42
        '
        'txtbxTeacherZipCode
        '
        Me.txtbxTeacherZipCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherZipCode.Location = New System.Drawing.Point(524, 313)
        Me.txtbxTeacherZipCode.Name = "txtbxTeacherZipCode"
        Me.txtbxTeacherZipCode.Size = New System.Drawing.Size(180, 23)
        Me.txtbxTeacherZipCode.TabIndex = 41
        '
        'lblTeacherZIP
        '
        Me.lblTeacherZIP.AutoSize = True
        Me.lblTeacherZIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherZIP.Location = New System.Drawing.Point(520, 291)
        Me.lblTeacherZIP.Name = "lblTeacherZIP"
        Me.lblTeacherZIP.Size = New System.Drawing.Size(65, 17)
        Me.lblTeacherZIP.TabIndex = 40
        Me.lblTeacherZIP.Text = "Zip Code"
        '
        'txtbxTeacherProvince
        '
        Me.txtbxTeacherProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherProvince.Location = New System.Drawing.Point(306, 313)
        Me.txtbxTeacherProvince.MaxLength = 50
        Me.txtbxTeacherProvince.Name = "txtbxTeacherProvince"
        Me.txtbxTeacherProvince.Size = New System.Drawing.Size(174, 23)
        Me.txtbxTeacherProvince.TabIndex = 39
        '
        'lblTeacherProvince
        '
        Me.lblTeacherProvince.AutoSize = True
        Me.lblTeacherProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherProvince.Location = New System.Drawing.Point(303, 291)
        Me.lblTeacherProvince.Name = "lblTeacherProvince"
        Me.lblTeacherProvince.Size = New System.Drawing.Size(63, 17)
        Me.lblTeacherProvince.TabIndex = 38
        Me.lblTeacherProvince.Text = "Province"
        '
        'TeacherEmail
        '
        Me.TeacherEmail.AutoSize = True
        Me.TeacherEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherEmail.Location = New System.Drawing.Point(530, 18)
        Me.TeacherEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TeacherEmail.Name = "TeacherEmail"
        Me.TeacherEmail.Size = New System.Drawing.Size(42, 17)
        Me.TeacherEmail.TabIndex = 8
        Me.TeacherEmail.Text = "Email"
        '
        'txtbxTeacherBarangay
        '
        Me.txtbxTeacherBarangay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherBarangay.Location = New System.Drawing.Point(62, 312)
        Me.txtbxTeacherBarangay.MaxLength = 20
        Me.txtbxTeacherBarangay.Name = "txtbxTeacherBarangay"
        Me.txtbxTeacherBarangay.Size = New System.Drawing.Size(192, 23)
        Me.txtbxTeacherBarangay.TabIndex = 37
        '
        'TextBoxTeacherEmail
        '
        Me.TextBoxTeacherEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherEmail.Location = New System.Drawing.Point(526, 38)
        Me.TextBoxTeacherEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTeacherEmail.MaxLength = 50
        Me.TextBoxTeacherEmail.Name = "TextBoxTeacherEmail"
        Me.TextBoxTeacherEmail.Size = New System.Drawing.Size(176, 23)
        Me.TextBoxTeacherEmail.TabIndex = 9
        '
        'lblTeacherBarangay
        '
        Me.lblTeacherBarangay.AutoSize = True
        Me.lblTeacherBarangay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherBarangay.Location = New System.Drawing.Point(58, 291)
        Me.lblTeacherBarangay.Name = "lblTeacherBarangay"
        Me.lblTeacherBarangay.Size = New System.Drawing.Size(69, 17)
        Me.lblTeacherBarangay.TabIndex = 36
        Me.lblTeacherBarangay.Text = "Barangay"
        '
        'TeacherContactNo
        '
        Me.TeacherContactNo.AutoSize = True
        Me.TeacherContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherContactNo.Location = New System.Drawing.Point(303, 110)
        Me.TeacherContactNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TeacherContactNo.Name = "TeacherContactNo"
        Me.TeacherContactNo.Size = New System.Drawing.Size(82, 17)
        Me.TeacherContactNo.TabIndex = 10
        Me.TeacherContactNo.Text = "Contact No."
        '
        'txtbxTeacherCountry
        '
        Me.txtbxTeacherCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherCountry.Location = New System.Drawing.Point(529, 266)
        Me.txtbxTeacherCountry.MaxLength = 20
        Me.txtbxTeacherCountry.Name = "txtbxTeacherCountry"
        Me.txtbxTeacherCountry.Size = New System.Drawing.Size(179, 23)
        Me.txtbxTeacherCountry.TabIndex = 35
        '
        'TextBoxTeacherContactNo
        '
        Me.TextBoxTeacherContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherContactNo.Location = New System.Drawing.Point(302, 129)
        Me.TextBoxTeacherContactNo.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTeacherContactNo.MaxLength = 15
        Me.TextBoxTeacherContactNo.Name = "TextBoxTeacherContactNo"
        Me.TextBoxTeacherContactNo.Size = New System.Drawing.Size(176, 23)
        Me.TextBoxTeacherContactNo.TabIndex = 11
        '
        'lblTeacherCountry
        '
        Me.lblTeacherCountry.AutoSize = True
        Me.lblTeacherCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherCountry.Location = New System.Drawing.Point(520, 245)
        Me.lblTeacherCountry.Name = "lblTeacherCountry"
        Me.lblTeacherCountry.Size = New System.Drawing.Size(57, 17)
        Me.lblTeacherCountry.TabIndex = 34
        Me.lblTeacherCountry.Text = "Country"
        '
        'txtbxTeacherCity
        '
        Me.txtbxTeacherCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherCity.Location = New System.Drawing.Point(307, 266)
        Me.txtbxTeacherCity.MaxLength = 50
        Me.txtbxTeacherCity.Name = "txtbxTeacherCity"
        Me.txtbxTeacherCity.Size = New System.Drawing.Size(174, 23)
        Me.txtbxTeacherCity.TabIndex = 33
        '
        'lblTeacherCity
        '
        Me.lblTeacherCity.AutoSize = True
        Me.lblTeacherCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherCity.Location = New System.Drawing.Point(304, 245)
        Me.lblTeacherCity.Name = "lblTeacherCity"
        Me.lblTeacherCity.Size = New System.Drawing.Size(116, 17)
        Me.lblTeacherCity.TabIndex = 32
        Me.lblTeacherCity.Text = "City / Municipality"
        '
        'txtbxTeacherHouseNo
        '
        Me.txtbxTeacherHouseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherHouseNo.Location = New System.Drawing.Point(62, 266)
        Me.txtbxTeacherHouseNo.Name = "txtbxTeacherHouseNo"
        Me.txtbxTeacherHouseNo.Size = New System.Drawing.Size(188, 23)
        Me.txtbxTeacherHouseNo.TabIndex = 29
        '
        'lbTeacherHouseNumber
        '
        Me.lbTeacherHouseNumber.AutoSize = True
        Me.lbTeacherHouseNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTeacherHouseNumber.Location = New System.Drawing.Point(58, 246)
        Me.lbTeacherHouseNumber.Name = "lbTeacherHouseNumber"
        Me.lbTeacherHouseNumber.Size = New System.Drawing.Size(103, 17)
        Me.lbTeacherHouseNumber.TabIndex = 28
        Me.lbTeacherHouseNumber.Text = "House Number"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(2, 231)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 17)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Address"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(-1, 2)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 17)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Teacher List"
        '
        'ComboBoxTeacherGender
        '
        Me.ComboBoxTeacherGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTeacherGender.FormattingEnabled = True
        Me.ComboBoxTeacherGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxTeacherGender.Location = New System.Drawing.Point(302, 41)
        Me.ComboBoxTeacherGender.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxTeacherGender.Name = "ComboBoxTeacherGender"
        Me.ComboBoxTeacherGender.Size = New System.Drawing.Size(84, 24)
        Me.ComboBoxTeacherGender.TabIndex = 25
        '
        'TeacherSex
        '
        Me.TeacherSex.AutoSize = True
        Me.TeacherSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherSex.Location = New System.Drawing.Point(303, 23)
        Me.TeacherSex.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TeacherSex.Name = "TeacherSex"
        Me.TeacherSex.Size = New System.Drawing.Size(31, 17)
        Me.TeacherSex.TabIndex = 24
        Me.TeacherSex.Text = "Sex"
        '
        'TeacherBirthDate
        '
        Me.TeacherBirthDate.AutoSize = True
        Me.TeacherBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherBirthDate.Location = New System.Drawing.Point(304, 67)
        Me.TeacherBirthDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TeacherBirthDate.Name = "TeacherBirthDate"
        Me.TeacherBirthDate.Size = New System.Drawing.Size(71, 17)
        Me.TeacherBirthDate.TabIndex = 22
        Me.TeacherBirthDate.Text = "Birth Date"
        '
        'TeacherStatus
        '
        Me.TeacherStatus.AutoSize = True
        Me.TeacherStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherStatus.Location = New System.Drawing.Point(760, 62)
        Me.TeacherStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TeacherStatus.Name = "TeacherStatus"
        Me.TeacherStatus.Size = New System.Drawing.Size(48, 17)
        Me.TeacherStatus.TabIndex = 20
        Me.TeacherStatus.Text = "Status"
        '
        'TeacherHireDate
        '
        Me.TeacherHireDate.AutoSize = True
        Me.TeacherHireDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherHireDate.Location = New System.Drawing.Point(530, 112)
        Me.TeacherHireDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TeacherHireDate.Name = "TeacherHireDate"
        Me.TeacherHireDate.Size = New System.Drawing.Size(68, 17)
        Me.TeacherHireDate.TabIndex = 16
        Me.TeacherHireDate.Text = "Hire Date"
        '
        'TextBoxTeacherSpecialization
        '
        Me.TextBoxTeacherSpecialization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherSpecialization.Location = New System.Drawing.Point(754, 38)
        Me.TextBoxTeacherSpecialization.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTeacherSpecialization.MaxLength = 100
        Me.TextBoxTeacherSpecialization.Name = "TextBoxTeacherSpecialization"
        Me.TextBoxTeacherSpecialization.Size = New System.Drawing.Size(156, 23)
        Me.TextBoxTeacherSpecialization.TabIndex = 15
        '
        'TeacherSpecialization
        '
        Me.TeacherSpecialization.AutoSize = True
        Me.TeacherSpecialization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherSpecialization.Location = New System.Drawing.Point(754, 17)
        Me.TeacherSpecialization.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TeacherSpecialization.Name = "TeacherSpecialization"
        Me.TeacherSpecialization.Size = New System.Drawing.Size(95, 17)
        Me.TeacherSpecialization.TabIndex = 14
        Me.TeacherSpecialization.Text = "Specialization"
        '
        'TextBoxTeacherEducationalAttainment
        '
        Me.TextBoxTeacherEducationalAttainment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherEducationalAttainment.Location = New System.Drawing.Point(529, 82)
        Me.TextBoxTeacherEducationalAttainment.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTeacherEducationalAttainment.MaxLength = 100
        Me.TextBoxTeacherEducationalAttainment.Name = "TextBoxTeacherEducationalAttainment"
        Me.TextBoxTeacherEducationalAttainment.Size = New System.Drawing.Size(173, 23)
        Me.TextBoxTeacherEducationalAttainment.TabIndex = 13
        '
        'TeacherEducationalAttainment
        '
        Me.TeacherEducationalAttainment.AutoSize = True
        Me.TeacherEducationalAttainment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherEducationalAttainment.Location = New System.Drawing.Point(532, 63)
        Me.TeacherEducationalAttainment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TeacherEducationalAttainment.Name = "TeacherEducationalAttainment"
        Me.TeacherEducationalAttainment.Size = New System.Drawing.Size(153, 17)
        Me.TeacherEducationalAttainment.TabIndex = 12
        Me.TeacherEducationalAttainment.Text = "Educational Attainment"
        '
        'TextBoxTeacherSurname
        '
        Me.TextBoxTeacherSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherSurname.Location = New System.Drawing.Point(63, 129)
        Me.TextBoxTeacherSurname.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTeacherSurname.MaxLength = 50
        Me.TextBoxTeacherSurname.Name = "TextBoxTeacherSurname"
        Me.TextBoxTeacherSurname.Size = New System.Drawing.Size(182, 23)
        Me.TextBoxTeacherSurname.TabIndex = 5
        '
        'TeacherSurname
        '
        Me.TeacherSurname.AutoSize = True
        Me.TeacherSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherSurname.Location = New System.Drawing.Point(66, 110)
        Me.TeacherSurname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TeacherSurname.Name = "TeacherSurname"
        Me.TeacherSurname.Size = New System.Drawing.Size(65, 17)
        Me.TeacherSurname.TabIndex = 4
        Me.TeacherSurname.Text = "Surname"
        '
        'TextBoxTeacherMiddleName
        '
        Me.TextBoxTeacherMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherMiddleName.Location = New System.Drawing.Point(64, 86)
        Me.TextBoxTeacherMiddleName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTeacherMiddleName.MaxLength = 50
        Me.TextBoxTeacherMiddleName.Name = "TextBoxTeacherMiddleName"
        Me.TextBoxTeacherMiddleName.Size = New System.Drawing.Size(180, 23)
        Me.TextBoxTeacherMiddleName.TabIndex = 3
        '
        'TeacherMiddleName
        '
        Me.TeacherMiddleName.AutoSize = True
        Me.TeacherMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherMiddleName.Location = New System.Drawing.Point(65, 65)
        Me.TeacherMiddleName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TeacherMiddleName.Name = "TeacherMiddleName"
        Me.TeacherMiddleName.Size = New System.Drawing.Size(90, 17)
        Me.TeacherMiddleName.TabIndex = 2
        Me.TeacherMiddleName.Text = "Middle Name"
        '
        'TextBoxTeacherFirstName
        '
        Me.TextBoxTeacherFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherFirstName.Location = New System.Drawing.Point(64, 41)
        Me.TextBoxTeacherFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTeacherFirstName.MaxLength = 50
        Me.TextBoxTeacherFirstName.Name = "TextBoxTeacherFirstName"
        Me.TextBoxTeacherFirstName.Size = New System.Drawing.Size(180, 23)
        Me.TextBoxTeacherFirstName.TabIndex = 1
        '
        'TeacherFirstName
        '
        Me.TeacherFirstName.AutoSize = True
        Me.TeacherFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherFirstName.Location = New System.Drawing.Point(67, 22)
        Me.TeacherFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TeacherFirstName.Name = "TeacherFirstName"
        Me.TeacherFirstName.Size = New System.Drawing.Size(76, 17)
        Me.TeacherFirstName.TabIndex = 0
        Me.TeacherFirstName.Text = "FIrst Name"
        '
        'btnTeaSearch
        '
        Me.btnTeaSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTeaSearch.Location = New System.Drawing.Point(844, 565)
        Me.btnTeaSearch.Name = "btnTeaSearch"
        Me.btnTeaSearch.Size = New System.Drawing.Size(88, 35)
        Me.btnTeaSearch.TabIndex = 24
        Me.btnTeaSearch.Text = "Search"
        Me.btnTeaSearch.UseVisualStyleBackColor = True
        '
        'picWatermark
        '
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(365, 113)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(486, 484)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 22
        Me.picWatermark.TabStop = False
        '
        'AdminManageTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 774)
        Me.Controls.Add(Me.pnlContent)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdminManageTeacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher"
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.dgvTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TextBoxProvince.ResumeLayout(False)
        Me.TextBoxProvince.PerformLayout()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents pnlContent As Panel
    Friend WithEvents dgvTeacher As DataGridView
    Friend WithEvents TextBoxProvince As Panel
    Friend WithEvents btnTeaDelete As Button
    Friend WithEvents btnTeaUpdate As Button
    Friend WithEvents btnTeaAdd As Button
    Friend WithEvents btnTeaSearch As Button
    Friend WithEvents lblTeacherList As Label
    Friend WithEvents TeacherFirstName As Label
    Friend WithEvents TeacherHireDate As Label
    Friend WithEvents TextBoxTeacherSpecialization As TextBox
    Friend WithEvents TeacherSpecialization As Label
    Friend WithEvents TextBoxTeacherEducationalAttainment As TextBox
    Friend WithEvents TeacherEducationalAttainment As Label
    Friend WithEvents TextBoxTeacherContactNo As TextBox
    Friend WithEvents TeacherContactNo As Label
    Friend WithEvents TextBoxTeacherEmail As TextBox
    Friend WithEvents TeacherEmail As Label
    Friend WithEvents TextBoxTeacherSurname As TextBox
    Friend WithEvents TeacherSurname As Label
    Friend WithEvents TextBoxTeacherMiddleName As TextBox
    Friend WithEvents TeacherMiddleName As Label
    Friend WithEvents TextBoxTeacherFirstName As TextBox
    Friend WithEvents TeacherSex As Label
    Friend WithEvents TeacherBirthDate As Label
    Friend WithEvents TeacherStatus As Label
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
    Friend WithEvents txtbxTeacherHouseNo As TextBox
    Friend WithEvents lbTeacherHouseNumber As Label
    Friend WithEvents ComboBoxTeacherStatus As ComboBox
    Friend WithEvents ManageTeacherHireDate As DateTimePicker
    Friend WithEvents DateTImePickerTeacherBirthdate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxTeacherSearch As TextBox
    Friend WithEvents TextBoxTeacherExtension As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTeacherAge As Label
    Friend WithEvents txtbxTeacherAge As TextBox
End Class
