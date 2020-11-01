CREATE TABLE [dbo].[Transaction]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SaleId] INT NULL, 
    [CashierId] NCHAR(10) NULL, 
    [TotalAmount] MONEY NULL, 
    [CardDigits] NVARCHAR(10) NULL DEFAULT 0, 
    [CardType] NVARCHAR(10) NULL, 
    [DateCreated] DATETIME2 NULL
)
