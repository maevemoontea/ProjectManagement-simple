CREATE TABLE [dbo].[Statuses]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StatusName] VARCHAR(50) NULL, 
    [StyleColor] INT NULL, 
    [Order] DECIMAL NULL
)
