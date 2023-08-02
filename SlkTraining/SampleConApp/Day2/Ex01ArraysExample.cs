using System;
using System.Linq;
namespace SampleConApp.Day2
{
    class Ex01ArraysExample
    {
        static void setValues(int[] array)
        {
            for(int i =0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter the value for the position {i}");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("All the values are set");
        }

        static void DisplayArrayItems(int [] items)
        {
            foreach (int item in items)
            {
                Console.WriteLine(item);
            }
        }

        //Exercise:
        static void DisplayMaxAndMinValue(int [] items)
        {
            int minValue = items.Min();
            int maxValue = items.Max();
            //Console.WriteLine("The Min Value is " + minValue);
            //Console.WriteLine("The Max value is " + maxValue);
            
        }

        static void arraysWithDifferentData()
        {
            object[] objects = new object[3];
            objects[0] = 123;
            objects[1] = 123.45;
            objects[2] = "Apple123";
            foreach(var item in objects)
                Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            arraysWithDifferentData();
            const int size = 5;
            //Datatype [] arrayName = new DataType[size];
            //Console.WriteLine("Enter the no of Score values U need to fill");
            //int size = int.Parse(Console.ReadLine());
            int[] scores = new int[size];
            //indexing of the Array always starts with 0 in C#.
            scores[0] = 123;
            scores[1] = 234;
            scores[2] = 345;
            scores[3] = 456;
            scores[4] = 567;

            //Foreach loop to loop thru the array and display the data on Console
            foreach(int value in scores)
            {
                Console.WriteLine(value);
            }//U dont have to know the size of the array and will be within the bounds of the Array. It moves automatically to the next element. U cannot come backwards. Foreach can be applied only on arrays/Collections. Elements within the foreach statement are read only..
             //
            Console.WriteLine("---------------------------------------------");
            string test = "Apple,Mango, Orange";//string is an array of charecters..
            foreach(var item in test)
                Console.WriteLine(item);

            scores = new int[size];//Creating a new instance of the Array, so old values that are set to this variable is lost.
            setValues(scores);
            DisplayArrayItems(scores);
            DisplayMaxAndMinValue(scores);
        }
    }
}
//How to create a 2 Dimensional Array?
//how to display the elements of 2 D Array in Matrix format.
//There is a class called System.Array in .NET? What is the advantage of it?
//There are functions: Clone, Copy and CopyTo? Find out what are the differences of the 3 Function.