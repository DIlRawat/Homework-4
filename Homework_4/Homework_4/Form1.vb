
Public Class Form1

    'create an weeklysalary object
    Dim SalaryOne As New WeeklySalary()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click
        'calculate pay when name and weekely sales entered
        'try and catch if salesperson name is not entered 
        'Or weekly sales Is Not entered in decimals
        Dim WeeklySalesEntered As Decimal
        Try
            SalaryOne.Name = SalesPersonNameTextBox.Text

            Try
                WeeklySalesEntered = Decimal.Parse(WeeklySalesTextBox.Text)

                'SalaryOne = New WeeklySalary(SalesPersonNameTextBox.Text, Decimal.Parse(WeeklySalesTextBox.Text))
                'pass the value enterd by user to the weeklysales property
                SalaryOne.WeeklySales = WeeklySalesEntered

                'access amount paid and commission then display on the firm
                AmountPaidTextBox.Text = SalaryOne.Pay.ToString("C")
                CommissionTextBox.Text = SalaryOne.Commission.ToString("C")

                'display the accumuated summary of 
                'totalsales, totalcommission, and totalpay
                SummaryForm.TotalSalesLabel.Text = SalaryOne.TotalSales.ToString("C")
                SummaryForm.TotolCommissionLabel.Text = SalaryOne.TotalCommission.ToString("C")
                SummaryForm.TotalPayLabel.Text = SalaryOne.TotalPay.ToString("C")

                'catch format exception
            Catch ex As FormatException
                MessageBox.Show("Please enter valid sales", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex2 As ArgumentOutOfRangeException
                MessageBox.Show(ex2.Message)
            End Try

        Catch ex As ArgumentNullException
            MessageBox.Show("Please Enter a name", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    'show about form when about is clicked from filemenu
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub
    'clear the form and focus on salesperson's name
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        SalesPersonNameTextBox.Clear()
        WeeklySalesTextBox.Clear()
        AmountPaidTextBox.Clear()
        CommissionTextBox.Clear()
        SalesPersonNameTextBox.Focus()
    End Sub
    'close the form
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        SummaryForm.Show()
        'SummaryForm.TotalPayLabel.Text = SalaryOne.TotalPay.ToString("C")
    End Sub


End Class
