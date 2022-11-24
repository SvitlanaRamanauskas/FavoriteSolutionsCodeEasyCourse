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
            double sumDs = 0;
            double hourMax = 12;
            double minutesMax = 60;

            double gradusPlus;
            double differenceHoursinDs = 0;
            double differenceMinutesinDs = 0;
            if ((hours == 0) && ((minutes > 0) && (minutes <= 59)))
            {
                gradusPlus = 0;
                differenceHoursinDs = 0;
                differenceMinutesinDs = (minutesMax - minutes) * 6;// (60-15)  * 6 = 270
            }
            else if ((minutes == 0) && ((hours > 0) && (hours <= 12)))
            {
                gradusPlus = (minutes * 30) / 60; // 7.5 to add to hoursinDegrees M= 40*6 = 240  30=60; ?g = minutes; (m*30)/60 = gradusy+ 
                differenceHoursinDs = (hourMax - hours) * 30 - gradusPlus;//  (12 - 7) * 30 - 7.5 = 142.5;  60
                differenceMinutesinDs = 0;
            }
            else if ((minutes == 0) && (hours == 0))
            {
                gradusPlus = 0;
                differenceHoursinDs = 0;
                differenceMinutesinDs = 0;
            }
            else if (((hours > 0) && (hours <= 12)) && ((minutes > 0) && (minutes <= 59)))
            {
                gradusPlus = (minutes * 30) / 60; // 28.5
                differenceHoursinDs = (hourMax - hours) * 30 - gradusPlus;// 61.5
                differenceMinutesinDs = (minutesMax - minutes) * 6; // 18;
            }

            sumDs = Math.Abs(differenceHoursinDs - differenceMinutesinDs);

            if (sumDs > 180)
            {
                sumDs = cycleAngle - sumDs;
            }

            Console.WriteLine(sumDs);
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