<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matriculas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Matriculas))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.datalistadoalumnos = New System.Windows.Forms.DataGridView()
        Me.Eli = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.GUARDARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.txtcosto_MATRICULA = New System.Windows.Forms.TextBox()
        Me.txtimporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTCOMPROBANTE = New System.Windows.Forms.ComboBox()
        Me.TXTNUMERODERECIBO = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MenuStrip6 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.datalistadoalumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.MenuStrip4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtbuscar)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(233, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 49)
        Me.Panel2.TabIndex = 2
        '
        'txtbuscar
        '
        Me.txtbuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.txtbuscar.Location = New System.Drawing.Point(57, 15)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(263, 19)
        Me.txtbuscar.TabIndex = 0
        Me.txtbuscar.Text = "buscar alumnos..."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(35, 47)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 43)
        '
        'datalistadoalumnos
        '
        Me.datalistadoalumnos.AllowUserToAddRows = False
        Me.datalistadoalumnos.AllowUserToDeleteRows = False
        Me.datalistadoalumnos.AllowUserToResizeRows = False
        Me.datalistadoalumnos.BackgroundColor = System.Drawing.Color.LightGray
        Me.datalistadoalumnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistadoalumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datalistadoalumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datalistadoalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadoalumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eli})
        Me.datalistadoalumnos.EnableHeadersVisualStyles = False
        Me.datalistadoalumnos.Location = New System.Drawing.Point(497, 67)
        Me.datalistadoalumnos.Name = "datalistadoalumnos"
        Me.datalistadoalumnos.ReadOnly = True
        Me.datalistadoalumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datalistadoalumnos.RowHeadersVisible = False
        Me.datalistadoalumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.datalistadoalumnos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistadoalumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadoalumnos.Size = New System.Drawing.Size(168, 274)
        Me.datalistadoalumnos.TabIndex = 5
        '
        'Eli
        '
        Me.Eli.HeaderText = ""
        Me.Eli.Image = CType(resources.GetObject("Eli.Image"), System.Drawing.Image)
        Me.Eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eli.Name = "Eli"
        Me.Eli.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Controls.Add(Me.TXTNUMERODERECIBO)
        Me.Panel4.Controls.Add(Me.TXTCOMPROBANTE)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.DateTimePicker1)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.NumericUpDown1)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtimporte)
        Me.Panel4.Controls.Add(Me.txtcosto_MATRICULA)
        Me.Panel4.Controls.Add(Me.ComboBox3)
        Me.Panel4.Controls.Add(Me.ComboBox2)
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.MenuStrip3)
        Me.Panel4.Location = New System.Drawing.Point(34, 98)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(592, 487)
        Me.Panel4.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(32, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Precio Matricula"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(200, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(351, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Ya fue Gestionado en Otra Institucion"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(32, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Seccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(32, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Horario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(32, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Grado"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GUARDARToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(86, 416)
        Me.MenuStrip3.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(107, 29)
        Me.MenuStrip3.TabIndex = 7
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'GUARDARToolStripMenuItem
        '
        Me.GUARDARToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.GUARDARToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GUARDARToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GUARDARToolStripMenuItem.Name = "GUARDARToolStripMenuItem"
        Me.GUARDARToolStripMenuItem.Size = New System.Drawing.Size(99, 25)
        Me.GUARDARToolStripMenuItem.Text = "GUARDAR"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(212, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(212, 60)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox2.TabIndex = 14
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(212, 96)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox3.TabIndex = 15
        '
        'txtcosto_MATRICULA
        '
        Me.txtcosto_MATRICULA.Location = New System.Drawing.Point(174, 158)
        Me.txtcosto_MATRICULA.Name = "txtcosto_MATRICULA"
        Me.txtcosto_MATRICULA.Size = New System.Drawing.Size(100, 20)
        Me.txtcosto_MATRICULA.TabIndex = 16
        Me.txtcosto_MATRICULA.Text = "0"
        '
        'txtimporte
        '
        Me.txtimporte.Location = New System.Drawing.Point(174, 193)
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(100, 20)
        Me.txtimporte.TabIndex = 17
        Me.txtimporte.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(82, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Importe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label6.Location = New System.Drawing.Point(101, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "saldo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(174, 226)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Text = "0"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(446, 160)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 21
        Me.TextBox2.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(286, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 20)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Precio De Pension"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(286, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Cant. de Pensiones"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(446, 193)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(100, 20)
        Me.NumericUpDown1.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(99, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(174, 255)
        Me.DateTimePicker1.MinDate = New Date(2025, 1, 5, 17, 15, 27, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(138, 26)
        Me.DateTimePicker1.TabIndex = 26
        Me.DateTimePicker1.Value = New Date(2025, 1, 5, 17, 15, 27, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(36, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Comprobante"
        '
        'TXTCOMPROBANTE
        '
        Me.TXTCOMPROBANTE.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TXTCOMPROBANTE.FormattingEnabled = True
        Me.TXTCOMPROBANTE.Location = New System.Drawing.Point(174, 304)
        Me.TXTCOMPROBANTE.Name = "TXTCOMPROBANTE"
        Me.TXTCOMPROBANTE.Size = New System.Drawing.Size(170, 21)
        Me.TXTCOMPROBANTE.TabIndex = 28
        '
        'TXTNUMERODERECIBO
        '
        Me.TXTNUMERODERECIBO.AutoSize = True
        Me.TXTNUMERODERECIBO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTNUMERODERECIBO.Location = New System.Drawing.Point(32, 341)
        Me.TXTNUMERODERECIBO.Name = "TXTNUMERODERECIBO"
        Me.TXTNUMERODERECIBO.Size = New System.Drawing.Size(122, 20)
        Me.TXTNUMERODERECIBO.TabIndex = 29
        Me.TXTNUMERODERECIBO.Text = "Nro de RECIBO"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(174, 341)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 30
        Me.TextBox3.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtObservacion)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.MenuStrip4)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.MenuStrip2)
        Me.Panel1.Location = New System.Drawing.Point(632, 236)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 223)
        Me.Panel1.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(200, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(351, 29)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Ya fue Gestionado en Otra Institucion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuStrip2.Location = New System.Drawing.Point(86, 416)
        Me.MenuStrip2.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(107, 29)
        Me.MenuStrip2.TabIndex = 7
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.RoyalBlue
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(99, 25)
        Me.ToolStripMenuItem2.Text = "GUARDAR"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(52, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(488, 25)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Este Grado Ya Fue Procesado En Otra Institucion"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.Location = New System.Drawing.Point(92, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(408, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Describa la institucion Educativa donde Curso estudios"
        '
        'MenuStrip4
        '
        Me.MenuStrip4.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.MenuStrip4.Location = New System.Drawing.Point(189, 180)
        Me.MenuStrip4.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.Size = New System.Drawing.Size(107, 29)
        Me.MenuStrip4.TabIndex = 26
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.BackColor = System.Drawing.Color.RoyalBlue
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(99, 25)
        Me.ToolStripMenuItem3.Text = "GUARDAR"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(301, 180)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 29)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Volver"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(20, 89)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(553, 73)
        Me.txtObservacion.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.MenuStrip6)
        Me.Panel3.Location = New System.Drawing.Point(632, 465)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(592, 223)
        Me.Panel3.TabIndex = 32
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.Location = New System.Drawing.Point(200, 416)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(351, 29)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Ya fue Gestionado en Otra Institucion"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'MenuStrip6
        '
        Me.MenuStrip6.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip6.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5})
        Me.MenuStrip6.Location = New System.Drawing.Point(86, 416)
        Me.MenuStrip6.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.MenuStrip6.Name = "MenuStrip6"
        Me.MenuStrip6.Size = New System.Drawing.Size(107, 29)
        Me.MenuStrip6.TabIndex = 7
        Me.MenuStrip6.Text = "MenuStrip6"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.RoyalBlue
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(99, 25)
        Me.ToolStripMenuItem5.Text = "GUARDAR"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(140, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(312, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(116, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(361, 25)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Ya fue matriculado(a) en este Grado"
        '
        'Matriculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 588)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.datalistadoalumnos)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Matriculas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriculas"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.datalistadoalumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuStrip6.ResumeLayout(False)
        Me.MenuStrip6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents datalistadoalumnos As DataGridView
    Friend WithEvents Eli As DataGridViewImageColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents GUARDARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtimporte As TextBox
    Friend WithEvents txtcosto_MATRICULA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TXTNUMERODERECIBO As Label
    Friend WithEvents TXTCOMPROBANTE As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuStrip4 As MenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents MenuStrip6 As MenuStrip
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
End Class
