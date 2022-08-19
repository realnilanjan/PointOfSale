CREATE PROCEDURE [dbo].[LoadPurchasedStock]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [StockinId], [Barcode], [DateReceived], [ReceivedQty], [SubTotal], [UserId], [OrderId]
	FROM [dbo].[StockPurchased]
END