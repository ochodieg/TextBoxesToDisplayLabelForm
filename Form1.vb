Public Class Form1
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        Display()

    End Sub

    Sub Display()
        ' MsgBox("Go")
        DisplayLabel.Text = FirstNameTextBox.Text & vbNewLine & LastNameTextBox.Text & vbNewLine & EmailTextBox.Text


        If EmailTextBox.Text = "" Then

            CreateEmail()
        End If


    End Sub

    Sub CreateEmail()

        EmailTextBox.Text = FirstNameTextBox.Text & "." & LastNameTextBox.Text & "@gmail.com"




    End Sub


End Class
