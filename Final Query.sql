SELECT 
	SaleDetail.SaleId,  
	--Sale.CustomerId,
	Products.[Name], 
	SaleDetail.Quantity,
	Products.RetailPrice, 
	SaleDetail.Tax,
	Sale.SaleDate,  
	Sale.SaleTaxRate, 
	Sale.DiscountApplied,
	Sale.GrandTotal,
	Sale.InvoiceNumber
	--Customer.CustomerName, 
	--Customer.CustomerAddressLine1, 
	--CustomerAddressLine2, 
	--Customer.CustomerAddressPin, 
	--Customer.CustomerEmail, 
	--Customer.CustomerPhone,
	--Coupons.IsFlatRate,
	--Coupons.IsPercentDiscount,
	--Coupons.CouponAmount
FROM 
	(
	(SaleDetail inner join Products on SaleDetail.ProductId = Products.StockId) 
	inner join
	Sale on Sale.SaleId = SaleDetail.SaleId) 
	--inner join
	--Coupons on Sale.CouponId = Coupons.Id
	--inner join 
	----Customer on Sale.CustomerId = Customer.CustomerId
--WHERE
	--Sale.InvoiceNumber = 'MEM-637402809961265064'