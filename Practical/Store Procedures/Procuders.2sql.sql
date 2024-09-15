use Employee_Detail
-- 1. insert employee
CREATE PROCEDURE [dbo].[PR_Insert_Employee]
@EmpName	nvarchar(50),
@ContactNo	decimal(10),
@Email	nvarchar(50),
@DepartmentId	int,
@DesignationId	int,
@Salary			decimal,
@Age			int,
@CreationDate	date,
@ModificationDate	date
As
Begin
	Insert Into [dbo].[Employee]
	(
		[dbo].[Employee].[EmpName],
		[dbo].[Employee].[ContactNo],
		[dbo].[Employee].[Email],
		[dbo].[Employee].[DepartmentId],
		[dbo].[Employee].[DesignationId],
		[dbo].[Employee].[Salary],
		[dbo].[Employee].[Age],
		[dbo].[Employee].[CreationDate],
		[dbo].[Employee].[ModificationDate]
	) 
	Values(
		@EmpName,
		@ContactNo,
		@Email,
		@DepartmentId,
		@DesignationId,
		@Salary,
		@Age,
		@CreationDate,
		@ModificationDate
	)
End

-- 2. Update employee
CREATE PROCEDURE [dbo].[PR_Update_Employee]
@EmpId		int,
@EmpName	nvarchar(50),
@ContactNo	decimal(10),
@Email	nvarchar(50),
@DepartmentId	int,
@DesignationId	int,
@Salary			decimal,
@Age			int,
@CreationDate	date,
@ModificationDate	date
As
Begin
	Update [dbo].[Employee]
	set [EmpName] = @EmpName,
		[ContactNo] = @ContactNo,
		[Email] = @Email,
		[DepartmentId] = @DepartmentId,
		[DesignationId] = @DesignationId,
		[Salary] = @Salary,
		[Age] = @Age,
		[CreationDate] = @CreationDate,
		[ModificationDate] = @ModificationDate
	where [dbo].[Employee].[EmpId] = @EmpId
End

--3.Select all employee
CREATE PROCEDURE [dbo].[PR_SelectAll_Employee]
As
Begin
	select 
		[dbo].[Employee].[EmpId],
		[dbo].[Employee].[EmpName],
		[dbo].[Employee].[ContactNo],
		[dbo].[Employee].[Email],
		[dbo].[Employee].[DepartmentId],
		[dbo].[Employee].[DesignationId],
		[dbo].[Employee].[Salary],
		[dbo].[Employee].[Age],
		[dbo].[Employee].[CreationDate],
		[dbo].[Employee].[ModificationDate]
	from [dbo].[Employee]
End

--4. Delete Employee
CREATE PROCEDURE [dbo].[PR_Delete_Employee]
@EmpId		int
As
Begin
	Delete From [dbo].[employee]
	Where [dbo].[Employee].[EmpId] = @EmpId
End

--5. Select By id Employee
CREATE PROCEDURE [dbo].[PR_SelectById_Employee]
@Empid	int
As
Begin
	Select 
		[dbo].[Employee].[EmpId],
		[dbo].[Employee].[EmpName],
		[dbo].[Employee].[ContactNo],
		[dbo].[Employee].[Email],
		[dbo].[Employee].[DepartmentId],
		[dbo].[Employee].[DesignationId],
		[dbo].[Employee].[Salary],
		[dbo].[Employee].[Age],
		[dbo].[Employee].[CreationDate],
		[dbo].[Employee].[ModificationDate]
	From [dbo].[Employee]
	Where [dbo].[employee].[empid] = @Empid 
End

--6. Insert Department
CREATE PROCEDURE [dbo].[PR_Insert_Department]
@DepartmentName	nvarchar(50),
@DepartmentCode	nvarchar(5),
@DesignationId	int,
@CreationDate	date,
@ModificationDate	date
As
Begin
	Insert Into [dbo].[Department]
	(
		[dbo].[Department].[DepartmentName],
		[dbo].[Department].[DepartmentCode],
		[dbo].[Department].[DesignationId],
		[dbo].[Department].[CreationDate],
		[dbo].[Department].[ModificationDate]
	) 
	Values(
		@DepartmentName,
		@DepartmentCode,
		@DesignationId,
		@CreationDate,
		@ModificationDate
	)
End

drop procedure	PR_Insert_Department

--7. Update Department
CREATE PROCEDURE [dbo].[PR_Update_Department]
@DeptId		int,
@DeptName	nvarchar(50),
@DeptCode	nvarchar(5),
@DesignationId	int,
@CreationDate	date,
@ModificationDate	date
As
Begin
	Update [dbo].[Department]
	Set [dbo].[department].[Departmentname] = @DeptName,
		[dbo].[department].[DepartmentCode] = @DeptCode,
		[dbo].[department].[DesignationId] = @DesignationId,
		[dbo].[department].[CreationDate] = @CreationDate,
		[dbo].[department].[ModificationDate] = @ModificationDate
	Where [dbo].[Department].[DepartmentId] = @DeptID
End

--8. Select All Department
CREATE PROCEDURE [dbo].[PR_SelectAll_Department]
As
Begin
	Select 
		[dbo].[Department].[DepartmentId],
		[dbo].[Department].[DepartmentName],
		[dbo].[Department].[DepartmentCode],
		[dbo].[Department].[DesignationId],
		[dbo].[Department].[CreationDate],
		[dbo].[Department].[ModificationDate]
	From [dbo].[department]
End

--9. Delete Department
CREATE PROCEDURE [dbo].[PR_Delete_Department]
@DeptId	int
As
Begin
	Delete From [dbo].[department]
	where [dbo].[department].[departmentId] = @DeptId
End

--10. insert Designation
CREATE PROCEDURE [dbo].[PR_Insert_Designation]
@DesignationName	nvarchar(50),
@DesignationCode	nvarchar(5),
@CreationDate	date,
@ModificationDate	date
As
Begin
	Insert Into [dbo].[Designation]
	(
		[dbo].[Designation].[DesignationName],
		[dbo].[Designation].[DesignationCode],
		[dbo].[Designation].[CreationDate],
		[dbo].[Designation].[ModificationDate]
	) 
	Values(
		@DesignationName,
		@DesignationCode,
		@CreationDate,
		@ModificationDate
	)
End

select * from [dbo].[Employee]
--11. Update Designation
CREATE PROCEDURE [dbo].[PR_Update_Designation]
@DesiId		int,
@DesiName	nvarchar(50),
@DesiCode	nvarchar(10),
@CreationDate	date,
@ModificationDate	date
As
Begin
	Update [dbo].[Designation]
	Set [dbo].[Designation].[Designationname] = @DesiName,
		[dbo].[Designation].[DesignationCode] = @DesiCode,
		[dbo].[Designation].[CreationDate] = @CreationDate,
		[dbo].[Designation].[ModificationDate] = @ModificationDate
	Where [dbo].[Designation].[DesignationId] = @DesiID
End

--12. Delete Designation
CREATE PROCEDURE [dbo].[PR_Delete_Designation]
@DesiId	int
As
Begin
	Delete From [dbo].[Designation]
	where [dbo].[Designation].[designationId] = @DesiId
End

--13. select all Designation
CREATE PROCEDURE [dbo].[PR_SelectAll_Designation]
As
Begin
	Select 
		[dbo].[Designation].[DesignationId],
		[dbo].[Designation].[DesignationName],
		[dbo].[Designation].[DesignationCode],
		[dbo].[Designation].[CreationDate],
		[dbo].[Designation].[ModificationDate]
	From [dbo].[Designation]
End

--14. Select By Designation ID
CREATE PROCEDURE [dbo].[PR_SelectById_Designation]
@DesiId	int
As
Begin
	Select 
		[dbo].[Designation].[DesignationId],
		[dbo].[Designation].[DesignationName],
		[dbo].[Designation].[DesignationCode],
		[dbo].[Designation].[CreationDate],
		[dbo].[Designation].[ModificationDate]
	From [dbo].[Designation]
	where [dbo].[Designation].[DesignationId] = @DesiId
End

--15. select by Department Id
CREATE PROCEDURE [dbo].[PR_SelectByID_Department]
@DeptId	int
As
Begin
	Select 
		[dbo].[Department].[DepartmentId],
		[dbo].[Department].[DepartmentName],
		[dbo].[Department].[DepartmentCode],
		[dbo].[Department].[DesignationId],
		[dbo].[Department].[CreationDate],
		[dbo].[Department].[ModificationDate]
	From [dbo].[department]
	where [dbo].[department].[departmentId] = @DeptId
End

--16. select Employee Name,DepartmentName,DesignationName
CREATE PROCEDURE [dbo].[PR_Select_Emp_Dept_Designation_Name]
As
Begin
	Select
		[dbo].[Employee].[EmpName],
		[dbo].[Department].[DepartmentName],
		[dbo].[Designation].[DesignationName]
	from [dbo].[Employee]
	Inner Join [dbo].[department] on [dbo].[department].[DepartmentId] = [dbo].[Employee].[DepartmentId]
	Inner Join [dbo].[designation] on [dbo].[designation].[DesignationId] = [dbo].[Employee].[DesignationId]
End

--17. select Department Name and Designation name
CREATE PROCEDURE [dbo].[PR_Select_Dept_Designation_Name]
As
Begin
	Select
		[dbo].[designation].[DesignationName],
		[dbo].[Department].[DepartmentName]
	from [dbo].[Designation]
	Inner Join [dbo].[department] on [dbo].[department].[DesignationId] = [dbo].[Designation].[DesignationId]
End

/*Exec PR_Insert_Designation 'FrontEnd Developer','FD','2024-07-13','2024-07-13'
Exec PR_Insert_Designation 'BackEnd Developer','BD','2024-07-13','2024-07-13'

Exec PR_Insert_Department 'Developer','D',1,'2024-07-13','2024-07-13'
Exec PR_Insert_Department 'Developer','D',2,'2024-07-13','2024-07-13'

Exec PR_Insert_Employee 'Krish Gohel',9558566847,'krishgohel173@gmail.com',1,1,200000,20,'2024-07-13','2024-07-13'
Exec PR_Insert_Employee 'mehul parmar',8460052468,'mehul555@gmail.com',1,2,20000,20,'2024-07-13','2024-07-13'
*/