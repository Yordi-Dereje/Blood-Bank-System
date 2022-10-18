-- functions used

-- age calculator
CREATE FUNCTION ageCalculate(@id int)
RETURNS int
AS
BEGIN
        DECLARE @age int;
        SELECT @age = datediff(YEAR, Dob, GetDate()) from DONOR_INFO where ID = @id;
        RETURN @age;
END

-- name concatenation
CREATE FUNCTION concatName(@id int)
RETURNS varchar(100)
AS
BEGIN
        DECLARE @fullName varchar(100);
        SELECT @fullName = concat(FirstName, ' ', LastName) from DONOR_INFO where ID = @id;
        RETURN @fullName;
END

-- date calculator
-- suggested username
-- address concat
-- transfer count
-- blood count enough for transfer ... esti echignawan

