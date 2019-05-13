using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates an array of random numbers.
            int[] nums = new int[100000];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(100000);
            }

            int[] nums2 = new int[100000];
            for (int i = 0; i < nums.Length; i++)
            {
                nums2[i] = rand.Next(100000);
            }

            Console.WriteLine("\nRandom Numbers:");

            foreach (int x in nums)
                Console.Write(x + " ");

            Console.WriteLine("\n\nBubble Sort - Sorted Numbers:"); 
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            BubbleSort(nums);
            stopwatch1.Stop();
            BubbleSortDisplay(nums);
           
            Console.WriteLine("\n\nInsertion Sort - Sorted Numbers:");
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();

            InsertionSort(nums2);
            stopwatch2.Stop();
            InsertionSortDisplay(nums2);

            Console.WriteLine($"\n\nProcessing time for Bubble Sort: {stopwatch1.ElapsedMilliseconds} milliseconds");
            Console.WriteLine($"\n\nProcessing time for Insertion Sort: {stopwatch2.ElapsedMilliseconds} milliseconds\n");
        }
        /*Basic bubble sort algorithm*/
        static int[] BubbleSort(int[] arr)
        {
            /*External loop makes sure we check all of array*/
            for (int i = 0; i < arr.Length - 1; i++)
            {
                /*Internal loop goes through the elements and checks each one*/
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    /*If the current element is larger than the next element, swap them*/
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr; 
        }
        //Insertion Sort algorithm
        static int[] InsertionSort(int[] array)
        {
            int temp, j;

            for(int i = 0; i < array.Length; i++)
            {
                j = i;
                temp = array[i];
                while(j > 0 && array[j-1] >= temp)
                {
                    array[j] = array[j - 1];
                    j -= 1;
                }
                array[j] = temp;
            }
            return array;
        }
        /*Display the array*/
        static void BubbleSortDisplay<T>(T[] arr)
        {
            foreach (T x in arr)
            {
                Console.Write(x + " ");
            }
        }
        static void InsertionSortDisplay<T>(T[] array)
        {
            foreach (T x in array)
            {
                Console.Write(x + " ");
            }
        }
    }
}
