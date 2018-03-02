Create database AgendaDB
Go 
Use AgendaDB
Go
Create table Contacto(
	IdContacto int identity(0,1) primary key,
	Nombre varchar(30),
	Apellido Varchar(60),
	Telefono varchar(20),
	Direccion varchar(50)
)

Go
Create table ImagenContacto(
	IdImagen int identity(0,1) primary key,
	NombreImagen varchar(100),
	IdContacto int foreign key references Contacto(IdContacto)
)

Go
Create table Usuario(
	IdUsuario int primary key,
	Correo varchar(30),
	Contrasenia varchar(30)
)