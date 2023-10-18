namespace ReflectionAnnotationsAndGarbage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Find nearest number with all even digits\n2.Fetch all class members\n3.Empty object Defualt constructor and Parameterized constructor\n4.Invoke method\n5.Exit");
            bool loopAgain = true;
            while (loopAgain)
            {
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FindNearestNumber find = new FindNearestNumber(22);
                        find.FindClosestNumberWithEvenDigits();
                        break;
                    case 2:
                        Reflections reflections = new Reflections();
                        reflections.Show();
                        break;
                    case 3:
                        DefualtConstructor defualtConstructor = new DefualtConstructor();
                        defualtConstructor.CreateFindNearestNumber("ReflectionAnnotationsAndGarbage.FindNearestNumber");
                        defualtConstructor.CreateFindNearestNumberWithParameter("ReflectionAnnotationsAndGarbage.FindNearestNumber", "FindNearestNumber", 20);
                        break;
                    case 4:
                        InvokeMethod invokeMethod = new InvokeMethod();
                        invokeMethod.Invokee("ReflectionAnnotationsAndGarbage.FindNearestNumber");
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    case 6:
                        loopAgain = false;
                        break;
                }
            }
        }
    }
}