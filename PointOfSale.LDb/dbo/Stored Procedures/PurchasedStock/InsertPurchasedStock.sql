CREATE PROCEDURE [dbo].[InsertPurchasedStock]
	@Barcode nvarchar(MAX),
	@NewStockQty int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Products 
	SET StockInHand = StockInHand + @NewStockQty
	WHERE Barcode = @Barcode
END