CREATE PROCEDURE [dbo].[GetAllSales]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 
		Sale.SaleId, 
		Sale.InvoiceNumber, 
		Customer.CustomerId, 
		Customer.CustomerName, 
		Customer.CustomerAddressLine1, 
		Customer.CustomerAddressLine2, 
		Customer.CustomerAddressPin, 
		Customer.CustomerEmail, 
		Customer.CustomerPhone,
		Sale.SaleDate
	FROM Sale
	INNER JOIN 
		Customer ON 
		Sale.CustomerId = Customer.CustomerId
END