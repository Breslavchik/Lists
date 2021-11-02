using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Lists;

namespace ListTests
{
    public class LLTests
    {
        private LinkedList _linkedlist;
       
        [SetUp]
        public void Setup()
        {
            _linkedlist = new LinkedList();
        }
       
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { }, 0)]
        public void GetLengthTest(int[] array, int exception)
        {
            //arrange           
            LinkedList temp = new LinkedList(array);
            //act            
            int actual = temp.GetLength();
            //assert
            Assert.AreEqual(exception, actual);
        }
    }
}
