using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class LinkedList
    {
        private Node _head;
        private Node _tail;
        public LinkedList()
        {
            _head = null;
            _tail = null;
        }
        public LinkedList(int value)
        {
            _head = new Node(value);
            _tail = _head;
        }
        public LinkedList(int[] array)
        {
            if (array.Length == 0)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _head = new Node(array[0]);
                _tail = _head;
                for (int i = 1; i < array.Length; i++)
                {
                    _tail.Next = new Node(array[i]);
                    _tail = _tail.Next;
                }
            }
        }
        public int GetLength()
        {
            int length = 0;
            if (_head == null && _tail == null)
            {
                return length;
            }
            else
            {
                Node current = _head;
                length = 1;
                while (current.Next != null)
                {
                    current = current.Next;
                    length++;
                }
            }
            return length;

        }
        //public int this[int index]
        //{
        //    get
        //    {
        //        Node current = _head;
        //        for (int i = 1; i < index; i++)
        //        {
        //            current = current.Next;
        //        }
        //        return current.Value;
        //    }
        //    set
        //    {
        //        Node current = _head;
        //        for (int i = 1; i < index; i++)
        //        {
        //            current = current.Next;
        //        }
        //        current.Value = value;
        //    }
        //}
        public int[] ToArray()
        {
            int length = GetLength();
            int[] array = new int[length];
            array[0] = _head.Value;
            Node current = _head;
            for (int i = 1; i < array.Length; i++)
            {
                current = current.Next;
                array[i] = current.Value;
            }
            return array;
        }
        public void PrintArray(LinkedList list)
        {
            int [] array =list.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        //AddFirst(int val) - добавление в начало списка
       public void AddFirst(int val)
        {
            _head.Next = _head;
            _head = new Node(val);
            _head.Next = _head.Next;
        }
        public void AddLast(int val)
        {
            if (_head == null && _tail == null)
            {
                _head = new Node(val);
                _tail = _head;
            }
            else
            {
                _tail.Next = new Node(val);
                _tail = _tail.Next;
            }
        }
    }
}
