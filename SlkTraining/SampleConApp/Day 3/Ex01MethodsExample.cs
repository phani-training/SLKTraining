using System;
//Methods or Functions are blocks of code that is created to reuse it in multiple locations of the Application. 
//One function should do only one job. Dont mix input/output with functionality
//A parameter is a dependency for the function. 
//A Return value is a result of the method, methods are supposed give the computed value, not 
namespace SampleConApp.Day_3
{
    class Ex01MethodsExample
    {

        public static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static Person createPerson()
        {
            Person person = new Person();
            person.Id = int.Parse(GetString("Enter UR ID Please"));
            person.Name = GetString("Enter the Name");
            person.Phone = long.Parse(GetString("Enter the Phone no"));
            person.Address = GetString("Enter the Address");
            return person;
        }
        static void Main(string[] args)
        {
            //Person person = createPerson();
            //Console.WriteLine($"The Details of the Person are as Follows\nThe Name: {person.Name}\nThe Address : {person.Address}\nThe Phone no: {person.Phone}");
            bool processing = false;
            do
            {
                const string menu = "------Math Program---------\n To Add Press 1\n To Subtract Press 2, \nTo Multiply Press 3\n To Divide Press 4\n";
                int choice = int.Parse(GetString(menu));
                processing = processMenu(choice);                
            } while (processing);
        }

        static bool processMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddOperation();
                    break;
                case 2:
                    SubOperation();
                    break;
                case 3:
                    MulOperation();
                    break;
                case 4:
                    DivOperation();
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    return false;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            return true;
        }

        static void AddOperation()
        {
            double firstValue = double.Parse(Ex01MethodsExample.GetString("Enter the First Value"));
            double secondValue = double.Parse(Ex01MethodsExample.GetString("Enter the Second Value"));
            double result = MathClassV2.AddFunction(firstValue, secondValue);
            Console.WriteLine("The Result of this operation is " + result);
        }

        static void SubOperation()
        {
            double firstValue = double.Parse(Ex01MethodsExample.GetString("Enter the First Value"));
            double secondValue = double.Parse(Ex01MethodsExample.GetString("Enter the Second Value"));
            double result = MathClassV2.SubFunction(firstValue, secondValue);
            Console.WriteLine("The Result of this operation is " + result);
        }

        static void MulOperation()
        {
            double firstValue = double.Parse(Ex01MethodsExample.GetString("Enter the First Value"));
            double secondValue = double.Parse(Ex01MethodsExample.GetString("Enter the Second Value"));
            double result = MathClassV2.MulFunction(firstValue, secondValue);
            Console.WriteLine("The Result of this operation is " + result);
        }

        static void DivOperation()
        {
            double firstValue = double.Parse(Ex01MethodsExample.GetString("Enter the First Value"));
            double secondValue = double.Parse(Ex01MethodsExample.GetString("Enter the Second Value"));
            double result = MathClassV2.DivFunction(firstValue, secondValue);
            Console.WriteLine("The Result of this operation is " + result);
        }


    }
}
