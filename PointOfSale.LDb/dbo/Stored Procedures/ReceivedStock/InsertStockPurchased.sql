CREATE PROCEDURE [dbo].[InsertStockPurchased]
	@Barcode nvarchar(MAX),
	@ReceivedQty int,
	@SubTotal money,
	@UserId int,
	@OrderId int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO StockPurchased (Barcode, ReceivedQty, SubTotal, UserId, OrderId)
	VALUES (@Barcode, @ReceivedQty, @SubTotal, @UserId, @OrderId);
END