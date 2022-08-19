CREATE PROCEDURE [dbo].[UpdateSoldProduct]
	@ProductId INT,
	@Quantity INT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [Products]
	SET StockInHand = StockInHand - @Quantity
	WHERE StockId = @ProductId;
END