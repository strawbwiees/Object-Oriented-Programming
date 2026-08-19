string correctPass = "123456789Password";
string userInput = "";

while(userInput != correctPass)
{
    Console.Write("Enter password: ");
    userInput = Console.ReadLine();

    if (userInput == correctPass)
    {
        Console.WriteLine("Access granted!");
    }
    else
    {
        Console.WriteLine("Incorrect password.");
    }
}
