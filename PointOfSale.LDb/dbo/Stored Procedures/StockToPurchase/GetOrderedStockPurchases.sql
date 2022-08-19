CREATE PROCEDURE [dbo].[GetOrderedStockPurchases]
	@Barcode nvarchar(MAX)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Id], [Barcode], [OrderQuantity], [OrderTotal], [Supplier], [OrderDate], [Remarks]
	FROM [dbo].[StockPurchaseOrder]
	WHERE Remarks = 'Ordered' AND Barcode = @Barcode
END