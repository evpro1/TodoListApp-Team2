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

        public void AddNewItem()
        {
            
        }

        public void SetItemStatus(int id, bool isCompleted)
        {

        }
    }
}
