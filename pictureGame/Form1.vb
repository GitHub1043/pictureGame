Public Class Form1
    Dim intPicture As Integer

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If intPicture = 1 And radOption1.Checked Then
            MessageBox.Show("Correct")
        Else
            MessageBox.Show("Wrong")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        intPicture = 2


        If intPicture = 1 Then
            picImage.Image = My.Resources.australia
            radOption1.Text = "Australia"
            radOption2.Text = "Costa Rica"
            radOption3.Text = "USA"
            radOption4.Text = "Italy"
        End If

        If intPicture = 2 Then
            picImage.Image = My.Resources.canada
            radOption1.Text = "USA"
            radOption2.Text = "Germany"
            radOption3.Text = "Canada"
            radOption4.Text = "England"
        End If

        If intPicture = 3 Then
            picImage.Image = My.Resources.costaRica
            radOption1.Text = "England"
            radOption2.Text = "Costa Rica"
            radOption3.Text = "Australia"
            radOption4.Text = "USA"
        End If

        If intPicture = 4 Then
            picImage.Image = My.Resources.england
            radOption1.Text = "England"
            radOption2.Text = "Germany"
            radOption3.Text = "USA"
            radOption4.Text = "Canada"
        End If

        If intPicture = 5 Then
            picImage.Image = My.Resources.germany
            radOption1.Text = "Greece"
            radOption2.Text = "Italy"
            radOption3.Text = "Germany"
            radOption4.Text = "Australia"
        End If

        If intPicture = 6 Then
            picImage.Image = My.Resources.greece
            radOption1.Text = "Greece"
            radOption2.Text = "Italy"
            radOption3.Text = "Australia"
            radOption4.Text = "USA"
        End If

        If intPicture = 7 Then
            picImage.Image = My.Resources.italy
            radOption1.Text = "Germany"
            radOption2.Text = "Costa Rica"
            radOption3.Text = "Canada"
            radOption4.Text = "Italy"
        End If

        If intPicture = 8 Then
            picImage.Image = My.Resources.usa
            radOption1.Text = "Canada"
            radOption2.Text = "USA"
            radOption3.Text = "Germany"
            radOption4.Text = "England"
        End If

    End Sub
End Class