<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        dgvCompras = New DataGridView()
        cmbTipoCliente = New ComboBox()
        MonthCalendar1 = New MonthCalendar()
        txtFecha = New TextBox()
        btnCalcular = New Button()
        btnRecibo = New Button()
        txtNombre = New TextBox()
        pnlRecibo = New Panel()
        PictureBox1 = New PictureBox()
        lblTotal2 = New Label()
        lblDescuento = New Label()
        lblTotal1 = New Label()
        lblImpuesto = New Label()
        lblSubtotal = New Label()
        lblPST = New Label()
        lblCantidad = New Label()
        lblProducto = New Label()
        lblTipo = New Label()
        lblNombre = New Label()
        lblFecha = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        btnSalir = New Button()
        Button2 = New Button()
        Button3 = New Button()
        CType(dgvCompras, ComponentModel.ISupportInitialize).BeginInit()
        pnlRecibo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvCompras
        ' 
        dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCompras.Location = New Point(547, 491)
        dgvCompras.Name = "dgvCompras"
        dgvCompras.RowHeadersWidth = 51
        dgvCompras.RowTemplate.Height = 29
        dgvCompras.Size = New Size(641, 219)
        dgvCompras.TabIndex = 0
        ' 
        ' cmbTipoCliente
        ' 
        cmbTipoCliente.FormattingEnabled = True
        cmbTipoCliente.Location = New Point(581, 177)
        cmbTipoCliente.Name = "cmbTipoCliente"
        cmbTipoCliente.Size = New Size(198, 28)
        cmbTipoCliente.TabIndex = 1
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(840, 89)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 2
        ' 
        ' txtFecha
        ' 
        txtFecha.Location = New Point(840, 320)
        txtFecha.Name = "txtFecha"
        txtFecha.ReadOnly = True
        txtFecha.Size = New Size(269, 27)
        txtFecha.TabIndex = 3
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(599, 252)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(162, 73)
        btnCalcular.TabIndex = 4
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' btnRecibo
        ' 
        btnRecibo.Location = New Point(599, 357)
        btnRecibo.Name = "btnRecibo"
        btnRecibo.Size = New Size(162, 73)
        btnRecibo.TabIndex = 5
        btnRecibo.Text = "Ver recibo"
        btnRecibo.UseVisualStyleBackColor = True
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(581, 95)
        txtNombre.Name = "txtNombre"
        txtNombre.PlaceholderText = "Nombre de cliente"
        txtNombre.Size = New Size(198, 27)
        txtNombre.TabIndex = 6
        ' 
        ' pnlRecibo
        ' 
        pnlRecibo.BackColor = SystemColors.ControlLightLight
        pnlRecibo.Controls.Add(PictureBox1)
        pnlRecibo.Controls.Add(lblTotal2)
        pnlRecibo.Controls.Add(lblDescuento)
        pnlRecibo.Controls.Add(lblTotal1)
        pnlRecibo.Controls.Add(lblImpuesto)
        pnlRecibo.Controls.Add(lblSubtotal)
        pnlRecibo.Controls.Add(lblPST)
        pnlRecibo.Controls.Add(lblCantidad)
        pnlRecibo.Controls.Add(lblProducto)
        pnlRecibo.Controls.Add(lblTipo)
        pnlRecibo.Controls.Add(lblNombre)
        pnlRecibo.Controls.Add(lblFecha)
        pnlRecibo.Controls.Add(Label14)
        pnlRecibo.Controls.Add(Label13)
        pnlRecibo.Controls.Add(Label12)
        pnlRecibo.Controls.Add(Label11)
        pnlRecibo.Controls.Add(Label10)
        pnlRecibo.Controls.Add(Label9)
        pnlRecibo.Controls.Add(Label8)
        pnlRecibo.Controls.Add(Label7)
        pnlRecibo.Controls.Add(Label6)
        pnlRecibo.Controls.Add(Label5)
        pnlRecibo.Controls.Add(Label4)
        pnlRecibo.Controls.Add(Label3)
        pnlRecibo.Controls.Add(Label2)
        pnlRecibo.Controls.Add(Label1)
        pnlRecibo.Location = New Point(1207, 49)
        pnlRecibo.Name = "pnlRecibo"
        pnlRecibo.Size = New Size(684, 971)
        pnlRecibo.TabIndex = 7
        pnlRecibo.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icono_parcial3
        PictureBox1.Location = New Point(504, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(107, 113)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' lblTotal2
        ' 
        lblTotal2.AutoSize = True
        lblTotal2.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal2.Location = New Point(495, 918)
        lblTotal2.Name = "lblTotal2"
        lblTotal2.Size = New Size(70, 24)
        lblTotal2.TabIndex = 25
        lblTotal2.Text = "Label25"
        ' 
        ' lblDescuento
        ' 
        lblDescuento.AutoSize = True
        lblDescuento.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblDescuento.Location = New Point(495, 880)
        lblDescuento.Name = "lblDescuento"
        lblDescuento.Size = New Size(64, 22)
        lblDescuento.TabIndex = 24
        lblDescuento.Text = "Label24"
        ' 
        ' lblTotal1
        ' 
        lblTotal1.AutoSize = True
        lblTotal1.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal1.Location = New Point(495, 844)
        lblTotal1.Name = "lblTotal1"
        lblTotal1.Size = New Size(64, 22)
        lblTotal1.TabIndex = 23
        lblTotal1.Text = "Label23"
        ' 
        ' lblImpuesto
        ' 
        lblImpuesto.AutoSize = True
        lblImpuesto.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblImpuesto.Location = New Point(495, 813)
        lblImpuesto.Name = "lblImpuesto"
        lblImpuesto.Size = New Size(64, 22)
        lblImpuesto.TabIndex = 22
        lblImpuesto.Text = "Label22"
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblSubtotal.Location = New Point(495, 777)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(64, 22)
        lblSubtotal.TabIndex = 21
        lblSubtotal.Text = "Label21"
        ' 
        ' lblPST
        ' 
        lblPST.AutoSize = True
        lblPST.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblPST.Location = New Point(495, 350)
        lblPST.Name = "lblPST"
        lblPST.Size = New Size(64, 22)
        lblPST.TabIndex = 20
        lblPST.Text = "Label20"
        ' 
        ' lblCantidad
        ' 
        lblCantidad.AutoSize = True
        lblCantidad.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblCantidad.Location = New Point(313, 350)
        lblCantidad.Name = "lblCantidad"
        lblCantidad.Size = New Size(64, 22)
        lblCantidad.TabIndex = 19
        lblCantidad.Text = "Label19"
        ' 
        ' lblProducto
        ' 
        lblProducto.AutoSize = True
        lblProducto.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblProducto.Location = New Point(35, 350)
        lblProducto.Name = "lblProducto"
        lblProducto.Size = New Size(64, 22)
        lblProducto.TabIndex = 18
        lblProducto.Text = "Label18"
        ' 
        ' lblTipo
        ' 
        lblTipo.AutoSize = True
        lblTipo.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblTipo.Location = New Point(526, 227)
        lblTipo.Name = "lblTipo"
        lblTipo.Size = New Size(64, 22)
        lblTipo.TabIndex = 17
        lblTipo.Text = "Label17"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Arial Narrow", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblNombre.Location = New Point(123, 225)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(71, 24)
        lblNombre.TabIndex = 16
        lblNombre.Text = "Label16"
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Font = New Font("Arial Narrow", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblFecha.Location = New Point(116, 173)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(71, 24)
        lblFecha.TabIndex = 15
        lblFecha.Text = "Label15"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(418, 920)
        Label14.Name = "Label14"
        Label14.Size = New Size(64, 24)
        Label14.TabIndex = 14
        Label14.Text = "Total:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(383, 881)
        Label13.Name = "Label13"
        Label13.Size = New Size(99, 19)
        Label13.TabIndex = 13
        Label13.Text = "Descuento:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(365, 845)
        Label12.Name = "Label12"
        Label12.Size = New Size(117, 19)
        Label12.TabIndex = 12
        Label12.Text = "Total a pagar:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(395, 814)
        Label11.Name = "Label11"
        Label11.Size = New Size(87, 19)
        Label11.TabIndex = 11
        Label11.Text = "Impuesto:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(401, 778)
        Label10.Name = "Label10"
        Label10.Size = New Size(81, 19)
        Label10.TabIndex = 10
        Label10.Text = "Subtotal:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(481, 308)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 19)
        Label9.TabIndex = 9
        Label9.Text = "Subtotal"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(287, 308)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 19)
        Label8.TabIndex = 8
        Label8.Text = "Cantidad"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(48, 308)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 19)
        Label7.TabIndex = 7
        Label7.Text = "Productos"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(391, 230)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 19)
        Label6.TabIndex = 6
        Label6.Text = "Tipo de cliente:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(48, 230)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 19)
        Label5.TabIndex = 5
        Label5.Text = "Cliente:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(48, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 19)
        Label4.TabIndex = 4
        Label4.Text = "Fecha:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(254, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 19)
        Label3.TabIndex = 3
        Label3.Text = "Tel: +50764831773"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(272, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 19)
        Label2.TabIndex = 2
        Label2.Text = "Ruc: 151997"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(212, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(254, 28)
        Label1.TabIndex = 1
        Label1.Text = "La Casa del Topógrafo"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(581, 66)
        Label15.Name = "Label15"
        Label15.Size = New Size(161, 19)
        Label15.TabIndex = 8
        Label15.Text = "Nombre del cliente:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(581, 144)
        Label16.Name = "Label16"
        Label16.Size = New Size(129, 19)
        Label16.TabIndex = 9
        Label16.Text = "Tipo de cliente:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(840, 60)
        Label17.Name = "Label17"
        Label17.Size = New Size(150, 19)
        Label17.TabIndex = 10
        Label17.Text = "Fecha de compra:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label18.Location = New Point(1494, 9)
        Label18.Name = "Label18"
        Label18.Size = New Size(164, 24)
        Label18.TabIndex = 11
        Label18.Text = "Johnny Gordillo"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label19.Location = New Point(1675, 9)
        Label19.Name = "Label19"
        Label19.Size = New Size(112, 24)
        Label19.TabIndex = 12
        Label19.Text = "8-915-1265"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label20.Location = New Point(1812, 9)
        Label20.Name = "Label20"
        Label20.Size = New Size(79, 24)
        Label20.TabIndex = 13
        Label20.Text = "9LS231"
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(616, 819)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(145, 75)
        btnSalir.TabIndex = 14
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(802, 819)
        Button2.Name = "Button2"
        Button2.Size = New Size(145, 75)
        Button2.TabIndex = 15
        Button2.Text = "Limpiar form."
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(983, 819)
        Button3.Name = "Button3"
        Button3.Size = New Size(145, 75)
        Button3.TabIndex = 16
        Button3.Text = "Limpiar fact."
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1055)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(btnSalir)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(pnlRecibo)
        Controls.Add(txtNombre)
        Controls.Add(btnRecibo)
        Controls.Add(btnCalcular)
        Controls.Add(txtFecha)
        Controls.Add(MonthCalendar1)
        Controls.Add(cmbTipoCliente)
        Controls.Add(dgvCompras)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Parcial #3"
        CType(dgvCompras, ComponentModel.ISupportInitialize).EndInit()
        pnlRecibo.ResumeLayout(False)
        pnlRecibo.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvCompras As DataGridView
    Friend WithEvents cmbTipoCliente As ComboBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnRecibo As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents pnlRecibo As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblTotal2 As Label
    Friend WithEvents lblDescuento As Label
    Friend WithEvents lblTotal1 As Label
    Friend WithEvents lblImpuesto As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblPST As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
