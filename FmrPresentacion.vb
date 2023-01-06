Imports System.Runtime.InteropServices

Public Class FmrPresentacion


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Dim result3 As Integer = MessageBox.Show("¿Esta seguro que desea Cerrar Sesion?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result3 = DialogResult.Yes Then
            FmrLogin.txtContraseña.Clear()
            FmrLogin.txtContraseña.Focus()
            FmrLogin.Show()
            Me.Close()



        End If


    End Sub

    Private Sub btnmaximizar_Click(sender As Object, e As EventArgs) Handles btnmaximizar.Click

        WindowState = FormWindowState.Maximized
        btnmaximizar.Visible = False
        btnRestaurar.Visible = True


    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click

        WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnmaximizar.Visible = True


    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click

        WindowState = FormWindowState.Minimized

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub BarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseDown


    End Sub
    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If


        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()




    End Sub
    Private Sub horafecha_Tick(sender As Object, e As EventArgs) Handles horafecha.Tick
        lblhora.Text = DateTime.Now.ToLongTimeString
        lblfecha.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub FmrPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    'ARRASTRAR FORMULARIO

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

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnAutos0km.Click
        FrmAutos.Show()
    End Sub

    Private Sub IconButton1_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAutos0km.MouseDown
        Color.FromArgb(238, 27, 36)



    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles btnClientes.Click


        FmrClientevb.Show()

    End Sub

    Private Sub btnClientes_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClientes.MouseDown
        Color.FromArgb(238, 27, 36)
    End Sub

    Private Sub btnVentas_MouseDown(sender As Object, e As MouseEventArgs)
        Color.FromArgb(238, 27, 36)
    End Sub

    Private Sub BtnAutosUsados_MouseDown(sender As Object, e As MouseEventArgs) Handles Btnreport.MouseDown
        Color.FromArgb(238, 27, 36)
    End Sub

    Private Sub BtnReparaciones_MouseDown(sender As Object, e As MouseEventArgs) 
        Color.FromArgb(238, 27, 36)
    End Sub

    Private Sub btnExit_MouseDown(sender As Object, e As MouseEventArgs) Handles btnExit.MouseDown
        Color.FromArgb(238, 27, 36)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result2 As Integer = MessageBox.Show("¿Esta seguro que desea Cerrar Sesion?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result2 = DialogResult.Yes Then
            FmrLogin.txtContraseña.Clear()
            FmrLogin.txtContraseña.Focus()
            FmrLogin.Show()
            Me.Close()



        End If
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If MenuVertical.Width = 220 Then
            tmocultarmenu.Enabled = True
        ElseIf MenuVertical.Width = 60 Then
            tmmostrarmenu.Enabled = True
        End If
    End Sub

    Private Sub tmocultarmenu_Tick(sender As Object, e As EventArgs) Handles tmocultarmenu.Tick

        If MenuVertical.Width <= 60 Then
            Me.tmocultarmenu.Enabled = False
        Else
            Me.MenuVertical.Width = MenuVertical.Width - 20
        End If

    End Sub

    Private Sub tmmostrarmenu_Tick(sender As Object, e As EventArgs) Handles tmmostrarmenu.Tick

        If MenuVertical.Width >= 220 Then
            Me.tmmostrarmenu.Enabled = False
        Else
            Me.MenuVertical.Width = MenuVertical.Width + 20
        End If

    End Sub

    Private Sub lblfecha_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BarraTitulo_Paint(sender As Object, e As PaintEventArgs) Handles BarraTitulo.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        frmStock.lbl_userinfo.Text = "Login Time: " & Date.Now.ToString("hh:mm:ss tt") & ""
        frmStock.Show()

    End Sub

    Private Sub Btnreport_Click(sender As Object, e As EventArgs) Handles Btnreport.Click
        FrmReport.Show()

    End Sub
End Class