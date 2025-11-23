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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(647, 495)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(613, 29)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "CFLC Sudent Information Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnAdministrator
        '
        Me.btnAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdministrator.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnAdministrator.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministrator.Location = New System.Drawing.Point(789, 553)
        Me.btnAdministrator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdministrator.Name = "btnAdministrator"
        Me.btnAdministrator.Size = New System.Drawing.Size(359, 48)
        Me.btnAdministrator.TabIndex = 2
        Me.btnAdministrator.Text = "Administrator"
        Me.btnAdministrator.UseVisualStyleBackColor = False
        '
        'btnTeacher
        '
        Me.btnTeacher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTeacher.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnTeacher.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacher.Location = New System.Drawing.Point(789, 608)
        Me.btnTeacher.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(359, 48)
        Me.btnTeacher.TabIndex = 3
        Me.btnTeacher.Text = "Teacher"
        Me.btnTeacher.UseVisualStyleBackColor = False
        '
        'btnSuperAdmin
        '
        Me.btnSuperAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSuperAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSuperAdmin.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuperAdmin.Location = New System.Drawing.Point(789, 663)
        Me.btnSuperAdmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSuperAdmin.Name = "btnSuperAdmin"
        Me.btnSuperAdmin.Size = New System.Drawing.Size(359, 48)
        Me.btnSuperAdmin.TabIndex = 4
        Me.btnSuperAdmin.Text = "SuperAdmin"
        Me.btnSuperAdmin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.CFLC.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(719, 74)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 406)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(173, 159)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(320, 185)
        Me.DataGridView1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1897, 859)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSuperAdmin)
        Me.Controls.Add(Me.btnTeacher)
        Me.Controls.Add(Me.btnAdministrator)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnAdministrator As Button
    Friend WithEvents btnTeacher As Button
    Friend WithEvents btnSuperAdmin As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
