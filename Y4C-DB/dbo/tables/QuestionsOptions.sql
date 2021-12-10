CREATE TABLE [dbo].[QuestionsOptions]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
	[Content] VARCHAR(500) NOT NULL, 
	[CreatedAt] DATETIMEOFFSET NOT NULL DEFAULT GETUTCDATE(),
    [LastModifiedAt] DATETIMEOFFSET NOT NULL DEFAULT GETUTCDATE(),
	[QuestionId] INT NOT NULL,

	CONSTRAINT [PK_QuestionsOptions_Id] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_QuestionsOptions_QuestionId] FOREIGN KEY ([QuestionId]) REFERENCES [Questions]([Id])
);
