Public Class Form1


    Private Sub btn_EnterWeightLoss_Click(sender As Object, e As EventArgs) Handles btn_EnterWeightLoss.Click
        Dim strWeightLoss As String
        Dim strcanelclicked As String = ""
        Dim decWeightLoss, decTotalWeightLoss As Decimal

        Dim inNumberOfEntries As Integer = 1
        Dim intMaxNumberOfEntries As Integer = 8

        strWeightLoss = InputBox("Enter the Weight Loss Team Member # " & inNumberOfEntries, "Weight Loss", " ")

        Do Until inNumberOfEntries > intMaxNumberOfEntries Or strWeightLoss = strcanelclicked
            If IsNumeric(strWeightLoss) Then
                decWeightLoss = Convert.ToDecimal(strWeightLoss)
                If decWeightLoss > 0 Then
                    decTotalWeightLoss += decWeightLoss
                    inNumberOfEntries = inNumberOfEntries + 1
                    Lst_WeighLoss.Items.Add("User Weight Loss: " & decWeightLoss & " " & "Running Total: " & decTotalWeightLoss)
                Else
                    MsgBox("Error - Enter a Postivie Number for the Weight Loss of Team Member" & inNumberOfEntries, MsgBoxStyle.OkOnly, "Weight Loss")
                End If
            Else
                MsgBox("Error - Enter a Number for the Weight Loss of Team Member" & inNumberOfEntries, MsgBoxStyle.OkOnly, "Weight Loss")
            End If
            If inNumberOfEntries <= intMaxNumberOfEntries Then
                strWeightLoss = InputBox("Enter the Weight Loss Team Member # " & inNumberOfEntries, "Weight Loss", " ")
            End If
        Loop
        Dim DecAverageLoss As Decimal

        If inNumberOfEntries > 1 Then
            DecAverageLoss = decTotalWeightLoss / (inNumberOfEntries - 1)
            lbl_AverageLoss.Text = "Average Weight Loss for the Team is " & DecAverageLoss.ToString("F1") & " Lbs"

        Else
            MsgBox("No Weight Loss Was Entereed ")
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Lst_WeighLoss.Items.Clear()
        lbl_AverageLoss.Text = ""
    End Sub
End Class
