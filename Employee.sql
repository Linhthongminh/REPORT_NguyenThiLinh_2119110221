CREATE DATABASE HR

CREATE TABLE Employee(
ID_Employee nvarchar(30), 
Name nvarchar(255), 
DateBirth nvarchar(255), 
Gender bit, 
PlaceBirth nvarchar(255), 
ID_Department nvarchar(30)
)

GO

CREATE TABLE Department(
ID_Department nvarchar(30),
Name nvarchar(255)
)

INSERT INTO Employee VALUES ('C53418', 'Romelu Lukaku', '11/10/1993', 'true', 'Belgium', 'KT')
INSERT INTO Employee VALUES ('X53416', 'Mason Mount', '10/01/1999', 'true', 'England', 'KD')
INSERT INTO Employee VALUES ('M53417', 'Kai Havert', '11/6/1999', 'true', 'Germany', 'NS')
INSERT INTO Employee VALUES ('LTM121', N'Linh thông minh', '12/6/2001', 'false', N'Việt Nam', 'KT')

INSERT INTO Department VALUES ('NS', 'HR')
INSERT INTO Department VALUES ('KT', 'Accounting')
INSERT INTO Department VALUES ('KD', 'Business')

SELECT *FROM Employee
SELECT *FROM Department

DROP TABLE Employee
DROP TABLE Department

DELETE FROM Employee
DELETE FROM Department