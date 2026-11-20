CREATE TABLE [dbo].[tblSupplierProduct]
(
    [SupplierProductID] INT IDENTITY(1,1) NOT NULL,
    [SupplierID]        INT NOT NULL,
    [CategoryID]        INT NULL,
    [ItemName]          VARCHAR(100) NOT NULL,
    [UnitPrice]         DECIMAL(10,2) NOT NULL,
    [Stock]             INT NOT NULL DEFAULT 0,
    CONSTRAINT [PK_tblSupplierProduct] PRIMARY KEY ([SupplierProductID]),
    CONSTRAINT [FK_tblSupplierProduct_tblSuppliers]
        FOREIGN KEY ([SupplierID]) REFERENCES [dbo].[tblSuppliers]([SupplierID]),
    CONSTRAINT [FK_tblSupplierProduct_tblCategory]
        FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[tblCategory]([CategoryID])
);