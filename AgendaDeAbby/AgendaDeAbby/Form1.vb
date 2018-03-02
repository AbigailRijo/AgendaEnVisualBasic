Public Class Form1
    Private Sub NuevoContactoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoContactoToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim salir As String = MsgBox("Esta seguro de que quiere salir?", MsgBoxStyle.OkCancel)
        If salir = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaDeContactos As List(Of Contacto) = BuscarContactos()

        For i As Integer = 0 To (listaDeContactos.Count() - 1)
            MsgBox(listaDeContactos(i).Nombre + " " + listaDeContactos(i).Apellido + " " + listaDeContactos(i).Telefono + " " + listaDeContactos(i).Direccion)
        Next i
        End


    End Sub
End Class
