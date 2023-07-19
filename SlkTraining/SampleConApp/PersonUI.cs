using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class PersonUI
    {
        static void Main()
        {
            //Person person = new Person();
            //person.Id = 123;
            //person.Name = "Phaniraj";
            //person.Address = "Bangalore";
            //person.Phone = 9945205684;

            Person person = new Person();
            Console.WriteLine("Enter the ID for the Person");
            person.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name for the Person");
            person.Name = Console.ReadLine();
            Console.WriteLine("Enter the Address of the Person");
            person.Address = Console.ReadLine();
            Console.WriteLine("Enter the Contact No of the Person");
            person.Phone = long.Parse(Console.ReadLine());

            Console.WriteLine("The details are as follows");
            Console.WriteLine($"Name: {person.Name}\nAddress: {person.Address}\nMobile no: {person.Phone}\nId : {person.Id}");
        }
    }
}


//Create a Class called Customer with Details like Name, BillNo, Bill Detail, Amount and Date. Take inputs from the User and display the details in the User interface. 