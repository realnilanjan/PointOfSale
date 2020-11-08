CREATE PROCEDURE [dbo].[GetSalesForToday] 
AS 
BEGIN
 SET NOCOUNT ON;
	SELECT
		SUM([GrandTotal]) AS 'Grand Total'
	FROM [Sale]
	WHERE [SaleDate] >= CONVERT(DateTime, DATEDIFF(DAY, 0, GETDATE()));
END

SELECT [SaleId], [CashierId], [InvoiceNumber], [CustomerId], [SaleDate], [SubTotal], [CouponId], [SaleTaxRate], [ShippingRate], [GrandTotal]
FROM Sale s WHERE s.SaleDate BETWEEN '2020-11-05 00:00:00' AND '2020-11-06 00:00:00'