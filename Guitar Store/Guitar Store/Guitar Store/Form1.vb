Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'These objects do not appear when the form first loads.
        Pic_Guitar1.Visible = False
        Pic_Guitar2.Visible = False
        Pic_Guitar3.Visible = False
        lbl_Conformation.Visible = False
        Btn_Exit.Enabled = False
    End Sub

    Private Sub btn_Guitar1_Click(sender As Object, e As EventArgs) Handles btn_Guitar1.Click
        'Makes Guitar 1 show when button is clicked
        Pic_Guitar1.Visible = True
        Pic_Guitar2.Visible = False
        Pic_Guitar3.Visible = False

    End Sub

    Private Sub btn_Guitar2_Click(sender As Object, e As EventArgs) Handles btn_Guitar2.Click
        'Makes Guitar 2 show when button is clicked
        Pic_Guitar2.Visible = True
        Pic_Guitar1.Visible = False
        Pic_Guitar3.Visible = False
    End Sub

    Private Sub btn_Guitar3_Click(sender As Object, e As EventArgs) Handles btn_Guitar3.Click
        'Makes Guitar 3 show when button is clicked
        Pic_Guitar3.Visible = True
        Pic_Guitar1.Visible = False
        Pic_Guitar2.Visible = False
    End Sub

    Private Sub btn_Select_Click(sender As Object, e As EventArgs) Handles btn_Select.Click
        lbl_Conformation.Visible = True
        Btn_Exit.Enabled = True
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Close()
    End Sub
End Class
