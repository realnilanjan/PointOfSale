CREATE PROCEDURE [dbo].[SetCouponApplied]
	@Id INT
AS
	UPDATE [Coupons]
	SET IsUsed = 1
	WHERE Id = @Id;
RETURN 0
