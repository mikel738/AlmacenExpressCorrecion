Public Class FormComprobarCantidadProductos
    Private Sub FormComprobarCantidadProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ControlesCantidad As New List(Of String)

        Dim cantidad As Integer = 30

        ControlesCantidad = Module1.nombreProductos
        For i = 0 To ControlesCantidad.Count - 1
            Dim nombreProducto As New Label
            nombreProducto.Text = ControlesCantidad(i)
            nombreProducto.Location = New Point(30, 30 + cantidad)
            PanelPonerCantidadProductos.Controls.Add(nombreProducto)

            Dim introducirCantidad As New TextBox
            introducirCantidad.Location = New Point(180, 30 + cantidad)
            introducirCantidad.Name = "CantidadProductos"
            PanelPonerCantidadProductos.Controls.Add(introducirCantidad)

            cantidad += 60
        Next


    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        Module1.HaSalidoYa = True
        Dim CantidadControles() As Control = {}
        CantidadControles = PanelPonerCantidadProductos.Controls.Find("CantidadProductos", True)
        CantidadProductosQuedan.Clear()

        For Each control As Control In CantidadControles
            Module1.CantidadProductosQuedan.Add(control.Text)
        Next
        Me.Close()
    End Sub
End Class
