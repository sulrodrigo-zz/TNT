using System;

namespace TNT
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteHeader();

            Console.WriteLine("Hey, Newbie! Tell me your name!");
            string player = Console.ReadLine();
            Console.Clear();
            WriteHeader();
            Console.WriteLine("Welcome {0}! Let's Play a Game...", player);
            Console.WriteLine(@"   _________ _____  ___  _________   ");
            Console.WriteLine(@"  |___   ___|| |\ \ | | |___   ___|  ");
            Console.WriteLine(@"      | |    | | \ \| |     | |      ");
            Console.WriteLine(@"      | |    | |  \ | |     | |      ");
            Console.WriteLine(@"      | |    | |   \  |     | |      ");
            Console.WriteLine(@"      |_|    |_|    \_|     |_|      ");
            Console.WriteLine("");
            Console.WriteLine("           :: THE GAME ::            ");
            Console.WriteLine("");

            while (true) {

                Random random = new Random();

                int correctNumber = random.Next(1,10);
                int guess = 0;

                Console.WriteLine("Choose a Number Between 1 and 10");

                while(guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if(!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Whoops... This is not a number...");
                        Console.ResetColor();
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if(guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("WRONG NUMBER! Try Again!");
                        Console.ResetColor();
                    }


                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("RIGHT NUMBER! Well Done!");
                Console.ResetColor();

                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.ReadKey();
                    return;
                }                
            }
        }


        public static void WriteHeader()
        {
            string AppName = "TNT";
            string AppVersion = "0.0.2";
            string AppAuthor = "Rodrigo Sul";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1}. Created By: {2}", AppName, AppVersion, AppAuthor);
            Console.ResetColor();
        }


    //    Console.WriteLine("Enter a Number between 1 and 10");
    //        int guess = Int32.Parse(Console.ReadLine());
    //    Random random = new Random();
    //    int result = random.Next(0, 10);
    //        while(guess != result)
    //        {
    //            Console.WriteLine("Enter a Number between 1 and 10");
    //        }

    //Console.WriteLine("Congrats!");



    }
}
