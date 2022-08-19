CREATE PROCEDURE [dbo].[GetAllSales]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT	[SaleId], 
			[User].Fullname AS 'CashierName', 
			[InvoiceNumber], 
			[CustomerId], 
			[SaleDate], 
			[SubTotal], 
			[CouponId], 
			[SaleTaxRate], 
			[ShippingRate], 
			[GrandTotal]
      FROM Sale
	  LEFT OUTER JOIN
	  [User] ON
	  Sale.CashierId = [User].UserId
	  ORDER BY Sale.SaleDate;
END