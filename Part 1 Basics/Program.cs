// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.DarkGreen;
string favMovie, firstName;
Console.WriteLine("FavMovie.com");
Console.WriteLine("///////////////////////////////////////////");
Console.WriteLine("press enter to continue");

Console.ReadLine();
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Please enter your first name:");
firstName = Console.ReadLine();
Console.WriteLine("Hi " + firstName.ToLower());
Console.WriteLine("press enter to continue");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
Console.WriteLine("Please enter your favorite movie:");
favMovie = Console.ReadLine();
Console.WriteLine("press enter to continue");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
Console.WriteLine("Welcome to FavMovie.com " + firstName.ToLower() + "!");
Console.WriteLine("////////////////////////////////////////////////////////");