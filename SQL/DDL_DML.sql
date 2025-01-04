create database LibraryDb
use LibraryDb

create table Genres
(
	Id int primary key identity,
	[Name] nvarchar(25) not null unique
)
create table Books
(
 Id int  primary key identity not null,
 [Name] nvarchar(40) not null,
 [Page] int not null ,
 Author nvarchar(30) 
)
alter table Books
drop column Author
alter table Books
add [Count] int 

alter table Books
add Price float

alter table Books
alter column Price decimal(9,2)

alter table Genres
drop constraint  UQ__Genres__737584F69B3BB5C6

alter table Genres
add constraint UG_Genres_Name unique([Name])

insert into Genres
values('Dedective'),('Roman'),('Elmi')

update  Genres
set [Name]='Science'
where Id=1
delete Genres
where Id=1

select * from Genres
order by Id

truncate table Genres

alter table Books
add GenreId int foreign Key  references Genres(Id)

insert into Books
values
('Pride&Prejudice',120,40,20.99,2),
('Becomin Jane',100,50,23,2),
('Atomic',240,12,12.99,1)
select * from Books

create table Authors
(
 Id int primary Key identity not null,
 FirstName nvarchar(50) not null,
 LastName nvarchar(50) not null
)
create table AuthorBooks
(
Id int primary key identity,
AuthorId int foreign key references Authors(Id),
BookId int foreign key references Books(Id)
)
insert into Authors
values('Jane','Austen'),('Filankesov','Filankes'),
		('Fesmankesov','Fesmankes')
select * from Books
insert into AuthorBooks(BookId,AuthorId)
values (2,1),(1,2),(3,2)

select b.[Name] as BookName,
		b.[Page] as BookPage,
		b.[Count] as BookCount,
		b.Price as BookPrice,
		g.[Name] as BookGenre
 from Books as b
join Genres as g
on g.Id=b.GenreId
select *from Books

select b.[Name] as BookName,
		b.[Page] as BookPage,
		b.[Count] as BookCount,
		b.Price as BookPrice,
		g.[Name] as BookGenre
 from Books as b
 right join Genres as g
on g.Id=b.GenreId





