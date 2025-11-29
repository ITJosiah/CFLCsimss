Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class TeacherViewSection
    Public Property IsEmbedded As Boolean = False
    Public Property TeacherID As String = ""

    Private Sub TeacherViewSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BackColor = Color.FromArgb(7, 77, 39)
        Me.Text = "Dashboard-Teacher"

        ' Set controls to read-only
        txtbxManSecSectionName.ReadOnly = True
        txtbxManSecSectionName.Enabled = False

        nudManSecGradeLevel.ReadOnly = True
        nudManSecGradeLevel.Enabled = False

        txtbxManSecTeacherID.ReadOnly = True
        txtbxManSecTeacherID.Enabled = False

        txtbxManSecRoomNo.ReadOnly = True
        txtbxManSecRoomNo.Enabled = False

        txtbxManSecBuildingName.ReadOnly = True
        txtbxManSecBuildingName.Enabled = False

        cmbManSecClassType.Enabled = False
        cmbManSecLearningMode.Enabled = False
        ComboBoxTeacherFloorLevel.Enabled = False

        ' Load teacher's section when form loads
        If Not String.IsNullOrEmpty(TeacherID) Then
            LoadTeacherSectionData()
        Else
            MessageBox.Show("TeacherID is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LoadTeacherSectionData()
        Try
            modDBx.openConn("cflc_db")
            Dim query As String = "SELECT SectionID, SectionName, GradeLevel, TeacherID, RoomNo, BuildingName, ClassType, LearningMode, FloorLevel FROM section WHERE TeacherID = @teacher_id"

            Using cmd As New MySqlCommand(query, modDBx.conn)
                cmd.Parameters.AddWithValue("@teacher_id", TeacherID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtbxManSecSectionName.Text = reader("SectionName").ToString()

                        Dim gradeLevelValue As Integer
                        If Integer.TryParse(reader("GradeLevel").ToString(), gradeLevelValue) Then
                            nudManSecGradeLevel.Value = gradeLevelValue
                        Else
                            nudManSecGradeLevel.Value = 0
                        End If

                        txtbxManSecTeacherID.Text = reader("TeacherID").ToString()
                        txtbxManSecRoomNo.Text = reader("RoomNo").ToString()
                        txtbxManSecBuildingName.Text = reader("BuildingName").ToString()
                        cmbManSecClassType.Text = reader("ClassType").ToString()
                        cmbManSecLearningMode.Text = reader("LearningMode").ToString()
                        ComboBoxTeacherFloorLevel.Text = reader("FloorLevel").ToString()
                    Else
                        MessageBox.Show("No section assigned to this teacher.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading section data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDBx.conn.State = ConnectionState.Open Then
                modDBx.conn.Close()
            End If
        End Try
    End Sub

    Private Sub ClearControls()
        txtbxManSecSectionName.Text = ""
        nudManSecGradeLevel.Value = 0
        txtbxManSecTeacherID.Text = ""
        txtbxManSecRoomNo.Text = ""
        txtbxManSecBuildingName.Text = ""
        cmbManSecClassType.Text = ""
        cmbManSecLearningMode.Text = ""
        ComboBoxTeacherFloorLevel.Text = ""
    End Sub

    Private Sub txtbxManSecTeacherID_TextChanged(sender As Object, e As EventArgs) Handles txtbxManSecTeacherID.TextChanged

    End Sub

    Private Sub lblManSecTeacherID_Click(sender As Object, e As EventArgs) Handles lblManSecTeacherID.Click

    End Sub

    Private Sub picWatermark_Click(sender As Object, e As EventArgs) Handles picWatermark.Click

    End Sub
End Class