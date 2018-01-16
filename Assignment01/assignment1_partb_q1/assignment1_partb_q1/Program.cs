using System;
using System.Collections;
using System.Collections.Generic;

namespace assignment1_partb_q1
{
    class Program
    {
        //Part B Ques 3
        static void Main(string[] args)
        {
            //Part B Ques 3 part a
            CompareDouble();
            //Part B Ques 3 part b
            CompareDec();
            //Part B Ques 3 part c
            CompareBool();
        }
        
        //The functions follow the same structure as the Main() method in Part A submission.
        //Kindly refer to Main() method of part A to understand comments.

        public static void CompareBool()
        {
            Console.WriteLine("\n------------For Boolean DataType----------\n");
            Console.WriteLine("\n\n------------Searching through the values----------\n");

            int size = 1000000;
            int random_search_size = 5;
            DynamicArray<bool> dy_arr = new DynamicArray<bool>(size);
            List<bool> myList = new List<bool>(size);
            bool[] myArray = new bool[size];
            Random rnd = new Random();
            int myNum;
            bool myBool;

            for (int index = 0; index < size; index++)
            {
                myNum = rnd.Next(1, 100);
                if (myNum < 50)
                    myBool = true;
                else myBool = false;

                dy_arr.Add(myBool);
                myArray[index] = myBool;
                myList.Add(myBool);
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            bool[] myRandom = new bool[random_search_size];
            for (int index = 0; index < random_search_size; index++)
            {
                myNum = rnd.Next(1, 100);
                if (myNum < 50)
                    myBool = true;
                else myBool = false;
                myRandom[index] = myBool;
            }
            int hits = 0;
            watch.Restart();
            foreach (bool rand in myRandom)
            {
                if (Array.IndexOf(myArray, rand) != -1)
                {
                    hits++;
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Array: " + elapsedMs + " Number of hits: " + hits);
            hits = 0;
            watch.Restart();
            foreach (bool rand in myRandom)
            {
                if (myList.IndexOf(rand) != -1)
                {
                    hits++;
                }
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("List: " + elapsedMs + " Number of hits: " + hits);
            hits = 0;
            watch.Restart();
            foreach (bool rand in myRandom)
            {
                if (dy_arr.IndexOf(rand) != -1)
                {
                    hits++;
                }
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("MyDynamicArrayList: " + elapsedMs + " Number of hits: " + hits+"\n");
        }
        public static void CompareDec()
        {
            Console.WriteLine("\n------------For Decimal DataType----------\n");
            Console.WriteLine("\n------------Traversing the collections and summing the values----------\n");
            int size = 1000000;
            int random_search_size = 5;
            DynamicArray<decimal> dy_arr = new DynamicArray<decimal>(size);
            List<decimal> myList = new List<decimal>(size);
            decimal[] myArray = new decimal[size];
            Random rnd = new Random();
            decimal myNum;

            for (int index = 0; index < size; index++)
            {
                myNum = (decimal)rnd.NextDouble();
                dy_arr.Add(myNum);
                myArray[index] = myNum;
                myList.Add(myNum);
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            decimal sum = 0;
            foreach (decimal num in myArray)
            {
                sum += num;
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Array Time: " + elapsedMs + " and Sum: " + sum);
            watch.Restart();
            sum = 0;
            foreach (decimal num in myList)
            {
                sum += num;
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("List: Time: " + elapsedMs + " and Sum: " + sum);
            watch.Restart();
            sum = 0;
            for (int index = 0; index < size; index++)
            {
                sum += dy_arr.Get(index);
            }

            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("MyDynamicArray: Time: " + elapsedMs + " and Sum: " + sum);

            //Searching another set of 5 random numbers
            decimal[] myRandom = new decimal[random_search_size];
            for (int index = 0; index < random_search_size; index++)
            {
                myNum = (decimal)rnd.NextDouble();
                myRandom[index] = myNum;
            }
            int hits = 0;
            watch.Restart();
            foreach (decimal rand in myRandom)
            {
                if (Array.IndexOf(myArray, rand) != -1)
                {
                    hits++;
                }
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("\n\n------------Searching through the values----------\n");
            Console.WriteLine("Array: " + elapsedMs + " Number of hits: " + hits);
            hits = 0;
            watch.Restart();
            foreach (decimal rand in myRandom)
            {
                if (myList.IndexOf(rand) != -1)
                {
                    hits++;
                }
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("List: " + elapsedMs + " Number of hits: " + hits);
            hits = 0;
            watch.Restart();
            foreach (decimal rand in myRandom)
            {
                if (dy_arr.IndexOf(rand) != -1)
                {
                    hits++;
                }
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("MyDynamicArrayList: " + elapsedMs + " Number of hits: " + hits);

        }
        public static void CompareDouble()
        {
            Console.WriteLine("\n------------For Double DataType----------\n");
            Console.WriteLine("\n------------Traversing the collections and summing the values----------\n");
            int size = 1000000;
            int random_search_size = 5;
            DynamicArray<double> dy_arr = new DynamicArray<double>(size);
            List<double> myList = new List<double>(size);
            double[] myArray = new double[size];
            Random rnd = new Random();
            double myNum;

            for (int index = 0; index < size; index++)
            {
                myNum = rnd.NextDouble();
                dy_arr.Add(myNum);
                myArray[index] = myNum;
                myList.Add(myNum);
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            double sum = 0;
            foreach (double num in myArray)
            {
                sum += num;
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Array Time: " + elapsedMs + " and Sum: " + sum);
            watch.Restart();
            sum = 0;
            foreach (double num in myList)
            {
                sum += num;
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("List Time: " + elapsedMs + " and Sum: " + sum);
            watch.Restart();
            sum = 0;
            for (int index = 0; index < size; index++)
            {
                sum += dy_arr.Get(index);
            }

            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("MyDynamicArray Time: " + elapsedMs + " and Sum: " + sum);

            double[] myRandom = new double[random_search_size];
            for (int index = 0; index < random_search_size; index++)
            {
                myNum = rnd.NextDouble();
                myRandom[index] = myNum;
            }
            int hits = 0;
            watch.Restart();
            foreach (double rand in myRandom)
            {
                if (Array.IndexOf(myArray, rand) != -1)
                {
                    hits++;
                }
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("\n\n------------Searching through the values----------\n");

            Console.WriteLine("Array: " + elapsedMs + " Number of hits: " + hits);
            hits = 0;
            watch.Restart();
            foreach (double rand in myRandom)
            {
                if (myList.IndexOf(rand) != -1)
                {
                    hits++;
                }
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("List: " + elapsedMs + " Number of hits: " + hits);
            hits = 0;
            watch.Restart();
            foreach (double rand in myRandom)
            {
                if (dy_arr.IndexOf(rand) != -1)
                {
                    hits++;
                }
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("MyDynamicArrayList: " + elapsedMs + " Number of hits: " + hits);
        }
    }
}
