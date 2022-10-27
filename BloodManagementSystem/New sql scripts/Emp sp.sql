-- employee stored procedures
Use BloodBankSql;

--INSERT
CREATE PROCEDURE spINSERT_EMP_INFO
@FirstName varchar(50),
@LastName varchar(50),
@Dob varchar(50),
@Gender varchar(6),
@Phone varchar(50),
@Email varchar(50),
@Country varchar(50),
@City varchar(50),
@Region varchar(50),
@Sal int,
@Stat bit
AS
BEGIN
        INSERT INTO EMP_INFO( FirstName, LastName, Dob, Gender, Phone, Email, Country, City, Region, Salary, Stat) VALUES (@FirstName, @LastName, @Dob, @Gender, @Phone, @Email, @Country, @City, @Region, @Sal, @Stat);
END


--UPDATE
ALTER PROCEDURE spUPDATE_EMP_INFO_AS_EMP
@id int,
@FirstName varchar(50),
@LastName varchar(50),
@Gender varchar(6),
@Phone varchar(50),
@Email varchar(50),
@Country varchar(50),
@City varchar(50),
@Region varchar(50)
AS
BEGIN
        UPDATE EMP_INFO SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, Phone = @Phone,Email = @Email, Country = @Country, City = @City, Region = @Region where ID = @id;
END

ALTER PROCEDURE spUPDATE_EMP_INFO_AS_ADMIN
@id int,
@Salary int,
@Stat bit
AS
BEGIN
	UPDATE EMP_INFO SET Salary = @Salary, Stat = @Stat where ID = @id;
END

--DELETE
CREATE PROCEDURE spDELETE_EMP_INFO
@ID INT
AS
BEGIN
        DELETE FROM EMP_INFO WHERE ID = @ID;
END

--SEARCH
CREATE PROCEDURE spLOAD_SEARCH_EMP_INFO
@ID INT
AS
BEGIN
        SELECT * FROM EMP_INFO WHERE ID = @ID
END

-- search by name
CREATE PROCEDURE sp_searchEmpByName
@Name varchar(100)
AS
BEGIN
	SELECT * FROM EMP_INFO WHERE FirstName like '%' + @Name + '%' or LastName like '%' + @Name + '%' or concat(FirstName,' ',LastName) like '%' + @Name + '%';
END

--DISPLAY
CREATE PROCEDURE spDISPLAY_EMP_INFO
AS
BEGIN
        SELECT * FROM EMP_INFO;
END


-- Employee accounts

-- INSERT
CREATE PROCEDURE spINSERT_EMP_ACCOUNTS
@ID INT,
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(50)
AS
BEGIN
        INSERT INTO EMP_ACCOUNTS VALUES (@ID,@USERNAME,@PASSWORD);
END

-- UPDATE
CREATE PROCEDURE spUPDATE_EMP_ACCOUNTS
@ID INT,
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(50)
AS
BEGIN
        UPDATE EMP_ACCOUNTS SET USERNAME = @USERNAME, PASSWORD = @PASSWORD WHERE ID = @ID;
END

-- DELETE
CREATE PROCEDURE spDELETE_EMP_ACCOUNTS
@ID INT
AS
BEGIN
        DELETE FROM EMP_ACCOUNTS WHERE ID = @ID;
END

-- SEARCH
CREATE PROCEDURE spLOAD_SEARCH_EMP_ACCOUNTS
@ID INT
AS
BEGIN
        SELECT * FROM EMP_ACCOUNTS WHERE ID = @ID;
END

-- DISPLAY
CREATE PROCEDURE spDISPLAY_EMP_ACCOUNTS
AS
BEGIN
        SELECT * FROM EMP_ACCOUNTS;
END