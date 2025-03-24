CREATE TABLE Personas (
    IdPersona INT IDENTITY(1,1) PRIMARY KEY, -- Identificador único de la persona
    Nombre NVARCHAR(100) NOT NULL, -- Nombre de la persona
    Apellido NVARCHAR(100) NOT NULL, -- Apellido de la persona
    Email NVARCHAR(150) UNIQUE NOT NULL, -- Correo electrónico único
    FechaNacimiento DATE NOT NULL, -- Fecha de nacimiento de la persona
    Telefono NVARCHAR(15), -- Teléfono de la persona

    -- Campos de auditoría
    AdicionadoPor NVARCHAR(100) NOT NULL, -- Usuario que agregó el registro
    FechaAdicion DATETIME DEFAULT GETDATE(), -- Fecha en que se agregó el registro
    ModificadoPor NVARCHAR(100), -- Usuario que modificó el registro
    FechaModificacion DATETIME -- Fecha de última modificación
);

