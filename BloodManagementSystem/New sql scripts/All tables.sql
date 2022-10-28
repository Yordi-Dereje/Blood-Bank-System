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



drop table donor_info;

CREATE TABLE DONOR_ACCOUNTS
(
ID int,
UserName varchar(50),
Password varchar(50),
Foreign key(ID) references DONOR_INFO(ID)
);

drop table donor_accounts;
select * from DONOR_INFO;

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

DELETE from EMP_INFO;

CREATE TABLE EMP_ACCOUNTS
(
ID int,
UserName varchar(50),
Password varchar(50),
Foreign key(ID) references EMP_INFO(ID)
);



insert into EMP_INFO(FirstName, LastName, Dob, Gender, Phone, Email, Country, City, Region, Salary, Stat) values('abe', 'kebe', '12/12/2000', 'Male', 'phone', 'email', 'bb','bb','bb', 10000, 1);
insert into EMP_ACCOUNTS values (1, 'abe', 'kebe');
select * from DONOR_ACCOUNTS;


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

drop table donor_percheck;

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

drop table donor_72checks;

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

drop table donor_3mon;

-- All 3 checkers deduced to one table used for temporary storage
CREATE TABLE FULL_CHECK(
ID int,
Datee varchar(50),
Check72 int,
Check3 int,
CheckPer int,
Foreign key (ID) references DONOR_INFO(ID)
);

drop table full_check;

-- Successfully completed donations
CREATE TABLE SUCCESSFUL_DONATION(
BloodID int primary key IDENTITY,
ID int,
DateDonated varchar(30),
Venue varchar(50),
BloodType varchar(3),
Foreign key (ID) references DONOR_INFO(ID)
);

drop table successful_donation;


SELECT * FROM  DONATION_CHART GROUP BY COUNT,MONTHS,YEARS ORDER BY MONTHS DESC
DROP TABLE  DONATION_CHART
CREATE TABLE DONATION_CHART
(
COUNT INT,
YEARS INT,
MONTHS VARCHAR(20)
);
INSERT INTO DONATION_CHART VALUES(10,'2022','SEPTEMBER');
INSERT INTO DONATION_CHART VALUES(20,'2022','OCTOBER');
INSERT INTO DONATION_CHART VALUES(30,'2022','DECEMBER');
INSERT INTO DONATION_CHART VALUES(10,'2022','JANUARY');
INSERT INTO DONATION_CHART VALUES(50,'2022','MARCH');
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

drop table fail_history;


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


-- Illness info
CREATE TABLE ILLNESS_INFO(
Name varchar(30),
Description varchar(1000)
);

select * from ILLNESS_INFO;
drop table ILLNESS_INFO;

Insert into ILLNESS_INFO values('Heart problems', 'Heart disease describes a range of conditions that affect your heart.  Heart diseases include several series of illness as blood vessel disease, heart rhythm problems (arrhythmias), congenital heart defects, heart valve disease, heart muscle defects and more.');
Insert into ILLNESS_INFO values('HIV/AIDS', 'Acquired immunodeficiency syndrome (AIDS) is a chronic, potentially life-threatening   condition caused by the human immunodeficiency virus (HIV). By damaging your immune system, HIV interferes with your ability   to fight infection and disease. HIV is a sexually transmitted infection (STI). It can also be spread by contact with infected blood');
Insert into ILLNESS_INFO values('Hepatitis B', 'Hepatitis B infection is caused by the hepatitis B virus (HBV). The virus is passed from person to person through blood, semen or other body fluids. ');
Insert into ILLNESS_INFO values('Hepatitis C', 'Hepatitis C is a viral infection that causes liver inflammation, sometimes leading to serious liver damage. The hepatitis C virus (HCV) spreads through contaminated blood.');
Insert into ILLNESS_INFO values('Sexually Transmitted Diseases', 'A disease caused by infection passed through unprotected sexual contact. It can be bacterial such as Gonorrhea and Syphilis, parasitical such as Trichomoniasis and viral such as HPV, genital herpes and HIV.');
Insert into ILLNESS_INFO values('Cancer', 'Cancer is a group of diseases involving abnormal cell growth with the potential to invade or spread to other parts of the body. There are over 100 types of cancers.');
Insert into ILLNESS_INFO values('Tuberculosis', 'Tuberculosis (TB) is a potentially serious infectious disease that mainly affects the lungs. The bacteria that cause tuberculosis are spread from person to person through tiny droplets released into the air via coughs and sneezes.');
Insert into ILLNESS_INFO values('Kidney problems', 'Kidney disease means your kidneys are damaged and can’t filter blood the way they should. Injuries on the kidneys include acute kidney injury, kidney cysts, kidney stones, and kidney infections.');
Insert into ILLNESS_INFO values('Abnormal Bleeding', 'Abnormal uterine bleeding is a menstrual cycle disorder. Any bleeding that is outside of your regular cyclic menstruation is considered abnormal uterine bleeding. Any change in the amount or duration of your period is also considered abnormal uterine bleeding.');


