Public Class Form1

    Const decEurosCon As Decimal = 0.85683D

    Const decCanadianCon As Decimal = 1.30167D

    Const decJapaneseCon As Decimal = 112.035D

    Const decMexicanCon As Decimal = 18.8442D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTNClear.Enabled = False
        BTNExit.Enabled = False
    End Sub

    Private Sub BTNConvert_Click(sender As Object, e As EventArgs) Handles BTNConvert.Click

        Dim strUSDollars As String
        Dim intUSDollars As Integer
        Dim decUSDollars As Decimal

        Dim decEurosValue, decCanadianValue, decJapaneseValue, decMexicanVallue As Decimal

        strUSDollars = TBDollars.Text
        decUSDollars = Convert.ToDecimal(strUSDollars)
        intUSDollars = Convert.ToInt32(strUSDollars)

        'Convert to Euros
        decEurosValue = decUSDollars * decEurosCon
        LBLEurosAmount.Text = "Value in Euros: " & "$" & decEurosValue

        'Convert to Canadian
        decCanadianValue = decUSDollars * decCanadianCon
        LBLCanadianDollarsAmount.Text = "Value in Canadian Dollars: " & "$" & decCanadianValue

        'Convert to Yen
        decJapaneseValue = decUSDollars * decJapaneseCon
        LBLJapaneseYenAmount.Text = "Value in Yen: " & "$" & decJapaneseValue

        'Convert to Pesos
        decMexicanVallue = decUSDollars * decMexicanCon
        LBLMexicanPesosAmount.Text = "Value in Pesos: " & "$" & decMexicanVallue

        BTNClear.Enabled = True
        BTNExit.Enabled = True
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        TBDollars.Clear()
        TBDate.Clear()
        LBLEurosAmount.ResetText()
        LBLCanadianDollarsAmount.ResetText()
        LBLJapaneseYenAmount.ResetText()
        LBLMexicanPesosAmount.ResetText()

        BTNClear.Enabled = False
    End Sub

    Private Sub BTNExit_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        Close()
    End Sub

End Class
