--------------Data Query Language----------------------
Select * from tblEmployee

Select empName , empAddress from tblEmployee

---------------Using Aggregate functions of SQL-----------------
Select Max(EmpSalary) as MaxSalary, Min(EmpSalary) as MinSalary, Avg(EmpSalary) as AvgSalary from tblEmployee

------------------Applying where clause---------------
Select empName from tblEmployee where empAddress = 'Chennai'

Select empName from tblEmployee where empName like '%raj%'

Select * from tblEmployee Where deptId is null
--use coalesce to replace the value in place of the truthness of the expression 
Select empName, COALESCE(deptId, 0) as deptInfo from tblEmployee where deptId is null

Select empName, ISNULL(deptId, 0) as deptInfo from tblEmployee where deptid is null

select top(5) empName from tblEmployee where empSalary between 60000 and 65000

select count(empname) as empCount from tblEmployee

select top(5) empname, empsalary from tblEmployee order by empSalary desc

select * from tblEmployee where empAddress ='Bangalore' or empSalary < 45000

Select top 50 percent * from tblEmployee order by empSalary
--todo: get the bottom 50 percent from tblEmployee order by empsalary

------------------------JOINS in Sql server---------------------------
--inner join is combining 2 tables based on common data. 
select empname, deptname from tblEmployee join tblDept on tblEmployee.deptId = tblDept.deptId

--left join is getting all the data of the left table and matching data from the right table. 
select empname , deptname from tblEmployee left join tblDept on tblEmployee.deptId = tblDept.deptId

--right join is opposite of left join....
select empname , deptname from tblEmployee right join tblDept on tblEmployee.deptId = tblDept.deptId

--------------------------group by---------------------------------
--Get all depts and their max salaries
select deptname , max(empsalary) as maxsalary from tblEmployee right join tblDept on tblEmployee.deptId = tblDept.deptId
group by tblDept.deptName
--get the empnames and deptnames grouped by deptname
select empname, deptname, avg(empsalary) as AvgSalary from tblEmployee join tblDept on tblEmployee.deptId = tblDept.deptId
group by  empname, deptName
--group by must have all the columns that u have selected in the select clause or it should be aggregate function. 







