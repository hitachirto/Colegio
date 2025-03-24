<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAGAR_PENSIONES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PAGAR_PENSIONES))
        Me.COMP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip5 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXTIMPORTE = New System.Windows.Forms.TextBox()
        Me.TXTFECHA = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.GUARDARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTCOMPROBANTE = New System.Windows.Forms.ComboBox()
        Me.datalistadoNumero_de_recibo = New System.Windows.Forms.DataGridView()
        Me.Eli = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TXTNUMERODERECIBO = New System.Windows.Forms.Label()
        Me.LBLALUMNO = New System.Windows.Forms.Label()
        Me.LBLDESCRIPCION = New System.Windows.Forms.Label()
        Me.LBLTOTAL = New System.Windows.Forms.Label()
        Me.LBLSALDO = New System.Windows.Forms.Label()
        Me.MenuStrip5.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        CType(Me.datalistadoNumero_de_recibo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'COMP
        '
        Me.COMP.AutoSize = True
        Me.COMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.COMP.ForeColor = System.Drawing.Color.Black
        Me.COMP.Location = New System.Drawing.Point(246, 71)
        Me.COMP.Name = "COMP"
        Me.COMP.Size = New System.Drawing.Size(74, 20)
        Me.COMP.TabIndex = 28
        Me.COMP.Text = "Alumno:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(214, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(254, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "TOTAL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(267, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Saldo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label4.Location = New System.Drawing.Point(254, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Importe:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(212, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Comprobante:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(212, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Nº de Recibo:"
        '
        'MenuStrip5
        '
        Me.MenuStrip5.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.MenuStrip5.Location = New System.Drawing.Point(541, 282)
        Me.MenuStrip5.Name = "MenuStrip5"
        Me.MenuStrip5.ShowItemToolTips = True
        Me.MenuStrip5.Size = New System.Drawing.Size(36, 24)
        Me.MenuStrip5.TabIndex = 35
        Me.MenuStrip5.Text = "MenuStrip5"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(28, 20)
        Me.ToolStripMenuItem4.ToolTipText = "Agregar nuevo"
        '
        'TXTIMPORTE
        '
        Me.TXTIMPORTE.Location = New System.Drawing.Point(362, 250)
        Me.TXTIMPORTE.Name = "TXTIMPORTE"
        Me.TXTIMPORTE.Size = New System.Drawing.Size(170, 20)
        Me.TXTIMPORTE.TabIndex = 0
        Me.TXTIMPORTE.Text = "0"
        '
        'TXTFECHA
        '
        Me.TXTFECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFECHA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TXTFECHA.Location = New System.Drawing.Point(362, 377)
        Me.TXTFECHA.MinDate = New Date(2025, 1, 5, 17, 15, 27, 0)
        Me.TXTFECHA.Name = "TXTFECHA"
        Me.TXTFECHA.Size = New System.Drawing.Size(138, 26)
        Me.TXTFECHA.TabIndex = 2
        Me.TXTFECHA.Value = New Date(2025, 1, 5, 17, 15, 27, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(266, 383)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Fecha:"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GUARDARToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(362, 418)
        Me.MenuStrip3.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(107, 29)
        Me.MenuStrip3.TabIndex = 39
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(358, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "PAGOS"
        '
        'TXTCOMPROBANTE
        '
        Me.TXTCOMPROBANTE.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TXTCOMPROBANTE.FormattingEnabled = True
        Me.TXTCOMPROBANTE.Items.AddRange(New Object() {"FACTURA", "NOTA"})
        Me.TXTCOMPROBANTE.Location = New System.Drawing.Point(362, 287)
        Me.TXTCOMPROBANTE.Name = "TXTCOMPROBANTE"
        Me.TXTCOMPROBANTE.Size = New System.Drawing.Size(170, 21)
        Me.TXTCOMPROBANTE.TabIndex = 1
        '
        'datalistadoNumero_de_recibo
        '
        Me.datalistadoNumero_de_recibo.AllowUserToAddRows = False
        Me.datalistadoNumero_de_recibo.AllowUserToDeleteRows = False
        Me.datalistadoNumero_de_recibo.AllowUserToResizeRows = False
        Me.datalistadoNumero_de_recibo.BackgroundColor = System.Drawing.Color.LightGray
        Me.datalistadoNumero_de_recibo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistadoNumero_de_recibo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datalistadoNumero_de_recibo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datalistadoNumero_de_recibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadoNumero_de_recibo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eli})
        Me.datalistadoNumero_de_recibo.EnableHeadersVisualStyles = False
        Me.datalistadoNumero_de_recibo.Location = New System.Drawing.Point(67, 435)
        Me.datalistadoNumero_de_recibo.Name = "datalistadoNumero_de_recibo"
        Me.datalistadoNumero_de_recibo.ReadOnly = True
        Me.datalistadoNumero_de_recibo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datalistadoNumero_de_recibo.RowHeadersVisible = False
        Me.datalistadoNumero_de_recibo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.datalistadoNumero_de_recibo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistadoNumero_de_recibo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadoNumero_de_recibo.Size = New System.Drawing.Size(244, 118)
        Me.datalistadoNumero_de_recibo.TabIndex = 41
        '
        'Eli
        '
        Me.Eli.HeaderText = ""
        Me.Eli.Image = CType(resources.GetObject("Eli.Image"), System.Drawing.Image)
        Me.Eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eli.Name = "Eli"
        Me.Eli.ReadOnly = True
        '
        'TXTNUMERODERECIBO
        '
        Me.TXTNUMERODERECIBO.AutoSize = True
        Me.TXTNUMERODERECIBO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TXTNUMERODERECIBO.ForeColor = System.Drawing.Color.Blue
        Me.TXTNUMERODERECIBO.Location = New System.Drawing.Point(358, 338)
        Me.TXTNUMERODERECIBO.Name = "TXTNUMERODERECIBO"
        Me.TXTNUMERODERECIBO.Size = New System.Drawing.Size(51, 20)
        Me.TXTNUMERODERECIBO.TabIndex = 42
        Me.TXTNUMERODERECIBO.Text = "Serie"
        '
        'LBLALUMNO
        '
        Me.LBLALUMNO.AutoSize = True
        Me.LBLALUMNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LBLALUMNO.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.LBLALUMNO.Location = New System.Drawing.Point(358, 71)
        Me.LBLALUMNO.Name = "LBLALUMNO"
        Me.LBLALUMNO.Size = New System.Drawing.Size(83, 20)
        Me.LBLALUMNO.TabIndex = 43
        Me.LBLALUMNO.Text = "ALUMNO"
        '
        'LBLDESCRIPCION
        '
        Me.LBLDESCRIPCION.AutoSize = True
        Me.LBLDESCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LBLDESCRIPCION.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.LBLDESCRIPCION.Location = New System.Drawing.Point(358, 114)
        Me.LBLDESCRIPCION.Name = "LBLDESCRIPCION"
        Me.LBLDESCRIPCION.Size = New System.Drawing.Size(131, 20)
        Me.LBLDESCRIPCION.TabIndex = 44
        Me.LBLDESCRIPCION.Text = "DESCRIPCION"
        '
        'LBLTOTAL
        '
        Me.LBLTOTAL.AutoSize = True
        Me.LBLTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LBLTOTAL.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.LBLTOTAL.Location = New System.Drawing.Point(358, 163)
        Me.LBLTOTAL.Name = "LBLTOTAL"
        Me.LBLTOTAL.Size = New System.Drawing.Size(64, 20)
        Me.LBLTOTAL.TabIndex = 45
        Me.LBLTOTAL.Text = "TOTAL"
        '
        'LBLSALDO
        '
        Me.LBLSALDO.AutoSize = True
        Me.LBLSALDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LBLSALDO.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.LBLSALDO.Location = New System.Drawing.Point(358, 212)
        Me.LBLSALDO.Name = "LBLSALDO"
        Me.LBLSALDO.Size = New System.Drawing.Size(69, 20)
        Me.LBLSALDO.TabIndex = 46
        Me.LBLSALDO.Text = "SALDO"
        '
        'PAGAR_PENSIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 601)
        Me.Controls.Add(Me.LBLSALDO)
        Me.Controls.Add(Me.LBLTOTAL)
        Me.Controls.Add(Me.LBLDESCRIPCION)
        Me.Controls.Add(Me.LBLALUMNO)
        Me.Controls.Add(Me.TXTNUMERODERECIBO)
        Me.Controls.Add(Me.datalistadoNumero_de_recibo)
        Me.Controls.Add(Me.TXTCOMPROBANTE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Controls.Add(Me.TXTFECHA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTIMPORTE)
        Me.Controls.Add(Me.MenuStrip5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.COMP)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PAGAR_PENSIONES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip5.ResumeLayout(False)
        Me.MenuStrip5.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        CType(Me.datalistadoNumero_de_recibo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents COMP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip5 As MenuStrip
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents TXTIMPORTE As TextBox
    Friend WithEvents TXTFECHA As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents GUARDARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTCOMPROBANTE As ComboBox
    Friend WithEvents datalistadoNumero_de_recibo As DataGridView
    Friend WithEvents Eli As DataGridViewImageColumn
    Friend WithEvents TXTNUMERODERECIBO As Label
    Friend WithEvents LBLALUMNO As Label
    Friend WithEvents LBLDESCRIPCION As Label
    Friend WithEvents LBLTOTAL As Label
    Friend WithEvents LBLSALDO As Label
End Class
