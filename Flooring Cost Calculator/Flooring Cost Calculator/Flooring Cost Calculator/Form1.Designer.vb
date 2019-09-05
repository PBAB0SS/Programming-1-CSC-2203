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
        Me.lbl_SquareFootage = New System.Windows.Forms.Label()
        Me.txt_SquareFootage = New System.Windows.Forms.TextBox()
        Me.rdo_Tile = New System.Windows.Forms.RadioButton()
        Me.grup_FlooringType = New System.Windows.Forms.GroupBox()
        Me.rdo_Hardwood = New System.Windows.Forms.RadioButton()
        Me.rdo_Carpet = New System.Windows.Forms.RadioButton()
        Me.lbl_CostEstimate = New System.Windows.Forms.Label()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.lbl_CostEstimateNumber = New System.Windows.Forms.Label()
        Me.grup_FlooringType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.Location = New System.Drawing.Point(91, 39)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(833, 82)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "Flooring Cost Calculator"
        '
        'lbl_SquareFootage
        '
        Me.lbl_SquareFootage.AutoSize = True
        Me.lbl_SquareFootage.Location = New System.Drawing.Point(113, 195)
        Me.lbl_SquareFootage.Name = "lbl_SquareFootage"
        Me.lbl_SquareFootage.Size = New System.Drawing.Size(256, 37)
        Me.lbl_SquareFootage.TabIndex = 1
        Me.lbl_SquareFootage.Text = "Square Footage:"
        '
        'txt_SquareFootage
        '
        Me.txt_SquareFootage.Location = New System.Drawing.Point(416, 188)
        Me.txt_SquareFootage.Name = "txt_SquareFootage"
        Me.txt_SquareFootage.Size = New System.Drawing.Size(193, 44)
        Me.txt_SquareFootage.TabIndex = 2
        '
        'rdo_Tile
        '
        Me.rdo_Tile.AutoSize = True
        Me.rdo_Tile.Location = New System.Drawing.Point(6, 43)
        Me.rdo_Tile.Name = "rdo_Tile"
        Me.rdo_Tile.Size = New System.Drawing.Size(112, 41)
        Me.rdo_Tile.TabIndex = 3
        Me.rdo_Tile.Text = "Tile"
        Me.rdo_Tile.UseVisualStyleBackColor = True
        '
        'grup_FlooringType
        '
        Me.grup_FlooringType.BackColor = System.Drawing.Color.White
        Me.grup_FlooringType.Controls.Add(Me.rdo_Hardwood)
        Me.grup_FlooringType.Controls.Add(Me.rdo_Carpet)
        Me.grup_FlooringType.Controls.Add(Me.rdo_Tile)
        Me.grup_FlooringType.ForeColor = System.Drawing.Color.Black
        Me.grup_FlooringType.Location = New System.Drawing.Point(378, 334)
        Me.grup_FlooringType.Name = "grup_FlooringType"
        Me.grup_FlooringType.Size = New System.Drawing.Size(258, 200)
        Me.grup_FlooringType.TabIndex = 4
        Me.grup_FlooringType.TabStop = False
        Me.grup_FlooringType.Text = "Flooring Type"
        '
        'rdo_Hardwood
        '
        Me.rdo_Hardwood.AutoSize = True
        Me.rdo_Hardwood.Location = New System.Drawing.Point(6, 137)
        Me.rdo_Hardwood.Name = "rdo_Hardwood"
        Me.rdo_Hardwood.Size = New System.Drawing.Size(208, 41)
        Me.rdo_Hardwood.TabIndex = 5
        Me.rdo_Hardwood.Text = "Hardwood"
        Me.rdo_Hardwood.UseVisualStyleBackColor = True
        '
        'rdo_Carpet
        '
        Me.rdo_Carpet.AutoSize = True
        Me.rdo_Carpet.Location = New System.Drawing.Point(6, 90)
        Me.rdo_Carpet.Name = "rdo_Carpet"
        Me.rdo_Carpet.Size = New System.Drawing.Size(157, 41)
        Me.rdo_Carpet.TabIndex = 4
        Me.rdo_Carpet.Text = "Carpet"
        Me.rdo_Carpet.UseVisualStyleBackColor = True
        '
        'lbl_CostEstimate
        '
        Me.lbl_CostEstimate.AutoSize = True
        Me.lbl_CostEstimate.Location = New System.Drawing.Point(113, 626)
        Me.lbl_CostEstimate.Name = "lbl_CostEstimate"
        Me.lbl_CostEstimate.Size = New System.Drawing.Size(225, 37)
        Me.lbl_CostEstimate.TabIndex = 6
        Me.lbl_CostEstimate.Text = "Cost Estimate:"
        '
        'btn_Calculate
        '
        Me.btn_Calculate.AutoSize = True
        Me.btn_Calculate.Location = New System.Drawing.Point(272, 765)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(160, 47)
        Me.btn_Calculate.TabIndex = 7
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.AutoSize = True
        Me.btn_Clear.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Clear.Location = New System.Drawing.Point(581, 765)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(142, 49)
        Me.btn_Clear.TabIndex = 8
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'lbl_CostEstimateNumber
        '
        Me.lbl_CostEstimateNumber.AutoSize = True
        Me.lbl_CostEstimateNumber.Location = New System.Drawing.Point(377, 626)
        Me.lbl_CostEstimateNumber.Name = "lbl_CostEstimateNumber"
        Me.lbl_CostEstimateNumber.Size = New System.Drawing.Size(0, 37)
        Me.lbl_CostEstimateNumber.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(1015, 997)
        Me.Controls.Add(Me.lbl_CostEstimateNumber)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.lbl_CostEstimate)
        Me.Controls.Add(Me.grup_FlooringType)
        Me.Controls.Add(Me.txt_SquareFootage)
        Me.Controls.Add(Me.lbl_SquareFootage)
        Me.Controls.Add(Me.lbl_Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grup_FlooringType.ResumeLayout(False)
        Me.grup_FlooringType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_SquareFootage As System.Windows.Forms.Label
    Friend WithEvents txt_SquareFootage As System.Windows.Forms.TextBox
    Friend WithEvents rdo_Tile As System.Windows.Forms.RadioButton
    Friend WithEvents grup_FlooringType As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_Hardwood As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Carpet As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_CostEstimate As System.Windows.Forms.Label
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents lbl_CostEstimateNumber As System.Windows.Forms.Label

End Class
