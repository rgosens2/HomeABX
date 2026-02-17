<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container
        Me.K8090 = New Velleman.Kits.K8090Board(Me.components)
        Me.btnConnect = New System.Windows.Forms.Button
        Me.PacketList = New System.Windows.Forms.ListBox
        Me.btnDisconnect = New System.Windows.Forms.Button
        Me.btnSend = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'K8090
        '
        Me.K8090.Port = "COM1"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(78, 33)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'PacketList
        '
        Me.PacketList.FormattingEnabled = True
        Me.PacketList.Location = New System.Drawing.Point(23, 126)
        Me.PacketList.Name = "PacketList"
        Me.PacketList.Size = New System.Drawing.Size(267, 199)
        Me.PacketList.TabIndex = 1
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(159, 33)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 2
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(118, 78)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 3
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 365)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.PacketList)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "MainForm"
        Me.Text = "K8090 - Sample01"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents K8090 As Velleman.Kits.K8090Board
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents PacketList As System.Windows.Forms.ListBox
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button

End Class
