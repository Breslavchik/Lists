using NUnit.Framework;
using Lists;

namespace DoublyLinkedListTests
{
    public class DLLTests
    {
        private DoublyLinkedList _doublylinkedlist;
        [SetUp]
        public void Setup()
        {
            _doublylinkedlist = new DoublyLinkedList();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}