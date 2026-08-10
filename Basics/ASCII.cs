Console.WriteLine("PROGRAM 3");

Console.Write("Enter a character: ");
char character = Convert.ToChar(Console.ReadLine());

int asciiValue = (int)character;

if (asciiValue >= 65 && asciiValue <= 90)
{
    Console.WriteLine("The character is an uppercase letter.");
}
else if (asciiValue >= 97 && asciiValue <= 122)
{
    Console.WriteLine("The character is a lowercase letter.");
}
else if (asciiValue >= 48 && asciiValue <= 57)
{
    Console.WriteLine("The character is a digit.");
}
else
{
    Console.WriteLine("The character is a special character.");
}

Console.WriteLine("The ASCII value of the character is: " + asciiValue);
