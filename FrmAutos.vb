
Imports System.IO

Public Class FrmAutos
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()

    End Sub

    Private Sub CmdVolver_Click(sender As Object, e As EventArgs) Handles CmdVolver.Click
        Close()

    End Sub

    Private Sub FrmAutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaauto()

    End Sub


    Public Sub cargareparacion()

        If grillareparacion.Rows.Count <> 0 Then
            grillareparacion.Rows.Clear()
        End If

        'llama a la funcion de carga de registros 

        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "select * from Reparacion where ID_Auto= " & GrillaAuto.CurrentRow.Cells(0).Value & " order by ID_Reparacion"


        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                grillareparacion.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4))

            End While



        Else

        End If

        lectordatos.Close()

    End Sub

    Public Sub cargaauto()

        If GrillaAuto.Rows.Count <> 0 Then
            GrillaAuto.Rows.Clear()
        End If

        'llama a la funcion de carga de registros 

        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from Compra order by ID_Compra"

        lectordatos = acciones.ExecuteReader

        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaAuto.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub

    Private Sub CmdAgregar1_Click(sender As Object, e As EventArgs) Handles CmdAgregar1.Click
        frmAbmAutos.lblseñal.Text = "AGREGAR"
        frmAbmAutos.txt_search.Visible = False
        frmAbmAutos.search.Visible = False
        frmAbmAutos.PictureBox4.Visible = False


        frmAbmAutos.Show()

    End Sub

    Private Sub CmdModificar1_Click(sender As Object, e As EventArgs) Handles CmdModificar1.Click

        frmAbmAutos.lblseñal.Text = "MODIFICAR"
        frmAbmAutos.txt_search.Text = GrillaAuto.CurrentRow.Cells(0).Value
        frmAbmAutos.txt_search.Focus()
        frmAbmAutos.Show()


    End Sub

    Private Sub cmdEliminar1_Click(sender As Object, e As EventArgs) Handles cmdEliminar1.Click

        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Compra WHERE ID_Compra = " & Val(GrillaAuto.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga de auto para refrescar la grilla
            cargaauto()



        End If

    End Sub

    Public Sub busquedaauto(ByVal id As String, ByVal dgv As DataGridView)

        If GrillaAuto.Rows.Count <> 0 Then
            GrillaAuto.Rows.Clear()
        End If

        'llama a la funcion de carga de registros de alumnos

        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from Compra Where ID_Compra like '" & "%" + id + "%" & "' or Marca like '" & "%" + id + "%" & "' "

        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaAuto.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub
    Private Sub txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged

        If txtbusqueda.Text.Contains("'") Then
            MsgBox("Este Caracter no es valido ")
            txtbusqueda.Clear()
        End If

        busquedaauto(txtbusqueda.Text, GrillaAuto)

        If txtbusqueda.Text = "" Then
            cargaauto()

        End If


    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GrillaAuto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaAuto.CellContentClick

    End Sub

    Private Sub GrillaAuto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaAuto.CellClick
        cargareparacion()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        FrmABMReparacion.lblseñalreparacion.Text = "AGREGAR"
        FrmABMReparacion.txtidauto.Text = GrillaAuto.CurrentRow.Cells(0).Value

        FrmABMReparacion.Show()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        FrmABMReparacion.lblseñalreparacion.Text = "MODIFICAR"
        FrmABMReparacion.txtid.Text = grillareparacion.CurrentRow.Cells(0).Value
        FrmABMReparacion.txtidauto.Text = grillareparacion.CurrentRow.Cells(1).Value
        FrmABMReparacion.fechareparacion.Value = grillareparacion.CurrentRow.Cells(2).Value
        FrmABMReparacion.txtdescripcion.Text = grillareparacion.CurrentRow.Cells(3).Value
        FrmABMReparacion.txtcosto.Text = grillareparacion.CurrentRow.Cells(4).Value

        FrmABMReparacion.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Reparacion WHERE ID_Reparacion = " & Val(grillareparacion.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion  para refrescar la grilla
            cargareparacion()




        End If


    End Sub



    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If GrillaAuto.Rows.Count <> 0 Then
            GrillaAuto.Rows.Clear()
        End If


        If RadioButton2.Checked = True Then

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Compra where Estado = 'VENDIDO' order by ID_Compra"
            lectordatos = acciones.ExecuteReader

            If lectordatos.HasRows Then

                While lectordatos.Read()

                    GrillaAuto.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13))
                End While

            Else

            End If

            lectordatos.Close()



            End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If GrillaAuto.Rows.Count <> 0 Then
            GrillaAuto.Rows.Clear()
        End If

        If RadioButton3.Checked = True Then

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Compra where Estado = 'DISPONIBLE' order by ID_Compra"
            lectordatos = acciones.ExecuteReader

            If lectordatos.HasRows Then

                While lectordatos.Read()

                    GrillaAuto.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13))
                End While

            Else

            End If

            lectordatos.Close()



        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If GrillaAuto.Rows.Count <> 0 Then
            GrillaAuto.Rows.Clear()
        End If

        If RadioButton1.Checked = True Then
            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Compra where Estado = 'REPARACION' order by ID_Compra"
            lectordatos = acciones.ExecuteReader
            If lectordatos.HasRows Then
                While lectordatos.Read()
                    GrillaAuto.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13))
                End While
            Else
            End If

            lectordatos.Close()
        End If
    End Sub



    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If GrillaAuto.Rows.Count <> 0 Then
            GrillaAuto.Rows.Clear()
        End If

        If RadioButton4.Checked = True Then
            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Compra order by ID_Compra"
            lectordatos = acciones.ExecuteReader
            If lectordatos.HasRows Then
                While lectordatos.Read()
                    GrillaAuto.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13))
                End While
            Else
            End If

            lectordatos.Close()
        End If
    End Sub




End Class