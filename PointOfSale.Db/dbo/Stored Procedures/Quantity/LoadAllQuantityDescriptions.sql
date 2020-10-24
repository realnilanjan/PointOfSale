CREATE PROCEDURE [dbo].[LoadAllQuantityDescriptions]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Id], [QtyDescription]
	FROM [dbo].[QuantityDescription]
END