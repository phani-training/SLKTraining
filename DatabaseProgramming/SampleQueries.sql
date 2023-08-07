use SLKDatabase;

Insert into empTable values(114, 'Rajeshwari', 'raji@gmail.com', 9876555431, 60000)

Insert into empTable(empName, empSalary, emailAddress, mobileNo, Id) values('John Alter', 45000, 'john@gmail.com', 9987844553, 115)

Select * from empTable where (empSalary > 50000 and empName like '%ra%')

Select Avg(EmpSalary) as AvgSalary, MAX(EmpSalary) as HighestSalary, Min(EmpSalary) as LeastSalary from empTable
