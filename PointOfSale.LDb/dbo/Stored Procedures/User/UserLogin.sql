CREATE PROCEDURE [dbo].[UserLogin]
	@Username nvarchar(50),
	@Password nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 
		[UserId], 
		[Fullname], 
		[Username], 
		[Password], 
		[UserRole], 
		[Contact], 
		[EmailAddress], 
		[Status]
	FROM [dbo].[User]
	WHERE [Username]=@Username AND [Password]=@Password;
END