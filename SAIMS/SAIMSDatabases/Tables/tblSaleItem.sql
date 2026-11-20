CREATE TABLE [dbo].[tblSaleItem]
(
    [SaleItemID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [SaleID]     INT NOT NULL,
    [ProductID]  INT NOT NULL,
    [Quantity]   INT NOT NULL,
    [UnitPrice]  DECIMAL(10,2) NOT NULL,
    [LineTotal]  DECIMAL(12,2) NOT NULL,
    CONSTRAINT [FK_tblSaleItem_Sale]    FOREIGN KEY ([SaleID])    REFERENCES [dbo].[tblSale]([SaleID]),
    CONSTRAINT [FK_tblSaleItem_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[tblProduct]([ProductID])
);