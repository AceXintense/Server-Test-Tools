Public Class Window

    Dim IPTemp As String
    Dim DataTemp As Integer
    Dim ReqTemp As Integer

    Private Sub SetIP_Click(sender As Object, e As EventArgs) Handles SetIP.Click
        IPTemp = IP.Text
        MsgBox("Is this IP Correct? " & IPTemp)
    End Sub

    Private Sub SetPacket_Click(sender As Object, e As EventArgs) Handles SetPacket.Click
        DataTemp = DataPacket.Text()
        MsgBox("Is this Packet Size Correct? " & DataTemp & " Byte(s)")
    End Sub

    Private Sub Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Thanks for using Server Test Tools By AceXintense")
    End Sub

    Private Sub SetRequests_Click(sender As Object, e As EventArgs) Handles SetRequests.Click
        ReqTemp = AmmountRequests.Text
    End Sub

    Private Sub Ping_Click(sender As Object, e As EventArgs) Handles Ping.Click
        If (IPTemp <> "" And DataTemp <> 0 And ReqTemp <> 0 And UnReq.Checked = False) Then
            RunCommandCom("Ping", IPTemp, DataTemp, ReqTemp)
        ElseIf (IPTemp <> "" And DataTemp <> 0 And UnReq.Checked = True) Then
            RunCommandComUn("Ping", IPTemp, DataTemp)
        ElseIf (IPTemp = "" And DataTemp > -1 And ReqTemp > -1 And UnReq.Checked = False) Then
            MsgBox("Please Set the IP and Packet Size and Set the Ammount of Requests")
        ElseIf (IPTemp = "" And DataTemp > -1 And ReqTemp > -1 And UnReq.Checked = True) Then
            MsgBox("Please Set the IP and Packet Size")
        ElseIf (IPTemp = "") Then
            MsgBox("Please Set IP")
        ElseIf (DataTemp = 0) Then
            MsgBox("Please Set Packet Size Larger Than 0")
        ElseIf (ReqTemp = 0 And UnReq.Checked = False) Then
            MsgBox("Please Set Request Size Larger Than 0")
        End If
    End Sub

    Private Sub IPv4_CheckedChanged(sender As Object, e As EventArgs) Handles IPv4.CheckedChanged
        If (IPv4.Checked = True) Then
            IPv6.Checked = False
        End If
    End Sub

    Private Sub IPv6_CheckedChanged(sender As Object, e As EventArgs) Handles IPv6.CheckedChanged
        If (IPv6.Checked = True) Then
            IPv4.Checked = False
        End If
    End Sub
    Private Sub RunCommandCom(command As String, arguments As String, packetSize As String, requestAmmount As String)
        If (IPv4.Checked = True) Then
            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = " " + If("/K", "/C") + " " + command + " " + arguments + " -l " + packetSize + " -4 " + " -n " + requestAmmount
            pi.FileName = "cmd.exe"
            p.StartInfo = pi
            p.Start()
        ElseIf (IPv6.Checked = True) Then
            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = " " + If("/K", "/C") + " " + command + " " + arguments + " -l " + packetSize + " -6 " + " -n " + requestAmmount
            pi.FileName = "cmd.exe"
            p.StartInfo = pi
            p.Start()
        End If
    End Sub

    Private Sub RunCommandComUn(command As String, arguments As String, packetSize As String)
        If (IPv4.Checked = True) Then
            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = " " + If("/K", "/C") + " " + command + " " + arguments + " -l " + packetSize + " -4 " + " -t "
            pi.FileName = "cmd.exe"
            p.StartInfo = pi
            p.Start()
        ElseIf (IPv6.Checked = True) Then
            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = " " + If("/K", "/C") + " " + command + " " + arguments + " -l " + packetSize + " -6 " + " -t "
            pi.FileName = "cmd.exe"
            p.StartInfo = pi
            p.Start()
        End If
    End Sub

    Private Sub UnReq_CheckedChanged(sender As Object, e As EventArgs) Handles UnReq.CheckedChanged
        If (UnReq.Checked = True) Then
            SetRequests.Enabled = False
            AmmountRequests.Enabled = False
        ElseIf (UnReq.Checked = False) Then
            SetRequests.Enabled = True
            AmmountRequests.Enabled = True
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        IPTemp = ""
        DataTemp = 0
        ReqTemp = 0
        DataPacket.Text = "10"
        IP.Text = "192.168.0.1"
        AmmountRequests.Text = "10"
        IPv4.Checked = True
        IPv6.Checked = False
        UnReq.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
