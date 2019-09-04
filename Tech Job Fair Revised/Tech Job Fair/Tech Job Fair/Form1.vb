Public Class Form1

    'All settings that are applied when the from first loads.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_ExitWindow.ForeColor = Color.Honeydew
        lbl_Date.Visible = False
        lbl_LocatedInLochlanHall.Visible = False
        lbl_Room101.Visible = False
    End Sub

    'All actions that occur after View Job Fair Details button is clicked
    Private Sub btn_ViewJobFiarDetails_Click(sender As Object, e As EventArgs) Handles btn_ViewJobFiarDetails.Click
        btn_ViewJobFiarDetails.ForeColor = Color.Honeydew
        btn_ExitWindow.ForeColor = Color.Black
        lbl_Date.Visible = True
        lbl_LocatedInLochlanHall.Visible = True
        lbl_Room101.Visible = True
        btn_ExitWindow.Enabled = True
    End Sub

    'Exit button
    Private Sub btn_ExitWindow_Click(sender As Object, e As EventArgs) Handles btn_ExitWindow.Click
        Close()
    End Sub

End Class
