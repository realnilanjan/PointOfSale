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
	Sale.DiscountApplied,
	Sale.SaleDate
FROM
	[Sale]
	INNER JOIN
	[Customer] ON
	Sale.CustomerId = Customer.CustomerId
Where Sale.SaleId = '1'