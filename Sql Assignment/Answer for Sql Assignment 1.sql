use AdventureWorks2019

--1
select ProductID , Name, Color, ListPrice
from Production.Product

--2
select ProductID , Name, Color, ListPrice
from Production.Product
where ListPrice = 0

--3
select ProductID , Name, Color, ListPrice
from Production.Product
where Color is null

--4
select ProductID , Name, Color, ListPrice
from Production.Product
where Color is not null

--5
select ProductID , Name, Color, ListPrice
from Production.Product
where Color is not null and ListPrice > 0

--6
select Name, Color
from Production.Product
where Color is not null

--7
select Name, Color
from Production.Product
where Color in('Black','Silver')

--8
select ProductID, Name
from Production.Product
where ProductID between 400 and 500

--9
select Name, Color
from Production.Product
where Color in('Black','Blue')

--10
select * 
from Production.Product
where Name like 'S%'

--11
select top 6 Name, ListPrice
from Production.Product
where Name like 'Seat%' or Name like 'Short%'
order by Name

--12
select top 5 Name, ListPrice
from Production.Product
where Name like 'A%' or Name like 'S%'
order by Name

--13
select *
from Production.Product
where Name like 'SPO%' and Name not like '%k%'
order by Name

--14
select distinct *
from Production.Product 
where Color is not null
order by Color desc

--15
select ProductSubcategoryID, Color
from Production.Product
where ProductSubcategoryID is not null and Color is not null

--16
SELECT ProductSubCategoryID
 , LEFT([Name],35) AS [Name]
 , Color, ListPrice 
FROM Production.Product
WHERE Color not IN ('Red','Black') 
 OR ListPrice BETWEEN 1000 AND 2000 
 AND ProductSubCategoryID = 1
ORDER BY ProductID

--17
select distinct ProductSubcategoryID, Name, Color, ListPrice
from Production.Product
where ProductSubcategoryID < 15 
and ListPrice between 500 and 1701
order by ProductSubcategoryID desc