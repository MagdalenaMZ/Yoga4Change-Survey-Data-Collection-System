﻿CREATE TABLE [dbo].[Questions]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [Content] VARCHAR(500) NOT NULL, 
    [TypeId] INT NOT NULL DEFAULT 1, 
    [CreatedAt] DATETIMEOFFSET NOT NULL DEFAULT GETUTCDATE(),
    [LastModifiedAt] DATETIMEOFFSET NOT NULL DEFAULT GETUTCDATE(),

    [Draft] BIT NULL, 
    CONSTRAINT [PK_Questions_Id] PRIMARY KEY ([Id])
)
