using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
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
            MakeLongerArray();
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
        }

        public void MakeLongerArray()
        {
            int newLength = Length;
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
        public void MakeShorterArray()
        {
            int newLength = _array.Length;
            if (newLength == _array.Length)
            {
                return;
            }
            while (newLength > 10 && newLength > Length)
            {
                if (newLength * 2 % 3 == 0)
                {
                    newLength = newLength * 2 / 3;
                }
                else
                {
                    newLength = newLength * 2 / 3 + 1;
                }

            }
            if (newLength < Length)
            {
                newLength = newLength * 3 / 2;
            }
           
            int[] newArray = new int[newLength];
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

            Length++;
            if (Length == _array.Length)
            {
                MakeLongerArray();
            }
            for (int i = Length - 1; i > 0; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[0] = val;
        }

        public void AddLast(int val)
        {
            Length++;
            if (Length == _array.Length)
            {
                MakeLongerArray();
            }
            _array[Length - 1] = val;
        }
        //добавление в начало списка
        public void AddFirst(ArrayList list)
        {
            Length = Length + list.Length;
            if (Length == _array.Length)
            {
                MakeLongerArray();
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
                MakeLongerArray();
            }
            for (int i = Length - list.Length; i < Length; i++)
            {
                _array[i] = list._array[i - (Length - list.Length)];
            }
        }

        //AddAt(int idx, int val) - вставка по указанному индексу
        public void AddAt(int idx, int val)
        {
            if (idx >= Length)
            {
                throw new IndexOutOfRangeException("Такого индекса нет");
            }
            Length++;
            if (Length == _array.Length)
            {
                MakeLongerArray();
            }
            for (int i = Length - 1; i > idx; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[idx] = val;
        }

        public void AddAt(int idx, ArrayList list)
        {
            if (idx >= Length)
            {
                throw new IndexOutOfRangeException("Такого индекса нет");
            }
            Length = Length + list.Length;
            if (Length == _array.Length)
            {
                MakeLongerArray();
            }
            
            for (int i = idx; i < Length - list.Length; i++)
            {
                _array[i + list.Length] = _array[i];
            }
            for (int i = idx; i < idx + list.Length; i++)
            {
                _array[i] = list._array[i - idx];
            }
        }
        //Set(int idx, int val) - поменять значение элемента с указанным индексом
        public void Set(int idx, int val)
        {
            if (idx >= Length)
            {
                throw new IndexOutOfRangeException("Такого индекса нет");
            }
            _array[idx] = val;
        }
        public void RemoveFirst()
        {
            for (int i = 0; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
            MakeShorterArray();
        }
        public void RemoveLast()
        {
            Length--;
           MakeShorterArray();
        }
        //RemoveAt(int idx) - удаление по индексу

        public void RemoveAt(int idx)
        {
            if (idx >= Length)
            {
                throw new IndexOutOfRangeException("Такого индекса нет");
            }
            for (int i = idx; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
            MakeShorterArray();
        }
        //RemoveFirstMultiple(int n) - удаление первых n элементов
        public void RemoveFirstMultiple(int n)
        {
            if (n > Length)
            {
                throw new Exception("Слишком большое число");
            }
            for (int i = n; i < Length; i++)
            {
                _array[i - n] = _array[i];
            }
            Length -= n;          
            MakeShorterArray();
        }
        //RemoveLastMultiple(int n) - удаление последних n элементов
        public void RemoveLastMultiple(int n)
        {
            if (n > Length)
            {
                throw new Exception("Слишком большое число");
            }
            Length -= n;
            MakeShorterArray();
        }
        //RemoveAtMultiple(int idx, int n) - удаление n элементов, начиная с указанного индекса
        //доделать
        public void RemoveAtMultiple(int idx, int n)
        {
            if (idx >= Length || idx + n > Length)
            {
                throw new IndexOutOfRangeException("Такого индекса нет");
            }
            for (int i = idx; i <Length ; i++)
            {
                _array[i] = _array[i+n];
            }
            Length -= n;
            MakeShorterArray();
        }
        //RemoveFirst(int val) - удалить первый попавшийся элемент, 
        //значение которого равно val(вернуть индекс удалённого элемента)
        public int RemoveFirst(int val)
        {
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == val)
                {
                    RemoveAt(i);
                    index = i;
                    break;
                }
            }
            Length--;
            MakeShorterArray();
            return index;
            
        }
        //RemoveAll(int val) - удалить все элементы, равные val (вернуть кол-во удалённых элементов)
        public int RemoveAll(int val)
        {
            int sum = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == val)
                {
                    _array[i] = _array[i + 1];
                    sum++;
                }
            }
            Length -= sum;
            MakeShorterArray();
            return sum;
        }
        //Contains(int val) - проверка, есть ли элемент в списке
        public bool Contains(int val)
        {            
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == val)
                {                    
                    return true;
                    break;
                }
            }            
            return false;
        }
        //IndexOf(int val) - вернёт индекс первого найденного элемента, равного val
        //(или -1, если элементов с таким значением в списке нет)
        public int IndexOf(int val)
        {
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == val)
                {                    
                    return i;
                    break;
                }
            }
            return index;
        }
        //GetFirst() - вернёт значение первого элемента списка
        public int GetFirst()
        {
            return _array[0];
        }
        //GetLast() - вернёт значение последнего элемента списка
        public int GetLast()
        {
            return _array[Length-1];
        }
        //Get(int idx) - вернёт значение элемента списка c указанным индексом
        public int Get(int idx)
        {
            if (idx >= Length)
            {
                throw new IndexOutOfRangeException("Нет такого индекса, увы");
            }
            return _array[idx];
        }        
        public void SwapVariables(ref int numberA, ref int numberB)
        {
            int temp = numberA;
            numberA = numberB;
            numberB = temp;
        }
        //Reverse() - изменение порядка элементов списка на обратный
        public void Reverse()
        {
            int half = Length / 2;
            for (int index = 0; index < half; index++)
            {
               SwapVariables(ref _array[index], ref _array[Length - 1 - index]);
            }
        }
        //Max() - поиск значения максимального элемента
        public int Max()
        {
            int max = _array[0];
            for (int index = 0; index < Length; index++)
            {
                if (_array[index] > max)
                {
                    max = _array[index];
                }
            }
            return max;
        }
        //Min() - поиск значения минимального элемента
        public int Min()
        {
            int min = _array[0];
            for (int index = 0; index < Length; index++)
            {
                if (_array[index] < min)
                {
                    min = _array[index];
                }
            }
            return min;
        }
        //IndexOfMax() - поиск индекс максимального элемента
        public int IndexOfMax()
        {
            int max = _array[0];
            int temp = 0;
            for (int index = 0; index < Length; index++)
            {
                if (_array[index] > max)
                {
                    max = _array[index];
                    temp = index;
                }
            }
            return temp;
        }
        public int IndexOfMin()
        {
            int min = _array[0];
            int temp = 0;
            for (int index = 0; index < Length; index++)
            {
                if (_array[index] < min)
                {
                    min = _array[index];
                    temp = index;
                }
            }
            return temp;
        }
        public void Sort()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[i] > _array[j])
                    {
                       SwapVariables(ref _array[j], ref _array[i]);
                    }
                }
            }
        }
        public void SortDesc()
        {
            for (int i = 0; i < Length; i++)
            {
                int temp = i;
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[j] > _array[temp])
                    {
                        temp = j;
                    }
                }
                SwapVariables(ref _array[temp], ref _array[i]);
            }
        }
    }

}
