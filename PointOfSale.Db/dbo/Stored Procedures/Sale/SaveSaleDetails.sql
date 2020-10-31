CREATE PROCEDURE [dbo].[SaveSaleDetails]
	@SaleId INT,
	@ProductId INT,
	@Quantity INT,
	@PurchasePrice MONEY,
	@Tax MONEY
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [SaleDetail] (SaleId, ProductId, Quantity, PurchasePrice, Tax)
	VALUES (@SaleId, @ProductId, @Quantity, @PurchasePrice, @Tax);
END