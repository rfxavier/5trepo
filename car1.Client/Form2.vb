Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fg.DataSource = car1.CarCollection.LoadAll
    End Sub
End Class