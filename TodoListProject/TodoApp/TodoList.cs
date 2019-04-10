using System;
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

        public TodoList()
        {
            Items = new List<TodoItem>();
        }

        public void AddNewItem(string newTextDesc)
        {
            DateTime newDueDate = DateTime.Today.AddDays(3);
            AddNewItem(newTextDesc, newDueDate);
        }

        public void AddNewItem(string newTextDesc, DateTime newDueDate)
        {
            runningId++;
            Items.Add(new TodoItem(runningId, newTextDesc, newDueDate));
        }

        public void RemoveItem(int id)
        {
            TodoItem tempItem = Items.Where(item => item.Id == id).FirstOrDefault();

            if(tempItem!=null)
            {
                Items.Remove(tempItem);
            }
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
