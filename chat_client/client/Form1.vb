Imports System.Net.Sockets
Imports System.Text
Public Class Form1
    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream
    Dim readData As String
    Dim infiniteCounter As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles bt_kirim.Click
        Dim outStream As Byte() = _
        System.Text.Encoding.ASCII.GetBytes(tb_message.Text) ' + "$")
        serverStream.Write(outStream, 0, outStream.Length)
        tb_message.Text = ""
        serverStream.Flush()

    End Sub

    Private Sub msg()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf msg))
        Else
            Memo_roomchat.Text = Memo_roomchat.Text + Environment.NewLine + " >> " + readData
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles Button2.Click
        readData = "Conected to Chat Server ..."
        msg()
        clientSocket.Connect(tb_ipserver.Text, tb_port.Text)
        Label2.Text = "Client Socket - Server Connected ..."
        serverStream = clientSocket.GetStream()

        Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(tb_nama.Text) ' + "$")
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf getMessage)
        ctThread.Start()
    End Sub

    Private Sub getMessage()
        For infiniteCounter = 1 To 2
            infiniteCounter = 1
            serverStream = clientSocket.GetStream()

            Dim buffSize As Long
            Dim inStream(10024) As Byte
            buffSize = clientSocket.ReceiveBufferSize
            serverStream.Read(inStream, 0, CLng(buffSize))
            'serverStream.Read(inStream, 0, CInt(clientSocket.ReceiveBufferSize)) '(buffSize))
            Dim returndata As String = _
            System.Text.Encoding.ASCII.GetString(inStream)
            readData = "" + returndata
            msg()
        Next
    End Sub

    Private Sub sb_sendmessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sb_sendmessage.Click
        If be_file_path.Text = "" Then
            getMessage()
        Else
            kirim_file()
        End If

    End Sub
    
    Private Sub be_file_path_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles be_file_path.ButtonClick
        Dim opendialog As New OpenFileDialog
        If opendialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            be_file_path.Text = opendialog.FileName
        End If
    End Sub
    
    Private Sub be_file_path_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles be_file_path.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            kirim_file()
        End If
    End Sub

    Sub kirim_file()

        Dim serverStream As NetworkStream = clientSocket.GetStream()
        Dim outStream As Byte() = IO.File.ReadAllBytes(be_file_path.Text)
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        be_file_path.Text = ""
        be_file_path.Focus()
    End Sub


    
End Class
