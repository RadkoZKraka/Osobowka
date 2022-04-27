create table Persons(
    PersonID int primary key,
    FirstName varchar,
    LastName varchar,
    Address varchar,
    City varchar,
);

select * from Persons;

insert into Persons values (1, N'Radosław', 'Krowicki', N'Poznańska 15/118', N'Kraków');

alter table Persons alter column FirstName varchar(255);
alter table Persons alter column LastName varchar(255);
alter table Persons alter column Address varchar(255);
alter table Persons alter column City varchar(255);