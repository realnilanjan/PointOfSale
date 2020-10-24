CREATE PROCEDURE [dbo].[LoadAllSuppliers]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Id], [SupplierName], [Address], [Contact], [EmailAddress]
	FROM [dbo].[Suppliers];
END