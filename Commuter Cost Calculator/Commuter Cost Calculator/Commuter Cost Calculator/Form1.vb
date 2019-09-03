Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl.Visible = False
        txt_1.Visible = False
        lbl_DaysWorked.Visible = False
        txt_DaysWorked.Visible = False
        lbl_MPG.Visible = False
        txt_MPG.Visible = False
        lbl_CostOfGas.Visible = False
        txt_CostOfGas.Visible = False
        lbl_MonthlyCost.Visible = False
        txt_MonthlyCost.Visible = False
        lbl_ParkingCost.Visible = False
        txt_ParkingCost.Visible = False
        btn_Calculate.Visible = False
        btn_Clear.Visible = False
        lbl_Output.Visible = False
        Pic_Car.Visible = False
        pic_Train.Visible = False
        pic_Bus.Visible = False
    End Sub

    Private Sub cbo_CommmuteType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_CommmuteType.SelectedIndexChanged
        lbl.Visible = True
        txt_1.Visible = True

        txt_1.Clear()
        txt_1.Focus()
        txt_CostOfGas.Clear()
        txt_DaysWorked.Clear()
        txt_MonthlyCost.Clear()
        txt_MPG.Clear()
        txt_ParkingCost.Clear()
        lbl_Output.Text = ""

        Select Case cbo_CommmuteType.SelectedIndex

            Case 0
                'Car
                CarElements()
                lbl.Text = "Enter Round Trip Distance:"
                lbl_DaysWorked.Text = "Enter Days Worked Per Month:"
                lbl_MPG.Text = "Enter Car's Milage Per Gallon:"
                lbl_CostOfGas.Text = "Enter Cost Per Gallon of Gas: $"
                lbl_MonthlyCost.Text = "Enter Monthly Cost of Maintenance and Insurence: $"
                lbl_ParkingCost.Text = "Enter Monthly Cost of Parking Pass: $"

            Case 1
                'Train
                TrainElements()
                lbl.Text = "Enter Round Trip Fares: $"
                lbl_DaysWorked.Text = "Enter Days Worked Per Month:"
                lbl_ParkingCost.Text = ""
            Case 2
                'Bus
                BusElements()
                lbl.Text = "Enter Round Trip Fares: $"
                lbl_DaysWorked.Text = "Enter Days Worked Per Month:"
                lbl_ParkingCost.Text = ""
        End Select

        btn_Calculate.Visible = True
        btn_Clear.Visible = True

    End Sub

    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        Dim blnIsSelected As Boolean

        blnIsSelected = ValidityCheck()

        If blnIsSelected = True Then
            Dim total As Decimal
            Select Case cbo_CommmuteType.SelectedIndex
                Case 0
                    total = CarMath()
                Case 1
                    total = TrainMath()
                Case 2
                    total = BusMath()
            End Select


            lbl_Output.Visible = True

            lbl_Output.Text = total.ToString("C")
        End If
    End Sub

    Private Function ValidityCheck() As Boolean
        Dim Distance As Decimal
        Dim Days As Integer
        Dim MPG As Decimal
        Dim Gas As Decimal
        Dim MonthlyCost As Decimal
        Dim ParkingCost As Decimal
        Dim blnValidityCheck As Boolean = False

        Try
            Select Case cbo_CommmuteType.SelectedIndex
                Case 0
                    MPG = Convert.ToDecimal(txt_MPG.Text)
                    Gas = Convert.ToDecimal(txt_CostOfGas.Text)
                    MonthlyCost = Convert.ToDecimal(txt_MonthlyCost.Text)
                    ParkingCost = Convert.ToDecimal(txt_ParkingCost.Text)

                    If IsNumeric(Distance) Then
                        blnValidityCheck = True
                    ElseIf IsNumeric(Days) Then
                        blnValidityCheck = True
                    ElseIf IsNumeric(MPG) Then
                        blnValidityCheck = True
                    ElseIf IsNumeric(Gas) Then
                        blnValidityCheck = True
                    ElseIf IsNumeric(MonthlyCost) Then
                        blnValidityCheck = True
                    ElseIf IsNumeric(ParkingCost) Then
                        blnValidityCheck = True
                    Else
                        MsgBox("Please Enter a Number", MsgBoxStyle.OkOnly, "Input Error")
                    End If
                Case 1
                    Distance = Convert.ToDecimal(txt_1.Text)
                    Days = Convert.ToInt32(txt_DaysWorked.Text)
                    If IsNumeric(Distance) Then
                        blnValidityCheck = True
                    ElseIf IsNumeric(Days) Then
                        blnValidityCheck = True
                    Else
                        MsgBox("Please Enter a Number", MsgBoxStyle.OkOnly, "Input Error")
                    End If
                Case 2
                    Distance = Convert.ToDecimal(txt_1.Text)
                    Days = Convert.ToInt32(txt_DaysWorked.Text)
                    If IsNumeric(Distance) Then
                        blnValidityCheck = True
                    ElseIf IsNumeric(Days) Then
                        blnValidityCheck = True
                    Else
                        MsgBox("Please Enter a Number", MsgBoxStyle.OkOnly, "Input Error")
                    End If
            End Select

        Catch excetion As FormatException
            MsgBox("Please Enter a Number", MsgBoxStyle.OkOnly, "Error")
        Catch excetion As OverflowException
            MsgBox("Please Enter a Number", MsgBoxStyle.OkOnly, "Error")
        Catch excetion As SystemException
            MsgBox("Please Enter a Number", MsgBoxStyle.OkOnly, "Error")
        End Try


        Return blnValidityCheck

    End Function

    Private Function CarMath() As Decimal
        Dim Distance As Decimal = Convert.ToDecimal(txt_1.Text)
        Dim Days As Integer = Convert.ToInt32(txt_DaysWorked.Text)
        Dim MPG As Decimal = Convert.ToDecimal(txt_MPG.Text)
        Dim Gas As Decimal = Convert.ToDecimal(txt_CostOfGas.Text)
        Dim MonthlyCost As Decimal = Convert.ToDecimal(txt_MonthlyCost.Text)
        Dim ParkingCost As Decimal = Convert.ToDecimal(txt_ParkingCost.Text)
        Dim Total As Decimal

        Total = ((Distance * Days * 12) / MPG) * Gas + (MonthlyCost + ParkingCost)

        Return Total
    End Function

    Private Function TrainMath() As Decimal
        Dim Distance As Decimal = Convert.ToDecimal(txt_1.Text)
        Dim Days As Integer = Convert.ToInt32(txt_DaysWorked.Text)
        Dim Total As Decimal

        Total = Distance * Days * 12

        Return Total

    End Function

    Private Function BusMath() As Decimal
        Dim Distance As Decimal = Convert.ToDecimal(txt_1.Text)
        Dim Days As Integer = Convert.ToInt32(txt_DaysWorked.Text)
        Dim Total As Decimal

        Total = Distance * Days * 12

        Return Total

    End Function

    Private Sub CarElements()
        Pic_Car.Visible = True
        pic_Train.Visible = False
        pic_Bus.Visible = False
        lbl_DaysWorked.Visible = True
        txt_DaysWorked.Visible = True
        lbl_MPG.Visible = True
        txt_MPG.Visible = True
        lbl_CostOfGas.Visible = True
        txt_CostOfGas.Visible = True
        lbl_MonthlyCost.Visible = True
        txt_MonthlyCost.Visible = True
        lbl_ParkingCost.Visible = True
        txt_ParkingCost.Visible = True
    End Sub

    Private Sub TrainElements()
        pic_Train.Visible = True
        Pic_Car.Visible = False
        pic_Bus.Visible = False
        lbl_DaysWorked.Visible = True
        txt_DaysWorked.Visible = True
        lbl_MPG.Visible = False
        txt_MPG.Visible = False
        lbl_CostOfGas.Visible = False
        txt_CostOfGas.Visible = False
        lbl_MonthlyCost.Visible = False
        txt_MonthlyCost.Visible = False
        lbl_ParkingCost.Visible = False
        txt_ParkingCost.Visible = False
    End Sub

    Private Sub BusElements()
        pic_Bus.Visible = True
        Pic_Car.Visible = False
        pic_Train.Visible = False
        lbl_DaysWorked.Visible = True
        txt_DaysWorked.Visible = True
        lbl_MPG.Visible = False
        txt_MPG.Visible = False
        lbl_CostOfGas.Visible = False
        txt_CostOfGas.Visible = False
        lbl_MonthlyCost.Visible = False
        txt_MonthlyCost.Visible = False
        lbl_ParkingCost.Visible = False
        txt_ParkingCost.Visible = False
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        Pic_Car.Visible = False
        pic_Train.Visible = False
        pic_Bus.Visible = False
        txt_1.Clear()
        txt_1.Focus()
        txt_CostOfGas.Clear()
        txt_DaysWorked.Clear()
        txt_MonthlyCost.Clear()
        txt_MPG.Clear()
        txt_ParkingCost.Clear()
        lbl_Output.Text = ""
        lbl.Visible = False
        txt_1.Visible = False
        lbl_DaysWorked.Visible = False
        txt_DaysWorked.Visible = False
        lbl_MPG.Visible = False
        txt_MPG.Visible = False
        lbl_CostOfGas.Visible = False
        txt_CostOfGas.Visible = False
        lbl_MonthlyCost.Visible = False
        txt_MonthlyCost.Visible = False
        lbl_ParkingCost.Visible = False
        txt_ParkingCost.Visible = False
        btn_Calculate.Visible = False
        btn_Clear.Visible = False
        lbl_Output.Visible = False
        cbo_CommmuteType.Items.Clear()
        AddItemsToCboBox()
    End Sub
    Private Sub AddItemsToCboBox()
        cbo_CommmuteType.Items.Add("Car")
        cbo_CommmuteType.Items.Add("Train")
        cbo_CommmuteType.Items.Add("Bus")
    End Sub
End Class
