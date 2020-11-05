
CREATE VIEW [dbo].[ViewAllBills]
	AS 
	SELECT 
	s.SaleId, 
	c.CustomerId, 
	c.CustomerName, 
	c.CustomerAddressLine1,
	c.CustomerAddressLine2, 
	c.CustomerAddressPin, 
	c.CustomerPhone
	FROM 
	[dbo].[Sale] s 
	INNER JOIN
	[dbo].[Customer] c 
	ON
	s.CustomerId = c.CustomerId