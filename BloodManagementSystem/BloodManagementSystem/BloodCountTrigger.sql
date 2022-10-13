use BloodOct2;
insert into BLOOD_COUNT values('A+', 0);
insert into BLOOD_COUNT values('B+', 0);
insert into BLOOD_COUNT values('AB+', 0);
insert into BLOOD_COUNT values('O+', 0);
insert into BLOOD_COUNT values('A-', 0);
insert into BLOOD_COUNT values('B-', 0);
insert into BLOOD_COUNT values('AB-', 0);
insert into BLOOD_COUNT values('O-', 0);

create trigger bloodcountAffected
ON SUCCESSFUL_DONATION
after insert
as
begin
	declare @type varchar(3);
	select @type = BloodType from INSERTED;
	update BLOOD_COUNT set bloodcount += 1 where bloodtype = @type;
end

select * from BLOOD_COUNT;