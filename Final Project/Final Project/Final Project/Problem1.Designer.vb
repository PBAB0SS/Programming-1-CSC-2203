<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problem1
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
        Me.btn_Return1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Return1
        '
        Me.btn_Return1.Location = New System.Drawing.Point(298, 792)
        Me.btn_Return1.Name = "btn_Return1"
        Me.btn_Return1.Size = New System.Drawing.Size(229, 123)
        Me.btn_Return1.TabIndex = 0
        Me.btn_Return1.Text = "Return to Start Menu"
        Me.btn_Return1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(58, 138)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(202, 44)
        Me.TextBox1.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 37
        Me.ListBox1.Location = New System.Drawing.Point(451, 138)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(502, 485)
        Me.ListBox1.TabIndex = 2
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(67, 239)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(163, 77)
        Me.btn_Add.TabIndex = 3
        Me.btn_Add.Text = "Add"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(58, 447)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(180, 96)
        Me.btn_Clear.TabIndex = 4
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.Location = New System.Drawing.Point(336, 29)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(269, 37)
        Me.lbl_Title.TabIndex = 5
        Me.lbl_Title.Text = "Number to Word"
        '
        'Problem1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 998)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_Return1)
        Me.Name = "Problem1"
        Me.Text = "Problem1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Return1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
End Class
