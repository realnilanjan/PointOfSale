CREATE PROCEDURE [dbo].[DeleteCoupon]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM [dbo].[Coupons]
	WHERE Id=@Id;
END