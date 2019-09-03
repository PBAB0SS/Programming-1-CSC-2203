Public Class Form1

    Private Sub btn_Enter_Click(sender As Object, e As EventArgs) Handles btn_Enter.Click
        Dim Grades(12) As Integer
        Dim Input As Integer
        Dim Count As Integer = 0
        Dim Number As Integer = 1

        While Count <= 12
            Input = InputBox("Enter a Number #" & Number)
            Grades(Count) = Input
            Count += 1
            Number += 1
        End While

        Array.Sort(Grades)

        Dim ObjWriter As IO.StreamWriter
        Dim File As String = "C:\Users\big_n\OneDrive - Palm Beach Atlantic University\Visual Studio 2012\Projects\Final Averages For Semester\Final Averages For Semester\Grades.txt"
        Dim Average As Decimal = (Grades(2) + Grades(3) + Grades(4) + Grades(5) + Grades(6) + Grades(7) + Grades(8) + Grades(9) + Grades(10) + Grades(12)) / 11

        ObjWriter = My.Computer.FileSystem.OpenTextFileWriter(File, False)

        For Each element In Grades
            ObjWriter.WriteLine(element)
        Next

        ObjWriter.WriteLine(Environment.NewLine & "Average: " & Average.ToString("F2") & "%")
        ObjWriter.Close()

    End Sub
End Class
