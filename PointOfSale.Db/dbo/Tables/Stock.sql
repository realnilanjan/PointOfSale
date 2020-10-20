CREATE TABLE [dbo].[Stock]
(
	[StockId] INT NOT NULL PRIMARY KEY IDENTITY(1, 1000), 
    [Barcode] NVARCHAR(MAX) NULL, 
    [QuantityDescription] NVARCHAR(10) NULL, 
    [Quantity] INT NULL, 
    [ProductBrand] NVARCHAR(50) NULL, 
    [ProductName] NVARCHAR(50) NULL, 
    [Price] MONEY NULL, 
    [StockInHand] INT NULL, 
    [CategoryId] INT NULL, 
    [SupplierId] INT NULL
)
