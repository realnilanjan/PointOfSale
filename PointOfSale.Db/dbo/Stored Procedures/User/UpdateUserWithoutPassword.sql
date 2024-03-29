﻿CREATE PROCEDURE [dbo].[UpdateUserWithoutPassword]
	@UserId int,
	@Fullname nvarchar(50),
	@Username nvarchar(50),
	@UserRole nvarchar(50),
	@Contact nvarchar(10),
	@EmailAddress nvarchar(100),
	@Status nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[User]
	SET [Fullname]=@Fullname, [Username]=@Username, [UserRole]=@UserRole, [Contact]=@Contact, [EmailAddress]=@EmailAddress, [Status]=@Status
	WHERE UserId = @UserId;
END