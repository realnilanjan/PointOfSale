CREATE TABLE [dbo].[User]
(
	[UserId] INT NOT NULL,
    [Fullname] NVARCHAR (50)  NULL,
    [Username] NVARCHAR (50) NULL,
    [Password] NVARCHAR (100) NULL,
    [UserRole] NVARCHAR (50)  NULL,
    [Contact] NVARCHAR (10) NULL,
    [EmailAddress] NVARCHAR (100)  NULL,
    [Status] NVARCHAR (50)  NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserId] ASC)
)
