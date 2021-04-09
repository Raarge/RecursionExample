using System;

namespace RecursionExample
{
    class Program
    {
        static void Main(string[] args)
        {

            int f = factorial(4);
            Console.WriteLine("Final value: " + f);
        }

        static int factorial(int n)
        {
            Console.WriteLine("The int n passed into factorial: " + n);
            if (n == 1)
                return 1;
            else
            {
                int result = n * factorial(n - 1);
                Console.WriteLine("Calling Factorial For: " + n + " which is: " + result);
                return result;
            }
        }
    }
}
