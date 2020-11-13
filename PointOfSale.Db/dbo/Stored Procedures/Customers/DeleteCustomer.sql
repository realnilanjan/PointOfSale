CREATE PROCEDURE [dbo].[DeleteCustomer]
	@CustomerId int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM [Customer]
	WHERE @CustomerId = @CustomerId;
END