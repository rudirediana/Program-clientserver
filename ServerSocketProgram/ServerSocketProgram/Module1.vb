Imports System.Net.Sockets

Imports System.Text

Module Module1

    Sub Main()
        Console.Write("Buka PORT Anda: ")
        Dim _port As Integer = Console.ReadLine()

        Dim serverSocket As New TcpListener(_port)

        Dim requestCount As Integer

        Dim clientSocket As TcpClient

        'perintah buka server
        serverSocket.Start()

        msg("Port dibuka")

        clientSocket = serverSocket.AcceptTcpClient()

        msg("terima koneksi dari klien")

        requestCount = 0



        While (True)

            Try

                requestCount = requestCount + 1

                Dim networkStream As NetworkStream = clientSocket.GetStream()

                'byte dirubah ke string
                Dim bytesFrom(10024) As Byte

                networkStream.Read(bytesFrom, 0, CInt(clientSocket.ReceiveBufferSize))

                Dim dataFromClient As String = System.Text.Encoding.ASCII.GetString(bytesFrom)

                dataFromClient = dataFromClient.Substring(0, 25)

                'pesan masuk dari klien
                msg("pesan dari klien : " + dataFromClient)

                'meminta isi file 
                If dataFromClient = "minta file dong" Then
                    
                    Dim sendBytes As [Byte]() = IO.File.ReadAllBytes("D:\oop.txt")
                    networkStream.Write(sendBytes, 0, sendBytes.Length)

                    networkStream.Flush()


                Else
                    'merubah kode byte ke string
                    Dim serverResponse As String = "Server response : " + Convert.ToString(requestCount)

                    Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(serverResponse)

                    networkStream.Write(sendBytes, 0, sendBytes.Length)

                    networkStream.Flush()
                End If

            Catch ex As Exception



            End Try

        End While


        clientSocket.Close()

        serverSocket.Stop()

        msg("exit")

        Console.ReadLine()

    End Sub


    Sub msg(ByVal mesg As String)

        mesg.Trim()

        Console.WriteLine(" > " + mesg)

    End Sub


End Module
