using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                ShowMenu();
                int input = ReadInput();
                if (input == 9) exit = true;
            } while (!exit);
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Welcome to To Do List Application!!!!");
            ShowCurrentList();
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. List all to do list");
            Console.WriteLine("2. Add new item");
            Console.WriteLine("3. Delete an item");
            Console.WriteLine("4. Mark an item as complete");
            Console.WriteLine("9. Quit");
            Console.WriteLine("Enter your choice: ");
        }

        public static int ReadInput()
        {
            int input;
            bool canParse = Int32.TryParse(Console.ReadLine(), out input);

            if (!canParse) input = 99; //if not a number, assign a default number which is invalid

            switch (input)
            {
                case 1:
                    Console.WriteLine("1");
                    break;

                case 2:
                    Console.WriteLine("2");
                    break;

                case 3:
                    Console.WriteLine("3");
                    break;

                case 9:

                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            return input;
        }

        public static void ShowCurrentList()
        {
            List<String> list = new List<String>();
            list.Add("Fix bug no 1");
            list.Add("Fix bug no 2");
            list.Add("Fix bug no 3");

            foreach (String s in list)
            {
                Console.WriteLine(s);
            }

        }
    }
}
