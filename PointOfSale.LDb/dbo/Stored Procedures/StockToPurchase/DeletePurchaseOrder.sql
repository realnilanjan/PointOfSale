CREATE PROCEDURE [dbo].[DeletePurchaseOrder]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM [dbo].[StockPurchaseOrder]
	WHERE Id=@Id;
END