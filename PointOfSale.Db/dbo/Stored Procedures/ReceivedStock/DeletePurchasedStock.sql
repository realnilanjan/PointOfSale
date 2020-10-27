CREATE PROCEDURE [dbo].[DeletePurchasedStock]
	@StockinId int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM [dbo].[StockPurchased]
	WHERE StockinId=@StockinId;
	
END