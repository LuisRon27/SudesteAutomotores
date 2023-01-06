Public Class FrmReport
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()

    End Sub

    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_report()
    End Sub

    Sub load_report()
        DataGridView1.Rows.Clear()


        Try

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select transno,transdate,transmonth,ID_Auto,Marca,Modelo,Color,Año,Placa,Precio,grandtotal from AutoInventory WHERE Placa like '%" & txt_search.Text & "%' or ID_Auto like '%" & txt_search.Text & "%' or Modelo like '%" & txt_search.Text & "%' or Marca like '%" & txt_search.Text & "%'"
            lectordatos = acciones.ExecuteReader

            While lectordatos.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, lectordatos.Item("transno"), lectordatos.Item("transdate"), lectordatos.Item("transmonth"), lectordatos.Item("ID_Auto"), lectordatos.Item("Marca"), lectordatos.Item("Modelo"), lectordatos.Item("Color"), lectordatos.Item("Año"), lectordatos.Item("Placa"), lectordatos.Item("Precio"), lectordatos.Item("grandtotal"))

            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        lectordatos.Close()

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        load_report()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        DataGridView1.Rows.Clear()


        Try

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select transno,transdate,transmonth,ID_Auto,Marca,Modelo,Color,Año,Placa,Precio,grandtotal from AutoInventory WHERE transdate between '" & date1 & "' and '" & date2 & "' "
            lectordatos = acciones.ExecuteReader

            While lectordatos.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, lectordatos.Item("transno"), lectordatos.Item("transdate"), lectordatos.Item("transmonth"), lectordatos.Item("ID_Auto"), lectordatos.Item("Marca"), lectordatos.Item("Modelo"), lectordatos.Item("Color"), lectordatos.Item("Año"), lectordatos.Item("Placa"), lectordatos.Item("Precio"), lectordatos.Item("grandtotal"))

            End While


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        lectordatos.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        ' Obtener el índice de la columna que deseas sumar (en este caso, la columna 8)
        Dim columnIndex As Integer = 11

        ' Obtener la suma de los valores en la columna especificada
        Dim sum As Double = 0

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim cellValue As String = CStr(row.Cells(columnIndex).Value)
            Dim value As Double
            If Double.TryParse(cellValue, value) Then
                ' Si la conversión es exitosa, agregar el valor convertido a la suma
                sum += value
            End If
        Next

        ' Mostrar la suma en el label en formato decimal con dos dígitos decimales
        lbl_total.Text = String.Format("Total: {0:N2}", sum)

    End Sub
End Class