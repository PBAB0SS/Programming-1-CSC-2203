Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strCornMazeTime As String
        Dim strcanelclicked As String = ""
        Dim decCornMazeTime, decTotalCornMazeTime As Decimal

        Dim inNumberOfEntries As Integer = 1
        Dim intMaxNumberOfEntries As Integer = 10

        strCornMazeTime = InputBox("Enter the Compleation Time for Participant # " & inNumberOfEntries, "Corn Maze")

        Do Until inNumberOfEntries > intMaxNumberOfEntries Or strCornMazeTime = strcanelclicked
            If IsNumeric(strCornMazeTime) Then
                decCornMazeTime = Convert.ToDecimal(strCornMazeTime)
                If decCornMazeTime > 0 Then
                    decTotalCornMazeTime += decCornMazeTime
                    inNumberOfEntries = inNumberOfEntries + 1
                    ListBox1.Items.Add(decCornMazeTime)
                Else
                    MsgBox("Error - Enter a Postivie Number for the " & inNumberOfEntries, MsgBoxStyle.OkOnly, "Weight Loss")
                End If
            Else
                MsgBox("Error - Enter Time for Corn Maze # " & inNumberOfEntries, MsgBoxStyle.OkOnly, "Weight Loss")
            End If
            If inNumberOfEntries <= intMaxNumberOfEntries Then
                strCornMazeTime = InputBox("Enter the Compleation Time for Participant # " & inNumberOfEntries, "Corn Maze")
            End If
        Loop
        Dim DecAverageLoss As Decimal

        If inNumberOfEntries > 1 Then
            DecAverageLoss = decTotalCornMazeTime / (inNumberOfEntries - 1)
            lbl_Output.Text = "The Average Completion Time is " & DecAverageLoss.ToString("F1")

        Else
            MsgBox("No Corn Maze Times Were Entereed")
        End If
    End Sub
End Class
