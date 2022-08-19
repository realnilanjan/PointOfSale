CREATE PROCEDURE [dbo].[GetBusinessInfo]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Id], [BusinessName], [GSTNumber], [BusinessType], [BusinsessAddress], [BusinessContact], [BusinessEmail]
	FROM [dbo].[BusinessDetails];
END