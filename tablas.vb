Public Class Form1
    Private Sub gtablas_Click(sender As Object, e As EventArgs) Handles gtablas.Click
        Dim ntabla, i As SByte
        ntabla = txtabla.Text

        Textabla.Items.Clear()
        If ntabla <= 12 Then
            For i = 1 To 10
                Textabla.Items.Add(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString())
            Next
        Else
            Textabla.Items.Add("porfavor solo ingrese numeros menor o igual a 12")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Textabla.SelectedIndexChanged

    End Sub
End Class
