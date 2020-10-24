CREATE PROCEDURE [dbo].[SaveUser]
	@Fullname nvarchar(50),
	@Username nvarchar(50),
	@Password nvarchar(100),
	@UserRole nvarchar(50),
	@Contact nvarchar(10),
	@EmailAddress nvarchar(100),
	@Status nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[User](Fullname, Username, [Password], UserRole, Contact, EmailAddress, [Status])
	VALUES (@Fullname, @Username, @Password, @UserRole, @Contact, @EmailAddress, @Status);
END	
