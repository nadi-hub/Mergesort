﻿using System;

class MergeSortExample
{
    public static void MergeSort(int[] array)
    {
        if (array.Length <= 1)
            return;

        int mid = array.Length / 2;

        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        Array.Copy(array, 0, left, 0, mid);
        Array.Copy(array, mid, right, 0, array.Length - mid);

        MergeSort(left);
        MergeSort(right);

        Merge(array, left, right);
    }

    private static void Merge(int[] array, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                array[k] = left[i];
                i++;
            }
            else
            {
                array[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < left.Length)
        {
            array[k] = left[i];
            i++;
            k++;
        }

        while (j < right.Length)
        {
            array[k] = right[j];
            j++;
            k++;
        }
    }

    static void Main(string[] args)
    {
        int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };

        Console.WriteLine("Unsortiertes Array:");
        Console.WriteLine(string.Join(", ", numbers));

        MergeSort(numbers);

        Console.WriteLine("Sortiertes Array:");
        Console.WriteLine(string.Join(", ", numbers));
    }
}