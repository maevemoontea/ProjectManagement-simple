CREATE TABLE [dbo].[Resources]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Age] NVARCHAR(50) NULL, 
    [Specialization] VARCHAR(50) NULL, 
    [Avatar] VARCHAR(50) NULL, 
    [PhoneNumber] NVARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [NowWorkingOn] NVARCHAR(50) NULL
)
