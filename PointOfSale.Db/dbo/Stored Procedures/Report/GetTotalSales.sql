﻿CREATE PROCEDURE [dbo].[GetTotalSales]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT SUM(GrandTotal)
	FROM [Sale]
END