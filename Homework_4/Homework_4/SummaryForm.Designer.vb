<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SalesLabel = New System.Windows.Forms.Label()
        Me.CommissionLabel = New System.Windows.Forms.Label()
        Me.PayLabel = New System.Windows.Forms.Label()
        Me.TotalSalesLabel = New System.Windows.Forms.Label()
        Me.TotolCommissionLabel = New System.Windows.Forms.Label()
        Me.TotalPayLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(500, 285)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(104, 32)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SalesLabel
        '
        Me.SalesLabel.AutoSize = True
        Me.SalesLabel.Location = New System.Drawing.Point(58, 59)
        Me.SalesLabel.Name = "SalesLabel"
        Me.SalesLabel.Size = New System.Drawing.Size(92, 20)
        Me.SalesLabel.TabIndex = 1
        Me.SalesLabel.Text = "Total Sales:"
        '
        'CommissionLabel
        '
        Me.CommissionLabel.AutoSize = True
        Me.CommissionLabel.Location = New System.Drawing.Point(58, 139)
        Me.CommissionLabel.Name = "CommissionLabel"
        Me.CommissionLabel.Size = New System.Drawing.Size(138, 20)
        Me.CommissionLabel.TabIndex = 2
        Me.CommissionLabel.Text = "Total Commission:"
        '
        'PayLabel
        '
        Me.PayLabel.AutoSize = True
        Me.PayLabel.Location = New System.Drawing.Point(58, 217)
        Me.PayLabel.Name = "PayLabel"
        Me.PayLabel.Size = New System.Drawing.Size(78, 20)
        Me.PayLabel.TabIndex = 3
        Me.PayLabel.Text = "Total Pay:"
        '
        'TotalSalesLabel
        '
        Me.TotalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalSalesLabel.Location = New System.Drawing.Point(223, 58)
        Me.TotalSalesLabel.Name = "TotalSalesLabel"
        Me.TotalSalesLabel.Size = New System.Drawing.Size(238, 41)
        Me.TotalSalesLabel.TabIndex = 4
        '
        'TotolCommissionLabel
        '
        Me.TotolCommissionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotolCommissionLabel.Location = New System.Drawing.Point(223, 128)
        Me.TotolCommissionLabel.Name = "TotolCommissionLabel"
        Me.TotolCommissionLabel.Size = New System.Drawing.Size(238, 41)
        Me.TotolCommissionLabel.TabIndex = 5
        '
        'TotalPayLabel
        '
        Me.TotalPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalPayLabel.Location = New System.Drawing.Point(223, 206)
        Me.TotalPayLabel.Name = "TotalPayLabel"
        Me.TotalPayLabel.Size = New System.Drawing.Size(238, 41)
        Me.TotalPayLabel.TabIndex = 6
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 349)
        Me.Controls.Add(Me.TotalPayLabel)
        Me.Controls.Add(Me.TotolCommissionLabel)
        Me.Controls.Add(Me.TotalSalesLabel)
        Me.Controls.Add(Me.PayLabel)
        Me.Controls.Add(Me.CommissionLabel)
        Me.Controls.Add(Me.SalesLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Name = "SummaryForm"
        Me.Text = "SummaryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents SalesLabel As Label
    Friend WithEvents CommissionLabel As Label
    Friend WithEvents PayLabel As Label
    Friend WithEvents TotalSalesLabel As Label
    Friend WithEvents TotolCommissionLabel As Label
    Friend WithEvents TotalPayLabel As Label
End Class
