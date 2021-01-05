<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lblServiceStatus = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbComputerName = New System.Windows.Forms.TextBox()
        Me.tbTVID = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvConnInfo = New System.Windows.Forms.DataGridView()
        Me.ConnectedID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConnectedName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConnectedTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisconnectedTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoggedInUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConnectionType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvConnInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.tsslVersion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 268)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(555, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(446, 17)
        Me.ToolStripStatusLabel2.Spring = True
        '
        'tsslVersion
        '
        Me.tsslVersion.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.tsslVersion.Name = "tsslVersion"
        Me.tsslVersion.Size = New System.Drawing.Size(94, 17)
        Me.tsslVersion.Text = "v0.0.0 Build 0000"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(531, 253)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.lblServiceStatus)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.tbComputerName)
        Me.TabPage2.Controls.Add(Me.tbTVID)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(523, 227)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "General"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(251, 79)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(121, 35)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Stopp TeamViewer Service"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lblServiceStatus
        '
        Me.lblServiceStatus.AutoSize = True
        Me.lblServiceStatus.Location = New System.Drawing.Point(375, 117)
        Me.lblServiceStatus.Name = "lblServiceStatus"
        Me.lblServiceStatus.Size = New System.Drawing.Size(64, 13)
        Me.lblServiceStatus.TabIndex = 12
        Me.lblServiceStatus.Text = "Status: N/A"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(378, 63)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 51)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Restart TeamViewer Service"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(20, 127)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(215, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Example: X-PC-1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(378, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 51)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Start cmd remote"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "TV Pass.:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(136, 22)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Computer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TV ID:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Do magic!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbComputerName
        '
        Me.tbComputerName.Location = New System.Drawing.Point(73, 10)
        Me.tbComputerName.Name = "tbComputerName"
        Me.tbComputerName.Size = New System.Drawing.Size(136, 22)
        Me.tbComputerName.TabIndex = 1
        '
        'tbTVID
        '
        Me.tbTVID.Location = New System.Drawing.Point(73, 49)
        Me.tbTVID.Name = "tbTVID"
        Me.tbTVID.Size = New System.Drawing.Size(136, 22)
        Me.tbTVID.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvConnInfo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(523, 227)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Connection Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvConnInfo
        '
        Me.dgvConnInfo.AllowUserToAddRows = False
        Me.dgvConnInfo.AllowUserToDeleteRows = False
        Me.dgvConnInfo.AllowUserToResizeRows = False
        Me.dgvConnInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvConnInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ConnectedID, Me.ConnectedName, Me.ConnectedTime, Me.DisconnectedTime, Me.LoggedInUser, Me.ConnectionType, Me.NA})
        Me.dgvConnInfo.Location = New System.Drawing.Point(9, 3)
        Me.dgvConnInfo.Name = "dgvConnInfo"
        Me.dgvConnInfo.ReadOnly = True
        Me.dgvConnInfo.RowHeadersVisible = False
        Me.dgvConnInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConnInfo.ShowEditingIcon = False
        Me.dgvConnInfo.Size = New System.Drawing.Size(511, 215)
        Me.dgvConnInfo.TabIndex = 0
        '
        'ConnectedID
        '
        Me.ConnectedID.HeaderText = "ConnectedID"
        Me.ConnectedID.Name = "ConnectedID"
        Me.ConnectedID.ReadOnly = True
        Me.ConnectedID.Width = 99
        '
        'ConnectedName
        '
        Me.ConnectedName.HeaderText = "ConnectedName"
        Me.ConnectedName.Name = "ConnectedName"
        Me.ConnectedName.ReadOnly = True
        Me.ConnectedName.Width = 117
        '
        'ConnectedTime
        '
        Me.ConnectedTime.HeaderText = "ConnectedTime"
        Me.ConnectedTime.Name = "ConnectedTime"
        Me.ConnectedTime.ReadOnly = True
        Me.ConnectedTime.Width = 112
        '
        'DisconnectedTime
        '
        Me.DisconnectedTime.HeaderText = "DisconnectedTime"
        Me.DisconnectedTime.Name = "DisconnectedTime"
        Me.DisconnectedTime.ReadOnly = True
        Me.DisconnectedTime.Width = 126
        '
        'LoggedInUser
        '
        Me.LoggedInUser.HeaderText = "LoggedInUser"
        Me.LoggedInUser.Name = "LoggedInUser"
        Me.LoggedInUser.ReadOnly = True
        Me.LoggedInUser.Width = 104
        '
        'ConnectionType
        '
        Me.ConnectionType.HeaderText = "ConnectionType"
        Me.ConnectionType.Name = "ConnectionType"
        Me.ConnectionType.ReadOnly = True
        Me.ConnectionType.Width = 115
        '
        'NA
        '
        Me.NA.HeaderText = "N/A"
        Me.NA.Name = "NA"
        Me.NA.ReadOnly = True
        Me.NA.Width = 51
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 290)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GetTeamviewerID"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvConnInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvConnInfo As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tbComputerName As System.Windows.Forms.TextBox
    Friend WithEvents tbTVID As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lblServiceStatus As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ConnectedID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConnectedName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConnectedTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisconnectedTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoggedInUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConnectionType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NA As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
