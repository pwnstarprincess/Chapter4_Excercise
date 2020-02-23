Public Class Form1
    Private Sub analyzeButton_Click(sender As Object, e As EventArgs) Handles analyzeButton.Click

        Dim loanPrincipal, interestRate, durationMonths, paymentPerMonth, interestTotal As String
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
End Class
