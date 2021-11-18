use Northwind
--1.a
insert into Region values (5, 'Middle Earth')

--1.b
insert into Territories values (11111,'Gondor',5)

--1.c
--SET IDENTITY_INSERT Employees ON
insert into Employees (EmployeeID, LastName,FirstName, City)values (10, 'King', 'Aragorn', 'Gondor')
insert into EmployeeTerritories values (@@IDENTITY,11111)

--2
update Territories set TerritoryDescription = 'Arnor'
where TerritoryDescription = 'Gondor'

--3
delete from EmployeeTerritories 
where TerritoryID = 11111
delete from Territories
where TerritoryID = 11111
delete from Region 
where RegionID = 5

--4
create view  view_product_order_Chen
as
select ProductName,SUM(Quantity) as TotalQTY from [Order Details] od JOIN Products p on p.ProductID = od.ProductID
group by ProductName

--5

create proc sp_product_order_quantity_Chen
	@ProductID int,
	@TotalQTY int out
as
	begin
	select @TotalQTY = SUM(Quantity) from [Order Details] od inner join Products p on p.ProductID = od.ProductID
	where p.ProductID = od.ProductID
	group by ProductName
	end
declare @Total int
EXEC sp_Product_Order_Quantity_Chen 11,@Total OUT
PRINT @Total
--6
create proc sp_product_order_city_Chen
	@ProductName varchar(20)
as
	begin
	select top 5 ShipCity, SUM(Quantity)
	from [Order Details] od inner join Products p
	on od.ProductID = p.ProductID
	inner join Orders o
	on o.OrderID = od.OrderID
	where ProductName = @ProductName
	group by ProductName, ShipCity
	order by SUM(Quantity) desc
	end

--7
create proc sp_product_move_employees_Chen
as
	begin 
	if exists (select EmployeeID from EmployeeTerritories where TerritoryID = (select TerritoryID from Territories where TerritoryDescription = 'Troy'))
	begin
	declare @id int 
	select @id = MAX(TerritoryID) from Territories


	end
	end

--8
--9

--10

create proc sp_birthday_employee_gaddam
as
	begin
	select * into #Temp
	from Employees where DATEPART(MM,BirthDate) = 02
	select * from #Temp
	end

--11
--12
--we can probably use except, or union statement to see the combination rows of two tables or use checksum statement
--14
--select concat(firstname, ' ', lastname, ' ' , Middlename) as FullName
--from Person
--15
--select top 1 marks from student where sex = 'F' order by marks desc
--16
--select student from students order by sex, marks

