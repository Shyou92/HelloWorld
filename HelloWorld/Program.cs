using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Factorial(int x)
            {
                if (x == 0)
                {
                    return 1;
                }
                else
                {
                    return x * Factorial(x - 1);
                }
            }

            int result = Factorial(5);

            Console.WriteLine(result);
        }
    }
}
