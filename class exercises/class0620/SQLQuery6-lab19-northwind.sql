--Lab 19

USE Northwind

-- 1
SELECT * FROM Customers

-- 2
SELECT DISTINCT Country
FROM Customers

-- 3
SELECT * FROM Customers 
WHERE CustomerID like 'BI%'

-- 4
SELECT TOP(100) *
FROM Orders

-- 5
SELECT *
FROM Customers
WHERE PostalCode in ('1010', '3012', '12209', '05023')

-- 6 
SELECT * FROM Orders
WHERE ShipRegion IS NOT NULL

-- 7
SELECT *
FROM Customers
ORDER BY Country, City

--8 
INSERT INTO Customers (CustomerID, CompanyName) VALUES ('Matt', 'Matt')

--9
UPDATE Orders
SET ShipRegion = 'EuroZone'
WHERE ShipCountry = 'France'

Select * from Orders WHERE ShipCountry = 'France' 

--10
select * from [Order Details] where Quantity = 1
DELETE from [Order Details] where Quantity = 1

-- 11
SELECT 
	AVG(UnitPrice) As UnitPriceAverage,
	MAX(UnitPrice) As MaxPrice,
	MIN(UnitPrice) As MinPrice
FROM [Order Details]

-- 12
SELECT 
	AVG(UnitPrice) As UnitPriceAverage,
	MAX(UnitPrice) As MaxPrice,
	MIN(UnitPrice) As MinPrice
FROM [Order Details]
GROUP BY OrderID

--13 
select CustomerID
from Orders
where OrderID = '10290'

--14
select * 
from Orders
inner join Customers on Customers.CustomerID = Orders.CustomerID

select * 
from Orders
left join Customers on Customers.CustomerID = Orders.CustomerID

select * 
from Orders
right join Customers on Customers.CustomerID = Orders.CustomerID

--15
select *
from Employees
where ReportsTo is null

--16
select *
from Employees
where ReportsTo = (
select EmployeeID from Employees where FirstName = 'Andrew'
)


select count(*)
from [Order Details]


SELECT *
FROM Customers
WHERE Country = 'Mexico'

SELECT *
FROM Customers
WHERE Country != 'Mexico'

SELECT *
FROM Customers
WHERE Country LIKE 'N%'

------- BONUS 20

--1
select * from Customers

--2
select * 
from Customers
where City in ( 'London' , 'Paris')

--3
select distinct(City)
from Customers

--4
select *
from Employees
order by FirstName

--5
-- no salaries

--6
--no salaries

--7
select * from Employees
where Notes like '%ba%'

--8
select 
OrderID,
FORMAT(SUM(Quantity * UnitPrice), 'C') as SubTotal,
FORMAT(SUM(Discount * Quantity * UnitPrice), 'C') as DiscountTotal,
FORMAT(SUM((Quantity * UnitPrice) - (Discount * Quantity * UnitPrice)), 'C') as GrandTotal
from [Order Details]
group by OrderID
order by OrderID


--9
select *
from Employees
where HireDate < GETDATE() and HireDate > '1994-01-01'

--10
select 
SUM(DATEDIFF(YEAR, HireDate, GETDATE())) as DateDiff
from Employees

--11
select *
from Products
order by UnitsInStock asc

select *
from Products
order by UnitsInStock desc

--12
select *
from Products
where UnitsInStock < 6
order by UnitsInStock asc

--13
select *
from Products
where Discontinued = 1

--14
select *
from Products
where ProductName like '%tofu%'

--15
select top 1 *
from Products
order by UnitPrice desc

--16
select * from Employees
where HireDate > '1993-01-01'

--17
select * from Employees
where TitleOfCourtesy in ('Ms.', 'Mrs.')

--18
select * from Employees
where HomePhone like '(206)%'