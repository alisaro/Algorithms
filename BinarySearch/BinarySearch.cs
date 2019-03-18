using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearching
{
    class Program
    {

        //-----------------------------------------------------------------------------
        public static int[] insertionSort(int[] numbers, bool display = false)
        {
            int i, key, value;
            int comparisons = 0;
            int swaps = 0;
            for (i = 1; i < numbers.Length; i++)
            {
                key = numbers[i]; //the second value of the array
                value = i - 1; //the first value of the array
                if (display)
                {

                    comparisons++;
                }
                while (value >= 0 && numbers[value] > key)
                {
                    //insertion of the correct number
                    numbers[value + 1] = numbers[value];
                    value = value - 1;
                    if (display)
                    {
                        swaps++;
                    }

                }

                numbers[value + 1] = key;
                //PrintOut(numbers);

            }
            if (display)
            {
                Console.WriteLine("Comparisons: " + comparisons + " " + "Swaps: " + swaps);
            }
            return numbers;
        }

        //--------------------------------------------------------------------------------------

        public static int BinarySearchDisplay(int[] arr, int targetValue)
        {
            int min = 0;
            int max = arr.Length - 1;
            int guess;
            while (min <= max)
            {
                guess = (min + max) / 2;
                if (arr[guess] == targetValue)
                {
                    return guess;

                }
                else if (arr[guess] < targetValue)
                {
                    min = guess + 1;

                }
                else
                {
                    max = guess - 1;

                }
            }
            return -1;
        }

     


        //----------------------------------------------------------------------

        public static void PrintOutAll(int[] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }

        //---------------------------------------------------------------------

        static void Main()
        {

            Random random = new Random();
            int a = 0; int b = 1000;
            int n = 20;
            int[] array = new int[n];


            Console.Write("\nArray with out order: ");
            //the array of N random integers
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(a, b);
            }

            
            PrintOutAll(array);
            Console.WriteLine();

            array = insertionSort(array);
            Console.Write("\nArray order: ");
            PrintOutAll(array);
            Console.WriteLine();

            int pos = random.Next(a, b);

            Console.WriteLine("\nValue to find: " + pos);

            int find = BinarySearchDisplay(array, pos);

            if (find == -1)
            {
                Console.WriteLine("\nThis value not exist");
            }
            else
            Console.WriteLine("\nPosition of value: " + find);

            Console.ReadKey();
        }
    }
}
