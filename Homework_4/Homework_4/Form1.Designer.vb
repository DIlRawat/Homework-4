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
        Me.SalesPersonNameLabel = New System.Windows.Forms.Label()
        Me.SalesPersonNameTextBox = New System.Windows.Forms.TextBox()
        Me.WeekelySalesLabel = New System.Windows.Forms.Label()
        Me.WeeklySalesTextBox = New System.Windows.Forms.TextBox()
        Me.AmountPaidLabel = New System.Windows.Forms.Label()
        Me.CommissionLabel = New System.Windows.Forms.Label()
        Me.AmountPaidTextBox = New System.Windows.Forms.TextBox()
        Me.CommissionTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalesPersonNameLabel
        '
        Me.SalesPersonNameLabel.AutoSize = True
        Me.SalesPersonNameLabel.Location = New System.Drawing.Point(89, 88)
        Me.SalesPersonNameLabel.Name = "SalesPersonNameLabel"
        Me.SalesPersonNameLabel.Size = New System.Drawing.Size(156, 20)
        Me.SalesPersonNameLabel.TabIndex = 0
        Me.SalesPersonNameLabel.Text = "SalesPerson's Name"
        '
        'SalesPersonNameTextBox
        '
        Me.SalesPersonNameTextBox.Location = New System.Drawing.Point(288, 88)
        Me.SalesPersonNameTextBox.Name = "SalesPersonNameTextBox"
        Me.SalesPersonNameTextBox.Size = New System.Drawing.Size(240, 26)
        Me.SalesPersonNameTextBox.TabIndex = 1
        '
        'WeekelySalesLabel
        '
        Me.WeekelySalesLabel.AutoSize = True
        Me.WeekelySalesLabel.Location = New System.Drawing.Point(89, 156)
        Me.WeekelySalesLabel.Name = "WeekelySalesLabel"
        Me.WeekelySalesLabel.Size = New System.Drawing.Size(104, 20)
        Me.WeekelySalesLabel.TabIndex = 2
        Me.WeekelySalesLabel.Text = "Weekly Sales"
        '
        'WeeklySalesTextBox
        '
        Me.WeeklySalesTextBox.Location = New System.Drawing.Point(288, 156)
        Me.WeeklySalesTextBox.Name = "WeeklySalesTextBox"
        Me.WeeklySalesTextBox.Size = New System.Drawing.Size(100, 26)
        Me.WeeklySalesTextBox.TabIndex = 3
        '
        'AmountPaidLabel
        '
        Me.AmountPaidLabel.AutoSize = True
        Me.AmountPaidLabel.Location = New System.Drawing.Point(89, 313)
        Me.AmountPaidLabel.Name = "AmountPaidLabel"
        Me.AmountPaidLabel.Size = New System.Drawing.Size(100, 20)
        Me.AmountPaidLabel.TabIndex = 4
        Me.AmountPaidLabel.Text = "Amount Paid"
        '
        'CommissionLabel
        '
        Me.CommissionLabel.AutoSize = True
        Me.CommissionLabel.Location = New System.Drawing.Point(89, 367)
        Me.CommissionLabel.Name = "CommissionLabel"
        Me.CommissionLabel.Size = New System.Drawing.Size(95, 20)
        Me.CommissionLabel.TabIndex = 5
        Me.CommissionLabel.Text = "Commission"
        '
        'AmountPaidTextBox
        '
        Me.AmountPaidTextBox.Location = New System.Drawing.Point(288, 307)
        Me.AmountPaidTextBox.Name = "AmountPaidTextBox"
        Me.AmountPaidTextBox.ReadOnly = True
        Me.AmountPaidTextBox.Size = New System.Drawing.Size(100, 26)
        Me.AmountPaidTextBox.TabIndex = 6
        '
        'CommissionTextBox
        '
        Me.CommissionTextBox.Location = New System.Drawing.Point(288, 367)
        Me.CommissionTextBox.Name = "CommissionTextBox"
        Me.CommissionTextBox.ReadOnly = True
        Me.CommissionTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CommissionTextBox.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(685, 33)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PayToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PayToolStripMenuItem
        '
        Me.PayToolStripMenuItem.Name = "PayToolStripMenuItem"
        Me.PayToolStripMenuItem.Size = New System.Drawing.Size(190, 34)
        Me.PayToolStripMenuItem.Text = "Pay"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(190, 34)
        Me.SummaryToolStripMenuItem.Text = "Summary"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(190, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(153, 34)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 435)
        Me.Controls.Add(Me.SalesPersonNameLabel)
        Me.Controls.Add(Me.SalesPersonNameTextBox)
        Me.Controls.Add(Me.WeekelySalesLabel)
        Me.Controls.Add(Me.WeeklySalesTextBox)
        Me.Controls.Add(Me.CommissionTextBox)
        Me.Controls.Add(Me.AmountPaidTextBox)
        Me.Controls.Add(Me.CommissionLabel)
        Me.Controls.Add(Me.AmountPaidLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Comission Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalesPersonNameLabel As Label
    Friend WithEvents SalesPersonNameTextBox As TextBox
    Friend WithEvents WeekelySalesLabel As Label
    Friend WithEvents WeeklySalesTextBox As TextBox
    Friend WithEvents AmountPaidLabel As Label
    Friend WithEvents CommissionLabel As Label
    Friend WithEvents AmountPaidTextBox As TextBox
    Friend WithEvents CommissionTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
