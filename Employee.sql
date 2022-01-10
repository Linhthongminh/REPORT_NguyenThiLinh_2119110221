CREATE DATABASE HR

CREATE TABLE Employee_2119110221(
ID_Employee nvarchar(30), 
Name nvarchar(255), 
DateBirth nvarchar(255), 
Gender bit, 
PlaceBirth nvarchar(255), 
ID_Department nvarchar(30)
)

GO

CREATE TABLE Department_2119110221(
ID_Department nvarchar(30),
Name nvarchar(255)
)

INSERT INTO Employee_2119110221 VALUES ('C53418', 'Romelu Lukaku', '11/10/1993', 'true', 'Belgium', 'KT')
INSERT INTO Employee_2119110221 VALUES ('X53416', 'Mason Mount', '10/01/1999', 'true', 'England', 'KD')
INSERT INTO Employee_2119110221 VALUES ('M53417', 'Kai Havert', '11/6/1999', 'true', 'Germany', 'NS')
INSERT INTO Employee_2119110221 VALUES ('LTM121', N'Linh thông minh', '12/6/2001', 'false', N'Việt Nam', 'KT')

INSERT INTO Department_2119110221 VALUES ('NS', 'HR')
INSERT INTO Department_2119110221 VALUES ('KT', 'Accounting')
INSERT INTO Department_2119110221 VALUES ('KD', 'Business')

SELECT *FROM Employee_2119110221
SELECT *FROM Department_2119110221

DROP TABLE Employee_2119110221
DROP TABLE Department_2119110221