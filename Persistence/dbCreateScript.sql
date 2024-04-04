CREATE DATABASE SimpleCrudAppDB;
GO


USE SimpleCrudAppDB;
GO


CREATE TABLE [Orders] (
    id INT IDENTITY PRIMARY KEY,
    ClientName VARCHAR(60),
    ClientEmail VARCHAR(60),
    CreationDate DATETIME,
    Paid BIT
);
GO


INSERT INTO [Orders] (ClientName, ClientEmail, CreationDate, Paid)
VALUES 
    ('Client 01', 'client01@example.com', GETDATE(), 1),
    ('Client 02', 'client02@example.com', GETDATE(), 0),
    ('Client 03', 'client03@example.com', GETDATE(), 1),
    ('Client 04', 'client04@example.com', GETDATE(), 0),
    ('Client 05', 'client05@example.com', GETDATE(), 1),
    ('Client 06', 'client06@example.com', GETDATE(), 0),
    ('Client 07', 'client07@example.com', GETDATE(), 1),
    ('Client 08', 'client08@example.com', GETDATE(), 0),
    ('Client 09', 'client09@example.com', GETDATE(), 1),
    ('Client 10', 'client10@example.com', GETDATE(), 0);
GO


CREATE TABLE Products (
    Id INT IDENTITY PRIMARY KEY,
    ProductName VARCHAR(20),
    Value DECIMAL(10, 2)
);
GO


INSERT INTO Products (ProductName, Value)
VALUES 
    ('Product 01', 10.99),
    ('Product 02', 15.50),
    ('Product 03', 20.00),
    ('Product 04', 8.75),
    ('Product 05', 12.49),
    ('Product 06', 18.99),
    ('Product 07', 9.99),
    ('Product 08', 14.00),
    ('Product 09', 22.75),
    ('Product 10', 16.49);
GO


CREATE TABLE OrdersProducts (
    id INT IDENTITY PRIMARY KEY,
    OrderId INT,
    ProductId INT,
    Quantity INT,
    FOREIGN KEY (OrderId) REFERENCES [Orders](id),
    FOREIGN KEY (ProductId) REFERENCES Products(Id)
);
GO

INSERT INTO OrdersProducts (OrderId, ProductId, Quantity)
VALUES 
    (1, 1, 2),
    (1, 2, 1),
    (2, 3, 3),
    (3, 1, 1),
    (3, 3, 2),
    (4, 2, 1),
    (5, 1, 2),
    (5, 3, 1),
    (6, 1, 3),
    (7, 2, 2);
GO
