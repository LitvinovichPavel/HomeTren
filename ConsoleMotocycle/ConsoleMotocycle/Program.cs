using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalMotocycleServiceModule;
namespace ConsoleMotocycle
{
    class Program
    {
        static void Main(string[] args)
        {
            MotocycleService service = new MotocycleService();
            MyConsoleMotocycle motocycle = new MyConsoleMotocycle("Suzuki");

            motocycle.StartEngine();
            motocycle.Move(1000);
            motocycle.Move(5000);
            motocycle.StopEngine();
            motocycle = null;
            service = null;

            service = new MotocycleService();
            motocycle = new MyConsoleMotocycle("Suzuki");
            motocycle.StartEngine();
            motocycle.Move(6000);
            motocycle.StopEngine();
            motocycle = null;
            service = null;

            service = new MotocycleService();
            motocycle = new MyConsoleMotocycle("Suzuki");
        }
        static void GoToService(int distanceFromLastService)
        {
            Console.WriteLine($"Time to go moto service. Current" +
                $" distsnce from the last service is: {distanceFromLastService}");
        }
    }
}
