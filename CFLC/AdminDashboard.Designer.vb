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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.flowButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnBackToDashboard = New System.Windows.Forms.Button()
        Me.btnManageStudents = New System.Windows.Forms.Button()
        Me.btnManageTeachers = New System.Windows.Forms.Button()
        Me.btnManageSections = New System.Windows.Forms.Button()
        Me.btnManageSubjects = New System.Windows.Forms.Button()
        Me.btnManageEnrollments = New System.Windows.Forms.Button()
        Me.btnGenerateReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.PieChartMunicipalityList = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PanelForTotalEnrollmentChartDashboard = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChartTotalEnrollmentPerYear = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ComboBoxEnrollmentPerYearDashboard = New System.Windows.Forms.ComboBox()
        Me.PieChartStudentGenderList = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlTeacherListDashboard = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTeacherListDashboard = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
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
        CType(Me.PieChartMunicipalityList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelForTotalEnrollmentChartDashboard.SuspendLayout()
        CType(Me.ChartTotalEnrollmentPerYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PieChartStudentGenderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTeacherListDashboard.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
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
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(40, 49, 40, 49)
        Me.pnlSidebar.Size = New System.Drawing.Size(400, 1175)
        Me.pnlSidebar.TabIndex = 11
        '
        'flowButtons
        '
        Me.flowButtons.BackColor = System.Drawing.Color.Transparent
        Me.flowButtons.Controls.Add(Me.btnBackToDashboard)
        Me.flowButtons.Controls.Add(Me.btnManageStudents)
        Me.flowButtons.Controls.Add(Me.btnManageTeachers)
        Me.flowButtons.Controls.Add(Me.btnManageSections)
        Me.flowButtons.Controls.Add(Me.btnManageSubjects)
        Me.flowButtons.Controls.Add(Me.btnManageEnrollments)
        Me.flowButtons.Controls.Add(Me.btnGenerateReports)
        Me.flowButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowButtons.Location = New System.Drawing.Point(40, 49)
        Me.flowButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.flowButtons.Name = "flowButtons"
        Me.flowButtons.Size = New System.Drawing.Size(320, 1015)
        Me.flowButtons.TabIndex = 0
        Me.flowButtons.WrapContents = False
        '
        'btnBackToDashboard
        '
        Me.btnBackToDashboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBackToDashboard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBackToDashboard.Location = New System.Drawing.Point(75, 0)
        Me.btnBackToDashboard.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnBackToDashboard.Name = "btnBackToDashboard"
        Me.btnBackToDashboard.Size = New System.Drawing.Size(169, 55)
        Me.btnBackToDashboard.TabIndex = 10
        Me.btnBackToDashboard.Text = "Home"
        Me.btnBackToDashboard.UseVisualStyleBackColor = True
        '
        'btnManageStudents
        '
        Me.btnManageStudents.Location = New System.Drawing.Point(0, 77)
        Me.btnManageStudents.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnManageStudents.Name = "btnManageStudents"
        Me.btnManageStudents.Size = New System.Drawing.Size(320, 55)
        Me.btnManageStudents.TabIndex = 4
        Me.btnManageStudents.Text = "Manage Students"
        Me.btnManageStudents.UseVisualStyleBackColor = True
        '
        'btnManageTeachers
        '
        Me.btnManageTeachers.Location = New System.Drawing.Point(0, 154)
        Me.btnManageTeachers.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnManageTeachers.Name = "btnManageTeachers"
        Me.btnManageTeachers.Size = New System.Drawing.Size(320, 55)
        Me.btnManageTeachers.TabIndex = 5
        Me.btnManageTeachers.Text = "Manage Teachers"
        Me.btnManageTeachers.UseVisualStyleBackColor = True
        '
        'btnManageSections
        '
        Me.btnManageSections.Location = New System.Drawing.Point(0, 231)
        Me.btnManageSections.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnManageSections.Name = "btnManageSections"
        Me.btnManageSections.Size = New System.Drawing.Size(320, 55)
        Me.btnManageSections.TabIndex = 6
        Me.btnManageSections.Text = "Manage Sections"
        Me.btnManageSections.UseVisualStyleBackColor = True
        '
        'btnManageSubjects
        '
        Me.btnManageSubjects.Location = New System.Drawing.Point(0, 308)
        Me.btnManageSubjects.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnManageSubjects.Name = "btnManageSubjects"
        Me.btnManageSubjects.Size = New System.Drawing.Size(320, 55)
        Me.btnManageSubjects.TabIndex = 8
        Me.btnManageSubjects.Text = "Manage Subjects"
        Me.btnManageSubjects.UseVisualStyleBackColor = True
        '
        'btnManageEnrollments
        '
        Me.btnManageEnrollments.Location = New System.Drawing.Point(0, 385)
        Me.btnManageEnrollments.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnManageEnrollments.Name = "btnManageEnrollments"
        Me.btnManageEnrollments.Size = New System.Drawing.Size(320, 55)
        Me.btnManageEnrollments.TabIndex = 7
        Me.btnManageEnrollments.Text = "Manage Enrollments"
        Me.btnManageEnrollments.UseVisualStyleBackColor = True
        '
        'btnGenerateReports
        '
        Me.btnGenerateReports.Location = New System.Drawing.Point(0, 462)
        Me.btnGenerateReports.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.btnGenerateReports.Name = "btnGenerateReports"
        Me.btnGenerateReports.Size = New System.Drawing.Size(320, 55)
        Me.btnGenerateReports.TabIndex = 9
        Me.btnGenerateReports.Text = "Generate Reports"
        Me.btnGenerateReports.UseVisualStyleBackColor = True
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
        'pnlMainContent
        '
        Me.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlMainContent.Controls.Add(Me.PieChartMunicipalityList)
        Me.pnlMainContent.Controls.Add(Me.PanelForTotalEnrollmentChartDashboard)
        Me.pnlMainContent.Controls.Add(Me.ComboBoxEnrollmentPerYearDashboard)
        Me.pnlMainContent.Controls.Add(Me.PieChartStudentGenderList)
        Me.pnlMainContent.Controls.Add(Me.pnlTeacherListDashboard)
        Me.pnlMainContent.Controls.Add(Me.pnlSubjectListDashboard)
        Me.pnlMainContent.Controls.Add(Me.pnlStudentListDashboard)
        Me.pnlMainContent.Controls.Add(Me.PictureBox1)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(400, 0)
        Me.pnlMainContent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(1524, 1175)
        Me.pnlMainContent.TabIndex = 12
        '
        'PieChartMunicipalityList
        '
        Me.PieChartMunicipalityList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PieChartMunicipalityList.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PieChartMunicipalityList.BorderlineColor = System.Drawing.Color.ForestGreen
        Me.PieChartMunicipalityList.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.PieChartMunicipalityList.BorderlineWidth = 3
        ChartArea1.Name = "ChartArea1"
        Me.PieChartMunicipalityList.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.DarkSeaGreen
        Legend1.Name = "Legend1"
        Me.PieChartMunicipalityList.Legends.Add(Legend1)
        Me.PieChartMunicipalityList.Location = New System.Drawing.Point(76, 678)
        Me.PieChartMunicipalityList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PieChartMunicipalityList.Name = "PieChartMunicipalityList"
        Me.PieChartMunicipalityList.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.PieChartMunicipalityList.Series.Add(Series1)
        Me.PieChartMunicipalityList.Size = New System.Drawing.Size(827, 448)
        Me.PieChartMunicipalityList.TabIndex = 12
        Me.PieChartMunicipalityList.Text = "Chart1"
        Me.PieChartMunicipalityList.UseWaitCursor = True
        '
        'PanelForTotalEnrollmentChartDashboard
        '
        Me.PanelForTotalEnrollmentChartDashboard.BackColor = System.Drawing.Color.ForestGreen
        Me.PanelForTotalEnrollmentChartDashboard.Controls.Add(Me.Label8)
        Me.PanelForTotalEnrollmentChartDashboard.Controls.Add(Me.ChartTotalEnrollmentPerYear)
        Me.PanelForTotalEnrollmentChartDashboard.Location = New System.Drawing.Point(76, 359)
        Me.PanelForTotalEnrollmentChartDashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelForTotalEnrollmentChartDashboard.Name = "PanelForTotalEnrollmentChartDashboard"
        Me.PanelForTotalEnrollmentChartDashboard.Size = New System.Drawing.Size(467, 350)
        Me.PanelForTotalEnrollmentChartDashboard.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(133, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 39)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Enrollments"
        '
        'ChartTotalEnrollmentPerYear
        '
        Me.ChartTotalEnrollmentPerYear.BackColor = System.Drawing.Color.DarkGreen
        Me.ChartTotalEnrollmentPerYear.BorderlineColor = System.Drawing.Color.Green
        Me.ChartTotalEnrollmentPerYear.BorderSkin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ChartTotalEnrollmentPerYear.BorderSkin.BorderColor = System.Drawing.Color.AliceBlue
        Me.ChartTotalEnrollmentPerYear.BorderSkin.PageColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.ChartTotalEnrollmentPerYear.ChartAreas.Add(ChartArea2)
        Me.ChartTotalEnrollmentPerYear.Location = New System.Drawing.Point(4, 58)
        Me.ChartTotalEnrollmentPerYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChartTotalEnrollmentPerYear.Name = "ChartTotalEnrollmentPerYear"
        Me.ChartTotalEnrollmentPerYear.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Series2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal
        Series2.BackImageTransparentColor = System.Drawing.Color.Transparent
        Series2.BackSecondaryColor = System.Drawing.Color.Transparent
        Series2.BorderColor = System.Drawing.Color.Green
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.Green
        Series2.LabelBackColor = System.Drawing.Color.White
        Series2.LabelBorderColor = System.Drawing.Color.White
        Series2.MarkerBorderColor = System.Drawing.Color.White
        Series2.MarkerColor = System.Drawing.Color.White
        Series2.Name = "Series1"
        Me.ChartTotalEnrollmentPerYear.Series.Add(Series2)
        Me.ChartTotalEnrollmentPerYear.Size = New System.Drawing.Size(460, 289)
        Me.ChartTotalEnrollmentPerYear.TabIndex = 0
        Me.ChartTotalEnrollmentPerYear.Text = "Chart1"
        '
        'ComboBoxEnrollmentPerYearDashboard
        '
        Me.ComboBoxEnrollmentPerYearDashboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxEnrollmentPerYearDashboard.BackColor = System.Drawing.Color.DarkGreen
        Me.ComboBoxEnrollmentPerYearDashboard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEnrollmentPerYearDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxEnrollmentPerYearDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEnrollmentPerYearDashboard.FormattingEnabled = True
        Me.ComboBoxEnrollmentPerYearDashboard.Location = New System.Drawing.Point(1019, 772)
        Me.ComboBoxEnrollmentPerYearDashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxEnrollmentPerYearDashboard.Name = "ComboBoxEnrollmentPerYearDashboard"
        Me.ComboBoxEnrollmentPerYearDashboard.Size = New System.Drawing.Size(149, 34)
        Me.ComboBoxEnrollmentPerYearDashboard.TabIndex = 0
        '
        'PieChartStudentGenderList
        '
        Me.PieChartStudentGenderList.BackColor = System.Drawing.Color.DarkGreen
        Me.PieChartStudentGenderList.BorderlineColor = System.Drawing.Color.ForestGreen
        Me.PieChartStudentGenderList.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.PieChartStudentGenderList.BorderlineWidth = 3
        ChartArea3.Name = "ChartArea1"
        Me.PieChartStudentGenderList.ChartAreas.Add(ChartArea3)
        Legend2.BackColor = System.Drawing.Color.DarkSeaGreen
        Legend2.Name = "Legend1"
        Me.PieChartStudentGenderList.Legends.Add(Legend2)
        Me.PieChartStudentGenderList.Location = New System.Drawing.Point(585, 359)
        Me.PieChartStudentGenderList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PieChartStudentGenderList.Name = "PieChartStudentGenderList"
        Me.PieChartStudentGenderList.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.PieChartStudentGenderList.Series.Add(Series3)
        Me.PieChartStudentGenderList.Size = New System.Drawing.Size(477, 350)
        Me.PieChartStudentGenderList.TabIndex = 8
        Me.PieChartStudentGenderList.Text = "Chart1"
        '
        'pnlTeacherListDashboard
        '
        Me.pnlTeacherListDashboard.BackColor = System.Drawing.Color.ForestGreen
        Me.pnlTeacherListDashboard.Controls.Add(Me.PictureBox3)
        Me.pnlTeacherListDashboard.Controls.Add(Me.Panel3)
        Me.pnlTeacherListDashboard.Controls.Add(Me.lblTeacherListDashboard)
        Me.pnlTeacherListDashboard.Controls.Add(Me.Label9)
        Me.pnlTeacherListDashboard.Location = New System.Drawing.Point(596, 87)
        Me.pnlTeacherListDashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTeacherListDashboard.Name = "pnlTeacherListDashboard"
        Me.pnlTeacherListDashboard.Size = New System.Drawing.Size(467, 212)
        Me.pnlTeacherListDashboard.TabIndex = 7
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(17, 69)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(153, 130)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Green
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(467, 59)
        Me.Panel3.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(115, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 95)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(124, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 39)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Teacher List"
        '
        'lblTeacherListDashboard
        '
        Me.lblTeacherListDashboard.AutoSize = True
        Me.lblTeacherListDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherListDashboard.Location = New System.Drawing.Point(231, 98)
        Me.lblTeacherListDashboard.Name = "lblTeacherListDashboard"
        Me.lblTeacherListDashboard.Size = New System.Drawing.Size(69, 76)
        Me.lblTeacherListDashboard.TabIndex = 1
        Me.lblTeacherListDashboard.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(64, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 39)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Student List"
        '
        'pnlSubjectListDashboard
        '
        Me.pnlSubjectListDashboard.BackColor = System.Drawing.Color.ForestGreen
        Me.pnlSubjectListDashboard.Controls.Add(Me.PictureBox2)
        Me.pnlSubjectListDashboard.Controls.Add(Me.Panel2)
        Me.pnlSubjectListDashboard.Controls.Add(Me.lblSubjectListDashboard)
        Me.pnlSubjectListDashboard.Controls.Add(Me.Label7)
        Me.pnlSubjectListDashboard.Location = New System.Drawing.Point(1115, 89)
        Me.pnlSubjectListDashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSubjectListDashboard.Name = "pnlSubjectListDashboard"
        Me.pnlSubjectListDashboard.Size = New System.Drawing.Size(467, 212)
        Me.pnlSubjectListDashboard.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 70)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 129)
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
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(467, 59)
        Me.Panel2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 95)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "0"
        '
        'lblNameSubjectListDashboard
        '
        Me.lblNameSubjectListDashboard.AutoSize = True
        Me.lblNameSubjectListDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameSubjectListDashboard.Location = New System.Drawing.Point(124, 9)
        Me.lblNameSubjectListDashboard.Name = "lblNameSubjectListDashboard"
        Me.lblNameSubjectListDashboard.Size = New System.Drawing.Size(193, 39)
        Me.lblNameSubjectListDashboard.TabIndex = 0
        Me.lblNameSubjectListDashboard.Text = "Subject List"
        '
        'lblSubjectListDashboard
        '
        Me.lblSubjectListDashboard.AutoSize = True
        Me.lblSubjectListDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectListDashboard.Location = New System.Drawing.Point(236, 98)
        Me.lblSubjectListDashboard.Name = "lblSubjectListDashboard"
        Me.lblSubjectListDashboard.Size = New System.Drawing.Size(69, 76)
        Me.lblSubjectListDashboard.TabIndex = 1
        Me.lblSubjectListDashboard.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 39)
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
        Me.pnlStudentListDashboard.Location = New System.Drawing.Point(76, 86)
        Me.pnlStudentListDashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlStudentListDashboard.Name = "pnlStudentListDashboard"
        Me.pnlStudentListDashboard.Size = New System.Drawing.Size(467, 212)
        Me.pnlStudentListDashboard.TabIndex = 4
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
        'lblStudentListDashboard
        '
        Me.lblStudentListDashboard.AutoSize = True
        Me.lblStudentListDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentListDashboard.Location = New System.Drawing.Point(236, 98)
        Me.lblStudentListDashboard.Name = "lblStudentListDashboard"
        Me.lblStudentListDashboard.Size = New System.Drawing.Size(69, 76)
        Me.lblStudentListDashboard.TabIndex = 1
        Me.lblStudentListDashboard.Text = "0"
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
        Me.PictureBox1.Location = New System.Drawing.Point(413, 236)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(700, 570)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1175)
        Me.Controls.Add(Me.pnlMainContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.pnlSidebar.ResumeLayout(False)
        Me.flowButtons.ResumeLayout(False)
        Me.pnlMainContent.ResumeLayout(False)
        CType(Me.PieChartMunicipalityList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelForTotalEnrollmentChartDashboard.ResumeLayout(False)
        Me.PanelForTotalEnrollmentChartDashboard.PerformLayout()
        CType(Me.ChartTotalEnrollmentPerYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PieChartStudentGenderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTeacherListDashboard.ResumeLayout(False)
        Me.pnlTeacherListDashboard.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents pnlTeacherListDashboard As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTeacherListDashboard As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PieChartStudentGenderList As DataVisualization.Charting.Chart
    Friend WithEvents ChartTotalEnrollmentPerYear As DataVisualization.Charting.Chart
    Friend WithEvents PanelForTotalEnrollmentChartDashboard As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBoxEnrollmentPerYearDashboard As ComboBox
    Friend WithEvents PieChartMunicipalityList As DataVisualization.Charting.Chart
End Class
