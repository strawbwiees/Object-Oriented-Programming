using System;

namespace UDFWithParameters
{
    public class UDFWithParameters
    {
        static void message(string name)
        {
            Console.WriteLine("Welcome friend " + name + "!");
            Console.WriteLine("Have a nice day!");
        }

        static void Main() {
            Console.Write("Please input a name: ");
            string name = Console.ReadLine();
            message(name);
        }
    }
}
