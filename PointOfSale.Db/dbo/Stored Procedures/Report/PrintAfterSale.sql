CREATE PROCEDURE [dbo].[PrintAfterSale]
	@SaleId NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
		Sale.InvoiceNumber,
		Sale.ShippingRate,
		Sale.DiscountApplied,
		Coupons.CouponCode,
		Customer.CustomerName, 
		Customer.CustomerAddressLine1, 
		Customer.CustomerAddressLine2, 
		Customer.CustomerAddressPin, 
		Customer.CustomerEmail, 
		Customer.CustomerPhone,
		Sale.SaleDate,
		[User].Fullname,
		Sale.GrandTotal
	FROM
		[Sale]
		INNER JOIN
		[Customer] ON
		Sale.CustomerId = Customer.CustomerId
		LEFT OUTER JOIN
		Coupons ON
		Sale.CouponId = Coupons.Id
		LEFT OUTER JOIN
		[User] ON
		Sale.CashierId = [User].UserId
	WHERE 
		Sale.SaleId = @SaleId
END