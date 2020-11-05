CREATE PROCEDURE [dbo].[GetAllCustomers]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [CustomerId], [CustomerName], [CustomerEmail], [CustomerPhone], [CustomerAddressLine1], [CustomerAddressLine2], [CustomerAddressPin], [RegistrationDate]
	FROM [dbo].[Customer]
END