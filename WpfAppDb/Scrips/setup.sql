-- Crear base de datos
CREATE DATABASE [TuBaseDeDatos];
GO

-- Usar base de datos
USE [TuBaseDeDatos];
GO

-- Crear tabla Category
CREATE TABLE [Categories] (
    [Id] INT IDENTITY(1,1) NOT NULL,
    [Name] NVARCHAR(255) NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id])
);
GO

-- Crear tabla Items
CREATE TABLE [Items] (
    [Id] INT IDENTITY(1,1) NOT NULL,
    [Name] NVARCHAR(255) NULL,
    [Description] NVARCHAR(MAX) NULL,
    [ImageUri] NVARCHAR(MAX) NULL,
    [CategoryId] INT NULL,
    CONSTRAINT [PK_Items] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Items_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([Id])
);
GO

-- Insertar datos en tabla Category
INSERT INTO [Categories] ([Name]) VALUES ('Cosas');
INSERT INTO [Categories] ([Name]) VALUES ('Más cosas');

-- Insertar datos en tabla Items
INSERT INTO [Items] ([Name], [Description], [ImageUri], [CategoryId]) VALUES ('Cosa 1', 'Descripción de la cosa.', 'https://i.pickadummy.com/index.php?imgsize=600x400', 1);
INSERT INTO [Items] ([Name], [Description], [ImageUri], [CategoryId]) VALUES ('Cosa 2', 'Descripción de la cosa.', 'https://i.pickadummy.com/index.php?imgsize=600x400', 2);
INSERT INTO [Items] ([Name], [Description], [ImageUri], [CategoryId]) VALUES ('Cosa 3', 'Descripción de la cosa.', 'https://i.pickadummy.com/index.php?imgsize=600x400', 1);
INSERT INTO [Items] ([Name], [Description], [ImageUri], [CategoryId]) VALUES ('Cosa 4', 'Descripción de la cosa.', 'https://i.pickadummy.com/index.php?imgsize=600x400', 2);
INSERT INTO [Items] ([Name], [Description], [ImageUri], [CategoryId]) VALUES ('Cosa 5', 'Descripción de la cosa.', 'https://i.pickadummy.com/index.php?imgsize=600x400', 1);
