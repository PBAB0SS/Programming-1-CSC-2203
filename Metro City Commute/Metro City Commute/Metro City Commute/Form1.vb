Public Class Form1
    Const SingleRide = 2.75D
    Const SevenDay = 30D
    Const ThirtyDay = 112D

    Private Sub btn_BuyTicket_Click(sender As Object, e As EventArgs) Handles btn_BuyTicket.Click
        Dim Total As Decimal

        If rdo_SingleRide.Checked = True Then
            Total = Val(txt_NumberOfTickets.Text) * SingleRide

        ElseIf rdo_7Day.Checked = True Then

            Total = Val(txt_NumberOfTickets.Text) * SevenDay

        ElseIf rdo_30Day.Checked = True Then

            Total = Val(txt_NumberOfTickets.Text) * ThirtyDay
        End If

        lbl_FinalCost.Text = "Final Ticket Cost: " & Total.ToString("C")
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txt_NumberOfTickets.Clear()
        lbl_FinalCost.Text = "Final Ticket Cost:"
        rdo_SingleRide.Checked = False
        rdo_7Day.Checked = False
        rdo_30Day.Checked = False
    End Sub
End Class
