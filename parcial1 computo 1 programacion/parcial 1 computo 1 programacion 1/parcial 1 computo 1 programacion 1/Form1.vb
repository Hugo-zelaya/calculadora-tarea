Public Class Form1
    Private Sub porcesar_Click(sender As Object, e As EventArgs) Handles porcesar.Click
        Dim cantidad, unidades, respuesta As String
        cantidad = txtcantidad.Text
        unidades = txtunidades.Text
        respuesta = txtrespuesta.Text
        txtRespuesta.Text = (cantidad \ unidades).ToString() + "/" + (cantidad Mod unidades).ToString()


    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

    End Sub


    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click

        If cbxEntrada.Text = "Pie Cuadrado" And cbxEntrada.Text = "Vara Cuadrada" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 0.36
        ElseIf cbxEntrada.Text = "Pie Cuadrado" And cbxEntrada.Text = "Yarda Cuadrada" Then
            cbxSalida.Text = Val(txtcantidad.Text) / 9
        ElseIf cbxEntrada.Text = "Pie Cuadrado" And cbxEntrada.Text = "Metro Cuadrado" Then
            cbxSalida.Text = Val(txtcantidad.Text) / 10.764
        ElseIf cbxEntrada.Text = "Pie Cuadrado" And cbxEntrada.Text = "Tareas" Then
            cbxSalida.Text = Val(txtcantidad.Text) / 628.8
        ElseIf cbxEntrada.Text = "Pie Cuadrado" And cbxEntrada.Text = "Manzana" Then
            cbxSalida.Text = Val(txtcantidad.Text) / 70.44
        ElseIf cbxEntrada.Text = "Pie Cuadrado" And cbxEntrada.Text = "Hectarea" Then
            cbxSalida.Text = Val(txtcantidad.Text) / 107639
        End If

        If cbxEntrada.Text = "Vara Cuadrada" And cbxEntrada.Text = "Pie Cuadrado" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 2.74
        ElseIf cbxEntrada.Text = "Vara Cuadrada" And cbxEntrada.Text = "Yarda Cuadrada" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 0.91
        ElseIf cbxEntrada.Text = "Vara Cuadrada" And cbxEntrada.Text = "Metro Cuadrado" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 0.83
        ElseIf cbxEntrada.Text = "Vara Cuadrada" And cbxEntrada.Text = "Tareas" Then
            cbxSalida.Text = Val(txtcantidad.Text) / 1000
        ElseIf cbxEntrada.Text = "Vara Cuadrada" And cbxEntrada.Text = "Manzana" Then
            cbxSalida.Text = Val(txtcantidad.Text) / 10000
        ElseIf cbxEntrada.Text = "Vara Cuadrada" And cbxEntrada.Text = "Hectarea" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 0.00006987
        End If

        If cbxEntrada.Text = "Yarda Cuadrada" And cbxEntrada.Text = "Vara Cuadrada" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 1.09
        ElseIf cbxEntrada.Text = "Yarda Cuadrada" And cbxEntrada.Text = "Pie Cuadrado" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 9
        ElseIf cbxEntrada.Text = "Yarda Cuadrada" And cbxEntrada.Text = "Metro Cuadrado" Then
            cbxSalida.Text = Val(txtcantidad.Text) / 1.196
        ElseIf cbxEntrada.Text = "Yarda Cuadrada" And cbxEntrada.Text = "Tareas" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 0.3649
        ElseIf cbxEntrada.Text = "Yarda Cuadrada" And cbxEntrada.Text = "Manzana" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 0.00010854
        ElseIf cbxEntrada.Text = "Yarda Cuadrada" And cbxEntrada.Text = "Hectarea" Then
            cbxSalida.Text = Val(txtcantidad.Text) / 11960
        End If

        If cbxEntrada.Text = "Metro Cuadrado" And cbxEntrada.Text = "Vara Cuadrada" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 1.19
        ElseIf cbxEntrada.Text = "Metro Cuadrado" And cbxEntrada.Text = "Pie Cuadrado" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 10.76
        ElseIf cbxEntrada.Text = "Metro Cuadrado" And cbxEntrada.Text = "Yarda Cuadrada" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 1.196
        ElseIf cbxEntrada.Text = "Metro Cuadrado" And cbxEntrada.Text = "Tareas" Then
            cbxSalida.Text = Val(txtcantidad.Text) / 1000
        ElseIf cbxEntrada.Text = "Metro Cuadrado" And cbxEntrada.Text = "Manzana" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 0.0001434
        ElseIf cbxEntrada.Text = "Metro Cuadrado" And cbxEntrada.Text = "Hectarea" Then
            cbxSalida.Text = Val(txtcantidad.Text) / 10000
        End If


        If cbxEntrada.Text = "Tareas" And cbxEntrada.Text = "Vara Cuadrada" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 624.29
        ElseIf cbxEntrada.Text = "Tareas" And cbxEntrada.Text = "Pie Cuadrado" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 470382
        ElseIf cbxEntrada.Text = "Tareas" And cbxEntrada.Text = "Yarda Cuadrada" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 522.64
        ElseIf cbxEntrada.Text = "Tareas" And cbxEntrada.Text = "Metro Cuadrado" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 437
        ElseIf cbxEntrada.Text = "Tareas" And cbxEntrada.Text = "Manzana" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 0.06
        ElseIf cbxEntrada.Text = "Tareas" And cbxEntrada.Text = "Hectarea" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 0.04
        End If

        If cbxEntrada.Text = "Manzana" And cbxEntrada.Text = "Vara Cuadrada" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 10000
        ElseIf cbxEntrada.Text = "Manzana" And cbxEntrada.Text = "Pie Cuadrado" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 75220.68
        ElseIf cbxEntrada.Text = "Manzana" And cbxEntrada.Text = "Yarda Cuadrada" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 8424.55
        ElseIf cbxEntrada.Text = "Manzana" And cbxEntrada.Text = "Metro Cuadrado" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 7044
        ElseIf cbxEntrada.Text = "Manzana" And cbxEntrada.Text = "Tareas" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 11.202
        ElseIf cbxEntrada.Text = "Manzana" And cbxEntrada.Text = "Hectarea" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 0.69
        End If


        If cbxEntrada.Text = "Hectarea" And cbxEntrada.Text = "Vara cuadrada" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 14233
        ElseIf cbxEntrada.Text = "Hectarea" And cbxEntrada.Text = "Pie Cuadrado" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 107639
        ElseIf cbxEntrada.Text = "Hectarea" And cbxEntrada.Text = "Yarda Cuadrada" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 11960
        ElseIf cbxEntrada.Text = "Hectarea" And cbxEntrada.Text = "Metro Cuadrado" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 10000
        ElseIf cbxEntrada.Text = "Hectarea" And cbxEntrada.Text = "Tareas" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 15.903
        ElseIf cbxEntrada.Text = "Hectarea" And cbxEntrada.Text = "Manzana" Then
            cbxSalida.Text = Val(txtcantidad.Text) * 1.419
        End If
    End Sub

End Class