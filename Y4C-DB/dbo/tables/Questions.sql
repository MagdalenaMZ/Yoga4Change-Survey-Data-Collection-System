CREATE TABLE [dbo].[Questions]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Content] NVARCHAR(100) NOT NULL, 
    [Type] INT NOT NULL, 
)
