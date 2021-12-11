CREATE TABLE [dbo].[Responses]
(
	Response_ID INT IDENTITY(1,1) NOT NULL,
	Question_ID INT NOT NULL,
	Survey_ID INT NOT NULL,
	Response_Content VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Responses] PRIMARY KEY ([Response_ID])
);


