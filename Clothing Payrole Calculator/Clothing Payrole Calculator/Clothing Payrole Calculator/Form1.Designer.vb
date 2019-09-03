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
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.lbl_Hours = New System.Windows.Forms.Label()
        Me.lbl_PerHour = New System.Windows.Forms.Label()
        Me.txt_Fname = New System.Windows.Forms.TextBox()
        Me.txt_Lname = New System.Windows.Forms.TextBox()
        Me.txt_Hours = New System.Windows.Forms.TextBox()
        Me.txt_PerHour = New System.Windows.Forms.TextBox()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_Output = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdo_Family = New System.Windows.Forms.RadioButton()
        Me.rdo_Single = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Location = New System.Drawing.Point(780, 50)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(491, 37)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "Retro Clothing Payrole Calculator"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Location = New System.Drawing.Point(521, 213)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(112, 37)
        Me.lbl_Name.TabIndex = 1
        Me.lbl_Name.Text = "Name:"
        '
        'lbl_Hours
        '
        Me.lbl_Hours.AutoSize = True
        Me.lbl_Hours.Location = New System.Drawing.Point(480, 327)
        Me.lbl_Hours.Name = "lbl_Hours"
        Me.lbl_Hours.Size = New System.Drawing.Size(272, 37)
        Me.lbl_Hours.TabIndex = 2
        Me.lbl_Hours.Text = "Number of Hours:"
        '
        'lbl_PerHour
        '
        Me.lbl_PerHour.AutoSize = True
        Me.lbl_PerHour.Location = New System.Drawing.Point(490, 436)
        Me.lbl_PerHour.Name = "lbl_PerHour"
        Me.lbl_PerHour.Size = New System.Drawing.Size(217, 37)
        Me.lbl_PerHour.TabIndex = 3
        Me.lbl_PerHour.Text = "Pay Per Hour:"
        '
        'txt_Fname
        '
        Me.txt_Fname.Location = New System.Drawing.Point(862, 213)
        Me.txt_Fname.Name = "txt_Fname"
        Me.txt_Fname.Size = New System.Drawing.Size(100, 44)
        Me.txt_Fname.TabIndex = 4
        '
        'txt_Lname
        '
        Me.txt_Lname.Location = New System.Drawing.Point(1043, 213)
        Me.txt_Lname.Name = "txt_Lname"
        Me.txt_Lname.Size = New System.Drawing.Size(100, 44)
        Me.txt_Lname.TabIndex = 5
        '
        'txt_Hours
        '
        Me.txt_Hours.Location = New System.Drawing.Point(862, 324)
        Me.txt_Hours.Name = "txt_Hours"
        Me.txt_Hours.Size = New System.Drawing.Size(100, 44)
        Me.txt_Hours.TabIndex = 6
        '
        'txt_PerHour
        '
        Me.txt_PerHour.Location = New System.Drawing.Point(835, 433)
        Me.txt_PerHour.Name = "txt_PerHour"
        Me.txt_PerHour.Size = New System.Drawing.Size(100, 44)
        Me.txt_PerHour.TabIndex = 7
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(402, 776)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(321, 120)
        Me.btn_Calculate.TabIndex = 8
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(1099, 776)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(317, 120)
        Me.btn_Clear.TabIndex = 9
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(2333, 56)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(87, 52)
        Me.ExitToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(156, 52)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'lbl_Output
        '
        Me.lbl_Output.AutoSize = True
        Me.lbl_Output.Location = New System.Drawing.Point(731, 1102)
        Me.lbl_Output.Name = "lbl_Output"
        Me.lbl_Output.Size = New System.Drawing.Size(0, 37)
        Me.lbl_Output.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdo_Family)
        Me.GroupBox1.Controls.Add(Me.rdo_Single)
        Me.GroupBox1.Location = New System.Drawing.Point(569, 508)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 183)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select One:"
        '
        'rdo_Family
        '
        Me.rdo_Family.AutoSize = True
        Me.rdo_Family.Location = New System.Drawing.Point(3, 121)
        Me.rdo_Family.Name = "rdo_Family"
        Me.rdo_Family.Size = New System.Drawing.Size(155, 41)
        Me.rdo_Family.TabIndex = 1
        Me.rdo_Family.TabStop = True
        Me.rdo_Family.Text = "Family"
        Me.rdo_Family.UseVisualStyleBackColor = True
        '
        'rdo_Single
        '
        Me.rdo_Single.AutoSize = True
        Me.rdo_Single.Location = New System.Drawing.Point(3, 40)
        Me.rdo_Single.Name = "rdo_Single"
        Me.rdo_Single.Size = New System.Drawing.Size(149, 41)
        Me.rdo_Single.TabIndex = 0
        Me.rdo_Single.TabStop = True
        Me.rdo_Single.Text = "Single"
        Me.rdo_Single.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2333, 1371)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Output)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.txt_PerHour)
        Me.Controls.Add(Me.txt_Hours)
        Me.Controls.Add(Me.txt_Lname)
        Me.Controls.Add(Me.txt_Fname)
        Me.Controls.Add(Me.lbl_PerHour)
        Me.Controls.Add(Me.lbl_Hours)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Retro Clothing Payrole Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_Hours As System.Windows.Forms.Label
    Friend WithEvents lbl_PerHour As System.Windows.Forms.Label
    Friend WithEvents txt_Fname As System.Windows.Forms.TextBox
    Friend WithEvents txt_Lname As System.Windows.Forms.TextBox
    Friend WithEvents txt_Hours As System.Windows.Forms.TextBox
    Friend WithEvents txt_PerHour As System.Windows.Forms.TextBox
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_Output As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_Family As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Single As System.Windows.Forms.RadioButton

End Class
