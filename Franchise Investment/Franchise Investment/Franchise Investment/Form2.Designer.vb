<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstFranchise = New System.Windows.Forms.ListBox()
        Me.lstInvestmentCost = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Franchise"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Investment cost"
        '
        'lstFranchise
        '
        Me.lstFranchise.FormattingEnabled = True
        Me.lstFranchise.Location = New System.Drawing.Point(56, 144)
        Me.lstFranchise.Name = "lstFranchise"
        Me.lstFranchise.Size = New System.Drawing.Size(120, 173)
        Me.lstFranchise.TabIndex = 2
        '
        'lstInvestmentCost
        '
        Me.lstInvestmentCost.FormattingEnabled = True
        Me.lstInvestmentCost.Location = New System.Drawing.Point(284, 144)
        Me.lstInvestmentCost.Name = "lstInvestmentCost"
        Me.lstInvestmentCost.Size = New System.Drawing.Size(120, 173)
        Me.lstInvestmentCost.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Return to Application"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 549)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstInvestmentCost)
        Me.Controls.Add(Me.lstFranchise)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstFranchise As System.Windows.Forms.ListBox
    Friend WithEvents lstInvestmentCost As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
