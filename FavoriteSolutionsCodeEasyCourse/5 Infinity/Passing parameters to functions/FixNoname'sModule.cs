using System;

namespace ParametersToMethods
{
    class FillTheArrayNow
    {
        static void Main()
        {
            var myArray = new int[10]; //0000000000
            var commandsCount = int.Parse(Console.ReadLine());// 4
            for (int k = 0; k < commandsCount; k++) // READING users commands 
            {
                string myString = Console.ReadLine();
                int index = int.Parse(myString[5].ToString());
                if (myString == ($"add1 {index}"))
                    PutOneAtIndex(myArray, index);
                if (myString == ($"add0 {index}"))
                    PutZeroAtIndex(myArray, index);
            }
            // Write your code here
            for (int i = 0; i < myArray.Length; i++)// WRITING the array with numbers
            {
                Console.Write(myArray[i]);
                if (i != myArray.Length - 1)
                    Console.Write(" ");
            }
        }

        static void PutOneAtIndex(int[] theArray, int index)
        {
            for (int i = 0; i < theArray.Length; i++)
            {
                if (i == index)
                    theArray[i] = 1;
            }// Write 1 to the array cell with index index
        }

        static void PutZeroAtIndex(int[] theArray, int index)
        {
            for (int i = 0; i < theArray.Length; i++)
            {
                if (i == index)
                    theArray[i] = 0;
            }// Write 0 to the array cell with index index
        }
    }
}
/*TASK  Write a program that first creates an int array, with a size of 10, and reads the number of commands from the user. After that, the program should read every command that the user inputs. Commands are represented by one string and could be of 2 types: add1 index or add0 index. These commands should change the corresponding array cell to 1 or 0. Forexample, the command add1 3 puts 1 to the array cell with an index of 3. After all the commands from the user are executed, print the array to the screen. Use methods  PutOneAtIndex  and PutZeroAtIndex for command execution. Example:
>4
>add1 1
>add0 1
>add1 9
>add1 5

0 0 0 0 0 1 0 0 0 1
/*Tip: To convert one char from string to int, use int.Parse(myString[index].ToString()) */