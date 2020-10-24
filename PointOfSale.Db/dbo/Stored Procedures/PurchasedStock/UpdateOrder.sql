CREATE PROCEDURE [dbo].[UpdateOrder]
	@OrderId int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE StockPurchaseOrder
	SET Remarks = 'Settled'
	WHERE Id=@OrderId
END