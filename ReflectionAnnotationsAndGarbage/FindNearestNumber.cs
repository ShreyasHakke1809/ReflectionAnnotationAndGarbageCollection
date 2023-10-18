namespace ReflectionAnnotationsAndGarbage
{
    public class FindNearestNumber
    {
        public int y;
        public FindNearestNumber()
        {
            Console.WriteLine("Defualt Constructor");
        }
        public FindNearestNumber(int y)
        {
            this.y = y;
        }
        public int name { get; set; }
        int closestEvenNumber;
        public void FindClosestNumberWithEvenDigits()
        {
            // Console.WriteLine("Enter an integer:");
            // y = Convert.ToInt32(Console.ReadLine());
            closestEvenNumber = y;
            while (true)
            {
                bool allDigitsEven = true;
                string numberStr = Math.Abs(closestEvenNumber).ToString();
                foreach (char digit in numberStr)
                {
                    if (digit % 2 != 0)
                    {
                        allDigitsEven = false;
                        break;
                    }
                }
                if (allDigitsEven)
                {
                    break;
                }
                closestEvenNumber++;
            }
            Console.WriteLine(closestEvenNumber);
        }
    }
}

