CREATE PROCEDURE [dbo].[GetAppliedCoupon]
	@CouponCode nvarchar(50)
AS
	SELECT [Id], [CouponCode], [CouponDescription], [IssueDate], [ExpiryDate], [IsFlatRate], [IsPercentDiscount], [CouponAmount], [IsUsed]
	FROM [dbo].[Coupons]
	WHERE CouponCode=@CouponCode;
RETURN 0
