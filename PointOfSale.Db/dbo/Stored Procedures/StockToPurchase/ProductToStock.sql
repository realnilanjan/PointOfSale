CREATE PROCEDURE [dbo].[ProductToStock]
	@Barcode nvarchar(MAX)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Brand], [Name], [StockPrice], [CategoryId], [SupplierId]
	FROM Products  
	WHERE Barcode = @Barcode
END