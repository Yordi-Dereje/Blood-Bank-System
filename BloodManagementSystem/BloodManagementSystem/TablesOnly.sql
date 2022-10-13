use BloodOct2;
-- all the tables for access

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

CREATE TABLE DONOR_ACCOUNTS
(
ID int,
UserName varchar(50),
Password varchar(50),
Foreign key(ID) references DONOR_INFO(ID)
);

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

CREATE TABLE DONOR_3MON(
ID int,
Tattoo bit,
Ear_Piercing bit,
Dental_Extraction bit,
Major_Surgery bit,
Minor_Surgery bit,
Foreign key (ID) references DONOR_INFO(ID)
);

CREATE TABLE FULL_CHECK(
ID int,
Check72 bit,
Check3 bit,
CheckPer bit,
Foreign key (ID) references DONOR_INFO(ID)
);
select * from full_check;

CREATE TABLE SUCCESSFUL_DONATION(
BloodID int primary key IDENTITY,
ID int,
DateDonated varchar(30),
Venue varchar(50),
BloodType varchar(3),
Foreign key (ID) references DONOR_INFO(ID)
);


select * from SUCCESSFUL_DONATION;

CREATE TABLE FAIL_HISTORY(
ID int,
DateDonated varchar(30),
Weight int,
BPsys int,
BPdy int,
Anemic bit,
Foreign key (ID) references DONOR_INFO(ID)
);

select * from FAIL_HISTORY;

CREATE TABLE BLOOD_COUNT(
bloodtype varchar(3),
bloodcount int
);




CREATE TABLE DONATION_INFO(
Donor_ID int,
Medical_Stat varchar(10),
Donation_Stat varchar(15),
Foreign key (Donor_ID) references DONOR_INFO(ID)
);

CREATE TABLE EMP_INFO
(
ID int primary key IDENTITY,
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

select * from emp_info;

CREATE TABLE EMP_ACCOUNTS
(
ID int,
UserName varchar(50),
Password varchar(50),
Foreign key(ID) references EMP_INFO(ID)
);


