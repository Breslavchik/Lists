using System;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            ArrayList list = new ArrayList(new int[] { 1, 2, 5 });
            
            Console.WriteLine(list.GetLength());
           // Console.WriteLine($"{ arr.ToArray()}") ;
            arr.AddFirst(list);
            Console.WriteLine($"{arr.ToArray()}");
            Console.ReadLine();
        }
    }
}
