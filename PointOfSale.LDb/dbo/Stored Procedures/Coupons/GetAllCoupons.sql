CREATE PROCEDURE [dbo].[GetAllCoupons]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Id], [CouponCode], [CouponDescription], [IssueDate], [ExpiryDate], [IsFlatRate], [IsPercentDiscount], [CouponAmount], [IsUsed]
	FROM [dbo].[Coupons]
END