CREATE PROCEDURE [dbo].[LoadAllSuppliers]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Id], [SupplierName]
	FROM [dbo].[Suppliers];
END