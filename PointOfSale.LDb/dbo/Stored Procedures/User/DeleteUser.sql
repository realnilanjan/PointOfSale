CREATE PROCEDURE [dbo].[DeleteUser]
	@UserId int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM [dbo].[User]
	WHERE UserId=@UserId;
END