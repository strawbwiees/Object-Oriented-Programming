// Program 1

Console.WriteLine();
Console.WriteLine("PROGRAM 1");

Console.Write("Enter first number: ");
int firstNum = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int secondNum = int.Parse(Console.ReadLine());

int newfirstNum = secondNum;
int newsecondNum = firstNum;

Console.WriteLine("After swapping: ");
Console.WriteLine("First number: " + newfirstNum);
Console.WriteLine("Second number: " + newsecondNum);

//Program 2

Console.WriteLine();
Console.WriteLine("PROGRAM 2");

Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Enter third number: ");
int num3 = int.Parse(Console.ReadLine());

int largest = Math.Max(num1, Math.Max(num2, num3));
int lowest = Math.Min(num1, Math.Min(num2, num3));


Console.WriteLine("The largest number is: " + largest);
Console.WriteLine("The lowest number is: " + lowest);

//Program 3

Console.WriteLine();
Console.WriteLine("PROGRAM 3");

Console.Write("Enter first integer: ");
int firstInt = int.Parse(Console.ReadLine());

Console.Write("Enter second integer: ");
int secondInt = int.Parse(Console.ReadLine());

int value = 20;

int value1 = Math.Abs(firstInt - value);
int value2 = Math.Abs(secondInt - value);

if (value1 < value2)
{
    Console.WriteLine("The number closest to 20 is: " + firstInt);
}
else if (value2 < value1)
{
    Console.WriteLine("The number closest to 20 is: " + secondInt);
}
else
{
    Console.WriteLine("0");
}
