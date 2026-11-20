CREATE TABLE [dbo].[tblPurchase]
(
    [PurchaseID]   INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [ProductID]    INT NOT NULL,
    [SupplierID]   INT NOT NULL,
    [Quantity]     INT NOT NULL,
    [CostPerUnit]  DECIMAL(10,2) NOT NULL,
    [TotalCost]    DECIMAL(12,2) NOT NULL,
    [PurchaseDate] DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT [FK_tblPurchase_Product]  FOREIGN KEY ([ProductID])  REFERENCES [dbo].[tblProduct]([ProductID]),
    CONSTRAINT [FK_tblPurchase_Supplier] FOREIGN KEY ([SupplierID]) REFERENCES [dbo].[tblSuppliers]([SupplierID])
);