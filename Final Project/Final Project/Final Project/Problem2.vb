Public Class Problem2

    Private Sub Problem2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Dim Output() As String

    Private Sub rdo_B10toB2_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_B10toB2.Click
        Dim K = TextBox1.Text

        If K = "" Then
            rdo_B10toB2.Checked = False
            MsgBox("input something!")
        Else
            K = Convert.ToInt32(K)


            Dim X As Integer = K
            Dim i As Integer = 0
            Dim W As Integer = 0

            Do Until X < 1

                X = X / 2
                W += 1

            Loop

            Array.Resize(Output, W)

            X = K
            i = 0

            Do Until X < 1

                Output(i) = X Mod 2
                X = X / 2
                i += 1

            Loop

            Array.Reverse(Output)

            For i = 0 To Output.Length - 1
                Label1.Text = Label1.Text & Output(i)
            Next

        End If

    End Sub

    Private Sub rdo_B2toB10_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_B2toB10.Click
        Dim K = TextBox1.Text

        If K = "" Then
            rdo_B10toB2.Checked = False
            MsgBox("input something!")
        Else

            Dim array() As Integer = {1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 80192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824}
            Dim Bin As String = ""
            Dim x As Integer

            For i As Integer = Len(K) To 1 Step -1
                Bin = Bin & Mid(K, i, 1)
            Next

            For i As Integer = 0 To Len(Bin) - 1
                If Mid(Bin, i + 1, 1) = "1" Then
                    x = x + array(i)
                End If
            Next

            Label1.Text = x.ToString
        End If

    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        TextBox1.Clear()
        rdo_B10toB2.Checked = False
        rdo_B2toB10.Checked = False
        Label1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub btn_Return_Click(sender As Object, e As EventArgs) Handles btn_Return2.Click
        Hide()
        Start_Menu.Show()
    End Sub

End Class