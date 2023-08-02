using System;
using System.Collections.Generic;
using System.IO;
//Events are practical implementation of delegates. Event are actions performed by the user on the object. It is widely used in UI Based Applications. Click, Double CLick, KeyPress are some of the events of the UI objects. For .NET, Web Forms, Win Forms. WPF are the examples of UI Apps. 
//All Events are instances of a Delegate. For most of the UI Applications, there is a built in event delegate by name EventHandler. 
namespace SampleConApp.Day8
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
        void AddNewEmployee(Employee emp);
        List<Employee> GetAllEmployees();

        event Action<String> EventHandler;
    }
    class FileEmployeeManager : IEmployeeManager
    {
        const string filename = "Data.txt";
        public event Action<string> EventHandler = null;
        public void AddNewEmployee(Employee emp)
        {
            string empDetails = $"{emp.EmpId},{emp.EmpName},{emp.EmpEmail},{emp.EmpSalary}\n";
            File.AppendAllText(filename, empDetails);
            EventHandler("Employee added successfully");
        }

        public List<Employee> GetAllEmployees()
        {
            //Go the file, get all lines of the file. each line represents an Employee. 
            string[] empRows = File.ReadAllLines(filename);
            List<Employee> empList = new List<Employee>();
            foreach(var row in empRows)
            {
                var words = row.Split(',');
                var emp = new Employee
                {
                    EmpId = int.Parse(words[0]),
                    EmpName = words[1],
                    EmpEmail = words[2],
                    EmpSalary = long.Parse(words[3])
                };
                empList.Add(emp);
            }
            EventHandler("Employee data is generated succesfully");
            return empList;
        }

    }
    class Ex02Events
    {
        const string menuFile = @"C:\Trainings\SLK Software\SlkTraining\SampleConApp\Day8\Menu.txt";

        static void Main(string[] args)
        {
            IEmployeeManager mgr = new FileEmployeeManager();
            //mgr.AddNewEmployee(new Employee { EmpId = 111, EmpEmail = "phanirajbn@gmail.com", EmpName = "Phaniraj", EmpSalary = 45000 });
            //mgr.AddNewEmployee(new Employee { EmpId = 112, EmpEmail = "suresh@gmail.com", EmpName = "Suresh", EmpSalary = 45000 });
            //mgr.AddNewEmployee(new Employee { EmpId = 113, EmpEmail = "alwin@gmail.com", EmpName = "Alwin", EmpSalary = 45000 });

            //mgr.EventHandler += new Action<string>(Mgr_EventHandler);
            mgr.EventHandler += Mgr_EventHandler;
            mgr.AddNewEmployee(new Employee { EmpId = 114, EmpEmail = "peter@gmail.com", EmpName = "peter@gmail.com", EmpSalary = 45000 });

            var records = mgr.GetAllEmployees();
            foreach(var emp in records)
            {
                Console.WriteLine(emp.EmpName + "--- can be contacted at  -----" + emp.EmpEmail);
            }
            //string menu = File.ReadAllText(menuFile);
            //do
            //{
            //    Console.WriteLine(menu);
            //    int choice = int.Parse(Console.ReadLine());
            //} while (true);


        }

        private static void Mgr_EventHandler(string message)
        {
            Console.WriteLine(message);
        }
    }
}
