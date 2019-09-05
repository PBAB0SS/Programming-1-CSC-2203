Public Class Form1
    Const decPricePerBike As Decimal = 9.95D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Clear.Enabled = False
        btn_Exit.Enabled = False
    End Sub

    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        Dim strNumberOfBikes As String
        Dim intNumberOfBikes As Integer
        Dim decTotalCost As Decimal

        strNumberOfBikes = TXT_NumberBikes.Text
        intNumberOfBikes = Convert.ToInt32(strNumberOfBikes)
        decTotalCost = intNumberOfBikes * decPricePerBike
        'Lbl_TotalCostInput.Text = "$" & decTotalCost
        Lbl_TotalCostInput.Text = decTotalCost.ToString("C")

        btn_Clear.Enabled = True
        btn_Exit.Enabled = True
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        TXT_NumberBikes.Clear()
        Lbl_TotalCostInput.Text = ""
        btn_Exit.Enabled = False
        btn_Clear.Enabled = False
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Close()
    End Sub

End Class
