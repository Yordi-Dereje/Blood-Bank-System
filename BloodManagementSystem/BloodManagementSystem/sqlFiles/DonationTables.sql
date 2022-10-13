use BloodBankSql;

-- permanent illness
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

--Procedures done within 72 hours before donation
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

-- Procedures done within 3 months before donation
CREATE TABLE DONOR_3MON(
ID int,
Tattoo bit,
Ear_Piercing bit,
Dental_Extraction bit,
Major_Surgery bit,
Minor_Surgery bit,
Foreign key (ID) references DONOR_INFO(ID)
);

-- All 3 checkers deduced to one table used for temporary storage
CREATE TABLE FULL_CHECK(
ID int,
Check72 bit,
Check3 bit,
CheckPer bit,
Foreign key (ID) references DONOR_INFO(ID)
);

-- Successfully completed donations
CREATE TABLE SUCCESSFUL_DONATION(
BloodID int primary key IDENTITY,
ID int,
DateDonated varchar(30),
Venue varchar(50),
BloodType varchar(3),
Foreign key (ID) references DONOR_INFO(ID)
);

-- Failed donations
CREATE TABLE FAIL_HISTORY(
ID int,
DateDonated varchar(30),
Weight int,
BPsys int,
BPdy int,
Anemic bit,
Foreign key (ID) references DONOR_INFO(ID)
);

-- BLOOD COUNT
CREATE TABLE BLOOD_COUNT(
bloodtype varchar(3),
count int
);

-- PERMANENT ILLNESS LIST
CREATE TABLE PERMANENTLY_ILL(
id int,
illness varchar(30),
foreign key (id) references DONOR_INFO(id)
);

