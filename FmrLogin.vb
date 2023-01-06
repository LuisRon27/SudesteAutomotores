Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class FmrLogin




    Dim Cont As Integer

    'Abro la cadena de conexion para poder llegar a la base de datos


    Private Sub Iniciar()


        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from Usuario where Nombre='" & Txtusuario.Text & "' and Contraseña='" & txtContraseña.Text & "'"

        lectordatos = acciones.ExecuteReader



        If lectordatos.HasRows = True Then

            Me.Hide()

            Bienvenida.Show()

        Else
            Cont = Cont + 1
            MsgBox("El Usuario Y contraseña no coinciden ", 32, "Advertencia")
            Txtusuario.Text = ""
            txtContraseña.Text = ""
            Txtusuario.Focus()

            If Cont > 2 Then

                MsgBox("Cumplio sus tres intentos ", 16, "Advertencia")
                Me.Close()
            End If

        End If

        lectordatos.Close()

    End Sub









#Region " Form Behaviors"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Application.Exit()


    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub


#End Region
#Region " Drag Form"



    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)


    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown


    End Sub

#End Region

#Region "Customize Controls"

    Private Sub CustomizeComponents()

        'txtuser
        Txtusuario.AutoSize = False
        Txtusuario.Size = New Size(350, 35)

        'txtpass
        txtContraseña.AutoSize = False
        txtContraseña.Size = New Size(350, 35)
        'txtContraseña.UseSystemPasswordChar = True

    End Sub
    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint

        Dim buttonpats As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim Myrectangle As Rectangle = Button1.ClientRectangle
        Myrectangle.Inflate(-7, 30)
        buttonpats.AddEllipse(Myrectangle)
        Button1.Region = New Region(buttonpats)


    End Sub
#End Region
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CustomizeComponents()


    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            conexionSql.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SudesteAutomotores;Data Source=LAPTOP-68VR45A9\SQLEXPRESS"

            conexionSql.Open()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Iniciar()



    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub pbocultar_Click(sender As Object, e As EventArgs) Handles pbocultar.Click
        txtContraseña.PasswordChar = "*"
        pbvisible.Visible = True
        pbocultar.Visible = False

    End Sub

    Private Sub pbvisible_Click(sender As Object, e As EventArgs) Handles pbvisible.Click
        txtContraseña.PasswordChar = ""
        pbvisible.Visible = False
        pbocultar.Visible = True
    End Sub

    Private Sub titlebar_Paint(sender As Object, e As PaintEventArgs) Handles titlebar.Paint

    End Sub
End Class
