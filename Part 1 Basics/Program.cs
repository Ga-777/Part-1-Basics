// See https://aka.ms/new-console-template for more information



Console.ForegroundColor = ConsoleColor.DarkGreen;

Console.WriteLine(@"
        
-------------------------------------------------------------------------,  _______________
[] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [  |,----------.  |\
-----------------------------------------------------------------------/   ||           |=| |
      \|/ | O -   ^^         |                  |           _   _     |    ||          || | |
     --O--|/ \        O  ^^  |   ^^   |||||     |     ___  ( ) ( )   _/    ||       . _o| | | __
 /\   /|\ |         --|--    | ^^     |O=O|     |_ __/_|_\,_|___|___/      |`-----------' |/ /~/
/  \/\    |~~~~~~~~~~~|~~~~~~|        ( - )     | `-O---O-'       |         ~~~~~~~~~~~~~~~ / /
  /\  \/\_|          / \     |       .-~~~-.    | -- -- -- -- -- /                          ~~
 /  /\ \  |         '   `    |      //| o |\\   |______________ |
--------------------------------------------------------------_/
[] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] ['
------------------------------------------------------------'
");
string quote = "";
string favMovie, firstName;
Console.WriteLine("FavMovie_ASCII_art_gen.com");
Console.WriteLine("///////////////////////////////////////////");
Console.WriteLine("press enter to continue");

Console.ReadLine();
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Please enter your first name:");
firstName = Console.ReadLine();
Console.Clear();
Console.WriteLine("Hi " + firstName.ToLower());
Console.WriteLine("press enter to continue");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
Console.WriteLine("Please enter your favorite movie:");
favMovie = Console.ReadLine();
Console.Clear();
Console.WriteLine("press enter to continue");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
if (string.IsNullOrEmpty(favMovie))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You didn't enter a favorite movie. Please try again.");
    return;
}
if (string.IsNullOrEmpty(firstName))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You didn't enter a first name. Please try again.");
    return;
}


Console.WriteLine("Welcome to FavMovie_ASCII_art_gen.com " + firstName.ToLower() + "!");
Console.WriteLine("////////////////////////////////////////////////////////");
Console.WriteLine("");
Console.WriteLine("Your favorite movie is: " + favMovie.ToUpper());
Console.WriteLine("Press enter to Check out the movie's ASCII art");

if (favMovie.ToLower().Contains("terminator"))
{
    quote = "I'll be back!";
    Console.ReadLine();
    Console.Clear();
    Thread.Sleep(1000);
    favMovie = favMovie.Replace("A", "@");
    favMovie = favMovie.Replace("a", "@");
    favMovie = favMovie.Replace("E", "3");
    favMovie = favMovie.Replace("e", "3");
    Console.WriteLine(favMovie.ToUpper());
    Console.WriteLine("ASCII art for Terminator:");
    Console.WriteLine(@"
                     ______
                   <((((((\\\
                   /      . }\
                   ;--..--._|}
(\                 '--/\--'  )
 \\                | '-'  :'|
  \\               . -==- .-|
   \\               \.__.'   \--._
   [\\          __.--|       //  _/'--.
   \ \\       .'-._ ('-----'/ __/      \
    \ \\     /   __>|      | '--.       |
     \ \\   |   \   |     /    /       /
      \ '\ /     \  |     |  _/       /
       \  \       \ |     | /        /
 snd    \  \      \        / ");
    Console.WriteLine("");
    Console.WriteLine(quote);
}
if (favMovie.ToLower().Contains("star wars"))
{
    quote = "May the force be with you!";
    Console.ReadLine();
    Console.Clear();
    Thread.Sleep(1000);
    favMovie = favMovie.Replace("A", "@");
    favMovie = favMovie.Replace("a", "@");
    favMovie = favMovie.Replace("E", "3");
    favMovie = favMovie.Replace("e", "3");
    Console.WriteLine(favMovie.ToUpper());
    Console.WriteLine("ASCII art for star wars:");
    Console.WriteLine(@"
      ________________
     |'-.--._ _________:
     |  /    |  __    __\
     | |  _  | [\_\= [\_\
     | |.' '. \.........|
     | ( <)  ||:       :|_
      \ '._.' | :.....: |_(o
       '-\_   \ .------./
       _   \   ||.---.||  _
      / \  '-._|/\n~~\n' | \
     (| []=.--[===[()]===[) |
     <\_/  \_______/ _.' /_/
     ///            (_/_/
     |\\            [\\
     ||:|           | I|
     |::|           | I|
     ||:|           | I|
     ||:|           : \:
     |\:|            \I|
     :/\:            ([])
     ([])             [|
      ||              |\_
     _/_\_            [ -'-.__
snd <]   \>            \_____.>
      \__/");
    Console.WriteLine("");
    Console.WriteLine(quote);
}


if
(favMovie.ToLower().Contains("spaceballs"))
{
    quote = "May the Schwartz be with you!";
    Console.ReadLine();
    Console.Clear();
    Thread.Sleep(1000);
    favMovie = favMovie.Replace("A", "@");
    favMovie = favMovie.Replace("a", "@");
    favMovie = favMovie.Replace("E", "3");
    favMovie = favMovie.Replace("e", "3");
    Console.WriteLine(favMovie.ToUpper());
    Console.WriteLine("ASCII art for Spaceballs:");
    Console.WriteLine(@"
        _________
     ,''         ``.
    /               \
   |   ,---------.   |
   |  /--.\ | /,--\  |
   | /`-._\\|//_,-'\ |
   |/._ _ _____ _ _.\|
   /   \ |=/#\=| /   \
  (_`-._\|=\#/=|/_,-'_)
   /  ._'-.___,-'_,  \
  / /   `-.\_/.-'   \ \
 : (  ,    | |    .  ) \
 |  \ |    |||    | /  |
 |   \|    |||    |/   |
 | ,-'|    |||    |`-. |
 |/|  |____\|/____|  |\|
  \'--|___((_))___|--|/
   |\_|-_ \\|//__-|_/ |
   |  |_  -\|/- ._|   /
   |\ |____/ \____|  |\
   ; \ |   | |   |   |;
  /   .|   | |   |   ||
  |   ||   | |   |    \
  ;   || -.| | -.|    /
  |   ;| - | |-- |   /\
  ;  ; |   | |   |   ||
  /  | |   | |   |   / \
 |  /  |___| |___|   \ |
/__,--.(=--)_(-- )_,--\_\
       /   ) (   \
 jrei /  ,'   '.  \
     (_,'       '._)");
    Console.WriteLine("");
    Console.WriteLine(quote);
}
else
    {
        Console.ReadLine();
        Console.Clear();
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Sorry, we don't have ASCII art for that movie.");
    }

