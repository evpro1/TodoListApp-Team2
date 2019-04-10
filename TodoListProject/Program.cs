﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListProject.TodoApp;

namespace TodoListProject
{
    public class Program
    {
        public static TodoList TodoList { get; set; }

        static void Main(string[] args)
        {
            bool exit = false;
            TodoList = new TodoList();
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
            //ShowCurrentList();
            Console.WriteLine("\nMenu: ");
            Console.WriteLine("1. List all to do items");
            Console.WriteLine("2. Add new item");
            Console.WriteLine("3. Delete an item");
            Console.WriteLine("4. Mark an item as complete");
            Console.WriteLine("9. Quit");
            Console.WriteLine("\nEnter your choice: ");
        }

        public static int ReadInput()
        {
            int input;
            bool canParse = Int32.TryParse(Console.ReadLine(), out input);

            if (!canParse) input = 99; //if not a number, assign a default number which is invalid

            switch (input)
            {
                case 1:
                    Console.WriteLine("The items in the list are:");
                    TodoList.Print();
                    break;

                case 2:
                    Console.WriteLine("Enter text description for new item, default is 3 days due date");
                    string newText = Console.ReadLine();
                    TodoList.AddNewItem(newText);

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
