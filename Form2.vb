Public Class Form2
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Show()
        Label1.Text = "Apenas um Hack de CS:GO"

        Button5.Hide()
        Button6.Hide()

        Button4.Show()

        Button4.Enabled = "True"
        Button4.Text = "Load CS:GO"

        Label7.Hide()
        Label8.Hide()

        Label5.Show()
        Label4.Show()
        Label4.Text = "Status: Online"
        Label4.ForeColor = Color.Green
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Show()
        Label1.Text = "Apenas um Hack de Valorant"

        Button4.Hide()
        Button6.Hide()

        Button5.Show()
        Button5.Enabled = "False"
        Button5.Text = "Load Valorant"

        Label7.Hide()
        Label8.Hide()

        Label5.Show()
        Label4.Show()
        Label4.Text = "Status: Desenvolvimento"
        Label4.ForeColor = Color.Orange
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Show()
        Label1.Text = "Apenas um Hack de Fortnite"

        Button4.Hide()
        Button5.Hide()

        Button6.Show()
        Button6.Enabled = "False"
        Button6.Text = "Load Fortnite"

        Label7.Hide()
        Label8.Hide()

        Label5.Show()
        Label4.Show()
        Label4.Text = "Status: Desatualizado"
        Label4.ForeColor = Color.Red
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        MessageBox.Show("Hack injetado com sucesso! Abra o CS:GO")
        Application.Exit()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Hide()
        Label1.Show()
        Label1.Text = "Não importa se você está no humor para destruir toda" & Environment.NewLine & "a equipe inimiga, ou quer apenas uma ligeira vantagem" & Environment.NewLine & "contra os outros, MayoCheats é a sua escolha. Nossos" & Environment.NewLine & "produtos são totalmente personalizáveis para melhorar" & Environment.NewLine & "sua experiência de jogo, tanto quanto você precisa."

        Label7.Text = "✅ " + DateTime.Now.ToLongDateString()
    End Sub
End Class