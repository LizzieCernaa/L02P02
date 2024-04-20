CREATE DATABASE libreriaDb
GO

USE libreriaDb
GO

CREATE TABLE [clientes] (
  [id] integer PRIMARY KEY,
  [nombre] nvarchar(255),
  [apellido] nvarchar(255),
  [email] nvarchar(255),
  [direccion] nvarchar(255),
  [created_at] timestamp
)
GO

CREATE TABLE [autores] (
  [id] integer PRIMARY KEY,
  [autor] varchar(200)
)
GO

CREATE TABLE [categorias] (
  [id] integer PRIMARY KEY,
  [categoria] varchar(200)
)
GO

CREATE TABLE [libros] (
  [id] integer PRIMARY KEY,
  [nombre] nvarchar(255),
  [descripcion] nvarchar(255),
  [url_imagen] nvarchar(255),
  [id_autor] integer,
  [id_categoria] integer,
  [precio] decimal(18,2),
  [estado] char(1)
)
GO

CREATE TABLE [pedido_encabezado] (
  [id] integer PRIMARY KEY,
  [id_cliente] integer,
  [cantidad_libros] integer,
  [total] decimal(18,2),
  [estado] char(1)
)
GO

CREATE TABLE [pedido_detalle] (
  [id] integer PRIMARY KEY,
  [id_pedido] integer,
  [id_libro] integer,
  [created_at] timestamp
)
GO

CREATE TABLE [comentarios_libros] (
  [id] integer PRIMARY KEY,
  [id_libro] integer,
  [comentarios] varchar(max),
  [usuario] varchar(50),
  [created_at] timestamp
)
GO

ALTER TABLE [pedido_encabezado] ADD FOREIGN KEY ([id_cliente]) REFERENCES [clientes] ([id])
GO

ALTER TABLE [pedido_detalle] ADD FOREIGN KEY ([id_pedido]) REFERENCES [pedido_encabezado] ([id])
GO

ALTER TABLE [pedido_detalle] ADD FOREIGN KEY ([id_libro]) REFERENCES [libros] ([id])
GO

ALTER TABLE [libros] ADD FOREIGN KEY ([id_autor]) REFERENCES [autores] ([id])
GO

ALTER TABLE [comentarios_libros] ADD FOREIGN KEY ([id_libro]) REFERENCES [libros] ([id])
GO

ALTER TABLE [libros] ADD FOREIGN KEY ([id_categoria]) REFERENCES [categorias] ([id])
GO
