--Hello Address Book Program Day-33 Program--

/*
create database payroll_service;
show database;
use payroll_service;
*/
CREATE TABLE employee_payroll
(
ID int primary key IDENTITY(1,1) NOT NULL,
Name varchar(50) NULL,
Salary decimal NULL,
StartDate date NULL
);


