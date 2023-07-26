using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Polymorphism is a feature of OOP that allows a member to behave in different manner based on the parameters or the object to which it belongs. With Parameters change, it is called Compile Time Polymorphism and with Object instantiation, its called as RUNTIME Polymorphism
 * POLY means many Morphism means kinds. 
 * If a class has to modify an existing method of the base class, it is called as METHOD OVERRIDING. In this case, the method signature(return type, name, parameters) should be retained in the derived version. The base method should be having a modifier 'virtual'. The Virtual methods are reimplemented(Overriden) using a modifier called override. Only virtual methods can be overriden in the derived classes. 
 * If a method is not virtual in the base class, it cannot be overriden. however U can reimplement the method in the derived class, but it will not behave polymorphically. 
 * Create a class called GeometricOperations with static methods to find area of Rectangle, Circle, Triangle, where the method name is simply GetArea and variable no of args: 
 * Rectange: b*h(2 parameters)
 * Circle: r(1 Parameter)
 * Triangle:3 Parameters, int, int, string("Triangle")  
 * A base class object can be substituted by any of the derived class objects but the converse of it is not possible. 
 */

namespace PolymorphismDemo
{
    class BaseClass
    {
        public virtual void TestFunc() => Console.WriteLine("Test Func is called");
    }

    class DerivedClass : BaseClass
    {
        public override void TestFunc() => Console.WriteLine("Test Func in a new Manner");
    }
}
namespace SampleConApp.Day4
{
    using PolymorphismDemo;


    class ClassFactory
    {
        public static BaseClass GetObject(string type)
        {
            if (type.ToUpper() == "BASE")
                return new BaseClass();
            else if (type.ToUpper() == "DERIVED")
                return new DerivedClass();
            else
                throw new Exception("Invalid Class type");
        }
    }
    class Ex02Polymorphism
    {
        static void Main()
        {
            Console.WriteLine("Which class U want to implement: Base or Derived");
            string answer = Console.ReadLine();

            BaseClass cls = ClassFactory.GetObject(answer);
            cls.TestFunc();
        }
    }
}
