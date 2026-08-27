using System;
namespace Calculator
{

    public class test
    {
        public static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;

            ret = Sum(a, b);
            Console.WriteLine("Max value is: {0}", ret);
            Console.ReadLine();
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;

        }
    }
}
