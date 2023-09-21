Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Timer1.Stop()
            ProgressBar1.Hide()
            Timer2.Start()
            ProgressBar2.Show()
            Label2.Text = "Carregando..."
        Else
            ProgressBar1.PerformStep()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (ProgressBar2.Value = ProgressBar2.Maximum) Then
            Timer2.Stop()
            Me.Hide()
            Form2.Show()
        Else
            ProgressBar2.PerformStep()
        End If
    End Sub
End Class
