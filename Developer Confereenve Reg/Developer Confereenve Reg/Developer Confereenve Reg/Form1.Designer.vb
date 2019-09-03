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
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.lbl_NumberOfAttendees = New System.Windows.Forms.Label()
        Me.lbl_Output = New System.Windows.Forms.Label()
        Me.txt_NumberOfAttendees = New System.Windows.Forms.TextBox()
        Me.btn_Register = New System.Windows.Forms.Button()
        Me.check_Discount = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Location = New System.Drawing.Point(216, 25)
        Me.lbl_Title.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(302, 20)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "App Developer's Conference Registration"
        '
        'lbl_NumberOfAttendees
        '
        Me.lbl_NumberOfAttendees.AutoSize = True
        Me.lbl_NumberOfAttendees.Location = New System.Drawing.Point(31, 118)
        Me.lbl_NumberOfAttendees.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lbl_NumberOfAttendees.Name = "lbl_NumberOfAttendees"
        Me.lbl_NumberOfAttendees.Size = New System.Drawing.Size(285, 20)
        Me.lbl_NumberOfAttendees.TabIndex = 1
        Me.lbl_NumberOfAttendees.Text = "Enter Number of Employees Attending:"
        '
        'lbl_Output
        '
        Me.lbl_Output.AutoSize = True
        Me.lbl_Output.Location = New System.Drawing.Point(125, 485)
        Me.lbl_Output.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lbl_Output.Name = "lbl_Output"
        Me.lbl_Output.Size = New System.Drawing.Size(85, 20)
        Me.lbl_Output.TabIndex = 2
        Me.lbl_Output.Text = "Total Cost:"
        '
        'txt_NumberOfAttendees
        '
        Me.txt_NumberOfAttendees.Location = New System.Drawing.Point(328, 118)
        Me.txt_NumberOfAttendees.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.txt_NumberOfAttendees.Name = "txt_NumberOfAttendees"
        Me.txt_NumberOfAttendees.Size = New System.Drawing.Size(49, 26)
        Me.txt_NumberOfAttendees.TabIndex = 3
        '
        'btn_Register
        '
        Me.btn_Register.Location = New System.Drawing.Point(108, 335)
        Me.btn_Register.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.btn_Register.Name = "btn_Register"
        Me.btn_Register.Size = New System.Drawing.Size(98, 50)
        Me.btn_Register.TabIndex = 5
        Me.btn_Register.Text = "Register"
        Me.btn_Register.UseVisualStyleBackColor = True
        '
        'check_Discount
        '
        Me.check_Discount.AutoSize = True
        Me.check_Discount.Location = New System.Drawing.Point(128, 223)
        Me.check_Discount.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.check_Discount.Name = "check_Discount"
        Me.check_Discount.Size = New System.Drawing.Size(289, 24)
        Me.check_Discount.TabIndex = 6
        Me.check_Discount.Text = "I Have attended the last conference"
        Me.check_Discount.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 31)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 30)
        Me.ToolStripMenuItem2.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 30)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 668)
        Me.Controls.Add(Me.check_Discount)
        Me.Controls.Add(Me.btn_Register)
        Me.Controls.Add(Me.txt_NumberOfAttendees)
        Me.Controls.Add(Me.lbl_Output)
        Me.Controls.Add(Me.lbl_NumberOfAttendees)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_NumberOfAttendees As System.Windows.Forms.Label
    Friend WithEvents lbl_Output As System.Windows.Forms.Label
    Friend WithEvents txt_NumberOfAttendees As System.Windows.Forms.TextBox
    Friend WithEvents btn_Register As System.Windows.Forms.Button
    Friend WithEvents check_Discount As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
