using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
class URI {   
    public static short[] Arr = {33, 2, 1333, 103, 1, 5, 21243, 987, 9, -543};
    static void Main(string[] args) {        
        Console.WriteLine("Selection Sort: ");
        var sortedArray = SelectionSort();

        // Writes the sorted Arr values to the console
        for (int i = 0; i < sortedArray.Length; i++)        
            Console.WriteLine(sortedArray[i]);        
    }
    
    public static short[] SelectionSort()
    {
        short[] sortedArray = new short[Arr.Length];

        for (int i = 0; i < sortedArray.Length; i++)
        {            
            sortedArray[i] = FindSmallest();
            // removes smallest element from main array
            var arrAsList = Arr.ToList();
            arrAsList.Remove(sortedArray[i]);
            Arr = arrAsList.ToArray();
        }
        return sortedArray;
    }

    public static short FindSmallest()
    {
        return Arr.Min();  
    }
}
