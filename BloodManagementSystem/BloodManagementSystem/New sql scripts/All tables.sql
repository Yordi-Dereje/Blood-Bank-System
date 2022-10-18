-- all tables

CREATE DATABASE BloodBankSql;
Use BloodBankSql;

-- donor table
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
Region varchar(50),
BloodType varchar(3)
);

CREATE TABLE DONOR_ACCOUNTS
(
ID int,
UserName varchar(50),
Password varchar(50),
Foreign key(ID) references DONOR_INFO(ID)
);

-- employee
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
Salary int,
Stat bit
);

CREATE TABLE EMP_ACCOUNTS
(
ID int,
UserName varchar(50),
Password varchar(50),
Foreign key(ID) references EMP_INFO(ID)
);

-- donation tables

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
bloodcount int
);

insert into BLOOD_COUNT values('A+', 10);
insert into BLOOD_COUNT values('B+', 10);
insert into BLOOD_COUNT values('AB+', 10);
insert into BLOOD_COUNT values('O+', 10);
insert into BLOOD_COUNT values('A-', 10);
insert into BLOOD_COUNT values('B-', 10);
insert into BLOOD_COUNT values('AB-', 10);
insert into BLOOD_COUNT values('O-', 10);

select * from BLOOD_COUNT;
drop table BLOOD_COUNT;


-- Hospital info
CREATE TABLE HOSPITAL_INFO(
Name varchar(50) primary key,
Phone varchar(15),
Email varchar(20),
Country varchar(50),
City varchar(50),
Region varchar(50),
Ownership varchar(50)
);
select * from HOSPITAL_INFO;


-- Transfer info
CREATE TABLE TRANSFER_INFO(
ID int primary key identity,
Hospital varchar(50),
Ap int,
Am int,
Bp int,
Bm int,
ABp int,
ABm int,
Op int,
Om int,
Date varchar(50),
Foreign key(Hospital) references HOSPITAL_INFO(Name)
);

drop table transfer_info;

select * from TRANSFER_INFO;
