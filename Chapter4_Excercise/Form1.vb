''Jennifer Pezzulo
''February 23, 2019
''Chapter 4 Excercise
''Git location:  https://github.com/pwnstarprincess/Chapter4_Excercise.git

Public Class Form1

    ''Function to Calculate Monthly Payment
    Private Function CalcMonthlyPayment(principal As Double, interest As Double, months As Double) As Double

        Return (principal * (interest / 12)) / (1 - (1 + (interest / 12)) ^ (-months))

    End Function

    ''Function to Calculate Total Interest
    Private Function CalcTotalInterest(principal As Double, interest As Double, months As Double) As Double

        Return months * CalcMonthlyPayment(principal, interest, months) - principal

    End Function

    ''Function to get Prinicpal as Double
    Private Function GetPrincipal() As Double

        Return Convert.ToDouble(principalTextBox.Text)

    End Function

    ''Function to get interest as Double
    Private Function GetInterest() As Double

        Return Convert.ToDouble(interestRateTextBox.Text) / 100

    End Function

    ''Function to get months as Double
    Private Function GetMonths() As Double

        Return Convert.ToDouble(monthsTextBox.Text)

    End Function
    ''Function to show the output results
    Private Sub ShowResults(monthly As Double, interest As Double)

        ''Output and format monthly payment and total interest to applicable textboxes
        monthlyPaymentTextBox.Text = (monthly.ToString("$0,00.00"))
        totalInterestTextBox.Text = (interest.ToString("$0,00.00"))

    End Sub
    ''function to validate input
    Private Function InputValid() As Boolean
        ''Check if input is numeric.  If it is, return true.
        If (IsNumeric(monthsTextBox.Text) And IsNumeric(principalTextBox.Text) And IsNumeric(interestRateTextBox.Text)) Then
            Return True
            ''If input is invalid, Show error message 
        Else
            MessageBox.Show("The ammount of loan, interest rate, and duration in months must be a number",
            "Input Validation Failed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            ''clear text in field containing incorrect data
            Dim input As Control
            For Each input In Me.Controls
                If TypeOf input Is TextBox And Not IsNumeric(input.Text) Then
                    input.Text = ""
                End If
            Next

            Return False

        End If

    End Function
    ''Subroutine for handling button click
    Private Sub AnalyzeButton_Click(sender As Object, e As EventArgs) Handles analyzeButton.Click
        ''If Input is valid
        If InputValid() Then
            ''Show Monthly Payment and total Interest paid
            ShowResults(CalcMonthlyPayment(GetPrincipal(), GetInterest(), GetMonths()), CalcTotalInterest(GetPrincipal(), GetInterest(), GetMonths()))

        End If

    End Sub

End Class
