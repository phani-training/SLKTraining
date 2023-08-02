using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Delegate is like Function pointers of C++. It will allow to pass a function as an argument to another function. 
 * U would need a delegete if U want to the caller of UR function to define a functionality of a feature.
 * Delegate is reference type, U should create the instance of it to use it. 
 * The fn that is mapped to the delegate instance should have the same signature of the delegate. 
 * Action and Func are the 2 Delegates introduced in .NET 4.0(2010) which had a generic overloaded version of 2 Functions: One with void and another with other type.
 * Practical examples of dalegates are many: Events, Multi Threading, Async calling, Callback functions
 */
namespace SampleConApp.Day8
{
    delegate void MathematicOperation(int fValue, int sValue);
    static class UserInteraction
    {
        public static void Calculate(MathematicOperation operation)
        {
            Console.WriteLine("Enter the First Value");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Value");
            int v2 = int.Parse(Console.ReadLine());
            if (operation != null)
            {
                operation(v1, v2);//invoke the operation method here
            }
            else
                Console.WriteLine("The Operation is not defined");
        }
    }
    class Ex01Delegates
    {
        static void addOperation(int x, int y)
        {
            Console.WriteLine("The result of add operation is: " + (x + y));
        }

        static void subOperation(int x, int y)
        {
            Console.WriteLine("The Subracted operation is " + (x - y));
        }
        static void Main(string[] args)
        {
            //Old syntax:
            //MathematicOperation instance = new MathematicOperation(addOperation);
            UserInteraction.Calculate(addOperation);
        }
    }
}
