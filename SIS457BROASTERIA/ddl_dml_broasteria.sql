
CREATE DATABASE LabBroasteria
GO
USE [master]
GO
CREATE LOGIN [usrbroasteria] WITH PASSWORD = N'123456',
	DEFAULT_DATABASE = [LabBroasteria],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = ON
GO
USE [LabBroasteria]
GO
CREATE USER [usrbroasteria] FOR LOGIN [usrbroasteria]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrbroasteria]
GO

DROP TABLE Empleado;
DROP TABLE Proveedor;
DROP TABLE Cliente;
DROP TABLE Usuario;
DROP TABLE Compra;
DROP TABLE Categoria;
DROP TABLE Producto;
DROP TABLE DetalleCompra;
DROP TABLE Venta;
DROP TABLE DetalleVenta;
DROP TABLE HistorialCompra;
DROP TABLE HistorialVenta;



CREATE TABLE Empleado(
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(12) NOT NULL,
  nombres VARCHAR(30) NOT NULL,
  primerApellido VARCHAR(30) NULL,
  segundoApellido VARCHAR(30) NULL,
  direccion VARCHAR(250) NOT NULL,
  celular BIGINT NOT NULL,
  cargo VARCHAR(50) NOT NULL
);

CREATE TABLE Proveedor (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  documento VARCHAR(50) NOT NULL,
  razonSocial VARCHAR(50) NOT NULL,
  email VARCHAR(20) NOT NULL,
  telefono VARCHAR(8) NOT NULL,
);  

CREATE TABLE Cliente (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  documento VARCHAR(50) NOT NULL,
  nombreCompleto VARCHAR(50) NOT NULL,
  email VARCHAR(20) NOT NULL,
  telefono VARCHAR(8) NOT NULL,
); 

CREATE TABLE Usuario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idEmpleado INT NOT NULL,
  usuario VARCHAR(15) NOT NULL,
  clave VARCHAR(250) NOT NULL,
  CONSTRAINT fk_Usuario_Empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado(id)
); 

CREATE TABLE Compra (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idUsuario INT NOT NULL,
  idProveedor INT NOT NULL,
  tipoDocumento VARCHAR(50) NOT NULL,
  numeroDocumento VARCHAR(50) NOT NULL,
  montoTotal DECIMAL(10,2) NOT NULL,
  CONSTRAINT fk_Compra_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuario(id),
  CONSTRAINT fk_Compra_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor(id)
); 

CREATE TABLE Categoria (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  descripcion VARCHAR(100) NOT NULL,
);

CREATE TABLE Producto (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCategoria INT NOT NULL,
  codigo VARCHAR(50) NOT NULL,
  nombre VARCHAR(50) NOT NULL,
  descripcion VARCHAR(100) NOT NULL,
  stock INT NOT NULL DEFAULT 0,
  precioVenta DECIMAL(10,2) DEFAULT 0,
  CONSTRAINT fk_Producto_Categoria FOREIGN KEY (idCategoria) REFERENCES Categoria(id)
);


CREATE TABLE DetalleCompra (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCompra INT NOT NULL,
  idProducto INT NOT NULL,
  precioCompra DECIMAL(10,2) DEFAULT 0,
  precioVenta DECIMAL(10,2) DEFAULT 0,
  cantidad INT NOT NULL,
  total DECIMAL(10,2) NOT NULL,
  CONSTRAINT fk_DetalleCompra_Compra FOREIGN KEY (idCompra) REFERENCES Compra(id),
  CONSTRAINT fk_DetalleCompra_Producto FOREIGN KEY (idProducto) REFERENCES Producto(id)
); 

CREATE TABLE Venta (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idUsuario INT NOT NULL,
  tipoDocumento VARCHAR(50) NOT NULL,
  numeroDocumento VARCHAR(50) NOT NULL,
  documentoCliente VARCHAR(50) NOT NULL,
  nombreCliente VARCHAR(100) NOT NULL,
  montoPago DECIMAL(10,2) NOT NULL,
  montoCambio DECIMAL(10,2) NOT NULL,
  montoTotal DECIMAL(10,2) NOT NULL,
  CONSTRAINT fk_Venta_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuario(id)
); 

CREATE TABLE DetalleVenta (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idVenta INT NOT NULL,
  idProducto INT NOT NULL,
  precioVenta DECIMAL(10,2),
  cantidad INT NOT NULL,
  subTotal DECIMAL(10,2) NOT NULL,
  CONSTRAINT fk_DetalleVenta_Venta FOREIGN KEY (idVenta) REFERENCES Venta(id),
  CONSTRAINT fk_DetalleVenta_Producto FOREIGN KEY (idProducto) REFERENCES Producto(id)
); 

CREATE TABLE HistorialCompra (
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    idProducto INT NOT NULL,
    precioCompra DECIMAL(10,2) NOT NULL,
    precioVenta DECIMAL(10,2) NOT NULL,
    cantidad INT NOT NULL,
    CONSTRAINT fk_HistorialCompra_Producto FOREIGN KEY (idProducto) REFERENCES Producto(id)
);

CREATE TABLE HistorialVenta (
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    idProducto INT NOT NULL,
    precioVenta DECIMAL(10,2) NOT NULL,
    cantidad INT NOT NULL,
    CONSTRAINT fk_HistorialVenta_Producto FOREIGN KEY (idProducto) REFERENCES Producto(id)
);

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Proveedor ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Cliente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cliente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cliente ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Compra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Compra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Compra ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Categoria ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Categoria ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Categoria ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE DetalleCompra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE DetalleCompra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE DetalleCompra ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Venta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Venta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Venta ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE DetalleVenta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE DetalleVenta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE DetalleVenta ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE HistorialCompra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE HistorialCompra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE HistorialCompra ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE HistorialVenta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE HistorialVenta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE HistorialVenta ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

-- DATOS CLIENTE
INSERT INTO Cliente(documento, nombreCompleto, email, telefono)
VALUES ('12674985','ManueL Prado', 'manuelopra@gmail.com', '74561256' );
INSERT INTO Cliente(documento, nombreCompleto, email, telefono)
VALUES ('14859748','Marcos Terraza', 'marcos@gmail.com', '74215841' );
INSERT INTO Cliente(documento, nombreCompleto, email, telefono)
VALUES ('15421525','Sebastian Garza', 'garza@gmail.com', '78454544' );
GO

SELECT * FROM CLIENTE

-- DATOS PROVEEDOR
INSERT INTO Proveedor(documento, razonSocial, email, telefono)
VALUES ('14585441','compra soda','javier@gmail.com','72584703');
INSERT INTO Proveedor(documento, razonSocial, email, telefono)
VALUES ('14581441','compra pollo','sergio@gmail.com','67785942');
INSERT INTO Proveedor(documento, razonSocial, email, telefono)
VALUES ('12457896','compra arroz','fabio@gmail.com','15154545');


SELECT * FROM PROVEEDOR
-- DATOS CATEGORIA
INSERT INTO Categoria(descripcion)
VALUES('Pollo'),
('Hamburguesa'),
('Sodas'),
('Refresco');

SELECT * FROM CATEGORIA

-- DATOS PRODUCTO
SELECT*FROM Producto
  INSERT INTO Producto(codigo,idCategoria, nombre, descripcion, stock, precioVenta)
  VALUES('Pl1',1, 'Pollo Broaster','Cuarto de pollo',50,15),
  ('Ha2',2, 'Hamburguesa ','Simple',20,10),
  ('So3',3, 'Soda Coca Cola','2 litros',50,12)
  GO

  --PROCEDIMIENTO LISTAR CATEGORIA
CREATE PROC paCategoriaListar @parametro VARCHAR(100)
AS
  SELECT * FROM Categoria
  WHERE estado<>-1 AND descripcion LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
GO
  EXEC paCategoriaListar 'Poll';
  GO

   --PROCEDIMIENTO LISTAR PRODUCTOS
CREATE PROC paProductoListar @parametro VARCHAR(100)
AS
  SELECT * FROM Producto
  WHERE estado<>-1 AND nombre LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
GO
  EXEC paProductoListar 'soda';
  GO

  --PROCEDIMIENTO LISTAR CLIENTES
CREATE PROC paClienteListar
    @parametro VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM Cliente
    WHERE estado <> -1 AND (
        documento LIKE '%' + REPLACE(@parametro, ' ', '%') + '%' OR
        nombreCompleto LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    );
END
GO
EXEC paClienteListar 'garza';
GO

--DATOS EMPLEADO
INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES('7246542','Sebastian ','Gironda', 'Carrasco', 'Eduardo Berdecio', 71451412, 'cajero');

--DATOS USUARIO
INSERT INTO Usuario(idEmpleado, usuario, clave)
VALUES(1, 'gironda', 'i0hcoO/nssY6WOs9pOp5Xw==');



