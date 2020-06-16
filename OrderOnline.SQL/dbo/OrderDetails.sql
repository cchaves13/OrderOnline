CREATE TABLE [dbo].[OrderDetails] (
    [Id]              INT IDENTITY (1, 1) NOT NULL,
    [OrderId]         INT NOT NULL,
    [ProductId]       INT NOT NULL,
    [ProductQuantity] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

