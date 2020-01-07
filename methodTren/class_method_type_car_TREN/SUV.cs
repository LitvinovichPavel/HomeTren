using System;
using System.Collections.Generic;
using System.Text;

namespace class_method_type_car_TREN
{
    class SUV
    {
        public string mark;
        public string model;
        public double volume;
        public int maxSpeed;
        public int mass;

        public SUV()
        {
            this.mark = mark;
            this.model = model;
            this.volume = volume;
            this.maxSpeed = maxSpeed;
            this.mass = mass;
        }
        public void ToyotaSequoia()
        {
            mark = "Toyota";
            model = "Sequoia";
            volume = 5.7;
            maxSpeed = 180;
            mass = 3300;
            Console.WriteLine($"{mark} {model} {volume} liters, max speed {maxSpeed} km/h, mass {mass} kg");
        }
    }
}
