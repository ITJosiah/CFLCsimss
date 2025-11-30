<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherDashboard
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
        Me.pnlTeacherMainContent = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlTeacherSidebar = New System.Windows.Forms.Panel()
        Me.PanelSideButton = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnTeacherViewSection = New System.Windows.Forms.Button()
        Me.btnTeacherViewStudents = New System.Windows.Forms.Button()
        Me.btnViewAssignedSubjects = New System.Windows.Forms.Button()
        Me.btnTeacherGenerateReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnBackToDashboard = New System.Windows.Forms.Button()
        Me.pnlTeacherMainContent.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTeacherSidebar.SuspendLayout()
        Me.PanelSideButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTeacherMainContent
        '
        Me.pnlTeacherMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlTeacherMainContent.Controls.Add(Me.PictureBox1)
        Me.pnlTeacherMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTeacherMainContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlTeacherMainContent.Name = "pnlTeacherMainContent"
        Me.pnlTeacherMainContent.Size = New System.Drawing.Size(1300, 633)
        Me.pnlTeacherMainContent.TabIndex = 13
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
        'pnlTeacherSidebar
        '
        Me.pnlTeacherSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlTeacherSidebar.Controls.Add(Me.PanelSideButton)
        Me.pnlTeacherSidebar.Controls.Add(Me.btnLogout)
        Me.pnlTeacherSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTeacherSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTeacherSidebar.Name = "pnlTeacherSidebar"
        Me.pnlTeacherSidebar.Padding = New System.Windows.Forms.Padding(30, 40, 30, 40)
        Me.pnlTeacherSidebar.Size = New System.Drawing.Size(300, 633)
        Me.pnlTeacherSidebar.TabIndex = 12
        '
        'PanelSideButton
        '
        Me.PanelSideButton.BackColor = System.Drawing.Color.Transparent
        Me.PanelSideButton.Controls.Add(Me.btnTeacherViewSection)
        Me.PanelSideButton.Controls.Add(Me.btnTeacherViewStudents)
        Me.PanelSideButton.Controls.Add(Me.btnViewAssignedSubjects)
        Me.PanelSideButton.Controls.Add(Me.btnTeacherGenerateReports)
        Me.PanelSideButton.Controls.Add(Me.btnBackToDashboard)
        Me.PanelSideButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideButton.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.PanelSideButton.Location = New System.Drawing.Point(30, 40)
        Me.PanelSideButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelSideButton.Name = "PanelSideButton"
        Me.PanelSideButton.Size = New System.Drawing.Size(240, 503)
        Me.PanelSideButton.TabIndex = 0
        Me.PanelSideButton.WrapContents = False
        '
        'btnTeacherViewSection
        '
        Me.btnTeacherViewSection.Location = New System.Drawing.Point(0, 0)
        Me.btnTeacherViewSection.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnTeacherViewSection.Name = "btnTeacherViewSection"
        Me.btnTeacherViewSection.Size = New System.Drawing.Size(240, 45)
        Me.btnTeacherViewSection.TabIndex = 11
        Me.btnTeacherViewSection.Text = "View Section"
        Me.btnTeacherViewSection.UseVisualStyleBackColor = True
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
        Me.btnLogout.Location = New System.Drawing.Point(30, 543)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(240, 50)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnBackToDashboard
        '
        Me.btnBackToDashboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBackToDashboard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBackToDashboard.Location = New System.Drawing.Point(56, 252)
        Me.btnBackToDashboard.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnBackToDashboard.Name = "btnBackToDashboard"
        Me.btnBackToDashboard.Size = New System.Drawing.Size(127, 45)
        Me.btnBackToDashboard.TabIndex = 12
        Me.btnBackToDashboard.Text = "Back to Dashboard"
        Me.btnBackToDashboard.UseVisualStyleBackColor = True
        '
        'TeacherDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 633)
        Me.Controls.Add(Me.pnlTeacherSidebar)
        Me.Controls.Add(Me.pnlTeacherMainContent)
        Me.Name = "TeacherDashboard"
        Me.Text = "TeacherDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTeacherMainContent.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTeacherSidebar.ResumeLayout(False)
        Me.PanelSideButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTeacherMainContent As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlTeacherSidebar As Panel
    Friend WithEvents PanelSideButton As FlowLayoutPanel
    Friend WithEvents btnTeacherViewStudents As Button
    Friend WithEvents btnViewAssignedSubjects As Button
    Friend WithEvents btnTeacherGenerateReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnTeacherViewSection As Button
    Friend WithEvents btnBackToDashboard As Button
End Class
