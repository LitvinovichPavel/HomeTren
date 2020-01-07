using System;
using System.Collections.Generic;
using System.Text;

namespace class_method_type_car_TREN
{
    class SUV
    {
        private string mark;
        private string model;
        private double volume;
        private int maxSpeed;
        private int mass;

        public void ToyotaSequoia()
        {
            mark = "Toyota";
            model = "Sequoia";
            volume = 5.7;
            maxSpeed = 180;
            mass = 3300;
            Console.WriteLine($"{mark} {model} {volume} liters, max speed {maxSpeed} km/h, mass {mass} kg");
        }
        public void CadillacEscalade()
        {
            mark = "Caddilac";
            model = "Escalade";
            volume = 6.2;
            maxSpeed = 170;
            mass = 3200;
            Console.WriteLine($"{mark} {model} {volume} liters, max speed {maxSpeed} km/h, mass {mass} kg");
        }
        public void ChevroletTahoe()
        {
            mark = "Chevrolet";
            model = "Tahoe";
            volume = 6.2;
            maxSpeed = 170;
            mass = 3200;
            Console.WriteLine($"{mark} {model} {volume} liters, max speed {maxSpeed} km/h, mass {mass} kg");
        }
    }
}
