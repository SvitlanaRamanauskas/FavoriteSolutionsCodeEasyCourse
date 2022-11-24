using System;

namespace ParametersToMethods
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int previous = 1;
            int current = 1;
            Console.Write("1 1");

            for (int i = 0; i < n - 2; ++i)
            {
                Console.Write(" ");

                GetNextFibonacci(ref previous, ref current);
                Console.Write(current);
            }
        }

        static void GetNextFibonacci(ref int previous, ref int current)
        {
            int tmp = current;
            current = previous + current;
            previous = tmp;
        }
    }
}

/*TASK Fix the method 'GetNextFibonacci' that takes two integers, representing two sequential Fibonacci numbers, and rearranges their values to get the next one. The Main method should read integer n from the console, and then, using GetNextFibonacci, output first n Fibonacci numbers, delimited by space. Example:
>10
1 1 2 3 5 8 13 21 34 55  */
