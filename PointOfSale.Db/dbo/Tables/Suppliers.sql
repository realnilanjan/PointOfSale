CREATE TABLE [dbo].[Suppliers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SupplierName] NVARCHAR(50) NULL, 
    [Address] NVARCHAR(100) NULL, 
    [Contact] NVARCHAR(10) NULL, 
    [EmailAddress] NVARCHAR(100) NULL
)
