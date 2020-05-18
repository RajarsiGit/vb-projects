Public Class Form1
    Public Shared totperson As Integer
    Public Shared totpay As Double
    Public Shared totpiece As Integer

    Private Sub CalculatePayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatePayToolStripMenuItem.Click
        If TextBox1.Text = "" Or TextBox1.Text = "" Then
            MessageBox.Show("Name or piece missing!", "Data unavailable!")
            Exit Sub
        End If
        Dim piece As Integer = TextBox2.Text
        Dim rate As Double = FindPayRate(piece)
        Label4.Text = rate * piece
        totpay += Label4.Text
        totperson += 1
        totpiece += piece
        SummaryToolStripMenuItem.Enabled = True
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        MessageBox.Show("Total number of pieces: " + Str(totpiece) + vbCrLf + "Total pay: $ " + Str(totpay) + vbCrLf + "Average pay per person: $ " + Str(totpay / totperson), "Summary")
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label4.Text = "00.0"
        TextBox1.Focus()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Label3.Font = New Font("Arial", 7.8, FontStyle.Bold)
        Label4.Font = New Font("Arial", 7.8, FontStyle.Bold)
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Label3.ForeColor = Color.Green
        Label4.ForeColor = Color.Green
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Program Name: " + Me.Text + vbCrLf + "Name: TBS Author", "About")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Public Function FindPayRate(ByVal piece As Integer) As Double
        If piece >= 1 And piece < 200 Then
            Return 0.5
        ElseIf piece >= 200 And piece < 400 Then
            Return 0.55
        ElseIf piece >= 400 And piece < 600 Then
            Return 0.6
        ElseIf piece >= 600 Then
            Return 0.65
        Else
            Return -1
        End If
    End Function
End Class