Use BloodBankSql;

CREATE FUNCTION ageCalculate(@id int)
RETURNS int
AS
BEGIN
	DECLARE @age int;
	SELECT @age = datediff(YEAR, Dob, GetDate()) from DONOR_INFO where ID = @id;
	RETURN @age;
END

CREATE FUNCTION concatName(@id int)
RETURNS varchar(100)
AS
BEGIN
	DECLARE @fullName varchar(100);
	SELECT @fullName = concat(FirstName, ' ', LastName) from DONOR_INFO where ID = @id;
	RETURN @fullName;
END


	
