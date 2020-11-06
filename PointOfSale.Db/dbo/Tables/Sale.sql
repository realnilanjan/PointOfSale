CREATE TABLE [dbo].[Sale]
(
	[SaleId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CashierId] INT NOT NULL, 
    [InvoiceNumber] NVARCHAR(50) NOT NULL, 
    [CustomerId] INT NOT NULL DEFAULT 0, 
    [SaleDate] DATETIME2 NOT NULL , 
    [SubTotal] MONEY NOT NULL, 
    [CouponId] INt NOT NULL, 
    [DiscountApplied] MONEY NOT NULL, 
    [SaleTaxRate] MONEY NOT NULL, 
    [ShippingRate] MONEY NOT NULL DEFAULT 0, 
    [GrandTotal] MONEY NOT NULL 

)
