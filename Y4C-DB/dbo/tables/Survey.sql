CREATE TABLE [dbo].[Survey]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [Description] VARCHAR(500) NOT NULL,
    [IsActive] BIT NOT NULL,

    CONSTRAINT [PK_Survey_Id] PRIMARY KEY ([Id])
)
