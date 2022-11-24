using System;

namespace SwitchStatement
{
    class DeliveryDrones
    {
        static void Main()
        {

            int distance = 0;
            bool drone = false;
            while (!drone)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "forward":
                        distance += 10;
                        break;
                    case "backward":
                        if (distance > 0)
                        {
                            distance -= 10;
                        }
                        else if (distance <= 0)
                        {
                            drone = true;
                            Console.WriteLine("Go back to base. Delivery failed.");
                        }
                        break;
                    case "Destination reached.":
                        drone = true;
                        Console.WriteLine(distance);
                        break;
                }
            }
        }
    }
}
/*TASK  At our resistance base, we have delivery drones. These are very simple flying robots that know only how to deliver boxes to the destination point. After some time, the drones begin to break. They'll move forward and then backward. We still keep a drone in circulation as long as it moves forward more often than backward. The drones log all their actions the console until it reaches the destination.
Your program should print the distance from the starting point to the destination. If, at some point, the drone performs more steps backward than forward, the program should terminate the delivery and output "Go back to base. Delivery failed." to the console.
You can assume that the drone flies along a straight line with no turns. If the drone outputs "forward", it means that it has moved 10 meters forward. Otherwise, if it moved backward, the output will be "backward". When the drone reaches the destination point, it prints "Destination reached." to the console In this case, the program should output the distance from the starting point to the destination. Use a switch to check the input from the drone.
Example 1:
>forward
>forward
>backward
>forward
>forward
>Destination reached.
 30
Example 2:
>forward
>backward
>backward
Go back to base. Delivery failed.*/