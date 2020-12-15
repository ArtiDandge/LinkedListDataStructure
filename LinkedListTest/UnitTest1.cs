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
        public void GivenValue_WhenValuePresentInList_ShouldPassTest()
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Node result = list.Search(30);
            Assert.AreEqual(30, result.data);            
        }

        public void GivenValue40_WhenSearch30InList_ThenAdd40ToAfter30()
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Node result = list.Search(30);
            list.InsertionAtPerticulatPosition(3, 40); 

        }
    }
}
