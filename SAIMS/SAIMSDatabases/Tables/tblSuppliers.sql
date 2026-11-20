CREATE TABLE [dbo].[tblSuppliers]
(
    [SupplierID] INT IDENTITY(1,1) NOT NULL,
    [Name]       VARCHAR(100) NOT NULL,
    [Email]      VARCHAR(100) NOT NULL,
    [Phone]      VARCHAR(20)  NOT NULL,
    [Address]    VARCHAR(200) NOT NULL,
    [IsActive]   BIT NOT NULL DEFAULT 1,
    CONSTRAINT [PK_tblSuppliers] PRIMARY KEY ([SupplierID]),
    CONSTRAINT [UQ_tblSuppliers_Name] UNIQUE ([Name])
);