CREATE PROCEDURE [dbo].[GetSalesByDate]
	@fromDate DATETIME2,
	@toDate DATETIME2
AS
BEGIN
	SET NOCOUNT ON;
	SELECT	[SaleId], 
			[CashierId], 
			[InvoiceNumber], 
			[CustomerId], 
			[SaleDate], 
			[SubTotal], 
			[CouponId], 
			[SaleTaxRate], 
			[ShippingRate], 
			[GrandTotal]
      FROM Sale
      WHERE SaleDate BETWEEN @fromDate AND @toDate;
END