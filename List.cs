// var names = new List<string> { "Nitish", "Ana", "Felipe" };
// foreach (var name in names)
// {
//   Console.WriteLine($"Hello {name.ToUpper()}!");
// }

// Console.WriteLine();
// names.Add("Maria");
// names.Add("Bill");
// names.Remove("Ana");
// foreach (var name in names)
// {
//   Console.WriteLine($"Hello {name.ToUpper()}!");
// }


// Console.WriteLine($"My name is {names[0]}.");
// Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

// Console.WriteLine($"The list has {names.Count} people in it");


// //index of element in List // Indexof()
// var index = names.IndexOf("Nitish");
// if (index != -1)
// {
//   Console.WriteLine($"The name {names[index]} is at index {index}");
// }
// var notFound = names.IndexOf("Not Found");
// Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");



//sorting in list 
// name.Sort();


// names.Sort();
// foreach (var name in names)
// {
//   Console.WriteLine($"Hello {name.ToUpper()}!");
// }



//fibbonacci series

// var fibonacciNumbers = new List<int> {1, 1};

// var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
// var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

// fibonacciNumbers.Add(previous + previous2);

// foreach(var item in fibonacciNumbers)
// {
//     Console.WriteLine(item);
// }



var fibonacciNumbers = new List<int> {1, 1};

while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}
foreach(var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}
