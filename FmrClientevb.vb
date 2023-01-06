Imports System.Runtime.InteropServices

Public Class FmrClientevb


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()

    End Sub


    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Close()
    End Sub


    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FmrClientevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargacliente()

    End Sub


    Public Sub busqueda(ByVal id As String, ByVal dgv As DataGridView)

        If GrillaCliente.Rows.Count <> 0 Then
            GrillaCliente.Rows.Clear()
        End If

        'llama a la funcion de carga de registros de alumnos

        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from Cliente Where ID_Cliente like '" & "%" + id + "%" & "' or Apellido like '" & "%" + id + "%" & "' "

        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaCliente.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub

    Public Sub cargacliente()

        If GrillaCliente.Rows.Count <> 0 Then
            GrillaCliente.Rows.Clear()
        End If

        'llama a la funcion de carga de registros de alumnos

        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "select * from Cliente order by ID_Cliente"


        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaCliente.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8))

            End While



        Else

        End If

        lectordatos.Close()

    End Sub

    Private Sub CmdModificar_Click(sender As Object, e As EventArgs) Handles CmdAgregar1.Click
        FrmAbmCliente.lblseñal.Text = "AGREGAR"
        FrmAbmCliente.Show()

    End Sub


    Private Sub CmdModificar1_Click(sender As Object, e As EventArgs) Handles CmdModificar1.Click

        FrmAbmCliente.lblseñal.Text = "MODIFICAR"
        FrmAbmCliente.txtid.Text = GrillaCliente.CurrentRow.Cells(0).Value
        FrmAbmCliente.txtnombre.Text = GrillaCliente.CurrentRow.Cells(1).Value
        FrmAbmCliente.txtapellido.Text = GrillaCliente.CurrentRow.Cells(2).Value
        FrmAbmCliente.txtdni.Text = GrillaCliente.CurrentRow.Cells(3).Value
        FrmAbmCliente.txttelefono.Text = GrillaCliente.CurrentRow.Cells(4).Value
        FrmAbmCliente.txtemail.Text = GrillaCliente.CurrentRow.Cells(5).Value
        FrmAbmCliente.cbo_provincia.Text = GrillaCliente.CurrentRow.Cells(6).Value
        FrmAbmCliente.txtlocalidad.Text = GrillaCliente.CurrentRow.Cells(7).Value
        FrmAbmCliente.txtdomicilio.Text = GrillaCliente.CurrentRow.Cells(8).Value

        FrmAbmCliente.Show()


    End Sub

    Private Sub CmdVolver_Click(sender As Object, e As EventArgs) Handles CmdVolver.Click
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
    Private Sub BarraTitulo_Paint(sender As Object, e As PaintEventArgs) Handles BarraTitulo.Paint

    End Sub

    Private Sub cmdEliminar1_Click(sender As Object, e As EventArgs) Handles cmdEliminar1.Click
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Cliente WHERE ID_Cliente = " & Val(GrillaCliente.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga de alumno para refrescar la grilla
            cargacliente()



        End If
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged

        If txtbusqueda.Text.Contains("'") Then
            MsgBox("Este Caracter no es valido ")
            txtbusqueda.Clear()
        End If

        busqueda(txtbusqueda.Text, GrillaCliente)

        If txtbusqueda.Text = "" Then
            cargacliente()

        End If

    End Sub

    Private Sub GrillaCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCliente.CellContentClick

    End Sub

    Private Sub GrillaCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCliente.CellDoubleClick
        If lbl_señal.Text = "buscar" Then
            frmAbmAutos.txtidcliente.Text = GrillaCliente.CurrentRow.Cells(0).Value

            Close()

        End If
    End Sub
End Class