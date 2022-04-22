use Northwind;
--1.      List all cities that have both Employees and Customers.
select distinct c.city
from Customers as c
WHERE c.City in (select city from Employees);
--2.      List all cities that have Customers but no Employee.
--a.      Use sub-query
select DISTINCT c.City
from Customers as c
where c.City NOT in (select city from Employees);
--b.      Do not use sub-query
select distinct c.City
from Customers as c left join Employees as e
on c.City = e.City
where e.EmployeeID is null;
--3.      List all products and their total order quantities throughout all orders.
select p.ProductID, sum(od.Quantity)
from Products as p left join [Order Details] as od
on p.ProductID = od.ProductID
group by p.ProductID;
--4.      List all Customer Cities and total products ordered by that city.
select c.City, sum(od.Quantity)
from Customers as c 
left join Orders as o on c.CustomerID = o.CustomerID
left join [Order Details] as od on o.OrderID = od.OrderID
group by c.City;
--5.      List all Customer Cities that have at least two customers.
--a.      Use union
select c.City
from Customers as c inner join  Orders as o on c.CustomerID = o.CustomerID
group by c.City
having count(c.CustomerID) >= 2
union
select c.City
from Customers as c inner join  Orders as o on c.CustomerID = o.CustomerID
group by c.City
having count(c.CustomerID) >= 2;
--b.      Use sub-query and no union
select distinct city
from Customers
where CustomerID IN (SELECT CustomerID FROM ORDERS group by CustomerID having COUNT(CustomerID) >=2);
--6.      List all Customer Cities that have ordered at least two different kinds of products.
select c.city,COUNT(DISTINCT ProductID)
from Customers as c join Orders as o on c.CustomerID = o.CustomerID
join [Order Details] as od on o.OrderID = od.OrderID
GROUP BY c.City
having count(ProductID) >= 2;
--7.      List all Customers who have ordered products, but have the ¡®ship city¡¯ on the order different from their own customer cities.
select distinct c.CustomerID, City, ShipCity
from Customers as c inner join Orders as o on c.CustomerID = o.CustomerID
where City != ShipCity;
--8.      List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
select temp2.ProductID, avg_Price, City
from (select distinct temp.ProductID, avg_Price, City, sum(Quantity) as sum_quant_by_city, rank() over (partition by temp.ProductID order by sum(Quantity) desc) AS rnk
from (select TOP 5 ProductID, round(avg(UnitPrice),2) as avg_Price
		from [Order Details] 
		group by ProductID 
		ORDER by sum(Quantity)) as temp
inner join [Order Details] as od on od.ProductID = temp.ProductID
inner join Orders as o on od.OrderID = o.OrderID
INNER JOIN Customers as c on c.CustomerID = o.CustomerID
group by temp.ProductID,avg_Price, City) as temp2
where rnk = 1;
--9.      List all cities that have never ordered something but we have employees there.
--a.      Use sub-query
select c.City
from Customers as c
where c.CustomerID NOT IN (select o.CustomerID FROM Orders as o)
and c.City in (Select e.City from Employees as e);
--b.      Do not use sub-query
select c.City
FROM Customers as c left join Orders as o on c.CustomerID = o.CustomerID
left join Employees as e on e.City = c.City
where OrderID is null
and e.EmployeeID is not null;
--10.  List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
select city
from (select TOP 1 city, count(orderID) as order_num_by_city
		from Employees as e join Orders as o on e.EmployeeID = o.EmployeeID
		group by City
		order by count(orderID) DESC) as temp
join (select top 1 ShipCity, sum(Quantity) as total_quant_by_ShipCity
		from [Order Details] as od join Orders as o on od.OrderID = o.OrderID
		group by ShipCity
		order by sum(Quantity) desc) as temp2
	on temp.City = temp2.ShipCity;
--11. How do you remove the duplicates record of a table?
--select distinct * from table;