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
        Me.lbl_GuitarStore = New System.Windows.Forms.Label()
        Me.lbl_Conformation = New System.Windows.Forms.Label()
        Me.btn_Guitar1 = New System.Windows.Forms.Button()
        Me.btn_Guitar2 = New System.Windows.Forms.Button()
        Me.btn_Guitar3 = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.Pic_Guitar1 = New System.Windows.Forms.PictureBox()
        Me.Pic_Guitar2 = New System.Windows.Forms.PictureBox()
        Me.Pic_Guitar3 = New System.Windows.Forms.PictureBox()
        Me.btn_Select = New System.Windows.Forms.Button()
        Me.btn_instructions = New System.Windows.Forms.Label()
        CType(Me.Pic_Guitar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Guitar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Guitar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_GuitarStore
        '
        Me.lbl_GuitarStore.AutoSize = True
        Me.lbl_GuitarStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GuitarStore.ForeColor = System.Drawing.Color.Red
        Me.lbl_GuitarStore.Location = New System.Drawing.Point(543, 50)
        Me.lbl_GuitarStore.Name = "lbl_GuitarStore"
        Me.lbl_GuitarStore.Size = New System.Drawing.Size(353, 69)
        Me.lbl_GuitarStore.TabIndex = 0
        Me.lbl_GuitarStore.Text = "Guitar Store"
        '
        'lbl_Conformation
        '
        Me.lbl_Conformation.AutoSize = True
        Me.lbl_Conformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Conformation.Location = New System.Drawing.Point(566, 1067)
        Me.lbl_Conformation.Name = "lbl_Conformation"
        Me.lbl_Conformation.Size = New System.Drawing.Size(347, 46)
        Me.lbl_Conformation.TabIndex = 1
        Me.lbl_Conformation.Text = "Enjoy Your Guitar!"
        '
        'btn_Guitar1
        '
        Me.btn_Guitar1.AutoSize = True
        Me.btn_Guitar1.Location = New System.Drawing.Point(218, 749)
        Me.btn_Guitar1.Name = "btn_Guitar1"
        Me.btn_Guitar1.Size = New System.Drawing.Size(312, 104)
        Me.btn_Guitar1.TabIndex = 2
        Me.btn_Guitar1.Text = "Guitar 1"
        Me.btn_Guitar1.UseVisualStyleBackColor = True
        '
        'btn_Guitar2
        '
        Me.btn_Guitar2.AutoSize = True
        Me.btn_Guitar2.Location = New System.Drawing.Point(574, 749)
        Me.btn_Guitar2.Name = "btn_Guitar2"
        Me.btn_Guitar2.Size = New System.Drawing.Size(312, 104)
        Me.btn_Guitar2.TabIndex = 3
        Me.btn_Guitar2.Text = "Guitar 2"
        Me.btn_Guitar2.UseVisualStyleBackColor = True
        '
        'btn_Guitar3
        '
        Me.btn_Guitar3.AutoSize = True
        Me.btn_Guitar3.Location = New System.Drawing.Point(937, 749)
        Me.btn_Guitar3.Name = "btn_Guitar3"
        Me.btn_Guitar3.Size = New System.Drawing.Size(312, 104)
        Me.btn_Guitar3.TabIndex = 4
        Me.btn_Guitar3.Text = "Guitar 3"
        Me.btn_Guitar3.UseVisualStyleBackColor = True
        '
        'Btn_Exit
        '
        Me.Btn_Exit.AutoSize = True
        Me.Btn_Exit.Location = New System.Drawing.Point(614, 1203)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(211, 86)
        Me.Btn_Exit.TabIndex = 5
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Pic_Guitar1
        '
        Me.Pic_Guitar1.Image = CType(resources.GetObject("Pic_Guitar1.Image"), System.Drawing.Image)
        Me.Pic_Guitar1.Location = New System.Drawing.Point(218, 262)
        Me.Pic_Guitar1.Name = "Pic_Guitar1"
        Me.Pic_Guitar1.Size = New System.Drawing.Size(312, 379)
        Me.Pic_Guitar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Guitar1.TabIndex = 6
        Me.Pic_Guitar1.TabStop = False
        '
        'Pic_Guitar2
        '
        Me.Pic_Guitar2.Image = CType(resources.GetObject("Pic_Guitar2.Image"), System.Drawing.Image)
        Me.Pic_Guitar2.Location = New System.Drawing.Point(600, 262)
        Me.Pic_Guitar2.Name = "Pic_Guitar2"
        Me.Pic_Guitar2.Size = New System.Drawing.Size(312, 379)
        Me.Pic_Guitar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Guitar2.TabIndex = 7
        Me.Pic_Guitar2.TabStop = False
        '
        'Pic_Guitar3
        '
        Me.Pic_Guitar3.Image = CType(resources.GetObject("Pic_Guitar3.Image"), System.Drawing.Image)
        Me.Pic_Guitar3.Location = New System.Drawing.Point(1009, 262)
        Me.Pic_Guitar3.Name = "Pic_Guitar3"
        Me.Pic_Guitar3.Size = New System.Drawing.Size(182, 379)
        Me.Pic_Guitar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Guitar3.TabIndex = 8
        Me.Pic_Guitar3.TabStop = False
        '
        'btn_Select
        '
        Me.btn_Select.AutoSize = True
        Me.btn_Select.Location = New System.Drawing.Point(600, 924)
        Me.btn_Select.Name = "btn_Select"
        Me.btn_Select.Size = New System.Drawing.Size(246, 81)
        Me.btn_Select.TabIndex = 9
        Me.btn_Select.Text = "Select Guitar"
        Me.btn_Select.UseVisualStyleBackColor = True
        '
        'btn_instructions
        '
        Me.btn_instructions.AutoSize = True
        Me.btn_instructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_instructions.Location = New System.Drawing.Point(482, 169)
        Me.btn_instructions.Name = "btn_instructions"
        Me.btn_instructions.Size = New System.Drawing.Size(543, 46)
        Me.btn_instructions.TabIndex = 10
        Me.btn_instructions.Text = "Please Choose a Guitar Type"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1503, 1483)
        Me.Controls.Add(Me.btn_instructions)
        Me.Controls.Add(Me.btn_Select)
        Me.Controls.Add(Me.Pic_Guitar3)
        Me.Controls.Add(Me.Pic_Guitar2)
        Me.Controls.Add(Me.Pic_Guitar1)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.btn_Guitar3)
        Me.Controls.Add(Me.btn_Guitar2)
        Me.Controls.Add(Me.btn_Guitar1)
        Me.Controls.Add(Me.lbl_Conformation)
        Me.Controls.Add(Me.lbl_GuitarStore)
        Me.Name = "Form1"
        CType(Me.Pic_Guitar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Guitar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Guitar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_GuitarStore As System.Windows.Forms.Label
    Friend WithEvents lbl_Conformation As System.Windows.Forms.Label
    Friend WithEvents btn_Guitar1 As System.Windows.Forms.Button
    Friend WithEvents btn_Guitar2 As System.Windows.Forms.Button
    Friend WithEvents btn_Guitar3 As System.Windows.Forms.Button
    Friend WithEvents Btn_Exit As System.Windows.Forms.Button
    Friend WithEvents Pic_Guitar1 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Guitar2 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Guitar3 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Select As System.Windows.Forms.Button
    Friend WithEvents btn_instructions As System.Windows.Forms.Label

End Class
