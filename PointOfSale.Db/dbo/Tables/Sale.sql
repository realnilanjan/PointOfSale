CREATE TABLE [dbo].[Sale]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CashierId] INT NOT NULL, 
    [InvoiceNumber] NVARCHAR(50) NOT NULL, 
    [SaleDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [SubTotal] MONEY NOT NULL, 
    [CouponId] INT NOT NULL, 
    [SaleTaxRate] MONEY NOT NULL, 
    [ShippingRate] MONEY NOT NULL DEFAULT 0, 
    [GrandTotal] MONEY NOT NULL, 
    CONSTRAINT [FK_Sale_ToUser] FOREIGN KEY ([CashierId]) REFERENCES [User]([UserId]), 
    CONSTRAINT [FK_Sale_ToCoupon] FOREIGN KEY ([CouponId]) REFERENCES [Coupons]([Id]) 

)
