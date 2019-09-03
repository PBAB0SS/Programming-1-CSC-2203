Public Class Form1
    Const FICA = 0.0765D
    Const FederalTax = 0.22D
    Const SateTax = 0.03

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Calculate.Enabled = False
        btn_Clear.Enabled = False
        btn_Exit.Enabled = False
    End Sub

    Private Sub txt_Income_TextChanged(sender As Object, e As EventArgs) Handles txt_Income.TextChanged
        btn_Calculate.Enabled = True
    End Sub

    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        btn_Clear.Enabled = True
        btn_Exit.Enabled = True

        Dim Income As Decimal
        Dim TotalFICA As Decimal
        Dim TotalFederalTax As Decimal
        Dim TotalStateIncome As Decimal
        Dim TotalNetPay As Decimal

        Income = Convert.ToDecimal(txt_Income.Text)

        TotalFICA = Income * FICA
        TotalFederalTax = Income * FederalTax
        TotalStateIncome = Income * SateTax
        TotalNetPay = Income - (TotalFICA + TotalFederalTax + TotalStateIncome)

        lbl_FicaTax.Text = "FICA Tax: " & TotalFICA.ToString("C")
        lbl_FederalTax.Text = "Federal Tax: " & TotalFederalTax.ToString("C")
        lbl_StateIncomeTax.Text = "State Income Tax: " & TotalStateIncome.ToString("C")
        lbl_NetPay.Text = "Net Pay: " & TotalNetPay.ToString("C")

    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Close()
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        btn_Clear.Enabled = False

        txt_Income.Clear()
        lbl_FicaTax.Text = "FICA Tax:"
        lbl_FederalTax.Text = "Federal Tax:"
        lbl_StateIncomeTax.Text = "State Income Tax:"
        lbl_NetPay.Text = "Net Pay:"
    End Sub

   
End Class