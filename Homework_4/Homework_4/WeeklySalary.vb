
'calculate the weekly salary and commission rate for a sales person
'based on their weekly sales

Public Class WeeklySalary


    'initialize the constants
    Const COMMISSION_RATE As Decimal = 0.2
    Const BASE_SALARY As Decimal = 200.0
    Const QUOTA_SALES As Decimal = 500.0

    Private SalesPersonNameString As String
    Private WeeklySalesDecimal As Decimal
    Private CommissionDecimal As Decimal
    Private PayDecimal As Decimal

    'initialize the shared properties
    Private Shared TotalSalesDecimal As Decimal
    Private Shared TotalCommissionDecimal As Decimal
    Private Shared TotalPayDecimal As Decimal


    'Properties for Name (must not be blank), Weekly Sales (must not be < 0)
    Property Name As String
        Get
            Return SalesPersonNameString
        End Get
        Set(value As String)
            If (value <> "") Then
                SalesPersonNameString = value
            Else
                Throw New ArgumentNullException("Name cannot be empty")
            End If
        End Set
    End Property

    Property WeeklySales As Decimal
        Get
            Return WeeklySalesDecimal
        End Get
        Set(value As Decimal)
            If (value < 0) Then
                Throw New ArgumentOutOfRangeException("Sales should be POSITIVE")
            Else
                WeeklySalesDecimal = value
                TotalSalesDecimal += WeeklySalesDecimal
                FindPay(WeeklySalesDecimal)
            End If
        End Set
    End Property

    'Readonly properties for Commission and Pay
    ReadOnly Property Commission As Decimal
        Get
            Return CommissionDecimal
        End Get
    End Property

    ReadOnly Property Pay As Decimal
        Get
            Return PayDecimal
        End Get
    End Property

    ' Readonly properties Total Sales, Total Commission, Total Pay 
    ReadOnly Property TotalSales As Decimal
        Get
            Return TotalSalesDecimal
        End Get
    End Property

    ReadOnly Property TotalCommission As Decimal
        Get
            Return TotalCommissionDecimal
        End Get
    End Property


    ReadOnly Property TotalPay As Decimal
        Get
            Return TotalPayDecimal
        End Get
    End Property


    'subroutine to find pay of the sales person
    Private Sub FindPay(AmountSales As Decimal)
        PayDecimal = BASE_SALARY + CalculateCommission(AmountSales)
        TotalPayDecimal += PayDecimal

    End Sub
    'function to calculate commission based on sales person's sale
    Private Function CalculateCommission(SalesDecimal As Decimal)
        If (SalesDecimal >= QUOTA_SALES) Then
            CommissionDecimal = SalesDecimal * COMMISSION_RATE
        Else
            CommissionDecimal = 0
        End If
        TotalCommissionDecimal += CommissionDecimal
        Return CommissionDecimal
    End Function
    'default constructor
    Sub New()

    End Sub
    'overiding the constructor with salesperson's name and weeklysales
    Sub New(Name As String, Sales As Decimal)
        SalesPersonNameString = Name
        WeeklySales = Sales
        FindPay(Sales)
    End Sub
End Class
