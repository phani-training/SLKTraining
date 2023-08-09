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

Insert into tblEmployee values('Ramesh','Mysore','phanirajbn@gmail.com', 45000) 
Insert into tblEmployee values('Robert','Chennai','robertjj@gmail.com', 55000) 
Insert into tblEmployee values('Syed','Mumbai','syed@gmail.com', 55000) 
Insert into tblEmployee values('Ram Kumar','Hubli','ramkumar@gmail.com', 65000) 
Insert into tblEmployee values('David','Panaji','davidcam@gmail.com', 40000) 
Insert into tblEmployee values('Ismail','Pune','ismailshr@gmail.com', 34000) 

Insert into tblEmployee(empAddress, emailId, empName, empSalary) values('Hyderabad', 'rajeev@gmail.com', 'Rajeev', 68000) -- Use this way if U want to set to specified columns and the order of columns in UR database. 


Select * from tblEmployee

Create table tblDept
(
   deptId int primary key identity(1, 1),
   deptName varchar(50) NOT NULL

)

--------------How to add new column into an existing table---------------------


