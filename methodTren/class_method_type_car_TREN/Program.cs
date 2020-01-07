using System;

namespace class_method_type_car_TREN
{
    class Program
    {
        static void Main(string[] args)
        {
            SUV toyotaSequoia = new SUV();
            toyotaSequoia.ToyotaSequoia();

            SUV caddilacEscalade = new SUV();
            caddilacEscalade.CadillacEscalade();

            SUV chevroletTahoe = new SUV();
            chevroletTahoe.ChevroletTahoe();

            Sport ferrari = new Sport();
            ferrari.FerrariF12();
        }
    }
}
