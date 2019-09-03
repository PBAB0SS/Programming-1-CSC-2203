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
        Me.lbl_UpperEndlineSeating = New System.Windows.Forms.Label()
        Me.lbl_LowerEndlineSeating = New System.Windows.Forms.Label()
        Me.lbl_SidlineSeating = New System.Windows.Forms.Label()
        Me.lbl_ClubSeats = New System.Windows.Forms.Label()
        Me.Pic_LowerEndlineSeating = New System.Windows.Forms.PictureBox()
        Me.pic_UpperEndlineSeating = New System.Windows.Forms.PictureBox()
        Me.Pic_SidelineSeating = New System.Windows.Forms.PictureBox()
        Me.Pic_ClubSeats = New System.Windows.Forms.PictureBox()
        Me.btn_UpperEndlineSeating = New System.Windows.Forms.Button()
        Me.btn_LowerEndlineSeating = New System.Windows.Forms.Button()
        Me.btn_SidelineSeating = New System.Windows.Forms.Button()
        Me.btn_ClubSeats = New System.Windows.Forms.Button()
        Me.lbl_Confirmation = New System.Windows.Forms.Label()
        Me.btn_Purchase = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        CType(Me.Pic_LowerEndlineSeating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_UpperEndlineSeating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_SidelineSeating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_ClubSeats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_UpperEndlineSeating
        '
        Me.lbl_UpperEndlineSeating.AutoSize = True
        Me.lbl_UpperEndlineSeating.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UpperEndlineSeating.Location = New System.Drawing.Point(68, 580)
        Me.lbl_UpperEndlineSeating.Name = "lbl_UpperEndlineSeating"
        Me.lbl_UpperEndlineSeating.Size = New System.Drawing.Size(120, 37)
        Me.lbl_UpperEndlineSeating.TabIndex = 0
        Me.lbl_UpperEndlineSeating.Text = "$15.00"
        '
        'lbl_LowerEndlineSeating
        '
        Me.lbl_LowerEndlineSeating.AutoSize = True
        Me.lbl_LowerEndlineSeating.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LowerEndlineSeating.Location = New System.Drawing.Point(348, 580)
        Me.lbl_LowerEndlineSeating.Name = "lbl_LowerEndlineSeating"
        Me.lbl_LowerEndlineSeating.Size = New System.Drawing.Size(122, 37)
        Me.lbl_LowerEndlineSeating.TabIndex = 1
        Me.lbl_LowerEndlineSeating.Text = "$25.00"
        '
        'lbl_SidlineSeating
        '
        Me.lbl_SidlineSeating.AutoSize = True
        Me.lbl_SidlineSeating.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SidlineSeating.Location = New System.Drawing.Point(642, 580)
        Me.lbl_SidlineSeating.Name = "lbl_SidlineSeating"
        Me.lbl_SidlineSeating.Size = New System.Drawing.Size(122, 37)
        Me.lbl_SidlineSeating.TabIndex = 2
        Me.lbl_SidlineSeating.Text = "$30.00"
        '
        'lbl_ClubSeats
        '
        Me.lbl_ClubSeats.AutoSize = True
        Me.lbl_ClubSeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ClubSeats.Location = New System.Drawing.Point(937, 580)
        Me.lbl_ClubSeats.Name = "lbl_ClubSeats"
        Me.lbl_ClubSeats.Size = New System.Drawing.Size(122, 37)
        Me.lbl_ClubSeats.TabIndex = 3
        Me.lbl_ClubSeats.Text = "$50.00"
        '
        'Pic_LowerEndlineSeating
        '
        Me.Pic_LowerEndlineSeating.Image = CType(resources.GetObject("Pic_LowerEndlineSeating.Image"), System.Drawing.Image)
        Me.Pic_LowerEndlineSeating.Location = New System.Drawing.Point(306, 310)
        Me.Pic_LowerEndlineSeating.Name = "Pic_LowerEndlineSeating"
        Me.Pic_LowerEndlineSeating.Size = New System.Drawing.Size(216, 206)
        Me.Pic_LowerEndlineSeating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_LowerEndlineSeating.TabIndex = 4
        Me.Pic_LowerEndlineSeating.TabStop = False
        '
        'pic_UpperEndlineSeating
        '
        Me.pic_UpperEndlineSeating.Image = CType(resources.GetObject("pic_UpperEndlineSeating.Image"), System.Drawing.Image)
        Me.pic_UpperEndlineSeating.Location = New System.Drawing.Point(24, 310)
        Me.pic_UpperEndlineSeating.Name = "pic_UpperEndlineSeating"
        Me.pic_UpperEndlineSeating.Size = New System.Drawing.Size(216, 206)
        Me.pic_UpperEndlineSeating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_UpperEndlineSeating.TabIndex = 5
        Me.pic_UpperEndlineSeating.TabStop = False
        '
        'Pic_SidelineSeating
        '
        Me.Pic_SidelineSeating.Image = CType(resources.GetObject("Pic_SidelineSeating.Image"), System.Drawing.Image)
        Me.Pic_SidelineSeating.Location = New System.Drawing.Point(600, 310)
        Me.Pic_SidelineSeating.Name = "Pic_SidelineSeating"
        Me.Pic_SidelineSeating.Size = New System.Drawing.Size(216, 206)
        Me.Pic_SidelineSeating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_SidelineSeating.TabIndex = 6
        Me.Pic_SidelineSeating.TabStop = False
        '
        'Pic_ClubSeats
        '
        Me.Pic_ClubSeats.Image = CType(resources.GetObject("Pic_ClubSeats.Image"), System.Drawing.Image)
        Me.Pic_ClubSeats.Location = New System.Drawing.Point(885, 310)
        Me.Pic_ClubSeats.Name = "Pic_ClubSeats"
        Me.Pic_ClubSeats.Size = New System.Drawing.Size(216, 206)
        Me.Pic_ClubSeats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_ClubSeats.TabIndex = 7
        Me.Pic_ClubSeats.TabStop = False
        '
        'btn_UpperEndlineSeating
        '
        Me.btn_UpperEndlineSeating.Location = New System.Drawing.Point(11, 176)
        Me.btn_UpperEndlineSeating.Name = "btn_UpperEndlineSeating"
        Me.btn_UpperEndlineSeating.Size = New System.Drawing.Size(246, 97)
        Me.btn_UpperEndlineSeating.TabIndex = 8
        Me.btn_UpperEndlineSeating.Text = "Upper Endline " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seating"
        Me.btn_UpperEndlineSeating.UseVisualStyleBackColor = True
        '
        'btn_LowerEndlineSeating
        '
        Me.btn_LowerEndlineSeating.Location = New System.Drawing.Point(293, 176)
        Me.btn_LowerEndlineSeating.Name = "btn_LowerEndlineSeating"
        Me.btn_LowerEndlineSeating.Size = New System.Drawing.Size(239, 97)
        Me.btn_LowerEndlineSeating.TabIndex = 9
        Me.btn_LowerEndlineSeating.Text = "Lower Endline" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Seating"
        Me.btn_LowerEndlineSeating.UseVisualStyleBackColor = True
        '
        'btn_SidelineSeating
        '
        Me.btn_SidelineSeating.Location = New System.Drawing.Point(579, 176)
        Me.btn_SidelineSeating.Name = "btn_SidelineSeating"
        Me.btn_SidelineSeating.Size = New System.Drawing.Size(240, 97)
        Me.btn_SidelineSeating.TabIndex = 10
        Me.btn_SidelineSeating.Text = "Sideline Seating"
        Me.btn_SidelineSeating.UseVisualStyleBackColor = True
        '
        'btn_ClubSeats
        '
        Me.btn_ClubSeats.Location = New System.Drawing.Point(902, 173)
        Me.btn_ClubSeats.Name = "btn_ClubSeats"
        Me.btn_ClubSeats.Size = New System.Drawing.Size(187, 100)
        Me.btn_ClubSeats.TabIndex = 11
        Me.btn_ClubSeats.Text = "Club Seats"
        Me.btn_ClubSeats.UseVisualStyleBackColor = True
        '
        'lbl_Confirmation
        '
        Me.lbl_Confirmation.AutoSize = True
        Me.lbl_Confirmation.Location = New System.Drawing.Point(287, 891)
        Me.lbl_Confirmation.Name = "lbl_Confirmation"
        Me.lbl_Confirmation.Size = New System.Drawing.Size(435, 37)
        Me.lbl_Confirmation.TabIndex = 12
        Me.lbl_Confirmation.Text = "Thank you for your purchase!"
        '
        'btn_Purchase
        '
        Me.btn_Purchase.BackColor = System.Drawing.Color.Green
        Me.btn_Purchase.ForeColor = System.Drawing.Color.White
        Me.btn_Purchase.Location = New System.Drawing.Point(413, 740)
        Me.btn_Purchase.Name = "btn_Purchase"
        Me.btn_Purchase.Size = New System.Drawing.Size(211, 77)
        Me.btn_Purchase.TabIndex = 13
        Me.btn_Purchase.Text = "Purchase"
        Me.btn_Purchase.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.Red
        Me.btn_Exit.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Exit.Location = New System.Drawing.Point(406, 1023)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(183, 57)
        Me.btn_Exit.TabIndex = 14
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbl_Title.Location = New System.Drawing.Point(161, 41)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(807, 82)
        Me.lbl_Title.TabIndex = 15
        Me.lbl_Title.Text = "Lacrosse Ticket Options"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 1139)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Purchase)
        Me.Controls.Add(Me.lbl_Confirmation)
        Me.Controls.Add(Me.btn_ClubSeats)
        Me.Controls.Add(Me.btn_SidelineSeating)
        Me.Controls.Add(Me.btn_LowerEndlineSeating)
        Me.Controls.Add(Me.btn_UpperEndlineSeating)
        Me.Controls.Add(Me.Pic_ClubSeats)
        Me.Controls.Add(Me.Pic_SidelineSeating)
        Me.Controls.Add(Me.pic_UpperEndlineSeating)
        Me.Controls.Add(Me.Pic_LowerEndlineSeating)
        Me.Controls.Add(Me.lbl_ClubSeats)
        Me.Controls.Add(Me.lbl_SidlineSeating)
        Me.Controls.Add(Me.lbl_LowerEndlineSeating)
        Me.Controls.Add(Me.lbl_UpperEndlineSeating)
        Me.Name = "Form1"
        CType(Me.Pic_LowerEndlineSeating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_UpperEndlineSeating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_SidelineSeating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_ClubSeats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_UpperEndlineSeating As System.Windows.Forms.Label
    Friend WithEvents lbl_LowerEndlineSeating As System.Windows.Forms.Label
    Friend WithEvents lbl_SidlineSeating As System.Windows.Forms.Label
    Friend WithEvents lbl_ClubSeats As System.Windows.Forms.Label
    Friend WithEvents Pic_LowerEndlineSeating As System.Windows.Forms.PictureBox
    Friend WithEvents pic_UpperEndlineSeating As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_SidelineSeating As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_ClubSeats As System.Windows.Forms.PictureBox
    Friend WithEvents btn_UpperEndlineSeating As System.Windows.Forms.Button
    Friend WithEvents btn_LowerEndlineSeating As System.Windows.Forms.Button
    Friend WithEvents btn_SidelineSeating As System.Windows.Forms.Button
    Friend WithEvents btn_ClubSeats As System.Windows.Forms.Button
    Friend WithEvents lbl_Confirmation As System.Windows.Forms.Label
    Friend WithEvents btn_Purchase As System.Windows.Forms.Button
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents lbl_Title As System.Windows.Forms.Label

End Class
