using System.Reflection;

namespace ReflectionAnnotationsAndGarbage
{
    internal class InvokeMethod
    {
        public void Invokee(string className)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type classType = assembly.GetType(className);

            if (classType != null)
            {
                // Create an instance of the class
                object instance = Activator.CreateInstance(classType);

                // Get the MethodInfo for the method you want to invoke
                MethodInfo methodInfo = classType.GetMethod("FindClosestNumberWithEvenDigits");

                if (methodInfo != null)
                {
                    // Invoke the method on the instance
                    object result = methodInfo.Invoke(instance, null);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Method not found");
                }
            }
            else
            {
                Console.WriteLine("Class not found");
            }
        }
    }
}

