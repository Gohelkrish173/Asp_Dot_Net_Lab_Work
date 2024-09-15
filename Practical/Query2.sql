--1. Select the name, address, city, and region of employees.
select Lastname + Firstname as name,address,city,Region from Employees

--2. Select the name, address, city, and region of employees living in USA
select Lastname + Firstname as name,address,city,Region from Employees
where country = 'USA'

--3. Select the name, address, city, and region of employees older than 50 years old.
select Lastname + Firstname as name,address,city,Region from Employees
where Year(getDate())-Year(birthdate) > 50

--4. Select the name, address, city, and region of employees that have placed orders to be delivered in Belgium. Write two versions of the query, with and without join.
select Lastname + Firstname as name,address,city,Region from Employees
right join orders on orders.EmployeeID = Employees.EmployeeID
where ShipCountry = 'Belgium'

--5. Select the employee name and the customer name for orders that are sent by the company ‘Speedy Express’ to customers who live in Brussels.
select Lastname + ' '+Firstname as name,customers.ContactName from Employees
inner join orders on Employees.EmployeeID = orders.EmployeeID
inner join Customers on Orders.CustomerID = Customers.CustomerID
where orders.ShipVia = 1

--6. Select the title and name of employees who have sold at least one of the products ‘Gravad Lax’ or ‘Mishi Kobe Niku’.
select title,(lastname + firstname) as name from Employees as emp
inner join orders as o on o.EmployeeID = emp.EmployeeID
inner join [Order Details] as od on od.OrderID = o.OrderID
inner join Products as p on p.ProductID = od.ProductID
where p.ProductName = 'Gravad Lax' or p.ProductName = 'Mishi Kobe Niku'

--7. Select the name and title of employees and the name and title of the person to which they refer (or null for the latter values if they don’t refer to another employee).
SELECT e.FirstName as [Employee Name], e.LastName as [Employee Lastname], b.LastName as [Reports To]
FROM Employees e
LEFT OUTER JOIN Employees AS b
ON e.ReportsTo = b.EmployeeID

--8. Select the customer name, the product name and the supplier name for customers who live in London and suppliers whose name is ‘Pavlova, Ltd.’ or ‘Karkki Oy’.
select c.contactname ,p.productname,s.contactname from Customers as c
inner join Orders as o on o.CustomerID = c.CustomerID
inner join [Order Details] as od on od.OrderID = o.OrderID
inner join Products as p on p.ProductID = od.ProductID
inner join Suppliers as s on s.SupplierID = p.SupplierID
where c.City = 'London' and (s.CompanyName = 'Pavlova, Ltd.' or s.CompanyName = 'Karkki Oy')

--9. Select the name of products that were bought or sold by people who live in London. Write two versions of the query, with and without union.
select p.productname from Products as p
inner join [Order Details] as od on od.ProductID = p.ProductID
inner join Orders as o on od.OrderID = o.OrderID
inner join Customers as c on c.CustomerID = o.CustomerID
inner join Employees as e on e.EmployeeID = o.EmployeeID
where c.City = 'London' and e.City = 'London'

select p.productname from Products as p
cross join [Order Details] as od 
cross join Orders as o 
cross join Customers as c 
cross join Employees as e
where c.City = 'London' and e.City = 'London'

--10. Select the names of employees who are strictly older than: (a) an employee who lives in London. (b) any employee who lives in London.
select LastName + ' ' + FirstName as name from Employees
where birthdate < any (select BirthDate from Employees where city='London')

select LastName + ' ' + FirstName as name from Employees
where birthdate < all (select BirthDate from Employees where city='London')

--11. Select the name of employees who work longer than any employee of London.
select Lastname + ' ' + firstname as name from Employees
where HireDate < any(select HireDate from Employees where City = 'London') 

--12. Select the name of employees and the city where they live for employees who have sold to customers in the same city.
select Lastname + ' ' + firstname as name, e.city from Employees e
inner join Orders as o on e.EmployeeID = o.EmployeeID
inner join Customers c on c.CustomerID = o.CustomerID
where e.city = c.City

--13. Select the name of customers who have not purchased any product.
select contactname from Customers as c
where CustomerID not in (select customerid from Orders)

--14. Select the name of customers who bought all products with price less than 5.
select contactname from Customers c
inner join orders o on o.CustomerID = c.CustomerID
inner join [Order Details] od on o.OrderID = od.OrderID
inner join Products p on od.ProductID = p.ProductID
where p.UnitPrice < 5

--15. 