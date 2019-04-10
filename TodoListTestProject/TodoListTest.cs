using System;
using System.Collections.Generic;
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
            TodoList list = new TodoList();
            int id1 = list.AddNewItem("Test1", new DateTime(2019, 4, 11));
            int id2 = list.AddNewItem("Test2", new DateTime(2019, 4, 13));

            List<TodoItem> expected = new List<TodoItem>();
            expected.Add(new TodoItem(id1, "Test1", new DateTime(2019,4,11)));
            expected.Add(new TodoItem(id2, "Test2", new DateTime(2019,4,13)));

            CollectionAssert.AreEqual(expected, list.Items);
        }

        [TestMethod]
        public void TestRemoveItem()
        {
            TodoList list = new TodoList();
            int id = list.AddNewItem("Test1", new DateTime(2019, 4, 11));

            bool found = list.Items.Where(x => x.Id == id && x.DueDate == new DateTime(2019, 4, 11)).Count() > 0 ? true : false;

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
            TodoList list = new TodoList();
            int id = list.AddNewItem("Test1", new DateTime(2019, 4, 11));

            bool found = list.Items.Where(x => x.Id == id).Count() > 0 ? true : false;

            if (found)
            {
                list.SetItemStatus(id, true);

                TodoItem item = list.Items.Where(x => x.Id == id).FirstOrDefault();

                Assert.IsTrue(item.IsCompleted);
            }
        }

        [TestMethod]
        public void TestAddNewItemWithDueDate()
        {
            TodoList list = new TodoList();
            int id = list.AddNewItem("Test1", new DateTime(2019,4,11));

            bool found = list.Items.Where(x => x.Id == id && x.DueDate == new DateTime(2019, 4, 11)).Count() > 0 ? true : false;

            Assert.IsTrue(found);
        }
    }
}
