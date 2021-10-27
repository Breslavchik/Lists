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



        [TestCase(new int[] {1,2,3,4,5}, 5)]
        public void GetLength(int[]array, int Length)
        {
            //arange
            //act

            //assert


        }
    }
}