CREATE TABLE Contacto (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    Telefono NVARCHAR(20),
    Correo NVARCHAR(100),
    Categoria NVARCHAR(50)
);