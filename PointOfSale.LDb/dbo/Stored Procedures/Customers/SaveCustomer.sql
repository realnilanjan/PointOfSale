CREATE PROCEDURE [dbo].[SaveCustomer]
	@CustomerName nvarchar(50),
	@CustomerEmail nvarchar(100),
	@CustomerPhone nvarchar(10),
	@CustomerAddressLine1 nvarchar(100),
	@CustomerAddressLine2 nvarchar(100),
	@CustomerAddressPin nvarchar(10),
	@RegistrationDate datetime2(7)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [Customer] (CustomerName, CustomerEmail, CustomerPhone, CustomerAddressLine1, CustomerAddressLine2, CustomerAddressPin, RegistrationDate)
	VALUES (@CustomerName, @CustomerEmail, @CustomerPhone, @CustomerAddressLine1, @CustomerAddressLine2, @CustomerAddressPin, @RegistrationDate)
END