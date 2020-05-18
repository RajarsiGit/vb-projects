Public Class Form1
    Public Shared balance As Double
    Public Shared deposits As Integer
    Public Shared checks As Integer
    Public Shared totdeposit As Double
    Public Shared totcheck As Double
    Private Sub TransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionToolStripMenuItem.Click
        If RadioButton1.Checked = True Then
            If Val(TextBox1.Text) < 0 Then
                MessageBox.Show("Negative amount!", "Warning!")
                Exit Sub
            End If
            Deposit(TextBox1.Text)
        ElseIf RadioButton2.Checked = True Then
            If Val(TextBox1.Text) > balance Then
                MessageBox.Show("Insufficient Funds!", "Warning!")
                balance -= 10
                TextBox2.Text = balance
                Exit Sub
            End If
            Check(TextBox1.Text)
        ElseIf RadioButton3.Checked = True Then
            Service()
        End If
    End Sub

    Public Sub Deposit(ByVal amount As Double)
        balance += amount
        totdeposit += amount
        TextBox2.Text = balance
    End Sub

    Public Sub Check(ByVal amount As Double)
        balance -= amount
        totcheck += amount
        TextBox2.Text = balance
    End Sub

    Public Sub Service()
        balance -= 10
        TextBox2.Text = balance
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        MessageBox.Show("Total deposits: " + Str(deposits) + vbCrLf + "Total deposit amount: $ " + Str(totdeposit) + vbCrLf + "Total checks: " + Str(checks) + vbCrLf + "Total check amount: $ " + Str(totcheck), "Summary")
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = balance
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Label2.Font = New Font("Arial", 7.8, FontStyle.Bold)
        TextBox2.Font = New Font("Arial", 7.8, FontStyle.Bold)
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Label2.ForeColor = Color.Green
        TextBox2.ForeColor = Color.Green
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Program Name: " + Me.Text + vbCrLf + "Name: TBS Author", "About")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class