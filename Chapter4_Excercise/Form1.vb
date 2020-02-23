Public Class Form1
    Private Sub analyzeButton_Click(sender As Object, e As EventArgs) Handles analyzeButton.Click

        Dim paymentPerMonth, interestTotal As String
        Dim principal, interest, months, monthlyPayment, totalInterest As Double

        ''Convert from string to double
        principal = Convert.ToDouble(principalTextBox.Text)
        interest = Convert.ToDouble(interestRateTextBox.Text) / 100
        months = Convert.ToDouble(monthsTextBox.Text)

        ''Calculate monthly payment and total interest
        monthlyPayment = (principal * (interest / 12)) / (1 - (1 + (interest / 12)) ^ (-months))
        totalInterest = months * monthlyPayment - principal

        ''Convert monthly payment and total interest to string and format
        paymentPerMonth = monthlyPayment.ToString("$0,00.00")
        interestTotal = totalInterest.ToString("$0,00.00")

        ''Output and format monthly payment and total interest to applicable textboxes
        monthlyPaymentTextBox.AppendText(paymentPerMonth)
        totalInterestTextBox.AppendText(interestTotal)


    End Sub

    Private Sub principalTextBox_TextChanged(sender As Object, e As EventArgs) Handles principalTextBox.TextChanged
        ''If the string is not empty then validate input with a try catch block
        If (Not String.IsNullOrEmpty(principalTextBox.Text)) Then

            ''Parse textbox as double
            Try
                Double.Parse(principalTextBox.Text)
            Catch ex As Exception
                ''Throw alert and clear textbox if not double
                MessageBox.Show("Please enter a number")
                principalTextBox.Clear()
            End Try

        End If
    End Sub

    Private Sub interestRateTextBox_TextChanged(sender As Object, e As EventArgs) Handles interestRateTextBox.TextChanged
        ''If the string is not empty then validate input with a try catch block
        If (Not String.IsNullOrEmpty(interestRateTextBox.Text)) Then

            ''Parse textbox as double
            Try
                Double.Parse(interestRateTextBox.Text)
            Catch ex As Exception
                ''Throw alert and clear textbox if not double
                MessageBox.Show("Please enter a number")
                interestRateTextBox.Clear()
            End Try

        End If
    End Sub

    Private Sub monthsTextBox_TextChanged(sender As Object, e As EventArgs) Handles monthsTextBox.TextChanged
        ''If the string is not empty then validate input with a try catch block
        If (Not String.IsNullOrEmpty(monthsTextBox.Text)) Then

            ''Parse textbox as double
            Try
                Double.Parse(monthsTextBox.Text)
            Catch ex As Exception
                ''Throw alert and clear textbox if not double
                MessageBox.Show("Please enter a number")
                monthsTextBox.Clear()
            End Try

        End If
    End Sub
End Class
