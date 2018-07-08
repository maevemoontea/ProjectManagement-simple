CREATE TABLE [dbo].[Projects]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProjectName] VARCHAR(50) NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [IsActive] BIT NULL, 
    [StartDate] DATETIME NULL, 
    [FinishDate] DATETIME NULL
)

GO
