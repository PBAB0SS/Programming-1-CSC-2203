Public Class Form1
    Const SingleStatus = 0.22D
    Const Family = 0.198D
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Close()
    End Sub

    Private Sub btn_Calculate_Click_1(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        Dim Name As String
        Dim NumberOfHours As Decimal
        Dim PayPerHour As Decimal
        Dim Total As Decimal

        Name = txt_Fname.Text & " " & txt_Lname.Text

        NumberOfHours = Val(txt_Hours.Text)
        PayPerHour = Val(txt_PerHour.Text)

        If txt_Fname.Text = String.Empty Then
            MsgBox("Please Enter First", MsgBoxStyle.OkOnly, "Input Error")

        ElseIf txt_Lname.Text = String.Empty Then
            MsgBox("Please Enter Last Name", MsgBoxStyle.OkOnly, "Input Error")
        Else
            If txt_Hours.Text = String.Empty Then
                MsgBox("Please Enter Number of Hours Worked", MsgBoxStyle.OkOnly, "Input Error")

            ElseIf NumberOfHours > 60 Then
                MsgBox("Please Enter a Value Less then 60 for Number of Hours", MsgBoxStyle.OkOnly, "Input Error")
            ElseIf NumberOfHours < 8 Then
                MsgBox("Please Enter a Value Greater then 8 for Number of Hours", MsgBoxStyle.OkOnly, "Input Error")


            ElseIf txt_PerHour.Text = String.Empty Then
                MsgBox("Please Enter Pay Per Hour", MsgBoxStyle.OkOnly, "Input Error")
            ElseIf PayPerHour > 40.0 Then
                MsgBox("Please Enter a Value Less then $40.00 for Pay Per Hour", MsgBoxStyle.OkOnly, "Input Error")
            ElseIf PayPerHour < 7.25 Then
                MsgBox("Please Enter a Value Greater then $7.25 for Pay Per Hour", MsgBoxStyle.OkOnly, "Input Error")
            Else

                If rdo_Single.Checked = True Then
                    Total = (NumberOfHours * PayPerHour) - (NumberOfHours * PayPerHour * SingleStatus)
                ElseIf rdo_Family.Checked = True Then
                    Total = (NumberOfHours * PayPerHour) - (NumberOfHours * PayPerHour * Family)
                End If

            End If
            lbl_Output.Text = Name & " " & Total.ToString("C")

        End If

    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txt_Fname.Clear()
        txt_Lname.Clear()
        txt_Hours.Clear()
        txt_PerHour.Clear()
        rdo_Family.Checked = False
        rdo_Single.Checked = False
        lbl_Output.Text = ""
    End Sub
End Class