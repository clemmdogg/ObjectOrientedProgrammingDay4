using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay4.Utilities
{
    internal class Menu
    {
        public Menu() { }
        public int CreateMenu(string[] menu)
        {
            int userChoice = 0;
            bool isEnterPressed = false;
            while (!isEnterPressed)
            {
                int count = 0;
                Console.Clear();
                foreach (string item in menu)
                {
                    if (userChoice == count)
                    {
                        string line = "";
                        Console.ForegroundColor = ConsoleColor.White;
                        foreach (char c in item)
                        {
                            line += '─';
                        }
                        Console.WriteLine("┌─" + line + "─┐");
                        Console.WriteLine("│ " + item + " │");
                        Console.WriteLine("└─" + line + "─┘");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("  " + item + "  ");
                        Console.WriteLine("");
                    }
                    count++;
                }
                while (true)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey(true);
                    if (userInput.Key == ConsoleKey.UpArrow && userChoice != 0)
                    {
                        userChoice--;
                        break;
                    }
                    if (userInput.Key == ConsoleKey.DownArrow && userChoice != menu.Length - 1)
                    {
                        userChoice++;
                        break;
                    }
                    if (userInput.Key == ConsoleKey.UpArrow && userChoice == 0)
                    {
                        userChoice = menu.Length - 1;
                        break;
                    }
                    if (userInput.Key == ConsoleKey.DownArrow && userChoice == menu.Length - 1)
                    {
                        userChoice = 0;
                        break;
                    }
                    if (userInput.Key == ConsoleKey.Enter)
                    {
                        isEnterPressed = true;
                        break;
                    }
                }

            }
            return userChoice;
        }
    }
}
