CREATE PROCEDURE [dbo].[DeleteStockPurchased]
	@Barcode nvarchar(MAX),
	@ReceivedQty int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Products 
	SET StockInHand = StockInHand - @ReceivedQty
	WHERE Barcode = @Barcode
END