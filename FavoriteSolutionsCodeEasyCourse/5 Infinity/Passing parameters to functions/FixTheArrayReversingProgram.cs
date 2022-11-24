using System;

namespace ParametersToMethods
{
    class WhyIsntItReversingMyArray
    {
        static void Main()
        {
            int[] exampleArray;
            GetNumbersFromConsole(out exampleArray);

            for (int i = 0; i < exampleArray.Length / 2; i++)
            {
                Swap(ref exampleArray[i], ref exampleArray[exampleArray.Length - i - 1]);
            }

            for (int i = 0; i < exampleArray.Length; i++)
            {
                Console.Write(exampleArray[i]);
                if (i != exampleArray.Length - 1)
                    Console.Write(" ");
            }
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static bool GetNumbersFromConsole(out int[] result)
        {
            int count = int.Parse(Console.ReadLine());
            result = new int[count];

            for (int i = 0; i < count; ++i)
            {
                result[i] = int.Parse(Console.ReadLine());
            }
            if (result.Length > 0)
                return true;
            else
                return false;

            //return result;
        }
    }
}
/*This program is supposed to reverse an array and then output it to the screen. But... something has gone wrong. Fix it! (Do not change the way that the array is output!). Example:
>4
>1
>2
>3
>4
4 3 2 1*/