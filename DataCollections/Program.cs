var names = new List<string> { "<name>", "Ana", "Felipe" };
foreach (var name in names)
{
	Console.WriteLine($"Hello {name.ToUpper()}!");
}

// List<T> can grow and shrink
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");

foreach (var name in names)
{
	Console.WriteLine($"Hello {name.ToUpper()}!");
}
// List<T> can be accessed by index
Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

// Checking how long the list is
Console.WriteLine($"The list has {names.Count} people in it");

/* IndexOf searches for the specified object and returns the zero-based index
 * of the first occurrence within the entire List<T>
 * if the item is not in the list, it returns -1
 */
var index = names.IndexOf("Felipe");
if (index != -1)
{
	Console.WriteLine($"The name {names[index]} is at index {index}");
}
var notFound = names.IndexOf("Not Found");
Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

// Sorting the list
names.Sort(); // sorts the list alphabetically
foreach (var name in names)
{
	Console.WriteLine($"Hello {name.ToUpper()}!");
}

var fibonacciNumbers = new List<int> { 1, 1 };
var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

fibonacciNumbers.Add(previous + previous2);

foreach (var item in fibonacciNumbers)
{
	Console.WriteLine(item);
}

var Fibonaccis = new List<int> { 1, 1 };
while (Fibonaccis.Count < 20)
{
	var previousNum = Fibonaccis[Fibonaccis.Count - 1];
	var previousNum2 = Fibonaccis[Fibonaccis.Count - 2];

	Fibonaccis.Add(previousNum + previousNum2);
}
foreach (var item in Fibonaccis)
{
	Console.WriteLine(item);
}