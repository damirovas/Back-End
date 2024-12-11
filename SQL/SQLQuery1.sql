create database CourseDb
use CourseDb
create table Students
(
	Id int not null unique ,
	FirstName nvarchar(20) not null,
	LastName nvarchar(20),
	Age int 
)
drop table Students
--DDL Data Definition


--DML 
--update table
alter table Students
add GPA int not null

alter table Students
drop column Age


alter table Students
add Age int not null

alter table Students
alter column GPA decimal(5,2)
drop table Students
drop database CourseDb
