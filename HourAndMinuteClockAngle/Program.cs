using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourAndMinuteClockAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter the Minutes : ");
            int minutes = int.Parse(Console.ReadLine());
            double countHourInDegrees = (hours * 30) + (minutes * 30.0 / 60);
            double countMinuteInDegrees = minutes * 6;
            double differnce = Math.Abs(countHourInDegrees - countMinuteInDegrees);
            if (differnce > 180)
            {
                differnce = 360 - differnce;
            }
            Console.WriteLine($"The angle between hour hand and minute hand is {differnce} degrees");
            Console.ReadKey();
        }
    }
}
