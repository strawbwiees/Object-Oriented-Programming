using System;

namespace Program6
{
    public class NearestValue
    {
        public static int Nearest(int firstInt, int secondInt)
        {
            int target = 20;

            int value1 = Math.Abs(firstInt - target);
            int value2 = Math.Abs(secondInt - target);

            if (value1 < value2)
            {
                return firstInt;
            }
            else if (value2 < value1)
            {
                return secondInt;
            }
            else
            {
                return 0; 
            }
        }

        public static void Main()
        {
            Console.Write("Enter first number: ");
            int firstInt = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondInt = int.Parse(Console.ReadLine());
            int closestNumber = Nearest(firstInt, secondInt);

            if (closestNumber == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("The number closest to 20 is: " + closestNumber);
            }
        }
    }
}
