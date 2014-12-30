Public Class Window

    Dim IPTemp As String
    Dim DataTemp As String

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

    Private Sub Ping_Click(sender As Object, e As EventArgs) Handles Ping.Click
        If (IPTemp <> "" And DataTemp <> "") Then
            MyUtilities.RunCommandCom("Ping", IPTemp, DataTemp)
        ElseIf (IPTemp = "" And DataTemp = "") Then
            MsgBox("Please Set the IP and Packet Size")
        ElseIf (IPTemp = "") Then
            MsgBox("Please Set IP")
        ElseIf (DataTemp = "") Then
            MsgBox("Please Set Packet Size")
        End If
    End Sub
End Class
Public Class MyUtilities
    Shared Sub RunCommandCom(command As String, arguments As String, packetSize As String)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If("/K", "/C") + " " + command + " " + arguments + " -l " + packetSize
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
    End Sub
End Class
