<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnManageStudents = New System.Windows.Forms.Button()
        Me.btnManageTeachers = New System.Windows.Forms.Button()
        Me.btnManageSections = New System.Windows.Forms.Button()
        Me.btnManageEnrollments = New System.Windows.Forms.Button()
        Me.btnManageSubjects = New System.Windows.Forms.Button()
        Me.btnGenerateReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.CFLC.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(512, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 330)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnManageStudents
        '
        Me.btnManageStudents.Location = New System.Drawing.Point(131, 177)
        Me.btnManageStudents.Name = "btnManageStudents"
        Me.btnManageStudents.Size = New System.Drawing.Size(134, 23)
        Me.btnManageStudents.TabIndex = 4
        Me.btnManageStudents.Text = "Manage Students"
        Me.btnManageStudents.UseVisualStyleBackColor = True
        '
        'btnManageTeachers
        '
        Me.btnManageTeachers.Location = New System.Drawing.Point(131, 221)
        Me.btnManageTeachers.Name = "btnManageTeachers"
        Me.btnManageTeachers.Size = New System.Drawing.Size(134, 23)
        Me.btnManageTeachers.TabIndex = 5
        Me.btnManageTeachers.Text = "Manage Teachers"
        Me.btnManageTeachers.UseVisualStyleBackColor = True
        '
        'btnManageSections
        '
        Me.btnManageSections.Location = New System.Drawing.Point(131, 268)
        Me.btnManageSections.Name = "btnManageSections"
        Me.btnManageSections.Size = New System.Drawing.Size(134, 23)
        Me.btnManageSections.TabIndex = 6
        Me.btnManageSections.Text = "Manage Sections"
        Me.btnManageSections.UseVisualStyleBackColor = True
        '
        'btnManageEnrollments
        '
        Me.btnManageEnrollments.Location = New System.Drawing.Point(131, 314)
        Me.btnManageEnrollments.Name = "btnManageEnrollments"
        Me.btnManageEnrollments.Size = New System.Drawing.Size(134, 23)
        Me.btnManageEnrollments.TabIndex = 7
        Me.btnManageEnrollments.Text = "Manage Enrollments"
        Me.btnManageEnrollments.UseVisualStyleBackColor = True
        '
        'btnManageSubjects
        '
        Me.btnManageSubjects.Location = New System.Drawing.Point(131, 361)
        Me.btnManageSubjects.Name = "btnManageSubjects"
        Me.btnManageSubjects.Size = New System.Drawing.Size(134, 23)
        Me.btnManageSubjects.TabIndex = 8
        Me.btnManageSubjects.Text = "Manage Subjects"
        Me.btnManageSubjects.UseVisualStyleBackColor = True
        '
        'btnGenerateReports
        '
        Me.btnGenerateReports.Location = New System.Drawing.Point(131, 418)
        Me.btnGenerateReports.Name = "btnGenerateReports"
        Me.btnGenerateReports.Size = New System.Drawing.Size(134, 23)
        Me.btnGenerateReports.TabIndex = 9
        Me.btnGenerateReports.Text = "Generate Reports"
        Me.btnGenerateReports.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(131, 472)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(134, 23)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 633)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnGenerateReports)
        Me.Controls.Add(Me.btnManageSubjects)
        Me.Controls.Add(Me.btnManageEnrollments)
        Me.Controls.Add(Me.btnManageSections)
        Me.Controls.Add(Me.btnManageTeachers)
        Me.Controls.Add(Me.btnManageStudents)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
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
End Class
