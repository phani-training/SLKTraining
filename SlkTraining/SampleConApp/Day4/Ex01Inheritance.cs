using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Inheritance is a feature of OOP based on a principle called open-closed principle. A Class is open for Extension but closed for modification.
 * A class once created, is immutable. U cannot change the class. 
 * Any change that U wish to implement to a class has to be done thru extension where the class is inherited into another and that class will be provided with these additional changes. 
 * SOLID Principles of OOP.
 * The class that is being extended is class as BASE/SUPER/PARENT class. The class that is extending is called as DERIVED/SUB/CHILD class. 
 * C# supports Single Inheritance. A class at any given level can have only one base class. C++ supports multiple Inheritance which has got issues with hirarchy. However, it supports multi level inheritance. A class can have a base class that is further derived from another class and so forth.  
 * There is no public accessor while U derive from the base class. All base class methods are available with the Same access specifier to its derived classes. 
 */
namespace SampleConApp.Day4
{

    class Account
    {
        public int AccountNo { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
    }

    class SBAccount : Account
    {
        public double RateOfInterest { get; set; }

        public void CreditAmount(double amount) => Balance += amount;

        public void DebitAmount(double amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new Exception("Insufficient Funds");
            }
        }

        public void CalculateInterest()
        {
            double principle = Balance;
            double term = 0.25;
            double interest = (principle * RateOfInterest * term) / 100;
            CreditAmount(interest);
        }
    }
    class Ex01Inheritance
    {
        static void Main()
        {
            Account acc = new Account { AccountNo = 111, Balance = 6000, Name = "Phaniraj" };

            SBAccount sbAcc = new SBAccount { AccountNo = 111, Balance = 6000, Name = "Phaniraj", RateOfInterest = 6.5 };
            sbAcc.DebitAmount(399);
            sbAcc.CreditAmount(60000);
            sbAcc.CalculateInterest();
            Console.WriteLine("The Balance is " + sbAcc.Balance);
        }
    }
}
