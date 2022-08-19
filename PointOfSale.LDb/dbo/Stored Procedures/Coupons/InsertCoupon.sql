CREATE PROCEDURE [dbo].[InsertCoupon]
	@CouponCode nvarchar(10),
	@CouponDescription nvarchar(100),
	@IssueDate datetime2(7),
	@ExpiryDate datetime2(7),
	@IsFlatRate bit,
	@IsPercentDiscount bit,
	@CouponAmount decimal(18,0),
	@IsUsed bit
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Coupons] (CouponCode, CouponDescription, IssueDate, ExpiryDate, IsFlatRate, IsPercentDiscount, CouponAmount, IsUsed)
	VALUES (@CouponCode, @CouponDescription, @IssueDate, @ExpiryDate, @IsFlatRate, @IsPercentDiscount, @CouponAmount, @IsUsed);
END