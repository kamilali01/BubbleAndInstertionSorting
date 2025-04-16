using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] array = { 7, 3, 10, 5, 2 };
        int[] array0 = { 7, 3, 10, 5, 2 };
        Console.WriteLine("Original array:");
        PrintArray(array);

        BubbleSort(array);
        Console.WriteLine("Bubble Sorted array:");
        PrintArray(array);

        InsertionSort(array0);
        Console.WriteLine("Insertion Sorted array:");
        PrintArray(array0);

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