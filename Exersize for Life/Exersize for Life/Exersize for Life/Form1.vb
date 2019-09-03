Public Class Form1
    Const ActivityPerWeek = 3
    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        Dim DOBMonth As Integer
        Dim DOBDate As Integer
        Dim DOBYear As Integer
        Dim CurrentDateMonth As Integer
        Dim CurrentDateDate As Integer
        Dim CurrentDateYear As Integer
        Dim TimeAliveMonths As Integer
        Dim TimeAliveDays As Integer
        Dim TimeAliveYears As Integer
        Dim MonthsToDays As Integer
        Dim YearsToDays As Integer
        Dim TotalDays As Integer
        Dim TotalWeeks As Integer



        DOBMonth = Val(txt_DOBMonth.Text)
        DOBDate = Val(txt_DOBDay.Text)
        DOBYear = Val(txt_DOBYear.Text)
        CurrentDateMonth = Val(txt_CurrentDateMonth.Text)
        CurrentDateDate = Val(txt_CurrentDateDate.Text)
        CurrentDateYear = Val(txt_CurrentDateYear.Text)

        TimeAliveMonths = CurrentDateMonth - DOBMonth
        TimeAliveDays = CurrentDateDate - DOBDate
        TimeAliveYears = CurrentDateYear - DOBYear

        MonthsToDays = TimeAliveMonths * 30
        YearsToDays = TimeAliveYears * 365

        TotalDays = MonthsToDays + TimeAliveDays + YearsToDays
        TotalWeeks = TotalDays / 7

        lbl_DataOutput.Text = "                          Name: " & txt_FName.Text & Environment.NewLine & "Hours Exersized in Life: " & FormatNumber(TotalWeeks * ActivityPerWeek)
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txt_FName.Clear()
        txt_DOBMonth.Clear()
        txt_DOBDay.Clear()
        txt_DOBYear.Clear()
        txt_CurrentDateMonth.Clear()
        txt_CurrentDateDate.Clear()
        txt_CurrentDateYear.Clear()
        lbl_DataOutput.Text = "                          Name: " & Environment.NewLine & "Hours Exersized in Life: "
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Close()
    End Sub
End Class
