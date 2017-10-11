Imports Entidaddes

Public Class Pedido : Implements IEquatable(Of Pedido)

    Public Property id As Integer
    Public Property pedido As String

    Public Overloads Function Equals(other As Pedido) As Boolean Implements IEquatable(Of Pedido).Equals
        Return Not IsNothing(other) AndAlso Me.pedido = other.pedido
    End Function
End Class
