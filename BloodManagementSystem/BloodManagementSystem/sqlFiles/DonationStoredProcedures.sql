use BloodBankSql;

-- 72 hour checks

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

--SEARCH
CREATE PROCEDURE spLOAD_SEARCH_DONOR_72CHECKS
@ID INT
AS
BEGIN
	SELECT * FROM DONOR_72CHECKS WHERE ID = @ID
END

-- 3 months check

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

--SEARCH
CREATE PROCEDURE spLOAD_SEARCH_DONOR_3MON
@ID INT
AS
BEGIN
	SELECT * FROM DONOR_3MON WHERE ID = @ID
END

-- Permanent check

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

--SEARCH
CREATE PROCEDURE spLOAD_SEARCH_DONOR_PER_CHECK
@ID INT
AS
BEGIN
	SELECT * FROM DONOR_PER_CHECK WHERE ID = @ID
END

-- Full checkers

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

-- DISPLAY
CREATE PROCEDURE spDISPLAY_FULL_CHECK
AS
BEGIN
	SELECT * FROM FULL_CHECK;
END

-- DELETE
CREATE PROCEDURE spDELETE_FULL_CHECK
@ID int
AS
BEGIN
	DELETE FROM FULL_CHECK WHERE ID = @ID
END

-- SUCCESSFUL DONATION

-- INSERT
CREATE PROCEDURE spINSERT_SUCCESSFUL_DONATION
@ID int,
@DateDonated varchar(30),
@Venue varchar(50),
@BloodType varchar(3)
AS
BEGIN
	INSERT INTO SUCCESSFUL_DONATION VALUES (@ID,@DateDonated,@Venue,@BloodType);
END

-- SEARCH
CREATE PROCEDURE spLOAD_SEARCH_SUCCESSFUL_DONATION
@ID INT
AS
BEGIN
	SELECT * FROM SUCCESSFUL_DONATION WHERE ID = @ID
END

-- DISPLAY
CREATE PROCEDURE spDISPLAY_SUCCESSFUL_DONATION
AS
BEGIN
	SELECT * FROM SUCCESSFUL_DONATION;
END

-- Failed donations

-- INSERT
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

-- SEARCH
CREATE PROCEDURE spLOAD_SEARCH_FAIL_HISTORY
@ID INT
AS
BEGIN
	SELECT * FROM FAIL_HISTORY WHERE ID = @ID;
END

-- DISPLAY
CREATE PROCEDURE spDISPLAY_FAIL_HISTORY
AS
BEGIN
	SELECT * FROM FAIL_HISTORY;
END
