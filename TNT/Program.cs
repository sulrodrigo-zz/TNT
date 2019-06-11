using System;

namespace TNT
{
    class Program
    {
        static void Main(string[] args)
        {
            string AppName = "TNT";
            string AppVersion = "0.0.1";
            string AppAuthor = "Rodrigo Sul";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1}. Created By: {2}", AppName, AppVersion, AppAuthor);
            Console.ResetColor();

            Console.WriteLine("Hey, Newbie! Tell me your name!");
            string player = Console.ReadLine();
            Console.WriteLine("Welcome {0}! Let's Play a Game...", player);

            Console.ReadKey();
        }
    }
}
