using System;
using System.Collections.Generic;
using System.Text;

namespace menuTemplate
{
    class Menu
    {
        string[] menu;
        int choice;

        public Menu(string[] options)
        {
            menu = options;
        }

        public int GetMenuChoice()
        {
            int menuChoice = 0;
            do
            {
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{menu[i]}");
                }
                Console.WriteLine("Enter Choice");

                while (!int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    Console.WriteLine("Please Enter a valid number: ");
                }

                if (menuChoice > menu.Length || menuChoice < 1)
                {
                    Console.WriteLine("Please Enter a Valid Choice: ");
                }
            }
            while (menuChoice > menu.Length || menuChoice < 1);

            return menuChoice;
        }
    }
}
