Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_Hight.Enabled = False
        txt_Weight.Enabled = False
        btn_Calculate.Enabled = False
        btn_Clear.Enabled = False
    End Sub

    Private Sub cbo_Measurement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Measurement.SelectedIndexChanged
        cbo_Hight.Enabled = True
        cbo_Hight.Items.Clear()
        Select Case cbo_Measurement.SelectedIndex
            Case 0
                For I = 1 To 84
                    Dim F As Integer = I \ 12
                    Dim C As Integer = I - F * 12
                    Dim S As String = (F.ToString() & "' " & C.ToString() & Chr(34))
                    cbo_Hight.Items.Add(S)
                Next
                lbl_WeightType.Text = "LBS"
            Case 1
                For I = 1 To 213
                    Dim F As Integer = I \ 100
                    Dim C As Integer = I - F * 100
                    cbo_Hight.Items.Add(F.ToString() & "m " & C.ToString() & "cm")
                Next
                lbl_WeightType.Text = "KG"
        End Select
        lbl_WeightType.Visible = True
        cbo_Hight.Focus()
    End Sub

    Private Sub cbo_Hight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Hight.SelectedIndexChanged
        txt_Weight.Enabled = True
        txt_Weight.Focus()
    End Sub

    Private Sub txt_Weight_TextChanged(sender As Object, e As EventArgs) Handles txt_Weight.TextChanged
        btn_Calculate.Enabled = True
    End Sub

    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        Dim blnMeasureIsSelected As Boolean

        blnMeasureIsSelected = ValidityCheck()

        Dim decTotalBMI As Decimal = Math()

        lbl_Output.Text = decTotalBMI.ToString("F2")

        btn_Clear.Enabled = True
    End Sub

    Private Function ValidityCheck() As Boolean
        Dim Weight As Decimal
        Dim blnValidityCheck As Boolean = False

        Try
            Weight = Convert.ToInt32(txt_Weight.Text)

            If IsNumeric(Weight) Then
                blnValidityCheck = True
            Else
                MsgBox("Please Enter Number for Weight", MsgBoxStyle.OkOnly, "Error")
            End If
        Catch excetion As FormatException
            MsgBox("Please Enter Number for Weight", MsgBoxStyle.OkOnly, "Error")
            txt_Weight.Clear()
            txt_Weight.Focus()
        Catch excetion As OverflowException
            MsgBox("Please Enter Number for Weight", MsgBoxStyle.OkOnly, "Error")
            txt_Weight.Clear()
            txt_Weight.Focus()
        Catch excetion As SystemException
            MsgBox("Please Enter Number for Weight", MsgBoxStyle.OkOnly, "Error")
            txt_Weight.Clear()
            txt_Weight.Focus()
        End Try

        Return blnValidityCheck

    End Function

    Private Function Math() As Decimal

        Dim decTotalBMI As Decimal
        If IsNumeric(txt_Weight.Text) Then

            Dim Weight As Decimal = Convert.ToInt32(txt_Weight.Text)

            Select Case cbo_Measurement.SelectedIndex
                Case 0
                    Dim HightFt() As String = cbo_Hight.SelectedItem.split("'")
                    HightFt(1) = HightFt(1).Substring(0, HightFt(1).Length - 1)
                    Dim Hight As Decimal = Convert.ToInt32(HightFt(0)) * 12 + Convert.ToInt32(HightFt(1))

                    decTotalBMI = ((Weight / (Hight * Hight)) * 703)

                Case 1
                    Dim HightM() As String = cbo_Hight.SelectedItem.split("m")
                    HightM(1) = HightM(1).Substring(0, HightM(1).Length - 1)
                    Dim Hight As Decimal = Convert.ToInt32(HightM(0)) * 100 + Convert.ToInt32(HightM(1))
                    Dim HightFinal As Decimal = Hight / 100

                    decTotalBMI = ((Weight / (HightFinal * HightFinal)))

            End Select

        End If

        Return decTotalBMI

    End Function

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        cbo_Measurement.Text = "Select a Measurment"
        cbo_Hight.Text = "Height"
        cbo_Hight.Enabled = False
        txt_Weight.Clear()
        txt_Weight.Enabled = False
        lbl_WeightType.Text = ""
        lbl_Output.Text = ""
        btn_Calculate.Enabled = False
        btn_Clear.Enabled = False
    End Sub
End Class
