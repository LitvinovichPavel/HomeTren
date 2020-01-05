using System;
using System.Collections.Generic;
using System.Text;

namespace methodTren
{
    class CarSport
    {
        public int maxSpeed;
        public int mass;
        public string mark;
        public string model;
        public double volume;
        public CarSport()
        {
        }
        public CarSport(string strMark, string strModel, int intMax, int intMass, double doVolume)
        {
            mark = strMark;
            model = strModel;
            maxSpeed = intMax;
            mass = intMass;
            volume = doVolume;
        }
        public void Info()
        {
            Console.WriteLine($"Mark: {mark}, model: {model}, speed: {maxSpeed}, mass: {mass}, engine: {volume}");
        }
    }
}
