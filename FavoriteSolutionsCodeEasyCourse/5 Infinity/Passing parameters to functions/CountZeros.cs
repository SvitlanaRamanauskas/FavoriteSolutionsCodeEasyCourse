using System;

namespace ParametersToMethods
{
    class HowManyZer0s
    {
        static void Main()
        {
            var input = Console.ReadLine();
            int numberOfZeros;


            if (AnalyzeString(input, out numberOfZeros))
            {
                Console.WriteLine(numberOfZeros);
            }
            else
            {
                Console.WriteLine("The string is invalid.");
            }
        }

        static bool AnalyzeString(string input, out int numberOfZeros)
        {
            numberOfZeros = 0;
            if (!string.IsNullOrEmpty(input))
            {

                foreach (char c in input)
                {
                    if (c == '0')
                    {
                        numberOfZeros++;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
/*TASK  Write a method, named AnalyzeString, that returns bool and takes two parameters, string input and out int numberOfZeros. It should calculate the number of zeros in the string and assign it to numberOfZeros. If the string passed to the method is empty, it should return false, otherwise, true. From the Main method, read the input string from the console, and call AnalyzeString with it. If AnalyzeString returns true, print the number of zeros, if it returns false, print 'The string is invalid.' Example 1:
>He0llo W0000rld!
5
Example 2: 
>
The string is invalid. */