using System.Reflection;

namespace ReflectionAnnotationsAndGarbage
{
    internal class Reflections : FindNearestNumber
    {
        public void Show()
        {
            Type type = typeof(FindNearestNumber);
            Console.WriteLine(type.Name);
            Console.WriteLine("Methods:");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine("\nConstructors:");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
            }
            Console.WriteLine("\nProperties:");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }
        }
    }
}
