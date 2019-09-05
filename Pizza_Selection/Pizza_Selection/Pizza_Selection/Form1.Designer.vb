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
        Me.lblPizzaSelection = New System.Windows.Forms.Label()
        Me.PicDeepDish = New System.Windows.Forms.PictureBox()
        Me.PicThinCrust = New System.Windows.Forms.PictureBox()
        Me.btnDeepDish = New System.Windows.Forms.Button()
        Me.btnSelectPizza = New System.Windows.Forms.Button()
        Me.btnThinCrust = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PicDeepDish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicThinCrust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPizzaSelection
        '
        Me.lblPizzaSelection.AutoSize = True
        Me.lblPizzaSelection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizzaSelection.Location = New System.Drawing.Point(625, 45)
        Me.lblPizzaSelection.Name = "lblPizzaSelection"
        Me.lblPizzaSelection.Size = New System.Drawing.Size(439, 65)
        Me.lblPizzaSelection.TabIndex = 0
        Me.lblPizzaSelection.Text = "Pizza Selection"
        '
        'PicDeepDish
        '
        Me.PicDeepDish.Image = CType(resources.GetObject("PicDeepDish.Image"), System.Drawing.Image)
        Me.PicDeepDish.Location = New System.Drawing.Point(419, 172)
        Me.PicDeepDish.Name = "PicDeepDish"
        Me.PicDeepDish.Size = New System.Drawing.Size(347, 250)
        Me.PicDeepDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDeepDish.TabIndex = 1
        Me.PicDeepDish.TabStop = False
        '
        'PicThinCrust
        '
        Me.PicThinCrust.Image = CType(resources.GetObject("PicThinCrust.Image"), System.Drawing.Image)
        Me.PicThinCrust.Location = New System.Drawing.Point(828, 172)
        Me.PicThinCrust.Name = "PicThinCrust"
        Me.PicThinCrust.Size = New System.Drawing.Size(347, 250)
        Me.PicThinCrust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicThinCrust.TabIndex = 2
        Me.PicThinCrust.TabStop = False
        '
        'btnDeepDish
        '
        Me.btnDeepDish.Location = New System.Drawing.Point(384, 540)
        Me.btnDeepDish.Name = "btnDeepDish"
        Me.btnDeepDish.Size = New System.Drawing.Size(250, 76)
        Me.btnDeepDish.TabIndex = 3
        Me.btnDeepDish.Text = "Deep Dish"
        Me.btnDeepDish.UseVisualStyleBackColor = True
        '
        'btnSelectPizza
        '
        Me.btnSelectPizza.Location = New System.Drawing.Point(714, 540)
        Me.btnSelectPizza.Name = "btnSelectPizza"
        Me.btnSelectPizza.Size = New System.Drawing.Size(250, 76)
        Me.btnSelectPizza.TabIndex = 4
        Me.btnSelectPizza.Text = "Select Pizza"
        Me.btnSelectPizza.UseVisualStyleBackColor = True
        '
        'btnThinCrust
        '
        Me.btnThinCrust.Location = New System.Drawing.Point(1052, 540)
        Me.btnThinCrust.Name = "btnThinCrust"
        Me.btnThinCrust.Size = New System.Drawing.Size(250, 76)
        Me.btnThinCrust.TabIndex = 5
        Me.btnThinCrust.Text = "Thin Crust"
        Me.btnThinCrust.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(394, 676)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(846, 37)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Choose a pizza type and then click the Select Pizza button"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Location = New System.Drawing.Point(615, 783)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(385, 37)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "Enjoy your pizza selection"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(687, 898)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(250, 76)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1671, 1158)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnThinCrust)
        Me.Controls.Add(Me.btnSelectPizza)
        Me.Controls.Add(Me.btnDeepDish)
        Me.Controls.Add(Me.PicThinCrust)
        Me.Controls.Add(Me.PicDeepDish)
        Me.Controls.Add(Me.lblPizzaSelection)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PicDeepDish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicThinCrust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPizzaSelection As System.Windows.Forms.Label
    Friend WithEvents PicDeepDish As System.Windows.Forms.PictureBox
    Friend WithEvents PicThinCrust As System.Windows.Forms.PictureBox
    Friend WithEvents btnDeepDish As System.Windows.Forms.Button
    Friend WithEvents btnSelectPizza As System.Windows.Forms.Button
    Friend WithEvents btnThinCrust As System.Windows.Forms.Button
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblConfirmation As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
