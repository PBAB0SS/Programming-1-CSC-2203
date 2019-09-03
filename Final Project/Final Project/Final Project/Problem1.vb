Public Class Problem1

    Dim A() As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

        Dim Input As String = Trim(TextBox1.Text)

        ListBox1.Items.Add(AmountInWords(Input))
        TextBox1.Clear()

    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        ListBox1.Items.Clear()
    End Sub

    Public Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount _
        As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String

        If Not IsNumeric(nAmount) Then Return"Please enter numeric values only."

        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
            tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Dim intAmount As Long = nAmount
        If intAmount > 0 Then
            nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                > (CLng(intAmount.ToString.Trim.Length / 3)), _
              CLng(intAmount.ToString.Trim.Length / 3) + 1, _
                CLng(intAmount.ToString.Trim.Length / 3))
            Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim, _
              (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
            Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

            Dim Ones() As String = _
            {"", "One", "Two", "Three", _
              "Four", "Five", _
              "Six", "Seven", "Eight", "Nine"}

            Dim Teens() As String = {"", _
            "Eleven", "Twelve", "Thirteen", _
              "Fourteen", "Fifteen", _
              "Sixteen", "Seventeen", "Eighteen", "Nineteen"}

            Dim Tens() As String = {"", "Ten", _
            "Twenty", "Thirty", _
              "Forty", "Fifty", "Sixty", _
              "Seventy", "Eighty", "Ninety"}

            Dim HMBT() As String = {"", "", _
            "Thousand"}

            intAmount = eAmount

            Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
            Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
            Dim nOne As Integer = intAmount \ 1

            If nHundred > 0 Then wAmount = wAmount & _
            Ones(nHundred) & " Hundred "
            If nTen > 0 Then
                If nTen = 1 And nOne > 0 Then
                    wAmount = wAmount & Teens(nOne) & " "
                Else
                    wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ")
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If
            Else
                If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
            End If
            wAmount = wAmount & HMBT(nSet) & " "
            wAmount = AmountInWords(CStr(CLng(nAmount) - (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
        End If


        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount = _
          IIf(InStr(wAmount.Trim.ToLower, "dollars"), wAmount.Trim, wAmount.Trim & " Dollars")

        Return wAmount
    End Function

    Private Sub btn_Return_Click(sender As Object, e As EventArgs) Handles btn_Return1.Click
        Hide()
        Start_Menu.Show()
    End Sub

End Class