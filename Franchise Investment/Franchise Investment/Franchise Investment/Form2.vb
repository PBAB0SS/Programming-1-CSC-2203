Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Array.Sort(Form1.NameofFranchise)

        For Each item In Form1.NameofFranchise
            lstFranchise.Items.Add(item)
        Next

        Array.Sort(Form1.investmentCost)

        For Each item In Form1.investmentCost
            lstInvestmentCost.Items.Add(item.ToString("C"))
        Next
    End Sub

End Class