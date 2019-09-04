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
        Me.lbl_TechJobFair = New System.Windows.Forms.Label()
        Me.lbl_AllStudentsAreWelcome = New System.Windows.Forms.Label()
        Me.btn_ViewJobFiarDetails = New System.Windows.Forms.Button()
        Me.lbl_Date = New System.Windows.Forms.Label()
        Me.lbl_LocatedInLochlanHall = New System.Windows.Forms.Label()
        Me.lbl_Room101 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_ExitWindow = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_TechJobFair
        '
        Me.lbl_TechJobFair.AutoSize = True
        Me.lbl_TechJobFair.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lbl_TechJobFair.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TechJobFair.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbl_TechJobFair.Location = New System.Drawing.Point(136, 75)
        Me.lbl_TechJobFair.Name = "lbl_TechJobFair"
        Me.lbl_TechJobFair.Size = New System.Drawing.Size(628, 106)
        Me.lbl_TechJobFair.TabIndex = 0
        Me.lbl_TechJobFair.Text = "Tech Job Fair"
        '
        'lbl_AllStudentsAreWelcome
        '
        Me.lbl_AllStudentsAreWelcome.AutoSize = True
        Me.lbl_AllStudentsAreWelcome.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AllStudentsAreWelcome.Location = New System.Drawing.Point(179, 199)
        Me.lbl_AllStudentsAreWelcome.Name = "lbl_AllStudentsAreWelcome"
        Me.lbl_AllStudentsAreWelcome.Size = New System.Drawing.Size(522, 53)
        Me.lbl_AllStudentsAreWelcome.TabIndex = 2
        Me.lbl_AllStudentsAreWelcome.Text = "All Students are Welcome"
        '
        'btn_ViewJobFiarDetails
        '
        Me.btn_ViewJobFiarDetails.AutoSize = True
        Me.btn_ViewJobFiarDetails.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ViewJobFiarDetails.Location = New System.Drawing.Point(188, 354)
        Me.btn_ViewJobFiarDetails.Name = "btn_ViewJobFiarDetails"
        Me.btn_ViewJobFiarDetails.Size = New System.Drawing.Size(464, 102)
        Me.btn_ViewJobFiarDetails.TabIndex = 3
        Me.btn_ViewJobFiarDetails.Text = "View Job Fair Details"
        Me.btn_ViewJobFiarDetails.UseVisualStyleBackColor = True
        '
        'lbl_Date
        '
        Me.lbl_Date.AutoSize = True
        Me.lbl_Date.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Date.Location = New System.Drawing.Point(278, 579)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(263, 53)
        Me.lbl_Date.TabIndex = 4
        Me.lbl_Date.Text = "May 2, 2016"
        '
        'lbl_LocatedInLochlanHall
        '
        Me.lbl_LocatedInLochlanHall.AutoSize = True
        Me.lbl_LocatedInLochlanHall.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LocatedInLochlanHall.Location = New System.Drawing.Point(190, 749)
        Me.lbl_LocatedInLochlanHall.Name = "lbl_LocatedInLochlanHall"
        Me.lbl_LocatedInLochlanHall.Size = New System.Drawing.Size(473, 53)
        Me.lbl_LocatedInLochlanHall.TabIndex = 5
        Me.lbl_LocatedInLochlanHall.Text = "Located in Lochlan Hall"
        '
        'lbl_Room101
        '
        Me.lbl_Room101.AutoSize = True
        Me.lbl_Room101.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Room101.Location = New System.Drawing.Point(278, 919)
        Me.lbl_Room101.Name = "lbl_Room101"
        Me.lbl_Room101.Size = New System.Drawing.Size(221, 53)
        Me.lbl_Room101.TabIndex = 6
        Me.lbl_Room101.Text = "Room 101"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(910, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(719, 1281)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btn_ExitWindow
        '
        Me.btn_ExitWindow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_ExitWindow.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ExitWindow.ForeColor = System.Drawing.Color.Honeydew
        Me.btn_ExitWindow.Location = New System.Drawing.Point(287, 1210)
        Me.btn_ExitWindow.Name = "btn_ExitWindow"
        Me.btn_ExitWindow.Size = New System.Drawing.Size(279, 79)
        Me.btn_ExitWindow.TabIndex = 9
        Me.btn_ExitWindow.Text = "Exit Window"
        Me.btn_ExitWindow.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(1657, 1345)
        Me.Controls.Add(Me.btn_ExitWindow)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_Room101)
        Me.Controls.Add(Me.lbl_LocatedInLochlanHall)
        Me.Controls.Add(Me.lbl_Date)
        Me.Controls.Add(Me.btn_ViewJobFiarDetails)
        Me.Controls.Add(Me.lbl_AllStudentsAreWelcome)
        Me.Controls.Add(Me.lbl_TechJobFair)
        Me.Name = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_TechJobFair As System.Windows.Forms.Label
    Friend WithEvents lbl_AllStudentsAreWelcome As System.Windows.Forms.Label
    Friend WithEvents btn_ViewJobFiarDetails As System.Windows.Forms.Button
    Friend WithEvents lbl_Date As System.Windows.Forms.Label
    Friend WithEvents lbl_LocatedInLochlanHall As System.Windows.Forms.Label
    Friend WithEvents lbl_Room101 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_ExitWindow As System.Windows.Forms.Button

End Class
