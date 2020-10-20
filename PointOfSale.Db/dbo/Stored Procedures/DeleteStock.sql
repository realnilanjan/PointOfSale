CREATE PROCEDURE [dbo].[DeleteStock]
	@StockId int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM [dbo].[Products]
	WHERE StockId=@StockId;
END