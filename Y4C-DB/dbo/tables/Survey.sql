CREATE TABLE [dbo].[Survey]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [Name] VARCHAR(500) NOT NULL,
    [IsPublished] BIT NOT NULL,

    CONSTRAINT [PK_Survey_Id] PRIMARY KEY ([Id])
)
