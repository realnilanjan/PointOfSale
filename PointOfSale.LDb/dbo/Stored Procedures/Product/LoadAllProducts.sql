CREATE PROCEDURE [dbo].[LoadAllProducts]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [StockId], [Barcode], [QtyDescId], [QtyDescription], [Brand], [Name], [StockPrice], [RetailPrice], [StockInHand], [CategoryId], [SupplierId], [IsTaxable]
	FROM [dbo].[Products]
END