using System;

namespace Exam
{
    class InsertAtIndex
    {
        static void Main()
        {
            double[] myArray = GetNumbersFromConsole();
            int insertIndex = int.Parse(Console.ReadLine());
            double temp = 0;
            temp = myArray[insertIndex];
            double elementToInsert = double.Parse(Console.ReadLine());

            for (int i = 0; i <= insertIndex; i++)
            {
                if (i == insertIndex)
                {
                    myArray[insertIndex] = elementToInsert;
                    Console.Write(myArray[insertIndex]);
                    Console.Write(",");
                    Console.Write(temp);
                    Console.Write(",");
                }
                else
                {
                    Console.Write(myArray[i]);
                    Console.Write(",");
                }
            }
            for (int i = insertIndex + 1; i < myArray.Length - 1; i++)
            {
                Console.Write(myArray[i]);
                if (i != myArray.Length - 2)
                    Console.Write(",");
            }
        }

        static double[] GetNumbersFromConsole()
        {
            int count = int.Parse(Console.ReadLine());
            double[] result = new double[count + 1]; // One extra element in the end

            for (int i = 0; i < count; ++i)
            {
                result[i] = double.Parse(Console.ReadLine());
            }

            return result;
        }
    }
}
/*TASK  Write a program to insert a new value in a double array at the specified index. Use method GetNumbersFromConsole to read the double array from the console. The array will be created with one extra, empty element, which gives you room to insert one more value. Read an integer insertIndex — index, where to insert an element, and a double element — the value to insert. Insert this element at index insertIndex. Output the array to the screen, separating each element with comma.
For example:
>4
>1.25
>3.14
>7.2
>-37.12
>2
>14.9
1.25,3.14,14.9,7.2,-37.12*/