Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Form1.tbNombreComercial.Text
        Label2.Text = Form1.tbNIT.Text
        Label3.Text = Form1.tbdireccion.Text
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class