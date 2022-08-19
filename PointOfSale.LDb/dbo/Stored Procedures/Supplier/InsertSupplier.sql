CREATE PROCEDURE [dbo].[InsertSupplier]
	@SupplierName nvarchar(50),
	@Address nvarchar(100),
	@Contact nvarchar(10),
	@EmailAddress nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Suppliers] ([dbo].[Suppliers].[SupplierName], [dbo].[Suppliers].[Address], [dbo].[Suppliers].[Contact], [dbo].[Suppliers].[EmailAddress])
	VALUES (@SupplierName, @Address, @Contact, @EmailAddress);
END