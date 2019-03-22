Public Class Form1

    Private Sub pullButton_Click(sender As Object, e As EventArgs) Handles pullButton.Click
        Randomize()
        Label1.Text = Int((Rnd() * 9) + 1)
        Label2.Text = Int((Rnd() * 9) + 1)
        Label3.Text = Int((Rnd() * 9) + 1)
        Label4.Text = Label4.Text - 1

        If Label4.Text = 0 Then
            MessageBox.Show("End of game. Thank you!", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If MessageBox.Show("End of game. Thank you!", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                Close()

            End If
        End If

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = 3
    End Sub

End Class
