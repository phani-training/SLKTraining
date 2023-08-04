using System;
using System.Threading;

//A Process is a running instance of an Application and a Thread is the sequence of execution within the process. 
//In .NET, Threads are instances of a class called System.Threading.Thread. Every thread when created will look for a function that defines the functionality of the thread. 
namespace SampleConApp.Day9
{
    class MultiThreading
    {
        static void ThreadFn()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread functionality occured!!!");
                Console.Beep();
                Thread.Sleep(1000);
            }
        }

        static void ThreadFnWithArg(object arg)
        {
            //arg expected is integer. 
            int maxCount = (int)arg;
            for (int i = 0; i < maxCount; i++)
            {
                Console.WriteLine("Thread functionality occured!!!");
                Console.Beep();
                Thread.Sleep(1000);
            }

        }
        static void Main(string[] args)
        {
            ////////////////OLD SYNTAX////////////////////////////////////////////
            //ThreadStart fn = new ThreadStart(ThreadFn);
            //Thread thread = new Thread(fn);
            ////////////////////////NEW SYNTAX////////////////////////////////////
            Thread thread = new Thread(ThreadFnWithArg);//Example for ThreadFunc with args...
            thread.Start(5);

            Console.WriteLine("Doing other works from Main Function");

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main functionality occured!!!");
                Console.Beep();
                Thread.Sleep(1000);
            }
        }
    }
}
