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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.lbl_Rate = New System.Windows.Forms.Label()
        Me.lbl_NumberOfBikes = New System.Windows.Forms.Label()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.TXT_NumberBikes = New System.Windows.Forms.TextBox()
        Me.lbl_TotalCost = New System.Windows.Forms.Label()
        Me.pic_Bike = New System.Windows.Forms.PictureBox()
        Me.Lbl_TotalCostInput = New System.Windows.Forms.Label()
        CType(Me.pic_Bike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Cursor = System.Windows.Forms.Cursors.Cross
        Me.lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_Title.Location = New System.Drawing.Point(91, 30)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(601, 91)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "City Bike Rental"
        '
        'lbl_Rate
        '
        Me.lbl_Rate.AutoSize = True
        Me.lbl_Rate.Location = New System.Drawing.Point(205, 163)
        Me.lbl_Rate.Name = "lbl_Rate"
        Me.lbl_Rate.Size = New System.Drawing.Size(413, 37)
        Me.lbl_Rate.TabIndex = 1
        Me.lbl_Rate.Text = "$9.50 Per Bike for 24 Hours"
        '
        'lbl_NumberOfBikes
        '
        Me.lbl_NumberOfBikes.AutoSize = True
        Me.lbl_NumberOfBikes.Location = New System.Drawing.Point(174, 290)
        Me.lbl_NumberOfBikes.Name = "lbl_NumberOfBikes"
        Me.lbl_NumberOfBikes.Size = New System.Drawing.Size(426, 37)
        Me.lbl_NumberOfBikes.TabIndex = 2
        Me.lbl_NumberOfBikes.Text = "Number of Bikes for Rentals:"
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(30, 560)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(242, 63)
        Me.btn_Calculate.TabIndex = 3
        Me.btn_Calculate.Text = "Calculate Cost"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(335, 560)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(165, 63)
        Me.btn_Clear.TabIndex = 4
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(586, 564)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(125, 54)
        Me.btn_Exit.TabIndex = 5
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'TXT_NumberBikes
        '
        Me.TXT_NumberBikes.Location = New System.Drawing.Point(642, 290)
        Me.TXT_NumberBikes.Name = "TXT_NumberBikes"
        Me.TXT_NumberBikes.Size = New System.Drawing.Size(100, 44)
        Me.TXT_NumberBikes.TabIndex = 6
        '
        'lbl_TotalCost
        '
        Me.lbl_TotalCost.AutoSize = True
        Me.lbl_TotalCost.Location = New System.Drawing.Point(174, 420)
        Me.lbl_TotalCost.Name = "lbl_TotalCost"
        Me.lbl_TotalCost.Size = New System.Drawing.Size(405, 37)
        Me.lbl_TotalCost.TabIndex = 7
        Me.lbl_TotalCost.Text = "Total Cost of Bikes Rented:"
        '
        'pic_Bike
        '
        Me.pic_Bike.Image = CType(resources.GetObject("pic_Bike.Image"), System.Drawing.Image)
        Me.pic_Bike.Location = New System.Drawing.Point(40, 678)
        Me.pic_Bike.Name = "pic_Bike"
        Me.pic_Bike.Size = New System.Drawing.Size(702, 283)
        Me.pic_Bike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Bike.TabIndex = 8
        Me.pic_Bike.TabStop = False
        '
        'Lbl_TotalCostInput
        '
        Me.Lbl_TotalCostInput.AutoSize = True
        Me.Lbl_TotalCostInput.Location = New System.Drawing.Point(622, 420)
        Me.Lbl_TotalCostInput.Name = "Lbl_TotalCostInput"
        Me.Lbl_TotalCostInput.Size = New System.Drawing.Size(0, 37)
        Me.Lbl_TotalCostInput.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 987)
        Me.Controls.Add(Me.Lbl_TotalCostInput)
        Me.Controls.Add(Me.pic_Bike)
        Me.Controls.Add(Me.lbl_TotalCost)
        Me.Controls.Add(Me.TXT_NumberBikes)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.lbl_NumberOfBikes)
        Me.Controls.Add(Me.lbl_Rate)
        Me.Controls.Add(Me.lbl_Title)
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        CType(Me.pic_Bike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_Rate As System.Windows.Forms.Label
    Friend WithEvents lbl_NumberOfBikes As System.Windows.Forms.Label
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents TXT_NumberBikes As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TotalCost As System.Windows.Forms.Label
    Friend WithEvents pic_Bike As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_TotalCostInput As System.Windows.Forms.Label

End Class
