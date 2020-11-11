SELECT
	Products.[Name],
	SaleDetail.Quantity,
	SaleDetail.PurchasePrice,
	SaleDetail.Tax
	--Customer.CustomerId, 
	--Customer.CustomerName, 
	--Customer.CustomerAddressLine1, 
	--Customer.CustomerAddressLine2, 
	--Customer.CustomerAddressPin, 
	--Customer.CustomerEmail, 
	--Customer.CustomerPhone,
	--Sale.DiscountApplied,
	--Sale.SaleDate
FROM
	(([SaleDetail]
	INNER JOIN
	[Products] ON
	[SaleDetail].ProductId = [Products].StockId)
	INNER JOIN
	Sale ON
	Sale.SaleId = SaleDetail.SaleId)
Where [SaleDetail].SaleId = '1'