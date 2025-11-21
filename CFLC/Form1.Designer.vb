<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAdministrator = New System.Windows.Forms.Button()
        Me.btnTeacher = New System.Windows.Forms.Button()
        Me.btnSuperAdmin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(485, 402)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(498, 24)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "CFLC Sudent Information Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnAdministrator
        '
        Me.btnAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdministrator.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnAdministrator.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministrator.Location = New System.Drawing.Point(592, 449)
        Me.btnAdministrator.Name = "btnAdministrator"
        Me.btnAdministrator.Size = New System.Drawing.Size(269, 39)
        Me.btnAdministrator.TabIndex = 2
        Me.btnAdministrator.Text = "Administrator"
        Me.btnAdministrator.UseVisualStyleBackColor = False
        '
        'btnTeacher
        '
        Me.btnTeacher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTeacher.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnTeacher.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacher.Location = New System.Drawing.Point(592, 494)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(269, 39)
        Me.btnTeacher.TabIndex = 3
        Me.btnTeacher.Text = "Teacher"
        Me.btnTeacher.UseVisualStyleBackColor = False
        '
        'btnSuperAdmin
        '
        Me.btnSuperAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSuperAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSuperAdmin.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuperAdmin.Location = New System.Drawing.Point(592, 539)
        Me.btnSuperAdmin.Name = "btnSuperAdmin"
        Me.btnSuperAdmin.Size = New System.Drawing.Size(269, 39)
        Me.btnSuperAdmin.TabIndex = 4
        Me.btnSuperAdmin.Text = "SuperAdmin"
        Me.btnSuperAdmin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.CFLC.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(539, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 330)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1423, 698)
        Me.Controls.Add(Me.btnSuperAdmin)
        Me.Controls.Add(Me.btnTeacher)
        Me.Controls.Add(Me.btnAdministrator)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnAdministrator As Button
    Friend WithEvents btnTeacher As Button
    Friend WithEvents btnSuperAdmin As Button
End Class
