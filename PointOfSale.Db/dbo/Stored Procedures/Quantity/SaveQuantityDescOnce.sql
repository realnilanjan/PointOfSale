CREATE PROCEDURE [dbo].[SaveQuantityDescOnce]
	@QtyDescription nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [QuantityDescription] (QtyDescription)
	VALUES (@QtyDescription)
END