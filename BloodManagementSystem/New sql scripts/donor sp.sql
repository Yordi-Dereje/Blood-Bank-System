Use BloodBankSql;
-- donor stored procedures

-- INSERT
CREATE PROCEDURE spINSERT_DONOR_INFO
@FirstName varchar(50),
@LastName varchar(50),
@Dob varchar (50),
@Gender varchar(6),
@Phone varchar(50),
@Email varchar(50),
@Country varchar(50),
@City varchar(50),
@Region varchar(50),
@BT varchar(3)
AS
BEGIN
        INSERT INTO DONOR_INFO(FirstName, LastName, Dob, Gender, Phone, Email, Country, City, Region, BloodType) VALUES (@FirstName, @LastName, @Dob, @Gender, @Phone, @Email, @Country, @City, @Region, @BT);
END

EXEC spINSERT_DONOR_INFO 'bbb', 'bbb','12/12/12', 'Male', '0911', 'bbb', 'bbb', 'bbb', 'bbb', 'B+';
select * from DONOR_INFO;

-- UPDATE
CREATE PROCEDURE spUPDATE_DONOR_INFO
@id int,
@FirstName varchar(50),
@LastName varchar(50),
@Dob varchar(50),
@Gender varchar(6),
@Phone varchar(50),
@Email varchar(50),
@Country varchar(50),
@City varchar(50),
@Region varchar(50)
AS
BEGIN
        UPDATE DONOR_INFO SET FirstName = @FirstName,LastName = @LastName, Dob = @Dob, Gender = @Gender,Phone = @Phone,Email = @Email,Country = @Country,City = @City,Region = @Region where id = @id;
END

drop procedure spUPDATE_DONOR_INFO;

-- UPDATE BLOOD TYPE
CREATE PROCEDURE spUPDATE_DONOR_BLOODTYPE
@ID int,
@BT varchar(3)
AS
BEGIN
	UPDATE DONOR_INFO SET BloodType = @BT WHERE ID = @ID;
END

-- DELETE
CREATE PROCEDURE spDELETE_DONOR_INFO
@ID INT
AS
BEGIN
        DELETE FROM DONOR_INFO WHERE ID = @ID;
END

-- SEARCH
CREATE PROCEDURE spLOAD_SEARCH
@name varchar(50)
AS
BEGIN
        SELECT * FROM DONOR_INFO WHERE FirstName = @name or LastName = @name or concat(FirstName,' ',LastName) = @name;
END

drop procedure spLOAD_SEARCH;

-- DISPLAY
CREATE PROCEDURE spDISPLAY_DONOR_INFO
AS
BEGIN
        SELECT * FROM DONOR_INFO;
END

-- DONOR ACCOUNTS

-- INSERT
CREATE PROCEDURE spINSERT_DONOR_ACCOUNTS
@ID INT,
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(50)
AS
BEGIN
        INSERT INTO DONOR_ACCOUNTS VALUES(@ID,@USERNAME,@PASSWORD);
END

-- UPDATE
CREATE PROCEDURE spUPDATE_DONOR_ACCOUNTS
@ID INT,
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(50)
AS
BEGIN
        UPDATE DONOR_ACCOUNTS SET USERNAME = @USERNAME, PASSWORD = @PASSWORD WHERE ID = @ID;
END

-- DELETE
CREATE PROCEDURE spDELETE_DONOR_ACCOUNTS
@ID INT
AS
BEGIN
        DELETE FROM DONOR_ACCOUNTS WHERE ID = @ID;
END

-- SEARCH
CREATE PROCEDURE spLOAD_SEARCH_ACCOUNTS
@ID INT
AS
BEGIN
        SELECT * FROM DONOR_ACCOUNTS WHERE ID = @ID
END

-- DISPLAY
CREATE PROCEDURE spDISPLAY_DONOR_ACCOUNTS
AS
BEGIN
        SELECT * FROM DONOR_ACCOUNTS;
END

CREATE PROCEDURE sp_searchDonorByName
@Name varchar(100)
AS
BEGIN
	SELECT * FROM DONOR_INFO WHERE FirstName like '%' + @Name + '%' or LastName like '%' + @Name + '%' or concat(FirstName,' ',LastName) like '%' + @Name + '%';
END


-- new procedures
CREATE PROCEDURE editDonor
@id int,
@fn varchar(50),
@ln varchar(50),
@gen varchar(6),
@Phone varchar(50),
@Email varchar(50),
@Country varchar(50),
@City varchar(50),
@Region varchar(50)