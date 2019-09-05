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
        Me.cbo_City = New System.Windows.Forms.ComboBox()
        Me.lbl_Team = New System.Windows.Forms.Label()
        Me.txt_Team = New System.Windows.Forms.TextBox()
        Me.lbl_Game = New System.Windows.Forms.Label()
        Me.lst_Game = New System.Windows.Forms.ListBox()
        Me.btn_CliantCost = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.lbl_GameType = New System.Windows.Forms.Label()
        Me.lbl_Cost = New System.Windows.Forms.Label()
        Me.lbl_Length = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Location = New System.Drawing.Point(306, 29)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(396, 37)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "Myster Escape Information"
        '
        'cbo_City
        '
        Me.cbo_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_City.FormattingEnabled = True
        Me.cbo_City.Items.AddRange(New Object() {"Dallas", "Paris", "Singapor"})
        Me.cbo_City.Location = New System.Drawing.Point(443, 112)
        Me.cbo_City.Name = "cbo_City"
        Me.cbo_City.Size = New System.Drawing.Size(371, 45)
        Me.cbo_City.TabIndex = 1
        '
        'lbl_Team
        '
        Me.lbl_Team.AutoSize = True
        Me.lbl_Team.Location = New System.Drawing.Point(242, 191)
        Me.lbl_Team.Name = "lbl_Team"
        Me.lbl_Team.Size = New System.Drawing.Size(266, 37)
        Me.lbl_Team.TabIndex = 2
        Me.lbl_Team.Text = "Number in Team:"
        '
        'txt_Team
        '
        Me.txt_Team.Location = New System.Drawing.Point(563, 191)
        Me.txt_Team.Name = "txt_Team"
        Me.txt_Team.Size = New System.Drawing.Size(100, 44)
        Me.txt_Team.TabIndex = 3
        '
        'lbl_Game
        '
        Me.lbl_Game.AutoSize = True
        Me.lbl_Game.Location = New System.Drawing.Point(242, 308)
        Me.lbl_Game.Name = "lbl_Game"
        Me.lbl_Game.Size = New System.Drawing.Size(288, 37)
        Me.lbl_Game.TabIndex = 4
        Me.lbl_Game.Text = "Select Game Type:"
        '
        'lst_Game
        '
        Me.lst_Game.FormattingEnabled = True
        Me.lst_Game.ItemHeight = 37
        Me.lst_Game.Location = New System.Drawing.Point(249, 348)
        Me.lst_Game.Name = "lst_Game"
        Me.lst_Game.Size = New System.Drawing.Size(304, 263)
        Me.lst_Game.TabIndex = 5
        '
        'btn_CliantCost
        '
        Me.btn_CliantCost.Location = New System.Drawing.Point(184, 660)
        Me.btn_CliantCost.Name = "btn_CliantCost"
        Me.btn_CliantCost.Size = New System.Drawing.Size(276, 68)
        Me.btn_CliantCost.TabIndex = 6
        Me.btn_CliantCost.Text = "Find Team Cost"
        Me.btn_CliantCost.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(525, 660)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(164, 68)
        Me.btn_Clear.TabIndex = 7
        Me.btn_Clear.Text = "Clear Form"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'lbl_GameType
        '
        Me.lbl_GameType.AutoSize = True
        Me.lbl_GameType.Location = New System.Drawing.Point(194, 802)
        Me.lbl_GameType.Name = "lbl_GameType"
        Me.lbl_GameType.Size = New System.Drawing.Size(113, 37)
        Me.lbl_GameType.TabIndex = 8
        Me.lbl_GameType.Text = "Game:"
        '
        'lbl_Cost
        '
        Me.lbl_Cost.AutoSize = True
        Me.lbl_Cost.Location = New System.Drawing.Point(194, 883)
        Me.lbl_Cost.Name = "lbl_Cost"
        Me.lbl_Cost.Size = New System.Drawing.Size(92, 37)
        Me.lbl_Cost.TabIndex = 9
        Me.lbl_Cost.Text = "Cost:"
        '
        'lbl_Length
        '
        Me.lbl_Length.AutoSize = True
        Me.lbl_Length.Location = New System.Drawing.Point(194, 966)
        Me.lbl_Length.Name = "lbl_Length"
        Me.lbl_Length.Size = New System.Drawing.Size(124, 37)
        Me.lbl_Length.TabIndex = 10
        Me.lbl_Length.Text = "Length:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(445, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 37)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Select City Location:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1127, 1032)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Length)
        Me.Controls.Add(Me.lbl_Cost)
        Me.Controls.Add(Me.lbl_GameType)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_CliantCost)
        Me.Controls.Add(Me.lst_Game)
        Me.Controls.Add(Me.lbl_Game)
        Me.Controls.Add(Me.txt_Team)
        Me.Controls.Add(Me.lbl_Team)
        Me.Controls.Add(Me.cbo_City)
        Me.Controls.Add(Me.lbl_Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents cbo_City As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Team As System.Windows.Forms.Label
    Friend WithEvents txt_Team As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Game As System.Windows.Forms.Label
    Friend WithEvents lst_Game As System.Windows.Forms.ListBox
    Friend WithEvents btn_CliantCost As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents lbl_GameType As System.Windows.Forms.Label
    Friend WithEvents lbl_Cost As System.Windows.Forms.Label
    Friend WithEvents lbl_Length As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
