CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Category NVARCHAR(100) NOT NULL,
    Price DECIMAL(18, 2) NOT NULL
);


INSERT INTO Products (Name, Category, Price) VALUES

('Product 5', 'Cat', 10.99);

DROP TABLE Products;

SELECT * FROM Products;

INSERT INTO Products (Name, Category, Price)
VALUES 
('Product A', 'Category 1', 19.99),
('Product B', 'Category 2', 29.99),
('Product C', 'Category 1', 39.99);

