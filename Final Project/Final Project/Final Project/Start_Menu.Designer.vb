<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start_Menu
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
        Me.btn_Problem1 = New System.Windows.Forms.Button()
        Me.btn_Problem2 = New System.Windows.Forms.Button()
        Me.btn_Problem3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Problem1
        '
        Me.btn_Problem1.Location = New System.Drawing.Point(161, 193)
        Me.btn_Problem1.Name = "btn_Problem1"
        Me.btn_Problem1.Size = New System.Drawing.Size(217, 101)
        Me.btn_Problem1.TabIndex = 0
        Me.btn_Problem1.Text = "Problem 1"
        Me.btn_Problem1.UseVisualStyleBackColor = True
        '
        'btn_Problem2
        '
        Me.btn_Problem2.Location = New System.Drawing.Point(161, 386)
        Me.btn_Problem2.Name = "btn_Problem2"
        Me.btn_Problem2.Size = New System.Drawing.Size(217, 101)
        Me.btn_Problem2.TabIndex = 1
        Me.btn_Problem2.Text = "Problem 2"
        Me.btn_Problem2.UseVisualStyleBackColor = True
        '
        'btn_Problem3
        '
        Me.btn_Problem3.Location = New System.Drawing.Point(161, 599)
        Me.btn_Problem3.Name = "btn_Problem3"
        Me.btn_Problem3.Size = New System.Drawing.Size(217, 101)
        Me.btn_Problem3.TabIndex = 2
        Me.btn_Problem3.Text = "Problem 3"
        Me.btn_Problem3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please Select an Option"
        '
        'Start_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 753)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Problem3)
        Me.Controls.Add(Me.btn_Problem2)
        Me.Controls.Add(Me.btn_Problem1)
        Me.Name = "Start_Menu"
        Me.Text = "Start Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Problem1 As System.Windows.Forms.Button
    Friend WithEvents btn_Problem2 As System.Windows.Forms.Button
    Friend WithEvents btn_Problem3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
