CREATE PROCEDURE [dbo].[GetSalesForToday]
	@SaleDate NVARCHAR(20)
AS
BEGIN
 SET NOCOUNT ON;
	SELECT SUM([SubTotal]) AS 'TotalSubtotal', SUM([SaleTaxRate]) AS 'TotalTax', SUM([GrandTotal]) AS 'GrandTotal'
	FROM [Sale]
	WHERE [SaleDate] >= DATEADD(MS,-1,CAST(DATEADD(DD,1,@SaleDate) AS DATETIME2));
END