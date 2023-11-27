Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    ' Clase para representar un producto
    Public Class Producto
        Public Property Nombre As String
        Public Property Precio As Double
        Public Property AplicaImpuesto As Boolean
    End Class

    ' Clase para representar una compra
    Public Class Compra
        Public Property Fecha As String
        Public Property NombreCliente As String
        Public Property TipoCliente As String
        Public Property Detalles As List(Of DetalleCompra)
        Public Property Subtotal As Double
        Public Property Impuesto As Double
        Public Property TotalCompra As Double
        Public Property Descuento As Double
        Public Property Total As Double
    End Class

    ' Clase para representar un detalle de compra (producto y cantidad)
    Public Class DetalleCompra
        Public Property Producto As Producto
        Public Property Cantidad As Integer
    End Class



    ' Lista de productos disponibles
    Private productos As New List(Of Producto) From {
        New Producto With {.Nombre = "TS Leica TS 01", .Precio = 5000.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "TS Hi-Target S420R", .Precio = 2600.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "TS Robotica Leica TS13", .Precio = 26500.16, .AplicaImpuesto = True},
        New Producto With {.Nombre = "TS Leica Flexline TS10", .Precio = 9500.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Antena GNSS Leica GS18", .Precio = 4500.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Antena Leica Zeno FLX100", .Precio = 7000.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Controladora Leica CS35", .Precio = 700.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Nivel Topcom AT-B3", .Precio = 420.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Nivel TRIMBLE Spectra AL24A", .Precio = 420.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Nivel FOIF AL 132", .Precio = 400.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Nivel LEICA NA730 ", .Precio = 1200.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Nivel  SOKKIA B40", .Precio = 420.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "N Digital SOUTH DL­201", .Precio = 1700.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Teodolito SOKKIA DT940", .Precio = 2600.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Teodolito PENTAX ETH­502", .Precio = 1300.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Mira Telescópica Ancha de aluminio de 5m.", .Precio = 80.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Mira con Código de Barras LEICA GSS111", .Precio = 150.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Ojo de Pollo para mira aluminio", .Precio = 5.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Trípode madera TOPCON DW­1", .Precio = 150.0, .AplicaImpuesto = True},
        New Producto With {.Nombre = "Trípode Aluminio LEICA GST05L", .Precio = 250.0, .AplicaImpuesto = True}
    }

    ' Lista para almacenar las compras
    Private compras As List(Of Compra) = New List(Of Compra)
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim fecha As String
        fecha = MonthCalendar1.SelectionStart.Date
        txtFecha.Text = fecha
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar DataGridView de compras
        dgvCompras.ColumnCount = 5
        dgvCompras.Columns(0).Name = "Fecha"
        dgvCompras.Columns(1).Name = "Nombre del Cliente"
        dgvCompras.Columns(2).Name = "Tipo de Cliente"
        dgvCompras.Columns(3).Name = "Total de Compra"
        dgvCompras.Columns(4).Name = "Descuento"


        ' Configurar CheckBoxes y NumericUpDowns de productos
        For i As Integer = 0 To productos.Count - 1
            Dim checkBox As New CheckBox()
            checkBox.Text = productos(i).Nombre & " - $" & productos(i).Precio.ToString("F2")
            checkBox.Location = New Point(10, 30 + i * 45)
            checkBox.Size = New Size(400, checkBox.Size.Height)
            Controls.Add(checkBox)

            Dim numericUpDown As New NumericUpDown()
            numericUpDown.Minimum = 0
            numericUpDown.Maximum = 100 ' Puedes ajustar según sea necesario
            numericUpDown.Location = New Point(410, 30 + i * 45)
            Controls.Add(numericUpDown)
        Next

        ' Configurar ComboBox de tipos de cliente
        cmbTipoCliente.Items.AddRange({"Regular", "Especial", "Jubilado"})


    End Sub
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        If Not String.IsNullOrEmpty(txtNombre.Text) AndAlso Not String.IsNullOrEmpty(txtFecha.Text) Then
            If cmbTipoCliente.SelectedItem IsNot Nothing Then
                ' Obtener detalles de productos seleccionados y sus cantidades
                Dim detallesCompra As List(Of DetalleCompra) = New List(Of DetalleCompra)()

                For i As Integer = 0 To productos.Count - 1
                    Dim checkBox As CheckBox = Controls.OfType(Of CheckBox)().FirstOrDefault(Function(cb) cb.Text.StartsWith(productos(i).Nombre))
                    Dim numericUpDown As NumericUpDown = Controls.OfType(Of NumericUpDown)().FirstOrDefault(Function(nud) nud.Location.Y = checkBox.Location.Y)

                    If checkBox IsNot Nothing AndAlso checkBox.Checked AndAlso numericUpDown IsNot Nothing Then
                        Dim cantidad As Integer = CInt(numericUpDown.Value)
                        If cantidad > 0 Then
                            detallesCompra.Add(New DetalleCompra With {.Producto = productos(i), .Cantidad = cantidad})
                        End If
                    End If
                Next
                ' Obtener nombre del cliente
                Dim nombreCliente = txtNombre.Text

                ' Obtener tipo de cliente
                Dim tipoCliente As String = cmbTipoCliente.SelectedItem.ToString()

                ' Calcular subtotal, impuesto y total
                Dim subtotal As Double = detallesCompra.Sum(Function(detalle) detalle.Producto.Precio * detalle.Cantidad)
                Dim descuento As Double = CalcularDescuento(tipoCliente, subtotal)
                Dim impuesto As Double = detallesCompra.Where(Function(detalle) detalle.Producto.AplicaImpuesto).Sum(Function(detalle) detalle.Producto.Precio * detalle.Cantidad * 0.07)
                Dim totalCompra As Double = subtotal + impuesto
                Dim total As Double = totalCompra - descuento

                ' Crear una instancia de la clase Compra
                Dim nuevaCompra As New Compra With {
                    .Fecha = MonthCalendar1.SelectionStart.Date,
                    .NombreCliente = nombreCliente, ' Puedes obtener esto de un TextBox u otro control de entrada
                    .TipoCliente = tipoCliente,
                    .Detalles = detallesCompra,
                    .Subtotal = subtotal,
                    .Impuesto = impuesto,
                    .Descuento = descuento,
                    .TotalCompra = totalCompra,
                    .Total = total
                }

                ' Agregar la compra a la lista y al DataGridView
                compras.Add(nuevaCompra)
                ' Formatear la cantidad con formato de moneda
                Dim totalCompraFormateado As String = String.Format("{0:C}", nuevaCompra.TotalCompra)
                Dim descuentoFormateado As String = String.Format("{0:C}", nuevaCompra.Descuento)
                ' Agregar la fila al DataGridView
                Dim unused = dgvCompras.Rows.Add(nuevaCompra.Fecha, nuevaCompra.NombreCliente, nuevaCompra.TipoCliente, totalCompraFormateado, descuentoFormateado)
                ' Limpiar los CheckBoxes y ComboBox después de agregar la compra
                LimpiarControles()
            Else
                MessageBox.Show("Por favor, seleccione que tipo de cliente es.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Por favor, revise los campos de nombre o fecha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Function CalcularDescuento(tipoCliente As String, subtotal As Double) As Double
        ' Aplicar descuento según el tipo de cliente
        Select Case tipoCliente
            Case "Especial"
                Return subtotal * 0.2
            Case "Jubilado"
                Return subtotal * 0.15
            Case Else
                Return 0
        End Select
    End Function

    Private Sub LimpiarControles()
        ' Limpiar los CheckBoxes, NumericUpDowns, ComboBox y TextBox después de agregar la compra
        For Each checkBox As CheckBox In Controls.OfType(Of CheckBox)()
            checkBox.Checked = False
        Next

        For Each numericUpDown As NumericUpDown In Controls.OfType(Of NumericUpDown)()
            numericUpDown.Value = 0
        Next

        cmbTipoCliente.SelectedIndex = -1
        txtFecha.Clear()
        txtNombre.Clear()

    End Sub

    Private Sub btnRecibo_Click(sender As Object, e As EventArgs) Handles btnRecibo.Click
        pnlRecibo.Visible = True
        ' Verificar si hay compras para mostrar el recibo
        If dgvCompras.Rows.Count > 0 Then
            ' Obtener la última compra agregada al DataGridView
            Dim ultimaCompra As Compra = compras.Last()
            Dim fecha, nombre, tipoCliente, nombreProducto, cantidadProducto, costoProducto,
                subTotal, impuesto, total, descuento, totalCompra As String

            ' Crear una cadena de texto con la información del recibo
            Dim recibo As String
            'recibo += $"Fecha: {ultimaCompra.Fecha}{Environment.NewLine}{Environment.NewLine}"
            nombre = $" {ultimaCompra.NombreCliente}"
            fecha = $" {ultimaCompra.Fecha}"
            tipoCliente = $" {ultimaCompra.TipoCliente}"
            descuento = $" ${ultimaCompra.Descuento:0.00}"
            totalCompra = $" ${ultimaCompra.TotalCompra:0.00}"

            For Each detalle As DetalleCompra In ultimaCompra.Detalles
                'recibo += $"{detalle.Producto.Nombre} -                        {detalle.Cantidad} -                                ${detalle.Producto.Precio * detalle.Cantidad:0.00}{Environment.NewLine}"
                nombreProducto += $"{detalle.Producto.Nombre}{Environment.NewLine}{Environment.NewLine}"
                cantidadProducto += $"{detalle.Cantidad}{Environment.NewLine}{Environment.NewLine}"
                costoProducto += $"{(detalle.Producto.Precio * detalle.Cantidad):0.00}{Environment.NewLine}{Environment.NewLine}"
            Next

            ' Mostrar subtotal, impuesto y total
            subTotal += $"${ultimaCompra.Subtotal:0.00}"
            impuesto += $"${ultimaCompra.Impuesto:0.00}"
            total += $"${ultimaCompra.Total:0.00}"

            ' Asignar la cadena de texto al label
            lblNombre.Text = nombre
            lblFecha.Text = fecha
            lblTipo.Text = tipoCliente
            lblProducto.Text = nombreProducto
            lblCantidad.Text = cantidadProducto
            lblPST.Text = costoProducto
            lblSubtotal.Text = subTotal
            lblImpuesto.Text = impuesto
            lblTotal1.Text = totalCompra
            lblTotal2.Text = total
            lblDescuento.Text = descuento
        Else
            MessageBox.Show("No hay compras para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LimpiarControles()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblNombre.Text = ""
        lblFecha.Text = ""
        lblTipo.Text = ""
        lblProducto.Text = ""
        lblCantidad.Text = ""
        lblPST.Text = ""
        lblSubtotal.Text = ""
        lblImpuesto.Text = ""
        lblTotal1.Text = ""
        lblTotal2.Text = ""
        lblDescuento.Text = ""
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            ' Si no es una letra, espacio ni una tecla de control, bloquear la entrada
            e.Handled = True
        End If

    End Sub
End Class
