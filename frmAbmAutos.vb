Imports System.IO

Public Class frmAbmAutos
    Private Sub cbo_provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_metodopago.SelectedIndexChanged

    End Sub

    Private Sub Cmdsalir_Click(sender As Object, e As EventArgs) Handles Cmdsalir.Click
        Close()

    End Sub

    Private Sub pic_foto_Click(sender As Object, e As EventArgs) Handles pic_foto.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

            pic_foto.Image = Image.FromFile(pop.FileName)

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FmrClientevb.lbl_señal.Text = "buscar"
        FmrClientevb.Show()
    End Sub

    Private Sub cmdaceptar_Click(sender As Object, e As EventArgs) Handles cmdaceptar.Click

        If lblseñal.Text = "AGREGAR" Then

            Try



                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Compra (ID_Compra,ID_Cliente, Fecha_Ingreso, Marca, Modelo, Color, Año, Placa, Foto, Costo_Patente, Costo_Compra, Metodo_Pago, Estado, Precio)VALUES(@ID_Compra,@ID_Cliente, @Fecha_Ingreso, @Marca, @Modelo, @Color, @Año, @Placa, @Foto, @Costo_Patente, @Costo_Compra, @Metodo_Pago, @Estado, @Precio)"
                acciones.Parameters.Clear()
                acciones.Parameters.AddWithValue("@ID_Compra", txtid.Text)
                acciones.Parameters.AddWithValue("@ID_Cliente", txtidcliente.Text)
                acciones.Parameters.AddWithValue("@Fecha_Ingreso", fechaingreso.Value)
                acciones.Parameters.AddWithValue("@Marca", txtmarca.Text)
                acciones.Parameters.AddWithValue("@Modelo", txtmodelo.Text)
                acciones.Parameters.AddWithValue("@Color", txtcolor.Text)
                acciones.Parameters.AddWithValue("@Año", txtaño.Text)
                acciones.Parameters.AddWithValue("@Placa", txtplaca.Text)
                acciones.Parameters.AddWithValue("@Costo_Patente", txtcostopatente.Text)
                acciones.Parameters.AddWithValue("@Costo_Compra", txtcostocompra.Text)
                acciones.Parameters.AddWithValue("@Metodo_Pago", cbo_metodopago.Text)
                acciones.Parameters.AddWithValue("@Estado", cbo_estado.Text)
                acciones.Parameters.AddWithValue("@Precio", txtpreciov.Text)


                Dim filesize As New UInt32
                Dim mstream As New System.IO.MemoryStream
                pic_foto.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.GetBuffer
                filesize = mstream.Length
                mstream.Close()

                acciones.Parameters.AddWithValue("@Foto", picture)


                acciones.ExecuteNonQuery()


                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)



                'conexion.close


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try


            FrmAutos.cargaauto()
            Close()


        End If

        If lblseñal.Text = "MODIFICAR" Then

            Try



                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Compra SET ID_Cliente = @ID_Cliente, Fecha_Ingreso = @Fecha_Ingreso, Marca = @Marca, Modelo =@Modelo, Color =@Color, Año =@Año, Placa =@Placa, Costo_Patente =@Costo_Patente, Costo_Compra =@Costo_Compra, Metodo_Pago =@Metodo_Pago, Estado =@Estado, Precio =@Precio, Foto =@Foto where ID_Compra = @ID_Compra"
                acciones.Parameters.Clear()
                acciones.Parameters.AddWithValue("@ID_Compra", txtid.Text)
                acciones.Parameters.AddWithValue("@ID_Cliente", txtidcliente.Text)
                acciones.Parameters.AddWithValue("@Fecha_Ingreso", fechaingreso.Value)
                acciones.Parameters.AddWithValue("@Marca", txtmarca.Text)
                acciones.Parameters.AddWithValue("@Modelo", txtmodelo.Text)
                acciones.Parameters.AddWithValue("@Color", txtcolor.Text)
                acciones.Parameters.AddWithValue("@Año", txtaño.Text)
                acciones.Parameters.AddWithValue("@Placa", txtplaca.Text)
                acciones.Parameters.AddWithValue("@Costo_Patente", txtcostopatente.Text)
                acciones.Parameters.AddWithValue("@Costo_Compra", txtcostocompra.Text)
                acciones.Parameters.AddWithValue("@Metodo_Pago", cbo_metodopago.Text)
                acciones.Parameters.AddWithValue("@Estado", cbo_estado.Text)
                acciones.Parameters.AddWithValue("@Precio", txtpreciov.Text)


                Dim filesize As New UInt32
                Dim mstream As New System.IO.MemoryStream
                pic_foto.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
                Dim picture() As Byte = mstream.GetBuffer
                filesize = mstream.Length
                mstream.Close()




                acciones.Parameters.AddWithValue("@Foto", picture)


                acciones.ExecuteNonQuery()


                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)



                'conexion.close


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try


            FrmAutos.cargaauto()
            Close()


        End If






    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()

    End Sub

    Private Sub frmAbmAutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles search.Click

        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "select ID_Compra, ID_Cliente,Fecha_Ingreso, Marca, Modelo,Color,Año,Placa,Costo_Patente,Costo_Compra,Metodo_Pago,Estado,Precio,Foto from Compra Where ID_Compra='" & txt_search.Text & "'"

        lectordatos = acciones.ExecuteReader

        While lectordatos.Read = True

            txtid.Text = lectordatos.Item("ID_Compra")
            txtidcliente.Text = lectordatos.Item("ID_Cliente")
            fechaingreso.Value = lectordatos.Item("Fecha_Ingreso")
            txtmarca.Text = lectordatos.Item("Marca")
            txtmodelo.Text = lectordatos.Item("Modelo")
            txtcolor.Text = lectordatos.Item("Color")
            txtaño.Text = lectordatos.Item("Año")
            txtplaca.Text = lectordatos.Item("Placa")
            txtcostopatente.Text = lectordatos.Item("Costo_Patente")
            txtcostocompra.Text = lectordatos.Item("Costo_Compra")
            cbo_metodopago.Text = lectordatos.Item("Metodo_Pago")
            cbo_estado.Text = lectordatos.Item("Estado")
            txtpreciov.Text = lectordatos.Item("Precio")

            Dim bytes As Byte() = lectordatos.Item("Foto")
            Dim ms As New MemoryStream(bytes)
            pic_foto.Image = Image.FromStream(ms)


        End While

        lectordatos.Close()

    End Sub

    Private Sub txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class