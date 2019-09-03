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
        Me.cbo_Plans = New System.Windows.Forms.ComboBox()
        Me.lbl_GB = New System.Windows.Forms.Label()
        Me.txt_GbUsed = New System.Windows.Forms.TextBox()
        Me.lbl_Info = New System.Windows.Forms.Label()
        Me.lbl_CBO = New System.Windows.Forms.Label()
        Me.lbl_Output = New System.Windows.Forms.Label()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        resources.ApplyResources(Me.lbl_Title, "lbl_Title")
        Me.lbl_Title.Name = "lbl_Title"
        '
        'cbo_Plans
        '
        Me.cbo_Plans.BackColor = System.Drawing.SystemColors.Window
        Me.cbo_Plans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Plans.FormattingEnabled = True
        Me.cbo_Plans.Items.AddRange(New Object() {resources.GetString("cbo_Plans.Items"), resources.GetString("cbo_Plans.Items1")})
        resources.ApplyResources(Me.cbo_Plans, "cbo_Plans")
        Me.cbo_Plans.Name = "cbo_Plans"
        '
        'lbl_GB
        '
        resources.ApplyResources(Me.lbl_GB, "lbl_GB")
        Me.lbl_GB.Name = "lbl_GB"
        '
        'txt_GbUsed
        '
        resources.ApplyResources(Me.txt_GbUsed, "txt_GbUsed")
        Me.txt_GbUsed.Name = "txt_GbUsed"
        '
        'lbl_Info
        '
        resources.ApplyResources(Me.lbl_Info, "lbl_Info")
        Me.lbl_Info.Name = "lbl_Info"
        '
        'lbl_CBO
        '
        Me.lbl_CBO.BackColor = System.Drawing.SystemColors.ControlLight
        resources.ApplyResources(Me.lbl_CBO, "lbl_CBO")
        Me.lbl_CBO.Name = "lbl_CBO"
        '
        'lbl_Output
        '
        resources.ApplyResources(Me.lbl_Output, "lbl_Output")
        Me.lbl_Output.Name = "lbl_Output"
        '
        'btn_Calculate
        '
        resources.ApplyResources(Me.btn_Calculate, "btn_Calculate")
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        resources.ApplyResources(Me.btn_Clear, "btn_Clear")
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.lbl_Output)
        Me.Controls.Add(Me.lbl_CBO)
        Me.Controls.Add(Me.lbl_Info)
        Me.Controls.Add(Me.txt_GbUsed)
        Me.Controls.Add(Me.lbl_GB)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.cbo_Plans)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents cbo_Plans As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_GB As System.Windows.Forms.Label
    Friend WithEvents txt_GbUsed As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Info As System.Windows.Forms.Label
    Friend WithEvents lbl_CBO As System.Windows.Forms.Label
    Friend WithEvents lbl_Output As System.Windows.Forms.Label
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button

End Class
