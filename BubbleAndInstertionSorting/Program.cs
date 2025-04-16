// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] array = { 7, 3, 10, 5, 2 };
        int[] array0 = { 7, 3, 10, 5, 2 };
        Console.WriteLine("Original array:");
        PrintArray(array);
        Console.WriteLine();

        Console.WriteLine("Linear Search:");
        LinearSearch(array, 5);
        Console.WriteLine();

        BubbleSort(array);
        Console.WriteLine("Bubble Sorted array:");
        PrintArray(array);
        Console.WriteLine();

        InsertionSort(array0);
        Console.WriteLine("Insertion Sorted array:");
        PrintArray(array0);
        Console.WriteLine();

        Console.WriteLine("Binary Search:");
        BinarySearch(array, 5);

    }

    static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int current = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > current)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = current;
        }
    }

    static void BubbleSort(int[] array)
    {
        bool isSwapped = false;
        for (int j = 0; j < array.Length; j++)
        {
            for (int i = 0; i < array.Length - j - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    isSwapped = true;
                }
            }
            if (isSwapped == false)
            {
                Console.WriteLine("Allready sorted.");
                return;
            }
        }
    }

    static void LinearSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                Console.WriteLine($" {target} found at {i}");
            }
        }
    }

    static void BinarySearch(int[] array, int target)
    {
        int right = array.Length - 1;
        int left = 0;
        

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (target == array[mid])
            {
                Console.WriteLine($"{target} found at {mid}");
                return;
            }
            if (target > array[mid])
            {
                left = mid + 1;
            }
            if (target < array[mid])
            {
                right = mid - 1;
            }
        }
        Console.WriteLine("Target not found");
        return;
    }

    static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i + " -> ");
        }
        Console.Write("null");
        Console.WriteLine();
    }
}