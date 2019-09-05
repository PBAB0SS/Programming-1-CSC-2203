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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DgsljfsldhfjToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.btn_EnterWeightLoss = New System.Windows.Forms.Button()
        Me.Lst_WeighLoss = New System.Windows.Forms.ListBox()
        Me.lbl_AverageLoss = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DgsljfsldhfjToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1619, 56)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DgsljfsldhfjToolStripMenuItem
        '
        Me.DgsljfsldhfjToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.DgsljfsldhfjToolStripMenuItem.Name = "DgsljfsldhfjToolStripMenuItem"
        Me.DgsljfsldhfjToolStripMenuItem.Size = New System.Drawing.Size(87, 52)
        Me.DgsljfsldhfjToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(181, 52)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 52)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Location = New System.Drawing.Point(108, 112)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(285, 74)
        Me.lbl_Title.TabIndex = 1
        Me.lbl_Title.Text = "Fitness Challenge " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Team Weight Loss"
        '
        'btn_EnterWeightLoss
        '
        Me.btn_EnterWeightLoss.Location = New System.Drawing.Point(145, 634)
        Me.btn_EnterWeightLoss.Name = "btn_EnterWeightLoss"
        Me.btn_EnterWeightLoss.Size = New System.Drawing.Size(248, 126)
        Me.btn_EnterWeightLoss.TabIndex = 2
        Me.btn_EnterWeightLoss.Text = "Enter Weight Loss"
        Me.btn_EnterWeightLoss.UseVisualStyleBackColor = True
        '
        'Lst_WeighLoss
        '
        Me.Lst_WeighLoss.FormattingEnabled = True
        Me.Lst_WeighLoss.ItemHeight = 37
        Me.Lst_WeighLoss.Location = New System.Drawing.Point(170, 242)
        Me.Lst_WeighLoss.Name = "Lst_WeighLoss"
        Me.Lst_WeighLoss.Size = New System.Drawing.Size(870, 337)
        Me.Lst_WeighLoss.TabIndex = 3
        '
        'lbl_AverageLoss
        '
        Me.lbl_AverageLoss.AutoSize = True
        Me.lbl_AverageLoss.Location = New System.Drawing.Point(138, 852)
        Me.lbl_AverageLoss.Name = "lbl_AverageLoss"
        Me.lbl_AverageLoss.Size = New System.Drawing.Size(521, 37)
        Me.lbl_AverageLoss.TabIndex = 4
        Me.lbl_AverageLoss.Text = "Average weight loss of your team is"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1619, 1240)
        Me.Controls.Add(Me.lbl_AverageLoss)
        Me.Controls.Add(Me.Lst_WeighLoss)
        Me.Controls.Add(Me.btn_EnterWeightLoss)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DgsljfsldhfjToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents btn_EnterWeightLoss As System.Windows.Forms.Button
    Friend WithEvents Lst_WeighLoss As System.Windows.Forms.ListBox
    Friend WithEvents lbl_AverageLoss As System.Windows.Forms.Label

End Class
