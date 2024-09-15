INSERT INTO Employee (EmpName, ContactNo, Email, DepartmentId, DesignationId, Salary, Age, CreationDate, ModificationDate)
VALUES 
('John Doe', 9876543210, 'john.doe@example.com', 1, 2, 60000.00, 28, GETDATE(), GETDATE()),
('Jane Smith', 8765432109, 'jane.smith@example.com', 2, 3, 70000.00, 32, GETDATE(), GETDATE()),
('Emily Johnson', 7654321098, 'emily.johnson@example.com', 3, 5, 50000.00, 26, GETDATE(), GETDATE()),
('Michael Brown', 6543210987, 'michael.brown@example.com', 4, 1, 80000.00, 35, GETDATE(), GETDATE()),
('Jessica Davis', 5432109876, 'jessica.davis@example.com', 5, 4, 55000.00, 29, GETDATE(), GETDATE());

INSERT INTO Department (DepartmentName, DeaprtmentCode, DesignationId, creationDate, modificationdate)
VALUES 
('IT', 'D01', 2, GETDATE(), GETDATE()),
('Finance', 'D02', 3, GETDATE(), GETDATE()),
('HR', 'D03', 5, GETDATE(), GETDATE()),
('Marketing', 'D04', 1, GETDATE(), GETDATE()),
('Operations', 'D05', 4, GETDATE(), GETDATE());

INSERT INTO Designation (DesignationName, DesignationCode, CreationDate, ModificationDate)
VALUES 
('Manager', 'MGR', GETDATE(), GETDATE()),
('Developer', 'DEV', GETDATE(), GETDATE()),
('Analyst', 'ANA', GETDATE(), GETDATE()),
('Tester', 'TST', GETDATE(), GETDATE()),
('HR', 'HR', GETDATE(), GETDATE());
