using System;

namespace Program4
{
    public class PrimeNumber
    {
        public static int Prime(int number)
        {
            if (number <= 1)
            {
                return 0;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }

            return 1;
        }

        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int prime = Prime(number);

            if (prime == 1)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }
    }
}
