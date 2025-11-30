<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuperAdminConfiguration
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
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtbxDatabase = New System.Windows.Forms.TextBox()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.txtbxPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtbxUID = New System.Windows.Forms.TextBox()
        Me.lblUID = New System.Windows.Forms.Label()
        Me.txtbxServer = New System.Windows.Forms.TextBox()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMainContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMainContent
        '
        Me.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlMainContent.Controls.Add(Me.btnSave)
        Me.pnlMainContent.Controls.Add(Me.txtbxDatabase)
        Me.pnlMainContent.Controls.Add(Me.lblDatabase)
        Me.pnlMainContent.Controls.Add(Me.txtbxPassword)
        Me.pnlMainContent.Controls.Add(Me.lblPassword)
        Me.pnlMainContent.Controls.Add(Me.txtbxUID)
        Me.pnlMainContent.Controls.Add(Me.lblUID)
        Me.pnlMainContent.Controls.Add(Me.txtbxServer)
        Me.pnlMainContent.Controls.Add(Me.lblServer)
        Me.pnlMainContent.Controls.Add(Me.lblTitle)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(900, 600)
        Me.pnlMainContent.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(300, 50)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "System Configuration"
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServer.ForeColor = System.Drawing.Color.White
        Me.lblServer.Location = New System.Drawing.Point(200, 150)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(70, 25)
        Me.lblServer.TabIndex = 1
        Me.lblServer.Text = "Server:"
        '
        'txtbxServer
        '
        Me.txtbxServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxServer.Location = New System.Drawing.Point(300, 148)
        Me.txtbxServer.Name = "txtbxServer"
        Me.txtbxServer.Size = New System.Drawing.Size(300, 30)
        Me.txtbxServer.TabIndex = 2
        '
        'lblUID
        '
        Me.lblUID.AutoSize = True
        Me.lblUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUID.ForeColor = System.Drawing.Color.White
        Me.lblUID.Location = New System.Drawing.Point(200, 200)
        Me.lblUID.Name = "lblUID"
        Me.lblUID.Size = New System.Drawing.Size(50, 25)
        Me.lblUID.TabIndex = 3
        Me.lblUID.Text = "UID:"
        '
        'txtbxUID
        '
        Me.txtbxUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxUID.Location = New System.Drawing.Point(300, 198)
        Me.txtbxUID.Name = "txtbxUID"
        Me.txtbxUID.Size = New System.Drawing.Size(300, 30)
        Me.txtbxUID.TabIndex = 4
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(200, 250)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(98, 25)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password:"
        '
        'txtbxPassword
        '
        Me.txtbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPassword.Location = New System.Drawing.Point(300, 248)
        Me.txtbxPassword.Name = "txtbxPassword"
        Me.txtbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbxPassword.Size = New System.Drawing.Size(300, 30)
        Me.txtbxPassword.TabIndex = 6
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatabase.ForeColor = System.Drawing.Color.White
        Me.lblDatabase.Location = New System.Drawing.Point(200, 300)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(92, 25)
        Me.lblDatabase.TabIndex = 7
        Me.lblDatabase.Text = "Database:"
        '
        'txtbxDatabase
        '
        Me.txtbxDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDatabase.Location = New System.Drawing.Point(300, 298)
        Me.txtbxDatabase.Name = "txtbxDatabase"
        Me.txtbxDatabase.Size = New System.Drawing.Size(300, 30)
        Me.txtbxDatabase.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(350, 380)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(200, 50)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save Configuration"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'SuperAdminConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.pnlMainContent)
        Me.Name = "SuperAdminConfiguration"
        Me.Text = "System Configuration"
        Me.pnlMainContent.ResumeLayout(False)
        Me.pnlMainContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblServer As Label
    Friend WithEvents txtbxServer As TextBox
    Friend WithEvents lblUID As Label
    Friend WithEvents txtbxUID As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtbxPassword As TextBox
    Friend WithEvents lblDatabase As Label
    Friend WithEvents txtbxDatabase As TextBox
    Friend WithEvents btnSave As Button
End Class
