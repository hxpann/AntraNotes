USE AdventureWorks2019;
--1
select count(productID)
from Production.Product;

--2
select count(ProductID)
FROM Production.Product
where ProductSubcategoryID is not null;

--3
select ProductSubcategoryID, count(ProductID) AS CountedProducts
FROM Production.Product
where ProductSubcategoryID is not null
group by ProductSubcategoryID;

--4
select count(ProductID)
FROM Production.Product
where ProductSubcategoryID is null;

--5
select sum(quantity)
from Production.ProductInventory;

--6
select ProductID, SUM(Quantity) as TheSum
from Production.ProductInventory
where LocationID = 40
group by ProductID
having sum(Quantity) < 100;

--7
select Shelf, ProductID, SUM(Quantity) as TheSum
from Production.ProductInventory
where LocationID = 40
group by Shelf, ProductID
having sum(Quantity) < 100;

--8
select avg(Quantity)
from Production.ProductInventory
where LocationID = 10;

--9
select ProductID, Shelf, avg(Quantity) as TheAvg
from Production.ProductInventory
GROUP BY ProductID, Shelf;

--10
select ProductID, Shelf, avg(Quantity) as TheAvg
from Production.ProductInventory
where Shelf != 'N/A'
GROUP BY ProductID, Shelf;

--11
select Color, Class, count(ProductID) as TheCount, avg(ListPrice) as AvgPrice
from Production.Product
where Color is not null
and Class is not null
group by Color, Class;

--12
select cr.Name as Country, sp.Name as Province
from person.CountryRegion as cr join person.StateProvince as sp
on cr.CountryRegionCode = sp.CountryRegionCode;

--13
select cr.Name as Country, sp.Name as Province
from person.CountryRegion as cr join person.StateProvince as sp
on cr.CountryRegionCode = sp.CountryRegionCode
where cr.Name = 'Germany' or cr.Name = 'Canada';

USE Northwind;
--14?
select ProductID
FROM Products
where ProductID in (select ProductID FROM [Order Details] AS od INNER JOIN ORDERS AS o
on od.OrderID = o.OrderID
where OrderDate >= dateadd(year, -25, dateadd(day,datediff(day,0,GETDATE()),0)));

--15
select top 5 ShipPostalCode from (
select ShipPostalCode,sum(Quantity) as quant
from Orders as o inner join [Order Details] as od
on o.OrderID = od.OrderID
group by ShipPostalCode) as temp
order by quant desc;

--16
select top 5 ShipPostalCode FROM (
select ShipPostalCode,sum(Quantity) as quant
from Orders as o inner join [Order Details] as od
on o.OrderID = od.OrderID
where OrderDate >= dateadd(year, -25, dateadd(day,datediff(day,0,GETDATE()),0))
group by ShipPostalCode) as temp
order by quant desc;

--17
select City,count(CustomerID) as Cust_num
FROM Customers
group by City;

--18
select City,count(CustomerID) as Cust_num
FROM Customers
group by City
having count(CustomerID) > 2;

--19
select CompanyName, OrderDate
from Customers as c inner join Orders as o
on c.CustomerID = o.CustomerID
where OrderDate > '1/1/1998';

--20
select CompanyName, OrderDate
from Customers as c inner join Orders as o
on c.CustomerID = o.CustomerID
where OrderDate in (select top 1 OrderDate from Orders order by OrderDate);

--21
select c.CompanyName, count(od.ProductID) AS product_count
from Customers as c inner JOIN Orders as o on c.CustomerID = o.CustomerID 
inner join [Order Details] as od on o.OrderID = od.OrderID
group by CompanyName;

--22
select c.CustomerID, count(od.ProductID) AS product_count
from Customers as c inner JOIN Orders as o on c.CustomerID = o.CustomerID 
inner join [Order Details] as od on o.OrderID = od.OrderID
group by c.CustomerID
having count(od.ProductID) > 100;

--23
select supp.CompanyName as [Supplier Company Name], ship.CompanyName as [Shipping Company Name]
from suppliers as supp inner join shippers as ship
on supp.SupplierID = ship.ShipperID;

--24
select OrderDate, ProductName
from [Order Details] as od inner join Products as p on od.ProductID = p.ProductID
inner join Orders as o on od.OrderID = o.OrderID;

--25
select e1.EmployeeID as Employee1, e2.EmployeeID as Employee2
from Employees as e1, Employees as e2
where e1.EmployeeID !=  e2.EmployeeID
and e1.Title = e2.Title;

--26
select m.EmployeeID AS managerID, count(e.EmployeeID) as employees
FROM Employees as e, Employees as m
where e.ReportsTo = m.EmployeeID
group by m.EmployeeID
having count(e.EmployeeID) > 2;

--27
select * from (
select City, CompanyName, ContactName as [Contact Name], 'Customer' as [Type (Customer or Supplier)]
from Customers as c
union all
select City, CompanyName, ContactName as [Contact Name], 'Supplier' as [Type (Customer or Supplier)]
from Suppliers as s) as temp
order by City;