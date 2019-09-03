Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Objects that do not load when form first opens
        pic_UpperEndlineSeating.Visible = False
        Pic_LowerEndlineSeating.Visible = False
        Pic_SidelineSeating.Visible = False
        Pic_ClubSeats.Visible = False
        lbl_UpperEndlineSeating.Visible = False
        lbl_LowerEndlineSeating.Visible = False
        lbl_SidlineSeating.Visible = False
        lbl_ClubSeats.Visible = False
        lbl_Confirmation.Visible = False
        btn_Purchase.Enabled = False
        btn_Exit.Enabled = False
    End Sub

    Private Sub btn_UpperEndlineSeating_Click(sender As Object, e As EventArgs) Handles btn_UpperEndlineSeating.Click
        'Picture and text for Upper Endline Seating appear when button is clicked 
        pic_UpperEndlineSeating.Visible = True
        Pic_LowerEndlineSeating.Visible = False
        Pic_SidelineSeating.Visible = False
        Pic_ClubSeats.Visible = False
        lbl_UpperEndlineSeating.Visible = True
        lbl_LowerEndlineSeating.Visible = False
        lbl_SidlineSeating.Visible = False
        lbl_ClubSeats.Visible = False
        lbl_Confirmation.Visible = False
        btn_Purchase.Enabled = True
    End Sub

    Private Sub btn_LowerEndlineSeating_Click(sender As Object, e As EventArgs) Handles btn_LowerEndlineSeating.Click
        'Picture and text for Lower Endline Seating appear when button is clicked
        pic_UpperEndlineSeating.Visible = False
        Pic_LowerEndlineSeating.Visible = True
        Pic_SidelineSeating.Visible = False
        Pic_ClubSeats.Visible = False
        lbl_UpperEndlineSeating.Visible = False
        lbl_LowerEndlineSeating.Visible = True
        lbl_SidlineSeating.Visible = False
        lbl_ClubSeats.Visible = False
        lbl_Confirmation.Visible = False
        btn_Purchase.Enabled = True
    End Sub

    Private Sub btn_SidelineSeating_Click(sender As Object, e As EventArgs) Handles btn_SidelineSeating.Click
        'Picture and text for Sideline Seating appear when button is clicked
        pic_UpperEndlineSeating.Visible = False
        Pic_LowerEndlineSeating.Visible = False
        Pic_SidelineSeating.Visible = True
        Pic_ClubSeats.Visible = False
        lbl_UpperEndlineSeating.Visible = False
        lbl_LowerEndlineSeating.Visible = False
        lbl_SidlineSeating.Visible = True
        lbl_ClubSeats.Visible = False
        lbl_Confirmation.Visible = False
        btn_Purchase.Enabled = True
    End Sub

    Private Sub btn_ClubSeats_Click(sender As Object, e As EventArgs) Handles btn_ClubSeats.Click
        'Picture and text for Club Seating appear when button is clicked
        pic_UpperEndlineSeating.Visible = False
        Pic_LowerEndlineSeating.Visible = False
        Pic_SidelineSeating.Visible = False
        Pic_ClubSeats.Visible = True
        lbl_UpperEndlineSeating.Visible = False
        lbl_LowerEndlineSeating.Visible = False
        lbl_SidlineSeating.Visible = False
        lbl_ClubSeats.Visible = True
        lbl_Confirmation.Visible = False
        btn_Purchase.Enabled = True
    End Sub

    Private Sub btn_Purchase_Click(sender As Object, e As EventArgs) Handles btn_Purchase.Click
        'Confirmation text shows up and exit button is enabled after pressing the purchase button
        lbl_Confirmation.Visible = True
        btn_Exit.Enabled = True
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Close()
    End Sub

End Class
