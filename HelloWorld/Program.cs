using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            linearSearch(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 9);

            int linearSearch(int[] array, int elementToSearch)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    if(array[i] == elementToSearch)
                    {
                        Console.WriteLine(i);
                        return i;
                    }
                }
                return -1;
            }
        }
    }
}
