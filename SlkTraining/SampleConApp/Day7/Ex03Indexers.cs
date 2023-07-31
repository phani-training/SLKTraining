using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Overloading the Subscript [] is called Indexer. U index a class 
//By indexing, U can make the object look like an array and get its data thru [index] value.
//This is helpful for collection classes, objects to represent like array etc. a
namespace SampleConApp.Day7
{
    class Employee
    {
        public string EmpAddress { get; set; }
        public string EmpName { get; set; }
        public int EmpId { get; set; }

        public string this[int index]
        {
            get
            {
                if (index == 0)
                    return EmpId.ToString();
                else if (index == 1)
                    return EmpName;
                else if (index == 2)
                    return EmpAddress;
                else
                    throw new IndexOutOfRangeException("There are only 3 properties to find");
            }
        } 
    }
    class Ex03Indexers
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee { EmpId = 123, EmpAddress = "Bangalore", EmpName ="Phaniraj" };
            Console.WriteLine(emp[5]);
        }
    }
}
