﻿CREATE PROCEDURE [dbo].[GetStocksSold]
AS
BEGIN
 SET NOCOUNT ON;
 SELECT SUM(Quantity)
 FROM SaleDetail
END