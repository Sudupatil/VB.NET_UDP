Imports System.Net
Imports System.Text.Encoding
Imports System.Net.NetworkInformation

Public Class Form1

    Dim UDPsender As New Sockets.UdpClient(0)
    Dim UDPreceiver As New Sockets.UdpClient(2000)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxIP.Enabled = True
        TextBoxPort.Enabled = True
        ButtonApply.Enabled = True
        ButtonChange.Enabled = False
        RichTextBoxSend.Enabled = False
        ButtonSend.Enabled = False
        ButtonClearTexttoSend.Enabled = False

        UDPreceiver.Client.ReceiveTimeout = 1000
        UDPreceiver.Client.Blocking = False
        TxtHost.Text = Dns.GetHostName()
        TxtIotHost.Text = "esp32.local"

        Dim ipAddresses() As IPAddress = Dns.GetHostAddresses(TxtIotHost.Text)
        TextBoxIP.Text = ipAddresses(0).ToString
        TextBoxPort.Text = 2000
    End Sub

    Private Sub ButtonApply_Click(sender As Object, e As EventArgs) Handles ButtonApply.Click
        If TextBoxIP.Text = "" Or TextBoxPort.Text = "" Then
            MessageBox.Show("Destination IP and Destination Port cannot be empty !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        TextBoxIP.Enabled = False
        TextBoxPort.Enabled = False
        ButtonApply.Enabled = False
        ButtonChange.Enabled = True
        RichTextBoxSend.Enabled = True
        ButtonSend.Enabled = True
        ButtonClearTexttoSend.Enabled = True
        TimerRcv.Enabled = True
    End Sub

    Private Sub ButtonChange_Click(sender As Object, e As EventArgs) Handles ButtonChange.Click
        TextBoxIP.Enabled = True
        TextBoxPort.Enabled = True
        ButtonApply.Enabled = True
        ButtonChange.Enabled = False
        RichTextBoxSend.Enabled = False
        ButtonSend.Enabled = False
        ButtonClearTexttoSend.Enabled = False
    End Sub

    Private Sub ButtonClearTexttoSend_Click(sender As Object, e As EventArgs) Handles ButtonClearTexttoSend.Click
        RichTextBoxSend.Clear()
    End Sub

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click

        Dim sendbytes() As Byte = ASCII.GetBytes(RichTextBoxSend.Text)

        Dim ipAddresses() As IPAddress = Dns.GetHostAddresses(TxtIotHost.Text)
        TextBoxIP.Text = ipAddresses(0).ToString
        TextBoxPort.Text = 2000


        UDPsender.Connect(TextBoxIP.Text, TextBoxPort.Text)
        UDPsender.Send(sendbytes, sendbytes.Length)
        RichTextBoxSend.Text = ""

        'UDPsender.Connect("esp32.local", TextBoxPort.Text)
        'RTxt.Text = UDPsender.Send(sendbytes, sendbytes.Length)

        'RichTextBoxSend.Text = ""

        'Dim ep As IPEndPoint = New IPEndPoint(IPAddress.Parse(TextBoxIP.Text), Val(TextBoxPort.Text))
        'UDPsender.Connect(ep)
        'UDPsender.Send(sendbytes, sendbytes.Length)
        'RichTextBoxSend.Text = ""

    End Sub

    Private Sub ButtonClearTextReceived_Click(sender As Object, e As EventArgs) Handles ButtonClearTextReceived.Click
        RichTextBoxReceive.Clear()
    End Sub

    Private Sub TimerRcv_Tick(sender As Object, e As EventArgs) Handles TimerRcv.Tick
        Try
            If My.Computer.Network.IsAvailable = False Then
                Label1.Text = "DisConnected....."
            Else
                Label1.Text = "Connected"
            End If

            Label1.Visible = Not Label1.Visible

            Dim ep As IPEndPoint = New IPEndPoint(IPAddress.Any, Val(TextBoxPort.Text))
            Dim rcvbytes() As Byte = UDPreceiver.Receive(ep)

            'RichTextBoxReceive.Text = ASCII.GetString(rcvbytes)
            RichTextBoxReceive.Text += "From " & ep.Address.ToString & " : " & ASCII.GetString(rcvbytes) & Environment.NewLine
            'Use this to find out what IP the text is from.
        Catch ex As Exception

        End Try
    End Sub


    ' Check if internet is available
    Public Function IsInternetAvailable() As Boolean
        Dim result As Boolean = False

        Try
            ' Ping Google DNS server to test internet connectivity
            Dim ping As New Ping()
            Dim reply As PingReply = ping.Send("8.8.8.8")

            If reply.Status = IPStatus.Success Then
                result = True
            End If
        Catch ex As Exception
            ' Handle exception
        End Try

        Return result
    End Function

    Private Sub BtnStartRev_Click(sender As Object, e As EventArgs) Handles BtnStartRev.Click
        TimerRcv.Enabled = True
    End Sub


    'IPAddress[] addresses = Dns.GetHostAddresses(hostname);
    '    If (addresses.Length == 0)
    '    {
    '        Console.WriteLine("Could not resolve hostname: {0}", hostname);
    '        Return;
    '    }

    '    UdpClient udpClient = New UdpClient();
    '    udpClient.Connect(addresses[0], port);
End Class
