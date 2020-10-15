CREATE PROCEDURE [dbo].[LoadAllUsers]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [UserId], [Fullname], [Username], [Password], [UserRole], [Contact], [EmailAddress], [Status]
	FROM [dbo].[User];
END