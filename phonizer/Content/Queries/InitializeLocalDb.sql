USE [master]
GO

CREATE DATABASE [aklion]
GO

USE [aklion]
GO

CREATE TABLE [dbo].[Order] (
    [Id]			INT	NOT NULL,
	[Date]			DATETIME NOT NULL,
    [Name]			NVARCHAR (MAX) NOT NULL,
	[Phone]			NVARCHAR (MAX) NOT NULL,
	[Email]			NVARCHAR (MAX) NULL,
    [Street]		NVARCHAR (MAX) NOT NULL,
	[HouseNumber]	NVARCHAR (MAX) NOT NULL,
	[OrderItems]	NVARCHAR (MAX) NOT NULL,
	[OrderSum]		DECIMAL	(18, 2) NOT NULL,
	[PaymentMethod]	NVARCHAR (MAX) NOT NULL,
	[Note]			NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO