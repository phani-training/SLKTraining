using System;
/*
 * public(Accessible to all), 
 * private(Only within the declared class), 
 * protected(Only within the declared class and its derived Class, 
 * internal(Only within the Project(Assembly))
 * default access specifier for the Project level is internal
 * default access specifier within the class is private. 
 * */
namespace SampleConApp.Day2
{
    //Members within the class are default private to the class. The members are inaccessible to the Users outside the class. Accessors will be 2 types: methods and properties.  
    class Person//Internal to the Project
    {
        long adhaarNo;
        string personName;
        string personPhone;
        string personAddress;

        public void SetAaddharNo(long no)
        {
            adhaarNo = no;
        }

        public long GetAadharNo()
        {
            return adhaarNo;
        }
    }

    class Ex03AccessModifiersDemo
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetAaddharNo(123123131231);
            Console.WriteLine("The no is " + person.GetAadharNo());
        }
    }
}
