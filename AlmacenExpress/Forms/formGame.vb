Imports MaterialSkin
Imports Classes
Imports Entidaddes
Imports MetroFramework

Public Class formGame
    'Variables antiguas
    Const caracteresInvalidos As String = ",.*/?¿=)(&%$!:;_-+¬|@#~<>1234567890"
    Private coordenadas As Point
    Private coordenadasActuales As Point
    Private pos As Integer = 10
    Private distancia As Integer = 10
    Private altura As Integer = 5
    Private cantidadPedidos As Integer = 0
    Private articulos As New List(Of String)
    Private CantidadProductos As New List(Of Integer)
    Private products As New List(Of Producto)
    Private productos() As String = {"boli", "calculadora", "taladradora", "goma", "pegamento", "subrayador", "papel", "lapiz", "tijera", "grapadora"}
    Private cantidad As New List(Of Producto)
    Private nombreImagenes() As String = {"Ball Point Pen-96.png", "Calculator-96.png", "Drill-96.png", "Eraser-96.png", "Glue-96.png", "Marker Pen-96.png", "Paper-96.png", "Pencil-96.png", "Scissors-96.png", "Stapler-96.png"}
    Private nombreImagenesBN() As String = {"Ball Point Pen-96b.png", "Calculator-96b.png", "Drill-96b.png", "Eraser-96b.png", "Glue-96b.png", "Marker Pen-96b.png", "Paper-96b.png", "Pencil-96b.png", "Scissors-96b.png", "Stapler-96b.png"}
    Private PuntosJugador As Integer = 0
    Private ReproducirMusica As Boolean = False

    'Aqui las nuevas variables
    Private tratamiento As New Tratamiento
    Private usuarios As New List(Of Usuario)
    Private pedidos As New List(Of Pedido)
    Private UsuarioCorrecto As Boolean = False
    Private pedidoEliminar As String = ""
    Private NumeroPedidoEliminar As Integer = 0
    Private YaSalio As Boolean = False
    Private puntuacionUsuario As New Puntuacion
    Private pedidosYaSalidos As New List(Of Pedido)
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load

        PictureBoxFlechaRoja.Visible = False
        CrearPictureBox()
        DevolverPedido()
        cantidad = tratamiento.productos
        For i = 0 To cantidad.Count - 1
            CantidadProductos.Add(cantidad(i).Cantidada)
        Next
        crearCantidadProductos()


    End Sub

    Public Sub ReponerProductosCantidad()
        For i = 0 To CantidadProductos.Count - 1
            CantidadProductos(i) = 50
        Next
    End Sub

    Private Sub formGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        skinManager.ColorScheme = New ColorScheme(Primary.Blue600, Primary.Blue600, Primary.Blue600, Accent.LightBlue200, TextShade.WHITE)
        tabControl.Height = Screen.PrimaryScreen.Bounds.Height - (pnlBar.Height + tabSelector.Height)
        ActualizarUsuarios()
        ActualizarPedidos()
    End Sub

    Public Sub ActualizarUsuarios()
        lstUsuarios.Items.Clear()
        usuarios = tratamiento.Usuarios
        If Not IsNothing(usuarios) Then
            For i = 0 To usuarios.Count - 1
                lstUsuarios.Items.Add(usuarios(i).Nombre)
            Next
        Else
            MetroMessageBox.Show(Me, "No hay usuarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Public Sub ActualizarPedidos()
        lstPedidos.Items.Clear()
        pedidos = tratamiento.Pedidos
        If Not IsNothing(pedidos) Then

            lstPedidos.DisplayMember = "pedido"
            For Each pedido As Pedido In pedidos
                lstPedidos.Items.Add(pedido)
            Next

        Else
            MetroMessageBox.Show(Me, "No hay pedidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn_Registro.Click
        If btnLogIn_Registro.Text = "Iniciar sesión" Then
            usuarios = tratamiento.Usuarios
            If Not IsNothing(usuarios) Then
                For Each usu As Usuario In usuarios
                    If usu.Nombre.ToLower = txtUser.Text.ToLower AndAlso usu.Cantraseña = txtContraseña.Text Then
                        UsuarioCorrecto = True
                        Exit For
                    Else
                        UsuarioCorrecto = False
                    End If
                Next

                If UsuarioCorrecto = True Then
                    MetroMessageBox.Show(Me, "Bienvenido " & txtUser.Text, "Hola", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    PanelOcultarJuegoInicio.Visible = False
                    For Each control As Control In pnlUserUI.Controls
                        control.Visible = False
                    Next
                    PictureBoxUsuario.Visible = True
                    lblNombreUsuarioPanel.Visible = True
                    lblNombreUsuarioPanel.Text = txtUser.Text
                    'Ocultamos el tab del admin --> Revisar despues
                    If txtUser.Text.ToLower <> "admin" Then
                        tabControl.TabPages.Remove(TabAdminTools)
                    End If


                    'Sacamos las puntuaciones del usuario
                    puntuacionUsuario = tratamiento.DevolverPuntuaciones(txtUser.Text)
                    Dim PuntosSeparados() As String
                    Dim puntosUsuario As String = ""
                    Dim puntosSplit As String = ""
                    puntosUsuario = puntuacionUsuario.Puntuacion
                    ' TODO Modificado por profes
                    If puntosUsuario <> "" Then
                        puntosSplit = puntosUsuario.Substring(0, puntosUsuario.Length - 1)
                        PuntosSeparados = puntosSplit.Split(";")

                        For i = 0 To PuntosSeparados.Length - 1
                            ChartPuntuaciones.Series(0).Points.Add(PuntosSeparados(i))
                        Next
                        ChartPuntuaciones.Series(0).LegendText = "Puntuaciones"
                    End If

                Else
                    MetroMessageBox.Show(Me, "La contraseña no es correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
        If btnLogIn_Registro.Text = "Registro" Then
            Dim respuesta As String
            If txtContraseña.Text = txtRepetirContraseña.Text Then
                respuesta = tratamiento.InsetarNuevoUsuario(txtUser.Text, txtContraseña.Text)
                MetroMessageBox.Show(Me, respuesta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUser.Text = ""
                txtContraseña.Text = ""
                txtRepetirContraseña.Text = ""
            Else
                MetroMessageBox.Show(Me, "Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtContraseña.Text = ""
                txtRepetirContraseña.Text = ""
            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCrearCuenta.Click
        btnCrearCuenta.Visible = False
        btnLogIn_Registro.Text = "Registro"
        LabelRepetirContra.Visible = True
        txtRepetirContraseña.Visible = True
        btnAtras.Visible = True
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        btnCrearCuenta.Visible = True
        btnAtras.Visible = False
        LabelRepetirContra.Visible = False
        txtRepetirContraseña.Visible = False
        btnLogIn_Registro.Text = "Iniciar sesión"
    End Sub

    Private Sub lstPedidos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPedidos.SelectedIndexChanged
        Dim pedido As Pedido = TryCast(lstPedidos.SelectedItem, Pedido)
        pedidoEliminar = pedido.pedido
        NumeroPedidoEliminar = pedido.id
    End Sub

    Private Sub btnEliminarPedido_Click(sender As Object, e As EventArgs) Handles btnEliminarPedido.Click
        Dim respuesta As String = ""
        Dim respuestaMessage As DialogResult
        If pedidoEliminar <> "" Then
            respuestaMessage = MessageBox.Show("¿Se va a eliminar el pedido " & pedidoEliminar & ", estas segura?", "Atención", MessageBoxButtons.OKCancel)
            If respuestaMessage = DialogResult.OK Then
                respuesta = tratamiento.BorrarPedido(NumeroPedidoEliminar)
            End If
            ActualizarPedidos()
        Else
            MetroMessageBox.Show(Me, "Selecciona primero un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Sub CrearPictureBox()
        Dim posPictureAltura As Integer = 30
        Dim posPictureAnchura As Integer = 30
        Dim contador As Integer = 0
        For i = 0 To 9
            contador += 1

            Dim picture As New PictureBox
            picture.Height = 90
            picture.Width = 90
            picture.Location = New Point(posPictureAnchura, 30 + posPictureAltura)
            picture.ImageLocation = ".\imagenes\" & nombreImagenes(i)
            picture.Name = productos(i)
            picture.Tag = nombreImagenes(i)
            posPictureAltura += 110
            picture.BackColor = Color.Transparent
            picture.Enabled = True

            If contador = 5 Then
                posPictureAltura = 30
                posPictureAnchura += 110
            End If

            tabGame.Controls.Add(picture)

            AddHandler picture.MouseDown, AddressOf imagenPresionada
            AddHandler picture.MouseMove, AddressOf imagenMoviendose
            AddHandler picture.MouseUp, AddressOf imagenSoltada

        Next
    End Sub

    Private Sub imagenPresionada(ByVal sender As Object, e As MouseEventArgs)
        Dim picture As PictureBox = TryCast(sender, PictureBox)
        coordenadas.Y = MousePosition.Y - picture.Top
        coordenadas.X = MousePosition.X - picture.Left
        coordenadasActuales.X = picture.Location.X
        coordenadasActuales.Y = picture.Location.Y
    End Sub

    Private Sub imagenMoviendose(ByVal sender As Object, e As MouseEventArgs)

        Dim picture As PictureBox = TryCast(sender, PictureBox)
        If e.Button = MouseButtons.Left Then

            PictureBoxFlechaRoja.Visible = True

            PanelProductos.SendToBack()
            picture.BringToFront()
            picture.Top = MousePosition.Y - coordenadas.Y
            picture.Left = MousePosition.X - coordenadas.X
            If picture.Location.Y + picture.Height >= PanelProductos.Location.Y And picture.Location.Y <= PanelProductos.Location.Y + PanelProductos.Height And
                picture.Location.X + picture.Width > PanelProductos.Location.X And picture.Location.X < PanelProductos.Location.X + PanelProductos.Width Then
                PanelProductos.BackColor = Color.Gray
            Else
                PanelProductos.BackColor = Color.LightGray
            End If
        End If
    End Sub

    Private Sub imagenSoltada(ByVal sender As Object, e As MouseEventArgs)
        Dim posicionImagen As Integer = 0
        Dim picture As PictureBox = TryCast(sender, PictureBox)

        PictureBoxFlechaRoja.Visible = False

        If picture.Location.Y + picture.Height >= PanelProductos.Location.Y And picture.Location.Y <= PanelProductos.Location.Y + PanelProductos.Height And
               picture.Location.X + picture.Width > PanelProductos.Location.X And picture.Location.X < PanelProductos.Location.X + PanelProductos.Width Then
            'Cambiamos la imagen de color cuando suelta
            picture.Location = coordenadasActuales
            picture.Enabled = False
            For i = 0 To nombreImagenes.Length - 1
                If nombreImagenes(i) = picture.Tag Then
                    picture.ImageLocation = ".\imagenes\" & nombreImagenesBN(i)
                End If
            Next

            'For i = 0 To articulos.Count - 1
            '    If articulos(i).ToLower = picture.Text.ToLower Then
            '        If NumericCantidadProductos.Value <= CantidadProductos(i) Then
            '            CantidadProductos(i) = CantidadProductos(i) - NumericCantidadProductos.Value
            '        Else
            '            MetroMessageBox.Show(Me, "La cantidad de productos que quieres comprar es demasiado alta, solo dispones de " & CantidadProductos(i) & " productos de ese tipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 150)
            '            picture.Location = coordenadasActuales
            '            picture.BackColor = Color.LightGreen
            '            Exit Sub
            '        End If

            '        Exit For
            '    End If
            'Next

            'Dim controlesLabelsEliminar() As Control
            'controlesLabelsEliminar = PanelJuego.Controls.Find("labelsCantidad", True)
            'For Each control As Control In controlesLabelsEliminar
            '    PanelJuego.Controls.Remove(control)
            'Next
            'crearLabelsCantidad()


            Dim p As New Button
            p.BackColor = Color.Gray
            p.Width = 70
            p.Height = 70
            p.Text = lblCantidadProductos.Text
            p.Font = New Font("Microsoft Sans Serif", 12)
            p.TextAlign = ContentAlignment.BottomRight
            p.ForeColor = Color.White
            p.Name = picture.Name
            p.ForeColor = Color.Red
            'p.Image = picture.Image
            'p.AutoSizeMode = PictureBoxSizeMode.StretchImage
            p.BackgroundImage = picture.Image
            p.BackgroundImageLayout = ImageLayout.Stretch
            p.Top = altura
            p.Left = distancia

            If p.Location.X + p.Width > PanelProductos.Width Then
                altura += 70
                p.Top = altura
                p.Left = 10
                distancia = 10
            End If

            PanelProductos.Controls.Add(p)
            PanelProductos.SendToBack()
            'PanelJuego.Controls.Remove(picture)
            distancia += 70
        Else
            picture.Location = coordenadasActuales
        End If
    End Sub

    Public Sub DevolverPedido()
        Dim random As New Random
        Dim posicionY As Integer = 50
        pedidos = tratamiento.Pedidos
        Dim pedidostr As String = ""
        Dim pedido As New Pedido

        PanelPedidos.Controls.Clear()

        Do
            Try
                pedido = pedidos(random.Next(pedidos.Count))
            Catch ex As Exception
                MsgBox("Ocurrio un errorcon los pedidos")
                Exit Sub
            End Try

            If Not pedidosYaSalidos.Contains(pedido) Then
                pedidosYaSalidos.Add(pedido)
                Exit Do
            End If
            If pedidosYaSalidos.Count = pedidos.Count Then
                MsgBox("Ya no quedan mas pedidos")
                btnReiniciar.Visible = True
                Exit Sub
            End If
        Loop Until pedidosYaSalidos.Count = pedidos.Count


        pedidostr = pedido.pedido
        Dim pedidosSeparados() As String = pedidostr.Split(";")

        For i = 0 To pedidosSeparados.Length - 1
            Dim textoPedido As New Label
            textoPedido.Text = pedidosSeparados(i)
            textoPedido.ForeColor = Color.DarkRed
            textoPedido.Font = New Font("Microsoft Sans Serif", 12)
            textoPedido.Location = New Point(15, posicionY)
            posicionY += 50
            PanelPedidos.Controls.Add(textoPedido)
            textoPedido.AutoSize = True
        Next
    End Sub



    Private Sub LimpiarControles()
        PanelProductos.Controls.Clear()
        Dim picturesBorrar() As Control = {}
        For i = 0 To productos.Length - 1
            tabGame.Controls.RemoveByKey(productos(i))
        Next

        'For Each control As Control In picturesBorrar
        '    PanelJuego.Controls.Remove(control)
        'Next
        CrearPictureBox()
        altura = 5
        distancia = 10
    End Sub

    Private Sub btnLimpiarPanelProductos_Click(sender As Object, e As EventArgs) Handles btnLimpiarPanelProductos.Click
        LimpiarControles()
    End Sub
    'Comprobacion cantidad controles panel
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs)
        MsgBox(PanelProductos.Controls.Count)
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnvalidar.Click
        Dim contiene As Boolean = False
        Dim productoComparar As String = ""
        Dim vueltas As Integer = 0


        If PanelProductos.Controls.Count = PanelPedidos.Controls.Count Then
            For i = 0 To PanelProductos.Controls.Count - 1
                For j = 0 To PanelPedidos.Controls.Count - 1
                    productoComparar = PanelProductos.Controls(i).Name & ":" & PanelProductos.Controls(i).Text
                    If productoComparar.Equals(PanelPedidos.Controls(j).Text) Then
                        contiene = True
                        Exit For
                    Else
                        contiene = False
                    End If
                    vueltas += 1
                Next
                If vueltas = PanelProductos.Controls.Count Then
                    Exit For
                End If
            Next
            If contiene = True Then
                MetroMessageBox.Show(Me, "¡¡¡Felicidades!!! lo has hecho genial", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Question)

                nombreProductos.Clear()
                'Pasamos los nombres al modulo
                For i = 0 To PanelProductos.Controls.Count - 1
                    Module1.nombreProductos.Add(PanelProductos.Controls(i).Name)
                Next
                'Abrimos el formulario
                Dim formComprobar As New FormComprobarCantidadProductos
                formComprobar.ShowDialog()


                Do
                    YaSalio = Module1.HaSalidoYa
                Loop Until YaSalio = True
                YaSalio = False
                Module1.HaSalidoYa = False
                Dim CantidadProductosIntroducidos As List(Of String) = Module1.CantidadProductosQuedan

                'Hacemos el calculo de productos que quedan
                Dim CantidadProductosComparar As New List(Of String)
                For i = 0 To PanelProductos.Controls.Count - 1
                    For j = 0 To productos.Count - 1
                        If productos(j) = PanelProductos.Controls(i).Name Then
                            CantidadProductos(j) -= PanelProductos.Controls(i).Text
                            CantidadProductosComparar.Add(CantidadProductos(j))
                        End If
                    Next
                Next

                'Comparamos las Cantidades
                For i = 0 To CantidadProductosComparar.Count - 1
                    If CantidadProductosComparar(i) = CantidadProductosIntroducidos(i) Then
                        MetroMessageBox.Show(Me, "Has acertado el producto " & nombreProductos(i) & " te llevas 10 puntos", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MetroMessageBox.Show(Me, "Has fallado el producto " & nombreProductos(i), "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Next

                'Actualizamos la cantidad de productos
                Dim controlesEliminar() As Control
                controlesEliminar = grbProductosCantidad.Controls.Find("CantidadProductosStock", True)
                For Each control As Control In controlesEliminar
                    grbProductosCantidad.Controls.Remove(control)
                Next
                crearCantidadProductos()
                Module1.CantidadProductosQuedan = CantidadProductosComparar

                DevolverPedido()

                LimpiarControles()

            Else
                MetroMessageBox.Show(Me, "Has fallado, la proxima vez sera mejor", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PanelProductos.Controls.Clear()
                LimpiarControles()
            End If
        Else
            MetroMessageBox.Show(Me, "La cantidad de productos introducidos no es la misma que la del pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LimpiarControles()
        End If
    End Sub


    Private Sub crearCantidadProductos()
        Dim posicionControl As Integer = 0
        For i = 0 To grbProductosCantidad.Controls.Count - 1
            Dim label As New Label
            label.Location = New Point(grbProductosCantidad.Controls(i).Location.X, grbProductosCantidad.Controls(i).Location.Y + 20)
            label.Tag = grbProductosCantidad.Controls(i).Text
            For j = 0 To productos.Length - 1
                If productos(j) = label.Tag Then
                    posicionControl = j
                    Exit For
                End If
            Next
            label.Text = CantidadProductos(posicionControl)
            label.TextAlign = ContentAlignment.MiddleCenter
            label.ForeColor = Color.DarkRed
            label.Name = "CantidadProductosStock"
            label.Width = grbProductosCantidad.Controls(i).Width
            label.Height = grbProductosCantidad.Controls(i).Height
            grbProductosCantidad.Controls.Add(label)
        Next

    End Sub

    Private Sub btnMenosCantidad_Click(sender As Object, e As EventArgs) Handles btnMenosCantidad.Click

        lblCantidadProductos.Text -= 1
        If lblCantidadProductos.Text <= 1 Then
            lblCantidadProductos.Text = 1
        End If
    End Sub

    Private Sub btnMasCantidad_Click(sender As Object, e As EventArgs) Handles btnMasCantidad.Click
        If lblCantidadProductos.Text < 50 Then
            lblCantidadProductos.Text += 1
        End If
    End Sub

    Private Sub btnRestar10_Click(sender As Object, e As EventArgs) Handles btnRestar10.Click

        lblCantidadProductos.Text -= 10
        If lblCantidadProductos.Text <= 1 Then
            lblCantidadProductos.Text = 1
        End If

    End Sub

    Private Sub btnSumar10_Click(sender As Object, e As EventArgs) Handles btnSumar10.Click
        If lblCantidadProductos.Text < 50 Then
            lblCantidadProductos.Text += 10
        End If
    End Sub

    Private Sub btnSonido_Click(sender As Object, e As EventArgs) Handles btnSonido.Click
        If ReproducirMusica = False Then
            My.Computer.Audio.Play(My.Resources.Zelda_Symphony_Orchestra___Great_Fairys_Fountain, AudioPlayMode.Background)
            ReproducirMusica = True
            btnSonido.Image = My.Resources.Medium_Volume_30px
        Else
            My.Computer.Audio.Stop()
            ReproducirMusica = False
            btnSonido.Image = My.Resources.Mute_30px_2
        End If


    End Sub

    Private Sub btnMostrarCantidadProductos_Click(sender As Object, e As EventArgs) Handles btnMostrarCantidadProductos.Click
        If grbProductosCantidad.Visible = False Then
            grbProductosCantidad.Visible = True
            btnMostrarCantidadProductos.BackgroundImage = My.Resources.Invisible_30px1
            btnMostrarCantidadProductos.BackgroundImageLayout = ImageLayout.Zoom
        Else
            grbProductosCantidad.Visible = False
            btnMostrarCantidadProductos.BackgroundImage = My.Resources.Visible_30px1
            btnMostrarCantidadProductos.BackgroundImageLayout = ImageLayout.Zoom
        End If

    End Sub

    Private Sub btnAñadirPedido_Click(sender As Object, e As EventArgs) Handles btnAñadirPedido.Click
        grbAñadirPedido.Visible = True
        cboProductos.DisplayMember = "Nombre"
        cboProductos.DataSource = tratamiento.productos

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        lblQueLleva.Text += cboProductos.Text & ":" & NumericUpDown1.Value & ";"
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim respuesta As String = ""
        Dim pedidoBueno As String = ""
        pedidoBueno = lblQueLleva.Text.Substring(0, lblQueLleva.Text.Length - 1)
        respuesta = tratamiento.InsetarNuevoPedido(pedidoBueno)
        If respuesta = "Exito" Then
            ActualizarPedidos()
            lblQueLleva.Text = ""
        End If
        MetroMessageBox.Show(Me, respuesta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnOcultarGrbPedido_Click(sender As Object, e As EventArgs) Handles btnOcultarGrbPedido.Click
        grbAñadirPedido.Visible = False
    End Sub

    Private Sub btnOtroPedido_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        pedidosYaSalidos.Clear()
        DevolverPedido()
    End Sub

    Private Sub btnReponer_Click(sender As Object, e As EventArgs) Handles btnReponer.Click
        ReponerProductosCantidad()
    End Sub
End Class



