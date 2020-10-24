CREATE PROCEDURE [dbo].[GetAllPurchaseOrders]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Id], [Barcode], [OrderQuantity], [OrderTotal], [Supplier], [OrderDate], [Remarks]
	FROM [dbo].[StockPurchaseOrder]
END