-- 1. Crear base de datos propia para la cafetería
CREATE DATABASE CafeteriaDB;
GO

USE CafeteriaDB;
GO

-- 2. Crear la tabla de productos
CREATE TABLE Productos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Producto NVARCHAR(150) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Categoria NVARCHAR(100) NOT NULL,
    Cantidad INT NOT NULL DEFAULT 0
);
GO

-- 3. Tabla Clientes
CREATE TABLE Clientes (
    Id_cliente INT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Telefono VARCHAR(20) NOT NULL,
    Direccion VARCHAR(150) NULL
);
GO

-- 4. Tabla Pedidos
CREATE TABLE Pedidos (
    Id_pedido INT PRIMARY KEY,
    Id_cliente INT NOT NULL FOREIGN KEY REFERENCES Clientes(Id_cliente),
    Fecha_pedido DATE NOT NULL,
    Estado_pedido VARCHAR(20) NOT NULL
);
GO

-- 5 Tabla Detalle_Pedido
CREATE TABLE Detalle_Pedido (
    Id_detalle INT PRIMARY KEY,
    Id_pedido INT NOT NULL FOREIGN KEY REFERENCES Pedidos(Id_pedido),
    Id_producto INT NOT NULL FOREIGN KEY REFERENCES Productos(Id),
    Cantidad INT NOT NULL,
    Precio_unitario DECIMAL(10,2) NOT NULL
);
GO

-- 6 Tabla Pagos
CREATE TABLE Pagos (
    Id_pago INT PRIMARY KEY,
    Id_pedido INT NOT NULL FOREIGN KEY REFERENCES Pedidos(Id_pedido),
    Monto_pagado DECIMAL(10,2) NOT NULL,
    Fecha_pago DATE NOT NULL,
    Metodo_pago VARCHAR(30) NOT NULL
);
GO

-----
--6. Script DML: Inserción de Datos del Sistema de la Cafetería 
----

-- 1. Clientes
INSERT INTO Clientes (Id_cliente, Nombre, Apellido, Telefono, Direccion) VALUES 
(1, 'Maria', 'Gómez', '7555-1234', 'Av. Las Flores #123'),
(2, 'Carlos', 'Perez', '7555-5678', 'Calle Principal #45'),
(3, 'Sofia', 'Rodriguez', '7555-9012', 'Col. Centro, Casa #8'),
(4, 'Luis', 'Martinez', '7555-3456', 'Residencial Los Pinos #12'),
(5, 'Elena', 'Torres', '7555-7890', 'Blvd. El Sol #78');
GO

-- 2. Productos
INSERT INTO Productos (Id, producto, Categoria, Precio, Cantidad) VALUES 
(1, 'Café Capuchino Gourmet 12oz', 'Bebidas Calientes', 3.50, 25),
(2, 'Cheesecake de Frutos Rojos', 'Repostería', 4.25, 10),
(3, 'Sandwich Club Pollo/Aguacate', 'Snacks/Almuerzos', 5.50, 15),
(4, 'Frappé Moca Organico 16oz', 'Bebidas Frías', 4.00, 23),
(5, 'Muffin de Arándanos Artesanal', 'Repostería', 2.50, 30);
GO

-- 3. Pedidos
INSERT INTO Pedidos (Id_pedido, Id_cliente, Fecha_pedido, Estado_pedido) VALUES 
(1, 1, '2026-03-01', 'Entregado'),
(2, 2, '2026-03-05', 'Pendiente'),
(3, 3, '2026-03-10', 'Entregado'),
(4, 4, '2026-03-12', 'Pendiente'),
(5, 5, '2026-03-15', 'Cancelado');
GO

-- 4. Detalle_Pedido
INSERT INTO Detalle_Pedido (Id_detalle, Id_pedido, Id_producto, Cantidad, Precio_unitario) VALUES 
(1, 1, 1, 2, 3.50),
(2, 1, 2, 1, 4.25),
(3, 2, 3, 1, 5.50),
(4, 3, 4, 2, 4.00),
(5, 3, 5, 1, 2.50),
(6, 4, 1, 1, 3.50),
(7, 4, 5, 1, 2.50),
(8, 5, 2, 2, 4.25);
GO

-- 5. Pagos
INSERT INTO Pagos (Id_pago, Id_pedido, Monto_pagado, Fecha_pago, Metodo_pago) VALUES 
(1, 1, 11.25, '2026-03-01', 'Tarjeta'),
(2, 2, 3.00, '2026-03-05', 'Efectivo'),
(3, 3, 10.50, '2026-03-10', 'Efectivo'),
(4, 4, 4.00, '2026-03-12', 'Transferencia');
GO
------
--7. Verificación de Carga y Registros en SQL Server 
-------

 SELECT COUNT(*) FROM Clientes;
 SELECT COUNT(*) FROM Productos;
 SELECT COUNT(*) FROM Pedidos;
 SELECT COUNT(*) FROM Detalle_Pedido; 
 SELECT COUNT(*) FROM Pagos;

 --
 --8. Solución de Objetos: Procedimientos Almacenados (SPs) 
--

-- SP 1 Registrar pago validando existencia del pedido
CREATE PROCEDURE sp_RegistrarPago
    @p_Id_pago INT,
    @p_Id_pedido INT,
    @p_Monto_pagado DECIMAL(10,2),
    @p_Fecha_pago DATE,
    @p_Metodo_pago VARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM Pedidos WHERE Id_pedido = @p_Id_pedido)
    BEGIN
        INSERT INTO Pagos (Id_pago, Id_pedido, Monto_pagado, Fecha_pago, Metodo_pago)
        VALUES (@p_Id_pago, @p_Id_pedido, @p_Monto_pagado, @p_Fecha_pago, @p_Metodo_pago);
        PRINT 'Pago registrado correctamente en el sistema de la cafetería.';
    END
    ELSE
    BEGIN
        RAISERROR('Error: El código de pedido no existe en el sistema.', 16, 1);
    END
END;
GO

--- Prueba SP 1 
EXEC sp_RegistrarPago 
    @p_Id_pago = 5, 
    @p_Id_pedido = 2, 
    @p_Monto_pagado = 2.50, 
    @p_Fecha_pago = '2026-03-20', 
    @p_Metodo_pago = 'Efectivo';

-- SP 2 Obtener pedidos por cliente
CREATE PROCEDURE sp_ObtenerPedidosPorCliente
    @p_Id_cliente INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT Id_pedido, Fecha_pedido, Estado_pedido
    FROM Pedidos
    WHERE Id_cliente = @p_Id_cliente;
END;
GO

---Prueba SP 2
EXEC sp_ObtenerPedidosPorCliente @p_Id_cliente = 1;