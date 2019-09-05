Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Clear.Enabled = False
    End Sub

    Private Sub cbo_City_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_City.SelectedIndexChanged
        Dim intCityChoice As Integer

        Label1.Visible = False

        intCityChoice = cbo_City.SelectedIndex
        lst_Game.Items.Clear()

        Select Case intCityChoice
            Case 0
                DallasTeam()
            Case 1
                ParisTeam()
            Case 2
                SingaporeTeam()
        End Select
    End Sub

    Private Sub DallasTeam()
        lst_Game.Items.Add("Spy in the Study")
        lst_Game.Items.Add("Hidden Cellar")
        lst_Game.Items.Add("Team Building")
    End Sub

    Private Sub ParisTeam()
        lst_Game.Items.Add("The Encounter")
        lst_Game.Items.Add("Library Larceny")
    End Sub

    Private Sub SingaporeTeam()
        lst_Game.Items.Add("Hidden Cellar")
        lst_Game.Items.Add("Team Building")
        lst_Game.Items.Add("Amazing Race")
    End Sub

    Private Sub lst_Game_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Game.SelectedIndexChanged
        btn_Clear.Enabled = True
    End Sub

    Private Sub btn_CliantCost_Click(sender As Object, e As EventArgs) Handles btn_CliantCost.Click
        Dim blnnumberinTeamisValid As Boolean = False
        Dim intGameChoice As Integer
        Dim blnGameisSelected As Boolean = False
        Dim strSelectedItem As String = ""
        Dim intTeamSize As Integer
        Dim intCityChoice As Integer
        Dim decTotalCost As Decimal
        Dim intLength As Integer = 0

        blnnumberinTeamisValid = ValidateNumberinTeam()


        intGameChoice = ValidateGameSelection(blnGameisSelected, strSelectedItem)

        If (blnnumberinTeamisValid And blnGameisSelected) Then
            intTeamSize = Convert.ToInt32(txt_Team.Text)
            intCityChoice = cbo_City.SelectedIndex

            Select Case intCityChoice
                Case 0
                    decTotalCost = DallasFindCost(intGameChoice, intTeamSize, intLength)
                Case 1
                    decTotalCost = ParisFindCost(intGameChoice, intTeamSize, intLength)
                Case 2
                    decTotalCost = SingaporeFindCost(intGameChoice, intTeamSize, intLength)

            End Select
            lbl_GameType.Text = "Game: " & strSelectedItem
            lbl_Cost.Text = "Cost: " & decTotalCost.ToString("C")
            lbl_Length.Text = "Length: " & intLength.ToString() & " Hour(s)"
        End If


    End Sub

    Private Function ValidateNumberinTeam() As Boolean
        Dim intTeamSize As Integer
        Dim blnValidityCheck As Boolean = False

        Try
            intTeamSize = Convert.ToInt16(txt_Team.Text)

            If intTeamSize >= 2 And intTeamSize <= 6 Then
                blnValidityCheck = True
            Else
                MsgBox("Please enter the number of people in your team (2-6)", MsgBoxStyle.OkOnly, "Error")
                txt_Team.Clear()
                txt_Team.Focus()
            End If
        Catch excetion As FormatException
            MsgBox("Please enter the number of people in your team (2-6)", MsgBoxStyle.OkOnly, "Error")
            txt_Team.Clear()
            txt_Team.Focus()
        Catch excetion As OverflowException
            MsgBox("Please enter the number of people in your team (2-6)", MsgBoxStyle.OkOnly, "Error")
            txt_Team.Clear()
            txt_Team.Focus()
        Catch excetion As SystemException
            MsgBox("Please enter the number of people in your team (2-6)", MsgBoxStyle.OkOnly, "Error")
            txt_Team.Clear()
            txt_Team.Focus()
        End Try

        Return blnValidityCheck

    End Function

    Private Function dallasFindCost(ByVal intGame As Integer, ByVal intTeam As Integer, ByRef intTime As Integer) As Decimal
        Dim decTeamCost As Decimal
        Dim decFinalCost As Decimal

        Select Case intGame
            Case 0
                decTeamCost = 32D
                intTime = 1
            Case 1
                decTeamCost = 39D
                intTime = 1
            Case 2
                decTeamCost = 55D
                intTime = 2
        End Select
        decFinalCost = decTeamCost * intTeam

        Return decFinalCost

    End Function

    Private Function ParisFindCost(ByVal intGame As Integer, ByVal intTeam As Integer, ByRef intTime As Integer) As Decimal
        Dim decTeamCost As Decimal
        Dim decFinalCost As Decimal

        Select Case intGame
            Case 0
                decTeamCost = 38D
                intTime = 1
            Case 1
                decTeamCost = 45D
                intTime = 1
        End Select
        decFinalCost = decTeamCost * intTeam

        Return decFinalCost

    End Function

    Private Function SingaporeFindCost(ByVal intGame As Integer, ByVal intTeam As Integer, ByRef intTime As Integer) As Decimal
        Dim decTeamCost As Decimal
        Dim decFinalCost As Decimal

        Select Case intGame
            Case 0
                decTeamCost = 45D
                intTime = 1
            Case 1
                decTeamCost = 65D
                intTime = 2
            Case 2
                decTeamCost = 75D
                intTime = 4
        End Select
        decFinalCost = decTeamCost * intTeam

        Return decFinalCost

    End Function

    Private Function ValidateGameSelection(ByRef blnGame As Boolean, ByRef strGame As String) As Integer
        Dim GameType As Integer

        Try
            GameType = Convert.ToInt32(lst_Game.SelectedIndex)
            strGame = lst_Game.SelectedItem.ToString()
            blnGame = True
        Catch Exception As SystemException
            MsgBox("Select a Game Type", , "Error")
            blnGame = False
        End Try

        Return GameType

    End Function

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        cbo_City.SelectedIndex = -1

        Label1.Visible = True
        lbl_GameType.Text = "Game:"
        lbl_Length.Text = "Length:"
        lbl_Cost.Text = "Cost:"
        txt_Team.Clear()
        lst_Game.Items.Clear()
        btn_Clear.Enabled = False



    End Sub

End Class