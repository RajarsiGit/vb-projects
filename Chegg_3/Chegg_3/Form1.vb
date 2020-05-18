Public Class Form1
    Public Const basepay As Double = 250.0
    Public Const quota As Double = 1000.0
    Public Const commrate As Double = 0.15
    Public Shared totsales As Double
    Public Shared totcomm As Double
    Public Shared totpay As Double
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Program Name: " + Me.Text + vbCrLf + "Name: TBS Author", "About")
    End Sub

    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Missing Name or Sales!", "Data unavailable")
            Exit Sub
        End If
        Dim sales As Double = TextBox1.Text
        If sales < 0 Then
            MessageBox.Show("Negative sales!", "Warning!")
            Exit Sub
        End If
        Dim commission As Double = CalcComm(sales)
        If commission > 0.0 Then
            Label4.Visible = True
            TextBox3.Visible = True
            TextBox3.Text = Format(Val(commission), "0.00")
            TextBox4.Text = Format(Val(basepay + commission), "0.00")
            totcomm += commission
            totpay += (basepay + commission)
        Else
            Label4.Visible = False
            TextBox3.Visible = False
            TextBox4.Text = Format(Val(basepay), "0.00")
            totpay += basepay
        End If
        totsales += sales
    End Sub

    Public Function CalcComm(ByVal sales As Double) As Double
        If sales >= quota Then
            Return sales * commrate
        Else
            Return 0.0
        End If
    End Function

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        MessageBox.Show("Total Sales: " + Format(totsales, "0.00") + vbCrLf + "Total Commission: " + Format(totcomm, "0.00") + vbCrLf + "Total Pay: " + Format(totpay, "0.00"), "Summary")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Label3.Font = New Font("Arial", 7.8, FontStyle.Bold)
        TextBox4.Font = New Font("Arial", 7.8, FontStyle.Bold)
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Label3.ForeColor = Color.Green
        TextBox4.ForeColor = Color.Green
    End Sub
End Class
