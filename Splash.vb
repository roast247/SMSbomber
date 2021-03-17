Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(8)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Hide()
            SMSBomber.Show()
            Timer1.Stop()
        End If
    End Sub
End Class
