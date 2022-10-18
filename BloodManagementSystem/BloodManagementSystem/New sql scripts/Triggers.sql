-- triggers used

CREATE TRIGGER BLOOD_COUNT_INCREMENT
ON SUCCESSFUL_DONATION
AFTER INSERT
AS
BEGIN
        DECLARE @type varchar(3);
        SELECT @type = BloodType from INSERTED;
        UPDATE BLOOD_COUNT set bloodcount += 1 where bloodtype = @type;
		
END

CREATE TRIGGER PHONE_EMAIL_VERIFICATION
ON DONOR_INFO
AFTER INSERT
AS
BEGIN
        DECLARE @phone varchar(30), @email varchar(50);
        SELECT @phone = Phone, @email = Email from INSERTED;
        IF EXISTS(SELECT * from DONOR_INFO where Phone = @phone or Email = @email)
                BEGIN
                        -- delete sp
                END
END

CREATE TRIGGER TRANSFER_DECREMENT
ON TRANSFER_INFO
AFTER INSERT
AS
BEGIN
	DECLARE @valap int, @valam int, @valbp int, @valbm int, @valabp int, @valabm int, @valop int, @valom int;
	SELECT @valap = Ap, @valam = Am, @valbp = Bp, @valbm = Bm, @valabp = Abp, @valabm = Abm, @valop = Op, @valom = Om from INSERTED;
	UPDATE BLOOD_COUNT set bloodcount -= @valap where bloodtype = 'A+';
	UPDATE BLOOD_COUNT set bloodcount -= @valam where bloodtype = 'A-';
	UPDATE BLOOD_COUNT set bloodcount -= @valbp where bloodtype = 'B+';
	UPDATE BLOOD_COUNT set bloodcount -= @valbm where bloodtype = 'B-';
	UPDATE BLOOD_COUNT set bloodcount -= @valabp where bloodtype = 'AB+';
	UPDATE BLOOD_COUNT set bloodcount -= @valabm where bloodtype = 'AB-';
	UPDATE BLOOD_COUNT set bloodcount -= @valop where bloodtype = 'O+';
	UPDATE BLOOD_COUNT set bloodcount -= @valom where bloodtype = 'O-';

	-- EXEC spDECREMENT_BLOODCOUNT @valap, 'A+';
	-- EXEC spDECREMENT_BLOODCOUNT @valam, 'A-';
	-- EXEC spDECREMENT_BLOODCOUNT @valbp, 'B+';
	-- EXEC spDECREMENT_BLOODCOUNT @valbm, 'B-';
	-- EXEC spDECREMENT_BLOODCOUNT @valabp, 'AB+';
	-- EXEC spDECREMENT_BLOODCOUNT @valabm, 'AB-';
	-- EXEC spDECREMENT_BLOODCOUNT @valop, 'O+';
	-- EXEC spDECREMENT_BLOODCOUNT @valom, 'O-';
END
	

