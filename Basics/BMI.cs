Console.WriteLine("PROGRAM 2");

Console.Write("Enter weight in kg: ");
double weight = double.Parse(Console.ReadLine());

Console.Write("Enter height in cm: ");
int height = int.Parse(Console.ReadLine());

double heightInMeters = height / 100.0;
double bmi = weight / (heightInMeters * heightInMeters);

Console.WriteLine("Your BMI is: " + bmi);

if (bmi < 18.5)
{
    Console.WriteLine("You're underweight.");
}
else if (bmi >= 18.5 && bmi < 24.9)
{
    Console.WriteLine("You have a normal weight.");
}
else if (bmi >= 25 && bmi < 29.9)
{
    Console.WriteLine("You're overweight.");
}
else
{
    Console.WriteLine("You're obese.");
}
