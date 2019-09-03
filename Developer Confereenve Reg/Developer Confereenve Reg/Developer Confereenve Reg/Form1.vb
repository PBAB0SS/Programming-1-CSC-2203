Public Class Form1
    Const A = 795D
    Const B = 645D
    Const C = 475D
    Const D = 385D
    Const Discount = 0.15D

    Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click
        Dim Total As Decimal

        If Val(txt_NumberOfAttendees.Text) < 1 Or txt_NumberOfAttendees.Text = "" Then
            MsgBox("Please Enter Number of Emploies Attending Conference")
        ElseIf Val(txt_NumberOfAttendees.Text) > 16 Then
            MsgBox("No more then 16 emploies can attend the conference.")
        Else

            If Val(txt_NumberOfAttendees.Text) = 1 And check_Discount.Checked = False Then
                Total = A * txt_NumberOfAttendees.Text
            ElseIf Val(txt_NumberOfAttendees.Text) >= 2 And Val(txt_NumberOfAttendees.Text) <= 4 And check_Discount.Checked = False Then
                Total = B * txt_NumberOfAttendees.Text
            ElseIf Val(txt_NumberOfAttendees.Text) >= 5 And Val(txt_NumberOfAttendees.Text) <= 7 And check_Discount.Checked = False Then
                Total = C * txt_NumberOfAttendees.Text
            ElseIf Val(txt_NumberOfAttendees.Text) >= 8 And Val(txt_NumberOfAttendees.Text) <= 16 And check_Discount.Checked = False Then
                Total = D * txt_NumberOfAttendees.Text
            End If

            If Val(txt_NumberOfAttendees.Text) = 1 And check_Discount.Checked = True Then
                Total = (A * txt_NumberOfAttendees.Text) - (A * txt_NumberOfAttendees.Text * Discount)
            ElseIf Val(txt_NumberOfAttendees.Text) >= 2 And Val(txt_NumberOfAttendees.Text) <= 4 And check_Discount.Checked = True Then
                Total = (B * txt_NumberOfAttendees.Text) - (B * txt_NumberOfAttendees.Text * Discount)
            ElseIf Val(txt_NumberOfAttendees.Text) >= 5 And Val(txt_NumberOfAttendees.Text) <= 7 And check_Discount.Checked = True Then
                Total = (C * txt_NumberOfAttendees.Text) - (C * txt_NumberOfAttendees.Text * Discount)
            ElseIf Val(txt_NumberOfAttendees.Text) >= 8 And Val(txt_NumberOfAttendees.Text) <= 16 And check_Discount.Checked = True Then
                Total = (D * txt_NumberOfAttendees.Text) - (D * txt_NumberOfAttendees.Text * Discount)

            End If

            lbl_Output.Text = "Total Cost: " & Total.ToString("C")
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        txt_NumberOfAttendees.Clear()
        lbl_Output.Text = "Total Cost:"
        check_Discount.Checked = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
