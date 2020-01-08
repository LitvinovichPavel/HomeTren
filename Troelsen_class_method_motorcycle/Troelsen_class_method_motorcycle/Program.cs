using System;

namespace AssemblyTwoTREN
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle mc = new Motorcycle(5);
            mc.PopWheely();
            mc.SetDriveName("POL");
            Console.WriteLine($"Name: {mc.name}");
        }
    }
    class Motorcycle
    {
        public int driveIntensity;
        public string name;

        public Motorcycle(int intensity)
        {
            driveIntensity = intensity;
        }

        public void SetDriveName(string name)
        {
            this.name = name;
        }

        public void PopWheely()
        {
            for (int i = 0; i < driveIntensity; i++)
            {
                Console.WriteLine("MOTORCUCLE");
            }
        }
    }
}
