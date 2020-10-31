CREATE TABLE [dbo].[Sale]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CashierId] INT NOT NULL, 
    [InvoiceNumber] NVARCHAR(50) NOT NULL, 
    [SaleDate] DATETIME2 NOT NULL , 
    [SubTotal] MONEY NOT NULL, 
    [CouponId] INT NOT NULL, 
    [SaleTaxRate] MONEY NOT NULL, 
    [ShippingRate] MONEY NOT NULL DEFAULT 0, 
    [GrandTotal] MONEY NOT NULL 

)
