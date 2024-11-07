using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
class URI {   
    static void Main(string[] args)
    {
        int[] arr = new int[] {12, 4, 533, 5111, 432, 3, 5, 64};      
        int[] sortedArr = BubbleSort(arr);  

        for (int i = 0; i < sortedArr.Length; i++)
        {
            Console.Write($"{sortedArr[i]}, ");
        }
    }

    // time complexity O(n2)
    static int[] BubbleSort(int[] arr)
    {
        int length = arr.Length;

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < (length - 1) - i; j++)
            {
                // if current value is bigger than next -> Swap
                if (arr[j] > arr[j + 1])
                    Swap(arr, j, j + 1);                
            }            
        }
        return arr;
    }

    // function to swap values
    static void Swap(int[] arr, int i, int j)
    {
        int value = arr[i];
        arr[i] = arr[j];
        arr[j] = value;
    }
}
