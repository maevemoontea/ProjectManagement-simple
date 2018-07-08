CREATE TABLE [dbo].[Tasks]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TaskName] VARCHAR(50) NULL, 
    [RelativeProject] NCHAR(10) NULL, 
    [Responsible] NCHAR(10) NULL, 
    [Accountable] NCHAR(10) NULL, 
    [Consulted] NCHAR(10) NULL, 
    [TaskDescription] VARCHAR(MAX) NULL, 
    [EstimatedTime] NCHAR(10) NULL, 
    [SpendTime] NCHAR(10) NULL, 
    [Status] NCHAR(10) NULL, 
    [IsActive] BIT NULL
)
