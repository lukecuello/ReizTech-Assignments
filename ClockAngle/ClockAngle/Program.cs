using System;

namespace ClockAngle;
class Program
{
    static void Main(string[] args)
    {
        int hours;
        int minutes;
        
        // Gets the appropriate value of the hour hand and the minute hand
        // The loop will repeat if the input is invalid 
        do
        {
            Console.WriteLine("Enter the hours on the clock (1-12):");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the minutes on the clock (0-59):");
            minutes = Convert.ToInt32(Console.ReadLine());
        } while ((hours < 1 || minutes < 0) || (hours > 12 || minutes > 60));
           

        // Calculates the angles of the hour and minute hands in reference to the 12:00 position
        double hourAngle = (hours % 12) * 30 + minutes * 0.5;
        double minuteAngle = minutes * 6;

        // Calculates the absolute difference between the two angle values of both hands 
        double angle = Math.Abs(hourAngle - minuteAngle);

        // Calculates the lesser angle between the two angles
        if (angle > 180)
        {
            angle = 360 - angle;
        }

        Console.WriteLine("The lesser angle between the hour and minute hands is {0} degrees.", angle);
    }
}
