CREATE TABLE [dbo].[Orders] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [ClientId]        INT           NOT NULL,
    [Status]          VARCHAR (200) NULL,
    [CreationDate]    DATETIME      NULL,
    [DeliverLocation] VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

