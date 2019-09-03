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
        Me.lbl_NumberOfTickets = New System.Windows.Forms.Label()
        Me.txt_NumberOfTickets = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdo_30Day = New System.Windows.Forms.RadioButton()
        Me.rdo_SingleRide = New System.Windows.Forms.RadioButton()
        Me.rdo_7Day = New System.Windows.Forms.RadioButton()
        Me.lbl_FinalCost = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_BuyTicket = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Location = New System.Drawing.Point(635, 96)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(477, 37)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "Purchase Metro Tickets for NYC"
        '
        'lbl_NumberOfTickets
        '
        Me.lbl_NumberOfTickets.AutoSize = True
        Me.lbl_NumberOfTickets.Location = New System.Drawing.Point(644, 355)
        Me.lbl_NumberOfTickets.Name = "lbl_NumberOfTickets"
        Me.lbl_NumberOfTickets.Size = New System.Drawing.Size(287, 37)
        Me.lbl_NumberOfTickets.TabIndex = 1
        Me.lbl_NumberOfTickets.Text = "Number of Tickets:"
        Me.lbl_NumberOfTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_NumberOfTickets
        '
        Me.txt_NumberOfTickets.Location = New System.Drawing.Point(1012, 348)
        Me.txt_NumberOfTickets.Name = "txt_NumberOfTickets"
        Me.txt_NumberOfTickets.Size = New System.Drawing.Size(100, 44)
        Me.txt_NumberOfTickets.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdo_30Day)
        Me.GroupBox1.Controls.Add(Me.rdo_SingleRide)
        Me.GroupBox1.Controls.Add(Me.rdo_7Day)
        Me.GroupBox1.Location = New System.Drawing.Point(669, 491)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 237)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ticket Type: Select One"
        '
        'rdo_30Day
        '
        Me.rdo_30Day.AutoSize = True
        Me.rdo_30Day.Location = New System.Drawing.Point(24, 169)
        Me.rdo_30Day.Name = "rdo_30Day"
        Me.rdo_30Day.Size = New System.Drawing.Size(356, 41)
        Me.rdo_30Day.TabIndex = 6
        Me.rdo_30Day.TabStop = True
        Me.rdo_30Day.Text = "30-Day Ticket ($112)"
        Me.rdo_30Day.UseVisualStyleBackColor = True
        '
        'rdo_SingleRide
        '
        Me.rdo_SingleRide.AutoSize = True
        Me.rdo_SingleRide.Location = New System.Drawing.Point(24, 43)
        Me.rdo_SingleRide.Name = "rdo_SingleRide"
        Me.rdo_SingleRide.Size = New System.Drawing.Size(428, 41)
        Me.rdo_SingleRide.TabIndex = 4
        Me.rdo_SingleRide.TabStop = True
        Me.rdo_SingleRide.Text = "Single Ride Ticket ($2.75)"
        Me.rdo_SingleRide.UseVisualStyleBackColor = True
        '
        'rdo_7Day
        '
        Me.rdo_7Day.AutoSize = True
        Me.rdo_7Day.Location = New System.Drawing.Point(24, 103)
        Me.rdo_7Day.Name = "rdo_7Day"
        Me.rdo_7Day.Size = New System.Drawing.Size(324, 41)
        Me.rdo_7Day.TabIndex = 5
        Me.rdo_7Day.TabStop = True
        Me.rdo_7Day.Text = "7-Day Ticket ($30)"
        Me.rdo_7Day.UseVisualStyleBackColor = True
        '
        'lbl_FinalCost
        '
        Me.lbl_FinalCost.AutoSize = True
        Me.lbl_FinalCost.Location = New System.Drawing.Point(644, 851)
        Me.lbl_FinalCost.Name = "lbl_FinalCost"
        Me.lbl_FinalCost.Size = New System.Drawing.Size(265, 37)
        Me.lbl_FinalCost.TabIndex = 4
        Me.lbl_FinalCost.Text = "Final Ticket Cost:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(563, 1000)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btn_BuyTicket
        '
        Me.btn_BuyTicket.Location = New System.Drawing.Point(711, 949)
        Me.btn_BuyTicket.Name = "btn_BuyTicket"
        Me.btn_BuyTicket.Size = New System.Drawing.Size(220, 77)
        Me.btn_BuyTicket.TabIndex = 6
        Me.btn_BuyTicket.Text = "Buy Ticket"
        Me.btn_BuyTicket.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(1060, 949)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(156, 77)
        Me.btn_Clear.TabIndex = 7
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(1419, 1065)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_BuyTicket)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_FinalCost)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_NumberOfTickets)
        Me.Controls.Add(Me.lbl_NumberOfTickets)
        Me.Controls.Add(Me.lbl_Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_NumberOfTickets As System.Windows.Forms.Label
    Friend WithEvents txt_NumberOfTickets As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_30Day As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_SingleRide As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_7Day As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_FinalCost As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_BuyTicket As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button

End Class
