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
        Me.cbo_Measurement = New System.Windows.Forms.ComboBox()
        Me.lbl_Weight = New System.Windows.Forms.Label()
        Me.cbo_Hight = New System.Windows.Forms.ComboBox()
        Me.txt_Weight = New System.Windows.Forms.TextBox()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.lbl_Output = New System.Windows.Forms.Label()
        Me.lbl_WeightType = New System.Windows.Forms.Label()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Location = New System.Drawing.Point(370, 9)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(499, 37)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "Body Mass Index (BMI) Calculator"
        '
        'cbo_Measurement
        '
        Me.cbo_Measurement.FormattingEnabled = True
        Me.cbo_Measurement.Items.AddRange(New Object() {"Imperial", "Metric"})
        Me.cbo_Measurement.Location = New System.Drawing.Point(167, 152)
        Me.cbo_Measurement.Name = "cbo_Measurement"
        Me.cbo_Measurement.Size = New System.Drawing.Size(418, 45)
        Me.cbo_Measurement.TabIndex = 2
        Me.cbo_Measurement.Text = "Select a Measurement"
        '
        'lbl_Weight
        '
        Me.lbl_Weight.AutoSize = True
        Me.lbl_Weight.Location = New System.Drawing.Point(120, 656)
        Me.lbl_Weight.Name = "lbl_Weight"
        Me.lbl_Weight.Size = New System.Drawing.Size(117, 37)
        Me.lbl_Weight.TabIndex = 3
        Me.lbl_Weight.Text = "Weight"
        '
        'cbo_Hight
        '
        Me.cbo_Hight.FormattingEnabled = True
        Me.cbo_Hight.Location = New System.Drawing.Point(167, 496)
        Me.cbo_Hight.Name = "cbo_Hight"
        Me.cbo_Hight.Size = New System.Drawing.Size(216, 45)
        Me.cbo_Hight.TabIndex = 4
        Me.cbo_Hight.Text = "Height"
        '
        'txt_Weight
        '
        Me.txt_Weight.Location = New System.Drawing.Point(262, 656)
        Me.txt_Weight.Name = "txt_Weight"
        Me.txt_Weight.Size = New System.Drawing.Size(100, 44)
        Me.txt_Weight.TabIndex = 5
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(144, 1000)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(251, 101)
        Me.btn_Calculate.TabIndex = 6
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'lbl_Output
        '
        Me.lbl_Output.AutoSize = True
        Me.lbl_Output.Location = New System.Drawing.Point(137, 871)
        Me.lbl_Output.Name = "lbl_Output"
        Me.lbl_Output.Size = New System.Drawing.Size(0, 37)
        Me.lbl_Output.TabIndex = 7
        '
        'lbl_WeightType
        '
        Me.lbl_WeightType.AutoSize = True
        Me.lbl_WeightType.Location = New System.Drawing.Point(383, 661)
        Me.lbl_WeightType.Name = "lbl_WeightType"
        Me.lbl_WeightType.Size = New System.Drawing.Size(0, 37)
        Me.lbl_WeightType.TabIndex = 8
        Me.lbl_WeightType.Visible = False
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(603, 1000)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(246, 101)
        Me.btn_Clear.TabIndex = 9
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(886, 152)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(735, 765)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1647, 1367)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.lbl_WeightType)
        Me.Controls.Add(Me.lbl_Output)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.txt_Weight)
        Me.Controls.Add(Me.cbo_Hight)
        Me.Controls.Add(Me.lbl_Weight)
        Me.Controls.Add(Me.cbo_Measurement)
        Me.Controls.Add(Me.lbl_Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents cbo_Measurement As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Weight As System.Windows.Forms.Label
    Friend WithEvents cbo_Hight As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Weight As System.Windows.Forms.TextBox
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents lbl_Output As System.Windows.Forms.Label
    Friend WithEvents lbl_WeightType As System.Windows.Forms.Label
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
