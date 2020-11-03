CREATE PROCEDURE [dbo].[SaveSale]
	@CashierId INT,
	@CustomerId INT,
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
	INSERT INTO [Sale] (CashierId, InvoiceNumber, CustomerId, SaleDate, SubTotal, CouponId, SaleTaxRate, ShippingRate, GrandTotal) 
	VALUES (@CashierId, @InvoiceNumber, @CustomerId, @SaleDate, @SubTotal, @CouponId, @SaleTaxRate, @ShippingRate, @GrandTotal);
	SELECT CAST(SCOPE_IDENTITY() AS INT);
END