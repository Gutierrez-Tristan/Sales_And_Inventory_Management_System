CREATE TABLE [dbo].[tblSale]
(
    [SaleID]       INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [SaleDate]     DATETIME NOT NULL DEFAULT GETDATE(),
    [CashierID]    INT NOT NULL,              -- Users.Id of the cashier
    [Subtotal]     DECIMAL(12,2) NOT NULL,
    [Discount]     DECIMAL(12,2) NOT NULL DEFAULT 0,
    [Total]        DECIMAL(12,2) NOT NULL,
    [AmountPaid]   DECIMAL(12,2) NOT NULL,
    [ChangeAmount] DECIMAL(12,2) NOT NULL,
    [VatRate]      DECIMAL(5,4)  NOT NULL DEFAULT 0,
    [VatAmount]    DECIMAL(12,2) NOT NULL DEFAULT 0,
);