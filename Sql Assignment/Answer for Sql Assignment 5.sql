--1
select c.iname ,SUM(o.amount) as total 
from customer c
join [order] o
on c.cust_id = o.cust_id
where o.order_date = '2002'

--2
select firstname, lastname
from person
where lastname like 'A%'

--3
select x.name, count(*) from person p 
left join (select * from person p where manager_id is null) x 
on p.person_id= x.manager_id 
group by x.name

--4
-- insert update and delete can cause trigger

--5.a
create table Company(CompanyID int primary key, CompanyName varchar(20) not null)
--5.b
create table Division(DivisionID int primary key, DivisionName varchar(20)not null)
--5.c
create table Contacts(CompanyID int foreign key, DivisionID int foreign key, locationName varchar(20) foreign key,primary key(CompanyID, DivisionID, locationName))
--5.d
create table PhysicalLocation(locationID int primary key, address varchar(20) not null)
--5.e
create table ContactsAddress(locationID int primary key, mailAddress varchar(30))