<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuperAdminDashboard
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
        Me.pnlSuperAdminMainContent.SuspendLayout()
        Me.pnlTeacherSidebar.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSuperAdminMainContent
        '
        Me.pnlSuperAdminMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlSuperAdminMainContent.Controls.Add(Me.PictureBox1)
        Me.pnlSuperAdminMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSuperAdminMainContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperAdminMainContent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlSuperAdminMainContent.Name = "pnlSuperAdminMainContent"
        Me.pnlSuperAdminMainContent.Size = New System.Drawing.Size(1733, 779)
        Me.pnlSuperAdminMainContent.TabIndex = 14
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
        'SuperAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 779)
        Me.Controls.Add(Me.pnlTeacherSidebar)
        Me.Controls.Add(Me.pnlSuperAdminMainContent)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SuperAdminDashboard"
        Me.Text = "SuperAdminDashboard"
        Me.pnlSuperAdminMainContent.ResumeLayout(False)
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
End Class
