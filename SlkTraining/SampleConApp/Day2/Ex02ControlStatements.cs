using System;
//Loops, If Statements, Switch Statements.
//For loop, Foreach Loop, While and Do...While.
namespace SampleConApp.Day2
{
    class Ex02ControlStatements
    {
        static void DoWhileExample()
        {
            bool processing = false;
            do
            {
                Console.WriteLine("Select the option as 1, 2 or 3");
                int option = int.Parse(Console.ReadLine());
                processing = SwitchCaseExample(option);
            } while (processing);
        }
        //static void SwitchCaseExample(int option)
        //{
        //        Console.WriteLine("Select the option as 1, 2 or 3");
        //        int option = int.Parse(Console.ReadLine());
        //    switch (option)
        //    {
        //        case 1: Console.WriteLine("User selected the First menu item"); break;
        //        case 2: Console.WriteLine("User selected the Mid menu item"); break;
        //        case 3: Console.WriteLine("User selected the Last menu item"); break;
        //        default: Console.WriteLine("User selected an invalid Choice"); break;
        //    }
        //}

        static bool SwitchCaseExample(int option)
        {
            switch (option)
            {
                case 1: Console.WriteLine("User selected the First menu item"); break;
                case 2: Console.WriteLine("User selected the Mid menu item"); break;
                case 3: Console.WriteLine("User selected the Last menu item"); break;
                default: Console.WriteLine("User selected an invalid Choice"); return false;
            }
            return true;
        }
        static void IfConditionExample()
        {
            Console.WriteLine("What Do U want to learn today?");
            string answer = Console.ReadLine();
            if (answer == ".NET")//Looks for Boolean Expression, trueness will execute the block. 
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("I dont do " + answer);
            }
            //if...else
            //if...elseif...elseif...else
        }
        static void Main(string[] args)
        {
            IfConditionExample();
            //SwitchCaseExample();
            DoWhileExample();
        }
    }
}
