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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherDashboard))
        Me.pnlTeacherMainContent = New System.Windows.Forms.Panel()
        Me.PieChartTeacherStudent4psList = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PieChartTeacherStudentIndigenous = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PieChartTeacherStudentGenderList = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlTeacherStudentListDashboard = New System.Windows.Forms.Panel()
        Me.PictureBoxStudentListIcon = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTeacherStudentListDashboard = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlTeacherSidebar = New System.Windows.Forms.Panel()
        Me.PanelSideButton = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnTeacherViewSection = New System.Windows.Forms.Button()
        Me.btnTeacherViewStudents = New System.Windows.Forms.Button()
        Me.btnViewAssignedSubjects = New System.Windows.Forms.Button()
        Me.btnTeacherGenerateReports = New System.Windows.Forms.Button()
        Me.btnBackToDashboard = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlTeacherMainContent.SuspendLayout()
        CType(Me.PieChartTeacherStudent4psList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PieChartTeacherStudentIndigenous, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PieChartTeacherStudentGenderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTeacherStudentListDashboard.SuspendLayout()
        CType(Me.PictureBoxStudentListIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTeacherSidebar.SuspendLayout()
        Me.PanelSideButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTeacherMainContent
        '
        Me.pnlTeacherMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlTeacherMainContent.Controls.Add(Me.PieChartTeacherStudent4psList)
        Me.pnlTeacherMainContent.Controls.Add(Me.PieChartTeacherStudentIndigenous)
        Me.pnlTeacherMainContent.Controls.Add(Me.PieChartTeacherStudentGenderList)
        Me.pnlTeacherMainContent.Controls.Add(Me.pnlTeacherStudentListDashboard)
        Me.pnlTeacherMainContent.Controls.Add(Me.PictureBox1)
        Me.pnlTeacherMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTeacherMainContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlTeacherMainContent.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTeacherMainContent.Name = "pnlTeacherMainContent"
        Me.pnlTeacherMainContent.Size = New System.Drawing.Size(1924, 1175)
        Me.pnlTeacherMainContent.TabIndex = 13
        '
        'PieChartTeacherStudent4psList
        '
        Me.PieChartTeacherStudent4psList.BackColor = System.Drawing.Color.DarkGreen
        Me.PieChartTeacherStudent4psList.BorderlineColor = System.Drawing.Color.ForestGreen
        Me.PieChartTeacherStudent4psList.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.PieChartTeacherStudent4psList.BorderlineWidth = 3
        ChartArea1.Name = "ChartArea1"
        Me.PieChartTeacherStudent4psList.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.DarkSeaGreen
        Legend1.Name = "Legend1"
        Me.PieChartTeacherStudent4psList.Legends.Add(Legend1)
        Me.PieChartTeacherStudent4psList.Location = New System.Drawing.Point(486, 49)
        Me.PieChartTeacherStudent4psList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PieChartTeacherStudent4psList.Name = "PieChartTeacherStudent4psList"
        Me.PieChartTeacherStudent4psList.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.PieChartTeacherStudent4psList.Series.Add(Series1)
        Me.PieChartTeacherStudent4psList.Size = New System.Drawing.Size(477, 350)
        Me.PieChartTeacherStudent4psList.TabIndex = 16
        Me.PieChartTeacherStudent4psList.Text = "Chart1"
        '
        'PieChartTeacherStudentIndigenous
        '
        Me.PieChartTeacherStudentIndigenous.BackColor = System.Drawing.Color.DarkGreen
        Me.PieChartTeacherStudentIndigenous.BorderlineColor = System.Drawing.Color.ForestGreen
        Me.PieChartTeacherStudentIndigenous.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.PieChartTeacherStudentIndigenous.BorderlineWidth = 3
        ChartArea2.Name = "ChartArea1"
        Me.PieChartTeacherStudentIndigenous.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.DarkSeaGreen
        Legend2.Name = "Legend1"
        Me.PieChartTeacherStudentIndigenous.Legends.Add(Legend2)
        Me.PieChartTeacherStudentIndigenous.Location = New System.Drawing.Point(1041, 49)
        Me.PieChartTeacherStudentIndigenous.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PieChartTeacherStudentIndigenous.Name = "PieChartTeacherStudentIndigenous"
        Me.PieChartTeacherStudentIndigenous.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.PieChartTeacherStudentIndigenous.Series.Add(Series2)
        Me.PieChartTeacherStudentIndigenous.Size = New System.Drawing.Size(477, 350)
        Me.PieChartTeacherStudentIndigenous.TabIndex = 15
        Me.PieChartTeacherStudentIndigenous.Text = "Chart1"
        '
        'PieChartTeacherStudentGenderList
        '
        Me.PieChartTeacherStudentGenderList.BackColor = System.Drawing.Color.DarkGreen
        Me.PieChartTeacherStudentGenderList.BorderlineColor = System.Drawing.Color.ForestGreen
        Me.PieChartTeacherStudentGenderList.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.PieChartTeacherStudentGenderList.BorderlineWidth = 3
        ChartArea3.Name = "ChartArea1"
        Me.PieChartTeacherStudentGenderList.ChartAreas.Add(ChartArea3)
        Legend3.BackColor = System.Drawing.Color.DarkSeaGreen
        Legend3.Name = "Legend1"
        Me.PieChartTeacherStudentGenderList.Legends.Add(Legend3)
        Me.PieChartTeacherStudentGenderList.Location = New System.Drawing.Point(486, 463)
        Me.PieChartTeacherStudentGenderList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PieChartTeacherStudentGenderList.Name = "PieChartTeacherStudentGenderList"
        Me.PieChartTeacherStudentGenderList.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.PieChartTeacherStudentGenderList.Series.Add(Series3)
        Me.PieChartTeacherStudentGenderList.Size = New System.Drawing.Size(477, 350)
        Me.PieChartTeacherStudentGenderList.TabIndex = 14
        Me.PieChartTeacherStudentGenderList.Text = "Chart1"
        '
        'pnlTeacherStudentListDashboard
        '
        Me.pnlTeacherStudentListDashboard.BackColor = System.Drawing.Color.ForestGreen
        Me.pnlTeacherStudentListDashboard.Controls.Add(Me.PictureBoxStudentListIcon)
        Me.pnlTeacherStudentListDashboard.Controls.Add(Me.Panel6)
        Me.pnlTeacherStudentListDashboard.Controls.Add(Me.lblTeacherStudentListDashboard)
        Me.pnlTeacherStudentListDashboard.Controls.Add(Me.Label1)
        Me.pnlTeacherStudentListDashboard.Location = New System.Drawing.Point(1589, 70)
        Me.pnlTeacherStudentListDashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTeacherStudentListDashboard.Name = "pnlTeacherStudentListDashboard"
        Me.pnlTeacherStudentListDashboard.Size = New System.Drawing.Size(467, 212)
        Me.pnlTeacherStudentListDashboard.TabIndex = 5
        '
        'PictureBoxStudentListIcon
        '
        Me.PictureBoxStudentListIcon.Image = CType(resources.GetObject("PictureBoxStudentListIcon.Image"), System.Drawing.Image)
        Me.PictureBoxStudentListIcon.Location = New System.Drawing.Point(16, 70)
        Me.PictureBoxStudentListIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxStudentListIcon.Name = "PictureBoxStudentListIcon"
        Me.PictureBoxStudentListIcon.Size = New System.Drawing.Size(153, 130)
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
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(467, 59)
        Me.Panel6.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 95)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(124, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 39)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Student List"
        '
        'lblTeacherStudentListDashboard
        '
        Me.lblTeacherStudentListDashboard.AutoSize = True
        Me.lblTeacherStudentListDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherStudentListDashboard.Location = New System.Drawing.Point(236, 98)
        Me.lblTeacherStudentListDashboard.Name = "lblTeacherStudentListDashboard"
        Me.lblTeacherStudentListDashboard.Size = New System.Drawing.Size(69, 76)
        Me.lblTeacherStudentListDashboard.TabIndex = 1
        Me.lblTeacherStudentListDashboard.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student List"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.CFLC.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(924, 374)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 406)
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
        Me.pnlTeacherSidebar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTeacherSidebar.Name = "pnlTeacherSidebar"
        Me.pnlTeacherSidebar.Padding = New System.Windows.Forms.Padding(40, 49, 40, 49)
        Me.pnlTeacherSidebar.Size = New System.Drawing.Size(400, 1175)
        Me.pnlTeacherSidebar.TabIndex = 12
        '
        'PanelSideButton
        '
        Me.PanelSideButton.BackColor = System.Drawing.Color.Transparent
        Me.PanelSideButton.Controls.Add(Me.btnBackToDashboard)
        Me.PanelSideButton.Controls.Add(Me.btnTeacherViewSection)
        Me.PanelSideButton.Controls.Add(Me.btnTeacherViewStudents)
        Me.PanelSideButton.Controls.Add(Me.btnViewAssignedSubjects)
        Me.PanelSideButton.Controls.Add(Me.btnTeacherGenerateReports)
        Me.PanelSideButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideButton.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.PanelSideButton.Location = New System.Drawing.Point(40, 49)
        Me.PanelSideButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelSideButton.Name = "PanelSideButton"
        Me.PanelSideButton.Size = New System.Drawing.Size(320, 1015)
        Me.PanelSideButton.TabIndex = 0
        Me.PanelSideButton.WrapContents = False
        '
        'btnTeacherViewSection
        '
        Me.btnTeacherViewSection.Location = New System.Drawing.Point(0, 77)
        Me.btnTeacherViewSection.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnTeacherViewSection.Name = "btnTeacherViewSection"
        Me.btnTeacherViewSection.Size = New System.Drawing.Size(320, 55)
        Me.btnTeacherViewSection.TabIndex = 11
        Me.btnTeacherViewSection.Text = "View Section"
        Me.btnTeacherViewSection.UseVisualStyleBackColor = True
        '
        'btnTeacherViewStudents
        '
        Me.btnTeacherViewStudents.Location = New System.Drawing.Point(0, 154)
        Me.btnTeacherViewStudents.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnTeacherViewStudents.Name = "btnTeacherViewStudents"
        Me.btnTeacherViewStudents.Size = New System.Drawing.Size(320, 55)
        Me.btnTeacherViewStudents.TabIndex = 4
        Me.btnTeacherViewStudents.Text = "View Students"
        Me.btnTeacherViewStudents.UseVisualStyleBackColor = True
        '
        'btnViewAssignedSubjects
        '
        Me.btnViewAssignedSubjects.Location = New System.Drawing.Point(0, 231)
        Me.btnViewAssignedSubjects.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnViewAssignedSubjects.Name = "btnViewAssignedSubjects"
        Me.btnViewAssignedSubjects.Size = New System.Drawing.Size(320, 55)
        Me.btnViewAssignedSubjects.TabIndex = 5
        Me.btnViewAssignedSubjects.Text = "View Assigned Subjects"
        Me.btnViewAssignedSubjects.UseVisualStyleBackColor = True
        '
        'btnTeacherGenerateReports
        '
        Me.btnTeacherGenerateReports.Location = New System.Drawing.Point(0, 308)
        Me.btnTeacherGenerateReports.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnTeacherGenerateReports.Name = "btnTeacherGenerateReports"
        Me.btnTeacherGenerateReports.Size = New System.Drawing.Size(320, 55)
        Me.btnTeacherGenerateReports.TabIndex = 9
        Me.btnTeacherGenerateReports.Text = "Generate Reports"
        Me.btnTeacherGenerateReports.UseVisualStyleBackColor = True
        '
        'btnBackToDashboard
        '
        Me.btnBackToDashboard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBackToDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnBackToDashboard.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnBackToDashboard.Name = "btnBackToDashboard"
        Me.btnBackToDashboard.Size = New System.Drawing.Size(169, 55)
        Me.btnBackToDashboard.TabIndex = 12
        Me.btnBackToDashboard.Text = "Home"
        Me.btnBackToDashboard.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(40, 1064)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(320, 62)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'TeacherDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1175)
        Me.Controls.Add(Me.pnlTeacherSidebar)
        Me.Controls.Add(Me.pnlTeacherMainContent)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TeacherDashboard"
        Me.Text = "TeacherDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTeacherMainContent.ResumeLayout(False)
        CType(Me.PieChartTeacherStudent4psList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PieChartTeacherStudentIndigenous, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PieChartTeacherStudentGenderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTeacherStudentListDashboard.ResumeLayout(False)
        Me.pnlTeacherStudentListDashboard.PerformLayout()
        CType(Me.PictureBoxStudentListIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
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
    Friend WithEvents pnlTeacherStudentListDashboard As Panel
    Friend WithEvents PictureBoxStudentListIcon As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTeacherStudentListDashboard As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PieChartTeacherStudentIndigenous As DataVisualization.Charting.Chart
    Friend WithEvents PieChartTeacherStudentGenderList As DataVisualization.Charting.Chart
    Friend WithEvents PieChartTeacherStudent4psList As DataVisualization.Charting.Chart
End Class
