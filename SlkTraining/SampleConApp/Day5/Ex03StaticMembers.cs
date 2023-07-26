using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Static members are functions used to be called without an object instance. 
//A Class members are accesible only thru an object. However, if U R frequently using some functions across the Application, then creating instances will be cumbersome. So it is recommended to make those functions as static, so that U dont need to create instance everytime U call the method.
//Static gives the scope of singleton across the application. Only one reference of it will be available across the Application.
//If U have only static members inside a class, then U can mark the class as static, so that the user of the class need not create the instance accidentally. The static class can have only static methods. 
namespace SampleConApp.Day5
{

    class Ex03StaticMembers
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpName = Utilities.GetString("Enter UR Name");
            emp.EmpId = Utilities.GetNumber("Enter the Id");
            emp.EmpEmail = Utilities.GetString("Enter the Email Address");
            emp.EmpSalary = Utilities.GetNumber("Enter the Salary");
            Console.WriteLine("The Name of the Employee is {0} having Email Address at {1} with Salary of Rs. {2}", emp.EmpName, emp.EmpEmail, emp.EmpSalary);
        }
    }
}
