Public Class Form
    'This creates the varables that will be used over various objects in the program
    Dim Day As Integer = 1
    Dim Hold As String
    Dim Input As Integer
    Dim Average As Integer

    'This controls the enter button
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Takes the input and puts it in txtOne.txt a textbox below the input text box that formats like a list.
        txtOne.Text &= txtInput.Text & vbCrLf
        'Tryparse makes sure that all enteries that are entered are infact numaric enteries and if not the program allows the user to try again.
        If Integer.TryParse(txtInput.Text, Input) Then
            'Adds the input to the holding varable that is used to calcualate average later
            Hold += CInt(txtInput.Text)
            txtInput.Text = ""
            Day += 1
            'if it is past day 7 the program will provent the user from adding additional enteries and will calculate the average.
            If Day = 8 Then
                txtInput.Enabled = False
                Average = Hold / 7
                txtOutput.Text = Average
                txtInput.Text = ""
                'If it's not past day 7 the program will increment the day
            Else
                lblCounter.Text = Day
            End If
            'If not a numaric number a message displays telling the user what they have done wrong.
        Else
            MessageBox.Show("Please only use numaric numbers. Text will not be accepted for this program")
        End If


    End Sub

    'The close button 
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'This is the reset button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtInput.Text = ""
        Day = 1
        Input = 0
        Average = 0
        Hold = 0
        txtOne.Text = ""
        txtOutput.Text = ""
        txtInput.Enabled = True
        lblCounter.Text = Day
    End Sub
End Class
