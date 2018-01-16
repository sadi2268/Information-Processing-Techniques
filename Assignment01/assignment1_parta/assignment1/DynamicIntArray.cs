using System;

namespace assignment1
{
    //Part A Ques 1
    class DynamicIntArray
    {
        //Part A Ques 1 part a
        public int size;
        //Part A Ques 1 part b
        public int capacity;
        //Part A Ques 1 part c
        public int[] dy_arr;

        //Part A Ques 1 part d
        public DynamicIntArray()
        {
            capacity = 10;
            dy_arr = new int[capacity];
            size = 0;
        }

        //Part A Ques 1 part e
        public DynamicIntArray(int cap)
        {
            capacity = cap;
            dy_arr = new int[capacity];
            size = 0;
        }
        //Part A Ques 1 part f - Thanks for the Hint!
        public void Add(int element)
        {
            if (size < capacity)
            {
                dy_arr[size] = element;
                size++;
            }
            else
            {
                Console.WriteLine("Resizing!");
                Array.Resize(ref dy_arr, capacity * 2);
                capacity = capacity * 2;
                dy_arr[size] = element;
                size++;
            }
        }
        //Part A Ques 1 part g
        public int Get(int index)
        {
            if (index < size)
            {
                return dy_arr[index];
            }
            else
                return -1;
        }
        //Part A Ques 1 part h
        public int IndexOf(int element)
        {
            int index = Array.IndexOf(dy_arr, element);
            return index;
        }

        //Helper method implemented to print the array
        public void Print()
        {
            foreach (int element in dy_arr)
            {
                Console.Write(element + " ");
            }
        }
    }

}
