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
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.lbl_StartingAmount = New System.Windows.Forms.Label()
        Me.txt_StartingAmount = New System.Windows.Forms.TextBox()
        Me.chk_InterestRate = New System.Windows.Forms.CheckBox()
        Me.lbl_WhatIsYourInterest = New System.Windows.Forms.Label()
        Me.txt_WhatIsInterest = New System.Windows.Forms.TextBox()
        Me.lbl_Checks = New System.Windows.Forms.Label()
        Me.txt_Checks = New System.Windows.Forms.TextBox()
        Me.lbl_ATM = New System.Windows.Forms.Label()
        Me.txt_ATM = New System.Windows.Forms.TextBox()
        Me.lbl_Deposits = New System.Windows.Forms.Label()
        Me.txt_Deposits = New System.Windows.Forms.TextBox()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.lbl_Output = New System.Windows.Forms.Label()
        Me.btn_CheckAdd = New System.Windows.Forms.Button()
        Me.btn_ATMAdd = New System.Windows.Forms.Button()
        Me.txt_DepositsAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Location = New System.Drawing.Point(580, 9)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(328, 37)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "Online Bank Statment"
        '
        'lbl_StartingAmount
        '
        Me.lbl_StartingAmount.AutoSize = True
        Me.lbl_StartingAmount.Location = New System.Drawing.Point(154, 175)
        Me.lbl_StartingAmount.Name = "lbl_StartingAmount"
        Me.lbl_StartingAmount.Size = New System.Drawing.Size(249, 37)
        Me.lbl_StartingAmount.TabIndex = 1
        Me.lbl_StartingAmount.Text = "Starting Amount"
        '
        'txt_StartingAmount
        '
        Me.txt_StartingAmount.Location = New System.Drawing.Point(458, 168)
        Me.txt_StartingAmount.Name = "txt_StartingAmount"
        Me.txt_StartingAmount.Size = New System.Drawing.Size(100, 44)
        Me.txt_StartingAmount.TabIndex = 2
        '
        'chk_InterestRate
        '
        Me.chk_InterestRate.AutoSize = True
        Me.chk_InterestRate.Location = New System.Drawing.Point(161, 272)
        Me.chk_InterestRate.Name = "chk_InterestRate"
        Me.chk_InterestRate.Size = New System.Drawing.Size(623, 41)
        Me.chk_InterestRate.TabIndex = 4
        Me.chk_InterestRate.Text = "Does Your Bank Contain Interest Rate?"
        Me.chk_InterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_InterestRate.UseVisualStyleBackColor = True
        '
        'lbl_WhatIsYourInterest
        '
        Me.lbl_WhatIsYourInterest.AutoSize = True
        Me.lbl_WhatIsYourInterest.Location = New System.Drawing.Point(154, 350)
        Me.lbl_WhatIsYourInterest.Name = "lbl_WhatIsYourInterest"
        Me.lbl_WhatIsYourInterest.Size = New System.Drawing.Size(309, 37)
        Me.lbl_WhatIsYourInterest.TabIndex = 5
        Me.lbl_WhatIsYourInterest.Text = "What is the Interest?"
        '
        'txt_WhatIsInterest
        '
        Me.txt_WhatIsInterest.Location = New System.Drawing.Point(504, 350)
        Me.txt_WhatIsInterest.Name = "txt_WhatIsInterest"
        Me.txt_WhatIsInterest.Size = New System.Drawing.Size(100, 44)
        Me.txt_WhatIsInterest.TabIndex = 6
        '
        'lbl_Checks
        '
        Me.lbl_Checks.AutoSize = True
        Me.lbl_Checks.Location = New System.Drawing.Point(154, 465)
        Me.lbl_Checks.Name = "lbl_Checks"
        Me.lbl_Checks.Size = New System.Drawing.Size(123, 37)
        Me.lbl_Checks.TabIndex = 7
        Me.lbl_Checks.Text = "Checks"
        '
        'txt_Checks
        '
        Me.txt_Checks.Location = New System.Drawing.Point(303, 458)
        Me.txt_Checks.Name = "txt_Checks"
        Me.txt_Checks.Size = New System.Drawing.Size(100, 44)
        Me.txt_Checks.TabIndex = 8
        '
        'lbl_ATM
        '
        Me.lbl_ATM.AutoSize = True
        Me.lbl_ATM.Location = New System.Drawing.Point(166, 548)
        Me.lbl_ATM.Name = "lbl_ATM"
        Me.lbl_ATM.Size = New System.Drawing.Size(229, 37)
        Me.lbl_ATM.TabIndex = 9
        Me.lbl_ATM.Text = "ATM Withdraw"
        '
        'txt_ATM
        '
        Me.txt_ATM.Location = New System.Drawing.Point(437, 541)
        Me.txt_ATM.Name = "txt_ATM"
        Me.txt_ATM.Size = New System.Drawing.Size(100, 44)
        Me.txt_ATM.TabIndex = 10
        '
        'lbl_Deposits
        '
        Me.lbl_Deposits.AutoSize = True
        Me.lbl_Deposits.Location = New System.Drawing.Point(166, 643)
        Me.lbl_Deposits.Name = "lbl_Deposits"
        Me.lbl_Deposits.Size = New System.Drawing.Size(141, 37)
        Me.lbl_Deposits.TabIndex = 11
        Me.lbl_Deposits.Text = "Deposits"
        '
        'txt_Deposits
        '
        Me.txt_Deposits.Location = New System.Drawing.Point(352, 636)
        Me.txt_Deposits.Name = "txt_Deposits"
        Me.txt_Deposits.Size = New System.Drawing.Size(100, 44)
        Me.txt_Deposits.TabIndex = 12
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(437, 815)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(176, 84)
        Me.btn_Clear.TabIndex = 13
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(161, 815)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(163, 84)
        Me.btn_Calculate.TabIndex = 14
        Me.btn_Calculate.Text = "Done"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'lbl_Output
        '
        Me.lbl_Output.AutoSize = True
        Me.lbl_Output.Location = New System.Drawing.Point(154, 1013)
        Me.lbl_Output.Name = "lbl_Output"
        Me.lbl_Output.Size = New System.Drawing.Size(111, 37)
        Me.lbl_Output.TabIndex = 15
        Me.lbl_Output.Text = "Label1"
        '
        'btn_CheckAdd
        '
        Me.btn_CheckAdd.AutoSize = True
        Me.btn_CheckAdd.Location = New System.Drawing.Point(637, 458)
        Me.btn_CheckAdd.Name = "btn_CheckAdd"
        Me.btn_CheckAdd.Size = New System.Drawing.Size(147, 56)
        Me.btn_CheckAdd.TabIndex = 16
        Me.btn_CheckAdd.Text = "Add"
        Me.btn_CheckAdd.UseVisualStyleBackColor = True
        '
        'btn_ATMAdd
        '
        Me.btn_ATMAdd.AutoSize = True
        Me.btn_ATMAdd.Location = New System.Drawing.Point(637, 544)
        Me.btn_ATMAdd.Name = "btn_ATMAdd"
        Me.btn_ATMAdd.Size = New System.Drawing.Size(147, 65)
        Me.btn_ATMAdd.TabIndex = 17
        Me.btn_ATMAdd.Text = "Add"
        Me.btn_ATMAdd.UseVisualStyleBackColor = True
        '
        'txt_DepositsAdd
        '
        Me.txt_DepositsAdd.AutoSize = True
        Me.txt_DepositsAdd.Location = New System.Drawing.Point(637, 636)
        Me.txt_DepositsAdd.Name = "txt_DepositsAdd"
        Me.txt_DepositsAdd.Size = New System.Drawing.Size(147, 55)
        Me.txt_DepositsAdd.TabIndex = 18
        Me.txt_DepositsAdd.Text = "Add"
        Me.txt_DepositsAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 1314)
        Me.Controls.Add(Me.txt_DepositsAdd)
        Me.Controls.Add(Me.btn_ATMAdd)
        Me.Controls.Add(Me.btn_CheckAdd)
        Me.Controls.Add(Me.lbl_Output)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.txt_Deposits)
        Me.Controls.Add(Me.lbl_Deposits)
        Me.Controls.Add(Me.txt_ATM)
        Me.Controls.Add(Me.lbl_ATM)
        Me.Controls.Add(Me.txt_Checks)
        Me.Controls.Add(Me.lbl_Checks)
        Me.Controls.Add(Me.txt_WhatIsInterest)
        Me.Controls.Add(Me.lbl_WhatIsYourInterest)
        Me.Controls.Add(Me.chk_InterestRate)
        Me.Controls.Add(Me.txt_StartingAmount)
        Me.Controls.Add(Me.lbl_StartingAmount)
        Me.Controls.Add(Me.lbl_Title)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_StartingAmount As System.Windows.Forms.Label
    Friend WithEvents txt_StartingAmount As System.Windows.Forms.TextBox
    Friend WithEvents chk_InterestRate As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_WhatIsYourInterest As System.Windows.Forms.Label
    Friend WithEvents txt_WhatIsInterest As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Checks As System.Windows.Forms.Label
    Friend WithEvents txt_Checks As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ATM As System.Windows.Forms.Label
    Friend WithEvents txt_ATM As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Deposits As System.Windows.Forms.Label
    Friend WithEvents txt_Deposits As System.Windows.Forms.TextBox
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents lbl_Output As System.Windows.Forms.Label
    Friend WithEvents btn_CheckAdd As System.Windows.Forms.Button
    Friend WithEvents btn_ATMAdd As System.Windows.Forms.Button
    Friend WithEvents txt_DepositsAdd As System.Windows.Forms.Button

End Class
