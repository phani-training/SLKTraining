using SampleConApp.Day8;
using System;
using System.Reflection;
//Reflection is a way of reading the metadata of an Assembly or an existing code in a programmatic manner. 
//With the metadata, we can get the classes, its members, accessiblity, member type, parameter info for those methods and many more. 
namespace SampleConApp.Day9
{
    class Ex01ReflectionExample
    {
        static void displayMethods(string className)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var selectedClassInfo = assembly.GetType(className);
            if (selectedClassInfo == null)
            {
                Console.WriteLine("The Class name is not found with us");
                return;
            }
            var methods = selectedClassInfo.GetMethods();
            foreach(var method in methods)
            {
                Console.WriteLine("Method Name: " + method.Name);
                Console.WriteLine("Parameters of the method");
                foreach(var parameter in method.GetParameters())
                {
                    Console.WriteLine($"Parameter Name: {parameter.Name}\nData Type : {parameter.ParameterType.Name}");
                }
            }
        }
        static void displayAllClasses()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var classes = assembly.GetTypes();
            foreach(var cls in classes)
                Console.WriteLine(cls.FullName);
        }

        static void getAttributes()
        {
            var classInfo = Assembly.GetExecutingAssembly().GetType("SampleConApp.Day8.Ex03Attributes");
            if(classInfo == null)
            {
                Console.WriteLine("Class not found");
                return;
            }

            var attributes = classInfo.GetCustomAttributes();
            foreach(var attribute in attributes)
            {
                if(attribute is GenderAttribute)
                {
                    var temp = attribute as GenderAttribute;
                    Console.WriteLine(temp.DefaultGender);
                }
            }
        }
        static void Main(string[] args)
        {
            displayAllClasses();            
            Console.WriteLine("Select one class from the List above");
            string fullName = Console.ReadLine();
           

            invokeMethod(fullName);

            //getAttributes();


        }

        static void invokeMethod(string className)
        {
            var cls = Assembly.GetExecutingAssembly().GetType(className);
            foreach(var m in cls.GetMethods())
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine("Select one method from the list above");
            string method = Console.ReadLine();
            var methodInfo = cls.GetMethod(method);
            //Get the parameters
            var parameters = methodInfo.GetParameters();
            object[] values = new object[parameters.Length];
            //Get the values from the user for those parameters
            for(int i = 0; i < values.Length; i++)
            {
                var pmName = parameters[i].Name;
                var pmType = parameters[i].ParameterType;
                Console.WriteLine($"Enter the value for {pmName} which is of the type {pmType.FullName}");
                var value = Console.ReadLine();
                values[i] = Convert.ChangeType(value, pmType);
            }
            //Create the object of UR Class
            var instance = Activator.CreateInstance(cls);
            //Invoke the method with this instance
            var result = methodInfo.Invoke(instance, values);
            Console.WriteLine($"The result of {methodInfo.Name} is {result}");

        }
    }
}
