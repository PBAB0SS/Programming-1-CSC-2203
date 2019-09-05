Imports System.Globalization

Public Class Form1

    Const EuroValue As Decimal = 0.85683D
    Const CADValue As Decimal = 1.30167D
    Const MXNValue As Decimal = 18.844D
    Const JPNValue As Decimal = 112.035D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Clear.Enabled = False
        btn_Exit.Enabled = False
    End Sub

    Private Sub btn_Convert_Click(sender As Object, e As EventArgs) Handles btn_Convert.Click
        Dim strUSDollars As String
        Dim decUSDollars As Decimal
        Dim ConvertedValueUSD, ConvertedValueCAD, ConvertedValueMXN, ConvertedValueJPY As Decimal

        strUSDollars = Txt_DollarsToConvert.Text
        decUSDollars = Convert.ToDecimal(strUSDollars)


        ConvertedValueUSD = decUSDollars * EuroValue
        lbl_Euros.Text = "Value in Euros " & ConvertedValueUSD.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"))

        ConvertedValueCAD = decUSDollars * CADValue
        lbl_CanadianDollars.Text = "value in Canadian Dollars " & ConvertedValueCAD.ToString("C", CultureInfo.CreateSpecificCulture("en-CA"))

        ConvertedValueJPY = decUSDollars * JPNValue
        lbl_JapeneseYen.Text = "value in Japenese Yen " & ConvertedValueJPY.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"))

        ConvertedValueMXN = decUSDollars * MXNValue
        lbl_MexicanPeso.Text = "value in Pesos " & ConvertedValueMXN.ToString("C", CultureInfo.CreateSpecificCulture("es-MX"))

        btn_Clear.Enabled = True
        btn_Exit.Enabled = True

    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        Txt_DollarsToConvert.Clear()
        Txt_Date.Clear()
        lbl_Euros.Text = "Value in Euros:"
        lbl_CanadianDollars.Text = "Value in Canadian Dollars:"
        lbl_MexicanPeso.Text = "Value in Mexican Pesos:"
        lbl_JapeneseYen.Text = "Value in Japenese Yen:"

        btn_Clear.Enabled = False
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Close()
    End Sub
End Class
