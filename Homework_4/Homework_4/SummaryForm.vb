Public Class SummaryForm

    Dim SalaryOne As New WeeklySalary()
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub TotalSalesLabel_Click(sender As Object, e As EventArgs) Handles TotalSalesLabel.Click

    End Sub

    Private Sub SummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalPayLabel.Text = SalaryOne.TotalPay.ToString("C")
        TotalSalesLabel.Text = SalaryOne.TotalSales.ToString("C")
        TotolCommissionLabel.Text = SalaryOne.TotalCommission.ToString("C")

    End Sub
End Class