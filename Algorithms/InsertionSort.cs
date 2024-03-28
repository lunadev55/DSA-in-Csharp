using System.Runtime.ExceptionServices;
using System.Text;

class Program
{       
    public static int[] InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {               
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;            
        }
        return arr;
    }
    public static void Main(string[] args)
    {         
        // [5, 3, 8, 2, 7]
        int[] arr = { 5, 3, 8, 2, 7 };

        InsertionSort(arr);
        
        foreach (int item in arr)
        {
            Console.WriteLine(item);
        }
    }         
}
