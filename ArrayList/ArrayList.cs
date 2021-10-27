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
            Length = 0;
            MakeLongerArray(array.Length);
            for (int i = 0; i < Length; i++)
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
           // return _array;
        }

        public void AddLast(int val)
        {
            if (Length == _array.Length)
            {
                MakeLongerArray(1);
            }
            _array[Length] = val;
            Length++;           
        }
              
        public void AddFirst(ArrayList list)
        {
            if (Length == _array.Length)
            {
                MakeLongerArray(list.Length);
            }
            Length = Length + list.Length;
            for (int i = 0; i < Length; i++)
            {
                _array[i + list.Length] = _array[i];
            }
            for (int i = 0; i < list.Length; i++)
            {
                _array[i] = list._array[i];
            }
            //return _array;
        }
        public void AddLast(ArrayList list)
        {
            if (Length == _array.Length)
            {
                MakeLongerArray(list.Length);
            }
            Length = Length + list.Length;
            for (int i = list.Length-1; i < Length; i++)
            {
                _array[i + list.Length] = list._array[i];
            }           
        }

        public void AddAt(int idx, int val)
        {
            if (Length == _array.Length)
            {
                MakeLongerArray(1);
            }
            Length++;
            if (idx > Length)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = idx; i<Length; i++)
            {
                _array[i+1] = _array[i];
            }
            _array[idx] = val;
            //return _array;
        }
        public void Set(int idx, int val)
        {
            _array[idx] = val;
        }
        
        public void RemoveFirst()
        {
            for (int i=Length; i>0; i--)
            {
                _array[i + 1] = _array[i];
            }

        }
        public void RemoveLast()
        {
            Length--;
            if (Length <= (_array.Length / 2))
            {
                MakeShorterArray(1);
            }
        }

    }
}
