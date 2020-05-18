Public Class Form1
    Public Shared totbooks As Integer
    Public Shared totreaders As Integer
    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MessageBox.Show("Program Name: Library" + vbCrLf + "Name: TBS Author", "About")
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Label3.Font = New Font("Arial", 7.8, FontStyle.Bold)
        TextBox3.Font = New Font("Arial", 7.8, FontStyle.Bold)
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Label3.ForeColor = Color.Green
        TextBox3.ForeColor = Color.Green
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PointsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PointsToolStripMenuItem.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Name or Books missing!", "Data unavailable")
            Exit Sub
        End If
        Dim books As Integer = TextBox2.Text
        If books < 0 Then
            MessageBox.Show("Negative no of books!", "Warning!")
            Exit Sub
        End If
        Dim points As Integer = CalcPoints(books)
        TextBox3.Text = points
        totbooks += books
        totreaders += 1
        SummaryToolStripMenuItem.Enabled = True
    End Sub

    Private Function CalcPoints(ByVal books As Integer) As Integer
        If books > 6 Then
            Return ((books - 6) * 20) + 75
        ElseIf books > 3 Then
            Return ((books - 3) * 15) + 30
        Else
            Return (books * 10)
        End If
    End Function

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        MessageBox.Show("Average no of books read: " + Str(totbooks / totreaders), "Summary")
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Focus()
    End Sub
End Class