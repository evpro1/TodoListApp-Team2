using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoListProject.TodoApp;

namespace TodoListTestProject
{
    [TestClass]
    public class TodoListTest
    {
        [TestMethod]
        public void TestAddNewItem()
        {
            TodoList list = new TodoList();
            list.AddNewItem("Test1");

            bool found = false;
            foreach (TodoItem item in list.Items)
            {
                if (item.TextDesc.CompareTo("Test1") == 0)
                {
                    found = true;
                    break;
                }
            }

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestRetrieveItemList()
        {
        }

        [TestMethod]
        public void TestRemoveItem()
        {
            TodoList list = new TodoList();
            int id = list.AddNewItem("Test1", new DateTime(2019, 4, 11));

            bool found = false;
            foreach (TodoItem item in list.Items)
            {
                if (item.TextDesc.CompareTo("Test1") == 0 && item.DueDate == new DateTime(2019, 4, 11))
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                list.RemoveItem(id);

                TodoItem item = list.Items.Where(x => x.Id == id).FirstOrDefault();

                Assert.IsNull(item);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCompleteItem()
        {
        }

        [TestMethod]
        public void TestAddNewItemWithDueDate()
        {
            TodoList list = new TodoList();
            list.AddNewItem("Test1", new DateTime(2019,4,11));

            bool found = false;
            foreach (TodoItem item in list.Items)
            {
                if (item.TextDesc.CompareTo("Test1") == 0 && item.DueDate == new DateTime(2019, 4, 11))
                {
                    found = true;
                    break;
                }
            }

            Assert.IsTrue(found);
        }
    }
}
