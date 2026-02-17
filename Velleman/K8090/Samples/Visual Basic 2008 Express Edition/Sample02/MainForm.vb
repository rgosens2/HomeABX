Public Class MainForm

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        'Change this port to reflect your settings
        K8090.Port = "COM17"

        If Not K8090.Connect() Then
            MessageBox.Show("Failed to connect")
        End If

    End Sub

    Private Sub K8090_CommandReceived(ByVal o As System.Object, _
        ByVal args As Velleman.Kits.CommandEventArgs) Handles K8090.CommandReceived

        ' Add the event to our list
        PacketList.Items.Add("Received event " + args.cmd.ToString())
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        ' Switch all relays on (this is identical to K8090.SwitchRelayOn(&HFF)
        K8090.SendCommand(Velleman.Kits.K8090Command.SwitchRelayOn, &H84, &H0, &H0)
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        ' Close our connection
        K8090.Disconnect()
    End Sub

End Class
