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
        Me.dgvLoginAdmin = New System.Windows.Forms.DataGridView()
        Me.txtbxManAdminSearch = New System.Windows.Forms.TextBox()
        Me.btnManAdDelete = New System.Windows.Forms.Button()
        Me.btnManAdUpdate = New System.Windows.Forms.Button()
        Me.btnManAdAdd = New System.Windows.Forms.Button()
        Me.grpAdminAccounts = New System.Windows.Forms.GroupBox()
        Me.ComboBoxAdminUserType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxAdminPassword = New System.Windows.Forms.TextBox()
        Me.lblStudentMiddleName = New System.Windows.Forms.Label()
        Me.txtbxAdminUserID = New System.Windows.Forms.TextBox()
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
        CType(Me.dgvLoginAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAdminAccounts.SuspendLayout()
        Me.pnlTeacherSidebar.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlSuperAdminMainContent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlSuperAdminMainContent.Name = "pnlSuperAdminMainContent"
        Me.pnlSuperAdminMainContent.Size = New System.Drawing.Size(1733, 779)
        Me.pnlSuperAdminMainContent.TabIndex = 15
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
        Me.dgvLoginAdmin.Location = New System.Drawing.Point(423, 267)
        Me.dgvLoginAdmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvLoginAdmin.Name = "dgvLoginAdmin"
        Me.dgvLoginAdmin.ReadOnly = True
        Me.dgvLoginAdmin.RowHeadersVisible = False
        Me.dgvLoginAdmin.RowHeadersWidth = 51
        Me.dgvLoginAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLoginAdmin.Size = New System.Drawing.Size(1259, 463)
        Me.dgvLoginAdmin.TabIndex = 24
        '
        'txtbxManAdminSearch
        '
        Me.txtbxManAdminSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxManAdminSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxManAdminSearch.Location = New System.Drawing.Point(423, 204)
        Me.txtbxManAdminSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbxManAdminSearch.MaxLength = 50
        Me.txtbxManAdminSearch.Name = "txtbxManAdminSearch"
        Me.txtbxManAdminSearch.Size = New System.Drawing.Size(247, 36)
        Me.txtbxManAdminSearch.TabIndex = 23
        '
        'btnManAdDelete
        '
        Me.btnManAdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManAdDelete.Location = New System.Drawing.Point(1567, 198)
        Me.btnManAdDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnManAdDelete.Name = "btnManAdDelete"
        Me.btnManAdDelete.Size = New System.Drawing.Size(115, 43)
        Me.btnManAdDelete.TabIndex = 22
        Me.btnManAdDelete.Text = "Delete"
        Me.btnManAdDelete.UseVisualStyleBackColor = True
        '
        'btnManAdUpdate
        '
        Me.btnManAdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManAdUpdate.Location = New System.Drawing.Point(1417, 198)
        Me.btnManAdUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnManAdUpdate.Name = "btnManAdUpdate"
        Me.btnManAdUpdate.Size = New System.Drawing.Size(115, 43)
        Me.btnManAdUpdate.TabIndex = 21
        Me.btnManAdUpdate.Text = "Update"
        Me.btnManAdUpdate.UseVisualStyleBackColor = True
        '
        'btnManAdAdd
        '
        Me.btnManAdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManAdAdd.Location = New System.Drawing.Point(1267, 198)
        Me.btnManAdAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnManAdAdd.Name = "btnManAdAdd"
        Me.btnManAdAdd.Size = New System.Drawing.Size(115, 43)
        Me.btnManAdAdd.TabIndex = 20
        Me.btnManAdAdd.Text = "Add"
        Me.btnManAdAdd.UseVisualStyleBackColor = True
        '
        'grpAdminAccounts
        '
        Me.grpAdminAccounts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAdminAccounts.BackColor = System.Drawing.Color.Gainsboro
        Me.grpAdminAccounts.Controls.Add(Me.ComboBoxAdminUserType)
        Me.grpAdminAccounts.Controls.Add(Me.Label1)
        Me.grpAdminAccounts.Controls.Add(Me.txtbxAdminPassword)
        Me.grpAdminAccounts.Controls.Add(Me.lblStudentMiddleName)
        Me.grpAdminAccounts.Controls.Add(Me.txtbxAdminUserID)
        Me.grpAdminAccounts.Controls.Add(Me.lblStudentFirstName)
        Me.grpAdminAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAdminAccounts.Location = New System.Drawing.Point(423, 49)
        Me.grpAdminAccounts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpAdminAccounts.Name = "grpAdminAccounts"
        Me.grpAdminAccounts.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpAdminAccounts.Size = New System.Drawing.Size(1259, 133)
        Me.grpAdminAccounts.TabIndex = 14
        Me.grpAdminAccounts.TabStop = False
        Me.grpAdminAccounts.Text = "Admin Accounts"
        '
        'ComboBoxAdminUserType
        '
        Me.ComboBoxAdminUserType.FormattingEnabled = True
        Me.ComboBoxAdminUserType.Location = New System.Drawing.Point(671, 60)
        Me.ComboBoxAdminUserType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxAdminUserType.Name = "ComboBoxAdminUserType"
        Me.ComboBoxAdminUserType.Size = New System.Drawing.Size(187, 28)
        Me.ComboBoxAdminUserType.TabIndex = 6
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
        'txtbxAdminPassword
        '
        Me.txtbxAdminPassword.Location = New System.Drawing.Point(361, 60)
        Me.txtbxAdminPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxAdminPassword.MaxLength = 50
        Me.txtbxAdminPassword.Name = "txtbxAdminPassword"
        Me.txtbxAdminPassword.Size = New System.Drawing.Size(252, 26)
        Me.txtbxAdminPassword.TabIndex = 4
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
        'txtbxAdminUserID
        '
        Me.txtbxAdminUserID.Location = New System.Drawing.Point(52, 60)
        Me.txtbxAdminUserID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxAdminUserID.MaxLength = 50
        Me.txtbxAdminUserID.Name = "txtbxAdminUserID"
        Me.txtbxAdminUserID.Size = New System.Drawing.Size(252, 26)
        Me.txtbxAdminUserID.TabIndex = 2
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
        Me.pnlTeacherSidebar.Size = New System.Drawing.Size(400, 779)
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(320, 619)
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
        Me.btnLogout.Location = New System.Drawing.Point(40, 668)
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
        Me.PictureBox1.Location = New System.Drawing.Point(828, 176)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 406)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'SuperAdminManageAdminAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 779)
        Me.Controls.Add(Me.pnlSuperAdminMainContent)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "SuperAdminManageAdminAccounts"
        Me.Text = "SuperAdminManageAdminAccounts"
        Me.pnlSuperAdminMainContent.ResumeLayout(False)
        Me.pnlSuperAdminMainContent.PerformLayout()
        CType(Me.dgvLoginAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAdminAccounts.ResumeLayout(False)
        Me.grpAdminAccounts.PerformLayout()
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
    Friend WithEvents grpAdminAccounts As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxAdminPassword As TextBox
    Friend WithEvents lblStudentMiddleName As Label
    Friend WithEvents txtbxAdminUserID As TextBox
    Friend WithEvents lblStudentFirstName As Label
    Friend WithEvents ComboBoxAdminUserType As ComboBox
    Friend WithEvents txtbxManAdminSearch As TextBox
    Friend WithEvents btnManAdDelete As Button
    Friend WithEvents btnManAdUpdate As Button
    Friend WithEvents btnManAdAdd As Button
    Friend WithEvents dgvLoginAdmin As DataGridView
End Class
