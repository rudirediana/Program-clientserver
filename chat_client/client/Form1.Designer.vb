<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bt_kirim = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.tb_message = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.tb_nama = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tb_ipserver = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tb_port = New System.Windows.Forms.TextBox
        Me.be_file_path = New DevExpress.XtraEditors.ButtonEdit
        Me.sb_sendmessage = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Memo_roomchat = New DevExpress.XtraEditors.MemoEdit
        CType(Me.be_file_path.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Memo_roomchat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_kirim
        '
        Me.bt_kirim.Location = New System.Drawing.Point(548, 185)
        Me.bt_kirim.Name = "bt_kirim"
        Me.bt_kirim.Size = New System.Drawing.Size(63, 25)
        Me.bt_kirim.TabIndex = 0
        Me.bt_kirim.Text = "kirim >>"
        Me.bt_kirim.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama           :"
        '
        'tb_message
        '
        Me.tb_message.Location = New System.Drawing.Point(299, 185)
        Me.tb_message.Multiline = True
        Me.tb_message.Name = "tb_message"
        Me.tb_message.Size = New System.Drawing.Size(243, 24)
        Me.tb_message.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(89, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Connect to Server"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tb_nama
        '
        Me.tb_nama.Location = New System.Drawing.Point(89, 6)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(123, 20)
        Me.tb_nama.TabIndex = 5
        Me.tb_nama.Text = "druds"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "disconnected >>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(299, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "kirim pesan :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "IP server      :"
        '
        'tb_ipserver
        '
        Me.tb_ipserver.Location = New System.Drawing.Point(89, 34)
        Me.tb_ipserver.Name = "tb_ipserver"
        Me.tb_ipserver.Size = New System.Drawing.Size(123, 20)
        Me.tb_ipserver.TabIndex = 9
        Me.tb_ipserver.Text = "127.0.0.1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Port             :"
        '
        'tb_port
        '
        Me.tb_port.Location = New System.Drawing.Point(89, 60)
        Me.tb_port.Name = "tb_port"
        Me.tb_port.Size = New System.Drawing.Size(123, 20)
        Me.tb_port.TabIndex = 11
        Me.tb_port.Text = "2345"
        '
        'be_file_path
        '
        Me.be_file_path.Location = New System.Drawing.Point(18, 182)
        Me.be_file_path.Name = "be_file_path"
        Me.be_file_path.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.be_file_path.Size = New System.Drawing.Size(194, 20)
        Me.be_file_path.TabIndex = 12
        '
        'sb_sendmessage
        '
        Me.sb_sendmessage.Location = New System.Drawing.Point(17, 208)
        Me.sb_sendmessage.Name = "sb_sendmessage"
        Me.sb_sendmessage.Size = New System.Drawing.Size(63, 25)
        Me.sb_sendmessage.TabIndex = 13
        Me.sb_sendmessage.Text = "kirim >>"
        Me.sb_sendmessage.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "kirim file :"
        '
        'Memo_roomchat
        '
        Me.Memo_roomchat.Location = New System.Drawing.Point(302, 39)
        Me.Memo_roomchat.Name = "Memo_roomchat"
        Me.Memo_roomchat.Size = New System.Drawing.Size(271, 124)
        Me.Memo_roomchat.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(641, 251)
        Me.Controls.Add(Me.Memo_roomchat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.sb_sendmessage)
        Me.Controls.Add(Me.be_file_path)
        Me.Controls.Add(Me.tb_port)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_ipserver)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_nama)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tb_message)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_kirim)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.be_file_path.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Memo_roomchat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_kirim As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_message As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tb_nama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_ipserver As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_port As System.Windows.Forms.TextBox
    Friend WithEvents be_file_path As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents sb_sendmessage As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Memo_roomchat As DevExpress.XtraEditors.MemoEdit

End Class
