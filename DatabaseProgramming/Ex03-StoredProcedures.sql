----Example on Stored Procs and Functions------------
-- If a query is executed, the query is parsed and then executed. If a query is frequently used, then its good to create a procedure so that it is parsed once and can be used many times without a need to reparse the query. 
Create Procedure createEmp
(
	@name nvarchar(50),
	@address nvarchar(200),
	@email nvarchar(200),
	@salary money,
	@dept int
)
AS
Insert into tblEmployee values(@name, @address, @email,@salary, @dept)

Create procedure findEmployee
(@empId int)
As
Select * from tblEmployee where empId = @empId

------------------------Execute the Stored procedure in SQL------------------------

EXEC	[dbo].[createEmp]
		@name = N'Vinod Kumar',
		@address = N'Shimoga',
		@email = N'vinod@gmail.com',
		@salary = 60000,
		@dept = 1

GO

DECLARE @empid int
SET @empid = 1001
EXEC dbo.findEmployee @empid 
