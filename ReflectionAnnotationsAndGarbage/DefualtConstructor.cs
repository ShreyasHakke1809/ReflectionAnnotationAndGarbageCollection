using System.Reflection;

namespace ReflectionAnnotationsAndGarbage
{
    public class DefualtConstructor : FindNearestNumber
    {
        public void CreateFindNearestNumber(string className)
        {
            Assembly executing = Assembly.GetExecutingAssembly();
            Type findNearestNumberType = executing.GetType(className);

            if (findNearestNumberType != null)
            {
                ConstructorInfo constructor = findNearestNumberType.GetConstructor(Type.EmptyTypes);
                if (constructor != null)
                {
                    var instance = Activator.CreateInstance(findNearestNumberType);
                    Console.WriteLine("Instance created: " + instance);
                }
                else
                {
                    Console.WriteLine("Class does not have a parameterless constructor.");
                }
            }
            else
            {
                Console.WriteLine("Class not found.");
            }
        }
        public void CreateFindNearestNumberWithParameter(string className, string constructorName, int f)
        {
            Assembly executing = Assembly.GetExecutingAssembly();
            Type findNearestNumberType = executing.GetType(className);

            if (findNearestNumberType != null)
            {
                ConstructorInfo constructorInfo = findNearestNumberType.GetConstructor(new Type[] { typeof(int) });
                if (constructorInfo != null && constructorInfo.Name == constructorName)
                {
                    var obj = constructorInfo.Invoke(new object[] { f });
                    Console.WriteLine("Object created: " + obj);
                }
                else
                {
                    Console.WriteLine("Could not find constructor with parameters");
                }
            }
            else
            {
                Console.WriteLine("Class not found");
            }
        }
    }
}

