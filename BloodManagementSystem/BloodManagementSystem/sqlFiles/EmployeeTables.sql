use BloodBankSql;

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
SELECT *FROM EMP_INFO;
INSERT INTO EMP_INFO VALUES('SEBRINA','ABDULREZAK','23/23/2022','FEMALE','0987654321','SEB@AA18','ETH','ADD','ADD',2000,1);
INSERT INTO EMP_ACCOUNTS VALUES(4,'EE','EE');
SELECT *FROM EMP_ACCOUNTS
CREATE TABLE EMP_ACCOUNTS
(
ID int,
UserName varchar(50),
Password varchar(50),
Foreign key(ID) references EMP_INFO(ID)
);