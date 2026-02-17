Public Class MainForm

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click

        'Change this port to reflect your settings
        K8090.Port = "COM17"

        If K8090.Connect() Then
            K8090.ToggleRelay(&HFF) ' Toggle all relays ON
            K8090.Disconnect()
        End If

    End Sub
End Class
