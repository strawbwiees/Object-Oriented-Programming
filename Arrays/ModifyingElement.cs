Console.Write("Enter the size of the array:");

int size = int.Parse(Console.ReadLine());

int[] myArray = new int[size];

Console.WriteLine("Enter the elements of the array:");
for (int i = 0; i < size; i++)
{
    Console.Write($"Element {i + 1}: ");
    myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nOriginal array:" + string.Join(", ", myArray));

Console.Write("\nEnter the index of the element you want to modify:");
int index = int.Parse(Console.ReadLine());

Console.WriteLine($"Current value at index {index}: {myArray[index]}");

Console.Write("Enter the new value: ");
int newValue = int.Parse(Console.ReadLine());

myArray[index] = newValue;
Console.WriteLine("Array after modifying the element:" + string.Join(", ", myArray));
