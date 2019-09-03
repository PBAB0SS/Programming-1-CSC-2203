<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problem3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Problem3))
        Me.btn_Return3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_EmployeeID = New System.Windows.Forms.TextBox()
        Me.txt_FullName = New System.Windows.Forms.TextBox()
        Me.chk_PreConference = New System.Windows.Forms.CheckBox()
        Me.chk_AI = New System.Windows.Forms.CheckBox()
        Me.chk_ComputerOrginization = New System.Windows.Forms.CheckBox()
        Me.chk_SoftwareEngineering = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.rdo_1Day = New System.Windows.Forms.RadioButton()
        Me.rdo_2Day = New System.Windows.Forms.RadioButton()
        Me.rdo_3Day = New System.Windows.Forms.RadioButton()
        Me.rdo_4Day = New System.Windows.Forms.RadioButton()
        Me.rdo_5Day = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Return3
        '
        Me.btn_Return3.Location = New System.Drawing.Point(650, 1298)
        Me.btn_Return3.Name = "btn_Return3"
        Me.btn_Return3.Size = New System.Drawing.Size(229, 123)
        Me.btn_Return3.TabIndex = 1
        Me.btn_Return3.Text = "Return to Start Menu"
        Me.btn_Return3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1111, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 249)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txt_EmployeeID
        '
        Me.txt_EmployeeID.ForeColor = System.Drawing.Color.DimGray
        Me.txt_EmployeeID.Location = New System.Drawing.Point(394, 40)
        Me.txt_EmployeeID.Name = "txt_EmployeeID"
        Me.txt_EmployeeID.Size = New System.Drawing.Size(201, 44)
        Me.txt_EmployeeID.TabIndex = 3
        Me.txt_EmployeeID.Text = "Employee ID"
        '
        'txt_FullName
        '
        Me.txt_FullName.ForeColor = System.Drawing.Color.DimGray
        Me.txt_FullName.Location = New System.Drawing.Point(394, 132)
        Me.txt_FullName.Name = "txt_FullName"
        Me.txt_FullName.Size = New System.Drawing.Size(201, 44)
        Me.txt_FullName.TabIndex = 4
        Me.txt_FullName.Text = "Full Name"
        '
        'chk_PreConference
        '
        Me.chk_PreConference.AutoSize = True
        Me.chk_PreConference.Location = New System.Drawing.Point(458, 816)
        Me.chk_PreConference.Name = "chk_PreConference"
        Me.chk_PreConference.Size = New System.Drawing.Size(381, 41)
        Me.chk_PreConference.TabIndex = 11
        Me.chk_PreConference.Text = "Preconference Course"
        Me.chk_PreConference.UseVisualStyleBackColor = True
        '
        'chk_AI
        '
        Me.chk_AI.AutoSize = True
        Me.chk_AI.Location = New System.Drawing.Point(0, 53)
        Me.chk_AI.Name = "chk_AI"
        Me.chk_AI.Size = New System.Drawing.Size(337, 41)
        Me.chk_AI.TabIndex = 12
        Me.chk_AI.Text = "Artificial Inteligence"
        Me.chk_AI.UseVisualStyleBackColor = True
        '
        'chk_ComputerOrginization
        '
        Me.chk_ComputerOrginization.AutoSize = True
        Me.chk_ComputerOrginization.Location = New System.Drawing.Point(387, 53)
        Me.chk_ComputerOrginization.Name = "chk_ComputerOrginization"
        Me.chk_ComputerOrginization.Size = New System.Drawing.Size(385, 41)
        Me.chk_ComputerOrginization.TabIndex = 13
        Me.chk_ComputerOrginization.Text = "Computer Orginization"
        Me.chk_ComputerOrginization.UseVisualStyleBackColor = True
        '
        'chk_SoftwareEngineering
        '
        Me.chk_SoftwareEngineering.AutoSize = True
        Me.chk_SoftwareEngineering.Location = New System.Drawing.Point(825, 53)
        Me.chk_SoftwareEngineering.Name = "chk_SoftwareEngineering"
        Me.chk_SoftwareEngineering.Size = New System.Drawing.Size(368, 41)
        Me.chk_SoftwareEngineering.TabIndex = 14
        Me.chk_SoftwareEngineering.Text = "Software Engineering"
        Me.chk_SoftwareEngineering.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_AI)
        Me.GroupBox1.Controls.Add(Me.chk_SoftwareEngineering)
        Me.GroupBox1.Controls.Add(Me.chk_ComputerOrginization)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 863)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1265, 137)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(554, 997)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(403, 201)
        Me.btn_Calculate.TabIndex = 16
        Me.btn_Calculate.Text = "Calculate Cost"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(118, 1046)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(225, 152)
        Me.btn_Clear.TabIndex = 17
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 37
        Me.ListBox1.Location = New System.Drawing.Point(1138, 987)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(330, 374)
        Me.ListBox1.TabIndex = 18
        '
        'rdo_1Day
        '
        Me.rdo_1Day.AutoSize = True
        Me.rdo_1Day.Location = New System.Drawing.Point(6, 43)
        Me.rdo_1Day.Name = "rdo_1Day"
        Me.rdo_1Day.Size = New System.Drawing.Size(77, 41)
        Me.rdo_1Day.TabIndex = 19
        Me.rdo_1Day.TabStop = True
        Me.rdo_1Day.Text = "1"
        Me.rdo_1Day.UseVisualStyleBackColor = True
        '
        'rdo_2Day
        '
        Me.rdo_2Day.AutoSize = True
        Me.rdo_2Day.Location = New System.Drawing.Point(6, 95)
        Me.rdo_2Day.Name = "rdo_2Day"
        Me.rdo_2Day.Size = New System.Drawing.Size(79, 41)
        Me.rdo_2Day.TabIndex = 20
        Me.rdo_2Day.TabStop = True
        Me.rdo_2Day.Text = "2"
        Me.rdo_2Day.UseVisualStyleBackColor = True
        '
        'rdo_3Day
        '
        Me.rdo_3Day.AutoSize = True
        Me.rdo_3Day.Location = New System.Drawing.Point(6, 142)
        Me.rdo_3Day.Name = "rdo_3Day"
        Me.rdo_3Day.Size = New System.Drawing.Size(79, 41)
        Me.rdo_3Day.TabIndex = 21
        Me.rdo_3Day.TabStop = True
        Me.rdo_3Day.Text = "3"
        Me.rdo_3Day.UseVisualStyleBackColor = True
        '
        'rdo_4Day
        '
        Me.rdo_4Day.AutoSize = True
        Me.rdo_4Day.Location = New System.Drawing.Point(6, 189)
        Me.rdo_4Day.Name = "rdo_4Day"
        Me.rdo_4Day.Size = New System.Drawing.Size(79, 41)
        Me.rdo_4Day.TabIndex = 22
        Me.rdo_4Day.TabStop = True
        Me.rdo_4Day.Text = "4"
        Me.rdo_4Day.UseVisualStyleBackColor = True
        '
        'rdo_5Day
        '
        Me.rdo_5Day.AutoSize = True
        Me.rdo_5Day.Location = New System.Drawing.Point(6, 236)
        Me.rdo_5Day.Name = "rdo_5Day"
        Me.rdo_5Day.Size = New System.Drawing.Size(79, 41)
        Me.rdo_5Day.TabIndex = 23
        Me.rdo_5Day.TabStop = True
        Me.rdo_5Day.Text = "5"
        Me.rdo_5Day.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdo_1Day)
        Me.GroupBox2.Controls.Add(Me.rdo_5Day)
        Me.GroupBox2.Controls.Add(Me.rdo_4Day)
        Me.GroupBox2.Controls.Add(Me.rdo_2Day)
        Me.GroupBox2.Controls.Add(Me.rdo_3Day)
        Me.GroupBox2.Location = New System.Drawing.Point(362, 270)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 283)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Days Attending?"
        '
        'Problem3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1525, 1448)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chk_PreConference)
        Me.Controls.Add(Me.txt_FullName)
        Me.Controls.Add(Me.txt_EmployeeID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_Return3)
        Me.Name = "Problem3"
        Me.Text = "Problem3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Return3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_EmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txt_FullName As System.Windows.Forms.TextBox
    Friend WithEvents chk_PreConference As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AI As System.Windows.Forms.CheckBox
    Friend WithEvents chk_ComputerOrginization As System.Windows.Forms.CheckBox
    Friend WithEvents chk_SoftwareEngineering As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents rdo_1Day As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_2Day As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_3Day As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_4Day As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_5Day As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
