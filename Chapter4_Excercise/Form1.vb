Public Class Form1
    Private Sub analyzeButton_Click(sender As Object, e As EventArgs) Handles analyzeButton.Click

        Dim loanAmmount, interestRate, durationMonths As String
        Dim loan, interest, months As Double

        ''Convert from string to double
        loan = Convert.ToDouble(loanTextBox)
        interest = Convert.ToDouble(interestRateTextBox)
        months = Convert.ToDouble(monthsTextBox)



    End Sub
End Class
