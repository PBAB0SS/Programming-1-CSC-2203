'Worked with Richard

Public Class Form1
    Const Superheros = 330D
    Const Autographs = 255D
    Const Convention = 299D
    Const Preview = 59D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Clear.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        Dim GroupSize As Integer
        Dim initalCost As Integer

        btn_Clear.Enabled = True

        If IsNumeric(txt_GroupSize.Text) Then
            GroupSize = Convert.ToInt16(txt_GroupSize.Text)

            If rad_ConventionSuperhero.Checked = True Then
                initalCost = Superheros * GroupSize
            ElseIf rad_ConventionAutographs.Checked = True Then
                initalCost = Autographs * GroupSize
            Else : rad_Convention.Checked = True
                initalCost = Convention * GroupSize
            End If

            If rad_PreviewNight.Checked = True Then
                initalCost = initalCost + (GroupSize * Preview)
            End If

            If GroupSize > 20 Then
                MsgBox("Group size cannot be excede 20", MsgBoxStyle.Information, "Input Error")
                lbl_Registration.Text = "Registration Cost:"
            ElseIf GroupSize < 1 Then
                MsgBox("Group size cannot be less then 1", MsgBoxStyle.Information, "Input Error")
                lbl_Registration.Text = "Registration Cost:"
            Else
                lbl_Registration.Text = "Registration Cost: $" & initalCost
            End If

        Else : MsgBox("Please Enter a Value", MsgBoxStyle.Information, "Input Error")

        End If
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txt_GroupSize.Clear()
        lbl_Registration.Text = "Registration Cost:"
        rad_ConventionSuperhero.Checked = False
        rad_ConventionAutographs.Checked = False
        rad_Convention.Checked = False
        rad_PreviewNight.Checked = False
        btn_Clear.Enabled = False
    End Sub
End Class