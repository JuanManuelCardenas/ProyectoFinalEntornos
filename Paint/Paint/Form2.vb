Public Class Form2
    Public abajo = False
    Public colorLapiz = Brushes.Black

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If abajo = True Then


            PictureBox1.CreateGraphics.FillEllipse(colorLapiz, e.X, e.Y, 10, 10)

        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        abajo = True
        If e.Button = Windows.Forms.MouseButtons.Right Then
            colorLapiz = Brushes.White
        End If
    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        abajo = False
        If e.Button = Windows.Forms.MouseButtons.Right Then
            colorLapiz = Brushes.White
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class