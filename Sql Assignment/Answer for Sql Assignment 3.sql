use Northwind

--1
select distinct City
from Customers
where city in (select City from Employees)

--2.a
select distinct City
from Customers
where city not in (select City from Employees)

--2.b
select distinct c.City
from Customers c
left join Employees e
on c.City = e.City

--3
select c.CustomerID, c.CompanyName, c.ContactName,
SUM(od.Quantity) as Quantity from
Customers c left join Orders o
on c.CustomerID = o.CustomerID left join [Order Details] od
on o.OrderID = od.OrderID
group by c.CustomerID, c.CompanyName, c.ContactName
order by Quantity desc

--4
select c.City, SUM(od.Quantity) as Quantity 
from Customers c left join Orders o
on c.CustomerID = o.CustomerID left join [Order Details] od
on o.OrderID = od.OrderID
group by c.City
order by Quantity desc

--5.a
select c1.City from Customers c1 group by c1.City having COUNT(c1.City) > 2
union
select c2.City from Customers c2 group by c2.City having COUNT(c2.City) = 2

--5.b
select distinct c1.City
from Customers c1
where c1.City not in 
(select c2.City from Customers c2 group by c2.City having COUNT(c2.City) < 2)

--6
select distinct c.City, count(od.ProductID) as Counted
from Orders o inner join Customers c
on c.CustomerID = o.CustomerID inner join [Order Details] od
on o.OrderID = od.OrderID
group by c.City, od.ProductID
having count(od.ProductID) > 2


--7
select distinct  o.ShipCity from Orders o
where o.ShipCity not in 
(select distinct c.city from Customers c)

--8
with cte_ordersc
as(
select oc.ShipCity,oc.ProductID, oc.average,DENSE_RANK() over (partition by
oc.ProductID 
order by oc.number) rnk 
from 
(select top 5 od.ProductID,o.ShipCity, SUM(Quantity) number,AVG(od.UnitPrice) average 
FROM dbo.Orders o left join dbo.[Order Details] od on o.OrderID=od.OrderID
group by o.ShipCity, od.ProductID
order by number desc) oc
)select * from cte_ordersc where rnk = 1--9.aselect e.City from Employees e
where e.City not in (
select c.City from Orders o inner join Customers c
on c.CustomerID = o.CustomerID)--9.bselect distinct e.City from Employees e
left join Customers c
on e.City = c.City
where c.City is null

--10
select * from
(select top 1 e.City, count(o.OrderID) countOrder 
from Employees e inner join Orders o
on e.EmployeeID = o.EmployeeID
group by e.City) T1 inner join (
select top 1 c.City, count(r.Quantity) countQuantity 
from [Order Details] r inner join Orders d 
on r.OrderID = d.OrderID inner join Customers c 
on c.CustomerID = d.CustomerID 
group by c.City) T2
on T1.City = T2.City

--11
--Find duplicate rows using GROUP BY clause or ROW_NUMBER() function.
--Use DELETE statement to remove the duplicate rows.

--12
--SELECT deptname,empid,salary
--FROM(
--SELECT d.deptname, e.empid, e.salary, rank() OVER ( PARTITION BY e.deptid ORDER BY
-- e.salary DESC ) AS rnk
-- FROM dept d, employee e
-- WHERE d.deptid = e.deptid
-- )
--WHERE rnk <= 3
--ORDER BY deptname,rnk

--13
--select countbydept.*
--from (
-- select deptid, count(*) as departCount
-- from Employee
-- group by deptid
-- order by departCount desc
-- limit 1
--) as maxcount
--inner join
--( select dept.id, dept.`name`, count(*) as employeeCount
-- from Dept
--  inner join Employee on Employee.deptid = deptid
-- group by deptid, deptname
--) countbydept

--14
--SELECT deptname,empid,salary
--FROM (
--SELECT d.deptname, e.empid, e.salary, rank() OVER ( PARTITION BY e.deptid ORDER BY
--e.salary DESC ) AS rnk
-- FROM dept d, employee e
-- WHERE d.deptid = e.deptid
-- )
--WHERE rnk <= 3
--ORDER BY deptname,rnk

--15  is Find the top 3 products from every city which were sold maximum
select * from
(select o.shipcity,dt.QTY,
dense_rank() over(partition by o.shipcity order by dt.QTY desc)"rnk"
from Orders o inner join
(select OrderID , productid, sum(Quantity) as QTY
from [Order Details] od group by OrderID, ProductID)dt
on o.OrderID = dt.OrderID)dt2
where dt2.rnk <=3

--16
create table #City (city varchar(20), distance int)

insert into #City values('A', 80)
insert into #City values('B', 150)
insert into #City values('C', 180)
insert into #City values('D', 220)

select dt.city, dt.distance from 
(select  city + '-' +  LAG(city) over(order by city) as city,
distance - LAG(distance)
over(order by city) as distance
from #City)dt
where dt.distance is not null



--drop table #City