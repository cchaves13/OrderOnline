CREATE TABLE [dbo].[Clients] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         VARCHAR (200)  NULL,
    [Address]      VARCHAR (500)  NULL,
    [Phone]        VARCHAR (20)   NULL,
    [LocationArea] VARCHAR (200)  NULL,
    [Email]        NVARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

