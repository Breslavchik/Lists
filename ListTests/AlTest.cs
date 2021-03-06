using NUnit.Framework;
using Lists;

namespace ListTests
{
   
        public class ALTests
        {
            private ArrayList _arraylist;
            [SetUp]
            public void Setup()
            {
                _arraylist = new ArrayList();
            }

            [TestCase(new int[] { 1, 2, 3 }, 3)]
            [TestCase(new int[] { }, 0)]
            public void GetLengthTest(int[] array, int exception)
            {
                //arrange           
                ArrayList temp = new ArrayList(array);
                //act            
                int actual = temp.GetLength();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 9, 1, 2, 3 }, new int[] { 1, 2, 3 }, 9)]
            [TestCase(new int[] { 0 }, new int[] { }, 0)]
            public void AddFirstTest(int[] array, int[] array2, int value)
            {
                //arrange
                ArrayList temp2 = new ArrayList(array);
                ArrayList temp = new ArrayList(array2);
                //act
                temp.AddFirst(value);
                int[] exception = temp2.ToArray();
                int[] actual = temp.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }

            [TestCase(new int[] { 1, 2, 3, 9 }, new int[] { 1, 2, 3 }, 9)]
            [TestCase(new int[] { 0 }, new int[] { }, 0)]
            public void AddLastTest(int[] array, int[] array2, int value)
            {
                //arrange
                ArrayList temp2 = new ArrayList(array);
                ArrayList temp = new ArrayList(array2);
                //act
                temp.AddLast(value);
                int[] exception = temp2.ToArray();
                int[] actual = temp.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 11, 20, 3, 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 11, 20, 3 })]
            public void AddFirstTest2(int[] array, int[] array2, int[] array3)
            {
                //arrange
                ArrayList temp2 = new ArrayList(array);
                ArrayList temp = new ArrayList(array2);
                ArrayList temp3 = new ArrayList(array3);
                //act
                temp.AddFirst(temp3);
                int[] exception = temp2.ToArray();
                int[] actual = temp.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }

            [TestCase(new int[] { 1, 2, 3, 11, 20, 3 }, new int[] { 1, 2, 3 }, new int[] { 11, 20, 3 })]
            public void AddLastTest2(int[] array, int[] array2, int[] array3)
            {
                //arrange
                ArrayList temp2 = new ArrayList(array);
                ArrayList temp = new ArrayList(array2);
                ArrayList temp3 = new ArrayList(array3);
                //act
                temp.AddLast(temp3);
                int[] exception = temp2.ToArray();
                int[] actual = temp.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }

            [TestCase(new int[] { 1, 2, 5, 3, 9 }, new int[] { 1, 2, 3, 9 }, 2, 5)]
            public void AddAtTest(int[] array, int[] array2, int index, int value)
            {
                //arrange
                ArrayList temp2 = new ArrayList(array);
                ArrayList temp = new ArrayList(array2);
                //act
                temp.AddAt(index, value);
                int[] exception = temp2.ToArray();
                int[] actual = temp.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 1, 77, 3, 9 }, 11, 11)]
            public void AddAtNegativeTest(int[] array, int index, int value)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                //act, assert
                Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.AddAt(index, value));
            }
            [TestCase(new int[] { 1, 2, 11, 20, 3, 3, 9 }, new int[] { 1, 2, 3, 9 }, new int[] { 11, 20, 3 }, 2)]
            public void AddAtTest2(int[] array, int[] array2, int[] array3, int index)
            {
                //arrange
                ArrayList temp2 = new ArrayList(array);
                ArrayList temp = new ArrayList(array2);
                ArrayList temp3 = new ArrayList(array3);
                //act
                temp.AddAt(index, temp3);
                int[] exception = temp2.ToArray();
                int[] actual = temp.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 1, 2, 3, 9 }, new int[] { 11, 20, 3 }, 5)]
            public void AddAtNegativeTest2(int[] array, int[] array2, int index)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                ArrayList temp2 = new ArrayList(array2);
                //act, assert
                Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.AddAt(index, temp2));
            }


            [TestCase(new int[] { 1, 77, 3, 9 }, new int[] { 1, 2, 3, 9 }, 1, 77)]
            public void SetTest(int[] array, int[] array2, int index, int value)
            {
                //arrange
                ArrayList temp2 = new ArrayList(array);
                ArrayList temp = new ArrayList(array2);
                //act
                temp.Set(index, value);
                int[] exception = temp2.ToArray();
                int[] actual = temp.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 1, 77, 3, 9 }, 11, 11)]
            public void SetNegativeTest(int[] array, int index, int value)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                //act, assert
                Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.Set(index, value));
            }

            [TestCase(new int[] { 9, 1, 2, 3 }, new int[] { 1, 2, 3 })]
            public void RemoveFirstTest(int[] array, int[] array2)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                ArrayList temp2 = new ArrayList(array2);
                //act
                temp.RemoveFirst();
                int[] exception = temp.ToArray();
                int[] actual = temp2.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 9, 1, 2, 3 }, new int[] { 9, 1, 2 })]
            public void RemoveLastTest(int[] array, int[] array2)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                ArrayList temp2 = new ArrayList(array2);
                //act
                temp.RemoveLast();
                int[] exception = temp.ToArray();
                int[] actual = temp2.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 9, 1, 2, 8, 9 }, new int[] { 9, 1, 2, 3, 8, 9 }, 3)]
            public void RemoveAtTest(int[] array, int[] array2, int idx)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                ArrayList temp2 = new ArrayList(array2);
                //act
                temp2.RemoveAt(3);
                int[] exception = temp.ToArray();
                int[] actual = temp2.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 1, 77, 3, 9 }, 11)]
            public void RemoveAtNegativeTest(int[] array, int index)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                //act, assert
                Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.RemoveAt(index));
            }
            [TestCase(new int[] { 3, 8, 9 }, new int[] { 9, 1, 2, 3, 8, 9 }, 3)]
            [TestCase(new int[] { }, new int[] { 9, 1, 2, 3, 8, 9 }, 6)]
            public void RemoveFirstMultipleTest(int[] array, int[] array2, int n)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                ArrayList temp2 = new ArrayList(array2);
                //act
                temp2.RemoveFirstMultiple(n);
                int[] exception = temp.ToArray();
                int[] actual = temp2.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 1, 77, 3, 9 }, 5)]
            public void RemoveFirstMultipleNegativeTest(int[] array, int n)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                //act, assert
                Assert.Throws(typeof(System.Exception), () => temp.RemoveFirstMultiple(n));
            }
            [TestCase(new int[] { 9, 1, 2 }, new int[] { 9, 1, 2, 3, 8, 9 }, 3)]
            [TestCase(new int[] { }, new int[] { 9, 1, 2, 3, 8, 9 }, 6)]
            public void RemoveLastMultipleTest(int[] array, int[] array2, int n)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                ArrayList temp2 = new ArrayList(array2);
                //act
                temp2.RemoveLastMultiple(n);
                int[] exception = temp.ToArray();
                int[] actual = temp2.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 1, 77, 3, 9 }, 5)]
            public void RemoveLastMultipleNegativeTest(int[] array, int n)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                //act, assert
                Assert.Throws(typeof(System.Exception), () => temp.RemoveLastMultiple(n));
            }
            [TestCase(new int[] { 1, 9 }, new int[] { 1, 2, 3, 9 }, 1, 2)]
            public void RemoveAtMultipleTest(int[] array, int[] array2, int index, int value)
            {
                //arrange
                ArrayList temp2 = new ArrayList(array);
                ArrayList temp = new ArrayList(array2);
                //act
                temp.RemoveAtMultiple(index, value);
                int[] exception = temp2.ToArray();
                int[] actual = temp.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 1, 77, 3, 9 }, 5, 2)]
            [TestCase(new int[] { 1, 77, 3, 9 }, 1, 4)]
            public void RemoveAtMultipleNegativeTest(int[] array, int index, int n)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                //act, assert
                Assert.Throws(typeof(System.IndexOutOfRangeException), () => temp.RemoveAtMultiple(index, n));
            }
            [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 3, 3)]
            [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 5, -1)]
            public void RemoveFirstTest2(int[] array, int val, int exception)
            {
                //arrange

                ArrayList temp = new ArrayList(array);
                //act                      
                int actual = temp.RemoveFirst(val);
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 9, 2)]
            [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 5, 0)]
            [TestCase(new int[] { 3, 3, 3 }, 3, 3)]
            public void RemoveAllTest(int[] array, int val, int exception)
            {
                //arrange

                ArrayList temp = new ArrayList(array);
                //act                      
                int actual = temp.RemoveAll(val);
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 9, true)]
            [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 5, false)]
            public void ContainsTest(int[] array, int val, bool exception)
            {
                //arrange

                ArrayList temp = new ArrayList(array);
                //act                      
                bool actual = temp.Contains(val);
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 9, 0)]
            [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 5, -1)]
            public void IndexOfTest(int[] array, int val, int exception)
            {
                //arrange

                ArrayList temp = new ArrayList(array);
                //act                      
                int actual = temp.IndexOf(val);
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 0, 4, 1, 2, 3 }, 0)]
            [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 9)]
            public void GetFirstTest(int[] array, int exception)
            {
                //arrange           
                ArrayList temp = new ArrayList(array);
                //act            
                int actual = temp.GetFirst();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 0, 4, 1, 2, 3 }, 3)]
            [TestCase(new int[] { 9, 1, 2, 3, 8, 9 }, 9)]
            public void GetLastTest(int[] array, int exception)
            {
                //arrange           
                ArrayList temp = new ArrayList(array);
                //act            
                int actual = temp.GetLast();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 9, 8, 3, 2, 1, 9 }, new int[] { 9, 1, 2, 3, 8, 9 })]
            public void ReverseTest(int[] array, int[] array2)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                ArrayList temp2 = new ArrayList(array2);
                //act
                temp2.Reverse();
                int[] exception = temp.ToArray();
                int[] actual = temp2.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 0, 4, 1, 2, 3 }, 4)]
            [TestCase(new int[] { 9, 1, 2, 3, 8, 9, 11 }, 11)]
            public void MaxTest(int[] array, int exception)
            {
                //arrange           
                ArrayList temp = new ArrayList(array);
                //act            
                int actual = temp.Max();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 0, 4, 1, 2, 3 }, 0)]
            [TestCase(new int[] { 9, 1, 2, 3, 8, 9, 11 }, 1)]
            public void MinTest(int[] array, int exception)
            {
                //arrange           
                ArrayList temp = new ArrayList(array);
                //act            
                int actual = temp.Min();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 0, 4, 1, 2, 3 }, 1)]
            [TestCase(new int[] { 9, 1, 2, 3, 8, 9, 11 }, 6)]
            public void IndexOfMaxTest(int[] array, int exception)
            {
                //arrange           
                ArrayList temp = new ArrayList(array);
                //act            
                int actual = temp.IndexOfMax();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 0, 4, 1, 2, 3 }, 0)]
            [TestCase(new int[] { 9, 1, -5, 2, 3, 8, 9, 11 }, 2)]
            public void IndexOfMinTest(int[] array, int exception)
            {
                //arrange           
                ArrayList temp = new ArrayList(array);
                //act            
                int actual = temp.IndexOfMin();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 1, 2, 3, 8, 9, 9 }, new int[] { 9, 1, 2, 3, 8, 9 })]
            public void SortTest(int[] array, int[] array2)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                ArrayList temp2 = new ArrayList(array2);
                //act
                temp2.Sort();
                int[] exception = temp.ToArray();
                int[] actual = temp2.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }
            [TestCase(new int[] { 9, 9, 8, 3, 2, 1 }, new int[] { 9, 1, 2, 3, 8, 9 })]
            public void SortDescTest(int[] array, int[] array2)
            {
                //arrange
                ArrayList temp = new ArrayList(array);
                ArrayList temp2 = new ArrayList(array2);
                //act
                temp2.SortDesc();
                int[] exception = temp.ToArray();
                int[] actual = temp2.ToArray();
                //assert
                Assert.AreEqual(exception, actual);
            }

        }
    
}