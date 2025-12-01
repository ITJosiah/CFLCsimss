<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuperAdminAccessAllLogs
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
        Me.dgvLogs = New System.Windows.Forms.DataGridView()
        Me.txtbxSearchLogs = New System.Windows.Forms.TextBox()
        Me.lblSearchLogs = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlMainContent.SuspendLayout()
        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(300, 488)
        Me.pnlSidebar.TabIndex = 0
        '
        'pnlMainContent
        '
        Me.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlMainContent.Controls.Add(Me.dgvLogs)
        Me.pnlMainContent.Controls.Add(Me.txtbxSearchLogs)
        Me.pnlMainContent.Controls.Add(Me.lblSearchLogs)
        Me.pnlMainContent.Controls.Add(Me.lblTitle)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(300, 0)
        Me.pnlMainContent.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(729, 488)
        Me.pnlMainContent.TabIndex = 1
        '
        'dgvLogs
        '
        Me.dgvLogs.AllowUserToAddRows = False
        Me.dgvLogs.AllowUserToDeleteRows = False
        Me.dgvLogs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLogs.BackgroundColor = System.Drawing.Color.White
        Me.dgvLogs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogs.Location = New System.Drawing.Point(225, 149)
        Me.dgvLogs.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvLogs.Name = "dgvLogs"
        Me.dgvLogs.ReadOnly = True
        Me.dgvLogs.RowHeadersVisible = False
        Me.dgvLogs.RowHeadersWidth = 51
        Me.dgvLogs.RowTemplate.Height = 24
        Me.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLogs.Size = New System.Drawing.Size(750, 406)
        Me.dgvLogs.TabIndex = 3
        '
        'txtbxSearchLogs
        '
        Me.txtbxSearchLogs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbxSearchLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxSearchLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSearchLogs.Location = New System.Drawing.Point(492, 110)
        Me.txtbxSearchLogs.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbxSearchLogs.Name = "txtbxSearchLogs"
        Me.txtbxSearchLogs.Size = New System.Drawing.Size(226, 23)
        Me.txtbxSearchLogs.TabIndex = 2
        '
        'lblSearchLogs
        '
        Me.lblSearchLogs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSearchLogs.AutoSize = True
        Me.lblSearchLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchLogs.ForeColor = System.Drawing.Color.White
        Me.lblSearchLogs.Location = New System.Drawing.Point(505, 73)
        Me.lblSearchLogs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSearchLogs.Name = "lblSearchLogs"
        Me.lblSearchLogs.Size = New System.Drawing.Size(184, 17)
        Me.lblSearchLogs.TabIndex = 1
        Me.lblSearchLogs.Text = "Search by User ID or Event:"
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(486, 25)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(221, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Access All Logs"
        '
        'SuperAdminAccessAllLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 488)
        Me.Controls.Add(Me.pnlMainContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(800, 400)
        Me.Name = "SuperAdminAccessAllLogs"
        Me.Text = "Access All Logs"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlMainContent.ResumeLayout(False)
        Me.pnlMainContent.PerformLayout()
        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSearchLogs As Label
    Friend WithEvents txtbxSearchLogs As TextBox
    Friend WithEvents dgvLogs As DataGridView
End Class
