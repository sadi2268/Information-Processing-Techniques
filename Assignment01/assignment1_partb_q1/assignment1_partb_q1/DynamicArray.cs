using System;
using System.Collections;
using System.Collections.Generic;

namespace assignment1_partb_q1
{
    /*
     *Following class is the net result of Part B ques 1 AND 2. 
     * 
     * Part B Ques 1 required us to change the DynamicIntArray to DynamicArray. This involves just 
     * changing the 'int' datatype to 'T' among other small changes.
     * 
     * Part B Ques 2 was the REAL CHALLENGE as it involved exploring/implementing different functions
     * of the IList<T> interface.
     * 
     */
    class DynamicArray<T> : IList<T>
    {
        public int size;
        public int capacity;
        public T[] dy_arr;

        public DynamicArray()
        {
            capacity = 10;
            dy_arr = new T[capacity];
            size = 0;
        }

        public DynamicArray(int cap)
        {
            capacity = cap;
            dy_arr = new T[capacity];
            size = 0;
        }

        //lambda expression used => for anonymous functions
        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public int Count = size; //size has to be static for this to work. Which is not what we desire.
        public int Count { get => size; }

        public bool IsReadOnly => false;

        public void Add(T element)
        {
            if (size < capacity - 5)
            {
                dy_arr[size] = element;
                size++;
            }
            else
            {
                //Console.WriteLine("Resizing!");
                Array.Resize(ref dy_arr, capacity * 2);
                capacity = capacity * 2;
                dy_arr[size] = element;
                size++;
            }
        }

        public void Clear()
        {
            //Using Array.Clear Method (Array, Int32, Int32) : Sets a range of elements in an array to the default value of each element type.
            //Trivially we could also traverse through the array and make every value to 0.
            Array.Clear(dy_arr, 0, size);
            size = 0;
        }

        public bool Contains(T item)
        {
            int index = Array.IndexOf(dy_arr, item);
            if (index == -1)
                return false;
            else
                return true;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int newIndex = 0; arrayIndex < size; arrayIndex++)
            {
                array[newIndex] = dy_arr[arrayIndex];
                newIndex++;
            }
        }

        public T Get(int index)
        {
            if (index < size)
            {
                return dy_arr[index];
            }
            else
                //Since the return type is T, we have to cast -1 to T.
                return (T)Convert.ChangeType(-1, typeof(T));
        }

        public IEnumerator<T> GetEnumerator()
        {
            int iterator = 0;
            while (iterator < size)
            {
                /*
                 * Using yield to define an iterator removes the need for an explicit extra 
                 * class (the class that holds the state for an enumeration) when you implement
                 * the IEnumerable and IEnumerator pattern for a custom collection type. 
                 * 
                 * Each iteration of the foreach loop calls the iterator method. When a 
                 * yield return statement is reached in the iterator method, expression is returned,
                 * and the current location in code is retained. Execution is restarted from that
                 * location the next time that the iterator function is called.
                 */
                yield return dy_arr[iterator++];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T element)
        {
            int index = Array.IndexOf(dy_arr, element);
            return index;
        }

        public void Insert(int index, T item)
        {
            int iterator = size;
            //Push every element before the index 1 block to its right to make room for the insertion
            while (iterator > index)
            {
                dy_arr[iterator] = dy_arr[iterator - 1];
                iterator--;
            }
            dy_arr[index] = item;
        }

        public void Print()
        {
            foreach (T element in dy_arr)
            {
                Console.Write(element + " ");
            }
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index == -1)
                return false;
            //Push every element after the index 1 block to its left. This will overwrite the value
            //to be deleted.
            while (index < size)
            {
                dy_arr[index] = dy_arr[index + 1];
                index++;
            }
            return true;
        }

        public void RemoveAt(int index)
        {
            while (index < size)
            {
                dy_arr[index] = dy_arr[index + 1];
                index++;
            }
        }

    }
}
