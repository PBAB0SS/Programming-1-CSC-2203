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
        Me.lbl_FicaTax = New System.Windows.Forms.Label()
        Me.lbl_FederalTax = New System.Windows.Forms.Label()
        Me.lbl_StateIncomeTax = New System.Windows.Forms.Label()
        Me.lbl_NetPay = New System.Windows.Forms.Label()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.lbl_Income = New System.Windows.Forms.Label()
        Me.txt_Income = New System.Windows.Forms.TextBox()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_FicaTax
        '
        Me.lbl_FicaTax.AutoSize = True
        Me.lbl_FicaTax.Location = New System.Drawing.Point(173, 442)
        Me.lbl_FicaTax.Name = "lbl_FicaTax"
        Me.lbl_FicaTax.Size = New System.Drawing.Size(161, 37)
        Me.lbl_FicaTax.TabIndex = 0
        Me.lbl_FicaTax.Text = "FICA Tax:"
        '
        'lbl_FederalTax
        '
        Me.lbl_FederalTax.AutoSize = True
        Me.lbl_FederalTax.Location = New System.Drawing.Point(173, 536)
        Me.lbl_FederalTax.Name = "lbl_FederalTax"
        Me.lbl_FederalTax.Size = New System.Drawing.Size(196, 37)
        Me.lbl_FederalTax.TabIndex = 1
        Me.lbl_FederalTax.Text = "Federal Tax:"
        '
        'lbl_StateIncomeTax
        '
        Me.lbl_StateIncomeTax.AutoSize = True
        Me.lbl_StateIncomeTax.Location = New System.Drawing.Point(173, 645)
        Me.lbl_StateIncomeTax.Name = "lbl_StateIncomeTax"
        Me.lbl_StateIncomeTax.Size = New System.Drawing.Size(275, 37)
        Me.lbl_StateIncomeTax.TabIndex = 2
        Me.lbl_StateIncomeTax.Text = "State Income Tax:"
        '
        'lbl_NetPay
        '
        Me.lbl_NetPay.AutoSize = True
        Me.lbl_NetPay.Location = New System.Drawing.Point(173, 737)
        Me.lbl_NetPay.Name = "lbl_NetPay"
        Me.lbl_NetPay.Size = New System.Drawing.Size(139, 37)
        Me.lbl_NetPay.TabIndex = 3
        Me.lbl_NetPay.Text = "Net Pay:"
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Location = New System.Drawing.Point(368, 64)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(337, 37)
        Me.lbl_Title.TabIndex = 4
        Me.lbl_Title.Text = "Income Tax Calculator"
        '
        'lbl_Income
        '
        Me.lbl_Income.AutoSize = True
        Me.lbl_Income.Location = New System.Drawing.Point(289, 218)
        Me.lbl_Income.Name = "lbl_Income"
        Me.lbl_Income.Size = New System.Drawing.Size(316, 37)
        Me.lbl_Income.TabIndex = 5
        Me.lbl_Income.Text = "Enter Annual Income"
        '
        'txt_Income
        '
        Me.txt_Income.Location = New System.Drawing.Point(717, 211)
        Me.txt_Income.Name = "txt_Income"
        Me.txt_Income.Size = New System.Drawing.Size(251, 44)
        Me.txt_Income.TabIndex = 6
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(898, 840)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(163, 80)
        Me.btn_Exit.TabIndex = 7
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(540, 830)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(165, 80)
        Me.btn_Clear.TabIndex = 8
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(163, 834)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(221, 76)
        Me.btn_Calculate.TabIndex = 9
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 991)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.txt_Income)
        Me.Controls.Add(Me.lbl_Income)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.lbl_NetPay)
        Me.Controls.Add(Me.lbl_StateIncomeTax)
        Me.Controls.Add(Me.lbl_FederalTax)
        Me.Controls.Add(Me.lbl_FicaTax)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_FicaTax As System.Windows.Forms.Label
    Friend WithEvents lbl_FederalTax As System.Windows.Forms.Label
    Friend WithEvents lbl_StateIncomeTax As System.Windows.Forms.Label
    Friend WithEvents lbl_NetPay As System.Windows.Forms.Label
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_Income As System.Windows.Forms.Label
    Friend WithEvents txt_Income As System.Windows.Forms.TextBox
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button

End Class
