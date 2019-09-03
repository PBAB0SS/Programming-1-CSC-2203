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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.lbl_GroupSize = New System.Windows.Forms.Label()
        Me.lbl_Registration = New System.Windows.Forms.Label()
        Me.txt_GroupSize = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad_Convention = New System.Windows.Forms.RadioButton()
        Me.rad_ConventionAutographs = New System.Windows.Forms.RadioButton()
        Me.rad_ConventionSuperhero = New System.Windows.Forms.RadioButton()
        Me.rad_PreviewNight = New System.Windows.Forms.RadioButton()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1033, 356)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Lucida Sans Typewriter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.Crimson
        Me.lbl_Title.Location = New System.Drawing.Point(71, 398)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(927, 144)
        Me.lbl_Title.TabIndex = 1
        Me.lbl_Title.Text = "Comic Character " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Convention Registration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_GroupSize
        '
        Me.lbl_GroupSize.AutoSize = True
        Me.lbl_GroupSize.Font = New System.Drawing.Font("Lucida Sans Typewriter", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupSize.ForeColor = System.Drawing.Color.Crimson
        Me.lbl_GroupSize.Location = New System.Drawing.Point(331, 618)
        Me.lbl_GroupSize.Name = "lbl_GroupSize"
        Me.lbl_GroupSize.Size = New System.Drawing.Size(284, 45)
        Me.lbl_GroupSize.TabIndex = 2
        Me.lbl_GroupSize.Text = "Group Size:"
        '
        'lbl_Registration
        '
        Me.lbl_Registration.AutoSize = True
        Me.lbl_Registration.Font = New System.Drawing.Font("Lucida Sans Typewriter", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registration.ForeColor = System.Drawing.Color.Crimson
        Me.lbl_Registration.Location = New System.Drawing.Point(99, 1040)
        Me.lbl_Registration.Name = "lbl_Registration"
        Me.lbl_Registration.Size = New System.Drawing.Size(452, 45)
        Me.lbl_Registration.TabIndex = 3
        Me.lbl_Registration.Text = "Registration Cost:"
        '
        'txt_GroupSize
        '
        Me.txt_GroupSize.Font = New System.Drawing.Font("Lucida Sans Typewriter", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GroupSize.ForeColor = System.Drawing.Color.Crimson
        Me.txt_GroupSize.Location = New System.Drawing.Point(642, 618)
        Me.txt_GroupSize.Name = "txt_GroupSize"
        Me.txt_GroupSize.Size = New System.Drawing.Size(95, 54)
        Me.txt_GroupSize.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad_Convention)
        Me.GroupBox1.Controls.Add(Me.rad_ConventionAutographs)
        Me.GroupBox1.Controls.Add(Me.rad_ConventionSuperhero)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(107, 694)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(855, 237)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Badge Type"
        '
        'rad_Convention
        '
        Me.rad_Convention.AutoSize = True
        Me.rad_Convention.Location = New System.Drawing.Point(0, 177)
        Me.rad_Convention.Name = "rad_Convention"
        Me.rad_Convention.Size = New System.Drawing.Size(304, 49)
        Me.rad_Convention.TabIndex = 2
        Me.rad_Convention.TabStop = True
        Me.rad_Convention.Text = "Convention"
        Me.rad_Convention.UseVisualStyleBackColor = True
        '
        'rad_ConventionAutographs
        '
        Me.rad_ConventionAutographs.AutoSize = True
        Me.rad_ConventionAutographs.Location = New System.Drawing.Point(0, 109)
        Me.rad_ConventionAutographs.Name = "rad_ConventionAutographs"
        Me.rad_ConventionAutographs.Size = New System.Drawing.Size(616, 49)
        Me.rad_ConventionAutographs.TabIndex = 1
        Me.rad_ConventionAutographs.TabStop = True
        Me.rad_ConventionAutographs.Text = "Convention + Autographs"
        Me.rad_ConventionAutographs.UseVisualStyleBackColor = True
        '
        'rad_ConventionSuperhero
        '
        Me.rad_ConventionSuperhero.AutoSize = True
        Me.rad_ConventionSuperhero.Location = New System.Drawing.Point(3, 48)
        Me.rad_ConventionSuperhero.Name = "rad_ConventionSuperhero"
        Me.rad_ConventionSuperhero.Size = New System.Drawing.Size(856, 49)
        Me.rad_ConventionSuperhero.TabIndex = 0
        Me.rad_ConventionSuperhero.TabStop = True
        Me.rad_ConventionSuperhero.Text = "Convention + Superhero Experience"
        Me.rad_ConventionSuperhero.UseVisualStyleBackColor = True
        '
        'rad_PreviewNight
        '
        Me.rad_PreviewNight.AutoSize = True
        Me.rad_PreviewNight.BackColor = System.Drawing.Color.Yellow
        Me.rad_PreviewNight.Font = New System.Drawing.Font("Lucida Sans Typewriter", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_PreviewNight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rad_PreviewNight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rad_PreviewNight.Location = New System.Drawing.Point(107, 926)
        Me.rad_PreviewNight.Name = "rad_PreviewNight"
        Me.rad_PreviewNight.Size = New System.Drawing.Size(856, 49)
        Me.rad_PreviewNight.TabIndex = 3
        Me.rad_PreviewNight.Text = "Optional Preview Night           "
        Me.rad_PreviewNight.UseVisualStyleBackColor = False
        '
        'btn_Calculate
        '
        Me.btn_Calculate.AutoSize = True
        Me.btn_Calculate.BackColor = System.Drawing.Color.Yellow
        Me.btn_Calculate.Font = New System.Drawing.Font("Lucida Sans Typewriter", 10.0!)
        Me.btn_Calculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Calculate.Location = New System.Drawing.Point(247, 1171)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(246, 59)
        Me.btn_Calculate.TabIndex = 7
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = False
        '
        'btn_Clear
        '
        Me.btn_Clear.AutoSize = True
        Me.btn_Clear.BackColor = System.Drawing.Color.Yellow
        Me.btn_Clear.Font = New System.Drawing.Font("Lucida Sans Typewriter", 10.0!)
        Me.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Clear.Location = New System.Drawing.Point(629, 1171)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(192, 59)
        Me.btn_Clear.TabIndex = 8
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1068, 1275)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.rad_PreviewNight)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_GroupSize)
        Me.Controls.Add(Me.lbl_Registration)
        Me.Controls.Add(Me.lbl_GroupSize)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Chomic Character Convention"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_GroupSize As System.Windows.Forms.Label
    Friend WithEvents lbl_Registration As System.Windows.Forms.Label
    Friend WithEvents txt_GroupSize As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rad_Convention As System.Windows.Forms.RadioButton
    Friend WithEvents rad_ConventionAutographs As System.Windows.Forms.RadioButton
    Friend WithEvents rad_ConventionSuperhero As System.Windows.Forms.RadioButton
    Friend WithEvents rad_PreviewNight As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button

End Class
