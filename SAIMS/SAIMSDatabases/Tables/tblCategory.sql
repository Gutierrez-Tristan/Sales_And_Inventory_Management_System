CREATE TABLE [dbo].[tblCategory]
(
    [CategoryID] INT IDENTITY(1,1) NOT NULL,
    [Name]       VARCHAR(100) NOT NULL,
    CONSTRAINT [PK_tblCategory] PRIMARY KEY ([CategoryID]),
    CONSTRAINT [UQ_tblCategory_Name] UNIQUE ([Name])
);