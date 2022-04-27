CREATE TABLE [dbo].[Table1]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[SurveyId] INT NOT NULL,
	[QuestionId] INT NOT NULL,
	[OrderInSurvey] INT NOT NULL,
	CONSTRAINT [PK_SurveyQuestions_Id] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_SurveyQuestions_SurveyId] FOREIGN KEY ([SurveyId]) REFERENCES [Survey]([Id]) ON DELETE CASCADE,
	CONSTRAINT [FK_SurveyQuestions_QuestionId] FOREIGN KEY ([QuestionId]) REFERENCES [Questions]([Id]) ON DELETE CASCADE
)
