<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Window
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SetIP = New System.Windows.Forms.Button()
        Me.Ping = New System.Windows.Forms.Button()
        Me.IP = New System.Windows.Forms.TextBox()
        Me.SetPacket = New System.Windows.Forms.Button()
        Me.DataPacket = New System.Windows.Forms.TextBox()
        Me.NetworkDataPacket = New System.Windows.Forms.Label()
        Me.IPv4 = New System.Windows.Forms.CheckBox()
        Me.IPv6 = New System.Windows.Forms.CheckBox()
        Me.AmmountRequests = New System.Windows.Forms.TextBox()
        Me.SetRequests = New System.Windows.Forms.Button()
        Me.UnReq = New System.Windows.Forms.CheckBox()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SetIP
        '
        Me.SetIP.Location = New System.Drawing.Point(9, 12)
        Me.SetIP.Name = "SetIP"
        Me.SetIP.Size = New System.Drawing.Size(100, 23)
        Me.SetIP.TabIndex = 0
        Me.SetIP.Text = "Set IP"
        Me.SetIP.UseVisualStyleBackColor = True
        '
        'Ping
        '
        Me.Ping.Location = New System.Drawing.Point(9, 90)
        Me.Ping.Name = "Ping"
        Me.Ping.Size = New System.Drawing.Size(111, 23)
        Me.Ping.TabIndex = 1
        Me.Ping.Text = "Ping IP"
        Me.Ping.UseVisualStyleBackColor = True
        '
        'IP
        '
        Me.IP.Location = New System.Drawing.Point(9, 41)
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(100, 20)
        Me.IP.TabIndex = 3
        Me.IP.Text = "192.168.0.1"
        Me.IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SetPacket
        '
        Me.SetPacket.Location = New System.Drawing.Point(115, 12)
        Me.SetPacket.Name = "SetPacket"
        Me.SetPacket.Size = New System.Drawing.Size(75, 23)
        Me.SetPacket.TabIndex = 4
        Me.SetPacket.Text = "Set Packet Size"
        Me.SetPacket.UseVisualStyleBackColor = True
        '
        'DataPacket
        '
        Me.DataPacket.Location = New System.Drawing.Point(115, 41)
        Me.DataPacket.Name = "DataPacket"
        Me.DataPacket.Size = New System.Drawing.Size(35, 20)
        Me.DataPacket.TabIndex = 5
        Me.DataPacket.Text = "10"
        Me.DataPacket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NetworkDataPacket
        '
        Me.NetworkDataPacket.AutoSize = True
        Me.NetworkDataPacket.Location = New System.Drawing.Point(151, 44)
        Me.NetworkDataPacket.Name = "NetworkDataPacket"
        Me.NetworkDataPacket.Size = New System.Drawing.Size(39, 13)
        Me.NetworkDataPacket.TabIndex = 6
        Me.NetworkDataPacket.Text = "Byte(s)"
        '
        'IPv4
        '
        Me.IPv4.AutoSize = True
        Me.IPv4.Checked = True
        Me.IPv4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.IPv4.Location = New System.Drawing.Point(126, 94)
        Me.IPv4.Name = "IPv4"
        Me.IPv4.Size = New System.Drawing.Size(78, 17)
        Me.IPv4.TabIndex = 7
        Me.IPv4.Text = "Force IPv4"
        Me.IPv4.UseVisualStyleBackColor = True
        '
        'IPv6
        '
        Me.IPv6.AutoSize = True
        Me.IPv6.Location = New System.Drawing.Point(218, 94)
        Me.IPv6.Name = "IPv6"
        Me.IPv6.Size = New System.Drawing.Size(78, 17)
        Me.IPv6.TabIndex = 8
        Me.IPv6.Text = "Force IPv6"
        Me.IPv6.UseVisualStyleBackColor = True
        '
        'AmmountRequests
        '
        Me.AmmountRequests.Location = New System.Drawing.Point(196, 42)
        Me.AmmountRequests.Name = "AmmountRequests"
        Me.AmmountRequests.Size = New System.Drawing.Size(100, 20)
        Me.AmmountRequests.TabIndex = 9
        Me.AmmountRequests.Text = "10"
        Me.AmmountRequests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SetRequests
        '
        Me.SetRequests.Location = New System.Drawing.Point(196, 12)
        Me.SetRequests.Name = "SetRequests"
        Me.SetRequests.Size = New System.Drawing.Size(100, 23)
        Me.SetRequests.TabIndex = 10
        Me.SetRequests.Text = "Set Requests"
        Me.SetRequests.UseVisualStyleBackColor = True
        '
        'UnReq
        '
        Me.UnReq.AutoSize = True
        Me.UnReq.Location = New System.Drawing.Point(126, 71)
        Me.UnReq.Name = "UnReq"
        Me.UnReq.Size = New System.Drawing.Size(170, 17)
        Me.UnReq.TabIndex = 11
        Me.UnReq.Text = "Send Packets Till Host Stops?"
        Me.UnReq.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(9, 64)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(111, 23)
        Me.Reset.TabIndex = 12
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(241, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Donate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(304, 151)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.UnReq)
        Me.Controls.Add(Me.SetRequests)
        Me.Controls.Add(Me.AmmountRequests)
        Me.Controls.Add(Me.IPv6)
        Me.Controls.Add(Me.IPv4)
        Me.Controls.Add(Me.NetworkDataPacket)
        Me.Controls.Add(Me.DataPacket)
        Me.Controls.Add(Me.SetPacket)
        Me.Controls.Add(Me.IP)
        Me.Controls.Add(Me.Ping)
        Me.Controls.Add(Me.SetIP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Window"
        Me.Text = "Server Test Tools"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SetIP As System.Windows.Forms.Button
    Friend WithEvents Ping As System.Windows.Forms.Button
    Friend WithEvents IP As System.Windows.Forms.TextBox
    Friend WithEvents SetPacket As System.Windows.Forms.Button
    Friend WithEvents DataPacket As System.Windows.Forms.TextBox
    Friend WithEvents NetworkDataPacket As System.Windows.Forms.Label
    Friend WithEvents IPv4 As System.Windows.Forms.CheckBox
    Friend WithEvents IPv6 As System.Windows.Forms.CheckBox
    Friend WithEvents AmmountRequests As System.Windows.Forms.TextBox
    Friend WithEvents SetRequests As System.Windows.Forms.Button
    Friend WithEvents UnReq As System.Windows.Forms.CheckBox
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
