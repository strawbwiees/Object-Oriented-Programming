using System;

namespace Program3
{
    public class SumOfTwoNumbers
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Main()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = Sum(num1, num2);

            Console.WriteLine("The sum is: " + sum);
        }
    }
}
