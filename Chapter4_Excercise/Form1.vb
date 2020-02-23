Public Class Form1
    Private Sub analyzeButton_Click(sender As Object, e As EventArgs) Handles analyzeButton.Click

        Dim loanPrincipal, interestRate, durationMonths, paymentPerMonth, interestTotal As String
        Dim principal, interest, months, monthlyPayment, totalInterest As Double

        ''Convert from string to double
        principal = Convert.ToDouble(principalTextBox)
        interest = Convert.ToDouble(interestRateTextBox)
        months = Convert.ToDouble(monthsTextBox)

        ''Calculate monthly payment and total interest
        monthlyPayment = (loanPrincipal * interest) / (1 - (1 + interest) ^ months)
        totalInterest = months * monthlyPayment - principal




    End Sub
End Class
