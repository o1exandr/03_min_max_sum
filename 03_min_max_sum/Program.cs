/*
 3. Визначити суму елементів, розміщених між максимальним та мінімальним елементом масиву.
Користуватися методами (Max, Min, IndexOf)
 */

using System;
using System.Linq;


namespace _03_min_max_sum
{
    class Program
    {
        static void FillRand(int[] arr, int left = 0, int rigth = 20)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(left, rigth);
            }
        }

        static void Print(int[] arr, string message = "")
        {
            Console.WriteLine(message);
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]}\t");
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            FillRand(arr);
            Print(arr, "Array:");
            int indexMin = Array.IndexOf(arr, arr.Min());
            int indexMax = Array.IndexOf(arr, arr.Max());
            Console.WriteLine($"Min arr[{indexMin}]:\t{arr.Min()}");
            Console.WriteLine($"Max arr[{indexMax}]:\t{arr.Max()}");
            int sum = 0;
            if (indexMin > indexMax)
            {
                int tmp = indexMin;
                indexMin = indexMax;
                indexMax = tmp;
            }
            for (int i = indexMin; i <= indexMax; i++)
                sum += arr[i];
            Console.WriteLine($"Sum between {arr.Min()} and {arr.Max()} = {sum}");
        }
    }
}
