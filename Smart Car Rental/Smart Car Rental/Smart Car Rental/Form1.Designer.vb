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
        Me.btn_DisplayFare = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.lbl_Subtitle = New System.Windows.Forms.Label()
        Me.lbl_Days = New System.Windows.Forms.Label()
        Me.lbl_Miles = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.txt_NumberofDays = New System.Windows.Forms.TextBox()
        Me.txt_NumberofMiles = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_DisplayFare
        '
        Me.btn_DisplayFare.Location = New System.Drawing.Point(78, 925)
        Me.btn_DisplayFare.Name = "btn_DisplayFare"
        Me.btn_DisplayFare.Size = New System.Drawing.Size(237, 85)
        Me.btn_DisplayFare.TabIndex = 0
        Me.btn_DisplayFare.Text = "Display Fare"
        Me.btn_DisplayFare.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(424, 925)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(218, 85)
        Me.btn_Clear.TabIndex = 1
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(774, 925)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(197, 85)
        Me.btn_Exit.TabIndex = 2
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1114, 311)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.Location = New System.Drawing.Point(317, 377)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(505, 64)
        Me.lbl_Title.TabIndex = 4
        Me.lbl_Title.Text = "Smart Car Rentals"
        '
        'lbl_Subtitle
        '
        Me.lbl_Subtitle.AutoSize = True
        Me.lbl_Subtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Subtitle.Location = New System.Drawing.Point(167, 444)
        Me.lbl_Subtitle.Name = "lbl_Subtitle"
        Me.lbl_Subtitle.Size = New System.Drawing.Size(805, 46)
        Me.lbl_Subtitle.TabIndex = 5
        Me.lbl_Subtitle.Text = "Only $29.99 Per Day Plus $0.39 Per Miles"
        '
        'lbl_Days
        '
        Me.lbl_Days.AutoSize = True
        Me.lbl_Days.Location = New System.Drawing.Point(295, 569)
        Me.lbl_Days.Name = "lbl_Days"
        Me.lbl_Days.Size = New System.Drawing.Size(258, 37)
        Me.lbl_Days.TabIndex = 6
        Me.lbl_Days.Text = "Number of Days:"
        '
        'lbl_Miles
        '
        Me.lbl_Miles.AutoSize = True
        Me.lbl_Miles.Location = New System.Drawing.Point(295, 665)
        Me.lbl_Miles.Name = "lbl_Miles"
        Me.lbl_Miles.Size = New System.Drawing.Size(259, 37)
        Me.lbl_Miles.TabIndex = 7
        Me.lbl_Miles.Text = "Number of Miles:"
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Location = New System.Drawing.Point(295, 767)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(309, 37)
        Me.lbl_Total.TabIndex = 8
        Me.lbl_Total.Text = "Total Cost of Rental:"
        '
        'txt_NumberofDays
        '
        Me.txt_NumberofDays.Location = New System.Drawing.Point(585, 566)
        Me.txt_NumberofDays.Name = "txt_NumberofDays"
        Me.txt_NumberofDays.Size = New System.Drawing.Size(100, 44)
        Me.txt_NumberofDays.TabIndex = 9
        '
        'txt_NumberofMiles
        '
        Me.txt_NumberofMiles.Location = New System.Drawing.Point(585, 658)
        Me.txt_NumberofMiles.Name = "txt_NumberofMiles"
        Me.txt_NumberofMiles.Size = New System.Drawing.Size(100, 44)
        Me.txt_NumberofMiles.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1138, 1106)
        Me.Controls.Add(Me.txt_NumberofMiles)
        Me.Controls.Add(Me.txt_NumberofDays)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.lbl_Miles)
        Me.Controls.Add(Me.lbl_Days)
        Me.Controls.Add(Me.lbl_Subtitle)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_DisplayFare)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Rent a Smart Car"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_DisplayFare As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_Subtitle As System.Windows.Forms.Label
    Friend WithEvents lbl_Days As System.Windows.Forms.Label
    Friend WithEvents lbl_Miles As System.Windows.Forms.Label
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents txt_NumberofDays As System.Windows.Forms.TextBox
    Friend WithEvents txt_NumberofMiles As System.Windows.Forms.TextBox

End Class
