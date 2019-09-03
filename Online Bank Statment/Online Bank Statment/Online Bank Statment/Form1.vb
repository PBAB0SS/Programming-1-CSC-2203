Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_WhatIsYourInterest.Visible = False
        txt_WhatIsInterest.Visible = False
    End Sub

    Private Sub chk_InterestRate_CheckedChanged(sender As Object, e As EventArgs) Handles chk_InterestRate.CheckedChanged
        If chk_InterestRate.Checked = True Then
            lbl_WhatIsYourInterest.Visible = True
            txt_WhatIsInterest.Visible = True
        Else
            lbl_WhatIsYourInterest.Visible = False
            txt_WhatIsInterest.Visible = False
        End If

    End Sub

    Public Checks As Decimal
    Public ATM As Decimal
    Public Deposits As Decimal

    Public RunningTotalCheck As Decimal
    Public RunningTotalATM As Decimal
    Public RunningTotalDeposits As Decimal

    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        Checks = Val(txt_Checks.Text)
        ATM = Val(txt_ATM.Text)
        Deposits = Val(txt_Deposits.Text)
        Dim StartAmount As Decimal = Val(txt_StartingAmount.Text)
        Dim interest As Decimal
        Dim Total As Decimal
        Dim FinalTotal As Decimal

        Dim IsValid As Boolean

        IsValid = ValidationCheck()

        If IsValid Then
            If chk_InterestRate.Checked = True Then
                Dim InterestRate As Decimal = Val(txt_WhatIsInterest.Text) / 100

                interest = ((StartAmount - (ATM + RunningTotalATM)) + ((Checks + RunningTotalCheck) + (Deposits + RunningTotalDeposits))) * (InterestRate)
                Total = ((StartAmount - (ATM + RunningTotalATM)) + ((Checks + RunningTotalCheck) + (Deposits + RunningTotalDeposits)))
                FinalTotal = interest + Total
            Else
                FinalTotal = (StartAmount - (ATM + RunningTotalATM)) + ((Checks + RunningTotalCheck) + (Deposits + RunningTotalDeposits))
            End If

            lbl_Output.Text = FinalTotal.ToString("C")
        End If

    End Sub

    Private Function ValidationCheck()
        Dim Validity As Boolean = False

        If IsNumeric(txt_StartingAmount.Text) Then
            Validity = True
            If chk_InterestRate.Checked = True Then
                If IsNumeric(txt_WhatIsInterest.Text) Then
                    Validity = True
                    If IsNumeric(txt_Checks.Text) Then
                        Validity = True
                        If IsNumeric(txt_ATM.Text) Then
                            Validity = True
                            If IsNumeric(txt_Deposits.Text) Then
                                Validity = True
                            Else
                                Validity = False
                                MsgBox("Please Enter a Number")
                            End If
                        Else
                            Validity = False
                            MsgBox("Please Enter a Number")
                        End If
                    Else
                        Validity = False
                        MsgBox("Please Enter a Number")
                    End If
                Else
                    Validity = False
                    MsgBox("Please Enter a Number")
                End If
            Else
                If IsNumeric(txt_Checks.Text) Then
                    Validity = True
                    If IsNumeric(txt_ATM.Text) Then
                        Validity = True
                        If IsNumeric(txt_Deposits.Text) Then
                            Validity = True
                        Else
                            Validity = False
                            MsgBox("Please Enter a Number")
                        End If
                    Else
                        Validity = False
                        MsgBox("Please Enter a Number")
                    End If
                Else
                    Validity = False
                    MsgBox("Please Enter a Number")
                End If
            End If
        Else
            MsgBox("Please Enter a Number")
            txt_StartingAmount.Clear()
            txt_StartingAmount.Focus()
        End If

        Return Validity

    End Function

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        If chk_InterestRate.Checked = True Then
            txt_StartingAmount.Clear()
            chk_InterestRate.Checked = False
            txt_WhatIsInterest.Clear()
            txt_Checks.Clear()
            txt_ATM.Clear()
            txt_Deposits.Clear()
            lbl_Output.Text = "Lable 1"
        Else
            txt_StartingAmount.Clear()
            txt_Checks.Clear()
            txt_ATM.Clear()
            txt_Deposits.Clear()
            lbl_Output.Text = "Lable 1"
        End If

        RunningTotalCheck = 0
        RunningTotalATM = 0
        RunningTotalDeposits = 0
    End Sub

    Private Sub btn_CheckAdd_Click(sender As Object, e As EventArgs) Handles btn_CheckAdd.Click
        Checks = Val(txt_Checks.Text)
        RunningTotalCheck += Checks
        txt_Checks.Clear()
    End Sub

    Private Sub btn_ATMAdd_Click(sender As Object, e As EventArgs) Handles btn_ATMAdd.Click
        ATM = Val(txt_ATM.Text)
        RunningTotalATM += ATM
        txt_ATM.Clear()
    End Sub

    Private Sub txt_DepositsAdd_Click(sender As Object, e As EventArgs) Handles txt_DepositsAdd.Click
        Deposits = Val(txt_Deposits.Text)
        RunningTotalDeposits += Deposits
        txt_Deposits.Clear()
    End Sub
End Class