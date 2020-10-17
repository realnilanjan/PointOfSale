CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryName] NVARCHAR(50) NOT NULL, 
    [CategoryDescription] NVARCHAR(100) NULL
)
