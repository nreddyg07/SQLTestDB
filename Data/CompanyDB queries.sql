CREATE DATABASE CompanyDB;
USE CompanyDB;
GO

CREATE TABLE Employee(
EmpID INT IDENTITY(1,1) PRIMARY KEY,
Name NVARCHAR(100),
Email NVARCHAR(100),
Dept NVARCHAR(50),
Salary DECIMAL(10,2)
);

CREATE TABLE Department(
DeptID INT IDENTITY(1,1) PRIMARY KEY,
DeptName NVARCHAR(50)
);

INSERT INTO Employee(Name, Email, Dept, Salary) VALUES ('Anita','anit@gmail.com','HR', 45000), ('Rohit','rohit@gmail.com', 'IT', 50000);

INSERT INTO Department(DeptName) VALUES ('IT'),('HR'), ('Tech'), ('Finance');

SELECT * FROM Employee;

DELETE FROM Employee WHERE EmpID=8;

