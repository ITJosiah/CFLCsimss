
Public Class TeacherDashboard
    Private currentContent As Form
    Public Property IsEmbedded As Boolean = False

    Private Sub TeacherDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties
        If Not IsEmbedded Then
            Me.WindowState = FormWindowState.Maximized
            Me.BackColor = Color.FromArgb(15, 56, 32)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        End If
        StyleSidebarButtons()
            PositionSidebarButtons()
            ShowHomeContent()
        End Sub

        Private Sub CenterLogo()
            If Not pnlTeacherMainContent.Controls.Contains(PictureBox1) Then
                Return
            End If

        Dim areaWidth As Integer = pnlTeacherMainContent.ClientSize.Width
        Dim areaHeight As Integer = pnlTeacherMainContent.ClientSize.Height

        PictureBox1.Left = (areaWidth - PictureBox1.Width) \ 2
        PictureBox1.Top = (areaHeight - PictureBox1.Height) \ 2
    End Sub

    Private Sub PositionSidebarButtons()
        ' Position sidebar buttons vertically with better spacing
        Dim sidebarWidth As Integer = 250
        Dim sidebarPadding As Integer = 10
        Dim buttonHeight As Integer = 70
        Dim buttonSpacing As Integer = 50
        Dim startTop As Integer = 60

        btnTeacherViewSection.Top = startTop
        btnTeacherViewSection.Left = sidebarPadding
        btnTeacherViewSection.Width = sidebarWidth - (sidebarPadding * 2)
        btnTeacherViewSection.Height = buttonHeight

        btnTeacherViewStudents.Top = btnTeacherViewSection.Bottom + buttonSpacing
        btnTeacherViewStudents.Left = sidebarPadding
        btnTeacherViewStudents.Width = sidebarWidth - (sidebarPadding * 2)
        btnTeacherViewStudents.Height = buttonHeight

        btnViewAssignedSubjects.Top = btnTeacherViewStudents.Bottom + buttonSpacing
        btnViewAssignedSubjects.Left = sidebarPadding
        btnViewAssignedSubjects.Width = sidebarWidth - (sidebarPadding * 2)
        btnViewAssignedSubjects.Height = buttonHeight

        btnTeacherGenerateReports.Top = btnTeacherViewStudents.Bottom + buttonSpacing
        btnTeacherGenerateReports.Left = sidebarPadding
        btnTeacherGenerateReports.Width = sidebarWidth - (sidebarPadding * 2)
        btnTeacherGenerateReports.Height = buttonHeight

        Dim logoutBottomPadding As Integer = 30
        btnLogout.Top = Me.ClientSize.Height - buttonHeight - logoutBottomPadding
        btnLogout.Left = sidebarPadding
        btnLogout.Width = sidebarWidth - (sidebarPadding * 2)
        btnLogout.Height = buttonHeight

    End Sub

    Private Sub AdminDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterLogo()
        PositionSidebarButtons()
    End Sub

    Private Sub StyleSidebarButtons()
        Dim buttons() As Button = {
                btnTeacherViewSection,
                btnTeacherViewStudents,
                btnViewAssignedSubjects,
                btnTeacherGenerateReports
            }

        For Each btn As Button In buttons
            btn.BackColor = Color.LightGray
            btn.ForeColor = Color.Black
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = Color.Gainsboro
            btn.Font = New Font(btn.Font.FontFamily, 15, FontStyle.Bold)
            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.Padding = New Padding(15, 0, 0, 0)
        Next

        btnLogout.BackColor = Color.Red
        btnLogout.ForeColor = Color.White
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btnLogout.Font = New Font(btnLogout.Font.FontFamily, 12, FontStyle.Bold)
        btnLogout.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub LoadContentForm(child As Form)
        If currentContent IsNot Nothing Then
            currentContent.Close()
            currentContent.Dispose()
            currentContent = Nothing
        End If

        ' Remove only the main content controls — do not remove the sidebar panel
        ClearMainContentExceptSidebar()

        currentContent = child
        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        child.Dock = DockStyle.Fill
        pnlTeacherMainContent.Controls.Add(child)
        child.Show()
    End Sub

    Private Sub ShowHomeContent()
        If currentContent IsNot Nothing Then
            currentContent.Close()
            currentContent.Dispose()
            currentContent = Nothing
        End If

        ' Remove only the main content controls — keep the sidebar intact
        ClearMainContentExceptSidebar()

        ' Re-add the logo to the main content area
        If Not pnlTeacherMainContent.Controls.Contains(PictureBox1) Then
            pnlTeacherMainContent.Controls.Add(PictureBox1)
        End If
        CenterLogo()
    End Sub

    ' Utility: remove everything from pnlTeacherMainContent except the left sidebar
    Private Sub ClearMainContentExceptSidebar()
        For i As Integer = pnlTeacherMainContent.Controls.Count - 1 To 0 Step -1
            Dim c As Control = pnlTeacherMainContent.Controls(i)
            If c Is pnlTeacherSidebar Then
                Continue For
            End If
            pnlTeacherMainContent.Controls.RemoveAt(i)
        Next
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            ExitFullScreen()
            Return True
        End If

        If keyData = Keys.F Then
            MakeItFullScreen()
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub ExitFullScreen()
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = False
    End Sub

    Private Sub MakeItFullScreen()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BringToFront()
    End Sub

    Private Sub btnTeacherViewSection_Click(sender As Object, e As EventArgs) Handles btnTeacherViewSection.Click
        Dim viewTeacherSectionsForms As New TeacherViewSection() With {
            .IsEmbedded = True
        }
        LoadContentForm(viewTeacherSectionsForms)
    End Sub
    Private Sub btnTeacherViewStudents_Click(sender As Object, e As EventArgs) Handles btnTeacherViewStudents.Click
        Dim viewTeacherStudentsForm As New TeacherViewStudents() With {
                .IsEmbedded = True
            }
        LoadContentForm(viewTeacherStudentsForm)
    End Sub

    Private Sub btnViewAssignedSubjects_Click(sender As Object, e As EventArgs) Handles btnViewAssignedSubjects.Click
        Dim viewTeacherAssignSubjectsForm As New TeacherViewAssignedSubjects() With {
            .IsEmbedded = True
        }
        LoadContentForm(viewTeacherAssignSubjectsForm)
    End Sub

    Private Sub btnTeacherGenerateReports_Click(sender As Object, e As EventArgs) Handles btnTeacherGenerateReports.Click

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
            ' Go back to Form1 (main menu)
            For Each form As Form In Application.OpenForms
                If form.Name = "Form1" Then
                    form.Show()
                    form.WindowState = FormWindowState.Maximized
                    Exit For
                End If
            Next
            Me.Close()
        End Sub


End Class