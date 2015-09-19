Imports System.Net.Sockets
Imports System.Text
Public Class Form1
    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        msg("Client Pengen bicara")
    End Sub

    Sub msg(ByVal mesg As String)
        TextBox1.Text = Environment.NewLine + " >> " + mesg
    End Sub

    Sub kirim_pesan()

        'kode merubah byte dan string
        Dim serverStream As NetworkStream = clientSocket.GetStream()
        Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(tb_message.Text)

        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        Dim inStream(10024) As Byte
        serverStream.Read(inStream, 0, CInt(clientSocket.ReceiveBufferSize))
        Dim returndata As String = System.Text.Encoding.ASCII.GetString(inStream)

        'respon dari server:
        me_respon_server.Text = returndata

        tb_message.Text = ""
        tb_message.Focus()
    End Sub

    Private Sub sb_connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sb_connect.Click
        Try

            'kode client connect to server:
            clientSocket.Connect(tb_ipaddress.Text, tb_port.Text)
            Label1.Text = "Client - Server Connected ..."


            'kirim pesan
            tb_message.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub sb_sendmessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sb_sendmessage.Click
        If be_file_path.Text = "" Then
            kirim_pesan()
        Else
            kirim_file()
        End If

    End Sub

    Private Sub tb_message_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_message.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            kirim_pesan()
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


