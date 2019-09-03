Public Class Form1
    Public Shared NameofFranchise(10) As String
    Public Shared investmentCost(10) As Decimal
    Public Shared File As String = "F:\Franchise Investment\Franchise Investment\Resteraunt Project.txt"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreader As IO.StreamReader
        Dim Count As Integer = 0
        If IO.File.Exists(File) Then
            objreader = IO.File.OpenText(File)
            Do While objreader.Peek <> -1
                NameofFranchise(Count) = objreader.ReadLine
                investmentCost(Count) = Convert.ToDecimal(objreader.ReadLine())
                Count += 1
            Loop
            objreader.Close()

            For i = 0 To NameofFranchise.Length - 1
                ListBox1.Items.Add(NameofFranchise(i))

            Next
        Else
            MsgBox("File Not Found")
            Close()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub DisplayResterauntNamesAndInvestmentValuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayResterauntNamesAndInvestmentValuesToolStripMenuItem.Click
        Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Decimal

        total = (investmentCost(0) + investmentCost(1) + investmentCost(2) + investmentCost(3) + investmentCost(4) + investmentCost(5) + investmentCost(6) + investmentCost(7) + investmentCost(8) + investmentCost(9) + investmentCost(10)) / 11

        Select Case ListBox1.SelectedIndex
            Case 0
                Label3.Text = "The Selected resteraunt investment cost of: " & investmentCost(0).ToString("C")
            Case 1
                Label3.Text = "The Selected resteraunt investment cost of: " & investmentCost(1).ToString("C")
            Case 2
                Label3.Text = "The Selected resteraunt investment cost of: " & investmentCost(2).ToString("C")
            Case 3
                Label3.Text = "The Selected resteraunt investment cost of: " & investmentCost(3).ToString("C")
            Case 4
                Label3.Text = "The Selected resteraunt investment cost of: " & investmentCost(4).ToString("C")
            Case 5
                Label3.Text = "The Selected resteraunt investment cost of: " & investmentCost(5).ToString("C")
            Case 6
                Label3.Text = "The Selected resteraunt investment cost of: " & investmentCost(6).ToString("C")
            Case 7
                Label3.Text = "The Selected resteraunt investment cost of: " & investmentCost(7).ToString("C")
            Case 8
                Label3.Text = "The Selected resteraunt investment cost of: " & investmentCost(8).ToString("C")
            Case 9
                Label3.Text = "The Selected resteraunt investment cost of: " & investmentCost(9).ToString("C")
            Case 10
                Label3.Text = "The Selected resteraunt investment cost of: " & investmentCost(10).ToString("C")
        End Select


    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Label3.Text = "The Selected resteraunt investment cost of:"
        Label4.Text = "Average Investment Cost:"
    End Sub
End Class
