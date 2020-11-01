CREATE PROCEDURE [dbo].[SaveTransaction]
	@SaleId INT,
	@CashierId INT,
	@TotalAmount MONEY,
	@CardDigits INT,
	@CardType nvarchar(10),
	@DateCreated datetime2(7)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Transaction] (SaleId, CashierId, TotalAmount, CardDigits, CardType, DateCreated)
	VALUES (@SaleId, @CashierId, @TotalAmount, @CardDigits, @CardType, @DateCreated);
END