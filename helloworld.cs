string aFriend = "Bill";
Console.WriteLine(aFriend);
aFriend = "Maira";
Console.WriteLine(aFriend);
Console.WriteLine("Hello " + aFriend);

Console.WriteLine($"Hello {aFriend}");
//or
Console.WriteLine("Hello {0}", aFriend);

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");


//length of a string by .Length 
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

//Trim 

string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");


//Replace 
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

//changing case
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());


// search string 
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));// return True
Console.WriteLine(songLyrics.Contains("greetings"));//return False


//StartWith and EndsWith 
//string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));

Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));
