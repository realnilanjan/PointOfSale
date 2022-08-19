CREATE PROCEDURE [dbo].[InsertStockPurchaseOrder]
	@Barcode nvarchar(MAX),
	@OrderQuantity int,
	@OrderTotal money,
	@Supplier int,
	@Remarks nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[StockPurchaseOrder] (Barcode, OrderQuantity, OrderTotal, Supplier, Remarks)
	VALUES (@Barcode, @OrderQuantity, @OrderTotal, @Supplier, @Remarks);
END