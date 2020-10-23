CREATE PROCEDURE [dbo].[ProductToOrder]
	@Barcode nvarchar(MAX)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id ,[p].[Barcode], [p].[Brand], [p].[Name], [p].[StockPrice], [p].[CategoryId], [p].[SupplierId]
	FROM [dbo].[Category] c, 
			[dbo].[Products] p  
	WHERE p.CategoryId=c.Id AND Barcode = @Barcode;
END