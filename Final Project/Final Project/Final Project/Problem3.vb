Public Class Problem3

    Dim NumberDays As Integer
    Const CostPerDay As Integer = 100D
    Const PreConference As Integer = 700D
    Dim TotalPreConference As Integer = 0

    Private Sub Problem3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        txt_FullName.Enabled = False
        rdo_1Day.Checked = True
    End Sub

    Private Sub txt_EmployeeID_TextChanged(sender As Object, e As EventArgs) Handles txt_EmployeeID.Click
        txt_EmployeeID.Clear()
        txt_EmployeeID.ForeColor = Color.Black
    End Sub

    Private Sub txt_EmployeeID_TextChanged_2(sender As Object, e As EventArgs) Handles txt_EmployeeID.TextChanged
        txt_FullName.Enabled = True
    End Sub

    Private Sub txt_EmployeeID_TextChanged_1(sender As Object, e As EventArgs) Handles txt_EmployeeID.Leave
        If Len(txt_EmployeeID.Text) < 5 Or Len(txt_EmployeeID.Text) > 5 Then
            MsgBox("Employee ID must be 5 digits")
            txt_EmployeeID.Focus()
        End If
    End Sub

    Private Sub txt_FullName_TextChanged(sender As Object, e As EventArgs) Handles txt_FullName.Click
        txt_FullName.Clear()
        txt_FullName.ForeColor = Color.Black
    End Sub

    Private Sub txt_FullName_TextChanged_2(sender As Object, e As EventArgs) Handles txt_FullName.TextChanged
        txt_FullName.ForeColor = Color.Black
    End Sub

    Private Sub txt_FullName_TextChanged_1(sender As Object, e As EventArgs) Handles txt_FullName.Leave
        If Len(txt_FullName.Text) > 1 And txt_FullName.Text.Contains(" ") Then

        Else
            MsgBox("Please Enter Full Name With Spaces")
        End If

    End Sub

    Private Sub chk_PreConference_CheckedChanged(sender As Object, e As EventArgs) Handles chk_PreConference.Click
        If chk_PreConference.Checked = True Then
            GroupBox1.Show()
        Else
            GroupBox1.Hide()
        End If
    End Sub

    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        If rdo_1Day.Checked = True Then
            NumberDays = 1

            If chk_PreConference.Checked = True Then

                If chk_AI.Checked = True And chk_ComputerOrginization.Checked = True And _
                    chk_ComputerOrginization.Checked = True Then

                    TotalPreConference = PreConference * 3

                ElseIf chk_AI.Checked = True And chk_ComputerOrginization.Checked = True Or _
                    chk_AI.Checked = True And chk_SoftwareEngineering.Checked = True Or _
                chk_ComputerOrginization.Checked = True And chk_SoftwareEngineering.Checked = True Then

                    TotalPreConference = PreConference * 2

                ElseIf chk_AI.Checked = True Or chk_ComputerOrginization.Checked = True Or _
                    chk_SoftwareEngineering.Checked = True Then

                    TotalPreConference = PreConference

                End If

            End If

        ElseIf rdo_2Day.Checked = True Then
            NumberDays = 2

            If chk_AI.Checked = True And chk_ComputerOrginization.Checked = True And _
                    chk_ComputerOrginization.Checked = True Then

                TotalPreConference = PreConference * 3

            ElseIf chk_AI.Checked = True And chk_ComputerOrginization.Checked = True Or _
                chk_AI.Checked = True And chk_SoftwareEngineering.Checked = True Or _
            chk_ComputerOrginization.Checked = True And chk_SoftwareEngineering.Checked = True Then

                TotalPreConference = PreConference * 2

            ElseIf chk_AI.Checked = True Or chk_ComputerOrginization.Checked = True Or _
                chk_SoftwareEngineering.Checked = True Then

                TotalPreConference = PreConference

            End If

        ElseIf rdo_3Day.Checked = True Then
            NumberDays = 3

            If chk_AI.Checked = True And chk_ComputerOrginization.Checked = True And _
                    chk_ComputerOrginization.Checked = True Then

                TotalPreConference = PreConference * 3

            ElseIf chk_AI.Checked = True And chk_ComputerOrginization.Checked = True Or _
                chk_AI.Checked = True And chk_SoftwareEngineering.Checked = True Or _
            chk_ComputerOrginization.Checked = True And chk_SoftwareEngineering.Checked = True Then

                TotalPreConference = PreConference * 2

            ElseIf chk_AI.Checked = True Or chk_ComputerOrginization.Checked = True Or _
                chk_SoftwareEngineering.Checked = True Then

                TotalPreConference = PreConference

            End If

        ElseIf rdo_4Day.Checked = True Then
            NumberDays = 4

            If chk_AI.Checked = True And chk_ComputerOrginization.Checked = True And _
                    chk_ComputerOrginization.Checked = True Then

                TotalPreConference = PreConference * 3

            ElseIf chk_AI.Checked = True And chk_ComputerOrginization.Checked = True Or _
                chk_AI.Checked = True And chk_SoftwareEngineering.Checked = True Or _
            chk_ComputerOrginization.Checked = True And chk_SoftwareEngineering.Checked = True Then

                TotalPreConference = PreConference * 2

            ElseIf chk_AI.Checked = True Or chk_ComputerOrginization.Checked = True Or _
                chk_SoftwareEngineering.Checked = True Then

                TotalPreConference = PreConference

            End If

        ElseIf rdo_5Day.Checked = True Then
            NumberDays = 5

            If chk_AI.Checked = True And chk_ComputerOrginization.Checked = True And _
                    chk_ComputerOrginization.Checked = True Then

                TotalPreConference = PreConference * 3

            ElseIf chk_AI.Checked = True And chk_ComputerOrginization.Checked = True Or _
                chk_AI.Checked = True And chk_SoftwareEngineering.Checked = True Or _
            chk_ComputerOrginization.Checked = True And chk_SoftwareEngineering.Checked = True Then

                TotalPreConference = PreConference * 2

            ElseIf chk_AI.Checked = True Or chk_ComputerOrginization.Checked = True Or _
                chk_SoftwareEngineering.Checked = True Then

                TotalPreConference = PreConference

            End If

        End If

        Dim ConferenceCost As Integer = (NumberDays * CostPerDay) + TotalPreConference
        Dim Result As DialogResult

        Result = MsgBox(ConferenceCost.ToString("C"), MsgBoxStyle.OkCancel, "Conference Cost")

        If Result = MsgBoxResult.Cancel Then
            Clear()
        Else

            Dim Count As Integer = 1
            Dim MaxNumberOfEntries = 5
            Dim ThingsLearned As String = InputBox("Enter things you learned (Maximum 5) " & "#" & Count)
            Dim InputCancle As String = ""

            Do Until Count > MaxNumberOfEntries Or ThingsLearned = InputCancle

                ListBox1.Items.Add(Trim(ThingsLearned))
                Count += 1

                If Count <= MaxNumberOfEntries Then
                    ThingsLearned = InputBox("Enter things you learned (Maximum 5) " & "#" & Count)
                End If
            Loop


            Dim ObjWriter As IO.StreamWriter
            Dim File As String = "C:\Users\big_n\OneDrive - Palm Beach Atlantic University\Visual Studio 2012\Projects\Final Project\Final Project\Log File.txt"

            ObjWriter = My.Computer.FileSystem.OpenTextFileWriter(File, False)

            If chk_PreConference.Checked = True Then
                ObjWriter.WriteLine("Employee ID: " & txt_EmployeeID.Text & Environment.NewLine & txt_FullName.Text & _
                                    Environment.NewLine & "Preconfernce Cources Taken: Yes" & Environment.NewLine & _
                                    "Conference Cost: " & ConferenceCost.ToString("C") & _
                                    Environment.NewLine & "Number of Days: " & NumberDays & Environment.NewLine)
            Else
                ObjWriter.WriteLine("Employee ID: " & txt_EmployeeID.Text & Environment.NewLine & txt_FullName.Text & _
                                        Environment.NewLine & "Preconfernce Cources Taken: No" & Environment.NewLine & _
                                        "Conference Cost: " & ConferenceCost.ToString("C") & _
                                        Environment.NewLine & "Number of Days: " & NumberDays & Environment.NewLine)
            End If

            For Each i In ListBox1.Items
                ObjWriter.WriteLine(i)
            Next

            ObjWriter.Close()
            End If

    End Sub

    Private Sub btn_Cleara_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        Clear()
    End Sub

    Private Sub btn_Return_Click(sender As Object, e As EventArgs) Handles btn_Return3.Click
        Hide()
        Start_Menu.Show()
    End Sub

    Private Sub Clear()
        txt_EmployeeID.ForeColor = Color.DimGray
        txt_EmployeeID.Text = "Employee ID"
        txt_FullName.ForeColor = Color.DimGray
        txt_FullName.Text = "Full Name"
        rdo_1Day.Checked = True
        chk_PreConference.Checked = False
        chk_AI.Checked = False
        chk_ComputerOrginization.Checked = False
        chk_SoftwareEngineering.Checked = False
        GroupBox1.Hide()
        ListBox1.Items.Clear()
    End Sub

End Class