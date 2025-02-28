scripts
CREATE DATABASE ReservasDB;
GO

-- Usar la base de datos
USE ReservasDB;
GO

-- Crear tabla de Usuarios
CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    Telefono NVARCHAR(20),
    Contrasena NVARCHAR(100) NOT NULL,
    Rol NVARCHAR(20) NOT NULL -- Cliente o Empleado
);

-- Crear tabla de Sucursales
CREATE TABLE Sucursales (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Direccion NVARCHAR(200),
    Telefono NVARCHAR(20),
    Administrador NVARCHAR(100),
    NumeroEspacios INT
);

-- Crear tabla de Espacios de Parqueo
CREATE TABLE EspaciosParqueo (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Numero INT NOT NULL,
    Ubicacion NVARCHAR(100),
    CostoPorHora DECIMAL(10,2),
    Estado NVARCHAR(20), -- Disponible u Ocupado
    SucursalId INT,
    FOREIGN KEY (SucursalId) REFERENCES Sucursales(Id)
);

-- Crear tabla de Reservas
CREATE TABLE Reservas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioId INT,
    EspacioParqueoId INT,
    Fecha DATE,
    Hora TIME,
    CantidadHoras INT,
    FOREIGN KEY (UsuarioId) REFERENCES Users(Id),
    FOREIGN KEY (EspacioParqueoId) REFERENCES EspaciosParqueo(Id)
);
