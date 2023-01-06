Imports System.Runtime.InteropServices

Public Class FrmAbmCliente

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdaceptar.Click


        'Para Agregar Datos

        If lblseñal.Text = "AGREGAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Cliente(Nombre,Apellido,Dni,Telefono,Email,Provincia,Localidad,Domicilio)VALUES('" & txtnombre.Text & "','" & txtapellido.Text & "','" & txtdni.Text & "', '" & txttelefono.Text & "', '" & txtemail.Text & "','" & cbo_provincia.Text & "','" & txtlocalidad.Text & "','" & txtdomicilio.Text & "')"
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            FmrClientevb.cargacliente()
            Close()

        End If

        'Para agregar los datos modificados 

        If lblseñal.Text = "MODIFICAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Cliente SET Nombre = '" & txtnombre.Text & "',Apellido = '" & txtapellido.Text & "' ,Dni = '" & txtdni.Text & "',Telefono = '" & txttelefono.Text & "' ,Email = '" & txtemail.Text & "',Provincia = '" & cbo_provincia.Text & "',Localidad = '" & txtlocalidad.Text & "',Domicilio = '" & txtdomicilio.Text & "' where ID_Cliente = " & Val(txtid.Text) & ""
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try


            Close()

        End If
        'Para resfrescar la grilla 
        FmrClientevb.cargacliente()




    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdsalir.Click
        Close()

    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub BarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseMove

        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

End Class