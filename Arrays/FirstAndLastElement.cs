Console.Write("Enter the size of the array:");

int size = int.Parse(Console.ReadLine());

int[] myArray = new int[size];

Console.WriteLine("Enter the elements of the array:");
for (int i = 0; i < size; i++)
{
    Console.Write($"Element {i + 1}: ");
    myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nArray:" + string.Join(", ", myArray));

Console.WriteLine($"First element: {myArray[0]}");
Console.WriteLine($"Last element: {myArray[size - 1]}");
