Public Class Contacto
    Private Id As Integer
    Private NombreContacto As String
    Private ApellidoContacto As String
    Private TelefonoContacto As String
    Private DireccionContacto As String

    Public Property IdContacto() As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return NombreContacto
        End Get
        Set(value As String)
            NombreContacto = value
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return ApellidoContacto
        End Get
        Set(value As String)
            ApellidoContacto = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return TelefonoContacto
        End Get
        Set(value As String)
            TelefonoContacto = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return DireccionContacto
        End Get
        Set(value As String)
            DireccionContacto = value
        End Set
    End Property

    Public Sub New(ByVal nombre As String, ByVal apellido As String, ByVal telefono As String, ByVal direccion As String)
        MyClass.Nombre = nombre
        MyClass.Apellido = apellido
        MyClass.Telefono = telefono
        MyClass.Direccion = direccion
    End Sub

    Public Sub New(ByVal idContacto As String)
        MyClass.IdContacto = idContacto
    End Sub

    Public Sub New()
    End Sub
End Class
