<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherGenerateReport
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.grpSubjectLoad = New System.Windows.Forms.GroupBox()
        Me.dgvSubjectLoad = New System.Windows.Forms.DataGridView()
        Me.lblSubjectLoadYear = New System.Windows.Forms.Label()
        Me.cmbSubjectLoadYear = New System.Windows.Forms.ComboBox()
        Me.btnTeacherGenerateSubjectLoad = New System.Windows.Forms.Button()
        Me.grpSectionStudents = New System.Windows.Forms.GroupBox()
        Me.dgvSectionStudents = New System.Windows.Forms.DataGridView()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.btnTeacherGenerateStudents = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlMainContent.SuspendLayout()
        Me.grpSubjectLoad.SuspendLayout()
        CType(Me.dgvSubjectLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSectionStudents.SuspendLayout()
        CType(Me.dgvSectionStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(300, 960)
        Me.pnlSidebar.TabIndex = 12
        '
        'pnlMainContent
        '
        Me.pnlMainContent.AutoScroll = True
        Me.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlMainContent.Controls.Add(Me.grpSubjectLoad)
        Me.pnlMainContent.Controls.Add(Me.grpSectionStudents)
        Me.pnlMainContent.Controls.Add(Me.PictureBox1)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(300, 0)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(1143, 960)
        Me.pnlMainContent.TabIndex = 13
        '
        'grpSectionStudents
        '
        Me.grpSectionStudents.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpSectionStudents.BackColor = System.Drawing.Color.White
        Me.grpSectionStudents.Controls.Add(Me.btnTeacherGenerateStudents)
        Me.grpSectionStudents.Controls.Add(Me.lblGender)
        Me.grpSectionStudents.Controls.Add(Me.cmbGender)
        Me.grpSectionStudents.Controls.Add(Me.dgvSectionStudents)
        Me.grpSectionStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSectionStudents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpSectionStudents.Location = New System.Drawing.Point(50, 20)
        Me.grpSectionStudents.Margin = New System.Windows.Forms.Padding(50, 20, 50, 20)
        Me.grpSectionStudents.MinimumSize = New System.Drawing.Size(800, 200)
        Me.grpSectionStudents.Name = "grpSectionStudents"
        Me.grpSectionStudents.Padding = New System.Windows.Forms.Padding(15, 10, 15, 15)
        Me.grpSectionStudents.Size = New System.Drawing.Size(1200, 200)
        Me.grpSectionStudents.TabIndex = 28
        Me.grpSectionStudents.TabStop = False
        Me.grpSectionStudents.Text = "Section Students Report"
        '
        'btnTeacherGenerateStudents
        '
        Me.btnTeacherGenerateStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnTeacherGenerateStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacherGenerateStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacherGenerateStudents.ForeColor = System.Drawing.Color.White
        Me.btnTeacherGenerateStudents.Location = New System.Drawing.Point(18, 30)
        Me.btnTeacherGenerateStudents.Name = "btnTeacherGenerateStudents"
        Me.btnTeacherGenerateStudents.Size = New System.Drawing.Size(150, 40)
        Me.btnTeacherGenerateStudents.TabIndex = 4
        Me.btnTeacherGenerateStudents.Text = "Print Students"
        Me.btnTeacherGenerateStudents.UseVisualStyleBackColor = False
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(190, 17)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(65, 20)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "Gender:"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Location = New System.Drawing.Point(190, 40)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(200, 28)
        Me.cmbGender.TabIndex = 5
        '
        'dgvSectionStudents
        '
        Me.dgvSectionStudents.AllowUserToAddRows = False
        Me.dgvSectionStudents.AllowUserToDeleteRows = False
        Me.dgvSectionStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSectionStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSectionStudents.BackgroundColor = System.Drawing.Color.White
        Me.dgvSectionStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSectionStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSectionStudents.Location = New System.Drawing.Point(18, 95)
        Me.dgvSectionStudents.Name = "dgvSectionStudents"
        Me.dgvSectionStudents.ReadOnly = True
        Me.dgvSectionStudents.RowHeadersWidth = 51
        Me.dgvSectionStudents.RowTemplate.Height = 24
        Me.dgvSectionStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSectionStudents.Size = New System.Drawing.Size(1164, 90)
        Me.dgvSectionStudents.TabIndex = 7
        '
        'grpSubjectLoad
        '
        Me.grpSubjectLoad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpSubjectLoad.BackColor = System.Drawing.Color.White
        Me.grpSubjectLoad.Controls.Add(Me.btnTeacherGenerateSubjectLoad)
        Me.grpSubjectLoad.Controls.Add(Me.lblSubjectLoadYear)
        Me.grpSubjectLoad.Controls.Add(Me.cmbSubjectLoadYear)
        Me.grpSubjectLoad.Controls.Add(Me.dgvSubjectLoad)
        Me.grpSubjectLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSubjectLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpSubjectLoad.Location = New System.Drawing.Point(50, 240)
        Me.grpSubjectLoad.Margin = New System.Windows.Forms.Padding(50, 20, 50, 20)
        Me.grpSubjectLoad.MinimumSize = New System.Drawing.Size(800, 200)
        Me.grpSubjectLoad.Name = "grpSubjectLoad"
        Me.grpSubjectLoad.Padding = New System.Windows.Forms.Padding(15, 10, 15, 15)
        Me.grpSubjectLoad.Size = New System.Drawing.Size(1200, 200)
        Me.grpSubjectLoad.TabIndex = 29
        Me.grpSubjectLoad.TabStop = False
        Me.grpSubjectLoad.Text = "Subject Load Report"
        '
        'btnTeacherGenerateSubjectLoad
        '
        Me.btnTeacherGenerateSubjectLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnTeacherGenerateSubjectLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacherGenerateSubjectLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacherGenerateSubjectLoad.ForeColor = System.Drawing.Color.White
        Me.btnTeacherGenerateSubjectLoad.Location = New System.Drawing.Point(18, 30)
        Me.btnTeacherGenerateSubjectLoad.Name = "btnTeacherGenerateSubjectLoad"
        Me.btnTeacherGenerateSubjectLoad.Size = New System.Drawing.Size(150, 40)
        Me.btnTeacherGenerateSubjectLoad.TabIndex = 8
        Me.btnTeacherGenerateSubjectLoad.Text = "Print Subject Load"
        Me.btnTeacherGenerateSubjectLoad.UseVisualStyleBackColor = False
        '
        'lblSubjectLoadYear
        '
        Me.lblSubjectLoadYear.AutoSize = True
        Me.lblSubjectLoadYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectLoadYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSubjectLoadYear.Location = New System.Drawing.Point(190, 17)
        Me.lblSubjectLoadYear.Name = "lblSubjectLoadYear"
        Me.lblSubjectLoadYear.Size = New System.Drawing.Size(47, 20)
        Me.lblSubjectLoadYear.TabIndex = 10
        Me.lblSubjectLoadYear.Text = "Year:"
        '
        'cmbSubjectLoadYear
        '
        Me.cmbSubjectLoadYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubjectLoadYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubjectLoadYear.FormattingEnabled = True
        Me.cmbSubjectLoadYear.Location = New System.Drawing.Point(190, 40)
        Me.cmbSubjectLoadYear.Name = "cmbSubjectLoadYear"
        Me.cmbSubjectLoadYear.Size = New System.Drawing.Size(200, 28)
        Me.cmbSubjectLoadYear.TabIndex = 9
        '
        'dgvSubjectLoad
        '
        Me.dgvSubjectLoad.AllowUserToAddRows = False
        Me.dgvSubjectLoad.AllowUserToDeleteRows = False
        Me.dgvSubjectLoad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSubjectLoad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubjectLoad.BackgroundColor = System.Drawing.Color.White
        Me.dgvSubjectLoad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSubjectLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubjectLoad.Location = New System.Drawing.Point(18, 95)
        Me.dgvSubjectLoad.Name = "dgvSubjectLoad"
        Me.dgvSubjectLoad.ReadOnly = True
        Me.dgvSubjectLoad.RowHeadersWidth = 51
        Me.dgvSubjectLoad.RowTemplate.Height = 24
        Me.dgvSubjectLoad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubjectLoad.Size = New System.Drawing.Size(1164, 90)
        Me.dgvSubjectLoad.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.CFLC.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(534, 247)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 330)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'TeacherGenerateReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 960)
        Me.Controls.Add(Me.pnlMainContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "TeacherGenerateReport"
        Me.Text = "Teacher Generate Reports"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlMainContent.ResumeLayout(False)
        Me.grpSubjectLoad.ResumeLayout(False)
        Me.grpSubjectLoad.PerformLayout()
        CType(Me.dgvSubjectLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSectionStudents.ResumeLayout(False)
        Me.grpSectionStudents.PerformLayout()
        CType(Me.dgvSectionStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpSectionStudents As GroupBox
    Friend WithEvents btnTeacherGenerateStudents As Button
    Friend WithEvents lblGender As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents dgvSectionStudents As DataGridView
    Friend WithEvents grpSubjectLoad As GroupBox
    Friend WithEvents btnTeacherGenerateSubjectLoad As Button
    Friend WithEvents lblSubjectLoadYear As Label
    Friend WithEvents cmbSubjectLoadYear As ComboBox
    Friend WithEvents dgvSubjectLoad As DataGridView
End Class
