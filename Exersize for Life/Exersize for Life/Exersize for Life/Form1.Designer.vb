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
        Me.lbl_FName = New System.Windows.Forms.Label()
        Me.lbl_DOB = New System.Windows.Forms.Label()
        Me.lbl_CurrentDate = New System.Windows.Forms.Label()
        Me.txt_DOBMonth = New System.Windows.Forms.TextBox()
        Me.txt_FName = New System.Windows.Forms.TextBox()
        Me.txt_DOBDay = New System.Windows.Forms.TextBox()
        Me.txt_DOBYear = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txt_CurrentDateYear = New System.Windows.Forms.TextBox()
        Me.txt_CurrentDateDate = New System.Windows.Forms.TextBox()
        Me.txt_CurrentDateMonth = New System.Windows.Forms.TextBox()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.lbl_DataOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Location = New System.Drawing.Point(348, 116)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(571, 37)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "YMCA Exersize For Lifetime Calculator"
        '
        'lbl_FName
        '
        Me.lbl_FName.AutoSize = True
        Me.lbl_FName.Location = New System.Drawing.Point(186, 304)
        Me.lbl_FName.Name = "lbl_FName"
        Me.lbl_FName.Size = New System.Drawing.Size(184, 37)
        Me.lbl_FName.TabIndex = 1
        Me.lbl_FName.Text = "First Name:"
        '
        'lbl_DOB
        '
        Me.lbl_DOB.AutoSize = True
        Me.lbl_DOB.Location = New System.Drawing.Point(186, 383)
        Me.lbl_DOB.Name = "lbl_DOB"
        Me.lbl_DOB.Size = New System.Drawing.Size(195, 37)
        Me.lbl_DOB.TabIndex = 2
        Me.lbl_DOB.Text = "Date of Birth"
        '
        'lbl_CurrentDate
        '
        Me.lbl_CurrentDate.AutoSize = True
        Me.lbl_CurrentDate.Location = New System.Drawing.Point(186, 483)
        Me.lbl_CurrentDate.Name = "lbl_CurrentDate"
        Me.lbl_CurrentDate.Size = New System.Drawing.Size(200, 37)
        Me.lbl_CurrentDate.TabIndex = 3
        Me.lbl_CurrentDate.Text = "Current Date"
        '
        'txt_DOBMonth
        '
        Me.txt_DOBMonth.Location = New System.Drawing.Point(560, 380)
        Me.txt_DOBMonth.Name = "txt_DOBMonth"
        Me.txt_DOBMonth.Size = New System.Drawing.Size(84, 44)
        Me.txt_DOBMonth.TabIndex = 5
        '
        'txt_FName
        '
        Me.txt_FName.Location = New System.Drawing.Point(535, 297)
        Me.txt_FName.Name = "txt_FName"
        Me.txt_FName.Size = New System.Drawing.Size(302, 44)
        Me.txt_FName.TabIndex = 6
        '
        'txt_DOBDay
        '
        Me.txt_DOBDay.Location = New System.Drawing.Point(658, 383)
        Me.txt_DOBDay.Name = "txt_DOBDay"
        Me.txt_DOBDay.Size = New System.Drawing.Size(92, 44)
        Me.txt_DOBDay.TabIndex = 7
        '
        'txt_DOBYear
        '
        Me.txt_DOBYear.Location = New System.Drawing.Point(765, 383)
        Me.txt_DOBYear.Name = "txt_DOBYear"
        Me.txt_DOBYear.Size = New System.Drawing.Size(154, 44)
        Me.txt_DOBYear.TabIndex = 8
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'txt_CurrentDateYear
        '
        Me.txt_CurrentDateYear.Location = New System.Drawing.Point(714, 480)
        Me.txt_CurrentDateYear.Name = "txt_CurrentDateYear"
        Me.txt_CurrentDateYear.Size = New System.Drawing.Size(111, 44)
        Me.txt_CurrentDateYear.TabIndex = 11
        '
        'txt_CurrentDateDate
        '
        Me.txt_CurrentDateDate.Location = New System.Drawing.Point(616, 480)
        Me.txt_CurrentDateDate.Name = "txt_CurrentDateDate"
        Me.txt_CurrentDateDate.Size = New System.Drawing.Size(72, 44)
        Me.txt_CurrentDateDate.TabIndex = 10
        '
        'txt_CurrentDateMonth
        '
        Me.txt_CurrentDateMonth.Location = New System.Drawing.Point(521, 480)
        Me.txt_CurrentDateMonth.Name = "txt_CurrentDateMonth"
        Me.txt_CurrentDateMonth.Size = New System.Drawing.Size(72, 44)
        Me.txt_CurrentDateMonth.TabIndex = 9
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(109, 792)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(195, 72)
        Me.btn_Calculate.TabIndex = 12
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(493, 792)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(195, 72)
        Me.btn_Clear.TabIndex = 13
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(879, 803)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(195, 72)
        Me.btn_Exit.TabIndex = 14
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'lbl_DataOutput
        '
        Me.lbl_DataOutput.AutoSize = True
        Me.lbl_DataOutput.Location = New System.Drawing.Point(186, 605)
        Me.lbl_DataOutput.Name = "lbl_DataOutput"
        Me.lbl_DataOutput.Size = New System.Drawing.Size(353, 111)
        Me.lbl_DataOutput.TabIndex = 15
        Me.lbl_DataOutput.Text = "                          Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hours Exersized in Life:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 1001)
        Me.Controls.Add(Me.lbl_DataOutput)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.txt_CurrentDateYear)
        Me.Controls.Add(Me.txt_CurrentDateDate)
        Me.Controls.Add(Me.txt_CurrentDateMonth)
        Me.Controls.Add(Me.txt_DOBYear)
        Me.Controls.Add(Me.txt_DOBDay)
        Me.Controls.Add(Me.txt_FName)
        Me.Controls.Add(Me.txt_DOBMonth)
        Me.Controls.Add(Me.lbl_CurrentDate)
        Me.Controls.Add(Me.lbl_DOB)
        Me.Controls.Add(Me.lbl_FName)
        Me.Controls.Add(Me.lbl_Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_FName As System.Windows.Forms.Label
    Friend WithEvents lbl_DOB As System.Windows.Forms.Label
    Friend WithEvents lbl_CurrentDate As System.Windows.Forms.Label
    Friend WithEvents txt_DOBMonth As System.Windows.Forms.TextBox
    Friend WithEvents txt_FName As System.Windows.Forms.TextBox
    Friend WithEvents txt_DOBDay As System.Windows.Forms.TextBox
    Friend WithEvents txt_DOBYear As System.Windows.Forms.TextBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents txt_CurrentDateYear As System.Windows.Forms.TextBox
    Friend WithEvents txt_CurrentDateDate As System.Windows.Forms.TextBox
    Friend WithEvents txt_CurrentDateMonth As System.Windows.Forms.TextBox
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents lbl_DataOutput As System.Windows.Forms.Label

End Class
