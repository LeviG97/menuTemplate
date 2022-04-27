using System;

namespace menuTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu
            string[] mainMenuOptions = { "Option1", "Option2", "Option3", "Exit" };
            Menu mainMenu = new Menu(mainMenuOptions);
            int choice = 0;

            do
            {
                choice = mainMenu.GetMenuChoice();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Frist option");
                        break;
                    case 2:
                        Console.WriteLine("Second option");
                        break;
                    case 3:
                        Console.WriteLine("Third option");
                        break;
                    case 4:
                        Console.WriteLine("Goodbye");
                        break;
                    default: break;
                }
            }
            while (choice != 4);
        }
    }
}
