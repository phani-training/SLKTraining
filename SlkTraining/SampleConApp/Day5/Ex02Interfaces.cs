using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Interfaces are like abstract classes but will have only abstract methods. It will not have any non abstract method.
//Any class that implements an interface must provide the public defns for all the methods of the interface, else, U should redeclare the method with abstract modifier and make the class also abstract. 
namespace SampleConApp.Day5
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public long EmpSalary { get; set; }
        public string EmpEmail { get; set; }
    }
    interface IEmployeeManager
    {
        //Interface members are not having access specifiers. U cannot have fields inside an interface. However, U can have properties. It will not have abstract modifier as it is always abstract.  
        void AddNewEmployee(Employee emp);
        void DeleteEmployee(int id);
        void UpdateEmployee(int id, Employee emp);

        Employee[] GetAllEmployees();        
    }

    class EmployeeManager : IEmployeeManager
    {
        public void AddNewEmployee(Employee emp)
        {
            Console.WriteLine($"Employee {emp.EmpName} is added to the database");
        }

        public void DeleteEmployee(int id)
        {
            Console.WriteLine($"Employee with Id {id} is Deleted from the database");
        }

        public Employee[] GetAllEmployees()
        {
            return new Employee[]
            {
                new Employee{ EmpId = 11, EmpName = "Phaniraj", EmpEmail = "phanirajbn@gmail.com", EmpSalary = 45000 },
                new Employee{ EmpId = 12, EmpName = "JoyDip", EmpEmail = "joydipMondal@gmail.com", EmpSalary = 55000 },
                new Employee{ EmpId = 13, EmpName = "Tom Alter", EmpEmail = "tm@gmail.com", EmpSalary = 65000 },
                new Employee{ EmpId = 14, EmpName = "Andrew", EmpEmail = "andrew@gmail.com", EmpSalary = 75000 },
                new Employee{ EmpId = 15, EmpName = "Steve", EmpEmail = "steveroman@gmail.com", EmpSalary = 35000 }
            };
        }

        public void UpdateEmployee(int id, Employee emp)
        {
            Console.WriteLine($"Employee {emp.EmpName} is updated to the database");
        }
    }
    class Ex02Interfaces
    {
        static void Main(string[] args)
        {
            IEmployeeManager mgr = new EmployeeManager();
            mgr.AddNewEmployee(new Employee { EmpName = "Rajesh" });
            mgr.UpdateEmployee(123, new Employee { EmpName = "Rajesh Kumar" });
            mgr.DeleteEmployee(123);
            var records = mgr.GetAllEmployees();
            foreach(var emp in records)
                Console.WriteLine(emp.EmpName);

        }
    }
}
