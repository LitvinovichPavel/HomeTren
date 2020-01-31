using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalMotocycleServiceModule;
namespace ConsoleMotocycle
{
    class MyConsoleMotocycle
    {
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public static int Odometer { get; private set; }
        public int DailyDistance { get; set; }
        public MyConsoleMotocycle(string model)
        {
            Model = model;
        }
        public void StartEngine()
        {
            Console.WriteLine();
            Console.WriteLine($"Engine has been starter at {DateTime.Now}");
        }
        public void Move(int distance)
        {
            DailyDistance += distance;
            Console.WriteLine($"Move to {distance}");
        }
        public void StopEngine()
        {
            Odometer += DailyDistance;
            //Call Service
            MotocycleService.DistanceFromLastService += DailyDistance;

            Console.WriteLine($"Engine has been stoped at {DateTime.Now}");
            Console.WriteLine($"TotalDistance: {Odometer} km");
        }
    }
}
