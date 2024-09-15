/*1.*/
--select CategoryName,Description from Categories

/*2.*/
--select Customerid,contactname,companyname from Customers
--where City = 'London'

--3.
--select * from Suppliers
--where Fax is not Null

--4.
--select Customerid from Orders
--where RequiredDate between '1997-01-01' and '1998-01-01' and Freight < 100

--5.
--select companyname,contactname from Customers
--where country in ('Mexico','sweden','germany')

--6.
--select COUNT(Discontinued) from Products
--where Discontinued > 0

--7.
--select CategoryName,description from Categories
--where Categoryname like 'Co%'

--8.
--select companyname,city,country,postalcode from Suppliers
--where Address like '%rue%'
--order by CompanyName

--9.
--select productid,quantity from [Order Details]

--10.
--select Customers.contactname,Customers.address from Customers
--inner join orders on orders.CustomerID = Customers.CustomerID
--inner join Shippers on Shippers.ShipperID = Orders.ShipVia
--where Shippers.CompanyName = 'speedy express'

--11.
--select companyname,contactname,contacttitle,region from Suppliers

--12.
--select pd.ProductName from products as pd
--inner join Categories as ct on ct.CategoryID = pd.ProductID
--where ct.CategoryName = 'condiments'

--13. Select a list of customer names who have no orders in the Orders table.
--select ct.ContactName from Customers as ct
--left join orders on orders.CustomerID = ct.CustomerID
--where orders.CustomerID is null

--14. Add a shipper named 'Amazon' to the Shippers table using SQL.
--insert into Shippers values('Amazon',8567854921)

--15. Change the company name from 'Amazon' to 'Amazon Prime Shipping' in the Shippers table using SQL.
--update Shippers 
--set CompanyName = 'Amazon Prime Shipping'
--where CompanyName = 'Amazon'

--16. Select a complete list of company names from the Shippers table. Include freight totals rounded to the nearest whole number for each shipper from the Orders table for those shippers with orders.
--select S.CompanyName,FLOOR(sum(O.freight)) as total from orders as O
--inner join Shippers as S on S.ShipperID = O.ShipVia
--group by S.CompanyName

--17.Select all employee first and last names from the Employees table by combining the 2 columns aliased as 'DisplayName'. The combined format should be 'LastName, FirstName'.  
--select Lastname +' '+ firstname as DisplayName from Employees

--18. Add yourself to the Customers table with an order for 'Grandma's Boysenberry Spread'.
--insert into Customers(CustomerID,companyname,contactname,contacttitle,address,city,Region,postalcode,country,phone,fax) values('K17','GNWebSoft','krish gohel','Owner','Kanak nagar-10','rajkot',null,'12547','india',9558566847,null)
--insert into Orders(CustomerID) values('k17')
--insert into [Order Details] values(11078,6,1000,1,0)

--19. Remove yourself and your order from the database.
--delete from [Order Details]
--where OrderID = 11078
--delete from Orders
--where OrderID = 11078
--delete from Customers
--where CustomerID = 'k17'

--20. Select a list of products from the Products table along with the total units in stock for each product. Give the computed column a name using the alias, 'TotalUnits'. Include only products with TotalUnits greater than 100.
--select productname,unitsinstock as TotalUnits from Products
--where UnitsInStock > 100
