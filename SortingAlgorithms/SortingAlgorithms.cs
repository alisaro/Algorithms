/*
 * C# Program:  Bubble Sort
 */
using System;
using System.Diagnostics;

namespace BubleSort{
    
    class Program{
        
        public static int[] BubleSort(int[] tab, bool display = false){
            int comparisons = 0;
            int n = tab.Length;
            int swaps = 0;
            do{
                //swapped = false;
                for(int i=0; i< n-1; i++){
                    int tmp = tab[i];
                    if(display){
                        
                    comparisons++;
                    }
                    if(tmp > tab[i+1]){
                        //tab.swap(tab[i],tab[i+1]);
                        tab[i]=tab[i+1];
                        tab[i+1]=tmp;
                        if(display){ 
                            swaps++;
                        }
                       
                        //swapped = true;
                    }
                    
                }
                
                n= n-1;
            }while(n != 1);
            if(display){ 
                Console.WriteLine("Comparisons: " + comparisons + " " + "Swaps: " + swaps);
            }
            return tab;
        }
        
        //------------------------------------------------------------------------
        
        public static int[] insertionSort(int[] numbers, bool display= false)
        { 
            int i, key, value; 
            int comparisons = 0;
            int swaps = 0;
            for (i=1; i < numbers.Length; i++){
                key = numbers [i]; //the second value of the array
                value = i - 1; //the first value of the array
                 if(display){
                        
                        comparisons++;
                    }
                while (value >= 0 && numbers[value] > key){
                    //insertion of the correct number
                    numbers [value + 1] = numbers [value];
                    value = value - 1;
                    if(display){
                        swaps++;
                    }
                    
                }
                
                numbers [value + 1] = key;
                //PrintOut(numbers);
            
            }
            if(display){ 
                Console.WriteLine("Comparisons: " + comparisons + " " + "Swaps: " + swaps);
            }
            return numbers;
        } 
    
        //----------------------------------------------------------------------
        
        /*public static int getMin(int[] arr, int start)
        {
            int min = arr[start];
            int minIndex = start;
            for (int i = start + 1; i < arr.Length; i++)
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            return minIndex;
        }*/

        public static int[] sortBySelection(int[] arr, bool display= false)
        {
            //long swaps = 0;
            int comparisons = 0;
            int swaps = 0;
            int minIndex;
            int min;
            for (int i = 0; i < arr.Length; i++)
            {
                int tmp = arr[i];
                
                
                //minIndex = getMin(arr, i);
                
                //-----------------------------
                min = arr[i];
                minIndex = i;
                for (int j = i + 1; j < arr.Length; j++){
                    if(display){
                            comparisons++;
                        }
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        minIndex = j;
                        
                    }
                }
                //-----------------------------
                
                if (i != minIndex)
                {
                   arr[i] = arr[minIndex];
                   arr[minIndex] = tmp;
                   if(display){
                        swaps++;
                   }      
                }
            }
            //Console.WriteLine("Insertion method did " + swaps + " swaps.");
           if(display){ 
            Console.WriteLine("Comparisons: " + comparisons + " " + "Swaps: " + swaps);
            
            }
            return arr;
        }
        
        //----------------------------------------------------------------------
        public static void PrintOut(int[] arr, int everyNth)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % everyNth == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();

        }
        
        
        public static void PrintOutAll(int[] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                    Console.Write(arr[i] + " ");
            }

        }
        
        
        static void Main() {
            
            //int[] tab={1,0,4,8,11,3,8,-2,5};
            
            DateTime start;
            TimeSpan timeItTook;
            int n = 50000; int th = 5000;
            int min = 0; int max = 500;
            Random random = new Random();

            int[] listZero = new int[n];
            int[] listOne = new int[n];
            int[] listTwo = new int[n];
            int[] listThree = new int[n];
            int[] listOne1 = new int[n];
            int[] listTwo2 = new int[n];
            int[] listThree3 = new int[n];
            
            //the array of N random integers
            for (int i = 0; i < n; i++)
            {
                listZero[i] = random.Next(min, max);
            }
            
            /*Console.WriteLine("The original array has {0} values. Every {1}th is printed out. ", n, th);
            PrintOut(listZero, n, th);
            Console.WriteLine("\n------------------");
            */
            for (int i = 0; i < n; i++)
            {
                listOne[i] = listZero[i];
                listOne1[i] = listZero[i];
                listTwo[i] = listZero[i];
                listTwo2[i] = listZero[i];
                listThree[i] = listZero[i];
                listThree3[i] = listZero[i];
            }

            
            /*PrintOut(listOne,th);
            Console.WriteLine("\nSorting by Bubble");
            start = DateTime.Now;
            listOne = BubleSort(listOne); 
            timeItTook  = DateTime.Now - start;
            PrintOut(listOne, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            */
            
            Console.WriteLine("\nSorting by Bubble");
            start = DateTime.Now;
            listOne1 = BubleSort(listOne1,true); 
            timeItTook  = DateTime.Now - start;
            PrintOut(listOne1, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            
            
            /*Console.WriteLine("\nSorting by Insertion");
            start = DateTime.Now;
            listTwo = insertionSort(listTwo); 
            timeItTook  = DateTime.Now - start;
            PrintOut(listTwo, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            */
            
            Console.WriteLine("\nSorting by Insertion");
            start = DateTime.Now;
            listTwo2 = insertionSort(listTwo2, true); 
            timeItTook  = DateTime.Now - start;
            PrintOut(listTwo2, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            //tab = insertionSort(numbers);
            
            
            /*Console.WriteLine("\nSorting by Selection");
            start = DateTime.Now;
            listThree = sortBySelection(listThree);
            timeItTook  = DateTime.Now - start;
            PrintOut(listThree, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            */
            Console.WriteLine("\nSorting by Selection");
            start = DateTime.Now;
            listThree3 = sortBySelection(listThree3,true);
            timeItTook  = DateTime.Now - start;
            PrintOut(listThree3, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            
            /*int[] test1 = {2,1,7,0,5};
            test1 = BubleSort(test1,true); 
            PrintOutAll(test1);
            Console.WriteLine("------------------");
            
            int[] test2 = {2,1,7,0,5};
            test2 = insertionSort(test2,true); 
            PrintOutAll(test2);
            Console.WriteLine("------------------");
            
            int[] test3 = {2,1,7,0,5};
            test3 = sortBySelection(test3,true); 
            PrintOutAll(test3);
            Console.WriteLine("------------------");*/
        }
    
    }
}



