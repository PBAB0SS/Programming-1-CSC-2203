<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problem2
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
        Me.btn_Return2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdo_B2toB10 = New System.Windows.Forms.RadioButton()
        Me.rdo_B10toB2 = New System.Windows.Forms.RadioButton()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.lbl_ForTextbox = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Return2
        '
        Me.btn_Return2.Location = New System.Drawing.Point(356, 773)
        Me.btn_Return2.Name = "btn_Return2"
        Me.btn_Return2.Size = New System.Drawing.Size(229, 123)
        Me.btn_Return2.TabIndex = 1
        Me.btn_Return2.Text = "Return to Start Menu"
        Me.btn_Return2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(277, 204)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 44)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(928, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdo_B2toB10)
        Me.GroupBox1.Controls.Add(Me.rdo_B10toB2)
        Me.GroupBox1.Location = New System.Drawing.Point(522, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 160)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose a Conversion"
        '
        'rdo_B2toB10
        '
        Me.rdo_B2toB10.AutoSize = True
        Me.rdo_B2toB10.Location = New System.Drawing.Point(3, 98)
        Me.rdo_B2toB10.Name = "rdo_B2toB10"
        Me.rdo_B2toB10.Size = New System.Drawing.Size(320, 41)
        Me.rdo_B2toB10.TabIndex = 1
        Me.rdo_B2toB10.TabStop = True
        Me.rdo_B2toB10.Text = "Base 2 to Base 10"
        Me.rdo_B2toB10.UseVisualStyleBackColor = True
        '
        'rdo_B10toB2
        '
        Me.rdo_B10toB2.AutoSize = True
        Me.rdo_B10toB2.Location = New System.Drawing.Point(3, 40)
        Me.rdo_B10toB2.Name = "rdo_B10toB2"
        Me.rdo_B10toB2.Size = New System.Drawing.Size(320, 41)
        Me.rdo_B10toB2.TabIndex = 0
        Me.rdo_B10toB2.TabStop = True
        Me.rdo_B10toB2.Text = "Base 10 to Base 2"
        Me.rdo_B10toB2.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(365, 463)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(211, 102)
        Me.btn_Clear.TabIndex = 5
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.Location = New System.Drawing.Point(77, 40)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(786, 37)
        Me.lbl_Title.TabIndex = 2
        Me.lbl_Title.Text = "Binary to Decimal and Decimal to Binary Converter"
        '
        'lbl_ForTextbox
        '
        Me.lbl_ForTextbox.AutoSize = True
        Me.lbl_ForTextbox.Location = New System.Drawing.Point(8, 207)
        Me.lbl_ForTextbox.Name = "lbl_ForTextbox"
        Me.lbl_ForTextbox.Size = New System.Drawing.Size(253, 37)
        Me.lbl_ForTextbox.TabIndex = 6
        Me.lbl_ForTextbox.Text = "Enter a Number:"
        '
        'Problem2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 927)
        Me.Controls.Add(Me.lbl_ForTextbox)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_Return2)
        Me.Name = "Problem2"
        Me.Text = "Problem2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Return2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_B2toB10 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_B10toB2 As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_ForTextbox As System.Windows.Forms.Label
End Class
