int secretnumber = 45;
int usersGuess = 0;

while (usersGuess != secretnumber)
{
    Console.Write("Guess the number: ");
    usersGuess = int.Parse(Console.ReadLine());

    if (usersGuess > secretnumber)
    {
        Console.WriteLine("Too high!\n");
    }
    else if (usersGuess < secretnumber)
    {
        Console.WriteLine("Too low!\n");
    }
    else
    {
        Console.WriteLine("Correct! You guessed the number.");
    }
}
