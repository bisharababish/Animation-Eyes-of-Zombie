Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Visible = True Then
            PictureBox2.Visible = True
            PictureBox1.Visible = False
        ElseIf PictureBox2.Visible = True Then
            PictureBox2.Visible = False
            PictureBox1.Visible = True

        End If

    End Sub
End Class
