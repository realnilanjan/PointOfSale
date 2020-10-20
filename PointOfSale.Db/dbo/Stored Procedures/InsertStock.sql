CREATE PROCEDURE [dbo].[InsertStock]
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
	INSERT INTO [dbo].[Products] (Barcode, QtyDescId, QtyDescription, Brand, [Name], StockPrice, RetailPrice, StockInHand, CategoryId, SupplierId, IsTaxable)
	VALUES (@Barcode, @QtyDescId, @QtyDescription, @Brand, @Name, @StockPrice, @RetailPrice, @StockInHand, @CategoryId, @SupplierId, @IsTaxable);
END