using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    static class Utilities
    {
        public static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        public static int GetNumber(string question)=> int.Parse(GetString(question));
        
        public static double GetDouble(string question) => double.Parse(GetString(question));
    }
}
