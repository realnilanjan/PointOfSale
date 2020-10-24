CREATE PROCEDURE [dbo].[LoadAllCategories]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Id], [CategoryName], [CategoryDescription]
	FROM [dbo].[Category]
END