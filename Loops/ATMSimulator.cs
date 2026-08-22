int initialBalance = 10000;
int atmChoice = 0;

do
{
    Console.WriteLine("==== ATM MENU =====");
    Console.WriteLine("1. Check Balance");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Exit");

    Console.Write("Enter choice: ");
    atmChoice = int.Parse(Console.ReadLine());

    switch (atmChoice)
    {
        case 1:
            Console.WriteLine("Current Balance: " + initialBalance + " php\n");
            break;
        case 2:
            Console.Write("Enter amount to deposit: ");
            int depositAmount = int.Parse(Console.ReadLine());
            initialBalance += depositAmount;
            Console.WriteLine("Deposited: " + depositAmount + " php");
            Console.WriteLine("Current Balance: " + initialBalance + " php\n");
            break;
        case 3:
            Console.Write("Enter amount to withdraw: ");
            int withdrawAmount = int.Parse(Console.ReadLine());
            if (withdrawAmount <= initialBalance)
            {
                initialBalance -= withdrawAmount;
                Console.WriteLine("Withdrew: " + withdrawAmount + " php");
                Console.WriteLine("Current Balance: " + initialBalance + " php\n");
            }
            else
            {
                Console.WriteLine("Insufficient funds.\n");
            }
            break;
        case 4:
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.\n");
            break;
    }
} while (atmChoice != 4);
