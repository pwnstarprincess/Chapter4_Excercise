<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.principalTextBox = New System.Windows.Forms.TextBox()
        Me.interestRateTextBox = New System.Windows.Forms.TextBox()
        Me.monthsTextBox = New System.Windows.Forms.TextBox()
        Me.monthlyPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.totalInterestTextBox = New System.Windows.Forms.TextBox()
        Me.analyzeButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'principalTextBox
        '
        Me.principalTextBox.Location = New System.Drawing.Point(250, 52)
        Me.principalTextBox.Name = "principalTextBox"
        Me.principalTextBox.Size = New System.Drawing.Size(130, 26)
        Me.principalTextBox.TabIndex = 0
        '
        'interestRateTextBox
        '
        Me.interestRateTextBox.Location = New System.Drawing.Point(250, 106)
        Me.interestRateTextBox.Name = "interestRateTextBox"
        Me.interestRateTextBox.Size = New System.Drawing.Size(130, 26)
        Me.interestRateTextBox.TabIndex = 1
        '
        'monthsTextBox
        '
        Me.monthsTextBox.Location = New System.Drawing.Point(250, 160)
        Me.monthsTextBox.Name = "monthsTextBox"
        Me.monthsTextBox.Size = New System.Drawing.Size(130, 26)
        Me.monthsTextBox.TabIndex = 2
        '
        'monthlyPaymentTextBox
        '
        Me.monthlyPaymentTextBox.Location = New System.Drawing.Point(250, 280)
        Me.monthlyPaymentTextBox.Name = "monthlyPaymentTextBox"
        Me.monthlyPaymentTextBox.ReadOnly = True
        Me.monthlyPaymentTextBox.Size = New System.Drawing.Size(130, 26)
        Me.monthlyPaymentTextBox.TabIndex = 4
        '
        'totalInterestTextBox
        '
        Me.totalInterestTextBox.Location = New System.Drawing.Point(250, 333)
        Me.totalInterestTextBox.Name = "totalInterestTextBox"
        Me.totalInterestTextBox.ReadOnly = True
        Me.totalInterestTextBox.Size = New System.Drawing.Size(130, 26)
        Me.totalInterestTextBox.TabIndex = 5
        '
        'analyzeButton
        '
        Me.analyzeButton.Location = New System.Drawing.Point(54, 208)
        Me.analyzeButton.Name = "analyzeButton"
        Me.analyzeButton.Size = New System.Drawing.Size(326, 53)
        Me.analyzeButton.TabIndex = 3
        Me.analyzeButton.Text = "Analyze"
        Me.analyzeButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ammount of Loan:  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Intereset rate:   "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "(such as 5.25)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Duration in Months "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Monthly payment:  "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total interest paid:  "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 402)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.analyzeButton)
        Me.Controls.Add(Me.totalInterestTextBox)
        Me.Controls.Add(Me.monthlyPaymentTextBox)
        Me.Controls.Add(Me.monthsTextBox)
        Me.Controls.Add(Me.interestRateTextBox)
        Me.Controls.Add(Me.principalTextBox)
        Me.Name = "Form1"
        Me.Text = "Car Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents principalTextBox As TextBox
    Friend WithEvents interestRateTextBox As TextBox
    Friend WithEvents monthsTextBox As TextBox
    Friend WithEvents monthlyPaymentTextBox As TextBox
    Friend WithEvents totalInterestTextBox As TextBox
    Friend WithEvents analyzeButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
