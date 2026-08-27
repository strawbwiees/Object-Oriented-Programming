using System;

namespace Program11
{
    public class Fibonacci
    {
        public static void Main()
        {
            Console.Write("Input number of Fibonacci Series : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nThe Fibonacci series of {n} numbers is : ");
            DisplayFibonacci(n);
        }

        public static void DisplayFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int temp;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }
    }
}
