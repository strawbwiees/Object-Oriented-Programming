Console.WriteLine("Program 1");

Console.Write("Enter full name: ");
string fullName = Console.ReadLine();

Console.Write("Enter age: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Enter course: ");
string course = Console.ReadLine();

Console.Write("Enter section: ");
string section = Console.ReadLine();

Console.WriteLine("=============================");

Console.WriteLine("Full name: " + fullName);
Console.WriteLine("Age: " + age);
Console.WriteLine("Course: " + course);
Console.WriteLine("Section: " + section);

Console.WriteLine("=============================");

Console.WriteLine("Length of name: " + fullName.Length);

Console.WriteLine("=============================");

Console.WriteLine("Uppercase name: " + fullName.ToUpper());
Console.WriteLine("Lowercase name: " + fullName.ToLower());
