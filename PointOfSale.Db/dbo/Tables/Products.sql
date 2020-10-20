CREATE TABLE [dbo].[Products]
(
	[StockId] INT NOT NULL PRIMARY KEY IDENTITY(10000, 1), 
    [Barcode] NVARCHAR(MAX) NULL, 
    [QtyDescId] INT NULL, 
    [QtyDescription] NVARCHAR(50) NULL, 
    [Brand] NVARCHAR(50) NULL, 
    [Name] NVARCHAR(100) NULL, 
    [StockPrice] MONEY NULL, 
    [RetailPrice] MONEY NULL, 
    [StockInHand] INT NULL, 
    [CategoryId] INT NULL, 
    [SupplierId] INT NULL, 
    [IsTaxable] BIT NULL 
)
