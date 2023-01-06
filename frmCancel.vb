Public Class frmCancel
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()

    End Sub

    Private Sub frmCancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_transaction()
    End Sub


    Sub load_transaction()

        DataGridView1.Rows.Clear()

        Try

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select transno, transdate, transmonth,ID_Auto,Marca,Modelo,Color,Año,Placa,Precio,grandtotal From AutoInventory"
            lectordatos = acciones.ExecuteReader

            While lectordatos.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, lectordatos.Item("ID_Auto"), lectordatos.Item("transdate"), lectordatos.Item("transno"), lectordatos.Item("grandtotal"))
            End While

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        lectordatos.Close()

    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "Column5" Then

            If MsgBox("Are You Sure Cancel This Order", vbQuestion + vbYesNo) = vbYes Then

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "DELETE From AutoInventory WHERE transno= @transno"
                acciones.Parameters.Clear()
                acciones.Parameters.AddWithValue("@transno", DataGridView1.CurrentRow.Cells(3).Value)
                acciones.ExecuteNonQuery()
                MsgBox("Order Cancel Success!", vbInformation)
            Else
                Return




            End If

        End If
        Update_Autostatus()
        load_transaction()
        frmStock.Load_Autos()

    End Sub


    Sub Update_Autostatus()


        Try

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "UPDATE Compra set Estado = @Estado Where ID_Compra = @ID_Compra"


            acciones.Parameters.Clear()
            acciones.Parameters.AddWithValue("@Estado", "DISPONIBLE")
            acciones.Parameters.AddWithValue("@ID_Compra", DataGridView1.CurrentRow.Cells(1).Value)
            acciones.ExecuteNonQuery()





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class