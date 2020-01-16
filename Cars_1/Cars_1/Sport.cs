using System;
using System.Collections.Generic;
using System.Text;

namespace Cars_1
{
    class Sport
    {
        public string mark;
        public string model;
        public double volume;
        public Sport(string mark, string model, double volume)
        {
            this.mark = mark;
            this.model = model;
            this.volume = volume;
        }
        public void BMWM6()
        {
        }
        public void FerrariF12()
        {
        }
        public void Info()
        {
            Console.WriteLine($"mark: {mark}, model: {model}, volume: {volume}");
        }
    }
}
