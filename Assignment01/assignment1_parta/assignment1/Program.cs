//imports
using System;
using System.Collections;
using System.Collections.Generic;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * OBSERVATIONS:
             * 
             * 1. DynamicIntArray performs much better than ArrayList for calculating the sum task.
             * 2. DynamicIntArray is as good as C# array and list for searching task.
             * 
            */

            //initializations for Part A Question 2
            int size = 1000000;
            int random_search_size = 5;

            DynamicIntArray dy_arr = new DynamicIntArray(size);
            int[] myArray = new int[size];
            ArrayList myAL = new ArrayList(size);
            List<int> myList = new List<int>(size);

            Random rnd = new Random();
            int myNum;

            //Part A Ques 2 part a: Fill all the collections with random numbers of the range [1,100)
            for (int index = 0; index < size; index++)
            {
                myNum = rnd.Next(1, 100);

                dy_arr.Add(myNum);
                myArray[index] = myNum;
                myAL.Add(myNum);
                myList.Add(myNum);
            }

            //To calculate the performance, Stopwatch is used. 

            var watch = System.Diagnostics.Stopwatch.StartNew();

            //Part A Ques 2 part b: Traversing and summing through the collections

            Console.WriteLine("\n------------Traversing the collections and summing the values----------\n");
            //For Array
            int sum = 0;
            foreach (int num in myArray)
            {
                sum += num;
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Array Time: " + elapsedMs+ " and Sum: "+sum);
            //For List
            sum = 0;
            watch.Restart();
            foreach (int num in myList)
            {
                sum += num;
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("List Time: " + elapsedMs + " and Sum: " + sum);
            //For ArrayList
            sum = 0;
            watch.Restart();
            foreach (int num in myAL)
            {
                sum += num;
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("ArrayList Time: " + elapsedMs + " and Sum: " + sum);
            //For DynamicIntArray
            sum = 0;
            watch.Restart();
            for (int index = 0; index< size; index++)
            {
                sum += dy_arr.Get(index);
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("MyDynamicIntArray Time: " + elapsedMs + " and Sum: " + sum);


            //Part A Ques 2 part c: Search 5 randomly chosen values and search through the collections
            Console.WriteLine("\n\n------------Searching through the values----------\n");
            int[] myRandom = new int[random_search_size];
            for (int index = 0; index < random_search_size; index++)
            {
                myNum = rnd.Next(1, 200);
                myRandom[index] = myNum;
            }
            //For Array
            int hits = 0;
            watch.Restart();
            foreach (int rand in myRandom)
            {
                if (Array.IndexOf(myArray,rand)!=-1)
                {
                    hits++;
                }
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Array: " + elapsedMs + " Number of hits: " + hits);
            //For List
            hits = 0;
            watch.Restart();
            foreach (int rand in myRandom)
            {
                if (myList.IndexOf(rand)!=-1)
                {
                    hits++;
                }
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("List: " + elapsedMs + " Number of hits: " + hits);
            //For ArrayList
            hits = 0;
            watch.Restart();
            foreach (int rand in myRandom)
            {
                if (myAL.IndexOf(rand)!=-1)
                {
                    hits++;
                }
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("ArrayList: " + elapsedMs + " Number of hits: " + hits);
            //For DynamicIntArray
            hits = 0;
            watch.Restart();
            foreach(int rand in myRandom)
            {
                if (dy_arr.IndexOf(rand) != -1)
                {
                    hits++;
                }
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("MyDynamicIntArray: " + elapsedMs + " Number of hits: " + hits+"\n");
        }
    }
}
