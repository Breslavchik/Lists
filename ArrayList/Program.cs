using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList arr = new ArrayList();
            // ArrayList temp2 = new ArrayList(new int[] { 1, 2, 5 });
            // ArrayList temp = new ArrayList(new int[] { 98, 23, 40 });

            // //Console.WriteLine(list.GetLength());
            // // Console.WriteLine($"{ arr.ToArray()}") ;
            //// arr.AddFirst(17);
            // arr.AddFirst(temp2);            
            // arr.PrintArray();
            // Console.WriteLine();
            // //вроде работает 

            // Console.WriteLine();
            // arr.AddFirst(temp2);
            // arr.PrintArray();
            // Console.WriteLine();
            // arr.AddLast(15);
            // arr.AddLast(18);
            // arr.PrintArray();
            // Console.WriteLine();
            // Console.WriteLine(arr.GetLength());

            //ArrayList temp2 = new ArrayList(new int[] { 1, 2, 3, 9 });
            //ArrayList temp = new ArrayList(new int[] { 1, 2, 3 });
            ////act
            //temp.AddFirst(temp2);

            //ArrayList temp2 = new ArrayList(new int[] { -10, 20, 50, 30, -8 });
            //ArrayList temp = new ArrayList(new int[] { 9, 1, 2, 3, 8, 9, 1 });
            //ArrayList temp3 = new ArrayList(new int[] { 3, 3, 3});
            ////act
            //// Console.WriteLine($"{temp.Sort()}"  );
            //temp3.PrintArray();
            //Console.WriteLine();
            //Console.WriteLine(temp3.GetLength());

            //Console.WriteLine($"{temp3.RemoveAll(3)}");
            //temp3.PrintArray();
            LinkedList list = new LinkedList(new int[] { 9, 1, 2, 3, 8, 9 });
            LinkedList list2 = new LinkedList(new int[] {  });
            //Console.WriteLine(list.GetLength());

            //list.RemoveAt(0);

            //list.AddFirst(7);

            // list.RemoveFirst(5);
            //list.PrintArray(list);
            Console.WriteLine();
            //Console.WriteLine($"{list.IndexOfMin()}");
            //int[] array=list.Sort();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //list.AddLast(77);
            list2.RemoveFirst();
            //list2.RemoveAll(3);
            //list2.AddLast(77);
            list2.PrintArray(list2);
            //ArrayList arlist = new ArrayList(new int[] { 1, 6, 8, 9, 11 });

        }
    }
}
