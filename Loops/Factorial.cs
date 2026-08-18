Console.Write("Enter number: ");
int factorialnumber = int.Parse(Console.ReadLine());
long factorial = 1;

for (int i = 1; i <= factorialnumber; i++)
{
    factorial *= i; 
}

Console.WriteLine($"{factorialnumber}! = {factorial}");
