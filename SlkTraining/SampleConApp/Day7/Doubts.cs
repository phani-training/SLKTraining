using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp.Day7
{
    abstract class Shape
    {

        public abstract double CalculateArea();

    }



    class Rectangle : Shape
    {

        public double Width { get; set; }

        public double Height { get; set; }



        public override double CalculateArea()
        {

            return Width * Height;

        }

    }



    
    class Doubts
    {
        static void Main()
        {
            Shape shape = new Rectangle { Width = 5, Height = 3 };

            double area = shape.CalculateArea();
        }
    }
}
