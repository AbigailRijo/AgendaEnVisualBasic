Public Class Form2
    Dim Nombre As String
    Dim Apellido As String
    Dim Telefono As String
    Dim Direccion As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "") Then
            Nombre = TextBox1.Text
            Apellido = TextBox2.Text
            Telefono = TextBox4.Text
            Direccion = TextBox3.Text

            Dim contacto As New Contacto(Nombre, Apellido, Telefono, Direccion)
            GuardarContacto(contacto)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            TextBox3.Text = ""
        Else
            MsgBox("Debe llenar todos los campos")
        End If

    End Sub
End Class