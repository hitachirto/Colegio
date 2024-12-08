<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENUPRINCIPALMATRICULAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENUPRINCIPALMATRICULAS))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblBUSQUEDA = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip5 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.logo_institucionfalse = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.MenuStrip4.SuspendLayout()
        Me.MenuStrip5.SuspendLayout()
        CType(Me.logo_institucionfalse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.MenuStrip2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1134, 63)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.lblBUSQUEDA)
        Me.Panel2.Controls.Add(Me.txtbuscar)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(191, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(546, 51)
        Me.Panel2.TabIndex = 2
        '
        'lblBUSQUEDA
        '
        Me.lblBUSQUEDA.AutoSize = True
        Me.lblBUSQUEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblBUSQUEDA.Location = New System.Drawing.Point(58, 16)
        Me.lblBUSQUEDA.Name = "lblBUSQUEDA"
        Me.lblBUSQUEDA.Size = New System.Drawing.Size(109, 18)
        Me.lblBUSQUEDA.TabIndex = 6
        Me.lblBUSQUEDA.Text = "Buscar Alumno"
        '
        'txtbuscar
        '
        Me.txtbuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtbuscar.Location = New System.Drawing.Point(52, 14)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(310, 22)
        Me.txtbuscar.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 11)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(38, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(32, 24)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(108, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "escuela"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.White
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.MenuStrip2.Location = New System.Drawing.Point(740, 20)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(105, 28)
        Me.MenuStrip2.TabIndex = 7
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(99, 24)
        Me.ToolStripMenuItem3.Text = "Alumnos"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.White
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip3.Location = New System.Drawing.Point(73, 18)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip3.Size = New System.Drawing.Size(38, 28)
        Me.MenuStrip3.TabIndex = 8
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(32, 24)
        '
        'MenuStrip4
        '
        Me.MenuStrip4.BackColor = System.Drawing.Color.White
        Me.MenuStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.MenuStrip4.Location = New System.Drawing.Point(125, 18)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip4.Size = New System.Drawing.Size(38, 28)
        Me.MenuStrip4.TabIndex = 9
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(32, 24)
        '
        'MenuStrip5
        '
        Me.MenuStrip5.BackColor = System.Drawing.Color.White
        Me.MenuStrip5.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip5.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5})
        Me.MenuStrip5.Location = New System.Drawing.Point(178, 18)
        Me.MenuStrip5.Name = "MenuStrip5"
        Me.MenuStrip5.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip5.Size = New System.Drawing.Size(38, 28)
        Me.MenuStrip5.TabIndex = 10
        Me.MenuStrip5.Text = "MenuStrip5"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(32, 24)
        '
        'logo_institucionfalse
        '
        Me.logo_institucionfalse.Location = New System.Drawing.Point(229, 7)
        Me.logo_institucionfalse.Name = "logo_institucionfalse"
        Me.logo_institucionfalse.Size = New System.Drawing.Size(50, 50)
        Me.logo_institucionfalse.TabIndex = 11
        Me.logo_institucionfalse.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.logo_institucionfalse)
        Me.Panel3.Controls.Add(Me.MenuStrip3)
        Me.Panel3.Controls.Add(Me.MenuStrip5)
        Me.Panel3.Controls.Add(Me.MenuStrip4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(848, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(286, 63)
        Me.Panel3.TabIndex = 12
        '
        'MENUPRINCIPALMATRICULAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MENUPRINCIPALMATRICULAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        Me.MenuStrip5.ResumeLayout(False)
        Me.MenuStrip5.PerformLayout()
        CType(Me.logo_institucionfalse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents lblBUSQUEDA As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents MenuStrip4 As MenuStrip
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents MenuStrip5 As MenuStrip
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents logo_institucionfalse As PictureBox
    Friend WithEvents Panel3 As Panel
End Class
