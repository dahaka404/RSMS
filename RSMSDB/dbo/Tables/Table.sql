CREATE TABLE [dbo].[Table] (
    [ID]     UNIQUEIDENTIFIER NOT NULL,
    [Number] INT              NOT NULL,
    [Chairs] INT              NOT NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([ID] ASC)
);

