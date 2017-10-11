<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formGame
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formGame))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.pnlUserUI = New System.Windows.Forms.Panel()
        Me.lblNombreUsuarioPanel = New System.Windows.Forms.Label()
        Me.PictureBoxUsuario = New System.Windows.Forms.PictureBox()
        Me.btnAtras = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnCrearCuenta = New System.Windows.Forms.Button()
        Me.LabelRepetirContra = New System.Windows.Forms.Label()
        Me.txtRepetirContraseña = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContraseña = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtUser = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnLogIn_Registro = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pnlStart = New System.Windows.Forms.Panel()
        Me.txtInstructions = New System.Windows.Forms.TextBox()
        Me.lblInstructionsTitle = New System.Windows.Forms.Label()
        Me.btnStartGame = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pnlBar = New System.Windows.Forms.Panel()
        Me.btnReponer = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnSonido = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnClose = New MaterialSkin.Controls.MaterialFlatButton()
        Me.tabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabGame = New System.Windows.Forms.TabPage()
        Me.btnMostrarCantidadProductos = New MetroFramework.Controls.MetroButton()
        Me.lblSelecionarcantidadInformacion = New System.Windows.Forms.Label()
        Me.btnMasCantidad = New System.Windows.Forms.Button()
        Me.btnMenosCantidad = New System.Windows.Forms.Button()
        Me.btnRestar10 = New System.Windows.Forms.Button()
        Me.btnSumar10 = New System.Windows.Forms.Button()
        Me.lblCantidadProductos = New System.Windows.Forms.Label()
        Me.grbProductosCantidad = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnvalidar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnReiniciar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnLimpiarPanelProductos = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PictureBoxFlechaRoja = New System.Windows.Forms.PictureBox()
        Me.PanelPedidos = New System.Windows.Forms.Panel()
        Me.PanelProductos = New System.Windows.Forms.Panel()
        Me.tabProgress = New System.Windows.Forms.TabPage()
        Me.ChartPuntuaciones = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabAdminTools = New System.Windows.Forms.TabPage()
        Me.grbAñadirPedido = New System.Windows.Forms.GroupBox()
        Me.btnOcultarGrbPedido = New System.Windows.Forms.Button()
        Me.cboProductos = New MetroFramework.Controls.MetroComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnAñadir = New MetroFramework.Controls.MetroTile()
        Me.btnGuardar = New MetroFramework.Controls.MetroTile()
        Me.lblQueLleva = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnEliminarPedido = New System.Windows.Forms.Button()
        Me.btnAñadirPedido = New System.Windows.Forms.Button()
        Me.lstPedidos = New System.Windows.Forms.ListBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lstUsuarios = New System.Windows.Forms.ListView()
        Me.PanelOcultarJuegoInicio = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tabSelector = New MaterialSkin.Controls.MaterialTabSelector()
        Me.pnlUserUI.SuspendLayout()
        CType(Me.PictureBoxUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStart.SuspendLayout()
        Me.pnlBar.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.tabGame.SuspendLayout()
        Me.grbProductosCantidad.SuspendLayout()
        CType(Me.PictureBoxFlechaRoja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProgress.SuspendLayout()
        CType(Me.ChartPuntuaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabAdminTools.SuspendLayout()
        Me.grbAñadirPedido.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOcultarJuegoInicio.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlUserUI
        '
        Me.pnlUserUI.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlUserUI.Controls.Add(Me.lblNombreUsuarioPanel)
        Me.pnlUserUI.Controls.Add(Me.PictureBoxUsuario)
        Me.pnlUserUI.Controls.Add(Me.btnAtras)
        Me.pnlUserUI.Controls.Add(Me.btnCrearCuenta)
        Me.pnlUserUI.Controls.Add(Me.LabelRepetirContra)
        Me.pnlUserUI.Controls.Add(Me.txtRepetirContraseña)
        Me.pnlUserUI.Controls.Add(Me.Label2)
        Me.pnlUserUI.Controls.Add(Me.Label1)
        Me.pnlUserUI.Controls.Add(Me.txtContraseña)
        Me.pnlUserUI.Controls.Add(Me.txtUser)
        Me.pnlUserUI.Controls.Add(Me.btnLogIn_Registro)
        Me.pnlUserUI.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlUserUI.Location = New System.Drawing.Point(842, 34)
        Me.pnlUserUI.Name = "pnlUserUI"
        Me.pnlUserUI.Size = New System.Drawing.Size(182, 734)
        Me.pnlUserUI.TabIndex = 0
        '
        'lblNombreUsuarioPanel
        '
        Me.lblNombreUsuarioPanel.AutoSize = True
        Me.lblNombreUsuarioPanel.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreUsuarioPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuarioPanel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblNombreUsuarioPanel.Location = New System.Drawing.Point(65, 173)
        Me.lblNombreUsuarioPanel.Name = "lblNombreUsuarioPanel"
        Me.lblNombreUsuarioPanel.Size = New System.Drawing.Size(65, 20)
        Me.lblNombreUsuarioPanel.TabIndex = 10
        Me.lblNombreUsuarioPanel.Text = "Nombre"
        Me.lblNombreUsuarioPanel.Visible = False
        '
        'PictureBoxUsuario
        '
        Me.PictureBoxUsuario.Image = Global.AlmacenExpress.My.Resources.Resources.Circled_User_Male_104px
        Me.PictureBoxUsuario.Location = New System.Drawing.Point(44, 70)
        Me.PictureBoxUsuario.Name = "PictureBoxUsuario"
        Me.PictureBoxUsuario.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUsuario.TabIndex = 9
        Me.PictureBoxUsuario.TabStop = False
        Me.PictureBoxUsuario.Visible = False
        '
        'btnAtras
        '
        Me.btnAtras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtras.AutoSize = True
        Me.btnAtras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAtras.Depth = 0
        Me.btnAtras.Icon = Global.AlmacenExpress.My.Resources.Resources.Undo_30px
        Me.btnAtras.Image = Global.AlmacenExpress.My.Resources.Resources.Undo_30px
        Me.btnAtras.Location = New System.Drawing.Point(4, 6)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAtras.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Primary = True
        Me.btnAtras.Size = New System.Drawing.Size(44, 36)
        Me.btnAtras.TabIndex = 8
        Me.btnAtras.UseVisualStyleBackColor = True
        Me.btnAtras.Visible = False
        '
        'btnCrearCuenta
        '
        Me.btnCrearCuenta.BackColor = System.Drawing.Color.Transparent
        Me.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearCuenta.Location = New System.Drawing.Point(22, 515)
        Me.btnCrearCuenta.Name = "btnCrearCuenta"
        Me.btnCrearCuenta.Size = New System.Drawing.Size(142, 23)
        Me.btnCrearCuenta.TabIndex = 7
        Me.btnCrearCuenta.Text = "¿No tienes cuenta?"
        Me.btnCrearCuenta.UseVisualStyleBackColor = False
        '
        'LabelRepetirContra
        '
        Me.LabelRepetirContra.AutoSize = True
        Me.LabelRepetirContra.BackColor = System.Drawing.Color.Transparent
        Me.LabelRepetirContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRepetirContra.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LabelRepetirContra.Location = New System.Drawing.Point(24, 360)
        Me.LabelRepetirContra.Name = "LabelRepetirContra"
        Me.LabelRepetirContra.Size = New System.Drawing.Size(148, 20)
        Me.LabelRepetirContra.TabIndex = 6
        Me.LabelRepetirContra.Text = "Repetir Contraseña"
        Me.LabelRepetirContra.Visible = False
        '
        'txtRepetirContraseña
        '
        Me.txtRepetirContraseña.Depth = 0
        Me.txtRepetirContraseña.ForeColor = System.Drawing.Color.White
        Me.txtRepetirContraseña.Hint = ""
        Me.txtRepetirContraseña.Location = New System.Drawing.Point(20, 383)
        Me.txtRepetirContraseña.MaxLength = 30
        Me.txtRepetirContraseña.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtRepetirContraseña.Name = "txtRepetirContraseña"
        Me.txtRepetirContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepetirContraseña.SelectedText = ""
        Me.txtRepetirContraseña.SelectionLength = 0
        Me.txtRepetirContraseña.SelectionStart = 0
        Me.txtRepetirContraseña.Size = New System.Drawing.Size(142, 23)
        Me.txtRepetirContraseña.TabIndex = 5
        Me.txtRepetirContraseña.TabStop = False
        Me.txtRepetirContraseña.UseSystemPasswordChar = False
        Me.txtRepetirContraseña.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(24, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(24, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario"
        '
        'txtContraseña
        '
        Me.txtContraseña.Depth = 0
        Me.txtContraseña.ForeColor = System.Drawing.Color.White
        Me.txtContraseña.Hint = ""
        Me.txtContraseña.Location = New System.Drawing.Point(20, 312)
        Me.txtContraseña.MaxLength = 30
        Me.txtContraseña.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.SelectedText = ""
        Me.txtContraseña.SelectionLength = 0
        Me.txtContraseña.SelectionStart = 0
        Me.txtContraseña.Size = New System.Drawing.Size(142, 23)
        Me.txtContraseña.TabIndex = 2
        Me.txtContraseña.TabStop = False
        Me.txtContraseña.UseSystemPasswordChar = False
        '
        'txtUser
        '
        Me.txtUser.Depth = 0
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Hint = ""
        Me.txtUser.Location = New System.Drawing.Point(20, 243)
        Me.txtUser.MaxLength = 30
        Me.txtUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.SelectedText = ""
        Me.txtUser.SelectionLength = 0
        Me.txtUser.SelectionStart = 0
        Me.txtUser.Size = New System.Drawing.Size(142, 23)
        Me.txtUser.TabIndex = 1
        Me.txtUser.TabStop = False
        Me.txtUser.UseSystemPasswordChar = False
        '
        'btnLogIn_Registro
        '
        Me.btnLogIn_Registro.AutoSize = True
        Me.btnLogIn_Registro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLogIn_Registro.Depth = 0
        Me.btnLogIn_Registro.Icon = Nothing
        Me.btnLogIn_Registro.Location = New System.Drawing.Point(32, 473)
        Me.btnLogIn_Registro.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLogIn_Registro.Name = "btnLogIn_Registro"
        Me.btnLogIn_Registro.Primary = True
        Me.btnLogIn_Registro.Size = New System.Drawing.Size(120, 36)
        Me.btnLogIn_Registro.TabIndex = 0
        Me.btnLogIn_Registro.Text = "Iniciar sesión"
        Me.btnLogIn_Registro.UseVisualStyleBackColor = True
        '
        'pnlStart
        '
        Me.pnlStart.Controls.Add(Me.txtInstructions)
        Me.pnlStart.Controls.Add(Me.lblInstructionsTitle)
        Me.pnlStart.Controls.Add(Me.btnStartGame)
        Me.pnlStart.Location = New System.Drawing.Point(57, 34)
        Me.pnlStart.Name = "pnlStart"
        Me.pnlStart.Size = New System.Drawing.Size(711, 585)
        Me.pnlStart.TabIndex = 6
        '
        'txtInstructions
        '
        Me.txtInstructions.BackColor = System.Drawing.Color.White
        Me.txtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructions.Location = New System.Drawing.Point(79, 101)
        Me.txtInstructions.Multiline = True
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.ReadOnly = True
        Me.txtInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInstructions.Size = New System.Drawing.Size(563, 376)
        Me.txtInstructions.TabIndex = 4
        Me.txtInstructions.Text = resources.GetString("txtInstructions.Text")
        '
        'lblInstructionsTitle
        '
        Me.lblInstructionsTitle.AutoSize = True
        Me.lblInstructionsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsTitle.Location = New System.Drawing.Point(268, 36)
        Me.lblInstructionsTitle.Name = "lblInstructionsTitle"
        Me.lblInstructionsTitle.Size = New System.Drawing.Size(189, 31)
        Me.lblInstructionsTitle.TabIndex = 2
        Me.lblInstructionsTitle.Text = "Instrucciones"
        '
        'btnStartGame
        '
        Me.btnStartGame.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStartGame.AutoSize = True
        Me.btnStartGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStartGame.Depth = 0
        Me.btnStartGame.ForeColor = System.Drawing.Color.Transparent
        Me.btnStartGame.Icon = Nothing
        Me.btnStartGame.Location = New System.Drawing.Point(287, 513)
        Me.btnStartGame.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Primary = True
        Me.btnStartGame.Size = New System.Drawing.Size(143, 36)
        Me.btnStartGame.TabIndex = 3
        Me.btnStartGame.Text = "Empezar a jugar"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'pnlBar
        '
        Me.pnlBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.pnlBar.Controls.Add(Me.btnReponer)
        Me.pnlBar.Controls.Add(Me.btnSonido)
        Me.pnlBar.Controls.Add(Me.btnClose)
        Me.pnlBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlBar.Name = "pnlBar"
        Me.pnlBar.Size = New System.Drawing.Size(1024, 34)
        Me.pnlBar.TabIndex = 1
        '
        'btnReponer
        '
        Me.btnReponer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReponer.AutoSize = True
        Me.btnReponer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReponer.Depth = 0
        Me.btnReponer.Icon = Global.AlmacenExpress.My.Resources.Resources.Truck_30px_1
        Me.btnReponer.Image = Global.AlmacenExpress.My.Resources.Resources.CloseIcon
        Me.btnReponer.Location = New System.Drawing.Point(864, -2)
        Me.btnReponer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnReponer.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnReponer.Name = "btnReponer"
        Me.btnReponer.Primary = True
        Me.btnReponer.Size = New System.Drawing.Size(44, 36)
        Me.btnReponer.TabIndex = 1
        Me.btnReponer.UseVisualStyleBackColor = True
        '
        'btnSonido
        '
        Me.btnSonido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSonido.AutoSize = True
        Me.btnSonido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSonido.Depth = 0
        Me.btnSonido.Icon = Global.AlmacenExpress.My.Resources.Resources.MutedIcon
        Me.btnSonido.Image = Global.AlmacenExpress.My.Resources.Resources.CloseIcon
        Me.btnSonido.Location = New System.Drawing.Point(928, -2)
        Me.btnSonido.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSonido.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSonido.Name = "btnSonido"
        Me.btnSonido.Primary = True
        Me.btnSonido.Size = New System.Drawing.Size(44, 36)
        Me.btnSonido.TabIndex = 1
        Me.btnSonido.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.AutoSize = True
        Me.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClose.Depth = 0
        Me.btnClose.Icon = Global.AlmacenExpress.My.Resources.Resources.CloseIcon
        Me.btnClose.Image = Global.AlmacenExpress.My.Resources.Resources.CloseIcon
        Me.btnClose.Location = New System.Drawing.Point(980, -2)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Primary = True
        Me.btnClose.Size = New System.Drawing.Size(44, 36)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabGame)
        Me.tabControl.Controls.Add(Me.tabProgress)
        Me.tabControl.Controls.Add(Me.TabPage1)
        Me.tabControl.Controls.Add(Me.TabAdminTools)
        Me.tabControl.Depth = 0
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabControl.Location = New System.Drawing.Point(0, 95)
        Me.tabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.tabControl.Name = "tabControl"
        Me.tabControl.Padding = New System.Drawing.Point(0, 0)
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(842, 673)
        Me.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabControl.TabIndex = 2
        '
        'tabGame
        '
        Me.tabGame.AutoScroll = True
        Me.tabGame.BackColor = System.Drawing.Color.Transparent
        Me.tabGame.Controls.Add(Me.btnMostrarCantidadProductos)
        Me.tabGame.Controls.Add(Me.lblSelecionarcantidadInformacion)
        Me.tabGame.Controls.Add(Me.btnMasCantidad)
        Me.tabGame.Controls.Add(Me.btnMenosCantidad)
        Me.tabGame.Controls.Add(Me.btnRestar10)
        Me.tabGame.Controls.Add(Me.btnSumar10)
        Me.tabGame.Controls.Add(Me.lblCantidadProductos)
        Me.tabGame.Controls.Add(Me.grbProductosCantidad)
        Me.tabGame.Controls.Add(Me.btnvalidar)
        Me.tabGame.Controls.Add(Me.btnReiniciar)
        Me.tabGame.Controls.Add(Me.btnLimpiarPanelProductos)
        Me.tabGame.Controls.Add(Me.PictureBoxFlechaRoja)
        Me.tabGame.Controls.Add(Me.PanelPedidos)
        Me.tabGame.Controls.Add(Me.PanelProductos)
        Me.tabGame.Location = New System.Drawing.Point(4, 22)
        Me.tabGame.Name = "tabGame"
        Me.tabGame.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGame.Size = New System.Drawing.Size(834, 647)
        Me.tabGame.TabIndex = 0
        Me.tabGame.Text = "JUGAR"
        '
        'btnMostrarCantidadProductos
        '
        Me.btnMostrarCantidadProductos.BackgroundImage = Global.AlmacenExpress.My.Resources.Resources.Invisible_30px1
        Me.btnMostrarCantidadProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMostrarCantidadProductos.Location = New System.Drawing.Point(637, 13)
        Me.btnMostrarCantidadProductos.Name = "btnMostrarCantidadProductos"
        Me.btnMostrarCantidadProductos.Size = New System.Drawing.Size(20, 20)
        Me.btnMostrarCantidadProductos.TabIndex = 9
        Me.btnMostrarCantidadProductos.UseSelectable = True
        '
        'lblSelecionarcantidadInformacion
        '
        Me.lblSelecionarcantidadInformacion.AutoSize = True
        Me.lblSelecionarcantidadInformacion.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblSelecionarcantidadInformacion.Location = New System.Drawing.Point(466, 70)
        Me.lblSelecionarcantidadInformacion.Name = "lblSelecionarcantidadInformacion"
        Me.lblSelecionarcantidadInformacion.Size = New System.Drawing.Size(180, 13)
        Me.lblSelecionarcantidadInformacion.TabIndex = 8
        Me.lblSelecionarcantidadInformacion.Text = "Selecciona la cantidad de productos"
        '
        'btnMasCantidad
        '
        Me.btnMasCantidad.BackgroundImage = Global.AlmacenExpress.My.Resources.Resources.Circled_Chevron_Up_30px
        Me.btnMasCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMasCantidad.FlatAppearance.BorderSize = 0
        Me.btnMasCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasCantidad.Location = New System.Drawing.Point(544, 90)
        Me.btnMasCantidad.Name = "btnMasCantidad"
        Me.btnMasCantidad.Size = New System.Drawing.Size(25, 25)
        Me.btnMasCantidad.TabIndex = 7
        Me.btnMasCantidad.UseVisualStyleBackColor = True
        '
        'btnMenosCantidad
        '
        Me.btnMenosCantidad.BackgroundImage = Global.AlmacenExpress.My.Resources.Resources.Circled_Chevron_Down_30px
        Me.btnMenosCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenosCantidad.FlatAppearance.BorderSize = 0
        Me.btnMenosCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenosCantidad.Location = New System.Drawing.Point(544, 116)
        Me.btnMenosCantidad.Name = "btnMenosCantidad"
        Me.btnMenosCantidad.Size = New System.Drawing.Size(25, 25)
        Me.btnMenosCantidad.TabIndex = 7
        Me.btnMenosCantidad.UseVisualStyleBackColor = True
        '
        'btnRestar10
        '
        Me.btnRestar10.BackgroundImage = Global.AlmacenExpress.My.Resources.Resources.Timezonemenos1030px
        Me.btnRestar10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRestar10.FlatAppearance.BorderSize = 0
        Me.btnRestar10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestar10.Location = New System.Drawing.Point(575, 116)
        Me.btnRestar10.Name = "btnRestar10"
        Me.btnRestar10.Size = New System.Drawing.Size(25, 25)
        Me.btnRestar10.TabIndex = 7
        Me.btnRestar10.UseVisualStyleBackColor = True
        '
        'btnSumar10
        '
        Me.btnSumar10.BackgroundImage = Global.AlmacenExpress.My.Resources.Resources.Timezonemas1030px
        Me.btnSumar10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSumar10.FlatAppearance.BorderSize = 0
        Me.btnSumar10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSumar10.Location = New System.Drawing.Point(575, 90)
        Me.btnSumar10.Name = "btnSumar10"
        Me.btnSumar10.Size = New System.Drawing.Size(25, 25)
        Me.btnSumar10.TabIndex = 7
        Me.btnSumar10.UseVisualStyleBackColor = True
        '
        'lblCantidadProductos
        '
        Me.lblCantidadProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadProductos.Location = New System.Drawing.Point(480, 92)
        Me.lblCantidadProductos.Name = "lblCantidadProductos"
        Me.lblCantidadProductos.Size = New System.Drawing.Size(58, 49)
        Me.lblCantidadProductos.TabIndex = 6
        Me.lblCantidadProductos.Text = "1"
        Me.lblCantidadProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbProductosCantidad
        '
        Me.grbProductosCantidad.Controls.Add(Me.Label12)
        Me.grbProductosCantidad.Controls.Add(Me.Label11)
        Me.grbProductosCantidad.Controls.Add(Me.Label10)
        Me.grbProductosCantidad.Controls.Add(Me.Label9)
        Me.grbProductosCantidad.Controls.Add(Me.Label8)
        Me.grbProductosCantidad.Controls.Add(Me.Label7)
        Me.grbProductosCantidad.Controls.Add(Me.Label6)
        Me.grbProductosCantidad.Controls.Add(Me.Label5)
        Me.grbProductosCantidad.Controls.Add(Me.Label4)
        Me.grbProductosCantidad.Controls.Add(Me.Label3)
        Me.grbProductosCantidad.Location = New System.Drawing.Point(8, 6)
        Me.grbProductosCantidad.Name = "grbProductosCantidad"
        Me.grbProductosCantidad.Size = New System.Drawing.Size(623, 55)
        Me.grbProductosCantidad.TabIndex = 4
        Me.grbProductosCantidad.TabStop = False
        Me.grbProductosCantidad.Text = "Productos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(546, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "grapadora"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(505, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "tijera"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(461, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "lapiz"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(411, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "papel"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(328, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "subrayador"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(246, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "pegamento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(200, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "goma"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "taladradora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "calculadora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "boli"
        '
        'btnvalidar
        '
        Me.btnvalidar.AutoSize = True
        Me.btnvalidar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnvalidar.Depth = 0
        Me.btnvalidar.Icon = Nothing
        Me.btnvalidar.Location = New System.Drawing.Point(512, 460)
        Me.btnvalidar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnvalidar.Name = "btnvalidar"
        Me.btnvalidar.Primary = True
        Me.btnvalidar.Size = New System.Drawing.Size(77, 36)
        Me.btnvalidar.TabIndex = 3
        Me.btnvalidar.Text = "Validar"
        Me.btnvalidar.UseVisualStyleBackColor = True
        '
        'btnReiniciar
        '
        Me.btnReiniciar.AutoSize = True
        Me.btnReiniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReiniciar.Depth = 0
        Me.btnReiniciar.Icon = Nothing
        Me.btnReiniciar.Location = New System.Drawing.Point(430, 506)
        Me.btnReiniciar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Primary = True
        Me.btnReiniciar.Size = New System.Drawing.Size(85, 36)
        Me.btnReiniciar.TabIndex = 3
        Me.btnReiniciar.Text = "Reiniciar"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'btnLimpiarPanelProductos
        '
        Me.btnLimpiarPanelProductos.AutoSize = True
        Me.btnLimpiarPanelProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLimpiarPanelProductos.Depth = 0
        Me.btnLimpiarPanelProductos.Icon = Nothing
        Me.btnLimpiarPanelProductos.Location = New System.Drawing.Point(352, 460)
        Me.btnLimpiarPanelProductos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLimpiarPanelProductos.Name = "btnLimpiarPanelProductos"
        Me.btnLimpiarPanelProductos.Primary = True
        Me.btnLimpiarPanelProductos.Size = New System.Drawing.Size(75, 36)
        Me.btnLimpiarPanelProductos.TabIndex = 3
        Me.btnLimpiarPanelProductos.Text = "Limpiar"
        Me.btnLimpiarPanelProductos.UseVisualStyleBackColor = True
        '
        'PictureBoxFlechaRoja
        '
        Me.PictureBoxFlechaRoja.Image = Global.AlmacenExpress.My.Resources.Resources.flechaRoja
        Me.PictureBoxFlechaRoja.Location = New System.Drawing.Point(262, 97)
        Me.PictureBoxFlechaRoja.Name = "PictureBoxFlechaRoja"
        Me.PictureBoxFlechaRoja.Size = New System.Drawing.Size(127, 60)
        Me.PictureBoxFlechaRoja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxFlechaRoja.TabIndex = 2
        Me.PictureBoxFlechaRoja.TabStop = False
        '
        'PanelPedidos
        '
        Me.PanelPedidos.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelPedidos.Location = New System.Drawing.Point(675, 3)
        Me.PanelPedidos.Name = "PanelPedidos"
        Me.PanelPedidos.Size = New System.Drawing.Size(156, 641)
        Me.PanelPedidos.TabIndex = 1
        '
        'PanelProductos
        '
        Me.PanelProductos.Location = New System.Drawing.Point(352, 163)
        Me.PanelProductos.Name = "PanelProductos"
        Me.PanelProductos.Size = New System.Drawing.Size(237, 277)
        Me.PanelProductos.TabIndex = 0
        '
        'tabProgress
        '
        Me.tabProgress.Controls.Add(Me.ChartPuntuaciones)
        Me.tabProgress.Location = New System.Drawing.Point(4, 22)
        Me.tabProgress.Name = "tabProgress"
        Me.tabProgress.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProgress.Size = New System.Drawing.Size(834, 647)
        Me.tabProgress.TabIndex = 2
        Me.tabProgress.Text = "PROGRESO"
        Me.tabProgress.UseVisualStyleBackColor = True
        '
        'ChartPuntuaciones
        '
        Me.ChartPuntuaciones.BorderlineColor = System.Drawing.Color.Maroon
        Me.ChartPuntuaciones.BorderlineWidth = 2
        ChartArea2.Name = "ChartArea1"
        Me.ChartPuntuaciones.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ChartPuntuaciones.Legends.Add(Legend2)
        Me.ChartPuntuaciones.Location = New System.Drawing.Point(28, 92)
        Me.ChartPuntuaciones.Name = "ChartPuntuaciones"
        Me.ChartPuntuaciones.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.ChartPuntuaciones.Series.Add(Series2)
        Me.ChartPuntuaciones.Size = New System.Drawing.Size(744, 492)
        Me.ChartPuntuaciones.TabIndex = 0
        Me.ChartPuntuaciones.Text = "Chart1"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlStart)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(834, 647)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Información"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabAdminTools
        '
        Me.TabAdminTools.Controls.Add(Me.grbAñadirPedido)
        Me.TabAdminTools.Controls.Add(Me.lblQueLleva)
        Me.TabAdminTools.Controls.Add(Me.Label13)
        Me.TabAdminTools.Controls.Add(Me.btnEliminarPedido)
        Me.TabAdminTools.Controls.Add(Me.btnAñadirPedido)
        Me.TabAdminTools.Controls.Add(Me.lstPedidos)
        Me.TabAdminTools.Controls.Add(Me.MaterialLabel3)
        Me.TabAdminTools.Controls.Add(Me.MaterialLabel1)
        Me.TabAdminTools.Controls.Add(Me.lstUsuarios)
        Me.TabAdminTools.Location = New System.Drawing.Point(4, 22)
        Me.TabAdminTools.Name = "TabAdminTools"
        Me.TabAdminTools.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAdminTools.Size = New System.Drawing.Size(834, 647)
        Me.TabAdminTools.TabIndex = 4
        Me.TabAdminTools.Text = "Admin Tools"
        Me.TabAdminTools.UseVisualStyleBackColor = True
        '
        'grbAñadirPedido
        '
        Me.grbAñadirPedido.Controls.Add(Me.btnOcultarGrbPedido)
        Me.grbAñadirPedido.Controls.Add(Me.cboProductos)
        Me.grbAñadirPedido.Controls.Add(Me.NumericUpDown1)
        Me.grbAñadirPedido.Controls.Add(Me.btnAñadir)
        Me.grbAñadirPedido.Controls.Add(Me.btnGuardar)
        Me.grbAñadirPedido.Location = New System.Drawing.Point(240, 495)
        Me.grbAñadirPedido.Name = "grbAñadirPedido"
        Me.grbAñadirPedido.Size = New System.Drawing.Size(320, 119)
        Me.grbAñadirPedido.TabIndex = 20
        Me.grbAñadirPedido.TabStop = False
        Me.grbAñadirPedido.Text = "Añadir pedido"
        Me.grbAñadirPedido.Visible = False
        '
        'btnOcultarGrbPedido
        '
        Me.btnOcultarGrbPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOcultarGrbPedido.BackgroundImage = Global.AlmacenExpress.My.Resources.Resources.Close_Window_24px_1
        Me.btnOcultarGrbPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOcultarGrbPedido.FlatAppearance.BorderSize = 0
        Me.btnOcultarGrbPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOcultarGrbPedido.Location = New System.Drawing.Point(298, 8)
        Me.btnOcultarGrbPedido.Name = "btnOcultarGrbPedido"
        Me.btnOcultarGrbPedido.Size = New System.Drawing.Size(20, 20)
        Me.btnOcultarGrbPedido.TabIndex = 20
        Me.btnOcultarGrbPedido.UseVisualStyleBackColor = True
        '
        'cboProductos
        '
        Me.cboProductos.FormattingEnabled = True
        Me.cboProductos.ItemHeight = 23
        Me.cboProductos.Location = New System.Drawing.Point(16, 34)
        Me.cboProductos.Name = "cboProductos"
        Me.cboProductos.Size = New System.Drawing.Size(146, 29)
        Me.cboProductos.TabIndex = 15
        Me.cboProductos.UseSelectable = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(16, 81)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 19
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnAñadir
        '
        Me.btnAñadir.ActiveControl = Nothing
        Me.btnAñadir.Location = New System.Drawing.Point(180, 19)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(100, 41)
        Me.btnAñadir.TabIndex = 16
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAñadir.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ActiveControl = Nothing
        Me.btnGuardar.Location = New System.Drawing.Point(180, 67)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 41)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Green
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGuardar.UseSelectable = True
        '
        'lblQueLleva
        '
        Me.lblQueLleva.AutoSize = True
        Me.lblQueLleva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQueLleva.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblQueLleva.Location = New System.Drawing.Point(369, 268)
        Me.lblQueLleva.Name = "lblQueLleva"
        Me.lblQueLleva.Size = New System.Drawing.Size(0, 20)
        Me.lblQueLleva.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label13.Location = New System.Drawing.Point(301, 268)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 20)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Llevas: "
        '
        'btnEliminarPedido
        '
        Me.btnEliminarPedido.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEliminarPedido.FlatAppearance.BorderSize = 0
        Me.btnEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPedido.Location = New System.Drawing.Point(78, 515)
        Me.btnEliminarPedido.Name = "btnEliminarPedido"
        Me.btnEliminarPedido.Size = New System.Drawing.Size(126, 33)
        Me.btnEliminarPedido.TabIndex = 13
        Me.btnEliminarPedido.Text = "Eliminar pedido"
        Me.btnEliminarPedido.UseVisualStyleBackColor = False
        '
        'btnAñadirPedido
        '
        Me.btnAñadirPedido.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAñadirPedido.FlatAppearance.BorderSize = 0
        Me.btnAñadirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAñadirPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadirPedido.Location = New System.Drawing.Point(78, 476)
        Me.btnAñadirPedido.Name = "btnAñadirPedido"
        Me.btnAñadirPedido.Size = New System.Drawing.Size(126, 33)
        Me.btnAñadirPedido.TabIndex = 14
        Me.btnAñadirPedido.Text = "Añadir pedido"
        Me.btnAñadirPedido.UseVisualStyleBackColor = False
        '
        'lstPedidos
        '
        Me.lstPedidos.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lstPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPedidos.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lstPedidos.FormattingEnabled = True
        Me.lstPedidos.ItemHeight = 20
        Me.lstPedidos.Location = New System.Drawing.Point(78, 290)
        Me.lstPedidos.Name = "lstPedidos"
        Me.lstPedidos.Size = New System.Drawing.Size(607, 180)
        Me.lstPedidos.TabIndex = 12
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(76, 268)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(63, 19)
        Me.MaterialLabel3.TabIndex = 11
        Me.MaterialLabel3.Text = "Pedidos"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(74, 24)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(69, 19)
        Me.MaterialLabel1.TabIndex = 10
        Me.MaterialLabel1.Text = "Usuarios"
        '
        'lstUsuarios
        '
        Me.lstUsuarios.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lstUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUsuarios.ForeColor = System.Drawing.SystemColors.Window
        Me.lstUsuarios.Location = New System.Drawing.Point(76, 45)
        Me.lstUsuarios.Name = "lstUsuarios"
        Me.lstUsuarios.Size = New System.Drawing.Size(270, 180)
        Me.lstUsuarios.TabIndex = 9
        Me.lstUsuarios.UseCompatibleStateImageBehavior = False
        Me.lstUsuarios.View = System.Windows.Forms.View.List
        '
        'PanelOcultarJuegoInicio
        '
        Me.PanelOcultarJuegoInicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelOcultarJuegoInicio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelOcultarJuegoInicio.Controls.Add(Me.PictureBox1)
        Me.PanelOcultarJuegoInicio.Location = New System.Drawing.Point(0, 34)
        Me.PanelOcultarJuegoInicio.Name = "PanelOcultarJuegoInicio"
        Me.PanelOcultarJuegoInicio.Size = New System.Drawing.Size(842, 734)
        Me.PanelOcultarJuegoInicio.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.AlmacenExpress.My.Resources.Resources.giphy
        Me.PictureBox1.Location = New System.Drawing.Point(291, 220)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 248)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tabSelector
        '
        Me.tabSelector.BaseTabControl = Me.tabControl
        Me.tabSelector.Depth = 0
        Me.tabSelector.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabSelector.Location = New System.Drawing.Point(0, 34)
        Me.tabSelector.MouseState = MaterialSkin.MouseState.HOVER
        Me.tabSelector.Name = "tabSelector"
        Me.tabSelector.Size = New System.Drawing.Size(842, 55)
        Me.tabSelector.TabIndex = 3
        Me.tabSelector.Text = "tabControl"
        '
        'formGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PanelOcultarJuegoInicio)
        Me.Controls.Add(Me.tabSelector)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.pnlUserUI)
        Me.Controls.Add(Me.pnlBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formGame"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlUserUI.ResumeLayout(False)
        Me.pnlUserUI.PerformLayout()
        CType(Me.PictureBoxUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStart.ResumeLayout(False)
        Me.pnlStart.PerformLayout()
        Me.pnlBar.ResumeLayout(False)
        Me.pnlBar.PerformLayout()
        Me.tabControl.ResumeLayout(False)
        Me.tabGame.ResumeLayout(False)
        Me.tabGame.PerformLayout()
        Me.grbProductosCantidad.ResumeLayout(False)
        Me.grbProductosCantidad.PerformLayout()
        CType(Me.PictureBoxFlechaRoja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProgress.ResumeLayout(False)
        CType(Me.ChartPuntuaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabAdminTools.ResumeLayout(False)
        Me.TabAdminTools.PerformLayout()
        Me.grbAñadirPedido.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOcultarJuegoInicio.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlUserUI As Panel
    Friend WithEvents pnlBar As Panel
    Friend WithEvents tabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tabGame As TabPage
    Friend WithEvents tabSelector As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents tabProgress As TabPage
    Friend WithEvents btnClose As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnSonido As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnLogIn_Registro As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtUser As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtContraseña As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelRepetirContra As Label
    Friend WithEvents txtRepetirContraseña As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnCrearCuenta As Button
    Friend WithEvents btnAtras As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents pnlStart As Panel
    Friend WithEvents txtInstructions As TextBox
    Friend WithEvents lblInstructionsTitle As Label
    Friend WithEvents btnStartGame As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PanelPedidos As Panel
    Friend WithEvents PanelProductos As Panel
    Friend WithEvents PictureBoxFlechaRoja As PictureBox
    Friend WithEvents btnLimpiarPanelProductos As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents grbProductosCantidad As GroupBox
    Friend WithEvents lblCantidadProductos As Label
    Friend WithEvents btnvalidar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnMasCantidad As Button
    Friend WithEvents btnMenosCantidad As Button
    Friend WithEvents btnRestar10 As Button
    Friend WithEvents btnSumar10 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSelecionarcantidadInformacion As Label
    Friend WithEvents btnMostrarCantidadProductos As MetroFramework.Controls.MetroButton
    Friend WithEvents TabAdminTools As TabPage
    Friend WithEvents btnEliminarPedido As Button
    Friend WithEvents btnAñadirPedido As Button
    Friend WithEvents lstPedidos As ListBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lstUsuarios As ListView
    Friend WithEvents PanelOcultarJuegoInicio As Panel
    Friend WithEvents cboProductos As MetroFramework.Controls.MetroComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lblQueLleva As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroTile
    Friend WithEvents btnAñadir As MetroFramework.Controls.MetroTile
    Friend WithEvents grbAñadirPedido As GroupBox
    Friend WithEvents btnOcultarGrbPedido As Button
    Friend WithEvents ChartPuntuaciones As DataVisualization.Charting.Chart
    Friend WithEvents lblNombreUsuarioPanel As Label
    Friend WithEvents PictureBoxUsuario As PictureBox
    Friend WithEvents btnReiniciar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReponer As MaterialSkin.Controls.MaterialFlatButton
End Class
