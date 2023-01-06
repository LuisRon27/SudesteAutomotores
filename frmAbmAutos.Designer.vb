<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbmAutos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdaceptar = New System.Windows.Forms.ToolStripButton()
        Me.Cmdsalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblseñal = New System.Windows.Forms.Label()
        Me.txtcostopatente = New System.Windows.Forms.TextBox()
        Me.txtplaca = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbo_metodopago = New System.Windows.Forms.ComboBox()
        Me.txtcostocompra = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtaño = New System.Windows.Forms.TextBox()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.fechaingreso = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.txtcolor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbo_estado = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtpreciov = New System.Windows.Forms.TextBox()
        Me.pic_foto = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.PictureBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.BarraTitulo.Controls.Add(Me.Label4)
        Me.BarraTitulo.Controls.Add(Me.PictureBox1)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(890, 38)
        Me.BarraTitulo.TabIndex = 7
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = Global.SudesteAutomotores.My.Resources.Resources.minimazar
        Me.btnMinimizar.Location = New System.Drawing.Point(822, 7)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "ABM - AUTO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.SudesteAutomotores.My.Resources.Resources.cerrar
        Me.PictureBox1.Location = New System.Drawing.Point(853, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdaceptar, Me.Cmdsalir, Me.ToolStripSeparator1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 38)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(890, 71)
        Me.ToolStrip1.TabIndex = 60
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdaceptar
        '
        Me.cmdaceptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdaceptar.Image = Global.SudesteAutomotores.My.Resources.Resources.Aceptar
        Me.cmdaceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdaceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdaceptar.Name = "cmdaceptar"
        Me.cmdaceptar.Size = New System.Drawing.Size(68, 68)
        Me.cmdaceptar.Text = "Aceptar"
        Me.cmdaceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Cmdsalir
        '
        Me.Cmdsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdsalir.Image = Global.SudesteAutomotores.My.Resources.Resources.Cancelar
        Me.Cmdsalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdsalir.Name = "Cmdsalir"
        Me.Cmdsalir.Size = New System.Drawing.Size(68, 68)
        Me.Cmdsalir.Text = "Salir"
        Me.Cmdsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'lblseñal
        '
        Me.lblseñal.AutoSize = True
        Me.lblseñal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblseñal.ForeColor = System.Drawing.Color.White
        Me.lblseñal.Location = New System.Drawing.Point(432, 41)
        Me.lblseñal.Name = "lblseñal"
        Me.lblseñal.Size = New System.Drawing.Size(52, 19)
        Me.lblseñal.TabIndex = 61
        Me.lblseñal.Text = "Señal"
        '
        'txtcostopatente
        '
        Me.txtcostopatente.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtcostopatente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcostopatente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcostopatente.ForeColor = System.Drawing.Color.White
        Me.txtcostopatente.Location = New System.Drawing.Point(131, 399)
        Me.txtcostopatente.Name = "txtcostopatente"
        Me.txtcostopatente.Size = New System.Drawing.Size(153, 27)
        Me.txtcostopatente.TabIndex = 79
        '
        'txtplaca
        '
        Me.txtplaca.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtplaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtplaca.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplaca.ForeColor = System.Drawing.Color.White
        Me.txtplaca.Location = New System.Drawing.Point(97, 346)
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Size = New System.Drawing.Size(187, 27)
        Me.txtplaca.TabIndex = 78
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(8, 514)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 19)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Costo Compra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 402)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 19)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Costo Patente"
        '
        'cbo_metodopago
        '
        Me.cbo_metodopago.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cbo_metodopago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_metodopago.ForeColor = System.Drawing.Color.White
        Me.cbo_metodopago.FormattingEnabled = True
        Me.cbo_metodopago.Items.AddRange(New Object() {"Efectivo", "Transferencia", "Cheque"})
        Me.cbo_metodopago.Location = New System.Drawing.Point(131, 460)
        Me.cbo_metodopago.Name = "cbo_metodopago"
        Me.cbo_metodopago.Size = New System.Drawing.Size(153, 21)
        Me.cbo_metodopago.TabIndex = 75
        '
        'txtcostocompra
        '
        Me.txtcostocompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtcostocompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcostocompra.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcostocompra.ForeColor = System.Drawing.Color.White
        Me.txtcostocompra.Location = New System.Drawing.Point(131, 511)
        Me.txtcostocompra.Name = "txtcostocompra"
        Me.txtcostocompra.Size = New System.Drawing.Size(153, 27)
        Me.txtcostocompra.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(13, 462)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 19)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Metodo Pago"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(34, 349)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 19)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Placa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(611, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 19)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Color"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(317, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 19)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "# Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Marca"
        '
        'txtaño
        '
        Me.txtaño.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtaño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaño.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaño.ForeColor = System.Drawing.Color.White
        Me.txtaño.Location = New System.Drawing.Point(97, 292)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(187, 27)
        Me.txtaño.TabIndex = 66
        '
        'txtmarca
        '
        Me.txtmarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtmarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmarca.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmarca.ForeColor = System.Drawing.Color.White
        Me.txtmarca.Location = New System.Drawing.Point(96, 216)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(188, 27)
        Me.txtmarca.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(730, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 19)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "#"
        '
        'txtidcliente
        '
        Me.txtidcliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtidcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtidcliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidcliente.ForeColor = System.Drawing.Color.White
        Me.txtidcliente.Location = New System.Drawing.Point(96, 159)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(136, 27)
        Me.txtidcliente.TabIndex = 63
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.ForeColor = System.Drawing.Color.White
        Me.txtid.Location = New System.Drawing.Point(753, 131)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(108, 27)
        Me.txtid.TabIndex = 62
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.SudesteAutomotores.My.Resources.Resources.find_search_document_6167
        Me.PictureBox3.Location = New System.Drawing.Point(252, 154)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 80
        Me.PictureBox3.TabStop = False
        '
        'fechaingreso
        '
        Me.fechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaingreso.Location = New System.Drawing.Point(429, 162)
        Me.fechaingreso.Name = "fechaingreso"
        Me.fechaingreso.Size = New System.Drawing.Size(150, 20)
        Me.fechaingreso.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(305, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Fecha Ingreso"
        '
        'txtmodelo
        '
        Me.txtmodelo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtmodelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmodelo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodelo.ForeColor = System.Drawing.Color.White
        Me.txtmodelo.Location = New System.Drawing.Point(391, 216)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(188, 27)
        Me.txtmodelo.TabIndex = 83
        '
        'txtcolor
        '
        Me.txtcolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcolor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcolor.ForeColor = System.Drawing.Color.White
        Me.txtcolor.Location = New System.Drawing.Point(667, 219)
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Size = New System.Drawing.Size(188, 27)
        Me.txtcolor.TabIndex = 84
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(36, 292)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 19)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Año"
        '
        'cbo_estado
        '
        Me.cbo_estado.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cbo_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_estado.ForeColor = System.Drawing.Color.White
        Me.cbo_estado.FormattingEnabled = True
        Me.cbo_estado.Items.AddRange(New Object() {"DISPONIBLE", "VENDIDO", "REPARACION"})
        Me.cbo_estado.Location = New System.Drawing.Point(133, 565)
        Me.cbo_estado.Name = "cbo_estado"
        Me.cbo_estado.Size = New System.Drawing.Size(153, 21)
        Me.cbo_estado.TabIndex = 87
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(18, 567)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 19)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Estado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(15, 619)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 19)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "Precio V."
        '
        'txtpreciov
        '
        Me.txtpreciov.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtpreciov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpreciov.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpreciov.ForeColor = System.Drawing.Color.White
        Me.txtpreciov.Location = New System.Drawing.Point(131, 611)
        Me.txtpreciov.Name = "txtpreciov"
        Me.txtpreciov.Size = New System.Drawing.Size(153, 27)
        Me.txtpreciov.TabIndex = 89
        '
        'pic_foto
        '
        Me.pic_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_foto.Location = New System.Drawing.Point(436, 322)
        Me.pic_foto.Name = "pic_foto"
        Me.pic_foto.Size = New System.Drawing.Size(326, 310)
        Me.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_foto.TabIndex = 90
        Me.pic_foto.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(579, 292)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 19)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "Foto"
        '
        'search
        '
        Me.search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search.Image = Global.SudesteAutomotores.My.Resources.Resources.find_search_document_6167
        Me.search.Location = New System.Drawing.Point(340, 70)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(32, 32)
        Me.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.search.TabIndex = 94
        Me.search.TabStop = False
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_search.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.ForeColor = System.Drawing.Color.White
        Me.txt_search.Location = New System.Drawing.Point(389, 77)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(186, 20)
        Me.txt_search.TabIndex = 93
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SudesteAutomotores.My.Resources.Resources.Canal_VB_NET_Buscar_2
        Me.PictureBox4.Location = New System.Drawing.Point(378, 75)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(208, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 92
        Me.PictureBox4.TabStop = False
        '
        'frmAbmAutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(890, 663)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.pic_foto)
        Me.Controls.Add(Me.txtpreciov)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbo_estado)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtcolor)
        Me.Controls.Add(Me.txtmodelo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fechaingreso)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtcostopatente)
        Me.Controls.Add(Me.txtplaca)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbo_metodopago)
        Me.Controls.Add(Me.txtcostocompra)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtaño)
        Me.Controls.Add(Me.txtmarca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lblseñal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAbmAutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAbmAutos"
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdaceptar As ToolStripButton
    Friend WithEvents Cmdsalir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblseñal As Label
    Friend WithEvents txtcostopatente As TextBox
    Friend WithEvents txtplaca As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbo_metodopago As ComboBox
    Friend WithEvents txtcostocompra As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtaño As TextBox
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents fechaingreso As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmodelo As TextBox
    Friend WithEvents txtcolor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbo_estado As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtpreciov As TextBox
    Friend WithEvents pic_foto As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents search As PictureBox
    Friend WithEvents txt_search As TextBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
