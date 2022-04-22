--Use Northwind database.  Write query for each step. Do not use IDE. BE CAREFUL WHEN DELETING DATA OR DROPPING TABLE.
USE Northwind;
--1.      Create a view named ¡°view_product_order_[your_last_name]¡±, list all products and total ordered quantity for that product.
create view view_product_order_Pan as
select ProductID, SUM(Quantity) AS total_ordered_quantity
	from [Order Details]
	group by ProductID;
select * from view_product_order_Pan;
drop view view_product_order_Pan;

--2.      Create a stored procedure ¡°sp_product_order_quantity_[your_last_name]¡± that accept product id as an input and total quantities of order as output parameter.
create proc sp_product_order_quantity_Pan
@ProductID int,
@total_ordered_quantity int out
AS
BEGIN
SELECT @total_ordered_quantity = sum(Quantity)
from [Order Details]
where ProductID = @ProductID
end

BEGIN 
DECLARE @total_ordered_quantity int
exec sp_product_order_quantity_Pan 1, @total_ordered_quantity out
print @total_ordered_quantity
end
drop proc sp_product_order_quantity_Pan;

--3.      Create a stored procedure ¡°sp_product_order_city_[your_last_name]¡± that accept product name as an input and top 5 cities that ordered most that product combined with the total quantity of that product ordered from that city as output.
create proc sp_product_order_city_Pan
@ProductName varchar(20)
as
begin
select ShipCity, total_ordered_quantity from
(select od.ProductID, ShipCity, sum(Quantity) as total_ordered_quantity, rank() over (partition by od.ProductID order by sum(Quantity) desc) as rnk
FROM [Order Details] as od join Orders as o on od.OrderID = o.OrderID
join Products as p on od.ProductID = p.ProductID
WHERE ProductName = @ProductName
group by od.ProductID, ShipCity) as temp
where rnk <= 5
end

exec sp_product_order_city_Pan 'Chang'

drop proc sp_product_order_city_Pan;

--4.      Create 2 new tables ¡°people_your_last_name¡± ¡°city_your_last_name¡±. City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. 
--        Remove city of Seattle. If there was anyone from Seattle, put them into a new city ¡°Madison¡±. 
--        Create a view ¡°Packers_your_name¡± lists all people from Green Bay. If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.
create table city_Pan (
	ID INT PRIMARY KEY,
	City varchar(20)
)
insert into city_Pan values (1,	'Seattle'),
							  (2, 'Green Bay')

create table people_Pan (
	ID INT PRIMARY KEY,
	Name varchar(20),
	City int foreign key references city_Pan(ID) on delete set null
)
insert into people_Pan values (1, 'Aaron Rodgers', 2),
							(2, 'Russell Wilson', 1),
							(3, 'Jody Nelson', 2)

create trigger delete_city_replacement on city_Pan
for delete
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @CityId INT
	SELECT @CityId = DELETED.Id FROM DELETED
	INSERT INTO city_Pan VALUES(@CityId, 'Madison')
	UPDATE people_Pan SET City = @CityID where City is null
END

select p.ID as peopleID, c.City as CityName from city_Pan as c join people_Pan as p on c.ID = p.City;
delete from city_Pan where City = 'Seattle';
select p.ID as peopleID, c.City as CityName from city_Pan as c join people_Pan as p on c.ID = p.City;


create view Packers_Hexi as
select p.ID
FROM people_Pan as p join city_Pan as c
on p.City = c.ID
where c.City = 'Green Bay';

begin tran
rollback

drop trigger delete_city_replacement;
drop table city_Pan;
drop table people_Pan;
drop view Packers_Hexi;

--5.       Create a stored procedure ¡°sp_birthday_employees_[you_last_name]¡± that creates a new table ¡°birthday_employees_your_last_name¡± and fill it with all employees that have a birthday on Feb. (Make a screen shot) drop the table. Employee table should not be affected.
create proc sp_birthday_employees_Pan
as
begin
declare @t table(EmployeeID int, BirthDate datetime);
insert into @t
select EmployeeID, BirthDate
from Employees
where month(BirthDate) = 2;
select * from @t
end

declare @t table(EmployeeID int, BirthDate datetime)
insert @t
exec sp_birthday_employees_Pan
select * from @t

drop proc sp_birthday_employees_Pan;

--6.      How do you make sure two tables have the same data?
--Let's say we have two tables: Table1 with ID as the Primary key and Table2 with ID as the Primary key
select t1.ID
FROM Table1 as t1
where exists (select t2.ID
			FROM Table2 as t2
			where t2.ID = t1.ID)
