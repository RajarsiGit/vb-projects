Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Program Name: " + Me.Text + vbCrLf + "Name: TBS Author", "About")
    End Sub

    Private Sub TitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitleToolStripMenuItem.Click
        If Label1.Visible = False Then
            Label1.Visible = True
            TitleToolStripMenuItem.Checked = True
        Else
            Label1.Visible = False
            TitleToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub CountryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CountryToolStripMenuItem1.Click
        If Label2.Visible = False Then
            Label2.Visible = True
            CountryToolStripMenuItem1.Checked = True
        Else
            Label2.Visible = False
            CountryToolStripMenuItem1.Checked = False
        End If
    End Sub

    Private Sub ProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammerToolStripMenuItem.Click
        If Label3.Visible = False Then
            Label3.Visible = True
            ProgrammerToolStripMenuItem.Checked = True
        Else
            Label3.Visible = False
            ProgrammerToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub UnitedStatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitedStatesToolStripMenuItem.Click
        PictureBox1.Image = PictureBox2.Image
        UnitedStatesToolStripMenuItem.Checked = True
        CanadaToolStripMenuItem.Checked = False
        JapanToolStripMenuItem.Checked = False
        MexicoToolStripMenuItem.Checked = False
    End Sub

    Private Sub CanadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CanadaToolStripMenuItem.Click
        PictureBox1.Image = PictureBox3.Image
        UnitedStatesToolStripMenuItem.Checked = False
        CanadaToolStripMenuItem.Checked = True
        JapanToolStripMenuItem.Checked = False
        MexicoToolStripMenuItem.Checked = False
    End Sub

    Private Sub JapanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JapanToolStripMenuItem.Click
        PictureBox1.Image = PictureBox4.Image
        UnitedStatesToolStripMenuItem.Checked = False
        CanadaToolStripMenuItem.Checked = False
        JapanToolStripMenuItem.Checked = True
        MexicoToolStripMenuItem.Checked = False
    End Sub

    Private Sub MexicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MexicoToolStripMenuItem.Click
        PictureBox1.Image = PictureBox5.Image
        UnitedStatesToolStripMenuItem.Checked = False
        CanadaToolStripMenuItem.Checked = False
        JapanToolStripMenuItem.Checked = False
        MexicoToolStripMenuItem.Checked = True
    End Sub
End Class
