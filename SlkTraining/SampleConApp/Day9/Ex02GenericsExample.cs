using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp.Day9
{
    class MyCollectionclass<T>
    {
        List<T> _collection = new List<T>();

        public void Add(T element) => _collection.Add(element);

        public List<T> All() => _collection;

        public void Update(int index, T element)
        {
            //var found = _collection[index];
            //found = element;

            _collection[index] = element;//More simplified one...
        }

        public T FindElement(Predicate<T> finder)
        {
            T found = _collection.Find(finder);
            return found;
        }
    }

    class Ex02CustomGenericsExample
    {
        static string name = string.Empty;
        static bool apple(string value)
        {
            return name == value;
        }
        
        static void Main(string[] args)
        {
            MyCollectionclass<string> collection = new MyCollectionclass<string>();
            collection.Add("Apples");
            collection.Add("Mangoes");
            collection.Add("Oranges");
            collection.Add("PineApples");
            collection.Add("Gauvas");

            var data = collection.All();
            foreach (var item in data) Console.WriteLine(item);

            Console.WriteLine("Enter the fruit Name to find");
            string name = Console.ReadLine();

            var foundRec = collection.FindElement(apple);
            //var foundRec = collection.Find((value) => value == name);

            Console.WriteLine("The found Fruit is " + foundRec); 

        }
    } 
}
