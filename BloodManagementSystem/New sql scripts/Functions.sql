-- functions used
 ]]
-- total donations
-- total transfers
-- total donors

CREATE FUNCTION totalDonations()
RETURNS int
AS
BEGIN
	DECLARE @count int;
	SELECT @count = count(*) from SUCCESSFUL_DONATION;
	RETURN @count;
END

select dbo.totalDonations();

CREATE FUNCTION totalDonors()
RETURNS int
AS
BEGIN
	DECLARE @count int;
	SELECT @count = count(*) from DONOR_INFO;
	RETURN @count;
END

CREATE FUNCTION totalTransfers()
RETURNS int
AS
BEGIN
	DECLARE @count int;
	SELECT @count = count(*) from TRANSFER_INFO;
	RETURN @count;
END

CREATE FUNCTION totalEmployees()
RETURNS int
AS
BEGIN
	DECLARE @count int;
	SELECT @count = count(*) from EMP_INFO;
	RETURN @count;
END

-- age calculator
CREATE FUNCTION ageCalculate(@id int)
RETURNS int
AS
BEGIN
        DECLARE @age int;
        SELECT @age = datediff(YEAR, Dob, GetDate()) from DONOR_INFO where ID = @id;
        RETURN @age;
END

CREATE FUNCTION ageCalculateE(@id int)
RETURNS int
AS
BEGIN
        DECLARE @age int;
        SELECT @age = datediff(YEAR, Dob, GetDate()) from EMP_INFO where ID = @id;
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

CREATE FUNCTION concatNameE(@id int)
RETURNS varchar(100)
AS
BEGIN
        DECLARE @fullName varchar(100);
        SELECT @fullName = concat(FirstName, ' ', LastName) from EMP_INFO where ID = @id;
        RETURN @fullName;
END

CREATE FUNCTION totalBloodTransfer(@id int)
RETURNS int
AS
BEGIN
	DECLARE @sum int = 0;
	SELECT @sum += Ap,@sum += Am, @sum += Bp, @sum += Bm, @sum += Abp, @sum += Abm, @sum += Op, @sum += Om from TRANSFER_INFO where ID = @id;
	RETURN @sum;
END


CREATE FUNCTION specificBloodCount(@type varchar(3))
RETURNS int
AS
BEGIN
	DECLARE @count int;
	SELECT @count = bloodcount from BLOOD_COUNT where bloodtype = @type;
	RETURN @count;
END

CREATE FUNCTION totalBloodTransfer(@id int)
RETURNS int
AS
BEGIN
	DECLARE @total int;
	SELECT @total += 1; -- finish this some other time
	RETURN @total;
END

CREATE FUNCTION SingleRequestCheck(@id int)
RETURNS int
AS
BEGIN
	DECLARE @c int;
	SELECT @c = count(*) from FULL_CHECK where ID = @id;
	RETURN @c;
END