Public Class MainWindow

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub GoogalToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoogalToolStripMenuItem.CheckStateChanged

    End Sub

    Private Sub GoogalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoogalToolStripMenuItem.Click
        Googal.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class
