CREATE PROCEDURE [dbo].[GetProductForCart]
	@Barcode nvarchar(MAX)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [StockId], [Barcode], [Name], [RetailPrice], [IsTaxable]
	FROM [dbo].[Products]
	WHERE StockInHand > 0 AND Barcode = @Barcode;
END