use AdventureWorks2019;
--1.  
select ProductID, Name, Color, ListPrice  from Production.Product;
--2.  
select ProductID, Name, Color, ListPrice  from Production.Product where ListPrice != 0;
--3. 
select ProductID, Name, Color, ListPrice  from Production.Product where Color is NULL;
--4. 
select ProductID, Name, Color, ListPrice  from Production.Product where Color is not Null;
--5. 
select ProductID, Name, Color, ListPrice  from Production.Product where Color is not Null and ListPrice > 0;
--6. 
select concat(Name, Color)  from Production.Product where Color is not Null;
--7. 
select 'Name:' + Name + ' -- COLOR:' + Color from Production.Product where color = 'Black' or color = 'Silver';
--8. 
select ProductID, Name from Production.Product where 400 < ProductID and ProductID < 500;
--9. 
SELECT ProductID, Name, Color FROM Production.Product where Color = 'Black' or Color = 'Blue';
--10. 
select ProductID FROM Production.Product where Name like 'S%';
--11. 
select Name, ListPrice from Production.Product where Name like 'S%' order by Name;
--12. 
select Name, ListPrice from Production.Product where Name like '[AS]%' order by Name;
--13. 
select * from Production.Product where Name like 'SPO[!K]%' order by Name;
--14. 
SELECT distinct Color  from Production.Product order by Color desc;
--15. 
select distinct ProductSubcategoryID, Color from Production.Product where ProductSubcategoryID is not null and Color is not Null order by ProductSubcategoryID, Color;
