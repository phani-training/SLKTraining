Create database SlkDatabase --DDL command for creating new database. If the database already exists, then an error will be thrown by the DB.

Drop database SlkDatabase -- DDL command for deleting the database, U should have exited(not use) the database. U should come to master and then delete the database.  
use SlkDatabase -- If U want to pass commands to the database, U should use the database using use keyword, afterwards the database can be used to create new objects in it.
GO -- it makes a bunch of SQL statements run like a batch...

sp_databases -- sp means stored procedure. A predefined function/group of statements that are pre-processed and can be used any time for faster execution. SQL server comes with some prebuilt Procedures that can be used to get info about the objects inside the database and the server.

------------To create the tables for the database---------------------
Create table tblEmployee
(
	--Columns for UR table. ColName dataType constraints including default
	empId int PRIMARY KEY IDENTITY(1001, 1),
	empName nvarchar(50) NOT NULL, --UNICODE Strings
	empAddress nvarchar(MAX) NOT NULL, 
	emailId nvarchar(200) NOT NULL,
	empSalary money NOT NULL 
) 


sp_tables 'tblEmployee' ----To the list of tables in the database:

sp_columns tblEmployee -- To get the list of columns within the specified table.

Insert into tblEmployee values('Phaniraj','Bangalore','phani@gmail.com', 67000, 1)
Insert into tblEmployee values('Ramesh','Mysore','phanirajbn@gmail.com', 45000, 2) 
Insert into tblEmployee values('Robert','Chennai','robertjj@gmail.com', 55000, 3) 
Insert into tblEmployee values('Syed','Mumbai','syed@gmail.com', 55000, 2) 
Insert into tblEmployee values('Ram Kumar','Hubli','ramkumar@gmail.com', 65000, 2) 
Insert into tblEmployee values('David','Panaji','davidcam@gmail.com', 40000, 3) 
Insert into tblEmployee values('Ismail','Pune','ismailshr@gmail.com', 34000, 2) 

Insert into tblEmployee(empAddress, emailId, empName, empSalary) values('Hyderabad', 'rajeev@gmail.com', 'Rajeev', 68000) -- Use this way if U want to set to specified columns and the order of columns in UR database. 
Insert into tblEmployee(empAddress, emailId, empName, empSalary) values('Hyderabad', 'sumanth@gmail.com', 'Sumanth', 68000)
Insert into tblEmployee(empAddress, emailId, empName, empSalary) values('Hyderabad', 'chinna@gmail.com', 'Chinna Reddy', 68000)
Insert into tblEmployee(empAddress, emailId, empName, empSalary) values('Hyderabad', 'mounika@gmail.com', 'Mounika', 68000)

Select * from tblEmployee

Create table tblDept
(
   deptId int primary key identity(1, 1),
   deptName varchar(50) NOT NULL

)

--------------How to add new column into an existing table---------------------
Alter table tblEmployee
Add deptId int
References tblDept(deptId) --It means the values in this column should be any of the values from the deptid column of the tblDept. It does not accept other values.

--------------How to delete column from an existing table---------------------
Alter table tblEmployee
--DROP CONSTRAINT FK__tblEmploy__deptI__38996AB5
DROP COLUMN DeptId

Insert into tblDept values('Training')
Insert into tblDept values('Development')
Insert into tblDept values('Human Resources')
Insert into tblDept values('IT Help Desk')
Insert into tblDept values('Utilities')

----------Modify the data of the table-------------
Update tblEmployee set deptId = 2 Where empid > 1002 And empId < 1005


-----------------Delete the data from the table---------------
Delete from tblEmployee Where EmpId = 890

select * from tblDept

Truncate table tblEmployee -- deletes all the rows of the table. It is same as delete from tblEmployee without a where clause. 

