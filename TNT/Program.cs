using System;

namespace TNT
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            GameMenu();
            int choice = int.Parse(Console.ReadLine());

            Console.Clear();
            GetAppInfo();

            if (choice == 1) {
                while (true)
                {

                    Random random = new Random();

                    int correctNumber = random.Next(1, 10);
                    int guess = 0;

                    Console.WriteLine("Choose a Number Between 1 and 10");

                    while (guess != correctNumber)
                    {
                        string input = Console.ReadLine();

                        if (!int.TryParse(input, out guess))
                        {
                            PrintColorMSG(ConsoleColor.Red, "Whoops... This is not a number...");
                            continue;
                        }

                        guess = Int32.Parse(input);

                        if (guess != correctNumber)
                        {
                            PrintColorMSG(ConsoleColor.Red, "WRONG NUMBER! Try Again!");
                        }
                    }
                    PrintColorMSG(ConsoleColor.Yellow, "RIGHT NUMBER! Well Done!");


                    Console.WriteLine("Play Again? [Y or N]");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                    {
                        continue;
                    }
                    else if (answer == "N")
                    {
                        Console.WriteLine("Bye!");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You're Badass, I like that. No Rules!");
                        Console.ReadKey();
                        return;
                    }
                }
            }
            else
            {
                PrintColorMSG(ConsoleColor.Red, "Not a Game!");
                Console.ReadKey();
                return;
            }
        }
        // Display App Info
        static void GetAppInfo()
        {
            string AppName = "TNT";
            string AppVersion = "0.2.0";
            string AppAuthor = "Rodrigo Sul";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1}. Created By: {2}", AppName, AppVersion, AppAuthor);
            Console.WriteLine(@"   _________ _____  ___  _________   ");
            Console.WriteLine(@"  |___   ___|| |\ \ | | |___   ___|  ");
            Console.WriteLine(@"      | |    | | \ \| |     | |      ");
            Console.WriteLine(@"      | |    | |  \ | |     | |      ");
            Console.WriteLine(@"      | |    | |   \  |     | |      ");
            Console.WriteLine(@"      |_|    |_|    \_|     |_|      ");
            Console.WriteLine("");
            Console.WriteLine("           :: THE GAME ::            ");
            Console.WriteLine("");
            Console.ResetColor();
        }

        //Ask user's Name and Greet
        static void GreetUser()
        {
            Console.WriteLine("Hey, Newbie! Tell me your name!");
            string player = Console.ReadLine();
            Console.WriteLine("Welcome {0}! Let's Play a Game...", player);
        }

        static void PrintColorMSG(ConsoleColor color, string msg)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        static void GameMenu()
        {
            PrintColorMSG(ConsoleColor.Blue,"        :: Choose Your Game! ::");
            Console.WriteLine(@"   _______________________________   ");
            Console.WriteLine(@"   |                             |   ");
            Console.WriteLine(@"   |    [1] - Number Guesser     |   ");
            Console.WriteLine(@"   |                             |   ");
            Console.WriteLine(@"   |                             |   ");
            Console.WriteLine(@"   |                             |   ");
            Console.WriteLine(@"   |_____________________________|   ");
        }
    }
}
