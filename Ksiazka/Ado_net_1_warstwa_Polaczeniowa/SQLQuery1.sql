CREATE PROCEDURE GetCarName
@carId int,
@carName varchar(50) output
AS
SELECT @carName = CarName from Inventory where CarId=@carId
