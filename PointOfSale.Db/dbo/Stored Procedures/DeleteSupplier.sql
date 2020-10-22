CREATE PROCEDURE [dbo].[DeleteSupplier]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM [dbo].[Suppliers]
	WHERE Id=@Id;
END