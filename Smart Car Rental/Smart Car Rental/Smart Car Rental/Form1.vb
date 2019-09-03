Public Class Form1
    Const CostPerDay = 29.99D
    Const PerMileDriven = 0.39D

    Private Sub btn_DisplayFare_Click(sender As Object, e As EventArgs) Handles btn_DisplayFare.Click
        Dim NumberofDays As Integer
        Dim NumberofMiles As Integer
        Dim TotalCost As Decimal

        NumberofDays = Convert.ToInt16(txt_NumberofDays.Text)
        NumberofMiles = Convert.ToInt16(txt_NumberofMiles.Text)

        TotalCost = (CostPerDay * NumberofDays) + (PerMileDriven * NumberofMiles)

        lbl_Total.Text = "Total Cost of Rental: " & TotalCost.ToString("C")
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Close()
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txt_NumberofDays.Clear()
        txt_NumberofMiles.Clear()
        lbl_Total.Text = "Total Cost of Rental:"
    End Sub
End Class