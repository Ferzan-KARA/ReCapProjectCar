CREATE TABLE Cars(
	Id int,
	BrandId int,
	ColorId int,
	ModelYear int,
	DailyPrice decimal,
	Car_Desc nvarchar(269)
);

CREATE TABLE Brands(
	BrandId int,
	BrandName nvarchar(128)
);

CREATE TABLE Colors(
	ColorId int,
	ColorName nvarchar(69)
);