using System;

namespace Exam
{
    class HandsAngle
    {
        static void Main()
        {
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double cycleAngle = 360;

            double hourMax = 12;
            double minutesMax = 60;
            int oneHourInDs = 30;
            double gradusAddToHours;
            double differenceHoursInDs = 0;
            double differenceMinutesInDs = 0;
            if (hours == 0 && minutes > 0 && minutes <= 59) //time: 00:48
            {
                gradusAddToHours = minutes * oneHourInDs / 60; // (Proporsion) 60 is amount of min in 1 hour // 24
                differenceHoursInDs = (hourMax - hours) * oneHourInDs - gradusAddToHours; // 336
                differenceMinutesInDs = (minutesMax - minutes) * 6;// 6 is amount of degrees in 1 minute //(60-48) * 6 = 72
            }
            else if (minutes == 0 && hours > 0 && hours <= 12) //time: 07:00
            {
                gradusAddToHours = 0; // no need
                differenceHoursInDs = (hourMax - hours) * oneHourInDs - gradusAddToHours;// (12 - 7) * 30 = 150;
                differenceMinutesInDs = (minutesMax - minutes) * 6; //360;
            }
            else if (minutes == 0 && hours == 0) // can skip but I leave for visualisation
            {
                gradusAddToHours = 0;
                differenceHoursInDs = 0;
                differenceMinutesInDs = 0;
            }
            else if (hours > 0 && hours <= 12 && minutes > 0 && minutes <= 59) //time: 10:57
            {
                gradusAddToHours = minutes * oneHourInDs / 60; // 28.5  
                differenceHoursInDs = (hourMax - hours) * oneHourInDs - gradusAddToHours; // 31.5
                differenceMinutesInDs = (minutesMax - minutes) * 6; // 18
            }


            double smallestAngle = Math.Abs(differenceHoursInDs - differenceMinutesInDs);

            if (smallestAngle > 180)
            {
                smallestAngle = cycleAngle - smallestAngle;
            }
            Console.WriteLine(smallestAngle);
        }
    }
}
/*TASK  We figured out that there is a spy among us. We don't know exactly who it is, but we know that all messages that this spy is sending are encoded using the angle between the hands of an analog clock. Your task is to write a program that, given a specific time, returns the angle between the hands of an analog clock showing that time. The input is 2 integers, each written from a new line, that represent hours and minutes (respectively) in the format [0...12] and [0...59]. You should output one number — the smallest angle in degrees between the hands of an analog clock that shows the specified time.
Example 1:
>10
>0
 60
Example 2:
>7
>15
127.5*/