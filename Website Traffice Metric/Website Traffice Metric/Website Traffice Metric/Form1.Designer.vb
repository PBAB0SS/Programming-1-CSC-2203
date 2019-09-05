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
        Me.btn_Analytics = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.lbl_Output = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lst_Analytics = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Analytics
        '
        Me.btn_Analytics.Location = New System.Drawing.Point(61, 151)
        Me.btn_Analytics.Name = "btn_Analytics"
        Me.btn_Analytics.Size = New System.Drawing.Size(349, 109)
        Me.btn_Analytics.TabIndex = 0
        Me.btn_Analytics.Text = "Enter Visitor Analytics"
        Me.btn_Analytics.UseVisualStyleBackColor = True
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Location = New System.Drawing.Point(311, 59)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(364, 37)
        Me.lbl_Title.TabIndex = 1
        Me.lbl_Title.Text = "Website Traffic Estimate"
        '
        'lbl_Output
        '
        Me.lbl_Output.AutoSize = True
        Me.lbl_Output.Location = New System.Drawing.Point(12, 944)
        Me.lbl_Output.Name = "lbl_Output"
        Me.lbl_Output.Size = New System.Drawing.Size(316, 37)
        Me.lbl_Output.TabIndex = 2
        Me.lbl_Output.Text = "Average Time Spent:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(886, 56)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(87, 52)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(181, 52)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 52)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lst_Analytics
        '
        Me.lst_Analytics.FormattingEnabled = True
        Me.lst_Analytics.ItemHeight = 37
        Me.lst_Analytics.Location = New System.Drawing.Point(482, 168)
        Me.lst_Analytics.Name = "lst_Analytics"
        Me.lst_Analytics.ScrollAlwaysVisible = True
        Me.lst_Analytics.Size = New System.Drawing.Size(389, 596)
        Me.lst_Analytics.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 1069)
        Me.Controls.Add(Me.lst_Analytics)
        Me.Controls.Add(Me.lbl_Output)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_Analytics)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Analytics As System.Windows.Forms.Button
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_Output As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lst_Analytics As System.Windows.Forms.ListBox

End Class
