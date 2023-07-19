
using System;
//Add capabilities to take inputs on the Name, Address, telephone no
namespace SampleConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the Name please");//Display on Output.
            //string name = Console.ReadLine();//Take inputs
            //Console.WriteLine("The Name entered is " + name);
            //Console.WriteLine("The name entered is {0}", name);
            //Console.WriteLine($"The name entered is {name}");//Interpolation Syntax. 

            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Address");
            string address = Console.ReadLine();
            
            Console.WriteLine("Enter the Phone no");
            //long phone = Convert.ToInt64(Console.ReadLine());//For all kinds of data conversion to long
            long phone = long.Parse(Console.ReadLine());//Only string to long. Performance wise long.parse is prefered.

            Console.WriteLine($"The Name entered is {name} from {address} and can be contacted at {phone}");
            //Convert class's ToInt64 vs. long.Parse.
        }
    }
}
