Public Class Form1


    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Me.IsMdiContainer = True
        Form2.MdiParent = Me
        Form2.Show()


    End Sub

   

    Private Sub RojoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RojoToolStripMenuItem.Click
        Form2.colorLapiz = Brushes.Red

    End Sub

    Private Sub AmarilloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AmarilloToolStripMenuItem.Click
        Form2.colorLapiz = Brushes.Yellow
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        dlgAbrir.ShowDialog()
        Form2.PictureBox1.ImageLocation = (dlgAbrir.FileName)
        Me.IsMdiContainer = True
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
