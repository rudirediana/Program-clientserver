Imports System.Net.Sockets
Imports System.Text
Module Module1
    Dim clientsList As New Hashtable

    Sub Main()
        Console.Write("buka port Anda : ")
        Dim port As Integer = Console.ReadLine()
        Dim serverSocket As New TcpListener(port)
        Dim clientSocket As TcpClient
        Dim infiniteCounter As Integer
        Dim counter As Integer

        serverSocket.Start()
        msg("minichat druds versi: 1.0.0 has started")
        msg("=======================================")
        msg("Chat Server Started ....")

        counter = 0
        infiniteCounter = 0
        For infiniteCounter = 1 To 2
            infiniteCounter = 1
            counter += 1
            clientSocket = serverSocket.AcceptTcpClient()

            Dim bytesFrom(10024) As Byte
            Dim dataFromClient As String

            Dim networkStream As NetworkStream = _
            clientSocket.GetStream()
            networkStream.Read(bytesFrom, 0, CInt(clientSocket.ReceiveBufferSize))
            dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom)
            dataFromClient = dataFromClient.Substring(0, 4) 'dataFromClient.IndexOf("$"))

            clientsList(dataFromClient) = clientSocket

            broadcast(dataFromClient + " Joined ", dataFromClient, False)

            msg(dataFromClient + " Joined chat room ")
            Dim client As New handleClinet
            client.startClient(clientSocket, dataFromClient, clientsList)
        Next

        clientSocket.Close()
        serverSocket.Stop()
        msg("exit")
        Console.ReadLine()
    End Sub

    Sub msg(ByVal mesg As String)
        mesg.Trim()
        Console.WriteLine(" >> " + mesg)
    End Sub
    Private Sub broadcast(ByVal msg As String, _
    ByVal uName As String, ByVal flag As Boolean)
        Dim Item As DictionaryEntry
        For Each Item In clientsList
            Dim broadcastSocket As TcpClient
            broadcastSocket = CType(Item.Value, TcpClient)
            Dim broadcastStream As NetworkStream = _
                    broadcastSocket.GetStream()
            Dim broadcastBytes As [Byte]()

            If flag = True Then
                broadcastBytes = Encoding.ASCII.GetBytes(uName + " says : " + msg)
            Else
                broadcastBytes = Encoding.ASCII.GetBytes(msg)
            End If

            broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length)
            broadcastStream.Flush()
        Next
    End Sub

    Public Class handleClinet
        Dim clientSocket As TcpClient
        Dim clNo As String
        Dim clientsList As Hashtable

        Public Sub startClient(ByVal inClientSocket As TcpClient, _
        ByVal clineNo As String, ByVal cList As Hashtable)
            Me.clientSocket = inClientSocket
            Me.clNo = clineNo
            Me.clientsList = cList
            Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf doChat)
            ctThread.Start()
        End Sub
        'Public Sub u_file as byte  
        'if dataFromClient ="file" then
        'u_file = IO.File.ReadAllBytes("E:oop.txt")
        'elseif dataFromClient ="1" then 
        'u_file = IO.File.ReadAllBytes("E:a.txt")
        'elseif dataFromCLient="2" then
        'u_file = IO.File.ReadAllBytes("E:b.txt")
        'end if
        'End Sub
        Private Sub doChat()
            'Dim infiniteCounter As Integer
            Dim requestCount As Integer
            'Dim bytesFrom(10024) As Byte
            Dim dataFromClient As String
            'Dim sendBytes As [Byte]()
            'Dim serverResponse As String
            Dim rCount As String
            requestCount = 0
            While (True)
                'infiniteCounter = 1 To 2
                '   infiniteCounter = 1
                Try
                    requestCount = requestCount + 1
                    Dim networkStream As NetworkStream = clientSocket.GetStream()

                    Dim bytesFrom(10024) As Byte
                    'networkStream.Read(bytesFrom, 0, CLng(clientSocket.ReceiveBufferSize))
                    networkStream.Read(bytesFrom, 0, CInt(clientSocket.ReceiveBufferSize))
                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom)
                    dataFromClient = dataFromClient.Substring(0, 100) 'dataFromClient.IndexOf("$"))
                    msg("From client - " + clNo + " : " + dataFromClient)
                    rCount = Convert.ToString(requestCount)

                    broadcast(dataFromClient, clNo, True)
                    'meminta isi file 
                    'If dataFromClient = "file" Then
                    If (bytesFrom(0) = 48) And (bytesFrom(1) = 0) Then
                        Dim sendBytes As [Byte]() = IO.File.ReadAllBytes("oop.txt")
                        networkStream.Write(sendBytes, 0, sendBytes.Length)
                        networkStream.Flush()

                        'ElseIf dataFromClient = "1" Then
                    ElseIf bytesFrom(0) = 49 And bytesFrom(1) = 0 Then
                        Dim sendBytes As [Byte]() = IO.File.ReadAllBytes("a.txt")
                        networkStream.Write(sendBytes, 0, sendBytes.Length)
                        networkStream.Flush()

                        'ElseIf dataFromClient = "2" Then
                    ElseIf bytesFrom(0) = 50 And bytesFrom(1) = 0 Then
                        Dim sendBytes As [Byte]() = IO.File.ReadAllBytes("b.txt")
                        networkStream.Write(sendBytes, 0, sendBytes.Length)
                        networkStream.Flush()
                        '              Else
                        '              Dim sendBytes As [Byte]() = msg("tidak ada dalam pilihan")
                        '              networkStream.Write(sendBytes, 0, sendBytes.Length)
                        '              networkStream.Flush()


                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End While

        End Sub

    End Class
End Module
