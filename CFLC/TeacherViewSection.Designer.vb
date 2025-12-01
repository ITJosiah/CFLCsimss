<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeacherViewSection
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
        Me.pnlTeacherSidebar = New System.Windows.Forms.Panel()
        Me.flowButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnTeacherViewSection = New System.Windows.Forms.Button()
        Me.btnTeacherViewStudents = New System.Windows.Forms.Button()
        Me.btnViewAssignedSubjects = New System.Windows.Forms.Button()
        Me.btnTeacherGenerateReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlManSecContent = New System.Windows.Forms.Panel()
        Me.grpSectionInfo = New System.Windows.Forms.GroupBox()
        Me.ComboBoxTeacherFloorLevel = New System.Windows.Forms.ComboBox()
        Me.ComboBoxFloorLevel = New System.Windows.Forms.Label()
        Me.txtbxManSecBuildingName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbManSecLearningMode = New System.Windows.Forms.ComboBox()
        Me.cmbManSecClassType = New System.Windows.Forms.ComboBox()
        Me.lblManSecLearningMode = New System.Windows.Forms.Label()
        Me.lblManSecClassType = New System.Windows.Forms.Label()
        Me.txtbxManSecRoomNo = New System.Windows.Forms.TextBox()
        Me.lblManSecRoomNo = New System.Windows.Forms.Label()
        Me.nudManSecGradeLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblManSecGradeLevel = New System.Windows.Forms.Label()
        Me.txtbxManSecTeacherID = New System.Windows.Forms.TextBox()
        Me.lblManSecTeacherID = New System.Windows.Forms.Label()
        Me.txtbxManSecSectionName = New System.Windows.Forms.TextBox()
        Me.lblManSecSectionName = New System.Windows.Forms.Label()
        Me.lblSectionsList = New System.Windows.Forms.Label()
        Me.picWatermark = New System.Windows.Forms.PictureBox()
        Me.pnlTeacherSidebar.SuspendLayout()
        Me.flowButtons.SuspendLayout()
        Me.pnlManSecContent.SuspendLayout()
        Me.grpSectionInfo.SuspendLayout()
        CType(Me.nudManSecGradeLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTeacherSidebar
        '
        Me.pnlTeacherSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlTeacherSidebar.Controls.Add(Me.flowButtons)
        Me.pnlTeacherSidebar.Controls.Add(Me.btnLogout)
        Me.pnlTeacherSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTeacherSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTeacherSidebar.Name = "pnlTeacherSidebar"
        Me.pnlTeacherSidebar.Padding = New System.Windows.Forms.Padding(30, 40, 30, 40)
        Me.pnlTeacherSidebar.Size = New System.Drawing.Size(300, 824)
        Me.pnlTeacherSidebar.TabIndex = 13
        '
        'flowButtons
        '
        Me.flowButtons.BackColor = System.Drawing.Color.Transparent
        Me.flowButtons.Controls.Add(Me.btnTeacherViewSection)
        Me.flowButtons.Controls.Add(Me.btnTeacherViewStudents)
        Me.flowButtons.Controls.Add(Me.btnViewAssignedSubjects)
        Me.flowButtons.Controls.Add(Me.btnTeacherGenerateReports)
        Me.flowButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowButtons.Location = New System.Drawing.Point(30, 40)
        Me.flowButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.flowButtons.Name = "flowButtons"
        Me.flowButtons.Size = New System.Drawing.Size(240, 694)
        Me.flowButtons.TabIndex = 0
        Me.flowButtons.WrapContents = False
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
        Me.btnLogout.Location = New System.Drawing.Point(30, 734)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(240, 50)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlManSecContent
        '
        Me.pnlManSecContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlManSecContent.Controls.Add(Me.grpSectionInfo)
        Me.pnlManSecContent.Controls.Add(Me.lblSectionsList)
        Me.pnlManSecContent.Controls.Add(Me.picWatermark)
        Me.pnlManSecContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlManSecContent.Location = New System.Drawing.Point(300, 0)
        Me.pnlManSecContent.Name = "pnlManSecContent"
        Me.pnlManSecContent.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlManSecContent.Size = New System.Drawing.Size(1268, 824)
        Me.pnlManSecContent.TabIndex = 14
        '
        'grpSectionInfo
        '
        Me.grpSectionInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSectionInfo.AutoSize = True
        Me.grpSectionInfo.BackColor = System.Drawing.Color.Gainsboro
        Me.grpSectionInfo.Controls.Add(Me.ComboBoxTeacherFloorLevel)
        Me.grpSectionInfo.Controls.Add(Me.ComboBoxFloorLevel)
        Me.grpSectionInfo.Controls.Add(Me.txtbxManSecBuildingName)
        Me.grpSectionInfo.Controls.Add(Me.Label1)
        Me.grpSectionInfo.Controls.Add(Me.cmbManSecLearningMode)
        Me.grpSectionInfo.Controls.Add(Me.cmbManSecClassType)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecLearningMode)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecClassType)
        Me.grpSectionInfo.Controls.Add(Me.txtbxManSecRoomNo)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecRoomNo)
        Me.grpSectionInfo.Controls.Add(Me.nudManSecGradeLevel)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecGradeLevel)
        Me.grpSectionInfo.Controls.Add(Me.txtbxManSecTeacherID)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecTeacherID)
        Me.grpSectionInfo.Controls.Add(Me.txtbxManSecSectionName)
        Me.grpSectionInfo.Controls.Add(Me.lblManSecSectionName)
        Me.grpSectionInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSectionInfo.Location = New System.Drawing.Point(33, 71)
        Me.grpSectionInfo.Name = "grpSectionInfo"
        Me.grpSectionInfo.Size = New System.Drawing.Size(1223, 637)
        Me.grpSectionInfo.TabIndex = 3
        Me.grpSectionInfo.TabStop = False
        Me.grpSectionInfo.Text = "Section Information"
        '
        'ComboBoxTeacherFloorLevel
        '
        Me.ComboBoxTeacherFloorLevel.FormattingEnabled = True
        Me.ComboBoxTeacherFloorLevel.Location = New System.Drawing.Point(542, 207)
        Me.ComboBoxTeacherFloorLevel.Name = "ComboBoxTeacherFloorLevel"
        Me.ComboBoxTeacherFloorLevel.Size = New System.Drawing.Size(235, 47)
        Me.ComboBoxTeacherFloorLevel.TabIndex = 41
        '
        'ComboBoxFloorLevel
        '
        Me.ComboBoxFloorLevel.AutoSize = True
        Me.ComboBoxFloorLevel.Location = New System.Drawing.Point(535, 164)
        Me.ComboBoxFloorLevel.Name = "ComboBoxFloorLevel"
        Me.ComboBoxFloorLevel.Size = New System.Drawing.Size(188, 39)
        Me.ComboBoxFloorLevel.TabIndex = 40
        Me.ComboBoxFloorLevel.Text = "Floor Level"
        '
        'txtbxManSecBuildingName
        '
        Me.txtbxManSecBuildingName.Location = New System.Drawing.Point(542, 328)
        Me.txtbxManSecBuildingName.Name = "txtbxManSecBuildingName"
        Me.txtbxManSecBuildingName.Size = New System.Drawing.Size(235, 47)
        Me.txtbxManSecBuildingName.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(535, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 39)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Building Name"
        '
        'cmbManSecLearningMode
        '
        Me.cmbManSecLearningMode.FormattingEnabled = True
        Me.cmbManSecLearningMode.Location = New System.Drawing.Point(542, 446)
        Me.cmbManSecLearningMode.Name = "cmbManSecLearningMode"
        Me.cmbManSecLearningMode.Size = New System.Drawing.Size(235, 47)
        Me.cmbManSecLearningMode.TabIndex = 34
        '
        'cmbManSecClassType
        '
        Me.cmbManSecClassType.FormattingEnabled = True
        Me.cmbManSecClassType.Location = New System.Drawing.Point(177, 446)
        Me.cmbManSecClassType.Name = "cmbManSecClassType"
        Me.cmbManSecClassType.Size = New System.Drawing.Size(235, 47)
        Me.cmbManSecClassType.TabIndex = 33
        '
        'lblManSecLearningMode
        '
        Me.lblManSecLearningMode.AutoSize = True
        Me.lblManSecLearningMode.Location = New System.Drawing.Point(535, 404)
        Me.lblManSecLearningMode.Name = "lblManSecLearningMode"
        Me.lblManSecLearningMode.Size = New System.Drawing.Size(246, 39)
        Me.lblManSecLearningMode.TabIndex = 32
        Me.lblManSecLearningMode.Text = "Learning Mode"
        '
        'lblManSecClassType
        '
        Me.lblManSecClassType.AutoSize = True
        Me.lblManSecClassType.Location = New System.Drawing.Point(170, 402)
        Me.lblManSecClassType.Name = "lblManSecClassType"
        Me.lblManSecClassType.Size = New System.Drawing.Size(191, 39)
        Me.lblManSecClassType.TabIndex = 30
        Me.lblManSecClassType.Text = "Class Type"
        '
        'txtbxManSecRoomNo
        '
        Me.txtbxManSecRoomNo.Location = New System.Drawing.Point(542, 92)
        Me.txtbxManSecRoomNo.Name = "txtbxManSecRoomNo"
        Me.txtbxManSecRoomNo.Size = New System.Drawing.Size(186, 47)
        Me.txtbxManSecRoomNo.TabIndex = 13
        '
        'lblManSecRoomNo
        '
        Me.lblManSecRoomNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblManSecRoomNo.AutoSize = True
        Me.lblManSecRoomNo.Location = New System.Drawing.Point(535, 52)
        Me.lblManSecRoomNo.Name = "lblManSecRoomNo"
        Me.lblManSecRoomNo.Size = New System.Drawing.Size(173, 39)
        Me.lblManSecRoomNo.TabIndex = 12
        Me.lblManSecRoomNo.Text = "Room No."
        '
        'nudManSecGradeLevel
        '
        Me.nudManSecGradeLevel.Location = New System.Drawing.Point(242, 207)
        Me.nudManSecGradeLevel.Name = "nudManSecGradeLevel"
        Me.nudManSecGradeLevel.Size = New System.Drawing.Size(47, 47)
        Me.nudManSecGradeLevel.TabIndex = 27
        '
        'lblManSecGradeLevel
        '
        Me.lblManSecGradeLevel.AutoSize = True
        Me.lblManSecGradeLevel.Location = New System.Drawing.Point(170, 164)
        Me.lblManSecGradeLevel.Name = "lblManSecGradeLevel"
        Me.lblManSecGradeLevel.Size = New System.Drawing.Size(205, 39)
        Me.lblManSecGradeLevel.TabIndex = 9
        Me.lblManSecGradeLevel.Text = "Grade Level"
        '
        'txtbxManSecTeacherID
        '
        Me.txtbxManSecTeacherID.Location = New System.Drawing.Point(177, 330)
        Me.txtbxManSecTeacherID.MaxLength = 20
        Me.txtbxManSecTeacherID.Name = "txtbxManSecTeacherID"
        Me.txtbxManSecTeacherID.Size = New System.Drawing.Size(224, 47)
        Me.txtbxManSecTeacherID.TabIndex = 6
        '
        'lblManSecTeacherID
        '
        Me.lblManSecTeacherID.AutoSize = True
        Me.lblManSecTeacherID.Location = New System.Drawing.Point(170, 286)
        Me.lblManSecTeacherID.Name = "lblManSecTeacherID"
        Me.lblManSecTeacherID.Size = New System.Drawing.Size(187, 39)
        Me.lblManSecTeacherID.TabIndex = 5
        Me.lblManSecTeacherID.Text = "Teacher ID"
        '
        'txtbxManSecSectionName
        '
        Me.txtbxManSecSectionName.Location = New System.Drawing.Point(177, 94)
        Me.txtbxManSecSectionName.MaxLength = 20
        Me.txtbxManSecSectionName.Name = "txtbxManSecSectionName"
        Me.txtbxManSecSectionName.Size = New System.Drawing.Size(190, 47)
        Me.txtbxManSecSectionName.TabIndex = 4
        '
        'lblManSecSectionName
        '
        Me.lblManSecSectionName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblManSecSectionName.AutoSize = True
        Me.lblManSecSectionName.Location = New System.Drawing.Point(170, 52)
        Me.lblManSecSectionName.Name = "lblManSecSectionName"
        Me.lblManSecSectionName.Size = New System.Drawing.Size(235, 39)
        Me.lblManSecSectionName.TabIndex = 3
        Me.lblManSecSectionName.Text = "Section Name"
        '
        'lblSectionsList
        '
        Me.lblSectionsList.AutoSize = True
        Me.lblSectionsList.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSectionsList.ForeColor = System.Drawing.Color.White
        Me.lblSectionsList.Location = New System.Drawing.Point(28, 29)
        Me.lblSectionsList.Name = "lblSectionsList"
        Me.lblSectionsList.Size = New System.Drawing.Size(117, 25)
        Me.lblSectionsList.TabIndex = 2
        Me.lblSectionsList.Text = "Sections List"
        '
        'picWatermark
        '
        Me.picWatermark.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.picWatermark.Image = Global.CFLC.My.Resources.Resources.logo
        Me.picWatermark.Location = New System.Drawing.Point(30, 448)
        Me.picWatermark.Name = "picWatermark"
        Me.picWatermark.Size = New System.Drawing.Size(1208, 346)
        Me.picWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWatermark.TabIndex = 5
        Me.picWatermark.TabStop = False
        '
        'TeacherViewSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1568, 824)
        Me.Controls.Add(Me.pnlManSecContent)
        Me.Controls.Add(Me.pnlTeacherSidebar)
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "TeacherViewSection"
        Me.Text = "TeacherViewSection"
        Me.pnlTeacherSidebar.ResumeLayout(False)
        Me.flowButtons.ResumeLayout(False)
        Me.pnlManSecContent.ResumeLayout(False)
        Me.pnlManSecContent.PerformLayout()
        Me.grpSectionInfo.ResumeLayout(False)
        Me.grpSectionInfo.PerformLayout()
        CType(Me.nudManSecGradeLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWatermark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTeacherSidebar As Panel
    Friend WithEvents flowButtons As FlowLayoutPanel
    Friend WithEvents btnTeacherViewSection As Button
    Friend WithEvents btnTeacherViewStudents As Button
    Friend WithEvents btnViewAssignedSubjects As Button
    Friend WithEvents btnTeacherGenerateReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlManSecContent As Panel
    Friend WithEvents grpSectionInfo As GroupBox
    Friend WithEvents txtbxManSecBuildingName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbManSecLearningMode As ComboBox
    Friend WithEvents cmbManSecClassType As ComboBox
    Friend WithEvents lblManSecLearningMode As Label
    Friend WithEvents lblManSecClassType As Label
    Friend WithEvents txtbxManSecRoomNo As TextBox
    Friend WithEvents lblManSecRoomNo As Label
    Friend WithEvents nudManSecGradeLevel As NumericUpDown
    Friend WithEvents lblManSecGradeLevel As Label
    Friend WithEvents txtbxManSecTeacherID As TextBox
    Friend WithEvents lblManSecTeacherID As Label
    Friend WithEvents txtbxManSecSectionName As TextBox
    Friend WithEvents lblManSecSectionName As Label
    Friend WithEvents lblSectionsList As Label
    Friend WithEvents picWatermark As PictureBox
    Friend WithEvents ComboBoxTeacherFloorLevel As ComboBox
    Friend WithEvents ComboBoxFloorLevel As Label
End Class
