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
        Me.btnTeaDelete = New System.Windows.Forms.Button()
        Me.dgvTeacher = New System.Windows.Forms.DataGridView()
        Me.TeacherID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBirthDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.THouseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBarangay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMunicipality = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TProvince = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCountry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TZipcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEducationalAttainment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TSpecialization = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.THireDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TSectionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTeaUpdate = New System.Windows.Forms.Button()
        Me.btnTeaAdd = New System.Windows.Forms.Button()
        Me.TextBoxProvince = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
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
        Me.TeacherGender = New System.Windows.Forms.Label()
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
        'btnTeaDelete
        '
        Me.btnTeaDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTeaDelete.Location = New System.Drawing.Point(1576, 693)
        Me.btnTeaDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTeaDelete.Name = "btnTeaDelete"
        Me.btnTeaDelete.Size = New System.Drawing.Size(115, 43)
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
        Me.dgvTeacher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TeacherID, Me.TFirstName, Me.TMiddleName, Me.TLastName, Me.TGender, Me.TBirthDate, Me.TContactNumber, Me.TEmail, Me.THouseNumber, Me.TBarangay, Me.TMunicipality, Me.TProvince, Me.TCountry, Me.TZipcode, Me.TEducationalAttainment, Me.TSpecialization, Me.THireDate, Me.TStatus, Me.TSectionID})
        Me.dgvTeacher.Location = New System.Drawing.Point(64, 488)
        Me.dgvTeacher.Name = "dgvTeacher"
        Me.dgvTeacher.ReadOnly = True
        Me.dgvTeacher.RowHeadersVisible = False
        Me.dgvTeacher.RowHeadersWidth = 51
        Me.dgvTeacher.RowTemplate.Height = 24
        Me.dgvTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTeacher.Size = New System.Drawing.Size(1627, 183)
        Me.dgvTeacher.TabIndex = 24
        '
        'TeacherID
        '
        Me.TeacherID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TeacherID.HeaderText = "Teacher ID"
        Me.TeacherID.MinimumWidth = 6
        Me.TeacherID.Name = "TeacherID"
        Me.TeacherID.ReadOnly = True
        Me.TeacherID.Width = 95
        '
        'TFirstName
        '
        Me.TFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TFirstName.HeaderText = "First Name"
        Me.TFirstName.MinimumWidth = 6
        Me.TFirstName.Name = "TFirstName"
        Me.TFirstName.ReadOnly = True
        Me.TFirstName.Width = 93
        '
        'TMiddleName
        '
        Me.TMiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMiddleName.HeaderText = "Middle Name"
        Me.TMiddleName.MinimumWidth = 6
        Me.TMiddleName.Name = "TMiddleName"
        Me.TMiddleName.ReadOnly = True
        Me.TMiddleName.Width = 108
        '
        'TLastName
        '
        Me.TLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TLastName.HeaderText = "Last Name"
        Me.TLastName.MinimumWidth = 6
        Me.TLastName.Name = "TLastName"
        Me.TLastName.ReadOnly = True
        Me.TLastName.Width = 93
        '
        'TGender
        '
        Me.TGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TGender.HeaderText = "Gender"
        Me.TGender.MinimumWidth = 6
        Me.TGender.Name = "TGender"
        Me.TGender.ReadOnly = True
        Me.TGender.Width = 81
        '
        'TBirthDate
        '
        Me.TBirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TBirthDate.HeaderText = "Birth Date"
        Me.TBirthDate.MinimumWidth = 6
        Me.TBirthDate.Name = "TBirthDate"
        Me.TBirthDate.ReadOnly = True
        Me.TBirthDate.Width = 87
        '
        'TContactNumber
        '
        Me.TContactNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TContactNumber.HeaderText = "Contact No"
        Me.TContactNumber.MinimumWidth = 6
        Me.TContactNumber.Name = "TContactNumber"
        Me.TContactNumber.ReadOnly = True
        Me.TContactNumber.Width = 94
        '
        'TEmail
        '
        Me.TEmail.HeaderText = "Email"
        Me.TEmail.MinimumWidth = 6
        Me.TEmail.Name = "TEmail"
        Me.TEmail.ReadOnly = True
        Me.TEmail.Width = 125
        '
        'THouseNumber
        '
        Me.THouseNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.THouseNumber.HeaderText = "House Number"
        Me.THouseNumber.MinimumWidth = 6
        Me.THouseNumber.Name = "THouseNumber"
        Me.THouseNumber.ReadOnly = True
        Me.THouseNumber.Width = 117
        '
        'TBarangay
        '
        Me.TBarangay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TBarangay.HeaderText = "Barangay"
        Me.TBarangay.MinimumWidth = 6
        Me.TBarangay.Name = "TBarangay"
        Me.TBarangay.ReadOnly = True
        Me.TBarangay.Width = 95
        '
        'TMunicipality
        '
        Me.TMunicipality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMunicipality.HeaderText = "Municipality"
        Me.TMunicipality.MinimumWidth = 6
        Me.TMunicipality.Name = "TMunicipality"
        Me.TMunicipality.ReadOnly = True
        Me.TMunicipality.Width = 106
        '
        'TProvince
        '
        Me.TProvince.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TProvince.HeaderText = "Province"
        Me.TProvince.MinimumWidth = 6
        Me.TProvince.Name = "TProvince"
        Me.TProvince.ReadOnly = True
        Me.TProvince.Width = 89
        '
        'TCountry
        '
        Me.TCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCountry.HeaderText = "Country"
        Me.TCountry.MinimumWidth = 6
        Me.TCountry.Name = "TCountry"
        Me.TCountry.ReadOnly = True
        Me.TCountry.Width = 81
        '
        'TZipcode
        '
        Me.TZipcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TZipcode.HeaderText = "Zipcode"
        Me.TZipcode.MinimumWidth = 6
        Me.TZipcode.Name = "TZipcode"
        Me.TZipcode.ReadOnly = True
        Me.TZipcode.Width = 86
        '
        'TEducationalAttainment
        '
        Me.TEducationalAttainment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TEducationalAttainment.HeaderText = "Educational Attainment"
        Me.TEducationalAttainment.MinimumWidth = 6
        Me.TEducationalAttainment.Name = "TEducationalAttainment"
        Me.TEducationalAttainment.ReadOnly = True
        Me.TEducationalAttainment.Width = 157
        '
        'TSpecialization
        '
        Me.TSpecialization.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TSpecialization.HeaderText = "Specialization"
        Me.TSpecialization.MinimumWidth = 6
        Me.TSpecialization.Name = "TSpecialization"
        Me.TSpecialization.ReadOnly = True
        Me.TSpecialization.Width = 120
        '
        'THireDate
        '
        Me.THireDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.THireDate.HeaderText = "Hire Date"
        Me.THireDate.MinimumWidth = 6
        Me.THireDate.Name = "THireDate"
        Me.THireDate.ReadOnly = True
        Me.THireDate.Width = 86
        '
        'TStatus
        '
        Me.TStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TStatus.HeaderText = "Status"
        Me.TStatus.MinimumWidth = 6
        Me.TStatus.Name = "TStatus"
        Me.TStatus.ReadOnly = True
        Me.TStatus.Width = 73
        '
        'TSectionID
        '
        Me.TSectionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TSectionID.HeaderText = "Section ID"
        Me.TSectionID.MinimumWidth = 6
        Me.TSectionID.Name = "TSectionID"
        Me.TSectionID.ReadOnly = True
        Me.TSectionID.Width = 90
        '
        'btnTeaUpdate
        '
        Me.btnTeaUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTeaUpdate.Location = New System.Drawing.Point(1426, 693)
        Me.btnTeaUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTeaUpdate.Name = "btnTeaUpdate"
        Me.btnTeaUpdate.Size = New System.Drawing.Size(115, 43)
        Me.btnTeaUpdate.TabIndex = 26
        Me.btnTeaUpdate.Text = "Update"
        Me.btnTeaUpdate.UseVisualStyleBackColor = True
        '
        'btnTeaAdd
        '
        Me.btnTeaAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTeaAdd.Location = New System.Drawing.Point(1277, 693)
        Me.btnTeaAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTeaAdd.Name = "btnTeaAdd"
        Me.btnTeaAdd.Size = New System.Drawing.Size(115, 43)
        Me.btnTeaAdd.TabIndex = 25
        Me.btnTeaAdd.Text = "Add"
        Me.btnTeaAdd.UseVisualStyleBackColor = True
        '
        'TextBoxProvince
        '
        Me.TextBoxProvince.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxProvince.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxProvince.Controls.Add(Me.Label1)
        Me.TextBoxProvince.Controls.Add(Me.DateTimePicker1)
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
        Me.TextBoxProvince.Controls.Add(Me.TeacherGender)
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
        Me.TextBoxProvince.Location = New System.Drawing.Point(64, 89)
        Me.TextBoxProvince.Name = "TextBoxProvince"
        Me.TextBoxProvince.Padding = New System.Windows.Forms.Padding(3)
        Me.TextBoxProvince.Size = New System.Drawing.Size(1627, 384)
        Me.TextBoxProvince.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1001, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 47
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(411, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(241, 26)
        Me.DateTimePicker1.TabIndex = 46
        '
        'ComboBoxTeacherStatus
        '
        Me.ComboBoxTeacherStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTeacherStatus.FormattingEnabled = True
        Me.ComboBoxTeacherStatus.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxTeacherStatus.Location = New System.Drawing.Point(1013, 94)
        Me.ComboBoxTeacherStatus.Name = "ComboBoxTeacherStatus"
        Me.ComboBoxTeacherStatus.Size = New System.Drawing.Size(110, 28)
        Me.ComboBoxTeacherStatus.TabIndex = 43
        '
        'ManageTeacherHireDate
        '
        Me.ManageTeacherHireDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageTeacherHireDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageTeacherHireDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ManageTeacherHireDate.Location = New System.Drawing.Point(713, 160)
        Me.ManageTeacherHireDate.Name = "ManageTeacherHireDate"
        Me.ManageTeacherHireDate.Size = New System.Drawing.Size(91, 26)
        Me.ManageTeacherHireDate.TabIndex = 42
        '
        'txtbxTeacherZipCode
        '
        Me.txtbxTeacherZipCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherZipCode.Location = New System.Drawing.Point(700, 304)
        Me.txtbxTeacherZipCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxTeacherZipCode.Name = "txtbxTeacherZipCode"
        Me.txtbxTeacherZipCode.Size = New System.Drawing.Size(239, 26)
        Me.txtbxTeacherZipCode.TabIndex = 41
        '
        'lblTeacherZIP
        '
        Me.lblTeacherZIP.AutoSize = True
        Me.lblTeacherZIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherZIP.Location = New System.Drawing.Point(696, 277)
        Me.lblTeacherZIP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacherZIP.Name = "lblTeacherZIP"
        Me.lblTeacherZIP.Size = New System.Drawing.Size(75, 20)
        Me.lblTeacherZIP.TabIndex = 40
        Me.lblTeacherZIP.Text = "Zip Code"
        '
        'txtbxTeacherProvince
        '
        Me.txtbxTeacherProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherProvince.Location = New System.Drawing.Point(410, 304)
        Me.txtbxTeacherProvince.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxTeacherProvince.MaxLength = 50
        Me.txtbxTeacherProvince.Name = "txtbxTeacherProvince"
        Me.txtbxTeacherProvince.Size = New System.Drawing.Size(231, 26)
        Me.txtbxTeacherProvince.TabIndex = 39
        '
        'lblTeacherProvince
        '
        Me.lblTeacherProvince.AutoSize = True
        Me.lblTeacherProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherProvince.Location = New System.Drawing.Point(406, 277)
        Me.lblTeacherProvince.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacherProvince.Name = "lblTeacherProvince"
        Me.lblTeacherProvince.Size = New System.Drawing.Size(74, 20)
        Me.lblTeacherProvince.TabIndex = 38
        Me.lblTeacherProvince.Text = "Province"
        '
        'TeacherEmail
        '
        Me.TeacherEmail.AutoSize = True
        Me.TeacherEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherEmail.Location = New System.Drawing.Point(696, 19)
        Me.TeacherEmail.Name = "TeacherEmail"
        Me.TeacherEmail.Size = New System.Drawing.Size(51, 20)
        Me.TeacherEmail.TabIndex = 8
        Me.TeacherEmail.Text = "Email"
        '
        'txtbxTeacherBarangay
        '
        Me.txtbxTeacherBarangay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherBarangay.Location = New System.Drawing.Point(84, 303)
        Me.txtbxTeacherBarangay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxTeacherBarangay.MaxLength = 20
        Me.txtbxTeacherBarangay.Name = "txtbxTeacherBarangay"
        Me.txtbxTeacherBarangay.Size = New System.Drawing.Size(255, 26)
        Me.txtbxTeacherBarangay.TabIndex = 37
        '
        'TextBoxTeacherEmail
        '
        Me.TextBoxTeacherEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherEmail.Location = New System.Drawing.Point(709, 44)
        Me.TextBoxTeacherEmail.MaxLength = 50
        Me.TextBoxTeacherEmail.Name = "TextBoxTeacherEmail"
        Me.TextBoxTeacherEmail.Size = New System.Drawing.Size(233, 26)
        Me.TextBoxTeacherEmail.TabIndex = 9
        '
        'lblTeacherBarangay
        '
        Me.lblTeacherBarangay.AutoSize = True
        Me.lblTeacherBarangay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherBarangay.Location = New System.Drawing.Point(80, 277)
        Me.lblTeacherBarangay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacherBarangay.Name = "lblTeacherBarangay"
        Me.lblTeacherBarangay.Size = New System.Drawing.Size(80, 20)
        Me.lblTeacherBarangay.TabIndex = 36
        Me.lblTeacherBarangay.Text = "Barangay"
        '
        'TeacherContactNo
        '
        Me.TeacherContactNo.AutoSize = True
        Me.TeacherContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherContactNo.Location = New System.Drawing.Point(355, 132)
        Me.TeacherContactNo.Name = "TeacherContactNo"
        Me.TeacherContactNo.Size = New System.Drawing.Size(97, 20)
        Me.TeacherContactNo.TabIndex = 10
        Me.TeacherContactNo.Text = "Contact No."
        '
        'txtbxTeacherCountry
        '
        Me.txtbxTeacherCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherCountry.Location = New System.Drawing.Point(707, 247)
        Me.txtbxTeacherCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxTeacherCountry.MaxLength = 20
        Me.txtbxTeacherCountry.Name = "txtbxTeacherCountry"
        Me.txtbxTeacherCountry.Size = New System.Drawing.Size(237, 26)
        Me.txtbxTeacherCountry.TabIndex = 35
        '
        'TextBoxTeacherContactNo
        '
        Me.TextBoxTeacherContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherContactNo.Location = New System.Drawing.Point(410, 156)
        Me.TextBoxTeacherContactNo.MaxLength = 15
        Me.TextBoxTeacherContactNo.Name = "TextBoxTeacherContactNo"
        Me.TextBoxTeacherContactNo.Size = New System.Drawing.Size(233, 26)
        Me.TextBoxTeacherContactNo.TabIndex = 11
        '
        'lblTeacherCountry
        '
        Me.lblTeacherCountry.AutoSize = True
        Me.lblTeacherCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherCountry.Location = New System.Drawing.Point(696, 221)
        Me.lblTeacherCountry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacherCountry.Name = "lblTeacherCountry"
        Me.lblTeacherCountry.Size = New System.Drawing.Size(67, 20)
        Me.lblTeacherCountry.TabIndex = 34
        Me.lblTeacherCountry.Text = "Country"
        '
        'txtbxTeacherCity
        '
        Me.txtbxTeacherCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherCity.Location = New System.Drawing.Point(411, 247)
        Me.txtbxTeacherCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxTeacherCity.MaxLength = 50
        Me.txtbxTeacherCity.Name = "txtbxTeacherCity"
        Me.txtbxTeacherCity.Size = New System.Drawing.Size(230, 26)
        Me.txtbxTeacherCity.TabIndex = 33
        '
        'lblTeacherCity
        '
        Me.lblTeacherCity.AutoSize = True
        Me.lblTeacherCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherCity.Location = New System.Drawing.Point(407, 221)
        Me.lblTeacherCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacherCity.Name = "lblTeacherCity"
        Me.lblTeacherCity.Size = New System.Drawing.Size(141, 20)
        Me.lblTeacherCity.TabIndex = 32
        Me.lblTeacherCity.Text = "City / Municipality"
        '
        'txtbxTeacherHouseNo
        '
        Me.txtbxTeacherHouseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTeacherHouseNo.Location = New System.Drawing.Point(84, 247)
        Me.txtbxTeacherHouseNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxTeacherHouseNo.Name = "txtbxTeacherHouseNo"
        Me.txtbxTeacherHouseNo.Size = New System.Drawing.Size(249, 26)
        Me.txtbxTeacherHouseNo.TabIndex = 29
        '
        'lbTeacherHouseNumber
        '
        Me.lbTeacherHouseNumber.AutoSize = True
        Me.lbTeacherHouseNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTeacherHouseNumber.Location = New System.Drawing.Point(80, 222)
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
        Me.Label15.Location = New System.Drawing.Point(5, 203)
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
        Me.ComboBoxTeacherGender.Location = New System.Drawing.Point(410, 47)
        Me.ComboBoxTeacherGender.Name = "ComboBoxTeacherGender"
        Me.ComboBoxTeacherGender.Size = New System.Drawing.Size(110, 28)
        Me.ComboBoxTeacherGender.TabIndex = 25
        '
        'TeacherGender
        '
        Me.TeacherGender.AutoSize = True
        Me.TeacherGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherGender.Location = New System.Drawing.Point(393, 25)
        Me.TeacherGender.Name = "TeacherGender"
        Me.TeacherGender.Size = New System.Drawing.Size(64, 20)
        Me.TeacherGender.TabIndex = 24
        Me.TeacherGender.Text = "Gender"
        '
        'TeacherBirthDate
        '
        Me.TeacherBirthDate.AutoSize = True
        Me.TeacherBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherBirthDate.Location = New System.Drawing.Point(368, 80)
        Me.TeacherBirthDate.Name = "TeacherBirthDate"
        Me.TeacherBirthDate.Size = New System.Drawing.Size(86, 20)
        Me.TeacherBirthDate.TabIndex = 22
        Me.TeacherBirthDate.Text = "Birth Date"
        '
        'TeacherStatus
        '
        Me.TeacherStatus.AutoSize = True
        Me.TeacherStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherStatus.Location = New System.Drawing.Point(990, 74)
        Me.TeacherStatus.Name = "TeacherStatus"
        Me.TeacherStatus.Size = New System.Drawing.Size(57, 20)
        Me.TeacherStatus.TabIndex = 20
        Me.TeacherStatus.Text = "Status"
        '
        'TeacherHireDate
        '
        Me.TeacherHireDate.AutoSize = True
        Me.TeacherHireDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherHireDate.Location = New System.Drawing.Point(676, 134)
        Me.TeacherHireDate.Name = "TeacherHireDate"
        Me.TeacherHireDate.Size = New System.Drawing.Size(82, 20)
        Me.TeacherHireDate.TabIndex = 16
        Me.TeacherHireDate.Text = "Hire Date"
        '
        'TextBoxTeacherSpecialization
        '
        Me.TextBoxTeacherSpecialization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherSpecialization.Location = New System.Drawing.Point(1013, 44)
        Me.TextBoxTeacherSpecialization.MaxLength = 100
        Me.TextBoxTeacherSpecialization.Name = "TextBoxTeacherSpecialization"
        Me.TextBoxTeacherSpecialization.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxTeacherSpecialization.TabIndex = 15
        '
        'TeacherSpecialization
        '
        Me.TeacherSpecialization.AutoSize = True
        Me.TeacherSpecialization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherSpecialization.Location = New System.Drawing.Point(962, 19)
        Me.TeacherSpecialization.Name = "TeacherSpecialization"
        Me.TeacherSpecialization.Size = New System.Drawing.Size(113, 20)
        Me.TeacherSpecialization.TabIndex = 14
        Me.TeacherSpecialization.Text = "Specialization"
        '
        'TextBoxTeacherEducationalAttainment
        '
        Me.TextBoxTeacherEducationalAttainment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherEducationalAttainment.Location = New System.Drawing.Point(713, 98)
        Me.TextBoxTeacherEducationalAttainment.MaxLength = 100
        Me.TextBoxTeacherEducationalAttainment.Name = "TextBoxTeacherEducationalAttainment"
        Me.TextBoxTeacherEducationalAttainment.Size = New System.Drawing.Size(229, 26)
        Me.TextBoxTeacherEducationalAttainment.TabIndex = 13
        '
        'TeacherEducationalAttainment
        '
        Me.TeacherEducationalAttainment.AutoSize = True
        Me.TeacherEducationalAttainment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherEducationalAttainment.Location = New System.Drawing.Point(655, 75)
        Me.TeacherEducationalAttainment.Name = "TeacherEducationalAttainment"
        Me.TeacherEducationalAttainment.Size = New System.Drawing.Size(181, 20)
        Me.TeacherEducationalAttainment.TabIndex = 12
        Me.TeacherEducationalAttainment.Text = "Educational Attainment"
        '
        'TextBoxTeacherSurname
        '
        Me.TextBoxTeacherSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherSurname.Location = New System.Drawing.Point(92, 156)
        Me.TextBoxTeacherSurname.MaxLength = 50
        Me.TextBoxTeacherSurname.Name = "TextBoxTeacherSurname"
        Me.TextBoxTeacherSurname.Size = New System.Drawing.Size(241, 26)
        Me.TextBoxTeacherSurname.TabIndex = 5
        '
        'TeacherSurname
        '
        Me.TeacherSurname.AutoSize = True
        Me.TeacherSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherSurname.Location = New System.Drawing.Point(65, 132)
        Me.TeacherSurname.Name = "TeacherSurname"
        Me.TeacherSurname.Size = New System.Drawing.Size(76, 20)
        Me.TeacherSurname.TabIndex = 4
        Me.TeacherSurname.Text = "Surname"
        '
        'TextBoxTeacherMiddleName
        '
        Me.TextBoxTeacherMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherMiddleName.Location = New System.Drawing.Point(94, 103)
        Me.TextBoxTeacherMiddleName.MaxLength = 50
        Me.TextBoxTeacherMiddleName.Name = "TextBoxTeacherMiddleName"
        Me.TextBoxTeacherMiddleName.Size = New System.Drawing.Size(239, 26)
        Me.TextBoxTeacherMiddleName.TabIndex = 3
        '
        'TeacherMiddleName
        '
        Me.TeacherMiddleName.AutoSize = True
        Me.TeacherMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherMiddleName.Location = New System.Drawing.Point(34, 77)
        Me.TeacherMiddleName.Name = "TeacherMiddleName"
        Me.TeacherMiddleName.Size = New System.Drawing.Size(107, 20)
        Me.TeacherMiddleName.TabIndex = 2
        Me.TeacherMiddleName.Text = "Middle Name"
        '
        'TextBoxTeacherFirstName
        '
        Me.TextBoxTeacherFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTeacherFirstName.Location = New System.Drawing.Point(94, 47)
        Me.TextBoxTeacherFirstName.MaxLength = 50
        Me.TextBoxTeacherFirstName.Name = "TextBoxTeacherFirstName"
        Me.TextBoxTeacherFirstName.Size = New System.Drawing.Size(239, 26)
        Me.TextBoxTeacherFirstName.TabIndex = 1
        '
        'TeacherFirstName
        '
        Me.TeacherFirstName.AutoSize = True
        Me.TeacherFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherFirstName.Location = New System.Drawing.Point(48, 27)
        Me.TeacherFirstName.Name = "TeacherFirstName"
        Me.TeacherFirstName.Size = New System.Drawing.Size(92, 20)
        Me.TeacherFirstName.TabIndex = 0
        Me.TeacherFirstName.Text = "FIrst Name"
        '
        'btnTeaSearch
        '
        Me.btnTeaSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTeaSearch.Location = New System.Drawing.Point(1125, 695)
        Me.btnTeaSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTeaSearch.Name = "btnTeaSearch"
        Me.btnTeaSearch.Size = New System.Drawing.Size(117, 43)
        Me.btnTeaSearch.TabIndex = 24
        Me.btnTeaSearch.Text = "Search"
        Me.btnTeaSearch.UseVisualStyleBackColor = True
        '
        'picWatermark
        '
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(487, 139)
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
    Friend WithEvents TeacherGender As Label
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
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TeacherID As DataGridViewTextBoxColumn
    Friend WithEvents TFirstName As DataGridViewTextBoxColumn
    Friend WithEvents TMiddleName As DataGridViewTextBoxColumn
    Friend WithEvents TLastName As DataGridViewTextBoxColumn
    Friend WithEvents TGender As DataGridViewTextBoxColumn
    Friend WithEvents TBirthDate As DataGridViewTextBoxColumn
    Friend WithEvents TContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents TEmail As DataGridViewTextBoxColumn
    Friend WithEvents THouseNumber As DataGridViewTextBoxColumn
    Friend WithEvents TBarangay As DataGridViewTextBoxColumn
    Friend WithEvents TMunicipality As DataGridViewTextBoxColumn
    Friend WithEvents TProvince As DataGridViewTextBoxColumn
    Friend WithEvents TCountry As DataGridViewTextBoxColumn
    Friend WithEvents TZipcode As DataGridViewTextBoxColumn
    Friend WithEvents TEducationalAttainment As DataGridViewTextBoxColumn
    Friend WithEvents TSpecialization As DataGridViewTextBoxColumn
    Friend WithEvents THireDate As DataGridViewTextBoxColumn
    Friend WithEvents TStatus As DataGridViewTextBoxColumn
    Friend WithEvents TSectionID As DataGridViewTextBoxColumn
End Class
