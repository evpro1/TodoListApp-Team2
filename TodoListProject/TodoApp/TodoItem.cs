using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListProject.TodoApp
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string TextDesc { get; set; }
        public bool IsCompleted { get; set; }

        public TodoItem(int newId, string newTextDesc)
        {
            Id = newId;
            TextDesc = newTextDesc;
            IsCompleted = false;
        }
    }
}
