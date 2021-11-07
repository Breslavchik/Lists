using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class DoublyLinkedList
    {
        private DoublyLinkedNode _head;
        private DoublyLinkedNode _tail;
        public DoublyLinkedList()
        {
            _head = null;
            _tail = null;
        }
        public DoublyLinkedList(int value)
        {
            _head = new DoublyLinkedNode(value);
            _tail = _head;
        }
        public DoublyLinkedList(int[] array)
        {
            if (array.Length == 0)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _head = new DoublyLinkedNode(array[0]);
                _tail = _head;
                for (int i = 1; i < array.Length; i++)
                {
                    _tail.Next = new DoublyLinkedNode(array[i]);
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
                DoublyLinkedNode current = _head;
                length = 1;
                while (current.Next != null)
                {
                    current = current.Next;
                    length++;
                }
            }
            return length;
        }
        public int[] ToArray()
        {
            int length = GetLength();
            int[] array = new int[length];
            if (length == 0)
            {
                return array;
            }
            array[0] = _head.Value;
            DoublyLinkedNode current = _head;
            for (int i = 1; i < array.Length; i++)
            {
                current = current.Next;
                array[i] = current.Value;
            }
            return array;
        }
        public void PrintArray(DoublyLinkedList list)
        {
            int[] array = list.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        //AddFirst(int val) - добавление в начало списка
        public void AddFirst(int val)
        {
            if (_head == null && _tail == null)
            {
                _head = new DoublyLinkedNode(val);
                _tail = _head;
                return;
            }
            DoublyLinkedNode tmp = new DoublyLinkedNode(val);
            tmp.Next = _head;
            _head = tmp;
        }
        public void AddFirst(DoublyLinkedList list)
        {
            list._tail.Next = _head;
            _head = list._head;
        }
        public void AddLast(int val)
        {
            if (_head == null && _tail == null)
            {
                _head = new DoublyLinkedNode(val);
                _tail = _head;
            }
            else
            {
                _tail.Next = new DoublyLinkedNode(val);
                _tail = _tail.Next;
            }
        }
        public void AddLast(DoublyLinkedList list)
        {
            _tail.Next = list._head;
        }
        //AddAt(int idx, int val) - вставка по указанному индексу
        public void AddAt(int idx, int val)
        {
            int length = GetLength();
            if (idx > length)
            {
                throw new IndexOutOfRangeException("Такого индекса нет");
            }
            DoublyLinkedNode current = _head;
            if (idx == 0)
            {
                current = _head;
            }
            for (int i = 1; i < idx; i++)
            {
                current = current.Next;
            }
            DoublyLinkedNode tmp = new DoublyLinkedNode(val);
            tmp.Next = current.Next;
            current.Next = tmp;
        }
        public void AddAt(int idx, DoublyLinkedList list)
        {
            int length = GetLength();
            if (idx > length)
            {
                throw new IndexOutOfRangeException("Такого индекса нет");
            }
            DoublyLinkedNode current = _head;

            for (int i = 1; i < idx; i++)
            {
                current = current.Next;
            }
            list._tail.Next = current.Next;
            current.Next = list._head;
        }
        //Set(int idx, int val) - поменять значение элемента с указанным индексом
        public void Set(int idx, int val)
        {
            int length = GetLength();
            if (idx > length)
            {
                throw new IndexOutOfRangeException("Такого индекса нет");
            }
            DoublyLinkedNode current = _head;

            for (int i = 1; i <= idx; i++)
            {
                current = current.Next;
            }
            current.Value = val;
        }
        public void RemoveFirst()
        {
            _head = _head.Next;
        }
        public void RemoveLast()
        {
            DoublyLinkedNode current = _head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            _tail.Value = current.Value;
            current.Next = _tail.Next;
            _tail = current;
        }
        public void RemoveAt(int idx)
        {
            int length = GetLength();
            if (idx > length)
            {
                throw new IndexOutOfRangeException("Попробуйте другое число");
            }
            if (idx == 0)
            {
                RemoveFirst();
                return;
            }
            DoublyLinkedNode current = _head;

            for (int i = 1; i < idx; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;
        }
        //RemoveFirstMultiple(int n) - удаление первых n элементов
        public void RemoveFirstMultiple(int n)
        {

            int length = GetLength();
            if (n > length)
            {
                throw new Exception("Попробуйте другое число");
            }
            if (n == length)
            {
                _head = null;
                _tail = null;
                return;
            }
            DoublyLinkedNode current = _head;

            for (int i = 1; i < n; i++)
            {
                current = current.Next;
            }
            _head = current.Next;
        }
        //RemoveLastMultiple(int n) - удаление последних n элементов
        public void RemoveLastMultiple(int n)
        {
            int length = GetLength();
            if (n > length)
            {
                throw new Exception("Попробуйте другое число");
            }
            if (n == length)
            {
                _head = null;
                _tail = null;
                return;
            }
            DoublyLinkedNode current = _head;
            for (int i = 1; i < length - n; i++)
            {
                current = current.Next;
            }
            _tail.Value = current.Value;
            current.Next = _tail.Next;
            _tail = current;
        }
        //RemoveAtMultiple(int idx, int n) - удаление n элементов, начиная с указанного индекса
        public void RemoveAtMultiple(int idx, int n)
        {
            int length = GetLength();
            if (idx + n > length)
            {
                throw new Exception("Попробуйте другое число");
            }
            if (length - n == idx)
            {
                RemoveLastMultiple(n);
                return;
            }
            if (idx == 0)
            {
                RemoveFirstMultiple(n);
                return;
            }
            DoublyLinkedNode current = _head;
            for (int i = 1; i < idx; i++)
            {
                current = current.Next;
            }
            for (int i = 1; i <= n; i++)
            {
                current.Next = current.Next.Next;
            }

        }
        // RemoveFirst(int val) - удалить первый попавшийся элемент, значение которого равно val(вернуть индекс удалённого элемента)
        public int RemoveFirst(int val)
        {
            int index = -1;
            DoublyLinkedNode current = _head;
            if (_head.Value == val)
            {
                RemoveFirst();
                return index = 0;
            }
            else
            {
                int tmp = 0;
                while (current.Next != null)
                {
                    current = current.Next;
                    tmp += 1;
                    if (current.Value == val)
                    {
                        if (current == _tail)
                        {
                            RemoveLast();
                            index = tmp;
                            return index;
                        }
                        RemoveAt(tmp);
                        index = tmp;
                        return index;
                    }
                }
                return index;
            }
        }
        //RemoveAll(int val) - удалить все элементы, равные val(вернуть кол-во удалённых элементов)
        //переделать
        public int RemoveAll(int val)
        {
            int sum = 0;
            DoublyLinkedNode current = _head;

            while (current.Next != null)
            {
                if (_head.Value == val)
                {
                    RemoveFirst();
                    sum += 1;
                }
                if (current.Next.Value == val)
                {
                    current.Next = current.Next.Next;
                    sum += 1;
                }
                current = current.Next;
            }
            if (val == _tail.Value)
            {
                _tail.Value = current.Value;
                current.Next = _tail.Next;
                _tail = current;
                sum += 1;
            }
            return sum;
        }
        //Contains(int val) - проверка, есть ли элемент в списке
        public bool Contains(int val)
        {
            DoublyLinkedNode current = _head;
            if (_head.Value == val)
            {
                return true;
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                    if (current.Value == val)
                    {
                        return true;
                        break;
                    }
                }
                return false;
            }
        }
        //IndexOf(int val) - вернёт индекс первого найденного элемента, равного val (или -1,
        //если элементов с таким значением в списке нет)
        public int IndexOf(int val)
        {
            int index = -1;
            DoublyLinkedNode current = _head;
            if (_head.Value == val)
            {
                return index = 0;
            }
            else
            {
                int tmp = 0;
                while (current.Next != null)
                {
                    current = current.Next;
                    tmp += 1;
                    if (current.Value == val)
                    {
                        index = tmp;
                        return index;
                    }
                }
                return index;
            }
        }
        public int GetFirst()
        {
            return _head.Value;
        }
        public int GetLast()
        {
            return _tail.Value;
        }
        //Get(int idx) - вернёт значение элемента списка c указанным индексом
        public int Get(int idx)
        {
            int length = GetLength();
            if (idx > length)
            {
                throw new IndexOutOfRangeException("Попробуйте другое число");
            }
            if (idx == 0)
            {
                return _head.Value;
            }
            DoublyLinkedNode current = _head;

            for (int i = 1; i <= idx; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }
        //Reverse() - изменение порядка элементов списка на обратный
        public void Reverse()
        {
            DoublyLinkedNode current = _head;
            while (current.Next != null)
            {

                DoublyLinkedNode tmp = current.Next;
                current.Next = tmp.Next;
                tmp.Next = _head;
                _head = tmp;
            }
            _tail = current;
        }
        //Max() - поиск значения максимального элемента
        public int Max()
        {
            DoublyLinkedNode current = _head;
            int max = _head.Value;
            while (current.Next != null)
            {
                current = current.Next;
                if (max < current.Value)
                {
                    max = current.Value;
                }
            }
            return max;
        }
        public int Min()
        {
            DoublyLinkedNode current = _head;
            int min = _head.Value;
            while (current.Next != null)
            {
                current = current.Next;
                if (min > current.Value)
                {
                    min = current.Value;
                }
            }
            return min;
        }
        public int IndexOfMax()
        {
            DoublyLinkedNode current = _head;
            int max = _head.Value;
            int index = 0;
            int tmp = 0;
            while (current.Next != null)
            {
                current = current.Next;
                index += 1;
                if (max < current.Value)
                {
                    max = current.Value;
                    tmp = index;
                }
            }
            return tmp;
        }
        public int IndexOfMin()
        {
            DoublyLinkedNode current = _head;
            int min = _head.Value;
            int index = 0;
            int tmp = 0;
            while (current.Next != null)
            {
                current = current.Next;
                index += 1;
                if (min > current.Value)
                {
                    min = current.Value;
                    tmp = index;
                }
            }
            return tmp;
        }
        public void SwapVariables(ref int numberA, ref int numberB)
        {
            int temp = numberA;
            numberA = numberB;
            numberB = temp;
        }
        public void Sort()
        {
            int[] array = ToArray();
            int j = 0;
            for (int i = 1; i < array.Length; i++)
            {
                j = i;

                while ((j > 0) && (array[j] < array[j - 1]))
                {
                    SwapVariables(ref array[j - 1], ref array[j]);
                    j--;
                }
            }
            DoublyLinkedNode current = _head;
            _head.Value = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                current = current.Next;
                current.Value = array[i];
            }
            _tail = current;
        }


        public void SortDesc()
        {
            int[] array = ToArray();
            int j = 0;
            for (int i = 1; i < array.Length; i++)
            {
                j = i;

                while ((j > 0) && (array[j] > array[j - 1]))
                {
                    SwapVariables(ref array[j - 1], ref array[j]);
                    j--;
                }
            }

            DoublyLinkedNode current = _head;
            _head.Value = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                current = current.Next;
                current.Value = array[i];
            }
            _tail = current;
        }
    }
}

