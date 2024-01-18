CREATE TABLE [dbo].[Account]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Username] NVARCHAR(50) NULL, 
    [Login] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL, 
    [SecretQuestion] NVARCHAR(MAX) NULL, 
    [SecretAnswer] NVARCHAR(MAX) NULL, 
    [SubscriptionEndDate] BIGINT NULL, 
    [CreationDate] BIGINT NULL, 
    [isAdmin] BIT NULL
)
