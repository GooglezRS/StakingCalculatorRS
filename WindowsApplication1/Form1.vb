Public Class Form1
    Dim cur As Integer
    Dim losts As Integer
    Dim wins As Integer
    Dim streak As Integer

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox35.Text = Convert.ToInt32(bet1.Text) + Convert.ToInt32(bet2.Text) + Convert.ToInt32(bet3.Text) + Convert.ToInt32(bet4.Text) + Convert.ToInt32(bet5.Text) + Convert.ToInt32(bet6.Text) + Convert.ToInt32(bet7.Text) + Convert.ToInt32(bet8.Text) + Convert.ToInt32(bet9.Text) + Convert.ToInt32(bet10.Text) + Convert.ToInt32(bet11.Text) + Convert.ToInt32(bet12.Text) + Convert.ToInt32(bet13.Text) + Convert.ToInt32(bet14.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wins = 0
        losts = 0
        cur = 1
        streak = 0

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (cur = 1) Then
            losts = losts + 1
            streak = streak + 1
            lostLabel.Text = losts
        End If
        If (cur = 2) Then
            cur = 1
            losts = losts + 1
            streak = 1
            lostLabel.Text = losts
        End If
        streakLabel.Text = streak

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (cur = 2) Then
            wins = wins + 1
            streak = streak + 1
            winLabel.Text = wins
        End If
        If (cur = 1) Then
            cur = 2
            wins = wins + 1
            streak = 1
            winLabel.Text = wins

        End If
        streakLabel.Text = streak
    End Sub

End Class
