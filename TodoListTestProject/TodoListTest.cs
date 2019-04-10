using System;
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
