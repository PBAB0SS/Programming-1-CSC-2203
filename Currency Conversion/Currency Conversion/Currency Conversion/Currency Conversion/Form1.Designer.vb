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
        Me.LBLCurrencyConversion = New System.Windows.Forms.Label()
        Me.LBLInstructions = New System.Windows.Forms.Label()
        Me.LBLUSDollars = New System.Windows.Forms.Label()
        Me.TBDollars = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LS1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LBLEuros = New System.Windows.Forms.Label()
        Me.LBLCanadianDollars = New System.Windows.Forms.Label()
        Me.LBLJapaneseYen = New System.Windows.Forms.Label()
        Me.LBLEurosAmount = New System.Windows.Forms.Label()
        Me.LBLCanadianDollarsAmount = New System.Windows.Forms.Label()
        Me.LBLJapaneseYenAmount = New System.Windows.Forms.Label()
        Me.TBDate = New System.Windows.Forms.TextBox()
        Me.LBLDate = New System.Windows.Forms.Label()
        Me.lbl_mex = New System.Windows.Forms.Label()
        Me.LBLMexicanPesosAmount = New System.Windows.Forms.Label()
        Me.BTNConvert = New System.Windows.Forms.Button()
        Me.BTNClear = New System.Windows.Forms.Button()
        Me.BTNExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLCurrencyConversion
        '
        Me.LBLCurrencyConversion.AutoSize = True
        Me.LBLCurrencyConversion.Location = New System.Drawing.Point(325, 48)
        Me.LBLCurrencyConversion.Name = "LBLCurrencyConversion"
        Me.LBLCurrencyConversion.Size = New System.Drawing.Size(129, 13)
        Me.LBLCurrencyConversion.TabIndex = 0
        Me.LBLCurrencyConversion.Text = "Currency Conversion Tool"
        '
        'LBLInstructions
        '
        Me.LBLInstructions.AutoSize = True
        Me.LBLInstructions.Location = New System.Drawing.Point(246, 111)
        Me.LBLInstructions.Name = "LBLInstructions"
        Me.LBLInstructions.Size = New System.Drawing.Size(347, 13)
        Me.LBLInstructions.TabIndex = 1
        Me.LBLInstructions.Text = "Enter the amount of US Dollars you wish to convert and the current date"
        '
        'LBLUSDollars
        '
        Me.LBLUSDollars.AutoSize = True
        Me.LBLUSDollars.Location = New System.Drawing.Point(268, 185)
        Me.LBLUSDollars.Name = "LBLUSDollars"
        Me.LBLUSDollars.Size = New System.Drawing.Size(57, 13)
        Me.LBLUSDollars.TabIndex = 2
        Me.LBLUSDollars.Text = "US Dollars"
        '
        'TBDollars
        '
        Me.TBDollars.Location = New System.Drawing.Point(458, 185)
        Me.TBDollars.Name = "TBDollars"
        Me.TBDollars.Size = New System.Drawing.Size(90, 20)
        Me.TBDollars.TabIndex = 3
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LS1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1034, 591)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'LS1
        '
        Me.LS1.Name = "LS1"
        Me.LS1.X1 = 219
        Me.LS1.X2 = 578
        Me.LS1.Y1 = 308
        Me.LS1.Y2 = 308
        '
        'LBLEuros
        '
        Me.LBLEuros.AutoSize = True
        Me.LBLEuros.Location = New System.Drawing.Point(268, 344)
        Me.LBLEuros.Name = "LBLEuros"
        Me.LBLEuros.Size = New System.Drawing.Size(34, 13)
        Me.LBLEuros.TabIndex = 5
        Me.LBLEuros.Text = "Euros"
        '
        'LBLCanadianDollars
        '
        Me.LBLCanadianDollars.AutoSize = True
        Me.LBLCanadianDollars.Location = New System.Drawing.Point(268, 390)
        Me.LBLCanadianDollars.Name = "LBLCanadianDollars"
        Me.LBLCanadianDollars.Size = New System.Drawing.Size(87, 13)
        Me.LBLCanadianDollars.TabIndex = 6
        Me.LBLCanadianDollars.Text = "Canadian Dollars"
        '
        'LBLJapaneseYen
        '
        Me.LBLJapaneseYen.AutoSize = True
        Me.LBLJapaneseYen.Location = New System.Drawing.Point(268, 437)
        Me.LBLJapaneseYen.Name = "LBLJapaneseYen"
        Me.LBLJapaneseYen.Size = New System.Drawing.Size(75, 13)
        Me.LBLJapaneseYen.TabIndex = 7
        Me.LBLJapaneseYen.Text = "Japanese Yen"
        '
        'LBLEurosAmount
        '
        Me.LBLEurosAmount.AutoSize = True
        Me.LBLEurosAmount.Location = New System.Drawing.Point(538, 344)
        Me.LBLEurosAmount.Name = "LBLEurosAmount"
        Me.LBLEurosAmount.Size = New System.Drawing.Size(0, 13)
        Me.LBLEurosAmount.TabIndex = 8
        '
        'LBLCanadianDollarsAmount
        '
        Me.LBLCanadianDollarsAmount.AutoSize = True
        Me.LBLCanadianDollarsAmount.Location = New System.Drawing.Point(538, 390)
        Me.LBLCanadianDollarsAmount.Name = "LBLCanadianDollarsAmount"
        Me.LBLCanadianDollarsAmount.Size = New System.Drawing.Size(0, 13)
        Me.LBLCanadianDollarsAmount.TabIndex = 9
        '
        'LBLJapaneseYenAmount
        '
        Me.LBLJapaneseYenAmount.AutoSize = True
        Me.LBLJapaneseYenAmount.Location = New System.Drawing.Point(538, 437)
        Me.LBLJapaneseYenAmount.Name = "LBLJapaneseYenAmount"
        Me.LBLJapaneseYenAmount.Size = New System.Drawing.Size(0, 13)
        Me.LBLJapaneseYenAmount.TabIndex = 10
        '
        'TBDate
        '
        Me.TBDate.Location = New System.Drawing.Point(458, 226)
        Me.TBDate.Name = "TBDate"
        Me.TBDate.Size = New System.Drawing.Size(90, 20)
        Me.TBDate.TabIndex = 11
        '
        'LBLDate
        '
        Me.LBLDate.AutoSize = True
        Me.LBLDate.Location = New System.Drawing.Point(268, 229)
        Me.LBLDate.Name = "LBLDate"
        Me.LBLDate.Size = New System.Drawing.Size(110, 13)
        Me.LBLDate.TabIndex = 12
        Me.LBLDate.Text = "Enter the current date"
        '
        'lbl_mex
        '
        Me.lbl_mex.AutoSize = True
        Me.lbl_mex.Location = New System.Drawing.Point(268, 490)
        Me.lbl_mex.Name = "lbl_mex"
        Me.lbl_mex.Size = New System.Drawing.Size(79, 13)
        Me.lbl_mex.TabIndex = 13
        Me.lbl_mex.Text = "Mexican Pesos"
        '
        'LBLMexicanPesosAmount
        '
        Me.LBLMexicanPesosAmount.AutoSize = True
        Me.LBLMexicanPesosAmount.Location = New System.Drawing.Point(538, 490)
        Me.LBLMexicanPesosAmount.Name = "LBLMexicanPesosAmount"
        Me.LBLMexicanPesosAmount.Size = New System.Drawing.Size(0, 13)
        Me.LBLMexicanPesosAmount.TabIndex = 14
        '
        'BTNConvert
        '
        Me.BTNConvert.Location = New System.Drawing.Point(258, 264)
        Me.BTNConvert.Name = "BTNConvert"
        Me.BTNConvert.Size = New System.Drawing.Size(97, 30)
        Me.BTNConvert.TabIndex = 15
        Me.BTNConvert.Text = "Convert Currency"
        Me.BTNConvert.UseVisualStyleBackColor = True
        '
        'BTNClear
        '
        Me.BTNClear.Location = New System.Drawing.Point(458, 264)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.Size = New System.Drawing.Size(101, 29)
        Me.BTNClear.TabIndex = 16
        Me.BTNClear.Text = "Clear"
        Me.BTNClear.UseVisualStyleBackColor = True
        '
        'BTNExit
        '
        Me.BTNExit.Location = New System.Drawing.Point(353, 534)
        Me.BTNExit.Name = "BTNExit"
        Me.BTNExit.Size = New System.Drawing.Size(101, 29)
        Me.BTNExit.TabIndex = 17
        Me.BTNExit.Text = "Exit"
        Me.BTNExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 591)
        Me.Controls.Add(Me.BTNExit)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.BTNConvert)
        Me.Controls.Add(Me.LBLMexicanPesosAmount)
        Me.Controls.Add(Me.lbl_mex)
        Me.Controls.Add(Me.LBLDate)
        Me.Controls.Add(Me.TBDate)
        Me.Controls.Add(Me.LBLJapaneseYenAmount)
        Me.Controls.Add(Me.LBLCanadianDollarsAmount)
        Me.Controls.Add(Me.LBLEurosAmount)
        Me.Controls.Add(Me.LBLJapaneseYen)
        Me.Controls.Add(Me.LBLCanadianDollars)
        Me.Controls.Add(Me.LBLEuros)
        Me.Controls.Add(Me.TBDollars)
        Me.Controls.Add(Me.LBLUSDollars)
        Me.Controls.Add(Me.LBLInstructions)
        Me.Controls.Add(Me.LBLCurrencyConversion)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLCurrencyConversion As System.Windows.Forms.Label
    Friend WithEvents LBLInstructions As System.Windows.Forms.Label
    Friend WithEvents LBLUSDollars As System.Windows.Forms.Label
    Friend WithEvents TBDollars As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LS1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LBLEuros As System.Windows.Forms.Label
    Friend WithEvents LBLCanadianDollars As System.Windows.Forms.Label
    Friend WithEvents LBLJapaneseYen As System.Windows.Forms.Label
    Friend WithEvents LBLEurosAmount As System.Windows.Forms.Label
    Friend WithEvents LBLCanadianDollarsAmount As System.Windows.Forms.Label
    Friend WithEvents LBLJapaneseYenAmount As System.Windows.Forms.Label
    Friend WithEvents TBDate As System.Windows.Forms.TextBox
    Friend WithEvents LBLDate As System.Windows.Forms.Label
    Friend WithEvents lbl_mex As System.Windows.Forms.Label
    Friend WithEvents LBLMexicanPesosAmount As System.Windows.Forms.Label
    Friend WithEvents BTNConvert As System.Windows.Forms.Button
    Friend WithEvents BTNClear As System.Windows.Forms.Button
    Friend WithEvents BTNExit As System.Windows.Forms.Button

End Class
