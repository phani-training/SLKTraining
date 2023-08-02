using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Atributes are used in C# to provide some declarative information or metedata about UR Code. 
//Atribute is a class that is derived from System.Attribute and can have overloaded constructors to map the base version and create new properties
namespace SampleConApp.Day8
{
    [AttributeUsage(AttributeTargets.All)]
    class GenderAttribute : Attribute
    {
        public GenderAttribute(string gender = "Male")
        {
            DefaultGender = gender;
        }
        public string DefaultGender { get; private set; }
    }

    [Gender("Female")]
    class Ex03Attributes
    {
        [Obsolete("TestFunc1 is obselete, For better performance, Use the new TestFunc2")]
        public static void TestFunc()
        {
            Console.WriteLine("Test Func is created");
        }

        public static void TestFunc2()
        {
            Console.WriteLine("Test Func is created in a new optimized manner");
            
        }
        static void Main(string[] args)
        {
            //TestFunc();
            TestFunc2();
        }
    }
}
