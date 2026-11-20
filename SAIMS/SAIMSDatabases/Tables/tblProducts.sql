CREATE TABLE [dbo].[tblProduct]
(
    [ProductID]         INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [SupplierProductID] INT NOT NULL,
    [CostPrice]         DECIMAL(10,2) NOT NULL,
    [SellingPrice]      DECIMAL(10,2) NOT NULL,
    [Stock]             INT NOT NULL DEFAULT 0,
    [ReorderLevel]      INT NOT NULL DEFAULT 0,
    CONSTRAINT [FK_tblProduct_SupplierProduct]
        FOREIGN KEY ([SupplierProductID]) REFERENCES [dbo].[tblSupplierProduct]([SupplierProductID]),
    CONSTRAINT [UQ_tblProduct_SupplierProduct] UNIQUE ([SupplierProductID])
);