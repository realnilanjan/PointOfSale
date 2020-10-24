CREATE TABLE [dbo].[StockPurchased]
(
	[StockinId]    INT            IDENTITY (1, 1) NOT NULL,
    [Barcode]      NVARCHAR (MAX) NULL,
    [DateReceived] DATETIME2 (7)  NULL DEFAULT getutcdate(),
    [ReceivedQty]  INT            NULL,
    [SubTotal]     MONEY          NULL,
    [UserId]       INT            NULL,
    [OrderId]      INT            NULL, 
    CONSTRAINT [PK_StockPurchased] PRIMARY KEY ([StockinId]),
)
