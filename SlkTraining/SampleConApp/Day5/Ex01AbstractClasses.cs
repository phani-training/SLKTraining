using System;
/*
 * Abstract is a concept of a feel rather than the actual seeing. Technically Abstraction is Implementation hiding. We can achieve this using Abstract classes. 
 * Abstract classes are those that have one or more abtract methods. These methods are not implemented in the class that is declared, rather it is implemented in the derived classes as they have the actual clarity of the functionality
 * Abstract classes are incomplete classes, as one or more methods are abstract and are not implemented. So U cannot instantiate them. 
 * If a class is derived from Abstract class, it must implement all the abstract methods of the abstract class. 
 */
namespace SampleConApp.Day5
{
    abstract class Account
    {
        public Account(int amount = 5000)
        {
            Balance = amount;
        }
        public int AccountNo { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }
        public void Credit(double amount) => Balance += amount;
        public void Debit(double amount) 
        {
            if(Balance < amount)
            {
                throw new Exception("Insufficient funds");
            }
            Balance -= amount;
        }
        //Calculation of interest is different for different kinds of accounts. But all accounts in this back needs to calculate interest. 
        public abstract void CalculateInterest();
       
    }

    class SBAccount : Account
    {
        public override void CalculateInterest()
        {
            //var is a convinient way of declaring local variables. It is called as IMPLICITLY Typed Variables. 
            var pricipal = Balance;
            var rateOfInterest = 6.5 /100;
            var term = 0.25;

            var interest = pricipal * rateOfInterest * term;
            Credit(interest);
        }
    }

    //Create few more classes for RDAccount and FDAccount and implement the CalculateInterest function in its own way.
    //

    enum AccountType
    {
        SB, RD, FD
    }
    class AccountFactory
    {
        public static Account CreateAccount(AccountType acc)
        {
            switch (acc)
            {
                case AccountType.SB:
                    return new SBAccount();
                case AccountType.RD:
                    break;
                case AccountType.FD:
                    break;
            }
            return null;
        }
    }
    class Ex01AbstractClasses
    {
        static void Main(string[] args)
        {
            Account acc = AccountFactory.CreateAccount(AccountType.SB);
            acc.CalculateInterest();
            Console.WriteLine("The Balance is " + acc.Balance);
        }
    }
}
