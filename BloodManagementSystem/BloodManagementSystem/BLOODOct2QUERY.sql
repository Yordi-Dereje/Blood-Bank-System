Create database BloodOct2;
Use BloodOct2;

--INSERT EMPACC, ALTER IDENETY ERROR ALEW 

--Donor
Create table DONOR_INFO(
ID int primary key IDENTITY,
FirstName varchar(50),
LastName varchar(50),
Dob varchar(50),
Gender varchar(6),
Phone varchar(50),
Email varchar(50),
Country varchar(50),
City varchar(50),
Region varchar(50)
); 
select * from donor_info;

--STORED PROC FOR DONOR

--INSERT
ALTER PROCEDURE spINSERT_DONOR_INFO
@FirstName varchar(50),
@LastName varchar(50),
@Dob varchar (50),
@Gender varchar(6),
@Phone varchar(50),
@Email varchar(50),
@Country varchar(50),
@City varchar(50),
@Region varchar(50)
AS
BEGIN
	INSERT INTO DONOR_INFO(FirstName,LastName, Dob,Gender,Phone,Email,Country,City,Region) VALUES (@FirstName,@LastName, @Dob,@Gender,@Phone,@Email,@Country,@City,@Region);
END

--UPDATE
CREATE PROCEDURE spUPDATE_DONOR_INFO
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
	UPDATE DONOR_INFO SET FirstName = @FirstName,LastName = @LastName,Gender = @Gender,Phone = @Phone,Email = @Email,Country = @Country,City = @City,Region = @Region where id = @id;
END

--SEARCH
CREATE PROCEDURE spLOAD_SEARCH
@ID INT
AS
BEGIN
	SELECT * FROM DONOR_INFO WHERE ID = @ID
END

--DISPLAY
CREATE PROCEDURE spDISPLAY_DONOR_INFO
AS
BEGIN
	SELECT * FROM DONOR_INFO;
END

CREATE TABLE DONOR_ACCOUNTS
(
ID int,
UserName varchar(50),
Password varchar(50),
Foreign key(ID) references DONOR_INFO(ID)
);


--INSERT
CREATE PROCEDURE spINSERT_DONOR_ACCOUNTS
@ID INT,
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(50)
AS
BEGIN
	INSERT INTO DONOR_ACCOUNTS(ID,USERNAME, PASSWORD) VALUES (@ID,@USERNAME,@PASSWORD);
END

--UPDATE
CREATE PROCEDURE spUPDATE_DONOR_ACCOUNTS
@ID INT,
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(50)
AS
BEGIN
	UPDATE DONOR_ACCOUNTS SET USERNAME = @USERNAME, PASSWORD = @PASSWORD WHERE ID = @ID;
END

--SEARCH

CREATE PROCEDURE spLOAD_SEARCH_ACCOUNTS
@ID INT
AS
BEGIN
	SELECT * FROM DONOR_ACCOUNTS WHERE ID = @ID
END

--DISPLAY
CREATE PROCEDURE spDISPLAY_DONOR_ACCOUNTS
AS
BEGIN
	SELECT * FROM DONOR_ACCOUNTS;
END

/*CREATE FUNCTION findAge(@id int)
returns int
begin
as
declare @age int;
select @age = datediff(YEAR, Dob, GetDate()) from DONOR_INFO where ID = id;
return @age;
end
*/

--employee
CREATE TABLE EMP_INFO
(
ID int primary key IDENTITY (1,1000),
FirstName varchar(50),
LastName varchar(50),
Dob varchar(50),
Gender varchar(6),
Phone varchar(50),
Email varchar(50),
Country varchar(50),
City varchar(50),
Region varchar(50),
Stat bit
);
DROP TABLE EMP_INFO;
Alter table EMP_INFO auto_increment = 1000;
--STORED PROCEDURES FOR EMPLOYES

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
@Stat bit
AS
BEGIN
	INSERT INTO EMP_INFO(FirstName,LastName, Dob,Gender,Phone,Email,Country,City,Region,Stat) VALUES (@FirstName,@LastName, @Dob,@Gender,@Phone,@Email,@Country,@City,@Region,@Stat);
END

--UPDATE
CREATE PROCEDURE spUPDATE_EMP_INFO
@id int,
@FirstName varchar(50),
@LastName varchar(50),
@Gender varchar(6),
@Phone varchar(50),
@Email varchar(50),
@Country varchar(50),
@City varchar(50),
@Region varchar(50),
@Stat bit
AS
BEGIN
	UPDATE EMP_INFO SET FirstName = @FirstName,LastName = @LastName,Gender = @Gender,Phone = @Phone,Email = @Email,Country = @Country,City = @City,Region = @Region, Stat = @Stat where id = @id;
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

--DISPLAY
CREATE PROCEDURE spDISPLAY_EMP_INFO
AS
BEGIN
	SELECT * FROM EMP_INFO;
END

SELECT *FROM EMP_ACCOUNTS;
INSERT INTO EMP_INFO(FirstName, LastName, Dob, Gender, Phone, Email, Country, City, Region, Stat) VALUES ('ee', 'ee', '12/12/12', 'Female', 'ee', 'ee', 'ee', 'ee', 'ee', 0);
INSERT INTO EMP_ACCOUNTS VALUES (1003,'ee', 'ee');

CREATE TABLE EMP_ACCOUNTS
(
ID int,
UserName varchar(50),
Password varchar(50),
Foreign key(ID) references EMP_INFO(ID)
);
DROP TABLE EMP_ACCOUNTS;
--INSERT
CREATE PROCEDURE spINSERT_EMP_ACCOUNTS
@ID INT,
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(50)
AS
BEGIN
	INSERT INTO EMP_ACCOUNTS(ID,USERNAME, PASSWORD) VALUES (@ID,@USERNAME,@PASSWORD);
END

--UPDATE
CREATE PROCEDURE spUPDATE_EMP_ACCOUNTS
@ID INT,
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(50)
AS
BEGIN
	UPDATE EMP_ACCOUNTS SET USERNAME = @USERNAME, PASSWORD = @PASSWORD WHERE ID = @ID;
END

--SEARCH

CREATE PROCEDURE spLOAD_SEARCH_EMP_ACCOUNTS
@ID INT
AS
BEGIN
	SELECT * FROM EMP_ACCOUNTS WHERE ID = @ID
END

--DISPLAY
CREATE PROCEDURE spDISPLAY_EMP_ACCOUNTS
AS
BEGIN
	SELECT * FROM EMP_ACCOUNTS;
END

drop table emp_accounts;
select * from emp_accounts;



CREATE TABLE DONOR_PERCHECK
(
ID int,
HeartProblems bit,
HIV bit,
HepB bit,
HepC bit,
STD bit,
Cancer bit,
TB bit,
KidneyProblems bit,
AbnormalBleeding bit,
Foreign key (ID) references DONOR_INFO(ID)
);

--INSERT

CREATE PROCEDURE spINSERT_DONOR_PERCHECK
@ID int,
@HeartProblems bit,
@HIV bit,
@HepB bit,
@HepC bit,
@STD bit,
@Cancer bit,
@TB bit,
@KidneyProblems bit,
@AbnormalBleeding bit
AS
BEGIN
	INSERT INTO DONOR_PERCHECK VALUES(@ID,@HeartProblems,@HIV,@HepB,@HepC,@STD,@Cancer,@TB,@KidneyProblems,@AbnormalBleeding);
END
--I DONT THINK WE CAN UPDATE OR DELETE THIS BUT LET IT BE LEGIZEW
--UPDATE
CREATE PROCEDURE spUPDATE_DONOR_PERCHECK
@ID int,
@HeartProblems bit,
@HIV bit,
@HepB bit,
@HepC bit,
@STD bit,
@Cancer bit,
@TB bit,
@KidneyProblems bit,
@AbnormalBleeding bit
AS
BEGIN
	UPDATE DONOR_PER_CHECK SET ID = @ID,HeartProblems = @HeartProblems,HIV = @HIV,HepB = @HepB,HepC = @HepC,STD = @STD,Cancer = @Cancer,TB = @TB,KidneyProblems = @KidneyProblems,AbnormalBleeding = @AbnormalBleeding	WHERE ID = @ID;
END
--DELETE

--SEARCH

CREATE PROCEDURE spLOAD_SEARCH_DONOR_PER_CHECK
@ID INT
AS
BEGIN
	SELECT * FROM DONOR_PER_CHECK WHERE ID = @ID
END

--DISPLAY
CREATE PROCEDURE spDISPLAY_DONOR_PER_CHECK
AS
BEGIN
	SELECT * FROM DONOR_PER_CHECK;
END


CREATE TABLE DONOR_72CHECKS
(
ID int,
Antibiotics bit,
Steroids bit,
Asprin bit,
Vaccination bit,
Alcohol bit,
Foreign key (ID) references DONOR_INFO(ID)
);

--INSERT
CREATE PROCEDURE spINSERT_DONOR_72CHECKS
@ID int,
@Antibiotics bit,
@Steroids bit,
@Asprin bit,
@Vaccination bit,
@Alcohol bit
AS
BEGIN
	INSERT INTO DONOR_72CHECKS VALUES (@ID,@Antibiotics,@Steroids,@Asprin,@Vaccination,@Alcohol);
END

--UPDATE
CREATE PROCEDURE spUPDATE_DONOR_72CHECKS
@ID int,
@Antibiotics bit,
@Steroids bit,
@Asprin bit,
@Vaccination bit,
@Alcohol bit
AS
BEGIN
	UPDATE DONOR_72CHECKS SET ID = @ID,Antibiotics = @Antibiotics,Steroids = @Steroids,Asprin = @Asprin,Vaccination = @Vaccination,Alcohol = @Alcohol WHERE ID = @ID;
END
--I  DONT THINK IT CAN DELETED
--DELETE
CREATE PROCEDURE spDELETE_DONOR_72CHECKS
@ID INT 
AS
BEGIN
	DELETE FROM DONOR_72CHECKS WHERE ID = @ID;
END

--SEARCH
CREATE PROCEDURE spLOAD_SEARCH_DONOR_72CHECKS
@ID INT
AS
BEGIN
	SELECT * FROM DONOR_72CHECKS WHERE ID = @ID
END

--DISPLAY
CREATE PROCEDURE spDISPLAY_DONOR_72CHECKS
AS
BEGIN
	SELECT * FROM DONOR_72CHECKS;
END


CREATE TABLE DONOR_3MON(
ID int,
Tattoo bit,
Ear_Piercing bit,
Dental_Extraction bit,
Major_Surgery bit,
Minor_Surgery bit,
Foreign key (ID) references DONOR_INFO(ID)
);

--INSERT
CREATE PROCEDURE spINSERT_DONOR_3MON
@ID int,
@Tattoo bit,
@Ear_Piercing bit,
@Dental_Extraction bit,
@Major_Surgery bit,
@Minor_Surgery bit
AS
BEGIN
	INSERT INTO DONOR_3MON VALUES (@ID,@Tattoo,@Ear_Piercing,@Dental_Extraction,@Major_Surgery,@Minor_Surgery);
END

--UPDATE
CREATE PROCEDURE spUPDATE_DONOR_3MON
@ID int,
@Tattoo bit,
@Ear_Piercing bit,
@Dental_Extraction bit,
@Major_Surgery bit,
@Minor_Surgery bit
AS
BEGIN
	UPDATE DONOR_3MON SET Tattoo = @Tattoo,Ear_Piercing = @Ear_Piercing,Dental_Extraction = @Dental_Extraction, Major_Surgery = @Major_Surgery, Minor_Surgery = @Minor_Surgery WHERE ID = @ID
END
--SEARCH
CREATE PROCEDURE spLOAD_SEARCH_DONOR_3MON
@ID INT
AS
BEGIN
	SELECT * FROM DONOR_3MON WHERE ID = @ID
END

--DISPLAY
CREATE PROCEDURE spDISPLAY_DONOR_3MON
AS
BEGIN
	SELECT * FROM DONOR_3MON;
END

CREATE TABLE FULL_CHECK(
ID int,
Check72 bit,
Check3 bit,
CheckPer bit,
Foreign key (ID) references DONOR_INFO(ID)
);

--INSERT
CREATE PROCEDURE spINSERT_FULL_CHECK
@ID int,
@Check72 bit,
@Check3 bit,
@CheckPer bit
AS
BEGIN
	INSERT INTO FULL_CHECK VALUES(@ID,@CHECK72,@CHECK3,@CHECKPER);
END
--UPDATE
CREATE PROCEDURE spUPDATE_FULL_CHECK
@ID int,
@Check72 bit,
@Check3 bit,
@CheckPer bit
AS
BEGIN
	UPDATE FULL_CHECK SET Check72 = @Check72,Check3 = @Check3,CheckPer = @CheckPer WHERE ID = @ID;
END

--SEARCH
CREATE PROCEDURE spLOAD_SEARCH_FULL_CHECK
@ID INT
AS
BEGIN
	SELECT * FROM FULL_CHECK WHERE ID = @ID
END

--DISPLAY
CREATE PROCEDURE spDISPLAY_FULL_CHECK
AS
BEGIN
	SELECT * FROM FULL_CHECK;
END
--drop table full_check;

CREATE TABLE SUCCESSFUL_DONATION(
BloodID int primary key IDENTITY,
ID int,
DateDonated varchar(30),
Venue varchar(50),
BloodType varchar(2),
Foreign key (ID) references DONOR_INFO(ID)
);
Alter table SUCCESSFUL_DONATION ALTER COLUMN BLOODID INT IDENTITY(1000);
-- successful_donation should initiate a trigger that would add value to blood count
select * from successful_donation;

--INSERT
CREATE PROCEDURE spINSERT_SUCCESSFUL_DONATION
@ID int,
@DateDonated varchar(30),
@Venue varchar(50),
@BloodType varchar(2)
AS
BEGIN
	INSERT INTO SUCCESSFUL_DONATION VALUES (@ID,@DateDonated,@Venue,@BloodType);
END

--UPDATE
CREATE PROCEDURE spUPDATE_SUCCESSFUL_DONATION
@ID int,
@DateDonated varchar(30),
@Venue varchar(50),
@BloodType varchar(2)
AS
BEGIN
	UPDATE SUCCESSFUL_DONATION SET DateDonated = @DateDonated,Venue = @Venue,BloodType = @BloodType WHERE ID = @ID;
END
--SEARCH
CREATE PROCEDURE spLOAD_SEARCH_SUCCESSFUL_DONATION
@ID INT
AS
BEGIN
	SELECT * FROM SUCCESSFUL_DONATION WHERE ID = @ID
END

--DISPLAY
CREATE PROCEDURE spDISPLAY_SUCCESSFUL_DONATION
AS
BEGIN
	SELECT * FROM SUCCESSFUL_DONATION;
END

CREATE TABLE FAIL_HISTORY(
ID int,
DateDonated varchar(30),
Weight int,
BPsys int,
BPdy int,
Anemic bit,
Foreign key (ID) references DONOR_INFO(ID)
);

--INSERT
CREATE PROCEDURE spINSERT_FAIL_HISTORY
@ID int,
@DateDonated varchar(30),
@Weight int,
@BPsys int,
@BPdy int,
@Anemic bit
AS
BEGIN
	INSERT INTO FAIL_HISTORY VALUES(@ID,@DateDonated,@Weight,@BPsys,@BPdy,@Anemic);
END

--UPDATE
CREATE PROCEDURE spUPDATE_FAIL_HISTORY
@ID int,
@DateDonated varchar(30),
@Weight int,
@BPsys int,
@BPdy int,
@Anemic bit
AS
BEGIN
	UPDATE FAIL_HISTORY SET DateDonated = @DateDonated,Weight = @Weight,BPsys = @BPsys,BPdy = @BPdy,Anemic = @Anemic WHERE ID = @ID;
END
--SEARCH
CREATE PROCEDURE spLOAD_SEARCH_FAIL_HISTORY
@ID INT
AS
BEGIN
	SELECT * FROM FAIL_HISTORY WHERE ID = @ID
END

--DISPLAY
CREATE PROCEDURE spDISPLAY_FAIL_HISTORY
AS
BEGIN
	SELECT * FROM FAIL_HISTORY;
END
--no need of stored
CREATE TABLE BLOOD_COUNT(
bloodtype varchar(2),
count int
);