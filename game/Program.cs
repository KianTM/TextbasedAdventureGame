using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int nav = 0;
            int navMax = 2;
            bool loopMenu = true;
            string[] mainMenuItems = new string[] { "Start game", "Options", "Exit" };
            PrintMenuItemsWithHeader(mainMenuItems, "Testland", 1);
            while (loopMenu)
            {
                ConsoleKey navInput = Console.ReadKey().Key;
                if (navInput == ConsoleKey.UpArrow)
                {
                    nav--;
                    if (nav < 0)
                    {
                        nav = navMax;
                    }
                    Console.Clear();
                }
                else if (navInput == ConsoleKey.DownArrow)
                {
                    nav++;
                    if (nav > navMax)
                    {
                        nav = 0;
                    }
                    Console.Clear();
                }
                else if (nav == 0 && navInput == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("You chose to start. This part of the game is still under development, so please have patience with me!");
                    loopMenu = false;
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                }
                switch (nav)
                {
                    case 0:
                        PrintMenuItemsWithHeader(mainMenuItems, "Testland", 1);
                        break;
                    case 1:
                        PrintMenuItemsWithHeader(mainMenuItems, "Testland", 2);
                        break;
                    case 2:
                        PrintMenuItemsWithHeader(mainMenuItems, "Testland", 3);
                        break;
                    default:
                        Console.WriteLine("how???");
                        break;
                }
            }
        }

        static void Highlight() // Changes the background on a series of strings to white and makes the text black
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Unhighlight() // Changes the background on a series of strings to black and makes the text white
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void HighlightString(string input) // Highlights a piece of string using the Highlight and Unhighlight methods
        {
            Highlight();
            Console.WriteLine(input);
            Unhighlight();
        }
        static void PrintMenuItems(string[] items, int highlight) // Print all items in a string variable in a menu format and highlight one
        {
            int x = 0;
            foreach (string i in items)
            {
                x++;
                if (x == highlight)
                {
                    HighlightString(i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void PrintMenuItemsWithHeader(string[] items, string header, int highlight) // Print all items in a string variable in a menu format with a header and highlight one
        {
            int x = 0;
            Console.WriteLine(header);
            Console.WriteLine();
            foreach (string i in items)
            {
                x++;
                if (x == highlight)
                {
                    HighlightString(i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}