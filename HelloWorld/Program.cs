using System;

namespace HelloWorld
{
    class Program
    {
        static int[] Sort(int[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                int current = arr[i];
                int j = i;

                while (j > 0 && arr[j - 1] > current)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = current;
            }

            return arr;
        }

        static int Search(int[] arr, int elem)
        {
            var min = 0;
            var max = arr.Length;

            while (true)
            {
                if (max - min == 1)
                {
                    if (arr[min].CompareTo(elem) == 0)
                        return min;
                    if (arr[max].CompareTo(elem) == 0)
                        return max;
                    return -1;
                }
                else
                {
                    var middle = min + (max - min) / 2;
                    var comparisonResult = arr[middle].CompareTo(elem);
                    if (comparisonResult == 0)
                        return middle;
                    if (comparisonResult < 0)
                        min = middle;
                    if (comparisonResult > 0)
                        max = middle;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 9, 1, 10, 7, 3, 8, 2, 6, 4 };

            int[] result = Sort(arr);

            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }    

            Console.WriteLine( $"My current position in array list is {Search(result, 8)}");
        }
    }
}
