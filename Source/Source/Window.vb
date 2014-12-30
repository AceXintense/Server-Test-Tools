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
            Process.Start("cmd.exe")
        End If
    End Sub
End Class
