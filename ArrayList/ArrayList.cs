using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class ArrayList
    {
        private int[] _array;
        public int Length { get; private set; }
        public ArrayList()
        {
            _array = new int[10];
            Length = 0;
        }

        public ArrayList(int value)
        {
            _array = new int[10];
            Length = 1;
            _array[0] = value;
        }

        public ArrayList(int[] array)
        {
            _array = new int[10];
            Length = array.Length;
            MakeLongerArray(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
        }

        public void MakeLongerArray(int newLength)
        {
            if (newLength <= _array.Length)
            {
                return;
            }
            int tmp = _array.Length;
            while (tmp < newLength)
            {
                tmp = 3 * tmp / 2;
            }
            int[] newArray = new int[tmp];
            for (int i = 0; i < newLength; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        public void MakeShorterArray(int newLength)
        {
            if (newLength == _array.Length)
            {
                return;
            }
            int tmp = _array.Length;
            while (tmp > newLength)
            {
                tmp = tmp / 3;
            }
            int[] newArray = new int[tmp];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        public int GetLength()
        {
            return Length;
        }

        public int[] ToArray()
        {
            int[] newArray = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                newArray[i] = _array[i];
            }
            return newArray;
        }
        
        public void PrintArray()
        {            
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]},"); 
            }
        }
        /*public override string ToString()
        {
            return string.Join(";", this.ToArray());
        }*/
        public void AddFirst(int val)
        {

            if (Length == _array.Length)
            {
                MakeLongerArray(1);
            }
            Length++;
            for (int i = Length - 1; i > 0; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[0] = val;         
        }

        public void AddLast(int val)
        {
            Length++;
            _array[Length-1] = val;           
        }
        //добавление в начало списка
        public void AddFirst(ArrayList list)
        {
            Length = Length + list.Length;
            if (Length == _array.Length)
            {
                MakeLongerArray(list.Length);
            }

            for (int i = 0; i < list.Length; i++)
            {
                _array[i + list.Length] = _array[i];
            }
            for (int i = 0; i < list.Length; i++)
            {
                _array[i] = list._array[i];
            }
        }
        
        public void AddLast(ArrayList list)
        {
            Length = Length + list.Length;
            if (Length == _array.Length)
            {
                MakeLongerArray(Length);
            }
            for (int i = Length-list.Length; i <Length; i++)
            {
                _array[i] = list._array[i-(Length-list.Length)];
            }
        }

        //AddAt(int idx, int val) - вставка по указанному индексу
        public void AddAt(int idx, int val)
        {
            Length++;
            if (Length == _array.Length)
            {
                MakeLongerArray(1);
            }
            
            if (idx >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = Length - 1; i > idx; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[idx] = val;
        }
        
        public void AddAt(int idx, ArrayList list)
        {
            Length = Length + list.Length;
            if (Length == _array.Length)
            {
                MakeLongerArray(Length);
            }
            for (int i = idx; i < Length-list.Length; i++)
            {
                _array[i + list.Length] = _array[i];
            }
            for (int i = idx; i < idx+list.Length; i++)
            {
                _array[i] = list._array[i - idx];
            }
        }
        //Set(int idx, int val) - поменять значение элемента с указанным индексом
        public void Set(int idx, int val)
        {
            if (idx>=Length)
            {
                throw new IndexOutOfRangeException();
            }
            _array[idx] = val;
        }
    }
}
