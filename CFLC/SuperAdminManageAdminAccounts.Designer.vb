<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuperAdminManageAdminAccounts
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
        Me.pnlSuperAdminMainContent = New System.Windows.Forms.Panel()
        Me.pnlTeacherSidebar = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSuperAdminManageAdmin = New System.Windows.Forms.Button()
        Me.btnSuperAdminManageTea = New System.Windows.Forms.Button()
        Me.btnSuperAdminManageSysCon = New System.Windows.Forms.Button()
        Me.btnSuperAdminGenerateReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpAdminAccounts = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxTeacherPassword = New System.Windows.Forms.TextBox()
        Me.lblStudentMiddleName = New System.Windows.Forms.Label()
        Me.txtbxTeacherUserID = New System.Windows.Forms.TextBox()
        Me.lblStudentFirstName = New System.Windows.Forms.Label()
        Me.ComboBoxAdminAccountsUserType = New System.Windows.Forms.ComboBox()
        Me.txtbxManAdminSearch = New System.Windows.Forms.TextBox()
        Me.btnManAdDelete = New System.Windows.Forms.Button()
        Me.btnManAdUpdate = New System.Windows.Forms.Button()
        Me.btnManAdAdd = New System.Windows.Forms.Button()
        Me.dgvLoginAdmin = New System.Windows.Forms.DataGridView()
        Me.pnlSuperAdminMainContent.SuspendLayout()
        Me.pnlTeacherSidebar.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAdminAccounts.SuspendLayout()
        CType(Me.dgvLoginAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSuperAdminMainContent
        '
        Me.pnlSuperAdminMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlSuperAdminMainContent.Controls.Add(Me.dgvLoginAdmin)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.txtbxManAdminSearch)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.btnManAdDelete)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.btnManAdUpdate)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.btnManAdAdd)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.grpAdminAccounts)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.pnlTeacherSidebar)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.PictureBox1)
        Me.pnlSuperAdminMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSuperAdminMainContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperAdminMainContent.Name = "pnlSuperAdminMainContent"
        Me.pnlSuperAdminMainContent.Size = New System.Drawing.Size(1300, 633)
        Me.pnlSuperAdminMainContent.TabIndex = 15
        '
        'pnlTeacherSidebar
        '
        Me.pnlTeacherSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlTeacherSidebar.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnlTeacherSidebar.Controls.Add(Me.btnLogout)
        Me.pnlTeacherSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTeacherSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTeacherSidebar.Name = "pnlTeacherSidebar"
        Me.pnlTeacherSidebar.Padding = New System.Windows.Forms.Padding(30, 40, 30, 40)
        Me.pnlTeacherSidebar.Size = New System.Drawing.Size(300, 633)
        Me.pnlTeacherSidebar.TabIndex = 12
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSuperAdminManageAdmin)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSuperAdminManageTea)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSuperAdminManageSysCon)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSuperAdminGenerateReports)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(30, 40)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(240, 503)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'btnSuperAdminManageAdmin
        '
        Me.btnSuperAdminManageAdmin.Location = New System.Drawing.Point(0, 0)
        Me.btnSuperAdminManageAdmin.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnSuperAdminManageAdmin.Name = "btnSuperAdminManageAdmin"
        Me.btnSuperAdminManageAdmin.Size = New System.Drawing.Size(240, 45)
        Me.btnSuperAdminManageAdmin.TabIndex = 11
        Me.btnSuperAdminManageAdmin.Text = "Manage Admin Accounts"
        Me.btnSuperAdminManageAdmin.UseVisualStyleBackColor = True
        '
        'btnSuperAdminManageTea
        '
        Me.btnSuperAdminManageTea.Location = New System.Drawing.Point(0, 63)
        Me.btnSuperAdminManageTea.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnSuperAdminManageTea.Name = "btnSuperAdminManageTea"
        Me.btnSuperAdminManageTea.Size = New System.Drawing.Size(240, 45)
        Me.btnSuperAdminManageTea.TabIndex = 4
        Me.btnSuperAdminManageTea.Text = "Manage Teacher Accounts"
        Me.btnSuperAdminManageTea.UseVisualStyleBackColor = True
        '
        'btnSuperAdminManageSysCon
        '
        Me.btnSuperAdminManageSysCon.Location = New System.Drawing.Point(0, 126)
        Me.btnSuperAdminManageSysCon.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnSuperAdminManageSysCon.Name = "btnSuperAdminManageSysCon"
        Me.btnSuperAdminManageSysCon.Size = New System.Drawing.Size(240, 45)
        Me.btnSuperAdminManageSysCon.TabIndex = 5
        Me.btnSuperAdminManageSysCon.Text = "Manage System Configuration"
        Me.btnSuperAdminManageSysCon.UseVisualStyleBackColor = True
        '
        'btnSuperAdminGenerateReports
        '
        Me.btnSuperAdminGenerateReports.Location = New System.Drawing.Point(0, 189)
        Me.btnSuperAdminGenerateReports.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnSuperAdminGenerateReports.Name = "btnSuperAdminGenerateReports"
        Me.btnSuperAdminGenerateReports.Size = New System.Drawing.Size(240, 45)
        Me.btnSuperAdminGenerateReports.TabIndex = 9
        Me.btnSuperAdminGenerateReports.Text = "Generate Reports"
        Me.btnSuperAdminGenerateReports.UseVisualStyleBackColor = True
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
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.CFLC.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(621, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 330)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'grpAdminAccounts
        '
        Me.grpAdminAccounts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAdminAccounts.BackColor = System.Drawing.Color.Gainsboro
        Me.grpAdminAccounts.Controls.Add(Me.ComboBoxAdminAccountsUserType)
        Me.grpAdminAccounts.Controls.Add(Me.Label1)
        Me.grpAdminAccounts.Controls.Add(Me.txtbxTeacherPassword)
        Me.grpAdminAccounts.Controls.Add(Me.lblStudentMiddleName)
        Me.grpAdminAccounts.Controls.Add(Me.txtbxTeacherUserID)
        Me.grpAdminAccounts.Controls.Add(Me.lblStudentFirstName)
        Me.grpAdminAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAdminAccounts.Location = New System.Drawing.Point(317, 40)
        Me.grpAdminAccounts.Name = "grpAdminAccounts"
        Me.grpAdminAccounts.Size = New System.Drawing.Size(944, 108)
        Me.grpAdminAccounts.TabIndex = 14
        Me.grpAdminAccounts.TabStop = False
        Me.grpAdminAccounts.Text = "Admin Accounts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(500, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "User Type "
        '
        'txtbxTeacherPassword
        '
        Me.txtbxTeacherPassword.Location = New System.Drawing.Point(271, 49)
        Me.txtbxTeacherPassword.MaxLength = 50
        Me.txtbxTeacherPassword.Name = "txtbxTeacherPassword"
        Me.txtbxTeacherPassword.Size = New System.Drawing.Size(190, 23)
        Me.txtbxTeacherPassword.TabIndex = 4
        '
        'lblStudentMiddleName
        '
        Me.lblStudentMiddleName.AutoSize = True
        Me.lblStudentMiddleName.Location = New System.Drawing.Point(268, 29)
        Me.lblStudentMiddleName.Name = "lblStudentMiddleName"
        Me.lblStudentMiddleName.Size = New System.Drawing.Size(69, 17)
        Me.lblStudentMiddleName.TabIndex = 3
        Me.lblStudentMiddleName.Text = "Password"
        '
        'txtbxTeacherUserID
        '
        Me.txtbxTeacherUserID.Location = New System.Drawing.Point(39, 49)
        Me.txtbxTeacherUserID.MaxLength = 50
        Me.txtbxTeacherUserID.Name = "txtbxTeacherUserID"
        Me.txtbxTeacherUserID.Size = New System.Drawing.Size(190, 23)
        Me.txtbxTeacherUserID.TabIndex = 2
        '
        'lblStudentFirstName
        '
        Me.lblStudentFirstName.AutoSize = True
        Me.lblStudentFirstName.Location = New System.Drawing.Point(36, 31)
        Me.lblStudentFirstName.Name = "lblStudentFirstName"
        Me.lblStudentFirstName.Size = New System.Drawing.Size(55, 17)
        Me.lblStudentFirstName.TabIndex = 1
        Me.lblStudentFirstName.Text = "User ID"
        '
        'ComboBoxAdminAccountsUserType
        '
        Me.ComboBoxAdminAccountsUserType.FormattingEnabled = True
        Me.ComboBoxAdminAccountsUserType.Location = New System.Drawing.Point(503, 49)
        Me.ComboBoxAdminAccountsUserType.Name = "ComboBoxAdminAccountsUserType"
        Me.ComboBoxAdminAccountsUserType.Size = New System.Drawing.Size(141, 24)
        Me.ComboBoxAdminAccountsUserType.TabIndex = 6
        '
        'txtbxManAdminSearch
        '
        Me.txtbxManAdminSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbxManAdminSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxManAdminSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxManAdminSearch.Location = New System.Drawing.Point(317, 166)
        Me.txtbxManAdminSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbxManAdminSearch.MaxLength = 50
        Me.txtbxManAdminSearch.Name = "txtbxManAdminSearch"
        Me.txtbxManAdminSearch.Size = New System.Drawing.Size(186, 30)
        Me.txtbxManAdminSearch.TabIndex = 23
        '
        'btnManAdDelete
        '
        Me.btnManAdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManAdDelete.Location = New System.Drawing.Point(1175, 161)
        Me.btnManAdDelete.Name = "btnManAdDelete"
        Me.btnManAdDelete.Size = New System.Drawing.Size(86, 35)
        Me.btnManAdDelete.TabIndex = 22
        Me.btnManAdDelete.Text = "Delete"
        Me.btnManAdDelete.UseVisualStyleBackColor = True
        '
        'btnManAdUpdate
        '
        Me.btnManAdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManAdUpdate.Location = New System.Drawing.Point(1063, 161)
        Me.btnManAdUpdate.Name = "btnManAdUpdate"
        Me.btnManAdUpdate.Size = New System.Drawing.Size(86, 35)
        Me.btnManAdUpdate.TabIndex = 21
        Me.btnManAdUpdate.Text = "Update"
        Me.btnManAdUpdate.UseVisualStyleBackColor = True
        '
        'btnManAdAdd
        '
        Me.btnManAdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManAdAdd.Location = New System.Drawing.Point(950, 161)
        Me.btnManAdAdd.Name = "btnManAdAdd"
        Me.btnManAdAdd.Size = New System.Drawing.Size(86, 35)
        Me.btnManAdAdd.TabIndex = 20
        Me.btnManAdAdd.Text = "Add"
        Me.btnManAdAdd.UseVisualStyleBackColor = True
        '
        'dgvLoginAdmin
        '
        Me.dgvLoginAdmin.AllowUserToAddRows = False
        Me.dgvLoginAdmin.AllowUserToDeleteRows = False
        Me.dgvLoginAdmin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLoginAdmin.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvLoginAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoginAdmin.Location = New System.Drawing.Point(317, 217)
        Me.dgvLoginAdmin.Name = "dgvLoginAdmin"
        Me.dgvLoginAdmin.ReadOnly = True
        Me.dgvLoginAdmin.RowHeadersVisible = False
        Me.dgvLoginAdmin.RowHeadersWidth = 51
        Me.dgvLoginAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLoginAdmin.Size = New System.Drawing.Size(944, 376)
        Me.dgvLoginAdmin.TabIndex = 24
        '
        'SuperAdminManageAdminAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 633)
        Me.Controls.Add(Me.pnlSuperAdminMainContent)
        Me.Name = "SuperAdminManageAdminAccounts"
        Me.Text = "SuperAdminManageAdminAccounts"
        Me.pnlSuperAdminMainContent.ResumeLayout(False)
        Me.pnlSuperAdminMainContent.PerformLayout()
        Me.pnlTeacherSidebar.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAdminAccounts.ResumeLayout(False)
        Me.grpAdminAccounts.PerformLayout()
        CType(Me.dgvLoginAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSuperAdminMainContent As Panel
    Friend WithEvents pnlTeacherSidebar As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnSuperAdminManageAdmin As Button
    Friend WithEvents btnSuperAdminManageTea As Button
    Friend WithEvents btnSuperAdminManageSysCon As Button
    Friend WithEvents btnSuperAdminGenerateReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpAdminAccounts As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxTeacherPassword As TextBox
    Friend WithEvents lblStudentMiddleName As Label
    Friend WithEvents txtbxTeacherUserID As TextBox
    Friend WithEvents lblStudentFirstName As Label
    Friend WithEvents ComboBoxAdminAccountsUserType As ComboBox
    Friend WithEvents txtbxManAdminSearch As TextBox
    Friend WithEvents btnManAdDelete As Button
    Friend WithEvents btnManAdUpdate As Button
    Friend WithEvents btnManAdAdd As Button
    Friend WithEvents dgvLoginAdmin As DataGridView
End Class
