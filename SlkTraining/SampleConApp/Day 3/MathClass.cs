using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Why does a method/function need a returntype or a parameter

namespace SampleConApp.Day_3
{
    class MathClass
    {
        //4 Functions in this math class
        public static void AddFunction()
        {
            double firstValue = double.Parse(Ex01MethodsExample.GetString("Enter the First Value"));
            double secondValue = double.Parse(Ex01MethodsExample.GetString("Enter the Second Value"));
            Console.WriteLine($"The Added Value : {firstValue + secondValue}");
        }

        public static void SubFunction()
        {
            double firstValue = double.Parse(Ex01MethodsExample.GetString("Enter the First Value"));
            double secondValue = double.Parse(Ex01MethodsExample.GetString("Enter the Second Value"));
            Console.WriteLine($"The Subtracted value: {firstValue - secondValue}");
        }
        public static void MulFunction()
        {
            double firstValue = double.Parse(Ex01MethodsExample.GetString("Enter the First Value"));
            double secondValue = double.Parse(Ex01MethodsExample.GetString("Enter the Second Value"));
            Console.WriteLine($"The Product value: {firstValue * secondValue}");
        }
        public static void DivFunction()
        {
            double firstValue = double.Parse(Ex01MethodsExample.GetString("Enter the First Value"));
            double secondValue = double.Parse(Ex01MethodsExample.GetString("Enter the Second Value"));
            Console.WriteLine($"The Div value: {firstValue / secondValue}");
        }
    }
}
