USE ProductsByCategories
GO

CREATE TABLE Categories(
CategoryId INT PRIMARY KEY IDENTITY(1,1),
CategoryName VARCHAR(100) NOT NULL
)

CREATE TABLE Products(
ProductId INT PRIMARY KEY IDENTITY(1,1),
ProductName VARCHAR(100) NOT NULL,
CategoryId INT,
CONSTRAINT FK_Products_To_Categories FOREIGN KEY (CategoryId)  REFERENCES Categories (CategoryId)
)

