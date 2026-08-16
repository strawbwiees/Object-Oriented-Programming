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

Console.Write("\nEnter the index of the element you want to remove:");

int removeIndex = int.Parse(Console.ReadLine());
int[] removedArray = new int[myArray.Length - 1];

for (int i = 0, j = 0; i < myArray.Length; i++)
{
    if (i == removeIndex)
    {
        continue;
    }

    removedArray[j] = myArray[i];
    j++;
}

Console.WriteLine("After removing element: " + string.Join(", ", removedArray));
