Public Class Form1

    Private Sub btn_Analytics_Click(sender As Object, e As EventArgs) Handles btn_Analytics.Click
        Dim inputCanclled As String = ""
        Dim strAnalyticsMetric As String
        Dim AnalyticsMetric As Integer
        Dim intNumberOfEntries As Integer = 1
        Dim intMaxNumberOfEntries As Integer = 12
        Dim runningTotal As Decimal = 0D

        strAnalyticsMetric = InputBox("Enter Visitor Times " & intNumberOfEntries, "Visitor Time Analytics", " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strAnalyticsMetric = inputCanclled
            If IsNumeric(strAnalyticsMetric) Then
                AnalyticsMetric = Convert.ToInt16(strAnalyticsMetric)
                If AnalyticsMetric > 0 Then
                    lst_Analytics.Items.Add(AnalyticsMetric)
                    runningTotal += AnalyticsMetric
                    intNumberOfEntries += 1
                Else
                    MsgBox("Enter a Positive Number for Visitor Times")
                End If
            Else
                MsgBox("Enter a Number for Visotor Times ")
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strAnalyticsMetric = InputBox("Enter Visitor Times " & intNumberOfEntries, "Visitor Time Analytics ", " ")
            End If
        Loop
        Dim AveragTime As Decimal

        If intNumberOfEntries > 1 Then
            AveragTime = runningTotal / (intNumberOfEntries - 1)
            lbl_Output.Text = "Average Time Spent: " & AveragTime.ToString("F2") & " Seconds"
        Else
            MsgBox("Enter a Visitor Time to Begin")
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lst_Analytics.Items.Clear()
        lbl_Output.Text = "Average Time Spent:"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
