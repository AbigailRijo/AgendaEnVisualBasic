Imports System.Data.SqlClient

Module FuncionesDB

    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Private myConn As SqlConnection = New SqlConnection("Initial Catalog=AgendaDB;" & "Data Source=localhost;Integrated Security=SSPI;")

    Public Sub Conectar()
        Try
            myConn.Open()
        Catch exc As Exception
            MsgBox(exc.Message.ToString)
        End Try
    End Sub

    Public Sub Desconectar()
        Try
            myConn.Close()
        Catch exc As Exception
            MsgBox(exc.Message.ToString)
        End Try
    End Sub

    Public Sub GuardarContacto(ByRef contacto As Contacto)
        Conectar()
        myCmd = New SqlCommand()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "insert into Contacto values(' " + contacto.Nombre.ToString + "','" + contacto.Apellido.ToString + "','" + contacto.Telefono.ToString + "','" + contacto.Direccion.ToString + "')"
        Dim result As Integer = myCmd.ExecuteNonQuery()
        If result > 0 Then
            MsgBox("Contacto guardado")
        Else
            MsgBox("No se pudo guardar el cotacto")
        End If
        Desconectar()
    End Sub

    Public Function BuscarContactos()
        Conectar()
        Dim ListaDeContactos As List(Of Contacto) = New List(Of Contacto)
        myCmd = New SqlCommand()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "select * from Contacto"
        myReader = myCmd.ExecuteReader()
        While myReader.Read()
            Dim contacto As New Contacto(myReader(1).ToString, myReader(2).ToString, myReader(3).ToString, myReader(4).ToString)
            ListaDeContactos.Add(contacto)
        End While
        Desconectar()
        Return ListaDeContactos
    End Function
End Module
