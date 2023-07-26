using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp.Day4
{
    class Parent
    {
        public virtual void Func1() => Console.WriteLine("Func1 from Parent");
        public virtual void Func2() => Console.WriteLine("Func2 from Parent");
    }

    class Child : Parent
    {
        public override void Func1() => Console.WriteLine("Func1 from Child");
        public override void Func2() => Console.WriteLine("Func2 from Child");
        
        public void Func3() => Console.WriteLine("Func3 from Child");
        public void Func4() => Console.WriteLine("Func4 from Child");
    }
    class InheritanceRecap
    {
        static void Main(string[] args)
        {
            Parent pObj = new Parent();
            pObj.Func1();
            pObj.Func2();

            pObj = new Child();//Call the child's version only if it is overriden.
            pObj.Func1();
            pObj.Func2();

            //Child copy = (Child)pObj;
            if (pObj is Child)
            {
                Child copy = pObj as Child;//as operator is used to typecase for reference types. 
                copy.Func3();
                copy.Func4();
            }
            



        }
    }
}
