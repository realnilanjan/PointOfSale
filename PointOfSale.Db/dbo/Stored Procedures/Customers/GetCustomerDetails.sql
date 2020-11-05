CREATE PROCEDURE [dbo].[GetCustomerDetails]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [CustomerId], [CustomerName], [CustomerEmail], [CustomerPhone], [CustomerAddressLine1], [CustomerAddressLine2], [CustomerAddressPin], [RegistrationDate]
	FROM [dbo].[Customer]
	WHERE CustomerId = @Id;
END