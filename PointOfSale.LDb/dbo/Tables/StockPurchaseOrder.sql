CREATE TABLE [dbo].[StockPurchaseOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1000, 1), 
    [Barcode] NVARCHAR(MAX) NULL, 
    [OrderQuantity] INT NULL, 
    [OrderTotal] MONEY NULL, 
    [Supplier] INT NULL, 
    [OrderDate] DATETIME2 NULL DEFAULT getutcdate(), 
    [Remarks] NVARCHAR(50) NULL
)
