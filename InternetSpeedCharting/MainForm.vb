
Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Initialize(Me)
    End Sub

    Public Sub WriteToOutput(text As String)
        If txtOutput.InvokeRequired Then
            txtOutput.Invoke(Sub()
                                 txtOutput.Text = $"{text}{vbCrLf}{txtOutput.Text}"

                                 If txtOutput.Text.Length > 10000 Then
                                     txtOutput.Text = txtOutput.Text.Substring(0, 10000)
                                 End If
                             End Sub)
        Else
            txtOutput.Text = $"{text}{vbCrLf}{txtOutput.Text}"

            If txtOutput.Text.Length > 10000 Then
                txtOutput.Text = txtOutput.Text.Substring(0, 10000)
            End If
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Main.StartTesting(nudMinutes.Value)
        btnStop.Enabled = True
        btnStart.Enabled = False
        nudMinutes.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Main.StopTesting()
        btnStop.Enabled = False
        btnStart.Enabled = True
        nudMinutes.Enabled = True
    End Sub
End Class
