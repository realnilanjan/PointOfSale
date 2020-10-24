CREATE PROCEDURE [dbo].[SaveBusiness]
	@BusinessName nvarchar(50),
	@GSTNumber nvarchar(50),
	@BusinessType nvarchar(50),
	@BusinsessAddress nvarchar(100),
	@BusinessContact nvarchar(50),
	@BusinessEmail nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[BusinessDetails](BusinessName, GSTNumber, BusinessType, BusinsessAddress, BusinessContact, BusinessEmail)
	VALUES (@BusinessName, @GSTNumber, @BusinessType, @BusinsessAddress, @BusinessContact, @BusinessEmail);
END	
