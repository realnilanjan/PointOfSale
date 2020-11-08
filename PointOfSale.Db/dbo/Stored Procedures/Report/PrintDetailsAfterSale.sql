CREATE PROCEDURE [dbo].[PrintDetailsAfterSale]
	@SaleId INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
	Products.[Name],
	SaleDetail.Quantity,
	SaleDetail.PurchasePrice,
	SaleDetail.Tax
FROM
	(([SaleDetail]
	INNER JOIN
	[Products] ON
	[SaleDetail].ProductId = [Products].StockId)
	INNER JOIN
	Sale ON
	Sale.SaleId = SaleDetail.SaleId)
WHERE 
	[SaleDetail].SaleId = @SaleId
END