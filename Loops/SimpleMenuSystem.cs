Console.WriteLine("==== MENU ====");
Console.WriteLine("1. Say Hello");
Console.WriteLine("2. Display Date");
Console.WriteLine("3. Exit");

Console.Write("Enter choice: ");
int choice = int.Parse(Console.ReadLine());

do
{
    switch (choice)
    {
        case 1:
            Console.WriteLine("Hello!");
            break;
        case 2:
            Console.WriteLine("Current Date: " + DateTime.Now.ToShortDateString());
            break;
        case 3:
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
    if (choice != 3)
    {
        Console.Write("\nEnter choice: ");
        choice = int.Parse(Console.ReadLine());
    }
} while (choice != 3);
