CREATE PROCEDURE [dbo].[SaveSale]
	@CashierId INT,
	@InvoiceNumber nvarchar(50),
	@SaleDate DATETIME2,
	@SubTotal MONEY,
	@CouponId INT,
	@SaleTaxRate MONEY,
	@ShippingRate MONEY,
	@GrandTotal MONEY
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [Sale] (CashierId, InvoiceNumber, SaleDate, SubTotal, CouponId, SaleTaxRate, ShippingRate, GrandTotal) 
	VALUES (@CashierId, @InvoiceNumber, @SaleDate, @SubTotal, @CouponId, @SaleTaxRate, @ShippingRate, @GrandTotal);
	SELECT CAST(SCOPE_IDENTITY() AS INT);
END