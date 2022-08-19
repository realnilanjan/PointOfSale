CREATE PROCEDURE [dbo].[UpdateSupplier]
	@Id int,
	@SupplierName nvarchar(50),
	@Address nvarchar(100),
	@Contact nvarchar(10),
	@EmailAddress nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[Suppliers]
	SET [dbo].[Suppliers].[SupplierName]=@SupplierName, [dbo].[Suppliers].[Address]=@Address, [dbo].[Suppliers].[Contact]=@Contact, [dbo].[Suppliers].[EmailAddress]=@EmailAddress
	WHERE [dbo].[Suppliers].[Id]=@Id;
END