use AdventureWorks2019

--1
select COUNT(ProductID) "Total Products"
from Production.Product

--2
select COUNT(ProductID)
from Production.Product 
where ProductSubcategoryID is not null

--3
select  ps.ProductSubcategoryID, COUNT(p.ProductID) "CountedProducts"
from Production.Product p  right join Production.ProductSubcategory ps
on p.ProductSubcategoryID = ps.ProductSubcategoryID
where ps.ProductSubcategoryID is not null
group by ps.ProductSubcategoryID 

--4
select count(ProductID)
from Production.Product
where ProductSubcategoryID is null

--5
select SUM(Quantity) as SumOfProduct
from Production.ProductInventory

--6
select ProductID, SUM(Quantity) as TheSum
from Production.ProductInventory
where LocationID = 40 and Quantity < 100
group by ProductID

--7
select ProductID, Shelf,SUM(Quantity) as TheSum
from Production.ProductInventory
where LocationID = 40 and Quantity < 100
group by ProductID, Shelf

--8
select AVG(Quantity) as AvgQuan
from Production.ProductInventory
where LocationID = 10 


--9
select  ProductID, Shelf, AVG(Quantity) as AvgQuan
from Production.ProductInventory
where LocationID = 10 
group by ProductID, Shelf
order by Shelf asc

--10 
select  ProductID, Shelf, AVG(Quantity) as AvgQuan
from Production.ProductInventory
where Shelf != 'N/A'
group by ProductID, Shelf
order by Shelf asc

--11
select Color, Class, COUNT(*) as TheCount, AVG(ListPrice) as AvgPrice
from Production.Product
where Color is not null and Class is not null
group by Color, Class

--12
select cr.Name as Country, sp.Name as Province
from Person.CountryRegion cr right join Person.StateProvince sp
on cr.CountryRegionCode = sp.CountryRegionCode

--13
select cr.Name as Country, sp.Name as Province
from Person.CountryRegion cr right join Person.StateProvince sp
on cr.CountryRegionCode = sp.CountryRegionCode
where cr.Name in ('Germany','Canada')

use Northwind
--14
select distinct p.ProductName
from Products p inner join [Order Details] o
on p.ProductID = o.ProductID
inner join Orders r
on r.OrderID = o.OrderID
where r.OrderDate between '1996-01-01' and '2021-01-01'

--15
select top 5 ShipPostalCode
from Orders
group by ShipPostalCode
order by COUNT(ShipPostalCode) desc

--16
select top 5 ShipPostalCode
from Orders
where OrderDate between '1996-01-01' and '2021-01-01'
group by ShipPostalCode
order by COUNT(ShipPostalCode) desc

--17
select c.City, COUNT(o.CustomerID) as CountedCustomer
from Orders o left join Customers c
on o.CustomerID = c.CustomerID
group by c.City

--18
select c.City, COUNT(o.CustomerID) as CountedCustomer
from Orders o left join Customers c
on o.CustomerID = c.CustomerID
group by c.City
having COUNT(o.CustomerID) > 10

--19
select distinct c.CompanyName, c.ContactName
from Orders o left join Customers c
on o.CustomerID = c.CustomerID
where o.OrderDate > '1998-01-01'

--20
select distinct top 4 c.CompanyName, c.ContactName, o.OrderDate
from Orders o left join Customers c
on o.CustomerID = c.CustomerID
order by o.OrderDate desc

--21
select c.ContactName, count(od.Quantity) as CountedPurchase 
from Orders o inner join Customers c
on o.CustomerID = c.CustomerID
inner join [Order Details] od
on o.OrderID = od.OrderID
group by c.ContactName
order by count(od.Quantity) asc--22select c.ContactName, count(od.Quantity) as CountedPurchase 
from Orders o inner join Customers c
on o.CustomerID = c.CustomerID
inner join [Order Details] od
on o.OrderID = od.OrderID
group by c.ContactName
having count(od.Quantity) > 100
order by count(od.Quantity) asc
--23
select s.CompanyName, x.CompanyName
from Shippers s
cross join Suppliers x

--24
select distinct r.OrderDate, p.ProductName
from Products p inner join [Order Details] o
on p.ProductID = o.ProductID
inner join Orders r
on r.OrderID = o.OrderID

--25
select  * 
from Employees e inner join Employees m
on e.Title = m.Title

--26
select e.EmployeeID, e.LastName, e.FirstName, e.Title 
from Employees e inner join Employees m
on e.EmployeeID = m.ReportsTo
group by e.EmployeeID, e.LastName, e.FirstName, e.Title
having count(m.ReportsTo) > 2

--27
select city, ContactName, 'Customer' as Type from Customers
union
select city, ContactName, 'Supplier' as Type from Suppliers

--28
--select * 
--from F1 
--inner join 
--F2 on 
--F1.T1 = F2.T2
--F1.T1 F2.T2
--2 2
--3 3

--29
--Select * 
--from F1 
--left join F2 
--on F1.T1 = F2.T2
--F1.T1 F2.T2
--1 null
--2 2
--3 3