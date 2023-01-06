
Imports System.IO
Public Class frmStock

    Private WithEvents pic As New PictureBox
    Private WithEvents lblautoid As New Label
    Private WithEvents lblMarca As New Label
    Private WithEvents lblprice As New Label

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        clear()
        Close()

    End Sub


    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_TransactionDate.Text = Date.Now.ToString("yyyy-MM-dd")
        Auto_GenerateTrasnsNo()
        Load_Autos()
    End Sub

    Sub Auto_GenerateTrasnsNo()

        Try

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * From AutoInventory order by ID desc"
            lectordatos = acciones.ExecuteReader
            lectordatos.Read()

            If lectordatos.HasRows Then
                lbl_TransactionNo.Text = lectordatos.Item("transno").ToString + 1
            Else
                lbl_TransactionNo.Text = Date.Now.ToString("yyyyMM") & "001"


            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        lectordatos.Close()

    End Sub


    Sub total()
        Dim sum As Double = 0
        For k As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(k).Cells(7).Value


        Next

        lbl_GrandTotal.Text = Format(CDec(sum), "#,##0.00")

    End Sub
    Sub Load_Autos()


        FlowLayoutPanel1.AutoScroll = True

        FlowLayoutPanel1.Controls.Clear()

        acciones.Connection = conexionSql
        acciones.CommandType = CommandType.Text
        acciones.CommandText = "Select ID_Compra, Marca,Modelo,Color,Año,Placa,Estado, Precio,Foto From Compra"
        lectordatos = acciones.ExecuteReader


        If lectordatos.HasRows Then

            While lectordatos.Read



                load_controls()

            End While
        End If

        lectordatos.Dispose()

        lectordatos.Close()


    End Sub
    Sub load_controls()

        Dim len As Long = lectordatos.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        lectordatos.GetBytes(0, 0, array, 0, CInt(len))

        pic = New PictureBox
        pic.Width = 120
        pic.Height = 150
        pic.BackgroundImageLayout = ImageLayout.Stretch
        pic.Tag = lectordatos.Item("ID_Compra").ToString


        lblautoid = New Label
        With lblautoid
            .ForeColor = Color.White
            .BackColor = Color.FromArgb(50, 50, 50)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Tag = lectordatos.Item("ID_Compra").ToString
        End With

        lblMarca = New Label
        With lblMarca
            .ForeColor = Color.White
            .BackColor = Color.FromArgb(50, 50, 50)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Tag = lectordatos.Item("ID_Compra").ToString
        End With

        lblprice = New Label
        With lblprice
            .ForeColor = Color.Orange
            .BackColor = Color.FromArgb(50, 50, 50)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Bottom
            .Font = New Font("Segoe UI", 12, FontStyle.Bold)
            .Tag = lectordatos.Item("ID_Compra").ToString
        End With




        Dim bytes As Byte() = lectordatos.Item("Foto")
        Dim ms As New MemoryStream(bytes)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        pic.BackgroundImage = bitmap
        lblautoid.Text = lectordatos.Item("ID_Compra").ToString
        lblMarca.Text = lectordatos.Item("Marca").ToString
        lblprice.Text = lectordatos.Item("Precio").ToString

        pic.Controls.Add(lblautoid)
        pic.Controls.Add(lblMarca)
        pic.Controls.Add(lblprice)

        FlowLayoutPanel1.Controls.Add(pic)

        AddHandler pic.Click, AddressOf selectimg_click
        AddHandler lblautoid.Click, AddressOf selectimg_click
        AddHandler lblMarca.Click, AddressOf selectimg_click
        AddHandler lblprice.Click, AddressOf selectimg_click

        Dim Estado As String = lectordatos("Estado")

        ' Si el valor de la columna "estatus" es "sell", elimina el control del FlowLayoutPanel
        If Estado = "VENDIDO" Then
            FlowLayoutPanel1.Controls.Remove(pic)
        End If


    End Sub

    Public Sub selectimg_click(sender As Object, e As EventArgs)

        Try

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select  ID_Compra, Marca,Modelo,Color,Año,Placa, Precio From Compra WHERE ID_Compra like '%" & sender.tag.ToString & "%'"
            lectordatos = acciones.ExecuteReader

            While lectordatos.Read = True


                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, lectordatos.Item("ID_Compra"), lectordatos.Item("Marca"), lectordatos.Item("Modelo"), lectordatos.Item("Color"), lectordatos.Item("Año"), lectordatos.Item("Placa"), lectordatos.Item("Precio"))




            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        lectordatos.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total()
    End Sub

    Private Sub txt__search_TextChanged(sender As Object, e As EventArgs) Handles txt__search.TextChanged

        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()

        acciones.Connection = conexionSql
        acciones.CommandType = CommandType.Text
        acciones.CommandText = "Select ID_Compra, Marca,Modelo,Color,Año,Placa,Estado, Precio,Foto From Compra WHERE ID_Compra like '%" & txt__search.Text & "%' or Marca like '%" & txt__search.Text & "%'"
        lectordatos = acciones.ExecuteReader


        If lectordatos.HasRows Then

            While lectordatos.Read
                load_controls()

            End While
        End If

        'lectordatos.Dispose()

        lectordatos.Close()

    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click

        If lbl_GrandTotal.Text > txt_enteramount.Text Then
            MsgBox("insufficient amount", vbExclamation)
            Return

        Else

            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO AutoInventory (transno, transdate, transmonth,ID_Auto,Marca,Modelo,Color,Año,Placa,Precio,grandtotal)VALUES(@transno, @transdate, @transmonth,@ID_Auto,@Marca,@Modelo,@Color,@Año,@Placa,@Precio,@grandtotal)"
                For j As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                    acciones.Parameters.Clear()
                    acciones.Parameters.AddWithValue("@transno", lbl_TransactionNo.Text)
                    acciones.Parameters.AddWithValue("@transdate", lbl_TransactionDate.Text)
                    acciones.Parameters.AddWithValue("@transmonth", Date.Now.ToString("MM"))

                    acciones.Parameters.AddWithValue("@ID_Auto", DataGridView1.Rows(j).Cells(1).Value)
                    acciones.Parameters.AddWithValue("@Marca", DataGridView1.Rows(j).Cells(2).Value)
                    acciones.Parameters.AddWithValue("@Modelo", DataGridView1.Rows(j).Cells(3).Value)
                    acciones.Parameters.AddWithValue("@Color", DataGridView1.Rows(j).Cells(4).Value)
                    acciones.Parameters.AddWithValue("@Año", DataGridView1.Rows(j).Cells(5).Value)
                    acciones.Parameters.AddWithValue("@Placa", DataGridView1.Rows(j).Cells(6).Value)
                    acciones.Parameters.AddWithValue("@Precio", DataGridView1.Rows(j).Cells(7).Value)



                    acciones.Parameters.AddWithValue("@grandtotal", lbl_GrandTotal.Text)
                    acciones.ExecuteNonQuery()
                    MsgBox("Tranaction save Success!", vbOKOnly + vbInformation)



                Next

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            update_autos()
            clear()

        End If



    End Sub

    Sub clear()


        DataGridView1.Rows.Clear()
        Load_Autos()
        Auto_GenerateTrasnsNo()
        txt_enteramount.Clear()
        txt__search.Clear()
        lbl_GrandTotal.Text = "0.00"

    End Sub


    Sub update_autos()

        Try

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "UPDATE Compra SET Estado = @Estado where ID_Compra = @ID_Compra"

            For j As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                acciones.Parameters.Clear()
                acciones.Parameters.AddWithValue("@Estado", "VENDIDO")
                acciones.Parameters.AddWithValue("@ID_Compra", DataGridView1.Rows(j).Cells(1).Value)


                acciones.ExecuteNonQuery()
            Next




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_managebook_Click(sender As Object, e As EventArgs) Handles btn_managebook.Click
        clear()

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        frmCancel.Show()
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        FrmReport.Show()

    End Sub
End Class