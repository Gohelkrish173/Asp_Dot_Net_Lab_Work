Create Table Employee(
EmpId	int primary key identity(1,1),
EmpName	nvarchar(50),
ContactNo	decimal(10),
Email	nvarchar(50),
DepartmentId	int,
DesignationId	int,
Salary			decimal,
Age				int,
CreationDate	date,
ModificationDate	date
foreign key (DepartmentId) References Department(DepartmentId),
foreign key (DesignationId) References Designation(DesignationId)
)

Create Table Department(
DepartmentId	int	Primary key identity(1,1),
DepartmentName	nvarchar(50),
DeaprtmentCode	nvarchar(5),
DesignationId	int,
creationDate	date,
modificationdate	date,
foreign key (DesignationId) References Designation(DesignationID)
)

Create Table Designation(
DesignationID	int Primary Key identity(1,1),
DesignationName nvarchar(50),
DesignationCode	nvarchar(5),
CreationDate	date,
ModificationDate	date
)