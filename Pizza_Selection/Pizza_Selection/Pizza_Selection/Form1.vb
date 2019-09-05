Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'disables the objects when form is first loaded
        PicDeepDish.Visible = False
        PicThinCrust.Visible = False
        btnSelectPizza.Enabled = False
        btnExit.Enabled = False

    End Sub

    Private Sub btnDeepDish_Click(sender As Object, e As EventArgs) Handles btnDeepDish.Click
        'makes deep dish pizza show when button is clicked
        PicDeepDish.Visible = True
        PicThinCrust.Visible = False
        btnSelectPizza.Enabled = True

    End Sub

    Private Sub btnThinCrust_Click(sender As Object, e As EventArgs) Handles btnThinCrust.Click
        'makes thin crust pizza picture show when button is clicked
        PicThinCrust.Visible = True
        PicDeepDish.Visible = False
        btnSelectPizza.Enabled = True
    End Sub

    Private Sub btnSelectPizza_Click(sender As Object, e As EventArgs) Handles btnSelectPizza.Click
        '
        btnDeepDish.Enabled = False
        btnThinCrust.Enabled = False
        btnSelectPizza.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class