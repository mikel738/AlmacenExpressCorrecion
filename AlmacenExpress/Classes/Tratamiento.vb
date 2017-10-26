Imports Entidaddes
Imports System.Data.OleDb

Public Class Tratamiento
    Private Const cadConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\AlmacenExpress.accdb"

    Public Function Usuarios() As List(Of Usuario)
        Dim misUsuarios As New List(Of Usuario)
        Dim sql As String = "Select * From Usuarios"
        Using conSQLUsuarios As New OleDbConnection(cadConexion)
            Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuarios)
            Try
                conSQLUsuarios.Open()
                Dim dr As OleDbDataReader = cmdUsuarios.ExecuteReader
                While dr.Read
                    Dim usu As New Usuario
                    usu.id = dr("Id")
                    usu.Nombre = dr("Nombre")
                    usu.Cantraseña = dr("Contraseña")
                    misUsuarios.Add(usu)
                End While
                Return misUsuarios
            Catch ex As Exception
                Return Nothing
            End Try
        End Using
    End Function

    Public Function Pedidos() As List(Of Pedido)
        Dim misPedidos As New List(Of Pedido)
        Dim sql As String = "Select * From Pedidos"
        Using conSQLUsuarios As New OleDbConnection(cadConexion)
            Dim cmdPedidos As New OleDbCommand(sql, conSQLUsuarios)
            Try
                conSQLUsuarios.Open()
                Dim dr As OleDbDataReader = cmdPedidos.ExecuteReader
                While dr.Read
                    Dim pedido As New Pedido
                    pedido.id = dr("Id")
                    pedido.pedido = dr("Pedido")
                    misPedidos.Add(pedido)
                End While
                Return misPedidos
            Catch ex As Exception
                Return Nothing
            End Try
        End Using
    End Function

    Public Function productos() As List(Of Producto)
        Dim misProductos As New List(Of Producto)
        Dim sql As String = "Select * From productos"
        'Dim conSQL As New OleDbConnection(cadConexion)

        Using conSQL As New OleDbConnection(cadConexion)
            Dim cmdPedidos As New OleDbCommand(sql, conSQL)
            Try
                conSQL.Open()
                Dim dr As OleDbDataReader = cmdPedidos.ExecuteReader
                While dr.Read
                    Dim product As New Producto
                    product.id = dr("Id")
                    product.Nombre = dr("Nombre")
                    product.Cantidada = dr("Cantidad")
                    misProductos.Add(product)
                End While
                Return misProductos
            Catch ex As OleDbException
                Throw New Exception("Ha ocurrido un error con la base de datos, consulta al administrador")
            End Try
        End Using

    End Function

    'PERFECTO
    Public Function InsetarNuevoUsuario(ByVal Nombre As String, ByVal Contraseña As String) As String
        Using conSQLUsuario As New OleDbConnection(cadConexion)
            Try
                conSQLUsuario.Open()
                Dim sql As String = "INSERT INTO Usuarios values(@id,@nombre,@contraseña)"
                Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuario)
                Dim posicion = SacarPosicionIdUltimoUsuario()
                cmdUsuarios.Parameters.AddWithValue("@id", posicion + 1)
                cmdUsuarios.Parameters.AddWithValue("@nombre", Nombre)
                cmdUsuarios.Parameters.AddWithValue("@contraseña", Contraseña)
                Dim nreg As Integer = cmdUsuarios.ExecuteNonQuery
                If nreg > 0 Then
                    Dim respuesta As String = ""
                    respuesta = insertarUsuarioPuntuaciones(Nombre)
                    If respuesta = "Exito" Then Return "Exito"
                End If
            Catch ex As Exception
                Return "Se ha producido un error al intentar insertar un nuevo usuario"
            End Try
            Return Nothing
        End Using
    End Function
    'esto cuando el usuario se crea. Se le añade sin puntos porque esos se añaden al final
    Public Function insertarUsuarioPuntuaciones(nombre As String) As String
        Using conSQLUsuario As New OleDbConnection(cadConexion)
            Try
                conSQLUsuario.Open()
                Dim sql As String = "INSERT INTO Puntuaciones values(@Id, @Nombre,@Puntuacion,@Total)"
                Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuario)
                Dim posicion = SacarPosicionIdUltimoUsuario()
                cmdUsuarios.Parameters.AddWithValue("@Nombre", nombre)
                cmdUsuarios.Parameters.AddWithValue("@Puntuacion", "")
                cmdUsuarios.Parameters.AddWithValue("@Total", 0)
                Dim nreg As Integer = cmdUsuarios.ExecuteNonQuery
                If nreg > 0 Then
                    Return "Exito"
                End If
            Catch ex As Exception
                Return "Se ha producido un error al intentar insertar un nuevo usuario en las puntuaciones"
            End Try
        End Using

        Return Nothing
    End Function

    Public Function InsetarNuevoPedido(ByVal pedido As String) As String
        Using conSQLUsuario As New OleDbConnection(cadConexion)
            Try
                conSQLUsuario.Open()
                Dim sql As String = "INSERT INTO Pedidos values(@id,@pedido)"
                Dim cmdPedido As New OleDbCommand(sql, conSQLUsuario)
                Dim posicion = SacarPosicionIdUltimoPedido()
                cmdPedido.Parameters.AddWithValue("@id", posicion + 1)
                cmdPedido.Parameters.AddWithValue("@pedido", pedido)
                Dim nreg As Integer = cmdPedido.ExecuteNonQuery
                If nreg > 0 Then
                    Return "Exito"
                End If
                Return "No se ha añadido nada"
            Catch ex As Exception
                Return "Se ha producido un error al intentar insertar un nuevo usuario"
            End Try
        End Using

    End Function

    Public Function SacarPosicionIdUltimoUsuario() As Integer
        Dim sql As String = "SELECT Max(id) As idMax FROM Usuarios"
        Using conSQLUsuarios As New OleDbConnection(cadConexion)
            Dim cmdUsuario As New OleDbCommand(sql, conSQLUsuarios)
            Try
                conSQLUsuarios.Open()
                Dim dr As OleDbDataReader = cmdUsuario.ExecuteReader
                If dr.Read Then
                    Dim IdMaximo As Integer = dr("idMax")
                    Return IdMaximo
                End If
            Catch ex As Exception
                Return 0
            End Try
        End Using

        Return Nothing
    End Function

    Public Function SacarPosicionIdUltimoPedido() As Integer
        Dim sql As String = "SELECT Max(id) As idMax FROM Pedidos"
        Using conSQL As New OleDbConnection(cadConexion)
            Dim cmdUsuario As New OleDbCommand(sql, conSQL)
            Try
                conSQL.Open()
                Dim dr As OleDbDataReader = cmdUsuario.ExecuteReader
                If dr.Read Then
                    Dim IdMaximo As Integer = dr("idMax")
                    Return IdMaximo
                End If
            Catch ex As Exception
                Return 0
            End Try
        End Using
        Return Nothing
    End Function


    Public Function BorrarPedido(ByVal NumeroPedido As Integer) As String
        Dim sql As String = "DELETE * FROM Pedidos WHERE id = @NumPedido"
        Dim conSQLUsuario As New OleDbConnection(cadConexion)
        Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuario)
        cmdUsuarios.Parameters.AddWithValue("@NumPedido", NumeroPedido)
        Try
            conSQLUsuario.Open()
            Dim nreg As Integer = cmdUsuarios.ExecuteNonQuery()
            If nreg > 0 Then
                Return "El o los pedidos se ha eliminado correctamente"
            End If
        Catch ex As Exception
            Return "ERROR"
        Finally
            conSQLUsuario.Close()
        End Try
        Return Nothing
    End Function

    Public Function BorrarUsuario(ByVal NumeroUsu As Integer) As String
        Dim sql As String = "DELETE * FROM Usuarios WHERE id = @NumUsu"
        Dim conSQLUsuario As New OleDbConnection(cadConexion)
        Dim cmdUsuarios As New OleDbCommand(sql, conSQLUsuario)
        cmdUsuarios.Parameters.AddWithValue("@NumUsu", NumeroUsu)
        Try
            conSQLUsuario.Open()
            Dim nreg As Integer = cmdUsuarios.ExecuteNonQuery()
            If nreg > 0 Then
                Return "El usuario se ha eliminado correctamente"
            End If
        Catch ex As Exception
            Return "ERROR"
        Finally
            conSQLUsuario.Close()
        End Try
        Return Nothing
    End Function

    'PERFECTO
    Public Function DevolverPuntuaciones(ByVal nombre As String) As Puntuacion
        Dim sql As String = "Select * From Puntuaciones where Nombre = @Nombre"
        Dim conSQL As New OleDbConnection(cadConexion)
        Dim cmdPedidos As New OleDbCommand(sql, conSQL)
        cmdPedidos.Parameters.AddWithValue("@Nombre", nombre)
        Dim puntuacionNombre As New Puntuacion
        Try
            conSQL.Open()
            Dim dr As OleDbDataReader = cmdPedidos.ExecuteReader
            If dr.Read Then
                puntuacionNombre.Nombre = dr("Nombre")
                puntuacionNombre.Puntuacion = dr("Puntuacion")
                puntuacionNombre.Total = dr("Total")
            End If
            Return puntuacionNombre
        Catch ex As Exception
            Return Nothing
        Finally
            conSQL.Close()
        End Try
    End Function

    Public Function actualizarPuntuaciones(nombre As String, puntos As Integer) As String
        Dim sql As String = "SELECT puntuacion from Puntuaciones where Nombre = @Nombre"
        Dim total As Integer = 0
        Dim puntitos As String = ""
        Using conSQL As New OleDbConnection(cadConexion)
            Dim cmdPuntos As New OleDbCommand(sql, conSQL)
            cmdPuntos.Parameters.AddWithValue("@Nombre", nombre)

            Try
                conSQL.Open()
                Dim dr As OleDbDataReader = cmdPuntos.ExecuteReader
                If dr.Read Then
                    puntitos = dr("Puntuacion")
                    Dim PuntosSeparados() As String

                    Dim num As Integer

                    PuntosSeparados = puntitos.Split(";")
                    For i = 0 To PuntosSeparados.Count - 1
                        Integer.TryParse(PuntosSeparados(i), num)
                        total += num
                    Next
                End If

            Catch ex As Exception
                Exit Try
            End Try
        End Using

        Dim sql1 As String = "UPDATE Puntuaciones SET Puntuacion = @Puntos, Total = @Total Where Nombre = @Nombre"

        Using conSQL As New OleDbConnection(cadConexion)
            Try
                conSQL.Open()
                Dim cmdPuntos As New OleDbCommand(sql1, conSQL)
                Dim punt As String = puntitos & puntos & ";"
                cmdPuntos.Parameters.AddWithValue("@Puntos", punt)
                cmdPuntos.Parameters.AddWithValue("@Total", total + puntos)
                cmdPuntos.Parameters.AddWithValue("@Nombre", nombre)
                Dim resp As Integer = cmdPuntos.ExecuteNonQuery()
                'no me hace el update, no me escribe en la base de datos
                If resp <= 0 Then
                    Return "ninguna fila afectada"
                End If

            Catch ex As Exception
                Return Nothing
            End Try

        End Using
    End Function
    Public Function cogerPuntuacionPersona(nombre As String) As Puntuacion
        Dim sql As String = "SELECT * from Puntuaciones where Nombre = @Nombre"
        Dim total As Integer = 0
        Dim puntitos As String = ""
        Dim puntos As New Puntuacion
        Using conSQL As New OleDbConnection(cadConexion)
            Dim cmdPuntos As New OleDbCommand(sql, conSQL)
            cmdPuntos.Parameters.AddWithValue("@Nombre", nombre)
            Try
                conSQL.Open()
                Dim dr As OleDbDataReader = cmdPuntos.ExecuteReader
                If dr.Read Then
                    puntos.Nombre = dr("Nombre")
                    puntos.Puntuacion = dr("Puntuacion")
                    puntos.Total = dr("Total")
                End If
            Catch ex As Exception
                Exit Try
            End Try
        End Using

        Return puntos
    End Function


End Class
