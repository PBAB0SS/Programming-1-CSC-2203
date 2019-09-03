Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_GB.Visible = False
        txt_GbUsed.Visible = False
        btn_Calculate.Visible = False
        btn_Clear.Visible = False
        lbl_Output.Visible = False
    End Sub

    Private Sub cbo_Plans_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Plans.SelectedIndexChanged
        Select Case cbo_Plans.SelectedIndex
            Case 0
                lbl_Info.Text = "Basic Plan: $29 a month plus $4 per GB of of data."
            Case 1
                lbl_Info.Text = "Deluxe Plan: $39 a month plus $1 per GB of data."
        End Select
        lbl_CBO.Visible = False
        lbl_GB.Visible = True
        txt_GbUsed.Visible = True
        txt_GbUsed.Focus()
    End Sub

    Private Sub txt_GbUsed_TextChanged(sender As Object, e As EventArgs) Handles txt_GbUsed.TextChanged
        btn_Calculate.Visible = True
        btn_Clear.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        lbl_Output.Visible = True

        Dim blnValidityCheckIsValid As Boolean

        blnValidityCheckIsValid = ValidityCheck()

        Dim TotalGb As Decimal
        Dim TotalCost As Decimal

        If (blnValidityCheckIsValid) Then
            TotalGb = Convert.ToInt32(txt_GbUsed.Text)

            Select Case cbo_Plans.SelectedIndex
                Case 0
                    TotalCost = (TotalGb * 4) + 29
                Case 1
                    TotalCost = (TotalGb * 1) + 39
            End Select

            lbl_Output.Text = "Your Monthly Bill Will Be: " & TotalCost.ToString("C")
        End If

    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        Dim CboBox As Integer

        CboBox = cbo_Plans.SelectedIndex

        cbo_Plans.Items.Clear()

        Select Case CboBox
            Case 0
                ComboBox()
        End Select

        lbl_Info.Text = ""
        lbl_GB.Visible = False
        txt_GbUsed.Clear()
        txt_GbUsed.Visible = False
        btn_Calculate.Visible = False
        btn_Clear.Visible = False
        lbl_Output.Text = ""
        lbl_CBO.Visible = True

    End Sub

    Private Function ValidityCheck() As Boolean
        Dim TotalGb As Decimal
        Dim blnValidityCheck As Boolean = False

        Try
            TotalGb = Convert.ToInt32(txt_GbUsed.Text)

            If IsNumeric(TotalGb) Then
                blnValidityCheck = True
            Else
                MsgBox("Please Enter Number of Gigibites Used Last Month", MsgBoxStyle.OkOnly, "Error")
            End If

        Catch excetion As FormatException
            MsgBox("Please Enter Number of Gigibites Used Last Month", MsgBoxStyle.OkOnly, "Error")
            txt_GbUsed.Clear()
            txt_GbUsed.Focus()
        Catch excetion As OverflowException
            MsgBox("Please Enter Number of Gigibites Used Last Month", MsgBoxStyle.OkOnly, "Error")
            txt_GbUsed.Clear()
            txt_GbUsed.Focus()
        Catch excetion As SystemException
            MsgBox("Please Enter Number of Gigibites Used Last Month", MsgBoxStyle.OkOnly, "Errorr")
            txt_GbUsed.Clear()
            txt_GbUsed.Focus()
        End Try

        Return blnValidityCheck

    End Function

    Private Sub ComboBox()
        cbo_Plans.Items.Add("Basic Plan: $29 per month")
        cbo_Plans.Items.Add("Delux Plan: $39 per month")
    End Sub

End Class
