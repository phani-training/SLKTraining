using System;
using System.Collections.Generic;

/*
 * Collection in .NET is a class that has multiple objects in it and is dynamic(U can add, remove, update anytime). It resolves the limitations of Arrays.
 * Collections in .NET are of 2 types: Generic and NonGeneric.
 * NonGeneric is old and has become obselete. In these collections, we can store any kind of data as they are internally stored as objects. object is unversal type, it can hold any type of data in it. The purpose of holding similar data is questionable. 
 * Generic Collections released in .NET 2.0(2005) is more type safe and stores only the data of that type. Generic collections are actually based on Non-Generic collections.
 * All the collection classes will implements some std interfaces to give a common set of functions to all kinds of collections
 * Important base interfaces for most of the collections: IEnumerable<T>->ICollection<T>->IList<T>, ISet<T>, IDictionary<K,V> and many more.
 * List<T>, HashSet<T>, Dictionary<K,V> are some of the major collection classes we use in our application. 
 * U should try to develop a Full App with actual data like Employee, Customer, Product,
 * Queue<T> and Stack<T> to work: 
 */
namespace SampleConApp.Day7
{
    class Ex01Collections
    {
        static Dictionary<string, string> users = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            //listExample();
            //SetExample();
            dictionaryExample();
        }

        private static void dictionaryExample()
        {
            //Data is stored in the form of key-value pairs where key is unique for the collection and value can be same.
            //Example of Usenames(Unique) and Passwords(might not be unique).
            //Hashtable is similar to Dictionary.
            //Dictionary is a collection of words(Key) and meanings  where word(Key) is unique and the meaning(Value) need not be unique.  
            do
            {
                Console.WriteLine("Enter 1 to sign-up or 2 to sign-in");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                    addUserHelper();
                else
                    loginUserHelper();

            } while (true);
        }

        private static void loginUserHelper()
        {
            Console.WriteLine("Enter the username");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Password");
            string pwd = Console.ReadLine();
            //3 answers: wrong name, wrong pwd or correct name and pwd
            if (!users.ContainsKey(name))
            {
                Console.WriteLine("User does not exist");
                return;
            }
            if(users[name] != pwd)
            {
                //name: key(index), users[name] refers to password
                Console.WriteLine("Password is wrong");
                return;
            }
            Console.WriteLine("Login Successfull");
        }

        private static void addUserHelper()
        {
            retry:
            Console.WriteLine("Enter the username");
            string name = Console.ReadLine();
            if (users.ContainsKey(name))
            {
                Console.WriteLine("This user already exists");
                goto retry;
            }
            Console.WriteLine("Enter the Password");
            string pwd = Console.ReadLine();
            users.Add(name, pwd);
        }
        private static void SetExample()
        {
            //Very similar to List, but will store only unique values. Internally it used an object's HashCode(Id created by .NET CLR to indentify an object/variable). For value types, the hashcode is the value itself. 
            var fruits = new HashSet<string>();
            do
            {
                Console.WriteLine("Enter the Fruit Name to add");
                var name = Console.ReadLine();
                if (!fruits.Add(name))
                {
                    Console.WriteLine($"The fruit {name} is already added");
                }
                Console.WriteLine("THe current basket items are : ");
                foreach (var item in fruits)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("Its HashValue is " + item.GetHashCode());
                }
            } while (true);//infinite loop....
        }

        private static void listExample()
        {
            //U can replace string with any other data type.
            //List<string> fruits = new List<string>(new string[] {
            //  "Apples", "Mangoes", "Oranges"
            //});//size will be 3

            ///////////////Create a blank List/////////////////
            List<string> fruits = new List<string>();
            fruits.Add("Apples");
            fruits.Add("Pine Apples");
            fruits.Add("Custard Apples");
            fruits.Add("Kashmir Apples");
            fruits.Add("Ooty Apples");

            foreach (var name in fruits)
                Console.WriteLine(name);
            var isRemoved = fruits.Remove("Apples large");//Removes the Apples
            if (isRemoved)
            {
                Console.WriteLine("It is removed");
            }
            else
            {
                Console.WriteLine("It was not found to remove");
            }
            //Insert(index, Value), InsertRange(index, Range), RemoveAt(index)

        }
    }
}
