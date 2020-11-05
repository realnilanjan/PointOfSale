CREATE TABLE [dbo].[Customer]
(
	[CustomerId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerName] NVARCHAR(50) NOT NULL, 
    [CustomerEmail] NVARCHAR(100) NOT NULL, 
    [CustomerPhone] NVARCHAR(10) NOT NULL, 
    [CustomerAddressLine1] NVARCHAR(100) NOT NULL, 
    [CustomerAddressLine2] NVARCHAR(100) NULL, 
    [CustomerAddressPin] NVARCHAR(10) NOT NULL, 
    [RegistrationDate] DATETIME2 NOT NULL
)
