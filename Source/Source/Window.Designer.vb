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
        Me.Ping.Location = New System.Drawing.Point(115, 67)
        Me.Ping.Name = "Ping"
        Me.Ping.Size = New System.Drawing.Size(75, 23)
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
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(198, 94)
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

End Class
