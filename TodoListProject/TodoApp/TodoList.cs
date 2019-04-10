﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListProject.TodoApp
{
    public class TodoList
    {
        public List<TodoItem> Items { get; set; }
        private int runningId = 0;

        public void AddNewItem(string newTextDesc)
        {
            runningId++;
            Items.Add(new TodoItem(runningId, newTextDesc));
        }

        public void RemoveItem(int id)
        {
        }

        public void SetItemStatus(int id, bool isCompleted)
        {

        }

        public void Print()
        {
            if (Items.Count > 0)
            {
                foreach (TodoItem item in Items)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No item in to do list");
            }
        }
    }
}
