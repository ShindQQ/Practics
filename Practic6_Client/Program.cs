using System.Reflection;

using Practic6;

namespace Practic6_Client
{
    class Program
    {
        static void GetParams(Assembly assembly)
        {
            Type type = assembly.GetType("Practic6.Temperature");

            Console.WriteLine($"Class: {type}");

            MethodInfo method = type.GetMethod("ConvertTemp");

            Console.WriteLine($"Info: {method.Name}");

            ParameterInfo[] parameters = method.GetParameters();

            Console.WriteLine($"Method has {parameters.Length} parametrs");


            foreach (var item in parameters)
            {
                Console.WriteLine($"Parametr name: {item.Name}");
                Console.WriteLine($"Parametr position: {item.Position}");
                Console.WriteLine($"Parametr type: {item.ParameterType}");
            }

            Console.WriteLine("-----");
        }

        static void ListAllMembers(Assembly assembly)
        {
            Type type = assembly.GetType("Practic6.Temperature");

            Console.WriteLine($"Class: {type}");

            MemberInfo[] members = type.GetMembers();

            foreach (MemberInfo member in members)
            {
                Console.WriteLine($"{member.MemberType}, {member}");
            }

            Console.WriteLine("-----");
        }

        static void ListAllTypes(Assembly assembly)
        {
            Console.WriteLine($"Types: {assembly.FullName}");

            Type[] types = assembly.GetTypes();

            foreach (var item in types)
            {
                Console.WriteLine($"Type: {item}");
            }

            Console.WriteLine("-----");
        }

        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("Practic6");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            ListAllTypes(assembly);
            ListAllMembers(assembly);
            GetParams(assembly);

            Temperature temp = new Celsius(50);
            Console.WriteLine(temp.ConvertTemp());

            temp = new Farenheit(50);
            Console.WriteLine(temp.ConvertTemp());
        }
    }
}