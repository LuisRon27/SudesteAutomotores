Public Class FrmABMReparacion
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtidauto.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub lblseñal_Click(sender As Object, e As EventArgs) Handles lblseñalreparacion.Click

    End Sub

    Private Sub cmdaceptar_Click(sender As Object, e As EventArgs) Handles cmdaceptar.Click
        'Para Agregar Datos

        If lblseñalreparacion.Text = "AGREGAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Reparacion(ID_Auto,Fecha, Descripcion, Costo)VALUES('" & txtidauto.Text & "','" & fechareparacion.Value & "','" & txtdescripcion.Text & "', '" & txtcosto.Text & "')"
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            FrmAutos.cargaauto()
            Close()

        End If

        If lblseñalreparacion.Text = "MODIFICAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Reparacion SET ID_Auto = '" & txtidauto.Text & "' ,Fecha = '" & fechareparacion.Value & "',Descripcion = '" & txtdescripcion.Text & "',Costo = '" & txtcosto.Text & "'  where ID_Reparacion = " & Val(txtid.Text) & ""
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            FrmAutos.cargaauto()
            Close()

        End If
    End Sub

    Private Sub Cmdsalir_Click(sender As Object, e As EventArgs) Handles Cmdsalir.Click
        Close()

    End Sub
End Class