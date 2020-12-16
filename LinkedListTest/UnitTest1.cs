using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDataStructure;
namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test case to search given value in linked list 
        /// </summary>
        [TestMethod]
        public void GivenValue_WhenValuePresentInList_ThenShouldPassTest()
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            int result = list.Search(30);
            Assert.AreEqual(30, result);            
        }

        /// <summary>
        /// Insert 40 after 30 in given list
        /// </summary>
        [TestMethod]
        public void GivenValue40_WhenSearch30InList_ThenShouldAdd40ToAfter30()
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InsertionAtPerticularPosition(40);
            int result = list.Search(40);
            Assert.AreEqual(40, result);

        }

        /// <summary>
        /// Given key value, delete that node and return count of list
        /// </summary>
        [TestMethod]
        public void GivenKeyValue_WhenPresentInLise_ThenShouldDeleteThetKeyAndReturnListCount()
        {
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(40);
            list.Add(30);
            list.Add(56);
            list.Display();
            list.deleteNode(40);
            int result = list.size();
            Assert.AreEqual(3, result);
        }

    }
}
