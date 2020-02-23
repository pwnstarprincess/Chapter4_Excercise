''Jennifer Pezzulo
''February 23, 2019
''Chapter 4 Excercise

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

    Private Sub ShowResults(monthly As Double, interest As Double)


        ''Output and format monthly payment and total interest to applicable textboxes
        monthlyPaymentTextBox.AppendText(monthly.ToString("$0,00.00"))
        totalInterestTextBox.AppendText(interest.ToString("$0,00.00"))

    End Sub

    Private Function InputValidator() As Boolean
        ''Check if input is numeric.  Display error message if it is not
        If (IsNumeric(monthsTextBox.Text) And IsNumeric(principalTextBox.Text) And IsNumeric(interestRateTextBox.Text)) Then
            Return True

        Else
            MessageBox.Show("The ammount of loan, interest rate, and duration in months must be a number",
            "Input Validation Failed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

            Dim input As Control
            For Each input In Me.Controls
                If TypeOf input Is TextBox And Not IsNumeric(input.Text) Then
                    input.Text = ""
                End If
            Next

            Return False

        End If

    End Function

    Private Sub AnalyzeButton_Click(sender As Object, e As EventArgs) Handles analyzeButton.Click

        If InputValidator() Then
            ''Show Monthly Payment and total Interest paid
            ShowResults(CalcMonthlyPayment(GetPrincipal(), GetInterest(), GetMonths()), CalcTotalInterest(GetPrincipal(), GetInterest(), GetMonths()))

        End If

    End Sub

End Class
