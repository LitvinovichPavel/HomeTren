using System;
using System.Collections.Generic;
using System.Text;

namespace class_method_type_car_TREN
{
    class Sport
    {
        private string mark;
        private string model;
        private double volume;
        private int maxSpeed;
        private int mass;
        public void FerrariF12()
        {
            mark = "Ferrari";
            model = "F12";
            volume = 6.2;
            maxSpeed = 320;
            mass = 1520;
            Console.WriteLine($"{mark} {model} {volume} liters, max speed {maxSpeed} km/h, mass {mass} kg");
        }
    }
}
