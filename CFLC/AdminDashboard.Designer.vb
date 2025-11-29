<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.flowButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnManageStudents = New System.Windows.Forms.Button()
        Me.btnManageTeachers = New System.Windows.Forms.Button()
        Me.btnManageSections = New System.Windows.Forms.Button()
        Me.btnManageSubjects = New System.Windows.Forms.Button()
        Me.btnManageEnrollments = New System.Windows.Forms.Button()
        Me.btnGenerateReports = New System.Windows.Forms.Button()
        Me.btnBackToDashboard = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.pnlSubjectListDashboard = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNameSubjectListDashboard = New System.Windows.Forms.Label()
        Me.lblSubjectListDashboard = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlStudentListDashboard = New System.Windows.Forms.Panel()
        Me.PictureBoxStudentListIcon = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblStudentListDashboard = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
        Me.pnlMainContent.SuspendLayout()
        Me.pnlSubjectListDashboard.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlStudentListDashboard.SuspendLayout()
        CType(Me.PictureBoxStudentListIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.flowButtons)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(30, 40, 30, 40)
        Me.pnlSidebar.Size = New System.Drawing.Size(300, 860)
        Me.pnlSidebar.TabIndex = 11
        '
        'flowButtons
        '
        Me.flowButtons.BackColor = System.Drawing.Color.Transparent
        Me.flowButtons.Controls.Add(Me.btnManageStudents)
        Me.flowButtons.Controls.Add(Me.btnManageTeachers)
        Me.flowButtons.Controls.Add(Me.btnManageSections)
        Me.flowButtons.Controls.Add(Me.btnManageSubjects)
        Me.flowButtons.Controls.Add(Me.btnManageEnrollments)
        Me.flowButtons.Controls.Add(Me.btnGenerateReports)
        Me.flowButtons.Controls.Add(Me.btnBackToDashboard)
        Me.flowButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowButtons.Location = New System.Drawing.Point(30, 40)
        Me.flowButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.flowButtons.Name = "flowButtons"
        Me.flowButtons.Size = New System.Drawing.Size(240, 730)
        Me.flowButtons.TabIndex = 0
        Me.flowButtons.WrapContents = False
        '
        'btnManageStudents
        '
        Me.btnManageStudents.Location = New System.Drawing.Point(0, 0)
        Me.btnManageStudents.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnManageStudents.Name = "btnManageStudents"
        Me.btnManageStudents.Size = New System.Drawing.Size(240, 45)
        Me.btnManageStudents.TabIndex = 4
        Me.btnManageStudents.Text = "Manage Students"
        Me.btnManageStudents.UseVisualStyleBackColor = True
        '
        'btnManageTeachers
        '
        Me.btnManageTeachers.Location = New System.Drawing.Point(0, 63)
        Me.btnManageTeachers.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnManageTeachers.Name = "btnManageTeachers"
        Me.btnManageTeachers.Size = New System.Drawing.Size(240, 45)
        Me.btnManageTeachers.TabIndex = 5
        Me.btnManageTeachers.Text = "Manage Teachers"
        Me.btnManageTeachers.UseVisualStyleBackColor = True
        '
        'btnManageSections
        '
        Me.btnManageSections.Location = New System.Drawing.Point(0, 126)
        Me.btnManageSections.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnManageSections.Name = "btnManageSections"
        Me.btnManageSections.Size = New System.Drawing.Size(240, 45)
        Me.btnManageSections.TabIndex = 6
        Me.btnManageSections.Text = "Manage Sections"
        Me.btnManageSections.UseVisualStyleBackColor = True
        '
        'btnManageSubjects
        '
        Me.btnManageSubjects.Location = New System.Drawing.Point(0, 189)
        Me.btnManageSubjects.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnManageSubjects.Name = "btnManageSubjects"
        Me.btnManageSubjects.Size = New System.Drawing.Size(240, 45)
        Me.btnManageSubjects.TabIndex = 8
        Me.btnManageSubjects.Text = "Manage Subjects"
        Me.btnManageSubjects.UseVisualStyleBackColor = True
        '
        'btnManageEnrollments
        '
        Me.btnManageEnrollments.Location = New System.Drawing.Point(0, 252)
        Me.btnManageEnrollments.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnManageEnrollments.Name = "btnManageEnrollments"
        Me.btnManageEnrollments.Size = New System.Drawing.Size(240, 45)
        Me.btnManageEnrollments.TabIndex = 7
        Me.btnManageEnrollments.Text = "Manage Enrollments"
        Me.btnManageEnrollments.UseVisualStyleBackColor = True
        '
        'btnGenerateReports
        '
        Me.btnGenerateReports.Location = New System.Drawing.Point(0, 315)
        Me.btnGenerateReports.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnGenerateReports.Name = "btnGenerateReports"
        Me.btnGenerateReports.Size = New System.Drawing.Size(240, 45)
        Me.btnGenerateReports.TabIndex = 9
        Me.btnGenerateReports.Text = "Generate Reports"
        Me.btnGenerateReports.UseVisualStyleBackColor = True
        '
        'btnBackToDashboard
        '
        Me.btnBackToDashboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBackToDashboard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBackToDashboard.Location = New System.Drawing.Point(56, 378)
        Me.btnBackToDashboard.Margin = New System.Windows.Forms.Padding(0, 0, 0, 18)
        Me.btnBackToDashboard.Name = "btnBackToDashboard"
        Me.btnBackToDashboard.Size = New System.Drawing.Size(127, 45)
        Me.btnBackToDashboard.TabIndex = 10
        Me.btnBackToDashboard.Text = "Back to Dashboard"
        Me.btnBackToDashboard.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(30, 770)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(240, 50)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlMainContent
        '
        Me.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlMainContent.Controls.Add(Me.pnlSubjectListDashboard)
        Me.pnlMainContent.Controls.Add(Me.pnlStudentListDashboard)
        Me.pnlMainContent.Controls.Add(Me.PictureBox1)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(300, 0)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(1143, 860)
        Me.pnlMainContent.TabIndex = 12
        '
        'pnlSubjectListDashboard
        '
        Me.pnlSubjectListDashboard.BackColor = System.Drawing.Color.ForestGreen
        Me.pnlSubjectListDashboard.Controls.Add(Me.PictureBox2)
        Me.pnlSubjectListDashboard.Controls.Add(Me.Panel2)
        Me.pnlSubjectListDashboard.Controls.Add(Me.lblSubjectListDashboard)
        Me.pnlSubjectListDashboard.Controls.Add(Me.Label7)
        Me.pnlSubjectListDashboard.Location = New System.Drawing.Point(50, 290)
        Me.pnlSubjectListDashboard.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSubjectListDashboard.Name = "pnlSubjectListDashboard"
        Me.pnlSubjectListDashboard.Size = New System.Drawing.Size(396, 172)
        Me.pnlSubjectListDashboard.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(18, 58)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 105)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblNameSubjectListDashboard)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(396, 48)
        Me.Panel2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 76)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "0"
        '
        'lblNameSubjectListDashboard
        '
        Me.lblNameSubjectListDashboard.AutoSize = True
        Me.lblNameSubjectListDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameSubjectListDashboard.Location = New System.Drawing.Point(119, 6)
        Me.lblNameSubjectListDashboard.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNameSubjectListDashboard.Name = "lblNameSubjectListDashboard"
        Me.lblNameSubjectListDashboard.Size = New System.Drawing.Size(155, 31)
        Me.lblNameSubjectListDashboard.TabIndex = 0
        Me.lblNameSubjectListDashboard.Text = "Subject List"
        '
        'lblSubjectListDashboard
        '
        Me.lblSubjectListDashboard.AutoSize = True
        Me.lblSubjectListDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectListDashboard.Location = New System.Drawing.Point(177, 80)
        Me.lblSubjectListDashboard.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubjectListDashboard.Name = "lblSubjectListDashboard"
        Me.lblSubjectListDashboard.Size = New System.Drawing.Size(57, 63)
        Me.lblSubjectListDashboard.TabIndex = 1
        Me.lblSubjectListDashboard.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 31)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Student List"
        '
        'pnlStudentListDashboard
        '
        Me.pnlStudentListDashboard.BackColor = System.Drawing.Color.ForestGreen
        Me.pnlStudentListDashboard.Controls.Add(Me.PictureBoxStudentListIcon)
        Me.pnlStudentListDashboard.Controls.Add(Me.Panel6)
        Me.pnlStudentListDashboard.Controls.Add(Me.lblStudentListDashboard)
        Me.pnlStudentListDashboard.Controls.Add(Me.Label1)
        Me.pnlStudentListDashboard.Location = New System.Drawing.Point(47, 30)
        Me.pnlStudentListDashboard.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlStudentListDashboard.Name = "pnlStudentListDashboard"
        Me.pnlStudentListDashboard.Size = New System.Drawing.Size(396, 229)
        Me.pnlStudentListDashboard.TabIndex = 4
        '
        'PictureBoxStudentListIcon
        '
        Me.PictureBoxStudentListIcon.Image = CType(resources.GetObject("PictureBoxStudentListIcon.Image"), System.Drawing.Image)
        Me.PictureBoxStudentListIcon.Location = New System.Drawing.Point(2, 58)
        Me.PictureBoxStudentListIcon.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBoxStudentListIcon.Name = "PictureBoxStudentListIcon"
        Me.PictureBoxStudentListIcon.Size = New System.Drawing.Size(195, 162)
        Me.PictureBoxStudentListIcon.TabIndex = 6
        Me.PictureBoxStudentListIcon.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Green
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(396, 48)
        Me.Panel6.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 76)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(119, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Student List"
        '
        'lblStudentListDashboard
        '
        Me.lblStudentListDashboard.AutoSize = True
        Me.lblStudentListDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentListDashboard.Location = New System.Drawing.Point(203, 110)
        Me.lblStudentListDashboard.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentListDashboard.Name = "lblStudentListDashboard"
        Me.lblStudentListDashboard.Size = New System.Drawing.Size(57, 63)
        Me.lblStudentListDashboard.TabIndex = 1
        Me.lblStudentListDashboard.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student List"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.CFLC.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(393, 247)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 330)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1443, 860)
        Me.Controls.Add(Me.pnlMainContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.pnlSidebar.ResumeLayout(False)
        Me.flowButtons.ResumeLayout(False)
        Me.pnlMainContent.ResumeLayout(False)
        Me.pnlSubjectListDashboard.ResumeLayout(False)
        Me.pnlSubjectListDashboard.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlStudentListDashboard.ResumeLayout(False)
        Me.pnlStudentListDashboard.PerformLayout()
        CType(Me.PictureBoxStudentListIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnManageTeachers As Button
    Friend WithEvents btnManageSections As Button
    Friend WithEvents btnManageEnrollments As Button
    Friend WithEvents btnManageSubjects As Button
    Friend WithEvents btnGenerateReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnManageStudents As Button
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents flowButtons As FlowLayoutPanel
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents pnlStudentListDashboard As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStudentListDashboard As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxStudentListIcon As PictureBox
    Friend WithEvents pnlSubjectListDashboard As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNameSubjectListDashboard As Label
    Friend WithEvents lblSubjectListDashboard As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBackToDashboard As Button
End Class
