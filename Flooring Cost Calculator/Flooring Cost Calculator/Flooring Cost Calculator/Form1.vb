Public Class Form1

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txt_SquareFootage.Clear()
        lbl_CostEstimateNumber.Text = ""
        rdo_Carpet.Checked = False
        rdo_Hardwood.Checked = False
        rdo_Tile.Checked = False
        txt_SquareFootage.Focus()
    End Sub

    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        Dim decSquareFootage As Decimal
        Dim decCostperSquareFoot As Decimal

        Dim decTileCost As Decimal = 4.49D
        Dim decCarpetCost As Decimal = 4.99D
        Dim decHardWoodCost As Decimal = 7.49D

        If IsNumeric(txt_SquareFootage.Text) Then
            decSquareFootage = Convert.ToDecimal(txt_SquareFootage.Text)
            If decSquareFootage > 0 Then
                If rdo_Tile.Checked Then
                    decCostperSquareFoot = decTileCost
                ElseIf rdo_Carpet.Checked Then
                    decCostperSquareFoot = decCarpetCost
                ElseIf rdo_Hardwood.Checked Then
                    decCostperSquareFoot = decHardWoodCost
                End If

                lbl_CostEstimateNumber.Text = (decCostperSquareFoot * decSquareFootage).ToString("C")

            Else
                MsgBox("Enter a positive number to proceed", MsgBoxStyle.OkCancel, "Input Error")
                txt_SquareFootage.Clear()
                txt_SquareFootage.Focus()
            End If
        Else
            MsgBox("Enter the Square footage to proceed", MsgBoxStyle.OkCancel, "Input Error")
            txt_SquareFootage.Clear()
            txt_SquareFootage.Focus()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdo_Tile.Checked = True
    End Sub
End Class
