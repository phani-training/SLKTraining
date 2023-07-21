using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace is a conceptual Grouping of UR Classes. If the classes are declared in the namespace, U should use the namespace and refer the classes if U R using it in different namespace
namespace Geometry
{
    class GeometricOperations
    {
        //Create methods to get Area of Square, Rectangle, Rhombus, Triangle.
        public static double GetAreaOfCircle(int radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
namespace SampleConApp.Day_3
{
    class Ex02NamespacesDemo
    {
        static void Main()
        {
            int radius = int.Parse(Ex01MethodsExample.GetString("Enter the radius of the Circle"));
            double value = GeometricOperations.GetAreaOfCircle(radius);
            Console.WriteLine("The Area of the circle is " + value);
        }
    }
}
