CREATE PROCEDURE [dbo].[UpdateCategory]
	@Id int,
	@CategoryName nvarchar(50),
	@CategoryDescription nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[Category]
	SET CategoryName=@CategoryName, CategoryDescription=@CategoryDescription
	WHERE Id=@Id;
END
