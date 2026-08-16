Console.Write("Enter the size of the array:");

int size = int.Parse(Console.ReadLine());

int[] myArray = new int[size];

Console.WriteLine("Enter the elements of the array:");
for (int i = 0; i < size; i++)
{
    Console.Write($"Element {i + 1}: ");
    myArray[i] = int.Parse(Console.ReadLine());
}

//original array
Console.WriteLine("\nOriginal array:" + string.Join(", ", myArray));

Console.Write("\nAdd an element to the array (enter a number): ");

int newElement = int.Parse(Console.ReadLine());
int[] newArray = new int[myArray.Length + 1];
Array.Copy(myArray, newArray, myArray.Length);
newArray[myArray.Length] = newElement;

Console.WriteLine("Array after adding the new element:" + string.Join(", ", newArray));
