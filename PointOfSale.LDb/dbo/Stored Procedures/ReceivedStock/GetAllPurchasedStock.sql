CREATE PROCEDURE [dbo].[GetAllPurchasedStock]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [StockinId], [Barcode], [DateReceived], [ReceivedQty], [SubTotal], [UserId], [OrderId]
	FROM [dbo].[StockPurchased]
END