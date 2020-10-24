CREATE PROCEDURE [dbo].[DeleteProduct]
	@StockId int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM [dbo].[Products]
	WHERE StockId=@StockId;
END