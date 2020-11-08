CREATE PROCEDURE [dbo].[PrintAfterSale]
	@SaleId NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
		Sale.InvoiceNumber,
		Sale.ShippingRate,
		Sale.DiscountApplied,
		Customer.CustomerName, 
		Customer.CustomerAddressLine1, 
		Customer.CustomerAddressLine2, 
		Customer.CustomerAddressPin, 
		Customer.CustomerEmail, 
		Customer.CustomerPhone,
		Sale.SaleDate
	FROM
		[Sale]
		INNER JOIN
		[Customer] ON
		Sale.CustomerId = Customer.CustomerId
	WHERE 
		Sale.SaleId = @SaleId
END