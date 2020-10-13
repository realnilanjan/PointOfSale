CREATE TABLE [dbo].[BusinessDetails]
(
	[Id] INT NOT NULL,
    [BusinessName] NVARCHAR(50) NULL, 
    [GSTNumber] NVARCHAR(50) NULL, 
    [BusinessType] NVARCHAR(50) NULL, 
    [BusinsessAddress] NVARCHAR(100) NULL, 
    [BusinessContact] NVARCHAR(50) NULL, 
    [BusinessEmail] NVARCHAR(100) NULL,
    CONSTRAINT [PK_BusinessDetails] PRIMARY KEY CLUSTERED ([Id] ASC)
)
