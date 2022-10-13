Create database BloodBankSql;
Use BloodBankSql;

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
