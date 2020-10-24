CREATE PROCEDURE [dbo].[DeleteCategory]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM [dbo].[Category]
	WHERE Id=@Id;
END