CREATE PROCEDURE [dbo].[GetTotalTransaction]
AS
BEGIN
	SELECT COUNT(*)
	FROM [dbo].[Transaction]
END