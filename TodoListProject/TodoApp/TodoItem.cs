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
        public DateTime DueDate { get; set; }

        public TodoItem(int newId, string newTextDesc, DateTime newDueDate)
        {
            Id = newId;
            TextDesc = newTextDesc;
            IsCompleted = false;
            DueDate = newDueDate;
        }

        public override bool Equals(object obj)
        {
            TodoItem other = (TodoItem)obj;

            return this.TextDesc.Equals(other.TextDesc);
        }
        public override string ToString()
        {
            return "Item:"+ Id +") "+TextDesc+" - Is completed: "+ IsCompleted;
        }
    }
}
