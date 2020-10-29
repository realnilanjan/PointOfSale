CREATE TABLE [dbo].[Coupons]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CouponCode] NVARCHAR(10) NOT NULL, 
    [CouponDescription] NVARCHAR(100) NOT NULL, 
    [IssueDate] DATETIME2 NOT NULL , 
    [ExpiryDate] DATETIME2 NOT NULL, 
    [IsFlatRate] BIT NOT NULL DEFAULT 1, 
    [IsPercentDiscount] BIT NOT NULL DEFAULT 0, 
    [CouponAmount] DECIMAL NOT NULL, 
    [IsUsed] BIT NOT NULL DEFAULT 0 
)
