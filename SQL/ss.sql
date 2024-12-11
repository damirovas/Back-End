create database CourseDb
use CourseDB
create table Students
(
  Id int unique,
  FirstName nvarchar(20) not null,
  LastName nvarchar(20),
  Age int not null

)
alter table Students
add GPA int not null

alter table Students
drop column Age

alter table Students
add Age int not null

alter table Students
alter column GPA decimal(2,2)


alter table Students
add constraint check_gpa_value
check (GPA>0)

ALter TaBle Students
add Constraint unique_id unique(Id)

alter table Students
drop constraint unique_id

alter table Students
drop constraint [UQ__Students__3214EC06A9073795]

alter table Students
add constraint unique_id unique(Id)

alter table Students
drop constraint unique_id

alter table Students
drop column Id

alter table Students
add Id int unique

alter table Students
add constraint unique_id unique(Id)

alter table Students
drop column Age 

alter table Students
add Age int check(Age>18) default 20
alter table Students
alter column GPA decimal(5,2)

insert Students(Id,FirstName,LastName,GPA,Age)
values (1,'Resul','Mirzeyev',80,19)
insert Students(Id,FirstName,LastName,GPA,Age)
values 
		(3,'Elxan','Musayev',11,21)
		
select * from Students

alter table Students
alter column Id int not null

ALTER TABLE Students
DROP CONSTRAINT UQ__Students__3214EC068B187CC8;
ALTER TABLE Students
DROP CONSTRAINT unique_id;
ALTER TABLE Students
ALTER COLUMN Id INT NOT NULL;
ALTER TABLE Students
ADD CONSTRAINT Student_Primary_Key PRIMARY KEY (Id);

create table Groups
(
	Id int primary key identity,
	[Name] varchar(30) not null unique
)
insert into Groups

VALUES ('GR2')
SELECT * FROM Groups