<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuperAdminManageTeacherAccounts
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
        Me.txtbxManTeaSearch = New System.Windows.Forms.TextBox()
        Me.btnManTeaDelete = New System.Windows.Forms.Button()
        Me.btnManTeaUpdate = New System.Windows.Forms.Button()
        Me.btnManTeacherAdd = New System.Windows.Forms.Button()
        Me.dgvTeacher = New System.Windows.Forms.DataGridView()
        Me.dgvLoginTeacher = New System.Windows.Forms.DataGridView()
        Me.grpTeacherAccounts = New System.Windows.Forms.GroupBox()
        Me.txtbxTeaAccountTeacherID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxTeacherUserType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxTeacherPassword = New System.Windows.Forms.TextBox()
        Me.lblStudentMiddleName = New System.Windows.Forms.Label()
        Me.txtbxTeacherUserID = New System.Windows.Forms.TextBox()
        Me.lblStudentFirstName = New System.Windows.Forms.Label()
        Me.pnlTeacherSidebar = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSuperAdminManageAdmin = New System.Windows.Forms.Button()
        Me.btnSuperAdminManageTea = New System.Windows.Forms.Button()
        Me.btnSuperAdminManageSysCon = New System.Windows.Forms.Button()
        Me.btnSuperAdminGenerateReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlSuperAdminMainContent.SuspendLayout()
        CType(Me.dgvTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLoginTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTeacherAccounts.SuspendLayout()
        Me.pnlTeacherSidebar.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSuperAdminMainContent
        '
        Me.pnlSuperAdminMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlSuperAdminMainContent.Controls.Add(Me.txtbxManTeaSearch)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.btnManTeaDelete)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.btnManTeaUpdate)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.btnManTeacherAdd)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.dgvTeacher)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.dgvLoginTeacher)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.grpTeacherAccounts)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.pnlTeacherSidebar)
        Me.pnlSuperAdminMainContent.Controls.Add(Me.PictureBox1)
        Me.pnlSuperAdminMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSuperAdminMainContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperAdminMainContent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlSuperAdminMainContent.Name = "pnlSuperAdminMainContent"
        Me.pnlSuperAdminMainContent.Size = New System.Drawing.Size(1712, 731)
        Me.pnlSuperAdminMainContent.TabIndex = 15
        '
        'txtbxManTeaSearch
        '
        Me.txtbxManTeaSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbxManTeaSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxManTeaSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxManTeaSearch.Location = New System.Drawing.Point(423, 188)
        Me.txtbxManTeaSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbxManTeaSearch.MaxLength = 50
        Me.txtbxManTeaSearch.Name = "txtbxManTeaSearch"
        Me.txtbxManTeaSearch.Size = New System.Drawing.Size(247, 36)
        Me.txtbxManTeaSearch.TabIndex = 19
        '
        'btnManTeaDelete
        '
        Me.btnManTeaDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManTeaDelete.Location = New System.Drawing.Point(1567, 182)
        Me.btnManTeaDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnManTeaDelete.Name = "btnManTeaDelete"
        Me.btnManTeaDelete.Size = New System.Drawing.Size(115, 43)
        Me.btnManTeaDelete.TabIndex = 18
        Me.btnManTeaDelete.Text = "Delete"
        Me.btnManTeaDelete.UseVisualStyleBackColor = True
        '
        'btnManTeaUpdate
        '
        Me.btnManTeaUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManTeaUpdate.Location = New System.Drawing.Point(1417, 182)
        Me.btnManTeaUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnManTeaUpdate.Name = "btnManTeaUpdate"
        Me.btnManTeaUpdate.Size = New System.Drawing.Size(115, 43)
        Me.btnManTeaUpdate.TabIndex = 17
        Me.btnManTeaUpdate.Text = "Update"
        Me.btnManTeaUpdate.UseVisualStyleBackColor = True
        '
        'btnManTeacherAdd
        '
        Me.btnManTeacherAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManTeacherAdd.Location = New System.Drawing.Point(1267, 182)
        Me.btnManTeacherAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnManTeacherAdd.Name = "btnManTeacherAdd"
        Me.btnManTeacherAdd.Size = New System.Drawing.Size(115, 43)
        Me.btnManTeacherAdd.TabIndex = 16
        Me.btnManTeacherAdd.Text = "Add"
        Me.btnManTeacherAdd.UseVisualStyleBackColor = True
        '
        'dgvTeacher
        '
        Me.dgvTeacher.AllowUserToAddRows = False
        Me.dgvTeacher.AllowUserToDeleteRows = False
        Me.dgvTeacher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTeacher.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeacher.Location = New System.Drawing.Point(1093, 249)
        Me.dgvTeacher.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvTeacher.Name = "dgvTeacher"
        Me.dgvTeacher.ReadOnly = True
        Me.dgvTeacher.RowHeadersVisible = False
        Me.dgvTeacher.RowHeadersWidth = 51
        Me.dgvTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTeacher.Size = New System.Drawing.Size(588, 433)
        Me.dgvTeacher.TabIndex = 15
        '
        'dgvLoginTeacher
        '
        Me.dgvLoginTeacher.AllowUserToAddRows = False
        Me.dgvLoginTeacher.AllowUserToDeleteRows = False
        Me.dgvLoginTeacher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLoginTeacher.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvLoginTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoginTeacher.Location = New System.Drawing.Point(423, 249)
        Me.dgvLoginTeacher.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvLoginTeacher.Name = "dgvLoginTeacher"
        Me.dgvLoginTeacher.ReadOnly = True
        Me.dgvLoginTeacher.RowHeadersVisible = False
        Me.dgvLoginTeacher.RowHeadersWidth = 51
        Me.dgvLoginTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLoginTeacher.Size = New System.Drawing.Size(615, 433)
        Me.dgvLoginTeacher.TabIndex = 14
        '
        'grpTeacherAccounts
        '
        Me.grpTeacherAccounts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTeacherAccounts.BackColor = System.Drawing.Color.Gainsboro
        Me.grpTeacherAccounts.Controls.Add(Me.txtbxTeaAccountTeacherID)
        Me.grpTeacherAccounts.Controls.Add(Me.Label2)
        Me.grpTeacherAccounts.Controls.Add(Me.txtbxTeacherUserType)
        Me.grpTeacherAccounts.Controls.Add(Me.Label1)
        Me.grpTeacherAccounts.Controls.Add(Me.txtbxTeacherPassword)
        Me.grpTeacherAccounts.Controls.Add(Me.lblStudentMiddleName)
        Me.grpTeacherAccounts.Controls.Add(Me.txtbxTeacherUserID)
        Me.grpTeacherAccounts.Controls.Add(Me.lblStudentFirstName)
        Me.grpTeacherAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTeacherAccounts.Location = New System.Drawing.Point(423, 28)
        Me.grpTeacherAccounts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTeacherAccounts.Name = "grpTeacherAccounts"
        Me.grpTeacherAccounts.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTeacherAccounts.Size = New System.Drawing.Size(1259, 133)
        Me.grpTeacherAccounts.TabIndex = 13
        Me.grpTeacherAccounts.TabStop = False
        Me.grpTeacherAccounts.Text = "Teacher Accounts"
        '
        'txtbxTeaAccountTeacherID
        '
        Me.txtbxTeaAccountTeacherID.Location = New System.Drawing.Point(972, 60)
        Me.txtbxTeaAccountTeacherID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxTeaAccountTeacherID.MaxLength = 50
        Me.txtbxTeaAccountTeacherID.Name = "txtbxTeaAccountTeacherID"
        Me.txtbxTeaAccountTeacherID.Size = New System.Drawing.Size(252, 26)
        Me.txtbxTeaAccountTeacherID.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(968, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Teacher ID"
        '
        'txtbxTeacherUserType
        '
        Me.txtbxTeacherUserType.Location = New System.Drawing.Point(671, 60)
        Me.txtbxTeacherUserType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxTeacherUserType.MaxLength = 50
        Me.txtbxTeacherUserType.Name = "txtbxTeacherUserType"
        Me.txtbxTeacherUserType.Size = New System.Drawing.Size(252, 26)
        Me.txtbxTeacherUserType.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(667, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "User Type "
        '
        'txtbxTeacherPassword
        '
        Me.txtbxTeacherPassword.Location = New System.Drawing.Point(361, 60)
        Me.txtbxTeacherPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxTeacherPassword.MaxLength = 50
        Me.txtbxTeacherPassword.Name = "txtbxTeacherPassword"
        Me.txtbxTeacherPassword.Size = New System.Drawing.Size(252, 26)
        Me.txtbxTeacherPassword.TabIndex = 4
        '
        'lblStudentMiddleName
        '
        Me.lblStudentMiddleName.AutoSize = True
        Me.lblStudentMiddleName.Location = New System.Drawing.Point(357, 36)
        Me.lblStudentMiddleName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentMiddleName.Name = "lblStudentMiddleName"
        Me.lblStudentMiddleName.Size = New System.Drawing.Size(83, 20)
        Me.lblStudentMiddleName.TabIndex = 3
        Me.lblStudentMiddleName.Text = "Password"
        '
        'txtbxTeacherUserID
        '
        Me.txtbxTeacherUserID.Location = New System.Drawing.Point(52, 60)
        Me.txtbxTeacherUserID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxTeacherUserID.MaxLength = 50
        Me.txtbxTeacherUserID.Name = "txtbxTeacherUserID"
        Me.txtbxTeacherUserID.Size = New System.Drawing.Size(252, 26)
        Me.txtbxTeacherUserID.TabIndex = 2
        '
        'lblStudentFirstName
        '
        Me.lblStudentFirstName.AutoSize = True
        Me.lblStudentFirstName.Location = New System.Drawing.Point(48, 38)
        Me.lblStudentFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentFirstName.Name = "lblStudentFirstName"
        Me.lblStudentFirstName.Size = New System.Drawing.Size(67, 20)
        Me.lblStudentFirstName.TabIndex = 1
        Me.lblStudentFirstName.Text = "User ID"
        '
        'pnlTeacherSidebar
        '
        Me.pnlTeacherSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlTeacherSidebar.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnlTeacherSidebar.Controls.Add(Me.btnLogout)
        Me.pnlTeacherSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTeacherSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTeacherSidebar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTeacherSidebar.Name = "pnlTeacherSidebar"
        Me.pnlTeacherSidebar.Padding = New System.Windows.Forms.Padding(40, 49, 40, 49)
        Me.pnlTeacherSidebar.Size = New System.Drawing.Size(400, 731)
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
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(40, 49)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(320, 571)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'btnSuperAdminManageAdmin
        '
        Me.btnSuperAdminManageAdmin.Location = New System.Drawing.Point(0, 0)
        Me.btnSuperAdminManageAdmin.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnSuperAdminManageAdmin.Name = "btnSuperAdminManageAdmin"
        Me.btnSuperAdminManageAdmin.Size = New System.Drawing.Size(320, 55)
        Me.btnSuperAdminManageAdmin.TabIndex = 11
        Me.btnSuperAdminManageAdmin.Text = "Manage Admin Accounts"
        Me.btnSuperAdminManageAdmin.UseVisualStyleBackColor = True
        '
        'btnSuperAdminManageTea
        '
        Me.btnSuperAdminManageTea.Location = New System.Drawing.Point(0, 77)
        Me.btnSuperAdminManageTea.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnSuperAdminManageTea.Name = "btnSuperAdminManageTea"
        Me.btnSuperAdminManageTea.Size = New System.Drawing.Size(320, 55)
        Me.btnSuperAdminManageTea.TabIndex = 4
        Me.btnSuperAdminManageTea.Text = "Manage Teacher Accounts"
        Me.btnSuperAdminManageTea.UseVisualStyleBackColor = True
        '
        'btnSuperAdminManageSysCon
        '
        Me.btnSuperAdminManageSysCon.Location = New System.Drawing.Point(0, 154)
        Me.btnSuperAdminManageSysCon.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnSuperAdminManageSysCon.Name = "btnSuperAdminManageSysCon"
        Me.btnSuperAdminManageSysCon.Size = New System.Drawing.Size(320, 55)
        Me.btnSuperAdminManageSysCon.TabIndex = 5
        Me.btnSuperAdminManageSysCon.Text = "Manage System Configuration"
        Me.btnSuperAdminManageSysCon.UseVisualStyleBackColor = True
        '
        'btnSuperAdminGenerateReports
        '
        Me.btnSuperAdminGenerateReports.Location = New System.Drawing.Point(0, 231)
        Me.btnSuperAdminGenerateReports.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnSuperAdminGenerateReports.Name = "btnSuperAdminGenerateReports"
        Me.btnSuperAdminGenerateReports.Size = New System.Drawing.Size(320, 55)
        Me.btnSuperAdminGenerateReports.TabIndex = 9
        Me.btnSuperAdminGenerateReports.Text = "Generate Reports"
        Me.btnSuperAdminGenerateReports.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(40, 620)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(320, 62)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.CFLC.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(817, 182)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 406)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'SuperAdminManageTeacherAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1712, 731)
        Me.Controls.Add(Me.pnlSuperAdminMainContent)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SuperAdminManageTeacherAccounts"
        Me.Text = "SuperAdminManageTeacherAccounts"
        Me.pnlSuperAdminMainContent.ResumeLayout(False)
        Me.pnlSuperAdminMainContent.PerformLayout()
        CType(Me.dgvTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLoginTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTeacherAccounts.ResumeLayout(False)
        Me.grpTeacherAccounts.PerformLayout()
        Me.pnlTeacherSidebar.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grpTeacherAccounts As GroupBox
    Friend WithEvents txtbxTeacherPassword As TextBox
    Friend WithEvents lblStudentMiddleName As Label
    Friend WithEvents txtbxTeacherUserID As TextBox
    Friend WithEvents lblStudentFirstName As Label
    Friend WithEvents txtbxTeaAccountTeacherID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxTeacherUserType As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvTeacher As DataGridView
    Friend WithEvents dgvLoginTeacher As DataGridView
    Friend WithEvents btnManTeaDelete As Button
    Friend WithEvents btnManTeaUpdate As Button
    Friend WithEvents btnManTeacherAdd As Button
    Friend WithEvents txtbxManTeaSearch As TextBox
End Class
