--Hello Address Book Program Day-33 Program--

/*
create database payroll_service;
show database;
use payroll_service;

CREATE TABLE employee_payroll
(
ID int primary key IDENTITY(1,1) NOT NULL,
Name varchar(50) NULL,
Salary decimal NULL,
StartDate date NULL
);
*/

Insert Into employee_payroll
(Name,Salary,StartDate) 
values
('Shyam',12340,'2022-08-01');

Select * from employee_payroll;

update employee_payroll set Name='Mohan',Salary=12000 where Id=2;

delete from employee_payroll where Id=2

