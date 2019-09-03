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
        Me.cbo_CommmuteType = New System.Windows.Forms.ComboBox()
        Me.Lbl_CommuteType = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txt_1 = New System.Windows.Forms.TextBox()
        Me.lbl_DaysWorked = New System.Windows.Forms.Label()
        Me.txt_DaysWorked = New System.Windows.Forms.TextBox()
        Me.lbl_MPG = New System.Windows.Forms.Label()
        Me.txt_MPG = New System.Windows.Forms.TextBox()
        Me.txt_CostOfGas = New System.Windows.Forms.TextBox()
        Me.lbl_CostOfGas = New System.Windows.Forms.Label()
        Me.txt_MonthlyCost = New System.Windows.Forms.TextBox()
        Me.lbl_MonthlyCost = New System.Windows.Forms.Label()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.lbl_Output = New System.Windows.Forms.Label()
        Me.txt_ParkingCost = New System.Windows.Forms.TextBox()
        Me.lbl_ParkingCost = New System.Windows.Forms.Label()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.Pic_Car = New System.Windows.Forms.PictureBox()
        Me.pic_Train = New System.Windows.Forms.PictureBox()
        Me.pic_Bus = New System.Windows.Forms.PictureBox()
        CType(Me.Pic_Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Train, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Bus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Location = New System.Drawing.Point(181, 12)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(495, 37)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "Yearly Commuter Cost Calculator"
        '
        'cbo_CommmuteType
        '
        Me.cbo_CommmuteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_CommmuteType.FormattingEnabled = True
        Me.cbo_CommmuteType.Items.AddRange(New Object() {"Car", "Train", "Bus"})
        Me.cbo_CommmuteType.Location = New System.Drawing.Point(388, 98)
        Me.cbo_CommmuteType.Name = "cbo_CommmuteType"
        Me.cbo_CommmuteType.Size = New System.Drawing.Size(444, 45)
        Me.cbo_CommmuteType.TabIndex = 1
        '
        'Lbl_CommuteType
        '
        Me.Lbl_CommuteType.AutoSize = True
        Me.Lbl_CommuteType.Location = New System.Drawing.Point(24, 98)
        Me.Lbl_CommuteType.Name = "Lbl_CommuteType"
        Me.Lbl_CommuteType.Size = New System.Drawing.Size(340, 37)
        Me.Lbl_CommuteType.TabIndex = 2
        Me.Lbl_CommuteType.Text = "Select Commute Type:"
        '
        'lbl
        '
        Me.lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl.Location = New System.Drawing.Point(4, 252)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(616, 41)
        Me.lbl.TabIndex = 3
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_1
        '
        Me.txt_1.Location = New System.Drawing.Point(626, 249)
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(226, 44)
        Me.txt_1.TabIndex = 4
        '
        'lbl_DaysWorked
        '
        Me.lbl_DaysWorked.Location = New System.Drawing.Point(4, 317)
        Me.lbl_DaysWorked.Name = "lbl_DaysWorked"
        Me.lbl_DaysWorked.Size = New System.Drawing.Size(616, 41)
        Me.lbl_DaysWorked.TabIndex = 5
        Me.lbl_DaysWorked.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_DaysWorked
        '
        Me.txt_DaysWorked.Location = New System.Drawing.Point(626, 314)
        Me.txt_DaysWorked.Name = "txt_DaysWorked"
        Me.txt_DaysWorked.Size = New System.Drawing.Size(226, 44)
        Me.txt_DaysWorked.TabIndex = 6
        '
        'lbl_MPG
        '
        Me.lbl_MPG.Location = New System.Drawing.Point(11, 385)
        Me.lbl_MPG.Name = "lbl_MPG"
        Me.lbl_MPG.Size = New System.Drawing.Size(609, 41)
        Me.lbl_MPG.TabIndex = 7
        Me.lbl_MPG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_MPG
        '
        Me.txt_MPG.Location = New System.Drawing.Point(626, 382)
        Me.txt_MPG.Name = "txt_MPG"
        Me.txt_MPG.Size = New System.Drawing.Size(226, 44)
        Me.txt_MPG.TabIndex = 8
        '
        'txt_CostOfGas
        '
        Me.txt_CostOfGas.Location = New System.Drawing.Point(626, 455)
        Me.txt_CostOfGas.Name = "txt_CostOfGas"
        Me.txt_CostOfGas.Size = New System.Drawing.Size(226, 44)
        Me.txt_CostOfGas.TabIndex = 10
        '
        'lbl_CostOfGas
        '
        Me.lbl_CostOfGas.Location = New System.Drawing.Point(11, 458)
        Me.lbl_CostOfGas.Name = "lbl_CostOfGas"
        Me.lbl_CostOfGas.Size = New System.Drawing.Size(609, 41)
        Me.lbl_CostOfGas.TabIndex = 9
        Me.lbl_CostOfGas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_MonthlyCost
        '
        Me.txt_MonthlyCost.Location = New System.Drawing.Point(626, 529)
        Me.txt_MonthlyCost.Name = "txt_MonthlyCost"
        Me.txt_MonthlyCost.Size = New System.Drawing.Size(226, 44)
        Me.txt_MonthlyCost.TabIndex = 12
        '
        'lbl_MonthlyCost
        '
        Me.lbl_MonthlyCost.Location = New System.Drawing.Point(11, 505)
        Me.lbl_MonthlyCost.Name = "lbl_MonthlyCost"
        Me.lbl_MonthlyCost.Size = New System.Drawing.Size(609, 90)
        Me.lbl_MonthlyCost.TabIndex = 11
        Me.lbl_MonthlyCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(51, 747)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(242, 90)
        Me.btn_Calculate.TabIndex = 13
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'lbl_Output
        '
        Me.lbl_Output.AutoSize = True
        Me.lbl_Output.Location = New System.Drawing.Point(373, 878)
        Me.lbl_Output.Name = "lbl_Output"
        Me.lbl_Output.Size = New System.Drawing.Size(111, 37)
        Me.lbl_Output.TabIndex = 14
        Me.lbl_Output.Text = "Label1"
        '
        'txt_ParkingCost
        '
        Me.txt_ParkingCost.Location = New System.Drawing.Point(626, 618)
        Me.txt_ParkingCost.Name = "txt_ParkingCost"
        Me.txt_ParkingCost.Size = New System.Drawing.Size(226, 44)
        Me.txt_ParkingCost.TabIndex = 15
        '
        'lbl_ParkingCost
        '
        Me.lbl_ParkingCost.Location = New System.Drawing.Point(11, 617)
        Me.lbl_ParkingCost.Name = "lbl_ParkingCost"
        Me.lbl_ParkingCost.Size = New System.Drawing.Size(609, 44)
        Me.lbl_ParkingCost.TabIndex = 16
        Me.lbl_ParkingCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(613, 747)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(193, 90)
        Me.btn_Clear.TabIndex = 17
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'Pic_Car
        '
        Me.Pic_Car.Image = CType(resources.GetObject("Pic_Car.Image"), System.Drawing.Image)
        Me.Pic_Car.Location = New System.Drawing.Point(888, 103)
        Me.Pic_Car.Name = "Pic_Car"
        Me.Pic_Car.Size = New System.Drawing.Size(486, 396)
        Me.Pic_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Car.TabIndex = 18
        Me.Pic_Car.TabStop = False
        '
        'pic_Train
        '
        Me.pic_Train.Image = CType(resources.GetObject("pic_Train.Image"), System.Drawing.Image)
        Me.pic_Train.Location = New System.Drawing.Point(888, 103)
        Me.pic_Train.Name = "pic_Train"
        Me.pic_Train.Size = New System.Drawing.Size(486, 396)
        Me.pic_Train.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Train.TabIndex = 19
        Me.pic_Train.TabStop = False
        '
        'pic_Bus
        '
        Me.pic_Bus.Image = CType(resources.GetObject("pic_Bus.Image"), System.Drawing.Image)
        Me.pic_Bus.Location = New System.Drawing.Point(888, 103)
        Me.pic_Bus.Name = "pic_Bus"
        Me.pic_Bus.Size = New System.Drawing.Size(486, 396)
        Me.pic_Bus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Bus.TabIndex = 20
        Me.pic_Bus.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 957)
        Me.Controls.Add(Me.pic_Bus)
        Me.Controls.Add(Me.pic_Train)
        Me.Controls.Add(Me.Pic_Car)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.lbl_ParkingCost)
        Me.Controls.Add(Me.txt_ParkingCost)
        Me.Controls.Add(Me.lbl_Output)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.txt_MonthlyCost)
        Me.Controls.Add(Me.lbl_MonthlyCost)
        Me.Controls.Add(Me.txt_CostOfGas)
        Me.Controls.Add(Me.lbl_CostOfGas)
        Me.Controls.Add(Me.txt_MPG)
        Me.Controls.Add(Me.lbl_MPG)
        Me.Controls.Add(Me.txt_DaysWorked)
        Me.Controls.Add(Me.lbl_DaysWorked)
        Me.Controls.Add(Me.txt_1)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Lbl_CommuteType)
        Me.Controls.Add(Me.cbo_CommmuteType)
        Me.Controls.Add(Me.lbl_Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Pic_Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Train, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Bus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents cbo_CommmuteType As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_CommuteType As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents txt_1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DaysWorked As System.Windows.Forms.Label
    Friend WithEvents txt_DaysWorked As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MPG As System.Windows.Forms.Label
    Friend WithEvents txt_MPG As System.Windows.Forms.TextBox
    Friend WithEvents txt_CostOfGas As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CostOfGas As System.Windows.Forms.Label
    Friend WithEvents txt_MonthlyCost As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MonthlyCost As System.Windows.Forms.Label
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents lbl_Output As System.Windows.Forms.Label
    Friend WithEvents txt_ParkingCost As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ParkingCost As System.Windows.Forms.Label
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents Pic_Car As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Train As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Bus As System.Windows.Forms.PictureBox

End Class
