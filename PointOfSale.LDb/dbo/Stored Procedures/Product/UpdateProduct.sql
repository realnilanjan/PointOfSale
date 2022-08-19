CREATE PROCEDURE [dbo].[UpdateProduct]
	@StockId int,
	@Barcode nvarchar(MAX),
	@QtyDescId int,
	@QtyDescription nvarchar(50),
	@Brand nvarchar(50),
	@Name nvarchar(100),
	@StockPrice money,
	@RetailPrice money,
	@StockInHand int,
	@CategoryId int,
	@SupplierId int,
	@IsTaxable bit
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[Products]
	SET Barcode=@Barcode, QtyDescId=@QtyDescId, QtyDescription=@QtyDescription, Brand=@Brand, [Name]=@Name, StockPrice=@StockPrice, 
		RetailPrice=@RetailPrice, StockInHand=@StockInHand, CategoryId=@CategoryId, SupplierId=@SupplierId, IsTaxable=@IsTaxable
	WHERE StockId=@StockId;
END