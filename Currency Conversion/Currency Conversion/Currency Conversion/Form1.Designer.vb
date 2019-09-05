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
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.Txt_DollarsToConvert = New System.Windows.Forms.TextBox()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Date = New System.Windows.Forms.Label()
        Me.Txt_Date = New System.Windows.Forms.TextBox()
        Me.lbl_Euros = New System.Windows.Forms.Label()
        Me.lbl_CanadianDollars = New System.Windows.Forms.Label()
        Me.lbl_MexicanPeso = New System.Windows.Forms.Label()
        Me.lbl_JapeneseYen = New System.Windows.Forms.Label()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Convert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(816, 952)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(166, 54)
        Me.btn_Exit.TabIndex = 0
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Txt_DollarsToConvert
        '
        Me.Txt_DollarsToConvert.Location = New System.Drawing.Point(831, 129)
        Me.Txt_DollarsToConvert.Name = "Txt_DollarsToConvert"
        Me.Txt_DollarsToConvert.Size = New System.Drawing.Size(222, 44)
        Me.Txt_DollarsToConvert.TabIndex = 1
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbl_Title.Location = New System.Drawing.Point(206, 9)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(711, 82)
        Me.lbl_Title.TabIndex = 2
        Me.lbl_Title.Text = "Currency Conversion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Location = New System.Drawing.Point(50, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(595, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter The value of US Dollars to Convert"
        '
        'lbl_Date
        '
        Me.lbl_Date.AutoSize = True
        Me.lbl_Date.Location = New System.Drawing.Point(50, 241)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(294, 37)
        Me.lbl_Date.TabIndex = 4
        Me.lbl_Date.Text = "Enter Current Date:"
        '
        'Txt_Date
        '
        Me.Txt_Date.Location = New System.Drawing.Point(831, 270)
        Me.Txt_Date.Name = "Txt_Date"
        Me.Txt_Date.Size = New System.Drawing.Size(222, 44)
        Me.Txt_Date.TabIndex = 5
        '
        'lbl_Euros
        '
        Me.lbl_Euros.AutoSize = True
        Me.lbl_Euros.Location = New System.Drawing.Point(68, 508)
        Me.lbl_Euros.Name = "lbl_Euros"
        Me.lbl_Euros.Size = New System.Drawing.Size(235, 37)
        Me.lbl_Euros.TabIndex = 7
        Me.lbl_Euros.Text = "Value in Euros:"
        '
        'lbl_CanadianDollars
        '
        Me.lbl_CanadianDollars.AutoSize = True
        Me.lbl_CanadianDollars.Location = New System.Drawing.Point(593, 508)
        Me.lbl_CanadianDollars.Name = "lbl_CanadianDollars"
        Me.lbl_CanadianDollars.Size = New System.Drawing.Size(398, 37)
        Me.lbl_CanadianDollars.TabIndex = 8
        Me.lbl_CanadianDollars.Text = "Value in Canadian Dollars:"
        '
        'lbl_MexicanPeso
        '
        Me.lbl_MexicanPeso.AutoSize = True
        Me.lbl_MexicanPeso.Location = New System.Drawing.Point(68, 656)
        Me.lbl_MexicanPeso.Name = "lbl_MexicanPeso"
        Me.lbl_MexicanPeso.Size = New System.Drawing.Size(365, 37)
        Me.lbl_MexicanPeso.TabIndex = 9
        Me.lbl_MexicanPeso.Text = "Value in Mexican Pesos:"
        '
        'lbl_JapeneseYen
        '
        Me.lbl_JapeneseYen.AutoSize = True
        Me.lbl_JapeneseYen.Location = New System.Drawing.Point(593, 656)
        Me.lbl_JapeneseYen.Name = "lbl_JapeneseYen"
        Me.lbl_JapeneseYen.Size = New System.Drawing.Size(354, 37)
        Me.lbl_JapeneseYen.TabIndex = 10
        Me.lbl_JapeneseYen.Text = "Value in Japenese Yen:"
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(493, 947)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(157, 59)
        Me.btn_Clear.TabIndex = 11
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Convert
        '
        Me.btn_Convert.Location = New System.Drawing.Point(185, 952)
        Me.btn_Convert.Name = "btn_Convert"
        Me.btn_Convert.Size = New System.Drawing.Size(184, 60)
        Me.btn_Convert.TabIndex = 12
        Me.btn_Convert.Text = "Convert"
        Me.btn_Convert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 1137)
        Me.Controls.Add(Me.btn_Convert)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.lbl_JapeneseYen)
        Me.Controls.Add(Me.lbl_MexicanPeso)
        Me.Controls.Add(Me.lbl_CanadianDollars)
        Me.Controls.Add(Me.lbl_Euros)
        Me.Controls.Add(Me.Txt_Date)
        Me.Controls.Add(Me.lbl_Date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.Txt_DollarsToConvert)
        Me.Controls.Add(Me.btn_Exit)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents Txt_DollarsToConvert As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Date As System.Windows.Forms.Label
    Friend WithEvents Txt_Date As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Euros As System.Windows.Forms.Label
    Friend WithEvents lbl_CanadianDollars As System.Windows.Forms.Label
    Friend WithEvents lbl_MexicanPeso As System.Windows.Forms.Label
    Friend WithEvents lbl_JapeneseYen As System.Windows.Forms.Label
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Convert As System.Windows.Forms.Button

End Class
