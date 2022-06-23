CREATE TABLE [dbo].[JobTbl]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [JobTitle] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(100) NOT NULL, 
    [Time] INT NOT NULL, 
    [Place] VARCHAR(50) NOT NULL, 
    [WorkerName] VARCHAR(50) NOT NULL
)
