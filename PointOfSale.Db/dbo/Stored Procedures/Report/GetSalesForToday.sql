CREATE PROCEDURE [dbo].[GetSalesForToday] 
AS 
BEGIN
 SET NOCOUNT ON;
	SELECT 
		--SUM([SubTotal]) AS 'Total Subtotal', 
		--SUM([SaleTaxRate]) AS 'Total Tax', 
		SUM([GrandTotal]) AS 'Grand Total'
	FROM [Sale]
	WHERE [SaleDate] >= CONVERT(DateTime, DATEDIFF(DAY, 0, GETDATE()));
END