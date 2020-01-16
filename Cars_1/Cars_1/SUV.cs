using System;
using System.Collections.Generic;
using System.Text;

namespace Cars_1
{
    class SUV
    {
        private string mark;
        private string model;
        private double volume;
        protected SUV(string model, double volume)
        {
            this.model = model;
            this.volume = volume;
        }
        public void Toyota()
        {
            mark = "TOYOTA";
            Console.WriteLine($"mark: {mark}, model: {model}, volume: {volume}");
        }
        
        public void Aydi()
        {
            mark = "AUDI";
            Console.WriteLine($"mark: {mark}, model: {model}, volume: {volume}");
        }
        
    }
}
