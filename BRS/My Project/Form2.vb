Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Form2

    Private Const port As Integer = 1234
    Private Const host As String = "127.0.0.1"

    Private sendSocket As Socket
    Private receiveSocket As Socket

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sendSocket = New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
        receiveSocket = New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)

        Dim receiveEndpoint As New IPEndPoint(IPAddress.Any, port)
        receiveSocket.Bind(receiveEndpoint)

        ' Create a state object to pass to the callback method
        Dim state As New StateObject()
        state.workSocket = receiveSocket

        ' Start listening for incoming messages
        receiveSocket.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, AddressOf OnDataReceived, state)
    End Sub
    Private Sub OnDataReceived(ar As IAsyncResult)
        Try
            ' Retrieve the state object and socket from the asynchronous state object
            Dim state As StateObject = CType(ar.AsyncState, StateObject)
            Dim receiveSocket As Socket = state.workSocket

            ' Read data from the remote device
            Dim bytesRead As Integer = receiveSocket.EndReceive(ar)

            ' If there are bytes to read, process them
            If bytesRead > 0 Then
                ' Convert the data received to a string
                Dim receiveMessage As String = Encoding.ASCII.GetString(state.buffer, 0, bytesRead)

                ' Update the receive text box with the received message
                Invoke(Sub() txtReceive.Text &= Environment.NewLine + receiveMessage)

                ' Continue listening for incoming messages
                receiveSocket.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, AddressOf OnDataReceived, state)
            End If
        Catch ex As Exception
            ' Handle any exceptions that occur during data receive
            MessageBox.Show("Error receiving data: " & ex.Message)
        End Try
    End Sub

    Public Class StateObject
        Public Const BufferSize As Integer = 1024

        Public workSocket As Socket = Nothing
        Public buffer(BufferSize) As Byte
    End Class

End Class