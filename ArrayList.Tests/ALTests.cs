using NUnit.Framework;

namespace ArrayList.Tests
{
    public class ALTests
    {
        private ArrayList _arraylist;
        [SetUp]
        public void Setup()
        {
            _arraylist = new ArrayList();
        }



        //[TestCase(new int[] {1,2,3,4,5}, 5)]
        //public void GetLength(int[]array, int Length)
        //{
        //    //arange
        //    //act

        //    //assert


        //}
        [Test]
        public void GetLengthTest()
        {
            //arrange           
            ArrayList temp = new ArrayList(new int[] { 1, 2, 3 });
            int exception = 3;
            //act            
            int actual = temp.GetLength();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [Test]
        public void AddFirstTest()
        {
            //arrange
            ArrayList temp2 = new ArrayList(new int[] { 9, 1, 2, 3 });
            ArrayList temp = new ArrayList(new int[] { 1, 2, 3 });
            //act
            temp.AddFirst(9);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }

        [Test]
        public void AddLastTest()
        {
            //arrange
            ArrayList temp2= new ArrayList(new int[] { 1, 2, 3, 9 });
            ArrayList temp = new ArrayList(new int[] { 1, 2, 3 });
            //act
            temp.AddLast(9);
            int[] exception=temp2.ToArray();
            int[] actual=temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [Test]
        public void AddFirstTest2()
        {
            //arrange
            ArrayList temp2 = new ArrayList(new int[] { 11, 20, 3, 1, 2, 3 });
            ArrayList temp = new ArrayList(new int[] { 1, 2, 3 });
            ArrayList temp3 = new ArrayList(new int[] { 11, 20, 3 });
            //act
            temp.AddFirst(temp3);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }

        [Test]
        public void AddLastTest2()
        {
            //arrange
            ArrayList temp2 = new ArrayList(new int[] { 1, 2, 3, 11, 20, 3 });
            ArrayList temp = new ArrayList(new int[] { 1, 2, 3 });
            ArrayList temp3 = new ArrayList(new int[] { 11, 20, 3 });
            //act
            temp.AddLast(temp3);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
       
        [Test]
        public void AddAtTest()
        {
            //arrange
            ArrayList temp2 = new ArrayList(new int[] { 1, 2, 5, 3, 9 });
            ArrayList temp = new ArrayList(new int[] { 1, 2, 3, 9 });
            //act
            temp.AddAt(2, 5);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
        [Test]
        public void AddAtTest2()
        {
            //arrange
            ArrayList temp2 = new ArrayList(new int[] { 1, 2, 11, 20, 3, 3, 9 });
            ArrayList temp = new ArrayList(new int[] { 1, 2, 3, 9 });
            ArrayList temp3 = new ArrayList(new int[] { 11, 20, 3 });
            //act
            temp.AddAt(2, temp3);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }

        [Test]
        public void Set()
        {
            //arrange
            ArrayList temp2 = new ArrayList(new int[] { 1, 77, 3, 9 });
            ArrayList temp = new ArrayList(new int[] { 1, 2, 3, 9 });
            //act
            temp.Set(1, 77);
            int[] exception = temp2.ToArray();
            int[] actual = temp.ToArray();
            //assert
            Assert.AreEqual(exception, actual);
        }
    }
}