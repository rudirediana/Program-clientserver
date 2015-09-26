<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.sb_connect = New DevExpress.XtraEditors.SimpleButton
        Me.tb_port = New System.Windows.Forms.TextBox
        Me.tb_ipaddress = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tb_message = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.sb_sendmessage = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.be_file_path = New DevExpress.XtraEditors.ButtonEdit
        Me.me_respon_server = New DevExpress.XtraEditors.MemoEdit
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.be_file_path.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.me_respon_server.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(297, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Disconnect"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sb_connect)
        Me.GroupBox1.Controls.Add(Me.tb_port)
        Me.GroupBox1.Controls.Add(Me.tb_ipaddress)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 113)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "alamat server: "
        '
        'sb_connect
        '
        Me.sb_connect.Location = New System.Drawing.Point(77, 74)
        Me.sb_connect.Name = "sb_connect"
        Me.sb_connect.Size = New System.Drawing.Size(115, 23)
        Me.sb_connect.TabIndex = 14
        Me.sb_connect.Text = "sambungkan-->"
        '
        'tb_port
        '
        Me.tb_port.BackColor = System.Drawing.Color.Cornsilk
        Me.tb_port.Location = New System.Drawing.Point(77, 47)
        Me.tb_port.Name = "tb_port"
        Me.tb_port.Size = New System.Drawing.Size(100, 20)
        Me.tb_port.TabIndex = 13
        '
        'tb_ipaddress
        '
        Me.tb_ipaddress.BackColor = System.Drawing.Color.Cornsilk
        Me.tb_ipaddress.Location = New System.Drawing.Point(77, 23)
        Me.tb_ipaddress.Name = "tb_ipaddress"
        Me.tb_ipaddress.Size = New System.Drawing.Size(100, 20)
        Me.tb_ipaddress.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Port          :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "IP address:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tb_message)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(300, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 102)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kirim Pesan"
        '
        'tb_message
        '
        Me.tb_message.BackColor = System.Drawing.Color.Cornsilk
        Me.tb_message.Location = New System.Drawing.Point(21, 45)
        Me.tb_message.Name = "tb_message"
        Me.tb_message.Size = New System.Drawing.Size(219, 20)
        Me.tb_message.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Lime
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(21, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(219, 20)
        Me.TextBox1.TabIndex = 4
        '
        'sb_sendmessage
        '
        Me.sb_sendmessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sb_sendmessage.Location = New System.Drawing.Point(73, 51)
        Me.sb_sendmessage.Name = "sb_sendmessage"
        Me.sb_sendmessage.Size = New System.Drawing.Size(117, 23)
        Me.sb_sendmessage.TabIndex = 5
        Me.sb_sendmessage.Text = "Kirim-->"
        Me.sb_sendmessage.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.sb_sendmessage)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(20, 158)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 80)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kirim File:"
        '
        'be_file_path
        '
        Me.be_file_path.Location = New System.Drawing.Point(36, 177)
        Me.be_file_path.Name = "be_file_path"
        Me.be_file_path.Properties.Appearance.BackColor = System.Drawing.Color.Cornsilk
        Me.be_file_path.Properties.Appearance.Options.UseBackColor = True
        Me.be_file_path.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.be_file_path.Size = New System.Drawing.Size(219, 20)
        Me.be_file_path.TabIndex = 0
        '
        'me_respon_server
        '
        Me.me_respon_server.Location = New System.Drawing.Point(300, 159)
        Me.me_respon_server.Name = "me_respon_server"
        Me.me_respon_server.Properties.Appearance.BackColor = System.Drawing.Color.Cornsilk
        Me.me_respon_server.Properties.Appearance.Options.UseBackColor = True
        Me.me_respon_server.Size = New System.Drawing.Size(256, 96)
        Me.me_respon_server.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(584, 267)
        Me.Controls.Add(Me.be_file_path)
        Me.Controls.Add(Me.me_respon_server)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Client Socket Programming"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.be_file_path.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.me_respon_server.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents sb_connect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tb_port As System.Windows.Forms.TextBox
    Friend WithEvents tb_ipaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_message As System.Windows.Forms.TextBox
    Friend WithEvents sb_sendmessage As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents be_file_path As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents me_respon_server As DevExpress.XtraEditors.MemoEdit

End Class
