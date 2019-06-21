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


SELECT *
FROM Customers
WHERE Country = 'Mexico'

SELECT *
FROM Customers
WHERE Country != 'Mexico'

SELECT *
FROM Customers
WHERE Country LIKE 'N%'