CREATE PROCEDURE [dbo].[InsertCategory]
	@CategoryName nvarchar(50),
	@CategoryDescription nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Category] (CategoryName, CategoryDescription)
	VALUES (@CategoryName, @CategoryDescription);
END