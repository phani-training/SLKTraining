using System;
using System.Collections.Generic;
/*
* Structs are value types in .NET
* They store the value instead of memory location(Reference)
* All Value types are structs in C#.
* Integral Types: byte, short, int and long
* Floating types: float(Single), double(Double), decimal(Decimal)
* Other types:char, bool, DateTime. 
* User defined types: Enums and structs. 
* Minified version of a class. With struct, U can have UR data, functions for the data. But it cannot be OO feature. 
* Constructors can be only parameterized constructors.
* U cannot have fields or properties initialized while declaring it. 
*/
namespace SampleConApp.Day6
{
    interface IEmpComponent
    {
        void AddNewEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(int empId);
        List<Employee> GetAllEmployees();
    }

    struct EmployeeManager : IEmpComponent
    {
        private List<Employee> empList { get; set; }

        public EmployeeManager(int size)//Will not use size, it is created to solve the parameterless ctor issue
        {
            empList = new List<Employee>(0);
        }
        public void AddNewEmployee(Employee emp)
        {
                empList.Add(emp);  
        }

        public void DeleteEmployee(int empId)
        {
            foreach(Employee emp in empList)
            {
                if(emp.EmpId == empId)
                {
                    empList.Remove(emp);
                    return;
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return empList;
        }

        public void UpdateEmployee(Employee updatedEmp)
        {
            for (int i = 0; i < empList.Count; i++)
            {
                var temp = empList[i];
                if(empList[i].EmpId == updatedEmp.EmpId)
                {
                    temp.EmpName = updatedEmp.EmpName;
                    temp.EmpName = updatedEmp.EmpAddress;
                    temp.EmpSalary = updatedEmp.EmpSalary;
                    empList[i] = temp;
                    return;
                }
            }
        }
    }
    struct Employee
    {
        public int EmpSalary { get; set; }
        public string EmpAddress { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
       
       public void Display()
        {
            Console.WriteLine($"------------Details of Mr.{EmpName.ToUpper()}----------------");
            Console.WriteLine("The ID: " + EmpId);
            Console.WriteLine("The Name: " + EmpName);
            Console.WriteLine("The Address: " + EmpAddress);
            Console.WriteLine("The Salary: {0:c}",EmpSalary);
            Console.WriteLine("--------------------------------------------------------------");
        }
    }

   //Use  this code and improvise the Application with the feature of a menu driven program that will have options like add, remove,find, update etc. The code should not abnormally terminate. If the User wants to close the Application, U should provide an option to close. Data is not stored to any external storage device. 
    class Ex01StructsExample
    {
        static void Main(string[] args)
        {
            //Like Class instantiation
            var emp = new Employee { EmpId = 123, EmpName = "Phaniraj", EmpAddress = "Bangalore", EmpSalary = 56000 };
            //emp.Display();
            try
            {
                EmployeeManager empMgr = new EmployeeManager(1000000);
                empMgr.AddNewEmployee(emp);
                Console.WriteLine("Employee added successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
