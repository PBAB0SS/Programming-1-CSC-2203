Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim InputCancelled As String = ""

        Dim strBowling As String

        Dim BowlingScore, Score As Integer
        Dim intnumberofentries As Integer = 1
        Dim intmaxnumberofentries As Integer = 10
        Dim RunningTotal As Integer = 0


        strBowling = InputBox("Enter Score #" & intnumberofentries, "Score Total", " ")



        Do Until intnumberofentries > intmaxnumberofentries Or strBowling = InputCancelled
            If IsNumeric(strBowling) Then
                BowlingScore = Convert.ToInt64(strBowling)
                If BowlingScore >= 0 Then
                    Score += BowlingScore
                    lstScore.Items.Add("Frame Score " & BowlingScore & " Total Score " & Score)
                    RunningTotal += BowlingScore
                    intnumberofentries += 1


                Else
                    MsgBox("Enter a Positive Number for Score")
                End If


            Else
                MsgBox("Enter a Number for Score")
            End If
            If intnumberofentries <= intmaxnumberofentries Then
                strBowling = InputBox("Enter Score #" & intnumberofentries, "Score Total", " ")

            End If

        Loop
        Dim ScoreTotal As Decimal


        If intnumberofentries > 1 Then
            ScoreTotal = (Score)
            lblTotal.Text = "Final Game score is " & ScoreTotal
        Else
            MsgBox("Enter a Number to Begin")
        End If
    End Sub
End Class
