CREATE PROCEDURE [dbo].[UpdateCustomer]
	@CustomerId int,
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
	UPDATE [Customer]
	SET CustomerName = @CustomerName, CustomerEmail = @CustomerEmail, CustomerPhone = @CustomerPhone, CustomerAddressLine1 = @CustomerAddressLine1, CustomerAddressLine2 = @CustomerAddressLine2,
		CustomerAddressPin = @CustomerAddressPin, RegistrationDate = @RegistrationDate
	WHERE CustomerId = @CustomerId;
END