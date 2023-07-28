using System;
/*
 * Exceptions are abnormal termination of a program when a certain logic is missed. The programmer or the application does not intend to move further because of a wrong input or the app fails to understand on how to go forward.
 * All Exceptions are objects of a class derived from System.Exception. 
 * Exceptions are generated when the program encounters a problem, at that time, the Runtime will create an object of class derived from System.Exception and throw that exception into the Application process.
 * Developers should handle the exception with try..catch..finally block
 * Here try should be followed by either catch or finally or both. 
 * finally is a block that is executed on all conditions.
 * catch blocks are executed as per the Exception class that is used to handle. 
 */

namespace SampleConApp.Day6
{
    //Custom exception is a class derived from Exception where we create to define Application specific Exceptions. 
    public class AgeException : Exception
    {
        public AgeException() { }
        public AgeException(string message) : base(message) { }
        public AgeException(string message, Exception inner) : base(message, inner) { }
       
    }
    class Ex02ExceptionHandling
    {
        static void Main(string[] args)
        {
            RETRY:
            Console.WriteLine("Enter the age");
            try
            {
                uint age = uint.Parse(Console.ReadLine());
                if (age == 0)
                    throw new AgeException("Age should not be 0 or negative");
                Console.WriteLine("The Age is " + age);
            }
            catch (FormatException)
            {
                Console.WriteLine("The input is expected to be a whole number");
                goto RETRY;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"It should be b/w {uint.MinValue} and {uint.MaxValue}");
                goto RETRY;
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
                goto RETRY;
            }
            finally
            {
                Console.WriteLine("End of the Program");
            }
        }
    }
}
